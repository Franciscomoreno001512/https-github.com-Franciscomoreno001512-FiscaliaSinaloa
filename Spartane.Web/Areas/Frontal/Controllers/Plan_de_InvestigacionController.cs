using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Plan_de_Investigacion;
using Spartane.Core.Domain.expediente_ministerio_publico;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Detalle_Plan_Actos_de_Investigacion;

using Spartane.Core.Domain.Categoria_de_Servicio_de_Apoyo;
using Spartane.Core.Domain.Tipo_de_Servicio_de_Apoyo;







using Spartane.Core.Domain.Spartan_User;


using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Plan_de_Investigacion;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Plan_de_Investigacion;
using Spartane.Web.Areas.WebApiConsumer.expediente_ministerio_publico;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Plan_Actos_de_Investigacion;

using Spartane.Web.Areas.WebApiConsumer.Categoria_de_Servicio_de_Apoyo;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Servicio_de_Apoyo;



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
    public class Plan_de_InvestigacionController : Controller
    {
        #region "variable declaration"

        private IPlan_de_InvestigacionService service = null;
        private IPlan_de_InvestigacionApiConsumer _IPlan_de_InvestigacionApiConsumer;
        private Iexpediente_ministerio_publicoApiConsumer _Iexpediente_ministerio_publicoApiConsumer;
        private ISpartan_UserApiConsumer _ISpartan_UserApiConsumer;
        private IDetalle_Plan_Actos_de_InvestigacionApiConsumer _IDetalle_Plan_Actos_de_InvestigacionApiConsumer;

        private ICategoria_de_Servicio_de_ApoyoApiConsumer _ICategoria_de_Servicio_de_ApoyoApiConsumer;
        private ITipo_de_Servicio_de_ApoyoApiConsumer _ITipo_de_Servicio_de_ApoyoApiConsumer;





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

        
        public Plan_de_InvestigacionController(IPlan_de_InvestigacionService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IPlan_de_InvestigacionApiConsumer Plan_de_InvestigacionApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , Iexpediente_ministerio_publicoApiConsumer expediente_ministerio_publicoApiConsumer , ISpartan_UserApiConsumer Spartan_UserApiConsumer , IDetalle_Plan_Actos_de_InvestigacionApiConsumer Detalle_Plan_Actos_de_InvestigacionApiConsumer , ICategoria_de_Servicio_de_ApoyoApiConsumer Categoria_de_Servicio_de_ApoyoApiConsumer , ITipo_de_Servicio_de_ApoyoApiConsumer Tipo_de_Servicio_de_ApoyoApiConsumer  )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IPlan_de_InvestigacionApiConsumer = Plan_de_InvestigacionApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_FormatApiConsumer = Spartan_FormatApiConsumer;
            this._ISpartan_Format_PermissionsApiConsumer = Spartan_Format_PermissionsApiConsumer;
            this._IGeneratePDFApiConsumer = GeneratePDFApiConsumer;
			this._ISpartan_FormatRelatedApiConsumer = Spartan_Format_RelatedApiConsumer;
            this._Iexpediente_ministerio_publicoApiConsumer = expediente_ministerio_publicoApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._IDetalle_Plan_Actos_de_InvestigacionApiConsumer = Detalle_Plan_Actos_de_InvestigacionApiConsumer;

            this._ICategoria_de_Servicio_de_ApoyoApiConsumer = Categoria_de_Servicio_de_ApoyoApiConsumer;
            this._ITipo_de_Servicio_de_ApoyoApiConsumer = Tipo_de_Servicio_de_ApoyoApiConsumer;



            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;


        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Plan_de_Investigacion
        [ObjectAuth(ObjectId = (ModuleObjectId)45478, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45478, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Plan_de_Investigacion/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45478, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45478, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varPlan_de_Investigacion = new Plan_de_InvestigacionModel();
			varPlan_de_Investigacion.Clave = Id;
			
            ViewBag.ObjectId = "45478";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;

            var permissionDetalle_Plan_Actos_de_Investigacion = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45479, ModuleId);
            ViewBag.PermissionDetalle_Plan_Actos_de_Investigacion = permissionDetalle_Plan_Actos_de_Investigacion;


            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IPlan_de_InvestigacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Plan_de_InvestigacionsData = _IPlan_de_InvestigacionApiConsumer.ListaSelAll(0, 1000, "Plan_de_Investigacion.Clave=" + Id, "").Resource.Plan_de_Investigacions;
				
				if (Plan_de_InvestigacionsData != null && Plan_de_InvestigacionsData.Count > 0)
                {
					var Plan_de_InvestigacionData = Plan_de_InvestigacionsData.First();
					varPlan_de_Investigacion= new Plan_de_InvestigacionModel
					{
						Clave  = Plan_de_InvestigacionData.Clave 
	                    ,Expediente_MP = Plan_de_InvestigacionData.Expediente_MP
                    ,Expediente_MPnic = CultureHelper.GetTraduction(Convert.ToString(Plan_de_InvestigacionData.Expediente_MP), "expediente_ministerio_publico") ??  (string)Plan_de_InvestigacionData.Expediente_MP_expediente_ministerio_publico.nic
                    ,Fecha_de_Registro = (Plan_de_InvestigacionData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(Plan_de_InvestigacionData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Registro = Plan_de_InvestigacionData.Hora_de_Registro
                    ,Usuario_que_Registra = Plan_de_InvestigacionData.Usuario_que_Registra
                    ,Usuario_que_RegistraName = CultureHelper.GetTraduction(Convert.ToString(Plan_de_InvestigacionData.Usuario_que_Registra), "Spartan_User") ??  (string)Plan_de_InvestigacionData.Usuario_que_Registra_Spartan_User.Name
                    ,Fecha_Reunion_Mando_Ministerial = (Plan_de_InvestigacionData.Fecha_Reunion_Mando_Ministerial == null ? string.Empty : Convert.ToDateTime(Plan_de_InvestigacionData.Fecha_Reunion_Mando_Ministerial).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_Reunion_Mando_Ministerial = Plan_de_InvestigacionData.Hora_Reunion_Mando_Ministerial
                    ,Asistentes = Plan_de_InvestigacionData.Asistentes
                    ,Acuerdos = Plan_de_InvestigacionData.Acuerdos

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

				
            return View(varPlan_de_Investigacion);
        }
		
	[HttpGet]
        public ActionResult AddPlan_de_Investigacion(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45478);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IPlan_de_InvestigacionApiConsumer.SetAuthHeader(_tokenManager.Token);
			Plan_de_InvestigacionModel varPlan_de_Investigacion= new Plan_de_InvestigacionModel();
            var permissionDetalle_Plan_Actos_de_Investigacion = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45479, ModuleId);
            ViewBag.PermissionDetalle_Plan_Actos_de_Investigacion = permissionDetalle_Plan_Actos_de_Investigacion;


            if (id.ToString() != "0")
            {
                var Plan_de_InvestigacionsData = _IPlan_de_InvestigacionApiConsumer.ListaSelAll(0, 1000, "Plan_de_Investigacion.Clave=" + id, "").Resource.Plan_de_Investigacions;
				
				if (Plan_de_InvestigacionsData != null && Plan_de_InvestigacionsData.Count > 0)
                {
					var Plan_de_InvestigacionData = Plan_de_InvestigacionsData.First();
					varPlan_de_Investigacion= new Plan_de_InvestigacionModel
					{
						Clave  = Plan_de_InvestigacionData.Clave 
	                    ,Expediente_MP = Plan_de_InvestigacionData.Expediente_MP
                    ,Expediente_MPnic = CultureHelper.GetTraduction(Convert.ToString(Plan_de_InvestigacionData.Expediente_MP), "expediente_ministerio_publico") ??  (string)Plan_de_InvestigacionData.Expediente_MP_expediente_ministerio_publico.nic
                    ,Fecha_de_Registro = (Plan_de_InvestigacionData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(Plan_de_InvestigacionData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Registro = Plan_de_InvestigacionData.Hora_de_Registro
                    ,Usuario_que_Registra = Plan_de_InvestigacionData.Usuario_que_Registra
                    ,Usuario_que_RegistraName = CultureHelper.GetTraduction(Convert.ToString(Plan_de_InvestigacionData.Usuario_que_Registra), "Spartan_User") ??  (string)Plan_de_InvestigacionData.Usuario_que_Registra_Spartan_User.Name
                    ,Fecha_Reunion_Mando_Ministerial = (Plan_de_InvestigacionData.Fecha_Reunion_Mando_Ministerial == null ? string.Empty : Convert.ToDateTime(Plan_de_InvestigacionData.Fecha_Reunion_Mando_Ministerial).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_Reunion_Mando_Ministerial = Plan_de_InvestigacionData.Hora_Reunion_Mando_Ministerial
                    ,Asistentes = Plan_de_InvestigacionData.Asistentes
                    ,Acuerdos = Plan_de_InvestigacionData.Acuerdos

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);



            return PartialView("AddPlan_de_Investigacion", varPlan_de_Investigacion);
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
        public ActionResult Getexpediente_ministerio_publicoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _Iexpediente_ministerio_publicoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _Iexpediente_ministerio_publicoApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.nic).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.clave), "expediente_ministerio_publico", "nic")?? m.nic,
                    Value = Convert.ToString(m.clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
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
        public ActionResult ShowAdvanceFilter(Plan_de_InvestigacionAdvanceSearchModel model, int idFilter = -1)
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



            var previousFiltersObj = new Plan_de_InvestigacionAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Plan_de_InvestigacionAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Plan_de_InvestigacionAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Plan_de_InvestigacionPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IPlan_de_InvestigacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Plan_de_Investigacions == null)
                result.Plan_de_Investigacions = new List<Plan_de_Investigacion>();

            return Json(new
            {
                data = result.Plan_de_Investigacions.Select(m => new Plan_de_InvestigacionGridModel
                    {
                    Clave = m.Clave
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,Fecha_Reunion_Mando_Ministerial = (m.Fecha_Reunion_Mando_Ministerial == null ? string.Empty : Convert.ToDateTime(m.Fecha_Reunion_Mando_Ministerial).ToString(ConfigurationProperty.DateFormat))
			,Hora_Reunion_Mando_Ministerial = m.Hora_Reunion_Mando_Ministerial
			,Asistentes = m.Asistentes
			,Acuerdos = m.Acuerdos

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetPlan_de_InvestigacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IPlan_de_InvestigacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IPlan_de_InvestigacionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Plan_de_Investigacion", m.),
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
        /// Get List of Plan_de_Investigacion from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Plan_de_Investigacion Entity</returns>
        public ActionResult GetPlan_de_InvestigacionList(UrlParametersModel param)
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
            _IPlan_de_InvestigacionApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Plan_de_InvestigacionPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Plan_de_InvestigacionAdvanceSearchModel))
                {
					var advanceFilter =
                    (Plan_de_InvestigacionAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Plan_de_InvestigacionPropertyMapper oPlan_de_InvestigacionPropertyMapper = new Plan_de_InvestigacionPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oPlan_de_InvestigacionPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IPlan_de_InvestigacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Plan_de_Investigacions == null)
                result.Plan_de_Investigacions = new List<Plan_de_Investigacion>();

            return Json(new
            {
                aaData = result.Plan_de_Investigacions.Select(m => new Plan_de_InvestigacionGridModel
            {
                    Clave = m.Clave
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,Fecha_Reunion_Mando_Ministerial = (m.Fecha_Reunion_Mando_Ministerial == null ? string.Empty : Convert.ToDateTime(m.Fecha_Reunion_Mando_Ministerial).ToString(ConfigurationProperty.DateFormat))
			,Hora_Reunion_Mando_Ministerial = m.Hora_Reunion_Mando_Ministerial
			,Asistentes = m.Asistentes
			,Acuerdos = m.Acuerdos

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetPlan_de_Investigacion_Expediente_MP_expediente_ministerio_publico(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _Iexpediente_ministerio_publicoApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(expediente_ministerio_publico.clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(expediente_ministerio_publico.nic as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _Iexpediente_ministerio_publicoApiConsumer.ListaSelAll(1, 20,elWhere , " expediente_ministerio_publico.nic ASC ").Resource;
               
                foreach (var item in result.expediente_ministerio_publicos)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.clave), "expediente_ministerio_publico", "nic");
                    item.nic =trans ??item.nic;
                }
                return Json(result.expediente_ministerio_publicos.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetPlan_de_Investigacion_Usuario_que_Registra_Spartan_User(string query, string where)
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
        [HttpGet]
        public JsonResult GetDetalle_Plan_Actos_de_Investigacion_Usuario_que_Contesta_Spartan_User(string query, string where)
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






        [NonAction]
        public string GetAdvanceFilter(Plan_de_InvestigacionAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Plan_de_Investigacion.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Plan_de_Investigacion.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceExpediente_MP))
            {
                switch (filter.Expediente_MPFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND expediente_ministerio_publico.nic LIKE '" + filter.AdvanceExpediente_MP + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND expediente_ministerio_publico.nic LIKE '%" + filter.AdvanceExpediente_MP + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND expediente_ministerio_publico.nic = '" + filter.AdvanceExpediente_MP + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND expediente_ministerio_publico.nic LIKE '%" + filter.AdvanceExpediente_MP + "%'";
                        break;
                }
            }
            else if (filter.AdvanceExpediente_MPMultiple != null && filter.AdvanceExpediente_MPMultiple.Count() > 0)
            {
                var Expediente_MPIds = string.Join(",", filter.AdvanceExpediente_MPMultiple);

                where += " AND Plan_de_Investigacion.Expediente_MP In (" + Expediente_MPIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro) || !string.IsNullOrEmpty(filter.ToFecha_de_Registro))
            {
                var Fecha_de_RegistroFrom = DateTime.ParseExact(filter.FromFecha_de_Registro, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_RegistroTo = DateTime.ParseExact(filter.ToFecha_de_Registro, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro))
                    where += " AND Plan_de_Investigacion.Fecha_de_Registro >= '" + Fecha_de_RegistroFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Registro))
                    where += " AND Plan_de_Investigacion.Fecha_de_Registro <= '" + Fecha_de_RegistroTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Registro) || !string.IsNullOrEmpty(filter.ToHora_de_Registro))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Registro))
                    where += " AND Convert(TIME,Plan_de_Investigacion.Hora_de_Registro) >='" + filter.FromHora_de_Registro + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Registro))
                    where += " AND Convert(TIME,Plan_de_Investigacion.Hora_de_Registro) <='" + filter.ToHora_de_Registro + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceUsuario_que_Registra))
            {
                switch (filter.Usuario_que_RegistraFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_User.Name LIKE '" + filter.AdvanceUsuario_que_Registra + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceUsuario_que_Registra + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_User.Name = '" + filter.AdvanceUsuario_que_Registra + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceUsuario_que_Registra + "%'";
                        break;
                }
            }
            else if (filter.AdvanceUsuario_que_RegistraMultiple != null && filter.AdvanceUsuario_que_RegistraMultiple.Count() > 0)
            {
                var Usuario_que_RegistraIds = string.Join(",", filter.AdvanceUsuario_que_RegistraMultiple);

                where += " AND Plan_de_Investigacion.Usuario_que_Registra In (" + Usuario_que_RegistraIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_Reunion_Mando_Ministerial) || !string.IsNullOrEmpty(filter.ToFecha_Reunion_Mando_Ministerial))
            {
                var Fecha_Reunion_Mando_MinisterialFrom = DateTime.ParseExact(filter.FromFecha_Reunion_Mando_Ministerial, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_Reunion_Mando_MinisterialTo = DateTime.ParseExact(filter.ToFecha_Reunion_Mando_Ministerial, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_Reunion_Mando_Ministerial))
                    where += " AND Plan_de_Investigacion.Fecha_Reunion_Mando_Ministerial >= '" + Fecha_Reunion_Mando_MinisterialFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_Reunion_Mando_Ministerial))
                    where += " AND Plan_de_Investigacion.Fecha_Reunion_Mando_Ministerial <= '" + Fecha_Reunion_Mando_MinisterialTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_Reunion_Mando_Ministerial) || !string.IsNullOrEmpty(filter.ToHora_Reunion_Mando_Ministerial))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_Reunion_Mando_Ministerial))
                    where += " AND Convert(TIME,Plan_de_Investigacion.Hora_Reunion_Mando_Ministerial) >='" + filter.FromHora_Reunion_Mando_Ministerial + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_Reunion_Mando_Ministerial))
                    where += " AND Convert(TIME,Plan_de_Investigacion.Hora_Reunion_Mando_Ministerial) <='" + filter.ToHora_Reunion_Mando_Ministerial + "'";
            }

            if (!string.IsNullOrEmpty(filter.Asistentes))
            {
                switch (filter.AsistentesFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Plan_de_Investigacion.Asistentes LIKE '" + filter.Asistentes + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Plan_de_Investigacion.Asistentes LIKE '%" + filter.Asistentes + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Plan_de_Investigacion.Asistentes = '" + filter.Asistentes + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Plan_de_Investigacion.Asistentes LIKE '%" + filter.Asistentes + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Acuerdos))
            {
                switch (filter.AcuerdosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Plan_de_Investigacion.Acuerdos LIKE '" + filter.Acuerdos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Plan_de_Investigacion.Acuerdos LIKE '%" + filter.Acuerdos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Plan_de_Investigacion.Acuerdos = '" + filter.Acuerdos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Plan_de_Investigacion.Acuerdos LIKE '%" + filter.Acuerdos + "%'";
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

        public ActionResult GetDetalle_Plan_Actos_de_Investigacion(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_Plan_Actos_de_InvestigacionGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Plan_Actos_de_InvestigacionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_Plan_Actos_de_Investigacion.Plan_de_Investigacion=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_Plan_Actos_de_Investigacion.Plan_de_Investigacion='" + RelationId + "'";
            }
            var result = _IDetalle_Plan_Actos_de_InvestigacionApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_Plan_Actos_de_Investigacions == null)
                result.Detalle_Plan_Actos_de_Investigacions = new List<Detalle_Plan_Actos_de_Investigacion>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_Plan_Actos_de_Investigacions.Select(m => new Detalle_Plan_Actos_de_InvestigacionGridModel
                {
                    Clave = m.Clave

                        ,Categoria = m.Categoria
                        ,CategoriaDescripcion = CultureHelper.GetTraduction(m.Categoria_Categoria_de_Servicio_de_Apoyo.Clave.ToString(), "Descripcion") ??(string)m.Categoria_Categoria_de_Servicio_de_Apoyo.Descripcion
                        ,Servicio_a_Solicitar = m.Servicio_a_Solicitar
                        ,Servicio_a_SolicitarServicio = CultureHelper.GetTraduction(m.Servicio_a_Solicitar_Tipo_de_Servicio_de_Apoyo.Clave.ToString(), "Servicio") ??(string)m.Servicio_a_Solicitar_Tipo_de_Servicio_de_Apoyo.Servicio
			,Hecho_Delictivo_Acreditado = m.Hecho_Delictivo_Acreditado
			,Tiempo_Estandar = m.Tiempo_Estandar
			,Ponderacion = m.Ponderacion
			,Fecha_Contestacion = (m.Fecha_Contestacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_Contestacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_Contestacion = m.Hora_Contestacion
			,Contestacion = m.Contestacion
			,Archivo_AdjuntoFileInfo = m.Archivo_Adjunto > 0 ? (ConvertSpartane_FileToGridFile(_ISpartane_FileApiConsumer.GetByKey(m.Archivo_Adjunto).Resource)) : new Grid_File { FileId = 0, FileSize = 0, FileName = "" }
                        ,Usuario_que_Contesta = m.Usuario_que_Contesta
                        ,Usuario_que_ContestaName = CultureHelper.GetTraduction(m.Usuario_que_Contesta_Spartan_User.Id_User.ToString(), "Name") ??(string)m.Usuario_que_Contesta_Spartan_User.Name

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_Plan_Actos_de_InvestigacionGridModel> GetDetalle_Plan_Actos_de_InvestigacionData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_Plan_Actos_de_InvestigacionGridModel> resultData = new List<Detalle_Plan_Actos_de_InvestigacionGridModel>();
            string where = "Detalle_Plan_Actos_de_Investigacion.Plan_de_Investigacion=" + Id;
            if("int" == "string")
            {
                where = "Detalle_Plan_Actos_de_Investigacion.Plan_de_Investigacion='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Plan_Actos_de_InvestigacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_Plan_Actos_de_InvestigacionApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_Plan_Actos_de_Investigacions != null)
            {
                resultData = result.Detalle_Plan_Actos_de_Investigacions.Select(m => new Detalle_Plan_Actos_de_InvestigacionGridModel
                    {
                        Clave = m.Clave

                        ,Categoria = m.Categoria
                        ,CategoriaDescripcion = CultureHelper.GetTraduction(m.Categoria_Categoria_de_Servicio_de_Apoyo.Clave.ToString(), "Descripcion") ??(string)m.Categoria_Categoria_de_Servicio_de_Apoyo.Descripcion
                        ,Servicio_a_Solicitar = m.Servicio_a_Solicitar
                        ,Servicio_a_SolicitarServicio = CultureHelper.GetTraduction(m.Servicio_a_Solicitar_Tipo_de_Servicio_de_Apoyo.Clave.ToString(), "Servicio") ??(string)m.Servicio_a_Solicitar_Tipo_de_Servicio_de_Apoyo.Servicio
			,Hecho_Delictivo_Acreditado = m.Hecho_Delictivo_Acreditado
			,Tiempo_Estandar = m.Tiempo_Estandar
			,Ponderacion = m.Ponderacion
			,Fecha_Contestacion = (m.Fecha_Contestacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_Contestacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_Contestacion = m.Hora_Contestacion
			,Contestacion = m.Contestacion
			,Archivo_AdjuntoFileInfo = m.Archivo_Adjunto > 0 ? (ConvertSpartane_FileToGridFile(_ISpartane_FileApiConsumer.GetByKey(m.Archivo_Adjunto).Resource)) : new Grid_File { FileId = 0, FileSize = 0, FileName = "" }
                        ,Usuario_que_Contesta = m.Usuario_que_Contesta
                        ,Usuario_que_ContestaName = CultureHelper.GetTraduction(m.Usuario_que_Contesta_Spartan_User.Id_User.ToString(), "Name") ??(string)m.Usuario_que_Contesta_Spartan_User.Name


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
                _IPlan_de_InvestigacionApiConsumer.SetAuthHeader(_tokenManager.Token);

                Plan_de_Investigacion varPlan_de_Investigacion = null;
                if (id.ToString() != "0")
                {
                        string where = "";
                    _IDetalle_Plan_Actos_de_InvestigacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_Plan_Actos_de_Investigacion.Plan_de_Investigacion=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_Plan_Actos_de_Investigacion.Plan_de_Investigacion='" + id + "'";
                    }
                    var Detalle_Plan_Actos_de_InvestigacionInfo =
                        _IDetalle_Plan_Actos_de_InvestigacionApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_Plan_Actos_de_InvestigacionInfo.Detalle_Plan_Actos_de_Investigacions.Count > 0)
                    {
                        var resultDetalle_Plan_Actos_de_Investigacion = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_Plan_Actos_de_InvestigacionItem in Detalle_Plan_Actos_de_InvestigacionInfo.Detalle_Plan_Actos_de_Investigacions)
                            resultDetalle_Plan_Actos_de_Investigacion = resultDetalle_Plan_Actos_de_Investigacion
                                              && _IDetalle_Plan_Actos_de_InvestigacionApiConsumer.Delete(Detalle_Plan_Actos_de_InvestigacionItem.Clave, null,null).Resource;

                        if (!resultDetalle_Plan_Actos_de_Investigacion)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }

                }
                var result = _IPlan_de_InvestigacionApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Plan_de_InvestigacionModel varPlan_de_Investigacion)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IPlan_de_InvestigacionApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Plan_de_InvestigacionInfo = new Plan_de_Investigacion
                    {
                        Clave = varPlan_de_Investigacion.Clave
                        ,Expediente_MP = varPlan_de_Investigacion.Expediente_MP
                        ,Fecha_de_Registro = (!String.IsNullOrEmpty(varPlan_de_Investigacion.Fecha_de_Registro)) ? DateTime.ParseExact(varPlan_de_Investigacion.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Registro = varPlan_de_Investigacion.Hora_de_Registro
                        ,Usuario_que_Registra = varPlan_de_Investigacion.Usuario_que_Registra
                        ,Fecha_Reunion_Mando_Ministerial = (!String.IsNullOrEmpty(varPlan_de_Investigacion.Fecha_Reunion_Mando_Ministerial)) ? DateTime.ParseExact(varPlan_de_Investigacion.Fecha_Reunion_Mando_Ministerial, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_Reunion_Mando_Ministerial = varPlan_de_Investigacion.Hora_Reunion_Mando_Ministerial
                        ,Asistentes = varPlan_de_Investigacion.Asistentes
                        ,Acuerdos = varPlan_de_Investigacion.Acuerdos

                    };

                    result = !IsNew ?
                        _IPlan_de_InvestigacionApiConsumer.Update(Plan_de_InvestigacionInfo, null, null).Resource.ToString() :
                         _IPlan_de_InvestigacionApiConsumer.Insert(Plan_de_InvestigacionInfo, null, null).Resource.ToString();
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
        public bool CopyDetalle_Plan_Actos_de_Investigacion(int MasterId, int referenceId, List<Detalle_Plan_Actos_de_InvestigacionGridModelPost> Detalle_Plan_Actos_de_InvestigacionItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_Plan_Actos_de_InvestigacionApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_Plan_Actos_de_InvestigacionData = _IDetalle_Plan_Actos_de_InvestigacionApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_Plan_Actos_de_Investigacion.Plan_de_Investigacion=" + referenceId,"").Resource;
                if (Detalle_Plan_Actos_de_InvestigacionData == null || Detalle_Plan_Actos_de_InvestigacionData.Detalle_Plan_Actos_de_Investigacions.Count == 0)
                    return true;

                var result = true;

                Detalle_Plan_Actos_de_InvestigacionGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_Plan_Actos_de_Investigacion in Detalle_Plan_Actos_de_InvestigacionData.Detalle_Plan_Actos_de_Investigacions)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_Plan_Actos_de_Investigacion Detalle_Plan_Actos_de_Investigacion1 = varDetalle_Plan_Actos_de_Investigacion;

                    if (Detalle_Plan_Actos_de_InvestigacionItems != null && Detalle_Plan_Actos_de_InvestigacionItems.Any(m => m.Clave == Detalle_Plan_Actos_de_Investigacion1.Clave))
                    {
                        modelDataToChange = Detalle_Plan_Actos_de_InvestigacionItems.FirstOrDefault(m => m.Clave == Detalle_Plan_Actos_de_Investigacion1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_Plan_Actos_de_Investigacion.Plan_de_Investigacion = MasterId;
                    var insertId = _IDetalle_Plan_Actos_de_InvestigacionApiConsumer.Insert(varDetalle_Plan_Actos_de_Investigacion,null,null).Resource;
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
        public ActionResult PostDetalle_Plan_Actos_de_Investigacion(List<Detalle_Plan_Actos_de_InvestigacionGridModelPost> Detalle_Plan_Actos_de_InvestigacionItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_Plan_Actos_de_Investigacion(MasterId, referenceId, Detalle_Plan_Actos_de_InvestigacionItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_Plan_Actos_de_InvestigacionItems != null && Detalle_Plan_Actos_de_InvestigacionItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_Plan_Actos_de_InvestigacionApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_Plan_Actos_de_InvestigacionItem in Detalle_Plan_Actos_de_InvestigacionItems)
                    {









                        #region Archivo_AdjuntoInfo
                        //Checking if file exist if yes edit or add
                        if (Detalle_Plan_Actos_de_InvestigacionItem.Archivo_AdjuntoInfo.Control != null && !Detalle_Plan_Actos_de_InvestigacionItem.Removed)
                        {
                            var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(Detalle_Plan_Actos_de_InvestigacionItem.Archivo_AdjuntoInfo.Control);
                            Detalle_Plan_Actos_de_InvestigacionItem.Archivo_AdjuntoInfo.FileId = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                            {
                                File = fileAsBytes,
                                Description = Detalle_Plan_Actos_de_InvestigacionItem.Archivo_AdjuntoInfo.Control.FileName,
                                File_Size = fileAsBytes.Length
                            }).Resource;
                        }
                        else if (!Detalle_Plan_Actos_de_InvestigacionItem.Removed && Detalle_Plan_Actos_de_InvestigacionItem.Archivo_AdjuntoInfo.RemoveFile)
                        {
                            Detalle_Plan_Actos_de_InvestigacionItem.Archivo_AdjuntoInfo.FileId = 0;
                        }
                        #endregion Archivo_AdjuntoInfo


                        //Removal Request
                        if (Detalle_Plan_Actos_de_InvestigacionItem.Removed)
                        {
                            result = result && _IDetalle_Plan_Actos_de_InvestigacionApiConsumer.Delete(Detalle_Plan_Actos_de_InvestigacionItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_Plan_Actos_de_InvestigacionItem.Clave = 0;

                        var Detalle_Plan_Actos_de_InvestigacionData = new Detalle_Plan_Actos_de_Investigacion
                        {
                            Plan_de_Investigacion = MasterId
                            ,Clave = Detalle_Plan_Actos_de_InvestigacionItem.Clave
                            ,Categoria = (Convert.ToInt16(Detalle_Plan_Actos_de_InvestigacionItem.Categoria) == 0 ? (Int16?)null : Convert.ToInt16(Detalle_Plan_Actos_de_InvestigacionItem.Categoria))
                            ,Servicio_a_Solicitar = (Convert.ToInt32(Detalle_Plan_Actos_de_InvestigacionItem.Servicio_a_Solicitar) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_Plan_Actos_de_InvestigacionItem.Servicio_a_Solicitar))
                            ,Hecho_Delictivo_Acreditado = Detalle_Plan_Actos_de_InvestigacionItem.Hecho_Delictivo_Acreditado
                            ,Tiempo_Estandar = Detalle_Plan_Actos_de_InvestigacionItem.Tiempo_Estandar
                            ,Ponderacion = Detalle_Plan_Actos_de_InvestigacionItem.Ponderacion
                            ,Fecha_Contestacion = (Detalle_Plan_Actos_de_InvestigacionItem.Fecha_Contestacion!= null) ? DateTime.ParseExact(Detalle_Plan_Actos_de_InvestigacionItem.Fecha_Contestacion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                            ,Hora_Contestacion = Detalle_Plan_Actos_de_InvestigacionItem.Hora_Contestacion
                            ,Contestacion = Detalle_Plan_Actos_de_InvestigacionItem.Contestacion
                            ,Archivo_Adjunto = Detalle_Plan_Actos_de_InvestigacionItem.Archivo_AdjuntoInfo.FileId
                            ,Usuario_que_Contesta = (Convert.ToInt32(Detalle_Plan_Actos_de_InvestigacionItem.Usuario_que_Contesta) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_Plan_Actos_de_InvestigacionItem.Usuario_que_Contesta))

                        };

                        var resultId = Detalle_Plan_Actos_de_InvestigacionItem.Clave > 0
                           ? _IDetalle_Plan_Actos_de_InvestigacionApiConsumer.Update(Detalle_Plan_Actos_de_InvestigacionData,null,null).Resource
                           : _IDetalle_Plan_Actos_de_InvestigacionApiConsumer.Insert(Detalle_Plan_Actos_de_InvestigacionData,null,null).Resource;

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
        public ActionResult GetDetalle_Plan_Actos_de_Investigacion_Categoria_de_Servicio_de_ApoyoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICategoria_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICategoria_de_Servicio_de_ApoyoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Categoria_de_Servicio_de_Apoyo", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_Plan_Actos_de_Investigacion_Tipo_de_Servicio_de_ApoyoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_Servicio_de_ApoyoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Tipo_de_Servicio_de_Apoyo", "Servicio");
                  item.Servicio= trans??item.Servicio;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }







        [HttpGet]
        public ActionResult GetDetalle_Plan_Actos_de_Investigacion_Spartan_UserAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISpartan_UserApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
                    item.Name= CultureHelper.GetTraduction(Convert.ToString(item.Id_User), "Spartan_User", "Name");
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }



        /// <summary>
        /// Write Element Array of Plan_de_Investigacion script
        /// </summary>
        /// <param name="oPlan_de_InvestigacionElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Plan_de_InvestigacionModuleAttributeList)
        {
            for (int i = 0; i < Plan_de_InvestigacionModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Plan_de_InvestigacionModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Plan_de_InvestigacionModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Plan_de_InvestigacionModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Plan_de_InvestigacionModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Plan_de_InvestigacionModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Plan_de_InvestigacionModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Plan_de_InvestigacionModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Plan_de_InvestigacionModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Plan_de_InvestigacionModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Plan_de_InvestigacionModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Plan_de_InvestigacionModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strPlan_de_InvestigacionScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Plan_de_Investigacion.js")))
            {
                strPlan_de_InvestigacionScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Plan_de_Investigacion element attributes
            string userChangeJson = jsSerialize.Serialize(Plan_de_InvestigacionModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strPlan_de_InvestigacionScript.IndexOf("inpuElementArray");
            string splittedString = strPlan_de_InvestigacionScript.Substring(indexOfArray, strPlan_de_InvestigacionScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Plan_de_InvestigacionModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Plan_de_InvestigacionModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strPlan_de_InvestigacionScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strPlan_de_InvestigacionScript.Substring(indexOfArrayHistory, strPlan_de_InvestigacionScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strPlan_de_InvestigacionScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strPlan_de_InvestigacionScript.Substring(endIndexOfMainElement + indexOfArray, strPlan_de_InvestigacionScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Plan_de_InvestigacionModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Plan_de_InvestigacionModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Plan_de_Investigacion.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Plan_de_Investigacion.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Plan_de_Investigacion.js")))
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
        public ActionResult Plan_de_InvestigacionPropertyBag()
        {
            return PartialView("Plan_de_InvestigacionPropertyBag", "Plan_de_Investigacion");
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
        public ActionResult AddDetalle_Plan_Actos_de_Investigacion(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_Plan_Actos_de_Investigacion/AddDetalle_Plan_Actos_de_Investigacion");
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
                var whereClauseFormat = "Object = 45478 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IPlan_de_InvestigacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Plan_de_Investigacion.Clave= " + RecordId;
                            var result = _IPlan_de_InvestigacionApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IPlan_de_InvestigacionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Plan_de_InvestigacionPropertyMapper());
			
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
                    (Plan_de_InvestigacionAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Plan_de_InvestigacionPropertyMapper oPlan_de_InvestigacionPropertyMapper = new Plan_de_InvestigacionPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oPlan_de_InvestigacionPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IPlan_de_InvestigacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Plan_de_Investigacions == null)
                result.Plan_de_Investigacions = new List<Plan_de_Investigacion>();

            var data = result.Plan_de_Investigacions.Select(m => new Plan_de_InvestigacionGridModel
            {
                Clave = m.Clave
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,Fecha_Reunion_Mando_Ministerial = (m.Fecha_Reunion_Mando_Ministerial == null ? string.Empty : Convert.ToDateTime(m.Fecha_Reunion_Mando_Ministerial).ToString(ConfigurationProperty.DateFormat))
			,Hora_Reunion_Mando_Ministerial = m.Hora_Reunion_Mando_Ministerial
			,Asistentes = m.Asistentes
			,Acuerdos = m.Acuerdos

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45478, arrayColumnsVisible), "Plan_de_InvestigacionList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45478, arrayColumnsVisible), "Plan_de_InvestigacionList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45478, arrayColumnsVisible), "Plan_de_InvestigacionList_" + DateTime.Now.ToString());
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

            _IPlan_de_InvestigacionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Plan_de_InvestigacionPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Plan_de_InvestigacionAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Plan_de_InvestigacionPropertyMapper oPlan_de_InvestigacionPropertyMapper = new Plan_de_InvestigacionPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oPlan_de_InvestigacionPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IPlan_de_InvestigacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Plan_de_Investigacions == null)
                result.Plan_de_Investigacions = new List<Plan_de_Investigacion>();

            var data = result.Plan_de_Investigacions.Select(m => new Plan_de_InvestigacionGridModel
            {
                Clave = m.Clave
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,Fecha_Reunion_Mando_Ministerial = (m.Fecha_Reunion_Mando_Ministerial == null ? string.Empty : Convert.ToDateTime(m.Fecha_Reunion_Mando_Ministerial).ToString(ConfigurationProperty.DateFormat))
			,Hora_Reunion_Mando_Ministerial = m.Hora_Reunion_Mando_Ministerial
			,Asistentes = m.Asistentes
			,Acuerdos = m.Acuerdos

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
                _IPlan_de_InvestigacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IPlan_de_InvestigacionApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Plan_de_Investigacion_Datos_GeneralesModel varPlan_de_Investigacion)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IPlan_de_InvestigacionApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Plan_de_Investigacion_Datos_GeneralesInfo = new Plan_de_Investigacion_Datos_Generales
                {
                    Clave = varPlan_de_Investigacion.Clave
                                            ,Expediente_MP = varPlan_de_Investigacion.Expediente_MP
                        ,Fecha_de_Registro = (!String.IsNullOrEmpty(varPlan_de_Investigacion.Fecha_de_Registro)) ? DateTime.ParseExact(varPlan_de_Investigacion.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Registro = varPlan_de_Investigacion.Hora_de_Registro
                        ,Usuario_que_Registra = varPlan_de_Investigacion.Usuario_que_Registra
                        ,Fecha_Reunion_Mando_Ministerial = (!String.IsNullOrEmpty(varPlan_de_Investigacion.Fecha_Reunion_Mando_Ministerial)) ? DateTime.ParseExact(varPlan_de_Investigacion.Fecha_Reunion_Mando_Ministerial, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_Reunion_Mando_Ministerial = varPlan_de_Investigacion.Hora_Reunion_Mando_Ministerial
                        ,Asistentes = varPlan_de_Investigacion.Asistentes
                        ,Acuerdos = varPlan_de_Investigacion.Acuerdos
                    
                };

                result = _IPlan_de_InvestigacionApiConsumer.Update_Datos_Generales(Plan_de_Investigacion_Datos_GeneralesInfo).Resource.ToString();
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
                _IPlan_de_InvestigacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IPlan_de_InvestigacionApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_Plan_Actos_de_Investigacion;
                var Detalle_Plan_Actos_de_InvestigacionData = GetDetalle_Plan_Actos_de_InvestigacionData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Plan_Actos_de_Investigacion);

                var result = new Plan_de_Investigacion_Datos_GeneralesModel
                {
                    Clave = m.Clave
                        ,Expediente_MP = m.Expediente_MP
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_Registra = m.Usuario_que_Registra
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,Fecha_Reunion_Mando_Ministerial = (m.Fecha_Reunion_Mando_Ministerial == null ? string.Empty : Convert.ToDateTime(m.Fecha_Reunion_Mando_Ministerial).ToString(ConfigurationProperty.DateFormat))
			,Hora_Reunion_Mando_Ministerial = m.Hora_Reunion_Mando_Ministerial
			,Asistentes = m.Asistentes
			,Acuerdos = m.Acuerdos

                    
                };
				var resultData = new
                {
                    data = result
                    ,Detalle = Detalle_Plan_Actos_de_InvestigacionData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Actos_de_Investigacion(Plan_de_Investigacion_Actos_de_InvestigacionModel varPlan_de_Investigacion)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IPlan_de_InvestigacionApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Plan_de_Investigacion_Actos_de_InvestigacionInfo = new Plan_de_Investigacion_Actos_de_Investigacion
                {
                    Clave = varPlan_de_Investigacion.Clave
                                        
                };

                result = _IPlan_de_InvestigacionApiConsumer.Update_Actos_de_Investigacion(Plan_de_Investigacion_Actos_de_InvestigacionInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Actos_de_Investigacion(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IPlan_de_InvestigacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IPlan_de_InvestigacionApiConsumer.Get_Actos_de_Investigacion(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_Plan_Actos_de_Investigacion;
                var Detalle_Plan_Actos_de_InvestigacionData = GetDetalle_Plan_Actos_de_InvestigacionData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Plan_Actos_de_Investigacion);

                var result = new Plan_de_Investigacion_Actos_de_InvestigacionModel
                {
                    Clave = m.Clave

                    
                };
				var resultData = new
                {
                    data = result
                    ,Detalle = Detalle_Plan_Actos_de_InvestigacionData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }


    }
}

