using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Consecuencia_Defuncion;
using Spartane.Core.Domain.Certifica_Defuncion;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Consecuencia_Defuncion;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Consecuencia_Defuncion;
using Spartane.Web.Areas.WebApiConsumer.Certifica_Defuncion;

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
    public class Consecuencia_DefuncionController : Controller
    {
        #region "variable declaration"

        private IConsecuencia_DefuncionService service = null;
        private IConsecuencia_DefuncionApiConsumer _IConsecuencia_DefuncionApiConsumer;
        private ICertifica_DefuncionApiConsumer _ICertifica_DefuncionApiConsumer;

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

        
        public Consecuencia_DefuncionController(IConsecuencia_DefuncionService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IConsecuencia_DefuncionApiConsumer Consecuencia_DefuncionApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , ICertifica_DefuncionApiConsumer Certifica_DefuncionApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IConsecuencia_DefuncionApiConsumer = Consecuencia_DefuncionApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_FormatApiConsumer = Spartan_FormatApiConsumer;
            this._ISpartan_Format_PermissionsApiConsumer = Spartan_Format_PermissionsApiConsumer;
            this._IGeneratePDFApiConsumer = GeneratePDFApiConsumer;
			this._ISpartan_FormatRelatedApiConsumer = Spartan_Format_RelatedApiConsumer;
            this._ICertifica_DefuncionApiConsumer = Certifica_DefuncionApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Consecuencia_Defuncion
        [ObjectAuth(ObjectId = (ModuleObjectId)44960, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 44960, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Consecuencia_Defuncion/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)44960, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(short Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 44960, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varConsecuencia_Defuncion = new Consecuencia_DefuncionModel();
			varConsecuencia_Defuncion.Clave = Id;
			
            ViewBag.ObjectId = "44960";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IConsecuencia_DefuncionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Consecuencia_DefuncionsData = _IConsecuencia_DefuncionApiConsumer.ListaSelAll(0, 1000, "Consecuencia_Defuncion.Clave=" + Id, "").Resource.Consecuencia_Defuncions;
				
				if (Consecuencia_DefuncionsData != null && Consecuencia_DefuncionsData.Count > 0)
                {
					var Consecuencia_DefuncionData = Consecuencia_DefuncionsData.First();
					varConsecuencia_Defuncion= new Consecuencia_DefuncionModel
					{
						Clave  = Consecuencia_DefuncionData.Clave 
	                    ,Descripcion = Consecuencia_DefuncionData.Descripcion
                    ,Tipo_Defuncion = Consecuencia_DefuncionData.Tipo_Defuncion
                    ,Tipo_DefuncionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Consecuencia_DefuncionData.Tipo_Defuncion), "Certifica_Defuncion") ??  (string)Consecuencia_DefuncionData.Tipo_Defuncion_Certifica_Defuncion.Descripcion

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ICertifica_DefuncionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Certifica_Defuncions_Tipo_Defuncion = _ICertifica_DefuncionApiConsumer.SelAll(true);
            if (Certifica_Defuncions_Tipo_Defuncion != null && Certifica_Defuncions_Tipo_Defuncion.Resource != null)
                ViewBag.Certifica_Defuncions_Tipo_Defuncion = Certifica_Defuncions_Tipo_Defuncion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Certifica_Defuncion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varConsecuencia_Defuncion);
        }
		
	[HttpGet]
        public ActionResult AddConsecuencia_Defuncion(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 44960);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IConsecuencia_DefuncionApiConsumer.SetAuthHeader(_tokenManager.Token);
			Consecuencia_DefuncionModel varConsecuencia_Defuncion= new Consecuencia_DefuncionModel();


            if (id.ToString() != "0")
            {
                var Consecuencia_DefuncionsData = _IConsecuencia_DefuncionApiConsumer.ListaSelAll(0, 1000, "Consecuencia_Defuncion.Clave=" + id, "").Resource.Consecuencia_Defuncions;
				
				if (Consecuencia_DefuncionsData != null && Consecuencia_DefuncionsData.Count > 0)
                {
					var Consecuencia_DefuncionData = Consecuencia_DefuncionsData.First();
					varConsecuencia_Defuncion= new Consecuencia_DefuncionModel
					{
						Clave  = Consecuencia_DefuncionData.Clave 
	                    ,Descripcion = Consecuencia_DefuncionData.Descripcion
                    ,Tipo_Defuncion = Consecuencia_DefuncionData.Tipo_Defuncion
                    ,Tipo_DefuncionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Consecuencia_DefuncionData.Tipo_Defuncion), "Certifica_Defuncion") ??  (string)Consecuencia_DefuncionData.Tipo_Defuncion_Certifica_Defuncion.Descripcion

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ICertifica_DefuncionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Certifica_Defuncions_Tipo_Defuncion = _ICertifica_DefuncionApiConsumer.SelAll(true);
            if (Certifica_Defuncions_Tipo_Defuncion != null && Certifica_Defuncions_Tipo_Defuncion.Resource != null)
                ViewBag.Certifica_Defuncions_Tipo_Defuncion = Certifica_Defuncions_Tipo_Defuncion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Certifica_Defuncion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddConsecuencia_Defuncion", varConsecuencia_Defuncion);
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
        public ActionResult GetCertifica_DefuncionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICertifica_DefuncionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICertifica_DefuncionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Certifica_Defuncion", "Descripcion")?? m.Descripcion,
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
        public ActionResult ShowAdvanceFilter(Consecuencia_DefuncionAdvanceSearchModel model, int idFilter = -1)
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

            _ICertifica_DefuncionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Certifica_Defuncions_Tipo_Defuncion = _ICertifica_DefuncionApiConsumer.SelAll(true);
            if (Certifica_Defuncions_Tipo_Defuncion != null && Certifica_Defuncions_Tipo_Defuncion.Resource != null)
                ViewBag.Certifica_Defuncions_Tipo_Defuncion = Certifica_Defuncions_Tipo_Defuncion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Certifica_Defuncion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ICertifica_DefuncionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Certifica_Defuncions_Tipo_Defuncion = _ICertifica_DefuncionApiConsumer.SelAll(true);
            if (Certifica_Defuncions_Tipo_Defuncion != null && Certifica_Defuncions_Tipo_Defuncion.Resource != null)
                ViewBag.Certifica_Defuncions_Tipo_Defuncion = Certifica_Defuncions_Tipo_Defuncion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Certifica_Defuncion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Consecuencia_DefuncionAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Consecuencia_DefuncionAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Consecuencia_DefuncionAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Consecuencia_DefuncionPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IConsecuencia_DefuncionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Consecuencia_Defuncions == null)
                result.Consecuencia_Defuncions = new List<Consecuencia_Defuncion>();

            return Json(new
            {
                data = result.Consecuencia_Defuncions.Select(m => new Consecuencia_DefuncionGridModel
                    {
                    Clave = m.Clave
			,Descripcion = m.Descripcion
                        ,Tipo_DefuncionDescripcion = CultureHelper.GetTraduction(m.Tipo_Defuncion_Certifica_Defuncion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Defuncion_Certifica_Defuncion.Descripcion

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetConsecuencia_DefuncionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IConsecuencia_DefuncionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IConsecuencia_DefuncionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Consecuencia_Defuncion", m.),
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
        /// Get List of Consecuencia_Defuncion from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Consecuencia_Defuncion Entity</returns>
        public ActionResult GetConsecuencia_DefuncionList(UrlParametersModel param)
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
            _IConsecuencia_DefuncionApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Consecuencia_DefuncionPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Consecuencia_DefuncionAdvanceSearchModel))
                {
					var advanceFilter =
                    (Consecuencia_DefuncionAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Consecuencia_DefuncionPropertyMapper oConsecuencia_DefuncionPropertyMapper = new Consecuencia_DefuncionPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oConsecuencia_DefuncionPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IConsecuencia_DefuncionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Consecuencia_Defuncions == null)
                result.Consecuencia_Defuncions = new List<Consecuencia_Defuncion>();

            return Json(new
            {
                aaData = result.Consecuencia_Defuncions.Select(m => new Consecuencia_DefuncionGridModel
            {
                    Clave = m.Clave
			,Descripcion = m.Descripcion
                        ,Tipo_DefuncionDescripcion = CultureHelper.GetTraduction(m.Tipo_Defuncion_Certifica_Defuncion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Defuncion_Certifica_Defuncion.Descripcion

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }







        [NonAction]
        public string GetAdvanceFilter(Consecuencia_DefuncionAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Consecuencia_Defuncion.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Consecuencia_Defuncion.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.Descripcion))
            {
                switch (filter.DescripcionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Consecuencia_Defuncion.Descripcion LIKE '" + filter.Descripcion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Consecuencia_Defuncion.Descripcion LIKE '%" + filter.Descripcion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Consecuencia_Defuncion.Descripcion = '" + filter.Descripcion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Consecuencia_Defuncion.Descripcion LIKE '%" + filter.Descripcion + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_Defuncion))
            {
                switch (filter.Tipo_DefuncionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Certifica_Defuncion.Descripcion LIKE '" + filter.AdvanceTipo_Defuncion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Certifica_Defuncion.Descripcion LIKE '%" + filter.AdvanceTipo_Defuncion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Certifica_Defuncion.Descripcion = '" + filter.AdvanceTipo_Defuncion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Certifica_Defuncion.Descripcion LIKE '%" + filter.AdvanceTipo_Defuncion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_DefuncionMultiple != null && filter.AdvanceTipo_DefuncionMultiple.Count() > 0)
            {
                var Tipo_DefuncionIds = string.Join(",", filter.AdvanceTipo_DefuncionMultiple);

                where += " AND Consecuencia_Defuncion.Tipo_Defuncion In (" + Tipo_DefuncionIds + ")";
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
        public ActionResult Delete(short id)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IConsecuencia_DefuncionApiConsumer.SetAuthHeader(_tokenManager.Token);

                Consecuencia_Defuncion varConsecuencia_Defuncion = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IConsecuencia_DefuncionApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Consecuencia_DefuncionModel varConsecuencia_Defuncion)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IConsecuencia_DefuncionApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Consecuencia_DefuncionInfo = new Consecuencia_Defuncion
                    {
                        Clave = varConsecuencia_Defuncion.Clave
                        ,Descripcion = varConsecuencia_Defuncion.Descripcion
                        ,Tipo_Defuncion = varConsecuencia_Defuncion.Tipo_Defuncion

                    };

                    result = !IsNew ?
                        _IConsecuencia_DefuncionApiConsumer.Update(Consecuencia_DefuncionInfo, null, null).Resource.ToString() :
                         _IConsecuencia_DefuncionApiConsumer.Insert(Consecuencia_DefuncionInfo, null, null).Resource.ToString();
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
        /// Write Element Array of Consecuencia_Defuncion script
        /// </summary>
        /// <param name="oConsecuencia_DefuncionElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Consecuencia_DefuncionModuleAttributeList)
        {
            for (int i = 0; i < Consecuencia_DefuncionModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Consecuencia_DefuncionModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Consecuencia_DefuncionModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Consecuencia_DefuncionModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Consecuencia_DefuncionModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Consecuencia_DefuncionModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Consecuencia_DefuncionModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Consecuencia_DefuncionModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Consecuencia_DefuncionModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Consecuencia_DefuncionModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Consecuencia_DefuncionModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Consecuencia_DefuncionModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strConsecuencia_DefuncionScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Consecuencia_Defuncion.js")))
            {
                strConsecuencia_DefuncionScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Consecuencia_Defuncion element attributes
            string userChangeJson = jsSerialize.Serialize(Consecuencia_DefuncionModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strConsecuencia_DefuncionScript.IndexOf("inpuElementArray");
            string splittedString = strConsecuencia_DefuncionScript.Substring(indexOfArray, strConsecuencia_DefuncionScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Consecuencia_DefuncionModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Consecuencia_DefuncionModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strConsecuencia_DefuncionScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strConsecuencia_DefuncionScript.Substring(indexOfArrayHistory, strConsecuencia_DefuncionScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strConsecuencia_DefuncionScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strConsecuencia_DefuncionScript.Substring(endIndexOfMainElement + indexOfArray, strConsecuencia_DefuncionScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Consecuencia_DefuncionModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Consecuencia_DefuncionModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Consecuencia_Defuncion.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Consecuencia_Defuncion.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Consecuencia_Defuncion.js")))
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
        public ActionResult Consecuencia_DefuncionPropertyBag()
        {
            return PartialView("Consecuencia_DefuncionPropertyBag", "Consecuencia_Defuncion");
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
                var whereClauseFormat = "Object = 44960 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IConsecuencia_DefuncionApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Consecuencia_Defuncion.Clave= " + RecordId;
                            var result = _IConsecuencia_DefuncionApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IConsecuencia_DefuncionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Consecuencia_DefuncionPropertyMapper());
			
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
                    (Consecuencia_DefuncionAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Consecuencia_DefuncionPropertyMapper oConsecuencia_DefuncionPropertyMapper = new Consecuencia_DefuncionPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oConsecuencia_DefuncionPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IConsecuencia_DefuncionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Consecuencia_Defuncions == null)
                result.Consecuencia_Defuncions = new List<Consecuencia_Defuncion>();

            var data = result.Consecuencia_Defuncions.Select(m => new Consecuencia_DefuncionGridModel
            {
                Clave = m.Clave
			,Descripcion = m.Descripcion
                        ,Tipo_DefuncionDescripcion = CultureHelper.GetTraduction(m.Tipo_Defuncion_Certifica_Defuncion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Defuncion_Certifica_Defuncion.Descripcion

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(44960, arrayColumnsVisible), "Consecuencia_DefuncionList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(44960, arrayColumnsVisible), "Consecuencia_DefuncionList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(44960, arrayColumnsVisible), "Consecuencia_DefuncionList_" + DateTime.Now.ToString());
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

            _IConsecuencia_DefuncionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Consecuencia_DefuncionPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Consecuencia_DefuncionAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Consecuencia_DefuncionPropertyMapper oConsecuencia_DefuncionPropertyMapper = new Consecuencia_DefuncionPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oConsecuencia_DefuncionPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IConsecuencia_DefuncionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Consecuencia_Defuncions == null)
                result.Consecuencia_Defuncions = new List<Consecuencia_Defuncion>();

            var data = result.Consecuencia_Defuncions.Select(m => new Consecuencia_DefuncionGridModel
            {
                Clave = m.Clave
			,Descripcion = m.Descripcion
                        ,Tipo_DefuncionDescripcion = CultureHelper.GetTraduction(m.Tipo_Defuncion_Certifica_Defuncion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Defuncion_Certifica_Defuncion.Descripcion

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
                _IConsecuencia_DefuncionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IConsecuencia_DefuncionApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Consecuencia_Defuncion_Datos_GeneralesModel varConsecuencia_Defuncion)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IConsecuencia_DefuncionApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Consecuencia_Defuncion_Datos_GeneralesInfo = new Consecuencia_Defuncion_Datos_Generales
                {
                    Clave = varConsecuencia_Defuncion.Clave
                                            ,Descripcion = varConsecuencia_Defuncion.Descripcion
                        ,Tipo_Defuncion = varConsecuencia_Defuncion.Tipo_Defuncion
                    
                };

                result = _IConsecuencia_DefuncionApiConsumer.Update_Datos_Generales(Consecuencia_Defuncion_Datos_GeneralesInfo).Resource.ToString();
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
                _IConsecuencia_DefuncionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IConsecuencia_DefuncionApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Consecuencia_Defuncion_Datos_GeneralesModel
                {
                    Clave = m.Clave
			,Descripcion = m.Descripcion
                        ,Tipo_Defuncion = m.Tipo_Defuncion
                        ,Tipo_DefuncionDescripcion = CultureHelper.GetTraduction(m.Tipo_Defuncion_Certifica_Defuncion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Defuncion_Certifica_Defuncion.Descripcion

                    
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

