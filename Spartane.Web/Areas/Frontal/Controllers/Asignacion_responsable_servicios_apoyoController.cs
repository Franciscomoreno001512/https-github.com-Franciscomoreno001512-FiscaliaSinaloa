using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Asignacion_responsable_servicios_apoyo;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Area_de_Servicios_de_Apoyo;
using Spartane.Core.Domain.Detalle_subareas_responsable_servicio_apoyo;

using Spartane.Core.Domain.SubArea_de_Servicios_de_Apoyo;


using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Asignacion_responsable_servicios_apoyo;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Asignacion_responsable_servicios_apoyo;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Area_de_Servicios_de_Apoyo;
using Spartane.Web.Areas.WebApiConsumer.Detalle_subareas_responsable_servicio_apoyo;

using Spartane.Web.Areas.WebApiConsumer.SubArea_de_Servicios_de_Apoyo;


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
    public class Asignacion_responsable_servicios_apoyoController : Controller
    {
        #region "variable declaration"

        private IAsignacion_responsable_servicios_apoyoService service = null;
        private IAsignacion_responsable_servicios_apoyoApiConsumer _IAsignacion_responsable_servicios_apoyoApiConsumer;
        private ISpartan_UserApiConsumer _ISpartan_UserApiConsumer;
        private IArea_de_Servicios_de_ApoyoApiConsumer _IArea_de_Servicios_de_ApoyoApiConsumer;
        private IDetalle_subareas_responsable_servicio_apoyoApiConsumer _IDetalle_subareas_responsable_servicio_apoyoApiConsumer;

        private ISubArea_de_Servicios_de_ApoyoApiConsumer _ISubArea_de_Servicios_de_ApoyoApiConsumer;


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

        
        public Asignacion_responsable_servicios_apoyoController(IAsignacion_responsable_servicios_apoyoService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IAsignacion_responsable_servicios_apoyoApiConsumer Asignacion_responsable_servicios_apoyoApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , ISpartan_UserApiConsumer Spartan_UserApiConsumer , IArea_de_Servicios_de_ApoyoApiConsumer Area_de_Servicios_de_ApoyoApiConsumer , IDetalle_subareas_responsable_servicio_apoyoApiConsumer Detalle_subareas_responsable_servicio_apoyoApiConsumer , ISubArea_de_Servicios_de_ApoyoApiConsumer SubArea_de_Servicios_de_ApoyoApiConsumer  )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IAsignacion_responsable_servicios_apoyoApiConsumer = Asignacion_responsable_servicios_apoyoApiConsumer;
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
            this._IArea_de_Servicios_de_ApoyoApiConsumer = Area_de_Servicios_de_ApoyoApiConsumer;
            this._IDetalle_subareas_responsable_servicio_apoyoApiConsumer = Detalle_subareas_responsable_servicio_apoyoApiConsumer;

            this._ISubArea_de_Servicios_de_ApoyoApiConsumer = SubArea_de_Servicios_de_ApoyoApiConsumer;


        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Asignacion_responsable_servicios_apoyo
        [ObjectAuth(ObjectId = (ModuleObjectId)46226, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 46226, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Asignacion_responsable_servicios_apoyo/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)46226, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 46226, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varAsignacion_responsable_servicios_apoyo = new Asignacion_responsable_servicios_apoyoModel();
			varAsignacion_responsable_servicios_apoyo.Clave = Id;
			
            ViewBag.ObjectId = "46226";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;

            var permissionDetalle_subareas_responsable_servicio_apoyo = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 46227, ModuleId);
            ViewBag.PermissionDetalle_subareas_responsable_servicio_apoyo = permissionDetalle_subareas_responsable_servicio_apoyo;


            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IAsignacion_responsable_servicios_apoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Asignacion_responsable_servicios_apoyosData = _IAsignacion_responsable_servicios_apoyoApiConsumer.ListaSelAll(0, 1000, "Asignacion_responsable_servicios_apoyo.Clave=" + Id, "").Resource.Asignacion_responsable_servicios_apoyos;
				
				if (Asignacion_responsable_servicios_apoyosData != null && Asignacion_responsable_servicios_apoyosData.Count > 0)
                {
					var Asignacion_responsable_servicios_apoyoData = Asignacion_responsable_servicios_apoyosData.First();
					varAsignacion_responsable_servicios_apoyo= new Asignacion_responsable_servicios_apoyoModel
					{
						Clave  = Asignacion_responsable_servicios_apoyoData.Clave 
	                    ,Usuario = Asignacion_responsable_servicios_apoyoData.Usuario
                    ,UsuarioName = CultureHelper.GetTraduction(Convert.ToString(Asignacion_responsable_servicios_apoyoData.Usuario), "Spartan_User") ??  (string)Asignacion_responsable_servicios_apoyoData.Usuario_Spartan_User.Name
                    ,Area_Asignada = Asignacion_responsable_servicios_apoyoData.Area_Asignada
                    ,Area_AsignadaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Asignacion_responsable_servicios_apoyoData.Area_Asignada), "Area_de_Servicios_de_Apoyo") ??  (string)Asignacion_responsable_servicios_apoyoData.Area_Asignada_Area_de_Servicios_de_Apoyo.Descripcion

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IArea_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Area_de_Servicios_de_Apoyos_Area_Asignada = _IArea_de_Servicios_de_ApoyoApiConsumer.SelAll(true);
            if (Area_de_Servicios_de_Apoyos_Area_Asignada != null && Area_de_Servicios_de_Apoyos_Area_Asignada.Resource != null)
                ViewBag.Area_de_Servicios_de_Apoyos_Area_Asignada = Area_de_Servicios_de_Apoyos_Area_Asignada.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Area_de_Servicios_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varAsignacion_responsable_servicios_apoyo);
        }
		
	[HttpGet]
        public ActionResult AddAsignacion_responsable_servicios_apoyo(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 46226);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IAsignacion_responsable_servicios_apoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
			Asignacion_responsable_servicios_apoyoModel varAsignacion_responsable_servicios_apoyo= new Asignacion_responsable_servicios_apoyoModel();
            var permissionDetalle_subareas_responsable_servicio_apoyo = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 46227, ModuleId);
            ViewBag.PermissionDetalle_subareas_responsable_servicio_apoyo = permissionDetalle_subareas_responsable_servicio_apoyo;


            if (id.ToString() != "0")
            {
                var Asignacion_responsable_servicios_apoyosData = _IAsignacion_responsable_servicios_apoyoApiConsumer.ListaSelAll(0, 1000, "Asignacion_responsable_servicios_apoyo.Clave=" + id, "").Resource.Asignacion_responsable_servicios_apoyos;
				
				if (Asignacion_responsable_servicios_apoyosData != null && Asignacion_responsable_servicios_apoyosData.Count > 0)
                {
					var Asignacion_responsable_servicios_apoyoData = Asignacion_responsable_servicios_apoyosData.First();
					varAsignacion_responsable_servicios_apoyo= new Asignacion_responsable_servicios_apoyoModel
					{
						Clave  = Asignacion_responsable_servicios_apoyoData.Clave 
	                    ,Usuario = Asignacion_responsable_servicios_apoyoData.Usuario
                    ,UsuarioName = CultureHelper.GetTraduction(Convert.ToString(Asignacion_responsable_servicios_apoyoData.Usuario), "Spartan_User") ??  (string)Asignacion_responsable_servicios_apoyoData.Usuario_Spartan_User.Name
                    ,Area_Asignada = Asignacion_responsable_servicios_apoyoData.Area_Asignada
                    ,Area_AsignadaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Asignacion_responsable_servicios_apoyoData.Area_Asignada), "Area_de_Servicios_de_Apoyo") ??  (string)Asignacion_responsable_servicios_apoyoData.Area_Asignada_Area_de_Servicios_de_Apoyo.Descripcion

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IArea_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Area_de_Servicios_de_Apoyos_Area_Asignada = _IArea_de_Servicios_de_ApoyoApiConsumer.SelAll(true);
            if (Area_de_Servicios_de_Apoyos_Area_Asignada != null && Area_de_Servicios_de_Apoyos_Area_Asignada.Resource != null)
                ViewBag.Area_de_Servicios_de_Apoyos_Area_Asignada = Area_de_Servicios_de_Apoyos_Area_Asignada.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Area_de_Servicios_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddAsignacion_responsable_servicios_apoyo", varAsignacion_responsable_servicios_apoyo);
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
        public ActionResult GetArea_de_Servicios_de_ApoyoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IArea_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IArea_de_Servicios_de_ApoyoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Area_de_Servicios_de_Apoyo", "Descripcion")?? m.Descripcion,
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
        public ActionResult ShowAdvanceFilter(Asignacion_responsable_servicios_apoyoAdvanceSearchModel model, int idFilter = -1)
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

            _IArea_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Area_de_Servicios_de_Apoyos_Area_Asignada = _IArea_de_Servicios_de_ApoyoApiConsumer.SelAll(true);
            if (Area_de_Servicios_de_Apoyos_Area_Asignada != null && Area_de_Servicios_de_Apoyos_Area_Asignada.Resource != null)
                ViewBag.Area_de_Servicios_de_Apoyos_Area_Asignada = Area_de_Servicios_de_Apoyos_Area_Asignada.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Area_de_Servicios_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IArea_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Area_de_Servicios_de_Apoyos_Area_Asignada = _IArea_de_Servicios_de_ApoyoApiConsumer.SelAll(true);
            if (Area_de_Servicios_de_Apoyos_Area_Asignada != null && Area_de_Servicios_de_Apoyos_Area_Asignada.Resource != null)
                ViewBag.Area_de_Servicios_de_Apoyos_Area_Asignada = Area_de_Servicios_de_Apoyos_Area_Asignada.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Area_de_Servicios_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Asignacion_responsable_servicios_apoyoAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Asignacion_responsable_servicios_apoyoAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Asignacion_responsable_servicios_apoyoAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Asignacion_responsable_servicios_apoyoPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IAsignacion_responsable_servicios_apoyoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Asignacion_responsable_servicios_apoyos == null)
                result.Asignacion_responsable_servicios_apoyos = new List<Asignacion_responsable_servicios_apoyo>();

            return Json(new
            {
                data = result.Asignacion_responsable_servicios_apoyos.Select(m => new Asignacion_responsable_servicios_apoyoGridModel
                    {
                    Clave = m.Clave
                        ,UsuarioName = CultureHelper.GetTraduction(m.Usuario_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_Spartan_User.Name
                        ,Area_AsignadaDescripcion = CultureHelper.GetTraduction(m.Area_Asignada_Area_de_Servicios_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.Area_Asignada_Area_de_Servicios_de_Apoyo.Descripcion

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetAsignacion_responsable_servicios_apoyoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IAsignacion_responsable_servicios_apoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IAsignacion_responsable_servicios_apoyoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Asignacion_responsable_servicios_apoyo", m.),
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
        /// Get List of Asignacion_responsable_servicios_apoyo from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Asignacion_responsable_servicios_apoyo Entity</returns>
        public ActionResult GetAsignacion_responsable_servicios_apoyoList(UrlParametersModel param)
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
            _IAsignacion_responsable_servicios_apoyoApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Asignacion_responsable_servicios_apoyoPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Asignacion_responsable_servicios_apoyoAdvanceSearchModel))
                {
					var advanceFilter =
                    (Asignacion_responsable_servicios_apoyoAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Asignacion_responsable_servicios_apoyoPropertyMapper oAsignacion_responsable_servicios_apoyoPropertyMapper = new Asignacion_responsable_servicios_apoyoPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oAsignacion_responsable_servicios_apoyoPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IAsignacion_responsable_servicios_apoyoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Asignacion_responsable_servicios_apoyos == null)
                result.Asignacion_responsable_servicios_apoyos = new List<Asignacion_responsable_servicios_apoyo>();

            return Json(new
            {
                aaData = result.Asignacion_responsable_servicios_apoyos.Select(m => new Asignacion_responsable_servicios_apoyoGridModel
            {
                    Clave = m.Clave
                        ,UsuarioName = CultureHelper.GetTraduction(m.Usuario_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_Spartan_User.Name
                        ,Area_AsignadaDescripcion = CultureHelper.GetTraduction(m.Area_Asignada_Area_de_Servicios_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.Area_Asignada_Area_de_Servicios_de_Apoyo.Descripcion

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetAsignacion_responsable_servicios_apoyo_Usuario_Spartan_User(string query, string where)
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
//Grid GetAutoComplete






        [NonAction]
        public string GetAdvanceFilter(Asignacion_responsable_servicios_apoyoAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Asignacion_responsable_servicios_apoyo.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Asignacion_responsable_servicios_apoyo.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceUsuario))
            {
                switch (filter.UsuarioFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_User.Name LIKE '" + filter.AdvanceUsuario + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceUsuario + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_User.Name = '" + filter.AdvanceUsuario + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceUsuario + "%'";
                        break;
                }
            }
            else if (filter.AdvanceUsuarioMultiple != null && filter.AdvanceUsuarioMultiple.Count() > 0)
            {
                var UsuarioIds = string.Join(",", filter.AdvanceUsuarioMultiple);

                where += " AND Asignacion_responsable_servicios_apoyo.Usuario In (" + UsuarioIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceArea_Asignada))
            {
                switch (filter.Area_AsignadaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Area_de_Servicios_de_Apoyo.Descripcion LIKE '" + filter.AdvanceArea_Asignada + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Area_de_Servicios_de_Apoyo.Descripcion LIKE '%" + filter.AdvanceArea_Asignada + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Area_de_Servicios_de_Apoyo.Descripcion = '" + filter.AdvanceArea_Asignada + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Area_de_Servicios_de_Apoyo.Descripcion LIKE '%" + filter.AdvanceArea_Asignada + "%'";
                        break;
                }
            }
            else if (filter.AdvanceArea_AsignadaMultiple != null && filter.AdvanceArea_AsignadaMultiple.Count() > 0)
            {
                var Area_AsignadaIds = string.Join(",", filter.AdvanceArea_AsignadaMultiple);

                where += " AND Asignacion_responsable_servicios_apoyo.Area_Asignada In (" + Area_AsignadaIds + ")";
            }


            where = new Regex(Regex.Escape("AND ")).Replace(where, "", 1);
            return where;
        }

        [NonAction]
        public Grid_File ConvertSpartane_FileToGridFile(Spartane.Core.Domain.Spartane_File.Spartane_File file)
        {
            return file == null ? new Grid_File { FileId = 0, FileSize = 0, FileName = "" } : new Grid_File { FileId = file.File_Id, FileName = file.Description, FileSize = file.File_Size ?? 0, };
        }

        public ActionResult GetDetalle_subareas_responsable_servicio_apoyo(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_subareas_responsable_servicio_apoyoGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_subareas_responsable_servicio_apoyoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_subareas_responsable_servicio_apoyo.Asignacion=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_subareas_responsable_servicio_apoyo.Asignacion='" + RelationId + "'";
            }
            var result = _IDetalle_subareas_responsable_servicio_apoyoApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_subareas_responsable_servicio_apoyos == null)
                result.Detalle_subareas_responsable_servicio_apoyos = new List<Detalle_subareas_responsable_servicio_apoyo>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_subareas_responsable_servicio_apoyos.Select(m => new Detalle_subareas_responsable_servicio_apoyoGridModel
                {
                    Clave = m.Clave

                        ,SubArea_Asignada = m.SubArea_Asignada
                        ,SubArea_AsignadaDescripcion = CultureHelper.GetTraduction(m.SubArea_Asignada_SubArea_de_Servicios_de_Apoyo.Clave.ToString(), "Descripcion") ??(string)m.SubArea_Asignada_SubArea_de_Servicios_de_Apoyo.Descripcion

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_subareas_responsable_servicio_apoyoGridModel> GetDetalle_subareas_responsable_servicio_apoyoData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_subareas_responsable_servicio_apoyoGridModel> resultData = new List<Detalle_subareas_responsable_servicio_apoyoGridModel>();
            string where = "Detalle_subareas_responsable_servicio_apoyo.Asignacion=" + Id;
            if("int" == "string")
            {
                where = "Detalle_subareas_responsable_servicio_apoyo.Asignacion='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_subareas_responsable_servicio_apoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_subareas_responsable_servicio_apoyoApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_subareas_responsable_servicio_apoyos != null)
            {
                resultData = result.Detalle_subareas_responsable_servicio_apoyos.Select(m => new Detalle_subareas_responsable_servicio_apoyoGridModel
                    {
                        Clave = m.Clave

                        ,SubArea_Asignada = m.SubArea_Asignada
                        ,SubArea_AsignadaDescripcion = CultureHelper.GetTraduction(m.SubArea_Asignada_SubArea_de_Servicios_de_Apoyo.Clave.ToString(), "Descripcion") ??(string)m.SubArea_Asignada_SubArea_de_Servicios_de_Apoyo.Descripcion


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
                _IAsignacion_responsable_servicios_apoyoApiConsumer.SetAuthHeader(_tokenManager.Token);

                Asignacion_responsable_servicios_apoyo varAsignacion_responsable_servicios_apoyo = null;
                if (id.ToString() != "0")
                {
                        string where = "";
                    _IDetalle_subareas_responsable_servicio_apoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_subareas_responsable_servicio_apoyo.Asignacion=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_subareas_responsable_servicio_apoyo.Asignacion='" + id + "'";
                    }
                    var Detalle_subareas_responsable_servicio_apoyoInfo =
                        _IDetalle_subareas_responsable_servicio_apoyoApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_subareas_responsable_servicio_apoyoInfo.Detalle_subareas_responsable_servicio_apoyos.Count > 0)
                    {
                        var resultDetalle_subareas_responsable_servicio_apoyo = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_subareas_responsable_servicio_apoyoItem in Detalle_subareas_responsable_servicio_apoyoInfo.Detalle_subareas_responsable_servicio_apoyos)
                            resultDetalle_subareas_responsable_servicio_apoyo = resultDetalle_subareas_responsable_servicio_apoyo
                                              && _IDetalle_subareas_responsable_servicio_apoyoApiConsumer.Delete(Detalle_subareas_responsable_servicio_apoyoItem.Clave, null,null).Resource;

                        if (!resultDetalle_subareas_responsable_servicio_apoyo)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }

                }
                var result = _IAsignacion_responsable_servicios_apoyoApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Asignacion_responsable_servicios_apoyoModel varAsignacion_responsable_servicios_apoyo)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IAsignacion_responsable_servicios_apoyoApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Asignacion_responsable_servicios_apoyoInfo = new Asignacion_responsable_servicios_apoyo
                    {
                        Clave = varAsignacion_responsable_servicios_apoyo.Clave
                        ,Usuario = varAsignacion_responsable_servicios_apoyo.Usuario
                        ,Area_Asignada = varAsignacion_responsable_servicios_apoyo.Area_Asignada

                    };

                    result = !IsNew ?
                        _IAsignacion_responsable_servicios_apoyoApiConsumer.Update(Asignacion_responsable_servicios_apoyoInfo, null, null).Resource.ToString() :
                         _IAsignacion_responsable_servicios_apoyoApiConsumer.Insert(Asignacion_responsable_servicios_apoyoInfo, null, null).Resource.ToString();
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
        public bool CopyDetalle_subareas_responsable_servicio_apoyo(int MasterId, int referenceId, List<Detalle_subareas_responsable_servicio_apoyoGridModelPost> Detalle_subareas_responsable_servicio_apoyoItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_subareas_responsable_servicio_apoyoApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_subareas_responsable_servicio_apoyoData = _IDetalle_subareas_responsable_servicio_apoyoApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_subareas_responsable_servicio_apoyo.Asignacion=" + referenceId,"").Resource;
                if (Detalle_subareas_responsable_servicio_apoyoData == null || Detalle_subareas_responsable_servicio_apoyoData.Detalle_subareas_responsable_servicio_apoyos.Count == 0)
                    return true;

                var result = true;

                Detalle_subareas_responsable_servicio_apoyoGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_subareas_responsable_servicio_apoyo in Detalle_subareas_responsable_servicio_apoyoData.Detalle_subareas_responsable_servicio_apoyos)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_subareas_responsable_servicio_apoyo Detalle_subareas_responsable_servicio_apoyo1 = varDetalle_subareas_responsable_servicio_apoyo;

                    if (Detalle_subareas_responsable_servicio_apoyoItems != null && Detalle_subareas_responsable_servicio_apoyoItems.Any(m => m.Clave == Detalle_subareas_responsable_servicio_apoyo1.Clave))
                    {
                        modelDataToChange = Detalle_subareas_responsable_servicio_apoyoItems.FirstOrDefault(m => m.Clave == Detalle_subareas_responsable_servicio_apoyo1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_subareas_responsable_servicio_apoyo.Asignacion = MasterId;
                    var insertId = _IDetalle_subareas_responsable_servicio_apoyoApiConsumer.Insert(varDetalle_subareas_responsable_servicio_apoyo,null,null).Resource;
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
        public ActionResult PostDetalle_subareas_responsable_servicio_apoyo(List<Detalle_subareas_responsable_servicio_apoyoGridModelPost> Detalle_subareas_responsable_servicio_apoyoItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_subareas_responsable_servicio_apoyo(MasterId, referenceId, Detalle_subareas_responsable_servicio_apoyoItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_subareas_responsable_servicio_apoyoItems != null && Detalle_subareas_responsable_servicio_apoyoItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_subareas_responsable_servicio_apoyoApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_subareas_responsable_servicio_apoyoItem in Detalle_subareas_responsable_servicio_apoyoItems)
                    {



                        //Removal Request
                        if (Detalle_subareas_responsable_servicio_apoyoItem.Removed)
                        {
                            result = result && _IDetalle_subareas_responsable_servicio_apoyoApiConsumer.Delete(Detalle_subareas_responsable_servicio_apoyoItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_subareas_responsable_servicio_apoyoItem.Clave = 0;

                        var Detalle_subareas_responsable_servicio_apoyoData = new Detalle_subareas_responsable_servicio_apoyo
                        {
                            Asignacion = MasterId
                            ,Clave = Detalle_subareas_responsable_servicio_apoyoItem.Clave
                            ,SubArea_Asignada = (Convert.ToInt32(Detalle_subareas_responsable_servicio_apoyoItem.SubArea_Asignada) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_subareas_responsable_servicio_apoyoItem.SubArea_Asignada))

                        };

                        var resultId = Detalle_subareas_responsable_servicio_apoyoItem.Clave > 0
                           ? _IDetalle_subareas_responsable_servicio_apoyoApiConsumer.Update(Detalle_subareas_responsable_servicio_apoyoData,null,null).Resource
                           : _IDetalle_subareas_responsable_servicio_apoyoApiConsumer.Insert(Detalle_subareas_responsable_servicio_apoyoData,null,null).Resource;

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
        public ActionResult GetDetalle_subareas_responsable_servicio_apoyo_SubArea_de_Servicios_de_ApoyoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISubArea_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISubArea_de_Servicios_de_ApoyoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "SubArea_de_Servicios_de_Apoyo", "Descripcion");
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
        /// Write Element Array of Asignacion_responsable_servicios_apoyo script
        /// </summary>
        /// <param name="oAsignacion_responsable_servicios_apoyoElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Asignacion_responsable_servicios_apoyoModuleAttributeList)
        {
            for (int i = 0; i < Asignacion_responsable_servicios_apoyoModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Asignacion_responsable_servicios_apoyoModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Asignacion_responsable_servicios_apoyoModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Asignacion_responsable_servicios_apoyoModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Asignacion_responsable_servicios_apoyoModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Asignacion_responsable_servicios_apoyoModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Asignacion_responsable_servicios_apoyoModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Asignacion_responsable_servicios_apoyoModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Asignacion_responsable_servicios_apoyoModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Asignacion_responsable_servicios_apoyoModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Asignacion_responsable_servicios_apoyoModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Asignacion_responsable_servicios_apoyoModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strAsignacion_responsable_servicios_apoyoScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Asignacion_responsable_servicios_apoyo.js")))
            {
                strAsignacion_responsable_servicios_apoyoScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Asignacion_responsable_servicios_apoyo element attributes
            string userChangeJson = jsSerialize.Serialize(Asignacion_responsable_servicios_apoyoModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strAsignacion_responsable_servicios_apoyoScript.IndexOf("inpuElementArray");
            string splittedString = strAsignacion_responsable_servicios_apoyoScript.Substring(indexOfArray, strAsignacion_responsable_servicios_apoyoScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Asignacion_responsable_servicios_apoyoModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Asignacion_responsable_servicios_apoyoModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strAsignacion_responsable_servicios_apoyoScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strAsignacion_responsable_servicios_apoyoScript.Substring(indexOfArrayHistory, strAsignacion_responsable_servicios_apoyoScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strAsignacion_responsable_servicios_apoyoScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strAsignacion_responsable_servicios_apoyoScript.Substring(endIndexOfMainElement + indexOfArray, strAsignacion_responsable_servicios_apoyoScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Asignacion_responsable_servicios_apoyoModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Asignacion_responsable_servicios_apoyoModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Asignacion_responsable_servicios_apoyo.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Asignacion_responsable_servicios_apoyo.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Asignacion_responsable_servicios_apoyo.js")))
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
        public ActionResult Asignacion_responsable_servicios_apoyoPropertyBag()
        {
            return PartialView("Asignacion_responsable_servicios_apoyoPropertyBag", "Asignacion_responsable_servicios_apoyo");
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
        public ActionResult AddDetalle_subareas_responsable_servicio_apoyo(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_subareas_responsable_servicio_apoyo/AddDetalle_subareas_responsable_servicio_apoyo");
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
                var whereClauseFormat = "Object = 46226 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IAsignacion_responsable_servicios_apoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Asignacion_responsable_servicios_apoyo.Clave= " + RecordId;
                            var result = _IAsignacion_responsable_servicios_apoyoApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IAsignacion_responsable_servicios_apoyoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Asignacion_responsable_servicios_apoyoPropertyMapper());
			
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
                    (Asignacion_responsable_servicios_apoyoAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Asignacion_responsable_servicios_apoyoPropertyMapper oAsignacion_responsable_servicios_apoyoPropertyMapper = new Asignacion_responsable_servicios_apoyoPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oAsignacion_responsable_servicios_apoyoPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IAsignacion_responsable_servicios_apoyoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Asignacion_responsable_servicios_apoyos == null)
                result.Asignacion_responsable_servicios_apoyos = new List<Asignacion_responsable_servicios_apoyo>();

            var data = result.Asignacion_responsable_servicios_apoyos.Select(m => new Asignacion_responsable_servicios_apoyoGridModel
            {
                Clave = m.Clave
                        ,UsuarioName = CultureHelper.GetTraduction(m.Usuario_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_Spartan_User.Name
                        ,Area_AsignadaDescripcion = CultureHelper.GetTraduction(m.Area_Asignada_Area_de_Servicios_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.Area_Asignada_Area_de_Servicios_de_Apoyo.Descripcion

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(46226, arrayColumnsVisible), "Asignacion_responsable_servicios_apoyoList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(46226, arrayColumnsVisible), "Asignacion_responsable_servicios_apoyoList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(46226, arrayColumnsVisible), "Asignacion_responsable_servicios_apoyoList_" + DateTime.Now.ToString());
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

            _IAsignacion_responsable_servicios_apoyoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Asignacion_responsable_servicios_apoyoPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Asignacion_responsable_servicios_apoyoAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Asignacion_responsable_servicios_apoyoPropertyMapper oAsignacion_responsable_servicios_apoyoPropertyMapper = new Asignacion_responsable_servicios_apoyoPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oAsignacion_responsable_servicios_apoyoPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IAsignacion_responsable_servicios_apoyoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Asignacion_responsable_servicios_apoyos == null)
                result.Asignacion_responsable_servicios_apoyos = new List<Asignacion_responsable_servicios_apoyo>();

            var data = result.Asignacion_responsable_servicios_apoyos.Select(m => new Asignacion_responsable_servicios_apoyoGridModel
            {
                Clave = m.Clave
                        ,UsuarioName = CultureHelper.GetTraduction(m.Usuario_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_Spartan_User.Name
                        ,Area_AsignadaDescripcion = CultureHelper.GetTraduction(m.Area_Asignada_Area_de_Servicios_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.Area_Asignada_Area_de_Servicios_de_Apoyo.Descripcion

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
                _IAsignacion_responsable_servicios_apoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IAsignacion_responsable_servicios_apoyoApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Asignacion_responsable_servicios_apoyo_Datos_GeneralesModel varAsignacion_responsable_servicios_apoyo)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IAsignacion_responsable_servicios_apoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Asignacion_responsable_servicios_apoyo_Datos_GeneralesInfo = new Asignacion_responsable_servicios_apoyo_Datos_Generales
                {
                    Clave = varAsignacion_responsable_servicios_apoyo.Clave
                                            ,Usuario = varAsignacion_responsable_servicios_apoyo.Usuario
                        ,Area_Asignada = varAsignacion_responsable_servicios_apoyo.Area_Asignada
                    
                };

                result = _IAsignacion_responsable_servicios_apoyoApiConsumer.Update_Datos_Generales(Asignacion_responsable_servicios_apoyo_Datos_GeneralesInfo).Resource.ToString();
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
                _IAsignacion_responsable_servicios_apoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IAsignacion_responsable_servicios_apoyoApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_subareas_responsable_servicio_apoyo;
                var Detalle_subareas_responsable_servicio_apoyoData = GetDetalle_subareas_responsable_servicio_apoyoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_subareas_responsable_servicio_apoyo);

                var result = new Asignacion_responsable_servicios_apoyo_Datos_GeneralesModel
                {
                    Clave = m.Clave
                        ,Usuario = m.Usuario
                        ,UsuarioName = CultureHelper.GetTraduction(m.Usuario_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_Spartan_User.Name
                        ,Area_Asignada = m.Area_Asignada
                        ,Area_AsignadaDescripcion = CultureHelper.GetTraduction(m.Area_Asignada_Area_de_Servicios_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.Area_Asignada_Area_de_Servicios_de_Apoyo.Descripcion

                    
                };
				var resultData = new
                {
                    data = result
                    ,SubAreas = Detalle_subareas_responsable_servicio_apoyoData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }


    }
}

