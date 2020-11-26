using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Unidad;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Region;
using Spartane.Core.Domain.Vigencia;
using Spartane.Core.Domain.Spartan_User;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Unidad;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Unidad;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Region;
using Spartane.Web.Areas.WebApiConsumer.Vigencia;
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
    public class UnidadController : Controller
    {
        #region "variable declaration"

        private IUnidadService service = null;
        private IUnidadApiConsumer _IUnidadApiConsumer;
        private IMunicipioApiConsumer _IMunicipioApiConsumer;
        private IRegionApiConsumer _IRegionApiConsumer;
        private IVigenciaApiConsumer _IVigenciaApiConsumer;
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

        
        public UnidadController(IUnidadService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IUnidadApiConsumer UnidadApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , IMunicipioApiConsumer MunicipioApiConsumer , IRegionApiConsumer RegionApiConsumer , IVigenciaApiConsumer VigenciaApiConsumer , ISpartan_UserApiConsumer Spartan_UserApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IUnidadApiConsumer = UnidadApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_FormatApiConsumer = Spartan_FormatApiConsumer;
            this._ISpartan_Format_PermissionsApiConsumer = Spartan_Format_PermissionsApiConsumer;
            this._IGeneratePDFApiConsumer = GeneratePDFApiConsumer;
			this._ISpartan_FormatRelatedApiConsumer = Spartan_Format_RelatedApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IRegionApiConsumer = RegionApiConsumer;
            this._IVigenciaApiConsumer = VigenciaApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Unidad
        [ObjectAuth(ObjectId = (ModuleObjectId)45256, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45256, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Unidad/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45256, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45256, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varUnidad = new UnidadModel();
			varUnidad.Clave = Id;
			
            ViewBag.ObjectId = "45256";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IUnidadApiConsumer.SetAuthHeader(_tokenManager.Token);
                var UnidadsData = _IUnidadApiConsumer.ListaSelAll(0, 1000, "Unidad.Clave=" + Id, "").Resource.Unidads;
				
				if (UnidadsData != null && UnidadsData.Count > 0)
                {
					var UnidadData = UnidadsData.First();
					varUnidad= new UnidadModel
					{
						Clave  = UnidadData.Clave 
	                    ,Clave_Unica_Municipio = UnidadData.Clave_Unica_Municipio
                    ,Clave_de_Municipio = UnidadData.Clave_de_Municipio
                    ,Clave_de_MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(UnidadData.Clave_de_Municipio), "Municipio") ??  (string)UnidadData.Clave_de_Municipio_Municipio.Nombre
                    ,Clave_de_Region = UnidadData.Clave_de_Region
                    ,Clave_de_RegionDescripcion = CultureHelper.GetTraduction(Convert.ToString(UnidadData.Clave_de_Region), "Region") ??  (string)UnidadData.Clave_de_Region_Region.Descripcion
                    ,Abreviacion = UnidadData.Abreviacion
                    ,Descripcion = UnidadData.Descripcion
                    ,Descripcion_Corta = UnidadData.Descripcion_Corta
                    ,Vigencia = UnidadData.Vigencia
                    ,VigenciaAbreviacion = CultureHelper.GetTraduction(Convert.ToString(UnidadData.Vigencia), "Vigencia") ??  (string)UnidadData.Vigencia_Vigencia.Abreviacion
                    ,Direccion = UnidadData.Direccion
                    ,Observaciones = UnidadData.Observaciones
                    ,Supervisor = UnidadData.Supervisor
                    ,SupervisorName = CultureHelper.GetTraduction(Convert.ToString(UnidadData.Supervisor), "Spartan_User") ??  (string)UnidadData.Supervisor_Spartan_User.Name
                    ,Consecutivo_CDI = UnidadData.Consecutivo_CDI

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Clave_de_Municipio = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Clave_de_Municipio != null && Municipios_Clave_de_Municipio.Resource != null)
                ViewBag.Municipios_Clave_de_Municipio = Municipios_Clave_de_Municipio.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IRegionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Regions_Clave_de_Region = _IRegionApiConsumer.SelAll(true);
            if (Regions_Clave_de_Region != null && Regions_Clave_de_Region.Resource != null)
                ViewBag.Regions_Clave_de_Region = Regions_Clave_de_Region.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Region", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IVigenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Vigencias_Vigencia = _IVigenciaApiConsumer.SelAll(true);
            if (Vigencias_Vigencia != null && Vigencias_Vigencia.Resource != null)
                ViewBag.Vigencias_Vigencia = Vigencias_Vigencia.Resource.Where(m => m.Abreviacion != null).OrderBy(m => m.Abreviacion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Vigencia", "Abreviacion") ?? m.Abreviacion.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varUnidad);
        }
		
	[HttpGet]
        public ActionResult AddUnidad(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45256);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IUnidadApiConsumer.SetAuthHeader(_tokenManager.Token);
			UnidadModel varUnidad= new UnidadModel();


            if (id.ToString() != "0")
            {
                var UnidadsData = _IUnidadApiConsumer.ListaSelAll(0, 1000, "Unidad.Clave=" + id, "").Resource.Unidads;
				
				if (UnidadsData != null && UnidadsData.Count > 0)
                {
					var UnidadData = UnidadsData.First();
					varUnidad= new UnidadModel
					{
						Clave  = UnidadData.Clave 
	                    ,Clave_Unica_Municipio = UnidadData.Clave_Unica_Municipio
                    ,Clave_de_Municipio = UnidadData.Clave_de_Municipio
                    ,Clave_de_MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(UnidadData.Clave_de_Municipio), "Municipio") ??  (string)UnidadData.Clave_de_Municipio_Municipio.Nombre
                    ,Clave_de_Region = UnidadData.Clave_de_Region
                    ,Clave_de_RegionDescripcion = CultureHelper.GetTraduction(Convert.ToString(UnidadData.Clave_de_Region), "Region") ??  (string)UnidadData.Clave_de_Region_Region.Descripcion
                    ,Abreviacion = UnidadData.Abreviacion
                    ,Descripcion = UnidadData.Descripcion
                    ,Descripcion_Corta = UnidadData.Descripcion_Corta
                    ,Vigencia = UnidadData.Vigencia
                    ,VigenciaAbreviacion = CultureHelper.GetTraduction(Convert.ToString(UnidadData.Vigencia), "Vigencia") ??  (string)UnidadData.Vigencia_Vigencia.Abreviacion
                    ,Direccion = UnidadData.Direccion
                    ,Observaciones = UnidadData.Observaciones
                    ,Supervisor = UnidadData.Supervisor
                    ,SupervisorName = CultureHelper.GetTraduction(Convert.ToString(UnidadData.Supervisor), "Spartan_User") ??  (string)UnidadData.Supervisor_Spartan_User.Name
                    ,Consecutivo_CDI = UnidadData.Consecutivo_CDI

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Clave_de_Municipio = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Clave_de_Municipio != null && Municipios_Clave_de_Municipio.Resource != null)
                ViewBag.Municipios_Clave_de_Municipio = Municipios_Clave_de_Municipio.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IRegionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Regions_Clave_de_Region = _IRegionApiConsumer.SelAll(true);
            if (Regions_Clave_de_Region != null && Regions_Clave_de_Region.Resource != null)
                ViewBag.Regions_Clave_de_Region = Regions_Clave_de_Region.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Region", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IVigenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Vigencias_Vigencia = _IVigenciaApiConsumer.SelAll(true);
            if (Vigencias_Vigencia != null && Vigencias_Vigencia.Resource != null)
                ViewBag.Vigencias_Vigencia = Vigencias_Vigencia.Resource.Where(m => m.Abreviacion != null).OrderBy(m => m.Abreviacion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Vigencia", "Abreviacion") ?? m.Abreviacion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddUnidad", varUnidad);
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
        public ActionResult GetMunicipioAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IMunicipioApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre")?? m.Nombre,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetRegionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRegionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IRegionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Region", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetVigenciaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IVigenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IVigenciaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Abreviacion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Vigencia", "Abreviacion")?? m.Abreviacion,
                    Value = Convert.ToString(m.Clave)
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
        public ActionResult ShowAdvanceFilter(UnidadAdvanceSearchModel model, int idFilter = -1)
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

            _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Clave_de_Municipio = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Clave_de_Municipio != null && Municipios_Clave_de_Municipio.Resource != null)
                ViewBag.Municipios_Clave_de_Municipio = Municipios_Clave_de_Municipio.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IRegionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Regions_Clave_de_Region = _IRegionApiConsumer.SelAll(true);
            if (Regions_Clave_de_Region != null && Regions_Clave_de_Region.Resource != null)
                ViewBag.Regions_Clave_de_Region = Regions_Clave_de_Region.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Region", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IVigenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Vigencias_Vigencia = _IVigenciaApiConsumer.SelAll(true);
            if (Vigencias_Vigencia != null && Vigencias_Vigencia.Resource != null)
                ViewBag.Vigencias_Vigencia = Vigencias_Vigencia.Resource.Where(m => m.Abreviacion != null).OrderBy(m => m.Abreviacion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Vigencia", "Abreviacion") ?? m.Abreviacion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Clave_de_Municipio = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Clave_de_Municipio != null && Municipios_Clave_de_Municipio.Resource != null)
                ViewBag.Municipios_Clave_de_Municipio = Municipios_Clave_de_Municipio.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IRegionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Regions_Clave_de_Region = _IRegionApiConsumer.SelAll(true);
            if (Regions_Clave_de_Region != null && Regions_Clave_de_Region.Resource != null)
                ViewBag.Regions_Clave_de_Region = Regions_Clave_de_Region.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Region", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IVigenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Vigencias_Vigencia = _IVigenciaApiConsumer.SelAll(true);
            if (Vigencias_Vigencia != null && Vigencias_Vigencia.Resource != null)
                ViewBag.Vigencias_Vigencia = Vigencias_Vigencia.Resource.Where(m => m.Abreviacion != null).OrderBy(m => m.Abreviacion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Vigencia", "Abreviacion") ?? m.Abreviacion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new UnidadAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (UnidadAdvanceSearchModel)(Session["AdvanceSearch"] ?? new UnidadAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new UnidadPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IUnidadApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Unidads == null)
                result.Unidads = new List<Unidad>();

            return Json(new
            {
                data = result.Unidads.Select(m => new UnidadGridModel
                    {
                    Clave = m.Clave
			,Clave_Unica_Municipio = m.Clave_Unica_Municipio
                        ,Clave_de_MunicipioNombre = CultureHelper.GetTraduction(m.Clave_de_Municipio_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Clave_de_Municipio_Municipio.Nombre
                        ,Clave_de_RegionDescripcion = CultureHelper.GetTraduction(m.Clave_de_Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Clave_de_Region_Region.Descripcion
			,Abreviacion = m.Abreviacion
			,Descripcion = m.Descripcion
			,Descripcion_Corta = m.Descripcion_Corta
                        ,VigenciaAbreviacion = CultureHelper.GetTraduction(m.Vigencia_Vigencia.Clave.ToString(), "Abreviacion") ?? (string)m.Vigencia_Vigencia.Abreviacion
			,Direccion = m.Direccion
			,Observaciones = m.Observaciones
                        ,SupervisorName = CultureHelper.GetTraduction(m.Supervisor_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Supervisor_Spartan_User.Name
			,Consecutivo_CDI = m.Consecutivo_CDI

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetUnidadAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IUnidadApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IUnidadApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Unidad", m.),
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
        /// Get List of Unidad from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Unidad Entity</returns>
        public ActionResult GetUnidadList(UrlParametersModel param)
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
            _IUnidadApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new UnidadPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(UnidadAdvanceSearchModel))
                {
					var advanceFilter =
                    (UnidadAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            UnidadPropertyMapper oUnidadPropertyMapper = new UnidadPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oUnidadPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IUnidadApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Unidads == null)
                result.Unidads = new List<Unidad>();

            return Json(new
            {
                aaData = result.Unidads.Select(m => new UnidadGridModel
            {
                    Clave = m.Clave
			,Clave_Unica_Municipio = m.Clave_Unica_Municipio
                        ,Clave_de_MunicipioNombre = CultureHelper.GetTraduction(m.Clave_de_Municipio_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Clave_de_Municipio_Municipio.Nombre
                        ,Clave_de_RegionDescripcion = CultureHelper.GetTraduction(m.Clave_de_Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Clave_de_Region_Region.Descripcion
			,Abreviacion = m.Abreviacion
			,Descripcion = m.Descripcion
			,Descripcion_Corta = m.Descripcion_Corta
                        ,VigenciaAbreviacion = CultureHelper.GetTraduction(m.Vigencia_Vigencia.Clave.ToString(), "Abreviacion") ?? (string)m.Vigencia_Vigencia.Abreviacion
			,Direccion = m.Direccion
			,Observaciones = m.Observaciones
                        ,SupervisorName = CultureHelper.GetTraduction(m.Supervisor_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Supervisor_Spartan_User.Name
			,Consecutivo_CDI = m.Consecutivo_CDI

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetUnidad_Supervisor_Spartan_User(string query, string where)
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
        public string GetAdvanceFilter(UnidadAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Unidad.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Unidad.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.FromClave_Unica_Municipio) || !string.IsNullOrEmpty(filter.ToClave_Unica_Municipio))
            {
                if (!string.IsNullOrEmpty(filter.FromClave_Unica_Municipio))
                    where += " AND Unidad.Clave_Unica_Municipio >= " + filter.FromClave_Unica_Municipio;
                if (!string.IsNullOrEmpty(filter.ToClave_Unica_Municipio))
                    where += " AND Unidad.Clave_Unica_Municipio <= " + filter.ToClave_Unica_Municipio;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceClave_de_Municipio))
            {
                switch (filter.Clave_de_MunicipioFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Municipio.Nombre LIKE '" + filter.AdvanceClave_de_Municipio + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceClave_de_Municipio + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Municipio.Nombre = '" + filter.AdvanceClave_de_Municipio + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceClave_de_Municipio + "%'";
                        break;
                }
            }
            else if (filter.AdvanceClave_de_MunicipioMultiple != null && filter.AdvanceClave_de_MunicipioMultiple.Count() > 0)
            {
                var Clave_de_MunicipioIds = string.Join(",", filter.AdvanceClave_de_MunicipioMultiple);

                where += " AND Unidad.Clave_de_Municipio In (" + Clave_de_MunicipioIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceClave_de_Region))
            {
                switch (filter.Clave_de_RegionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Region.Descripcion LIKE '" + filter.AdvanceClave_de_Region + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Region.Descripcion LIKE '%" + filter.AdvanceClave_de_Region + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Region.Descripcion = '" + filter.AdvanceClave_de_Region + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Region.Descripcion LIKE '%" + filter.AdvanceClave_de_Region + "%'";
                        break;
                }
            }
            else if (filter.AdvanceClave_de_RegionMultiple != null && filter.AdvanceClave_de_RegionMultiple.Count() > 0)
            {
                var Clave_de_RegionIds = string.Join(",", filter.AdvanceClave_de_RegionMultiple);

                where += " AND Unidad.Clave_de_Region In (" + Clave_de_RegionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Abreviacion))
            {
                switch (filter.AbreviacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Unidad.Abreviacion LIKE '" + filter.Abreviacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Unidad.Abreviacion LIKE '%" + filter.Abreviacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Unidad.Abreviacion = '" + filter.Abreviacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Unidad.Abreviacion LIKE '%" + filter.Abreviacion + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Descripcion))
            {
                switch (filter.DescripcionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Unidad.Descripcion LIKE '" + filter.Descripcion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Unidad.Descripcion LIKE '%" + filter.Descripcion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Unidad.Descripcion = '" + filter.Descripcion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Unidad.Descripcion LIKE '%" + filter.Descripcion + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Descripcion_Corta))
            {
                switch (filter.Descripcion_CortaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Unidad.Descripcion_Corta LIKE '" + filter.Descripcion_Corta + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Unidad.Descripcion_Corta LIKE '%" + filter.Descripcion_Corta + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Unidad.Descripcion_Corta = '" + filter.Descripcion_Corta + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Unidad.Descripcion_Corta LIKE '%" + filter.Descripcion_Corta + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceVigencia))
            {
                switch (filter.VigenciaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Vigencia.Abreviacion LIKE '" + filter.AdvanceVigencia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Vigencia.Abreviacion LIKE '%" + filter.AdvanceVigencia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Vigencia.Abreviacion = '" + filter.AdvanceVigencia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Vigencia.Abreviacion LIKE '%" + filter.AdvanceVigencia + "%'";
                        break;
                }
            }
            else if (filter.AdvanceVigenciaMultiple != null && filter.AdvanceVigenciaMultiple.Count() > 0)
            {
                var VigenciaIds = string.Join(",", filter.AdvanceVigenciaMultiple);

                where += " AND Unidad.Vigencia In (" + VigenciaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Direccion))
            {
                switch (filter.DireccionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Unidad.Direccion LIKE '" + filter.Direccion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Unidad.Direccion LIKE '%" + filter.Direccion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Unidad.Direccion = '" + filter.Direccion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Unidad.Direccion LIKE '%" + filter.Direccion + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Observaciones))
            {
                switch (filter.ObservacionesFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Unidad.Observaciones LIKE '" + filter.Observaciones + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Unidad.Observaciones LIKE '%" + filter.Observaciones + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Unidad.Observaciones = '" + filter.Observaciones + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Unidad.Observaciones LIKE '%" + filter.Observaciones + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceSupervisor))
            {
                switch (filter.SupervisorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_User.Name LIKE '" + filter.AdvanceSupervisor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceSupervisor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_User.Name = '" + filter.AdvanceSupervisor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceSupervisor + "%'";
                        break;
                }
            }
            else if (filter.AdvanceSupervisorMultiple != null && filter.AdvanceSupervisorMultiple.Count() > 0)
            {
                var SupervisorIds = string.Join(",", filter.AdvanceSupervisorMultiple);

                where += " AND Unidad.Supervisor In (" + SupervisorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromConsecutivo_CDI) || !string.IsNullOrEmpty(filter.ToConsecutivo_CDI))
            {
                if (!string.IsNullOrEmpty(filter.FromConsecutivo_CDI))
                    where += " AND Unidad.Consecutivo_CDI >= " + filter.FromConsecutivo_CDI;
                if (!string.IsNullOrEmpty(filter.ToConsecutivo_CDI))
                    where += " AND Unidad.Consecutivo_CDI <= " + filter.ToConsecutivo_CDI;
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
                _IUnidadApiConsumer.SetAuthHeader(_tokenManager.Token);

                Unidad varUnidad = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IUnidadApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, UnidadModel varUnidad)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IUnidadApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var UnidadInfo = new Unidad
                    {
                        Clave = varUnidad.Clave
                        ,Clave_Unica_Municipio = varUnidad.Clave_Unica_Municipio
                        ,Clave_de_Municipio = varUnidad.Clave_de_Municipio
                        ,Clave_de_Region = varUnidad.Clave_de_Region
                        ,Abreviacion = varUnidad.Abreviacion
                        ,Descripcion = varUnidad.Descripcion
                        ,Descripcion_Corta = varUnidad.Descripcion_Corta
                        ,Vigencia = varUnidad.Vigencia
                        ,Direccion = varUnidad.Direccion
                        ,Observaciones = varUnidad.Observaciones
                        ,Supervisor = varUnidad.Supervisor
                        ,Consecutivo_CDI = varUnidad.Consecutivo_CDI

                    };

                    result = !IsNew ?
                        _IUnidadApiConsumer.Update(UnidadInfo, null, null).Resource.ToString() :
                         _IUnidadApiConsumer.Insert(UnidadInfo, null, null).Resource.ToString();
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
        /// Write Element Array of Unidad script
        /// </summary>
        /// <param name="oUnidadElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew UnidadModuleAttributeList)
        {
            for (int i = 0; i < UnidadModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(UnidadModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    UnidadModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(UnidadModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    UnidadModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (UnidadModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < UnidadModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < UnidadModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(UnidadModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							UnidadModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(UnidadModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							UnidadModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strUnidadScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Unidad.js")))
            {
                strUnidadScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Unidad element attributes
            string userChangeJson = jsSerialize.Serialize(UnidadModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strUnidadScript.IndexOf("inpuElementArray");
            string splittedString = strUnidadScript.Substring(indexOfArray, strUnidadScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(UnidadModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (UnidadModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strUnidadScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strUnidadScript.Substring(indexOfArrayHistory, strUnidadScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strUnidadScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strUnidadScript.Substring(endIndexOfMainElement + indexOfArray, strUnidadScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (UnidadModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in UnidadModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Unidad.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Unidad.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Unidad.js")))
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
        public ActionResult UnidadPropertyBag()
        {
            return PartialView("UnidadPropertyBag", "Unidad");
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
                var whereClauseFormat = "Object = 45256 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IUnidadApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Unidad.Clave= " + RecordId;
                            var result = _IUnidadApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IUnidadApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new UnidadPropertyMapper());
			
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
                    (UnidadAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            UnidadPropertyMapper oUnidadPropertyMapper = new UnidadPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oUnidadPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IUnidadApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Unidads == null)
                result.Unidads = new List<Unidad>();

            var data = result.Unidads.Select(m => new UnidadGridModel
            {
                Clave = m.Clave
			,Clave_Unica_Municipio = m.Clave_Unica_Municipio
                        ,Clave_de_MunicipioNombre = CultureHelper.GetTraduction(m.Clave_de_Municipio_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Clave_de_Municipio_Municipio.Nombre
                        ,Clave_de_RegionDescripcion = CultureHelper.GetTraduction(m.Clave_de_Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Clave_de_Region_Region.Descripcion
			,Abreviacion = m.Abreviacion
			,Descripcion = m.Descripcion
			,Descripcion_Corta = m.Descripcion_Corta
                        ,VigenciaAbreviacion = CultureHelper.GetTraduction(m.Vigencia_Vigencia.Clave.ToString(), "Abreviacion") ?? (string)m.Vigencia_Vigencia.Abreviacion
			,Direccion = m.Direccion
			,Observaciones = m.Observaciones
                        ,SupervisorName = CultureHelper.GetTraduction(m.Supervisor_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Supervisor_Spartan_User.Name
			,Consecutivo_CDI = m.Consecutivo_CDI

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45256, arrayColumnsVisible), "UnidadList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45256, arrayColumnsVisible), "UnidadList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45256, arrayColumnsVisible), "UnidadList_" + DateTime.Now.ToString());
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

            _IUnidadApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new UnidadPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (UnidadAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            UnidadPropertyMapper oUnidadPropertyMapper = new UnidadPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oUnidadPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IUnidadApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Unidads == null)
                result.Unidads = new List<Unidad>();

            var data = result.Unidads.Select(m => new UnidadGridModel
            {
                Clave = m.Clave
			,Clave_Unica_Municipio = m.Clave_Unica_Municipio
                        ,Clave_de_MunicipioNombre = CultureHelper.GetTraduction(m.Clave_de_Municipio_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Clave_de_Municipio_Municipio.Nombre
                        ,Clave_de_RegionDescripcion = CultureHelper.GetTraduction(m.Clave_de_Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Clave_de_Region_Region.Descripcion
			,Abreviacion = m.Abreviacion
			,Descripcion = m.Descripcion
			,Descripcion_Corta = m.Descripcion_Corta
                        ,VigenciaAbreviacion = CultureHelper.GetTraduction(m.Vigencia_Vigencia.Clave.ToString(), "Abreviacion") ?? (string)m.Vigencia_Vigencia.Abreviacion
			,Direccion = m.Direccion
			,Observaciones = m.Observaciones
                        ,SupervisorName = CultureHelper.GetTraduction(m.Supervisor_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Supervisor_Spartan_User.Name
			,Consecutivo_CDI = m.Consecutivo_CDI

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
                _IUnidadApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IUnidadApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Unidad_Datos_GeneralesModel varUnidad)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IUnidadApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Unidad_Datos_GeneralesInfo = new Unidad_Datos_Generales
                {
                    Clave = varUnidad.Clave
                                            ,Clave_Unica_Municipio = varUnidad.Clave_Unica_Municipio
                        ,Clave_de_Municipio = varUnidad.Clave_de_Municipio
                        ,Clave_de_Region = varUnidad.Clave_de_Region
                        ,Abreviacion = varUnidad.Abreviacion
                        ,Descripcion = varUnidad.Descripcion
                        ,Descripcion_Corta = varUnidad.Descripcion_Corta
                        ,Vigencia = varUnidad.Vigencia
                        ,Direccion = varUnidad.Direccion
                        ,Observaciones = varUnidad.Observaciones
                        ,Supervisor = varUnidad.Supervisor
                        ,Consecutivo_CDI = varUnidad.Consecutivo_CDI
                    
                };

                result = _IUnidadApiConsumer.Update_Datos_Generales(Unidad_Datos_GeneralesInfo).Resource.ToString();
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
                _IUnidadApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IUnidadApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Unidad_Datos_GeneralesModel
                {
                    Clave = m.Clave
			,Clave_Unica_Municipio = m.Clave_Unica_Municipio
                        ,Clave_de_Municipio = m.Clave_de_Municipio
                        ,Clave_de_MunicipioNombre = CultureHelper.GetTraduction(m.Clave_de_Municipio_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Clave_de_Municipio_Municipio.Nombre
                        ,Clave_de_Region = m.Clave_de_Region
                        ,Clave_de_RegionDescripcion = CultureHelper.GetTraduction(m.Clave_de_Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Clave_de_Region_Region.Descripcion
			,Abreviacion = m.Abreviacion
			,Descripcion = m.Descripcion
			,Descripcion_Corta = m.Descripcion_Corta
                        ,Vigencia = m.Vigencia
                        ,VigenciaAbreviacion = CultureHelper.GetTraduction(m.Vigencia_Vigencia.Clave.ToString(), "Abreviacion") ?? (string)m.Vigencia_Vigencia.Abreviacion
			,Direccion = m.Direccion
			,Observaciones = m.Observaciones
                        ,Supervisor = m.Supervisor
                        ,SupervisorName = CultureHelper.GetTraduction(m.Supervisor_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Supervisor_Spartan_User.Name
			,Consecutivo_CDI = m.Consecutivo_CDI

                    
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

