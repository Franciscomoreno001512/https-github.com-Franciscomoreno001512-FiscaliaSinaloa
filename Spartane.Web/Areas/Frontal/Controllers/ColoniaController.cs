﻿using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Vigencia;
using Spartane.Core.Domain.Tipo_de_Localidad;
using Spartane.Core.Domain.Colonia;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Colonia;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Vigencia;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Localidad;
using Spartane.Web.Areas.WebApiConsumer.Colonia;

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
    public class ColoniaController : Controller
    {
        #region "variable declaration"

        private IColoniaService service = null;
        private IColoniaApiConsumer _IColoniaApiConsumer;
        private IMunicipioApiConsumer _IMunicipioApiConsumer;
        private IVigenciaApiConsumer _IVigenciaApiConsumer;
        private ITipo_de_LocalidadApiConsumer _ITipo_de_LocalidadApiConsumer;

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

        
        public ColoniaController(IColoniaService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IColoniaApiConsumer ColoniaApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , IMunicipioApiConsumer MunicipioApiConsumer , IVigenciaApiConsumer VigenciaApiConsumer , ITipo_de_LocalidadApiConsumer Tipo_de_LocalidadApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
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
            this._IVigenciaApiConsumer = VigenciaApiConsumer;
            this._ITipo_de_LocalidadApiConsumer = Tipo_de_LocalidadApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Colonia
        [ObjectAuth(ObjectId = (ModuleObjectId)44956, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 44956, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Colonia/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)44956, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 44956, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varColonia = new ColoniaModel();
			varColonia.Clave = Id;
			
            ViewBag.ObjectId = "44956";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var ColoniasData = _IColoniaApiConsumer.ListaSelAll(0, 1000, "Colonia.Clave=" + Id, "").Resource.Colonias;
				
				if (ColoniasData != null && ColoniasData.Count > 0)
                {
					var ColoniaData = ColoniasData.First();
					varColonia= new ColoniaModel
					{
						Clave  = ColoniaData.Clave 
	                    ,Nombre = ColoniaData.Nombre
                    ,Municipio = ColoniaData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(ColoniaData.Municipio), "Municipio") ??  (string)ColoniaData.Municipio_Municipio.Nombre
                    ,Codigo_Postal = ColoniaData.Codigo_Postal
                    ,Zona = ColoniaData.Zona
                    ,Vigente = ColoniaData.Vigente
                    ,VigenteAbreviacion = CultureHelper.GetTraduction(Convert.ToString(ColoniaData.Vigente), "Vigencia") ??  (string)ColoniaData.Vigente_Vigencia.Abreviacion
                    ,Observaciones = ColoniaData.Observaciones
                    ,cod_pais = ColoniaData.cod_pais
                    ,cod_edo = ColoniaData.cod_edo
                    ,loc_justicia = ColoniaData.loc_justicia
                    ,pob_justicia = ColoniaData.pob_justicia
                    ,sector = ColoniaData.sector
                    ,estatus = ColoniaData.estatus
                    ,cod_localidad = ColoniaData.cod_localidad
                    ,Tipo = ColoniaData.Tipo
                    ,TipoDescripcion = CultureHelper.GetTraduction(Convert.ToString(ColoniaData.Tipo), "Tipo_de_Localidad") ??  (string)ColoniaData.Tipo_Tipo_de_Localidad.Descripcion
                    ,Poblacion = ColoniaData.Poblacion
                    ,PoblacionNombre = CultureHelper.GetTraduction(Convert.ToString(ColoniaData.Poblacion), "Colonia") ??  (string)ColoniaData.Poblacion_Colonia.Nombre

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Municipio = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio != null && Municipios_Municipio.Resource != null)
                ViewBag.Municipios_Municipio = Municipios_Municipio.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IVigenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Vigencias_Vigente = _IVigenciaApiConsumer.SelAll(true);
            if (Vigencias_Vigente != null && Vigencias_Vigente.Resource != null)
                ViewBag.Vigencias_Vigente = Vigencias_Vigente.Resource.Where(m => m.Abreviacion != null).OrderBy(m => m.Abreviacion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Vigencia", "Abreviacion") ?? m.Abreviacion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_LocalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Localidads_Tipo = _ITipo_de_LocalidadApiConsumer.SelAll(true);
            if (Tipo_de_Localidads_Tipo != null && Tipo_de_Localidads_Tipo.Resource != null)
                ViewBag.Tipo_de_Localidads_Tipo = Tipo_de_Localidads_Tipo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Localidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varColonia);
        }
		
	[HttpGet]
        public ActionResult AddColonia(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 44956);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
			ColoniaModel varColonia= new ColoniaModel();


            if (id.ToString() != "0")
            {
                var ColoniasData = _IColoniaApiConsumer.ListaSelAll(0, 1000, "Colonia.Clave=" + id, "").Resource.Colonias;
				
				if (ColoniasData != null && ColoniasData.Count > 0)
                {
					var ColoniaData = ColoniasData.First();
					varColonia= new ColoniaModel
					{
						Clave  = ColoniaData.Clave 
	                    ,Nombre = ColoniaData.Nombre
                    ,Municipio = ColoniaData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(ColoniaData.Municipio), "Municipio") ??  (string)ColoniaData.Municipio_Municipio.Nombre
                    ,Codigo_Postal = ColoniaData.Codigo_Postal
                    ,Zona = ColoniaData.Zona
                    ,Vigente = ColoniaData.Vigente
                    ,VigenteAbreviacion = CultureHelper.GetTraduction(Convert.ToString(ColoniaData.Vigente), "Vigencia") ??  (string)ColoniaData.Vigente_Vigencia.Abreviacion
                    ,Observaciones = ColoniaData.Observaciones
                    ,cod_pais = ColoniaData.cod_pais
                    ,cod_edo = ColoniaData.cod_edo
                    ,loc_justicia = ColoniaData.loc_justicia
                    ,pob_justicia = ColoniaData.pob_justicia
                    ,sector = ColoniaData.sector
                    ,estatus = ColoniaData.estatus
                    ,cod_localidad = ColoniaData.cod_localidad
                    ,Tipo = ColoniaData.Tipo
                    ,TipoDescripcion = CultureHelper.GetTraduction(Convert.ToString(ColoniaData.Tipo), "Tipo_de_Localidad") ??  (string)ColoniaData.Tipo_Tipo_de_Localidad.Descripcion
                    ,Poblacion = ColoniaData.Poblacion
                    ,PoblacionNombre = CultureHelper.GetTraduction(Convert.ToString(ColoniaData.Poblacion), "Colonia") ??  (string)ColoniaData.Poblacion_Colonia.Nombre

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Municipio = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio != null && Municipios_Municipio.Resource != null)
                ViewBag.Municipios_Municipio = Municipios_Municipio.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IVigenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Vigencias_Vigente = _IVigenciaApiConsumer.SelAll(true);
            if (Vigencias_Vigente != null && Vigencias_Vigente.Resource != null)
                ViewBag.Vigencias_Vigente = Vigencias_Vigente.Resource.Where(m => m.Abreviacion != null).OrderBy(m => m.Abreviacion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Vigencia", "Abreviacion") ?? m.Abreviacion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_LocalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Localidads_Tipo = _ITipo_de_LocalidadApiConsumer.SelAll(true);
            if (Tipo_de_Localidads_Tipo != null && Tipo_de_Localidads_Tipo.Resource != null)
                ViewBag.Tipo_de_Localidads_Tipo = Tipo_de_Localidads_Tipo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Localidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddColonia", varColonia);
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
        public ActionResult GetTipo_de_LocalidadAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_LocalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_LocalidadApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Localidad", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
		[HttpGet]
        public ActionResult GetColoniaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IColoniaApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre")?? m.Nombre,
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
        public ActionResult ShowAdvanceFilter(ColoniaAdvanceSearchModel model, int idFilter = -1)
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
            var Municipios_Municipio = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio != null && Municipios_Municipio.Resource != null)
                ViewBag.Municipios_Municipio = Municipios_Municipio.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IVigenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Vigencias_Vigente = _IVigenciaApiConsumer.SelAll(true);
            if (Vigencias_Vigente != null && Vigencias_Vigente.Resource != null)
                ViewBag.Vigencias_Vigente = Vigencias_Vigente.Resource.Where(m => m.Abreviacion != null).OrderBy(m => m.Abreviacion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Vigencia", "Abreviacion") ?? m.Abreviacion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_LocalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Localidads_Tipo = _ITipo_de_LocalidadApiConsumer.SelAll(true);
            if (Tipo_de_Localidads_Tipo != null && Tipo_de_Localidads_Tipo.Resource != null)
                ViewBag.Tipo_de_Localidads_Tipo = Tipo_de_Localidads_Tipo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Localidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Municipio = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio != null && Municipios_Municipio.Resource != null)
                ViewBag.Municipios_Municipio = Municipios_Municipio.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IVigenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Vigencias_Vigente = _IVigenciaApiConsumer.SelAll(true);
            if (Vigencias_Vigente != null && Vigencias_Vigente.Resource != null)
                ViewBag.Vigencias_Vigente = Vigencias_Vigente.Resource.Where(m => m.Abreviacion != null).OrderBy(m => m.Abreviacion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Vigencia", "Abreviacion") ?? m.Abreviacion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_LocalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Localidads_Tipo = _ITipo_de_LocalidadApiConsumer.SelAll(true);
            if (Tipo_de_Localidads_Tipo != null && Tipo_de_Localidads_Tipo.Resource != null)
                ViewBag.Tipo_de_Localidads_Tipo = Tipo_de_Localidads_Tipo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Localidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new ColoniaAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (ColoniaAdvanceSearchModel)(Session["AdvanceSearch"] ?? new ColoniaAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new ColoniaPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IColoniaApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Colonias == null)
                result.Colonias = new List<Colonia>();

            return Json(new
            {
                data = result.Colonias.Select(m => new ColoniaGridModel
                    {
                    Clave = m.Clave
			,Nombre = m.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Municipio_Municipio.Nombre
			,Codigo_Postal = m.Codigo_Postal
			,Zona = m.Zona
                        ,VigenteAbreviacion = CultureHelper.GetTraduction(m.Vigente_Vigencia.Clave.ToString(), "Abreviacion") ?? (string)m.Vigente_Vigencia.Abreviacion
			,Observaciones = m.Observaciones
			,cod_pais = m.cod_pais
			,cod_edo = m.cod_edo
			,loc_justicia = m.loc_justicia
			,pob_justicia = m.pob_justicia
			,sector = m.sector
			,estatus = m.estatus
			,cod_localidad = m.cod_localidad
                        ,TipoDescripcion = CultureHelper.GetTraduction(m.Tipo_Tipo_de_Localidad.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Tipo_de_Localidad.Descripcion
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetColoniaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IColoniaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Colonia", m.),
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
        /// Get List of Colonia from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Colonia Entity</returns>
        public ActionResult GetColoniaList(UrlParametersModel param)
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
            _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new ColoniaPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(ColoniaAdvanceSearchModel))
                {
					var advanceFilter =
                    (ColoniaAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            ColoniaPropertyMapper oColoniaPropertyMapper = new ColoniaPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oColoniaPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IColoniaApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Colonias == null)
                result.Colonias = new List<Colonia>();

            return Json(new
            {
                aaData = result.Colonias.Select(m => new ColoniaGridModel
            {
                    Clave = m.Clave
			,Nombre = m.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Municipio_Municipio.Nombre
			,Codigo_Postal = m.Codigo_Postal
			,Zona = m.Zona
                        ,VigenteAbreviacion = CultureHelper.GetTraduction(m.Vigente_Vigencia.Clave.ToString(), "Abreviacion") ?? (string)m.Vigente_Vigencia.Abreviacion
			,Observaciones = m.Observaciones
			,cod_pais = m.cod_pais
			,cod_edo = m.cod_edo
			,loc_justicia = m.loc_justicia
			,pob_justicia = m.pob_justicia
			,sector = m.sector
			,estatus = m.estatus
			,cod_localidad = m.cod_localidad
                        ,TipoDescripcion = CultureHelper.GetTraduction(m.Tipo_Tipo_de_Localidad.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Tipo_de_Localidad.Descripcion
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetColonia_Poblacion_Colonia(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Colonia.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Colonia.Nombre as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IColoniaApiConsumer.ListaSelAll(1, 20,elWhere , " Colonia.Nombre ASC ").Resource;
               
                foreach (var item in result.Colonias)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Colonia", "Nombre");
                    item.Nombre =trans ??item.Nombre;
                }
                return Json(result.Colonias.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }





        [NonAction]
        public string GetAdvanceFilter(ColoniaAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Colonia.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Colonia.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.Nombre))
            {
                switch (filter.NombreFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Colonia.Nombre LIKE '" + filter.Nombre + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Colonia.Nombre LIKE '%" + filter.Nombre + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Colonia.Nombre = '" + filter.Nombre + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Colonia.Nombre LIKE '%" + filter.Nombre + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceMunicipio))
            {
                switch (filter.MunicipioFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Municipio.Nombre LIKE '" + filter.AdvanceMunicipio + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Municipio.Nombre = '" + filter.AdvanceMunicipio + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio + "%'";
                        break;
                }
            }
            else if (filter.AdvanceMunicipioMultiple != null && filter.AdvanceMunicipioMultiple.Count() > 0)
            {
                var MunicipioIds = string.Join(",", filter.AdvanceMunicipioMultiple);

                where += " AND Colonia.Municipio In (" + MunicipioIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromCodigo_Postal) || !string.IsNullOrEmpty(filter.ToCodigo_Postal))
            {
                if (!string.IsNullOrEmpty(filter.FromCodigo_Postal))
                    where += " AND Colonia.Codigo_Postal >= " + filter.FromCodigo_Postal;
                if (!string.IsNullOrEmpty(filter.ToCodigo_Postal))
                    where += " AND Colonia.Codigo_Postal <= " + filter.ToCodigo_Postal;
            }

            if (!string.IsNullOrEmpty(filter.Zona))
            {
                switch (filter.ZonaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Colonia.Zona LIKE '" + filter.Zona + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Colonia.Zona LIKE '%" + filter.Zona + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Colonia.Zona = '" + filter.Zona + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Colonia.Zona LIKE '%" + filter.Zona + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceVigente))
            {
                switch (filter.VigenteFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Vigencia.Abreviacion LIKE '" + filter.AdvanceVigente + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Vigencia.Abreviacion LIKE '%" + filter.AdvanceVigente + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Vigencia.Abreviacion = '" + filter.AdvanceVigente + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Vigencia.Abreviacion LIKE '%" + filter.AdvanceVigente + "%'";
                        break;
                }
            }
            else if (filter.AdvanceVigenteMultiple != null && filter.AdvanceVigenteMultiple.Count() > 0)
            {
                var VigenteIds = string.Join(",", filter.AdvanceVigenteMultiple);

                where += " AND Colonia.Vigente In (" + VigenteIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Observaciones))
            {
                switch (filter.ObservacionesFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Colonia.Observaciones LIKE '" + filter.Observaciones + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Colonia.Observaciones LIKE '%" + filter.Observaciones + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Colonia.Observaciones = '" + filter.Observaciones + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Colonia.Observaciones LIKE '%" + filter.Observaciones + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Fromcod_pais) || !string.IsNullOrEmpty(filter.Tocod_pais))
            {
                if (!string.IsNullOrEmpty(filter.Fromcod_pais))
                    where += " AND Colonia.cod_pais >= " + filter.Fromcod_pais;
                if (!string.IsNullOrEmpty(filter.Tocod_pais))
                    where += " AND Colonia.cod_pais <= " + filter.Tocod_pais;
            }

            if (!string.IsNullOrEmpty(filter.Fromcod_edo) || !string.IsNullOrEmpty(filter.Tocod_edo))
            {
                if (!string.IsNullOrEmpty(filter.Fromcod_edo))
                    where += " AND Colonia.cod_edo >= " + filter.Fromcod_edo;
                if (!string.IsNullOrEmpty(filter.Tocod_edo))
                    where += " AND Colonia.cod_edo <= " + filter.Tocod_edo;
            }

            if (!string.IsNullOrEmpty(filter.Fromloc_justicia) || !string.IsNullOrEmpty(filter.Toloc_justicia))
            {
                if (!string.IsNullOrEmpty(filter.Fromloc_justicia))
                    where += " AND Colonia.loc_justicia >= " + filter.Fromloc_justicia;
                if (!string.IsNullOrEmpty(filter.Toloc_justicia))
                    where += " AND Colonia.loc_justicia <= " + filter.Toloc_justicia;
            }

            if (!string.IsNullOrEmpty(filter.Frompob_justicia) || !string.IsNullOrEmpty(filter.Topob_justicia))
            {
                if (!string.IsNullOrEmpty(filter.Frompob_justicia))
                    where += " AND Colonia.pob_justicia >= " + filter.Frompob_justicia;
                if (!string.IsNullOrEmpty(filter.Topob_justicia))
                    where += " AND Colonia.pob_justicia <= " + filter.Topob_justicia;
            }

            if (!string.IsNullOrEmpty(filter.Fromsector) || !string.IsNullOrEmpty(filter.Tosector))
            {
                if (!string.IsNullOrEmpty(filter.Fromsector))
                    where += " AND Colonia.sector >= " + filter.Fromsector;
                if (!string.IsNullOrEmpty(filter.Tosector))
                    where += " AND Colonia.sector <= " + filter.Tosector;
            }

            if (!string.IsNullOrEmpty(filter.estatus))
            {
                switch (filter.estatusFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Colonia.estatus LIKE '" + filter.estatus + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Colonia.estatus LIKE '%" + filter.estatus + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Colonia.estatus = '" + filter.estatus + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Colonia.estatus LIKE '%" + filter.estatus + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Fromcod_localidad) || !string.IsNullOrEmpty(filter.Tocod_localidad))
            {
                if (!string.IsNullOrEmpty(filter.Fromcod_localidad))
                    where += " AND Colonia.cod_localidad >= " + filter.Fromcod_localidad;
                if (!string.IsNullOrEmpty(filter.Tocod_localidad))
                    where += " AND Colonia.cod_localidad <= " + filter.Tocod_localidad;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo))
            {
                switch (filter.TipoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Localidad.Descripcion LIKE '" + filter.AdvanceTipo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Localidad.Descripcion LIKE '%" + filter.AdvanceTipo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Localidad.Descripcion = '" + filter.AdvanceTipo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Localidad.Descripcion LIKE '%" + filter.AdvanceTipo + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipoMultiple != null && filter.AdvanceTipoMultiple.Count() > 0)
            {
                var TipoIds = string.Join(",", filter.AdvanceTipoMultiple);

                where += " AND Colonia.Tipo In (" + TipoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvancePoblacion))
            {
                switch (filter.PoblacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Colonia.Nombre LIKE '" + filter.AdvancePoblacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvancePoblacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Colonia.Nombre = '" + filter.AdvancePoblacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvancePoblacion + "%'";
                        break;
                }
            }
            else if (filter.AdvancePoblacionMultiple != null && filter.AdvancePoblacionMultiple.Count() > 0)
            {
                var PoblacionIds = string.Join(",", filter.AdvancePoblacionMultiple);

                where += " AND Colonia.Poblacion In (" + PoblacionIds + ")";
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
                _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);

                Colonia varColonia = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IColoniaApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, ColoniaModel varColonia)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var ColoniaInfo = new Colonia
                    {
                        Clave = varColonia.Clave
                        ,Nombre = varColonia.Nombre
                        ,Municipio = varColonia.Municipio
                        ,Codigo_Postal = varColonia.Codigo_Postal
                        ,Zona = varColonia.Zona
                        ,Vigente = varColonia.Vigente
                        ,Observaciones = varColonia.Observaciones
                        ,cod_pais = varColonia.cod_pais
                        ,cod_edo = varColonia.cod_edo
                        ,loc_justicia = varColonia.loc_justicia
                        ,pob_justicia = varColonia.pob_justicia
                        ,sector = varColonia.sector
                        ,estatus = varColonia.estatus
                        ,cod_localidad = varColonia.cod_localidad
                        ,Tipo = varColonia.Tipo
                        ,Poblacion = varColonia.Poblacion

                    };

                    result = !IsNew ?
                        _IColoniaApiConsumer.Update(ColoniaInfo, null, null).Resource.ToString() :
                         _IColoniaApiConsumer.Insert(ColoniaInfo, null, null).Resource.ToString();
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
        /// Write Element Array of Colonia script
        /// </summary>
        /// <param name="oColoniaElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew ColoniaModuleAttributeList)
        {
            for (int i = 0; i < ColoniaModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(ColoniaModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    ColoniaModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(ColoniaModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    ColoniaModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (ColoniaModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < ColoniaModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < ColoniaModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(ColoniaModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							ColoniaModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(ColoniaModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							ColoniaModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strColoniaScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Colonia.js")))
            {
                strColoniaScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Colonia element attributes
            string userChangeJson = jsSerialize.Serialize(ColoniaModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strColoniaScript.IndexOf("inpuElementArray");
            string splittedString = strColoniaScript.Substring(indexOfArray, strColoniaScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(ColoniaModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (ColoniaModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strColoniaScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strColoniaScript.Substring(indexOfArrayHistory, strColoniaScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strColoniaScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strColoniaScript.Substring(endIndexOfMainElement + indexOfArray, strColoniaScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (ColoniaModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in ColoniaModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Colonia.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Colonia.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Colonia.js")))
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
        public ActionResult ColoniaPropertyBag()
        {
            return PartialView("ColoniaPropertyBag", "Colonia");
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
                var whereClauseFormat = "Object = 44956 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Colonia.Clave= " + RecordId;
                            var result = _IColoniaApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new ColoniaPropertyMapper());
			
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
                    (ColoniaAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            ColoniaPropertyMapper oColoniaPropertyMapper = new ColoniaPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oColoniaPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IColoniaApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Colonias == null)
                result.Colonias = new List<Colonia>();

            var data = result.Colonias.Select(m => new ColoniaGridModel
            {
                Clave = m.Clave
			,Nombre = m.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Municipio_Municipio.Nombre
			,Codigo_Postal = m.Codigo_Postal
			,Zona = m.Zona
                        ,VigenteAbreviacion = CultureHelper.GetTraduction(m.Vigente_Vigencia.Clave.ToString(), "Abreviacion") ?? (string)m.Vigente_Vigencia.Abreviacion
			,Observaciones = m.Observaciones
			,cod_pais = m.cod_pais
			,cod_edo = m.cod_edo
			,loc_justicia = m.loc_justicia
			,pob_justicia = m.pob_justicia
			,sector = m.sector
			,estatus = m.estatus
			,cod_localidad = m.cod_localidad
                        ,TipoDescripcion = CultureHelper.GetTraduction(m.Tipo_Tipo_de_Localidad.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Tipo_de_Localidad.Descripcion
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(44956, arrayColumnsVisible), "ColoniaList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(44956, arrayColumnsVisible), "ColoniaList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(44956, arrayColumnsVisible), "ColoniaList_" + DateTime.Now.ToString());
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

            _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new ColoniaPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (ColoniaAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            ColoniaPropertyMapper oColoniaPropertyMapper = new ColoniaPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oColoniaPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IColoniaApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Colonias == null)
                result.Colonias = new List<Colonia>();

            var data = result.Colonias.Select(m => new ColoniaGridModel
            {
                Clave = m.Clave
			,Nombre = m.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Municipio_Municipio.Nombre
			,Codigo_Postal = m.Codigo_Postal
			,Zona = m.Zona
                        ,VigenteAbreviacion = CultureHelper.GetTraduction(m.Vigente_Vigencia.Clave.ToString(), "Abreviacion") ?? (string)m.Vigente_Vigencia.Abreviacion
			,Observaciones = m.Observaciones
			,cod_pais = m.cod_pais
			,cod_edo = m.cod_edo
			,loc_justicia = m.loc_justicia
			,pob_justicia = m.pob_justicia
			,sector = m.sector
			,estatus = m.estatus
			,cod_localidad = m.cod_localidad
                        ,TipoDescripcion = CultureHelper.GetTraduction(m.Tipo_Tipo_de_Localidad.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Tipo_de_Localidad.Descripcion
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre

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
                _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IColoniaApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Colonia_Datos_GeneralesModel varColonia)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Colonia_Datos_GeneralesInfo = new Colonia_Datos_Generales
                {
                    Clave = varColonia.Clave
                                            ,Nombre = varColonia.Nombre
                        ,Municipio = varColonia.Municipio
                        ,Codigo_Postal = varColonia.Codigo_Postal
                        ,Zona = varColonia.Zona
                        ,Vigente = varColonia.Vigente
                        ,Observaciones = varColonia.Observaciones
                        ,cod_pais = varColonia.cod_pais
                        ,cod_edo = varColonia.cod_edo
                        ,loc_justicia = varColonia.loc_justicia
                        ,pob_justicia = varColonia.pob_justicia
                        ,sector = varColonia.sector
                        ,estatus = varColonia.estatus
                        ,cod_localidad = varColonia.cod_localidad
                        ,Tipo = varColonia.Tipo
                        ,Poblacion = varColonia.Poblacion
                    
                };

                result = _IColoniaApiConsumer.Update_Datos_Generales(Colonia_Datos_GeneralesInfo).Resource.ToString();
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
                _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IColoniaApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Colonia_Datos_GeneralesModel
                {
                    Clave = m.Clave
			,Nombre = m.Nombre
                        ,Municipio = m.Municipio
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Municipio_Municipio.Nombre
			,Codigo_Postal = m.Codigo_Postal
			,Zona = m.Zona
                        ,Vigente = m.Vigente
                        ,VigenteAbreviacion = CultureHelper.GetTraduction(m.Vigente_Vigencia.Clave.ToString(), "Abreviacion") ?? (string)m.Vigente_Vigencia.Abreviacion
			,Observaciones = m.Observaciones
			,cod_pais = m.cod_pais
			,cod_edo = m.cod_edo
			,loc_justicia = m.loc_justicia
			,pob_justicia = m.pob_justicia
			,sector = m.sector
			,estatus = m.estatus
			,cod_localidad = m.cod_localidad
                        ,Tipo = m.Tipo
                        ,TipoDescripcion = CultureHelper.GetTraduction(m.Tipo_Tipo_de_Localidad.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Tipo_de_Localidad.Descripcion
                        ,Poblacion = m.Poblacion
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre

                    
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

