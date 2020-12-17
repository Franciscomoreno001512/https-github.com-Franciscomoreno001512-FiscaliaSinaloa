using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_Resumen_Denuncia;
using Spartane.Core.Domain.Modulo_Atencion_Inicial;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_Resumen_Denuncia;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Resumen_Denuncia;
using Spartane.Web.Areas.WebApiConsumer.Modulo_Atencion_Inicial;

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
    public class Detalle_Resumen_DenunciaController : Controller
    {
        #region "variable declaration"

        private IDetalle_Resumen_DenunciaService service = null;
        private IDetalle_Resumen_DenunciaApiConsumer _IDetalle_Resumen_DenunciaApiConsumer;
        private IModulo_Atencion_InicialApiConsumer _IModulo_Atencion_InicialApiConsumer;

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

        
        public Detalle_Resumen_DenunciaController(IDetalle_Resumen_DenunciaService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_Resumen_DenunciaApiConsumer Detalle_Resumen_DenunciaApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , IModulo_Atencion_InicialApiConsumer Modulo_Atencion_InicialApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_Resumen_DenunciaApiConsumer = Detalle_Resumen_DenunciaApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_FormatApiConsumer = Spartan_FormatApiConsumer;
            this._ISpartan_Format_PermissionsApiConsumer = Spartan_Format_PermissionsApiConsumer;
            this._IGeneratePDFApiConsumer = GeneratePDFApiConsumer;
			this._ISpartan_FormatRelatedApiConsumer = Spartan_Format_RelatedApiConsumer;
            this._IModulo_Atencion_InicialApiConsumer = Modulo_Atencion_InicialApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_Resumen_Denuncia
        [ObjectAuth(ObjectId = (ModuleObjectId)45620, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45620, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Detalle_Resumen_Denuncia/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45620, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45620, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varDetalle_Resumen_Denuncia = new Detalle_Resumen_DenunciaModel();
			varDetalle_Resumen_Denuncia.Clave = Id;
			
            ViewBag.ObjectId = "45620";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IDetalle_Resumen_DenunciaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_Resumen_DenunciasData = _IDetalle_Resumen_DenunciaApiConsumer.ListaSelAll(0, 1000, "Detalle_Resumen_Denuncia.Clave=" + Id, "").Resource.Detalle_Resumen_Denuncias;
				
				if (Detalle_Resumen_DenunciasData != null && Detalle_Resumen_DenunciasData.Count > 0)
                {
					var Detalle_Resumen_DenunciaData = Detalle_Resumen_DenunciasData.First();
					varDetalle_Resumen_Denuncia= new Detalle_Resumen_DenunciaModel
					{
						Clave  = Detalle_Resumen_DenunciaData.Clave 
	                    ,Modulo_Atencion_Inicial = Detalle_Resumen_DenunciaData.Modulo_Atencion_Inicial
                    ,Modulo_Atencion_InicialNUAT = CultureHelper.GetTraduction(Convert.ToString(Detalle_Resumen_DenunciaData.Modulo_Atencion_Inicial), "Modulo_Atencion_Inicial") ??  (string)Detalle_Resumen_DenunciaData.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
                    ,Probable_Responsable = Detalle_Resumen_DenunciaData.Probable_Responsable
                    ,Delito = Detalle_Resumen_DenunciaData.Delito
                    ,Victima = Detalle_Resumen_DenunciaData.Victima
                    ,Relacion = Detalle_Resumen_DenunciaData.Relacion
                    ,Hechos = Detalle_Resumen_DenunciaData.Hechos
                    ,Generado = Detalle_Resumen_DenunciaData.Generado.GetValueOrDefault()
                    ,Archivo_Descargado = Detalle_Resumen_DenunciaData.Archivo_Descargado.GetValueOrDefault()
                    ,Fecha_de_registro = (Detalle_Resumen_DenunciaData.Fecha_de_registro == null ? string.Empty : Convert.ToDateTime(Detalle_Resumen_DenunciaData.Fecha_de_registro).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_registro = Detalle_Resumen_DenunciaData.Hora_de_registro

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IModulo_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modulo_Atencion_Inicials_Modulo_Atencion_Inicial = _IModulo_Atencion_InicialApiConsumer.SelAll(true);
            if (Modulo_Atencion_Inicials_Modulo_Atencion_Inicial != null && Modulo_Atencion_Inicials_Modulo_Atencion_Inicial.Resource != null)
                ViewBag.Modulo_Atencion_Inicials_Modulo_Atencion_Inicial = Modulo_Atencion_Inicials_Modulo_Atencion_Inicial.Resource.Where(m => m.NUAT != null).OrderBy(m => m.NUAT).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modulo_Atencion_Inicial", "NUAT") ?? m.NUAT.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varDetalle_Resumen_Denuncia);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_Resumen_Denuncia(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45620);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_Resumen_DenunciaApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_Resumen_DenunciaModel varDetalle_Resumen_Denuncia= new Detalle_Resumen_DenunciaModel();


            if (id.ToString() != "0")
            {
                var Detalle_Resumen_DenunciasData = _IDetalle_Resumen_DenunciaApiConsumer.ListaSelAll(0, 1000, "Detalle_Resumen_Denuncia.Clave=" + id, "").Resource.Detalle_Resumen_Denuncias;
				
				if (Detalle_Resumen_DenunciasData != null && Detalle_Resumen_DenunciasData.Count > 0)
                {
					var Detalle_Resumen_DenunciaData = Detalle_Resumen_DenunciasData.First();
					varDetalle_Resumen_Denuncia= new Detalle_Resumen_DenunciaModel
					{
						Clave  = Detalle_Resumen_DenunciaData.Clave 
	                    ,Modulo_Atencion_Inicial = Detalle_Resumen_DenunciaData.Modulo_Atencion_Inicial
                    ,Modulo_Atencion_InicialNUAT = CultureHelper.GetTraduction(Convert.ToString(Detalle_Resumen_DenunciaData.Modulo_Atencion_Inicial), "Modulo_Atencion_Inicial") ??  (string)Detalle_Resumen_DenunciaData.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
                    ,Probable_Responsable = Detalle_Resumen_DenunciaData.Probable_Responsable
                    ,Delito = Detalle_Resumen_DenunciaData.Delito
                    ,Victima = Detalle_Resumen_DenunciaData.Victima
                    ,Relacion = Detalle_Resumen_DenunciaData.Relacion
                    ,Hechos = Detalle_Resumen_DenunciaData.Hechos
                    ,Generado = Detalle_Resumen_DenunciaData.Generado.GetValueOrDefault()
                    ,Archivo_Descargado = Detalle_Resumen_DenunciaData.Archivo_Descargado.GetValueOrDefault()
                    ,Fecha_de_registro = (Detalle_Resumen_DenunciaData.Fecha_de_registro == null ? string.Empty : Convert.ToDateTime(Detalle_Resumen_DenunciaData.Fecha_de_registro).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_registro = Detalle_Resumen_DenunciaData.Hora_de_registro

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IModulo_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modulo_Atencion_Inicials_Modulo_Atencion_Inicial = _IModulo_Atencion_InicialApiConsumer.SelAll(true);
            if (Modulo_Atencion_Inicials_Modulo_Atencion_Inicial != null && Modulo_Atencion_Inicials_Modulo_Atencion_Inicial.Resource != null)
                ViewBag.Modulo_Atencion_Inicials_Modulo_Atencion_Inicial = Modulo_Atencion_Inicials_Modulo_Atencion_Inicial.Resource.Where(m => m.NUAT != null).OrderBy(m => m.NUAT).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modulo_Atencion_Inicial", "NUAT") ?? m.NUAT.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddDetalle_Resumen_Denuncia", varDetalle_Resumen_Denuncia);
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
        public ActionResult GetModulo_Atencion_InicialAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModulo_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IModulo_Atencion_InicialApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.NUAT).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modulo_Atencion_Inicial", "NUAT")?? m.NUAT,
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
        public ActionResult ShowAdvanceFilter(Detalle_Resumen_DenunciaAdvanceSearchModel model, int idFilter = -1)
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

            _IModulo_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modulo_Atencion_Inicials_Modulo_Atencion_Inicial = _IModulo_Atencion_InicialApiConsumer.SelAll(true);
            if (Modulo_Atencion_Inicials_Modulo_Atencion_Inicial != null && Modulo_Atencion_Inicials_Modulo_Atencion_Inicial.Resource != null)
                ViewBag.Modulo_Atencion_Inicials_Modulo_Atencion_Inicial = Modulo_Atencion_Inicials_Modulo_Atencion_Inicial.Resource.Where(m => m.NUAT != null).OrderBy(m => m.NUAT).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modulo_Atencion_Inicial", "NUAT") ?? m.NUAT.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IModulo_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modulo_Atencion_Inicials_Modulo_Atencion_Inicial = _IModulo_Atencion_InicialApiConsumer.SelAll(true);
            if (Modulo_Atencion_Inicials_Modulo_Atencion_Inicial != null && Modulo_Atencion_Inicials_Modulo_Atencion_Inicial.Resource != null)
                ViewBag.Modulo_Atencion_Inicials_Modulo_Atencion_Inicial = Modulo_Atencion_Inicials_Modulo_Atencion_Inicial.Resource.Where(m => m.NUAT != null).OrderBy(m => m.NUAT).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modulo_Atencion_Inicial", "NUAT") ?? m.NUAT.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Detalle_Resumen_DenunciaAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Detalle_Resumen_DenunciaAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Detalle_Resumen_DenunciaAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Resumen_DenunciaPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_Resumen_DenunciaApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Resumen_Denuncias == null)
                result.Detalle_Resumen_Denuncias = new List<Detalle_Resumen_Denuncia>();

            return Json(new
            {
                data = result.Detalle_Resumen_Denuncias.Select(m => new Detalle_Resumen_DenunciaGridModel
                    {
                    Clave = m.Clave
                        ,Modulo_Atencion_InicialNUAT = CultureHelper.GetTraduction(m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.Clave.ToString(), "NUAT") ?? (string)m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
			,Probable_Responsable = m.Probable_Responsable
			,Delito = m.Delito
			,Victima = m.Victima
			,Relacion = m.Relacion
			,Hechos = m.Hechos
			,Generado = m.Generado
			,Archivo_Descargado = m.Archivo_Descargado
                        ,Fecha_de_registro = (m.Fecha_de_registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_registro = m.Hora_de_registro

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetDetalle_Resumen_DenunciaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_Resumen_DenunciaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_Resumen_DenunciaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Detalle_Resumen_Denuncia", m.),
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
        /// Get List of Detalle_Resumen_Denuncia from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Detalle_Resumen_Denuncia Entity</returns>
        public ActionResult GetDetalle_Resumen_DenunciaList(UrlParametersModel param)
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
            _IDetalle_Resumen_DenunciaApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Detalle_Resumen_DenunciaPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Detalle_Resumen_DenunciaAdvanceSearchModel))
                {
					var advanceFilter =
                    (Detalle_Resumen_DenunciaAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Detalle_Resumen_DenunciaPropertyMapper oDetalle_Resumen_DenunciaPropertyMapper = new Detalle_Resumen_DenunciaPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oDetalle_Resumen_DenunciaPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IDetalle_Resumen_DenunciaApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Resumen_Denuncias == null)
                result.Detalle_Resumen_Denuncias = new List<Detalle_Resumen_Denuncia>();

            return Json(new
            {
                aaData = result.Detalle_Resumen_Denuncias.Select(m => new Detalle_Resumen_DenunciaGridModel
            {
                    Clave = m.Clave
                        ,Modulo_Atencion_InicialNUAT = CultureHelper.GetTraduction(m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.Clave.ToString(), "NUAT") ?? (string)m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
			,Probable_Responsable = m.Probable_Responsable
			,Delito = m.Delito
			,Victima = m.Victima
			,Relacion = m.Relacion
			,Hechos = m.Hechos
			,Generado = m.Generado
			,Archivo_Descargado = m.Archivo_Descargado
                        ,Fecha_de_registro = (m.Fecha_de_registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_registro = m.Hora_de_registro

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }







        [NonAction]
        public string GetAdvanceFilter(Detalle_Resumen_DenunciaAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Detalle_Resumen_Denuncia.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Detalle_Resumen_Denuncia.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceModulo_Atencion_Inicial))
            {
                switch (filter.Modulo_Atencion_InicialFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_Atencion_Inicial.NUAT LIKE '" + filter.AdvanceModulo_Atencion_Inicial + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_Atencion_Inicial.NUAT LIKE '%" + filter.AdvanceModulo_Atencion_Inicial + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_Atencion_Inicial.NUAT = '" + filter.AdvanceModulo_Atencion_Inicial + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_Atencion_Inicial.NUAT LIKE '%" + filter.AdvanceModulo_Atencion_Inicial + "%'";
                        break;
                }
            }
            else if (filter.AdvanceModulo_Atencion_InicialMultiple != null && filter.AdvanceModulo_Atencion_InicialMultiple.Count() > 0)
            {
                var Modulo_Atencion_InicialIds = string.Join(",", filter.AdvanceModulo_Atencion_InicialMultiple);

                where += " AND Detalle_Resumen_Denuncia.Modulo_Atencion_Inicial In (" + Modulo_Atencion_InicialIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Probable_Responsable))
            {
                switch (filter.Probable_ResponsableFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_Resumen_Denuncia.Probable_Responsable LIKE '" + filter.Probable_Responsable + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_Resumen_Denuncia.Probable_Responsable LIKE '%" + filter.Probable_Responsable + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_Resumen_Denuncia.Probable_Responsable = '" + filter.Probable_Responsable + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_Resumen_Denuncia.Probable_Responsable LIKE '%" + filter.Probable_Responsable + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Delito))
            {
                switch (filter.DelitoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_Resumen_Denuncia.Delito LIKE '" + filter.Delito + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_Resumen_Denuncia.Delito LIKE '%" + filter.Delito + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_Resumen_Denuncia.Delito = '" + filter.Delito + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_Resumen_Denuncia.Delito LIKE '%" + filter.Delito + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Victima))
            {
                switch (filter.VictimaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_Resumen_Denuncia.Victima LIKE '" + filter.Victima + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_Resumen_Denuncia.Victima LIKE '%" + filter.Victima + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_Resumen_Denuncia.Victima = '" + filter.Victima + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_Resumen_Denuncia.Victima LIKE '%" + filter.Victima + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Relacion))
            {
                switch (filter.RelacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_Resumen_Denuncia.Relacion LIKE '" + filter.Relacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_Resumen_Denuncia.Relacion LIKE '%" + filter.Relacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_Resumen_Denuncia.Relacion = '" + filter.Relacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_Resumen_Denuncia.Relacion LIKE '%" + filter.Relacion + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Hechos))
            {
                switch (filter.HechosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_Resumen_Denuncia.Hechos LIKE '" + filter.Hechos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_Resumen_Denuncia.Hechos LIKE '%" + filter.Hechos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_Resumen_Denuncia.Hechos = '" + filter.Hechos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_Resumen_Denuncia.Hechos LIKE '%" + filter.Hechos + "%'";
                        break;
                }
            }

            if (filter.Generado != RadioOptions.NoApply)
                where += " AND Detalle_Resumen_Denuncia.Generado = " + Convert.ToInt32(filter.Generado);

            if (filter.Archivo_Descargado != RadioOptions.NoApply)
                where += " AND Detalle_Resumen_Denuncia.Archivo_Descargado = " + Convert.ToInt32(filter.Archivo_Descargado);

            if (!string.IsNullOrEmpty(filter.FromFecha_de_registro) || !string.IsNullOrEmpty(filter.ToFecha_de_registro))
            {
                var Fecha_de_registroFrom = DateTime.ParseExact(filter.FromFecha_de_registro, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_registroTo = DateTime.ParseExact(filter.ToFecha_de_registro, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_registro))
                    where += " AND Detalle_Resumen_Denuncia.Fecha_de_registro >= '" + Fecha_de_registroFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_registro))
                    where += " AND Detalle_Resumen_Denuncia.Fecha_de_registro <= '" + Fecha_de_registroTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_registro) || !string.IsNullOrEmpty(filter.ToHora_de_registro))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_registro))
                    where += " AND Convert(TIME,Detalle_Resumen_Denuncia.Hora_de_registro) >='" + filter.FromHora_de_registro + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_registro))
                    where += " AND Convert(TIME,Detalle_Resumen_Denuncia.Hora_de_registro) <='" + filter.ToHora_de_registro + "'";
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
                _IDetalle_Resumen_DenunciaApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_Resumen_Denuncia varDetalle_Resumen_Denuncia = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IDetalle_Resumen_DenunciaApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_Resumen_DenunciaModel varDetalle_Resumen_Denuncia)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_Resumen_DenunciaApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Detalle_Resumen_DenunciaInfo = new Detalle_Resumen_Denuncia
                    {
                        Clave = varDetalle_Resumen_Denuncia.Clave
                        ,Modulo_Atencion_Inicial = varDetalle_Resumen_Denuncia.Modulo_Atencion_Inicial
                        ,Probable_Responsable = varDetalle_Resumen_Denuncia.Probable_Responsable
                        ,Delito = varDetalle_Resumen_Denuncia.Delito
                        ,Victima = varDetalle_Resumen_Denuncia.Victima
                        ,Relacion = varDetalle_Resumen_Denuncia.Relacion
                        ,Hechos = varDetalle_Resumen_Denuncia.Hechos
                        ,Generado = varDetalle_Resumen_Denuncia.Generado
                        ,Archivo_Descargado = varDetalle_Resumen_Denuncia.Archivo_Descargado
                        ,Fecha_de_registro = (!String.IsNullOrEmpty(varDetalle_Resumen_Denuncia.Fecha_de_registro)) ? DateTime.ParseExact(varDetalle_Resumen_Denuncia.Fecha_de_registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_registro = varDetalle_Resumen_Denuncia.Hora_de_registro

                    };

                    result = !IsNew ?
                        _IDetalle_Resumen_DenunciaApiConsumer.Update(Detalle_Resumen_DenunciaInfo, null, null).Resource.ToString() :
                         _IDetalle_Resumen_DenunciaApiConsumer.Insert(Detalle_Resumen_DenunciaInfo, null, null).Resource.ToString();
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
        /// Write Element Array of Detalle_Resumen_Denuncia script
        /// </summary>
        /// <param name="oDetalle_Resumen_DenunciaElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Detalle_Resumen_DenunciaModuleAttributeList)
        {
            for (int i = 0; i < Detalle_Resumen_DenunciaModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_Resumen_DenunciaModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_Resumen_DenunciaModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_Resumen_DenunciaModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_Resumen_DenunciaModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_Resumen_DenunciaModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_Resumen_DenunciaModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Detalle_Resumen_DenunciaModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Detalle_Resumen_DenunciaModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Detalle_Resumen_DenunciaModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Detalle_Resumen_DenunciaModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Detalle_Resumen_DenunciaModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strDetalle_Resumen_DenunciaScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_Resumen_Denuncia.js")))
            {
                strDetalle_Resumen_DenunciaScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_Resumen_Denuncia element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_Resumen_DenunciaModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_Resumen_DenunciaScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_Resumen_DenunciaScript.Substring(indexOfArray, strDetalle_Resumen_DenunciaScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_Resumen_DenunciaModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_Resumen_DenunciaModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_Resumen_DenunciaScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strDetalle_Resumen_DenunciaScript.Substring(indexOfArrayHistory, strDetalle_Resumen_DenunciaScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strDetalle_Resumen_DenunciaScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_Resumen_DenunciaScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_Resumen_DenunciaScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Detalle_Resumen_DenunciaModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Detalle_Resumen_DenunciaModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_Resumen_Denuncia.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_Resumen_Denuncia.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_Resumen_Denuncia.js")))
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
        public ActionResult Detalle_Resumen_DenunciaPropertyBag()
        {
            return PartialView("Detalle_Resumen_DenunciaPropertyBag", "Detalle_Resumen_Denuncia");
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
                var whereClauseFormat = "Object = 45620 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IDetalle_Resumen_DenunciaApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Detalle_Resumen_Denuncia.Clave= " + RecordId;
                            var result = _IDetalle_Resumen_DenunciaApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IDetalle_Resumen_DenunciaApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Detalle_Resumen_DenunciaPropertyMapper());
			
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
                    (Detalle_Resumen_DenunciaAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Detalle_Resumen_DenunciaPropertyMapper oDetalle_Resumen_DenunciaPropertyMapper = new Detalle_Resumen_DenunciaPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oDetalle_Resumen_DenunciaPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_Resumen_DenunciaApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Resumen_Denuncias == null)
                result.Detalle_Resumen_Denuncias = new List<Detalle_Resumen_Denuncia>();

            var data = result.Detalle_Resumen_Denuncias.Select(m => new Detalle_Resumen_DenunciaGridModel
            {
                Clave = m.Clave
                        ,Modulo_Atencion_InicialNUAT = CultureHelper.GetTraduction(m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.Clave.ToString(), "NUAT") ?? (string)m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
			,Probable_Responsable = m.Probable_Responsable
			,Delito = m.Delito
			,Victima = m.Victima
			,Relacion = m.Relacion
			,Hechos = m.Hechos
			,Generado = m.Generado
			,Archivo_Descargado = m.Archivo_Descargado
                        ,Fecha_de_registro = (m.Fecha_de_registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_registro = m.Hora_de_registro

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45620, arrayColumnsVisible), "Detalle_Resumen_DenunciaList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45620, arrayColumnsVisible), "Detalle_Resumen_DenunciaList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45620, arrayColumnsVisible), "Detalle_Resumen_DenunciaList_" + DateTime.Now.ToString());
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

            _IDetalle_Resumen_DenunciaApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Detalle_Resumen_DenunciaPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Detalle_Resumen_DenunciaAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Detalle_Resumen_DenunciaPropertyMapper oDetalle_Resumen_DenunciaPropertyMapper = new Detalle_Resumen_DenunciaPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oDetalle_Resumen_DenunciaPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_Resumen_DenunciaApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Resumen_Denuncias == null)
                result.Detalle_Resumen_Denuncias = new List<Detalle_Resumen_Denuncia>();

            var data = result.Detalle_Resumen_Denuncias.Select(m => new Detalle_Resumen_DenunciaGridModel
            {
                Clave = m.Clave
                        ,Modulo_Atencion_InicialNUAT = CultureHelper.GetTraduction(m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.Clave.ToString(), "NUAT") ?? (string)m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
			,Probable_Responsable = m.Probable_Responsable
			,Delito = m.Delito
			,Victima = m.Victima
			,Relacion = m.Relacion
			,Hechos = m.Hechos
			,Generado = m.Generado
			,Archivo_Descargado = m.Archivo_Descargado
                        ,Fecha_de_registro = (m.Fecha_de_registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_registro = m.Hora_de_registro

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
                _IDetalle_Resumen_DenunciaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_Resumen_DenunciaApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Detalle_Resumen_Denuncia_Datos_GeneralesModel varDetalle_Resumen_Denuncia)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_Resumen_DenunciaApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Detalle_Resumen_Denuncia_Datos_GeneralesInfo = new Detalle_Resumen_Denuncia_Datos_Generales
                {
                    Clave = varDetalle_Resumen_Denuncia.Clave
                                            ,Modulo_Atencion_Inicial = varDetalle_Resumen_Denuncia.Modulo_Atencion_Inicial
                        ,Probable_Responsable = varDetalle_Resumen_Denuncia.Probable_Responsable
                        ,Delito = varDetalle_Resumen_Denuncia.Delito
                        ,Victima = varDetalle_Resumen_Denuncia.Victima
                        ,Relacion = varDetalle_Resumen_Denuncia.Relacion
                        ,Hechos = varDetalle_Resumen_Denuncia.Hechos
                        ,Generado = varDetalle_Resumen_Denuncia.Generado
                        ,Archivo_Descargado = varDetalle_Resumen_Denuncia.Archivo_Descargado
                        ,Fecha_de_registro = (!String.IsNullOrEmpty(varDetalle_Resumen_Denuncia.Fecha_de_registro)) ? DateTime.ParseExact(varDetalle_Resumen_Denuncia.Fecha_de_registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_registro = varDetalle_Resumen_Denuncia.Hora_de_registro
                    
                };

                result = _IDetalle_Resumen_DenunciaApiConsumer.Update_Datos_Generales(Detalle_Resumen_Denuncia_Datos_GeneralesInfo).Resource.ToString();
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
                _IDetalle_Resumen_DenunciaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IDetalle_Resumen_DenunciaApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Detalle_Resumen_Denuncia_Datos_GeneralesModel
                {
                    Clave = m.Clave
                        ,Modulo_Atencion_Inicial = m.Modulo_Atencion_Inicial
                        ,Modulo_Atencion_InicialNUAT = CultureHelper.GetTraduction(m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.Clave.ToString(), "NUAT") ?? (string)m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
			,Probable_Responsable = m.Probable_Responsable
			,Delito = m.Delito
			,Victima = m.Victima
			,Relacion = m.Relacion
			,Hechos = m.Hechos
			,Generado = m.Generado
			,Archivo_Descargado = m.Archivo_Descargado
                        ,Fecha_de_registro = (m.Fecha_de_registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_registro = m.Hora_de_registro

                    
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

