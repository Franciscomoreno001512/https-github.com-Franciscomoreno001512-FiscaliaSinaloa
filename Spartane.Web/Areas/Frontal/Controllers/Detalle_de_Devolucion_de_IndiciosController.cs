using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_de_Devolucion_de_Indicios;
using Spartane.Core.Domain.Indicios_para_MPI;
using Spartane.Core.Domain.Servicios_Periciales;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_de_Devolucion_de_Indicios;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Devolucion_de_Indicios;
using Spartane.Web.Areas.WebApiConsumer.Indicios_para_MPI;
using Spartane.Web.Areas.WebApiConsumer.Servicios_Periciales;

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
    public class Detalle_de_Devolucion_de_IndiciosController : Controller
    {
        #region "variable declaration"

        private IDetalle_de_Devolucion_de_IndiciosService service = null;
        private IDetalle_de_Devolucion_de_IndiciosApiConsumer _IDetalle_de_Devolucion_de_IndiciosApiConsumer;
        private IIndicios_para_MPIApiConsumer _IIndicios_para_MPIApiConsumer;
        private IServicios_PericialesApiConsumer _IServicios_PericialesApiConsumer;

        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Detalle_de_Devolucion_de_IndiciosController(IDetalle_de_Devolucion_de_IndiciosService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_de_Devolucion_de_IndiciosApiConsumer Detalle_de_Devolucion_de_IndiciosApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer , IIndicios_para_MPIApiConsumer Indicios_para_MPIApiConsumer , IServicios_PericialesApiConsumer Servicios_PericialesApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_de_Devolucion_de_IndiciosApiConsumer = Detalle_de_Devolucion_de_IndiciosApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._IIndicios_para_MPIApiConsumer = Indicios_para_MPIApiConsumer;
            this._IServicios_PericialesApiConsumer = Servicios_PericialesApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_de_Devolucion_de_Indicios
        [ObjectAuth(ObjectId = (ModuleObjectId)45187, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45187);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/Detalle_de_Devolucion_de_Indicios/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)45187, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45187);
            ViewBag.Permission = permission;
            var varDetalle_de_Devolucion_de_Indicios = new Detalle_de_Devolucion_de_IndiciosModel();
			
            ViewBag.ObjectId = "45187";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Devolucion_de_IndiciosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_de_Devolucion_de_IndiciosData = _IDetalle_de_Devolucion_de_IndiciosApiConsumer.GetByKeyComplete(Id).Resource.Detalle_de_Devolucion_de_Indicioss[0];
                if (Detalle_de_Devolucion_de_IndiciosData == null)
                    return HttpNotFound();

                varDetalle_de_Devolucion_de_Indicios = new Detalle_de_Devolucion_de_IndiciosModel
                {
                    Clave = (int)Detalle_de_Devolucion_de_IndiciosData.Clave
                    ,Fecha_de_Devolucion = (Detalle_de_Devolucion_de_IndiciosData.Fecha_de_Devolucion == null ? string.Empty : Convert.ToDateTime(Detalle_de_Devolucion_de_IndiciosData.Fecha_de_Devolucion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Devolucion = Detalle_de_Devolucion_de_IndiciosData.Hora_de_Devolucion
                    ,Nombre_de_Persona_que_Entrega = Detalle_de_Devolucion_de_IndiciosData.Nombre_de_Persona_que_Entrega
                    ,Numero_de_Indicio = Detalle_de_Devolucion_de_IndiciosData.Numero_de_Indicio
                    ,Numero_de_IndicioDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Devolucion_de_IndiciosData.Numero_de_Indicio), "Indicios_para_MPI") ??  (string)Detalle_de_Devolucion_de_IndiciosData.Numero_de_Indicio_Indicios_para_MPI.Descripcion
                    ,Nombre_de_Indicio = Detalle_de_Devolucion_de_IndiciosData.Nombre_de_Indicio
                    ,Descripcion_de_Devolucion_de_Indicio = Detalle_de_Devolucion_de_IndiciosData.Descripcion_de_Devolucion_de_Indicio
                    ,Diligencia_que_Devuelve = Detalle_de_Devolucion_de_IndiciosData.Diligencia_que_Devuelve
                    ,Diligencia_que_DevuelveServicio = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Devolucion_de_IndiciosData.Diligencia_que_Devuelve), "Servicios_Periciales") ??  (string)Detalle_de_Devolucion_de_IndiciosData.Diligencia_que_Devuelve_Servicios_Periciales.Servicio

                };

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IIndicios_para_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Indicios_para_MPIs_Numero_de_Indicio = _IIndicios_para_MPIApiConsumer.SelAll(true);
            if (Indicios_para_MPIs_Numero_de_Indicio != null && Indicios_para_MPIs_Numero_de_Indicio.Resource != null)
                ViewBag.Indicios_para_MPIs_Numero_de_Indicio = Indicios_para_MPIs_Numero_de_Indicio.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Indicios_para_MPI", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IServicios_PericialesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Servicios_Pericialess_Diligencia_que_Devuelve = _IServicios_PericialesApiConsumer.SelAll(true);
            if (Servicios_Pericialess_Diligencia_que_Devuelve != null && Servicios_Pericialess_Diligencia_que_Devuelve.Resource != null)
                ViewBag.Servicios_Pericialess_Diligencia_que_Devuelve = Servicios_Pericialess_Diligencia_que_Devuelve.Resource.Where(m => m.Servicio != null).OrderBy(m => m.Servicio).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Servicios_Periciales", "Servicio") ?? m.Servicio.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(varDetalle_de_Devolucion_de_Indicios);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_de_Devolucion_de_Indicios(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45187);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_de_Devolucion_de_IndiciosApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_de_Devolucion_de_IndiciosModel varDetalle_de_Devolucion_de_Indicios= new Detalle_de_Devolucion_de_IndiciosModel();


            if (id.ToString() != "0")
            {
                var Detalle_de_Devolucion_de_IndiciossData = _IDetalle_de_Devolucion_de_IndiciosApiConsumer.ListaSelAll(0, 1000, "Detalle_de_Devolucion_de_Indicios.Clave=" + id, "").Resource.Detalle_de_Devolucion_de_Indicioss;
				
				if (Detalle_de_Devolucion_de_IndiciossData != null && Detalle_de_Devolucion_de_IndiciossData.Count > 0)
                {
					var Detalle_de_Devolucion_de_IndiciosData = Detalle_de_Devolucion_de_IndiciossData.First();
					varDetalle_de_Devolucion_de_Indicios= new Detalle_de_Devolucion_de_IndiciosModel
					{
						Clave  = Detalle_de_Devolucion_de_IndiciosData.Clave 
	                    ,Fecha_de_Devolucion = (Detalle_de_Devolucion_de_IndiciosData.Fecha_de_Devolucion == null ? string.Empty : Convert.ToDateTime(Detalle_de_Devolucion_de_IndiciosData.Fecha_de_Devolucion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Devolucion = Detalle_de_Devolucion_de_IndiciosData.Hora_de_Devolucion
                    ,Nombre_de_Persona_que_Entrega = Detalle_de_Devolucion_de_IndiciosData.Nombre_de_Persona_que_Entrega
                    ,Numero_de_Indicio = Detalle_de_Devolucion_de_IndiciosData.Numero_de_Indicio
                    ,Numero_de_IndicioDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Devolucion_de_IndiciosData.Numero_de_Indicio), "Indicios_para_MPI") ??  (string)Detalle_de_Devolucion_de_IndiciosData.Numero_de_Indicio_Indicios_para_MPI.Descripcion
                    ,Nombre_de_Indicio = Detalle_de_Devolucion_de_IndiciosData.Nombre_de_Indicio
                    ,Descripcion_de_Devolucion_de_Indicio = Detalle_de_Devolucion_de_IndiciosData.Descripcion_de_Devolucion_de_Indicio
                    ,Diligencia_que_Devuelve = Detalle_de_Devolucion_de_IndiciosData.Diligencia_que_Devuelve
                    ,Diligencia_que_DevuelveServicio = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Devolucion_de_IndiciosData.Diligencia_que_Devuelve), "Servicios_Periciales") ??  (string)Detalle_de_Devolucion_de_IndiciosData.Diligencia_que_Devuelve_Servicios_Periciales.Servicio

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IIndicios_para_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Indicios_para_MPIs_Numero_de_Indicio = _IIndicios_para_MPIApiConsumer.SelAll(true);
            if (Indicios_para_MPIs_Numero_de_Indicio != null && Indicios_para_MPIs_Numero_de_Indicio.Resource != null)
                ViewBag.Indicios_para_MPIs_Numero_de_Indicio = Indicios_para_MPIs_Numero_de_Indicio.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Indicios_para_MPI", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IServicios_PericialesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Servicios_Pericialess_Diligencia_que_Devuelve = _IServicios_PericialesApiConsumer.SelAll(true);
            if (Servicios_Pericialess_Diligencia_que_Devuelve != null && Servicios_Pericialess_Diligencia_que_Devuelve.Resource != null)
                ViewBag.Servicios_Pericialess_Diligencia_que_Devuelve = Servicios_Pericialess_Diligencia_que_Devuelve.Resource.Where(m => m.Servicio != null).OrderBy(m => m.Servicio).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Servicios_Periciales", "Servicio") ?? m.Servicio.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddDetalle_de_Devolucion_de_Indicios", varDetalle_de_Devolucion_de_Indicios);
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
        public ActionResult GetIndicios_para_MPIAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IIndicios_para_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IIndicios_para_MPIApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Indicios_para_MPI", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetServicios_PericialesAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IServicios_PericialesApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IServicios_PericialesApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Servicio).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Servicios_Periciales", "Servicio")?? m.Servicio,
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_Devolucion_de_IndiciosPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_de_Devolucion_de_IndiciosApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Devolucion_de_Indicioss == null)
                result.Detalle_de_Devolucion_de_Indicioss = new List<Detalle_de_Devolucion_de_Indicios>();

            return Json(new
            {
                data = result.Detalle_de_Devolucion_de_Indicioss.Select(m => new Detalle_de_Devolucion_de_IndiciosGridModel
                    {
                    Clave = m.Clave
                        ,Fecha_de_Devolucion = (m.Fecha_de_Devolucion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Devolucion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Devolucion = m.Hora_de_Devolucion
			,Nombre_de_Persona_que_Entrega = m.Nombre_de_Persona_que_Entrega
                        ,Numero_de_IndicioDescripcion = CultureHelper.GetTraduction(m.Numero_de_Indicio_Indicios_para_MPI.Clave.ToString(), "Descripcion") ?? (string)m.Numero_de_Indicio_Indicios_para_MPI.Descripcion
			,Nombre_de_Indicio = m.Nombre_de_Indicio
			,Descripcion_de_Devolucion_de_Indicio = m.Descripcion_de_Devolucion_de_Indicio
                        ,Diligencia_que_DevuelveServicio = CultureHelper.GetTraduction(m.Diligencia_que_Devuelve_Servicios_Periciales.Clave.ToString(), "Servicio") ?? (string)m.Diligencia_que_Devuelve_Servicios_Periciales.Servicio

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
                _IDetalle_de_Devolucion_de_IndiciosApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_de_Devolucion_de_Indicios varDetalle_de_Devolucion_de_Indicios = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IDetalle_de_Devolucion_de_IndiciosApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_de_Devolucion_de_IndiciosModel varDetalle_de_Devolucion_de_Indicios)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_de_Devolucion_de_IndiciosApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Detalle_de_Devolucion_de_IndiciosInfo = new Detalle_de_Devolucion_de_Indicios
                    {
                        Clave = varDetalle_de_Devolucion_de_Indicios.Clave
                        ,Fecha_de_Devolucion = (!String.IsNullOrEmpty(varDetalle_de_Devolucion_de_Indicios.Fecha_de_Devolucion)) ? DateTime.ParseExact(varDetalle_de_Devolucion_de_Indicios.Fecha_de_Devolucion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Devolucion = varDetalle_de_Devolucion_de_Indicios.Hora_de_Devolucion
                        ,Nombre_de_Persona_que_Entrega = varDetalle_de_Devolucion_de_Indicios.Nombre_de_Persona_que_Entrega
                        ,Numero_de_Indicio = varDetalle_de_Devolucion_de_Indicios.Numero_de_Indicio
                        ,Nombre_de_Indicio = varDetalle_de_Devolucion_de_Indicios.Nombre_de_Indicio
                        ,Descripcion_de_Devolucion_de_Indicio = varDetalle_de_Devolucion_de_Indicios.Descripcion_de_Devolucion_de_Indicio
                        ,Diligencia_que_Devuelve = varDetalle_de_Devolucion_de_Indicios.Diligencia_que_Devuelve

                    };

                    result = !IsNew ?
                        _IDetalle_de_Devolucion_de_IndiciosApiConsumer.Update(Detalle_de_Devolucion_de_IndiciosInfo, null, null).Resource.ToString() :
                         _IDetalle_de_Devolucion_de_IndiciosApiConsumer.Insert(Detalle_de_Devolucion_de_IndiciosInfo, null, null).Resource.ToString();

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
        /// Write Element Array of Detalle_de_Devolucion_de_Indicios script
        /// </summary>
        /// <param name="oDetalle_de_Devolucion_de_IndiciosElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements Detalle_de_Devolucion_de_IndiciosModuleAttributeList)
        {
            for (int i = 0; i < Detalle_de_Devolucion_de_IndiciosModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_de_Devolucion_de_IndiciosModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_de_Devolucion_de_IndiciosModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_de_Devolucion_de_IndiciosModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_de_Devolucion_de_IndiciosModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_de_Devolucion_de_IndiciosModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_de_Devolucion_de_IndiciosModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(Detalle_de_Devolucion_de_IndiciosModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						Detalle_de_Devolucion_de_IndiciosModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(Detalle_de_Devolucion_de_IndiciosModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						Detalle_de_Devolucion_de_IndiciosModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strDetalle_de_Devolucion_de_IndiciosScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Devolucion_de_Indicios.js")))
            {
                strDetalle_de_Devolucion_de_IndiciosScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_de_Devolucion_de_Indicios element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_de_Devolucion_de_IndiciosModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_de_Devolucion_de_IndiciosScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_de_Devolucion_de_IndiciosScript.Substring(indexOfArray, strDetalle_de_Devolucion_de_IndiciosScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_de_Devolucion_de_IndiciosModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_de_Devolucion_de_IndiciosModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_de_Devolucion_de_IndiciosScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strDetalle_de_Devolucion_de_IndiciosScript.Substring(indexOfArrayHistory, strDetalle_de_Devolucion_de_IndiciosScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strDetalle_de_Devolucion_de_IndiciosScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_de_Devolucion_de_IndiciosScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_de_Devolucion_de_IndiciosScript.Length - (endIndexOfMainElement + indexOfArray));
            if (Detalle_de_Devolucion_de_IndiciosModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strDetalle_de_Devolucion_de_IndiciosScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strDetalle_de_Devolucion_de_IndiciosScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strDetalle_de_Devolucion_de_IndiciosScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strDetalle_de_Devolucion_de_IndiciosScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_de_Devolucion_de_Indicios.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_de_Devolucion_de_Indicios.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Devolucion_de_Indicios.js")))
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
        public ActionResult Detalle_de_Devolucion_de_IndiciosPropertyBag()
        {
            return PartialView("Detalle_de_Devolucion_de_IndiciosPropertyBag", "Detalle_de_Devolucion_de_Indicios");
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

            _IDetalle_de_Devolucion_de_IndiciosApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_Devolucion_de_IndiciosPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_Devolucion_de_IndiciosApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Devolucion_de_Indicioss == null)
                result.Detalle_de_Devolucion_de_Indicioss = new List<Detalle_de_Devolucion_de_Indicios>();

            var data = result.Detalle_de_Devolucion_de_Indicioss.Select(m => new Detalle_de_Devolucion_de_IndiciosGridModel
            {
                Clave = m.Clave
                ,Fecha_de_Devolucion = (m.Fecha_de_Devolucion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Devolucion).ToString(ConfigurationProperty.DateFormat))
                ,Hora_de_Devolucion = m.Hora_de_Devolucion
                ,Nombre_de_Persona_que_Entrega = m.Nombre_de_Persona_que_Entrega
                ,Numero_de_IndicioDescripcion = (string)m.Numero_de_Indicio_Indicios_para_MPI.Descripcion
                ,Nombre_de_Indicio = m.Nombre_de_Indicio
                ,Descripcion_de_Devolucion_de_Indicio = m.Descripcion_de_Devolucion_de_Indicio
                ,Diligencia_que_DevuelveServicio = (string)m.Diligencia_que_Devuelve_Servicios_Periciales.Servicio

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "Detalle_de_Devolucion_de_IndiciosList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "Detalle_de_Devolucion_de_IndiciosList_" + DateTime.Now.ToString());
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

            _IDetalle_de_Devolucion_de_IndiciosApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_Devolucion_de_IndiciosPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_Devolucion_de_IndiciosApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Devolucion_de_Indicioss == null)
                result.Detalle_de_Devolucion_de_Indicioss = new List<Detalle_de_Devolucion_de_Indicios>();

            var data = result.Detalle_de_Devolucion_de_Indicioss.Select(m => new Detalle_de_Devolucion_de_IndiciosGridModel
            {
                Clave = m.Clave
                ,Fecha_de_Devolucion = (m.Fecha_de_Devolucion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Devolucion).ToString(ConfigurationProperty.DateFormat))
                ,Hora_de_Devolucion = m.Hora_de_Devolucion
                ,Nombre_de_Persona_que_Entrega = m.Nombre_de_Persona_que_Entrega
                ,Numero_de_IndicioDescripcion = (string)m.Numero_de_Indicio_Indicios_para_MPI.Descripcion
                ,Nombre_de_Indicio = m.Nombre_de_Indicio
                ,Descripcion_de_Devolucion_de_Indicio = m.Descripcion_de_Devolucion_de_Indicio
                ,Diligencia_que_DevuelveServicio = (string)m.Diligencia_que_Devuelve_Servicios_Periciales.Servicio

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
