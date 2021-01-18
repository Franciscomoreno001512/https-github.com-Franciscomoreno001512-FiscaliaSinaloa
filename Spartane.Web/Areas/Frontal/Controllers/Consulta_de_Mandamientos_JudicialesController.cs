using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales;
using Spartane.Core.Domain.Genero;
using Spartane.Core.Domain.Nacionalidad;
using Spartane.Core.Domain.Detalle_de_Resultados;





using Spartane.Core.Domain.Genero;
using Spartane.Core.Domain.Nacionalidad;


using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Consulta_de_Mandamientos_Judiciales;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Consulta_de_Mandamientos_Judiciales;
using Spartane.Web.Areas.WebApiConsumer.Genero;
using Spartane.Web.Areas.WebApiConsumer.Nacionalidad;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Resultados;


using Spartane.Web.Areas.WebApiConsumer.Genero;
using Spartane.Web.Areas.WebApiConsumer.Nacionalidad;


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
    public class Consulta_de_Mandamientos_JudicialesController : Controller
    {
        #region "variable declaration"

        private IConsulta_de_Mandamientos_JudicialesService service = null;
        private IConsulta_de_Mandamientos_JudicialesApiConsumer _IConsulta_de_Mandamientos_JudicialesApiConsumer;
        private IGeneroApiConsumer _IGeneroApiConsumer;
        private INacionalidadApiConsumer _INacionalidadApiConsumer;
        private IDetalle_de_ResultadosApiConsumer _IDetalle_de_ResultadosApiConsumer;




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

        
        public Consulta_de_Mandamientos_JudicialesController(IConsulta_de_Mandamientos_JudicialesService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IConsulta_de_Mandamientos_JudicialesApiConsumer Consulta_de_Mandamientos_JudicialesApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , IGeneroApiConsumer GeneroApiConsumer , INacionalidadApiConsumer NacionalidadApiConsumer , IDetalle_de_ResultadosApiConsumer Detalle_de_ResultadosApiConsumer  )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IConsulta_de_Mandamientos_JudicialesApiConsumer = Consulta_de_Mandamientos_JudicialesApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_FormatApiConsumer = Spartan_FormatApiConsumer;
            this._ISpartan_Format_PermissionsApiConsumer = Spartan_Format_PermissionsApiConsumer;
            this._IGeneratePDFApiConsumer = GeneratePDFApiConsumer;
			this._ISpartan_FormatRelatedApiConsumer = Spartan_Format_RelatedApiConsumer;
            this._IGeneroApiConsumer = GeneroApiConsumer;
            this._INacionalidadApiConsumer = NacionalidadApiConsumer;
            this._IDetalle_de_ResultadosApiConsumer = Detalle_de_ResultadosApiConsumer;


            this._IGeneroApiConsumer = GeneroApiConsumer;
            this._INacionalidadApiConsumer = NacionalidadApiConsumer;


        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Consulta_de_Mandamientos_Judiciales
        [ObjectAuth(ObjectId = (ModuleObjectId)45664, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45664, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Consulta_de_Mandamientos_Judiciales/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45664, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45664, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varConsulta_de_Mandamientos_Judiciales = new Consulta_de_Mandamientos_JudicialesModel();
			varConsulta_de_Mandamientos_Judiciales.Clave = Id;
			
            ViewBag.ObjectId = "45664";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;

            var permissionDetalle_de_Resultados = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45674, ModuleId);
            ViewBag.PermissionDetalle_de_Resultados = permissionDetalle_de_Resultados;


            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IConsulta_de_Mandamientos_JudicialesApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Consulta_de_Mandamientos_JudicialessData = _IConsulta_de_Mandamientos_JudicialesApiConsumer.ListaSelAll(0, 1000, "Consulta_de_Mandamientos_Judiciales.Clave=" + Id, "").Resource.Consulta_de_Mandamientos_Judicialess;
				
				if (Consulta_de_Mandamientos_JudicialessData != null && Consulta_de_Mandamientos_JudicialessData.Count > 0)
                {
					var Consulta_de_Mandamientos_JudicialesData = Consulta_de_Mandamientos_JudicialessData.First();
					varConsulta_de_Mandamientos_Judiciales= new Consulta_de_Mandamientos_JudicialesModel
					{
						Clave  = Consulta_de_Mandamientos_JudicialesData.Clave 
	                    ,Nombre = Consulta_de_Mandamientos_JudicialesData.Nombre
                    ,Apellido_Paterno = Consulta_de_Mandamientos_JudicialesData.Apellido_Paterno
                    ,Apellido_Materno = Consulta_de_Mandamientos_JudicialesData.Apellido_Materno
                    ,Fecha_de_Nacimiento = (Consulta_de_Mandamientos_JudicialesData.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(Consulta_de_Mandamientos_JudicialesData.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
                    ,Sexo = Consulta_de_Mandamientos_JudicialesData.Sexo
                    ,SexoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Consulta_de_Mandamientos_JudicialesData.Sexo), "Genero") ??  (string)Consulta_de_Mandamientos_JudicialesData.Sexo_Genero.Descripcion
                    ,Nacionalidad = Consulta_de_Mandamientos_JudicialesData.Nacionalidad
                    ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(Convert.ToString(Consulta_de_Mandamientos_JudicialesData.Nacionalidad), "Nacionalidad") ??  (string)Consulta_de_Mandamientos_JudicialesData.Nacionalidad_Nacionalidad.NacionalidadC

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Generos_Sexo = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Sexo != null && Generos_Sexo.Resource != null)
                ViewBag.Generos_Sexo = Generos_Sexo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varConsulta_de_Mandamientos_Judiciales);
        }
		
	[HttpGet]
        public ActionResult AddConsulta_de_Mandamientos_Judiciales(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45664);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IConsulta_de_Mandamientos_JudicialesApiConsumer.SetAuthHeader(_tokenManager.Token);
			Consulta_de_Mandamientos_JudicialesModel varConsulta_de_Mandamientos_Judiciales= new Consulta_de_Mandamientos_JudicialesModel();
            var permissionDetalle_de_Resultados = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45674, ModuleId);
            ViewBag.PermissionDetalle_de_Resultados = permissionDetalle_de_Resultados;


            if (id.ToString() != "0")
            {
                var Consulta_de_Mandamientos_JudicialessData = _IConsulta_de_Mandamientos_JudicialesApiConsumer.ListaSelAll(0, 1000, "Consulta_de_Mandamientos_Judiciales.Clave=" + id, "").Resource.Consulta_de_Mandamientos_Judicialess;
				
				if (Consulta_de_Mandamientos_JudicialessData != null && Consulta_de_Mandamientos_JudicialessData.Count > 0)
                {
					var Consulta_de_Mandamientos_JudicialesData = Consulta_de_Mandamientos_JudicialessData.First();
					varConsulta_de_Mandamientos_Judiciales= new Consulta_de_Mandamientos_JudicialesModel
					{
						Clave  = Consulta_de_Mandamientos_JudicialesData.Clave 
	                    ,Nombre = Consulta_de_Mandamientos_JudicialesData.Nombre
                    ,Apellido_Paterno = Consulta_de_Mandamientos_JudicialesData.Apellido_Paterno
                    ,Apellido_Materno = Consulta_de_Mandamientos_JudicialesData.Apellido_Materno
                    ,Fecha_de_Nacimiento = (Consulta_de_Mandamientos_JudicialesData.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(Consulta_de_Mandamientos_JudicialesData.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
                    ,Sexo = Consulta_de_Mandamientos_JudicialesData.Sexo
                    ,SexoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Consulta_de_Mandamientos_JudicialesData.Sexo), "Genero") ??  (string)Consulta_de_Mandamientos_JudicialesData.Sexo_Genero.Descripcion
                    ,Nacionalidad = Consulta_de_Mandamientos_JudicialesData.Nacionalidad
                    ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(Convert.ToString(Consulta_de_Mandamientos_JudicialesData.Nacionalidad), "Nacionalidad") ??  (string)Consulta_de_Mandamientos_JudicialesData.Nacionalidad_Nacionalidad.NacionalidadC

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Generos_Sexo = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Sexo != null && Generos_Sexo.Resource != null)
                ViewBag.Generos_Sexo = Generos_Sexo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddConsulta_de_Mandamientos_Judiciales", varConsulta_de_Mandamientos_Judiciales);
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
        public ActionResult GetGeneroAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IGeneroApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
		[HttpGet]
        public ActionResult GetNacionalidadAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _INacionalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _INacionalidadApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.NacionalidadC).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Nacionalidad", "NacionalidadC")?? m.NacionalidadC,
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
        public ActionResult ShowAdvanceFilter(Consulta_de_Mandamientos_JudicialesAdvanceSearchModel model, int idFilter = -1)
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

            _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Generos_Sexo = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Sexo != null && Generos_Sexo.Resource != null)
                ViewBag.Generos_Sexo = Generos_Sexo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Generos_Sexo = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Sexo != null && Generos_Sexo.Resource != null)
                ViewBag.Generos_Sexo = Generos_Sexo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Consulta_de_Mandamientos_JudicialesAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Consulta_de_Mandamientos_JudicialesAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Consulta_de_Mandamientos_JudicialesAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Consulta_de_Mandamientos_JudicialesPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IConsulta_de_Mandamientos_JudicialesApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Consulta_de_Mandamientos_Judicialess == null)
                result.Consulta_de_Mandamientos_Judicialess = new List<Consulta_de_Mandamientos_Judiciales>();

            return Json(new
            {
                data = result.Consulta_de_Mandamientos_Judicialess.Select(m => new Consulta_de_Mandamientos_JudicialesGridModel
                    {
                    Clave = m.Clave
			,Nombre = m.Nombre
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
                        ,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_Genero.Descripcion
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "Nacionalidad") ?? (string)m.Nacionalidad_Nacionalidad.NacionalidadC

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetConsulta_de_Mandamientos_JudicialesAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IConsulta_de_Mandamientos_JudicialesApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IConsulta_de_Mandamientos_JudicialesApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Consulta_de_Mandamientos_Judiciales", m.),
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
        /// Get List of Consulta_de_Mandamientos_Judiciales from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Consulta_de_Mandamientos_Judiciales Entity</returns>
        public ActionResult GetConsulta_de_Mandamientos_JudicialesList(UrlParametersModel param)
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
            _IConsulta_de_Mandamientos_JudicialesApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Consulta_de_Mandamientos_JudicialesPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Consulta_de_Mandamientos_JudicialesAdvanceSearchModel))
                {
					var advanceFilter =
                    (Consulta_de_Mandamientos_JudicialesAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Consulta_de_Mandamientos_JudicialesPropertyMapper oConsulta_de_Mandamientos_JudicialesPropertyMapper = new Consulta_de_Mandamientos_JudicialesPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oConsulta_de_Mandamientos_JudicialesPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IConsulta_de_Mandamientos_JudicialesApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Consulta_de_Mandamientos_Judicialess == null)
                result.Consulta_de_Mandamientos_Judicialess = new List<Consulta_de_Mandamientos_Judiciales>();

            return Json(new
            {
                aaData = result.Consulta_de_Mandamientos_Judicialess.Select(m => new Consulta_de_Mandamientos_JudicialesGridModel
            {
                    Clave = m.Clave
			,Nombre = m.Nombre
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
                        ,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_Genero.Descripcion
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "Nacionalidad") ?? (string)m.Nacionalidad_Nacionalidad.NacionalidadC

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetConsulta_de_Mandamientos_Judiciales_Nacionalidad_Nacionalidad(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _INacionalidadApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Nacionalidad.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Nacionalidad.NacionalidadC as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _INacionalidadApiConsumer.ListaSelAll(1, 20,elWhere , " Nacionalidad.NacionalidadC ASC ").Resource;
               
                foreach (var item in result.Nacionalidads)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Nacionalidad", "NacionalidadC");
                    item.NacionalidadC =trans ??item.NacionalidadC;
                }
                return Json(result.Nacionalidads.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
//Grid GetAutoComplete
        [HttpGet]
        public JsonResult GetDetalle_de_Resultados_Nacionalidad_Nacionalidad(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _INacionalidadApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Nacionalidad.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Nacionalidad.NacionalidadC as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _INacionalidadApiConsumer.ListaSelAll(1, 20,elWhere , " Nacionalidad.NacionalidadC ASC ").Resource;
               
                foreach (var item in result.Nacionalidads)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Nacionalidad", "NacionalidadC");
                    item.NacionalidadC =trans ??item.NacionalidadC;
                }
                return Json(result.Nacionalidads.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }






        [NonAction]
        public string GetAdvanceFilter(Consulta_de_Mandamientos_JudicialesAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Consulta_de_Mandamientos_Judiciales.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Consulta_de_Mandamientos_Judiciales.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.Nombre))
            {
                switch (filter.NombreFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Consulta_de_Mandamientos_Judiciales.Nombre LIKE '" + filter.Nombre + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Consulta_de_Mandamientos_Judiciales.Nombre LIKE '%" + filter.Nombre + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Consulta_de_Mandamientos_Judiciales.Nombre = '" + filter.Nombre + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Consulta_de_Mandamientos_Judiciales.Nombre LIKE '%" + filter.Nombre + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_Paterno))
            {
                switch (filter.Apellido_PaternoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Consulta_de_Mandamientos_Judiciales.Apellido_Paterno LIKE '" + filter.Apellido_Paterno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Consulta_de_Mandamientos_Judiciales.Apellido_Paterno LIKE '%" + filter.Apellido_Paterno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Consulta_de_Mandamientos_Judiciales.Apellido_Paterno = '" + filter.Apellido_Paterno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Consulta_de_Mandamientos_Judiciales.Apellido_Paterno LIKE '%" + filter.Apellido_Paterno + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_Materno))
            {
                switch (filter.Apellido_MaternoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Consulta_de_Mandamientos_Judiciales.Apellido_Materno LIKE '" + filter.Apellido_Materno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Consulta_de_Mandamientos_Judiciales.Apellido_Materno LIKE '%" + filter.Apellido_Materno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Consulta_de_Mandamientos_Judiciales.Apellido_Materno = '" + filter.Apellido_Materno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Consulta_de_Mandamientos_Judiciales.Apellido_Materno LIKE '%" + filter.Apellido_Materno + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Nacimiento) || !string.IsNullOrEmpty(filter.ToFecha_de_Nacimiento))
            {
                var Fecha_de_NacimientoFrom = DateTime.ParseExact(filter.FromFecha_de_Nacimiento, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_NacimientoTo = DateTime.ParseExact(filter.ToFecha_de_Nacimiento, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Nacimiento))
                    where += " AND Consulta_de_Mandamientos_Judiciales.Fecha_de_Nacimiento >= '" + Fecha_de_NacimientoFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Nacimiento))
                    where += " AND Consulta_de_Mandamientos_Judiciales.Fecha_de_Nacimiento <= '" + Fecha_de_NacimientoTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceSexo))
            {
                switch (filter.SexoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Genero.Descripcion LIKE '" + filter.AdvanceSexo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Genero.Descripcion LIKE '%" + filter.AdvanceSexo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Genero.Descripcion = '" + filter.AdvanceSexo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Genero.Descripcion LIKE '%" + filter.AdvanceSexo + "%'";
                        break;
                }
            }
            else if (filter.AdvanceSexoMultiple != null && filter.AdvanceSexoMultiple.Count() > 0)
            {
                var SexoIds = string.Join(",", filter.AdvanceSexoMultiple);

                where += " AND Consulta_de_Mandamientos_Judiciales.Sexo In (" + SexoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceNacionalidad))
            {
                switch (filter.NacionalidadFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Nacionalidad.NacionalidadC LIKE '" + filter.AdvanceNacionalidad + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Nacionalidad.NacionalidadC LIKE '%" + filter.AdvanceNacionalidad + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Nacionalidad.NacionalidadC = '" + filter.AdvanceNacionalidad + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Nacionalidad.NacionalidadC LIKE '%" + filter.AdvanceNacionalidad + "%'";
                        break;
                }
            }
            else if (filter.AdvanceNacionalidadMultiple != null && filter.AdvanceNacionalidadMultiple.Count() > 0)
            {
                var NacionalidadIds = string.Join(",", filter.AdvanceNacionalidadMultiple);

                where += " AND Consulta_de_Mandamientos_Judiciales.Nacionalidad In (" + NacionalidadIds + ")";
            }


            where = new Regex(Regex.Escape("AND ")).Replace(where, "", 1);
            return where;
        }

        [NonAction]
        public Grid_File ConvertSpartane_FileToGridFile(Spartane.Core.Domain.Spartane_File.Spartane_File file)
        {
            return file == null ? new Grid_File { FileId = 0, FileSize = 0, FileName = "" } : new Grid_File { FileId = file.File_Id, FileName = file.Description, FileSize = file.File_Size ?? 0, };
        }

        public ActionResult GetDetalle_de_Resultados(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_ResultadosGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_ResultadosApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_Resultados.Consulta_de_Ordenes=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_Resultados.Consulta_de_Ordenes='" + RelationId + "'";
            }
            var result = _IDetalle_de_ResultadosApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_Resultadoss == null)
                result.Detalle_de_Resultadoss = new List<Detalle_de_Resultados>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_Resultadoss.Select(m => new Detalle_de_ResultadosGridModel
                {
                    Clave = m.Clave

			,Nombre = m.Nombre
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Fecha_Nacimiento = (m.Fecha_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_Nacimiento).ToString(ConfigurationProperty.DateFormat))
                        ,Sexo = m.Sexo
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ??(string)m.Sexo_Genero.Descripcion
                        ,Nacionalidad = m.Nacionalidad
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "NacionalidadC") ??(string)m.Nacionalidad_Nacionalidad.NacionalidadC

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_ResultadosGridModel> GetDetalle_de_ResultadosData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_ResultadosGridModel> resultData = new List<Detalle_de_ResultadosGridModel>();
            string where = "Detalle_de_Resultados.Consulta_de_Ordenes=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_Resultados.Consulta_de_Ordenes='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_ResultadosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_ResultadosApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_Resultadoss != null)
            {
                resultData = result.Detalle_de_Resultadoss.Select(m => new Detalle_de_ResultadosGridModel
                    {
                        Clave = m.Clave

			,Nombre = m.Nombre
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Fecha_Nacimiento = (m.Fecha_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_Nacimiento).ToString(ConfigurationProperty.DateFormat))
                        ,Sexo = m.Sexo
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ??(string)m.Sexo_Genero.Descripcion
                        ,Nacionalidad = m.Nacionalidad
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "NacionalidadC") ??(string)m.Nacionalidad_Nacionalidad.NacionalidadC


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
                _IConsulta_de_Mandamientos_JudicialesApiConsumer.SetAuthHeader(_tokenManager.Token);

                Consulta_de_Mandamientos_Judiciales varConsulta_de_Mandamientos_Judiciales = null;
                if (id.ToString() != "0")
                {
                        string where = "";
                    _IDetalle_de_ResultadosApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_Resultados.Consulta_de_Ordenes=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_Resultados.Consulta_de_Ordenes='" + id + "'";
                    }
                    var Detalle_de_ResultadosInfo =
                        _IDetalle_de_ResultadosApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_ResultadosInfo.Detalle_de_Resultadoss.Count > 0)
                    {
                        var resultDetalle_de_Resultados = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_ResultadosItem in Detalle_de_ResultadosInfo.Detalle_de_Resultadoss)
                            resultDetalle_de_Resultados = resultDetalle_de_Resultados
                                              && _IDetalle_de_ResultadosApiConsumer.Delete(Detalle_de_ResultadosItem.Clave, null,null).Resource;

                        if (!resultDetalle_de_Resultados)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }

                }
                var result = _IConsulta_de_Mandamientos_JudicialesApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Consulta_de_Mandamientos_JudicialesModel varConsulta_de_Mandamientos_Judiciales)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IConsulta_de_Mandamientos_JudicialesApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Consulta_de_Mandamientos_JudicialesInfo = new Consulta_de_Mandamientos_Judiciales
                    {
                        Clave = varConsulta_de_Mandamientos_Judiciales.Clave
                        ,Nombre = varConsulta_de_Mandamientos_Judiciales.Nombre
                        ,Apellido_Paterno = varConsulta_de_Mandamientos_Judiciales.Apellido_Paterno
                        ,Apellido_Materno = varConsulta_de_Mandamientos_Judiciales.Apellido_Materno
                        ,Fecha_de_Nacimiento = (!String.IsNullOrEmpty(varConsulta_de_Mandamientos_Judiciales.Fecha_de_Nacimiento)) ? DateTime.ParseExact(varConsulta_de_Mandamientos_Judiciales.Fecha_de_Nacimiento, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Sexo = varConsulta_de_Mandamientos_Judiciales.Sexo
                        ,Nacionalidad = varConsulta_de_Mandamientos_Judiciales.Nacionalidad

                    };

                    result = !IsNew ?
                        _IConsulta_de_Mandamientos_JudicialesApiConsumer.Update(Consulta_de_Mandamientos_JudicialesInfo, null, null).Resource.ToString() :
                         _IConsulta_de_Mandamientos_JudicialesApiConsumer.Insert(Consulta_de_Mandamientos_JudicialesInfo, null, null).Resource.ToString();
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
        public bool CopyDetalle_de_Resultados(int MasterId, int referenceId, List<Detalle_de_ResultadosGridModelPost> Detalle_de_ResultadosItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_ResultadosApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_ResultadosData = _IDetalle_de_ResultadosApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_Resultados.Consulta_de_Ordenes=" + referenceId,"").Resource;
                if (Detalle_de_ResultadosData == null || Detalle_de_ResultadosData.Detalle_de_Resultadoss.Count == 0)
                    return true;

                var result = true;

                Detalle_de_ResultadosGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_Resultados in Detalle_de_ResultadosData.Detalle_de_Resultadoss)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_Resultados Detalle_de_Resultados1 = varDetalle_de_Resultados;

                    if (Detalle_de_ResultadosItems != null && Detalle_de_ResultadosItems.Any(m => m.Clave == Detalle_de_Resultados1.Clave))
                    {
                        modelDataToChange = Detalle_de_ResultadosItems.FirstOrDefault(m => m.Clave == Detalle_de_Resultados1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_de_Resultados.Consulta_de_Ordenes = MasterId;
                    var insertId = _IDetalle_de_ResultadosApiConsumer.Insert(varDetalle_de_Resultados,null,null).Resource;
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
        public ActionResult PostDetalle_de_Resultados(List<Detalle_de_ResultadosGridModelPost> Detalle_de_ResultadosItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_Resultados(MasterId, referenceId, Detalle_de_ResultadosItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_ResultadosItems != null && Detalle_de_ResultadosItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_ResultadosApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_ResultadosItem in Detalle_de_ResultadosItems)
                    {








                        //Removal Request
                        if (Detalle_de_ResultadosItem.Removed)
                        {
                            result = result && _IDetalle_de_ResultadosApiConsumer.Delete(Detalle_de_ResultadosItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_ResultadosItem.Clave = 0;

                        var Detalle_de_ResultadosData = new Detalle_de_Resultados
                        {
                            Consulta_de_Ordenes = MasterId
                            ,Clave = Detalle_de_ResultadosItem.Clave
                            ,Nombre = Detalle_de_ResultadosItem.Nombre
                            ,Apellido_Paterno = Detalle_de_ResultadosItem.Apellido_Paterno
                            ,Apellido_Materno = Detalle_de_ResultadosItem.Apellido_Materno
                            ,Fecha_Nacimiento = (Detalle_de_ResultadosItem.Fecha_Nacimiento!= null) ? DateTime.ParseExact(Detalle_de_ResultadosItem.Fecha_Nacimiento, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                            ,Sexo = (Convert.ToInt32(Detalle_de_ResultadosItem.Sexo) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_ResultadosItem.Sexo))
                            ,Nacionalidad = (Convert.ToInt32(Detalle_de_ResultadosItem.Nacionalidad) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_ResultadosItem.Nacionalidad))

                        };

                        var resultId = Detalle_de_ResultadosItem.Clave > 0
                           ? _IDetalle_de_ResultadosApiConsumer.Update(Detalle_de_ResultadosData,null,null).Resource
                           : _IDetalle_de_ResultadosApiConsumer.Insert(Detalle_de_ResultadosData,null,null).Resource;

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
        public ActionResult GetDetalle_de_Resultados_GeneroAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IGeneroApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Genero", "Descripcion");
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
        public ActionResult GetDetalle_de_Resultados_NacionalidadAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _INacionalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _INacionalidadApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
                    item.NacionalidadC= CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Nacionalidad", "NacionalidadC");
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }



        /// <summary>
        /// Write Element Array of Consulta_de_Mandamientos_Judiciales script
        /// </summary>
        /// <param name="oConsulta_de_Mandamientos_JudicialesElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Consulta_de_Mandamientos_JudicialesModuleAttributeList)
        {
            for (int i = 0; i < Consulta_de_Mandamientos_JudicialesModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Consulta_de_Mandamientos_JudicialesModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Consulta_de_Mandamientos_JudicialesModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Consulta_de_Mandamientos_JudicialesModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Consulta_de_Mandamientos_JudicialesModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Consulta_de_Mandamientos_JudicialesModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Consulta_de_Mandamientos_JudicialesModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Consulta_de_Mandamientos_JudicialesModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Consulta_de_Mandamientos_JudicialesModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Consulta_de_Mandamientos_JudicialesModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Consulta_de_Mandamientos_JudicialesModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Consulta_de_Mandamientos_JudicialesModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strConsulta_de_Mandamientos_JudicialesScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Consulta_de_Mandamientos_Judiciales.js")))
            {
                strConsulta_de_Mandamientos_JudicialesScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Consulta_de_Mandamientos_Judiciales element attributes
            string userChangeJson = jsSerialize.Serialize(Consulta_de_Mandamientos_JudicialesModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strConsulta_de_Mandamientos_JudicialesScript.IndexOf("inpuElementArray");
            string splittedString = strConsulta_de_Mandamientos_JudicialesScript.Substring(indexOfArray, strConsulta_de_Mandamientos_JudicialesScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Consulta_de_Mandamientos_JudicialesModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Consulta_de_Mandamientos_JudicialesModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strConsulta_de_Mandamientos_JudicialesScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strConsulta_de_Mandamientos_JudicialesScript.Substring(indexOfArrayHistory, strConsulta_de_Mandamientos_JudicialesScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strConsulta_de_Mandamientos_JudicialesScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strConsulta_de_Mandamientos_JudicialesScript.Substring(endIndexOfMainElement + indexOfArray, strConsulta_de_Mandamientos_JudicialesScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Consulta_de_Mandamientos_JudicialesModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Consulta_de_Mandamientos_JudicialesModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Consulta_de_Mandamientos_Judiciales.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Consulta_de_Mandamientos_Judiciales.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Consulta_de_Mandamientos_Judiciales.js")))
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
        public ActionResult Consulta_de_Mandamientos_JudicialesPropertyBag()
        {
            return PartialView("Consulta_de_Mandamientos_JudicialesPropertyBag", "Consulta_de_Mandamientos_Judiciales");
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
        public ActionResult AddDetalle_de_Resultados(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_Resultados/AddDetalle_de_Resultados");
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
                var whereClauseFormat = "Object = 45664 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IConsulta_de_Mandamientos_JudicialesApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Consulta_de_Mandamientos_Judiciales.Clave= " + RecordId;
                            var result = _IConsulta_de_Mandamientos_JudicialesApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IConsulta_de_Mandamientos_JudicialesApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Consulta_de_Mandamientos_JudicialesPropertyMapper());
			
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
                    (Consulta_de_Mandamientos_JudicialesAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Consulta_de_Mandamientos_JudicialesPropertyMapper oConsulta_de_Mandamientos_JudicialesPropertyMapper = new Consulta_de_Mandamientos_JudicialesPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oConsulta_de_Mandamientos_JudicialesPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IConsulta_de_Mandamientos_JudicialesApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Consulta_de_Mandamientos_Judicialess == null)
                result.Consulta_de_Mandamientos_Judicialess = new List<Consulta_de_Mandamientos_Judiciales>();

            var data = result.Consulta_de_Mandamientos_Judicialess.Select(m => new Consulta_de_Mandamientos_JudicialesGridModel
            {
                Clave = m.Clave
			,Nombre = m.Nombre
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
                        ,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_Genero.Descripcion
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "Nacionalidad") ?? (string)m.Nacionalidad_Nacionalidad.NacionalidadC

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45664, arrayColumnsVisible), "Consulta_de_Mandamientos_JudicialesList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45664, arrayColumnsVisible), "Consulta_de_Mandamientos_JudicialesList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45664, arrayColumnsVisible), "Consulta_de_Mandamientos_JudicialesList_" + DateTime.Now.ToString());
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

            _IConsulta_de_Mandamientos_JudicialesApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Consulta_de_Mandamientos_JudicialesPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Consulta_de_Mandamientos_JudicialesAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Consulta_de_Mandamientos_JudicialesPropertyMapper oConsulta_de_Mandamientos_JudicialesPropertyMapper = new Consulta_de_Mandamientos_JudicialesPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oConsulta_de_Mandamientos_JudicialesPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IConsulta_de_Mandamientos_JudicialesApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Consulta_de_Mandamientos_Judicialess == null)
                result.Consulta_de_Mandamientos_Judicialess = new List<Consulta_de_Mandamientos_Judiciales>();

            var data = result.Consulta_de_Mandamientos_Judicialess.Select(m => new Consulta_de_Mandamientos_JudicialesGridModel
            {
                Clave = m.Clave
			,Nombre = m.Nombre
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
                        ,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_Genero.Descripcion
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "Nacionalidad") ?? (string)m.Nacionalidad_Nacionalidad.NacionalidadC

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
                _IConsulta_de_Mandamientos_JudicialesApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IConsulta_de_Mandamientos_JudicialesApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Consulta_de_Mandamientos_Judiciales_Datos_GeneralesModel varConsulta_de_Mandamientos_Judiciales)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IConsulta_de_Mandamientos_JudicialesApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Consulta_de_Mandamientos_Judiciales_Datos_GeneralesInfo = new Consulta_de_Mandamientos_Judiciales_Datos_Generales
                {
                    Clave = varConsulta_de_Mandamientos_Judiciales.Clave
                                            ,Nombre = varConsulta_de_Mandamientos_Judiciales.Nombre
                        ,Apellido_Paterno = varConsulta_de_Mandamientos_Judiciales.Apellido_Paterno
                        ,Apellido_Materno = varConsulta_de_Mandamientos_Judiciales.Apellido_Materno
                        ,Fecha_de_Nacimiento = (!String.IsNullOrEmpty(varConsulta_de_Mandamientos_Judiciales.Fecha_de_Nacimiento)) ? DateTime.ParseExact(varConsulta_de_Mandamientos_Judiciales.Fecha_de_Nacimiento, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Sexo = varConsulta_de_Mandamientos_Judiciales.Sexo
                        ,Nacionalidad = varConsulta_de_Mandamientos_Judiciales.Nacionalidad
                    
                };

                result = _IConsulta_de_Mandamientos_JudicialesApiConsumer.Update_Datos_Generales(Consulta_de_Mandamientos_Judiciales_Datos_GeneralesInfo).Resource.ToString();
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
                _IConsulta_de_Mandamientos_JudicialesApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IConsulta_de_Mandamientos_JudicialesApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_de_Resultados;
                var Detalle_de_ResultadosData = GetDetalle_de_ResultadosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Resultados);

                var result = new Consulta_de_Mandamientos_Judiciales_Datos_GeneralesModel
                {
                    Clave = m.Clave
			,Nombre = m.Nombre
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
                        ,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
                        ,Sexo = m.Sexo
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_Genero.Descripcion
                        ,Nacionalidad = m.Nacionalidad
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "Nacionalidad") ?? (string)m.Nacionalidad_Nacionalidad.NacionalidadC

                    
                };
				var resultData = new
                {
                    data = result
                    ,Resultados = Detalle_de_ResultadosData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }


    }
}

