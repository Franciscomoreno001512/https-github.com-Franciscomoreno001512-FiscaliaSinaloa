using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Especialista_de_Justicia_Alternativa;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Especialista_de_Justicia_Alternativa;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Especialista_de_Justicia_Alternativa;

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
    public class Especialista_de_Justicia_AlternativaController : Controller
    {
        #region "variable declaration"

        private IEspecialista_de_Justicia_AlternativaService service = null;
        private IEspecialista_de_Justicia_AlternativaApiConsumer _IEspecialista_de_Justicia_AlternativaApiConsumer;

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

        
        public Especialista_de_Justicia_AlternativaController(IEspecialista_de_Justicia_AlternativaService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IEspecialista_de_Justicia_AlternativaApiConsumer Especialista_de_Justicia_AlternativaApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IEspecialista_de_Justicia_AlternativaApiConsumer = Especialista_de_Justicia_AlternativaApiConsumer;
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

        // GET: Frontal/Especialista_de_Justicia_Alternativa
        [ObjectAuth(ObjectId = (ModuleObjectId)45008, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45008, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Especialista_de_Justicia_Alternativa/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45008, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45008, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varEspecialista_de_Justicia_Alternativa = new Especialista_de_Justicia_AlternativaModel();
			varEspecialista_de_Justicia_Alternativa.Clave = Id;
			
            ViewBag.ObjectId = "45008";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IEspecialista_de_Justicia_AlternativaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Especialista_de_Justicia_AlternativasData = _IEspecialista_de_Justicia_AlternativaApiConsumer.ListaSelAll(0, 1000, "Especialista_de_Justicia_Alternativa.Clave=" + Id, "").Resource.Especialista_de_Justicia_Alternativas;
				
				if (Especialista_de_Justicia_AlternativasData != null && Especialista_de_Justicia_AlternativasData.Count > 0)
                {
					var Especialista_de_Justicia_AlternativaData = Especialista_de_Justicia_AlternativasData.First();
					varEspecialista_de_Justicia_Alternativa= new Especialista_de_Justicia_AlternativaModel
					{
						Clave  = Especialista_de_Justicia_AlternativaData.Clave 
	                    ,Numero_de_Empleado = Especialista_de_Justicia_AlternativaData.Numero_de_Empleado
                    ,Nombre_de_Especialista = Especialista_de_Justicia_AlternativaData.Nombre_de_Especialista
                    ,Carga_de_Trabajo = Especialista_de_Justicia_AlternativaData.Carga_de_Trabajo

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

				
            return View(varEspecialista_de_Justicia_Alternativa);
        }
		
	[HttpGet]
        public ActionResult AddEspecialista_de_Justicia_Alternativa(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45008);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IEspecialista_de_Justicia_AlternativaApiConsumer.SetAuthHeader(_tokenManager.Token);
			Especialista_de_Justicia_AlternativaModel varEspecialista_de_Justicia_Alternativa= new Especialista_de_Justicia_AlternativaModel();


            if (id.ToString() != "0")
            {
                var Especialista_de_Justicia_AlternativasData = _IEspecialista_de_Justicia_AlternativaApiConsumer.ListaSelAll(0, 1000, "Especialista_de_Justicia_Alternativa.Clave=" + id, "").Resource.Especialista_de_Justicia_Alternativas;
				
				if (Especialista_de_Justicia_AlternativasData != null && Especialista_de_Justicia_AlternativasData.Count > 0)
                {
					var Especialista_de_Justicia_AlternativaData = Especialista_de_Justicia_AlternativasData.First();
					varEspecialista_de_Justicia_Alternativa= new Especialista_de_Justicia_AlternativaModel
					{
						Clave  = Especialista_de_Justicia_AlternativaData.Clave 
	                    ,Numero_de_Empleado = Especialista_de_Justicia_AlternativaData.Numero_de_Empleado
                    ,Nombre_de_Especialista = Especialista_de_Justicia_AlternativaData.Nombre_de_Especialista
                    ,Carga_de_Trabajo = Especialista_de_Justicia_AlternativaData.Carga_de_Trabajo

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);



            return PartialView("AddEspecialista_de_Justicia_Alternativa", varEspecialista_de_Justicia_Alternativa);
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
        public ActionResult ShowAdvanceFilter(Especialista_de_Justicia_AlternativaAdvanceSearchModel model, int idFilter = -1)
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



            var previousFiltersObj = new Especialista_de_Justicia_AlternativaAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Especialista_de_Justicia_AlternativaAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Especialista_de_Justicia_AlternativaAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Especialista_de_Justicia_AlternativaPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IEspecialista_de_Justicia_AlternativaApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Especialista_de_Justicia_Alternativas == null)
                result.Especialista_de_Justicia_Alternativas = new List<Especialista_de_Justicia_Alternativa>();

            return Json(new
            {
                data = result.Especialista_de_Justicia_Alternativas.Select(m => new Especialista_de_Justicia_AlternativaGridModel
                    {
                    Clave = m.Clave
			,Numero_de_Empleado = m.Numero_de_Empleado
			,Nombre_de_Especialista = m.Nombre_de_Especialista
			,Carga_de_Trabajo = m.Carga_de_Trabajo

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetEspecialista_de_Justicia_AlternativaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEspecialista_de_Justicia_AlternativaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEspecialista_de_Justicia_AlternativaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Especialista_de_Justicia_Alternativa", m.),
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
        /// Get List of Especialista_de_Justicia_Alternativa from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Especialista_de_Justicia_Alternativa Entity</returns>
        public ActionResult GetEspecialista_de_Justicia_AlternativaList(UrlParametersModel param)
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
            _IEspecialista_de_Justicia_AlternativaApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Especialista_de_Justicia_AlternativaPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Especialista_de_Justicia_AlternativaAdvanceSearchModel))
                {
					var advanceFilter =
                    (Especialista_de_Justicia_AlternativaAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Especialista_de_Justicia_AlternativaPropertyMapper oEspecialista_de_Justicia_AlternativaPropertyMapper = new Especialista_de_Justicia_AlternativaPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oEspecialista_de_Justicia_AlternativaPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IEspecialista_de_Justicia_AlternativaApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Especialista_de_Justicia_Alternativas == null)
                result.Especialista_de_Justicia_Alternativas = new List<Especialista_de_Justicia_Alternativa>();

            return Json(new
            {
                aaData = result.Especialista_de_Justicia_Alternativas.Select(m => new Especialista_de_Justicia_AlternativaGridModel
            {
                    Clave = m.Clave
			,Numero_de_Empleado = m.Numero_de_Empleado
			,Nombre_de_Especialista = m.Nombre_de_Especialista
			,Carga_de_Trabajo = m.Carga_de_Trabajo

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }







        [NonAction]
        public string GetAdvanceFilter(Especialista_de_Justicia_AlternativaAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Especialista_de_Justicia_Alternativa.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Especialista_de_Justicia_Alternativa.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.Numero_de_Empleado))
            {
                switch (filter.Numero_de_EmpleadoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Especialista_de_Justicia_Alternativa.Numero_de_Empleado LIKE '" + filter.Numero_de_Empleado + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Especialista_de_Justicia_Alternativa.Numero_de_Empleado LIKE '%" + filter.Numero_de_Empleado + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Especialista_de_Justicia_Alternativa.Numero_de_Empleado = '" + filter.Numero_de_Empleado + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Especialista_de_Justicia_Alternativa.Numero_de_Empleado LIKE '%" + filter.Numero_de_Empleado + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Nombre_de_Especialista))
            {
                switch (filter.Nombre_de_EspecialistaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Especialista_de_Justicia_Alternativa.Nombre_de_Especialista LIKE '" + filter.Nombre_de_Especialista + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Especialista_de_Justicia_Alternativa.Nombre_de_Especialista LIKE '%" + filter.Nombre_de_Especialista + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Especialista_de_Justicia_Alternativa.Nombre_de_Especialista = '" + filter.Nombre_de_Especialista + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Especialista_de_Justicia_Alternativa.Nombre_de_Especialista LIKE '%" + filter.Nombre_de_Especialista + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromCarga_de_Trabajo) || !string.IsNullOrEmpty(filter.ToCarga_de_Trabajo))
            {
                if (!string.IsNullOrEmpty(filter.FromCarga_de_Trabajo))
                    where += " AND Especialista_de_Justicia_Alternativa.Carga_de_Trabajo >= " + filter.FromCarga_de_Trabajo;
                if (!string.IsNullOrEmpty(filter.ToCarga_de_Trabajo))
                    where += " AND Especialista_de_Justicia_Alternativa.Carga_de_Trabajo <= " + filter.ToCarga_de_Trabajo;
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
                _IEspecialista_de_Justicia_AlternativaApiConsumer.SetAuthHeader(_tokenManager.Token);

                Especialista_de_Justicia_Alternativa varEspecialista_de_Justicia_Alternativa = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IEspecialista_de_Justicia_AlternativaApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Especialista_de_Justicia_AlternativaModel varEspecialista_de_Justicia_Alternativa)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IEspecialista_de_Justicia_AlternativaApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Especialista_de_Justicia_AlternativaInfo = new Especialista_de_Justicia_Alternativa
                    {
                        Clave = varEspecialista_de_Justicia_Alternativa.Clave
                        ,Numero_de_Empleado = varEspecialista_de_Justicia_Alternativa.Numero_de_Empleado
                        ,Nombre_de_Especialista = varEspecialista_de_Justicia_Alternativa.Nombre_de_Especialista
                        ,Carga_de_Trabajo = varEspecialista_de_Justicia_Alternativa.Carga_de_Trabajo

                    };

                    result = !IsNew ?
                        _IEspecialista_de_Justicia_AlternativaApiConsumer.Update(Especialista_de_Justicia_AlternativaInfo, null, null).Resource.ToString() :
                         _IEspecialista_de_Justicia_AlternativaApiConsumer.Insert(Especialista_de_Justicia_AlternativaInfo, null, null).Resource.ToString();
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
        /// Write Element Array of Especialista_de_Justicia_Alternativa script
        /// </summary>
        /// <param name="oEspecialista_de_Justicia_AlternativaElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Especialista_de_Justicia_AlternativaModuleAttributeList)
        {
            for (int i = 0; i < Especialista_de_Justicia_AlternativaModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Especialista_de_Justicia_AlternativaModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Especialista_de_Justicia_AlternativaModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Especialista_de_Justicia_AlternativaModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Especialista_de_Justicia_AlternativaModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Especialista_de_Justicia_AlternativaModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Especialista_de_Justicia_AlternativaModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Especialista_de_Justicia_AlternativaModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Especialista_de_Justicia_AlternativaModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Especialista_de_Justicia_AlternativaModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Especialista_de_Justicia_AlternativaModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Especialista_de_Justicia_AlternativaModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strEspecialista_de_Justicia_AlternativaScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Especialista_de_Justicia_Alternativa.js")))
            {
                strEspecialista_de_Justicia_AlternativaScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Especialista_de_Justicia_Alternativa element attributes
            string userChangeJson = jsSerialize.Serialize(Especialista_de_Justicia_AlternativaModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strEspecialista_de_Justicia_AlternativaScript.IndexOf("inpuElementArray");
            string splittedString = strEspecialista_de_Justicia_AlternativaScript.Substring(indexOfArray, strEspecialista_de_Justicia_AlternativaScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Especialista_de_Justicia_AlternativaModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Especialista_de_Justicia_AlternativaModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strEspecialista_de_Justicia_AlternativaScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strEspecialista_de_Justicia_AlternativaScript.Substring(indexOfArrayHistory, strEspecialista_de_Justicia_AlternativaScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strEspecialista_de_Justicia_AlternativaScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strEspecialista_de_Justicia_AlternativaScript.Substring(endIndexOfMainElement + indexOfArray, strEspecialista_de_Justicia_AlternativaScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Especialista_de_Justicia_AlternativaModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Especialista_de_Justicia_AlternativaModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Especialista_de_Justicia_Alternativa.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Especialista_de_Justicia_Alternativa.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Especialista_de_Justicia_Alternativa.js")))
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
        public ActionResult Especialista_de_Justicia_AlternativaPropertyBag()
        {
            return PartialView("Especialista_de_Justicia_AlternativaPropertyBag", "Especialista_de_Justicia_Alternativa");
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
                var whereClauseFormat = "Object = 45008 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IEspecialista_de_Justicia_AlternativaApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Especialista_de_Justicia_Alternativa.Clave= " + RecordId;
                            var result = _IEspecialista_de_Justicia_AlternativaApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IEspecialista_de_Justicia_AlternativaApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Especialista_de_Justicia_AlternativaPropertyMapper());
			
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
                    (Especialista_de_Justicia_AlternativaAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Especialista_de_Justicia_AlternativaPropertyMapper oEspecialista_de_Justicia_AlternativaPropertyMapper = new Especialista_de_Justicia_AlternativaPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oEspecialista_de_Justicia_AlternativaPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IEspecialista_de_Justicia_AlternativaApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Especialista_de_Justicia_Alternativas == null)
                result.Especialista_de_Justicia_Alternativas = new List<Especialista_de_Justicia_Alternativa>();

            var data = result.Especialista_de_Justicia_Alternativas.Select(m => new Especialista_de_Justicia_AlternativaGridModel
            {
                Clave = m.Clave
			,Numero_de_Empleado = m.Numero_de_Empleado
			,Nombre_de_Especialista = m.Nombre_de_Especialista
			,Carga_de_Trabajo = m.Carga_de_Trabajo

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45008, arrayColumnsVisible), "Especialista_de_Justicia_AlternativaList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45008, arrayColumnsVisible), "Especialista_de_Justicia_AlternativaList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45008, arrayColumnsVisible), "Especialista_de_Justicia_AlternativaList_" + DateTime.Now.ToString());
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

            _IEspecialista_de_Justicia_AlternativaApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Especialista_de_Justicia_AlternativaPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Especialista_de_Justicia_AlternativaAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Especialista_de_Justicia_AlternativaPropertyMapper oEspecialista_de_Justicia_AlternativaPropertyMapper = new Especialista_de_Justicia_AlternativaPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oEspecialista_de_Justicia_AlternativaPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IEspecialista_de_Justicia_AlternativaApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Especialista_de_Justicia_Alternativas == null)
                result.Especialista_de_Justicia_Alternativas = new List<Especialista_de_Justicia_Alternativa>();

            var data = result.Especialista_de_Justicia_Alternativas.Select(m => new Especialista_de_Justicia_AlternativaGridModel
            {
                Clave = m.Clave
			,Numero_de_Empleado = m.Numero_de_Empleado
			,Nombre_de_Especialista = m.Nombre_de_Especialista
			,Carga_de_Trabajo = m.Carga_de_Trabajo

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
                _IEspecialista_de_Justicia_AlternativaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEspecialista_de_Justicia_AlternativaApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Especialista_de_Justicia_Alternativa_Datos_GeneralesModel varEspecialista_de_Justicia_Alternativa)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEspecialista_de_Justicia_AlternativaApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Especialista_de_Justicia_Alternativa_Datos_GeneralesInfo = new Especialista_de_Justicia_Alternativa_Datos_Generales
                {
                    Clave = varEspecialista_de_Justicia_Alternativa.Clave
                                            ,Numero_de_Empleado = varEspecialista_de_Justicia_Alternativa.Numero_de_Empleado
                        ,Nombre_de_Especialista = varEspecialista_de_Justicia_Alternativa.Nombre_de_Especialista
                        ,Carga_de_Trabajo = varEspecialista_de_Justicia_Alternativa.Carga_de_Trabajo
                    
                };

                result = _IEspecialista_de_Justicia_AlternativaApiConsumer.Update_Datos_Generales(Especialista_de_Justicia_Alternativa_Datos_GeneralesInfo).Resource.ToString();
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
                _IEspecialista_de_Justicia_AlternativaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IEspecialista_de_Justicia_AlternativaApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Especialista_de_Justicia_Alternativa_Datos_GeneralesModel
                {
                    Clave = m.Clave
			,Numero_de_Empleado = m.Numero_de_Empleado
			,Nombre_de_Especialista = m.Nombre_de_Especialista
			,Carga_de_Trabajo = m.Carga_de_Trabajo

                    
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

