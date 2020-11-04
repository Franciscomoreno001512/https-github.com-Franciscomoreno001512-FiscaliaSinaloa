using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Descarga_de_Archivo;
using Spartane.Core.Domain.Detalle_de_Descarga_de_Archivo;




using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Descarga_de_Archivo;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Descarga_de_Archivo;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Descarga_de_Archivo;



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
    public class Descarga_de_ArchivoController : Controller
    {
        #region "variable declaration"

        private IDescarga_de_ArchivoService service = null;
        private IDescarga_de_ArchivoApiConsumer _IDescarga_de_ArchivoApiConsumer;
        private IDetalle_de_Descarga_de_ArchivoApiConsumer _IDetalle_de_Descarga_de_ArchivoApiConsumer;



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

        
        public Descarga_de_ArchivoController(IDescarga_de_ArchivoService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDescarga_de_ArchivoApiConsumer Descarga_de_ArchivoApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , IDetalle_de_Descarga_de_ArchivoApiConsumer Detalle_de_Descarga_de_ArchivoApiConsumer 
)
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDescarga_de_ArchivoApiConsumer = Descarga_de_ArchivoApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_FormatApiConsumer = Spartan_FormatApiConsumer;
            this._ISpartan_Format_PermissionsApiConsumer = Spartan_Format_PermissionsApiConsumer;
            this._IGeneratePDFApiConsumer = GeneratePDFApiConsumer;
			this._ISpartan_FormatRelatedApiConsumer = Spartan_Format_RelatedApiConsumer;
            this._IDetalle_de_Descarga_de_ArchivoApiConsumer = Detalle_de_Descarga_de_ArchivoApiConsumer;



        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Descarga_de_Archivo
        [ObjectAuth(ObjectId = (ModuleObjectId)45113, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45113, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Descarga_de_Archivo/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45113, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45113, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varDescarga_de_Archivo = new Descarga_de_ArchivoModel();
			varDescarga_de_Archivo.Clave = Id;
			
            ViewBag.ObjectId = "45113";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;

            var permissionDetalle_de_Descarga_de_Archivo = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45114, ModuleId);
            ViewBag.PermissionDetalle_de_Descarga_de_Archivo = permissionDetalle_de_Descarga_de_Archivo;


            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IDescarga_de_ArchivoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Descarga_de_ArchivosData = _IDescarga_de_ArchivoApiConsumer.ListaSelAll(0, 1000, "Descarga_de_Archivo.Clave=" + Id, "").Resource.Descarga_de_Archivos;
				
				if (Descarga_de_ArchivosData != null && Descarga_de_ArchivosData.Count > 0)
                {
					var Descarga_de_ArchivoData = Descarga_de_ArchivosData.First();
					varDescarga_de_Archivo= new Descarga_de_ArchivoModel
					{
						Clave  = Descarga_de_ArchivoData.Clave 
	                    ,Nombre = Descarga_de_ArchivoData.Nombre

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

				
            return View(varDescarga_de_Archivo);
        }
		
	[HttpGet]
        public ActionResult AddDescarga_de_Archivo(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45113);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDescarga_de_ArchivoApiConsumer.SetAuthHeader(_tokenManager.Token);
			Descarga_de_ArchivoModel varDescarga_de_Archivo= new Descarga_de_ArchivoModel();
            var permissionDetalle_de_Descarga_de_Archivo = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45114, ModuleId);
            ViewBag.PermissionDetalle_de_Descarga_de_Archivo = permissionDetalle_de_Descarga_de_Archivo;


            if (id.ToString() != "0")
            {
                var Descarga_de_ArchivosData = _IDescarga_de_ArchivoApiConsumer.ListaSelAll(0, 1000, "Descarga_de_Archivo.Clave=" + id, "").Resource.Descarga_de_Archivos;
				
				if (Descarga_de_ArchivosData != null && Descarga_de_ArchivosData.Count > 0)
                {
					var Descarga_de_ArchivoData = Descarga_de_ArchivosData.First();
					varDescarga_de_Archivo= new Descarga_de_ArchivoModel
					{
						Clave  = Descarga_de_ArchivoData.Clave 
	                    ,Nombre = Descarga_de_ArchivoData.Nombre

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);



            return PartialView("AddDescarga_de_Archivo", varDescarga_de_Archivo);
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
        public ActionResult ShowAdvanceFilter(Descarga_de_ArchivoAdvanceSearchModel model, int idFilter = -1)
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



            var previousFiltersObj = new Descarga_de_ArchivoAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Descarga_de_ArchivoAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Descarga_de_ArchivoAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Descarga_de_ArchivoPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDescarga_de_ArchivoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Descarga_de_Archivos == null)
                result.Descarga_de_Archivos = new List<Descarga_de_Archivo>();

            return Json(new
            {
                data = result.Descarga_de_Archivos.Select(m => new Descarga_de_ArchivoGridModel
                    {
                    Clave = m.Clave
			,Nombre = m.Nombre

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetDescarga_de_ArchivoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDescarga_de_ArchivoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDescarga_de_ArchivoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Descarga_de_Archivo", m.),
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
        /// Get List of Descarga_de_Archivo from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Descarga_de_Archivo Entity</returns>
        public ActionResult GetDescarga_de_ArchivoList(UrlParametersModel param)
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
            _IDescarga_de_ArchivoApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Descarga_de_ArchivoPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Descarga_de_ArchivoAdvanceSearchModel))
                {
					var advanceFilter =
                    (Descarga_de_ArchivoAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Descarga_de_ArchivoPropertyMapper oDescarga_de_ArchivoPropertyMapper = new Descarga_de_ArchivoPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oDescarga_de_ArchivoPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IDescarga_de_ArchivoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Descarga_de_Archivos == null)
                result.Descarga_de_Archivos = new List<Descarga_de_Archivo>();

            return Json(new
            {
                aaData = result.Descarga_de_Archivos.Select(m => new Descarga_de_ArchivoGridModel
            {
                    Clave = m.Clave
			,Nombre = m.Nombre

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


//Grid GetAutoComplete






        [NonAction]
        public string GetAdvanceFilter(Descarga_de_ArchivoAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Descarga_de_Archivo.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Descarga_de_Archivo.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.Nombre))
            {
                switch (filter.NombreFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Descarga_de_Archivo.Nombre LIKE '" + filter.Nombre + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Descarga_de_Archivo.Nombre LIKE '%" + filter.Nombre + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Descarga_de_Archivo.Nombre = '" + filter.Nombre + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Descarga_de_Archivo.Nombre LIKE '%" + filter.Nombre + "%'";
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

        public ActionResult GetDetalle_de_Descarga_de_Archivo(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_Descarga_de_ArchivoGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Descarga_de_ArchivoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_Descarga_de_Archivo.Descarga_de_Archivos=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_Descarga_de_Archivo.Descarga_de_Archivos='" + RelationId + "'";
            }
            var result = _IDetalle_de_Descarga_de_ArchivoApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_Descarga_de_Archivos == null)
                result.Detalle_de_Descarga_de_Archivos = new List<Detalle_de_Descarga_de_Archivo>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_Descarga_de_Archivos.Select(m => new Detalle_de_Descarga_de_ArchivoGridModel
                {
                    Clave = m.Clave

			,Documento = m.Documento

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_Descarga_de_ArchivoGridModel> GetDetalle_de_Descarga_de_ArchivoData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_Descarga_de_ArchivoGridModel> resultData = new List<Detalle_de_Descarga_de_ArchivoGridModel>();
            string where = "Detalle_de_Descarga_de_Archivo.Descarga_de_Archivos=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_Descarga_de_Archivo.Descarga_de_Archivos='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Descarga_de_ArchivoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_Descarga_de_ArchivoApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_Descarga_de_Archivos != null)
            {
                resultData = result.Detalle_de_Descarga_de_Archivos.Select(m => new Detalle_de_Descarga_de_ArchivoGridModel
                    {
                        Clave = m.Clave

			,Documento = m.Documento


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
                _IDescarga_de_ArchivoApiConsumer.SetAuthHeader(_tokenManager.Token);

                Descarga_de_Archivo varDescarga_de_Archivo = null;
                if (id.ToString() != "0")
                {
                        string where = "";
                    _IDetalle_de_Descarga_de_ArchivoApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_Descarga_de_Archivo.Descarga_de_Archivos=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_Descarga_de_Archivo.Descarga_de_Archivos='" + id + "'";
                    }
                    var Detalle_de_Descarga_de_ArchivoInfo =
                        _IDetalle_de_Descarga_de_ArchivoApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_Descarga_de_ArchivoInfo.Detalle_de_Descarga_de_Archivos.Count > 0)
                    {
                        var resultDetalle_de_Descarga_de_Archivo = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_Descarga_de_ArchivoItem in Detalle_de_Descarga_de_ArchivoInfo.Detalle_de_Descarga_de_Archivos)
                            resultDetalle_de_Descarga_de_Archivo = resultDetalle_de_Descarga_de_Archivo
                                              && _IDetalle_de_Descarga_de_ArchivoApiConsumer.Delete(Detalle_de_Descarga_de_ArchivoItem.Clave, null,null).Resource;

                        if (!resultDetalle_de_Descarga_de_Archivo)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }

                }
                var result = _IDescarga_de_ArchivoApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Descarga_de_ArchivoModel varDescarga_de_Archivo)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDescarga_de_ArchivoApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Descarga_de_ArchivoInfo = new Descarga_de_Archivo
                    {
                        Clave = varDescarga_de_Archivo.Clave
                        ,Nombre = varDescarga_de_Archivo.Nombre

                    };

                    result = !IsNew ?
                        _IDescarga_de_ArchivoApiConsumer.Update(Descarga_de_ArchivoInfo, null, null).Resource.ToString() :
                         _IDescarga_de_ArchivoApiConsumer.Insert(Descarga_de_ArchivoInfo, null, null).Resource.ToString();
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
        public bool CopyDetalle_de_Descarga_de_Archivo(int MasterId, int referenceId, List<Detalle_de_Descarga_de_ArchivoGridModelPost> Detalle_de_Descarga_de_ArchivoItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_Descarga_de_ArchivoApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_Descarga_de_ArchivoData = _IDetalle_de_Descarga_de_ArchivoApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_Descarga_de_Archivo.Descarga_de_Archivos=" + referenceId,"").Resource;
                if (Detalle_de_Descarga_de_ArchivoData == null || Detalle_de_Descarga_de_ArchivoData.Detalle_de_Descarga_de_Archivos.Count == 0)
                    return true;

                var result = true;

                Detalle_de_Descarga_de_ArchivoGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_Descarga_de_Archivo in Detalle_de_Descarga_de_ArchivoData.Detalle_de_Descarga_de_Archivos)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_Descarga_de_Archivo Detalle_de_Descarga_de_Archivo1 = varDetalle_de_Descarga_de_Archivo;

                    if (Detalle_de_Descarga_de_ArchivoItems != null && Detalle_de_Descarga_de_ArchivoItems.Any(m => m.Clave == Detalle_de_Descarga_de_Archivo1.Clave))
                    {
                        modelDataToChange = Detalle_de_Descarga_de_ArchivoItems.FirstOrDefault(m => m.Clave == Detalle_de_Descarga_de_Archivo1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_de_Descarga_de_Archivo.Descarga_de_Archivos = MasterId;
                    var insertId = _IDetalle_de_Descarga_de_ArchivoApiConsumer.Insert(varDetalle_de_Descarga_de_Archivo,null,null).Resource;
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
        public ActionResult PostDetalle_de_Descarga_de_Archivo(List<Detalle_de_Descarga_de_ArchivoGridModelPost> Detalle_de_Descarga_de_ArchivoItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_Descarga_de_Archivo(MasterId, referenceId, Detalle_de_Descarga_de_ArchivoItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_Descarga_de_ArchivoItems != null && Detalle_de_Descarga_de_ArchivoItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_Descarga_de_ArchivoApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_Descarga_de_ArchivoItem in Detalle_de_Descarga_de_ArchivoItems)
                    {



                        //Removal Request
                        if (Detalle_de_Descarga_de_ArchivoItem.Removed)
                        {
                            result = result && _IDetalle_de_Descarga_de_ArchivoApiConsumer.Delete(Detalle_de_Descarga_de_ArchivoItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_Descarga_de_ArchivoItem.Clave = 0;

                        var Detalle_de_Descarga_de_ArchivoData = new Detalle_de_Descarga_de_Archivo
                        {
                            Descarga_de_Archivos = MasterId
                            ,Clave = Detalle_de_Descarga_de_ArchivoItem.Clave
                            ,Documento = Detalle_de_Descarga_de_ArchivoItem.Documento

                        };

                        var resultId = Detalle_de_Descarga_de_ArchivoItem.Clave > 0
                           ? _IDetalle_de_Descarga_de_ArchivoApiConsumer.Update(Detalle_de_Descarga_de_ArchivoData,null,null).Resource
                           : _IDetalle_de_Descarga_de_ArchivoApiConsumer.Insert(Detalle_de_Descarga_de_ArchivoData,null,null).Resource;

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






        /// <summary>
        /// Write Element Array of Descarga_de_Archivo script
        /// </summary>
        /// <param name="oDescarga_de_ArchivoElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Descarga_de_ArchivoModuleAttributeList)
        {
            for (int i = 0; i < Descarga_de_ArchivoModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Descarga_de_ArchivoModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Descarga_de_ArchivoModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Descarga_de_ArchivoModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Descarga_de_ArchivoModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Descarga_de_ArchivoModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Descarga_de_ArchivoModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Descarga_de_ArchivoModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Descarga_de_ArchivoModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Descarga_de_ArchivoModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Descarga_de_ArchivoModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Descarga_de_ArchivoModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strDescarga_de_ArchivoScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Descarga_de_Archivo.js")))
            {
                strDescarga_de_ArchivoScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Descarga_de_Archivo element attributes
            string userChangeJson = jsSerialize.Serialize(Descarga_de_ArchivoModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDescarga_de_ArchivoScript.IndexOf("inpuElementArray");
            string splittedString = strDescarga_de_ArchivoScript.Substring(indexOfArray, strDescarga_de_ArchivoScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Descarga_de_ArchivoModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Descarga_de_ArchivoModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDescarga_de_ArchivoScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strDescarga_de_ArchivoScript.Substring(indexOfArrayHistory, strDescarga_de_ArchivoScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strDescarga_de_ArchivoScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDescarga_de_ArchivoScript.Substring(endIndexOfMainElement + indexOfArray, strDescarga_de_ArchivoScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Descarga_de_ArchivoModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Descarga_de_ArchivoModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Descarga_de_Archivo.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Descarga_de_Archivo.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Descarga_de_Archivo.js")))
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
        public ActionResult Descarga_de_ArchivoPropertyBag()
        {
            return PartialView("Descarga_de_ArchivoPropertyBag", "Descarga_de_Archivo");
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
        public ActionResult AddDetalle_de_Descarga_de_Archivo(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_Descarga_de_Archivo/AddDetalle_de_Descarga_de_Archivo");
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
                var whereClauseFormat = "Object = 45113 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IDescarga_de_ArchivoApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Descarga_de_Archivo.Clave= " + RecordId;
                            var result = _IDescarga_de_ArchivoApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IDescarga_de_ArchivoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Descarga_de_ArchivoPropertyMapper());
			
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
                    (Descarga_de_ArchivoAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Descarga_de_ArchivoPropertyMapper oDescarga_de_ArchivoPropertyMapper = new Descarga_de_ArchivoPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oDescarga_de_ArchivoPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDescarga_de_ArchivoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Descarga_de_Archivos == null)
                result.Descarga_de_Archivos = new List<Descarga_de_Archivo>();

            var data = result.Descarga_de_Archivos.Select(m => new Descarga_de_ArchivoGridModel
            {
                Clave = m.Clave
			,Nombre = m.Nombre

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45113, arrayColumnsVisible), "Descarga_de_ArchivoList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45113, arrayColumnsVisible), "Descarga_de_ArchivoList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45113, arrayColumnsVisible), "Descarga_de_ArchivoList_" + DateTime.Now.ToString());
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

            _IDescarga_de_ArchivoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Descarga_de_ArchivoPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Descarga_de_ArchivoAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Descarga_de_ArchivoPropertyMapper oDescarga_de_ArchivoPropertyMapper = new Descarga_de_ArchivoPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oDescarga_de_ArchivoPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDescarga_de_ArchivoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Descarga_de_Archivos == null)
                result.Descarga_de_Archivos = new List<Descarga_de_Archivo>();

            var data = result.Descarga_de_Archivos.Select(m => new Descarga_de_ArchivoGridModel
            {
                Clave = m.Clave
			,Nombre = m.Nombre

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
                _IDescarga_de_ArchivoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDescarga_de_ArchivoApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Descarga_de_Archivo_Datos_GeneralesModel varDescarga_de_Archivo)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDescarga_de_ArchivoApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Descarga_de_Archivo_Datos_GeneralesInfo = new Descarga_de_Archivo_Datos_Generales
                {
                    Clave = varDescarga_de_Archivo.Clave
                                            ,Nombre = varDescarga_de_Archivo.Nombre
                    
                };

                result = _IDescarga_de_ArchivoApiConsumer.Update_Datos_Generales(Descarga_de_Archivo_Datos_GeneralesInfo).Resource.ToString();
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
                _IDescarga_de_ArchivoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IDescarga_de_ArchivoApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_de_Descarga_de_Archivo;
                var Detalle_de_Descarga_de_ArchivoData = GetDetalle_de_Descarga_de_ArchivoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Descarga_de_Archivo);

                var result = new Descarga_de_Archivo_Datos_GeneralesModel
                {
                    Clave = m.Clave
			,Nombre = m.Nombre

                    
                };
				var resultData = new
                {
                    data = result
                    ,Documentos = Detalle_de_Descarga_de_ArchivoData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }


    }
}

