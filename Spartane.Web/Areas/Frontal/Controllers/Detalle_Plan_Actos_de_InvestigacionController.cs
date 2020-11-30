using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_Plan_Actos_de_Investigacion;
using Spartane.Core.Domain.Categoria_de_Servicio_de_Apoyo;
using Spartane.Core.Domain.Tipo_de_Servicio_de_Apoyo;
using Spartane.Core.Domain.Spartan_User;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_Plan_Actos_de_Investigacion;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Plan_Actos_de_Investigacion;
using Spartane.Web.Areas.WebApiConsumer.Categoria_de_Servicio_de_Apoyo;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Servicio_de_Apoyo;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;

using Spartane.Web.AuthFilters;
using Spartane.Web.Helpers;
using Spartane.Web.Models;
using Spartane.Web.SqlModelMapper;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Web.Mvc;
using System.IO;
using Newtonsoft.Json;
using Spartane.Core.Domain.Spartan_Business_Rule;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Business_Rule;
using Spartane.Web.Areas.WebApiConsumer.Spartan_BR_Process_Event_Detail;

namespace Spartane.Web.Areas.Frontal.Controllers
{
    [OutputCache(NoStore = true, Duration = 0, VaryByParam = "*")]
    public class Detalle_Plan_Actos_de_InvestigacionController : Controller
    {
        #region "variable declaration"

        private IDetalle_Plan_Actos_de_InvestigacionService service = null;
        private IDetalle_Plan_Actos_de_InvestigacionApiConsumer _IDetalle_Plan_Actos_de_InvestigacionApiConsumer;
        private ICategoria_de_Servicio_de_ApoyoApiConsumer _ICategoria_de_Servicio_de_ApoyoApiConsumer;
        private ITipo_de_Servicio_de_ApoyoApiConsumer _ITipo_de_Servicio_de_ApoyoApiConsumer;
        private ISpartan_UserApiConsumer _ISpartan_UserApiConsumer;

        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Detalle_Plan_Actos_de_InvestigacionController(IDetalle_Plan_Actos_de_InvestigacionService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_Plan_Actos_de_InvestigacionApiConsumer Detalle_Plan_Actos_de_InvestigacionApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer , ICategoria_de_Servicio_de_ApoyoApiConsumer Categoria_de_Servicio_de_ApoyoApiConsumer , ITipo_de_Servicio_de_ApoyoApiConsumer Tipo_de_Servicio_de_ApoyoApiConsumer , ISpartan_UserApiConsumer Spartan_UserApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_Plan_Actos_de_InvestigacionApiConsumer = Detalle_Plan_Actos_de_InvestigacionApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ICategoria_de_Servicio_de_ApoyoApiConsumer = Categoria_de_Servicio_de_ApoyoApiConsumer;
            this._ITipo_de_Servicio_de_ApoyoApiConsumer = Tipo_de_Servicio_de_ApoyoApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_Plan_Actos_de_Investigacion
        [ObjectAuth(ObjectId = (ModuleObjectId)45479, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45479);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/Detalle_Plan_Actos_de_Investigacion/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)45479, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45479);
            ViewBag.Permission = permission;
            var varDetalle_Plan_Actos_de_Investigacion = new Detalle_Plan_Actos_de_InvestigacionModel();
			
            ViewBag.ObjectId = "45479";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_Plan_Actos_de_InvestigacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_Plan_Actos_de_InvestigacionData = _IDetalle_Plan_Actos_de_InvestigacionApiConsumer.GetByKeyComplete(Id).Resource.Detalle_Plan_Actos_de_Investigacions[0];
                if (Detalle_Plan_Actos_de_InvestigacionData == null)
                    return HttpNotFound();

