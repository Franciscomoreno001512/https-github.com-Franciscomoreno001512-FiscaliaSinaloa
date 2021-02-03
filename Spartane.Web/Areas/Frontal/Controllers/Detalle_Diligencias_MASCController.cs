using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_Diligencias_MASC;
using Spartane.Core.Domain.Solicitud;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Tipo_de_Diligencia_MASC;
using Spartane.Core.Domain.Dilgencia_MASC;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_Diligencias_MASC;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Diligencias_MASC;
using Spartane.Web.Areas.WebApiConsumer.Solicitud;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Diligencia_MASC;
using Spartane.Web.Areas.WebApiConsumer.Dilgencia_MASC;

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
    public class Detalle_Diligencias_MASCController : Controller
    {
        #region "variable declaration"

        private IDetalle_Diligencias_MASCService service = null;
        private IDetalle_Diligencias_MASCApiConsumer _IDetalle_Diligencias_MASCApiConsumer;
        private ISolicitudApiConsumer _ISolicitudApiConsumer;
        private ISpartan_UserApiConsumer _ISpartan_UserApiConsumer;
        private ITipo_de_Diligencia_MASCApiConsumer _ITipo_de_Diligencia_MASCApiConsumer;
        private IDilgencia_MASCApiConsumer _IDilgencia_MASCApiConsumer;

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

        
        public Detalle_Diligencias_MASCController(IDetalle_Diligencias_MASCService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_Diligencias_MASCApiConsumer Detalle_Diligencias_MASCApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , ISolicitudApiConsumer SolicitudApiConsumer , ISpartan_UserApiConsumer Spartan_UserApiConsumer , ITipo_de_Diligencia_MASCApiConsumer Tipo_de_Diligencia_MASCApiConsumer , IDilgencia_MASCApiConsumer Dilgencia_MASCApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_Diligencias_MASCApiConsumer = Detalle_Diligencias_MASCApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_FormatApiConsumer = Spartan_FormatApiConsumer;
            this._ISpartan_Format_PermissionsApiConsumer = Spartan_Format_PermissionsApiConsumer;
            this._IGeneratePDFApiConsumer = GeneratePDFApiConsumer;
			this._ISpartan_FormatRelatedApiConsumer = Spartan_Format_RelatedApiConsumer;
            this._ISolicitudApiConsumer = SolicitudApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._ITipo_de_Diligencia_MASCApiConsumer = Tipo_de_Diligencia_MASCApiConsumer;
            this._IDilgencia_MASCApiConsumer = Dilgencia_MASCApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_Diligencias_MASC
        [ObjectAuth(ObjectId = (ModuleObjectId)45344, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45344, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Detalle_Diligencias_MASC/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45344, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45344, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varDetalle_Diligencias_MASC = new Detalle_Diligencias_MASCModel();
			varDetalle_Diligencias_MASC.Clave = Id;
			
            ViewBag.ObjectId = "45344";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IDetalle_Diligencias_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_Diligencias_MASCsData = _IDetalle_Diligencias_MASCApiConsumer.ListaSelAll(0, 1000, "Detalle_Diligencias_MASC.Clave=" + Id, "").Resource.Detalle_Diligencias_MASCs;
				
				if (Detalle_Diligencias_MASCsData != null && Detalle_Diligencias_MASCsData.Count > 0)
                {
					var Detalle_Diligencias_MASCData = Detalle_Diligencias_MASCsData.First();
					varDetalle_Diligencias_MASC= new Detalle_Diligencias_MASCModel
					{
						Clave  = Detalle_Diligencias_MASCData.Clave 
	                    ,Solicitud = Detalle_Diligencias_MASCData.Solicitud
                    ,SolicitudNumero_de_Folio = CultureHelper.GetTraduction(Convert.ToString(Detalle_Diligencias_MASCData.Solicitud), "Solicitud") ??  (string)Detalle_Diligencias_MASCData.Solicitud_Solicitud.Numero_de_Folio
                    ,Fecha = (Detalle_Diligencias_MASCData.Fecha == null ? string.Empty : Convert.ToDateTime(Detalle_Diligencias_MASCData.Fecha).ToString(ConfigurationProperty.DateFormat))
                    ,Hora = Detalle_Diligencias_MASCData.Hora
                    ,Facilitador = Detalle_Diligencias_MASCData.Facilitador
                    ,FacilitadorName = CultureHelper.GetTraduction(Convert.ToString(Detalle_Diligencias_MASCData.Facilitador), "Spartan_User") ??  (string)Detalle_Diligencias_MASCData.Facilitador_Spartan_User.Name
                    ,Tipo_de_Diligencia = Detalle_Diligencias_MASCData.Tipo_de_Diligencia
                    ,Tipo_de_DiligenciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Diligencias_MASCData.Tipo_de_Diligencia), "Tipo_de_Diligencia_MASC") ??  (string)Detalle_Diligencias_MASCData.Tipo_de_Diligencia_Tipo_de_Diligencia_MASC.Descripcion
                    ,Diligencia = Detalle_Diligencias_MASCData.Diligencia
                    ,DiligenciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Diligencias_MASCData.Diligencia), "Dilgencia_MASC") ??  (string)Detalle_Diligencias_MASCData.Diligencia_Dilgencia_MASC.Descripcion
                    ,Observaciones = Detalle_Diligencias_MASCData.Observaciones

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_Diligencia_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Diligencia_MASCs_Tipo_de_Diligencia = _ITipo_de_Diligencia_MASCApiConsumer.SelAll(true);
            if (Tipo_de_Diligencia_MASCs_Tipo_de_Diligencia != null && Tipo_de_Diligencia_MASCs_Tipo_de_Diligencia.Resource != null)
                ViewBag.Tipo_de_Diligencia_MASCs_Tipo_de_Diligencia = Tipo_de_Diligencia_MASCs_Tipo_de_Diligencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Diligencia_MASC", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDilgencia_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Dilgencia_MASCs_Diligencia = _IDilgencia_MASCApiConsumer.SelAll(true);
            if (Dilgencia_MASCs_Diligencia != null && Dilgencia_MASCs_Diligencia.Resource != null)
                ViewBag.Dilgencia_MASCs_Diligencia = Dilgencia_MASCs_Diligencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Dilgencia_MASC", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varDetalle_Diligencias_MASC);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_Diligencias_MASC(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45344);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_Diligencias_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_Diligencias_MASCModel varDetalle_Diligencias_MASC= new Detalle_Diligencias_MASCModel();


            if (id.ToString() != "0")
            {
                var Detalle_Diligencias_MASCsData = _IDetalle_Diligencias_MASCApiConsumer.ListaSelAll(0, 1000, "Detalle_Diligencias_MASC.Clave=" + id, "").Resource.Detalle_Diligencias_MASCs;
				
				if (Detalle_Diligencias_MASCsData != null && Detalle_Diligencias_MASCsData.Count > 0)
                {
					var Detalle_Diligencias_MASCData = Detalle_Diligencias_MASCsData.First();
					varDetalle_Diligencias_MASC= new Detalle_Diligencias_MASCModel
					{
						Clave  = Detalle_Diligencias_MASCData.Clave 
	                    ,Solicitud = Detalle_Diligencias_MASCData.Solicitud
                    ,SolicitudNumero_de_Folio = CultureHelper.GetTraduction(Convert.ToString(Detalle_Diligencias_MASCData.Solicitud), "Solicitud") ??  (string)Detalle_Diligencias_MASCData.Solicitud_Solicitud.Numero_de_Folio
                    ,Fecha = (Detalle_Diligencias_MASCData.Fecha == null ? string.Empty : Convert.ToDateTime(Detalle_Diligencias_MASCData.Fecha).ToString(ConfigurationProperty.DateFormat))
                    ,Hora = Detalle_Diligencias_MASCData.Hora
                    ,Facilitador = Detalle_Diligencias_MASCData.Facilitador
                    ,FacilitadorName = CultureHelper.GetTraduction(Convert.ToString(Detalle_Diligencias_MASCData.Facilitador), "Spartan_User") ??  (string)Detalle_Diligencias_MASCData.Facilitador_Spartan_User.Name
                    ,Tipo_de_Diligencia = Detalle_Diligencias_MASCData.Tipo_de_Diligencia
                    ,Tipo_de_DiligenciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Diligencias_MASCData.Tipo_de_Diligencia), "Tipo_de_Diligencia_MASC") ??  (string)Detalle_Diligencias_MASCData.Tipo_de_Diligencia_Tipo_de_Diligencia_MASC.Descripcion
                    ,Diligencia = Detalle_Diligencias_MASCData.Diligencia
                    ,DiligenciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Diligencias_MASCData.Diligencia), "Dilgencia_MASC") ??  (string)Detalle_Diligencias_MASCData.Diligencia_Dilgencia_MASC.Descripcion
                    ,Observaciones = Detalle_Diligencias_MASCData.Observaciones

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_Diligencia_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Diligencia_MASCs_Tipo_de_Diligencia = _ITipo_de_Diligencia_MASCApiConsumer.SelAll(true);
            if (Tipo_de_Diligencia_MASCs_Tipo_de_Diligencia != null && Tipo_de_Diligencia_MASCs_Tipo_de_Diligencia.Resource != null)
                ViewBag.Tipo_de_Diligencia_MASCs_Tipo_de_Diligencia = Tipo_de_Diligencia_MASCs_Tipo_de_Diligencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Diligencia_MASC", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDilgencia_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Dilgencia_MASCs_Diligencia = _IDilgencia_MASCApiConsumer.SelAll(true);
            if (Dilgencia_MASCs_Diligencia != null && Dilgencia_MASCs_Diligencia.Resource != null)
                ViewBag.Dilgencia_MASCs_Diligencia = Dilgencia_MASCs_Diligencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Dilgencia_MASC", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddDetalle_Diligencias_MASC", varDetalle_Diligencias_MASC);
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
        public ActionResult GetSolicitudAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISolicitudApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Numero_de_Folio).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Solicitud", "Numero_de_Folio")?? m.Numero_de_Folio,
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
        [HttpGet]
        public ActionResult GetTipo_de_Diligencia_MASCAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_Diligencia_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_Diligencia_MASCApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Diligencia_MASC", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDilgencia_MASCAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDilgencia_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDilgencia_MASCApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Dilgencia_MASC", "Descripcion")?? m.Descripcion,
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
        public ActionResult ShowAdvanceFilter(Detalle_Diligencias_MASCAdvanceSearchModel model, int idFilter = -1)
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

            _ITipo_de_Diligencia_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Diligencia_MASCs_Tipo_de_Diligencia = _ITipo_de_Diligencia_MASCApiConsumer.SelAll(true);
            if (Tipo_de_Diligencia_MASCs_Tipo_de_Diligencia != null && Tipo_de_Diligencia_MASCs_Tipo_de_Diligencia.Resource != null)
                ViewBag.Tipo_de_Diligencia_MASCs_Tipo_de_Diligencia = Tipo_de_Diligencia_MASCs_Tipo_de_Diligencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Diligencia_MASC", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDilgencia_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Dilgencia_MASCs_Diligencia = _IDilgencia_MASCApiConsumer.SelAll(true);
            if (Dilgencia_MASCs_Diligencia != null && Dilgencia_MASCs_Diligencia.Resource != null)
                ViewBag.Dilgencia_MASCs_Diligencia = Dilgencia_MASCs_Diligencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Dilgencia_MASC", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_Diligencia_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Diligencia_MASCs_Tipo_de_Diligencia = _ITipo_de_Diligencia_MASCApiConsumer.SelAll(true);
            if (Tipo_de_Diligencia_MASCs_Tipo_de_Diligencia != null && Tipo_de_Diligencia_MASCs_Tipo_de_Diligencia.Resource != null)
                ViewBag.Tipo_de_Diligencia_MASCs_Tipo_de_Diligencia = Tipo_de_Diligencia_MASCs_Tipo_de_Diligencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Diligencia_MASC", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDilgencia_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Dilgencia_MASCs_Diligencia = _IDilgencia_MASCApiConsumer.SelAll(true);
            if (Dilgencia_MASCs_Diligencia != null && Dilgencia_MASCs_Diligencia.Resource != null)
                ViewBag.Dilgencia_MASCs_Diligencia = Dilgencia_MASCs_Diligencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Dilgencia_MASC", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Detalle_Diligencias_MASCAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Detalle_Diligencias_MASCAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Detalle_Diligencias_MASCAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Diligencias_MASCPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_Diligencias_MASCApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Diligencias_MASCs == null)
                result.Detalle_Diligencias_MASCs = new List<Detalle_Diligencias_MASC>();

            return Json(new
            {
                data = result.Detalle_Diligencias_MASCs.Select(m => new Detalle_Diligencias_MASCGridModel
                    {
                    Clave = m.Clave
                        ,SolicitudNumero_de_Folio = CultureHelper.GetTraduction(m.Solicitud_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Solicitud_Solicitud.Numero_de_Folio
                        ,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora
                        ,FacilitadorName = CultureHelper.GetTraduction(m.Facilitador_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Facilitador_Spartan_User.Name
                        ,Tipo_de_DiligenciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Diligencia_Tipo_de_Diligencia_MASC.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Diligencia_Tipo_de_Diligencia_MASC.Descripcion
                        ,DiligenciaDescripcion = CultureHelper.GetTraduction(m.Diligencia_Dilgencia_MASC.Clave.ToString(), "Descripcion") ?? (string)m.Diligencia_Dilgencia_MASC.Descripcion
			,Observaciones = m.Observaciones

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetDetalle_Diligencias_MASCAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_Diligencias_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_Diligencias_MASCApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Detalle_Diligencias_MASC", m.),
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
        /// Get List of Detalle_Diligencias_MASC from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Detalle_Diligencias_MASC Entity</returns>
        public ActionResult GetDetalle_Diligencias_MASCList(UrlParametersModel param)
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
            _IDetalle_Diligencias_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Detalle_Diligencias_MASCPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Detalle_Diligencias_MASCAdvanceSearchModel))
                {
					var advanceFilter =
                    (Detalle_Diligencias_MASCAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Detalle_Diligencias_MASCPropertyMapper oDetalle_Diligencias_MASCPropertyMapper = new Detalle_Diligencias_MASCPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oDetalle_Diligencias_MASCPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IDetalle_Diligencias_MASCApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Diligencias_MASCs == null)
                result.Detalle_Diligencias_MASCs = new List<Detalle_Diligencias_MASC>();

            return Json(new
            {
                aaData = result.Detalle_Diligencias_MASCs.Select(m => new Detalle_Diligencias_MASCGridModel
            {
                    Clave = m.Clave
                        ,SolicitudNumero_de_Folio = CultureHelper.GetTraduction(m.Solicitud_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Solicitud_Solicitud.Numero_de_Folio
                        ,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora
                        ,FacilitadorName = CultureHelper.GetTraduction(m.Facilitador_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Facilitador_Spartan_User.Name
                        ,Tipo_de_DiligenciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Diligencia_Tipo_de_Diligencia_MASC.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Diligencia_Tipo_de_Diligencia_MASC.Descripcion
                        ,DiligenciaDescripcion = CultureHelper.GetTraduction(m.Diligencia_Dilgencia_MASC.Clave.ToString(), "Descripcion") ?? (string)m.Diligencia_Dilgencia_MASC.Descripcion
			,Observaciones = m.Observaciones

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetDetalle_Diligencias_MASC_Solicitud_Solicitud(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Solicitud.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Solicitud.Numero_de_Folio as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _ISolicitudApiConsumer.ListaSelAll(1, 20,elWhere , " Solicitud.Numero_de_Folio ASC ").Resource;
               
                foreach (var item in result.Solicituds)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Solicitud", "Numero_de_Folio");
                    item.Numero_de_Folio =trans ??item.Numero_de_Folio;
                }
                return Json(result.Solicituds.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetDetalle_Diligencias_MASC_Facilitador_Spartan_User(string query, string where)
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
        public string GetAdvanceFilter(Detalle_Diligencias_MASCAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Detalle_Diligencias_MASC.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Detalle_Diligencias_MASC.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceSolicitud))
            {
                switch (filter.SolicitudFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud.Numero_de_Folio LIKE '" + filter.AdvanceSolicitud + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud.Numero_de_Folio LIKE '%" + filter.AdvanceSolicitud + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud.Numero_de_Folio = '" + filter.AdvanceSolicitud + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud.Numero_de_Folio LIKE '%" + filter.AdvanceSolicitud + "%'";
                        break;
                }
            }
            else if (filter.AdvanceSolicitudMultiple != null && filter.AdvanceSolicitudMultiple.Count() > 0)
            {
                var SolicitudIds = string.Join(",", filter.AdvanceSolicitudMultiple);

                where += " AND Detalle_Diligencias_MASC.Solicitud In (" + SolicitudIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha) || !string.IsNullOrEmpty(filter.ToFecha))
            {
                var FechaFrom = DateTime.ParseExact(filter.FromFecha, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var FechaTo = DateTime.ParseExact(filter.ToFecha, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha))
                    where += " AND Detalle_Diligencias_MASC.Fecha >= '" + FechaFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha))
                    where += " AND Detalle_Diligencias_MASC.Fecha <= '" + FechaTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora) || !string.IsNullOrEmpty(filter.ToHora))
            {
                if (!string.IsNullOrEmpty(filter.FromHora))
                    where += " AND Convert(TIME,Detalle_Diligencias_MASC.Hora) >='" + filter.FromHora + "'";
                if (!string.IsNullOrEmpty(filter.ToHora))
                    where += " AND Convert(TIME,Detalle_Diligencias_MASC.Hora) <='" + filter.ToHora + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceFacilitador))
            {
                switch (filter.FacilitadorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_User.Name LIKE '" + filter.AdvanceFacilitador + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceFacilitador + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_User.Name = '" + filter.AdvanceFacilitador + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceFacilitador + "%'";
                        break;
                }
            }
            else if (filter.AdvanceFacilitadorMultiple != null && filter.AdvanceFacilitadorMultiple.Count() > 0)
            {
                var FacilitadorIds = string.Join(",", filter.AdvanceFacilitadorMultiple);

                where += " AND Detalle_Diligencias_MASC.Facilitador In (" + FacilitadorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Diligencia))
            {
                switch (filter.Tipo_de_DiligenciaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Diligencia_MASC.Descripcion LIKE '" + filter.AdvanceTipo_de_Diligencia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Diligencia_MASC.Descripcion LIKE '%" + filter.AdvanceTipo_de_Diligencia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Diligencia_MASC.Descripcion = '" + filter.AdvanceTipo_de_Diligencia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Diligencia_MASC.Descripcion LIKE '%" + filter.AdvanceTipo_de_Diligencia + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_DiligenciaMultiple != null && filter.AdvanceTipo_de_DiligenciaMultiple.Count() > 0)
            {
                var Tipo_de_DiligenciaIds = string.Join(",", filter.AdvanceTipo_de_DiligenciaMultiple);

                where += " AND Detalle_Diligencias_MASC.Tipo_de_Diligencia In (" + Tipo_de_DiligenciaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceDiligencia))
            {
                switch (filter.DiligenciaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Dilgencia_MASC.Descripcion LIKE '" + filter.AdvanceDiligencia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Dilgencia_MASC.Descripcion LIKE '%" + filter.AdvanceDiligencia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Dilgencia_MASC.Descripcion = '" + filter.AdvanceDiligencia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Dilgencia_MASC.Descripcion LIKE '%" + filter.AdvanceDiligencia + "%'";
                        break;
                }
            }
            else if (filter.AdvanceDiligenciaMultiple != null && filter.AdvanceDiligenciaMultiple.Count() > 0)
            {
                var DiligenciaIds = string.Join(",", filter.AdvanceDiligenciaMultiple);

                where += " AND Detalle_Diligencias_MASC.Diligencia In (" + DiligenciaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Observaciones))
            {
                switch (filter.ObservacionesFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_Diligencias_MASC.Observaciones LIKE '" + filter.Observaciones + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_Diligencias_MASC.Observaciones LIKE '%" + filter.Observaciones + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_Diligencias_MASC.Observaciones = '" + filter.Observaciones + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_Diligencias_MASC.Observaciones LIKE '%" + filter.Observaciones + "%'";
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
                _IDetalle_Diligencias_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_Diligencias_MASC varDetalle_Diligencias_MASC = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IDetalle_Diligencias_MASCApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_Diligencias_MASCModel varDetalle_Diligencias_MASC)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_Diligencias_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Detalle_Diligencias_MASCInfo = new Detalle_Diligencias_MASC
                    {
                        Clave = varDetalle_Diligencias_MASC.Clave
                        ,Solicitud = varDetalle_Diligencias_MASC.Solicitud
                        ,Fecha = (!String.IsNullOrEmpty(varDetalle_Diligencias_MASC.Fecha)) ? DateTime.ParseExact(varDetalle_Diligencias_MASC.Fecha, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora = varDetalle_Diligencias_MASC.Hora
                        ,Facilitador = varDetalle_Diligencias_MASC.Facilitador
                        ,Tipo_de_Diligencia = varDetalle_Diligencias_MASC.Tipo_de_Diligencia
                        ,Diligencia = varDetalle_Diligencias_MASC.Diligencia
                        ,Observaciones = varDetalle_Diligencias_MASC.Observaciones

                    };

                    result = !IsNew ?
                        _IDetalle_Diligencias_MASCApiConsumer.Update(Detalle_Diligencias_MASCInfo, null, null).Resource.ToString() :
                         _IDetalle_Diligencias_MASCApiConsumer.Insert(Detalle_Diligencias_MASCInfo, null, null).Resource.ToString();
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
        /// Write Element Array of Detalle_Diligencias_MASC script
        /// </summary>
        /// <param name="oDetalle_Diligencias_MASCElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Detalle_Diligencias_MASCModuleAttributeList)
        {
            for (int i = 0; i < Detalle_Diligencias_MASCModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_Diligencias_MASCModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_Diligencias_MASCModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_Diligencias_MASCModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_Diligencias_MASCModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_Diligencias_MASCModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_Diligencias_MASCModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Detalle_Diligencias_MASCModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Detalle_Diligencias_MASCModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Detalle_Diligencias_MASCModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Detalle_Diligencias_MASCModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Detalle_Diligencias_MASCModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strDetalle_Diligencias_MASCScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_Diligencias_MASC.js")))
            {
                strDetalle_Diligencias_MASCScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_Diligencias_MASC element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_Diligencias_MASCModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_Diligencias_MASCScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_Diligencias_MASCScript.Substring(indexOfArray, strDetalle_Diligencias_MASCScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_Diligencias_MASCModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_Diligencias_MASCModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_Diligencias_MASCScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strDetalle_Diligencias_MASCScript.Substring(indexOfArrayHistory, strDetalle_Diligencias_MASCScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strDetalle_Diligencias_MASCScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_Diligencias_MASCScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_Diligencias_MASCScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Detalle_Diligencias_MASCModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Detalle_Diligencias_MASCModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_Diligencias_MASC.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_Diligencias_MASC.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_Diligencias_MASC.js")))
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
        public ActionResult Detalle_Diligencias_MASCPropertyBag()
        {
            return PartialView("Detalle_Diligencias_MASCPropertyBag", "Detalle_Diligencias_MASC");
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
                var whereClauseFormat = "Object = 45344 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IDetalle_Diligencias_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Detalle_Diligencias_MASC.Clave= " + RecordId;
                            var result = _IDetalle_Diligencias_MASCApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IDetalle_Diligencias_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Detalle_Diligencias_MASCPropertyMapper());
			
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
                    (Detalle_Diligencias_MASCAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Detalle_Diligencias_MASCPropertyMapper oDetalle_Diligencias_MASCPropertyMapper = new Detalle_Diligencias_MASCPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oDetalle_Diligencias_MASCPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_Diligencias_MASCApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Diligencias_MASCs == null)
                result.Detalle_Diligencias_MASCs = new List<Detalle_Diligencias_MASC>();

            var data = result.Detalle_Diligencias_MASCs.Select(m => new Detalle_Diligencias_MASCGridModel
            {
                Clave = m.Clave
                        ,SolicitudNumero_de_Folio = CultureHelper.GetTraduction(m.Solicitud_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Solicitud_Solicitud.Numero_de_Folio
                        ,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora
                        ,FacilitadorName = CultureHelper.GetTraduction(m.Facilitador_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Facilitador_Spartan_User.Name
                        ,Tipo_de_DiligenciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Diligencia_Tipo_de_Diligencia_MASC.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Diligencia_Tipo_de_Diligencia_MASC.Descripcion
                        ,DiligenciaDescripcion = CultureHelper.GetTraduction(m.Diligencia_Dilgencia_MASC.Clave.ToString(), "Descripcion") ?? (string)m.Diligencia_Dilgencia_MASC.Descripcion
			,Observaciones = m.Observaciones

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45344, arrayColumnsVisible), "Detalle_Diligencias_MASCList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45344, arrayColumnsVisible), "Detalle_Diligencias_MASCList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45344, arrayColumnsVisible), "Detalle_Diligencias_MASCList_" + DateTime.Now.ToString());
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

            _IDetalle_Diligencias_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Detalle_Diligencias_MASCPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Detalle_Diligencias_MASCAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Detalle_Diligencias_MASCPropertyMapper oDetalle_Diligencias_MASCPropertyMapper = new Detalle_Diligencias_MASCPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oDetalle_Diligencias_MASCPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_Diligencias_MASCApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Diligencias_MASCs == null)
                result.Detalle_Diligencias_MASCs = new List<Detalle_Diligencias_MASC>();

            var data = result.Detalle_Diligencias_MASCs.Select(m => new Detalle_Diligencias_MASCGridModel
            {
                Clave = m.Clave
                        ,SolicitudNumero_de_Folio = CultureHelper.GetTraduction(m.Solicitud_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Solicitud_Solicitud.Numero_de_Folio
                        ,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora
                        ,FacilitadorName = CultureHelper.GetTraduction(m.Facilitador_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Facilitador_Spartan_User.Name
                        ,Tipo_de_DiligenciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Diligencia_Tipo_de_Diligencia_MASC.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Diligencia_Tipo_de_Diligencia_MASC.Descripcion
                        ,DiligenciaDescripcion = CultureHelper.GetTraduction(m.Diligencia_Dilgencia_MASC.Clave.ToString(), "Descripcion") ?? (string)m.Diligencia_Dilgencia_MASC.Descripcion
			,Observaciones = m.Observaciones

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
                _IDetalle_Diligencias_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_Diligencias_MASCApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Detalle_Diligencias_MASC_Datos_GeneralesModel varDetalle_Diligencias_MASC)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_Diligencias_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Detalle_Diligencias_MASC_Datos_GeneralesInfo = new Detalle_Diligencias_MASC_Datos_Generales
                {
                    Clave = varDetalle_Diligencias_MASC.Clave
                                            ,Solicitud = varDetalle_Diligencias_MASC.Solicitud
                        ,Fecha = (!String.IsNullOrEmpty(varDetalle_Diligencias_MASC.Fecha)) ? DateTime.ParseExact(varDetalle_Diligencias_MASC.Fecha, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora = varDetalle_Diligencias_MASC.Hora
                        ,Facilitador = varDetalle_Diligencias_MASC.Facilitador
                        ,Tipo_de_Diligencia = varDetalle_Diligencias_MASC.Tipo_de_Diligencia
                        ,Diligencia = varDetalle_Diligencias_MASC.Diligencia
                        ,Observaciones = varDetalle_Diligencias_MASC.Observaciones
                    
                };

                result = _IDetalle_Diligencias_MASCApiConsumer.Update_Datos_Generales(Detalle_Diligencias_MASC_Datos_GeneralesInfo).Resource.ToString();
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
                _IDetalle_Diligencias_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IDetalle_Diligencias_MASCApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Detalle_Diligencias_MASC_Datos_GeneralesModel
                {
                    Clave = m.Clave
                        ,Solicitud = m.Solicitud
                        ,SolicitudNumero_de_Folio = CultureHelper.GetTraduction(m.Solicitud_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Solicitud_Solicitud.Numero_de_Folio
                        ,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora
                        ,Facilitador = m.Facilitador
                        ,FacilitadorName = CultureHelper.GetTraduction(m.Facilitador_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Facilitador_Spartan_User.Name
                        ,Tipo_de_Diligencia = m.Tipo_de_Diligencia
                        ,Tipo_de_DiligenciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Diligencia_Tipo_de_Diligencia_MASC.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Diligencia_Tipo_de_Diligencia_MASC.Descripcion
                        ,Diligencia = m.Diligencia
                        ,DiligenciaDescripcion = CultureHelper.GetTraduction(m.Diligencia_Dilgencia_MASC.Clave.ToString(), "Descripcion") ?? (string)m.Diligencia_Dilgencia_MASC.Descripcion
			,Observaciones = m.Observaciones

                    
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

