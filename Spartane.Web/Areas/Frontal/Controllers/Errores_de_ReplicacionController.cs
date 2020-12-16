using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Errores_de_Replicacion;
using Spartane.Core.Domain.Spartan_User;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Errores_de_Replicacion;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Errores_de_Replicacion;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;

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
    public class Errores_de_ReplicacionController : Controller
    {
        #region "variable declaration"

        private IErrores_de_ReplicacionService service = null;
        private IErrores_de_ReplicacionApiConsumer _IErrores_de_ReplicacionApiConsumer;
        private ISpartan_UserApiConsumer _ISpartan_UserApiConsumer;

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

        
        public Errores_de_ReplicacionController(IErrores_de_ReplicacionService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IErrores_de_ReplicacionApiConsumer Errores_de_ReplicacionApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , ISpartan_UserApiConsumer Spartan_UserApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IErrores_de_ReplicacionApiConsumer = Errores_de_ReplicacionApiConsumer;
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

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Errores_de_Replicacion
        [ObjectAuth(ObjectId = (ModuleObjectId)45235, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45235, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Errores_de_Replicacion/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45235, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45235, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varErrores_de_Replicacion = new Errores_de_ReplicacionModel();
			varErrores_de_Replicacion.Clave = Id;
			
            ViewBag.ObjectId = "45235";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IErrores_de_ReplicacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Errores_de_ReplicacionsData = _IErrores_de_ReplicacionApiConsumer.ListaSelAll(0, 1000, "Errores_de_Replicacion.Clave=" + Id, "").Resource.Errores_de_Replicacions;
				
				if (Errores_de_ReplicacionsData != null && Errores_de_ReplicacionsData.Count > 0)
                {
					var Errores_de_ReplicacionData = Errores_de_ReplicacionsData.First();
					varErrores_de_Replicacion= new Errores_de_ReplicacionModel
					{
						Clave  = Errores_de_ReplicacionData.Clave 
	                    ,ID_del_Dispositivo = Errores_de_ReplicacionData.ID_del_Dispositivo
                    ,Usuario = Errores_de_ReplicacionData.Usuario
                    ,UsuarioName = CultureHelper.GetTraduction(Convert.ToString(Errores_de_ReplicacionData.Usuario), "Spartan_User") ??  (string)Errores_de_ReplicacionData.Usuario_Spartan_User.Name
                    ,Fecha_del_Error = (Errores_de_ReplicacionData.Fecha_del_Error == null ? string.Empty : Convert.ToDateTime(Errores_de_ReplicacionData.Fecha_del_Error).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_del_Error = Errores_de_ReplicacionData.Hora_del_Error
                    ,Campo_con_Error = Errores_de_ReplicacionData.Campo_con_Error
                    ,Valor_del_Campo_en_Dispositivo = Errores_de_ReplicacionData.Valor_del_Campo_en_Dispositivo
                    ,Valor_del_Campo_en_Web = Errores_de_ReplicacionData.Valor_del_Campo_en_Web
                    ,Folio = Errores_de_ReplicacionData.Folio

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Usuario = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Usuario != null && Spartan_Users_Usuario.Resource != null)
                ViewBag.Spartan_Users_Usuario = Spartan_Users_Usuario.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
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

				
            return View(varErrores_de_Replicacion);
        }
		
	[HttpGet]
        public ActionResult AddErrores_de_Replicacion(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45235);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IErrores_de_ReplicacionApiConsumer.SetAuthHeader(_tokenManager.Token);
			Errores_de_ReplicacionModel varErrores_de_Replicacion= new Errores_de_ReplicacionModel();


            if (id.ToString() != "0")
            {
                var Errores_de_ReplicacionsData = _IErrores_de_ReplicacionApiConsumer.ListaSelAll(0, 1000, "Errores_de_Replicacion.Clave=" + id, "").Resource.Errores_de_Replicacions;
				
				if (Errores_de_ReplicacionsData != null && Errores_de_ReplicacionsData.Count > 0)
                {
					var Errores_de_ReplicacionData = Errores_de_ReplicacionsData.First();
					varErrores_de_Replicacion= new Errores_de_ReplicacionModel
					{
						Clave  = Errores_de_ReplicacionData.Clave 
	                    ,ID_del_Dispositivo = Errores_de_ReplicacionData.ID_del_Dispositivo
                    ,Usuario = Errores_de_ReplicacionData.Usuario
                    ,UsuarioName = CultureHelper.GetTraduction(Convert.ToString(Errores_de_ReplicacionData.Usuario), "Spartan_User") ??  (string)Errores_de_ReplicacionData.Usuario_Spartan_User.Name
                    ,Fecha_del_Error = (Errores_de_ReplicacionData.Fecha_del_Error == null ? string.Empty : Convert.ToDateTime(Errores_de_ReplicacionData.Fecha_del_Error).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_del_Error = Errores_de_ReplicacionData.Hora_del_Error
                    ,Campo_con_Error = Errores_de_ReplicacionData.Campo_con_Error
                    ,Valor_del_Campo_en_Dispositivo = Errores_de_ReplicacionData.Valor_del_Campo_en_Dispositivo
                    ,Valor_del_Campo_en_Web = Errores_de_ReplicacionData.Valor_del_Campo_en_Web
                    ,Folio = Errores_de_ReplicacionData.Folio

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Usuario = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Usuario != null && Spartan_Users_Usuario.Resource != null)
                ViewBag.Spartan_Users_Usuario = Spartan_Users_Usuario.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();


            return PartialView("AddErrores_de_Replicacion", varErrores_de_Replicacion);
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



        [HttpPost]
        public JsonResult ClearAdvanceFilter()
        {
            Session["AdvanceSearch"] = null;
            return Json(new { result = Session["AdvanceSearch"] == null }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult ShowAdvanceFilter(Errores_de_ReplicacionAdvanceSearchModel model, int idFilter = -1)
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

            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Usuario = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Usuario != null && Spartan_Users_Usuario.Resource != null)
                ViewBag.Spartan_Users_Usuario = Spartan_Users_Usuario.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Usuario = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Usuario != null && Spartan_Users_Usuario.Resource != null)
                ViewBag.Spartan_Users_Usuario = Spartan_Users_Usuario.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();


            var previousFiltersObj = new Errores_de_ReplicacionAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Errores_de_ReplicacionAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Errores_de_ReplicacionAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Errores_de_ReplicacionPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IErrores_de_ReplicacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Errores_de_Replicacions == null)
                result.Errores_de_Replicacions = new List<Errores_de_Replicacion>();

            return Json(new
            {
                data = result.Errores_de_Replicacions.Select(m => new Errores_de_ReplicacionGridModel
                    {
                    Clave = m.Clave
			,ID_del_Dispositivo = m.ID_del_Dispositivo
                        ,UsuarioName = CultureHelper.GetTraduction(m.Usuario_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Usuario_Spartan_User.Name
                        ,Fecha_del_Error = (m.Fecha_del_Error == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Error).ToString(ConfigurationProperty.DateFormat))
			,Hora_del_Error = m.Hora_del_Error
			,Campo_con_Error = m.Campo_con_Error
			,Valor_del_Campo_en_Dispositivo = m.Valor_del_Campo_en_Dispositivo
			,Valor_del_Campo_en_Web = m.Valor_del_Campo_en_Web
			,Folio = m.Folio

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetErrores_de_ReplicacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IErrores_de_ReplicacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IErrores_de_ReplicacionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Errores_de_Replicacion", m.),
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
        /// Get List of Errores_de_Replicacion from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Errores_de_Replicacion Entity</returns>
        public ActionResult GetErrores_de_ReplicacionList(UrlParametersModel param)
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
            _IErrores_de_ReplicacionApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Errores_de_ReplicacionPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Errores_de_ReplicacionAdvanceSearchModel))
                {
					var advanceFilter =
                    (Errores_de_ReplicacionAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Errores_de_ReplicacionPropertyMapper oErrores_de_ReplicacionPropertyMapper = new Errores_de_ReplicacionPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oErrores_de_ReplicacionPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IErrores_de_ReplicacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Errores_de_Replicacions == null)
                result.Errores_de_Replicacions = new List<Errores_de_Replicacion>();

            return Json(new
            {
                aaData = result.Errores_de_Replicacions.Select(m => new Errores_de_ReplicacionGridModel
            {
                    Clave = m.Clave
			,ID_del_Dispositivo = m.ID_del_Dispositivo
                        ,UsuarioName = CultureHelper.GetTraduction(m.Usuario_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Usuario_Spartan_User.Name
                        ,Fecha_del_Error = (m.Fecha_del_Error == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Error).ToString(ConfigurationProperty.DateFormat))
			,Hora_del_Error = m.Hora_del_Error
			,Campo_con_Error = m.Campo_con_Error
			,Valor_del_Campo_en_Dispositivo = m.Valor_del_Campo_en_Dispositivo
			,Valor_del_Campo_en_Web = m.Valor_del_Campo_en_Web
			,Folio = m.Folio

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }







        [NonAction]
        public string GetAdvanceFilter(Errores_de_ReplicacionAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Errores_de_Replicacion.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Errores_de_Replicacion.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.ID_del_Dispositivo))
            {
                switch (filter.ID_del_DispositivoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Errores_de_Replicacion.ID_del_Dispositivo LIKE '" + filter.ID_del_Dispositivo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Errores_de_Replicacion.ID_del_Dispositivo LIKE '%" + filter.ID_del_Dispositivo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Errores_de_Replicacion.ID_del_Dispositivo = '" + filter.ID_del_Dispositivo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Errores_de_Replicacion.ID_del_Dispositivo LIKE '%" + filter.ID_del_Dispositivo + "%'";
                        break;
                }
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

                where += " AND Errores_de_Replicacion.Usuario In (" + UsuarioIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_del_Error) || !string.IsNullOrEmpty(filter.ToFecha_del_Error))
            {
                var Fecha_del_ErrorFrom = DateTime.ParseExact(filter.FromFecha_del_Error, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_del_ErrorTo = DateTime.ParseExact(filter.ToFecha_del_Error, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_del_Error))
                    where += " AND Errores_de_Replicacion.Fecha_del_Error >= '" + Fecha_del_ErrorFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_del_Error))
                    where += " AND Errores_de_Replicacion.Fecha_del_Error <= '" + Fecha_del_ErrorTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_del_Error) || !string.IsNullOrEmpty(filter.ToHora_del_Error))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_del_Error))
                    where += " AND Convert(TIME,Errores_de_Replicacion.Hora_del_Error) >='" + filter.FromHora_del_Error + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_del_Error))
                    where += " AND Convert(TIME,Errores_de_Replicacion.Hora_del_Error) <='" + filter.ToHora_del_Error + "'";
            }

            if (!string.IsNullOrEmpty(filter.Campo_con_Error))
            {
                switch (filter.Campo_con_ErrorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Errores_de_Replicacion.Campo_con_Error LIKE '" + filter.Campo_con_Error + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Errores_de_Replicacion.Campo_con_Error LIKE '%" + filter.Campo_con_Error + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Errores_de_Replicacion.Campo_con_Error = '" + filter.Campo_con_Error + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Errores_de_Replicacion.Campo_con_Error LIKE '%" + filter.Campo_con_Error + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Valor_del_Campo_en_Dispositivo))
            {
                switch (filter.Valor_del_Campo_en_DispositivoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Errores_de_Replicacion.Valor_del_Campo_en_Dispositivo LIKE '" + filter.Valor_del_Campo_en_Dispositivo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Errores_de_Replicacion.Valor_del_Campo_en_Dispositivo LIKE '%" + filter.Valor_del_Campo_en_Dispositivo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Errores_de_Replicacion.Valor_del_Campo_en_Dispositivo = '" + filter.Valor_del_Campo_en_Dispositivo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Errores_de_Replicacion.Valor_del_Campo_en_Dispositivo LIKE '%" + filter.Valor_del_Campo_en_Dispositivo + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Valor_del_Campo_en_Web))
            {
                switch (filter.Valor_del_Campo_en_WebFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Errores_de_Replicacion.Valor_del_Campo_en_Web LIKE '" + filter.Valor_del_Campo_en_Web + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Errores_de_Replicacion.Valor_del_Campo_en_Web LIKE '%" + filter.Valor_del_Campo_en_Web + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Errores_de_Replicacion.Valor_del_Campo_en_Web = '" + filter.Valor_del_Campo_en_Web + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Errores_de_Replicacion.Valor_del_Campo_en_Web LIKE '%" + filter.Valor_del_Campo_en_Web + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFolio) || !string.IsNullOrEmpty(filter.ToFolio))
            {
                if (!string.IsNullOrEmpty(filter.FromFolio))
                    where += " AND Errores_de_Replicacion.Folio >= " + filter.FromFolio;
                if (!string.IsNullOrEmpty(filter.ToFolio))
                    where += " AND Errores_de_Replicacion.Folio <= " + filter.ToFolio;
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
                _IErrores_de_ReplicacionApiConsumer.SetAuthHeader(_tokenManager.Token);

                Errores_de_Replicacion varErrores_de_Replicacion = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IErrores_de_ReplicacionApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Errores_de_ReplicacionModel varErrores_de_Replicacion)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IErrores_de_ReplicacionApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Errores_de_ReplicacionInfo = new Errores_de_Replicacion
                    {
                        Clave = varErrores_de_Replicacion.Clave
                        ,ID_del_Dispositivo = varErrores_de_Replicacion.ID_del_Dispositivo
                        ,Usuario = varErrores_de_Replicacion.Usuario
                        ,Fecha_del_Error = (!String.IsNullOrEmpty(varErrores_de_Replicacion.Fecha_del_Error)) ? DateTime.ParseExact(varErrores_de_Replicacion.Fecha_del_Error, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_del_Error = varErrores_de_Replicacion.Hora_del_Error
                        ,Campo_con_Error = varErrores_de_Replicacion.Campo_con_Error
                        ,Valor_del_Campo_en_Dispositivo = varErrores_de_Replicacion.Valor_del_Campo_en_Dispositivo
                        ,Valor_del_Campo_en_Web = varErrores_de_Replicacion.Valor_del_Campo_en_Web
                        ,Folio = varErrores_de_Replicacion.Folio

                    };

                    result = !IsNew ?
                        _IErrores_de_ReplicacionApiConsumer.Update(Errores_de_ReplicacionInfo, null, null).Resource.ToString() :
                         _IErrores_de_ReplicacionApiConsumer.Insert(Errores_de_ReplicacionInfo, null, null).Resource.ToString();
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
        /// Write Element Array of Errores_de_Replicacion script
        /// </summary>
        /// <param name="oErrores_de_ReplicacionElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Errores_de_ReplicacionModuleAttributeList)
        {
            for (int i = 0; i < Errores_de_ReplicacionModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Errores_de_ReplicacionModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Errores_de_ReplicacionModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Errores_de_ReplicacionModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Errores_de_ReplicacionModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Errores_de_ReplicacionModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Errores_de_ReplicacionModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Errores_de_ReplicacionModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Errores_de_ReplicacionModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Errores_de_ReplicacionModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Errores_de_ReplicacionModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Errores_de_ReplicacionModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strErrores_de_ReplicacionScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Errores_de_Replicacion.js")))
            {
                strErrores_de_ReplicacionScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Errores_de_Replicacion element attributes
            string userChangeJson = jsSerialize.Serialize(Errores_de_ReplicacionModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strErrores_de_ReplicacionScript.IndexOf("inpuElementArray");
            string splittedString = strErrores_de_ReplicacionScript.Substring(indexOfArray, strErrores_de_ReplicacionScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Errores_de_ReplicacionModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Errores_de_ReplicacionModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strErrores_de_ReplicacionScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strErrores_de_ReplicacionScript.Substring(indexOfArrayHistory, strErrores_de_ReplicacionScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strErrores_de_ReplicacionScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strErrores_de_ReplicacionScript.Substring(endIndexOfMainElement + indexOfArray, strErrores_de_ReplicacionScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Errores_de_ReplicacionModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Errores_de_ReplicacionModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Errores_de_Replicacion.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Errores_de_Replicacion.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Errores_de_Replicacion.js")))
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
        public ActionResult Errores_de_ReplicacionPropertyBag()
        {
            return PartialView("Errores_de_ReplicacionPropertyBag", "Errores_de_Replicacion");
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
                var whereClauseFormat = "Object = 45235 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IErrores_de_ReplicacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Errores_de_Replicacion.Clave= " + RecordId;
                            var result = _IErrores_de_ReplicacionApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IErrores_de_ReplicacionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Errores_de_ReplicacionPropertyMapper());
			
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
                    (Errores_de_ReplicacionAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Errores_de_ReplicacionPropertyMapper oErrores_de_ReplicacionPropertyMapper = new Errores_de_ReplicacionPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oErrores_de_ReplicacionPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IErrores_de_ReplicacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Errores_de_Replicacions == null)
                result.Errores_de_Replicacions = new List<Errores_de_Replicacion>();

            var data = result.Errores_de_Replicacions.Select(m => new Errores_de_ReplicacionGridModel
            {
                Clave = m.Clave
			,ID_del_Dispositivo = m.ID_del_Dispositivo
                        ,UsuarioName = CultureHelper.GetTraduction(m.Usuario_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Usuario_Spartan_User.Name
                        ,Fecha_del_Error = (m.Fecha_del_Error == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Error).ToString(ConfigurationProperty.DateFormat))
			,Hora_del_Error = m.Hora_del_Error
			,Campo_con_Error = m.Campo_con_Error
			,Valor_del_Campo_en_Dispositivo = m.Valor_del_Campo_en_Dispositivo
			,Valor_del_Campo_en_Web = m.Valor_del_Campo_en_Web
			,Folio = m.Folio

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45235, arrayColumnsVisible), "Errores_de_ReplicacionList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45235, arrayColumnsVisible), "Errores_de_ReplicacionList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45235, arrayColumnsVisible), "Errores_de_ReplicacionList_" + DateTime.Now.ToString());
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

            _IErrores_de_ReplicacionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Errores_de_ReplicacionPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Errores_de_ReplicacionAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Errores_de_ReplicacionPropertyMapper oErrores_de_ReplicacionPropertyMapper = new Errores_de_ReplicacionPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oErrores_de_ReplicacionPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IErrores_de_ReplicacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Errores_de_Replicacions == null)
                result.Errores_de_Replicacions = new List<Errores_de_Replicacion>();

            var data = result.Errores_de_Replicacions.Select(m => new Errores_de_ReplicacionGridModel
            {
                Clave = m.Clave
			,ID_del_Dispositivo = m.ID_del_Dispositivo
                        ,UsuarioName = CultureHelper.GetTraduction(m.Usuario_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Usuario_Spartan_User.Name
                        ,Fecha_del_Error = (m.Fecha_del_Error == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Error).ToString(ConfigurationProperty.DateFormat))
			,Hora_del_Error = m.Hora_del_Error
			,Campo_con_Error = m.Campo_con_Error
			,Valor_del_Campo_en_Dispositivo = m.Valor_del_Campo_en_Dispositivo
			,Valor_del_Campo_en_Web = m.Valor_del_Campo_en_Web
			,Folio = m.Folio

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
                _IErrores_de_ReplicacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IErrores_de_ReplicacionApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Errores_de_Replicacion_Datos_GeneralesModel varErrores_de_Replicacion)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IErrores_de_ReplicacionApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Errores_de_Replicacion_Datos_GeneralesInfo = new Errores_de_Replicacion_Datos_Generales
                {
                    Clave = varErrores_de_Replicacion.Clave
                                            ,ID_del_Dispositivo = varErrores_de_Replicacion.ID_del_Dispositivo
                        ,Usuario = varErrores_de_Replicacion.Usuario
                        ,Fecha_del_Error = (!String.IsNullOrEmpty(varErrores_de_Replicacion.Fecha_del_Error)) ? DateTime.ParseExact(varErrores_de_Replicacion.Fecha_del_Error, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_del_Error = varErrores_de_Replicacion.Hora_del_Error
                        ,Campo_con_Error = varErrores_de_Replicacion.Campo_con_Error
                        ,Valor_del_Campo_en_Dispositivo = varErrores_de_Replicacion.Valor_del_Campo_en_Dispositivo
                        ,Valor_del_Campo_en_Web = varErrores_de_Replicacion.Valor_del_Campo_en_Web
                        ,Folio = varErrores_de_Replicacion.Folio
                    
                };

                result = _IErrores_de_ReplicacionApiConsumer.Update_Datos_Generales(Errores_de_Replicacion_Datos_GeneralesInfo).Resource.ToString();
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
                _IErrores_de_ReplicacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IErrores_de_ReplicacionApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Errores_de_Replicacion_Datos_GeneralesModel
                {
                    Clave = m.Clave
			,ID_del_Dispositivo = m.ID_del_Dispositivo
                        ,Usuario = m.Usuario
                        ,UsuarioName = CultureHelper.GetTraduction(m.Usuario_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Usuario_Spartan_User.Name
                        ,Fecha_del_Error = (m.Fecha_del_Error == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Error).ToString(ConfigurationProperty.DateFormat))
			,Hora_del_Error = m.Hora_del_Error
			,Campo_con_Error = m.Campo_con_Error
			,Valor_del_Campo_en_Dispositivo = m.Valor_del_Campo_en_Dispositivo
			,Valor_del_Campo_en_Web = m.Valor_del_Campo_en_Web
			,Folio = m.Folio

                    
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

