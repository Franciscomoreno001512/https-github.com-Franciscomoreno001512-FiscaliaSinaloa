﻿using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Configuracion_de_Servicios_de_Apoyo;
using Spartane.Core.Domain.Region;
using Spartane.Core.Domain.Area_de_Servicios_de_Apoyo;
using Spartane.Core.Domain.SubArea_de_Servicios_de_Apoyo;
using Spartane.Core.Domain.Detalle_Solicitud_Disponibles_Configuracion;

using Spartane.Core.Domain.Documento;


using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Configuracion_de_Servicios_de_Apoyo;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Configuracion_de_Servicios_de_Apoyo;
using Spartane.Web.Areas.WebApiConsumer.Region;
using Spartane.Web.Areas.WebApiConsumer.Area_de_Servicios_de_Apoyo;
using Spartane.Web.Areas.WebApiConsumer.SubArea_de_Servicios_de_Apoyo;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Solicitud_Disponibles_Configuracion;

using Spartane.Web.Areas.WebApiConsumer.Documento;


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
    public class Configuracion_de_Servicios_de_ApoyoController : Controller
    {
        #region "variable declaration"

        private IConfiguracion_de_Servicios_de_ApoyoService service = null;
        private IConfiguracion_de_Servicios_de_ApoyoApiConsumer _IConfiguracion_de_Servicios_de_ApoyoApiConsumer;
        private IRegionApiConsumer _IRegionApiConsumer;
        private IArea_de_Servicios_de_ApoyoApiConsumer _IArea_de_Servicios_de_ApoyoApiConsumer;
        private ISubArea_de_Servicios_de_ApoyoApiConsumer _ISubArea_de_Servicios_de_ApoyoApiConsumer;
        private IDetalle_Solicitud_Disponibles_ConfiguracionApiConsumer _IDetalle_Solicitud_Disponibles_ConfiguracionApiConsumer;

        private IDocumentoApiConsumer _IDocumentoApiConsumer;


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

        
        public Configuracion_de_Servicios_de_ApoyoController(IConfiguracion_de_Servicios_de_ApoyoService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IConfiguracion_de_Servicios_de_ApoyoApiConsumer Configuracion_de_Servicios_de_ApoyoApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , IRegionApiConsumer RegionApiConsumer , IArea_de_Servicios_de_ApoyoApiConsumer Area_de_Servicios_de_ApoyoApiConsumer , ISubArea_de_Servicios_de_ApoyoApiConsumer SubArea_de_Servicios_de_ApoyoApiConsumer , IDetalle_Solicitud_Disponibles_ConfiguracionApiConsumer Detalle_Solicitud_Disponibles_ConfiguracionApiConsumer , IDocumentoApiConsumer DocumentoApiConsumer  )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IConfiguracion_de_Servicios_de_ApoyoApiConsumer = Configuracion_de_Servicios_de_ApoyoApiConsumer;
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
            this._IArea_de_Servicios_de_ApoyoApiConsumer = Area_de_Servicios_de_ApoyoApiConsumer;
            this._ISubArea_de_Servicios_de_ApoyoApiConsumer = SubArea_de_Servicios_de_ApoyoApiConsumer;
            this._IDetalle_Solicitud_Disponibles_ConfiguracionApiConsumer = Detalle_Solicitud_Disponibles_ConfiguracionApiConsumer;

            this._IDocumentoApiConsumer = DocumentoApiConsumer;


        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Configuracion_de_Servicios_de_Apoyo
        [ObjectAuth(ObjectId = (ModuleObjectId)46223, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 46223, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Configuracion_de_Servicios_de_Apoyo/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)46223, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 46223, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varConfiguracion_de_Servicios_de_Apoyo = new Configuracion_de_Servicios_de_ApoyoModel();
			varConfiguracion_de_Servicios_de_Apoyo.Clave = Id;
			
            ViewBag.ObjectId = "46223";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;

            var permissionDetalle_Solicitud_Disponibles_Configuracion = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 46225, ModuleId);
            ViewBag.PermissionDetalle_Solicitud_Disponibles_Configuracion = permissionDetalle_Solicitud_Disponibles_Configuracion;


            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IConfiguracion_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Configuracion_de_Servicios_de_ApoyosData = _IConfiguracion_de_Servicios_de_ApoyoApiConsumer.ListaSelAll(0, 1000, "Configuracion_de_Servicios_de_Apoyo.Clave=" + Id, "").Resource.Configuracion_de_Servicios_de_Apoyos;
				
				if (Configuracion_de_Servicios_de_ApoyosData != null && Configuracion_de_Servicios_de_ApoyosData.Count > 0)
                {
					var Configuracion_de_Servicios_de_ApoyoData = Configuracion_de_Servicios_de_ApoyosData.First();
					varConfiguracion_de_Servicios_de_Apoyo= new Configuracion_de_Servicios_de_ApoyoModel
					{
						Clave  = Configuracion_de_Servicios_de_ApoyoData.Clave 
	                    ,Region = Configuracion_de_Servicios_de_ApoyoData.Region
                    ,RegionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Configuracion_de_Servicios_de_ApoyoData.Region), "Region") ??  (string)Configuracion_de_Servicios_de_ApoyoData.Region_Region.Descripcion
                    ,Area = Configuracion_de_Servicios_de_ApoyoData.Area
                    ,AreaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Configuracion_de_Servicios_de_ApoyoData.Area), "Area_de_Servicios_de_Apoyo") ??  (string)Configuracion_de_Servicios_de_ApoyoData.Area_Area_de_Servicios_de_Apoyo.Descripcion
                    ,SubArea = Configuracion_de_Servicios_de_ApoyoData.SubArea
                    ,SubAreaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Configuracion_de_Servicios_de_ApoyoData.SubArea), "SubArea_de_Servicios_de_Apoyo") ??  (string)Configuracion_de_Servicios_de_ApoyoData.SubArea_SubArea_de_Servicios_de_Apoyo.Descripcion
                    ,Acreditada = Configuracion_de_Servicios_de_ApoyoData.Acreditada.GetValueOrDefault()
                    ,Centralizada = Configuracion_de_Servicios_de_ApoyoData.Centralizada.GetValueOrDefault()

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
            _IArea_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Area_de_Servicios_de_Apoyos_Area = _IArea_de_Servicios_de_ApoyoApiConsumer.SelAll(true);
            if (Area_de_Servicios_de_Apoyos_Area != null && Area_de_Servicios_de_Apoyos_Area.Resource != null)
                ViewBag.Area_de_Servicios_de_Apoyos_Area = Area_de_Servicios_de_Apoyos_Area.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Area_de_Servicios_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISubArea_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var SubArea_de_Servicios_de_Apoyos_SubArea = _ISubArea_de_Servicios_de_ApoyoApiConsumer.SelAll(true);
            if (SubArea_de_Servicios_de_Apoyos_SubArea != null && SubArea_de_Servicios_de_Apoyos_SubArea.Resource != null)
                ViewBag.SubArea_de_Servicios_de_Apoyos_SubArea = SubArea_de_Servicios_de_Apoyos_SubArea.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "SubArea_de_Servicios_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varConfiguracion_de_Servicios_de_Apoyo);
        }
		
	[HttpGet]
        public ActionResult AddConfiguracion_de_Servicios_de_Apoyo(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 46223);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IConfiguracion_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
			Configuracion_de_Servicios_de_ApoyoModel varConfiguracion_de_Servicios_de_Apoyo= new Configuracion_de_Servicios_de_ApoyoModel();
            var permissionDetalle_Solicitud_Disponibles_Configuracion = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 46225, ModuleId);
            ViewBag.PermissionDetalle_Solicitud_Disponibles_Configuracion = permissionDetalle_Solicitud_Disponibles_Configuracion;


            if (id.ToString() != "0")
            {
                var Configuracion_de_Servicios_de_ApoyosData = _IConfiguracion_de_Servicios_de_ApoyoApiConsumer.ListaSelAll(0, 1000, "Configuracion_de_Servicios_de_Apoyo.Clave=" + id, "").Resource.Configuracion_de_Servicios_de_Apoyos;
				
				if (Configuracion_de_Servicios_de_ApoyosData != null && Configuracion_de_Servicios_de_ApoyosData.Count > 0)
                {
					var Configuracion_de_Servicios_de_ApoyoData = Configuracion_de_Servicios_de_ApoyosData.First();
					varConfiguracion_de_Servicios_de_Apoyo= new Configuracion_de_Servicios_de_ApoyoModel
					{
						Clave  = Configuracion_de_Servicios_de_ApoyoData.Clave 
	                    ,Region = Configuracion_de_Servicios_de_ApoyoData.Region
                    ,RegionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Configuracion_de_Servicios_de_ApoyoData.Region), "Region") ??  (string)Configuracion_de_Servicios_de_ApoyoData.Region_Region.Descripcion
                    ,Area = Configuracion_de_Servicios_de_ApoyoData.Area
                    ,AreaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Configuracion_de_Servicios_de_ApoyoData.Area), "Area_de_Servicios_de_Apoyo") ??  (string)Configuracion_de_Servicios_de_ApoyoData.Area_Area_de_Servicios_de_Apoyo.Descripcion
                    ,SubArea = Configuracion_de_Servicios_de_ApoyoData.SubArea
                    ,SubAreaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Configuracion_de_Servicios_de_ApoyoData.SubArea), "SubArea_de_Servicios_de_Apoyo") ??  (string)Configuracion_de_Servicios_de_ApoyoData.SubArea_SubArea_de_Servicios_de_Apoyo.Descripcion
                    ,Acreditada = Configuracion_de_Servicios_de_ApoyoData.Acreditada.GetValueOrDefault()
                    ,Centralizada = Configuracion_de_Servicios_de_ApoyoData.Centralizada.GetValueOrDefault()

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
            _IArea_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Area_de_Servicios_de_Apoyos_Area = _IArea_de_Servicios_de_ApoyoApiConsumer.SelAll(true);
            if (Area_de_Servicios_de_Apoyos_Area != null && Area_de_Servicios_de_Apoyos_Area.Resource != null)
                ViewBag.Area_de_Servicios_de_Apoyos_Area = Area_de_Servicios_de_Apoyos_Area.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Area_de_Servicios_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISubArea_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var SubArea_de_Servicios_de_Apoyos_SubArea = _ISubArea_de_Servicios_de_ApoyoApiConsumer.SelAll(true);
            if (SubArea_de_Servicios_de_Apoyos_SubArea != null && SubArea_de_Servicios_de_Apoyos_SubArea.Resource != null)
                ViewBag.SubArea_de_Servicios_de_Apoyos_SubArea = SubArea_de_Servicios_de_Apoyos_SubArea.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "SubArea_de_Servicios_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddConfiguracion_de_Servicios_de_Apoyo", varConfiguracion_de_Servicios_de_Apoyo);
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
        public ActionResult GetArea_de_Servicios_de_ApoyoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IArea_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IArea_de_Servicios_de_ApoyoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Area_de_Servicios_de_Apoyo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetSubArea_de_Servicios_de_ApoyoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISubArea_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISubArea_de_Servicios_de_ApoyoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "SubArea_de_Servicios_de_Apoyo", "Descripcion")?? m.Descripcion,
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
        public ActionResult ShowAdvanceFilter(Configuracion_de_Servicios_de_ApoyoAdvanceSearchModel model, int idFilter = -1)
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
            _IArea_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Area_de_Servicios_de_Apoyos_Area = _IArea_de_Servicios_de_ApoyoApiConsumer.SelAll(true);
            if (Area_de_Servicios_de_Apoyos_Area != null && Area_de_Servicios_de_Apoyos_Area.Resource != null)
                ViewBag.Area_de_Servicios_de_Apoyos_Area = Area_de_Servicios_de_Apoyos_Area.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Area_de_Servicios_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISubArea_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var SubArea_de_Servicios_de_Apoyos_SubArea = _ISubArea_de_Servicios_de_ApoyoApiConsumer.SelAll(true);
            if (SubArea_de_Servicios_de_Apoyos_SubArea != null && SubArea_de_Servicios_de_Apoyos_SubArea.Resource != null)
                ViewBag.SubArea_de_Servicios_de_Apoyos_SubArea = SubArea_de_Servicios_de_Apoyos_SubArea.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "SubArea_de_Servicios_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _IArea_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Area_de_Servicios_de_Apoyos_Area = _IArea_de_Servicios_de_ApoyoApiConsumer.SelAll(true);
            if (Area_de_Servicios_de_Apoyos_Area != null && Area_de_Servicios_de_Apoyos_Area.Resource != null)
                ViewBag.Area_de_Servicios_de_Apoyos_Area = Area_de_Servicios_de_Apoyos_Area.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Area_de_Servicios_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISubArea_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var SubArea_de_Servicios_de_Apoyos_SubArea = _ISubArea_de_Servicios_de_ApoyoApiConsumer.SelAll(true);
            if (SubArea_de_Servicios_de_Apoyos_SubArea != null && SubArea_de_Servicios_de_Apoyos_SubArea.Resource != null)
                ViewBag.SubArea_de_Servicios_de_Apoyos_SubArea = SubArea_de_Servicios_de_Apoyos_SubArea.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "SubArea_de_Servicios_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Configuracion_de_Servicios_de_ApoyoAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Configuracion_de_Servicios_de_ApoyoAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Configuracion_de_Servicios_de_ApoyoAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Configuracion_de_Servicios_de_ApoyoPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IConfiguracion_de_Servicios_de_ApoyoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Configuracion_de_Servicios_de_Apoyos == null)
                result.Configuracion_de_Servicios_de_Apoyos = new List<Configuracion_de_Servicios_de_Apoyo>();

            return Json(new
            {
                data = result.Configuracion_de_Servicios_de_Apoyos.Select(m => new Configuracion_de_Servicios_de_ApoyoGridModel
                    {
                    Clave = m.Clave
                        ,RegionDescripcion = CultureHelper.GetTraduction(m.Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Region_Region.Descripcion
                        ,AreaDescripcion = CultureHelper.GetTraduction(m.Area_Area_de_Servicios_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.Area_Area_de_Servicios_de_Apoyo.Descripcion
                        ,SubAreaDescripcion = CultureHelper.GetTraduction(m.SubArea_SubArea_de_Servicios_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.SubArea_SubArea_de_Servicios_de_Apoyo.Descripcion
			,Acreditada = m.Acreditada
			,Centralizada = m.Centralizada

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetConfiguracion_de_Servicios_de_ApoyoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IConfiguracion_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IConfiguracion_de_Servicios_de_ApoyoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Configuracion_de_Servicios_de_Apoyo", m.),
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
        /// Get List of Configuracion_de_Servicios_de_Apoyo from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Configuracion_de_Servicios_de_Apoyo Entity</returns>
        public ActionResult GetConfiguracion_de_Servicios_de_ApoyoList(UrlParametersModel param)
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
            _IConfiguracion_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Configuracion_de_Servicios_de_ApoyoPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Configuracion_de_Servicios_de_ApoyoAdvanceSearchModel))
                {
					var advanceFilter =
                    (Configuracion_de_Servicios_de_ApoyoAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Configuracion_de_Servicios_de_ApoyoPropertyMapper oConfiguracion_de_Servicios_de_ApoyoPropertyMapper = new Configuracion_de_Servicios_de_ApoyoPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oConfiguracion_de_Servicios_de_ApoyoPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IConfiguracion_de_Servicios_de_ApoyoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Configuracion_de_Servicios_de_Apoyos == null)
                result.Configuracion_de_Servicios_de_Apoyos = new List<Configuracion_de_Servicios_de_Apoyo>();

            return Json(new
            {
                aaData = result.Configuracion_de_Servicios_de_Apoyos.Select(m => new Configuracion_de_Servicios_de_ApoyoGridModel
            {
                    Clave = m.Clave
                        ,RegionDescripcion = CultureHelper.GetTraduction(m.Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Region_Region.Descripcion
                        ,AreaDescripcion = CultureHelper.GetTraduction(m.Area_Area_de_Servicios_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.Area_Area_de_Servicios_de_Apoyo.Descripcion
                        ,SubAreaDescripcion = CultureHelper.GetTraduction(m.SubArea_SubArea_de_Servicios_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.SubArea_SubArea_de_Servicios_de_Apoyo.Descripcion
			,Acreditada = m.Acreditada
			,Centralizada = m.Centralizada

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


//Grid GetAutoComplete
        [HttpGet]
        public JsonResult GetDetalle_Solicitud_Disponibles_Configuracion_Documento_Documento(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Documento.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Documento.Descripcion as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IDocumentoApiConsumer.ListaSelAll(1, 20,elWhere , " Documento.Descripcion ASC ").Resource;
               
                foreach (var item in result.Documentos)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Documento", "Descripcion");
                    item.Descripcion =trans ??item.Descripcion;
                }
                return Json(result.Documentos.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }






        [NonAction]
        public string GetAdvanceFilter(Configuracion_de_Servicios_de_ApoyoAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Configuracion_de_Servicios_de_Apoyo.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Configuracion_de_Servicios_de_Apoyo.Clave <= " + filter.ToClave;
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

                where += " AND Configuracion_de_Servicios_de_Apoyo.Region In (" + RegionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceArea))
            {
                switch (filter.AreaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Area_de_Servicios_de_Apoyo.Descripcion LIKE '" + filter.AdvanceArea + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Area_de_Servicios_de_Apoyo.Descripcion LIKE '%" + filter.AdvanceArea + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Area_de_Servicios_de_Apoyo.Descripcion = '" + filter.AdvanceArea + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Area_de_Servicios_de_Apoyo.Descripcion LIKE '%" + filter.AdvanceArea + "%'";
                        break;
                }
            }
            else if (filter.AdvanceAreaMultiple != null && filter.AdvanceAreaMultiple.Count() > 0)
            {
                var AreaIds = string.Join(",", filter.AdvanceAreaMultiple);

                where += " AND Configuracion_de_Servicios_de_Apoyo.Area In (" + AreaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceSubArea))
            {
                switch (filter.SubAreaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND SubArea_de_Servicios_de_Apoyo.Descripcion LIKE '" + filter.AdvanceSubArea + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND SubArea_de_Servicios_de_Apoyo.Descripcion LIKE '%" + filter.AdvanceSubArea + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND SubArea_de_Servicios_de_Apoyo.Descripcion = '" + filter.AdvanceSubArea + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND SubArea_de_Servicios_de_Apoyo.Descripcion LIKE '%" + filter.AdvanceSubArea + "%'";
                        break;
                }
            }
            else if (filter.AdvanceSubAreaMultiple != null && filter.AdvanceSubAreaMultiple.Count() > 0)
            {
                var SubAreaIds = string.Join(",", filter.AdvanceSubAreaMultiple);

                where += " AND Configuracion_de_Servicios_de_Apoyo.SubArea In (" + SubAreaIds + ")";
            }

            if (filter.Acreditada != RadioOptions.NoApply)
                where += " AND Configuracion_de_Servicios_de_Apoyo.Acreditada = " + Convert.ToInt32(filter.Acreditada);

            if (filter.Centralizada != RadioOptions.NoApply)
                where += " AND Configuracion_de_Servicios_de_Apoyo.Centralizada = " + Convert.ToInt32(filter.Centralizada);


            where = new Regex(Regex.Escape("AND ")).Replace(where, "", 1);
            return where;
        }

        [NonAction]
        public Grid_File ConvertSpartane_FileToGridFile(Spartane.Core.Domain.Spartane_File.Spartane_File file)
        {
            return file == null ? new Grid_File { FileId = 0, FileSize = 0, FileName = "" } : new Grid_File { FileId = file.File_Id, FileName = file.Description, FileSize = file.File_Size ?? 0, };
        }

        public ActionResult GetDetalle_Solicitud_Disponibles_Configuracion(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_Solicitud_Disponibles_ConfiguracionGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Solicitud_Disponibles_ConfiguracionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_Solicitud_Disponibles_Configuracion.Configuracion=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_Solicitud_Disponibles_Configuracion.Configuracion='" + RelationId + "'";
            }
            var result = _IDetalle_Solicitud_Disponibles_ConfiguracionApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_Solicitud_Disponibles_Configuracions == null)
                result.Detalle_Solicitud_Disponibles_Configuracions = new List<Detalle_Solicitud_Disponibles_Configuracion>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_Solicitud_Disponibles_Configuracions.Select(m => new Detalle_Solicitud_Disponibles_ConfiguracionGridModel
                {
                    Clave = m.Clave

                        ,Documento = m.Documento
                        ,DocumentoDescripcion = CultureHelper.GetTraduction(m.Documento_Documento.Clave.ToString(), "Descripcion") ??(string)m.Documento_Documento.Descripcion

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_Solicitud_Disponibles_ConfiguracionGridModel> GetDetalle_Solicitud_Disponibles_ConfiguracionData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_Solicitud_Disponibles_ConfiguracionGridModel> resultData = new List<Detalle_Solicitud_Disponibles_ConfiguracionGridModel>();
            string where = "Detalle_Solicitud_Disponibles_Configuracion.Configuracion=" + Id;
            if("int" == "string")
            {
                where = "Detalle_Solicitud_Disponibles_Configuracion.Configuracion='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Solicitud_Disponibles_ConfiguracionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_Solicitud_Disponibles_ConfiguracionApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_Solicitud_Disponibles_Configuracions != null)
            {
                resultData = result.Detalle_Solicitud_Disponibles_Configuracions.Select(m => new Detalle_Solicitud_Disponibles_ConfiguracionGridModel
                    {
                        Clave = m.Clave

                        ,Documento = m.Documento
                        ,DocumentoDescripcion = CultureHelper.GetTraduction(m.Documento_Documento.Clave.ToString(), "Descripcion") ??(string)m.Documento_Documento.Descripcion


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
                _IConfiguracion_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);

                Configuracion_de_Servicios_de_Apoyo varConfiguracion_de_Servicios_de_Apoyo = null;
                if (id.ToString() != "0")
                {
                        string where = "";
                    _IDetalle_Solicitud_Disponibles_ConfiguracionApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_Solicitud_Disponibles_Configuracion.Configuracion=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_Solicitud_Disponibles_Configuracion.Configuracion='" + id + "'";
                    }
                    var Detalle_Solicitud_Disponibles_ConfiguracionInfo =
                        _IDetalle_Solicitud_Disponibles_ConfiguracionApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_Solicitud_Disponibles_ConfiguracionInfo.Detalle_Solicitud_Disponibles_Configuracions.Count > 0)
                    {
                        var resultDetalle_Solicitud_Disponibles_Configuracion = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_Solicitud_Disponibles_ConfiguracionItem in Detalle_Solicitud_Disponibles_ConfiguracionInfo.Detalle_Solicitud_Disponibles_Configuracions)
                            resultDetalle_Solicitud_Disponibles_Configuracion = resultDetalle_Solicitud_Disponibles_Configuracion
                                              && _IDetalle_Solicitud_Disponibles_ConfiguracionApiConsumer.Delete(Detalle_Solicitud_Disponibles_ConfiguracionItem.Clave, null,null).Resource;

                        if (!resultDetalle_Solicitud_Disponibles_Configuracion)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }

                }
                var result = _IConfiguracion_de_Servicios_de_ApoyoApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Configuracion_de_Servicios_de_ApoyoModel varConfiguracion_de_Servicios_de_Apoyo)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IConfiguracion_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Configuracion_de_Servicios_de_ApoyoInfo = new Configuracion_de_Servicios_de_Apoyo
                    {
                        Clave = varConfiguracion_de_Servicios_de_Apoyo.Clave
                        ,Region = varConfiguracion_de_Servicios_de_Apoyo.Region
                        ,Area = varConfiguracion_de_Servicios_de_Apoyo.Area
                        ,SubArea = varConfiguracion_de_Servicios_de_Apoyo.SubArea
                        ,Acreditada = varConfiguracion_de_Servicios_de_Apoyo.Acreditada
                        ,Centralizada = varConfiguracion_de_Servicios_de_Apoyo.Centralizada

                    };

                    result = !IsNew ?
                        _IConfiguracion_de_Servicios_de_ApoyoApiConsumer.Update(Configuracion_de_Servicios_de_ApoyoInfo, null, null).Resource.ToString() :
                         _IConfiguracion_de_Servicios_de_ApoyoApiConsumer.Insert(Configuracion_de_Servicios_de_ApoyoInfo, null, null).Resource.ToString();
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
        public bool CopyDetalle_Solicitud_Disponibles_Configuracion(int MasterId, int referenceId, List<Detalle_Solicitud_Disponibles_ConfiguracionGridModelPost> Detalle_Solicitud_Disponibles_ConfiguracionItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_Solicitud_Disponibles_ConfiguracionApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_Solicitud_Disponibles_ConfiguracionData = _IDetalle_Solicitud_Disponibles_ConfiguracionApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_Solicitud_Disponibles_Configuracion.Configuracion=" + referenceId,"").Resource;
                if (Detalle_Solicitud_Disponibles_ConfiguracionData == null || Detalle_Solicitud_Disponibles_ConfiguracionData.Detalle_Solicitud_Disponibles_Configuracions.Count == 0)
                    return true;

                var result = true;

                Detalle_Solicitud_Disponibles_ConfiguracionGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_Solicitud_Disponibles_Configuracion in Detalle_Solicitud_Disponibles_ConfiguracionData.Detalle_Solicitud_Disponibles_Configuracions)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_Solicitud_Disponibles_Configuracion Detalle_Solicitud_Disponibles_Configuracion1 = varDetalle_Solicitud_Disponibles_Configuracion;

                    if (Detalle_Solicitud_Disponibles_ConfiguracionItems != null && Detalle_Solicitud_Disponibles_ConfiguracionItems.Any(m => m.Clave == Detalle_Solicitud_Disponibles_Configuracion1.Clave))
                    {
                        modelDataToChange = Detalle_Solicitud_Disponibles_ConfiguracionItems.FirstOrDefault(m => m.Clave == Detalle_Solicitud_Disponibles_Configuracion1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_Solicitud_Disponibles_Configuracion.Configuracion = MasterId;
                    var insertId = _IDetalle_Solicitud_Disponibles_ConfiguracionApiConsumer.Insert(varDetalle_Solicitud_Disponibles_Configuracion,null,null).Resource;
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
        public ActionResult PostDetalle_Solicitud_Disponibles_Configuracion(List<Detalle_Solicitud_Disponibles_ConfiguracionGridModelPost> Detalle_Solicitud_Disponibles_ConfiguracionItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_Solicitud_Disponibles_Configuracion(MasterId, referenceId, Detalle_Solicitud_Disponibles_ConfiguracionItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_Solicitud_Disponibles_ConfiguracionItems != null && Detalle_Solicitud_Disponibles_ConfiguracionItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_Solicitud_Disponibles_ConfiguracionApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_Solicitud_Disponibles_ConfiguracionItem in Detalle_Solicitud_Disponibles_ConfiguracionItems)
                    {



                        //Removal Request
                        if (Detalle_Solicitud_Disponibles_ConfiguracionItem.Removed)
                        {
                            result = result && _IDetalle_Solicitud_Disponibles_ConfiguracionApiConsumer.Delete(Detalle_Solicitud_Disponibles_ConfiguracionItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_Solicitud_Disponibles_ConfiguracionItem.Clave = 0;

                        var Detalle_Solicitud_Disponibles_ConfiguracionData = new Detalle_Solicitud_Disponibles_Configuracion
                        {
                            Configuracion = MasterId
                            ,Clave = Detalle_Solicitud_Disponibles_ConfiguracionItem.Clave
                            ,Documento = (Convert.ToInt32(Detalle_Solicitud_Disponibles_ConfiguracionItem.Documento) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_Solicitud_Disponibles_ConfiguracionItem.Documento))

                        };

                        var resultId = Detalle_Solicitud_Disponibles_ConfiguracionItem.Clave > 0
                           ? _IDetalle_Solicitud_Disponibles_ConfiguracionApiConsumer.Update(Detalle_Solicitud_Disponibles_ConfiguracionData,null,null).Resource
                           : _IDetalle_Solicitud_Disponibles_ConfiguracionApiConsumer.Insert(Detalle_Solicitud_Disponibles_ConfiguracionData,null,null).Resource;

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
        public ActionResult GetDetalle_Solicitud_Disponibles_Configuracion_DocumentoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDocumentoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
                    item.Descripcion= CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Documento", "Descripcion");
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }



        /// <summary>
        /// Write Element Array of Configuracion_de_Servicios_de_Apoyo script
        /// </summary>
        /// <param name="oConfiguracion_de_Servicios_de_ApoyoElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Configuracion_de_Servicios_de_ApoyoModuleAttributeList)
        {
            for (int i = 0; i < Configuracion_de_Servicios_de_ApoyoModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Configuracion_de_Servicios_de_ApoyoModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Configuracion_de_Servicios_de_ApoyoModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Configuracion_de_Servicios_de_ApoyoModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Configuracion_de_Servicios_de_ApoyoModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Configuracion_de_Servicios_de_ApoyoModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Configuracion_de_Servicios_de_ApoyoModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Configuracion_de_Servicios_de_ApoyoModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Configuracion_de_Servicios_de_ApoyoModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Configuracion_de_Servicios_de_ApoyoModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Configuracion_de_Servicios_de_ApoyoModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Configuracion_de_Servicios_de_ApoyoModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strConfiguracion_de_Servicios_de_ApoyoScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Configuracion_de_Servicios_de_Apoyo.js")))
            {
                strConfiguracion_de_Servicios_de_ApoyoScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Configuracion_de_Servicios_de_Apoyo element attributes
            string userChangeJson = jsSerialize.Serialize(Configuracion_de_Servicios_de_ApoyoModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strConfiguracion_de_Servicios_de_ApoyoScript.IndexOf("inpuElementArray");
            string splittedString = strConfiguracion_de_Servicios_de_ApoyoScript.Substring(indexOfArray, strConfiguracion_de_Servicios_de_ApoyoScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Configuracion_de_Servicios_de_ApoyoModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Configuracion_de_Servicios_de_ApoyoModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strConfiguracion_de_Servicios_de_ApoyoScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strConfiguracion_de_Servicios_de_ApoyoScript.Substring(indexOfArrayHistory, strConfiguracion_de_Servicios_de_ApoyoScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strConfiguracion_de_Servicios_de_ApoyoScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strConfiguracion_de_Servicios_de_ApoyoScript.Substring(endIndexOfMainElement + indexOfArray, strConfiguracion_de_Servicios_de_ApoyoScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Configuracion_de_Servicios_de_ApoyoModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Configuracion_de_Servicios_de_ApoyoModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Configuracion_de_Servicios_de_Apoyo.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Configuracion_de_Servicios_de_Apoyo.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Configuracion_de_Servicios_de_Apoyo.js")))
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
        public ActionResult Configuracion_de_Servicios_de_ApoyoPropertyBag()
        {
            return PartialView("Configuracion_de_Servicios_de_ApoyoPropertyBag", "Configuracion_de_Servicios_de_Apoyo");
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
        public ActionResult AddDetalle_Solicitud_Disponibles_Configuracion(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_Solicitud_Disponibles_Configuracion/AddDetalle_Solicitud_Disponibles_Configuracion");
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
                var whereClauseFormat = "Object = 46223 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IConfiguracion_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Configuracion_de_Servicios_de_Apoyo.Clave= " + RecordId;
                            var result = _IConfiguracion_de_Servicios_de_ApoyoApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IConfiguracion_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Configuracion_de_Servicios_de_ApoyoPropertyMapper());
			
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
                    (Configuracion_de_Servicios_de_ApoyoAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Configuracion_de_Servicios_de_ApoyoPropertyMapper oConfiguracion_de_Servicios_de_ApoyoPropertyMapper = new Configuracion_de_Servicios_de_ApoyoPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oConfiguracion_de_Servicios_de_ApoyoPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IConfiguracion_de_Servicios_de_ApoyoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Configuracion_de_Servicios_de_Apoyos == null)
                result.Configuracion_de_Servicios_de_Apoyos = new List<Configuracion_de_Servicios_de_Apoyo>();

            var data = result.Configuracion_de_Servicios_de_Apoyos.Select(m => new Configuracion_de_Servicios_de_ApoyoGridModel
            {
                Clave = m.Clave
                        ,RegionDescripcion = CultureHelper.GetTraduction(m.Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Region_Region.Descripcion
                        ,AreaDescripcion = CultureHelper.GetTraduction(m.Area_Area_de_Servicios_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.Area_Area_de_Servicios_de_Apoyo.Descripcion
                        ,SubAreaDescripcion = CultureHelper.GetTraduction(m.SubArea_SubArea_de_Servicios_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.SubArea_SubArea_de_Servicios_de_Apoyo.Descripcion
			,Acreditada = m.Acreditada
			,Centralizada = m.Centralizada

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(46223, arrayColumnsVisible), "Configuracion_de_Servicios_de_ApoyoList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(46223, arrayColumnsVisible), "Configuracion_de_Servicios_de_ApoyoList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(46223, arrayColumnsVisible), "Configuracion_de_Servicios_de_ApoyoList_" + DateTime.Now.ToString());
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

            _IConfiguracion_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Configuracion_de_Servicios_de_ApoyoPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Configuracion_de_Servicios_de_ApoyoAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Configuracion_de_Servicios_de_ApoyoPropertyMapper oConfiguracion_de_Servicios_de_ApoyoPropertyMapper = new Configuracion_de_Servicios_de_ApoyoPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oConfiguracion_de_Servicios_de_ApoyoPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IConfiguracion_de_Servicios_de_ApoyoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Configuracion_de_Servicios_de_Apoyos == null)
                result.Configuracion_de_Servicios_de_Apoyos = new List<Configuracion_de_Servicios_de_Apoyo>();

            var data = result.Configuracion_de_Servicios_de_Apoyos.Select(m => new Configuracion_de_Servicios_de_ApoyoGridModel
            {
                Clave = m.Clave
                        ,RegionDescripcion = CultureHelper.GetTraduction(m.Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Region_Region.Descripcion
                        ,AreaDescripcion = CultureHelper.GetTraduction(m.Area_Area_de_Servicios_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.Area_Area_de_Servicios_de_Apoyo.Descripcion
                        ,SubAreaDescripcion = CultureHelper.GetTraduction(m.SubArea_SubArea_de_Servicios_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.SubArea_SubArea_de_Servicios_de_Apoyo.Descripcion
			,Acreditada = m.Acreditada
			,Centralizada = m.Centralizada

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
                _IConfiguracion_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IConfiguracion_de_Servicios_de_ApoyoApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Configuracion_de_Servicios_de_Apoyo_Datos_GeneralesModel varConfiguracion_de_Servicios_de_Apoyo)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IConfiguracion_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Configuracion_de_Servicios_de_Apoyo_Datos_GeneralesInfo = new Configuracion_de_Servicios_de_Apoyo_Datos_Generales
                {
                    Clave = varConfiguracion_de_Servicios_de_Apoyo.Clave
                                            ,Region = varConfiguracion_de_Servicios_de_Apoyo.Region
                        ,Area = varConfiguracion_de_Servicios_de_Apoyo.Area
                        ,SubArea = varConfiguracion_de_Servicios_de_Apoyo.SubArea
                        ,Acreditada = varConfiguracion_de_Servicios_de_Apoyo.Acreditada
                        ,Centralizada = varConfiguracion_de_Servicios_de_Apoyo.Centralizada
                    
                };

                result = _IConfiguracion_de_Servicios_de_ApoyoApiConsumer.Update_Datos_Generales(Configuracion_de_Servicios_de_Apoyo_Datos_GeneralesInfo).Resource.ToString();
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
                _IConfiguracion_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IConfiguracion_de_Servicios_de_ApoyoApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_Solicitud_Disponibles_Configuracion;
                var Detalle_Solicitud_Disponibles_ConfiguracionData = GetDetalle_Solicitud_Disponibles_ConfiguracionData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Solicitud_Disponibles_Configuracion);

                var result = new Configuracion_de_Servicios_de_Apoyo_Datos_GeneralesModel
                {
                    Clave = m.Clave
                        ,Region = m.Region
                        ,RegionDescripcion = CultureHelper.GetTraduction(m.Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Region_Region.Descripcion
                        ,Area = m.Area
                        ,AreaDescripcion = CultureHelper.GetTraduction(m.Area_Area_de_Servicios_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.Area_Area_de_Servicios_de_Apoyo.Descripcion
                        ,SubArea = m.SubArea
                        ,SubAreaDescripcion = CultureHelper.GetTraduction(m.SubArea_SubArea_de_Servicios_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.SubArea_SubArea_de_Servicios_de_Apoyo.Descripcion
			,Acreditada = m.Acreditada
			,Centralizada = m.Centralizada

                    
                };
				var resultData = new
                {
                    data = result
                    ,Solicitudes_Disponibles = Detalle_Solicitud_Disponibles_ConfiguracionData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }


    }
}

