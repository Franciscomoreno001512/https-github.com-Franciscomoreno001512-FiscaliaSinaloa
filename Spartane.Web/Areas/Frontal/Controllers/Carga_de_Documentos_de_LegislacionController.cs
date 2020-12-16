using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Carga_de_Documentos_de_Legislacion;
using Spartane.Core.Domain.Estatus_de_Documento;
using Spartane.Core.Domain.Estatus_de_Actualizacion_de_Documento;
using Spartane.Core.Domain.Detalle_de_Documentos_de_Legislacion;


using Spartane.Core.Domain.Estatus_Detalle_Documentos_Legislacion;


using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Carga_de_Documentos_de_Legislacion;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Carga_de_Documentos_de_Legislacion;
using Spartane.Web.Areas.WebApiConsumer.Estatus_de_Documento;
using Spartane.Web.Areas.WebApiConsumer.Estatus_de_Actualizacion_de_Documento;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Documentos_de_Legislacion;

using Spartane.Web.Areas.WebApiConsumer.Estatus_Detalle_Documentos_Legislacion;


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
    public class Carga_de_Documentos_de_LegislacionController : Controller
    {
        #region "variable declaration"

        private ICarga_de_Documentos_de_LegislacionService service = null;
        private ICarga_de_Documentos_de_LegislacionApiConsumer _ICarga_de_Documentos_de_LegislacionApiConsumer;
        private IEstatus_de_DocumentoApiConsumer _IEstatus_de_DocumentoApiConsumer;
        private IEstatus_de_Actualizacion_de_DocumentoApiConsumer _IEstatus_de_Actualizacion_de_DocumentoApiConsumer;
        private IDetalle_de_Documentos_de_LegislacionApiConsumer _IDetalle_de_Documentos_de_LegislacionApiConsumer;

        private IEstatus_Detalle_Documentos_LegislacionApiConsumer _IEstatus_Detalle_Documentos_LegislacionApiConsumer;


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

        
        public Carga_de_Documentos_de_LegislacionController(ICarga_de_Documentos_de_LegislacionService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, ICarga_de_Documentos_de_LegislacionApiConsumer Carga_de_Documentos_de_LegislacionApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , IEstatus_de_DocumentoApiConsumer Estatus_de_DocumentoApiConsumer , IEstatus_de_Actualizacion_de_DocumentoApiConsumer Estatus_de_Actualizacion_de_DocumentoApiConsumer , IDetalle_de_Documentos_de_LegislacionApiConsumer Detalle_de_Documentos_de_LegislacionApiConsumer , IEstatus_Detalle_Documentos_LegislacionApiConsumer Estatus_Detalle_Documentos_LegislacionApiConsumer
 )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._ICarga_de_Documentos_de_LegislacionApiConsumer = Carga_de_Documentos_de_LegislacionApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_FormatApiConsumer = Spartan_FormatApiConsumer;
            this._ISpartan_Format_PermissionsApiConsumer = Spartan_Format_PermissionsApiConsumer;
            this._IGeneratePDFApiConsumer = GeneratePDFApiConsumer;
			this._ISpartan_FormatRelatedApiConsumer = Spartan_Format_RelatedApiConsumer;
            this._IEstatus_de_DocumentoApiConsumer = Estatus_de_DocumentoApiConsumer;
            this._IEstatus_de_Actualizacion_de_DocumentoApiConsumer = Estatus_de_Actualizacion_de_DocumentoApiConsumer;
            this._IDetalle_de_Documentos_de_LegislacionApiConsumer = Detalle_de_Documentos_de_LegislacionApiConsumer;

            this._IEstatus_Detalle_Documentos_LegislacionApiConsumer = Estatus_Detalle_Documentos_LegislacionApiConsumer;


        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Carga_de_Documentos_de_Legislacion
        [ObjectAuth(ObjectId = (ModuleObjectId)45205, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45205, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Carga_de_Documentos_de_Legislacion/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45205, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45205, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varCarga_de_Documentos_de_Legislacion = new Carga_de_Documentos_de_LegislacionModel();
			varCarga_de_Documentos_de_Legislacion.Folio = Id;
			
            ViewBag.ObjectId = "45205";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;

            var permissionDetalle_de_Documentos_de_Legislacion = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45214, ModuleId);
            ViewBag.PermissionDetalle_de_Documentos_de_Legislacion = permissionDetalle_de_Documentos_de_Legislacion; 

            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _ICarga_de_Documentos_de_LegislacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Carga_de_Documentos_de_LegislacionsData = _ICarga_de_Documentos_de_LegislacionApiConsumer.ListaSelAll(0, 1000, "Carga_de_Documentos_de_Legislacion.Folio=" + Id, "").Resource.Carga_de_Documentos_de_Legislacions;
				
				if (Carga_de_Documentos_de_LegislacionsData != null && Carga_de_Documentos_de_LegislacionsData.Count > 0)
                {
					var Carga_de_Documentos_de_LegislacionData = Carga_de_Documentos_de_LegislacionsData.First();
					varCarga_de_Documentos_de_Legislacion= new Carga_de_Documentos_de_LegislacionModel
					{
						Folio  = Carga_de_Documentos_de_LegislacionData.Folio 
	                    ,Nombre = Carga_de_Documentos_de_LegislacionData.Nombre
                    ,Descripcion = Carga_de_Documentos_de_LegislacionData.Descripcion
                    ,Adjuntar_Documento = Carga_de_Documentos_de_LegislacionData.Adjuntar_Documento
                    ,Estatus = Carga_de_Documentos_de_LegislacionData.Estatus
                    ,EstatusDescripcion = CultureHelper.GetTraduction(Convert.ToString(Carga_de_Documentos_de_LegislacionData.Estatus), "Estatus_de_Documento") ??  (string)Carga_de_Documentos_de_LegislacionData.Estatus_Estatus_de_Documento.Descripcion
                    ,Estatus_de_Actualizacion = Carga_de_Documentos_de_LegislacionData.Estatus_de_Actualizacion
                    ,Estatus_de_ActualizacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Carga_de_Documentos_de_LegislacionData.Estatus_de_Actualizacion), "Estatus_de_Actualizacion_de_Documento") ??  (string)Carga_de_Documentos_de_LegislacionData.Estatus_de_Actualizacion_Estatus_de_Actualizacion_de_Documento.Descripcion

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IEstatus_de_DocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_de_Documentos_Estatus = _IEstatus_de_DocumentoApiConsumer.SelAll(true);
            if (Estatus_de_Documentos_Estatus != null && Estatus_de_Documentos_Estatus.Resource != null)
                ViewBag.Estatus_de_Documentos_Estatus = Estatus_de_Documentos_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Documento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();             _IEstatus_de_Actualizacion_de_DocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_de_Actualizacion_de_Documentos_Estatus_de_Actualizacion = _IEstatus_de_Actualizacion_de_DocumentoApiConsumer.SelAll(true);
            if (Estatus_de_Actualizacion_de_Documentos_Estatus_de_Actualizacion != null && Estatus_de_Actualizacion_de_Documentos_Estatus_de_Actualizacion.Resource != null)
                ViewBag.Estatus_de_Actualizacion_de_Documentos_Estatus_de_Actualizacion = Estatus_de_Actualizacion_de_Documentos_Estatus_de_Actualizacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Actualizacion_de_Documento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varCarga_de_Documentos_de_Legislacion);
        }
		
	[HttpGet]
        public ActionResult AddCarga_de_Documentos_de_Legislacion(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45205);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _ICarga_de_Documentos_de_LegislacionApiConsumer.SetAuthHeader(_tokenManager.Token);
			Carga_de_Documentos_de_LegislacionModel varCarga_de_Documentos_de_Legislacion= new Carga_de_Documentos_de_LegislacionModel();
            var permissionDetalle_de_Documentos_de_Legislacion = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45214, ModuleId);
            ViewBag.PermissionDetalle_de_Documentos_de_Legislacion = permissionDetalle_de_Documentos_de_Legislacion; 

            if (id.ToString() != "0")
            {
                var Carga_de_Documentos_de_LegislacionsData = _ICarga_de_Documentos_de_LegislacionApiConsumer.ListaSelAll(0, 1000, "Carga_de_Documentos_de_Legislacion.Folio=" + id, "").Resource.Carga_de_Documentos_de_Legislacions;
				
				if (Carga_de_Documentos_de_LegislacionsData != null && Carga_de_Documentos_de_LegislacionsData.Count > 0)
                {
					var Carga_de_Documentos_de_LegislacionData = Carga_de_Documentos_de_LegislacionsData.First();
					varCarga_de_Documentos_de_Legislacion= new Carga_de_Documentos_de_LegislacionModel
					{
						Folio  = Carga_de_Documentos_de_LegislacionData.Folio 
	                    ,Nombre = Carga_de_Documentos_de_LegislacionData.Nombre
                    ,Descripcion = Carga_de_Documentos_de_LegislacionData.Descripcion
                    ,Adjuntar_Documento = Carga_de_Documentos_de_LegislacionData.Adjuntar_Documento
                    ,Estatus = Carga_de_Documentos_de_LegislacionData.Estatus
                    ,EstatusDescripcion = CultureHelper.GetTraduction(Convert.ToString(Carga_de_Documentos_de_LegislacionData.Estatus), "Estatus_de_Documento") ??  (string)Carga_de_Documentos_de_LegislacionData.Estatus_Estatus_de_Documento.Descripcion
                    ,Estatus_de_Actualizacion = Carga_de_Documentos_de_LegislacionData.Estatus_de_Actualizacion
                    ,Estatus_de_ActualizacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Carga_de_Documentos_de_LegislacionData.Estatus_de_Actualizacion), "Estatus_de_Actualizacion_de_Documento") ??  (string)Carga_de_Documentos_de_LegislacionData.Estatus_de_Actualizacion_Estatus_de_Actualizacion_de_Documento.Descripcion

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IEstatus_de_DocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_de_Documentos_Estatus = _IEstatus_de_DocumentoApiConsumer.SelAll(true);
            if (Estatus_de_Documentos_Estatus != null && Estatus_de_Documentos_Estatus.Resource != null)
                ViewBag.Estatus_de_Documentos_Estatus = Estatus_de_Documentos_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Documento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();             _IEstatus_de_Actualizacion_de_DocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_de_Actualizacion_de_Documentos_Estatus_de_Actualizacion = _IEstatus_de_Actualizacion_de_DocumentoApiConsumer.SelAll(true);
            if (Estatus_de_Actualizacion_de_Documentos_Estatus_de_Actualizacion != null && Estatus_de_Actualizacion_de_Documentos_Estatus_de_Actualizacion.Resource != null)
                ViewBag.Estatus_de_Actualizacion_de_Documentos_Estatus_de_Actualizacion = Estatus_de_Actualizacion_de_Documentos_Estatus_de_Actualizacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Actualizacion_de_Documento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList(); 

            return PartialView("AddCarga_de_Documentos_de_Legislacion", varCarga_de_Documentos_de_Legislacion);
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
        public ActionResult GetEstatus_de_DocumentoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstatus_de_DocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstatus_de_DocumentoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Documento", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetEstatus_de_Actualizacion_de_DocumentoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstatus_de_Actualizacion_de_DocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstatus_de_Actualizacion_de_DocumentoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Actualizacion_de_Documento", "Descripcion")?? m.Descripcion,
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
        public ActionResult ShowAdvanceFilter(Carga_de_Documentos_de_LegislacionAdvanceSearchModel model, int idFilter = -1)
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

            _IEstatus_de_DocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_de_Documentos_Estatus = _IEstatus_de_DocumentoApiConsumer.SelAll(true);
            if (Estatus_de_Documentos_Estatus != null && Estatus_de_Documentos_Estatus.Resource != null)
                ViewBag.Estatus_de_Documentos_Estatus = Estatus_de_Documentos_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Documento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();             _IEstatus_de_Actualizacion_de_DocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_de_Actualizacion_de_Documentos_Estatus_de_Actualizacion = _IEstatus_de_Actualizacion_de_DocumentoApiConsumer.SelAll(true);
            if (Estatus_de_Actualizacion_de_Documentos_Estatus_de_Actualizacion != null && Estatus_de_Actualizacion_de_Documentos_Estatus_de_Actualizacion.Resource != null)
                ViewBag.Estatus_de_Actualizacion_de_Documentos_Estatus_de_Actualizacion = Estatus_de_Actualizacion_de_Documentos_Estatus_de_Actualizacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Actualizacion_de_Documento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList(); 

            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IEstatus_de_DocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_de_Documentos_Estatus = _IEstatus_de_DocumentoApiConsumer.SelAll(true);
            if (Estatus_de_Documentos_Estatus != null && Estatus_de_Documentos_Estatus.Resource != null)
                ViewBag.Estatus_de_Documentos_Estatus = Estatus_de_Documentos_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Documento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();             _IEstatus_de_Actualizacion_de_DocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_de_Actualizacion_de_Documentos_Estatus_de_Actualizacion = _IEstatus_de_Actualizacion_de_DocumentoApiConsumer.SelAll(true);
            if (Estatus_de_Actualizacion_de_Documentos_Estatus_de_Actualizacion != null && Estatus_de_Actualizacion_de_Documentos_Estatus_de_Actualizacion.Resource != null)
                ViewBag.Estatus_de_Actualizacion_de_Documentos_Estatus_de_Actualizacion = Estatus_de_Actualizacion_de_Documentos_Estatus_de_Actualizacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Actualizacion_de_Documento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList(); 

            var previousFiltersObj = new Carga_de_Documentos_de_LegislacionAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Carga_de_Documentos_de_LegislacionAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Carga_de_Documentos_de_LegislacionAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Carga_de_Documentos_de_LegislacionPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _ICarga_de_Documentos_de_LegislacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Carga_de_Documentos_de_Legislacions == null)
                result.Carga_de_Documentos_de_Legislacions = new List<Carga_de_Documentos_de_Legislacion>();

            return Json(new
            {
                data = result.Carga_de_Documentos_de_Legislacions.Select(m => new Carga_de_Documentos_de_LegislacionGridModel
                    {
                    Folio = m.Folio
			,Nombre = m.Nombre
			,Descripcion = m.Descripcion
			,Adjuntar_Documento = m.Adjuntar_Documento
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_de_Documento.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_de_Documento.Descripcion
                        ,Estatus_de_ActualizacionDescripcion = CultureHelper.GetTraduction(m.Estatus_de_Actualizacion_Estatus_de_Actualizacion_de_Documento.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_de_Actualizacion_Estatus_de_Actualizacion_de_Documento.Descripcion

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetCarga_de_Documentos_de_LegislacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICarga_de_Documentos_de_LegislacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICarga_de_Documentos_de_LegislacionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Folio), "Carga_de_Documentos_de_Legislacion", m.),
                     Value = Convert.ToString(m.Folio)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
*/
        /// <summary>
        /// Get List of Carga_de_Documentos_de_Legislacion from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Carga_de_Documentos_de_Legislacion Entity</returns>
        public ActionResult GetCarga_de_Documentos_de_LegislacionList(UrlParametersModel param)
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
            _ICarga_de_Documentos_de_LegislacionApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Carga_de_Documentos_de_LegislacionPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Carga_de_Documentos_de_LegislacionAdvanceSearchModel))
                {
					var advanceFilter =
                    (Carga_de_Documentos_de_LegislacionAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Carga_de_Documentos_de_LegislacionPropertyMapper oCarga_de_Documentos_de_LegislacionPropertyMapper = new Carga_de_Documentos_de_LegislacionPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oCarga_de_Documentos_de_LegislacionPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _ICarga_de_Documentos_de_LegislacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Carga_de_Documentos_de_Legislacions == null)
                result.Carga_de_Documentos_de_Legislacions = new List<Carga_de_Documentos_de_Legislacion>();

            return Json(new
            {
                aaData = result.Carga_de_Documentos_de_Legislacions.Select(m => new Carga_de_Documentos_de_LegislacionGridModel
            {
                    Folio = m.Folio
			,Nombre = m.Nombre
			,Descripcion = m.Descripcion
			,Adjuntar_Documento = m.Adjuntar_Documento
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_de_Documento.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_de_Documento.Descripcion
                        ,Estatus_de_ActualizacionDescripcion = CultureHelper.GetTraduction(m.Estatus_de_Actualizacion_Estatus_de_Actualizacion_de_Documento.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_de_Actualizacion_Estatus_de_Actualizacion_de_Documento.Descripcion

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


//Grid GetAutoComplete






        [NonAction]
        public string GetAdvanceFilter(Carga_de_Documentos_de_LegislacionAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromFolio) || !string.IsNullOrEmpty(filter.ToFolio))
            {
                if (!string.IsNullOrEmpty(filter.FromFolio))
                    where += " AND Carga_de_Documentos_de_Legislacion.Folio >= " + filter.FromFolio;
                if (!string.IsNullOrEmpty(filter.ToFolio))
                    where += " AND Carga_de_Documentos_de_Legislacion.Folio <= " + filter.ToFolio;
            }

            if (!string.IsNullOrEmpty(filter.Nombre))
            {
                switch (filter.NombreFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Carga_de_Documentos_de_Legislacion.Nombre LIKE '" + filter.Nombre + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Carga_de_Documentos_de_Legislacion.Nombre LIKE '%" + filter.Nombre + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Carga_de_Documentos_de_Legislacion.Nombre = '" + filter.Nombre + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Carga_de_Documentos_de_Legislacion.Nombre LIKE '%" + filter.Nombre + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Descripcion))
            {
                switch (filter.DescripcionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Carga_de_Documentos_de_Legislacion.Descripcion LIKE '" + filter.Descripcion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Carga_de_Documentos_de_Legislacion.Descripcion LIKE '%" + filter.Descripcion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Carga_de_Documentos_de_Legislacion.Descripcion = '" + filter.Descripcion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Carga_de_Documentos_de_Legislacion.Descripcion LIKE '%" + filter.Descripcion + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromAdjuntar_Documento) || !string.IsNullOrEmpty(filter.ToAdjuntar_Documento))
            {
                if (!string.IsNullOrEmpty(filter.FromAdjuntar_Documento))
                    where += " AND Carga_de_Documentos_de_Legislacion.Adjuntar_Documento >= " + filter.FromAdjuntar_Documento;
                if (!string.IsNullOrEmpty(filter.ToAdjuntar_Documento))
                    where += " AND Carga_de_Documentos_de_Legislacion.Adjuntar_Documento <= " + filter.ToAdjuntar_Documento;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstatus))
            {
                switch (filter.EstatusFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estatus_de_Documento.Descripcion LIKE '" + filter.AdvanceEstatus + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estatus_de_Documento.Descripcion LIKE '%" + filter.AdvanceEstatus + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estatus_de_Documento.Descripcion = '" + filter.AdvanceEstatus + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estatus_de_Documento.Descripcion LIKE '%" + filter.AdvanceEstatus + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstatusMultiple != null && filter.AdvanceEstatusMultiple.Count() > 0)
            {
                var EstatusIds = string.Join(",", filter.AdvanceEstatusMultiple);

                where += " AND Carga_de_Documentos_de_Legislacion.Estatus In (" + EstatusIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstatus_de_Actualizacion))
            {
                switch (filter.Estatus_de_ActualizacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estatus_de_Actualizacion_de_Documento.Descripcion LIKE '" + filter.AdvanceEstatus_de_Actualizacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estatus_de_Actualizacion_de_Documento.Descripcion LIKE '%" + filter.AdvanceEstatus_de_Actualizacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estatus_de_Actualizacion_de_Documento.Descripcion = '" + filter.AdvanceEstatus_de_Actualizacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estatus_de_Actualizacion_de_Documento.Descripcion LIKE '%" + filter.AdvanceEstatus_de_Actualizacion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstatus_de_ActualizacionMultiple != null && filter.AdvanceEstatus_de_ActualizacionMultiple.Count() > 0)
            {
                var Estatus_de_ActualizacionIds = string.Join(",", filter.AdvanceEstatus_de_ActualizacionMultiple);

                where += " AND Carga_de_Documentos_de_Legislacion.Estatus_de_Actualizacion In (" + Estatus_de_ActualizacionIds + ")";
            }


            where = new Regex(Regex.Escape("AND ")).Replace(where, "", 1);
            return where;
        }

        [NonAction]
        public Grid_File ConvertSpartane_FileToGridFile(Spartane.Core.Domain.Spartane_File.Spartane_File file)
        {
            return file == null ? new Grid_File { FileId = 0, FileSize = 0, FileName = "" } : new Grid_File { FileId = file.File_Id, FileName = file.Description, FileSize = file.File_Size ?? 0, };
        }

        public ActionResult GetDetalle_de_Documentos_de_Legislacion(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_Documentos_de_LegislacionGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Documentos_de_LegislacionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_Documentos_de_Legislacion.Documentos_de_Legislacion=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_Documentos_de_Legislacion.Documentos_de_Legislacion='" + RelationId + "'";
            }
            var result = _IDetalle_de_Documentos_de_LegislacionApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_Documentos_de_Legislacions == null)
                result.Detalle_de_Documentos_de_Legislacions = new List<Detalle_de_Documentos_de_Legislacion>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_Documentos_de_Legislacions.Select(m => new Detalle_de_Documentos_de_LegislacionGridModel
                {
                    Clave = m.Clave

			,ID_de_Dispositivo = m.ID_de_Dispositivo
                        ,Estatus = m.Estatus
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_Detalle_Documentos_Legislacion.Clave.ToString(), "Descripcion") ??(string)m.Estatus_Estatus_Detalle_Documentos_Legislacion.Descripcion

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_Documentos_de_LegislacionGridModel> GetDetalle_de_Documentos_de_LegislacionData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_Documentos_de_LegislacionGridModel> resultData = new List<Detalle_de_Documentos_de_LegislacionGridModel>();
            string where = "Detalle_de_Documentos_de_Legislacion.Documentos_de_Legislacion=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_Documentos_de_Legislacion.Documentos_de_Legislacion='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Documentos_de_LegislacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_Documentos_de_LegislacionApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_Documentos_de_Legislacions != null)
            {
                resultData = result.Detalle_de_Documentos_de_Legislacions.Select(m => new Detalle_de_Documentos_de_LegislacionGridModel
                    {
                        Clave = m.Clave

			,ID_de_Dispositivo = m.ID_de_Dispositivo
                        ,Estatus = m.Estatus
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_Detalle_Documentos_Legislacion.Clave.ToString(), "Descripcion") ??(string)m.Estatus_Estatus_Detalle_Documentos_Legislacion.Descripcion


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }


        [HttpDelete]
        public ActionResult Delete(int id)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICarga_de_Documentos_de_LegislacionApiConsumer.SetAuthHeader(_tokenManager.Token);

                Carga_de_Documentos_de_Legislacion varCarga_de_Documentos_de_Legislacion = null;
                if (id.ToString() != "0")
                {
                        string where = "";
                    _IDetalle_de_Documentos_de_LegislacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_Documentos_de_Legislacion.Documentos_de_Legislacion=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_Documentos_de_Legislacion.Documentos_de_Legislacion='" + id + "'";
                    }
                    var Detalle_de_Documentos_de_LegislacionInfo =
                        _IDetalle_de_Documentos_de_LegislacionApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_Documentos_de_LegislacionInfo.Detalle_de_Documentos_de_Legislacions.Count > 0)
                    {
                        var resultDetalle_de_Documentos_de_Legislacion = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_Documentos_de_LegislacionItem in Detalle_de_Documentos_de_LegislacionInfo.Detalle_de_Documentos_de_Legislacions)
                            resultDetalle_de_Documentos_de_Legislacion = resultDetalle_de_Documentos_de_Legislacion
                                              && _IDetalle_de_Documentos_de_LegislacionApiConsumer.Delete(Detalle_de_Documentos_de_LegislacionItem.Clave, null,null).Resource;

                        if (!resultDetalle_de_Documentos_de_Legislacion)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }

                }
                var result = _ICarga_de_Documentos_de_LegislacionApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Carga_de_Documentos_de_LegislacionModel varCarga_de_Documentos_de_Legislacion)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _ICarga_de_Documentos_de_LegislacionApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Carga_de_Documentos_de_LegislacionInfo = new Carga_de_Documentos_de_Legislacion
                    {
                        Folio = varCarga_de_Documentos_de_Legislacion.Folio
                        ,Nombre = varCarga_de_Documentos_de_Legislacion.Nombre
                        ,Descripcion = varCarga_de_Documentos_de_Legislacion.Descripcion
                        ,Adjuntar_Documento = varCarga_de_Documentos_de_Legislacion.Adjuntar_Documento
                        ,Estatus = varCarga_de_Documentos_de_Legislacion.Estatus
                        ,Estatus_de_Actualizacion = varCarga_de_Documentos_de_Legislacion.Estatus_de_Actualizacion

                    };

                    result = !IsNew ?
                        _ICarga_de_Documentos_de_LegislacionApiConsumer.Update(Carga_de_Documentos_de_LegislacionInfo, null, null).Resource.ToString() :
                         _ICarga_de_Documentos_de_LegislacionApiConsumer.Insert(Carga_de_Documentos_de_LegislacionInfo, null, null).Resource.ToString();
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

        [NonAction]
        public bool CopyDetalle_de_Documentos_de_Legislacion(int MasterId, int referenceId, List<Detalle_de_Documentos_de_LegislacionGridModelPost> Detalle_de_Documentos_de_LegislacionItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_Documentos_de_LegislacionApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_Documentos_de_LegislacionData = _IDetalle_de_Documentos_de_LegislacionApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_Documentos_de_Legislacion.Documentos_de_Legislacion=" + referenceId,"").Resource;
                if (Detalle_de_Documentos_de_LegislacionData == null || Detalle_de_Documentos_de_LegislacionData.Detalle_de_Documentos_de_Legislacions.Count == 0)
                    return true;

                var result = true;

                Detalle_de_Documentos_de_LegislacionGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_Documentos_de_Legislacion in Detalle_de_Documentos_de_LegislacionData.Detalle_de_Documentos_de_Legislacions)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_Documentos_de_Legislacion Detalle_de_Documentos_de_Legislacion1 = varDetalle_de_Documentos_de_Legislacion;

                    if (Detalle_de_Documentos_de_LegislacionItems != null && Detalle_de_Documentos_de_LegislacionItems.Any(m => m.Clave == Detalle_de_Documentos_de_Legislacion1.Clave))
                    {
                        modelDataToChange = Detalle_de_Documentos_de_LegislacionItems.FirstOrDefault(m => m.Clave == Detalle_de_Documentos_de_Legislacion1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_de_Documentos_de_Legislacion.Documentos_de_Legislacion = MasterId;
                    var insertId = _IDetalle_de_Documentos_de_LegislacionApiConsumer.Insert(varDetalle_de_Documentos_de_Legislacion,null,null).Resource;
                    if (insertId > 0 && modelDataToChange != null)
                        modelDataToChange.Clave = insertId;

                    result = insertId > 0;
                }
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult PostDetalle_de_Documentos_de_Legislacion(List<Detalle_de_Documentos_de_LegislacionGridModelPost> Detalle_de_Documentos_de_LegislacionItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_Documentos_de_Legislacion(MasterId, referenceId, Detalle_de_Documentos_de_LegislacionItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_Documentos_de_LegislacionItems != null && Detalle_de_Documentos_de_LegislacionItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_Documentos_de_LegislacionApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_Documentos_de_LegislacionItem in Detalle_de_Documentos_de_LegislacionItems)
                    {




                        //Removal Request
                        if (Detalle_de_Documentos_de_LegislacionItem.Removed)
                        {
                            result = result && _IDetalle_de_Documentos_de_LegislacionApiConsumer.Delete(Detalle_de_Documentos_de_LegislacionItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_Documentos_de_LegislacionItem.Clave = 0;

                        var Detalle_de_Documentos_de_LegislacionData = new Detalle_de_Documentos_de_Legislacion
                        {
                            Documentos_de_Legislacion = MasterId
                            ,Clave = Detalle_de_Documentos_de_LegislacionItem.Clave
                            ,ID_de_Dispositivo = Detalle_de_Documentos_de_LegislacionItem.ID_de_Dispositivo
                            ,Estatus = (Convert.ToInt32(Detalle_de_Documentos_de_LegislacionItem.Estatus) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Documentos_de_LegislacionItem.Estatus))

                        };

                        var resultId = Detalle_de_Documentos_de_LegislacionItem.Clave > 0
                           ? _IDetalle_de_Documentos_de_LegislacionApiConsumer.Update(Detalle_de_Documentos_de_LegislacionData,null,null).Resource
                           : _IDetalle_de_Documentos_de_LegislacionApiConsumer.Insert(Detalle_de_Documentos_de_LegislacionData,null,null).Resource;

                        result = result && resultId != -1;
                    }
                }
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }



        [HttpGet]
        public ActionResult GetDetalle_de_Documentos_de_Legislacion_Estatus_Detalle_Documentos_LegislacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstatus_Detalle_Documentos_LegislacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstatus_Detalle_Documentos_LegislacionApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Estatus_Detalle_Documentos_Legislacion", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }



        /// <summary>
        /// Write Element Array of Carga_de_Documentos_de_Legislacion script
        /// </summary>
        /// <param name="oCarga_de_Documentos_de_LegislacionElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Carga_de_Documentos_de_LegislacionModuleAttributeList)
        {
            for (int i = 0; i < Carga_de_Documentos_de_LegislacionModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Carga_de_Documentos_de_LegislacionModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Carga_de_Documentos_de_LegislacionModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Carga_de_Documentos_de_LegislacionModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Carga_de_Documentos_de_LegislacionModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Carga_de_Documentos_de_LegislacionModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Carga_de_Documentos_de_LegislacionModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Carga_de_Documentos_de_LegislacionModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Carga_de_Documentos_de_LegislacionModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Carga_de_Documentos_de_LegislacionModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Carga_de_Documentos_de_LegislacionModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Carga_de_Documentos_de_LegislacionModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strCarga_de_Documentos_de_LegislacionScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Carga_de_Documentos_de_Legislacion.js")))
            {
                strCarga_de_Documentos_de_LegislacionScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Carga_de_Documentos_de_Legislacion element attributes
            string userChangeJson = jsSerialize.Serialize(Carga_de_Documentos_de_LegislacionModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strCarga_de_Documentos_de_LegislacionScript.IndexOf("inpuElementArray");
            string splittedString = strCarga_de_Documentos_de_LegislacionScript.Substring(indexOfArray, strCarga_de_Documentos_de_LegislacionScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Carga_de_Documentos_de_LegislacionModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Carga_de_Documentos_de_LegislacionModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strCarga_de_Documentos_de_LegislacionScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strCarga_de_Documentos_de_LegislacionScript.Substring(indexOfArrayHistory, strCarga_de_Documentos_de_LegislacionScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strCarga_de_Documentos_de_LegislacionScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strCarga_de_Documentos_de_LegislacionScript.Substring(endIndexOfMainElement + indexOfArray, strCarga_de_Documentos_de_LegislacionScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Carga_de_Documentos_de_LegislacionModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Carga_de_Documentos_de_LegislacionModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Carga_de_Documentos_de_Legislacion.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Carga_de_Documentos_de_Legislacion.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Carga_de_Documentos_de_Legislacion.js")))
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
        public ActionResult Carga_de_Documentos_de_LegislacionPropertyBag()
        {
            return PartialView("Carga_de_Documentos_de_LegislacionPropertyBag", "Carga_de_Documentos_de_Legislacion");
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

        [HttpGet]
        public ActionResult AddDetalle_de_Documentos_de_Legislacion(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_Documentos_de_Legislacion/AddDetalle_de_Documentos_de_Legislacion");
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
                var whereClauseFormat = "Object = 45205 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _ICarga_de_Documentos_de_LegislacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Carga_de_Documentos_de_Legislacion.Folio= " + RecordId;
                            var result = _ICarga_de_Documentos_de_LegislacionApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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
										  
			string[] arrayColumnsVisible = null;

			 where = HttpUtility.UrlEncode(where);
            if (!_tokenManager.GenerateToken())
                return;

            _ICarga_de_Documentos_de_LegislacionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Carga_de_Documentos_de_LegislacionPropertyMapper());
			
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
                    (Carga_de_Documentos_de_LegislacionAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Carga_de_Documentos_de_LegislacionPropertyMapper oCarga_de_Documentos_de_LegislacionPropertyMapper = new Carga_de_Documentos_de_LegislacionPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oCarga_de_Documentos_de_LegislacionPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _ICarga_de_Documentos_de_LegislacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Carga_de_Documentos_de_Legislacions == null)
                result.Carga_de_Documentos_de_Legislacions = new List<Carga_de_Documentos_de_Legislacion>();

            var data = result.Carga_de_Documentos_de_Legislacions.Select(m => new Carga_de_Documentos_de_LegislacionGridModel
            {
                Folio = m.Folio
			,Nombre = m.Nombre
			,Descripcion = m.Descripcion
			,Adjuntar_Documento = m.Adjuntar_Documento
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_de_Documento.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_de_Documento.Descripcion
                        ,Estatus_de_ActualizacionDescripcion = CultureHelper.GetTraduction(m.Estatus_de_Actualizacion_Estatus_de_Actualizacion_de_Documento.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_de_Actualizacion_Estatus_de_Actualizacion_de_Documento.Descripcion

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45205, arrayColumnsVisible), "Carga_de_Documentos_de_LegislacionList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45205, arrayColumnsVisible), "Carga_de_Documentos_de_LegislacionList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45205, arrayColumnsVisible), "Carga_de_Documentos_de_LegislacionList_" + DateTime.Now.ToString());
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

            _ICarga_de_Documentos_de_LegislacionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Carga_de_Documentos_de_LegislacionPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Carga_de_Documentos_de_LegislacionAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Carga_de_Documentos_de_LegislacionPropertyMapper oCarga_de_Documentos_de_LegislacionPropertyMapper = new Carga_de_Documentos_de_LegislacionPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oCarga_de_Documentos_de_LegislacionPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _ICarga_de_Documentos_de_LegislacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Carga_de_Documentos_de_Legislacions == null)
                result.Carga_de_Documentos_de_Legislacions = new List<Carga_de_Documentos_de_Legislacion>();

            var data = result.Carga_de_Documentos_de_Legislacions.Select(m => new Carga_de_Documentos_de_LegislacionGridModel
            {
                Folio = m.Folio
			,Nombre = m.Nombre
			,Descripcion = m.Descripcion
			,Adjuntar_Documento = m.Adjuntar_Documento
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_de_Documento.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_de_Documento.Descripcion
                        ,Estatus_de_ActualizacionDescripcion = CultureHelper.GetTraduction(m.Estatus_de_Actualizacion_Estatus_de_Actualizacion_de_Documento.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_de_Actualizacion_Estatus_de_Actualizacion_de_Documento.Descripcion

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
                _ICarga_de_Documentos_de_LegislacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICarga_de_Documentos_de_LegislacionApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Carga_de_Documentos_de_Legislacion_Datos_GeneralesModel varCarga_de_Documentos_de_Legislacion)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICarga_de_Documentos_de_LegislacionApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Carga_de_Documentos_de_Legislacion_Datos_GeneralesInfo = new Carga_de_Documentos_de_Legislacion_Datos_Generales
                {
                    Folio = varCarga_de_Documentos_de_Legislacion.Folio
                                            ,Nombre = varCarga_de_Documentos_de_Legislacion.Nombre
                        ,Descripcion = varCarga_de_Documentos_de_Legislacion.Descripcion
                        ,Adjuntar_Documento = varCarga_de_Documentos_de_Legislacion.Adjuntar_Documento
                        ,Estatus = varCarga_de_Documentos_de_Legislacion.Estatus
                        ,Estatus_de_Actualizacion = varCarga_de_Documentos_de_Legislacion.Estatus_de_Actualizacion
                    
                };

                result = _ICarga_de_Documentos_de_LegislacionApiConsumer.Update_Datos_Generales(Carga_de_Documentos_de_Legislacion_Datos_GeneralesInfo).Resource.ToString();
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
                _ICarga_de_Documentos_de_LegislacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _ICarga_de_Documentos_de_LegislacionApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_de_Documentos_de_Legislacion;
                var Detalle_de_Documentos_de_LegislacionData = GetDetalle_de_Documentos_de_LegislacionData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Documentos_de_Legislacion);

                var result = new Carga_de_Documentos_de_Legislacion_Datos_GeneralesModel
                {
                    Folio = m.Folio
			,Nombre = m.Nombre
			,Descripcion = m.Descripcion
			,Adjuntar_Documento = m.Adjuntar_Documento
                        ,Estatus = m.Estatus
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_de_Documento.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_de_Documento.Descripcion
                        ,Estatus_de_Actualizacion = m.Estatus_de_Actualizacion
                        ,Estatus_de_ActualizacionDescripcion = CultureHelper.GetTraduction(m.Estatus_de_Actualizacion_Estatus_de_Actualizacion_de_Documento.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_de_Actualizacion_Estatus_de_Actualizacion_de_Documento.Descripcion

                    
                };
				var resultData = new
                {
                    data = result
                    ,Dispositivos = Detalle_de_Documentos_de_LegislacionData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }


    }
}

