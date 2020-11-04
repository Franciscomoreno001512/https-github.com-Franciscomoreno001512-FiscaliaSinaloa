using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Diligencias;
using Spartane.Core.Domain.Servicios_Periciales;
using Spartane.Core.Domain.Estatus_del_Dictamen;
using Spartane.Core.Domain.Rol_de_Diligencia;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Diligencias;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Diligencias;
using Spartane.Web.Areas.WebApiConsumer.Servicios_Periciales;
using Spartane.Web.Areas.WebApiConsumer.Estatus_del_Dictamen;
using Spartane.Web.Areas.WebApiConsumer.Rol_de_Diligencia;

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

using Spartane.Web.Areas.WebApiConsumer.Spartan_Format;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Format_Permissions;
using Spartane.Web.Areas.WebApiConsumer.GeneratePDF;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;

using Spartane.Web.Areas.WebApiConsumer.Spartan_Format_Related;
using Spartane.Core.Domain.Spartan_Format;
using iTextSharp.text.pdf;


namespace Spartane.Web.Areas.Frontal.Controllers
{
    [OutputCache(NoStore = true, Duration = 0, VaryByParam = "*")]
    public class DiligenciasController : Controller
    {
        #region "variable declaration"

        private IDiligenciasService service = null;
        private IDiligenciasApiConsumer _IDiligenciasApiConsumer;
        private IServicios_PericialesApiConsumer _IServicios_PericialesApiConsumer;
        private IEstatus_del_DictamenApiConsumer _IEstatus_del_DictamenApiConsumer;
        private IRol_de_DiligenciaApiConsumer _IRol_de_DiligenciaApiConsumer;

        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;
        private IGeneratePDFApiConsumer _IGeneratePDFApiConsumer;
        private ISpartan_FormatApiConsumer _ISpartan_FormatApiConsumer;
        private ISpartan_Format_PermissionsApiConsumer _ISpartan_Format_PermissionsApiConsumer;
		private ISpartan_Format_RelatedApiConsumer _ISpartan_FormatRelatedApiConsumer;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public DiligenciasController(IDiligenciasService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDiligenciasApiConsumer DiligenciasApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , IServicios_PericialesApiConsumer Servicios_PericialesApiConsumer , IEstatus_del_DictamenApiConsumer Estatus_del_DictamenApiConsumer , IRol_de_DiligenciaApiConsumer Rol_de_DiligenciaApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDiligenciasApiConsumer = DiligenciasApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_FormatApiConsumer = Spartan_FormatApiConsumer;
            this._ISpartan_Format_PermissionsApiConsumer = Spartan_Format_PermissionsApiConsumer;
            this._IGeneratePDFApiConsumer = GeneratePDFApiConsumer;
			this._ISpartan_FormatRelatedApiConsumer = Spartan_Format_RelatedApiConsumer;
            this._IServicios_PericialesApiConsumer = Servicios_PericialesApiConsumer;
            this._IEstatus_del_DictamenApiConsumer = Estatus_del_DictamenApiConsumer;
            this._IRol_de_DiligenciaApiConsumer = Rol_de_DiligenciaApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Diligencias
        [ObjectAuth(ObjectId = (ModuleObjectId)45176, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index(int ModuleId=0)
        {
			if (Session["AdvanceReportFilter"] != null)
            {
                Session["AdvanceReportFilter"] = null;
                Session["AdvanceSearch"] = null;
            }
			if (ModuleId == 0)
            {
                ModuleId = Convert.ToInt32(Session["CurrentModuleId"]);
                if (ModuleId == 0)
                {
                    Response.Redirect("~/");
                }
            }
            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45176, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Diligencias/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45176, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45176, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varDiligencias = new DiligenciasModel();
			varDiligencias.Clave = Id;
			
            ViewBag.ObjectId = "45176";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IDiligenciasApiConsumer.SetAuthHeader(_tokenManager.Token);
                var DiligenciassData = _IDiligenciasApiConsumer.ListaSelAll(0, 1000, "Diligencias.Clave=" + Id, "").Resource.Diligenciass;
				
				if (DiligenciassData != null && DiligenciassData.Count > 0)
                {
					var DiligenciasData = DiligenciassData.First();
					varDiligencias= new DiligenciasModel
					{
						Clave  = DiligenciasData.Clave 
	                    ,Fecha_de_Registro = (DiligenciasData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(DiligenciasData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Registro = DiligenciasData.Hora_de_Registro
                    ,Servicio = DiligenciasData.Servicio
                    ,ServicioServicio = CultureHelper.GetTraduction(Convert.ToString(DiligenciasData.Servicio), "Servicios_Periciales") ??  (string)DiligenciasData.Servicio_Servicios_Periciales.Servicio
                    ,Especialista = DiligenciasData.Especialista
                    ,Estatus_del_Dictamen = DiligenciasData.Estatus_del_Dictamen
                    ,Estatus_del_DictamenDescripcion = CultureHelper.GetTraduction(Convert.ToString(DiligenciasData.Estatus_del_Dictamen), "Estatus_del_Dictamen") ??  (string)DiligenciasData.Estatus_del_Dictamen_Estatus_del_Dictamen.Descripcion
                    ,Fecha_del_Dictamen = (DiligenciasData.Fecha_del_Dictamen == null ? string.Empty : Convert.ToDateTime(DiligenciasData.Fecha_del_Dictamen).ToString(ConfigurationProperty.DateFormat))
                    ,Dictamen = DiligenciasData.Dictamen
                    ,Rol_de_Donde_Proviene = DiligenciasData.Rol_de_Donde_Proviene
                    ,Rol_de_Donde_ProvieneDescripcion = CultureHelper.GetTraduction(Convert.ToString(DiligenciasData.Rol_de_Donde_Proviene), "Rol_de_Diligencia") ??  (string)DiligenciasData.Rol_de_Donde_Proviene_Rol_de_Diligencia.Descripcion
                    ,Clave_Diligencia = DiligenciasData.Clave_Diligencia

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IServicios_PericialesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Servicios_Pericialess_Servicio = _IServicios_PericialesApiConsumer.SelAll(true);
            if (Servicios_Pericialess_Servicio != null && Servicios_Pericialess_Servicio.Resource != null)
                ViewBag.Servicios_Pericialess_Servicio = Servicios_Pericialess_Servicio.Resource.Where(m => m.Servicio != null).OrderBy(m => m.Servicio).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Servicios_Periciales", "Servicio") ?? m.Servicio.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatus_del_DictamenApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_del_Dictamens_Estatus_del_Dictamen = _IEstatus_del_DictamenApiConsumer.SelAll(true);
            if (Estatus_del_Dictamens_Estatus_del_Dictamen != null && Estatus_del_Dictamens_Estatus_del_Dictamen.Resource != null)
                ViewBag.Estatus_del_Dictamens_Estatus_del_Dictamen = Estatus_del_Dictamens_Estatus_del_Dictamen.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_del_Dictamen", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IRol_de_DiligenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Rol_de_Diligencias_Rol_de_Donde_Proviene = _IRol_de_DiligenciaApiConsumer.SelAll(true);
            if (Rol_de_Diligencias_Rol_de_Donde_Proviene != null && Rol_de_Diligencias_Rol_de_Donde_Proviene.Resource != null)
                ViewBag.Rol_de_Diligencias_Rol_de_Donde_Proviene = Rol_de_Diligencias_Rol_de_Donde_Proviene.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Rol_de_Diligencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
				
			var viewInEframe = false;
			var isPartial = false;
            var isMR = false;
            var nameMR = string.Empty;
            var nameAttribute = string.Empty;

	        if (Request.QueryString["isPartial"]!= null)
                isPartial = Convert.ToBoolean(Request.QueryString["isPartial"]);

            if (Request.QueryString["isMR"] != null)
                isMR = Convert.ToBoolean(Request.QueryString["isMR"]);

            if (Request.QueryString["nameMR"] != null)
                nameMR = Request.QueryString["nameMR"].ToString();

            if (Request.QueryString["nameAttribute"] != null)
                nameAttribute = Request.QueryString["nameAttribute"].ToString();
				
			if (Request.QueryString["viewInEframe"] != null)
                viewInEframe = Convert.ToBoolean(Request.QueryString["viewInEframe"]);	
				
			ViewBag.isPartial=isPartial;
			ViewBag.isMR=isMR;
			ViewBag.nameMR=nameMR;
			ViewBag.nameAttribute=nameAttribute;
			ViewBag.viewInEframe = viewInEframe;

				
            return View(varDiligencias);
        }
		
	[HttpGet]
        public ActionResult AddDiligencias(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45176);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDiligenciasApiConsumer.SetAuthHeader(_tokenManager.Token);
			DiligenciasModel varDiligencias= new DiligenciasModel();


            if (id.ToString() != "0")
            {
                var DiligenciassData = _IDiligenciasApiConsumer.ListaSelAll(0, 1000, "Diligencias.Clave=" + id, "").Resource.Diligenciass;
				
				if (DiligenciassData != null && DiligenciassData.Count > 0)
                {
					var DiligenciasData = DiligenciassData.First();
					varDiligencias= new DiligenciasModel
					{
						Clave  = DiligenciasData.Clave 
	                    ,Fecha_de_Registro = (DiligenciasData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(DiligenciasData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Registro = DiligenciasData.Hora_de_Registro
                    ,Servicio = DiligenciasData.Servicio
                    ,ServicioServicio = CultureHelper.GetTraduction(Convert.ToString(DiligenciasData.Servicio), "Servicios_Periciales") ??  (string)DiligenciasData.Servicio_Servicios_Periciales.Servicio
                    ,Especialista = DiligenciasData.Especialista
                    ,Estatus_del_Dictamen = DiligenciasData.Estatus_del_Dictamen
                    ,Estatus_del_DictamenDescripcion = CultureHelper.GetTraduction(Convert.ToString(DiligenciasData.Estatus_del_Dictamen), "Estatus_del_Dictamen") ??  (string)DiligenciasData.Estatus_del_Dictamen_Estatus_del_Dictamen.Descripcion
                    ,Fecha_del_Dictamen = (DiligenciasData.Fecha_del_Dictamen == null ? string.Empty : Convert.ToDateTime(DiligenciasData.Fecha_del_Dictamen).ToString(ConfigurationProperty.DateFormat))
                    ,Dictamen = DiligenciasData.Dictamen
                    ,Rol_de_Donde_Proviene = DiligenciasData.Rol_de_Donde_Proviene
                    ,Rol_de_Donde_ProvieneDescripcion = CultureHelper.GetTraduction(Convert.ToString(DiligenciasData.Rol_de_Donde_Proviene), "Rol_de_Diligencia") ??  (string)DiligenciasData.Rol_de_Donde_Proviene_Rol_de_Diligencia.Descripcion
                    ,Clave_Diligencia = DiligenciasData.Clave_Diligencia

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IServicios_PericialesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Servicios_Pericialess_Servicio = _IServicios_PericialesApiConsumer.SelAll(true);
            if (Servicios_Pericialess_Servicio != null && Servicios_Pericialess_Servicio.Resource != null)
                ViewBag.Servicios_Pericialess_Servicio = Servicios_Pericialess_Servicio.Resource.Where(m => m.Servicio != null).OrderBy(m => m.Servicio).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Servicios_Periciales", "Servicio") ?? m.Servicio.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatus_del_DictamenApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_del_Dictamens_Estatus_del_Dictamen = _IEstatus_del_DictamenApiConsumer.SelAll(true);
            if (Estatus_del_Dictamens_Estatus_del_Dictamen != null && Estatus_del_Dictamens_Estatus_del_Dictamen.Resource != null)
                ViewBag.Estatus_del_Dictamens_Estatus_del_Dictamen = Estatus_del_Dictamens_Estatus_del_Dictamen.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_del_Dictamen", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IRol_de_DiligenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Rol_de_Diligencias_Rol_de_Donde_Proviene = _IRol_de_DiligenciaApiConsumer.SelAll(true);
            if (Rol_de_Diligencias_Rol_de_Donde_Proviene != null && Rol_de_Diligencias_Rol_de_Donde_Proviene.Resource != null)
                ViewBag.Rol_de_Diligencias_Rol_de_Donde_Proviene = Rol_de_Diligencias_Rol_de_Donde_Proviene.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Rol_de_Diligencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddDiligencias", varDiligencias);
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
        [HttpGet]
        public ActionResult GetEstatus_del_DictamenAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstatus_del_DictamenApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstatus_del_DictamenApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_del_Dictamen", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetRol_de_DiligenciaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRol_de_DiligenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IRol_de_DiligenciaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Rol_de_Diligencia", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }



        [HttpPost]
        public JsonResult ClearAdvanceFilter()
        {
            Session["AdvanceSearch"] = null;
            return Json(new { result = Session["AdvanceSearch"] == null }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult ShowAdvanceFilter(DiligenciasAdvanceSearchModel model, int idFilter = -1)
        {
            if (ModelState.IsValid)
            {
                Session["AdvanceSearch"] = model;
				if (idFilter != -1)
                {
                    Session["AdvanceReportFilter"] = GetAdvanceFilter(model);
                    return RedirectToAction("Index", "Report", new { id = idFilter });
                }
                return RedirectToAction("Index");
            }
            ViewBag.Filter = new List<SelectListItem>
            {
                new SelectListItem() {Text = Resources.Resources.BeginWith, Value = "1"},
                new SelectListItem() {Text = Resources.Resources.EndWith, Value = "2"},
                new SelectListItem() {Text = Resources.Resources.Contains, Value = "4"},
                new SelectListItem() {Text = Resources.Resources.Exact, Value = "3"},
            };
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IServicios_PericialesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Servicios_Pericialess_Servicio = _IServicios_PericialesApiConsumer.SelAll(true);
            if (Servicios_Pericialess_Servicio != null && Servicios_Pericialess_Servicio.Resource != null)
                ViewBag.Servicios_Pericialess_Servicio = Servicios_Pericialess_Servicio.Resource.Where(m => m.Servicio != null).OrderBy(m => m.Servicio).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Servicios_Periciales", "Servicio") ?? m.Servicio.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatus_del_DictamenApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_del_Dictamens_Estatus_del_Dictamen = _IEstatus_del_DictamenApiConsumer.SelAll(true);
            if (Estatus_del_Dictamens_Estatus_del_Dictamen != null && Estatus_del_Dictamens_Estatus_del_Dictamen.Resource != null)
                ViewBag.Estatus_del_Dictamens_Estatus_del_Dictamen = Estatus_del_Dictamens_Estatus_del_Dictamen.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_del_Dictamen", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IRol_de_DiligenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Rol_de_Diligencias_Rol_de_Donde_Proviene = _IRol_de_DiligenciaApiConsumer.SelAll(true);
            if (Rol_de_Diligencias_Rol_de_Donde_Proviene != null && Rol_de_Diligencias_Rol_de_Donde_Proviene.Resource != null)
                ViewBag.Rol_de_Diligencias_Rol_de_Donde_Proviene = Rol_de_Diligencias_Rol_de_Donde_Proviene.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Rol_de_Diligencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IServicios_PericialesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Servicios_Pericialess_Servicio = _IServicios_PericialesApiConsumer.SelAll(true);
            if (Servicios_Pericialess_Servicio != null && Servicios_Pericialess_Servicio.Resource != null)
                ViewBag.Servicios_Pericialess_Servicio = Servicios_Pericialess_Servicio.Resource.Where(m => m.Servicio != null).OrderBy(m => m.Servicio).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Servicios_Periciales", "Servicio") ?? m.Servicio.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatus_del_DictamenApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_del_Dictamens_Estatus_del_Dictamen = _IEstatus_del_DictamenApiConsumer.SelAll(true);
            if (Estatus_del_Dictamens_Estatus_del_Dictamen != null && Estatus_del_Dictamens_Estatus_del_Dictamen.Resource != null)
                ViewBag.Estatus_del_Dictamens_Estatus_del_Dictamen = Estatus_del_Dictamens_Estatus_del_Dictamen.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_del_Dictamen", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IRol_de_DiligenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Rol_de_Diligencias_Rol_de_Donde_Proviene = _IRol_de_DiligenciaApiConsumer.SelAll(true);
            if (Rol_de_Diligencias_Rol_de_Donde_Proviene != null && Rol_de_Diligencias_Rol_de_Donde_Proviene.Resource != null)
                ViewBag.Rol_de_Diligencias_Rol_de_Donde_Proviene = Rol_de_Diligencias_Rol_de_Donde_Proviene.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Rol_de_Diligencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new DiligenciasAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (DiligenciasAdvanceSearchModel)(Session["AdvanceSearch"] ?? new DiligenciasAdvanceSearchModel());
            }

            ViewBag.Filter = new List<SelectListItem>
            {
                new SelectListItem() {Text = Resources.Resources.BeginWith, Value = "1"},
                new SelectListItem() {Text = Resources.Resources.EndWith, Value = "2"},
                new SelectListItem() {Text = Resources.Resources.Contains, Value = "4"},
                new SelectListItem() {Text = Resources.Resources.Exact, Value = "3"},

            };

            return View(previousFiltersObj);
        }

        public ActionResult Get()
        {
            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new DiligenciasPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDiligenciasApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Diligenciass == null)
                result.Diligenciass = new List<Diligencias>();

            return Json(new
            {
                data = result.Diligenciass.Select(m => new DiligenciasGridModel
                    {
                    Clave = m.Clave
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,ServicioServicio = CultureHelper.GetTraduction(m.Servicio_Servicios_Periciales.Clave.ToString(), "Servicio") ?? (string)m.Servicio_Servicios_Periciales.Servicio
			,Especialista = m.Especialista
                        ,Estatus_del_DictamenDescripcion = CultureHelper.GetTraduction(m.Estatus_del_Dictamen_Estatus_del_Dictamen.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_del_Dictamen_Estatus_del_Dictamen.Descripcion
                        ,Fecha_del_Dictamen = (m.Fecha_del_Dictamen == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Dictamen).ToString(ConfigurationProperty.DateFormat))
			,Dictamen = m.Dictamen
                        ,Rol_de_Donde_ProvieneDescripcion = CultureHelper.GetTraduction(m.Rol_de_Donde_Proviene_Rol_de_Diligencia.Clave.ToString(), "Descripcion") ?? (string)m.Rol_de_Donde_Proviene_Rol_de_Diligencia.Descripcion
			,Clave_Diligencia = m.Clave_Diligencia

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetDiligenciasAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDiligenciasApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDiligenciasApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Diligencias", m.),
                     Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
*/
        /// <summary>
        /// Get List of Diligencias from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Diligencias Entity</returns>
        public ActionResult GetDiligenciasList(UrlParametersModel param)
        {
			 int sEcho = param.sEcho;
            int iDisplayStart = param.iDisplayStart;
            int iDisplayLength = param.iDisplayLength;
            string where = param.where;
            string order = param.order;

            where = HttpUtility.UrlEncode(where);
            int sortColumn = -1;
            string sortDirection = "asc";
            if (iDisplayLength == -1)
            {
                //length = TOTAL_ROWS;
                iDisplayLength = Int32.MaxValue;
            }
            // note: we only sort one column at a time
            if (param.sortColumn != null)
            {
                sortColumn = int.Parse(param.sortColumn);
            }
            if (param.sortDirection != null)
            {
                sortDirection = param.sortDirection;
            }


            if (!_tokenManager.GenerateToken())
                return null;
            _IDiligenciasApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new DiligenciasPropertyMapper());
				
			if (!String.IsNullOrEmpty(where))
            {
                 configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
            if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            //Adding Advance Search
            if (param.AdvanceSearch != null && param.AdvanceSearch == true && Session["AdvanceSearch"] != null)            
            {
				if (Session["AdvanceSearch"].GetType() == typeof(DiligenciasAdvanceSearchModel))
                {
					var advanceFilter =
                    (DiligenciasAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            DiligenciasPropertyMapper oDiligenciasPropertyMapper = new DiligenciasPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oDiligenciasPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IDiligenciasApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Diligenciass == null)
                result.Diligenciass = new List<Diligencias>();

            return Json(new
            {
                aaData = result.Diligenciass.Select(m => new DiligenciasGridModel
            {
                    Clave = m.Clave
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,ServicioServicio = CultureHelper.GetTraduction(m.Servicio_Servicios_Periciales.Clave.ToString(), "Servicio") ?? (string)m.Servicio_Servicios_Periciales.Servicio
			,Especialista = m.Especialista
                        ,Estatus_del_DictamenDescripcion = CultureHelper.GetTraduction(m.Estatus_del_Dictamen_Estatus_del_Dictamen.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_del_Dictamen_Estatus_del_Dictamen.Descripcion
                        ,Fecha_del_Dictamen = (m.Fecha_del_Dictamen == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Dictamen).ToString(ConfigurationProperty.DateFormat))
			,Dictamen = m.Dictamen
                        ,Rol_de_Donde_ProvieneDescripcion = CultureHelper.GetTraduction(m.Rol_de_Donde_Proviene_Rol_de_Diligencia.Clave.ToString(), "Descripcion") ?? (string)m.Rol_de_Donde_Proviene_Rol_de_Diligencia.Descripcion
			,Clave_Diligencia = m.Clave_Diligencia

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }







        [NonAction]
        public string GetAdvanceFilter(DiligenciasAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro) || !string.IsNullOrEmpty(filter.ToFecha_de_Registro))
            {
                var Fecha_de_RegistroFrom = DateTime.ParseExact(filter.FromFecha_de_Registro, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_RegistroTo = DateTime.ParseExact(filter.ToFecha_de_Registro, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro))
                    where += " AND Diligencias.Fecha_de_Registro >= '" + Fecha_de_RegistroFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Registro))
                    where += " AND Diligencias.Fecha_de_Registro <= '" + Fecha_de_RegistroTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Registro) || !string.IsNullOrEmpty(filter.ToHora_de_Registro))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Registro))
                    where += " AND Convert(TIME,Diligencias.Hora_de_Registro) >='" + filter.FromHora_de_Registro + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Registro))
                    where += " AND Convert(TIME,Diligencias.Hora_de_Registro) <='" + filter.ToHora_de_Registro + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceServicio))
            {
                switch (filter.ServicioFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Servicios_Periciales.Servicio LIKE '" + filter.AdvanceServicio + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Servicios_Periciales.Servicio LIKE '%" + filter.AdvanceServicio + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Servicios_Periciales.Servicio = '" + filter.AdvanceServicio + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Servicios_Periciales.Servicio LIKE '%" + filter.AdvanceServicio + "%'";
                        break;
                }
            }
            else if (filter.AdvanceServicioMultiple != null && filter.AdvanceServicioMultiple.Count() > 0)
            {
                var ServicioIds = string.Join(",", filter.AdvanceServicioMultiple);

                where += " AND Diligencias.Servicio In (" + ServicioIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromEspecialista) || !string.IsNullOrEmpty(filter.ToEspecialista))
            {
                if (!string.IsNullOrEmpty(filter.FromEspecialista))
                    where += " AND Diligencias.Especialista >= " + filter.FromEspecialista;
                if (!string.IsNullOrEmpty(filter.ToEspecialista))
                    where += " AND Diligencias.Especialista <= " + filter.ToEspecialista;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstatus_del_Dictamen))
            {
                switch (filter.Estatus_del_DictamenFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estatus_del_Dictamen.Descripcion LIKE '" + filter.AdvanceEstatus_del_Dictamen + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estatus_del_Dictamen.Descripcion LIKE '%" + filter.AdvanceEstatus_del_Dictamen + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estatus_del_Dictamen.Descripcion = '" + filter.AdvanceEstatus_del_Dictamen + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estatus_del_Dictamen.Descripcion LIKE '%" + filter.AdvanceEstatus_del_Dictamen + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstatus_del_DictamenMultiple != null && filter.AdvanceEstatus_del_DictamenMultiple.Count() > 0)
            {
                var Estatus_del_DictamenIds = string.Join(",", filter.AdvanceEstatus_del_DictamenMultiple);

                where += " AND Diligencias.Estatus_del_Dictamen In (" + Estatus_del_DictamenIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_del_Dictamen) || !string.IsNullOrEmpty(filter.ToFecha_del_Dictamen))
            {
                var Fecha_del_DictamenFrom = DateTime.ParseExact(filter.FromFecha_del_Dictamen, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_del_DictamenTo = DateTime.ParseExact(filter.ToFecha_del_Dictamen, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_del_Dictamen))
                    where += " AND Diligencias.Fecha_del_Dictamen >= '" + Fecha_del_DictamenFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_del_Dictamen))
                    where += " AND Diligencias.Fecha_del_Dictamen <= '" + Fecha_del_DictamenTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromDictamen) || !string.IsNullOrEmpty(filter.ToDictamen))
            {
                if (!string.IsNullOrEmpty(filter.FromDictamen))
                    where += " AND Diligencias.Dictamen >= " + filter.FromDictamen;
                if (!string.IsNullOrEmpty(filter.ToDictamen))
                    where += " AND Diligencias.Dictamen <= " + filter.ToDictamen;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceRol_de_Donde_Proviene))
            {
                switch (filter.Rol_de_Donde_ProvieneFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Rol_de_Diligencia.Descripcion LIKE '" + filter.AdvanceRol_de_Donde_Proviene + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Rol_de_Diligencia.Descripcion LIKE '%" + filter.AdvanceRol_de_Donde_Proviene + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Rol_de_Diligencia.Descripcion = '" + filter.AdvanceRol_de_Donde_Proviene + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Rol_de_Diligencia.Descripcion LIKE '%" + filter.AdvanceRol_de_Donde_Proviene + "%'";
                        break;
                }
            }
            else if (filter.AdvanceRol_de_Donde_ProvieneMultiple != null && filter.AdvanceRol_de_Donde_ProvieneMultiple.Count() > 0)
            {
                var Rol_de_Donde_ProvieneIds = string.Join(",", filter.AdvanceRol_de_Donde_ProvieneMultiple);

                where += " AND Diligencias.Rol_de_Donde_Proviene In (" + Rol_de_Donde_ProvieneIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Diligencias.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Diligencias.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.Clave_Diligencia))
            {
                switch (filter.Clave_DiligenciaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Diligencias.Clave_Diligencia LIKE '" + filter.Clave_Diligencia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Diligencias.Clave_Diligencia LIKE '%" + filter.Clave_Diligencia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Diligencias.Clave_Diligencia = '" + filter.Clave_Diligencia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Diligencias.Clave_Diligencia LIKE '%" + filter.Clave_Diligencia + "%'";
                        break;
                }
            }


            where = new Regex(Regex.Escape("AND ")).Replace(where, "", 1);
            return where;
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
                _IDiligenciasApiConsumer.SetAuthHeader(_tokenManager.Token);

                Diligencias varDiligencias = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IDiligenciasApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, DiligenciasModel varDiligencias)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDiligenciasApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var DiligenciasInfo = new Diligencias
                    {
                        Clave = varDiligencias.Clave
                        ,Fecha_de_Registro = (!String.IsNullOrEmpty(varDiligencias.Fecha_de_Registro)) ? DateTime.ParseExact(varDiligencias.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Registro = varDiligencias.Hora_de_Registro
                        ,Servicio = varDiligencias.Servicio
                        ,Especialista = varDiligencias.Especialista
                        ,Estatus_del_Dictamen = varDiligencias.Estatus_del_Dictamen
                        ,Fecha_del_Dictamen = (!String.IsNullOrEmpty(varDiligencias.Fecha_del_Dictamen)) ? DateTime.ParseExact(varDiligencias.Fecha_del_Dictamen, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Dictamen = varDiligencias.Dictamen
                        ,Rol_de_Donde_Proviene = varDiligencias.Rol_de_Donde_Proviene
                        ,Clave_Diligencia = varDiligencias.Clave_Diligencia

                    };

                    result = !IsNew ?
                        _IDiligenciasApiConsumer.Update(DiligenciasInfo, null, null).Resource.ToString() :
                         _IDiligenciasApiConsumer.Insert(DiligenciasInfo, null, null).Resource.ToString();
					Session["KeyValueInserted"] = result;
                    return Json(result, JsonRequestBehavior.AllowGet);
				//}
				//return Json(false, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }



        /// <summary>
        /// Write Element Array of Diligencias script
        /// </summary>
        /// <param name="oDiligenciasElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew DiligenciasModuleAttributeList)
        {
            for (int i = 0; i < DiligenciasModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(DiligenciasModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    DiligenciasModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(DiligenciasModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    DiligenciasModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (DiligenciasModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < DiligenciasModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < DiligenciasModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(DiligenciasModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							DiligenciasModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(DiligenciasModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							DiligenciasModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strDiligenciasScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Diligencias.js")))
            {
                strDiligenciasScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Diligencias element attributes
            string userChangeJson = jsSerialize.Serialize(DiligenciasModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDiligenciasScript.IndexOf("inpuElementArray");
            string splittedString = strDiligenciasScript.Substring(indexOfArray, strDiligenciasScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(DiligenciasModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (DiligenciasModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDiligenciasScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strDiligenciasScript.Substring(indexOfArrayHistory, strDiligenciasScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strDiligenciasScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDiligenciasScript.Substring(endIndexOfMainElement + indexOfArray, strDiligenciasScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (DiligenciasModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in DiligenciasModuleAttributeList.ChildModuleAttributeList)
                {
				if (item!= null && item.elements != null  && item.elements.Count>0)
                    ResponseChild += "\r\n  \n\r function set" + item.table + "Validation() { " +
                                    " \r\n var inpuElementChildArray =" + jsSerialize.Serialize(item.elements) + ";" +
                                    "  \r\n setInputEntityAttributes(inpuElementChildArray, \".\", 0);" +
                                    "  \r\n setDynamicRenderElement(); \n\r } ";

                }
            }
            finalResponse = finalResponse.Substring(0, finalResponse.IndexOf("});") + 4) +  "\n\r";
            finalResponse += ResponseChild;
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Diligencias.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Diligencias.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Diligencias.js")))
                {
                    strCustomScript = r.ReadToEnd();
                
                }

                int indexOfArray = strCustomScript.IndexOf("inpuElementArray");
                string splittedString = strCustomScript.Substring(indexOfArray, strCustomScript.Length - indexOfArray);                
                int indexOfMainElement = splittedString.IndexOf('[');                
                int endIndexOfMainElement = splittedString.IndexOf(']') + 1;                
                string mainJsonArray = splittedString.Substring(indexOfMainElement, endIndexOfMainElement - indexOfMainElement);

                int indexOfChildArray = strCustomScript.IndexOf("function set");
                string childJsonArray = "[";
                if (indexOfChildArray != -1)
                {
                    string splittedChildString = strCustomScript.Substring(indexOfChildArray, strCustomScript.Length - indexOfChildArray);

                    var funcionsValidations = splittedChildString.Split(new string[] { "function" }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (var str in funcionsValidations)
                    {
                        var tabla = str.Substring(0, str.IndexOf('('));
                        tabla = tabla.Trim().Replace("set", string.Empty).Replace("Validation", string.Empty);
                        childJsonArray += "{ \"table\": \"" + tabla + "\", \"elements\":";
                        int indexOfChildElement = str.IndexOf('[');
                        int endIndexOfChildElement = str.IndexOf(']') + 1;
                        childJsonArray += str.Substring(indexOfChildElement, endIndexOfChildElement - indexOfChildElement) + "},";
                    }
                }
                childJsonArray = childJsonArray.TrimEnd(',') + "]";
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
        public ActionResult DiligenciasPropertyBag()
        {
            return PartialView("DiligenciasPropertyBag", "Diligencias");
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
        public FileStreamResult PrintFormats(int idFormat, string RecordId)
        {
            if (!_tokenManager.GenerateToken())
                return null;

            _IGeneratePDFApiConsumer.SetAuthHeader(_tokenManager.Token);
            _ISpartan_FormatRelatedApiConsumer.SetAuthHeader(_tokenManager.Token);

            MemoryStream ms = new MemoryStream();
           
            //Buscar los Formatos Relacionados
            var relacionados = _ISpartan_FormatRelatedApiConsumer.ListaSelAll(0, 5000, "Spartan_Format_Related.FormatId = " + idFormat, "").Resource.Spartan_Format_Relateds.OrderBy(r => r.Order).ToList();
            if (relacionados.Count > 0)
            {
                var outputDocument = new iTextSharp.text.Document();
                var writer = new PdfCopy(outputDocument, ms);
                outputDocument.Open();
                foreach (var spartan_Format_Related in relacionados)
                {
                    var bytePdf = _IGeneratePDFApiConsumer.GeneratePDF(Convert.ToInt32(spartan_Format_Related.FormatId_Related), RecordId).Resource;
                    var reader = new PdfReader(bytePdf);
                    for (var j = 1; j <= reader.NumberOfPages; j++)
                    {
                        writer.AddPage(writer.GetImportedPage(reader, j));
                    }
                    writer.FreeReader(reader);
                    reader.Close();
                }
                writer.Close();
                outputDocument.Close();
                var allPagesContent = ms.GetBuffer();
                ms.Flush();
            }
            else {
                var bytePdf = _IGeneratePDFApiConsumer.GeneratePDF(idFormat, RecordId);
                ms.Write(bytePdf.Resource, 0, bytePdf.Resource.Length);           
            }
                
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=Formatos.pdf");
            Response.Buffer = true;
            Response.Clear();
            Response.OutputStream.Write(ms.GetBuffer(), 0, ms.GetBuffer().Length);
            Response.OutputStream.Flush();
            Response.End();

            return new FileStreamResult(Response.OutputStream, "application/pdf");
        }
		
		
		
		[HttpGet]
        public ActionResult GetFormats(string RecordId)
        {
            if (!_tokenManager.GenerateToken())
                return null;

            var formatList = new List<SelectListItem>();

            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);
            _ISpartan_Format_PermissionsApiConsumer.SetAuthHeader(_tokenManager.Token);
           _ISpartan_FormatApiConsumer.SetAuthHeader(_tokenManager.Token);

            var whereClause = " Spartan_Format_Permissions.Spartan_User_Role = " + SessionHelper.Role + " AND Spartan_Format_Permissions.Permission_Type = 1 AND Apply=1 ";
            var formatsPermisions = _ISpartan_Format_PermissionsApiConsumer.ListaSelAll(0, 500, whereClause, string.Empty).Resource;
            if (formatsPermisions.RowCount > 0)
            {
                var formats = string.Join(",", formatsPermisions.Spartan_Format_Permissionss.Select(f => f.Format).ToArray());
                var whereClauseFormat = "Object = 45176 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IDiligenciasApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Diligencias.Clave= " + RecordId;
                            var result = _IDiligenciasApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
                            if (result != null && result.Resource != null && result.Resource.RowCount > 0)
                            {
                                formatList.Add(new SelectListItem
                                {
                                    Text =  CultureHelper.GetTraductionAdd(format.FormatId.ToString(), "Format", format.Format_Name),
                                    Value = Convert.ToString(format.FormatId)
                                });
                            }
                        }
                        else
                        {
                            formatList.Add(new SelectListItem
                            {
                                Text =  CultureHelper.GetTraductionAdd(format.FormatId.ToString(), "Format", format.Format_Name),
                                Value = Convert.ToString(format.FormatId)
                            });
                        }


                    }
                }
            }
            return Json(formatList, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public void Export(string format, int pageIndex, int pageSize, string iSortCol, string sSortDir, string where, string order, dynamic columnsVisible)
        {
            var exportFormatType = (ExportFormatType)Enum.Parse(
                                          typeof(ExportFormatType), format, true);
										  
			string[] arrayColumnsVisible = ((string[])columnsVisible)[0].ToString().Split(',');

			 where = HttpUtility.UrlEncode(where);
            if (!_tokenManager.GenerateToken())
                return;

            _IDiligenciasApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new DiligenciasPropertyMapper());
			
			 if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
            if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            //Adding Advance Search
            if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (DiligenciasAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            DiligenciasPropertyMapper oDiligenciasPropertyMapper = new DiligenciasPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oDiligenciasPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDiligenciasApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Diligenciass == null)
                result.Diligenciass = new List<Diligencias>();

            var data = result.Diligenciass.Select(m => new DiligenciasGridModel
            {
                Clave = m.Clave
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,ServicioServicio = CultureHelper.GetTraduction(m.Servicio_Servicios_Periciales.Clave.ToString(), "Servicio") ?? (string)m.Servicio_Servicios_Periciales.Servicio
			,Especialista = m.Especialista
                        ,Estatus_del_DictamenDescripcion = CultureHelper.GetTraduction(m.Estatus_del_Dictamen_Estatus_del_Dictamen.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_del_Dictamen_Estatus_del_Dictamen.Descripcion
                        ,Fecha_del_Dictamen = (m.Fecha_del_Dictamen == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Dictamen).ToString(ConfigurationProperty.DateFormat))
			,Dictamen = m.Dictamen
                        ,Rol_de_Donde_ProvieneDescripcion = CultureHelper.GetTraduction(m.Rol_de_Donde_Proviene_Rol_de_Diligencia.Clave.ToString(), "Descripcion") ?? (string)m.Rol_de_Donde_Proviene_Rol_de_Diligencia.Descripcion
			,Clave_Diligencia = m.Clave_Diligencia

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45176, arrayColumnsVisible), "DiligenciasList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45176, arrayColumnsVisible), "DiligenciasList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45176, arrayColumnsVisible), "DiligenciasList_" + DateTime.Now.ToString());
                    break;
            }
        }

        [HttpGet]
        //[ObjectAuth(ObjectId = ModuleObjectId.EMPLEADOS_OBJECT, PermissionType = PermissionTypes.Export)]
        public ActionResult Print(string format, int pageIndex, int pageSize, string iSortCol, string sSortDir,string where, string order)
        {
            var exportFormatType = (ExportFormatType)Enum.Parse(
                                          typeof(ExportFormatType), format, true);

			where = HttpUtility.UrlEncode(where);
										   
            if (!_tokenManager.GenerateToken())
                return null;

            _IDiligenciasApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new DiligenciasPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (DiligenciasAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            DiligenciasPropertyMapper oDiligenciasPropertyMapper = new DiligenciasPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oDiligenciasPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDiligenciasApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Diligenciass == null)
                result.Diligenciass = new List<Diligencias>();

            var data = result.Diligenciass.Select(m => new DiligenciasGridModel
            {
                Clave = m.Clave
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,ServicioServicio = CultureHelper.GetTraduction(m.Servicio_Servicios_Periciales.Clave.ToString(), "Servicio") ?? (string)m.Servicio_Servicios_Periciales.Servicio
			,Especialista = m.Especialista
                        ,Estatus_del_DictamenDescripcion = CultureHelper.GetTraduction(m.Estatus_del_Dictamen_Estatus_del_Dictamen.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_del_Dictamen_Estatus_del_Dictamen.Descripcion
                        ,Fecha_del_Dictamen = (m.Fecha_del_Dictamen == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Dictamen).ToString(ConfigurationProperty.DateFormat))
			,Dictamen = m.Dictamen
                        ,Rol_de_Donde_ProvieneDescripcion = CultureHelper.GetTraduction(m.Rol_de_Donde_Proviene_Rol_de_Diligencia.Clave.ToString(), "Descripcion") ?? (string)m.Rol_de_Donde_Proviene_Rol_de_Diligencia.Descripcion
			,Clave_Diligencia = m.Clave_Diligencia

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
		
		[HttpGet]
        public JsonResult CreateID()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDiligenciasApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDiligenciasApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Diligencias_Datos_GeneralesModel varDiligencias)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDiligenciasApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Diligencias_Datos_GeneralesInfo = new Diligencias_Datos_Generales
                {
                    Clave = varDiligencias.Clave
                                            ,Fecha_de_Registro = (!String.IsNullOrEmpty(varDiligencias.Fecha_de_Registro)) ? DateTime.ParseExact(varDiligencias.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Registro = varDiligencias.Hora_de_Registro
                        ,Servicio = varDiligencias.Servicio
                        ,Especialista = varDiligencias.Especialista
                        ,Estatus_del_Dictamen = varDiligencias.Estatus_del_Dictamen
                        ,Fecha_del_Dictamen = (!String.IsNullOrEmpty(varDiligencias.Fecha_del_Dictamen)) ? DateTime.ParseExact(varDiligencias.Fecha_del_Dictamen, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Dictamen = varDiligencias.Dictamen
                        ,Rol_de_Donde_Proviene = varDiligencias.Rol_de_Donde_Proviene
                        ,Clave_Diligencia = varDiligencias.Clave_Diligencia
                    
                };

                result = _IDiligenciasApiConsumer.Update_Datos_Generales(Diligencias_Datos_GeneralesInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Datos_Generales(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDiligenciasApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IDiligenciasApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Diligencias_Datos_GeneralesModel
                {
                    Clave = m.Clave
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Servicio = m.Servicio
                        ,ServicioServicio = CultureHelper.GetTraduction(m.Servicio_Servicios_Periciales.Clave.ToString(), "Servicio") ?? (string)m.Servicio_Servicios_Periciales.Servicio
			,Especialista = m.Especialista
                        ,Estatus_del_Dictamen = m.Estatus_del_Dictamen
                        ,Estatus_del_DictamenDescripcion = CultureHelper.GetTraduction(m.Estatus_del_Dictamen_Estatus_del_Dictamen.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_del_Dictamen_Estatus_del_Dictamen.Descripcion
                        ,Fecha_del_Dictamen = (m.Fecha_del_Dictamen == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Dictamen).ToString(ConfigurationProperty.DateFormat))
			,Dictamen = m.Dictamen
                        ,Rol_de_Donde_Proviene = m.Rol_de_Donde_Proviene
                        ,Rol_de_Donde_ProvieneDescripcion = CultureHelper.GetTraduction(m.Rol_de_Donde_Proviene_Rol_de_Diligencia.Clave.ToString(), "Descripcion") ?? (string)m.Rol_de_Donde_Proviene_Rol_de_Diligencia.Descripcion
			,Clave_Diligencia = m.Clave_Diligencia

                    
                };
				var resultData = new
                {
                    data = result

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }


    }
}

