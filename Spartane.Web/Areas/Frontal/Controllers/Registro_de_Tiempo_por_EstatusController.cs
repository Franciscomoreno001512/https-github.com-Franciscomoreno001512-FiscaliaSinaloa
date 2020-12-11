using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Registro_de_Tiempo_por_Estatus;
using Spartane.Core.Domain.Modulo_Atencion_Inicial;
using Spartane.Core.Domain.Estatus;
using Spartane.Core.Domain.Estatus_Orientador;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Registro_de_Tiempo_por_Estatus;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Registro_de_Tiempo_por_Estatus;
using Spartane.Web.Areas.WebApiConsumer.Modulo_Atencion_Inicial;
using Spartane.Web.Areas.WebApiConsumer.Estatus;
using Spartane.Web.Areas.WebApiConsumer.Estatus_Orientador;

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
    public class Registro_de_Tiempo_por_EstatusController : Controller
    {
        #region "variable declaration"

        private IRegistro_de_Tiempo_por_EstatusService service = null;
        private IRegistro_de_Tiempo_por_EstatusApiConsumer _IRegistro_de_Tiempo_por_EstatusApiConsumer;
        private IModulo_Atencion_InicialApiConsumer _IModulo_Atencion_InicialApiConsumer;
        private IEstatusApiConsumer _IEstatusApiConsumer;
        private IEstatus_OrientadorApiConsumer _IEstatus_OrientadorApiConsumer;

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

        
        public Registro_de_Tiempo_por_EstatusController(IRegistro_de_Tiempo_por_EstatusService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IRegistro_de_Tiempo_por_EstatusApiConsumer Registro_de_Tiempo_por_EstatusApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , IModulo_Atencion_InicialApiConsumer Modulo_Atencion_InicialApiConsumer , IEstatusApiConsumer EstatusApiConsumer , IEstatus_OrientadorApiConsumer Estatus_OrientadorApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IRegistro_de_Tiempo_por_EstatusApiConsumer = Registro_de_Tiempo_por_EstatusApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_FormatApiConsumer = Spartan_FormatApiConsumer;
            this._ISpartan_Format_PermissionsApiConsumer = Spartan_Format_PermissionsApiConsumer;
            this._IGeneratePDFApiConsumer = GeneratePDFApiConsumer;
			this._ISpartan_FormatRelatedApiConsumer = Spartan_Format_RelatedApiConsumer;
            this._IModulo_Atencion_InicialApiConsumer = Modulo_Atencion_InicialApiConsumer;
            this._IEstatusApiConsumer = EstatusApiConsumer;
            this._IEstatus_OrientadorApiConsumer = Estatus_OrientadorApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Registro_de_Tiempo_por_Estatus
        [ObjectAuth(ObjectId = (ModuleObjectId)45128, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45128, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Registro_de_Tiempo_por_Estatus/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45128, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45128, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varRegistro_de_Tiempo_por_Estatus = new Registro_de_Tiempo_por_EstatusModel();
			varRegistro_de_Tiempo_por_Estatus.Clave = Id;
			
            ViewBag.ObjectId = "45128";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IRegistro_de_Tiempo_por_EstatusApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Registro_de_Tiempo_por_EstatussData = _IRegistro_de_Tiempo_por_EstatusApiConsumer.ListaSelAll(0, 1000, "Registro_de_Tiempo_por_Estatus.Clave=" + Id, "").Resource.Registro_de_Tiempo_por_Estatuss;
				
				if (Registro_de_Tiempo_por_EstatussData != null && Registro_de_Tiempo_por_EstatussData.Count > 0)
                {
					var Registro_de_Tiempo_por_EstatusData = Registro_de_Tiempo_por_EstatussData.First();
					varRegistro_de_Tiempo_por_Estatus= new Registro_de_Tiempo_por_EstatusModel
					{
						Clave  = Registro_de_Tiempo_por_EstatusData.Clave 
	                    ,Fecha = (Registro_de_Tiempo_por_EstatusData.Fecha == null ? string.Empty : Convert.ToDateTime(Registro_de_Tiempo_por_EstatusData.Fecha).ToString(ConfigurationProperty.DateFormat))
                    ,Hora = Registro_de_Tiempo_por_EstatusData.Hora
                    ,NUAT = Registro_de_Tiempo_por_EstatusData.NUAT
                    ,NUATNUAT = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Tiempo_por_EstatusData.NUAT), "Modulo_Atencion_Inicial") ??  (string)Registro_de_Tiempo_por_EstatusData.NUAT_Modulo_Atencion_Inicial.NUAT
                    ,Estatus_Interno = Registro_de_Tiempo_por_EstatusData.Estatus_Interno
                    ,Estatus_InternoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Tiempo_por_EstatusData.Estatus_Interno), "Estatus") ??  (string)Registro_de_Tiempo_por_EstatusData.Estatus_Interno_Estatus.Descripcion
                    ,Estatus = Registro_de_Tiempo_por_EstatusData.Estatus
                    ,EstatusDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Tiempo_por_EstatusData.Estatus), "Estatus_Orientador") ??  (string)Registro_de_Tiempo_por_EstatusData.Estatus_Estatus_Orientador.Descripcion
                    ,Estatus_Destino = Registro_de_Tiempo_por_EstatusData.Estatus_Destino
                    ,Tiempo_Transcurrido = Registro_de_Tiempo_por_EstatusData.Tiempo_Transcurrido

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IModulo_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modulo_Atencion_Inicials_NUAT = _IModulo_Atencion_InicialApiConsumer.SelAll(true);
            if (Modulo_Atencion_Inicials_NUAT != null && Modulo_Atencion_Inicials_NUAT.Resource != null)
                ViewBag.Modulo_Atencion_Inicials_NUAT = Modulo_Atencion_Inicials_NUAT.Resource.Where(m => m.NUAT != null).OrderBy(m => m.NUAT).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modulo_Atencion_Inicial", "NUAT") ?? m.NUAT.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatusApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatuss_Estatus_Interno = _IEstatusApiConsumer.SelAll(true);
            if (Estatuss_Estatus_Interno != null && Estatuss_Estatus_Interno.Resource != null)
                ViewBag.Estatuss_Estatus_Interno = Estatuss_Estatus_Interno.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatus_OrientadorApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_Orientadors_Estatus = _IEstatus_OrientadorApiConsumer.SelAll(true);
            if (Estatus_Orientadors_Estatus != null && Estatus_Orientadors_Estatus.Resource != null)
                ViewBag.Estatus_Orientadors_Estatus = Estatus_Orientadors_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_Orientador", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varRegistro_de_Tiempo_por_Estatus);
        }
		
	[HttpGet]
        public ActionResult AddRegistro_de_Tiempo_por_Estatus(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45128);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IRegistro_de_Tiempo_por_EstatusApiConsumer.SetAuthHeader(_tokenManager.Token);
			Registro_de_Tiempo_por_EstatusModel varRegistro_de_Tiempo_por_Estatus= new Registro_de_Tiempo_por_EstatusModel();


            if (id.ToString() != "0")
            {
                var Registro_de_Tiempo_por_EstatussData = _IRegistro_de_Tiempo_por_EstatusApiConsumer.ListaSelAll(0, 1000, "Registro_de_Tiempo_por_Estatus.Clave=" + id, "").Resource.Registro_de_Tiempo_por_Estatuss;
				
				if (Registro_de_Tiempo_por_EstatussData != null && Registro_de_Tiempo_por_EstatussData.Count > 0)
                {
					var Registro_de_Tiempo_por_EstatusData = Registro_de_Tiempo_por_EstatussData.First();
					varRegistro_de_Tiempo_por_Estatus= new Registro_de_Tiempo_por_EstatusModel
					{
						Clave  = Registro_de_Tiempo_por_EstatusData.Clave 
	                    ,Fecha = (Registro_de_Tiempo_por_EstatusData.Fecha == null ? string.Empty : Convert.ToDateTime(Registro_de_Tiempo_por_EstatusData.Fecha).ToString(ConfigurationProperty.DateFormat))
                    ,Hora = Registro_de_Tiempo_por_EstatusData.Hora
                    ,NUAT = Registro_de_Tiempo_por_EstatusData.NUAT
                    ,NUATNUAT = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Tiempo_por_EstatusData.NUAT), "Modulo_Atencion_Inicial") ??  (string)Registro_de_Tiempo_por_EstatusData.NUAT_Modulo_Atencion_Inicial.NUAT
                    ,Estatus_Interno = Registro_de_Tiempo_por_EstatusData.Estatus_Interno
                    ,Estatus_InternoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Tiempo_por_EstatusData.Estatus_Interno), "Estatus") ??  (string)Registro_de_Tiempo_por_EstatusData.Estatus_Interno_Estatus.Descripcion
                    ,Estatus = Registro_de_Tiempo_por_EstatusData.Estatus
                    ,EstatusDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Tiempo_por_EstatusData.Estatus), "Estatus_Orientador") ??  (string)Registro_de_Tiempo_por_EstatusData.Estatus_Estatus_Orientador.Descripcion
                    ,Estatus_Destino = Registro_de_Tiempo_por_EstatusData.Estatus_Destino
                    ,Tiempo_Transcurrido = Registro_de_Tiempo_por_EstatusData.Tiempo_Transcurrido

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IModulo_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modulo_Atencion_Inicials_NUAT = _IModulo_Atencion_InicialApiConsumer.SelAll(true);
            if (Modulo_Atencion_Inicials_NUAT != null && Modulo_Atencion_Inicials_NUAT.Resource != null)
                ViewBag.Modulo_Atencion_Inicials_NUAT = Modulo_Atencion_Inicials_NUAT.Resource.Where(m => m.NUAT != null).OrderBy(m => m.NUAT).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modulo_Atencion_Inicial", "NUAT") ?? m.NUAT.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatusApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatuss_Estatus_Interno = _IEstatusApiConsumer.SelAll(true);
            if (Estatuss_Estatus_Interno != null && Estatuss_Estatus_Interno.Resource != null)
                ViewBag.Estatuss_Estatus_Interno = Estatuss_Estatus_Interno.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatus_OrientadorApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_Orientadors_Estatus = _IEstatus_OrientadorApiConsumer.SelAll(true);
            if (Estatus_Orientadors_Estatus != null && Estatus_Orientadors_Estatus.Resource != null)
                ViewBag.Estatus_Orientadors_Estatus = Estatus_Orientadors_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_Orientador", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddRegistro_de_Tiempo_por_Estatus", varRegistro_de_Tiempo_por_Estatus);
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
        public ActionResult GetModulo_Atencion_InicialAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModulo_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IModulo_Atencion_InicialApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.NUAT).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modulo_Atencion_Inicial", "NUAT")?? m.NUAT,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetEstatusAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstatusApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstatusApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetEstatus_OrientadorAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstatus_OrientadorApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstatus_OrientadorApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_Orientador", "Descripcion")?? m.Descripcion,
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
        public ActionResult ShowAdvanceFilter(Registro_de_Tiempo_por_EstatusAdvanceSearchModel model, int idFilter = -1)
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

            _IModulo_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modulo_Atencion_Inicials_NUAT = _IModulo_Atencion_InicialApiConsumer.SelAll(true);
            if (Modulo_Atencion_Inicials_NUAT != null && Modulo_Atencion_Inicials_NUAT.Resource != null)
                ViewBag.Modulo_Atencion_Inicials_NUAT = Modulo_Atencion_Inicials_NUAT.Resource.Where(m => m.NUAT != null).OrderBy(m => m.NUAT).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modulo_Atencion_Inicial", "NUAT") ?? m.NUAT.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatusApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatuss_Estatus_Interno = _IEstatusApiConsumer.SelAll(true);
            if (Estatuss_Estatus_Interno != null && Estatuss_Estatus_Interno.Resource != null)
                ViewBag.Estatuss_Estatus_Interno = Estatuss_Estatus_Interno.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatus_OrientadorApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_Orientadors_Estatus = _IEstatus_OrientadorApiConsumer.SelAll(true);
            if (Estatus_Orientadors_Estatus != null && Estatus_Orientadors_Estatus.Resource != null)
                ViewBag.Estatus_Orientadors_Estatus = Estatus_Orientadors_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_Orientador", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IModulo_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modulo_Atencion_Inicials_NUAT = _IModulo_Atencion_InicialApiConsumer.SelAll(true);
            if (Modulo_Atencion_Inicials_NUAT != null && Modulo_Atencion_Inicials_NUAT.Resource != null)
                ViewBag.Modulo_Atencion_Inicials_NUAT = Modulo_Atencion_Inicials_NUAT.Resource.Where(m => m.NUAT != null).OrderBy(m => m.NUAT).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modulo_Atencion_Inicial", "NUAT") ?? m.NUAT.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatusApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatuss_Estatus_Interno = _IEstatusApiConsumer.SelAll(true);
            if (Estatuss_Estatus_Interno != null && Estatuss_Estatus_Interno.Resource != null)
                ViewBag.Estatuss_Estatus_Interno = Estatuss_Estatus_Interno.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatus_OrientadorApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_Orientadors_Estatus = _IEstatus_OrientadorApiConsumer.SelAll(true);
            if (Estatus_Orientadors_Estatus != null && Estatus_Orientadors_Estatus.Resource != null)
                ViewBag.Estatus_Orientadors_Estatus = Estatus_Orientadors_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_Orientador", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Registro_de_Tiempo_por_EstatusAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Registro_de_Tiempo_por_EstatusAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Registro_de_Tiempo_por_EstatusAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Registro_de_Tiempo_por_EstatusPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IRegistro_de_Tiempo_por_EstatusApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Registro_de_Tiempo_por_Estatuss == null)
                result.Registro_de_Tiempo_por_Estatuss = new List<Registro_de_Tiempo_por_Estatus>();

            return Json(new
            {
                data = result.Registro_de_Tiempo_por_Estatuss.Select(m => new Registro_de_Tiempo_por_EstatusGridModel
                    {
                    Clave = m.Clave
                        ,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora
                        ,NUATNUAT = CultureHelper.GetTraduction(m.NUAT_Modulo_Atencion_Inicial.Clave.ToString(), "NUAT") ?? (string)m.NUAT_Modulo_Atencion_Inicial.NUAT
                        ,Estatus_InternoDescripcion = CultureHelper.GetTraduction(m.Estatus_Interno_Estatus.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Interno_Estatus.Descripcion
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_Orientador.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_Orientador.Descripcion
			,Estatus_Destino = m.Estatus_Destino
			,Tiempo_Transcurrido = m.Tiempo_Transcurrido

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetRegistro_de_Tiempo_por_EstatusAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRegistro_de_Tiempo_por_EstatusApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IRegistro_de_Tiempo_por_EstatusApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Registro_de_Tiempo_por_Estatus", m.),
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
        /// Get List of Registro_de_Tiempo_por_Estatus from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Registro_de_Tiempo_por_Estatus Entity</returns>
        public ActionResult GetRegistro_de_Tiempo_por_EstatusList(UrlParametersModel param)
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
            _IRegistro_de_Tiempo_por_EstatusApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Registro_de_Tiempo_por_EstatusPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Registro_de_Tiempo_por_EstatusAdvanceSearchModel))
                {
					var advanceFilter =
                    (Registro_de_Tiempo_por_EstatusAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Registro_de_Tiempo_por_EstatusPropertyMapper oRegistro_de_Tiempo_por_EstatusPropertyMapper = new Registro_de_Tiempo_por_EstatusPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oRegistro_de_Tiempo_por_EstatusPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IRegistro_de_Tiempo_por_EstatusApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Registro_de_Tiempo_por_Estatuss == null)
                result.Registro_de_Tiempo_por_Estatuss = new List<Registro_de_Tiempo_por_Estatus>();

            return Json(new
            {
                aaData = result.Registro_de_Tiempo_por_Estatuss.Select(m => new Registro_de_Tiempo_por_EstatusGridModel
            {
                    Clave = m.Clave
                        ,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora
                        ,NUATNUAT = CultureHelper.GetTraduction(m.NUAT_Modulo_Atencion_Inicial.Clave.ToString(), "NUAT") ?? (string)m.NUAT_Modulo_Atencion_Inicial.NUAT
                        ,Estatus_InternoDescripcion = CultureHelper.GetTraduction(m.Estatus_Interno_Estatus.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Interno_Estatus.Descripcion
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_Orientador.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_Orientador.Descripcion
			,Estatus_Destino = m.Estatus_Destino
			,Tiempo_Transcurrido = m.Tiempo_Transcurrido

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }







        [NonAction]
        public string GetAdvanceFilter(Registro_de_Tiempo_por_EstatusAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Registro_de_Tiempo_por_Estatus.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Registro_de_Tiempo_por_Estatus.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.FromFecha) || !string.IsNullOrEmpty(filter.ToFecha))
            {
                var FechaFrom = DateTime.ParseExact(filter.FromFecha, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var FechaTo = DateTime.ParseExact(filter.ToFecha, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha))
                    where += " AND Registro_de_Tiempo_por_Estatus.Fecha >= '" + FechaFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha))
                    where += " AND Registro_de_Tiempo_por_Estatus.Fecha <= '" + FechaTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora) || !string.IsNullOrEmpty(filter.ToHora))
            {
                if (!string.IsNullOrEmpty(filter.FromHora))
                    where += " AND Convert(TIME,Registro_de_Tiempo_por_Estatus.Hora) >='" + filter.FromHora + "'";
                if (!string.IsNullOrEmpty(filter.ToHora))
                    where += " AND Convert(TIME,Registro_de_Tiempo_por_Estatus.Hora) <='" + filter.ToHora + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceNUAT))
            {
                switch (filter.NUATFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_Atencion_Inicial.NUAT LIKE '" + filter.AdvanceNUAT + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_Atencion_Inicial.NUAT LIKE '%" + filter.AdvanceNUAT + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_Atencion_Inicial.NUAT = '" + filter.AdvanceNUAT + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_Atencion_Inicial.NUAT LIKE '%" + filter.AdvanceNUAT + "%'";
                        break;
                }
            }
            else if (filter.AdvanceNUATMultiple != null && filter.AdvanceNUATMultiple.Count() > 0)
            {
                var NUATIds = string.Join(",", filter.AdvanceNUATMultiple);

                where += " AND Registro_de_Tiempo_por_Estatus.NUAT In (" + NUATIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstatus_Interno))
            {
                switch (filter.Estatus_InternoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estatus.Descripcion LIKE '" + filter.AdvanceEstatus_Interno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estatus.Descripcion LIKE '%" + filter.AdvanceEstatus_Interno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estatus.Descripcion = '" + filter.AdvanceEstatus_Interno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estatus.Descripcion LIKE '%" + filter.AdvanceEstatus_Interno + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstatus_InternoMultiple != null && filter.AdvanceEstatus_InternoMultiple.Count() > 0)
            {
                var Estatus_InternoIds = string.Join(",", filter.AdvanceEstatus_InternoMultiple);

                where += " AND Registro_de_Tiempo_por_Estatus.Estatus_Interno In (" + Estatus_InternoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstatus))
            {
                switch (filter.EstatusFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estatus_Orientador.Descripcion LIKE '" + filter.AdvanceEstatus + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estatus_Orientador.Descripcion LIKE '%" + filter.AdvanceEstatus + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estatus_Orientador.Descripcion = '" + filter.AdvanceEstatus + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estatus_Orientador.Descripcion LIKE '%" + filter.AdvanceEstatus + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstatusMultiple != null && filter.AdvanceEstatusMultiple.Count() > 0)
            {
                var EstatusIds = string.Join(",", filter.AdvanceEstatusMultiple);

                where += " AND Registro_de_Tiempo_por_Estatus.Estatus In (" + EstatusIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromEstatus_Destino) || !string.IsNullOrEmpty(filter.ToEstatus_Destino))
            {
                if (!string.IsNullOrEmpty(filter.FromEstatus_Destino))
                    where += " AND Registro_de_Tiempo_por_Estatus.Estatus_Destino >= " + filter.FromEstatus_Destino;
                if (!string.IsNullOrEmpty(filter.ToEstatus_Destino))
                    where += " AND Registro_de_Tiempo_por_Estatus.Estatus_Destino <= " + filter.ToEstatus_Destino;
            }

            if (!string.IsNullOrEmpty(filter.Tiempo_Transcurrido))
            {
                switch (filter.Tiempo_TranscurridoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Registro_de_Tiempo_por_Estatus.Tiempo_Transcurrido LIKE '" + filter.Tiempo_Transcurrido + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Registro_de_Tiempo_por_Estatus.Tiempo_Transcurrido LIKE '%" + filter.Tiempo_Transcurrido + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Registro_de_Tiempo_por_Estatus.Tiempo_Transcurrido = '" + filter.Tiempo_Transcurrido + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Registro_de_Tiempo_por_Estatus.Tiempo_Transcurrido LIKE '%" + filter.Tiempo_Transcurrido + "%'";
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
                _IRegistro_de_Tiempo_por_EstatusApiConsumer.SetAuthHeader(_tokenManager.Token);

                Registro_de_Tiempo_por_Estatus varRegistro_de_Tiempo_por_Estatus = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IRegistro_de_Tiempo_por_EstatusApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Registro_de_Tiempo_por_EstatusModel varRegistro_de_Tiempo_por_Estatus)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IRegistro_de_Tiempo_por_EstatusApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Registro_de_Tiempo_por_EstatusInfo = new Registro_de_Tiempo_por_Estatus
                    {
                        Clave = varRegistro_de_Tiempo_por_Estatus.Clave
                        ,Fecha = (!String.IsNullOrEmpty(varRegistro_de_Tiempo_por_Estatus.Fecha)) ? DateTime.ParseExact(varRegistro_de_Tiempo_por_Estatus.Fecha, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora = varRegistro_de_Tiempo_por_Estatus.Hora
                        ,NUAT = varRegistro_de_Tiempo_por_Estatus.NUAT
                        ,Estatus_Interno = varRegistro_de_Tiempo_por_Estatus.Estatus_Interno
                        ,Estatus = varRegistro_de_Tiempo_por_Estatus.Estatus
                        ,Estatus_Destino = varRegistro_de_Tiempo_por_Estatus.Estatus_Destino
                        ,Tiempo_Transcurrido = varRegistro_de_Tiempo_por_Estatus.Tiempo_Transcurrido

                    };

                    result = !IsNew ?
                        _IRegistro_de_Tiempo_por_EstatusApiConsumer.Update(Registro_de_Tiempo_por_EstatusInfo, null, null).Resource.ToString() :
                         _IRegistro_de_Tiempo_por_EstatusApiConsumer.Insert(Registro_de_Tiempo_por_EstatusInfo, null, null).Resource.ToString();
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
        /// Write Element Array of Registro_de_Tiempo_por_Estatus script
        /// </summary>
        /// <param name="oRegistro_de_Tiempo_por_EstatusElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Registro_de_Tiempo_por_EstatusModuleAttributeList)
        {
            for (int i = 0; i < Registro_de_Tiempo_por_EstatusModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Registro_de_Tiempo_por_EstatusModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Registro_de_Tiempo_por_EstatusModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Registro_de_Tiempo_por_EstatusModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Registro_de_Tiempo_por_EstatusModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Registro_de_Tiempo_por_EstatusModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Registro_de_Tiempo_por_EstatusModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Registro_de_Tiempo_por_EstatusModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Registro_de_Tiempo_por_EstatusModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Registro_de_Tiempo_por_EstatusModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Registro_de_Tiempo_por_EstatusModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Registro_de_Tiempo_por_EstatusModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strRegistro_de_Tiempo_por_EstatusScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Registro_de_Tiempo_por_Estatus.js")))
            {
                strRegistro_de_Tiempo_por_EstatusScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Registro_de_Tiempo_por_Estatus element attributes
            string userChangeJson = jsSerialize.Serialize(Registro_de_Tiempo_por_EstatusModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strRegistro_de_Tiempo_por_EstatusScript.IndexOf("inpuElementArray");
            string splittedString = strRegistro_de_Tiempo_por_EstatusScript.Substring(indexOfArray, strRegistro_de_Tiempo_por_EstatusScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Registro_de_Tiempo_por_EstatusModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Registro_de_Tiempo_por_EstatusModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strRegistro_de_Tiempo_por_EstatusScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strRegistro_de_Tiempo_por_EstatusScript.Substring(indexOfArrayHistory, strRegistro_de_Tiempo_por_EstatusScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strRegistro_de_Tiempo_por_EstatusScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strRegistro_de_Tiempo_por_EstatusScript.Substring(endIndexOfMainElement + indexOfArray, strRegistro_de_Tiempo_por_EstatusScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Registro_de_Tiempo_por_EstatusModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Registro_de_Tiempo_por_EstatusModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Registro_de_Tiempo_por_Estatus.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Registro_de_Tiempo_por_Estatus.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Registro_de_Tiempo_por_Estatus.js")))
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
        public ActionResult Registro_de_Tiempo_por_EstatusPropertyBag()
        {
            return PartialView("Registro_de_Tiempo_por_EstatusPropertyBag", "Registro_de_Tiempo_por_Estatus");
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
                var whereClauseFormat = "Object = 45128 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IRegistro_de_Tiempo_por_EstatusApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Registro_de_Tiempo_por_Estatus.Clave= " + RecordId;
                            var result = _IRegistro_de_Tiempo_por_EstatusApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IRegistro_de_Tiempo_por_EstatusApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Registro_de_Tiempo_por_EstatusPropertyMapper());
			
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
                    (Registro_de_Tiempo_por_EstatusAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Registro_de_Tiempo_por_EstatusPropertyMapper oRegistro_de_Tiempo_por_EstatusPropertyMapper = new Registro_de_Tiempo_por_EstatusPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oRegistro_de_Tiempo_por_EstatusPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IRegistro_de_Tiempo_por_EstatusApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Registro_de_Tiempo_por_Estatuss == null)
                result.Registro_de_Tiempo_por_Estatuss = new List<Registro_de_Tiempo_por_Estatus>();

            var data = result.Registro_de_Tiempo_por_Estatuss.Select(m => new Registro_de_Tiempo_por_EstatusGridModel
            {
                Clave = m.Clave
                        ,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora
                        ,NUATNUAT = CultureHelper.GetTraduction(m.NUAT_Modulo_Atencion_Inicial.Clave.ToString(), "NUAT") ?? (string)m.NUAT_Modulo_Atencion_Inicial.NUAT
                        ,Estatus_InternoDescripcion = CultureHelper.GetTraduction(m.Estatus_Interno_Estatus.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Interno_Estatus.Descripcion
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_Orientador.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_Orientador.Descripcion
			,Estatus_Destino = m.Estatus_Destino
			,Tiempo_Transcurrido = m.Tiempo_Transcurrido

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45128, arrayColumnsVisible), "Registro_de_Tiempo_por_EstatusList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45128, arrayColumnsVisible), "Registro_de_Tiempo_por_EstatusList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45128, arrayColumnsVisible), "Registro_de_Tiempo_por_EstatusList_" + DateTime.Now.ToString());
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

            _IRegistro_de_Tiempo_por_EstatusApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Registro_de_Tiempo_por_EstatusPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Registro_de_Tiempo_por_EstatusAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Registro_de_Tiempo_por_EstatusPropertyMapper oRegistro_de_Tiempo_por_EstatusPropertyMapper = new Registro_de_Tiempo_por_EstatusPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oRegistro_de_Tiempo_por_EstatusPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IRegistro_de_Tiempo_por_EstatusApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Registro_de_Tiempo_por_Estatuss == null)
                result.Registro_de_Tiempo_por_Estatuss = new List<Registro_de_Tiempo_por_Estatus>();

            var data = result.Registro_de_Tiempo_por_Estatuss.Select(m => new Registro_de_Tiempo_por_EstatusGridModel
            {
                Clave = m.Clave
                        ,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora
                        ,NUATNUAT = CultureHelper.GetTraduction(m.NUAT_Modulo_Atencion_Inicial.Clave.ToString(), "NUAT") ?? (string)m.NUAT_Modulo_Atencion_Inicial.NUAT
                        ,Estatus_InternoDescripcion = CultureHelper.GetTraduction(m.Estatus_Interno_Estatus.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Interno_Estatus.Descripcion
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_Orientador.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_Orientador.Descripcion
			,Estatus_Destino = m.Estatus_Destino
			,Tiempo_Transcurrido = m.Tiempo_Transcurrido

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
                _IRegistro_de_Tiempo_por_EstatusApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IRegistro_de_Tiempo_por_EstatusApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Registro_de_Tiempo_por_Estatus_Datos_GeneralesModel varRegistro_de_Tiempo_por_Estatus)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRegistro_de_Tiempo_por_EstatusApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Registro_de_Tiempo_por_Estatus_Datos_GeneralesInfo = new Registro_de_Tiempo_por_Estatus_Datos_Generales
                {
                    Clave = varRegistro_de_Tiempo_por_Estatus.Clave
                                            ,Fecha = (!String.IsNullOrEmpty(varRegistro_de_Tiempo_por_Estatus.Fecha)) ? DateTime.ParseExact(varRegistro_de_Tiempo_por_Estatus.Fecha, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora = varRegistro_de_Tiempo_por_Estatus.Hora
                        ,NUAT = varRegistro_de_Tiempo_por_Estatus.NUAT
                        ,Estatus_Interno = varRegistro_de_Tiempo_por_Estatus.Estatus_Interno
                        ,Estatus = varRegistro_de_Tiempo_por_Estatus.Estatus
                        ,Estatus_Destino = varRegistro_de_Tiempo_por_Estatus.Estatus_Destino
                        ,Tiempo_Transcurrido = varRegistro_de_Tiempo_por_Estatus.Tiempo_Transcurrido
                    
                };

                result = _IRegistro_de_Tiempo_por_EstatusApiConsumer.Update_Datos_Generales(Registro_de_Tiempo_por_Estatus_Datos_GeneralesInfo).Resource.ToString();
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
                _IRegistro_de_Tiempo_por_EstatusApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IRegistro_de_Tiempo_por_EstatusApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Registro_de_Tiempo_por_Estatus_Datos_GeneralesModel
                {
                    Clave = m.Clave
                        ,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora
                        ,NUAT = m.NUAT
                        ,NUATNUAT = CultureHelper.GetTraduction(m.NUAT_Modulo_Atencion_Inicial.Clave.ToString(), "NUAT") ?? (string)m.NUAT_Modulo_Atencion_Inicial.NUAT
                        ,Estatus_Interno = m.Estatus_Interno
                        ,Estatus_InternoDescripcion = CultureHelper.GetTraduction(m.Estatus_Interno_Estatus.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Interno_Estatus.Descripcion
                        ,Estatus = m.Estatus
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_Orientador.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_Orientador.Descripcion
			,Estatus_Destino = m.Estatus_Destino
			,Tiempo_Transcurrido = m.Tiempo_Transcurrido

                    
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