                varDetalle_Plan_Actos_de_Investigacion = new Detalle_Plan_Actos_de_InvestigacionModel
                {
                    Clave = (int)Detalle_Plan_Actos_de_InvestigacionData.Clave
                    ,Categoria = Detalle_Plan_Actos_de_InvestigacionData.Categoria
                    ,CategoriaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Plan_Actos_de_InvestigacionData.Categoria), "Categoria_de_Servicio_de_Apoyo") ??  (string)Detalle_Plan_Actos_de_InvestigacionData.Categoria_Categoria_de_Servicio_de_Apoyo.Descripcion
                    ,Servicio_a_Solicitar = Detalle_Plan_Actos_de_InvestigacionData.Servicio_a_Solicitar
                    ,Servicio_a_SolicitarServicio = CultureHelper.GetTraduction(Convert.ToString(Detalle_Plan_Actos_de_InvestigacionData.Servicio_a_Solicitar), "Tipo_de_Servicio_de_Apoyo") ??  (string)Detalle_Plan_Actos_de_InvestigacionData.Servicio_a_Solicitar_Tipo_de_Servicio_de_Apoyo.Servicio
                    ,Hecho_Delictivo_Acreditado = Detalle_Plan_Actos_de_InvestigacionData.Hecho_Delictivo_Acreditado
                    ,Tiempo_Estandar = Detalle_Plan_Actos_de_InvestigacionData.Tiempo_Estandar
                    ,Ponderacion = Detalle_Plan_Actos_de_InvestigacionData.Ponderacion
                    ,Fecha_Contestacion = (Detalle_Plan_Actos_de_InvestigacionData.Fecha_Contestacion == null ? string.Empty : Convert.ToDateTime(Detalle_Plan_Actos_de_InvestigacionData.Fecha_Contestacion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_Contestacion = Detalle_Plan_Actos_de_InvestigacionData.Hora_Contestacion
                    ,Contestacion = Detalle_Plan_Actos_de_InvestigacionData.Contestacion
                    ,Archivo_Adjunto = Detalle_Plan_Actos_de_InvestigacionData.Archivo_Adjunto
                    ,Usuario_que_Contesta = Detalle_Plan_Actos_de_InvestigacionData.Usuario_que_Contesta
                    ,Usuario_que_ContestaName = CultureHelper.GetTraduction(Convert.ToString(Detalle_Plan_Actos_de_InvestigacionData.Usuario_que_Contesta), "Spartan_User") ??  (string)Detalle_Plan_Actos_de_InvestigacionData.Usuario_que_Contesta_Spartan_User.Name

                };
                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.Archivo_AdjuntoSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varDetalle_Plan_Actos_de_Investigacion.Archivo_Adjunto).Resource;

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ICategoria_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Categoria_de_Servicio_de_Apoyos_Categoria = _ICategoria_de_Servicio_de_ApoyoApiConsumer.SelAll(true);
            if (Categoria_de_Servicio_de_Apoyos_Categoria != null && Categoria_de_Servicio_de_Apoyos_Categoria.Resource != null)
                ViewBag.Categoria_de_Servicio_de_Apoyos_Categoria = Categoria_de_Servicio_de_Apoyos_Categoria.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Categoria_de_Servicio_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Servicio_de_Apoyos_Servicio_a_Solicitar = _ITipo_de_Servicio_de_ApoyoApiConsumer.SelAll(true);
            if (Tipo_de_Servicio_de_Apoyos_Servicio_a_Solicitar != null && Tipo_de_Servicio_de_Apoyos_Servicio_a_Solicitar.Resource != null)
                ViewBag.Tipo_de_Servicio_de_Apoyos_Servicio_a_Solicitar = Tipo_de_Servicio_de_Apoyos_Servicio_a_Solicitar.Resource.Where(m => m.Servicio != null).OrderBy(m => m.Servicio).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Servicio_de_Apoyo", "Servicio") ?? m.Servicio.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(varDetalle_Plan_Actos_de_Investigacion);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_Plan_Actos_de_Investigacion(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45479);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_Plan_Actos_de_InvestigacionApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_Plan_Actos_de_InvestigacionModel varDetalle_Plan_Actos_de_Investigacion= new Detalle_Plan_Actos_de_InvestigacionModel();


