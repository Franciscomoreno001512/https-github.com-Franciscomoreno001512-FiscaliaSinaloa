using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Solicitud_de_Apoyo_Externa;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Region;
using Spartane.Core.Domain.Unidad;
using Spartane.Core.Domain.Autoridad_Externa;
using Spartane.Core.Domain.Area_de_Servicios_de_Apoyo;
using Spartane.Core.Domain.SubArea_de_Servicios_de_Apoyo;
using Spartane.Core.Domain.Documento;
using Spartane.Core.Domain.Estatus_de_Apoyo_Externo;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Documento;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Solicitud_de_Apoyo_Externa;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Solicitud_de_Apoyo_Externa;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Region;
using Spartane.Web.Areas.WebApiConsumer.Unidad;
using Spartane.Web.Areas.WebApiConsumer.Autoridad_Externa;
using Spartane.Web.Areas.WebApiConsumer.Area_de_Servicios_de_Apoyo;
using Spartane.Web.Areas.WebApiConsumer.SubArea_de_Servicios_de_Apoyo;
using Spartane.Web.Areas.WebApiConsumer.Documento;
using Spartane.Web.Areas.WebApiConsumer.Estatus_de_Apoyo_Externo;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
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
    public class Solicitud_de_Apoyo_ExternaController : Controller
    {
        #region "variable declaration"

        private ISolicitud_de_Apoyo_ExternaService service = null;
        private ISolicitud_de_Apoyo_ExternaApiConsumer _ISolicitud_de_Apoyo_ExternaApiConsumer;
        private ISpartan_UserApiConsumer _ISpartan_UserApiConsumer;
        private IRegionApiConsumer _IRegionApiConsumer;
        private IUnidadApiConsumer _IUnidadApiConsumer;
        private IAutoridad_ExternaApiConsumer _IAutoridad_ExternaApiConsumer;
        private IArea_de_Servicios_de_ApoyoApiConsumer _IArea_de_Servicios_de_ApoyoApiConsumer;
        private ISubArea_de_Servicios_de_ApoyoApiConsumer _ISubArea_de_Servicios_de_ApoyoApiConsumer;
        private IDocumentoApiConsumer _IDocumentoApiConsumer;
        private IEstatus_de_Apoyo_ExternoApiConsumer _IEstatus_de_Apoyo_ExternoApiConsumer;

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

        
        public Solicitud_de_Apoyo_ExternaController(ISolicitud_de_Apoyo_ExternaService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, ISolicitud_de_Apoyo_ExternaApiConsumer Solicitud_de_Apoyo_ExternaApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , ISpartan_UserApiConsumer Spartan_UserApiConsumer , IRegionApiConsumer RegionApiConsumer , IUnidadApiConsumer UnidadApiConsumer , IAutoridad_ExternaApiConsumer Autoridad_ExternaApiConsumer , IArea_de_Servicios_de_ApoyoApiConsumer Area_de_Servicios_de_ApoyoApiConsumer , ISubArea_de_Servicios_de_ApoyoApiConsumer SubArea_de_Servicios_de_ApoyoApiConsumer , IDocumentoApiConsumer DocumentoApiConsumer , IEstatus_de_Apoyo_ExternoApiConsumer Estatus_de_Apoyo_ExternoApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._ISolicitud_de_Apoyo_ExternaApiConsumer = Solicitud_de_Apoyo_ExternaApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_FormatApiConsumer = Spartan_FormatApiConsumer;
            this._ISpartan_Format_PermissionsApiConsumer = Spartan_Format_PermissionsApiConsumer;
            this._IGeneratePDFApiConsumer = GeneratePDFApiConsumer;
			this._ISpartan_FormatRelatedApiConsumer = Spartan_Format_RelatedApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._IRegionApiConsumer = RegionApiConsumer;
            this._IUnidadApiConsumer = UnidadApiConsumer;
            this._IAutoridad_ExternaApiConsumer = Autoridad_ExternaApiConsumer;
            this._IArea_de_Servicios_de_ApoyoApiConsumer = Area_de_Servicios_de_ApoyoApiConsumer;
            this._ISubArea_de_Servicios_de_ApoyoApiConsumer = SubArea_de_Servicios_de_ApoyoApiConsumer;
            this._IDocumentoApiConsumer = DocumentoApiConsumer;
            this._IEstatus_de_Apoyo_ExternoApiConsumer = Estatus_de_Apoyo_ExternoApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._IDocumentoApiConsumer = DocumentoApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Solicitud_de_Apoyo_Externa
        [ObjectAuth(ObjectId = (ModuleObjectId)46249, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 46249, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Solicitud_de_Apoyo_Externa/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)46249, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 46249, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varSolicitud_de_Apoyo_Externa = new Solicitud_de_Apoyo_ExternaModel();
			varSolicitud_de_Apoyo_Externa.Folio = Id;
			
            ViewBag.ObjectId = "46249";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _ISolicitud_de_Apoyo_ExternaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Solicitud_de_Apoyo_ExternasData = _ISolicitud_de_Apoyo_ExternaApiConsumer.ListaSelAll(0, 1000, "Solicitud_de_Apoyo_Externa.Folio=" + Id, "").Resource.Solicitud_de_Apoyo_Externas;
				
				if (Solicitud_de_Apoyo_ExternasData != null && Solicitud_de_Apoyo_ExternasData.Count > 0)
                {
					var Solicitud_de_Apoyo_ExternaData = Solicitud_de_Apoyo_ExternasData.First();
					varSolicitud_de_Apoyo_Externa= new Solicitud_de_Apoyo_ExternaModel
					{
						Folio  = Solicitud_de_Apoyo_ExternaData.Folio 
	                    ,Fecha_de_Registro = (Solicitud_de_Apoyo_ExternaData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(Solicitud_de_Apoyo_ExternaData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_registro = Solicitud_de_Apoyo_ExternaData.Hora_de_registro
                    ,Usuario_que_Registra = Solicitud_de_Apoyo_ExternaData.Usuario_que_Registra
                    ,Usuario_que_RegistraName = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Apoyo_ExternaData.Usuario_que_Registra), "Spartan_User") ??  (string)Solicitud_de_Apoyo_ExternaData.Usuario_que_Registra_Spartan_User.Name
                    ,Region = Solicitud_de_Apoyo_ExternaData.Region
                    ,RegionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Apoyo_ExternaData.Region), "Region") ??  (string)Solicitud_de_Apoyo_ExternaData.Region_Region.Descripcion
                    ,Unidad = Solicitud_de_Apoyo_ExternaData.Unidad
                    ,UnidadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Apoyo_ExternaData.Unidad), "Unidad") ??  (string)Solicitud_de_Apoyo_ExternaData.Unidad_Unidad.Descripcion
                    ,Anio = Solicitud_de_Apoyo_ExternaData.Anio
                    ,Fecha_de_Solicitud = (Solicitud_de_Apoyo_ExternaData.Fecha_de_Solicitud == null ? string.Empty : Convert.ToDateTime(Solicitud_de_Apoyo_ExternaData.Fecha_de_Solicitud).ToString(ConfigurationProperty.DateFormat))
                    ,Numero_de_Oficio_Externo = Solicitud_de_Apoyo_ExternaData.Numero_de_Oficio_Externo
                    ,Solicitante = Solicitud_de_Apoyo_ExternaData.Solicitante
                    ,Rango = Solicitud_de_Apoyo_ExternaData.Rango
                    ,Autoridad_Externa = Solicitud_de_Apoyo_ExternaData.Autoridad_Externa
                    ,Autoridad_ExternaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Apoyo_ExternaData.Autoridad_Externa), "Autoridad_Externa") ??  (string)Solicitud_de_Apoyo_ExternaData.Autoridad_Externa_Autoridad_Externa.Descripcion
                    ,Narracion_Solicitud = Solicitud_de_Apoyo_ExternaData.Narracion_Solicitud
                    ,Archivo_Adjunto = Solicitud_de_Apoyo_ExternaData.Archivo_Adjunto
                    ,Area_Asignada = Solicitud_de_Apoyo_ExternaData.Area_Asignada
                    ,Area_AsignadaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Apoyo_ExternaData.Area_Asignada), "Area_de_Servicios_de_Apoyo") ??  (string)Solicitud_de_Apoyo_ExternaData.Area_Asignada_Area_de_Servicios_de_Apoyo.Descripcion
                    ,SubArea_Asignada = Solicitud_de_Apoyo_ExternaData.SubArea_Asignada
                    ,SubArea_AsignadaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Apoyo_ExternaData.SubArea_Asignada), "SubArea_de_Servicios_de_Apoyo") ??  (string)Solicitud_de_Apoyo_ExternaData.SubArea_Asignada_SubArea_de_Servicios_de_Apoyo.Descripcion
                    ,Dictamen_Solicitado = Solicitud_de_Apoyo_ExternaData.Dictamen_Solicitado
                    ,Dictamen_SolicitadoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Apoyo_ExternaData.Dictamen_Solicitado), "Documento") ??  (string)Solicitud_de_Apoyo_ExternaData.Dictamen_Solicitado_Documento.Descripcion
                    ,Estatus = Solicitud_de_Apoyo_ExternaData.Estatus
                    ,EstatusDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Apoyo_ExternaData.Estatus), "Estatus_de_Apoyo_Externo") ??  (string)Solicitud_de_Apoyo_ExternaData.Estatus_Estatus_de_Apoyo_Externo.Descripcion
                    ,Fecha_de_Contestacion = (Solicitud_de_Apoyo_ExternaData.Fecha_de_Contestacion == null ? string.Empty : Convert.ToDateTime(Solicitud_de_Apoyo_ExternaData.Fecha_de_Contestacion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Contestacion = Solicitud_de_Apoyo_ExternaData.Hora_de_Contestacion
                    ,Responsable_que_Contesta = Solicitud_de_Apoyo_ExternaData.Responsable_que_Contesta
                    ,Responsable_que_ContestaName = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Apoyo_ExternaData.Responsable_que_Contesta), "Spartan_User") ??  (string)Solicitud_de_Apoyo_ExternaData.Responsable_que_Contesta_Spartan_User.Name
                    ,No__Contestacion = Solicitud_de_Apoyo_ExternaData.No__Contestacion
                    ,Dictamen = Solicitud_de_Apoyo_ExternaData.Dictamen
                    ,DictamenDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Apoyo_ExternaData.Dictamen), "Documento") ??  (string)Solicitud_de_Apoyo_ExternaData.Dictamen_Documento.Descripcion
                    ,Observaciones = Solicitud_de_Apoyo_ExternaData.Observaciones
                    ,Ver_Documento = Solicitud_de_Apoyo_ExternaData.Ver_Documento

					};
				}
				
				                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.Archivo_AdjuntoSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varSolicitud_de_Apoyo_Externa.Archivo_Adjunto).Resource;
                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.Ver_DocumentoSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varSolicitud_de_Apoyo_Externa.Ver_Documento).Resource;

				
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
            _IAutoridad_ExternaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Autoridad_Externas_Autoridad_Externa = _IAutoridad_ExternaApiConsumer.SelAll(true);
            if (Autoridad_Externas_Autoridad_Externa != null && Autoridad_Externas_Autoridad_Externa.Resource != null)
                ViewBag.Autoridad_Externas_Autoridad_Externa = Autoridad_Externas_Autoridad_Externa.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Autoridad_Externa", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IArea_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Area_de_Servicios_de_Apoyos_Area_Asignada = _IArea_de_Servicios_de_ApoyoApiConsumer.SelAll(true);
            if (Area_de_Servicios_de_Apoyos_Area_Asignada != null && Area_de_Servicios_de_Apoyos_Area_Asignada.Resource != null)
                ViewBag.Area_de_Servicios_de_Apoyos_Area_Asignada = Area_de_Servicios_de_Apoyos_Area_Asignada.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Area_de_Servicios_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISubArea_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var SubArea_de_Servicios_de_Apoyos_SubArea_Asignada = _ISubArea_de_Servicios_de_ApoyoApiConsumer.SelAll(true);
            if (SubArea_de_Servicios_de_Apoyos_SubArea_Asignada != null && SubArea_de_Servicios_de_Apoyos_SubArea_Asignada.Resource != null)
                ViewBag.SubArea_de_Servicios_de_Apoyos_SubArea_Asignada = SubArea_de_Servicios_de_Apoyos_SubArea_Asignada.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "SubArea_de_Servicios_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatus_de_Apoyo_ExternoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_de_Apoyo_Externos_Estatus = _IEstatus_de_Apoyo_ExternoApiConsumer.SelAll(true);
            if (Estatus_de_Apoyo_Externos_Estatus != null && Estatus_de_Apoyo_Externos_Estatus.Resource != null)
                ViewBag.Estatus_de_Apoyo_Externos_Estatus = Estatus_de_Apoyo_Externos_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Apoyo_Externo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varSolicitud_de_Apoyo_Externa);
        }
		
	[HttpGet]
        public ActionResult AddSolicitud_de_Apoyo_Externa(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 46249);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _ISolicitud_de_Apoyo_ExternaApiConsumer.SetAuthHeader(_tokenManager.Token);
			Solicitud_de_Apoyo_ExternaModel varSolicitud_de_Apoyo_Externa= new Solicitud_de_Apoyo_ExternaModel();


            if (id.ToString() != "0")
            {
                var Solicitud_de_Apoyo_ExternasData = _ISolicitud_de_Apoyo_ExternaApiConsumer.ListaSelAll(0, 1000, "Solicitud_de_Apoyo_Externa.Folio=" + id, "").Resource.Solicitud_de_Apoyo_Externas;
				
				if (Solicitud_de_Apoyo_ExternasData != null && Solicitud_de_Apoyo_ExternasData.Count > 0)
                {
					var Solicitud_de_Apoyo_ExternaData = Solicitud_de_Apoyo_ExternasData.First();
					varSolicitud_de_Apoyo_Externa= new Solicitud_de_Apoyo_ExternaModel
					{
						Folio  = Solicitud_de_Apoyo_ExternaData.Folio 
	                    ,Fecha_de_Registro = (Solicitud_de_Apoyo_ExternaData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(Solicitud_de_Apoyo_ExternaData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_registro = Solicitud_de_Apoyo_ExternaData.Hora_de_registro
                    ,Usuario_que_Registra = Solicitud_de_Apoyo_ExternaData.Usuario_que_Registra
                    ,Usuario_que_RegistraName = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Apoyo_ExternaData.Usuario_que_Registra), "Spartan_User") ??  (string)Solicitud_de_Apoyo_ExternaData.Usuario_que_Registra_Spartan_User.Name
                    ,Region = Solicitud_de_Apoyo_ExternaData.Region
                    ,RegionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Apoyo_ExternaData.Region), "Region") ??  (string)Solicitud_de_Apoyo_ExternaData.Region_Region.Descripcion
                    ,Unidad = Solicitud_de_Apoyo_ExternaData.Unidad
                    ,UnidadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Apoyo_ExternaData.Unidad), "Unidad") ??  (string)Solicitud_de_Apoyo_ExternaData.Unidad_Unidad.Descripcion
                    ,Anio = Solicitud_de_Apoyo_ExternaData.Anio
                    ,Fecha_de_Solicitud = (Solicitud_de_Apoyo_ExternaData.Fecha_de_Solicitud == null ? string.Empty : Convert.ToDateTime(Solicitud_de_Apoyo_ExternaData.Fecha_de_Solicitud).ToString(ConfigurationProperty.DateFormat))
                    ,Numero_de_Oficio_Externo = Solicitud_de_Apoyo_ExternaData.Numero_de_Oficio_Externo
                    ,Solicitante = Solicitud_de_Apoyo_ExternaData.Solicitante
                    ,Rango = Solicitud_de_Apoyo_ExternaData.Rango
                    ,Autoridad_Externa = Solicitud_de_Apoyo_ExternaData.Autoridad_Externa
                    ,Autoridad_ExternaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Apoyo_ExternaData.Autoridad_Externa), "Autoridad_Externa") ??  (string)Solicitud_de_Apoyo_ExternaData.Autoridad_Externa_Autoridad_Externa.Descripcion
                    ,Narracion_Solicitud = Solicitud_de_Apoyo_ExternaData.Narracion_Solicitud
                    ,Archivo_Adjunto = Solicitud_de_Apoyo_ExternaData.Archivo_Adjunto
                    ,Area_Asignada = Solicitud_de_Apoyo_ExternaData.Area_Asignada
                    ,Area_AsignadaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Apoyo_ExternaData.Area_Asignada), "Area_de_Servicios_de_Apoyo") ??  (string)Solicitud_de_Apoyo_ExternaData.Area_Asignada_Area_de_Servicios_de_Apoyo.Descripcion
                    ,SubArea_Asignada = Solicitud_de_Apoyo_ExternaData.SubArea_Asignada
                    ,SubArea_AsignadaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Apoyo_ExternaData.SubArea_Asignada), "SubArea_de_Servicios_de_Apoyo") ??  (string)Solicitud_de_Apoyo_ExternaData.SubArea_Asignada_SubArea_de_Servicios_de_Apoyo.Descripcion
                    ,Dictamen_Solicitado = Solicitud_de_Apoyo_ExternaData.Dictamen_Solicitado
                    ,Dictamen_SolicitadoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Apoyo_ExternaData.Dictamen_Solicitado), "Documento") ??  (string)Solicitud_de_Apoyo_ExternaData.Dictamen_Solicitado_Documento.Descripcion
                    ,Estatus = Solicitud_de_Apoyo_ExternaData.Estatus
                    ,EstatusDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Apoyo_ExternaData.Estatus), "Estatus_de_Apoyo_Externo") ??  (string)Solicitud_de_Apoyo_ExternaData.Estatus_Estatus_de_Apoyo_Externo.Descripcion
                    ,Fecha_de_Contestacion = (Solicitud_de_Apoyo_ExternaData.Fecha_de_Contestacion == null ? string.Empty : Convert.ToDateTime(Solicitud_de_Apoyo_ExternaData.Fecha_de_Contestacion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Contestacion = Solicitud_de_Apoyo_ExternaData.Hora_de_Contestacion
                    ,Responsable_que_Contesta = Solicitud_de_Apoyo_ExternaData.Responsable_que_Contesta
                    ,Responsable_que_ContestaName = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Apoyo_ExternaData.Responsable_que_Contesta), "Spartan_User") ??  (string)Solicitud_de_Apoyo_ExternaData.Responsable_que_Contesta_Spartan_User.Name
                    ,No__Contestacion = Solicitud_de_Apoyo_ExternaData.No__Contestacion
                    ,Dictamen = Solicitud_de_Apoyo_ExternaData.Dictamen
                    ,DictamenDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Apoyo_ExternaData.Dictamen), "Documento") ??  (string)Solicitud_de_Apoyo_ExternaData.Dictamen_Documento.Descripcion
                    ,Observaciones = Solicitud_de_Apoyo_ExternaData.Observaciones
                    ,Ver_Documento = Solicitud_de_Apoyo_ExternaData.Ver_Documento

					};
				}
                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.Archivo_AdjuntoSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varSolicitud_de_Apoyo_Externa.Archivo_Adjunto).Resource;
                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.Ver_DocumentoSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varSolicitud_de_Apoyo_Externa.Ver_Documento).Resource;

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
            _IAutoridad_ExternaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Autoridad_Externas_Autoridad_Externa = _IAutoridad_ExternaApiConsumer.SelAll(true);
            if (Autoridad_Externas_Autoridad_Externa != null && Autoridad_Externas_Autoridad_Externa.Resource != null)
                ViewBag.Autoridad_Externas_Autoridad_Externa = Autoridad_Externas_Autoridad_Externa.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Autoridad_Externa", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IArea_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Area_de_Servicios_de_Apoyos_Area_Asignada = _IArea_de_Servicios_de_ApoyoApiConsumer.SelAll(true);
            if (Area_de_Servicios_de_Apoyos_Area_Asignada != null && Area_de_Servicios_de_Apoyos_Area_Asignada.Resource != null)
                ViewBag.Area_de_Servicios_de_Apoyos_Area_Asignada = Area_de_Servicios_de_Apoyos_Area_Asignada.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Area_de_Servicios_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISubArea_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var SubArea_de_Servicios_de_Apoyos_SubArea_Asignada = _ISubArea_de_Servicios_de_ApoyoApiConsumer.SelAll(true);
            if (SubArea_de_Servicios_de_Apoyos_SubArea_Asignada != null && SubArea_de_Servicios_de_Apoyos_SubArea_Asignada.Resource != null)
                ViewBag.SubArea_de_Servicios_de_Apoyos_SubArea_Asignada = SubArea_de_Servicios_de_Apoyos_SubArea_Asignada.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "SubArea_de_Servicios_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatus_de_Apoyo_ExternoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_de_Apoyo_Externos_Estatus = _IEstatus_de_Apoyo_ExternoApiConsumer.SelAll(true);
            if (Estatus_de_Apoyo_Externos_Estatus != null && Estatus_de_Apoyo_Externos_Estatus.Resource != null)
                ViewBag.Estatus_de_Apoyo_Externos_Estatus = Estatus_de_Apoyo_Externos_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Apoyo_Externo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddSolicitud_de_Apoyo_Externa", varSolicitud_de_Apoyo_Externa);
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
        public ActionResult GetAutoridad_ExternaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IAutoridad_ExternaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IAutoridad_ExternaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Autoridad_Externa", "Descripcion")?? m.Descripcion,
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
		[HttpGet]
        public ActionResult GetDocumentoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDocumentoApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Documento", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetEstatus_de_Apoyo_ExternoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstatus_de_Apoyo_ExternoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstatus_de_Apoyo_ExternoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Apoyo_Externo", "Descripcion")?? m.Descripcion,
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
        public ActionResult ShowAdvanceFilter(Solicitud_de_Apoyo_ExternaAdvanceSearchModel model, int idFilter = -1)
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
            _IAutoridad_ExternaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Autoridad_Externas_Autoridad_Externa = _IAutoridad_ExternaApiConsumer.SelAll(true);
            if (Autoridad_Externas_Autoridad_Externa != null && Autoridad_Externas_Autoridad_Externa.Resource != null)
                ViewBag.Autoridad_Externas_Autoridad_Externa = Autoridad_Externas_Autoridad_Externa.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Autoridad_Externa", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IArea_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Area_de_Servicios_de_Apoyos_Area_Asignada = _IArea_de_Servicios_de_ApoyoApiConsumer.SelAll(true);
            if (Area_de_Servicios_de_Apoyos_Area_Asignada != null && Area_de_Servicios_de_Apoyos_Area_Asignada.Resource != null)
                ViewBag.Area_de_Servicios_de_Apoyos_Area_Asignada = Area_de_Servicios_de_Apoyos_Area_Asignada.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Area_de_Servicios_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISubArea_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var SubArea_de_Servicios_de_Apoyos_SubArea_Asignada = _ISubArea_de_Servicios_de_ApoyoApiConsumer.SelAll(true);
            if (SubArea_de_Servicios_de_Apoyos_SubArea_Asignada != null && SubArea_de_Servicios_de_Apoyos_SubArea_Asignada.Resource != null)
                ViewBag.SubArea_de_Servicios_de_Apoyos_SubArea_Asignada = SubArea_de_Servicios_de_Apoyos_SubArea_Asignada.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "SubArea_de_Servicios_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatus_de_Apoyo_ExternoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_de_Apoyo_Externos_Estatus = _IEstatus_de_Apoyo_ExternoApiConsumer.SelAll(true);
            if (Estatus_de_Apoyo_Externos_Estatus != null && Estatus_de_Apoyo_Externos_Estatus.Resource != null)
                ViewBag.Estatus_de_Apoyo_Externos_Estatus = Estatus_de_Apoyo_Externos_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Apoyo_Externo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _IAutoridad_ExternaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Autoridad_Externas_Autoridad_Externa = _IAutoridad_ExternaApiConsumer.SelAll(true);
            if (Autoridad_Externas_Autoridad_Externa != null && Autoridad_Externas_Autoridad_Externa.Resource != null)
                ViewBag.Autoridad_Externas_Autoridad_Externa = Autoridad_Externas_Autoridad_Externa.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Autoridad_Externa", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IArea_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Area_de_Servicios_de_Apoyos_Area_Asignada = _IArea_de_Servicios_de_ApoyoApiConsumer.SelAll(true);
            if (Area_de_Servicios_de_Apoyos_Area_Asignada != null && Area_de_Servicios_de_Apoyos_Area_Asignada.Resource != null)
                ViewBag.Area_de_Servicios_de_Apoyos_Area_Asignada = Area_de_Servicios_de_Apoyos_Area_Asignada.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Area_de_Servicios_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISubArea_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var SubArea_de_Servicios_de_Apoyos_SubArea_Asignada = _ISubArea_de_Servicios_de_ApoyoApiConsumer.SelAll(true);
            if (SubArea_de_Servicios_de_Apoyos_SubArea_Asignada != null && SubArea_de_Servicios_de_Apoyos_SubArea_Asignada.Resource != null)
                ViewBag.SubArea_de_Servicios_de_Apoyos_SubArea_Asignada = SubArea_de_Servicios_de_Apoyos_SubArea_Asignada.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "SubArea_de_Servicios_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatus_de_Apoyo_ExternoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_de_Apoyo_Externos_Estatus = _IEstatus_de_Apoyo_ExternoApiConsumer.SelAll(true);
            if (Estatus_de_Apoyo_Externos_Estatus != null && Estatus_de_Apoyo_Externos_Estatus.Resource != null)
                ViewBag.Estatus_de_Apoyo_Externos_Estatus = Estatus_de_Apoyo_Externos_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Apoyo_Externo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Solicitud_de_Apoyo_ExternaAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Solicitud_de_Apoyo_ExternaAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Solicitud_de_Apoyo_ExternaAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Solicitud_de_Apoyo_ExternaPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _ISolicitud_de_Apoyo_ExternaApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Solicitud_de_Apoyo_Externas == null)
                result.Solicitud_de_Apoyo_Externas = new List<Solicitud_de_Apoyo_Externa>();

            return Json(new
            {
                data = result.Solicitud_de_Apoyo_Externas.Select(m => new Solicitud_de_Apoyo_ExternaGridModel
                    {
                    Folio = m.Folio
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_registro = m.Hora_de_registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,RegionDescripcion = CultureHelper.GetTraduction(m.Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Region_Region.Descripcion
                        ,UnidadDescripcion = CultureHelper.GetTraduction(m.Unidad_Unidad.Clave.ToString(), "Descripcion") ?? (string)m.Unidad_Unidad.Descripcion
			,Anio = m.Anio
                        ,Fecha_de_Solicitud = (m.Fecha_de_Solicitud == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Solicitud).ToString(ConfigurationProperty.DateFormat))
			,Numero_de_Oficio_Externo = m.Numero_de_Oficio_Externo
			,Solicitante = m.Solicitante
			,Rango = m.Rango
                        ,Autoridad_ExternaDescripcion = CultureHelper.GetTraduction(m.Autoridad_Externa_Autoridad_Externa.Clave.ToString(), "Descripcion") ?? (string)m.Autoridad_Externa_Autoridad_Externa.Descripcion
			,Narracion_Solicitud = m.Narracion_Solicitud
			,Archivo_Adjunto = m.Archivo_Adjunto
                        ,Area_AsignadaDescripcion = CultureHelper.GetTraduction(m.Area_Asignada_Area_de_Servicios_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.Area_Asignada_Area_de_Servicios_de_Apoyo.Descripcion
                        ,SubArea_AsignadaDescripcion = CultureHelper.GetTraduction(m.SubArea_Asignada_SubArea_de_Servicios_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.SubArea_Asignada_SubArea_de_Servicios_de_Apoyo.Descripcion
                        ,Dictamen_SolicitadoDescripcion = CultureHelper.GetTraduction(m.Dictamen_Solicitado_Documento.Clave.ToString(), "Documento") ?? (string)m.Dictamen_Solicitado_Documento.Descripcion
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_de_Apoyo_Externo.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_de_Apoyo_Externo.Descripcion
                        ,Fecha_de_Contestacion = (m.Fecha_de_Contestacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Contestacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Contestacion = m.Hora_de_Contestacion
                        ,Responsable_que_ContestaName = CultureHelper.GetTraduction(m.Responsable_que_Contesta_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Responsable_que_Contesta_Spartan_User.Name
			,No__Contestacion = m.No__Contestacion
                        ,DictamenDescripcion = CultureHelper.GetTraduction(m.Dictamen_Documento.Clave.ToString(), "Documento") ?? (string)m.Dictamen_Documento.Descripcion
			,Observaciones = m.Observaciones
			,Ver_Documento = m.Ver_Documento

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetSolicitud_de_Apoyo_ExternaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitud_de_Apoyo_ExternaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISolicitud_de_Apoyo_ExternaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Folio), "Solicitud_de_Apoyo_Externa", m.),
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
        /// Get List of Solicitud_de_Apoyo_Externa from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Solicitud_de_Apoyo_Externa Entity</returns>
        public ActionResult GetSolicitud_de_Apoyo_ExternaList(UrlParametersModel param)
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
            _ISolicitud_de_Apoyo_ExternaApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Solicitud_de_Apoyo_ExternaPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Solicitud_de_Apoyo_ExternaAdvanceSearchModel))
                {
					var advanceFilter =
                    (Solicitud_de_Apoyo_ExternaAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Solicitud_de_Apoyo_ExternaPropertyMapper oSolicitud_de_Apoyo_ExternaPropertyMapper = new Solicitud_de_Apoyo_ExternaPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oSolicitud_de_Apoyo_ExternaPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _ISolicitud_de_Apoyo_ExternaApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Solicitud_de_Apoyo_Externas == null)
                result.Solicitud_de_Apoyo_Externas = new List<Solicitud_de_Apoyo_Externa>();

            return Json(new
            {
                aaData = result.Solicitud_de_Apoyo_Externas.Select(m => new Solicitud_de_Apoyo_ExternaGridModel
            {
                    Folio = m.Folio
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_registro = m.Hora_de_registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,RegionDescripcion = CultureHelper.GetTraduction(m.Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Region_Region.Descripcion
                        ,UnidadDescripcion = CultureHelper.GetTraduction(m.Unidad_Unidad.Clave.ToString(), "Descripcion") ?? (string)m.Unidad_Unidad.Descripcion
			,Anio = m.Anio
                        ,Fecha_de_Solicitud = (m.Fecha_de_Solicitud == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Solicitud).ToString(ConfigurationProperty.DateFormat))
			,Numero_de_Oficio_Externo = m.Numero_de_Oficio_Externo
			,Solicitante = m.Solicitante
			,Rango = m.Rango
                        ,Autoridad_ExternaDescripcion = CultureHelper.GetTraduction(m.Autoridad_Externa_Autoridad_Externa.Clave.ToString(), "Descripcion") ?? (string)m.Autoridad_Externa_Autoridad_Externa.Descripcion
			,Narracion_Solicitud = m.Narracion_Solicitud
			,Archivo_Adjunto = m.Archivo_Adjunto
                        ,Area_AsignadaDescripcion = CultureHelper.GetTraduction(m.Area_Asignada_Area_de_Servicios_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.Area_Asignada_Area_de_Servicios_de_Apoyo.Descripcion
                        ,SubArea_AsignadaDescripcion = CultureHelper.GetTraduction(m.SubArea_Asignada_SubArea_de_Servicios_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.SubArea_Asignada_SubArea_de_Servicios_de_Apoyo.Descripcion
                        ,Dictamen_SolicitadoDescripcion = CultureHelper.GetTraduction(m.Dictamen_Solicitado_Documento.Clave.ToString(), "Documento") ?? (string)m.Dictamen_Solicitado_Documento.Descripcion
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_de_Apoyo_Externo.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_de_Apoyo_Externo.Descripcion
                        ,Fecha_de_Contestacion = (m.Fecha_de_Contestacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Contestacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Contestacion = m.Hora_de_Contestacion
                        ,Responsable_que_ContestaName = CultureHelper.GetTraduction(m.Responsable_que_Contesta_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Responsable_que_Contesta_Spartan_User.Name
			,No__Contestacion = m.No__Contestacion
                        ,DictamenDescripcion = CultureHelper.GetTraduction(m.Dictamen_Documento.Clave.ToString(), "Documento") ?? (string)m.Dictamen_Documento.Descripcion
			,Observaciones = m.Observaciones
			,Ver_Documento = m.Ver_Documento

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetSolicitud_de_Apoyo_Externa_Usuario_que_Registra_Spartan_User(string query, string where)
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
        [HttpGet]
        public JsonResult GetSolicitud_de_Apoyo_Externa_Dictamen_Solicitado_Documento(string query, string where)
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
        [HttpGet]
        public JsonResult GetSolicitud_de_Apoyo_Externa_Responsable_que_Contesta_Spartan_User(string query, string where)
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
        [HttpGet]
        public JsonResult GetSolicitud_de_Apoyo_Externa_Dictamen_Documento(string query, string where)
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
        public string GetAdvanceFilter(Solicitud_de_Apoyo_ExternaAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromFolio) || !string.IsNullOrEmpty(filter.ToFolio))
            {
                if (!string.IsNullOrEmpty(filter.FromFolio))
                    where += " AND Solicitud_de_Apoyo_Externa.Folio >= " + filter.FromFolio;
                if (!string.IsNullOrEmpty(filter.ToFolio))
                    where += " AND Solicitud_de_Apoyo_Externa.Folio <= " + filter.ToFolio;
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro) || !string.IsNullOrEmpty(filter.ToFecha_de_Registro))
            {
                var Fecha_de_RegistroFrom = DateTime.ParseExact(filter.FromFecha_de_Registro, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_RegistroTo = DateTime.ParseExact(filter.ToFecha_de_Registro, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro))
                    where += " AND Solicitud_de_Apoyo_Externa.Fecha_de_Registro >= '" + Fecha_de_RegistroFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Registro))
                    where += " AND Solicitud_de_Apoyo_Externa.Fecha_de_Registro <= '" + Fecha_de_RegistroTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_registro) || !string.IsNullOrEmpty(filter.ToHora_de_registro))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_registro))
                    where += " AND Convert(TIME,Solicitud_de_Apoyo_Externa.Hora_de_registro) >='" + filter.FromHora_de_registro + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_registro))
                    where += " AND Convert(TIME,Solicitud_de_Apoyo_Externa.Hora_de_registro) <='" + filter.ToHora_de_registro + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceUsuario_que_Registra))
            {
                switch (filter.Usuario_que_RegistraFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_User.Name LIKE '" + filter.AdvanceUsuario_que_Registra + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceUsuario_que_Registra + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_User.Name = '" + filter.AdvanceUsuario_que_Registra + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceUsuario_que_Registra + "%'";
                        break;
                }
            }
            else if (filter.AdvanceUsuario_que_RegistraMultiple != null && filter.AdvanceUsuario_que_RegistraMultiple.Count() > 0)
            {
                var Usuario_que_RegistraIds = string.Join(",", filter.AdvanceUsuario_que_RegistraMultiple);

                where += " AND Solicitud_de_Apoyo_Externa.Usuario_que_Registra In (" + Usuario_que_RegistraIds + ")";
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

                where += " AND Solicitud_de_Apoyo_Externa.Region In (" + RegionIds + ")";
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

                where += " AND Solicitud_de_Apoyo_Externa.Unidad In (" + UnidadIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromAnio) || !string.IsNullOrEmpty(filter.ToAnio))
            {
                if (!string.IsNullOrEmpty(filter.FromAnio))
                    where += " AND Solicitud_de_Apoyo_Externa.Anio >= " + filter.FromAnio;
                if (!string.IsNullOrEmpty(filter.ToAnio))
                    where += " AND Solicitud_de_Apoyo_Externa.Anio <= " + filter.ToAnio;
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Solicitud) || !string.IsNullOrEmpty(filter.ToFecha_de_Solicitud))
            {
                var Fecha_de_SolicitudFrom = DateTime.ParseExact(filter.FromFecha_de_Solicitud, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_SolicitudTo = DateTime.ParseExact(filter.ToFecha_de_Solicitud, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Solicitud))
                    where += " AND Solicitud_de_Apoyo_Externa.Fecha_de_Solicitud >= '" + Fecha_de_SolicitudFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Solicitud))
                    where += " AND Solicitud_de_Apoyo_Externa.Fecha_de_Solicitud <= '" + Fecha_de_SolicitudTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.Numero_de_Oficio_Externo))
            {
                switch (filter.Numero_de_Oficio_ExternoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud_de_Apoyo_Externa.Numero_de_Oficio_Externo LIKE '" + filter.Numero_de_Oficio_Externo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud_de_Apoyo_Externa.Numero_de_Oficio_Externo LIKE '%" + filter.Numero_de_Oficio_Externo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud_de_Apoyo_Externa.Numero_de_Oficio_Externo = '" + filter.Numero_de_Oficio_Externo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud_de_Apoyo_Externa.Numero_de_Oficio_Externo LIKE '%" + filter.Numero_de_Oficio_Externo + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Solicitante))
            {
                switch (filter.SolicitanteFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud_de_Apoyo_Externa.Solicitante LIKE '" + filter.Solicitante + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud_de_Apoyo_Externa.Solicitante LIKE '%" + filter.Solicitante + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud_de_Apoyo_Externa.Solicitante = '" + filter.Solicitante + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud_de_Apoyo_Externa.Solicitante LIKE '%" + filter.Solicitante + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Rango))
            {
                switch (filter.RangoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud_de_Apoyo_Externa.Rango LIKE '" + filter.Rango + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud_de_Apoyo_Externa.Rango LIKE '%" + filter.Rango + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud_de_Apoyo_Externa.Rango = '" + filter.Rango + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud_de_Apoyo_Externa.Rango LIKE '%" + filter.Rango + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceAutoridad_Externa))
            {
                switch (filter.Autoridad_ExternaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Autoridad_Externa.Descripcion LIKE '" + filter.AdvanceAutoridad_Externa + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Autoridad_Externa.Descripcion LIKE '%" + filter.AdvanceAutoridad_Externa + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Autoridad_Externa.Descripcion = '" + filter.AdvanceAutoridad_Externa + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Autoridad_Externa.Descripcion LIKE '%" + filter.AdvanceAutoridad_Externa + "%'";
                        break;
                }
            }
            else if (filter.AdvanceAutoridad_ExternaMultiple != null && filter.AdvanceAutoridad_ExternaMultiple.Count() > 0)
            {
                var Autoridad_ExternaIds = string.Join(",", filter.AdvanceAutoridad_ExternaMultiple);

                where += " AND Solicitud_de_Apoyo_Externa.Autoridad_Externa In (" + Autoridad_ExternaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Narracion_Solicitud))
            {
                switch (filter.Narracion_SolicitudFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud_de_Apoyo_Externa.Narracion_Solicitud LIKE '" + filter.Narracion_Solicitud + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud_de_Apoyo_Externa.Narracion_Solicitud LIKE '%" + filter.Narracion_Solicitud + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud_de_Apoyo_Externa.Narracion_Solicitud = '" + filter.Narracion_Solicitud + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud_de_Apoyo_Externa.Narracion_Solicitud LIKE '%" + filter.Narracion_Solicitud + "%'";
                        break;
                }
            }

            if (filter.Archivo_Adjunto != RadioOptions.NoApply)
                where += " AND Solicitud_de_Apoyo_Externa.Archivo_Adjunto " + (filter.Archivo_Adjunto == RadioOptions.Yes ? ">" : "==") + " 0";

            if (!string.IsNullOrEmpty(filter.AdvanceArea_Asignada))
            {
                switch (filter.Area_AsignadaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Area_de_Servicios_de_Apoyo.Descripcion LIKE '" + filter.AdvanceArea_Asignada + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Area_de_Servicios_de_Apoyo.Descripcion LIKE '%" + filter.AdvanceArea_Asignada + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Area_de_Servicios_de_Apoyo.Descripcion = '" + filter.AdvanceArea_Asignada + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Area_de_Servicios_de_Apoyo.Descripcion LIKE '%" + filter.AdvanceArea_Asignada + "%'";
                        break;
                }
            }
            else if (filter.AdvanceArea_AsignadaMultiple != null && filter.AdvanceArea_AsignadaMultiple.Count() > 0)
            {
                var Area_AsignadaIds = string.Join(",", filter.AdvanceArea_AsignadaMultiple);

                where += " AND Solicitud_de_Apoyo_Externa.Area_Asignada In (" + Area_AsignadaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceSubArea_Asignada))
            {
                switch (filter.SubArea_AsignadaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND SubArea_de_Servicios_de_Apoyo.Descripcion LIKE '" + filter.AdvanceSubArea_Asignada + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND SubArea_de_Servicios_de_Apoyo.Descripcion LIKE '%" + filter.AdvanceSubArea_Asignada + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND SubArea_de_Servicios_de_Apoyo.Descripcion = '" + filter.AdvanceSubArea_Asignada + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND SubArea_de_Servicios_de_Apoyo.Descripcion LIKE '%" + filter.AdvanceSubArea_Asignada + "%'";
                        break;
                }
            }
            else if (filter.AdvanceSubArea_AsignadaMultiple != null && filter.AdvanceSubArea_AsignadaMultiple.Count() > 0)
            {
                var SubArea_AsignadaIds = string.Join(",", filter.AdvanceSubArea_AsignadaMultiple);

                where += " AND Solicitud_de_Apoyo_Externa.SubArea_Asignada In (" + SubArea_AsignadaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceDictamen_Solicitado))
            {
                switch (filter.Dictamen_SolicitadoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Documento.Descripcion LIKE '" + filter.AdvanceDictamen_Solicitado + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Documento.Descripcion LIKE '%" + filter.AdvanceDictamen_Solicitado + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Documento.Descripcion = '" + filter.AdvanceDictamen_Solicitado + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Documento.Descripcion LIKE '%" + filter.AdvanceDictamen_Solicitado + "%'";
                        break;
                }
            }
            else if (filter.AdvanceDictamen_SolicitadoMultiple != null && filter.AdvanceDictamen_SolicitadoMultiple.Count() > 0)
            {
                var Dictamen_SolicitadoIds = string.Join(",", filter.AdvanceDictamen_SolicitadoMultiple);

                where += " AND Solicitud_de_Apoyo_Externa.Dictamen_Solicitado In (" + Dictamen_SolicitadoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstatus))
            {
                switch (filter.EstatusFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estatus_de_Apoyo_Externo.Descripcion LIKE '" + filter.AdvanceEstatus + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estatus_de_Apoyo_Externo.Descripcion LIKE '%" + filter.AdvanceEstatus + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estatus_de_Apoyo_Externo.Descripcion = '" + filter.AdvanceEstatus + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estatus_de_Apoyo_Externo.Descripcion LIKE '%" + filter.AdvanceEstatus + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstatusMultiple != null && filter.AdvanceEstatusMultiple.Count() > 0)
            {
                var EstatusIds = string.Join(",", filter.AdvanceEstatusMultiple);

                where += " AND Solicitud_de_Apoyo_Externa.Estatus In (" + EstatusIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Contestacion) || !string.IsNullOrEmpty(filter.ToFecha_de_Contestacion))
            {
                var Fecha_de_ContestacionFrom = DateTime.ParseExact(filter.FromFecha_de_Contestacion, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_ContestacionTo = DateTime.ParseExact(filter.ToFecha_de_Contestacion, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Contestacion))
                    where += " AND Solicitud_de_Apoyo_Externa.Fecha_de_Contestacion >= '" + Fecha_de_ContestacionFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Contestacion))
                    where += " AND Solicitud_de_Apoyo_Externa.Fecha_de_Contestacion <= '" + Fecha_de_ContestacionTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Contestacion) || !string.IsNullOrEmpty(filter.ToHora_de_Contestacion))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Contestacion))
                    where += " AND Convert(TIME,Solicitud_de_Apoyo_Externa.Hora_de_Contestacion) >='" + filter.FromHora_de_Contestacion + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Contestacion))
                    where += " AND Convert(TIME,Solicitud_de_Apoyo_Externa.Hora_de_Contestacion) <='" + filter.ToHora_de_Contestacion + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceResponsable_que_Contesta))
            {
                switch (filter.Responsable_que_ContestaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_User.Name LIKE '" + filter.AdvanceResponsable_que_Contesta + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceResponsable_que_Contesta + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_User.Name = '" + filter.AdvanceResponsable_que_Contesta + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceResponsable_que_Contesta + "%'";
                        break;
                }
            }
            else if (filter.AdvanceResponsable_que_ContestaMultiple != null && filter.AdvanceResponsable_que_ContestaMultiple.Count() > 0)
            {
                var Responsable_que_ContestaIds = string.Join(",", filter.AdvanceResponsable_que_ContestaMultiple);

                where += " AND Solicitud_de_Apoyo_Externa.Responsable_que_Contesta In (" + Responsable_que_ContestaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.No__Contestacion))
            {
                switch (filter.No__ContestacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud_de_Apoyo_Externa.No__Contestacion LIKE '" + filter.No__Contestacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud_de_Apoyo_Externa.No__Contestacion LIKE '%" + filter.No__Contestacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud_de_Apoyo_Externa.No__Contestacion = '" + filter.No__Contestacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud_de_Apoyo_Externa.No__Contestacion LIKE '%" + filter.No__Contestacion + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceDictamen))
            {
                switch (filter.DictamenFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Documento.Descripcion LIKE '" + filter.AdvanceDictamen + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Documento.Descripcion LIKE '%" + filter.AdvanceDictamen + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Documento.Descripcion = '" + filter.AdvanceDictamen + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Documento.Descripcion LIKE '%" + filter.AdvanceDictamen + "%'";
                        break;
                }
            }
            else if (filter.AdvanceDictamenMultiple != null && filter.AdvanceDictamenMultiple.Count() > 0)
            {
                var DictamenIds = string.Join(",", filter.AdvanceDictamenMultiple);

                where += " AND Solicitud_de_Apoyo_Externa.Dictamen In (" + DictamenIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Observaciones))
            {
                switch (filter.ObservacionesFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud_de_Apoyo_Externa.Observaciones LIKE '" + filter.Observaciones + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud_de_Apoyo_Externa.Observaciones LIKE '%" + filter.Observaciones + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud_de_Apoyo_Externa.Observaciones = '" + filter.Observaciones + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud_de_Apoyo_Externa.Observaciones LIKE '%" + filter.Observaciones + "%'";
                        break;
                }
            }

            if (filter.Ver_Documento != RadioOptions.NoApply)
                where += " AND Solicitud_de_Apoyo_Externa.Ver_Documento " + (filter.Ver_Documento == RadioOptions.Yes ? ">" : "==") + " 0";


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
                _ISolicitud_de_Apoyo_ExternaApiConsumer.SetAuthHeader(_tokenManager.Token);

                Solicitud_de_Apoyo_Externa varSolicitud_de_Apoyo_Externa = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _ISolicitud_de_Apoyo_ExternaApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Solicitud_de_Apoyo_ExternaModel varSolicitud_de_Apoyo_Externa)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _ISolicitud_de_Apoyo_ExternaApiConsumer.SetAuthHeader(_tokenManager.Token);


                    if (varSolicitud_de_Apoyo_Externa.Archivo_AdjuntoRemoveAttachment != 0 && varSolicitud_de_Apoyo_Externa.Archivo_AdjuntoFile == null)
                    {
                        varSolicitud_de_Apoyo_Externa.Archivo_Adjunto = 0;
                    }

                    if (varSolicitud_de_Apoyo_Externa.Archivo_AdjuntoFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varSolicitud_de_Apoyo_Externa.Archivo_AdjuntoFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varSolicitud_de_Apoyo_Externa.Archivo_Adjunto = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varSolicitud_de_Apoyo_Externa.Archivo_AdjuntoFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }
                    if (varSolicitud_de_Apoyo_Externa.Ver_DocumentoRemoveAttachment != 0 && varSolicitud_de_Apoyo_Externa.Ver_DocumentoFile == null)
                    {
                        varSolicitud_de_Apoyo_Externa.Ver_Documento = 0;
                    }

                    if (varSolicitud_de_Apoyo_Externa.Ver_DocumentoFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varSolicitud_de_Apoyo_Externa.Ver_DocumentoFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varSolicitud_de_Apoyo_Externa.Ver_Documento = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varSolicitud_de_Apoyo_Externa.Ver_DocumentoFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }

                    
                    var result = "";
                    var Solicitud_de_Apoyo_ExternaInfo = new Solicitud_de_Apoyo_Externa
                    {
                        Folio = varSolicitud_de_Apoyo_Externa.Folio
                        ,Fecha_de_Registro = (!String.IsNullOrEmpty(varSolicitud_de_Apoyo_Externa.Fecha_de_Registro)) ? DateTime.ParseExact(varSolicitud_de_Apoyo_Externa.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_registro = varSolicitud_de_Apoyo_Externa.Hora_de_registro
                        ,Usuario_que_Registra = varSolicitud_de_Apoyo_Externa.Usuario_que_Registra
                        ,Region = varSolicitud_de_Apoyo_Externa.Region
                        ,Unidad = varSolicitud_de_Apoyo_Externa.Unidad
                        ,Anio = varSolicitud_de_Apoyo_Externa.Anio
                        ,Fecha_de_Solicitud = (!String.IsNullOrEmpty(varSolicitud_de_Apoyo_Externa.Fecha_de_Solicitud)) ? DateTime.ParseExact(varSolicitud_de_Apoyo_Externa.Fecha_de_Solicitud, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Numero_de_Oficio_Externo = varSolicitud_de_Apoyo_Externa.Numero_de_Oficio_Externo
                        ,Solicitante = varSolicitud_de_Apoyo_Externa.Solicitante
                        ,Rango = varSolicitud_de_Apoyo_Externa.Rango
                        ,Autoridad_Externa = varSolicitud_de_Apoyo_Externa.Autoridad_Externa
                        ,Narracion_Solicitud = varSolicitud_de_Apoyo_Externa.Narracion_Solicitud
                        ,Archivo_Adjunto = (varSolicitud_de_Apoyo_Externa.Archivo_Adjunto.HasValue && varSolicitud_de_Apoyo_Externa.Archivo_Adjunto != 0) ? ((int?)Convert.ToInt32(varSolicitud_de_Apoyo_Externa.Archivo_Adjunto.Value)) : null

                        ,Area_Asignada = varSolicitud_de_Apoyo_Externa.Area_Asignada
                        ,SubArea_Asignada = varSolicitud_de_Apoyo_Externa.SubArea_Asignada
                        ,Dictamen_Solicitado = varSolicitud_de_Apoyo_Externa.Dictamen_Solicitado
                        ,Estatus = varSolicitud_de_Apoyo_Externa.Estatus
                        ,Fecha_de_Contestacion = (!String.IsNullOrEmpty(varSolicitud_de_Apoyo_Externa.Fecha_de_Contestacion)) ? DateTime.ParseExact(varSolicitud_de_Apoyo_Externa.Fecha_de_Contestacion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Contestacion = varSolicitud_de_Apoyo_Externa.Hora_de_Contestacion
                        ,Responsable_que_Contesta = varSolicitud_de_Apoyo_Externa.Responsable_que_Contesta
                        ,No__Contestacion = varSolicitud_de_Apoyo_Externa.No__Contestacion
                        ,Dictamen = varSolicitud_de_Apoyo_Externa.Dictamen
                        ,Observaciones = varSolicitud_de_Apoyo_Externa.Observaciones
                        ,Ver_Documento = (varSolicitud_de_Apoyo_Externa.Ver_Documento.HasValue && varSolicitud_de_Apoyo_Externa.Ver_Documento != 0) ? ((int?)Convert.ToInt32(varSolicitud_de_Apoyo_Externa.Ver_Documento.Value)) : null


                    };

                    result = !IsNew ?
                        _ISolicitud_de_Apoyo_ExternaApiConsumer.Update(Solicitud_de_Apoyo_ExternaInfo, null, null).Resource.ToString() :
                         _ISolicitud_de_Apoyo_ExternaApiConsumer.Insert(Solicitud_de_Apoyo_ExternaInfo, null, null).Resource.ToString();
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
        /// Write Element Array of Solicitud_de_Apoyo_Externa script
        /// </summary>
        /// <param name="oSolicitud_de_Apoyo_ExternaElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Solicitud_de_Apoyo_ExternaModuleAttributeList)
        {
            for (int i = 0; i < Solicitud_de_Apoyo_ExternaModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Solicitud_de_Apoyo_ExternaModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Solicitud_de_Apoyo_ExternaModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Solicitud_de_Apoyo_ExternaModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Solicitud_de_Apoyo_ExternaModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Solicitud_de_Apoyo_ExternaModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Solicitud_de_Apoyo_ExternaModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Solicitud_de_Apoyo_ExternaModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Solicitud_de_Apoyo_ExternaModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Solicitud_de_Apoyo_ExternaModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Solicitud_de_Apoyo_ExternaModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Solicitud_de_Apoyo_ExternaModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strSolicitud_de_Apoyo_ExternaScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Solicitud_de_Apoyo_Externa.js")))
            {
                strSolicitud_de_Apoyo_ExternaScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Solicitud_de_Apoyo_Externa element attributes
            string userChangeJson = jsSerialize.Serialize(Solicitud_de_Apoyo_ExternaModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strSolicitud_de_Apoyo_ExternaScript.IndexOf("inpuElementArray");
            string splittedString = strSolicitud_de_Apoyo_ExternaScript.Substring(indexOfArray, strSolicitud_de_Apoyo_ExternaScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Solicitud_de_Apoyo_ExternaModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Solicitud_de_Apoyo_ExternaModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strSolicitud_de_Apoyo_ExternaScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strSolicitud_de_Apoyo_ExternaScript.Substring(indexOfArrayHistory, strSolicitud_de_Apoyo_ExternaScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strSolicitud_de_Apoyo_ExternaScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strSolicitud_de_Apoyo_ExternaScript.Substring(endIndexOfMainElement + indexOfArray, strSolicitud_de_Apoyo_ExternaScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Solicitud_de_Apoyo_ExternaModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Solicitud_de_Apoyo_ExternaModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Solicitud_de_Apoyo_Externa.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Solicitud_de_Apoyo_Externa.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Solicitud_de_Apoyo_Externa.js")))
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
        public ActionResult Solicitud_de_Apoyo_ExternaPropertyBag()
        {
            return PartialView("Solicitud_de_Apoyo_ExternaPropertyBag", "Solicitud_de_Apoyo_Externa");
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
                var whereClauseFormat = "Object = 46249 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _ISolicitud_de_Apoyo_ExternaApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Solicitud_de_Apoyo_Externa.Folio= " + RecordId;
                            var result = _ISolicitud_de_Apoyo_ExternaApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _ISolicitud_de_Apoyo_ExternaApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Solicitud_de_Apoyo_ExternaPropertyMapper());
			
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
                    (Solicitud_de_Apoyo_ExternaAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Solicitud_de_Apoyo_ExternaPropertyMapper oSolicitud_de_Apoyo_ExternaPropertyMapper = new Solicitud_de_Apoyo_ExternaPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oSolicitud_de_Apoyo_ExternaPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _ISolicitud_de_Apoyo_ExternaApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Solicitud_de_Apoyo_Externas == null)
                result.Solicitud_de_Apoyo_Externas = new List<Solicitud_de_Apoyo_Externa>();

            var data = result.Solicitud_de_Apoyo_Externas.Select(m => new Solicitud_de_Apoyo_ExternaGridModel
            {
                Folio = m.Folio
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_registro = m.Hora_de_registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,RegionDescripcion = CultureHelper.GetTraduction(m.Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Region_Region.Descripcion
                        ,UnidadDescripcion = CultureHelper.GetTraduction(m.Unidad_Unidad.Clave.ToString(), "Descripcion") ?? (string)m.Unidad_Unidad.Descripcion
			,Anio = m.Anio
                        ,Fecha_de_Solicitud = (m.Fecha_de_Solicitud == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Solicitud).ToString(ConfigurationProperty.DateFormat))
			,Numero_de_Oficio_Externo = m.Numero_de_Oficio_Externo
			,Solicitante = m.Solicitante
			,Rango = m.Rango
                        ,Autoridad_ExternaDescripcion = CultureHelper.GetTraduction(m.Autoridad_Externa_Autoridad_Externa.Clave.ToString(), "Descripcion") ?? (string)m.Autoridad_Externa_Autoridad_Externa.Descripcion
			,Narracion_Solicitud = m.Narracion_Solicitud
			,Archivo_Adjunto = m.Archivo_Adjunto
                        ,Area_AsignadaDescripcion = CultureHelper.GetTraduction(m.Area_Asignada_Area_de_Servicios_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.Area_Asignada_Area_de_Servicios_de_Apoyo.Descripcion
                        ,SubArea_AsignadaDescripcion = CultureHelper.GetTraduction(m.SubArea_Asignada_SubArea_de_Servicios_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.SubArea_Asignada_SubArea_de_Servicios_de_Apoyo.Descripcion
                        ,Dictamen_SolicitadoDescripcion = CultureHelper.GetTraduction(m.Dictamen_Solicitado_Documento.Clave.ToString(), "Documento") ?? (string)m.Dictamen_Solicitado_Documento.Descripcion
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_de_Apoyo_Externo.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_de_Apoyo_Externo.Descripcion
                        ,Fecha_de_Contestacion = (m.Fecha_de_Contestacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Contestacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Contestacion = m.Hora_de_Contestacion
                        ,Responsable_que_ContestaName = CultureHelper.GetTraduction(m.Responsable_que_Contesta_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Responsable_que_Contesta_Spartan_User.Name
			,No__Contestacion = m.No__Contestacion
                        ,DictamenDescripcion = CultureHelper.GetTraduction(m.Dictamen_Documento.Clave.ToString(), "Documento") ?? (string)m.Dictamen_Documento.Descripcion
			,Observaciones = m.Observaciones
			,Ver_Documento = m.Ver_Documento

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(46249, arrayColumnsVisible), "Solicitud_de_Apoyo_ExternaList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(46249, arrayColumnsVisible), "Solicitud_de_Apoyo_ExternaList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(46249, arrayColumnsVisible), "Solicitud_de_Apoyo_ExternaList_" + DateTime.Now.ToString());
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

            _ISolicitud_de_Apoyo_ExternaApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Solicitud_de_Apoyo_ExternaPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Solicitud_de_Apoyo_ExternaAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Solicitud_de_Apoyo_ExternaPropertyMapper oSolicitud_de_Apoyo_ExternaPropertyMapper = new Solicitud_de_Apoyo_ExternaPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oSolicitud_de_Apoyo_ExternaPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _ISolicitud_de_Apoyo_ExternaApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Solicitud_de_Apoyo_Externas == null)
                result.Solicitud_de_Apoyo_Externas = new List<Solicitud_de_Apoyo_Externa>();

            var data = result.Solicitud_de_Apoyo_Externas.Select(m => new Solicitud_de_Apoyo_ExternaGridModel
            {
                Folio = m.Folio
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_registro = m.Hora_de_registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,RegionDescripcion = CultureHelper.GetTraduction(m.Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Region_Region.Descripcion
                        ,UnidadDescripcion = CultureHelper.GetTraduction(m.Unidad_Unidad.Clave.ToString(), "Descripcion") ?? (string)m.Unidad_Unidad.Descripcion
			,Anio = m.Anio
                        ,Fecha_de_Solicitud = (m.Fecha_de_Solicitud == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Solicitud).ToString(ConfigurationProperty.DateFormat))
			,Numero_de_Oficio_Externo = m.Numero_de_Oficio_Externo
			,Solicitante = m.Solicitante
			,Rango = m.Rango
                        ,Autoridad_ExternaDescripcion = CultureHelper.GetTraduction(m.Autoridad_Externa_Autoridad_Externa.Clave.ToString(), "Descripcion") ?? (string)m.Autoridad_Externa_Autoridad_Externa.Descripcion
			,Narracion_Solicitud = m.Narracion_Solicitud
			,Archivo_Adjunto = m.Archivo_Adjunto
                        ,Area_AsignadaDescripcion = CultureHelper.GetTraduction(m.Area_Asignada_Area_de_Servicios_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.Area_Asignada_Area_de_Servicios_de_Apoyo.Descripcion
                        ,SubArea_AsignadaDescripcion = CultureHelper.GetTraduction(m.SubArea_Asignada_SubArea_de_Servicios_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.SubArea_Asignada_SubArea_de_Servicios_de_Apoyo.Descripcion
                        ,Dictamen_SolicitadoDescripcion = CultureHelper.GetTraduction(m.Dictamen_Solicitado_Documento.Clave.ToString(), "Documento") ?? (string)m.Dictamen_Solicitado_Documento.Descripcion
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_de_Apoyo_Externo.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_de_Apoyo_Externo.Descripcion
                        ,Fecha_de_Contestacion = (m.Fecha_de_Contestacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Contestacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Contestacion = m.Hora_de_Contestacion
                        ,Responsable_que_ContestaName = CultureHelper.GetTraduction(m.Responsable_que_Contesta_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Responsable_que_Contesta_Spartan_User.Name
			,No__Contestacion = m.No__Contestacion
                        ,DictamenDescripcion = CultureHelper.GetTraduction(m.Dictamen_Documento.Clave.ToString(), "Documento") ?? (string)m.Dictamen_Documento.Descripcion
			,Observaciones = m.Observaciones
			,Ver_Documento = m.Ver_Documento

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
                _ISolicitud_de_Apoyo_ExternaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISolicitud_de_Apoyo_ExternaApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Solicitud_de_Apoyo_Externa_Datos_GeneralesModel varSolicitud_de_Apoyo_Externa)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitud_de_Apoyo_ExternaApiConsumer.SetAuthHeader(_tokenManager.Token);
				                    if (varSolicitud_de_Apoyo_Externa.Archivo_AdjuntoRemoveAttachment != 0 && varSolicitud_de_Apoyo_Externa.Archivo_AdjuntoFile == null)
                    {
                        varSolicitud_de_Apoyo_Externa.Archivo_Adjunto = 0;
                    }

                    if (varSolicitud_de_Apoyo_Externa.Archivo_AdjuntoFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varSolicitud_de_Apoyo_Externa.Archivo_AdjuntoFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varSolicitud_de_Apoyo_Externa.Archivo_Adjunto = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varSolicitud_de_Apoyo_Externa.Archivo_AdjuntoFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }

                var result = "";
                var Solicitud_de_Apoyo_Externa_Datos_GeneralesInfo = new Solicitud_de_Apoyo_Externa_Datos_Generales
                {
                    Folio = varSolicitud_de_Apoyo_Externa.Folio
                                            ,Fecha_de_Registro = (!String.IsNullOrEmpty(varSolicitud_de_Apoyo_Externa.Fecha_de_Registro)) ? DateTime.ParseExact(varSolicitud_de_Apoyo_Externa.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_registro = varSolicitud_de_Apoyo_Externa.Hora_de_registro
                        ,Usuario_que_Registra = varSolicitud_de_Apoyo_Externa.Usuario_que_Registra
                        ,Region = varSolicitud_de_Apoyo_Externa.Region
                        ,Unidad = varSolicitud_de_Apoyo_Externa.Unidad
                        ,Anio = varSolicitud_de_Apoyo_Externa.Anio
                        ,Fecha_de_Solicitud = (!String.IsNullOrEmpty(varSolicitud_de_Apoyo_Externa.Fecha_de_Solicitud)) ? DateTime.ParseExact(varSolicitud_de_Apoyo_Externa.Fecha_de_Solicitud, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Numero_de_Oficio_Externo = varSolicitud_de_Apoyo_Externa.Numero_de_Oficio_Externo
                        ,Solicitante = varSolicitud_de_Apoyo_Externa.Solicitante
                        ,Rango = varSolicitud_de_Apoyo_Externa.Rango
                        ,Autoridad_Externa = varSolicitud_de_Apoyo_Externa.Autoridad_Externa
                        ,Narracion_Solicitud = varSolicitud_de_Apoyo_Externa.Narracion_Solicitud
                        ,Archivo_Adjunto = (varSolicitud_de_Apoyo_Externa.Archivo_Adjunto.HasValue && varSolicitud_de_Apoyo_Externa.Archivo_Adjunto != 0) ? ((int?)Convert.ToInt32(varSolicitud_de_Apoyo_Externa.Archivo_Adjunto.Value)) : null

                        ,Area_Asignada = varSolicitud_de_Apoyo_Externa.Area_Asignada
                        ,SubArea_Asignada = varSolicitud_de_Apoyo_Externa.SubArea_Asignada
                        ,Dictamen_Solicitado = varSolicitud_de_Apoyo_Externa.Dictamen_Solicitado
                        ,Estatus = varSolicitud_de_Apoyo_Externa.Estatus
                    
                };

                result = _ISolicitud_de_Apoyo_ExternaApiConsumer.Update_Datos_Generales(Solicitud_de_Apoyo_Externa_Datos_GeneralesInfo).Resource.ToString();
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
                _ISolicitud_de_Apoyo_ExternaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _ISolicitud_de_Apoyo_ExternaApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Solicitud_de_Apoyo_Externa_Datos_GeneralesModel
                {
                    Folio = m.Folio
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_registro = m.Hora_de_registro
                        ,Usuario_que_Registra = m.Usuario_que_Registra
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,Region = m.Region
                        ,RegionDescripcion = CultureHelper.GetTraduction(m.Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Region_Region.Descripcion
                        ,Unidad = m.Unidad
                        ,UnidadDescripcion = CultureHelper.GetTraduction(m.Unidad_Unidad.Clave.ToString(), "Descripcion") ?? (string)m.Unidad_Unidad.Descripcion
			,Anio = m.Anio
                        ,Fecha_de_Solicitud = (m.Fecha_de_Solicitud == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Solicitud).ToString(ConfigurationProperty.DateFormat))
			,Numero_de_Oficio_Externo = m.Numero_de_Oficio_Externo
			,Solicitante = m.Solicitante
			,Rango = m.Rango
                        ,Autoridad_Externa = m.Autoridad_Externa
                        ,Autoridad_ExternaDescripcion = CultureHelper.GetTraduction(m.Autoridad_Externa_Autoridad_Externa.Clave.ToString(), "Descripcion") ?? (string)m.Autoridad_Externa_Autoridad_Externa.Descripcion
			,Narracion_Solicitud = m.Narracion_Solicitud
			,Archivo_Adjunto = m.Archivo_Adjunto
                        ,Area_Asignada = m.Area_Asignada
                        ,Area_AsignadaDescripcion = CultureHelper.GetTraduction(m.Area_Asignada_Area_de_Servicios_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.Area_Asignada_Area_de_Servicios_de_Apoyo.Descripcion
                        ,SubArea_Asignada = m.SubArea_Asignada
                        ,SubArea_AsignadaDescripcion = CultureHelper.GetTraduction(m.SubArea_Asignada_SubArea_de_Servicios_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.SubArea_Asignada_SubArea_de_Servicios_de_Apoyo.Descripcion
                        ,Dictamen_Solicitado = m.Dictamen_Solicitado
                        ,Dictamen_SolicitadoDescripcion = CultureHelper.GetTraduction(m.Dictamen_Solicitado_Documento.Clave.ToString(), "Documento") ?? (string)m.Dictamen_Solicitado_Documento.Descripcion
                        ,Estatus = m.Estatus
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_de_Apoyo_Externo.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_de_Apoyo_Externo.Descripcion

                    
                };
				var resultData = new
                {
                    data = result

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Contestacion(Solicitud_de_Apoyo_Externa_ContestacionModel varSolicitud_de_Apoyo_Externa)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitud_de_Apoyo_ExternaApiConsumer.SetAuthHeader(_tokenManager.Token);
				                    if (varSolicitud_de_Apoyo_Externa.Ver_DocumentoRemoveAttachment != 0 && varSolicitud_de_Apoyo_Externa.Ver_DocumentoFile == null)
                    {
                        varSolicitud_de_Apoyo_Externa.Ver_Documento = 0;
                    }

                    if (varSolicitud_de_Apoyo_Externa.Ver_DocumentoFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varSolicitud_de_Apoyo_Externa.Ver_DocumentoFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varSolicitud_de_Apoyo_Externa.Ver_Documento = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varSolicitud_de_Apoyo_Externa.Ver_DocumentoFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }

                var result = "";
                var Solicitud_de_Apoyo_Externa_ContestacionInfo = new Solicitud_de_Apoyo_Externa_Contestacion
                {
                    Folio = varSolicitud_de_Apoyo_Externa.Folio
                                            ,Fecha_de_Contestacion = (!String.IsNullOrEmpty(varSolicitud_de_Apoyo_Externa.Fecha_de_Contestacion)) ? DateTime.ParseExact(varSolicitud_de_Apoyo_Externa.Fecha_de_Contestacion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Contestacion = varSolicitud_de_Apoyo_Externa.Hora_de_Contestacion
                        ,Responsable_que_Contesta = varSolicitud_de_Apoyo_Externa.Responsable_que_Contesta
                        ,No__Contestacion = varSolicitud_de_Apoyo_Externa.No__Contestacion
                        ,Dictamen = varSolicitud_de_Apoyo_Externa.Dictamen
                        ,Observaciones = varSolicitud_de_Apoyo_Externa.Observaciones
                        ,Ver_Documento = (varSolicitud_de_Apoyo_Externa.Ver_Documento.HasValue && varSolicitud_de_Apoyo_Externa.Ver_Documento != 0) ? ((int?)Convert.ToInt32(varSolicitud_de_Apoyo_Externa.Ver_Documento.Value)) : null

                    
                };

                result = _ISolicitud_de_Apoyo_ExternaApiConsumer.Update_Contestacion(Solicitud_de_Apoyo_Externa_ContestacionInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Contestacion(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitud_de_Apoyo_ExternaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _ISolicitud_de_Apoyo_ExternaApiConsumer.Get_Contestacion(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Solicitud_de_Apoyo_Externa_ContestacionModel
                {
                    Folio = m.Folio
                        ,Fecha_de_Contestacion = (m.Fecha_de_Contestacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Contestacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Contestacion = m.Hora_de_Contestacion
                        ,Responsable_que_Contesta = m.Responsable_que_Contesta
                        ,Responsable_que_ContestaName = CultureHelper.GetTraduction(m.Responsable_que_Contesta_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Responsable_que_Contesta_Spartan_User.Name
			,No__Contestacion = m.No__Contestacion
                        ,Dictamen = m.Dictamen
                        ,DictamenDescripcion = CultureHelper.GetTraduction(m.Dictamen_Documento.Clave.ToString(), "Documento") ?? (string)m.Dictamen_Documento.Descripcion
			,Observaciones = m.Observaciones
			,Ver_Documento = m.Ver_Documento

                    
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

