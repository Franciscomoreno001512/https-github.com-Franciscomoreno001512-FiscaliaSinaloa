using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Jefes_de_Usuarios_del_Sistema;
using Spartane.Core.Domain.Region;
using Spartane.Core.Domain.Unidad;
using Spartane.Core.Domain.Vigencia;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Jefes_de_Usuarios_del_Sistema;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Jefes_de_Usuarios_del_Sistema;
using Spartane.Web.Areas.WebApiConsumer.Region;
using Spartane.Web.Areas.WebApiConsumer.Unidad;
using Spartane.Web.Areas.WebApiConsumer.Vigencia;

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
    public class Jefes_de_Usuarios_del_SistemaController : Controller
    {
        #region "variable declaration"

        private IJefes_de_Usuarios_del_SistemaService service = null;
        private IJefes_de_Usuarios_del_SistemaApiConsumer _IJefes_de_Usuarios_del_SistemaApiConsumer;
        private IRegionApiConsumer _IRegionApiConsumer;
        private IUnidadApiConsumer _IUnidadApiConsumer;
        private IVigenciaApiConsumer _IVigenciaApiConsumer;

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

        
        public Jefes_de_Usuarios_del_SistemaController(IJefes_de_Usuarios_del_SistemaService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IJefes_de_Usuarios_del_SistemaApiConsumer Jefes_de_Usuarios_del_SistemaApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , IRegionApiConsumer RegionApiConsumer , IUnidadApiConsumer UnidadApiConsumer , IVigenciaApiConsumer VigenciaApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IJefes_de_Usuarios_del_SistemaApiConsumer = Jefes_de_Usuarios_del_SistemaApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_FormatApiConsumer = Spartan_FormatApiConsumer;
            this._ISpartan_Format_PermissionsApiConsumer = Spartan_Format_PermissionsApiConsumer;
            this._IGeneratePDFApiConsumer = GeneratePDFApiConsumer;
			this._ISpartan_FormatRelatedApiConsumer = Spartan_Format_RelatedApiConsumer;
            this._IRegionApiConsumer = RegionApiConsumer;
            this._IUnidadApiConsumer = UnidadApiConsumer;
            this._IVigenciaApiConsumer = VigenciaApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Jefes_de_Usuarios_del_Sistema
        [ObjectAuth(ObjectId = (ModuleObjectId)45189, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45189, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Jefes_de_Usuarios_del_Sistema/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45189, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45189, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varJefes_de_Usuarios_del_Sistema = new Jefes_de_Usuarios_del_SistemaModel();
			varJefes_de_Usuarios_del_Sistema.Clave = Id;
			
            ViewBag.ObjectId = "45189";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IJefes_de_Usuarios_del_SistemaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Jefes_de_Usuarios_del_SistemasData = _IJefes_de_Usuarios_del_SistemaApiConsumer.ListaSelAll(0, 1000, "Jefes_de_Usuarios_del_Sistema.Clave=" + Id, "").Resource.Jefes_de_Usuarios_del_Sistemas;
				
				if (Jefes_de_Usuarios_del_SistemasData != null && Jefes_de_Usuarios_del_SistemasData.Count > 0)
                {
					var Jefes_de_Usuarios_del_SistemaData = Jefes_de_Usuarios_del_SistemasData.First();
					varJefes_de_Usuarios_del_Sistema= new Jefes_de_Usuarios_del_SistemaModel
					{
						Clave  = Jefes_de_Usuarios_del_SistemaData.Clave 
	                    ,Region = Jefes_de_Usuarios_del_SistemaData.Region
                    ,RegionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Jefes_de_Usuarios_del_SistemaData.Region), "Region") ??  (string)Jefes_de_Usuarios_del_SistemaData.Region_Region.Descripcion
                    ,Ministerio_Publico_en_Turno = Jefes_de_Usuarios_del_SistemaData.Ministerio_Publico_en_Turno
                    ,Unidad = Jefes_de_Usuarios_del_SistemaData.Unidad
                    ,UnidadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Jefes_de_Usuarios_del_SistemaData.Unidad), "Unidad") ??  (string)Jefes_de_Usuarios_del_SistemaData.Unidad_Unidad.Descripcion
                    ,Vigencia = Jefes_de_Usuarios_del_SistemaData.Vigencia
                    ,VigenciaAbreviacion = CultureHelper.GetTraduction(Convert.ToString(Jefes_de_Usuarios_del_SistemaData.Vigencia), "Vigencia") ??  (string)Jefes_de_Usuarios_del_SistemaData.Vigencia_Vigencia.Abreviacion
                    ,Observaciones = Jefes_de_Usuarios_del_SistemaData.Observaciones

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IRegionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Regions_Region = _IRegionApiConsumer.SelAll(true);
            if (Regions_Region != null && Regions_Region.Resource != null)
                ViewBag.Regions_Region = Regions_Region.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Region", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IUnidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Unidads_Unidad = _IUnidadApiConsumer.SelAll(true);
            if (Unidads_Unidad != null && Unidads_Unidad.Resource != null)
                ViewBag.Unidads_Unidad = Unidads_Unidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Unidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varJefes_de_Usuarios_del_Sistema);
        }
		
	[HttpGet]
        public ActionResult AddJefes_de_Usuarios_del_Sistema(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45189);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IJefes_de_Usuarios_del_SistemaApiConsumer.SetAuthHeader(_tokenManager.Token);
			Jefes_de_Usuarios_del_SistemaModel varJefes_de_Usuarios_del_Sistema= new Jefes_de_Usuarios_del_SistemaModel();


            if (id.ToString() != "0")
            {
                var Jefes_de_Usuarios_del_SistemasData = _IJefes_de_Usuarios_del_SistemaApiConsumer.ListaSelAll(0, 1000, "Jefes_de_Usuarios_del_Sistema.Clave=" + id, "").Resource.Jefes_de_Usuarios_del_Sistemas;
				
				if (Jefes_de_Usuarios_del_SistemasData != null && Jefes_de_Usuarios_del_SistemasData.Count > 0)
                {
					var Jefes_de_Usuarios_del_SistemaData = Jefes_de_Usuarios_del_SistemasData.First();
					varJefes_de_Usuarios_del_Sistema= new Jefes_de_Usuarios_del_SistemaModel
					{
						Clave  = Jefes_de_Usuarios_del_SistemaData.Clave 
	                    ,Region = Jefes_de_Usuarios_del_SistemaData.Region
                    ,RegionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Jefes_de_Usuarios_del_SistemaData.Region), "Region") ??  (string)Jefes_de_Usuarios_del_SistemaData.Region_Region.Descripcion
                    ,Ministerio_Publico_en_Turno = Jefes_de_Usuarios_del_SistemaData.Ministerio_Publico_en_Turno
                    ,Unidad = Jefes_de_Usuarios_del_SistemaData.Unidad
                    ,UnidadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Jefes_de_Usuarios_del_SistemaData.Unidad), "Unidad") ??  (string)Jefes_de_Usuarios_del_SistemaData.Unidad_Unidad.Descripcion
                    ,Vigencia = Jefes_de_Usuarios_del_SistemaData.Vigencia
                    ,VigenciaAbreviacion = CultureHelper.GetTraduction(Convert.ToString(Jefes_de_Usuarios_del_SistemaData.Vigencia), "Vigencia") ??  (string)Jefes_de_Usuarios_del_SistemaData.Vigencia_Vigencia.Abreviacion
                    ,Observaciones = Jefes_de_Usuarios_del_SistemaData.Observaciones

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IRegionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Regions_Region = _IRegionApiConsumer.SelAll(true);
            if (Regions_Region != null && Regions_Region.Resource != null)
                ViewBag.Regions_Region = Regions_Region.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Region", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IUnidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Unidads_Unidad = _IUnidadApiConsumer.SelAll(true);
            if (Unidads_Unidad != null && Unidads_Unidad.Resource != null)
                ViewBag.Unidads_Unidad = Unidads_Unidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Unidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IVigenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Vigencias_Vigencia = _IVigenciaApiConsumer.SelAll(true);
            if (Vigencias_Vigencia != null && Vigencias_Vigencia.Resource != null)
                ViewBag.Vigencias_Vigencia = Vigencias_Vigencia.Resource.Where(m => m.Abreviacion != null).OrderBy(m => m.Abreviacion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Vigencia", "Abreviacion") ?? m.Abreviacion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddJefes_de_Usuarios_del_Sistema", varJefes_de_Usuarios_del_Sistema);
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
        public ActionResult GetUnidadAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IUnidadApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IUnidadApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Unidad", "Descripcion")?? m.Descripcion,
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



        [HttpPost]
        public JsonResult ClearAdvanceFilter()
        {
            Session["AdvanceSearch"] = null;
            return Json(new { result = Session["AdvanceSearch"] == null }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult ShowAdvanceFilter(Jefes_de_Usuarios_del_SistemaAdvanceSearchModel model, int idFilter = -1)
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

            _IRegionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Regions_Region = _IRegionApiConsumer.SelAll(true);
            if (Regions_Region != null && Regions_Region.Resource != null)
                ViewBag.Regions_Region = Regions_Region.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Region", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IUnidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Unidads_Unidad = _IUnidadApiConsumer.SelAll(true);
            if (Unidads_Unidad != null && Unidads_Unidad.Resource != null)
                ViewBag.Unidads_Unidad = Unidads_Unidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Unidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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

            _IRegionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Regions_Region = _IRegionApiConsumer.SelAll(true);
            if (Regions_Region != null && Regions_Region.Resource != null)
                ViewBag.Regions_Region = Regions_Region.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Region", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IUnidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Unidads_Unidad = _IUnidadApiConsumer.SelAll(true);
            if (Unidads_Unidad != null && Unidads_Unidad.Resource != null)
                ViewBag.Unidads_Unidad = Unidads_Unidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Unidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IVigenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Vigencias_Vigencia = _IVigenciaApiConsumer.SelAll(true);
            if (Vigencias_Vigencia != null && Vigencias_Vigencia.Resource != null)
                ViewBag.Vigencias_Vigencia = Vigencias_Vigencia.Resource.Where(m => m.Abreviacion != null).OrderBy(m => m.Abreviacion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Vigencia", "Abreviacion") ?? m.Abreviacion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Jefes_de_Usuarios_del_SistemaAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Jefes_de_Usuarios_del_SistemaAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Jefes_de_Usuarios_del_SistemaAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Jefes_de_Usuarios_del_SistemaPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IJefes_de_Usuarios_del_SistemaApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Jefes_de_Usuarios_del_Sistemas == null)
                result.Jefes_de_Usuarios_del_Sistemas = new List<Jefes_de_Usuarios_del_Sistema>();

            return Json(new
            {
                data = result.Jefes_de_Usuarios_del_Sistemas.Select(m => new Jefes_de_Usuarios_del_SistemaGridModel
                    {
                    Clave = m.Clave
                        ,RegionDescripcion = CultureHelper.GetTraduction(m.Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Region_Region.Descripcion
			,Ministerio_Publico_en_Turno = m.Ministerio_Publico_en_Turno
                        ,UnidadDescripcion = CultureHelper.GetTraduction(m.Unidad_Unidad.Clave.ToString(), "Descripcion") ?? (string)m.Unidad_Unidad.Descripcion
                        ,VigenciaAbreviacion = CultureHelper.GetTraduction(m.Vigencia_Vigencia.Clave.ToString(), "Abreviacion") ?? (string)m.Vigencia_Vigencia.Abreviacion
			,Observaciones = m.Observaciones

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetJefes_de_Usuarios_del_SistemaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IJefes_de_Usuarios_del_SistemaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IJefes_de_Usuarios_del_SistemaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Jefes_de_Usuarios_del_Sistema", m.),
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
        /// Get List of Jefes_de_Usuarios_del_Sistema from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Jefes_de_Usuarios_del_Sistema Entity</returns>
        public ActionResult GetJefes_de_Usuarios_del_SistemaList(UrlParametersModel param)
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
            _IJefes_de_Usuarios_del_SistemaApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Jefes_de_Usuarios_del_SistemaPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Jefes_de_Usuarios_del_SistemaAdvanceSearchModel))
                {
					var advanceFilter =
                    (Jefes_de_Usuarios_del_SistemaAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Jefes_de_Usuarios_del_SistemaPropertyMapper oJefes_de_Usuarios_del_SistemaPropertyMapper = new Jefes_de_Usuarios_del_SistemaPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oJefes_de_Usuarios_del_SistemaPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IJefes_de_Usuarios_del_SistemaApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Jefes_de_Usuarios_del_Sistemas == null)
                result.Jefes_de_Usuarios_del_Sistemas = new List<Jefes_de_Usuarios_del_Sistema>();

            return Json(new
            {
                aaData = result.Jefes_de_Usuarios_del_Sistemas.Select(m => new Jefes_de_Usuarios_del_SistemaGridModel
            {
                    Clave = m.Clave
                        ,RegionDescripcion = CultureHelper.GetTraduction(m.Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Region_Region.Descripcion
			,Ministerio_Publico_en_Turno = m.Ministerio_Publico_en_Turno
                        ,UnidadDescripcion = CultureHelper.GetTraduction(m.Unidad_Unidad.Clave.ToString(), "Descripcion") ?? (string)m.Unidad_Unidad.Descripcion
                        ,VigenciaAbreviacion = CultureHelper.GetTraduction(m.Vigencia_Vigencia.Clave.ToString(), "Abreviacion") ?? (string)m.Vigencia_Vigencia.Abreviacion
			,Observaciones = m.Observaciones

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }







        [NonAction]
        public string GetAdvanceFilter(Jefes_de_Usuarios_del_SistemaAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Jefes_de_Usuarios_del_Sistema.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Jefes_de_Usuarios_del_Sistema.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceRegion))
            {
                switch (filter.RegionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Region.Descripcion LIKE '" + filter.AdvanceRegion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Region.Descripcion LIKE '%" + filter.AdvanceRegion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Region.Descripcion = '" + filter.AdvanceRegion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Region.Descripcion LIKE '%" + filter.AdvanceRegion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceRegionMultiple != null && filter.AdvanceRegionMultiple.Count() > 0)
            {
                var RegionIds = string.Join(",", filter.AdvanceRegionMultiple);

                where += " AND Jefes_de_Usuarios_del_Sistema.Region In (" + RegionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Ministerio_Publico_en_Turno))
            {
                switch (filter.Ministerio_Publico_en_TurnoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Jefes_de_Usuarios_del_Sistema.Ministerio_Publico_en_Turno LIKE '" + filter.Ministerio_Publico_en_Turno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Jefes_de_Usuarios_del_Sistema.Ministerio_Publico_en_Turno LIKE '%" + filter.Ministerio_Publico_en_Turno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Jefes_de_Usuarios_del_Sistema.Ministerio_Publico_en_Turno = '" + filter.Ministerio_Publico_en_Turno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Jefes_de_Usuarios_del_Sistema.Ministerio_Publico_en_Turno LIKE '%" + filter.Ministerio_Publico_en_Turno + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceUnidad))
            {
                switch (filter.UnidadFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Unidad.Descripcion LIKE '" + filter.AdvanceUnidad + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Unidad.Descripcion LIKE '%" + filter.AdvanceUnidad + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Unidad.Descripcion = '" + filter.AdvanceUnidad + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Unidad.Descripcion LIKE '%" + filter.AdvanceUnidad + "%'";
                        break;
                }
            }
            else if (filter.AdvanceUnidadMultiple != null && filter.AdvanceUnidadMultiple.Count() > 0)
            {
                var UnidadIds = string.Join(",", filter.AdvanceUnidadMultiple);

                where += " AND Jefes_de_Usuarios_del_Sistema.Unidad In (" + UnidadIds + ")";
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

                where += " AND Jefes_de_Usuarios_del_Sistema.Vigencia In (" + VigenciaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Observaciones))
            {
                switch (filter.ObservacionesFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Jefes_de_Usuarios_del_Sistema.Observaciones LIKE '" + filter.Observaciones + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Jefes_de_Usuarios_del_Sistema.Observaciones LIKE '%" + filter.Observaciones + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Jefes_de_Usuarios_del_Sistema.Observaciones = '" + filter.Observaciones + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Jefes_de_Usuarios_del_Sistema.Observaciones LIKE '%" + filter.Observaciones + "%'";
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



        [HttpDelete]
        public ActionResult Delete(int id)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IJefes_de_Usuarios_del_SistemaApiConsumer.SetAuthHeader(_tokenManager.Token);

                Jefes_de_Usuarios_del_Sistema varJefes_de_Usuarios_del_Sistema = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IJefes_de_Usuarios_del_SistemaApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Jefes_de_Usuarios_del_SistemaModel varJefes_de_Usuarios_del_Sistema)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IJefes_de_Usuarios_del_SistemaApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Jefes_de_Usuarios_del_SistemaInfo = new Jefes_de_Usuarios_del_Sistema
                    {
                        Clave = varJefes_de_Usuarios_del_Sistema.Clave
                        ,Region = varJefes_de_Usuarios_del_Sistema.Region
                        ,Ministerio_Publico_en_Turno = varJefes_de_Usuarios_del_Sistema.Ministerio_Publico_en_Turno
                        ,Unidad = varJefes_de_Usuarios_del_Sistema.Unidad
                        ,Vigencia = varJefes_de_Usuarios_del_Sistema.Vigencia
                        ,Observaciones = varJefes_de_Usuarios_del_Sistema.Observaciones

                    };

                    result = !IsNew ?
                        _IJefes_de_Usuarios_del_SistemaApiConsumer.Update(Jefes_de_Usuarios_del_SistemaInfo, null, null).Resource.ToString() :
                         _IJefes_de_Usuarios_del_SistemaApiConsumer.Insert(Jefes_de_Usuarios_del_SistemaInfo, null, null).Resource.ToString();
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
        /// Write Element Array of Jefes_de_Usuarios_del_Sistema script
        /// </summary>
        /// <param name="oJefes_de_Usuarios_del_SistemaElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Jefes_de_Usuarios_del_SistemaModuleAttributeList)
        {
            for (int i = 0; i < Jefes_de_Usuarios_del_SistemaModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Jefes_de_Usuarios_del_SistemaModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Jefes_de_Usuarios_del_SistemaModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Jefes_de_Usuarios_del_SistemaModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Jefes_de_Usuarios_del_SistemaModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Jefes_de_Usuarios_del_SistemaModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Jefes_de_Usuarios_del_SistemaModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Jefes_de_Usuarios_del_SistemaModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Jefes_de_Usuarios_del_SistemaModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Jefes_de_Usuarios_del_SistemaModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Jefes_de_Usuarios_del_SistemaModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Jefes_de_Usuarios_del_SistemaModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strJefes_de_Usuarios_del_SistemaScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Jefes_de_Usuarios_del_Sistema.js")))
            {
                strJefes_de_Usuarios_del_SistemaScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Jefes_de_Usuarios_del_Sistema element attributes
            string userChangeJson = jsSerialize.Serialize(Jefes_de_Usuarios_del_SistemaModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strJefes_de_Usuarios_del_SistemaScript.IndexOf("inpuElementArray");
            string splittedString = strJefes_de_Usuarios_del_SistemaScript.Substring(indexOfArray, strJefes_de_Usuarios_del_SistemaScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Jefes_de_Usuarios_del_SistemaModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Jefes_de_Usuarios_del_SistemaModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strJefes_de_Usuarios_del_SistemaScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strJefes_de_Usuarios_del_SistemaScript.Substring(indexOfArrayHistory, strJefes_de_Usuarios_del_SistemaScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strJefes_de_Usuarios_del_SistemaScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strJefes_de_Usuarios_del_SistemaScript.Substring(endIndexOfMainElement + indexOfArray, strJefes_de_Usuarios_del_SistemaScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Jefes_de_Usuarios_del_SistemaModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Jefes_de_Usuarios_del_SistemaModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Jefes_de_Usuarios_del_Sistema.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Jefes_de_Usuarios_del_Sistema.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Jefes_de_Usuarios_del_Sistema.js")))
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
        public ActionResult Jefes_de_Usuarios_del_SistemaPropertyBag()
        {
            return PartialView("Jefes_de_Usuarios_del_SistemaPropertyBag", "Jefes_de_Usuarios_del_Sistema");
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
                var whereClauseFormat = "Object = 45189 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IJefes_de_Usuarios_del_SistemaApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Jefes_de_Usuarios_del_Sistema.Clave= " + RecordId;
                            var result = _IJefes_de_Usuarios_del_SistemaApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IJefes_de_Usuarios_del_SistemaApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Jefes_de_Usuarios_del_SistemaPropertyMapper());
			
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
                    (Jefes_de_Usuarios_del_SistemaAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Jefes_de_Usuarios_del_SistemaPropertyMapper oJefes_de_Usuarios_del_SistemaPropertyMapper = new Jefes_de_Usuarios_del_SistemaPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oJefes_de_Usuarios_del_SistemaPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IJefes_de_Usuarios_del_SistemaApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Jefes_de_Usuarios_del_Sistemas == null)
                result.Jefes_de_Usuarios_del_Sistemas = new List<Jefes_de_Usuarios_del_Sistema>();

            var data = result.Jefes_de_Usuarios_del_Sistemas.Select(m => new Jefes_de_Usuarios_del_SistemaGridModel
            {
                Clave = m.Clave
                        ,RegionDescripcion = CultureHelper.GetTraduction(m.Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Region_Region.Descripcion
			,Ministerio_Publico_en_Turno = m.Ministerio_Publico_en_Turno
                        ,UnidadDescripcion = CultureHelper.GetTraduction(m.Unidad_Unidad.Clave.ToString(), "Descripcion") ?? (string)m.Unidad_Unidad.Descripcion
                        ,VigenciaAbreviacion = CultureHelper.GetTraduction(m.Vigencia_Vigencia.Clave.ToString(), "Abreviacion") ?? (string)m.Vigencia_Vigencia.Abreviacion
			,Observaciones = m.Observaciones

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45189, arrayColumnsVisible), "Jefes_de_Usuarios_del_SistemaList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45189, arrayColumnsVisible), "Jefes_de_Usuarios_del_SistemaList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45189, arrayColumnsVisible), "Jefes_de_Usuarios_del_SistemaList_" + DateTime.Now.ToString());
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

            _IJefes_de_Usuarios_del_SistemaApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Jefes_de_Usuarios_del_SistemaPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Jefes_de_Usuarios_del_SistemaAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Jefes_de_Usuarios_del_SistemaPropertyMapper oJefes_de_Usuarios_del_SistemaPropertyMapper = new Jefes_de_Usuarios_del_SistemaPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oJefes_de_Usuarios_del_SistemaPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IJefes_de_Usuarios_del_SistemaApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Jefes_de_Usuarios_del_Sistemas == null)
                result.Jefes_de_Usuarios_del_Sistemas = new List<Jefes_de_Usuarios_del_Sistema>();

            var data = result.Jefes_de_Usuarios_del_Sistemas.Select(m => new Jefes_de_Usuarios_del_SistemaGridModel
            {
                Clave = m.Clave
                        ,RegionDescripcion = CultureHelper.GetTraduction(m.Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Region_Region.Descripcion
			,Ministerio_Publico_en_Turno = m.Ministerio_Publico_en_Turno
                        ,UnidadDescripcion = CultureHelper.GetTraduction(m.Unidad_Unidad.Clave.ToString(), "Descripcion") ?? (string)m.Unidad_Unidad.Descripcion
                        ,VigenciaAbreviacion = CultureHelper.GetTraduction(m.Vigencia_Vigencia.Clave.ToString(), "Abreviacion") ?? (string)m.Vigencia_Vigencia.Abreviacion
			,Observaciones = m.Observaciones

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
                _IJefes_de_Usuarios_del_SistemaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IJefes_de_Usuarios_del_SistemaApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Jefes_de_Usuarios_del_Sistema_Datos_GeneralesModel varJefes_de_Usuarios_del_Sistema)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IJefes_de_Usuarios_del_SistemaApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Jefes_de_Usuarios_del_Sistema_Datos_GeneralesInfo = new Jefes_de_Usuarios_del_Sistema_Datos_Generales
                {
                    Clave = varJefes_de_Usuarios_del_Sistema.Clave
                                            ,Region = varJefes_de_Usuarios_del_Sistema.Region
                        ,Ministerio_Publico_en_Turno = varJefes_de_Usuarios_del_Sistema.Ministerio_Publico_en_Turno
                        ,Unidad = varJefes_de_Usuarios_del_Sistema.Unidad
                        ,Vigencia = varJefes_de_Usuarios_del_Sistema.Vigencia
                        ,Observaciones = varJefes_de_Usuarios_del_Sistema.Observaciones
                    
                };

                result = _IJefes_de_Usuarios_del_SistemaApiConsumer.Update_Datos_Generales(Jefes_de_Usuarios_del_Sistema_Datos_GeneralesInfo).Resource.ToString();
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
                _IJefes_de_Usuarios_del_SistemaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IJefes_de_Usuarios_del_SistemaApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Jefes_de_Usuarios_del_Sistema_Datos_GeneralesModel
                {
                    Clave = m.Clave
                        ,Region = m.Region
                        ,RegionDescripcion = CultureHelper.GetTraduction(m.Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Region_Region.Descripcion
			,Ministerio_Publico_en_Turno = m.Ministerio_Publico_en_Turno
                        ,Unidad = m.Unidad
                        ,UnidadDescripcion = CultureHelper.GetTraduction(m.Unidad_Unidad.Clave.ToString(), "Descripcion") ?? (string)m.Unidad_Unidad.Descripcion
                        ,Vigencia = m.Vigencia
                        ,VigenciaAbreviacion = CultureHelper.GetTraduction(m.Vigencia_Vigencia.Clave.ToString(), "Abreviacion") ?? (string)m.Vigencia_Vigencia.Abreviacion
			,Observaciones = m.Observaciones

                    
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