            if (id.ToString() != "0")
            {
                var Detalle_Plan_Actos_de_InvestigacionsData = _IDetalle_Plan_Actos_de_InvestigacionApiConsumer.ListaSelAll(0, 1000, "Detalle_Plan_Actos_de_Investigacion.Clave=" + id, "").Resource.Detalle_Plan_Actos_de_Investigacions;
				
				if (Detalle_Plan_Actos_de_InvestigacionsData != null && Detalle_Plan_Actos_de_InvestigacionsData.Count > 0)
                {
					var Detalle_Plan_Actos_de_InvestigacionData = Detalle_Plan_Actos_de_InvestigacionsData.First();
					varDetalle_Plan_Actos_de_Investigacion= new Detalle_Plan_Actos_de_InvestigacionModel
					{
						Clave  = Detalle_Plan_Actos_de_InvestigacionData.Clave 
	                    ,Categoria = Detalle_Plan_Actos_de_InvestigacionData.Categoria
                    ,CategoriaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Plan_Actos_de_InvestigacionData.Categoria), "Categoria_de_Servicio_de_Apoyo") ??  (string)Detalle_Plan_Actos_de_InvestigacionData.Categoria_Categoria_de_Servicio_de_Apoyo.Descripcion
                    ,Servicio_a_Solicitar = Detalle_Plan_Actos_de_InvestigacionData.Servicio_a_Solicitar
                    ,Servicio_a_SolicitarServicio = CultureHelper.GetTraduction(Convert.ToString(Detalle_Plan_Actos_de_InvestigacionData.Servicio_a_Solicitar), "Tipo_de_Servicio_de_Apoyo") ??  (string)Detalle_Plan_Actos_de_InvestigacionData.Servicio_a_Solicitar_Tipo_de_Servicio_de_Apoyo.Servicio
                    ,Hecho_Delictivo_Acreditado = Detalle_Plan_Actos_de_InvestigacionData.Hecho_Delictivo_Acreditado
                    ,Tiempo_Estandar = Detalle_Plan_Actos_de_InvestigacionData.Tiempo_Estandar
                    ,Ponderacion = Detalle_Plan_Actos_de_InvestigacionData.Ponderacion
                    ,Fecha_Contestacion = (Detalle_Plan_Actos_de_InvestigacionData.Fecha_Contestacion == null ? string.Empty : Convert.ToDateTime(Detalle_Plan_Actos_de_InvestigacionData.Fecha_Contestacion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_Contestacion = Detalle_Plan_Actos_de_InvestigacionData.Hora_Contestacion
                    ,Contestacion = Detalle_Plan_Actos_de_InvestigacionData.Contestacion
                    ,Archivo_Adjunto = Detalle_Plan_Actos_de_InvestigacionData.Archivo_Adjunto
                    ,Usuario_que_Contesta = Detalle_Plan_Actos_de_InvestigacionData.Usuario_que_Contesta
                    ,Usuario_que_ContestaName = CultureHelper.GetTraduction(Convert.ToString(Detalle_Plan_Actos_de_InvestigacionData.Usuario_que_Contesta), "Spartan_User") ??  (string)Detalle_Plan_Actos_de_InvestigacionData.Usuario_que_Contesta_Spartan_User.Name

					};
				}
                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.Archivo_AdjuntoSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varDetalle_Plan_Actos_de_Investigacion.Archivo_Adjunto).Resource;

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ICategoria_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Categoria_de_Servicio_de_Apoyos_Categoria = _ICategoria_de_Servicio_de_ApoyoApiConsumer.SelAll(true);
            if (Categoria_de_Servicio_de_Apoyos_Categoria != null && Categoria_de_Servicio_de_Apoyos_Categoria.Resource != null)
                ViewBag.Categoria_de_Servicio_de_Apoyos_Categoria = Categoria_de_Servicio_de_Apoyos_Categoria.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Categoria_de_Servicio_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Servicio_de_Apoyos_Servicio_a_Solicitar = _ITipo_de_Servicio_de_ApoyoApiConsumer.SelAll(true);
            if (Tipo_de_Servicio_de_Apoyos_Servicio_a_Solicitar != null && Tipo_de_Servicio_de_Apoyos_Servicio_a_Solicitar.Resource != null)
                ViewBag.Tipo_de_Servicio_de_Apoyos_Servicio_a_Solicitar = Tipo_de_Servicio_de_Apoyos_Servicio_a_Solicitar.Resource.Where(m => m.Servicio != null).OrderBy(m => m.Servicio).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Servicio_de_Apoyo", "Servicio") ?? m.Servicio.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddDetalle_Plan_Actos_de_Investigacion", varDetalle_Plan_Actos_de_Investigacion);
        }


        [HttpGet]
        public FileResult GetFile(int id)
        {

            if (!_tokenManager.GenerateToken())
                return null;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var fileInfo = _ISpartane_FileApiConsumer.GetByKey(id).Resource;
            if (fileInfo == null)
                return null;
            return File(fileInfo.File, System.Net.Mime.MediaTypeNames.Application.Octet, fileInfo.Description);
        }

        [HttpGet]
        public ActionResult GetCategoria_de_Servicio_de_ApoyoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICategoria_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICategoria_de_Servicio_de_ApoyoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Categoria_de_Servicio_de_Apoyo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetTipo_de_Servicio_de_ApoyoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_Servicio_de_ApoyoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Servicio).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Servicio_de_Apoyo", "Servicio")?? m.Servicio,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
		[HttpGet]
        public ActionResult GetSpartan_UserAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISpartan_UserApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name")?? m.Name,
                    Value = Convert.ToString(m.Id_User)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }



        public ActionResult Get()
        {
            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Plan_Actos_de_InvestigacionPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_Plan_Actos_de_InvestigacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Plan_Actos_de_Investigacions == null)
                result.Detalle_Plan_Actos_de_Investigacions = new List<Detalle_Plan_Actos_de_Investigacion>();

            return Json(new
            {
                data = result.Detalle_Plan_Actos_de_Investigacions.Select(m => new Detalle_Plan_Actos_de_InvestigacionGridModel
                    {
                    Clave = m.Clave
                        ,CategoriaDescripcion = CultureHelper.GetTraduction(m.Categoria_Categoria_de_Servicio_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.Categoria_Categoria_de_Servicio_de_Apoyo.Descripcion
                        ,Servicio_a_SolicitarServicio = CultureHelper.GetTraduction(m.Servicio_a_Solicitar_Tipo_de_Servicio_de_Apoyo.Clave.ToString(), "Servicio") ?? (string)m.Servicio_a_Solicitar_Tipo_de_Servicio_de_Apoyo.Servicio
			,Hecho_Delictivo_Acreditado = m.Hecho_Delictivo_Acreditado
			,Tiempo_Estandar = m.Tiempo_Estandar
			,Ponderacion = m.Ponderacion
                        ,Fecha_Contestacion = (m.Fecha_Contestacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_Contestacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_Contestacion = m.Hora_Contestacion
			,Contestacion = m.Contestacion
			,Archivo_Adjunto = m.Archivo_Adjunto
                        ,Usuario_que_ContestaName = CultureHelper.GetTraduction(m.Usuario_que_Contesta_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Contesta_Spartan_User.Name

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetDetalle_Plan_Actos_de_Investigacion_Usuario_que_Contesta_Spartan_User(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Spartan_User.Id_User as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Spartan_User.Name as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _ISpartan_UserApiConsumer.ListaSelAll(1, 20,elWhere , " Spartan_User.Name ASC ").Resource;
               
                foreach (var item in result.Spartan_Users)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Id_User), "Spartan_User", "Name");
                    item.Name =trans ??item.Name;
                }
                return Json(result.Spartan_Users.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }





       

        [NonAction]
        public Grid_File ConvertSpartane_FileToGridFile(Spartane.Core.Domain.Spartane_File.Spartane_File file)
        {
            return file == null ? new Grid_File { FileId = 0, FileSize = 0, FileName = "" } : new Grid_File { FileId = file.File_Id, FileName = file.Description, FileSize = file.File_Size ?? 0, };
        }



        [HttpDelete]
        public ActionResult Delete(int id)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_Plan_Actos_de_InvestigacionApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_Plan_Actos_de_Investigacion varDetalle_Plan_Actos_de_Investigacion = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IDetalle_Plan_Actos_de_InvestigacionApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_Plan_Actos_de_InvestigacionModel varDetalle_Plan_Actos_de_Investigacion)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_Plan_Actos_de_InvestigacionApiConsumer.SetAuthHeader(_tokenManager.Token);


                    if (varDetalle_Plan_Actos_de_Investigacion.Archivo_AdjuntoRemoveAttachment != 0 && varDetalle_Plan_Actos_de_Investigacion.Archivo_AdjuntoFile == null)
                    {
                        varDetalle_Plan_Actos_de_Investigacion.Archivo_Adjunto = 0;
                    }

                    if (varDetalle_Plan_Actos_de_Investigacion.Archivo_AdjuntoFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varDetalle_Plan_Actos_de_Investigacion.Archivo_AdjuntoFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varDetalle_Plan_Actos_de_Investigacion.Archivo_Adjunto = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varDetalle_Plan_Actos_de_Investigacion.Archivo_AdjuntoFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }

                    
                    var result = "";
                    var Detalle_Plan_Actos_de_InvestigacionInfo = new Detalle_Plan_Actos_de_Investigacion
                    {
                        Clave = varDetalle_Plan_Actos_de_Investigacion.Clave
                        ,Categoria = varDetalle_Plan_Actos_de_Investigacion.Categoria
                        ,Servicio_a_Solicitar = varDetalle_Plan_Actos_de_Investigacion.Servicio_a_Solicitar
                        ,Hecho_Delictivo_Acreditado = varDetalle_Plan_Actos_de_Investigacion.Hecho_Delictivo_Acreditado
                        ,Tiempo_Estandar = varDetalle_Plan_Actos_de_Investigacion.Tiempo_Estandar
                        ,Ponderacion = varDetalle_Plan_Actos_de_Investigacion.Ponderacion
                        ,Fecha_Contestacion = (!String.IsNullOrEmpty(varDetalle_Plan_Actos_de_Investigacion.Fecha_Contestacion)) ? DateTime.ParseExact(varDetalle_Plan_Actos_de_Investigacion.Fecha_Contestacion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_Contestacion = varDetalle_Plan_Actos_de_Investigacion.Hora_Contestacion
                        ,Contestacion = varDetalle_Plan_Actos_de_Investigacion.Contestacion
                        ,Archivo_Adjunto = (varDetalle_Plan_Actos_de_Investigacion.Archivo_Adjunto.HasValue && varDetalle_Plan_Actos_de_Investigacion.Archivo_Adjunto != 0) ? ((int?)Convert.ToInt32(varDetalle_Plan_Actos_de_Investigacion.Archivo_Adjunto.Value)) : null

                        ,Usuario_que_Contesta = varDetalle_Plan_Actos_de_Investigacion.Usuario_que_Contesta

                    };

                    result = !IsNew ?
                        _IDetalle_Plan_Actos_de_InvestigacionApiConsumer.Update(Detalle_Plan_Actos_de_InvestigacionInfo, null, null).Resource.ToString() :
                         _IDetalle_Plan_Actos_de_InvestigacionApiConsumer.Insert(Detalle_Plan_Actos_de_InvestigacionInfo, null, null).Resource.ToString();

                    return Json(result, JsonRequestBehavior.AllowGet);
				}
				return Json(false, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }



        /// <summary>
        /// Write Element Array of Detalle_Plan_Actos_de_Investigacion script
        /// </summary>
        /// <param name="oDetalle_Plan_Actos_de_InvestigacionElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements Detalle_Plan_Actos_de_InvestigacionModuleAttributeList)
        {
            for (int i = 0; i < Detalle_Plan_Actos_de_InvestigacionModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_Plan_Actos_de_InvestigacionModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_Plan_Actos_de_InvestigacionModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_Plan_Actos_de_InvestigacionModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_Plan_Actos_de_InvestigacionModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_Plan_Actos_de_InvestigacionModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_Plan_Actos_de_InvestigacionModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(Detalle_Plan_Actos_de_InvestigacionModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						Detalle_Plan_Actos_de_InvestigacionModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(Detalle_Plan_Actos_de_InvestigacionModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						Detalle_Plan_Actos_de_InvestigacionModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strDetalle_Plan_Actos_de_InvestigacionScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_Plan_Actos_de_Investigacion.js")))
            {
                strDetalle_Plan_Actos_de_InvestigacionScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_Plan_Actos_de_Investigacion element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_Plan_Actos_de_InvestigacionModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_Plan_Actos_de_InvestigacionScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_Plan_Actos_de_InvestigacionScript.Substring(indexOfArray, strDetalle_Plan_Actos_de_InvestigacionScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_Plan_Actos_de_InvestigacionModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_Plan_Actos_de_InvestigacionModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_Plan_Actos_de_InvestigacionScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strDetalle_Plan_Actos_de_InvestigacionScript.Substring(indexOfArrayHistory, strDetalle_Plan_Actos_de_InvestigacionScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strDetalle_Plan_Actos_de_InvestigacionScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_Plan_Actos_de_InvestigacionScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_Plan_Actos_de_InvestigacionScript.Length - (endIndexOfMainElement + indexOfArray));
            if (Detalle_Plan_Actos_de_InvestigacionModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strDetalle_Plan_Actos_de_InvestigacionScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strDetalle_Plan_Actos_de_InvestigacionScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strDetalle_Plan_Actos_de_InvestigacionScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strDetalle_Plan_Actos_de_InvestigacionScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_Plan_Actos_de_Investigacion.js")))
            {
                w.WriteLine(finalResponse);
            }
            
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        

        [HttpPost]
        public JsonResult ReadScriptSettings()
        {
            string strCustomScript = string.Empty;
            
            CustomElementAttribute oCustomElementAttribute = new CustomElementAttribute();

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_Plan_Actos_de_Investigacion.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_Plan_Actos_de_Investigacion.js")))
                {
                    strCustomScript = r.ReadToEnd();
                
                }

                int indexOfArray = strCustomScript.IndexOf("inpuElementArray");
                string splittedString = strCustomScript.Substring(indexOfArray, strCustomScript.Length - indexOfArray);                
                int indexOfMainElement = splittedString.IndexOf('[');                
                int endIndexOfMainElement = splittedString.IndexOf(']') + 1;                
                string mainJsonArray = splittedString.Substring(indexOfMainElement, endIndexOfMainElement - indexOfMainElement);

                int indexOfChildArray = strCustomScript.IndexOf("inpuElementChildArray");
				string childJsonArray = "";
                if (indexOfChildArray != -1)
                {
					string splittedChildString = strCustomScript.Substring(indexOfChildArray, strCustomScript.Length - indexOfChildArray);
					int indexOfChildElement = splittedChildString.IndexOf('[');
					int endIndexOfChildElement = splittedChildString.IndexOf(']') + 1;
					childJsonArray = splittedChildString.Substring(indexOfChildElement, endIndexOfChildElement - indexOfChildElement);
				}
                var MainElementList = JsonConvert.DeserializeObject(mainJsonArray);
                var ChildElementList = JsonConvert.DeserializeObject(childJsonArray);

                oCustomElementAttribute.MainElement = MainElementList.ToString();
				if (indexOfChildArray != -1)
                {
					oCustomElementAttribute.ChildElement = ChildElementList.ToString();
				}
            }
            else
            {
                oCustomElementAttribute.MainElement = string.Empty;
                oCustomElementAttribute.ChildElement = string.Empty;
            }        
            return Json(oCustomElementAttribute, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Detalle_Plan_Actos_de_InvestigacionPropertyBag()
        {
            return PartialView("Detalle_Plan_Actos_de_InvestigacionPropertyBag", "Detalle_Plan_Actos_de_Investigacion");
        }
		
		public List<Spartan_Business_Rule> GetBusinessRules(int ObjectId, int Attribute)
        {
            if (!_tokenManager.GenerateToken())
                return null;
            List<Spartan_Business_Rule> result = new List<Spartan_Business_Rule>();
            _ISpartan_Business_RuleApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (Attribute != 0)
            {
                result = _ISpartan_Business_RuleApiConsumer.ListaSelAll(0, 1000, "Object = " + ObjectId + " AND Attribute = " + Attribute, "").Resource.Spartan_Business_Rules;
            }
            else
            {
                List<Spartan_Business_Rule> partialResult = _ISpartan_Business_RuleApiConsumer.ListaSelAll(0, 1000, "Object = " + ObjectId, "").Resource.Spartan_Business_Rules;
                foreach (var item in partialResult)
                {
                    if (item.Attribute == Attribute)
                    {
                        result.Add(item);
                    }
                    else//Busco las reglas con el event process en cuestion
                    {
                        _ISpartan_BR_Process_Event_DetailApiConsumer.SetAuthHeader(_tokenManager.Token);
                        var eventProcess = _ISpartan_BR_Process_Event_DetailApiConsumer.ListaSelAll(0, 1000, "Business_Rule = " + item.BusinessRuleId, "").Resource;
                        if (Attribute == 0 && eventProcess.Spartan_BR_Process_Event_Details.Where(x => x.Process_Event == 1).Count() > 0)
                        {
                            result.Add(item);
                        }
                        if ((Attribute == 2) && eventProcess.Spartan_BR_Process_Event_Details.Where(x => x.Process_Event == 2 || x.Process_Event == 3).Count() > 0)
                        {
                            result.Add(item);
                        }
                        if ((Attribute == 3) && eventProcess.Spartan_BR_Process_Event_Details.Where(x => x.Process_Event == 4 || x.Process_Event == 5).Count() > 0)
                        {
                            result.Add(item);
                        }
                        //TODO Faltan en la base de datos cuando creas una row de grilla
                    }
                }
            }
            return result;
        }



        #endregion "Controller Methods"

        #region "Custom methods"

        [HttpGet]
        public void Export(string format, int pageIndex, int pageSize)
        {
            var exportFormatType = (ExportFormatType)Enum.Parse(
                                          typeof(ExportFormatType), format, true);

            if (!_tokenManager.GenerateToken())
                return;

            _IDetalle_Plan_Actos_de_InvestigacionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Plan_Actos_de_InvestigacionPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_Plan_Actos_de_InvestigacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Plan_Actos_de_Investigacions == null)
                result.Detalle_Plan_Actos_de_Investigacions = new List<Detalle_Plan_Actos_de_Investigacion>();

            var data = result.Detalle_Plan_Actos_de_Investigacions.Select(m => new Detalle_Plan_Actos_de_InvestigacionGridModel
            {
                Clave = m.Clave
                ,CategoriaDescripcion = (string)m.Categoria_Categoria_de_Servicio_de_Apoyo.Descripcion
                ,Servicio_a_SolicitarServicio = (string)m.Servicio_a_Solicitar_Tipo_de_Servicio_de_Apoyo.Servicio
                ,Hecho_Delictivo_Acreditado = m.Hecho_Delictivo_Acreditado
                ,Tiempo_Estandar = m.Tiempo_Estandar
                ,Ponderacion = m.Ponderacion
                ,Fecha_Contestacion = (m.Fecha_Contestacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_Contestacion).ToString(ConfigurationProperty.DateFormat))
                ,Hora_Contestacion = m.Hora_Contestacion
                ,Contestacion = m.Contestacion
                ,Usuario_que_ContestaName = (string)m.Usuario_que_Contesta_Spartan_User.Name

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "Detalle_Plan_Actos_de_InvestigacionList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "Detalle_Plan_Actos_de_InvestigacionList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(), "EmployeeList_" + DateTime.Now.ToString());
                    break;
            }
        }

        [HttpGet]
        //[ObjectAuth(ObjectId = ModuleObjectId.EMPLEADOS_OBJECT, PermissionType = PermissionTypes.Export)]
        public ActionResult Print(string format, int pageIndex, int pageSize)
        {
            var exportFormatType = (ExportFormatType)Enum.Parse(
                                          typeof(ExportFormatType), format, true);

            if (!_tokenManager.GenerateToken())
                return null;

            _IDetalle_Plan_Actos_de_InvestigacionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Plan_Actos_de_InvestigacionPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_Plan_Actos_de_InvestigacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Plan_Actos_de_Investigacions == null)
                result.Detalle_Plan_Actos_de_Investigacions = new List<Detalle_Plan_Actos_de_Investigacion>();

            var data = result.Detalle_Plan_Actos_de_Investigacions.Select(m => new Detalle_Plan_Actos_de_InvestigacionGridModel
            {
                Clave = m.Clave
                ,CategoriaDescripcion = (string)m.Categoria_Categoria_de_Servicio_de_Apoyo.Descripcion
                ,Servicio_a_SolicitarServicio = (string)m.Servicio_a_Solicitar_Tipo_de_Servicio_de_Apoyo.Servicio
                ,Hecho_Delictivo_Acreditado = m.Hecho_Delictivo_Acreditado
                ,Tiempo_Estandar = m.Tiempo_Estandar
                ,Ponderacion = m.Ponderacion
                ,Fecha_Contestacion = (m.Fecha_Contestacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_Contestacion).ToString(ConfigurationProperty.DateFormat))
                ,Hora_Contestacion = m.Hora_Contestacion
                ,Contestacion = m.Contestacion
                ,Usuario_que_ContestaName = (string)m.Usuario_que_Contesta_Spartan_User.Name

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
