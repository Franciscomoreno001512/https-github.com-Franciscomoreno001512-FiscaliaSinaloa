﻿using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Generador_Folio_Encuesta;
using Spartane.Core.Domain.Modulo_Encuesta;
using Spartane.Core.Domain.Region;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Generador_Folio_Encuesta;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Generador_Folio_Encuesta;
using Spartane.Web.Areas.WebApiConsumer.Modulo_Encuesta;
using Spartane.Web.Areas.WebApiConsumer.Region;

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
    public class Generador_Folio_EncuestaController : Controller
    {
        #region "variable declaration"

        private IGenerador_Folio_EncuestaService service = null;
        private IGenerador_Folio_EncuestaApiConsumer _IGenerador_Folio_EncuestaApiConsumer;
        private IModulo_EncuestaApiConsumer _IModulo_EncuestaApiConsumer;
        private IRegionApiConsumer _IRegionApiConsumer;

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

        
        public Generador_Folio_EncuestaController(IGenerador_Folio_EncuestaService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IGenerador_Folio_EncuestaApiConsumer Generador_Folio_EncuestaApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , IModulo_EncuestaApiConsumer Modulo_EncuestaApiConsumer , IRegionApiConsumer RegionApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IGenerador_Folio_EncuestaApiConsumer = Generador_Folio_EncuestaApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_FormatApiConsumer = Spartan_FormatApiConsumer;
            this._ISpartan_Format_PermissionsApiConsumer = Spartan_Format_PermissionsApiConsumer;
            this._IGeneratePDFApiConsumer = GeneratePDFApiConsumer;
			this._ISpartan_FormatRelatedApiConsumer = Spartan_Format_RelatedApiConsumer;
            this._IModulo_EncuestaApiConsumer = Modulo_EncuestaApiConsumer;
            this._IRegionApiConsumer = RegionApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Generador_Folio_Encuesta
        [ObjectAuth(ObjectId = (ModuleObjectId)45608, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45608, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Generador_Folio_Encuesta/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45608, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45608, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varGenerador_Folio_Encuesta = new Generador_Folio_EncuestaModel();
			varGenerador_Folio_Encuesta.Folio = Id;
			
            ViewBag.ObjectId = "45608";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IGenerador_Folio_EncuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Generador_Folio_EncuestasData = _IGenerador_Folio_EncuestaApiConsumer.ListaSelAll(0, 1000, "Generador_Folio_Encuesta.Folio=" + Id, "").Resource.Generador_Folio_Encuestas;
				
				if (Generador_Folio_EncuestasData != null && Generador_Folio_EncuestasData.Count > 0)
                {
					var Generador_Folio_EncuestaData = Generador_Folio_EncuestasData.First();
					varGenerador_Folio_Encuesta= new Generador_Folio_EncuestaModel
					{
						Folio  = Generador_Folio_EncuestaData.Folio 
	                    ,Fecha_Genera = (Generador_Folio_EncuestaData.Fecha_Genera == null ? string.Empty : Convert.ToDateTime(Generador_Folio_EncuestaData.Fecha_Genera).ToString(ConfigurationProperty.DateFormat))
                    ,Anio_Genera = Generador_Folio_EncuestaData.Anio_Genera
                    ,Modulo_Encuesta = Generador_Folio_EncuestaData.Modulo_Encuesta
                    ,Modulo_EncuestaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Generador_Folio_EncuestaData.Modulo_Encuesta), "Modulo_Encuesta") ??  (string)Generador_Folio_EncuestaData.Modulo_Encuesta_Modulo_Encuesta.Descripcion
                    ,Region = Generador_Folio_EncuestaData.Region
                    ,RegionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Generador_Folio_EncuestaData.Region), "Region") ??  (string)Generador_Folio_EncuestaData.Region_Region.Descripcion
                    ,Consecutivo = Generador_Folio_EncuestaData.Consecutivo
                    ,Folio_Encuesta_Ultimo_Generado = Generador_Folio_EncuestaData.Folio_Encuesta_Ultimo_Generado

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IModulo_EncuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modulo_Encuestas_Modulo_Encuesta = _IModulo_EncuestaApiConsumer.SelAll(true);
            if (Modulo_Encuestas_Modulo_Encuesta != null && Modulo_Encuestas_Modulo_Encuesta.Resource != null)
                ViewBag.Modulo_Encuestas_Modulo_Encuesta = Modulo_Encuestas_Modulo_Encuesta.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modulo_Encuesta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IRegionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Regions_Region = _IRegionApiConsumer.SelAll(true);
            if (Regions_Region != null && Regions_Region.Resource != null)
                ViewBag.Regions_Region = Regions_Region.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Region", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varGenerador_Folio_Encuesta);
        }
		
	[HttpGet]
        public ActionResult AddGenerador_Folio_Encuesta(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45608);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IGenerador_Folio_EncuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
			Generador_Folio_EncuestaModel varGenerador_Folio_Encuesta= new Generador_Folio_EncuestaModel();


            if (id.ToString() != "0")
            {
                var Generador_Folio_EncuestasData = _IGenerador_Folio_EncuestaApiConsumer.ListaSelAll(0, 1000, "Generador_Folio_Encuesta.Folio=" + id, "").Resource.Generador_Folio_Encuestas;
				
				if (Generador_Folio_EncuestasData != null && Generador_Folio_EncuestasData.Count > 0)
                {
					var Generador_Folio_EncuestaData = Generador_Folio_EncuestasData.First();
					varGenerador_Folio_Encuesta= new Generador_Folio_EncuestaModel
					{
						Folio  = Generador_Folio_EncuestaData.Folio 
	                    ,Fecha_Genera = (Generador_Folio_EncuestaData.Fecha_Genera == null ? string.Empty : Convert.ToDateTime(Generador_Folio_EncuestaData.Fecha_Genera).ToString(ConfigurationProperty.DateFormat))
                    ,Anio_Genera = Generador_Folio_EncuestaData.Anio_Genera
                    ,Modulo_Encuesta = Generador_Folio_EncuestaData.Modulo_Encuesta
                    ,Modulo_EncuestaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Generador_Folio_EncuestaData.Modulo_Encuesta), "Modulo_Encuesta") ??  (string)Generador_Folio_EncuestaData.Modulo_Encuesta_Modulo_Encuesta.Descripcion
                    ,Region = Generador_Folio_EncuestaData.Region
                    ,RegionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Generador_Folio_EncuestaData.Region), "Region") ??  (string)Generador_Folio_EncuestaData.Region_Region.Descripcion
                    ,Consecutivo = Generador_Folio_EncuestaData.Consecutivo
                    ,Folio_Encuesta_Ultimo_Generado = Generador_Folio_EncuestaData.Folio_Encuesta_Ultimo_Generado

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IModulo_EncuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modulo_Encuestas_Modulo_Encuesta = _IModulo_EncuestaApiConsumer.SelAll(true);
            if (Modulo_Encuestas_Modulo_Encuesta != null && Modulo_Encuestas_Modulo_Encuesta.Resource != null)
                ViewBag.Modulo_Encuestas_Modulo_Encuesta = Modulo_Encuestas_Modulo_Encuesta.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modulo_Encuesta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IRegionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Regions_Region = _IRegionApiConsumer.SelAll(true);
            if (Regions_Region != null && Regions_Region.Resource != null)
                ViewBag.Regions_Region = Regions_Region.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Region", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddGenerador_Folio_Encuesta", varGenerador_Folio_Encuesta);
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
        public ActionResult GetModulo_EncuestaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModulo_EncuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IModulo_EncuestaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modulo_Encuesta", "Descripcion")?? m.Descripcion,
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



        [HttpPost]
        public JsonResult ClearAdvanceFilter()
        {
            Session["AdvanceSearch"] = null;
            return Json(new { result = Session["AdvanceSearch"] == null }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult ShowAdvanceFilter(Generador_Folio_EncuestaAdvanceSearchModel model, int idFilter = -1)
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

            _IModulo_EncuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modulo_Encuestas_Modulo_Encuesta = _IModulo_EncuestaApiConsumer.SelAll(true);
            if (Modulo_Encuestas_Modulo_Encuesta != null && Modulo_Encuestas_Modulo_Encuesta.Resource != null)
                ViewBag.Modulo_Encuestas_Modulo_Encuesta = Modulo_Encuestas_Modulo_Encuesta.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modulo_Encuesta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IRegionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Regions_Region = _IRegionApiConsumer.SelAll(true);
            if (Regions_Region != null && Regions_Region.Resource != null)
                ViewBag.Regions_Region = Regions_Region.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Region", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IModulo_EncuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modulo_Encuestas_Modulo_Encuesta = _IModulo_EncuestaApiConsumer.SelAll(true);
            if (Modulo_Encuestas_Modulo_Encuesta != null && Modulo_Encuestas_Modulo_Encuesta.Resource != null)
                ViewBag.Modulo_Encuestas_Modulo_Encuesta = Modulo_Encuestas_Modulo_Encuesta.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modulo_Encuesta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IRegionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Regions_Region = _IRegionApiConsumer.SelAll(true);
            if (Regions_Region != null && Regions_Region.Resource != null)
                ViewBag.Regions_Region = Regions_Region.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Region", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Generador_Folio_EncuestaAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Generador_Folio_EncuestaAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Generador_Folio_EncuestaAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Generador_Folio_EncuestaPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IGenerador_Folio_EncuestaApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Generador_Folio_Encuestas == null)
                result.Generador_Folio_Encuestas = new List<Generador_Folio_Encuesta>();

            return Json(new
            {
                data = result.Generador_Folio_Encuestas.Select(m => new Generador_Folio_EncuestaGridModel
                    {
                    Folio = m.Folio
                        ,Fecha_Genera = (m.Fecha_Genera == null ? string.Empty : Convert.ToDateTime(m.Fecha_Genera).ToString(ConfigurationProperty.DateFormat))
			,Anio_Genera = m.Anio_Genera
                        ,Modulo_EncuestaDescripcion = CultureHelper.GetTraduction(m.Modulo_Encuesta_Modulo_Encuesta.Clave.ToString(), "Descripcion") ?? (string)m.Modulo_Encuesta_Modulo_Encuesta.Descripcion
                        ,RegionDescripcion = CultureHelper.GetTraduction(m.Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Region_Region.Descripcion
			,Consecutivo = m.Consecutivo
			,Folio_Encuesta_Ultimo_Generado = m.Folio_Encuesta_Ultimo_Generado

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetGenerador_Folio_EncuestaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IGenerador_Folio_EncuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IGenerador_Folio_EncuestaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Folio), "Generador_Folio_Encuesta", m.),
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
        /// Get List of Generador_Folio_Encuesta from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Generador_Folio_Encuesta Entity</returns>
        public ActionResult GetGenerador_Folio_EncuestaList(UrlParametersModel param)
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
            _IGenerador_Folio_EncuestaApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Generador_Folio_EncuestaPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Generador_Folio_EncuestaAdvanceSearchModel))
                {
					var advanceFilter =
                    (Generador_Folio_EncuestaAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Generador_Folio_EncuestaPropertyMapper oGenerador_Folio_EncuestaPropertyMapper = new Generador_Folio_EncuestaPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oGenerador_Folio_EncuestaPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IGenerador_Folio_EncuestaApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Generador_Folio_Encuestas == null)
                result.Generador_Folio_Encuestas = new List<Generador_Folio_Encuesta>();

            return Json(new
            {
                aaData = result.Generador_Folio_Encuestas.Select(m => new Generador_Folio_EncuestaGridModel
            {
                    Folio = m.Folio
                        ,Fecha_Genera = (m.Fecha_Genera == null ? string.Empty : Convert.ToDateTime(m.Fecha_Genera).ToString(ConfigurationProperty.DateFormat))
			,Anio_Genera = m.Anio_Genera
                        ,Modulo_EncuestaDescripcion = CultureHelper.GetTraduction(m.Modulo_Encuesta_Modulo_Encuesta.Clave.ToString(), "Descripcion") ?? (string)m.Modulo_Encuesta_Modulo_Encuesta.Descripcion
                        ,RegionDescripcion = CultureHelper.GetTraduction(m.Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Region_Region.Descripcion
			,Consecutivo = m.Consecutivo
			,Folio_Encuesta_Ultimo_Generado = m.Folio_Encuesta_Ultimo_Generado

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }







        [NonAction]
        public string GetAdvanceFilter(Generador_Folio_EncuestaAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromFolio) || !string.IsNullOrEmpty(filter.ToFolio))
            {
                if (!string.IsNullOrEmpty(filter.FromFolio))
                    where += " AND Generador_Folio_Encuesta.Folio >= " + filter.FromFolio;
                if (!string.IsNullOrEmpty(filter.ToFolio))
                    where += " AND Generador_Folio_Encuesta.Folio <= " + filter.ToFolio;
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_Genera) || !string.IsNullOrEmpty(filter.ToFecha_Genera))
            {
                var Fecha_GeneraFrom = DateTime.ParseExact(filter.FromFecha_Genera, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_GeneraTo = DateTime.ParseExact(filter.ToFecha_Genera, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_Genera))
                    where += " AND Generador_Folio_Encuesta.Fecha_Genera >= '" + Fecha_GeneraFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_Genera))
                    where += " AND Generador_Folio_Encuesta.Fecha_Genera <= '" + Fecha_GeneraTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromAnio_Genera) || !string.IsNullOrEmpty(filter.ToAnio_Genera))
            {
                if (!string.IsNullOrEmpty(filter.FromAnio_Genera))
                    where += " AND Generador_Folio_Encuesta.Anio_Genera >= " + filter.FromAnio_Genera;
                if (!string.IsNullOrEmpty(filter.ToAnio_Genera))
                    where += " AND Generador_Folio_Encuesta.Anio_Genera <= " + filter.ToAnio_Genera;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceModulo_Encuesta))
            {
                switch (filter.Modulo_EncuestaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_Encuesta.Descripcion LIKE '" + filter.AdvanceModulo_Encuesta + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_Encuesta.Descripcion LIKE '%" + filter.AdvanceModulo_Encuesta + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_Encuesta.Descripcion = '" + filter.AdvanceModulo_Encuesta + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_Encuesta.Descripcion LIKE '%" + filter.AdvanceModulo_Encuesta + "%'";
                        break;
                }
            }
            else if (filter.AdvanceModulo_EncuestaMultiple != null && filter.AdvanceModulo_EncuestaMultiple.Count() > 0)
            {
                var Modulo_EncuestaIds = string.Join(",", filter.AdvanceModulo_EncuestaMultiple);

                where += " AND Generador_Folio_Encuesta.Modulo_Encuesta In (" + Modulo_EncuestaIds + ")";
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

                where += " AND Generador_Folio_Encuesta.Region In (" + RegionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromConsecutivo) || !string.IsNullOrEmpty(filter.ToConsecutivo))
            {
                if (!string.IsNullOrEmpty(filter.FromConsecutivo))
                    where += " AND Generador_Folio_Encuesta.Consecutivo >= " + filter.FromConsecutivo;
                if (!string.IsNullOrEmpty(filter.ToConsecutivo))
                    where += " AND Generador_Folio_Encuesta.Consecutivo <= " + filter.ToConsecutivo;
            }

            if (!string.IsNullOrEmpty(filter.Folio_Encuesta_Ultimo_Generado))
            {
                switch (filter.Folio_Encuesta_Ultimo_GeneradoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Generador_Folio_Encuesta.Folio_Encuesta_Ultimo_Generado LIKE '" + filter.Folio_Encuesta_Ultimo_Generado + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Generador_Folio_Encuesta.Folio_Encuesta_Ultimo_Generado LIKE '%" + filter.Folio_Encuesta_Ultimo_Generado + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Generador_Folio_Encuesta.Folio_Encuesta_Ultimo_Generado = '" + filter.Folio_Encuesta_Ultimo_Generado + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Generador_Folio_Encuesta.Folio_Encuesta_Ultimo_Generado LIKE '%" + filter.Folio_Encuesta_Ultimo_Generado + "%'";
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
                _IGenerador_Folio_EncuestaApiConsumer.SetAuthHeader(_tokenManager.Token);

                Generador_Folio_Encuesta varGenerador_Folio_Encuesta = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IGenerador_Folio_EncuestaApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Generador_Folio_EncuestaModel varGenerador_Folio_Encuesta)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IGenerador_Folio_EncuestaApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Generador_Folio_EncuestaInfo = new Generador_Folio_Encuesta
                    {
                        Folio = varGenerador_Folio_Encuesta.Folio
                        ,Fecha_Genera = (!String.IsNullOrEmpty(varGenerador_Folio_Encuesta.Fecha_Genera)) ? DateTime.ParseExact(varGenerador_Folio_Encuesta.Fecha_Genera, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Anio_Genera = varGenerador_Folio_Encuesta.Anio_Genera
                        ,Modulo_Encuesta = varGenerador_Folio_Encuesta.Modulo_Encuesta
                        ,Region = varGenerador_Folio_Encuesta.Region
                        ,Consecutivo = varGenerador_Folio_Encuesta.Consecutivo
                        ,Folio_Encuesta_Ultimo_Generado = varGenerador_Folio_Encuesta.Folio_Encuesta_Ultimo_Generado

                    };

                    result = !IsNew ?
                        _IGenerador_Folio_EncuestaApiConsumer.Update(Generador_Folio_EncuestaInfo, null, null).Resource.ToString() :
                         _IGenerador_Folio_EncuestaApiConsumer.Insert(Generador_Folio_EncuestaInfo, null, null).Resource.ToString();
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
        /// Write Element Array of Generador_Folio_Encuesta script
        /// </summary>
        /// <param name="oGenerador_Folio_EncuestaElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Generador_Folio_EncuestaModuleAttributeList)
        {
            for (int i = 0; i < Generador_Folio_EncuestaModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Generador_Folio_EncuestaModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Generador_Folio_EncuestaModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Generador_Folio_EncuestaModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Generador_Folio_EncuestaModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Generador_Folio_EncuestaModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Generador_Folio_EncuestaModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Generador_Folio_EncuestaModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Generador_Folio_EncuestaModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Generador_Folio_EncuestaModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Generador_Folio_EncuestaModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Generador_Folio_EncuestaModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strGenerador_Folio_EncuestaScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Generador_Folio_Encuesta.js")))
            {
                strGenerador_Folio_EncuestaScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Generador_Folio_Encuesta element attributes
            string userChangeJson = jsSerialize.Serialize(Generador_Folio_EncuestaModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strGenerador_Folio_EncuestaScript.IndexOf("inpuElementArray");
            string splittedString = strGenerador_Folio_EncuestaScript.Substring(indexOfArray, strGenerador_Folio_EncuestaScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Generador_Folio_EncuestaModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Generador_Folio_EncuestaModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strGenerador_Folio_EncuestaScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strGenerador_Folio_EncuestaScript.Substring(indexOfArrayHistory, strGenerador_Folio_EncuestaScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strGenerador_Folio_EncuestaScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strGenerador_Folio_EncuestaScript.Substring(endIndexOfMainElement + indexOfArray, strGenerador_Folio_EncuestaScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Generador_Folio_EncuestaModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Generador_Folio_EncuestaModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Generador_Folio_Encuesta.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Generador_Folio_Encuesta.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Generador_Folio_Encuesta.js")))
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
        public ActionResult Generador_Folio_EncuestaPropertyBag()
        {
            return PartialView("Generador_Folio_EncuestaPropertyBag", "Generador_Folio_Encuesta");
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
                var whereClauseFormat = "Object = 45608 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IGenerador_Folio_EncuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Generador_Folio_Encuesta.Folio= " + RecordId;
                            var result = _IGenerador_Folio_EncuestaApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IGenerador_Folio_EncuestaApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Generador_Folio_EncuestaPropertyMapper());
			
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
                    (Generador_Folio_EncuestaAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Generador_Folio_EncuestaPropertyMapper oGenerador_Folio_EncuestaPropertyMapper = new Generador_Folio_EncuestaPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oGenerador_Folio_EncuestaPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IGenerador_Folio_EncuestaApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Generador_Folio_Encuestas == null)
                result.Generador_Folio_Encuestas = new List<Generador_Folio_Encuesta>();

            var data = result.Generador_Folio_Encuestas.Select(m => new Generador_Folio_EncuestaGridModel
            {
                Folio = m.Folio
                        ,Fecha_Genera = (m.Fecha_Genera == null ? string.Empty : Convert.ToDateTime(m.Fecha_Genera).ToString(ConfigurationProperty.DateFormat))
			,Anio_Genera = m.Anio_Genera
                        ,Modulo_EncuestaDescripcion = CultureHelper.GetTraduction(m.Modulo_Encuesta_Modulo_Encuesta.Clave.ToString(), "Descripcion") ?? (string)m.Modulo_Encuesta_Modulo_Encuesta.Descripcion
                        ,RegionDescripcion = CultureHelper.GetTraduction(m.Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Region_Region.Descripcion
			,Consecutivo = m.Consecutivo
			,Folio_Encuesta_Ultimo_Generado = m.Folio_Encuesta_Ultimo_Generado

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45608, arrayColumnsVisible), "Generador_Folio_EncuestaList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45608, arrayColumnsVisible), "Generador_Folio_EncuestaList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45608, arrayColumnsVisible), "Generador_Folio_EncuestaList_" + DateTime.Now.ToString());
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

            _IGenerador_Folio_EncuestaApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Generador_Folio_EncuestaPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Generador_Folio_EncuestaAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Generador_Folio_EncuestaPropertyMapper oGenerador_Folio_EncuestaPropertyMapper = new Generador_Folio_EncuestaPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oGenerador_Folio_EncuestaPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IGenerador_Folio_EncuestaApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Generador_Folio_Encuestas == null)
                result.Generador_Folio_Encuestas = new List<Generador_Folio_Encuesta>();

            var data = result.Generador_Folio_Encuestas.Select(m => new Generador_Folio_EncuestaGridModel
            {
                Folio = m.Folio
                        ,Fecha_Genera = (m.Fecha_Genera == null ? string.Empty : Convert.ToDateTime(m.Fecha_Genera).ToString(ConfigurationProperty.DateFormat))
			,Anio_Genera = m.Anio_Genera
                        ,Modulo_EncuestaDescripcion = CultureHelper.GetTraduction(m.Modulo_Encuesta_Modulo_Encuesta.Clave.ToString(), "Descripcion") ?? (string)m.Modulo_Encuesta_Modulo_Encuesta.Descripcion
                        ,RegionDescripcion = CultureHelper.GetTraduction(m.Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Region_Region.Descripcion
			,Consecutivo = m.Consecutivo
			,Folio_Encuesta_Ultimo_Generado = m.Folio_Encuesta_Ultimo_Generado

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
                _IGenerador_Folio_EncuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IGenerador_Folio_EncuestaApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Generador_Folio_Encuesta_Datos_GeneralesModel varGenerador_Folio_Encuesta)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IGenerador_Folio_EncuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Generador_Folio_Encuesta_Datos_GeneralesInfo = new Generador_Folio_Encuesta_Datos_Generales
                {
                    Folio = varGenerador_Folio_Encuesta.Folio
                                            ,Fecha_Genera = (!String.IsNullOrEmpty(varGenerador_Folio_Encuesta.Fecha_Genera)) ? DateTime.ParseExact(varGenerador_Folio_Encuesta.Fecha_Genera, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Anio_Genera = varGenerador_Folio_Encuesta.Anio_Genera
                        ,Modulo_Encuesta = varGenerador_Folio_Encuesta.Modulo_Encuesta
                        ,Region = varGenerador_Folio_Encuesta.Region
                        ,Consecutivo = varGenerador_Folio_Encuesta.Consecutivo
                        ,Folio_Encuesta_Ultimo_Generado = varGenerador_Folio_Encuesta.Folio_Encuesta_Ultimo_Generado
                    
                };

                result = _IGenerador_Folio_EncuestaApiConsumer.Update_Datos_Generales(Generador_Folio_Encuesta_Datos_GeneralesInfo).Resource.ToString();
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
                _IGenerador_Folio_EncuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IGenerador_Folio_EncuestaApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Generador_Folio_Encuesta_Datos_GeneralesModel
                {
                    Folio = m.Folio
                        ,Fecha_Genera = (m.Fecha_Genera == null ? string.Empty : Convert.ToDateTime(m.Fecha_Genera).ToString(ConfigurationProperty.DateFormat))
			,Anio_Genera = m.Anio_Genera
                        ,Modulo_Encuesta = m.Modulo_Encuesta
                        ,Modulo_EncuestaDescripcion = CultureHelper.GetTraduction(m.Modulo_Encuesta_Modulo_Encuesta.Clave.ToString(), "Descripcion") ?? (string)m.Modulo_Encuesta_Modulo_Encuesta.Descripcion
                        ,Region = m.Region
                        ,RegionDescripcion = CultureHelper.GetTraduction(m.Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Region_Region.Descripcion
			,Consecutivo = m.Consecutivo
			,Folio_Encuesta_Ultimo_Generado = m.Folio_Encuesta_Ultimo_Generado

                    
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

