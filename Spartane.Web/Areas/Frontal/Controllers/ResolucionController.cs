﻿using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Resolucion;
using Spartane.Core.Domain.Tipo_de_Resolucion;
using Spartane.Core.Domain.Resolucion;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Resolucion;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Resolucion;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Resolucion;
using Spartane.Web.Areas.WebApiConsumer.Resolucion;

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
    public class ResolucionController : Controller
    {
        #region "variable declaration"

        private IResolucionService service = null;
        private IResolucionApiConsumer _IResolucionApiConsumer;
        private ITipo_de_ResolucionApiConsumer _ITipo_de_ResolucionApiConsumer;

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

        
        public ResolucionController(IResolucionService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IResolucionApiConsumer ResolucionApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , ITipo_de_ResolucionApiConsumer Tipo_de_ResolucionApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IResolucionApiConsumer = ResolucionApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_FormatApiConsumer = Spartan_FormatApiConsumer;
            this._ISpartan_Format_PermissionsApiConsumer = Spartan_Format_PermissionsApiConsumer;
            this._IGeneratePDFApiConsumer = GeneratePDFApiConsumer;
			this._ISpartan_FormatRelatedApiConsumer = Spartan_Format_RelatedApiConsumer;
            this._ITipo_de_ResolucionApiConsumer = Tipo_de_ResolucionApiConsumer;
            this._IResolucionApiConsumer = ResolucionApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Resolucion
        [ObjectAuth(ObjectId = (ModuleObjectId)45546, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45546, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Resolucion/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45546, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45546, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varResolucion = new ResolucionModel();
			varResolucion.Clave = Id;
			
            ViewBag.ObjectId = "45546";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var ResolucionsData = _IResolucionApiConsumer.ListaSelAll(0, 1000, "Resolucion.Clave=" + Id, "").Resource.Resolucions;
				
				if (ResolucionsData != null && ResolucionsData.Count > 0)
                {
					var ResolucionData = ResolucionsData.First();
					varResolucion= new ResolucionModel
					{
						Clave  = ResolucionData.Clave 
	                    ,Descripcion = ResolucionData.Descripcion
                    ,Tipo = ResolucionData.Tipo
                    ,TipoDescripcion = CultureHelper.GetTraduction(Convert.ToString(ResolucionData.Tipo), "Tipo_de_Resolucion") ??  (string)ResolucionData.Tipo_Tipo_de_Resolucion.Descripcion
                    ,Resolucion_Padre_para_Autorizacion = ResolucionData.Resolucion_Padre_para_Autorizacion
                    ,Resolucion_Padre_para_AutorizacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(ResolucionData.Resolucion_Padre_para_Autorizacion), "Resolucion") ??  (string)ResolucionData.Resolucion_Padre_para_Autorizacion_Resolucion.Descripcion
                    ,Generar_Judicializacion = ResolucionData.Generar_Judicializacion.GetValueOrDefault()
                    ,ClaveFiscalia = ResolucionData.ClaveFiscalia
                    ,Resolucion_AT = ResolucionData.Resolucion_AT.GetValueOrDefault()
                    ,Resolucion_MP = ResolucionData.Resolucion_MP.GetValueOrDefault()
                    ,Aplica_para_Adolescentes = ResolucionData.Aplica_para_Adolescentes.GetValueOrDefault()
                    ,Aplica_para_Denuncia = ResolucionData.Aplica_para_Denuncia.GetValueOrDefault()
                    ,Aplica_para_Carpeta_de_Investigacion = ResolucionData.Aplica_para_Carpeta_de_Investigacion.GetValueOrDefault()
                    ,Abreviacion = ResolucionData.Abreviacion
                    ,Vigencia = ResolucionData.Vigencia
                    ,MostrarDependencia = ResolucionData.MostrarDependencia
                    ,Conteo = ResolucionData.Conteo
                    ,Estatus = ResolucionData.Estatus
                    ,Estatus_esp = ResolucionData.Estatus_esp
                    ,Mostrar_Estadistico = ResolucionData.Mostrar_Estadistico

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_ResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Resolucions_Tipo = _ITipo_de_ResolucionApiConsumer.SelAll(true);
            if (Tipo_de_Resolucions_Tipo != null && Tipo_de_Resolucions_Tipo.Resource != null)
                ViewBag.Tipo_de_Resolucions_Tipo = Tipo_de_Resolucions_Tipo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Resolucion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resolucions_Resolucion_Padre_para_Autorizacion = _IResolucionApiConsumer.SelAll(true);
            if (Resolucions_Resolucion_Padre_para_Autorizacion != null && Resolucions_Resolucion_Padre_para_Autorizacion.Resource != null)
                ViewBag.Resolucions_Resolucion_Padre_para_Autorizacion = Resolucions_Resolucion_Padre_para_Autorizacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resolucion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varResolucion);
        }
		
	[HttpGet]
        public ActionResult AddResolucion(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45546);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);
			ResolucionModel varResolucion= new ResolucionModel();


            if (id.ToString() != "0")
            {
                var ResolucionsData = _IResolucionApiConsumer.ListaSelAll(0, 1000, "Resolucion.Clave=" + id, "").Resource.Resolucions;
				
				if (ResolucionsData != null && ResolucionsData.Count > 0)
                {
					var ResolucionData = ResolucionsData.First();
					varResolucion= new ResolucionModel
					{
						Clave  = ResolucionData.Clave 
	                    ,Descripcion = ResolucionData.Descripcion
                    ,Tipo = ResolucionData.Tipo
                    ,TipoDescripcion = CultureHelper.GetTraduction(Convert.ToString(ResolucionData.Tipo), "Tipo_de_Resolucion") ??  (string)ResolucionData.Tipo_Tipo_de_Resolucion.Descripcion
                    ,Resolucion_Padre_para_Autorizacion = ResolucionData.Resolucion_Padre_para_Autorizacion
                    ,Resolucion_Padre_para_AutorizacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(ResolucionData.Resolucion_Padre_para_Autorizacion), "Resolucion") ??  (string)ResolucionData.Resolucion_Padre_para_Autorizacion_Resolucion.Descripcion
                    ,Generar_Judicializacion = ResolucionData.Generar_Judicializacion.GetValueOrDefault()
                    ,ClaveFiscalia = ResolucionData.ClaveFiscalia
                    ,Resolucion_AT = ResolucionData.Resolucion_AT.GetValueOrDefault()
                    ,Resolucion_MP = ResolucionData.Resolucion_MP.GetValueOrDefault()
                    ,Aplica_para_Adolescentes = ResolucionData.Aplica_para_Adolescentes.GetValueOrDefault()
                    ,Aplica_para_Denuncia = ResolucionData.Aplica_para_Denuncia.GetValueOrDefault()
                    ,Aplica_para_Carpeta_de_Investigacion = ResolucionData.Aplica_para_Carpeta_de_Investigacion.GetValueOrDefault()
                    ,Abreviacion = ResolucionData.Abreviacion
                    ,Vigencia = ResolucionData.Vigencia
                    ,MostrarDependencia = ResolucionData.MostrarDependencia
                    ,Conteo = ResolucionData.Conteo
                    ,Estatus = ResolucionData.Estatus
                    ,Estatus_esp = ResolucionData.Estatus_esp
                    ,Mostrar_Estadistico = ResolucionData.Mostrar_Estadistico

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_ResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Resolucions_Tipo = _ITipo_de_ResolucionApiConsumer.SelAll(true);
            if (Tipo_de_Resolucions_Tipo != null && Tipo_de_Resolucions_Tipo.Resource != null)
                ViewBag.Tipo_de_Resolucions_Tipo = Tipo_de_Resolucions_Tipo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Resolucion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resolucions_Resolucion_Padre_para_Autorizacion = _IResolucionApiConsumer.SelAll(true);
            if (Resolucions_Resolucion_Padre_para_Autorizacion != null && Resolucions_Resolucion_Padre_para_Autorizacion.Resource != null)
                ViewBag.Resolucions_Resolucion_Padre_para_Autorizacion = Resolucions_Resolucion_Padre_para_Autorizacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resolucion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddResolucion", varResolucion);
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
        public ActionResult GetTipo_de_ResolucionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_ResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_ResolucionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Resolucion", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetResolucionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IResolucionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resolucion", "Descripcion")?? m.Descripcion,
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
        public ActionResult ShowAdvanceFilter(ResolucionAdvanceSearchModel model, int idFilter = -1)
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

            _ITipo_de_ResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Resolucions_Tipo = _ITipo_de_ResolucionApiConsumer.SelAll(true);
            if (Tipo_de_Resolucions_Tipo != null && Tipo_de_Resolucions_Tipo.Resource != null)
                ViewBag.Tipo_de_Resolucions_Tipo = Tipo_de_Resolucions_Tipo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Resolucion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resolucions_Resolucion_Padre_para_Autorizacion = _IResolucionApiConsumer.SelAll(true);
            if (Resolucions_Resolucion_Padre_para_Autorizacion != null && Resolucions_Resolucion_Padre_para_Autorizacion.Resource != null)
                ViewBag.Resolucions_Resolucion_Padre_para_Autorizacion = Resolucions_Resolucion_Padre_para_Autorizacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resolucion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_ResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Resolucions_Tipo = _ITipo_de_ResolucionApiConsumer.SelAll(true);
            if (Tipo_de_Resolucions_Tipo != null && Tipo_de_Resolucions_Tipo.Resource != null)
                ViewBag.Tipo_de_Resolucions_Tipo = Tipo_de_Resolucions_Tipo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Resolucion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resolucions_Resolucion_Padre_para_Autorizacion = _IResolucionApiConsumer.SelAll(true);
            if (Resolucions_Resolucion_Padre_para_Autorizacion != null && Resolucions_Resolucion_Padre_para_Autorizacion.Resource != null)
                ViewBag.Resolucions_Resolucion_Padre_para_Autorizacion = Resolucions_Resolucion_Padre_para_Autorizacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resolucion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new ResolucionAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (ResolucionAdvanceSearchModel)(Session["AdvanceSearch"] ?? new ResolucionAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new ResolucionPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IResolucionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Resolucions == null)
                result.Resolucions = new List<Resolucion>();

            return Json(new
            {
                data = result.Resolucions.Select(m => new ResolucionGridModel
                    {
                    Clave = m.Clave
			,Descripcion = m.Descripcion
                        ,TipoDescripcion = CultureHelper.GetTraduction(m.Tipo_Tipo_de_Resolucion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Tipo_de_Resolucion.Descripcion
                        ,Resolucion_Padre_para_AutorizacionDescripcion = CultureHelper.GetTraduction(m.Resolucion_Padre_para_Autorizacion_Resolucion.Clave.ToString(), "Descripcion") ?? (string)m.Resolucion_Padre_para_Autorizacion_Resolucion.Descripcion
			,Generar_Judicializacion = m.Generar_Judicializacion
			,ClaveFiscalia = m.ClaveFiscalia
			,Resolucion_AT = m.Resolucion_AT
			,Resolucion_MP = m.Resolucion_MP
			,Aplica_para_Adolescentes = m.Aplica_para_Adolescentes
			,Aplica_para_Denuncia = m.Aplica_para_Denuncia
			,Aplica_para_Carpeta_de_Investigacion = m.Aplica_para_Carpeta_de_Investigacion
			,Abreviacion = m.Abreviacion
			,Vigencia = m.Vigencia
			,MostrarDependencia = m.MostrarDependencia
			,Conteo = m.Conteo
			,Estatus = m.Estatus
			,Estatus_esp = m.Estatus_esp
			,Mostrar_Estadistico = m.Mostrar_Estadistico

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetResolucionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IResolucionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Resolucion", m.),
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
        /// Get List of Resolucion from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Resolucion Entity</returns>
        public ActionResult GetResolucionList(UrlParametersModel param)
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
            _IResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new ResolucionPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(ResolucionAdvanceSearchModel))
                {
					var advanceFilter =
                    (ResolucionAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            ResolucionPropertyMapper oResolucionPropertyMapper = new ResolucionPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oResolucionPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IResolucionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Resolucions == null)
                result.Resolucions = new List<Resolucion>();

            return Json(new
            {
                aaData = result.Resolucions.Select(m => new ResolucionGridModel
            {
                    Clave = m.Clave
			,Descripcion = m.Descripcion
                        ,TipoDescripcion = CultureHelper.GetTraduction(m.Tipo_Tipo_de_Resolucion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Tipo_de_Resolucion.Descripcion
                        ,Resolucion_Padre_para_AutorizacionDescripcion = CultureHelper.GetTraduction(m.Resolucion_Padre_para_Autorizacion_Resolucion.Clave.ToString(), "Descripcion") ?? (string)m.Resolucion_Padre_para_Autorizacion_Resolucion.Descripcion
			,Generar_Judicializacion = m.Generar_Judicializacion
			,ClaveFiscalia = m.ClaveFiscalia
			,Resolucion_AT = m.Resolucion_AT
			,Resolucion_MP = m.Resolucion_MP
			,Aplica_para_Adolescentes = m.Aplica_para_Adolescentes
			,Aplica_para_Denuncia = m.Aplica_para_Denuncia
			,Aplica_para_Carpeta_de_Investigacion = m.Aplica_para_Carpeta_de_Investigacion
			,Abreviacion = m.Abreviacion
			,Vigencia = m.Vigencia
			,MostrarDependencia = m.MostrarDependencia
			,Conteo = m.Conteo
			,Estatus = m.Estatus
			,Estatus_esp = m.Estatus_esp
			,Mostrar_Estadistico = m.Mostrar_Estadistico

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }







        [NonAction]
        public string GetAdvanceFilter(ResolucionAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Resolucion.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Resolucion.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.Descripcion))
            {
                switch (filter.DescripcionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Resolucion.Descripcion LIKE '" + filter.Descripcion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Resolucion.Descripcion LIKE '%" + filter.Descripcion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Resolucion.Descripcion = '" + filter.Descripcion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Resolucion.Descripcion LIKE '%" + filter.Descripcion + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo))
            {
                switch (filter.TipoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Resolucion.Descripcion LIKE '" + filter.AdvanceTipo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Resolucion.Descripcion LIKE '%" + filter.AdvanceTipo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Resolucion.Descripcion = '" + filter.AdvanceTipo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Resolucion.Descripcion LIKE '%" + filter.AdvanceTipo + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipoMultiple != null && filter.AdvanceTipoMultiple.Count() > 0)
            {
                var TipoIds = string.Join(",", filter.AdvanceTipoMultiple);

                where += " AND Resolucion.Tipo In (" + TipoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceResolucion_Padre_para_Autorizacion))
            {
                switch (filter.Resolucion_Padre_para_AutorizacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Resolucion.Descripcion LIKE '" + filter.AdvanceResolucion_Padre_para_Autorizacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Resolucion.Descripcion LIKE '%" + filter.AdvanceResolucion_Padre_para_Autorizacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Resolucion.Descripcion = '" + filter.AdvanceResolucion_Padre_para_Autorizacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Resolucion.Descripcion LIKE '%" + filter.AdvanceResolucion_Padre_para_Autorizacion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceResolucion_Padre_para_AutorizacionMultiple != null && filter.AdvanceResolucion_Padre_para_AutorizacionMultiple.Count() > 0)
            {
                var Resolucion_Padre_para_AutorizacionIds = string.Join(",", filter.AdvanceResolucion_Padre_para_AutorizacionMultiple);

                where += " AND Resolucion.Resolucion_Padre_para_Autorizacion In (" + Resolucion_Padre_para_AutorizacionIds + ")";
            }

            if (filter.Generar_Judicializacion != RadioOptions.NoApply)
                where += " AND Resolucion.Generar_Judicializacion = " + Convert.ToInt32(filter.Generar_Judicializacion);

            if (!string.IsNullOrEmpty(filter.ClaveFiscalia))
            {
                switch (filter.ClaveFiscaliaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Resolucion.ClaveFiscalia LIKE '" + filter.ClaveFiscalia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Resolucion.ClaveFiscalia LIKE '%" + filter.ClaveFiscalia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Resolucion.ClaveFiscalia = '" + filter.ClaveFiscalia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Resolucion.ClaveFiscalia LIKE '%" + filter.ClaveFiscalia + "%'";
                        break;
                }
            }

            if (filter.Resolucion_AT != RadioOptions.NoApply)
                where += " AND Resolucion.Resolucion_AT = " + Convert.ToInt32(filter.Resolucion_AT);

            if (filter.Resolucion_MP != RadioOptions.NoApply)
                where += " AND Resolucion.Resolucion_MP = " + Convert.ToInt32(filter.Resolucion_MP);

            if (filter.Aplica_para_Adolescentes != RadioOptions.NoApply)
                where += " AND Resolucion.Aplica_para_Adolescentes = " + Convert.ToInt32(filter.Aplica_para_Adolescentes);

            if (filter.Aplica_para_Denuncia != RadioOptions.NoApply)
                where += " AND Resolucion.Aplica_para_Denuncia = " + Convert.ToInt32(filter.Aplica_para_Denuncia);

            if (filter.Aplica_para_Carpeta_de_Investigacion != RadioOptions.NoApply)
                where += " AND Resolucion.Aplica_para_Carpeta_de_Investigacion = " + Convert.ToInt32(filter.Aplica_para_Carpeta_de_Investigacion);

            if (!string.IsNullOrEmpty(filter.Abreviacion))
            {
                switch (filter.AbreviacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Resolucion.Abreviacion LIKE '" + filter.Abreviacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Resolucion.Abreviacion LIKE '%" + filter.Abreviacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Resolucion.Abreviacion = '" + filter.Abreviacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Resolucion.Abreviacion LIKE '%" + filter.Abreviacion + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Vigencia))
            {
                switch (filter.VigenciaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Resolucion.Vigencia LIKE '" + filter.Vigencia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Resolucion.Vigencia LIKE '%" + filter.Vigencia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Resolucion.Vigencia = '" + filter.Vigencia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Resolucion.Vigencia LIKE '%" + filter.Vigencia + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.MostrarDependencia))
            {
                switch (filter.MostrarDependenciaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Resolucion.MostrarDependencia LIKE '" + filter.MostrarDependencia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Resolucion.MostrarDependencia LIKE '%" + filter.MostrarDependencia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Resolucion.MostrarDependencia = '" + filter.MostrarDependencia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Resolucion.MostrarDependencia LIKE '%" + filter.MostrarDependencia + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromConteo) || !string.IsNullOrEmpty(filter.ToConteo))
            {
                if (!string.IsNullOrEmpty(filter.FromConteo))
                    where += " AND Resolucion.Conteo >= " + filter.FromConteo;
                if (!string.IsNullOrEmpty(filter.ToConteo))
                    where += " AND Resolucion.Conteo <= " + filter.ToConteo;
            }

            if (!string.IsNullOrEmpty(filter.FromEstatus) || !string.IsNullOrEmpty(filter.ToEstatus))
            {
                if (!string.IsNullOrEmpty(filter.FromEstatus))
                    where += " AND Resolucion.Estatus >= " + filter.FromEstatus;
                if (!string.IsNullOrEmpty(filter.ToEstatus))
                    where += " AND Resolucion.Estatus <= " + filter.ToEstatus;
            }

            if (!string.IsNullOrEmpty(filter.FromEstatus_esp) || !string.IsNullOrEmpty(filter.ToEstatus_esp))
            {
                if (!string.IsNullOrEmpty(filter.FromEstatus_esp))
                    where += " AND Resolucion.Estatus_esp >= " + filter.FromEstatus_esp;
                if (!string.IsNullOrEmpty(filter.ToEstatus_esp))
                    where += " AND Resolucion.Estatus_esp <= " + filter.ToEstatus_esp;
            }

            if (!string.IsNullOrEmpty(filter.FromMostrar_Estadistico) || !string.IsNullOrEmpty(filter.ToMostrar_Estadistico))
            {
                if (!string.IsNullOrEmpty(filter.FromMostrar_Estadistico))
                    where += " AND Resolucion.Mostrar_Estadistico >= " + filter.FromMostrar_Estadistico;
                if (!string.IsNullOrEmpty(filter.ToMostrar_Estadistico))
                    where += " AND Resolucion.Mostrar_Estadistico <= " + filter.ToMostrar_Estadistico;
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
                _IResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);

                Resolucion varResolucion = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IResolucionApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, ResolucionModel varResolucion)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var ResolucionInfo = new Resolucion
                    {
                        Clave = varResolucion.Clave
                        ,Descripcion = varResolucion.Descripcion
                        ,Tipo = varResolucion.Tipo
                        ,Resolucion_Padre_para_Autorizacion = varResolucion.Resolucion_Padre_para_Autorizacion
                        ,Generar_Judicializacion = varResolucion.Generar_Judicializacion
                        ,ClaveFiscalia = varResolucion.ClaveFiscalia
                        ,Resolucion_AT = varResolucion.Resolucion_AT
                        ,Resolucion_MP = varResolucion.Resolucion_MP
                        ,Aplica_para_Adolescentes = varResolucion.Aplica_para_Adolescentes
                        ,Aplica_para_Denuncia = varResolucion.Aplica_para_Denuncia
                        ,Aplica_para_Carpeta_de_Investigacion = varResolucion.Aplica_para_Carpeta_de_Investigacion
                        ,Abreviacion = varResolucion.Abreviacion
                        ,Vigencia = varResolucion.Vigencia
                        ,MostrarDependencia = varResolucion.MostrarDependencia
                        ,Conteo = varResolucion.Conteo
                        ,Estatus = varResolucion.Estatus
                        ,Estatus_esp = varResolucion.Estatus_esp
                        ,Mostrar_Estadistico = varResolucion.Mostrar_Estadistico

                    };

                    result = !IsNew ?
                        _IResolucionApiConsumer.Update(ResolucionInfo, null, null).Resource.ToString() :
                         _IResolucionApiConsumer.Insert(ResolucionInfo, null, null).Resource.ToString();
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
        /// Write Element Array of Resolucion script
        /// </summary>
        /// <param name="oResolucionElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew ResolucionModuleAttributeList)
        {
            for (int i = 0; i < ResolucionModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(ResolucionModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    ResolucionModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(ResolucionModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    ResolucionModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (ResolucionModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < ResolucionModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < ResolucionModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(ResolucionModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							ResolucionModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(ResolucionModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							ResolucionModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strResolucionScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Resolucion.js")))
            {
                strResolucionScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Resolucion element attributes
            string userChangeJson = jsSerialize.Serialize(ResolucionModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strResolucionScript.IndexOf("inpuElementArray");
            string splittedString = strResolucionScript.Substring(indexOfArray, strResolucionScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(ResolucionModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (ResolucionModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strResolucionScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strResolucionScript.Substring(indexOfArrayHistory, strResolucionScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strResolucionScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strResolucionScript.Substring(endIndexOfMainElement + indexOfArray, strResolucionScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (ResolucionModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in ResolucionModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Resolucion.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Resolucion.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Resolucion.js")))
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
        public ActionResult ResolucionPropertyBag()
        {
            return PartialView("ResolucionPropertyBag", "Resolucion");
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
                var whereClauseFormat = "Object = 45546 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Resolucion.Clave= " + RecordId;
                            var result = _IResolucionApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new ResolucionPropertyMapper());
			
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
                    (ResolucionAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            ResolucionPropertyMapper oResolucionPropertyMapper = new ResolucionPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oResolucionPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IResolucionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Resolucions == null)
                result.Resolucions = new List<Resolucion>();

            var data = result.Resolucions.Select(m => new ResolucionGridModel
            {
                Clave = m.Clave
			,Descripcion = m.Descripcion
                        ,TipoDescripcion = CultureHelper.GetTraduction(m.Tipo_Tipo_de_Resolucion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Tipo_de_Resolucion.Descripcion
                        ,Resolucion_Padre_para_AutorizacionDescripcion = CultureHelper.GetTraduction(m.Resolucion_Padre_para_Autorizacion_Resolucion.Clave.ToString(), "Descripcion") ?? (string)m.Resolucion_Padre_para_Autorizacion_Resolucion.Descripcion
			,Generar_Judicializacion = m.Generar_Judicializacion
			,ClaveFiscalia = m.ClaveFiscalia
			,Resolucion_AT = m.Resolucion_AT
			,Resolucion_MP = m.Resolucion_MP
			,Aplica_para_Adolescentes = m.Aplica_para_Adolescentes
			,Aplica_para_Denuncia = m.Aplica_para_Denuncia
			,Aplica_para_Carpeta_de_Investigacion = m.Aplica_para_Carpeta_de_Investigacion
			,Abreviacion = m.Abreviacion
			,Vigencia = m.Vigencia
			,MostrarDependencia = m.MostrarDependencia
			,Conteo = m.Conteo
			,Estatus = m.Estatus
			,Estatus_esp = m.Estatus_esp
			,Mostrar_Estadistico = m.Mostrar_Estadistico

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45546, arrayColumnsVisible), "ResolucionList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45546, arrayColumnsVisible), "ResolucionList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45546, arrayColumnsVisible), "ResolucionList_" + DateTime.Now.ToString());
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

            _IResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new ResolucionPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (ResolucionAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            ResolucionPropertyMapper oResolucionPropertyMapper = new ResolucionPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oResolucionPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IResolucionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Resolucions == null)
                result.Resolucions = new List<Resolucion>();

            var data = result.Resolucions.Select(m => new ResolucionGridModel
            {
                Clave = m.Clave
			,Descripcion = m.Descripcion
                        ,TipoDescripcion = CultureHelper.GetTraduction(m.Tipo_Tipo_de_Resolucion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Tipo_de_Resolucion.Descripcion
                        ,Resolucion_Padre_para_AutorizacionDescripcion = CultureHelper.GetTraduction(m.Resolucion_Padre_para_Autorizacion_Resolucion.Clave.ToString(), "Descripcion") ?? (string)m.Resolucion_Padre_para_Autorizacion_Resolucion.Descripcion
			,Generar_Judicializacion = m.Generar_Judicializacion
			,ClaveFiscalia = m.ClaveFiscalia
			,Resolucion_AT = m.Resolucion_AT
			,Resolucion_MP = m.Resolucion_MP
			,Aplica_para_Adolescentes = m.Aplica_para_Adolescentes
			,Aplica_para_Denuncia = m.Aplica_para_Denuncia
			,Aplica_para_Carpeta_de_Investigacion = m.Aplica_para_Carpeta_de_Investigacion
			,Abreviacion = m.Abreviacion
			,Vigencia = m.Vigencia
			,MostrarDependencia = m.MostrarDependencia
			,Conteo = m.Conteo
			,Estatus = m.Estatus
			,Estatus_esp = m.Estatus_esp
			,Mostrar_Estadistico = m.Mostrar_Estadistico

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
                _IResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IResolucionApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Resolucion_Datos_GeneralesModel varResolucion)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Resolucion_Datos_GeneralesInfo = new Resolucion_Datos_Generales
                {
                    Clave = varResolucion.Clave
                                            ,Descripcion = varResolucion.Descripcion
                        ,Tipo = varResolucion.Tipo
                        ,Resolucion_Padre_para_Autorizacion = varResolucion.Resolucion_Padre_para_Autorizacion
                        ,Generar_Judicializacion = varResolucion.Generar_Judicializacion
                        ,ClaveFiscalia = varResolucion.ClaveFiscalia
                        ,Resolucion_AT = varResolucion.Resolucion_AT
                        ,Resolucion_MP = varResolucion.Resolucion_MP
                        ,Aplica_para_Adolescentes = varResolucion.Aplica_para_Adolescentes
                        ,Aplica_para_Denuncia = varResolucion.Aplica_para_Denuncia
                        ,Aplica_para_Carpeta_de_Investigacion = varResolucion.Aplica_para_Carpeta_de_Investigacion
                        ,Abreviacion = varResolucion.Abreviacion
                        ,Vigencia = varResolucion.Vigencia
                        ,MostrarDependencia = varResolucion.MostrarDependencia
                        ,Conteo = varResolucion.Conteo
                        ,Estatus = varResolucion.Estatus
                        ,Estatus_esp = varResolucion.Estatus_esp
                        ,Mostrar_Estadistico = varResolucion.Mostrar_Estadistico
                    
                };

                result = _IResolucionApiConsumer.Update_Datos_Generales(Resolucion_Datos_GeneralesInfo).Resource.ToString();
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
                _IResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IResolucionApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Resolucion_Datos_GeneralesModel
                {
                    Clave = m.Clave
			,Descripcion = m.Descripcion
                        ,Tipo = m.Tipo
                        ,TipoDescripcion = CultureHelper.GetTraduction(m.Tipo_Tipo_de_Resolucion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Tipo_de_Resolucion.Descripcion
                        ,Resolucion_Padre_para_Autorizacion = m.Resolucion_Padre_para_Autorizacion
                        ,Resolucion_Padre_para_AutorizacionDescripcion = CultureHelper.GetTraduction(m.Resolucion_Padre_para_Autorizacion_Resolucion.Clave.ToString(), "Descripcion") ?? (string)m.Resolucion_Padre_para_Autorizacion_Resolucion.Descripcion
			,Generar_Judicializacion = m.Generar_Judicializacion
			,ClaveFiscalia = m.ClaveFiscalia
			,Resolucion_AT = m.Resolucion_AT
			,Resolucion_MP = m.Resolucion_MP
			,Aplica_para_Adolescentes = m.Aplica_para_Adolescentes
			,Aplica_para_Denuncia = m.Aplica_para_Denuncia
			,Aplica_para_Carpeta_de_Investigacion = m.Aplica_para_Carpeta_de_Investigacion
			,Abreviacion = m.Abreviacion
			,Vigencia = m.Vigencia
			,MostrarDependencia = m.MostrarDependencia
			,Conteo = m.Conteo
			,Estatus = m.Estatus
			,Estatus_esp = m.Estatus_esp
			,Mostrar_Estadistico = m.Mostrar_Estadistico

                    
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

