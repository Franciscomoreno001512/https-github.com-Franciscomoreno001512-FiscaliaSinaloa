using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_Aseguramiento_Objetos_Asegurados;
using Spartane.Core.Domain.Motivo_de_Registro;
using Spartane.Core.Domain.Tipo_de_Equipo_de_Comunicacion;
using Spartane.Core.Domain.Marca_de_Equipo_de_Comunicacion;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_Aseguramiento_Objetos_Asegurados;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Aseguramiento_Objetos_Asegurados;
using Spartane.Web.Areas.WebApiConsumer.Motivo_de_Registro;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Equipo_de_Comunicacion;
using Spartane.Web.Areas.WebApiConsumer.Marca_de_Equipo_de_Comunicacion;

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
    public class Detalle_Aseguramiento_Objetos_AseguradosController : Controller
    {
        #region "variable declaration"

        private IDetalle_Aseguramiento_Objetos_AseguradosService service = null;
        private IDetalle_Aseguramiento_Objetos_AseguradosApiConsumer _IDetalle_Aseguramiento_Objetos_AseguradosApiConsumer;
        private IMotivo_de_RegistroApiConsumer _IMotivo_de_RegistroApiConsumer;
        private ITipo_de_Equipo_de_ComunicacionApiConsumer _ITipo_de_Equipo_de_ComunicacionApiConsumer;
        private IMarca_de_Equipo_de_ComunicacionApiConsumer _IMarca_de_Equipo_de_ComunicacionApiConsumer;

        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Detalle_Aseguramiento_Objetos_AseguradosController(IDetalle_Aseguramiento_Objetos_AseguradosService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_Aseguramiento_Objetos_AseguradosApiConsumer Detalle_Aseguramiento_Objetos_AseguradosApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer , IMotivo_de_RegistroApiConsumer Motivo_de_RegistroApiConsumer , ITipo_de_Equipo_de_ComunicacionApiConsumer Tipo_de_Equipo_de_ComunicacionApiConsumer , IMarca_de_Equipo_de_ComunicacionApiConsumer Marca_de_Equipo_de_ComunicacionApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_Aseguramiento_Objetos_AseguradosApiConsumer = Detalle_Aseguramiento_Objetos_AseguradosApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._IMotivo_de_RegistroApiConsumer = Motivo_de_RegistroApiConsumer;
            this._ITipo_de_Equipo_de_ComunicacionApiConsumer = Tipo_de_Equipo_de_ComunicacionApiConsumer;
            this._IMarca_de_Equipo_de_ComunicacionApiConsumer = Marca_de_Equipo_de_ComunicacionApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_Aseguramiento_Objetos_Asegurados
        [ObjectAuth(ObjectId = (ModuleObjectId)45530, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45530);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/Detalle_Aseguramiento_Objetos_Asegurados/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)45530, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45530);
            ViewBag.Permission = permission;
            var varDetalle_Aseguramiento_Objetos_Asegurados = new Detalle_Aseguramiento_Objetos_AseguradosModel();
			
            ViewBag.ObjectId = "45530";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_Aseguramiento_Objetos_AseguradosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_Aseguramiento_Objetos_AseguradosData = _IDetalle_Aseguramiento_Objetos_AseguradosApiConsumer.GetByKeyComplete(Id).Resource.Detalle_Aseguramiento_Objetos_Aseguradoss[0];
                if (Detalle_Aseguramiento_Objetos_AseguradosData == null)
                    return HttpNotFound();

                varDetalle_Aseguramiento_Objetos_Asegurados = new Detalle_Aseguramiento_Objetos_AseguradosModel
                {
                    Clave = (int)Detalle_Aseguramiento_Objetos_AseguradosData.Clave
                    ,Motivo_de_Registro = Detalle_Aseguramiento_Objetos_AseguradosData.Motivo_de_Registro
                    ,Motivo_de_RegistroDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Aseguramiento_Objetos_AseguradosData.Motivo_de_Registro), "Motivo_de_Registro") ??  (string)Detalle_Aseguramiento_Objetos_AseguradosData.Motivo_de_Registro_Motivo_de_Registro.Descripcion
                    ,Numero = Detalle_Aseguramiento_Objetos_AseguradosData.Numero
                    ,Tipo = Detalle_Aseguramiento_Objetos_AseguradosData.Tipo
                    ,TipoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Aseguramiento_Objetos_AseguradosData.Tipo), "Tipo_de_Equipo_de_Comunicacion") ??  (string)Detalle_Aseguramiento_Objetos_AseguradosData.Tipo_Tipo_de_Equipo_de_Comunicacion.Descripcion
                    ,Marca = Detalle_Aseguramiento_Objetos_AseguradosData.Marca
                    ,MarcaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Aseguramiento_Objetos_AseguradosData.Marca), "Marca_de_Equipo_de_Comunicacion") ??  (string)Detalle_Aseguramiento_Objetos_AseguradosData.Marca_Marca_de_Equipo_de_Comunicacion.Descripcion
                    ,Serie = Detalle_Aseguramiento_Objetos_AseguradosData.Serie
                    ,IMEI = Detalle_Aseguramiento_Objetos_AseguradosData.IMEI

                };

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IMotivo_de_RegistroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Motivo_de_Registros_Motivo_de_Registro = _IMotivo_de_RegistroApiConsumer.SelAll(true);
            if (Motivo_de_Registros_Motivo_de_Registro != null && Motivo_de_Registros_Motivo_de_Registro.Resource != null)
                ViewBag.Motivo_de_Registros_Motivo_de_Registro = Motivo_de_Registros_Motivo_de_Registro.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Motivo_de_Registro", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_Equipo_de_ComunicacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Equipo_de_Comunicacions_Tipo = _ITipo_de_Equipo_de_ComunicacionApiConsumer.SelAll(true);
            if (Tipo_de_Equipo_de_Comunicacions_Tipo != null && Tipo_de_Equipo_de_Comunicacions_Tipo.Resource != null)
                ViewBag.Tipo_de_Equipo_de_Comunicacions_Tipo = Tipo_de_Equipo_de_Comunicacions_Tipo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Equipo_de_Comunicacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMarca_de_Equipo_de_ComunicacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Marca_de_Equipo_de_Comunicacions_Marca = _IMarca_de_Equipo_de_ComunicacionApiConsumer.SelAll(true);
            if (Marca_de_Equipo_de_Comunicacions_Marca != null && Marca_de_Equipo_de_Comunicacions_Marca.Resource != null)
                ViewBag.Marca_de_Equipo_de_Comunicacions_Marca = Marca_de_Equipo_de_Comunicacions_Marca.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Marca_de_Equipo_de_Comunicacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(varDetalle_Aseguramiento_Objetos_Asegurados);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_Aseguramiento_Objetos_Asegurados(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45530);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_Aseguramiento_Objetos_AseguradosApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_Aseguramiento_Objetos_AseguradosModel varDetalle_Aseguramiento_Objetos_Asegurados= new Detalle_Aseguramiento_Objetos_AseguradosModel();


            if (id.ToString() != "0")
            {
                var Detalle_Aseguramiento_Objetos_AseguradossData = _IDetalle_Aseguramiento_Objetos_AseguradosApiConsumer.ListaSelAll(0, 1000, "Detalle_Aseguramiento_Objetos_Asegurados.Clave=" + id, "").Resource.Detalle_Aseguramiento_Objetos_Aseguradoss;
				
				if (Detalle_Aseguramiento_Objetos_AseguradossData != null && Detalle_Aseguramiento_Objetos_AseguradossData.Count > 0)
                {
					var Detalle_Aseguramiento_Objetos_AseguradosData = Detalle_Aseguramiento_Objetos_AseguradossData.First();
					varDetalle_Aseguramiento_Objetos_Asegurados= new Detalle_Aseguramiento_Objetos_AseguradosModel
					{
						Clave  = Detalle_Aseguramiento_Objetos_AseguradosData.Clave 
	                    ,Motivo_de_Registro = Detalle_Aseguramiento_Objetos_AseguradosData.Motivo_de_Registro
                    ,Motivo_de_RegistroDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Aseguramiento_Objetos_AseguradosData.Motivo_de_Registro), "Motivo_de_Registro") ??  (string)Detalle_Aseguramiento_Objetos_AseguradosData.Motivo_de_Registro_Motivo_de_Registro.Descripcion
                    ,Numero = Detalle_Aseguramiento_Objetos_AseguradosData.Numero
                    ,Tipo = Detalle_Aseguramiento_Objetos_AseguradosData.Tipo
                    ,TipoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Aseguramiento_Objetos_AseguradosData.Tipo), "Tipo_de_Equipo_de_Comunicacion") ??  (string)Detalle_Aseguramiento_Objetos_AseguradosData.Tipo_Tipo_de_Equipo_de_Comunicacion.Descripcion
                    ,Marca = Detalle_Aseguramiento_Objetos_AseguradosData.Marca
                    ,MarcaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Aseguramiento_Objetos_AseguradosData.Marca), "Marca_de_Equipo_de_Comunicacion") ??  (string)Detalle_Aseguramiento_Objetos_AseguradosData.Marca_Marca_de_Equipo_de_Comunicacion.Descripcion
                    ,Serie = Detalle_Aseguramiento_Objetos_AseguradosData.Serie
                    ,IMEI = Detalle_Aseguramiento_Objetos_AseguradosData.IMEI

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IMotivo_de_RegistroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Motivo_de_Registros_Motivo_de_Registro = _IMotivo_de_RegistroApiConsumer.SelAll(true);
            if (Motivo_de_Registros_Motivo_de_Registro != null && Motivo_de_Registros_Motivo_de_Registro.Resource != null)
                ViewBag.Motivo_de_Registros_Motivo_de_Registro = Motivo_de_Registros_Motivo_de_Registro.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Motivo_de_Registro", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_Equipo_de_ComunicacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Equipo_de_Comunicacions_Tipo = _ITipo_de_Equipo_de_ComunicacionApiConsumer.SelAll(true);
            if (Tipo_de_Equipo_de_Comunicacions_Tipo != null && Tipo_de_Equipo_de_Comunicacions_Tipo.Resource != null)
                ViewBag.Tipo_de_Equipo_de_Comunicacions_Tipo = Tipo_de_Equipo_de_Comunicacions_Tipo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Equipo_de_Comunicacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMarca_de_Equipo_de_ComunicacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Marca_de_Equipo_de_Comunicacions_Marca = _IMarca_de_Equipo_de_ComunicacionApiConsumer.SelAll(true);
            if (Marca_de_Equipo_de_Comunicacions_Marca != null && Marca_de_Equipo_de_Comunicacions_Marca.Resource != null)
                ViewBag.Marca_de_Equipo_de_Comunicacions_Marca = Marca_de_Equipo_de_Comunicacions_Marca.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Marca_de_Equipo_de_Comunicacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddDetalle_Aseguramiento_Objetos_Asegurados", varDetalle_Aseguramiento_Objetos_Asegurados);
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
        public ActionResult GetMotivo_de_RegistroAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMotivo_de_RegistroApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IMotivo_de_RegistroApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Motivo_de_Registro", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetTipo_de_Equipo_de_ComunicacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_Equipo_de_ComunicacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_Equipo_de_ComunicacionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Equipo_de_Comunicacion", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetMarca_de_Equipo_de_ComunicacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMarca_de_Equipo_de_ComunicacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IMarca_de_Equipo_de_ComunicacionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Marca_de_Equipo_de_Comunicacion", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Aseguramiento_Objetos_AseguradosPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_Aseguramiento_Objetos_AseguradosApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Aseguramiento_Objetos_Aseguradoss == null)
                result.Detalle_Aseguramiento_Objetos_Aseguradoss = new List<Detalle_Aseguramiento_Objetos_Asegurados>();

            return Json(new
            {
                data = result.Detalle_Aseguramiento_Objetos_Aseguradoss.Select(m => new Detalle_Aseguramiento_Objetos_AseguradosGridModel
                    {
                    Clave = m.Clave
                        ,Motivo_de_RegistroDescripcion = CultureHelper.GetTraduction(m.Motivo_de_Registro_Motivo_de_Registro.Clave.ToString(), "Descripcion") ?? (string)m.Motivo_de_Registro_Motivo_de_Registro.Descripcion
			,Numero = m.Numero
                        ,TipoDescripcion = CultureHelper.GetTraduction(m.Tipo_Tipo_de_Equipo_de_Comunicacion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Tipo_de_Equipo_de_Comunicacion.Descripcion
                        ,MarcaDescripcion = CultureHelper.GetTraduction(m.Marca_Marca_de_Equipo_de_Comunicacion.Clave.ToString(), "Descripcion") ?? (string)m.Marca_Marca_de_Equipo_de_Comunicacion.Descripcion
			,Serie = m.Serie
			,IMEI = m.IMEI

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
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
                _IDetalle_Aseguramiento_Objetos_AseguradosApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_Aseguramiento_Objetos_Asegurados varDetalle_Aseguramiento_Objetos_Asegurados = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IDetalle_Aseguramiento_Objetos_AseguradosApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_Aseguramiento_Objetos_AseguradosModel varDetalle_Aseguramiento_Objetos_Asegurados)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_Aseguramiento_Objetos_AseguradosApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Detalle_Aseguramiento_Objetos_AseguradosInfo = new Detalle_Aseguramiento_Objetos_Asegurados
                    {
                        Clave = varDetalle_Aseguramiento_Objetos_Asegurados.Clave
                        ,Motivo_de_Registro = varDetalle_Aseguramiento_Objetos_Asegurados.Motivo_de_Registro
                        ,Numero = varDetalle_Aseguramiento_Objetos_Asegurados.Numero
                        ,Tipo = varDetalle_Aseguramiento_Objetos_Asegurados.Tipo
                        ,Marca = varDetalle_Aseguramiento_Objetos_Asegurados.Marca
                        ,Serie = varDetalle_Aseguramiento_Objetos_Asegurados.Serie
                        ,IMEI = varDetalle_Aseguramiento_Objetos_Asegurados.IMEI

                    };

                    result = !IsNew ?
                        _IDetalle_Aseguramiento_Objetos_AseguradosApiConsumer.Update(Detalle_Aseguramiento_Objetos_AseguradosInfo, null, null).Resource.ToString() :
                         _IDetalle_Aseguramiento_Objetos_AseguradosApiConsumer.Insert(Detalle_Aseguramiento_Objetos_AseguradosInfo, null, null).Resource.ToString();

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
        /// Write Element Array of Detalle_Aseguramiento_Objetos_Asegurados script
        /// </summary>
        /// <param name="oDetalle_Aseguramiento_Objetos_AseguradosElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements Detalle_Aseguramiento_Objetos_AseguradosModuleAttributeList)
        {
            for (int i = 0; i < Detalle_Aseguramiento_Objetos_AseguradosModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_Aseguramiento_Objetos_AseguradosModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_Aseguramiento_Objetos_AseguradosModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_Aseguramiento_Objetos_AseguradosModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_Aseguramiento_Objetos_AseguradosModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_Aseguramiento_Objetos_AseguradosModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_Aseguramiento_Objetos_AseguradosModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(Detalle_Aseguramiento_Objetos_AseguradosModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						Detalle_Aseguramiento_Objetos_AseguradosModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(Detalle_Aseguramiento_Objetos_AseguradosModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						Detalle_Aseguramiento_Objetos_AseguradosModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strDetalle_Aseguramiento_Objetos_AseguradosScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_Aseguramiento_Objetos_Asegurados.js")))
            {
                strDetalle_Aseguramiento_Objetos_AseguradosScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_Aseguramiento_Objetos_Asegurados element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_Aseguramiento_Objetos_AseguradosModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_Aseguramiento_Objetos_AseguradosScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_Aseguramiento_Objetos_AseguradosScript.Substring(indexOfArray, strDetalle_Aseguramiento_Objetos_AseguradosScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_Aseguramiento_Objetos_AseguradosModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_Aseguramiento_Objetos_AseguradosModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_Aseguramiento_Objetos_AseguradosScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strDetalle_Aseguramiento_Objetos_AseguradosScript.Substring(indexOfArrayHistory, strDetalle_Aseguramiento_Objetos_AseguradosScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strDetalle_Aseguramiento_Objetos_AseguradosScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_Aseguramiento_Objetos_AseguradosScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_Aseguramiento_Objetos_AseguradosScript.Length - (endIndexOfMainElement + indexOfArray));
            if (Detalle_Aseguramiento_Objetos_AseguradosModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strDetalle_Aseguramiento_Objetos_AseguradosScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strDetalle_Aseguramiento_Objetos_AseguradosScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strDetalle_Aseguramiento_Objetos_AseguradosScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strDetalle_Aseguramiento_Objetos_AseguradosScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_Aseguramiento_Objetos_Asegurados.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_Aseguramiento_Objetos_Asegurados.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_Aseguramiento_Objetos_Asegurados.js")))
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
        public ActionResult Detalle_Aseguramiento_Objetos_AseguradosPropertyBag()
        {
            return PartialView("Detalle_Aseguramiento_Objetos_AseguradosPropertyBag", "Detalle_Aseguramiento_Objetos_Asegurados");
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

            _IDetalle_Aseguramiento_Objetos_AseguradosApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Aseguramiento_Objetos_AseguradosPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_Aseguramiento_Objetos_AseguradosApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Aseguramiento_Objetos_Aseguradoss == null)
                result.Detalle_Aseguramiento_Objetos_Aseguradoss = new List<Detalle_Aseguramiento_Objetos_Asegurados>();

            var data = result.Detalle_Aseguramiento_Objetos_Aseguradoss.Select(m => new Detalle_Aseguramiento_Objetos_AseguradosGridModel
            {
                Clave = m.Clave
                ,Motivo_de_RegistroDescripcion = (string)m.Motivo_de_Registro_Motivo_de_Registro.Descripcion
                ,Numero = m.Numero
                ,TipoDescripcion = (string)m.Tipo_Tipo_de_Equipo_de_Comunicacion.Descripcion
                ,MarcaDescripcion = (string)m.Marca_Marca_de_Equipo_de_Comunicacion.Descripcion
                ,Serie = m.Serie
                ,IMEI = m.IMEI

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "Detalle_Aseguramiento_Objetos_AseguradosList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "Detalle_Aseguramiento_Objetos_AseguradosList_" + DateTime.Now.ToString());
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

            _IDetalle_Aseguramiento_Objetos_AseguradosApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Aseguramiento_Objetos_AseguradosPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_Aseguramiento_Objetos_AseguradosApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Aseguramiento_Objetos_Aseguradoss == null)
                result.Detalle_Aseguramiento_Objetos_Aseguradoss = new List<Detalle_Aseguramiento_Objetos_Asegurados>();

            var data = result.Detalle_Aseguramiento_Objetos_Aseguradoss.Select(m => new Detalle_Aseguramiento_Objetos_AseguradosGridModel
            {
                Clave = m.Clave
                ,Motivo_de_RegistroDescripcion = (string)m.Motivo_de_Registro_Motivo_de_Registro.Descripcion
                ,Numero = m.Numero
                ,TipoDescripcion = (string)m.Tipo_Tipo_de_Equipo_de_Comunicacion.Descripcion
                ,MarcaDescripcion = (string)m.Marca_Marca_de_Equipo_de_Comunicacion.Descripcion
                ,Serie = m.Serie
                ,IMEI = m.IMEI

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
