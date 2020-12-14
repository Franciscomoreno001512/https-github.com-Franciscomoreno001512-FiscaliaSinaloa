using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Configurador_de_Movimientos;
using Spartane.Core.Domain.Fase_de_Judicializacion;
using Spartane.Core.Domain.Detalle_Datos_Adicionales_Movimiento;


using Spartane.Core.Domain.Tipo_de_Dato;
using Spartane.Core.Domain.Relaciones_para_Movimientos;



using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Configurador_de_Movimientos;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Configurador_de_Movimientos;
using Spartane.Web.Areas.WebApiConsumer.Fase_de_Judicializacion;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Datos_Adicionales_Movimiento;

using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Dato;
using Spartane.Web.Areas.WebApiConsumer.Relaciones_para_Movimientos;



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
    public class Configurador_de_MovimientosController : Controller
    {
        #region "variable declaration"

        private IConfigurador_de_MovimientosService service = null;
        private IConfigurador_de_MovimientosApiConsumer _IConfigurador_de_MovimientosApiConsumer;
        private IFase_de_JudicializacionApiConsumer _IFase_de_JudicializacionApiConsumer;
        private IDetalle_Datos_Adicionales_MovimientoApiConsumer _IDetalle_Datos_Adicionales_MovimientoApiConsumer;

        private ITipo_de_DatoApiConsumer _ITipo_de_DatoApiConsumer;
        private IRelaciones_para_MovimientosApiConsumer _IRelaciones_para_MovimientosApiConsumer;



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

        
        public Configurador_de_MovimientosController(IConfigurador_de_MovimientosService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IConfigurador_de_MovimientosApiConsumer Configurador_de_MovimientosApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , IFase_de_JudicializacionApiConsumer Fase_de_JudicializacionApiConsumer , IDetalle_Datos_Adicionales_MovimientoApiConsumer Detalle_Datos_Adicionales_MovimientoApiConsumer , ITipo_de_DatoApiConsumer Tipo_de_DatoApiConsumer , IRelaciones_para_MovimientosApiConsumer Relaciones_para_MovimientosApiConsumer  )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IConfigurador_de_MovimientosApiConsumer = Configurador_de_MovimientosApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_FormatApiConsumer = Spartan_FormatApiConsumer;
            this._ISpartan_Format_PermissionsApiConsumer = Spartan_Format_PermissionsApiConsumer;
            this._IGeneratePDFApiConsumer = GeneratePDFApiConsumer;
			this._ISpartan_FormatRelatedApiConsumer = Spartan_Format_RelatedApiConsumer;
            this._IFase_de_JudicializacionApiConsumer = Fase_de_JudicializacionApiConsumer;
            this._IDetalle_Datos_Adicionales_MovimientoApiConsumer = Detalle_Datos_Adicionales_MovimientoApiConsumer;

            this._ITipo_de_DatoApiConsumer = Tipo_de_DatoApiConsumer;
            this._IRelaciones_para_MovimientosApiConsumer = Relaciones_para_MovimientosApiConsumer;



        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Configurador_de_Movimientos
        [ObjectAuth(ObjectId = (ModuleObjectId)45634, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45634, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Configurador_de_Movimientos/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45634, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45634, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varConfigurador_de_Movimientos = new Configurador_de_MovimientosModel();
			varConfigurador_de_Movimientos.Clave = Id;
			
            ViewBag.ObjectId = "45634";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;

            var permissionDetalle_Datos_Adicionales_Movimiento = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45635, ModuleId);
            ViewBag.PermissionDetalle_Datos_Adicionales_Movimiento = permissionDetalle_Datos_Adicionales_Movimiento;


            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IConfigurador_de_MovimientosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Configurador_de_MovimientossData = _IConfigurador_de_MovimientosApiConsumer.ListaSelAll(0, 1000, "Configurador_de_Movimientos.Clave=" + Id, "").Resource.Configurador_de_Movimientoss;
				
				if (Configurador_de_MovimientossData != null && Configurador_de_MovimientossData.Count > 0)
                {
					var Configurador_de_MovimientosData = Configurador_de_MovimientossData.First();
					varConfigurador_de_Movimientos= new Configurador_de_MovimientosModel
					{
						Clave  = Configurador_de_MovimientosData.Clave 
	                    ,Descripcion = Configurador_de_MovimientosData.Descripcion
                    ,Fase = Configurador_de_MovimientosData.Fase
                    ,FaseDescripcion = CultureHelper.GetTraduction(Convert.ToString(Configurador_de_MovimientosData.Fase), "Fase_de_Judicializacion") ??  (string)Configurador_de_MovimientosData.Fase_Fase_de_Judicializacion.Descripcion
                    ,Aplica_para_Adolescentes = Configurador_de_MovimientosData.Aplica_para_Adolescentes.GetValueOrDefault()

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IFase_de_JudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Fase_de_Judicializacions_Fase = _IFase_de_JudicializacionApiConsumer.SelAll(true);
            if (Fase_de_Judicializacions_Fase != null && Fase_de_Judicializacions_Fase.Resource != null)
                ViewBag.Fase_de_Judicializacions_Fase = Fase_de_Judicializacions_Fase.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Fase_de_Judicializacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varConfigurador_de_Movimientos);
        }
		
	[HttpGet]
        public ActionResult AddConfigurador_de_Movimientos(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45634);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IConfigurador_de_MovimientosApiConsumer.SetAuthHeader(_tokenManager.Token);
			Configurador_de_MovimientosModel varConfigurador_de_Movimientos= new Configurador_de_MovimientosModel();
            var permissionDetalle_Datos_Adicionales_Movimiento = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45635, ModuleId);
            ViewBag.PermissionDetalle_Datos_Adicionales_Movimiento = permissionDetalle_Datos_Adicionales_Movimiento;


            if (id.ToString() != "0")
            {
                var Configurador_de_MovimientossData = _IConfigurador_de_MovimientosApiConsumer.ListaSelAll(0, 1000, "Configurador_de_Movimientos.Clave=" + id, "").Resource.Configurador_de_Movimientoss;
				
				if (Configurador_de_MovimientossData != null && Configurador_de_MovimientossData.Count > 0)
                {
					var Configurador_de_MovimientosData = Configurador_de_MovimientossData.First();
					varConfigurador_de_Movimientos= new Configurador_de_MovimientosModel
					{
						Clave  = Configurador_de_MovimientosData.Clave 
	                    ,Descripcion = Configurador_de_MovimientosData.Descripcion
                    ,Fase = Configurador_de_MovimientosData.Fase
                    ,FaseDescripcion = CultureHelper.GetTraduction(Convert.ToString(Configurador_de_MovimientosData.Fase), "Fase_de_Judicializacion") ??  (string)Configurador_de_MovimientosData.Fase_Fase_de_Judicializacion.Descripcion
                    ,Aplica_para_Adolescentes = Configurador_de_MovimientosData.Aplica_para_Adolescentes.GetValueOrDefault()

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IFase_de_JudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Fase_de_Judicializacions_Fase = _IFase_de_JudicializacionApiConsumer.SelAll(true);
            if (Fase_de_Judicializacions_Fase != null && Fase_de_Judicializacions_Fase.Resource != null)
                ViewBag.Fase_de_Judicializacions_Fase = Fase_de_Judicializacions_Fase.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Fase_de_Judicializacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddConfigurador_de_Movimientos", varConfigurador_de_Movimientos);
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
        public ActionResult GetFase_de_JudicializacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IFase_de_JudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IFase_de_JudicializacionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Fase_de_Judicializacion", "Descripcion")?? m.Descripcion,
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
        public ActionResult ShowAdvanceFilter(Configurador_de_MovimientosAdvanceSearchModel model, int idFilter = -1)
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

            _IFase_de_JudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Fase_de_Judicializacions_Fase = _IFase_de_JudicializacionApiConsumer.SelAll(true);
            if (Fase_de_Judicializacions_Fase != null && Fase_de_Judicializacions_Fase.Resource != null)
                ViewBag.Fase_de_Judicializacions_Fase = Fase_de_Judicializacions_Fase.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Fase_de_Judicializacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IFase_de_JudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Fase_de_Judicializacions_Fase = _IFase_de_JudicializacionApiConsumer.SelAll(true);
            if (Fase_de_Judicializacions_Fase != null && Fase_de_Judicializacions_Fase.Resource != null)
                ViewBag.Fase_de_Judicializacions_Fase = Fase_de_Judicializacions_Fase.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Fase_de_Judicializacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Configurador_de_MovimientosAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Configurador_de_MovimientosAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Configurador_de_MovimientosAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Configurador_de_MovimientosPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IConfigurador_de_MovimientosApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Configurador_de_Movimientoss == null)
                result.Configurador_de_Movimientoss = new List<Configurador_de_Movimientos>();

            return Json(new
            {
                data = result.Configurador_de_Movimientoss.Select(m => new Configurador_de_MovimientosGridModel
                    {
                    Clave = m.Clave
			,Descripcion = m.Descripcion
                        ,FaseDescripcion = CultureHelper.GetTraduction(m.Fase_Fase_de_Judicializacion.Clave.ToString(), "Descripcion") ?? (string)m.Fase_Fase_de_Judicializacion.Descripcion
			,Aplica_para_Adolescentes = m.Aplica_para_Adolescentes

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetConfigurador_de_MovimientosAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IConfigurador_de_MovimientosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IConfigurador_de_MovimientosApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Configurador_de_Movimientos", m.),
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
        /// Get List of Configurador_de_Movimientos from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Configurador_de_Movimientos Entity</returns>
        public ActionResult GetConfigurador_de_MovimientosList(UrlParametersModel param)
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
            _IConfigurador_de_MovimientosApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Configurador_de_MovimientosPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Configurador_de_MovimientosAdvanceSearchModel))
                {
					var advanceFilter =
                    (Configurador_de_MovimientosAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Configurador_de_MovimientosPropertyMapper oConfigurador_de_MovimientosPropertyMapper = new Configurador_de_MovimientosPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oConfigurador_de_MovimientosPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IConfigurador_de_MovimientosApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Configurador_de_Movimientoss == null)
                result.Configurador_de_Movimientoss = new List<Configurador_de_Movimientos>();

            return Json(new
            {
                aaData = result.Configurador_de_Movimientoss.Select(m => new Configurador_de_MovimientosGridModel
            {
                    Clave = m.Clave
			,Descripcion = m.Descripcion
                        ,FaseDescripcion = CultureHelper.GetTraduction(m.Fase_Fase_de_Judicializacion.Clave.ToString(), "Descripcion") ?? (string)m.Fase_Fase_de_Judicializacion.Descripcion
			,Aplica_para_Adolescentes = m.Aplica_para_Adolescentes

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


//Grid GetAutoComplete
        [HttpGet]
        public JsonResult GetDetalle_Datos_Adicionales_Movimiento_Relacion_Relaciones_para_Movimientos(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRelaciones_para_MovimientosApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Relaciones_para_Movimientos.ObjectId as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Relaciones_para_Movimientos.Descripcion as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IRelaciones_para_MovimientosApiConsumer.ListaSelAll(1, 20,elWhere , " Relaciones_para_Movimientos.Descripcion ASC ").Resource;
               
                foreach (var item in result.Relaciones_para_Movimientoss)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.ObjectId), "Relaciones_para_Movimientos", "Descripcion");
                    item.Descripcion =trans ??item.Descripcion;
                }
                return Json(result.Relaciones_para_Movimientoss.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }






        [NonAction]
        public string GetAdvanceFilter(Configurador_de_MovimientosAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Configurador_de_Movimientos.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Configurador_de_Movimientos.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.Descripcion))
            {
                switch (filter.DescripcionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Configurador_de_Movimientos.Descripcion LIKE '" + filter.Descripcion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Configurador_de_Movimientos.Descripcion LIKE '%" + filter.Descripcion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Configurador_de_Movimientos.Descripcion = '" + filter.Descripcion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Configurador_de_Movimientos.Descripcion LIKE '%" + filter.Descripcion + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceFase))
            {
                switch (filter.FaseFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Fase_de_Judicializacion.Descripcion LIKE '" + filter.AdvanceFase + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Fase_de_Judicializacion.Descripcion LIKE '%" + filter.AdvanceFase + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Fase_de_Judicializacion.Descripcion = '" + filter.AdvanceFase + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Fase_de_Judicializacion.Descripcion LIKE '%" + filter.AdvanceFase + "%'";
                        break;
                }
            }
            else if (filter.AdvanceFaseMultiple != null && filter.AdvanceFaseMultiple.Count() > 0)
            {
                var FaseIds = string.Join(",", filter.AdvanceFaseMultiple);

                where += " AND Configurador_de_Movimientos.Fase In (" + FaseIds + ")";
            }

            if (filter.Aplica_para_Adolescentes != RadioOptions.NoApply)
                where += " AND Configurador_de_Movimientos.Aplica_para_Adolescentes = " + Convert.ToInt32(filter.Aplica_para_Adolescentes);


            where = new Regex(Regex.Escape("AND ")).Replace(where, "", 1);
            return where;
        }

        [NonAction]
        public Grid_File ConvertSpartane_FileToGridFile(Spartane.Core.Domain.Spartane_File.Spartane_File file)
        {
            return file == null ? new Grid_File { FileId = 0, FileSize = 0, FileName = "" } : new Grid_File { FileId = file.File_Id, FileName = file.Description, FileSize = file.File_Size ?? 0, };
        }

        public ActionResult GetDetalle_Datos_Adicionales_Movimiento(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_Datos_Adicionales_MovimientoGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Datos_Adicionales_MovimientoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_Datos_Adicionales_Movimiento.Movimiento=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_Datos_Adicionales_Movimiento.Movimiento='" + RelationId + "'";
            }
            var result = _IDetalle_Datos_Adicionales_MovimientoApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_Datos_Adicionales_Movimientos == null)
                result.Detalle_Datos_Adicionales_Movimientos = new List<Detalle_Datos_Adicionales_Movimiento>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_Datos_Adicionales_Movimientos.Select(m => new Detalle_Datos_Adicionales_MovimientoGridModel
                {
                    Clave = m.Clave

			,Dato = m.Dato
                        ,Tipo_de_Dato = m.Tipo_de_Dato
                        ,Tipo_de_DatoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Dato_Tipo_de_Dato.Clave.ToString(), "Descripcion") ??(string)m.Tipo_de_Dato_Tipo_de_Dato.Descripcion
                        ,Relacion = m.Relacion
                        ,RelacionDescripcion = CultureHelper.GetTraduction(m.Relacion_Relaciones_para_Movimientos.ObjectId.ToString(), "Descripcion") ??(string)m.Relacion_Relaciones_para_Movimientos.Descripcion
			,Obligatorio = m.Obligatorio

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_Datos_Adicionales_MovimientoGridModel> GetDetalle_Datos_Adicionales_MovimientoData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_Datos_Adicionales_MovimientoGridModel> resultData = new List<Detalle_Datos_Adicionales_MovimientoGridModel>();
            string where = "Detalle_Datos_Adicionales_Movimiento.Movimiento=" + Id;
            if("int" == "string")
            {
                where = "Detalle_Datos_Adicionales_Movimiento.Movimiento='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Datos_Adicionales_MovimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_Datos_Adicionales_MovimientoApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_Datos_Adicionales_Movimientos != null)
            {
                resultData = result.Detalle_Datos_Adicionales_Movimientos.Select(m => new Detalle_Datos_Adicionales_MovimientoGridModel
                    {
                        Clave = m.Clave

			,Dato = m.Dato
                        ,Tipo_de_Dato = m.Tipo_de_Dato
                        ,Tipo_de_DatoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Dato_Tipo_de_Dato.Clave.ToString(), "Descripcion") ??(string)m.Tipo_de_Dato_Tipo_de_Dato.Descripcion
                        ,Relacion = m.Relacion
                        ,RelacionDescripcion = CultureHelper.GetTraduction(m.Relacion_Relaciones_para_Movimientos.ObjectId.ToString(), "Descripcion") ??(string)m.Relacion_Relaciones_para_Movimientos.Descripcion
			,Obligatorio = m.Obligatorio


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
                _IConfigurador_de_MovimientosApiConsumer.SetAuthHeader(_tokenManager.Token);

                Configurador_de_Movimientos varConfigurador_de_Movimientos = null;
                if (id.ToString() != "0")
                {
                        string where = "";
                    _IDetalle_Datos_Adicionales_MovimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_Datos_Adicionales_Movimiento.Movimiento=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_Datos_Adicionales_Movimiento.Movimiento='" + id + "'";
                    }
                    var Detalle_Datos_Adicionales_MovimientoInfo =
                        _IDetalle_Datos_Adicionales_MovimientoApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_Datos_Adicionales_MovimientoInfo.Detalle_Datos_Adicionales_Movimientos.Count > 0)
                    {
                        var resultDetalle_Datos_Adicionales_Movimiento = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_Datos_Adicionales_MovimientoItem in Detalle_Datos_Adicionales_MovimientoInfo.Detalle_Datos_Adicionales_Movimientos)
                            resultDetalle_Datos_Adicionales_Movimiento = resultDetalle_Datos_Adicionales_Movimiento
                                              && _IDetalle_Datos_Adicionales_MovimientoApiConsumer.Delete(Detalle_Datos_Adicionales_MovimientoItem.Clave, null,null).Resource;

                        if (!resultDetalle_Datos_Adicionales_Movimiento)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }

                }
                var result = _IConfigurador_de_MovimientosApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Configurador_de_MovimientosModel varConfigurador_de_Movimientos)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IConfigurador_de_MovimientosApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Configurador_de_MovimientosInfo = new Configurador_de_Movimientos
                    {
                        Clave = varConfigurador_de_Movimientos.Clave
                        ,Descripcion = varConfigurador_de_Movimientos.Descripcion
                        ,Fase = varConfigurador_de_Movimientos.Fase
                        ,Aplica_para_Adolescentes = varConfigurador_de_Movimientos.Aplica_para_Adolescentes

                    };

                    result = !IsNew ?
                        _IConfigurador_de_MovimientosApiConsumer.Update(Configurador_de_MovimientosInfo, null, null).Resource.ToString() :
                         _IConfigurador_de_MovimientosApiConsumer.Insert(Configurador_de_MovimientosInfo, null, null).Resource.ToString();
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
        public bool CopyDetalle_Datos_Adicionales_Movimiento(int MasterId, int referenceId, List<Detalle_Datos_Adicionales_MovimientoGridModelPost> Detalle_Datos_Adicionales_MovimientoItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_Datos_Adicionales_MovimientoApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_Datos_Adicionales_MovimientoData = _IDetalle_Datos_Adicionales_MovimientoApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_Datos_Adicionales_Movimiento.Movimiento=" + referenceId,"").Resource;
                if (Detalle_Datos_Adicionales_MovimientoData == null || Detalle_Datos_Adicionales_MovimientoData.Detalle_Datos_Adicionales_Movimientos.Count == 0)
                    return true;

                var result = true;

                Detalle_Datos_Adicionales_MovimientoGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_Datos_Adicionales_Movimiento in Detalle_Datos_Adicionales_MovimientoData.Detalle_Datos_Adicionales_Movimientos)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_Datos_Adicionales_Movimiento Detalle_Datos_Adicionales_Movimiento1 = varDetalle_Datos_Adicionales_Movimiento;

                    if (Detalle_Datos_Adicionales_MovimientoItems != null && Detalle_Datos_Adicionales_MovimientoItems.Any(m => m.Clave == Detalle_Datos_Adicionales_Movimiento1.Clave))
                    {
                        modelDataToChange = Detalle_Datos_Adicionales_MovimientoItems.FirstOrDefault(m => m.Clave == Detalle_Datos_Adicionales_Movimiento1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_Datos_Adicionales_Movimiento.Movimiento = MasterId;
                    var insertId = _IDetalle_Datos_Adicionales_MovimientoApiConsumer.Insert(varDetalle_Datos_Adicionales_Movimiento,null,null).Resource;
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
        public ActionResult PostDetalle_Datos_Adicionales_Movimiento(List<Detalle_Datos_Adicionales_MovimientoGridModelPost> Detalle_Datos_Adicionales_MovimientoItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_Datos_Adicionales_Movimiento(MasterId, referenceId, Detalle_Datos_Adicionales_MovimientoItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_Datos_Adicionales_MovimientoItems != null && Detalle_Datos_Adicionales_MovimientoItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_Datos_Adicionales_MovimientoApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_Datos_Adicionales_MovimientoItem in Detalle_Datos_Adicionales_MovimientoItems)
                    {






                        //Removal Request
                        if (Detalle_Datos_Adicionales_MovimientoItem.Removed)
                        {
                            result = result && _IDetalle_Datos_Adicionales_MovimientoApiConsumer.Delete(Detalle_Datos_Adicionales_MovimientoItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_Datos_Adicionales_MovimientoItem.Clave = 0;

                        var Detalle_Datos_Adicionales_MovimientoData = new Detalle_Datos_Adicionales_Movimiento
                        {
                            Movimiento = MasterId
                            ,Clave = Detalle_Datos_Adicionales_MovimientoItem.Clave
                            ,Dato = Detalle_Datos_Adicionales_MovimientoItem.Dato
                            ,Tipo_de_Dato = (Convert.ToInt32(Detalle_Datos_Adicionales_MovimientoItem.Tipo_de_Dato) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_Datos_Adicionales_MovimientoItem.Tipo_de_Dato))
                            ,Relacion = (Convert.ToInt32(Detalle_Datos_Adicionales_MovimientoItem.Relacion) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_Datos_Adicionales_MovimientoItem.Relacion))
                            ,Obligatorio = Detalle_Datos_Adicionales_MovimientoItem.Obligatorio

                        };

                        var resultId = Detalle_Datos_Adicionales_MovimientoItem.Clave > 0
                           ? _IDetalle_Datos_Adicionales_MovimientoApiConsumer.Update(Detalle_Datos_Adicionales_MovimientoData,null,null).Resource
                           : _IDetalle_Datos_Adicionales_MovimientoApiConsumer.Insert(Detalle_Datos_Adicionales_MovimientoData,null,null).Resource;

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
        public ActionResult GetDetalle_Datos_Adicionales_Movimiento_Tipo_de_DatoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_DatoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_DatoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Tipo_de_Dato", "Descripcion");
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
        public ActionResult GetDetalle_Datos_Adicionales_Movimiento_Relaciones_para_MovimientosAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRelaciones_para_MovimientosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IRelaciones_para_MovimientosApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
                    item.Descripcion= CultureHelper.GetTraduction(Convert.ToString(item.ObjectId), "Relaciones_para_Movimientos", "Descripcion");
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }




        /// <summary>
        /// Write Element Array of Configurador_de_Movimientos script
        /// </summary>
        /// <param name="oConfigurador_de_MovimientosElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Configurador_de_MovimientosModuleAttributeList)
        {
            for (int i = 0; i < Configurador_de_MovimientosModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Configurador_de_MovimientosModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Configurador_de_MovimientosModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Configurador_de_MovimientosModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Configurador_de_MovimientosModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Configurador_de_MovimientosModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Configurador_de_MovimientosModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Configurador_de_MovimientosModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Configurador_de_MovimientosModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Configurador_de_MovimientosModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Configurador_de_MovimientosModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Configurador_de_MovimientosModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strConfigurador_de_MovimientosScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Configurador_de_Movimientos.js")))
            {
                strConfigurador_de_MovimientosScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Configurador_de_Movimientos element attributes
            string userChangeJson = jsSerialize.Serialize(Configurador_de_MovimientosModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strConfigurador_de_MovimientosScript.IndexOf("inpuElementArray");
            string splittedString = strConfigurador_de_MovimientosScript.Substring(indexOfArray, strConfigurador_de_MovimientosScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Configurador_de_MovimientosModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Configurador_de_MovimientosModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strConfigurador_de_MovimientosScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strConfigurador_de_MovimientosScript.Substring(indexOfArrayHistory, strConfigurador_de_MovimientosScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strConfigurador_de_MovimientosScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strConfigurador_de_MovimientosScript.Substring(endIndexOfMainElement + indexOfArray, strConfigurador_de_MovimientosScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Configurador_de_MovimientosModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Configurador_de_MovimientosModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Configurador_de_Movimientos.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Configurador_de_Movimientos.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Configurador_de_Movimientos.js")))
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
        public ActionResult Configurador_de_MovimientosPropertyBag()
        {
            return PartialView("Configurador_de_MovimientosPropertyBag", "Configurador_de_Movimientos");
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
        public ActionResult AddDetalle_Datos_Adicionales_Movimiento(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_Datos_Adicionales_Movimiento/AddDetalle_Datos_Adicionales_Movimiento");
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
                var whereClauseFormat = "Object = 45634 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IConfigurador_de_MovimientosApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Configurador_de_Movimientos.Clave= " + RecordId;
                            var result = _IConfigurador_de_MovimientosApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IConfigurador_de_MovimientosApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Configurador_de_MovimientosPropertyMapper());
			
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
                    (Configurador_de_MovimientosAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Configurador_de_MovimientosPropertyMapper oConfigurador_de_MovimientosPropertyMapper = new Configurador_de_MovimientosPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oConfigurador_de_MovimientosPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IConfigurador_de_MovimientosApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Configurador_de_Movimientoss == null)
                result.Configurador_de_Movimientoss = new List<Configurador_de_Movimientos>();

            var data = result.Configurador_de_Movimientoss.Select(m => new Configurador_de_MovimientosGridModel
            {
                Clave = m.Clave
			,Descripcion = m.Descripcion
                        ,FaseDescripcion = CultureHelper.GetTraduction(m.Fase_Fase_de_Judicializacion.Clave.ToString(), "Descripcion") ?? (string)m.Fase_Fase_de_Judicializacion.Descripcion
			,Aplica_para_Adolescentes = m.Aplica_para_Adolescentes

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45634, arrayColumnsVisible), "Configurador_de_MovimientosList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45634, arrayColumnsVisible), "Configurador_de_MovimientosList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45634, arrayColumnsVisible), "Configurador_de_MovimientosList_" + DateTime.Now.ToString());
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

            _IConfigurador_de_MovimientosApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Configurador_de_MovimientosPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Configurador_de_MovimientosAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Configurador_de_MovimientosPropertyMapper oConfigurador_de_MovimientosPropertyMapper = new Configurador_de_MovimientosPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oConfigurador_de_MovimientosPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IConfigurador_de_MovimientosApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Configurador_de_Movimientoss == null)
                result.Configurador_de_Movimientoss = new List<Configurador_de_Movimientos>();

            var data = result.Configurador_de_Movimientoss.Select(m => new Configurador_de_MovimientosGridModel
            {
                Clave = m.Clave
			,Descripcion = m.Descripcion
                        ,FaseDescripcion = CultureHelper.GetTraduction(m.Fase_Fase_de_Judicializacion.Clave.ToString(), "Descripcion") ?? (string)m.Fase_Fase_de_Judicializacion.Descripcion
			,Aplica_para_Adolescentes = m.Aplica_para_Adolescentes

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
                _IConfigurador_de_MovimientosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IConfigurador_de_MovimientosApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Configurador_de_Movimientos_Datos_GeneralesModel varConfigurador_de_Movimientos)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IConfigurador_de_MovimientosApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Configurador_de_Movimientos_Datos_GeneralesInfo = new Configurador_de_Movimientos_Datos_Generales
                {
                    Clave = varConfigurador_de_Movimientos.Clave
                                            ,Descripcion = varConfigurador_de_Movimientos.Descripcion
                        ,Fase = varConfigurador_de_Movimientos.Fase
                        ,Aplica_para_Adolescentes = varConfigurador_de_Movimientos.Aplica_para_Adolescentes
                    
                };

                result = _IConfigurador_de_MovimientosApiConsumer.Update_Datos_Generales(Configurador_de_Movimientos_Datos_GeneralesInfo).Resource.ToString();
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
                _IConfigurador_de_MovimientosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IConfigurador_de_MovimientosApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_Datos_Adicionales_Movimiento;
                var Detalle_Datos_Adicionales_MovimientoData = GetDetalle_Datos_Adicionales_MovimientoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Datos_Adicionales_Movimiento);

                var result = new Configurador_de_Movimientos_Datos_GeneralesModel
                {
                    Clave = m.Clave
			,Descripcion = m.Descripcion
                        ,Fase = m.Fase
                        ,FaseDescripcion = CultureHelper.GetTraduction(m.Fase_Fase_de_Judicializacion.Clave.ToString(), "Descripcion") ?? (string)m.Fase_Fase_de_Judicializacion.Descripcion
			,Aplica_para_Adolescentes = m.Aplica_para_Adolescentes

                    
                };
				var resultData = new
                {
                    data = result
                    ,Datos_Adicionales = Detalle_Datos_Adicionales_MovimientoData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }


    }
}

