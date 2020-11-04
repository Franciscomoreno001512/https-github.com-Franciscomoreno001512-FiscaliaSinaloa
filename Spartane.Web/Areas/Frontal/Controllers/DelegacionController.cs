using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Delegacion;
using Spartane.Core.Domain.Region;
using Spartane.Core.Domain.Distrito_Judicial;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Delegacion;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Delegacion;
using Spartane.Web.Areas.WebApiConsumer.Region;
using Spartane.Web.Areas.WebApiConsumer.Distrito_Judicial;

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
    public class DelegacionController : Controller
    {
        #region "variable declaration"

        private IDelegacionService service = null;
        private IDelegacionApiConsumer _IDelegacionApiConsumer;
        private IRegionApiConsumer _IRegionApiConsumer;
        private IDistrito_JudicialApiConsumer _IDistrito_JudicialApiConsumer;

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

        
        public DelegacionController(IDelegacionService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDelegacionApiConsumer DelegacionApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , IRegionApiConsumer RegionApiConsumer , IDistrito_JudicialApiConsumer Distrito_JudicialApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDelegacionApiConsumer = DelegacionApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_FormatApiConsumer = Spartan_FormatApiConsumer;
            this._ISpartan_Format_PermissionsApiConsumer = Spartan_Format_PermissionsApiConsumer;
            this._IGeneratePDFApiConsumer = GeneratePDFApiConsumer;
			this._ISpartan_FormatRelatedApiConsumer = Spartan_Format_RelatedApiConsumer;
            this._IRegionApiConsumer = RegionApiConsumer;
            this._IDistrito_JudicialApiConsumer = Distrito_JudicialApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Delegacion
        [ObjectAuth(ObjectId = (ModuleObjectId)45016, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45016, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Delegacion/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45016, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45016, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varDelegacion = new DelegacionModel();
			varDelegacion.Clave = Id;
			
            ViewBag.ObjectId = "45016";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IDelegacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var DelegacionsData = _IDelegacionApiConsumer.ListaSelAll(0, 1000, "Delegacion.Clave=" + Id, "").Resource.Delegacions;
				
				if (DelegacionsData != null && DelegacionsData.Count > 0)
                {
					var DelegacionData = DelegacionsData.First();
					varDelegacion= new DelegacionModel
					{
						Clave  = DelegacionData.Clave 
	                    ,Descripcion = DelegacionData.Descripcion
                    ,Zona = DelegacionData.Zona
                    ,ZonaDescripcion = CultureHelper.GetTraduction(Convert.ToString(DelegacionData.Zona), "Region") ??  (string)DelegacionData.Zona_Region.Descripcion
                    ,Clave_Expediente = DelegacionData.Clave_Expediente
                    ,Direccion = DelegacionData.Direccion
                    ,Consecutivo_MPO = DelegacionData.Consecutivo_MPO
                    ,Consecutivo_MPI = DelegacionData.Consecutivo_MPI
                    ,Distrito = DelegacionData.Distrito
                    ,DistritoDescripcion = CultureHelper.GetTraduction(Convert.ToString(DelegacionData.Distrito), "Distrito_Judicial") ??  (string)DelegacionData.Distrito_Distrito_Judicial.Descripcion
                    ,Abreviacion_Delegacion = DelegacionData.Abreviacion_Delegacion

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IRegionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Regions_Zona = _IRegionApiConsumer.SelAll(true);
            if (Regions_Zona != null && Regions_Zona.Resource != null)
                ViewBag.Regions_Zona = Regions_Zona.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Region", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDistrito_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Distrito_Judicials_Distrito = _IDistrito_JudicialApiConsumer.SelAll(true);
            if (Distrito_Judicials_Distrito != null && Distrito_Judicials_Distrito.Resource != null)
                ViewBag.Distrito_Judicials_Distrito = Distrito_Judicials_Distrito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Distrito_Judicial", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varDelegacion);
        }
		
	[HttpGet]
        public ActionResult AddDelegacion(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45016);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDelegacionApiConsumer.SetAuthHeader(_tokenManager.Token);
			DelegacionModel varDelegacion= new DelegacionModel();


            if (id.ToString() != "0")
            {
                var DelegacionsData = _IDelegacionApiConsumer.ListaSelAll(0, 1000, "Delegacion.Clave=" + id, "").Resource.Delegacions;
				
				if (DelegacionsData != null && DelegacionsData.Count > 0)
                {
					var DelegacionData = DelegacionsData.First();
					varDelegacion= new DelegacionModel
					{
						Clave  = DelegacionData.Clave 
	                    ,Descripcion = DelegacionData.Descripcion
                    ,Zona = DelegacionData.Zona
                    ,ZonaDescripcion = CultureHelper.GetTraduction(Convert.ToString(DelegacionData.Zona), "Region") ??  (string)DelegacionData.Zona_Region.Descripcion
                    ,Clave_Expediente = DelegacionData.Clave_Expediente
                    ,Direccion = DelegacionData.Direccion
                    ,Consecutivo_MPO = DelegacionData.Consecutivo_MPO
                    ,Consecutivo_MPI = DelegacionData.Consecutivo_MPI
                    ,Distrito = DelegacionData.Distrito
                    ,DistritoDescripcion = CultureHelper.GetTraduction(Convert.ToString(DelegacionData.Distrito), "Distrito_Judicial") ??  (string)DelegacionData.Distrito_Distrito_Judicial.Descripcion
                    ,Abreviacion_Delegacion = DelegacionData.Abreviacion_Delegacion

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IRegionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Regions_Zona = _IRegionApiConsumer.SelAll(true);
            if (Regions_Zona != null && Regions_Zona.Resource != null)
                ViewBag.Regions_Zona = Regions_Zona.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Region", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDistrito_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Distrito_Judicials_Distrito = _IDistrito_JudicialApiConsumer.SelAll(true);
            if (Distrito_Judicials_Distrito != null && Distrito_Judicials_Distrito.Resource != null)
                ViewBag.Distrito_Judicials_Distrito = Distrito_Judicials_Distrito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Distrito_Judicial", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddDelegacion", varDelegacion);
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
        public ActionResult GetRegionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRegionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IRegionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Region", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDistrito_JudicialAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDistrito_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDistrito_JudicialApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Distrito_Judicial", "Descripcion")?? m.Descripcion,
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
        public ActionResult ShowAdvanceFilter(DelegacionAdvanceSearchModel model, int idFilter = -1)
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

            _IRegionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Regions_Zona = _IRegionApiConsumer.SelAll(true);
            if (Regions_Zona != null && Regions_Zona.Resource != null)
                ViewBag.Regions_Zona = Regions_Zona.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Region", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDistrito_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Distrito_Judicials_Distrito = _IDistrito_JudicialApiConsumer.SelAll(true);
            if (Distrito_Judicials_Distrito != null && Distrito_Judicials_Distrito.Resource != null)
                ViewBag.Distrito_Judicials_Distrito = Distrito_Judicials_Distrito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Distrito_Judicial", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IRegionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Regions_Zona = _IRegionApiConsumer.SelAll(true);
            if (Regions_Zona != null && Regions_Zona.Resource != null)
                ViewBag.Regions_Zona = Regions_Zona.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Region", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDistrito_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Distrito_Judicials_Distrito = _IDistrito_JudicialApiConsumer.SelAll(true);
            if (Distrito_Judicials_Distrito != null && Distrito_Judicials_Distrito.Resource != null)
                ViewBag.Distrito_Judicials_Distrito = Distrito_Judicials_Distrito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Distrito_Judicial", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new DelegacionAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (DelegacionAdvanceSearchModel)(Session["AdvanceSearch"] ?? new DelegacionAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new DelegacionPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDelegacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Delegacions == null)
                result.Delegacions = new List<Delegacion>();

            return Json(new
            {
                data = result.Delegacions.Select(m => new DelegacionGridModel
                    {
                    Clave = m.Clave
			,Descripcion = m.Descripcion
                        ,ZonaDescripcion = CultureHelper.GetTraduction(m.Zona_Region.Clave.ToString(), "Descripcion") ?? (string)m.Zona_Region.Descripcion
			,Clave_Expediente = m.Clave_Expediente
			,Direccion = m.Direccion
			,Consecutivo_MPO = m.Consecutivo_MPO
			,Consecutivo_MPI = m.Consecutivo_MPI
                        ,DistritoDescripcion = CultureHelper.GetTraduction(m.Distrito_Distrito_Judicial.Clave.ToString(), "Descripcion") ?? (string)m.Distrito_Distrito_Judicial.Descripcion
			,Abreviacion_Delegacion = m.Abreviacion_Delegacion

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetDelegacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDelegacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDelegacionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Delegacion", m.),
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
        /// Get List of Delegacion from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Delegacion Entity</returns>
        public ActionResult GetDelegacionList(UrlParametersModel param)
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
            _IDelegacionApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new DelegacionPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(DelegacionAdvanceSearchModel))
                {
					var advanceFilter =
                    (DelegacionAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            DelegacionPropertyMapper oDelegacionPropertyMapper = new DelegacionPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oDelegacionPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IDelegacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Delegacions == null)
                result.Delegacions = new List<Delegacion>();

            return Json(new
            {
                aaData = result.Delegacions.Select(m => new DelegacionGridModel
            {
                    Clave = m.Clave
			,Descripcion = m.Descripcion
                        ,ZonaDescripcion = CultureHelper.GetTraduction(m.Zona_Region.Clave.ToString(), "Descripcion") ?? (string)m.Zona_Region.Descripcion
			,Clave_Expediente = m.Clave_Expediente
			,Direccion = m.Direccion
			,Consecutivo_MPO = m.Consecutivo_MPO
			,Consecutivo_MPI = m.Consecutivo_MPI
                        ,DistritoDescripcion = CultureHelper.GetTraduction(m.Distrito_Distrito_Judicial.Clave.ToString(), "Descripcion") ?? (string)m.Distrito_Distrito_Judicial.Descripcion
			,Abreviacion_Delegacion = m.Abreviacion_Delegacion

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }







        [NonAction]
        public string GetAdvanceFilter(DelegacionAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Delegacion.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Delegacion.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.Descripcion))
            {
                switch (filter.DescripcionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Delegacion.Descripcion LIKE '" + filter.Descripcion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Delegacion.Descripcion LIKE '%" + filter.Descripcion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Delegacion.Descripcion = '" + filter.Descripcion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Delegacion.Descripcion LIKE '%" + filter.Descripcion + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceZona))
            {
                switch (filter.ZonaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Region.Descripcion LIKE '" + filter.AdvanceZona + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Region.Descripcion LIKE '%" + filter.AdvanceZona + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Region.Descripcion = '" + filter.AdvanceZona + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Region.Descripcion LIKE '%" + filter.AdvanceZona + "%'";
                        break;
                }
            }
            else if (filter.AdvanceZonaMultiple != null && filter.AdvanceZonaMultiple.Count() > 0)
            {
                var ZonaIds = string.Join(",", filter.AdvanceZonaMultiple);

                where += " AND Delegacion.Zona In (" + ZonaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromClave_Expediente) || !string.IsNullOrEmpty(filter.ToClave_Expediente))
            {
                if (!string.IsNullOrEmpty(filter.FromClave_Expediente))
                    where += " AND Delegacion.Clave_Expediente >= " + filter.FromClave_Expediente;
                if (!string.IsNullOrEmpty(filter.ToClave_Expediente))
                    where += " AND Delegacion.Clave_Expediente <= " + filter.ToClave_Expediente;
            }

            if (!string.IsNullOrEmpty(filter.Direccion))
            {
                switch (filter.DireccionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Delegacion.Direccion LIKE '" + filter.Direccion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Delegacion.Direccion LIKE '%" + filter.Direccion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Delegacion.Direccion = '" + filter.Direccion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Delegacion.Direccion LIKE '%" + filter.Direccion + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromConsecutivo_MPO) || !string.IsNullOrEmpty(filter.ToConsecutivo_MPO))
            {
                if (!string.IsNullOrEmpty(filter.FromConsecutivo_MPO))
                    where += " AND Delegacion.Consecutivo_MPO >= " + filter.FromConsecutivo_MPO;
                if (!string.IsNullOrEmpty(filter.ToConsecutivo_MPO))
                    where += " AND Delegacion.Consecutivo_MPO <= " + filter.ToConsecutivo_MPO;
            }

            if (!string.IsNullOrEmpty(filter.FromConsecutivo_MPI) || !string.IsNullOrEmpty(filter.ToConsecutivo_MPI))
            {
                if (!string.IsNullOrEmpty(filter.FromConsecutivo_MPI))
                    where += " AND Delegacion.Consecutivo_MPI >= " + filter.FromConsecutivo_MPI;
                if (!string.IsNullOrEmpty(filter.ToConsecutivo_MPI))
                    where += " AND Delegacion.Consecutivo_MPI <= " + filter.ToConsecutivo_MPI;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceDistrito))
            {
                switch (filter.DistritoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Distrito_Judicial.Descripcion LIKE '" + filter.AdvanceDistrito + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Distrito_Judicial.Descripcion LIKE '%" + filter.AdvanceDistrito + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Distrito_Judicial.Descripcion = '" + filter.AdvanceDistrito + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Distrito_Judicial.Descripcion LIKE '%" + filter.AdvanceDistrito + "%'";
                        break;
                }
            }
            else if (filter.AdvanceDistritoMultiple != null && filter.AdvanceDistritoMultiple.Count() > 0)
            {
                var DistritoIds = string.Join(",", filter.AdvanceDistritoMultiple);

                where += " AND Delegacion.Distrito In (" + DistritoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Abreviacion_Delegacion))
            {
                switch (filter.Abreviacion_DelegacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Delegacion.Abreviacion_Delegacion LIKE '" + filter.Abreviacion_Delegacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Delegacion.Abreviacion_Delegacion LIKE '%" + filter.Abreviacion_Delegacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Delegacion.Abreviacion_Delegacion = '" + filter.Abreviacion_Delegacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Delegacion.Abreviacion_Delegacion LIKE '%" + filter.Abreviacion_Delegacion + "%'";
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
                _IDelegacionApiConsumer.SetAuthHeader(_tokenManager.Token);

                Delegacion varDelegacion = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IDelegacionApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, DelegacionModel varDelegacion)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDelegacionApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var DelegacionInfo = new Delegacion
                    {
                        Clave = varDelegacion.Clave
                        ,Descripcion = varDelegacion.Descripcion
                        ,Zona = varDelegacion.Zona
                        ,Clave_Expediente = varDelegacion.Clave_Expediente
                        ,Direccion = varDelegacion.Direccion
                        ,Consecutivo_MPO = varDelegacion.Consecutivo_MPO
                        ,Consecutivo_MPI = varDelegacion.Consecutivo_MPI
                        ,Distrito = varDelegacion.Distrito
                        ,Abreviacion_Delegacion = varDelegacion.Abreviacion_Delegacion

                    };

                    result = !IsNew ?
                        _IDelegacionApiConsumer.Update(DelegacionInfo, null, null).Resource.ToString() :
                         _IDelegacionApiConsumer.Insert(DelegacionInfo, null, null).Resource.ToString();
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
        /// Write Element Array of Delegacion script
        /// </summary>
        /// <param name="oDelegacionElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew DelegacionModuleAttributeList)
        {
            for (int i = 0; i < DelegacionModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(DelegacionModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    DelegacionModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(DelegacionModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    DelegacionModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (DelegacionModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < DelegacionModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < DelegacionModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(DelegacionModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							DelegacionModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(DelegacionModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							DelegacionModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strDelegacionScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Delegacion.js")))
            {
                strDelegacionScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Delegacion element attributes
            string userChangeJson = jsSerialize.Serialize(DelegacionModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDelegacionScript.IndexOf("inpuElementArray");
            string splittedString = strDelegacionScript.Substring(indexOfArray, strDelegacionScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(DelegacionModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (DelegacionModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDelegacionScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strDelegacionScript.Substring(indexOfArrayHistory, strDelegacionScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strDelegacionScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDelegacionScript.Substring(endIndexOfMainElement + indexOfArray, strDelegacionScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (DelegacionModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in DelegacionModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Delegacion.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Delegacion.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Delegacion.js")))
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
        public ActionResult DelegacionPropertyBag()
        {
            return PartialView("DelegacionPropertyBag", "Delegacion");
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
                var whereClauseFormat = "Object = 45016 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IDelegacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Delegacion.Clave= " + RecordId;
                            var result = _IDelegacionApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IDelegacionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new DelegacionPropertyMapper());
			
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
                    (DelegacionAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            DelegacionPropertyMapper oDelegacionPropertyMapper = new DelegacionPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oDelegacionPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDelegacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Delegacions == null)
                result.Delegacions = new List<Delegacion>();

            var data = result.Delegacions.Select(m => new DelegacionGridModel
            {
                Clave = m.Clave
			,Descripcion = m.Descripcion
                        ,ZonaDescripcion = CultureHelper.GetTraduction(m.Zona_Region.Clave.ToString(), "Descripcion") ?? (string)m.Zona_Region.Descripcion
			,Clave_Expediente = m.Clave_Expediente
			,Direccion = m.Direccion
			,Consecutivo_MPO = m.Consecutivo_MPO
			,Consecutivo_MPI = m.Consecutivo_MPI
                        ,DistritoDescripcion = CultureHelper.GetTraduction(m.Distrito_Distrito_Judicial.Clave.ToString(), "Descripcion") ?? (string)m.Distrito_Distrito_Judicial.Descripcion
			,Abreviacion_Delegacion = m.Abreviacion_Delegacion

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45016, arrayColumnsVisible), "DelegacionList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45016, arrayColumnsVisible), "DelegacionList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45016, arrayColumnsVisible), "DelegacionList_" + DateTime.Now.ToString());
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

            _IDelegacionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new DelegacionPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (DelegacionAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            DelegacionPropertyMapper oDelegacionPropertyMapper = new DelegacionPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oDelegacionPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDelegacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Delegacions == null)
                result.Delegacions = new List<Delegacion>();

            var data = result.Delegacions.Select(m => new DelegacionGridModel
            {
                Clave = m.Clave
			,Descripcion = m.Descripcion
                        ,ZonaDescripcion = CultureHelper.GetTraduction(m.Zona_Region.Clave.ToString(), "Descripcion") ?? (string)m.Zona_Region.Descripcion
			,Clave_Expediente = m.Clave_Expediente
			,Direccion = m.Direccion
			,Consecutivo_MPO = m.Consecutivo_MPO
			,Consecutivo_MPI = m.Consecutivo_MPI
                        ,DistritoDescripcion = CultureHelper.GetTraduction(m.Distrito_Distrito_Judicial.Clave.ToString(), "Descripcion") ?? (string)m.Distrito_Distrito_Judicial.Descripcion
			,Abreviacion_Delegacion = m.Abreviacion_Delegacion

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
                _IDelegacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDelegacionApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Delegacion_Datos_GeneralesModel varDelegacion)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDelegacionApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Delegacion_Datos_GeneralesInfo = new Delegacion_Datos_Generales
                {
                    Clave = varDelegacion.Clave
                                            ,Descripcion = varDelegacion.Descripcion
                        ,Zona = varDelegacion.Zona
                        ,Clave_Expediente = varDelegacion.Clave_Expediente
                        ,Direccion = varDelegacion.Direccion
                        ,Consecutivo_MPO = varDelegacion.Consecutivo_MPO
                        ,Consecutivo_MPI = varDelegacion.Consecutivo_MPI
                        ,Distrito = varDelegacion.Distrito
                        ,Abreviacion_Delegacion = varDelegacion.Abreviacion_Delegacion
                    
                };

                result = _IDelegacionApiConsumer.Update_Datos_Generales(Delegacion_Datos_GeneralesInfo).Resource.ToString();
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
                _IDelegacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IDelegacionApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Delegacion_Datos_GeneralesModel
                {
                    Clave = m.Clave
			,Descripcion = m.Descripcion
                        ,Zona = m.Zona
                        ,ZonaDescripcion = CultureHelper.GetTraduction(m.Zona_Region.Clave.ToString(), "Descripcion") ?? (string)m.Zona_Region.Descripcion
			,Clave_Expediente = m.Clave_Expediente
			,Direccion = m.Direccion
			,Consecutivo_MPO = m.Consecutivo_MPO
			,Consecutivo_MPI = m.Consecutivo_MPI
                        ,Distrito = m.Distrito
                        ,DistritoDescripcion = CultureHelper.GetTraduction(m.Distrito_Distrito_Judicial.Clave.ToString(), "Descripcion") ?? (string)m.Distrito_Distrito_Judicial.Descripcion
			,Abreviacion_Delegacion = m.Abreviacion_Delegacion

                    
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

