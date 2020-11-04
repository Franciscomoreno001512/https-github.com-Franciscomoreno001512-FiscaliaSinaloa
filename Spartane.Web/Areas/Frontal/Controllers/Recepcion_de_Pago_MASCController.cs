using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Recepcion_de_Pago_MASC;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Solicitud;
using Spartane.Core.Domain.Detalle_de_Solicitud_Requerido;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Recepcion_de_Pago_MASC;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Recepcion_de_Pago_MASC;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Solicitud;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Solicitud_Requerido;

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
    public class Recepcion_de_Pago_MASCController : Controller
    {
        #region "variable declaration"

        private IRecepcion_de_Pago_MASCService service = null;
        private IRecepcion_de_Pago_MASCApiConsumer _IRecepcion_de_Pago_MASCApiConsumer;
        private ISpartan_UserApiConsumer _ISpartan_UserApiConsumer;
        private ISolicitudApiConsumer _ISolicitudApiConsumer;
        private IDetalle_de_Solicitud_RequeridoApiConsumer _IDetalle_de_Solicitud_RequeridoApiConsumer;

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

        
        public Recepcion_de_Pago_MASCController(IRecepcion_de_Pago_MASCService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IRecepcion_de_Pago_MASCApiConsumer Recepcion_de_Pago_MASCApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , ISpartan_UserApiConsumer Spartan_UserApiConsumer , ISolicitudApiConsumer SolicitudApiConsumer , IDetalle_de_Solicitud_RequeridoApiConsumer Detalle_de_Solicitud_RequeridoApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IRecepcion_de_Pago_MASCApiConsumer = Recepcion_de_Pago_MASCApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_FormatApiConsumer = Spartan_FormatApiConsumer;
            this._ISpartan_Format_PermissionsApiConsumer = Spartan_Format_PermissionsApiConsumer;
            this._IGeneratePDFApiConsumer = GeneratePDFApiConsumer;
			this._ISpartan_FormatRelatedApiConsumer = Spartan_Format_RelatedApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._ISolicitudApiConsumer = SolicitudApiConsumer;
            this._IDetalle_de_Solicitud_RequeridoApiConsumer = Detalle_de_Solicitud_RequeridoApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Recepcion_de_Pago_MASC
        [ObjectAuth(ObjectId = (ModuleObjectId)45355, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45355, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Recepcion_de_Pago_MASC/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45355, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45355, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varRecepcion_de_Pago_MASC = new Recepcion_de_Pago_MASCModel();
			varRecepcion_de_Pago_MASC.Clave = Id;
			
            ViewBag.ObjectId = "45355";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IRecepcion_de_Pago_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Recepcion_de_Pago_MASCsData = _IRecepcion_de_Pago_MASCApiConsumer.ListaSelAll(0, 1000, "Recepcion_de_Pago_MASC.Clave=" + Id, "").Resource.Recepcion_de_Pago_MASCs;
				
				if (Recepcion_de_Pago_MASCsData != null && Recepcion_de_Pago_MASCsData.Count > 0)
                {
					var Recepcion_de_Pago_MASCData = Recepcion_de_Pago_MASCsData.First();
					varRecepcion_de_Pago_MASC= new Recepcion_de_Pago_MASCModel
					{
						Clave  = Recepcion_de_Pago_MASCData.Clave 
	                    ,Fecha_de_Recepcion = (Recepcion_de_Pago_MASCData.Fecha_de_Recepcion == null ? string.Empty : Convert.ToDateTime(Recepcion_de_Pago_MASCData.Fecha_de_Recepcion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Recepcion = Recepcion_de_Pago_MASCData.Hora_de_Recepcion
                    ,Usuario_que_Recibe = Recepcion_de_Pago_MASCData.Usuario_que_Recibe
                    ,Usuario_que_RecibeName = CultureHelper.GetTraduction(Convert.ToString(Recepcion_de_Pago_MASCData.Usuario_que_Recibe), "Spartan_User") ??  (string)Recepcion_de_Pago_MASCData.Usuario_que_Recibe_Spartan_User.Name
                    ,Numero_de_Expediente = Recepcion_de_Pago_MASCData.Numero_de_Expediente
                    ,Numero_de_ExpedienteNumero_de_Folio = CultureHelper.GetTraduction(Convert.ToString(Recepcion_de_Pago_MASCData.Numero_de_Expediente), "Solicitud") ??  (string)Recepcion_de_Pago_MASCData.Numero_de_Expediente_Solicitud.Numero_de_Folio
                    ,Requerido = Recepcion_de_Pago_MASCData.Requerido
                    ,RequeridoNombre_Completo = CultureHelper.GetTraduction(Convert.ToString(Recepcion_de_Pago_MASCData.Requerido), "Detalle_de_Solicitud_Requerido") ??  (string)Recepcion_de_Pago_MASCData.Requerido_Detalle_de_Solicitud_Requerido.Nombre_Completo
                    ,Nombre_de_la_Persona_que_entrega = Recepcion_de_Pago_MASCData.Nombre_de_la_Persona_que_entrega
                    ,Numero_de_Pago = Recepcion_de_Pago_MASCData.Numero_de_Pago
                    ,Monto_del_Pago = Recepcion_de_Pago_MASCData.Monto_del_Pago
                    ,Pago_Completo = Recepcion_de_Pago_MASCData.Pago_Completo.GetValueOrDefault()
                    ,Motivo_para_no_entregar_pago_completo = Recepcion_de_Pago_MASCData.Motivo_para_no_entregar_pago_completo

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);



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

				
            return View(varRecepcion_de_Pago_MASC);
        }
		
	[HttpGet]
        public ActionResult AddRecepcion_de_Pago_MASC(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45355);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IRecepcion_de_Pago_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
			Recepcion_de_Pago_MASCModel varRecepcion_de_Pago_MASC= new Recepcion_de_Pago_MASCModel();


            if (id.ToString() != "0")
            {
                var Recepcion_de_Pago_MASCsData = _IRecepcion_de_Pago_MASCApiConsumer.ListaSelAll(0, 1000, "Recepcion_de_Pago_MASC.Clave=" + id, "").Resource.Recepcion_de_Pago_MASCs;
				
				if (Recepcion_de_Pago_MASCsData != null && Recepcion_de_Pago_MASCsData.Count > 0)
                {
					var Recepcion_de_Pago_MASCData = Recepcion_de_Pago_MASCsData.First();
					varRecepcion_de_Pago_MASC= new Recepcion_de_Pago_MASCModel
					{
						Clave  = Recepcion_de_Pago_MASCData.Clave 
	                    ,Fecha_de_Recepcion = (Recepcion_de_Pago_MASCData.Fecha_de_Recepcion == null ? string.Empty : Convert.ToDateTime(Recepcion_de_Pago_MASCData.Fecha_de_Recepcion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Recepcion = Recepcion_de_Pago_MASCData.Hora_de_Recepcion
                    ,Usuario_que_Recibe = Recepcion_de_Pago_MASCData.Usuario_que_Recibe
                    ,Usuario_que_RecibeName = CultureHelper.GetTraduction(Convert.ToString(Recepcion_de_Pago_MASCData.Usuario_que_Recibe), "Spartan_User") ??  (string)Recepcion_de_Pago_MASCData.Usuario_que_Recibe_Spartan_User.Name
                    ,Numero_de_Expediente = Recepcion_de_Pago_MASCData.Numero_de_Expediente
                    ,Numero_de_ExpedienteNumero_de_Folio = CultureHelper.GetTraduction(Convert.ToString(Recepcion_de_Pago_MASCData.Numero_de_Expediente), "Solicitud") ??  (string)Recepcion_de_Pago_MASCData.Numero_de_Expediente_Solicitud.Numero_de_Folio
                    ,Requerido = Recepcion_de_Pago_MASCData.Requerido
                    ,RequeridoNombre_Completo = CultureHelper.GetTraduction(Convert.ToString(Recepcion_de_Pago_MASCData.Requerido), "Detalle_de_Solicitud_Requerido") ??  (string)Recepcion_de_Pago_MASCData.Requerido_Detalle_de_Solicitud_Requerido.Nombre_Completo
                    ,Nombre_de_la_Persona_que_entrega = Recepcion_de_Pago_MASCData.Nombre_de_la_Persona_que_entrega
                    ,Numero_de_Pago = Recepcion_de_Pago_MASCData.Numero_de_Pago
                    ,Monto_del_Pago = Recepcion_de_Pago_MASCData.Monto_del_Pago
                    ,Pago_Completo = Recepcion_de_Pago_MASCData.Pago_Completo.GetValueOrDefault()
                    ,Motivo_para_no_entregar_pago_completo = Recepcion_de_Pago_MASCData.Motivo_para_no_entregar_pago_completo

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);



            return PartialView("AddRecepcion_de_Pago_MASC", varRecepcion_de_Pago_MASC);
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
        public ActionResult GetDetalle_de_Solicitud_RequeridoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Solicitud_RequeridoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_Solicitud_RequeridoApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Nombre_Completo).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_Solicitud_Requerido", "Nombre_Completo")?? m.Nombre_Completo,
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
        public ActionResult ShowAdvanceFilter(Recepcion_de_Pago_MASCAdvanceSearchModel model, int idFilter = -1)
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



            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);



            var previousFiltersObj = new Recepcion_de_Pago_MASCAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Recepcion_de_Pago_MASCAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Recepcion_de_Pago_MASCAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Recepcion_de_Pago_MASCPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IRecepcion_de_Pago_MASCApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Recepcion_de_Pago_MASCs == null)
                result.Recepcion_de_Pago_MASCs = new List<Recepcion_de_Pago_MASC>();

            return Json(new
            {
                data = result.Recepcion_de_Pago_MASCs.Select(m => new Recepcion_de_Pago_MASCGridModel
                    {
                    Clave = m.Clave
                        ,Fecha_de_Recepcion = (m.Fecha_de_Recepcion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Recepcion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Recepcion = m.Hora_de_Recepcion
                        ,Usuario_que_RecibeName = CultureHelper.GetTraduction(m.Usuario_que_Recibe_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Recibe_Spartan_User.Name
                        ,Numero_de_ExpedienteNumero_de_Folio = CultureHelper.GetTraduction(m.Numero_de_Expediente_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Numero_de_Expediente_Solicitud.Numero_de_Folio
                        ,RequeridoNombre_Completo = CultureHelper.GetTraduction(m.Requerido_Detalle_de_Solicitud_Requerido.Clave.ToString(), "Detalle_de_Solicitud_Requerido") ?? (string)m.Requerido_Detalle_de_Solicitud_Requerido.Nombre_Completo
			,Nombre_de_la_Persona_que_entrega = m.Nombre_de_la_Persona_que_entrega
			,Numero_de_Pago = m.Numero_de_Pago
			,Monto_del_Pago = m.Monto_del_Pago
			,Pago_Completo = m.Pago_Completo
			,Motivo_para_no_entregar_pago_completo = m.Motivo_para_no_entregar_pago_completo

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetRecepcion_de_Pago_MASCAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRecepcion_de_Pago_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IRecepcion_de_Pago_MASCApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Recepcion_de_Pago_MASC", m.),
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
        /// Get List of Recepcion_de_Pago_MASC from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Recepcion_de_Pago_MASC Entity</returns>
        public ActionResult GetRecepcion_de_Pago_MASCList(UrlParametersModel param)
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
            _IRecepcion_de_Pago_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Recepcion_de_Pago_MASCPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Recepcion_de_Pago_MASCAdvanceSearchModel))
                {
					var advanceFilter =
                    (Recepcion_de_Pago_MASCAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Recepcion_de_Pago_MASCPropertyMapper oRecepcion_de_Pago_MASCPropertyMapper = new Recepcion_de_Pago_MASCPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oRecepcion_de_Pago_MASCPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IRecepcion_de_Pago_MASCApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Recepcion_de_Pago_MASCs == null)
                result.Recepcion_de_Pago_MASCs = new List<Recepcion_de_Pago_MASC>();

            return Json(new
            {
                aaData = result.Recepcion_de_Pago_MASCs.Select(m => new Recepcion_de_Pago_MASCGridModel
            {
                    Clave = m.Clave
                        ,Fecha_de_Recepcion = (m.Fecha_de_Recepcion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Recepcion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Recepcion = m.Hora_de_Recepcion
                        ,Usuario_que_RecibeName = CultureHelper.GetTraduction(m.Usuario_que_Recibe_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Recibe_Spartan_User.Name
                        ,Numero_de_ExpedienteNumero_de_Folio = CultureHelper.GetTraduction(m.Numero_de_Expediente_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Numero_de_Expediente_Solicitud.Numero_de_Folio
                        ,RequeridoNombre_Completo = CultureHelper.GetTraduction(m.Requerido_Detalle_de_Solicitud_Requerido.Clave.ToString(), "Detalle_de_Solicitud_Requerido") ?? (string)m.Requerido_Detalle_de_Solicitud_Requerido.Nombre_Completo
			,Nombre_de_la_Persona_que_entrega = m.Nombre_de_la_Persona_que_entrega
			,Numero_de_Pago = m.Numero_de_Pago
			,Monto_del_Pago = m.Monto_del_Pago
			,Pago_Completo = m.Pago_Completo
			,Motivo_para_no_entregar_pago_completo = m.Motivo_para_no_entregar_pago_completo

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetRecepcion_de_Pago_MASC_Usuario_que_Recibe_Spartan_User(string query, string where)
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
        [HttpGet]
        public JsonResult GetRecepcion_de_Pago_MASC_Numero_de_Expediente_Solicitud(string query, string where)
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
        public JsonResult GetRecepcion_de_Pago_MASC_Requerido_Detalle_de_Solicitud_Requerido(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Solicitud_RequeridoApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Detalle_de_Solicitud_Requerido.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Detalle_de_Solicitud_Requerido.Nombre_Completo as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IDetalle_de_Solicitud_RequeridoApiConsumer.ListaSelAll(1, 20,elWhere , " Detalle_de_Solicitud_Requerido.Nombre_Completo ASC ").Resource;
               
                foreach (var item in result.Detalle_de_Solicitud_Requeridos)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Detalle_de_Solicitud_Requerido", "Nombre_Completo");
                    item.Nombre_Completo =trans ??item.Nombre_Completo;
                }
                return Json(result.Detalle_de_Solicitud_Requeridos.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }





        [NonAction]
        public string GetAdvanceFilter(Recepcion_de_Pago_MASCAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Recepcion_de_Pago_MASC.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Recepcion_de_Pago_MASC.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Recepcion) || !string.IsNullOrEmpty(filter.ToFecha_de_Recepcion))
            {
                var Fecha_de_RecepcionFrom = DateTime.ParseExact(filter.FromFecha_de_Recepcion, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_RecepcionTo = DateTime.ParseExact(filter.ToFecha_de_Recepcion, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Recepcion))
                    where += " AND Recepcion_de_Pago_MASC.Fecha_de_Recepcion >= '" + Fecha_de_RecepcionFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Recepcion))
                    where += " AND Recepcion_de_Pago_MASC.Fecha_de_Recepcion <= '" + Fecha_de_RecepcionTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Recepcion) || !string.IsNullOrEmpty(filter.ToHora_de_Recepcion))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Recepcion))
                    where += " AND Convert(TIME,Recepcion_de_Pago_MASC.Hora_de_Recepcion) >='" + filter.FromHora_de_Recepcion + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Recepcion))
                    where += " AND Convert(TIME,Recepcion_de_Pago_MASC.Hora_de_Recepcion) <='" + filter.ToHora_de_Recepcion + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceUsuario_que_Recibe))
            {
                switch (filter.Usuario_que_RecibeFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_User.Name LIKE '" + filter.AdvanceUsuario_que_Recibe + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceUsuario_que_Recibe + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_User.Name = '" + filter.AdvanceUsuario_que_Recibe + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceUsuario_que_Recibe + "%'";
                        break;
                }
            }
            else if (filter.AdvanceUsuario_que_RecibeMultiple != null && filter.AdvanceUsuario_que_RecibeMultiple.Count() > 0)
            {
                var Usuario_que_RecibeIds = string.Join(",", filter.AdvanceUsuario_que_RecibeMultiple);

                where += " AND Recepcion_de_Pago_MASC.Usuario_que_Recibe In (" + Usuario_que_RecibeIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceNumero_de_Expediente))
            {
                switch (filter.Numero_de_ExpedienteFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud.Numero_de_Folio LIKE '" + filter.AdvanceNumero_de_Expediente + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud.Numero_de_Folio LIKE '%" + filter.AdvanceNumero_de_Expediente + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud.Numero_de_Folio = '" + filter.AdvanceNumero_de_Expediente + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud.Numero_de_Folio LIKE '%" + filter.AdvanceNumero_de_Expediente + "%'";
                        break;
                }
            }
            else if (filter.AdvanceNumero_de_ExpedienteMultiple != null && filter.AdvanceNumero_de_ExpedienteMultiple.Count() > 0)
            {
                var Numero_de_ExpedienteIds = string.Join(",", filter.AdvanceNumero_de_ExpedienteMultiple);

                where += " AND Recepcion_de_Pago_MASC.Numero_de_Expediente In (" + Numero_de_ExpedienteIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceRequerido))
            {
                switch (filter.RequeridoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Nombre_Completo LIKE '" + filter.AdvanceRequerido + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Requerido.Nombre_Completo LIKE '%" + filter.AdvanceRequerido + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Requerido.Nombre_Completo = '" + filter.AdvanceRequerido + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Requerido.Nombre_Completo LIKE '%" + filter.AdvanceRequerido + "%'";
                        break;
                }
            }
            else if (filter.AdvanceRequeridoMultiple != null && filter.AdvanceRequeridoMultiple.Count() > 0)
            {
                var RequeridoIds = string.Join(",", filter.AdvanceRequeridoMultiple);

                where += " AND Recepcion_de_Pago_MASC.Requerido In (" + RequeridoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Nombre_de_la_Persona_que_entrega))
            {
                switch (filter.Nombre_de_la_Persona_que_entregaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Recepcion_de_Pago_MASC.Nombre_de_la_Persona_que_entrega LIKE '" + filter.Nombre_de_la_Persona_que_entrega + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Recepcion_de_Pago_MASC.Nombre_de_la_Persona_que_entrega LIKE '%" + filter.Nombre_de_la_Persona_que_entrega + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Recepcion_de_Pago_MASC.Nombre_de_la_Persona_que_entrega = '" + filter.Nombre_de_la_Persona_que_entrega + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Recepcion_de_Pago_MASC.Nombre_de_la_Persona_que_entrega LIKE '%" + filter.Nombre_de_la_Persona_que_entrega + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromNumero_de_Pago) || !string.IsNullOrEmpty(filter.ToNumero_de_Pago))
            {
                if (!string.IsNullOrEmpty(filter.FromNumero_de_Pago))
                    where += " AND Recepcion_de_Pago_MASC.Numero_de_Pago >= " + filter.FromNumero_de_Pago;
                if (!string.IsNullOrEmpty(filter.ToNumero_de_Pago))
                    where += " AND Recepcion_de_Pago_MASC.Numero_de_Pago <= " + filter.ToNumero_de_Pago;
            }

            if (!string.IsNullOrEmpty(filter.FromMonto_del_Pago) || !string.IsNullOrEmpty(filter.ToMonto_del_Pago))
            {
                if (!string.IsNullOrEmpty(filter.FromMonto_del_Pago))
                    where += " AND Recepcion_de_Pago_MASC.Monto_del_Pago >= " + filter.FromMonto_del_Pago;
                if (!string.IsNullOrEmpty(filter.ToMonto_del_Pago))
                    where += " AND Recepcion_de_Pago_MASC.Monto_del_Pago <= " + filter.ToMonto_del_Pago;
            }

            if (filter.Pago_Completo != RadioOptions.NoApply)
                where += " AND Recepcion_de_Pago_MASC.Pago_Completo = " + Convert.ToInt32(filter.Pago_Completo);

            if (!string.IsNullOrEmpty(filter.Motivo_para_no_entregar_pago_completo))
            {
                switch (filter.Motivo_para_no_entregar_pago_completoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Recepcion_de_Pago_MASC.Motivo_para_no_entregar_pago_completo LIKE '" + filter.Motivo_para_no_entregar_pago_completo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Recepcion_de_Pago_MASC.Motivo_para_no_entregar_pago_completo LIKE '%" + filter.Motivo_para_no_entregar_pago_completo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Recepcion_de_Pago_MASC.Motivo_para_no_entregar_pago_completo = '" + filter.Motivo_para_no_entregar_pago_completo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Recepcion_de_Pago_MASC.Motivo_para_no_entregar_pago_completo LIKE '%" + filter.Motivo_para_no_entregar_pago_completo + "%'";
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
                _IRecepcion_de_Pago_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

                Recepcion_de_Pago_MASC varRecepcion_de_Pago_MASC = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IRecepcion_de_Pago_MASCApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Recepcion_de_Pago_MASCModel varRecepcion_de_Pago_MASC)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IRecepcion_de_Pago_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Recepcion_de_Pago_MASCInfo = new Recepcion_de_Pago_MASC
                    {
                        Clave = varRecepcion_de_Pago_MASC.Clave
                        ,Fecha_de_Recepcion = (!String.IsNullOrEmpty(varRecepcion_de_Pago_MASC.Fecha_de_Recepcion)) ? DateTime.ParseExact(varRecepcion_de_Pago_MASC.Fecha_de_Recepcion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Recepcion = varRecepcion_de_Pago_MASC.Hora_de_Recepcion
                        ,Usuario_que_Recibe = varRecepcion_de_Pago_MASC.Usuario_que_Recibe
                        ,Numero_de_Expediente = varRecepcion_de_Pago_MASC.Numero_de_Expediente
                        ,Requerido = varRecepcion_de_Pago_MASC.Requerido
                        ,Nombre_de_la_Persona_que_entrega = varRecepcion_de_Pago_MASC.Nombre_de_la_Persona_que_entrega
                        ,Numero_de_Pago = varRecepcion_de_Pago_MASC.Numero_de_Pago
                        ,Monto_del_Pago = varRecepcion_de_Pago_MASC.Monto_del_Pago
                        ,Pago_Completo = varRecepcion_de_Pago_MASC.Pago_Completo
                        ,Motivo_para_no_entregar_pago_completo = varRecepcion_de_Pago_MASC.Motivo_para_no_entregar_pago_completo

                    };

                    result = !IsNew ?
                        _IRecepcion_de_Pago_MASCApiConsumer.Update(Recepcion_de_Pago_MASCInfo, null, null).Resource.ToString() :
                         _IRecepcion_de_Pago_MASCApiConsumer.Insert(Recepcion_de_Pago_MASCInfo, null, null).Resource.ToString();
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
        /// Write Element Array of Recepcion_de_Pago_MASC script
        /// </summary>
        /// <param name="oRecepcion_de_Pago_MASCElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Recepcion_de_Pago_MASCModuleAttributeList)
        {
            for (int i = 0; i < Recepcion_de_Pago_MASCModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Recepcion_de_Pago_MASCModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Recepcion_de_Pago_MASCModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Recepcion_de_Pago_MASCModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Recepcion_de_Pago_MASCModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Recepcion_de_Pago_MASCModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Recepcion_de_Pago_MASCModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Recepcion_de_Pago_MASCModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Recepcion_de_Pago_MASCModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Recepcion_de_Pago_MASCModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Recepcion_de_Pago_MASCModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Recepcion_de_Pago_MASCModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strRecepcion_de_Pago_MASCScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Recepcion_de_Pago_MASC.js")))
            {
                strRecepcion_de_Pago_MASCScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Recepcion_de_Pago_MASC element attributes
            string userChangeJson = jsSerialize.Serialize(Recepcion_de_Pago_MASCModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strRecepcion_de_Pago_MASCScript.IndexOf("inpuElementArray");
            string splittedString = strRecepcion_de_Pago_MASCScript.Substring(indexOfArray, strRecepcion_de_Pago_MASCScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Recepcion_de_Pago_MASCModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Recepcion_de_Pago_MASCModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strRecepcion_de_Pago_MASCScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strRecepcion_de_Pago_MASCScript.Substring(indexOfArrayHistory, strRecepcion_de_Pago_MASCScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strRecepcion_de_Pago_MASCScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strRecepcion_de_Pago_MASCScript.Substring(endIndexOfMainElement + indexOfArray, strRecepcion_de_Pago_MASCScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Recepcion_de_Pago_MASCModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Recepcion_de_Pago_MASCModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Recepcion_de_Pago_MASC.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Recepcion_de_Pago_MASC.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Recepcion_de_Pago_MASC.js")))
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
        public ActionResult Recepcion_de_Pago_MASCPropertyBag()
        {
            return PartialView("Recepcion_de_Pago_MASCPropertyBag", "Recepcion_de_Pago_MASC");
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
                var whereClauseFormat = "Object = 45355 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IRecepcion_de_Pago_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Recepcion_de_Pago_MASC.Clave= " + RecordId;
                            var result = _IRecepcion_de_Pago_MASCApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IRecepcion_de_Pago_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Recepcion_de_Pago_MASCPropertyMapper());
			
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
                    (Recepcion_de_Pago_MASCAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Recepcion_de_Pago_MASCPropertyMapper oRecepcion_de_Pago_MASCPropertyMapper = new Recepcion_de_Pago_MASCPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oRecepcion_de_Pago_MASCPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IRecepcion_de_Pago_MASCApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Recepcion_de_Pago_MASCs == null)
                result.Recepcion_de_Pago_MASCs = new List<Recepcion_de_Pago_MASC>();

            var data = result.Recepcion_de_Pago_MASCs.Select(m => new Recepcion_de_Pago_MASCGridModel
            {
                Clave = m.Clave
                        ,Fecha_de_Recepcion = (m.Fecha_de_Recepcion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Recepcion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Recepcion = m.Hora_de_Recepcion
                        ,Usuario_que_RecibeName = CultureHelper.GetTraduction(m.Usuario_que_Recibe_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Recibe_Spartan_User.Name
                        ,Numero_de_ExpedienteNumero_de_Folio = CultureHelper.GetTraduction(m.Numero_de_Expediente_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Numero_de_Expediente_Solicitud.Numero_de_Folio
                        ,RequeridoNombre_Completo = CultureHelper.GetTraduction(m.Requerido_Detalle_de_Solicitud_Requerido.Clave.ToString(), "Detalle_de_Solicitud_Requerido") ?? (string)m.Requerido_Detalle_de_Solicitud_Requerido.Nombre_Completo
			,Nombre_de_la_Persona_que_entrega = m.Nombre_de_la_Persona_que_entrega
			,Numero_de_Pago = m.Numero_de_Pago
			,Monto_del_Pago = m.Monto_del_Pago
			,Pago_Completo = m.Pago_Completo
			,Motivo_para_no_entregar_pago_completo = m.Motivo_para_no_entregar_pago_completo

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45355, arrayColumnsVisible), "Recepcion_de_Pago_MASCList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45355, arrayColumnsVisible), "Recepcion_de_Pago_MASCList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45355, arrayColumnsVisible), "Recepcion_de_Pago_MASCList_" + DateTime.Now.ToString());
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

            _IRecepcion_de_Pago_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Recepcion_de_Pago_MASCPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Recepcion_de_Pago_MASCAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Recepcion_de_Pago_MASCPropertyMapper oRecepcion_de_Pago_MASCPropertyMapper = new Recepcion_de_Pago_MASCPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oRecepcion_de_Pago_MASCPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IRecepcion_de_Pago_MASCApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Recepcion_de_Pago_MASCs == null)
                result.Recepcion_de_Pago_MASCs = new List<Recepcion_de_Pago_MASC>();

            var data = result.Recepcion_de_Pago_MASCs.Select(m => new Recepcion_de_Pago_MASCGridModel
            {
                Clave = m.Clave
                        ,Fecha_de_Recepcion = (m.Fecha_de_Recepcion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Recepcion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Recepcion = m.Hora_de_Recepcion
                        ,Usuario_que_RecibeName = CultureHelper.GetTraduction(m.Usuario_que_Recibe_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Recibe_Spartan_User.Name
                        ,Numero_de_ExpedienteNumero_de_Folio = CultureHelper.GetTraduction(m.Numero_de_Expediente_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Numero_de_Expediente_Solicitud.Numero_de_Folio
                        ,RequeridoNombre_Completo = CultureHelper.GetTraduction(m.Requerido_Detalle_de_Solicitud_Requerido.Clave.ToString(), "Detalle_de_Solicitud_Requerido") ?? (string)m.Requerido_Detalle_de_Solicitud_Requerido.Nombre_Completo
			,Nombre_de_la_Persona_que_entrega = m.Nombre_de_la_Persona_que_entrega
			,Numero_de_Pago = m.Numero_de_Pago
			,Monto_del_Pago = m.Monto_del_Pago
			,Pago_Completo = m.Pago_Completo
			,Motivo_para_no_entregar_pago_completo = m.Motivo_para_no_entregar_pago_completo

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
                _IRecepcion_de_Pago_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IRecepcion_de_Pago_MASCApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Recepcion_de_Pago_MASC_Datos_GeneralesModel varRecepcion_de_Pago_MASC)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRecepcion_de_Pago_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Recepcion_de_Pago_MASC_Datos_GeneralesInfo = new Recepcion_de_Pago_MASC_Datos_Generales
                {
                    Clave = varRecepcion_de_Pago_MASC.Clave
                                            ,Fecha_de_Recepcion = (!String.IsNullOrEmpty(varRecepcion_de_Pago_MASC.Fecha_de_Recepcion)) ? DateTime.ParseExact(varRecepcion_de_Pago_MASC.Fecha_de_Recepcion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Recepcion = varRecepcion_de_Pago_MASC.Hora_de_Recepcion
                        ,Usuario_que_Recibe = varRecepcion_de_Pago_MASC.Usuario_que_Recibe
                        ,Numero_de_Expediente = varRecepcion_de_Pago_MASC.Numero_de_Expediente
                        ,Requerido = varRecepcion_de_Pago_MASC.Requerido
                        ,Nombre_de_la_Persona_que_entrega = varRecepcion_de_Pago_MASC.Nombre_de_la_Persona_que_entrega
                        ,Numero_de_Pago = varRecepcion_de_Pago_MASC.Numero_de_Pago
                        ,Monto_del_Pago = varRecepcion_de_Pago_MASC.Monto_del_Pago
                        ,Pago_Completo = varRecepcion_de_Pago_MASC.Pago_Completo
                        ,Motivo_para_no_entregar_pago_completo = varRecepcion_de_Pago_MASC.Motivo_para_no_entregar_pago_completo
                    
                };

                result = _IRecepcion_de_Pago_MASCApiConsumer.Update_Datos_Generales(Recepcion_de_Pago_MASC_Datos_GeneralesInfo).Resource.ToString();
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
                _IRecepcion_de_Pago_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IRecepcion_de_Pago_MASCApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Recepcion_de_Pago_MASC_Datos_GeneralesModel
                {
                    Clave = m.Clave
                        ,Fecha_de_Recepcion = (m.Fecha_de_Recepcion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Recepcion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Recepcion = m.Hora_de_Recepcion
                        ,Usuario_que_Recibe = m.Usuario_que_Recibe
                        ,Usuario_que_RecibeName = CultureHelper.GetTraduction(m.Usuario_que_Recibe_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Recibe_Spartan_User.Name
                        ,Numero_de_Expediente = m.Numero_de_Expediente
                        ,Numero_de_ExpedienteNumero_de_Folio = CultureHelper.GetTraduction(m.Numero_de_Expediente_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Numero_de_Expediente_Solicitud.Numero_de_Folio
                        ,Requerido = m.Requerido
                        ,RequeridoNombre_Completo = CultureHelper.GetTraduction(m.Requerido_Detalle_de_Solicitud_Requerido.Clave.ToString(), "Detalle_de_Solicitud_Requerido") ?? (string)m.Requerido_Detalle_de_Solicitud_Requerido.Nombre_Completo
			,Nombre_de_la_Persona_que_entrega = m.Nombre_de_la_Persona_que_entrega
			,Numero_de_Pago = m.Numero_de_Pago
			,Monto_del_Pago = m.Monto_del_Pago
			,Pago_Completo = m.Pago_Completo
			,Motivo_para_no_entregar_pago_completo = m.Motivo_para_no_entregar_pago_completo

                    
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

