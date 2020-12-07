using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Generador_de_Folios;
using Spartane.Core.Domain.Tipo_de_Denuncia;
using Spartane.Core.Domain.Region;
using Spartane.Core.Domain.Unidad;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Generador_de_Folios;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Generador_de_Folios;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Denuncia;
using Spartane.Web.Areas.WebApiConsumer.Region;
using Spartane.Web.Areas.WebApiConsumer.Unidad;

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
    public class Generador_de_FoliosController : Controller
    {
        #region "variable declaration"

        private IGenerador_de_FoliosService service = null;
        private IGenerador_de_FoliosApiConsumer _IGenerador_de_FoliosApiConsumer;
        private ITipo_de_DenunciaApiConsumer _ITipo_de_DenunciaApiConsumer;
        private IRegionApiConsumer _IRegionApiConsumer;
        private IUnidadApiConsumer _IUnidadApiConsumer;

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

        
        public Generador_de_FoliosController(IGenerador_de_FoliosService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IGenerador_de_FoliosApiConsumer Generador_de_FoliosApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , ITipo_de_DenunciaApiConsumer Tipo_de_DenunciaApiConsumer , IRegionApiConsumer RegionApiConsumer , IUnidadApiConsumer UnidadApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IGenerador_de_FoliosApiConsumer = Generador_de_FoliosApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_FormatApiConsumer = Spartan_FormatApiConsumer;
            this._ISpartan_Format_PermissionsApiConsumer = Spartan_Format_PermissionsApiConsumer;
            this._IGeneratePDFApiConsumer = GeneratePDFApiConsumer;
			this._ISpartan_FormatRelatedApiConsumer = Spartan_Format_RelatedApiConsumer;
            this._ITipo_de_DenunciaApiConsumer = Tipo_de_DenunciaApiConsumer;
            this._IRegionApiConsumer = RegionApiConsumer;
            this._IUnidadApiConsumer = UnidadApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Generador_de_Folios
        [ObjectAuth(ObjectId = (ModuleObjectId)45581, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45581, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Generador_de_Folios/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45581, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45581, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varGenerador_de_Folios = new Generador_de_FoliosModel();
			varGenerador_de_Folios.Folio = Id;
			
            ViewBag.ObjectId = "45581";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IGenerador_de_FoliosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Generador_de_FoliossData = _IGenerador_de_FoliosApiConsumer.ListaSelAll(0, 1000, "Generador_de_Folios.Folio=" + Id, "").Resource.Generador_de_Folioss;
				
				if (Generador_de_FoliossData != null && Generador_de_FoliossData.Count > 0)
                {
					var Generador_de_FoliosData = Generador_de_FoliossData.First();
					varGenerador_de_Folios= new Generador_de_FoliosModel
					{
						Folio  = Generador_de_FoliosData.Folio 
	                    ,Fecha_de_Generador_de_Folio = (Generador_de_FoliosData.Fecha_de_Generador_de_Folio == null ? string.Empty : Convert.ToDateTime(Generador_de_FoliosData.Fecha_de_Generador_de_Folio).ToString(ConfigurationProperty.DateFormat))
                    ,Anio_de_Generador_de_Folio = Generador_de_FoliosData.Anio_de_Generador_de_Folio
                    ,Tipo_de_Denuncia = Generador_de_FoliosData.Tipo_de_Denuncia
                    ,Tipo_de_DenunciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Generador_de_FoliosData.Tipo_de_Denuncia), "Tipo_de_Denuncia") ??  (string)Generador_de_FoliosData.Tipo_de_Denuncia_Tipo_de_Denuncia.Descripcion
                    ,Region = Generador_de_FoliosData.Region
                    ,RegionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Generador_de_FoliosData.Region), "Region") ??  (string)Generador_de_FoliosData.Region_Region.Descripcion
                    ,Unidad = Generador_de_FoliosData.Unidad
                    ,UnidadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Generador_de_FoliosData.Unidad), "Unidad") ??  (string)Generador_de_FoliosData.Unidad_Unidad.Descripcion
                    ,Consecutivo = Generador_de_FoliosData.Consecutivo
                    ,Folio_Ultimo_Generado = Generador_de_FoliosData.Folio_Ultimo_Generado

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_DenunciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Denuncias_Tipo_de_Denuncia = _ITipo_de_DenunciaApiConsumer.SelAll(true);
            if (Tipo_de_Denuncias_Tipo_de_Denuncia != null && Tipo_de_Denuncias_Tipo_de_Denuncia.Resource != null)
                ViewBag.Tipo_de_Denuncias_Tipo_de_Denuncia = Tipo_de_Denuncias_Tipo_de_Denuncia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Denuncia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
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

				
            return View(varGenerador_de_Folios);
        }
		
	[HttpGet]
        public ActionResult AddGenerador_de_Folios(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45581);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IGenerador_de_FoliosApiConsumer.SetAuthHeader(_tokenManager.Token);
			Generador_de_FoliosModel varGenerador_de_Folios= new Generador_de_FoliosModel();


            if (id.ToString() != "0")
            {
                var Generador_de_FoliossData = _IGenerador_de_FoliosApiConsumer.ListaSelAll(0, 1000, "Generador_de_Folios.Folio=" + id, "").Resource.Generador_de_Folioss;
				
				if (Generador_de_FoliossData != null && Generador_de_FoliossData.Count > 0)
                {
					var Generador_de_FoliosData = Generador_de_FoliossData.First();
					varGenerador_de_Folios= new Generador_de_FoliosModel
					{
						Folio  = Generador_de_FoliosData.Folio 
	                    ,Fecha_de_Generador_de_Folio = (Generador_de_FoliosData.Fecha_de_Generador_de_Folio == null ? string.Empty : Convert.ToDateTime(Generador_de_FoliosData.Fecha_de_Generador_de_Folio).ToString(ConfigurationProperty.DateFormat))
                    ,Anio_de_Generador_de_Folio = Generador_de_FoliosData.Anio_de_Generador_de_Folio
                    ,Tipo_de_Denuncia = Generador_de_FoliosData.Tipo_de_Denuncia
                    ,Tipo_de_DenunciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Generador_de_FoliosData.Tipo_de_Denuncia), "Tipo_de_Denuncia") ??  (string)Generador_de_FoliosData.Tipo_de_Denuncia_Tipo_de_Denuncia.Descripcion
                    ,Region = Generador_de_FoliosData.Region
                    ,RegionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Generador_de_FoliosData.Region), "Region") ??  (string)Generador_de_FoliosData.Region_Region.Descripcion
                    ,Unidad = Generador_de_FoliosData.Unidad
                    ,UnidadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Generador_de_FoliosData.Unidad), "Unidad") ??  (string)Generador_de_FoliosData.Unidad_Unidad.Descripcion
                    ,Consecutivo = Generador_de_FoliosData.Consecutivo
                    ,Folio_Ultimo_Generado = Generador_de_FoliosData.Folio_Ultimo_Generado

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_DenunciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Denuncias_Tipo_de_Denuncia = _ITipo_de_DenunciaApiConsumer.SelAll(true);
            if (Tipo_de_Denuncias_Tipo_de_Denuncia != null && Tipo_de_Denuncias_Tipo_de_Denuncia.Resource != null)
                ViewBag.Tipo_de_Denuncias_Tipo_de_Denuncia = Tipo_de_Denuncias_Tipo_de_Denuncia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Denuncia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
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


            return PartialView("AddGenerador_de_Folios", varGenerador_de_Folios);
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
        public ActionResult GetTipo_de_DenunciaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_DenunciaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_DenunciaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Denuncia", "Descripcion")?? m.Descripcion,
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



        [HttpPost]
        public JsonResult ClearAdvanceFilter()
        {
            Session["AdvanceSearch"] = null;
            return Json(new { result = Session["AdvanceSearch"] == null }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult ShowAdvanceFilter(Generador_de_FoliosAdvanceSearchModel model, int idFilter = -1)
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

            _ITipo_de_DenunciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Denuncias_Tipo_de_Denuncia = _ITipo_de_DenunciaApiConsumer.SelAll(true);
            if (Tipo_de_Denuncias_Tipo_de_Denuncia != null && Tipo_de_Denuncias_Tipo_de_Denuncia.Resource != null)
                ViewBag.Tipo_de_Denuncias_Tipo_de_Denuncia = Tipo_de_Denuncias_Tipo_de_Denuncia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Denuncia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
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


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_DenunciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Denuncias_Tipo_de_Denuncia = _ITipo_de_DenunciaApiConsumer.SelAll(true);
            if (Tipo_de_Denuncias_Tipo_de_Denuncia != null && Tipo_de_Denuncias_Tipo_de_Denuncia.Resource != null)
                ViewBag.Tipo_de_Denuncias_Tipo_de_Denuncia = Tipo_de_Denuncias_Tipo_de_Denuncia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Denuncia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
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


            var previousFiltersObj = new Generador_de_FoliosAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Generador_de_FoliosAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Generador_de_FoliosAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Generador_de_FoliosPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IGenerador_de_FoliosApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Generador_de_Folioss == null)
                result.Generador_de_Folioss = new List<Generador_de_Folios>();

            return Json(new
            {
                data = result.Generador_de_Folioss.Select(m => new Generador_de_FoliosGridModel
                    {
                    Folio = m.Folio
                        ,Fecha_de_Generador_de_Folio = (m.Fecha_de_Generador_de_Folio == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Generador_de_Folio).ToString(ConfigurationProperty.DateFormat))
			,Anio_de_Generador_de_Folio = m.Anio_de_Generador_de_Folio
                        ,Tipo_de_DenunciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Denuncia_Tipo_de_Denuncia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Denuncia_Tipo_de_Denuncia.Descripcion
                        ,RegionDescripcion = CultureHelper.GetTraduction(m.Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Region_Region.Descripcion
                        ,UnidadDescripcion = CultureHelper.GetTraduction(m.Unidad_Unidad.Clave.ToString(), "Descripcion") ?? (string)m.Unidad_Unidad.Descripcion
			,Consecutivo = m.Consecutivo
			,Folio_Ultimo_Generado = m.Folio_Ultimo_Generado

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetGenerador_de_FoliosAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IGenerador_de_FoliosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IGenerador_de_FoliosApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Folio), "Generador_de_Folios", m.),
                     Value = Convert.ToString(m.Folio)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
*/
        /// <summary>
        /// Get List of Generador_de_Folios from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Generador_de_Folios Entity</returns>
        public ActionResult GetGenerador_de_FoliosList(UrlParametersModel param)
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
            _IGenerador_de_FoliosApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Generador_de_FoliosPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Generador_de_FoliosAdvanceSearchModel))
                {
					var advanceFilter =
                    (Generador_de_FoliosAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Generador_de_FoliosPropertyMapper oGenerador_de_FoliosPropertyMapper = new Generador_de_FoliosPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oGenerador_de_FoliosPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IGenerador_de_FoliosApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Generador_de_Folioss == null)
                result.Generador_de_Folioss = new List<Generador_de_Folios>();

            return Json(new
            {
                aaData = result.Generador_de_Folioss.Select(m => new Generador_de_FoliosGridModel
            {
                    Folio = m.Folio
                        ,Fecha_de_Generador_de_Folio = (m.Fecha_de_Generador_de_Folio == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Generador_de_Folio).ToString(ConfigurationProperty.DateFormat))
			,Anio_de_Generador_de_Folio = m.Anio_de_Generador_de_Folio
                        ,Tipo_de_DenunciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Denuncia_Tipo_de_Denuncia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Denuncia_Tipo_de_Denuncia.Descripcion
                        ,RegionDescripcion = CultureHelper.GetTraduction(m.Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Region_Region.Descripcion
                        ,UnidadDescripcion = CultureHelper.GetTraduction(m.Unidad_Unidad.Clave.ToString(), "Descripcion") ?? (string)m.Unidad_Unidad.Descripcion
			,Consecutivo = m.Consecutivo
			,Folio_Ultimo_Generado = m.Folio_Ultimo_Generado

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }







        [NonAction]
        public string GetAdvanceFilter(Generador_de_FoliosAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromFolio) || !string.IsNullOrEmpty(filter.ToFolio))
            {
                if (!string.IsNullOrEmpty(filter.FromFolio))
                    where += " AND Generador_de_Folios.Folio >= " + filter.FromFolio;
                if (!string.IsNullOrEmpty(filter.ToFolio))
                    where += " AND Generador_de_Folios.Folio <= " + filter.ToFolio;
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Generador_de_Folio) || !string.IsNullOrEmpty(filter.ToFecha_de_Generador_de_Folio))
            {
                var Fecha_de_Generador_de_FolioFrom = DateTime.ParseExact(filter.FromFecha_de_Generador_de_Folio, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_Generador_de_FolioTo = DateTime.ParseExact(filter.ToFecha_de_Generador_de_Folio, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Generador_de_Folio))
                    where += " AND Generador_de_Folios.Fecha_de_Generador_de_Folio >= '" + Fecha_de_Generador_de_FolioFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Generador_de_Folio))
                    where += " AND Generador_de_Folios.Fecha_de_Generador_de_Folio <= '" + Fecha_de_Generador_de_FolioTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromAnio_de_Generador_de_Folio) || !string.IsNullOrEmpty(filter.ToAnio_de_Generador_de_Folio))
            {
                if (!string.IsNullOrEmpty(filter.FromAnio_de_Generador_de_Folio))
                    where += " AND Generador_de_Folios.Anio_de_Generador_de_Folio >= " + filter.FromAnio_de_Generador_de_Folio;
                if (!string.IsNullOrEmpty(filter.ToAnio_de_Generador_de_Folio))
                    where += " AND Generador_de_Folios.Anio_de_Generador_de_Folio <= " + filter.ToAnio_de_Generador_de_Folio;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Denuncia))
            {
                switch (filter.Tipo_de_DenunciaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Denuncia.Descripcion LIKE '" + filter.AdvanceTipo_de_Denuncia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Denuncia.Descripcion LIKE '%" + filter.AdvanceTipo_de_Denuncia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Denuncia.Descripcion = '" + filter.AdvanceTipo_de_Denuncia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Denuncia.Descripcion LIKE '%" + filter.AdvanceTipo_de_Denuncia + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_DenunciaMultiple != null && filter.AdvanceTipo_de_DenunciaMultiple.Count() > 0)
            {
                var Tipo_de_DenunciaIds = string.Join(",", filter.AdvanceTipo_de_DenunciaMultiple);

                where += " AND Generador_de_Folios.Tipo_de_Denuncia In (" + Tipo_de_DenunciaIds + ")";
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

                where += " AND Generador_de_Folios.Region In (" + RegionIds + ")";
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

                where += " AND Generador_de_Folios.Unidad In (" + UnidadIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromConsecutivo) || !string.IsNullOrEmpty(filter.ToConsecutivo))
            {
                if (!string.IsNullOrEmpty(filter.FromConsecutivo))
                    where += " AND Generador_de_Folios.Consecutivo >= " + filter.FromConsecutivo;
                if (!string.IsNullOrEmpty(filter.ToConsecutivo))
                    where += " AND Generador_de_Folios.Consecutivo <= " + filter.ToConsecutivo;
            }

            if (!string.IsNullOrEmpty(filter.Folio_Ultimo_Generado))
            {
                switch (filter.Folio_Ultimo_GeneradoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Generador_de_Folios.Folio_Ultimo_Generado LIKE '" + filter.Folio_Ultimo_Generado + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Generador_de_Folios.Folio_Ultimo_Generado LIKE '%" + filter.Folio_Ultimo_Generado + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Generador_de_Folios.Folio_Ultimo_Generado = '" + filter.Folio_Ultimo_Generado + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Generador_de_Folios.Folio_Ultimo_Generado LIKE '%" + filter.Folio_Ultimo_Generado + "%'";
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
                _IGenerador_de_FoliosApiConsumer.SetAuthHeader(_tokenManager.Token);

                Generador_de_Folios varGenerador_de_Folios = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IGenerador_de_FoliosApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Generador_de_FoliosModel varGenerador_de_Folios)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IGenerador_de_FoliosApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Generador_de_FoliosInfo = new Generador_de_Folios
                    {
                        Folio = varGenerador_de_Folios.Folio
                        ,Fecha_de_Generador_de_Folio = (!String.IsNullOrEmpty(varGenerador_de_Folios.Fecha_de_Generador_de_Folio)) ? DateTime.ParseExact(varGenerador_de_Folios.Fecha_de_Generador_de_Folio, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Anio_de_Generador_de_Folio = varGenerador_de_Folios.Anio_de_Generador_de_Folio
                        ,Tipo_de_Denuncia = varGenerador_de_Folios.Tipo_de_Denuncia
                        ,Region = varGenerador_de_Folios.Region
                        ,Unidad = varGenerador_de_Folios.Unidad
                        ,Consecutivo = varGenerador_de_Folios.Consecutivo
                        ,Folio_Ultimo_Generado = varGenerador_de_Folios.Folio_Ultimo_Generado

                    };

                    result = !IsNew ?
                        _IGenerador_de_FoliosApiConsumer.Update(Generador_de_FoliosInfo, null, null).Resource.ToString() :
                         _IGenerador_de_FoliosApiConsumer.Insert(Generador_de_FoliosInfo, null, null).Resource.ToString();
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
        /// Write Element Array of Generador_de_Folios script
        /// </summary>
        /// <param name="oGenerador_de_FoliosElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Generador_de_FoliosModuleAttributeList)
        {
            for (int i = 0; i < Generador_de_FoliosModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Generador_de_FoliosModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Generador_de_FoliosModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Generador_de_FoliosModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Generador_de_FoliosModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Generador_de_FoliosModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Generador_de_FoliosModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Generador_de_FoliosModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Generador_de_FoliosModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Generador_de_FoliosModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Generador_de_FoliosModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Generador_de_FoliosModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strGenerador_de_FoliosScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Generador_de_Folios.js")))
            {
                strGenerador_de_FoliosScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Generador_de_Folios element attributes
            string userChangeJson = jsSerialize.Serialize(Generador_de_FoliosModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strGenerador_de_FoliosScript.IndexOf("inpuElementArray");
            string splittedString = strGenerador_de_FoliosScript.Substring(indexOfArray, strGenerador_de_FoliosScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Generador_de_FoliosModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Generador_de_FoliosModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strGenerador_de_FoliosScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strGenerador_de_FoliosScript.Substring(indexOfArrayHistory, strGenerador_de_FoliosScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strGenerador_de_FoliosScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strGenerador_de_FoliosScript.Substring(endIndexOfMainElement + indexOfArray, strGenerador_de_FoliosScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Generador_de_FoliosModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Generador_de_FoliosModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Generador_de_Folios.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Generador_de_Folios.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Generador_de_Folios.js")))
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
        public ActionResult Generador_de_FoliosPropertyBag()
        {
            return PartialView("Generador_de_FoliosPropertyBag", "Generador_de_Folios");
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
                var whereClauseFormat = "Object = 45581 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IGenerador_de_FoliosApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Generador_de_Folios.Folio= " + RecordId;
                            var result = _IGenerador_de_FoliosApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IGenerador_de_FoliosApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Generador_de_FoliosPropertyMapper());
			
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
                    (Generador_de_FoliosAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Generador_de_FoliosPropertyMapper oGenerador_de_FoliosPropertyMapper = new Generador_de_FoliosPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oGenerador_de_FoliosPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IGenerador_de_FoliosApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Generador_de_Folioss == null)
                result.Generador_de_Folioss = new List<Generador_de_Folios>();

            var data = result.Generador_de_Folioss.Select(m => new Generador_de_FoliosGridModel
            {
                Folio = m.Folio
                        ,Fecha_de_Generador_de_Folio = (m.Fecha_de_Generador_de_Folio == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Generador_de_Folio).ToString(ConfigurationProperty.DateFormat))
			,Anio_de_Generador_de_Folio = m.Anio_de_Generador_de_Folio
                        ,Tipo_de_DenunciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Denuncia_Tipo_de_Denuncia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Denuncia_Tipo_de_Denuncia.Descripcion
                        ,RegionDescripcion = CultureHelper.GetTraduction(m.Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Region_Region.Descripcion
                        ,UnidadDescripcion = CultureHelper.GetTraduction(m.Unidad_Unidad.Clave.ToString(), "Descripcion") ?? (string)m.Unidad_Unidad.Descripcion
			,Consecutivo = m.Consecutivo
			,Folio_Ultimo_Generado = m.Folio_Ultimo_Generado

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45581, arrayColumnsVisible), "Generador_de_FoliosList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45581, arrayColumnsVisible), "Generador_de_FoliosList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45581, arrayColumnsVisible), "Generador_de_FoliosList_" + DateTime.Now.ToString());
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

            _IGenerador_de_FoliosApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Generador_de_FoliosPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Generador_de_FoliosAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Generador_de_FoliosPropertyMapper oGenerador_de_FoliosPropertyMapper = new Generador_de_FoliosPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oGenerador_de_FoliosPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IGenerador_de_FoliosApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Generador_de_Folioss == null)
                result.Generador_de_Folioss = new List<Generador_de_Folios>();

            var data = result.Generador_de_Folioss.Select(m => new Generador_de_FoliosGridModel
            {
                Folio = m.Folio
                        ,Fecha_de_Generador_de_Folio = (m.Fecha_de_Generador_de_Folio == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Generador_de_Folio).ToString(ConfigurationProperty.DateFormat))
			,Anio_de_Generador_de_Folio = m.Anio_de_Generador_de_Folio
                        ,Tipo_de_DenunciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Denuncia_Tipo_de_Denuncia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Denuncia_Tipo_de_Denuncia.Descripcion
                        ,RegionDescripcion = CultureHelper.GetTraduction(m.Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Region_Region.Descripcion
                        ,UnidadDescripcion = CultureHelper.GetTraduction(m.Unidad_Unidad.Clave.ToString(), "Descripcion") ?? (string)m.Unidad_Unidad.Descripcion
			,Consecutivo = m.Consecutivo
			,Folio_Ultimo_Generado = m.Folio_Ultimo_Generado

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
                _IGenerador_de_FoliosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IGenerador_de_FoliosApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Generador_de_Folios_Datos_GeneralesModel varGenerador_de_Folios)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IGenerador_de_FoliosApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Generador_de_Folios_Datos_GeneralesInfo = new Generador_de_Folios_Datos_Generales
                {
                    Folio = varGenerador_de_Folios.Folio
                                            ,Fecha_de_Generador_de_Folio = (!String.IsNullOrEmpty(varGenerador_de_Folios.Fecha_de_Generador_de_Folio)) ? DateTime.ParseExact(varGenerador_de_Folios.Fecha_de_Generador_de_Folio, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Anio_de_Generador_de_Folio = varGenerador_de_Folios.Anio_de_Generador_de_Folio
                        ,Tipo_de_Denuncia = varGenerador_de_Folios.Tipo_de_Denuncia
                        ,Region = varGenerador_de_Folios.Region
                        ,Unidad = varGenerador_de_Folios.Unidad
                        ,Consecutivo = varGenerador_de_Folios.Consecutivo
                        ,Folio_Ultimo_Generado = varGenerador_de_Folios.Folio_Ultimo_Generado
                    
                };

                result = _IGenerador_de_FoliosApiConsumer.Update_Datos_Generales(Generador_de_Folios_Datos_GeneralesInfo).Resource.ToString();
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
                _IGenerador_de_FoliosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IGenerador_de_FoliosApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Generador_de_Folios_Datos_GeneralesModel
                {
                    Folio = m.Folio
                        ,Fecha_de_Generador_de_Folio = (m.Fecha_de_Generador_de_Folio == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Generador_de_Folio).ToString(ConfigurationProperty.DateFormat))
			,Anio_de_Generador_de_Folio = m.Anio_de_Generador_de_Folio
                        ,Tipo_de_Denuncia = m.Tipo_de_Denuncia
                        ,Tipo_de_DenunciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Denuncia_Tipo_de_Denuncia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Denuncia_Tipo_de_Denuncia.Descripcion
                        ,Region = m.Region
                        ,RegionDescripcion = CultureHelper.GetTraduction(m.Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Region_Region.Descripcion
                        ,Unidad = m.Unidad
                        ,UnidadDescripcion = CultureHelper.GetTraduction(m.Unidad_Unidad.Clave.ToString(), "Descripcion") ?? (string)m.Unidad_Unidad.Descripcion
			,Consecutivo = m.Consecutivo
			,Folio_Ultimo_Generado = m.Folio_Ultimo_Generado

                    
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

