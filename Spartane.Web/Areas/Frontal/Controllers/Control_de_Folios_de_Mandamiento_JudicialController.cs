﻿using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Control_de_Folios_de_Mandamiento_Judicial;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Control_de_Folios_de_Mandamiento_Judicial;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Control_de_Folios_de_Mandamiento_Judicial;

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
    public class Control_de_Folios_de_Mandamiento_JudicialController : Controller
    {
        #region "variable declaration"

        private IControl_de_Folios_de_Mandamiento_JudicialService service = null;
        private IControl_de_Folios_de_Mandamiento_JudicialApiConsumer _IControl_de_Folios_de_Mandamiento_JudicialApiConsumer;

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

        
        public Control_de_Folios_de_Mandamiento_JudicialController(IControl_de_Folios_de_Mandamiento_JudicialService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IControl_de_Folios_de_Mandamiento_JudicialApiConsumer Control_de_Folios_de_Mandamiento_JudicialApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IControl_de_Folios_de_Mandamiento_JudicialApiConsumer = Control_de_Folios_de_Mandamiento_JudicialApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_FormatApiConsumer = Spartan_FormatApiConsumer;
            this._ISpartan_Format_PermissionsApiConsumer = Spartan_Format_PermissionsApiConsumer;
            this._IGeneratePDFApiConsumer = GeneratePDFApiConsumer;
			this._ISpartan_FormatRelatedApiConsumer = Spartan_Format_RelatedApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Control_de_Folios_de_Mandamiento_Judicial
        [ObjectAuth(ObjectId = (ModuleObjectId)46305, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 46305, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Control_de_Folios_de_Mandamiento_Judicial/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)46305, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 46305, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varControl_de_Folios_de_Mandamiento_Judicial = new Control_de_Folios_de_Mandamiento_JudicialModel();
			varControl_de_Folios_de_Mandamiento_Judicial.Consecutivo = Id;
			
            ViewBag.ObjectId = "46305";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IControl_de_Folios_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Control_de_Folios_de_Mandamiento_JudicialsData = _IControl_de_Folios_de_Mandamiento_JudicialApiConsumer.ListaSelAll(0, 1000, "Control_de_Folios_de_Mandamiento_Judicial.Consecutivo=" + Id, "").Resource.Control_de_Folios_de_Mandamiento_Judicials;
				
				if (Control_de_Folios_de_Mandamiento_JudicialsData != null && Control_de_Folios_de_Mandamiento_JudicialsData.Count > 0)
                {
					var Control_de_Folios_de_Mandamiento_JudicialData = Control_de_Folios_de_Mandamiento_JudicialsData.First();
					varControl_de_Folios_de_Mandamiento_Judicial= new Control_de_Folios_de_Mandamiento_JudicialModel
					{
						Consecutivo  = Control_de_Folios_de_Mandamiento_JudicialData.Consecutivo 
	                    ,Folio = Control_de_Folios_de_Mandamiento_JudicialData.Folio
                    ,Ano = Control_de_Folios_de_Mandamiento_JudicialData.Ano

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

				
            return View(varControl_de_Folios_de_Mandamiento_Judicial);
        }
		
	[HttpGet]
        public ActionResult AddControl_de_Folios_de_Mandamiento_Judicial(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 46305);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IControl_de_Folios_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
			Control_de_Folios_de_Mandamiento_JudicialModel varControl_de_Folios_de_Mandamiento_Judicial= new Control_de_Folios_de_Mandamiento_JudicialModel();


            if (id.ToString() != "0")
            {
                var Control_de_Folios_de_Mandamiento_JudicialsData = _IControl_de_Folios_de_Mandamiento_JudicialApiConsumer.ListaSelAll(0, 1000, "Control_de_Folios_de_Mandamiento_Judicial.Consecutivo=" + id, "").Resource.Control_de_Folios_de_Mandamiento_Judicials;
				
				if (Control_de_Folios_de_Mandamiento_JudicialsData != null && Control_de_Folios_de_Mandamiento_JudicialsData.Count > 0)
                {
					var Control_de_Folios_de_Mandamiento_JudicialData = Control_de_Folios_de_Mandamiento_JudicialsData.First();
					varControl_de_Folios_de_Mandamiento_Judicial= new Control_de_Folios_de_Mandamiento_JudicialModel
					{
						Consecutivo  = Control_de_Folios_de_Mandamiento_JudicialData.Consecutivo 
	                    ,Folio = Control_de_Folios_de_Mandamiento_JudicialData.Folio
                    ,Ano = Control_de_Folios_de_Mandamiento_JudicialData.Ano

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);



            return PartialView("AddControl_de_Folios_de_Mandamiento_Judicial", varControl_de_Folios_de_Mandamiento_Judicial);
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




        [HttpPost]
        public JsonResult ClearAdvanceFilter()
        {
            Session["AdvanceSearch"] = null;
            return Json(new { result = Session["AdvanceSearch"] == null }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult ShowAdvanceFilter(Control_de_Folios_de_Mandamiento_JudicialAdvanceSearchModel model, int idFilter = -1)
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



            var previousFiltersObj = new Control_de_Folios_de_Mandamiento_JudicialAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Control_de_Folios_de_Mandamiento_JudicialAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Control_de_Folios_de_Mandamiento_JudicialAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Control_de_Folios_de_Mandamiento_JudicialPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IControl_de_Folios_de_Mandamiento_JudicialApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Control_de_Folios_de_Mandamiento_Judicials == null)
                result.Control_de_Folios_de_Mandamiento_Judicials = new List<Control_de_Folios_de_Mandamiento_Judicial>();

            return Json(new
            {
                data = result.Control_de_Folios_de_Mandamiento_Judicials.Select(m => new Control_de_Folios_de_Mandamiento_JudicialGridModel
                    {
                    Consecutivo = m.Consecutivo
			,Folio = m.Folio
			,Ano = m.Ano

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetControl_de_Folios_de_Mandamiento_JudicialAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IControl_de_Folios_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IControl_de_Folios_de_Mandamiento_JudicialApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Consecutivo), "Control_de_Folios_de_Mandamiento_Judicial", m.),
                     Value = Convert.ToString(m.Consecutivo)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
*/
        /// <summary>
        /// Get List of Control_de_Folios_de_Mandamiento_Judicial from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Control_de_Folios_de_Mandamiento_Judicial Entity</returns>
        public ActionResult GetControl_de_Folios_de_Mandamiento_JudicialList(UrlParametersModel param)
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
            _IControl_de_Folios_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Control_de_Folios_de_Mandamiento_JudicialPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Control_de_Folios_de_Mandamiento_JudicialAdvanceSearchModel))
                {
					var advanceFilter =
                    (Control_de_Folios_de_Mandamiento_JudicialAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Control_de_Folios_de_Mandamiento_JudicialPropertyMapper oControl_de_Folios_de_Mandamiento_JudicialPropertyMapper = new Control_de_Folios_de_Mandamiento_JudicialPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oControl_de_Folios_de_Mandamiento_JudicialPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IControl_de_Folios_de_Mandamiento_JudicialApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Control_de_Folios_de_Mandamiento_Judicials == null)
                result.Control_de_Folios_de_Mandamiento_Judicials = new List<Control_de_Folios_de_Mandamiento_Judicial>();

            return Json(new
            {
                aaData = result.Control_de_Folios_de_Mandamiento_Judicials.Select(m => new Control_de_Folios_de_Mandamiento_JudicialGridModel
            {
                    Consecutivo = m.Consecutivo
			,Folio = m.Folio
			,Ano = m.Ano

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }







        [NonAction]
        public string GetAdvanceFilter(Control_de_Folios_de_Mandamiento_JudicialAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromConsecutivo) || !string.IsNullOrEmpty(filter.ToConsecutivo))
            {
                if (!string.IsNullOrEmpty(filter.FromConsecutivo))
                    where += " AND Control_de_Folios_de_Mandamiento_Judicial.Consecutivo >= " + filter.FromConsecutivo;
                if (!string.IsNullOrEmpty(filter.ToConsecutivo))
                    where += " AND Control_de_Folios_de_Mandamiento_Judicial.Consecutivo <= " + filter.ToConsecutivo;
            }

            if (!string.IsNullOrEmpty(filter.FromFolio) || !string.IsNullOrEmpty(filter.ToFolio))
            {
                if (!string.IsNullOrEmpty(filter.FromFolio))
                    where += " AND Control_de_Folios_de_Mandamiento_Judicial.Folio >= " + filter.FromFolio;
                if (!string.IsNullOrEmpty(filter.ToFolio))
                    where += " AND Control_de_Folios_de_Mandamiento_Judicial.Folio <= " + filter.ToFolio;
            }

            if (!string.IsNullOrEmpty(filter.FromAno) || !string.IsNullOrEmpty(filter.ToAno))
            {
                if (!string.IsNullOrEmpty(filter.FromAno))
                    where += " AND Control_de_Folios_de_Mandamiento_Judicial.Ano >= " + filter.FromAno;
                if (!string.IsNullOrEmpty(filter.ToAno))
                    where += " AND Control_de_Folios_de_Mandamiento_Judicial.Ano <= " + filter.ToAno;
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
                _IControl_de_Folios_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);

                Control_de_Folios_de_Mandamiento_Judicial varControl_de_Folios_de_Mandamiento_Judicial = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IControl_de_Folios_de_Mandamiento_JudicialApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Control_de_Folios_de_Mandamiento_JudicialModel varControl_de_Folios_de_Mandamiento_Judicial)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IControl_de_Folios_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Control_de_Folios_de_Mandamiento_JudicialInfo = new Control_de_Folios_de_Mandamiento_Judicial
                    {
                        Consecutivo = varControl_de_Folios_de_Mandamiento_Judicial.Consecutivo
                        ,Folio = varControl_de_Folios_de_Mandamiento_Judicial.Folio
                        ,Ano = varControl_de_Folios_de_Mandamiento_Judicial.Ano

                    };

                    result = !IsNew ?
                        _IControl_de_Folios_de_Mandamiento_JudicialApiConsumer.Update(Control_de_Folios_de_Mandamiento_JudicialInfo, null, null).Resource.ToString() :
                         _IControl_de_Folios_de_Mandamiento_JudicialApiConsumer.Insert(Control_de_Folios_de_Mandamiento_JudicialInfo, null, null).Resource.ToString();
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
        /// Write Element Array of Control_de_Folios_de_Mandamiento_Judicial script
        /// </summary>
        /// <param name="oControl_de_Folios_de_Mandamiento_JudicialElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Control_de_Folios_de_Mandamiento_JudicialModuleAttributeList)
        {
            for (int i = 0; i < Control_de_Folios_de_Mandamiento_JudicialModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Control_de_Folios_de_Mandamiento_JudicialModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Control_de_Folios_de_Mandamiento_JudicialModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Control_de_Folios_de_Mandamiento_JudicialModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Control_de_Folios_de_Mandamiento_JudicialModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Control_de_Folios_de_Mandamiento_JudicialModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Control_de_Folios_de_Mandamiento_JudicialModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Control_de_Folios_de_Mandamiento_JudicialModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Control_de_Folios_de_Mandamiento_JudicialModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Control_de_Folios_de_Mandamiento_JudicialModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Control_de_Folios_de_Mandamiento_JudicialModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Control_de_Folios_de_Mandamiento_JudicialModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strControl_de_Folios_de_Mandamiento_JudicialScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Control_de_Folios_de_Mandamiento_Judicial.js")))
            {
                strControl_de_Folios_de_Mandamiento_JudicialScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Control_de_Folios_de_Mandamiento_Judicial element attributes
            string userChangeJson = jsSerialize.Serialize(Control_de_Folios_de_Mandamiento_JudicialModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strControl_de_Folios_de_Mandamiento_JudicialScript.IndexOf("inpuElementArray");
            string splittedString = strControl_de_Folios_de_Mandamiento_JudicialScript.Substring(indexOfArray, strControl_de_Folios_de_Mandamiento_JudicialScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Control_de_Folios_de_Mandamiento_JudicialModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Control_de_Folios_de_Mandamiento_JudicialModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strControl_de_Folios_de_Mandamiento_JudicialScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strControl_de_Folios_de_Mandamiento_JudicialScript.Substring(indexOfArrayHistory, strControl_de_Folios_de_Mandamiento_JudicialScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strControl_de_Folios_de_Mandamiento_JudicialScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strControl_de_Folios_de_Mandamiento_JudicialScript.Substring(endIndexOfMainElement + indexOfArray, strControl_de_Folios_de_Mandamiento_JudicialScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Control_de_Folios_de_Mandamiento_JudicialModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Control_de_Folios_de_Mandamiento_JudicialModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Control_de_Folios_de_Mandamiento_Judicial.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Control_de_Folios_de_Mandamiento_Judicial.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Control_de_Folios_de_Mandamiento_Judicial.js")))
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
        public ActionResult Control_de_Folios_de_Mandamiento_JudicialPropertyBag()
        {
            return PartialView("Control_de_Folios_de_Mandamiento_JudicialPropertyBag", "Control_de_Folios_de_Mandamiento_Judicial");
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
                var whereClauseFormat = "Object = 46305 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IControl_de_Folios_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Control_de_Folios_de_Mandamiento_Judicial.Consecutivo= " + RecordId;
                            var result = _IControl_de_Folios_de_Mandamiento_JudicialApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IControl_de_Folios_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Control_de_Folios_de_Mandamiento_JudicialPropertyMapper());
			
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
                    (Control_de_Folios_de_Mandamiento_JudicialAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Control_de_Folios_de_Mandamiento_JudicialPropertyMapper oControl_de_Folios_de_Mandamiento_JudicialPropertyMapper = new Control_de_Folios_de_Mandamiento_JudicialPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oControl_de_Folios_de_Mandamiento_JudicialPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IControl_de_Folios_de_Mandamiento_JudicialApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Control_de_Folios_de_Mandamiento_Judicials == null)
                result.Control_de_Folios_de_Mandamiento_Judicials = new List<Control_de_Folios_de_Mandamiento_Judicial>();

            var data = result.Control_de_Folios_de_Mandamiento_Judicials.Select(m => new Control_de_Folios_de_Mandamiento_JudicialGridModel
            {
                Consecutivo = m.Consecutivo
			,Folio = m.Folio
			,Ano = m.Ano

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(46305, arrayColumnsVisible), "Control_de_Folios_de_Mandamiento_JudicialList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(46305, arrayColumnsVisible), "Control_de_Folios_de_Mandamiento_JudicialList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(46305, arrayColumnsVisible), "Control_de_Folios_de_Mandamiento_JudicialList_" + DateTime.Now.ToString());
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

            _IControl_de_Folios_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Control_de_Folios_de_Mandamiento_JudicialPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Control_de_Folios_de_Mandamiento_JudicialAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Control_de_Folios_de_Mandamiento_JudicialPropertyMapper oControl_de_Folios_de_Mandamiento_JudicialPropertyMapper = new Control_de_Folios_de_Mandamiento_JudicialPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oControl_de_Folios_de_Mandamiento_JudicialPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IControl_de_Folios_de_Mandamiento_JudicialApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Control_de_Folios_de_Mandamiento_Judicials == null)
                result.Control_de_Folios_de_Mandamiento_Judicials = new List<Control_de_Folios_de_Mandamiento_Judicial>();

            var data = result.Control_de_Folios_de_Mandamiento_Judicials.Select(m => new Control_de_Folios_de_Mandamiento_JudicialGridModel
            {
                Consecutivo = m.Consecutivo
			,Folio = m.Folio
			,Ano = m.Ano

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
                _IControl_de_Folios_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IControl_de_Folios_de_Mandamiento_JudicialApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Control_de_Folios_de_Mandamiento_Judicial_Datos_GeneralesModel varControl_de_Folios_de_Mandamiento_Judicial)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IControl_de_Folios_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Control_de_Folios_de_Mandamiento_Judicial_Datos_GeneralesInfo = new Control_de_Folios_de_Mandamiento_Judicial_Datos_Generales
                {
                    Consecutivo = varControl_de_Folios_de_Mandamiento_Judicial.Consecutivo
                                            ,Folio = varControl_de_Folios_de_Mandamiento_Judicial.Folio
                        ,Ano = varControl_de_Folios_de_Mandamiento_Judicial.Ano
                    
                };

                result = _IControl_de_Folios_de_Mandamiento_JudicialApiConsumer.Update_Datos_Generales(Control_de_Folios_de_Mandamiento_Judicial_Datos_GeneralesInfo).Resource.ToString();
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
                _IControl_de_Folios_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IControl_de_Folios_de_Mandamiento_JudicialApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Control_de_Folios_de_Mandamiento_Judicial_Datos_GeneralesModel
                {
                    Consecutivo = m.Consecutivo
			,Folio = m.Folio
			,Ano = m.Ano

                    
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

