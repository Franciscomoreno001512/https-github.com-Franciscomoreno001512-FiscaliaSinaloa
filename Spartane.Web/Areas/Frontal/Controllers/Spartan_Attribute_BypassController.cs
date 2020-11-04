using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Spartan_Attribute_Bypass;
using Spartane.Core.Domain.Spartan_Object_ByPass;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Spartan_Attribute_Bypass;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Attribute_Bypass;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Object_ByPass;

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
    public class Spartan_Attribute_BypassController : Controller
    {
        #region "variable declaration"

        private ISpartan_Attribute_BypassService service = null;
        private ISpartan_Attribute_BypassApiConsumer _ISpartan_Attribute_BypassApiConsumer;
        private ISpartan_Object_ByPassApiConsumer _ISpartan_Object_ByPassApiConsumer;

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

        
        public Spartan_Attribute_BypassController(ISpartan_Attribute_BypassService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, ISpartan_Attribute_BypassApiConsumer Spartan_Attribute_BypassApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , ISpartan_Object_ByPassApiConsumer Spartan_Object_ByPassApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._ISpartan_Attribute_BypassApiConsumer = Spartan_Attribute_BypassApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_FormatApiConsumer = Spartan_FormatApiConsumer;
            this._ISpartan_Format_PermissionsApiConsumer = Spartan_Format_PermissionsApiConsumer;
            this._IGeneratePDFApiConsumer = GeneratePDFApiConsumer;
			this._ISpartan_FormatRelatedApiConsumer = Spartan_Format_RelatedApiConsumer;
            this._ISpartan_Object_ByPassApiConsumer = Spartan_Object_ByPassApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Spartan_Attribute_Bypass
        [ObjectAuth(ObjectId = (ModuleObjectId)45360, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45360, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Spartan_Attribute_Bypass/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45360, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45360, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varSpartan_Attribute_Bypass = new Spartan_Attribute_BypassModel();
			varSpartan_Attribute_Bypass.AttributeId = Id;
			
            ViewBag.ObjectId = "45360";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _ISpartan_Attribute_BypassApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Spartan_Attribute_BypasssData = _ISpartan_Attribute_BypassApiConsumer.ListaSelAll(0, 1000, "Spartan_Attribute_Bypass.AttributeId=" + Id, "").Resource.Spartan_Attribute_Bypasss;
				
				if (Spartan_Attribute_BypasssData != null && Spartan_Attribute_BypasssData.Count > 0)
                {
					var Spartan_Attribute_BypassData = Spartan_Attribute_BypasssData.First();
					varSpartan_Attribute_Bypass= new Spartan_Attribute_BypassModel
					{
						AttributeId  = Spartan_Attribute_BypassData.AttributeId 
	                    ,Description = Spartan_Attribute_BypassData.Description
                    ,ObjectId = Spartan_Attribute_BypassData.ObjectId
                    ,ObjectIdDescription = CultureHelper.GetTraduction(Convert.ToString(Spartan_Attribute_BypassData.ObjectId), "Spartan_Object_ByPass") ??  (string)Spartan_Attribute_BypassData.ObjectId_Spartan_Object_ByPass.Description

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ISpartan_Object_ByPassApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Object_ByPasss_ObjectId = _ISpartan_Object_ByPassApiConsumer.SelAll(true);
            if (Spartan_Object_ByPasss_ObjectId != null && Spartan_Object_ByPasss_ObjectId.Resource != null)
                ViewBag.Spartan_Object_ByPasss_ObjectId = Spartan_Object_ByPasss_ObjectId.Resource.Where(m => m.Description != null).OrderBy(m => m.Description).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.ObjectId), "Spartan_Object_ByPass", "Description") ?? m.Description.ToString(), Value = Convert.ToString(m.ObjectId)
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

				
            return View(varSpartan_Attribute_Bypass);
        }
		
	[HttpGet]
        public ActionResult AddSpartan_Attribute_Bypass(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45360);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _ISpartan_Attribute_BypassApiConsumer.SetAuthHeader(_tokenManager.Token);
			Spartan_Attribute_BypassModel varSpartan_Attribute_Bypass= new Spartan_Attribute_BypassModel();


            if (id.ToString() != "0")
            {
                var Spartan_Attribute_BypasssData = _ISpartan_Attribute_BypassApiConsumer.ListaSelAll(0, 1000, "Spartan_Attribute_Bypass.AttributeId=" + id, "").Resource.Spartan_Attribute_Bypasss;
				
				if (Spartan_Attribute_BypasssData != null && Spartan_Attribute_BypasssData.Count > 0)
                {
					var Spartan_Attribute_BypassData = Spartan_Attribute_BypasssData.First();
					varSpartan_Attribute_Bypass= new Spartan_Attribute_BypassModel
					{
						AttributeId  = Spartan_Attribute_BypassData.AttributeId 
	                    ,Description = Spartan_Attribute_BypassData.Description
                    ,ObjectId = Spartan_Attribute_BypassData.ObjectId
                    ,ObjectIdDescription = CultureHelper.GetTraduction(Convert.ToString(Spartan_Attribute_BypassData.ObjectId), "Spartan_Object_ByPass") ??  (string)Spartan_Attribute_BypassData.ObjectId_Spartan_Object_ByPass.Description

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ISpartan_Object_ByPassApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Object_ByPasss_ObjectId = _ISpartan_Object_ByPassApiConsumer.SelAll(true);
            if (Spartan_Object_ByPasss_ObjectId != null && Spartan_Object_ByPasss_ObjectId.Resource != null)
                ViewBag.Spartan_Object_ByPasss_ObjectId = Spartan_Object_ByPasss_ObjectId.Resource.Where(m => m.Description != null).OrderBy(m => m.Description).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.ObjectId), "Spartan_Object_ByPass", "Description") ?? m.Description.ToString(), Value = Convert.ToString(m.ObjectId)
                }).ToList();


            return PartialView("AddSpartan_Attribute_Bypass", varSpartan_Attribute_Bypass);
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
        public ActionResult GetSpartan_Object_ByPassAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISpartan_Object_ByPassApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISpartan_Object_ByPassApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Description).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.ObjectId), "Spartan_Object_ByPass", "Description")?? m.Description,
                    Value = Convert.ToString(m.ObjectId)
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
        public ActionResult ShowAdvanceFilter(Spartan_Attribute_BypassAdvanceSearchModel model, int idFilter = -1)
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

            _ISpartan_Object_ByPassApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Object_ByPasss_ObjectId = _ISpartan_Object_ByPassApiConsumer.SelAll(true);
            if (Spartan_Object_ByPasss_ObjectId != null && Spartan_Object_ByPasss_ObjectId.Resource != null)
                ViewBag.Spartan_Object_ByPasss_ObjectId = Spartan_Object_ByPasss_ObjectId.Resource.Where(m => m.Description != null).OrderBy(m => m.Description).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.ObjectId), "Spartan_Object_ByPass", "Description") ?? m.Description.ToString(), Value = Convert.ToString(m.ObjectId)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ISpartan_Object_ByPassApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Object_ByPasss_ObjectId = _ISpartan_Object_ByPassApiConsumer.SelAll(true);
            if (Spartan_Object_ByPasss_ObjectId != null && Spartan_Object_ByPasss_ObjectId.Resource != null)
                ViewBag.Spartan_Object_ByPasss_ObjectId = Spartan_Object_ByPasss_ObjectId.Resource.Where(m => m.Description != null).OrderBy(m => m.Description).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.ObjectId), "Spartan_Object_ByPass", "Description") ?? m.Description.ToString(), Value = Convert.ToString(m.ObjectId)
                }).ToList();


            var previousFiltersObj = new Spartan_Attribute_BypassAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Spartan_Attribute_BypassAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Spartan_Attribute_BypassAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Spartan_Attribute_BypassPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _ISpartan_Attribute_BypassApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Spartan_Attribute_Bypasss == null)
                result.Spartan_Attribute_Bypasss = new List<Spartan_Attribute_Bypass>();

            return Json(new
            {
                data = result.Spartan_Attribute_Bypasss.Select(m => new Spartan_Attribute_BypassGridModel
                    {
                    AttributeId = m.AttributeId
			,Description = m.Description
                        ,ObjectIdDescription = CultureHelper.GetTraduction(m.ObjectId_Spartan_Object_ByPass.ObjectId.ToString(), "Description") ?? (string)m.ObjectId_Spartan_Object_ByPass.Description

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetSpartan_Attribute_BypassAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISpartan_Attribute_BypassApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISpartan_Attribute_BypassApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.AttributeId), "Spartan_Attribute_Bypass", m.),
                     Value = Convert.ToString(m.AttributeId)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
*/
        /// <summary>
        /// Get List of Spartan_Attribute_Bypass from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Spartan_Attribute_Bypass Entity</returns>
        public ActionResult GetSpartan_Attribute_BypassList(UrlParametersModel param)
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
            _ISpartan_Attribute_BypassApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Spartan_Attribute_BypassPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Spartan_Attribute_BypassAdvanceSearchModel))
                {
					var advanceFilter =
                    (Spartan_Attribute_BypassAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Spartan_Attribute_BypassPropertyMapper oSpartan_Attribute_BypassPropertyMapper = new Spartan_Attribute_BypassPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oSpartan_Attribute_BypassPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _ISpartan_Attribute_BypassApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Spartan_Attribute_Bypasss == null)
                result.Spartan_Attribute_Bypasss = new List<Spartan_Attribute_Bypass>();

            return Json(new
            {
                aaData = result.Spartan_Attribute_Bypasss.Select(m => new Spartan_Attribute_BypassGridModel
            {
                    AttributeId = m.AttributeId
			,Description = m.Description
                        ,ObjectIdDescription = CultureHelper.GetTraduction(m.ObjectId_Spartan_Object_ByPass.ObjectId.ToString(), "Description") ?? (string)m.ObjectId_Spartan_Object_ByPass.Description

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }







        [NonAction]
        public string GetAdvanceFilter(Spartan_Attribute_BypassAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromAttributeId) || !string.IsNullOrEmpty(filter.ToAttributeId))
            {
                if (!string.IsNullOrEmpty(filter.FromAttributeId))
                    where += " AND Spartan_Attribute_Bypass.AttributeId >= " + filter.FromAttributeId;
                if (!string.IsNullOrEmpty(filter.ToAttributeId))
                    where += " AND Spartan_Attribute_Bypass.AttributeId <= " + filter.ToAttributeId;
            }

            if (!string.IsNullOrEmpty(filter.Description))
            {
                switch (filter.DescriptionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_Attribute_Bypass.Description LIKE '" + filter.Description + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_Attribute_Bypass.Description LIKE '%" + filter.Description + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_Attribute_Bypass.Description = '" + filter.Description + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_Attribute_Bypass.Description LIKE '%" + filter.Description + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceObjectId))
            {
                switch (filter.ObjectIdFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_Object_ByPass.Description LIKE '" + filter.AdvanceObjectId + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_Object_ByPass.Description LIKE '%" + filter.AdvanceObjectId + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_Object_ByPass.Description = '" + filter.AdvanceObjectId + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_Object_ByPass.Description LIKE '%" + filter.AdvanceObjectId + "%'";
                        break;
                }
            }
            else if (filter.AdvanceObjectIdMultiple != null && filter.AdvanceObjectIdMultiple.Count() > 0)
            {
                var ObjectIdIds = string.Join(",", filter.AdvanceObjectIdMultiple);

                where += " AND Spartan_Attribute_Bypass.ObjectId In (" + ObjectIdIds + ")";
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
                _ISpartan_Attribute_BypassApiConsumer.SetAuthHeader(_tokenManager.Token);

                Spartan_Attribute_Bypass varSpartan_Attribute_Bypass = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _ISpartan_Attribute_BypassApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Spartan_Attribute_BypassModel varSpartan_Attribute_Bypass)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _ISpartan_Attribute_BypassApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Spartan_Attribute_BypassInfo = new Spartan_Attribute_Bypass
                    {
                        AttributeId = varSpartan_Attribute_Bypass.AttributeId
                        ,Description = varSpartan_Attribute_Bypass.Description
                        ,ObjectId = varSpartan_Attribute_Bypass.ObjectId

                    };

                    result = !IsNew ?
                        _ISpartan_Attribute_BypassApiConsumer.Update(Spartan_Attribute_BypassInfo, null, null).Resource.ToString() :
                         _ISpartan_Attribute_BypassApiConsumer.Insert(Spartan_Attribute_BypassInfo, null, null).Resource.ToString();
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
        /// Write Element Array of Spartan_Attribute_Bypass script
        /// </summary>
        /// <param name="oSpartan_Attribute_BypassElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Spartan_Attribute_BypassModuleAttributeList)
        {
            for (int i = 0; i < Spartan_Attribute_BypassModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Spartan_Attribute_BypassModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Spartan_Attribute_BypassModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Spartan_Attribute_BypassModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Spartan_Attribute_BypassModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Spartan_Attribute_BypassModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Spartan_Attribute_BypassModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Spartan_Attribute_BypassModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Spartan_Attribute_BypassModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Spartan_Attribute_BypassModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Spartan_Attribute_BypassModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Spartan_Attribute_BypassModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strSpartan_Attribute_BypassScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Spartan_Attribute_Bypass.js")))
            {
                strSpartan_Attribute_BypassScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Spartan_Attribute_Bypass element attributes
            string userChangeJson = jsSerialize.Serialize(Spartan_Attribute_BypassModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strSpartan_Attribute_BypassScript.IndexOf("inpuElementArray");
            string splittedString = strSpartan_Attribute_BypassScript.Substring(indexOfArray, strSpartan_Attribute_BypassScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Spartan_Attribute_BypassModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Spartan_Attribute_BypassModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strSpartan_Attribute_BypassScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strSpartan_Attribute_BypassScript.Substring(indexOfArrayHistory, strSpartan_Attribute_BypassScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strSpartan_Attribute_BypassScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strSpartan_Attribute_BypassScript.Substring(endIndexOfMainElement + indexOfArray, strSpartan_Attribute_BypassScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Spartan_Attribute_BypassModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Spartan_Attribute_BypassModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Spartan_Attribute_Bypass.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Spartan_Attribute_Bypass.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Spartan_Attribute_Bypass.js")))
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
        public ActionResult Spartan_Attribute_BypassPropertyBag()
        {
            return PartialView("Spartan_Attribute_BypassPropertyBag", "Spartan_Attribute_Bypass");
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
                var whereClauseFormat = "Object = 45360 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _ISpartan_Attribute_BypassApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Spartan_Attribute_Bypass.AttributeId= " + RecordId;
                            var result = _ISpartan_Attribute_BypassApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _ISpartan_Attribute_BypassApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Spartan_Attribute_BypassPropertyMapper());
			
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
                    (Spartan_Attribute_BypassAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Spartan_Attribute_BypassPropertyMapper oSpartan_Attribute_BypassPropertyMapper = new Spartan_Attribute_BypassPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oSpartan_Attribute_BypassPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _ISpartan_Attribute_BypassApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Spartan_Attribute_Bypasss == null)
                result.Spartan_Attribute_Bypasss = new List<Spartan_Attribute_Bypass>();

            var data = result.Spartan_Attribute_Bypasss.Select(m => new Spartan_Attribute_BypassGridModel
            {
                AttributeId = m.AttributeId
			,Description = m.Description
                        ,ObjectIdDescription = CultureHelper.GetTraduction(m.ObjectId_Spartan_Object_ByPass.ObjectId.ToString(), "Description") ?? (string)m.ObjectId_Spartan_Object_ByPass.Description

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45360, arrayColumnsVisible), "Spartan_Attribute_BypassList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45360, arrayColumnsVisible), "Spartan_Attribute_BypassList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45360, arrayColumnsVisible), "Spartan_Attribute_BypassList_" + DateTime.Now.ToString());
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

            _ISpartan_Attribute_BypassApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Spartan_Attribute_BypassPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Spartan_Attribute_BypassAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Spartan_Attribute_BypassPropertyMapper oSpartan_Attribute_BypassPropertyMapper = new Spartan_Attribute_BypassPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oSpartan_Attribute_BypassPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _ISpartan_Attribute_BypassApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Spartan_Attribute_Bypasss == null)
                result.Spartan_Attribute_Bypasss = new List<Spartan_Attribute_Bypass>();

            var data = result.Spartan_Attribute_Bypasss.Select(m => new Spartan_Attribute_BypassGridModel
            {
                AttributeId = m.AttributeId
			,Description = m.Description
                        ,ObjectIdDescription = CultureHelper.GetTraduction(m.ObjectId_Spartan_Object_ByPass.ObjectId.ToString(), "Description") ?? (string)m.ObjectId_Spartan_Object_ByPass.Description

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
                _ISpartan_Attribute_BypassApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISpartan_Attribute_BypassApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Spartan_Attribute_Bypass_Datos_GeneralesModel varSpartan_Attribute_Bypass)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISpartan_Attribute_BypassApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Spartan_Attribute_Bypass_Datos_GeneralesInfo = new Spartan_Attribute_Bypass_Datos_Generales
                {
                    AttributeId = varSpartan_Attribute_Bypass.AttributeId
                                            ,Description = varSpartan_Attribute_Bypass.Description
                        ,ObjectId = varSpartan_Attribute_Bypass.ObjectId
                    
                };

                result = _ISpartan_Attribute_BypassApiConsumer.Update_Datos_Generales(Spartan_Attribute_Bypass_Datos_GeneralesInfo).Resource.ToString();
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
                _ISpartan_Attribute_BypassApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _ISpartan_Attribute_BypassApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Spartan_Attribute_Bypass_Datos_GeneralesModel
                {
                    AttributeId = m.AttributeId
			,Description = m.Description
                        ,ObjectId = m.ObjectId
                        ,ObjectIdDescription = CultureHelper.GetTraduction(m.ObjectId_Spartan_Object_ByPass.ObjectId.ToString(), "Description") ?? (string)m.ObjectId_Spartan_Object_ByPass.Description

                    
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

