using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Solicitud_de_Notificacion;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Origen_de_Invitacion;
using Spartane.Core.Domain.Modulo_Atencion_Inicial;
using Spartane.Core.Domain.Solicitud;
using Spartane.Core.Domain.Expediente_Inicial;
using Spartane.Core.Domain.Tipo_de_Invitacion;
using Spartane.Core.Domain.Detalle_de_Invitado_de_Notificacion;




using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Colonia;





using Spartane.Core.Domain.Estatus_de_Notificacion;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Resultado_de_Notificacion;
using Spartane.Core.Domain.Incidente_con_Invitacion;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Solicitud_de_Notificacion;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Solicitud_de_Notificacion;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Origen_de_Invitacion;
using Spartane.Web.Areas.WebApiConsumer.Modulo_Atencion_Inicial;
using Spartane.Web.Areas.WebApiConsumer.Solicitud;
using Spartane.Web.Areas.WebApiConsumer.Expediente_Inicial;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Invitacion;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Invitado_de_Notificacion;

using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Colonia;

using Spartane.Web.Areas.WebApiConsumer.Estatus_de_Notificacion;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Resultado_de_Notificacion;
using Spartane.Web.Areas.WebApiConsumer.Incidente_con_Invitacion;

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
    public class Solicitud_de_NotificacionController : Controller
    {
        #region "variable declaration"

        private ISolicitud_de_NotificacionService service = null;
        private ISolicitud_de_NotificacionApiConsumer _ISolicitud_de_NotificacionApiConsumer;
        private ISpartan_UserApiConsumer _ISpartan_UserApiConsumer;
        private IOrigen_de_InvitacionApiConsumer _IOrigen_de_InvitacionApiConsumer;
        private IModulo_Atencion_InicialApiConsumer _IModulo_Atencion_InicialApiConsumer;
        private ISolicitudApiConsumer _ISolicitudApiConsumer;
        private IExpediente_InicialApiConsumer _IExpediente_InicialApiConsumer;
        private ITipo_de_InvitacionApiConsumer _ITipo_de_InvitacionApiConsumer;
        private IDetalle_de_Invitado_de_NotificacionApiConsumer _IDetalle_de_Invitado_de_NotificacionApiConsumer;

        private IEstadoApiConsumer _IEstadoApiConsumer;
        private IMunicipioApiConsumer _IMunicipioApiConsumer;
        private IColoniaApiConsumer _IColoniaApiConsumer;

        private IEstatus_de_NotificacionApiConsumer _IEstatus_de_NotificacionApiConsumer;
        private IResultado_de_NotificacionApiConsumer _IResultado_de_NotificacionApiConsumer;
        private IIncidente_con_InvitacionApiConsumer _IIncidente_con_InvitacionApiConsumer;

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

        
        public Solicitud_de_NotificacionController(ISolicitud_de_NotificacionService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, ISolicitud_de_NotificacionApiConsumer Solicitud_de_NotificacionApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , ISpartan_UserApiConsumer Spartan_UserApiConsumer , IOrigen_de_InvitacionApiConsumer Origen_de_InvitacionApiConsumer , IModulo_Atencion_InicialApiConsumer Modulo_Atencion_InicialApiConsumer , ISolicitudApiConsumer SolicitudApiConsumer , IExpediente_InicialApiConsumer Expediente_InicialApiConsumer , ITipo_de_InvitacionApiConsumer Tipo_de_InvitacionApiConsumer , IDetalle_de_Invitado_de_NotificacionApiConsumer Detalle_de_Invitado_de_NotificacionApiConsumer , IEstadoApiConsumer EstadoApiConsumer , IMunicipioApiConsumer MunicipioApiConsumer , IColoniaApiConsumer ColoniaApiConsumer  , IEstatus_de_NotificacionApiConsumer Estatus_de_NotificacionApiConsumer , IResultado_de_NotificacionApiConsumer Resultado_de_NotificacionApiConsumer , IIncidente_con_InvitacionApiConsumer Incidente_con_InvitacionApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._ISolicitud_de_NotificacionApiConsumer = Solicitud_de_NotificacionApiConsumer;
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
            this._IOrigen_de_InvitacionApiConsumer = Origen_de_InvitacionApiConsumer;
            this._IModulo_Atencion_InicialApiConsumer = Modulo_Atencion_InicialApiConsumer;
            this._ISolicitudApiConsumer = SolicitudApiConsumer;
            this._IExpediente_InicialApiConsumer = Expediente_InicialApiConsumer;
            this._ITipo_de_InvitacionApiConsumer = Tipo_de_InvitacionApiConsumer;
            this._IDetalle_de_Invitado_de_NotificacionApiConsumer = Detalle_de_Invitado_de_NotificacionApiConsumer;

            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;

            this._IEstatus_de_NotificacionApiConsumer = Estatus_de_NotificacionApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._IResultado_de_NotificacionApiConsumer = Resultado_de_NotificacionApiConsumer;
            this._IIncidente_con_InvitacionApiConsumer = Incidente_con_InvitacionApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Solicitud_de_Notificacion
        [ObjectAuth(ObjectId = (ModuleObjectId)45356, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45356, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Solicitud_de_Notificacion/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45356, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45356, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varSolicitud_de_Notificacion = new Solicitud_de_NotificacionModel();
			varSolicitud_de_Notificacion.Folio = Id;
			
            ViewBag.ObjectId = "45356";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;

            var permissionDetalle_de_Invitado_de_Notificacion = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45358, ModuleId);
            ViewBag.PermissionDetalle_de_Invitado_de_Notificacion = permissionDetalle_de_Invitado_de_Notificacion;


            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _ISolicitud_de_NotificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Solicitud_de_NotificacionsData = _ISolicitud_de_NotificacionApiConsumer.ListaSelAll(0, 1000, "Solicitud_de_Notificacion.Folio=" + Id, "").Resource.Solicitud_de_Notificacions;
				
				if (Solicitud_de_NotificacionsData != null && Solicitud_de_NotificacionsData.Count > 0)
                {
					var Solicitud_de_NotificacionData = Solicitud_de_NotificacionsData.First();
					varSolicitud_de_Notificacion= new Solicitud_de_NotificacionModel
					{
						Folio  = Solicitud_de_NotificacionData.Folio 
	                    ,Fecha_de_Solicitud = (Solicitud_de_NotificacionData.Fecha_de_Solicitud == null ? string.Empty : Convert.ToDateTime(Solicitud_de_NotificacionData.Fecha_de_Solicitud).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Solicitud = Solicitud_de_NotificacionData.Hora_de_Solicitud
                    ,Usuario_que_Solicita = Solicitud_de_NotificacionData.Usuario_que_Solicita
                    ,Usuario_que_SolicitaName = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_NotificacionData.Usuario_que_Solicita), "Spartan_User") ??  (string)Solicitud_de_NotificacionData.Usuario_que_Solicita_Spartan_User.Name
                    ,Origen = Solicitud_de_NotificacionData.Origen
                    ,OrigenDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_NotificacionData.Origen), "Origen_de_Invitacion") ??  (string)Solicitud_de_NotificacionData.Origen_Origen_de_Invitacion.Descripcion
                    ,Expediente_Atencion_Temprana = Solicitud_de_NotificacionData.Expediente_Atencion_Temprana
                    ,Expediente_Atencion_TempranaFolio = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_NotificacionData.Expediente_Atencion_Temprana), "Modulo_Atencion_Inicial") ??  (string)Solicitud_de_NotificacionData.Expediente_Atencion_Temprana_Modulo_Atencion_Inicial.Folio
                    ,Expediente_Mecanismos_Alternos = Solicitud_de_NotificacionData.Expediente_Mecanismos_Alternos
                    ,Expediente_Mecanismos_AlternosNumero_de_Folio = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_NotificacionData.Expediente_Mecanismos_Alternos), "Solicitud") ??  (string)Solicitud_de_NotificacionData.Expediente_Mecanismos_Alternos_Solicitud.Numero_de_Folio
                    ,Carpeta_de_Investigacion = Solicitud_de_NotificacionData.Carpeta_de_Investigacion
                    ,Carpeta_de_InvestigacionNIC = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_NotificacionData.Carpeta_de_Investigacion), "Expediente_Inicial") ??  (string)Solicitud_de_NotificacionData.Carpeta_de_Investigacion_Expediente_Inicial.NIC
                    ,Forma_de_Invitacion = Solicitud_de_NotificacionData.Forma_de_Invitacion
                    ,Forma_de_InvitacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_NotificacionData.Forma_de_Invitacion), "Tipo_de_Invitacion") ??  (string)Solicitud_de_NotificacionData.Forma_de_Invitacion_Tipo_de_Invitacion.Descripcion
                    ,Numero_de_Invitacion = Solicitud_de_NotificacionData.Numero_de_Invitacion
                    ,Fecha_de_la_cita = (Solicitud_de_NotificacionData.Fecha_de_la_cita == null ? string.Empty : Convert.ToDateTime(Solicitud_de_NotificacionData.Fecha_de_la_cita).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_la_Cita = Solicitud_de_NotificacionData.Hora_de_la_Cita
                    ,Lugar_de_la_Cita = Solicitud_de_NotificacionData.Lugar_de_la_Cita
                    ,Estatus = Solicitud_de_NotificacionData.Estatus
                    ,EstatusDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_NotificacionData.Estatus), "Estatus_de_Notificacion") ??  (string)Solicitud_de_NotificacionData.Estatus_Estatus_de_Notificacion.Descripcion
                    ,Fecha_de_Notificacion = (Solicitud_de_NotificacionData.Fecha_de_Notificacion == null ? string.Empty : Convert.ToDateTime(Solicitud_de_NotificacionData.Fecha_de_Notificacion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Notificacion = Solicitud_de_NotificacionData.Hora_de_Notificacion
                    ,Notificador = Solicitud_de_NotificacionData.Notificador
                    ,NotificadorName = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_NotificacionData.Notificador), "Spartan_User") ??  (string)Solicitud_de_NotificacionData.Notificador_Spartan_User.Name
                    ,Resultado = Solicitud_de_NotificacionData.Resultado
                    ,ResultadoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_NotificacionData.Resultado), "Resultado_de_Notificacion") ??  (string)Solicitud_de_NotificacionData.Resultado_Resultado_de_Notificacion.Descripcion
                    ,Archivo = Solicitud_de_NotificacionData.Archivo
                    ,Incidente_en_la_Recepcion = Solicitud_de_NotificacionData.Incidente_en_la_Recepcion
                    ,Incidente_en_la_RecepcionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_NotificacionData.Incidente_en_la_Recepcion), "Incidente_con_Invitacion") ??  (string)Solicitud_de_NotificacionData.Incidente_en_la_Recepcion_Incidente_con_Invitacion.Descripcion

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IOrigen_de_InvitacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Origen_de_Invitacions_Origen = _IOrigen_de_InvitacionApiConsumer.SelAll(true);
            if (Origen_de_Invitacions_Origen != null && Origen_de_Invitacions_Origen.Resource != null)
                ViewBag.Origen_de_Invitacions_Origen = Origen_de_Invitacions_Origen.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Origen_de_Invitacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_InvitacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Invitacions_Forma_de_Invitacion = _ITipo_de_InvitacionApiConsumer.SelAll(true);
            if (Tipo_de_Invitacions_Forma_de_Invitacion != null && Tipo_de_Invitacions_Forma_de_Invitacion.Resource != null)
                ViewBag.Tipo_de_Invitacions_Forma_de_Invitacion = Tipo_de_Invitacions_Forma_de_Invitacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Invitacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatus_de_NotificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_de_Notificacions_Estatus = _IEstatus_de_NotificacionApiConsumer.SelAll(true);
            if (Estatus_de_Notificacions_Estatus != null && Estatus_de_Notificacions_Estatus.Resource != null)
                ViewBag.Estatus_de_Notificacions_Estatus = Estatus_de_Notificacions_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Notificacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResultado_de_NotificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resultado_de_Notificacions_Resultado = _IResultado_de_NotificacionApiConsumer.SelAll(true);
            if (Resultado_de_Notificacions_Resultado != null && Resultado_de_Notificacions_Resultado.Resource != null)
                ViewBag.Resultado_de_Notificacions_Resultado = Resultado_de_Notificacions_Resultado.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resultado_de_Notificacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IIncidente_con_InvitacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Incidente_con_Invitacions_Incidente_en_la_Recepcion = _IIncidente_con_InvitacionApiConsumer.SelAll(true);
            if (Incidente_con_Invitacions_Incidente_en_la_Recepcion != null && Incidente_con_Invitacions_Incidente_en_la_Recepcion.Resource != null)
                ViewBag.Incidente_con_Invitacions_Incidente_en_la_Recepcion = Incidente_con_Invitacions_Incidente_en_la_Recepcion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Incidente_con_Invitacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varSolicitud_de_Notificacion);
        }
		
	[HttpGet]
        public ActionResult AddSolicitud_de_Notificacion(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45356);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _ISolicitud_de_NotificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
			Solicitud_de_NotificacionModel varSolicitud_de_Notificacion= new Solicitud_de_NotificacionModel();
            var permissionDetalle_de_Invitado_de_Notificacion = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45358, ModuleId);
            ViewBag.PermissionDetalle_de_Invitado_de_Notificacion = permissionDetalle_de_Invitado_de_Notificacion;


            if (id.ToString() != "0")
            {
                var Solicitud_de_NotificacionsData = _ISolicitud_de_NotificacionApiConsumer.ListaSelAll(0, 1000, "Solicitud_de_Notificacion.Folio=" + id, "").Resource.Solicitud_de_Notificacions;
				
				if (Solicitud_de_NotificacionsData != null && Solicitud_de_NotificacionsData.Count > 0)
                {
					var Solicitud_de_NotificacionData = Solicitud_de_NotificacionsData.First();
					varSolicitud_de_Notificacion= new Solicitud_de_NotificacionModel
					{
						Folio  = Solicitud_de_NotificacionData.Folio 
	                    ,Fecha_de_Solicitud = (Solicitud_de_NotificacionData.Fecha_de_Solicitud == null ? string.Empty : Convert.ToDateTime(Solicitud_de_NotificacionData.Fecha_de_Solicitud).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Solicitud = Solicitud_de_NotificacionData.Hora_de_Solicitud
                    ,Usuario_que_Solicita = Solicitud_de_NotificacionData.Usuario_que_Solicita
                    ,Usuario_que_SolicitaName = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_NotificacionData.Usuario_que_Solicita), "Spartan_User") ??  (string)Solicitud_de_NotificacionData.Usuario_que_Solicita_Spartan_User.Name
                    ,Origen = Solicitud_de_NotificacionData.Origen
                    ,OrigenDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_NotificacionData.Origen), "Origen_de_Invitacion") ??  (string)Solicitud_de_NotificacionData.Origen_Origen_de_Invitacion.Descripcion
                    ,Expediente_Atencion_Temprana = Solicitud_de_NotificacionData.Expediente_Atencion_Temprana
                    ,Expediente_Atencion_TempranaFolio = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_NotificacionData.Expediente_Atencion_Temprana), "Modulo_Atencion_Inicial") ??  (string)Solicitud_de_NotificacionData.Expediente_Atencion_Temprana_Modulo_Atencion_Inicial.Folio
                    ,Expediente_Mecanismos_Alternos = Solicitud_de_NotificacionData.Expediente_Mecanismos_Alternos
                    ,Expediente_Mecanismos_AlternosNumero_de_Folio = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_NotificacionData.Expediente_Mecanismos_Alternos), "Solicitud") ??  (string)Solicitud_de_NotificacionData.Expediente_Mecanismos_Alternos_Solicitud.Numero_de_Folio
                    ,Carpeta_de_Investigacion = Solicitud_de_NotificacionData.Carpeta_de_Investigacion
                    ,Carpeta_de_InvestigacionNIC = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_NotificacionData.Carpeta_de_Investigacion), "Expediente_Inicial") ??  (string)Solicitud_de_NotificacionData.Carpeta_de_Investigacion_Expediente_Inicial.NIC
                    ,Forma_de_Invitacion = Solicitud_de_NotificacionData.Forma_de_Invitacion
                    ,Forma_de_InvitacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_NotificacionData.Forma_de_Invitacion), "Tipo_de_Invitacion") ??  (string)Solicitud_de_NotificacionData.Forma_de_Invitacion_Tipo_de_Invitacion.Descripcion
                    ,Numero_de_Invitacion = Solicitud_de_NotificacionData.Numero_de_Invitacion
                    ,Fecha_de_la_cita = (Solicitud_de_NotificacionData.Fecha_de_la_cita == null ? string.Empty : Convert.ToDateTime(Solicitud_de_NotificacionData.Fecha_de_la_cita).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_la_Cita = Solicitud_de_NotificacionData.Hora_de_la_Cita
                    ,Lugar_de_la_Cita = Solicitud_de_NotificacionData.Lugar_de_la_Cita
                    ,Estatus = Solicitud_de_NotificacionData.Estatus
                    ,EstatusDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_NotificacionData.Estatus), "Estatus_de_Notificacion") ??  (string)Solicitud_de_NotificacionData.Estatus_Estatus_de_Notificacion.Descripcion
                    ,Fecha_de_Notificacion = (Solicitud_de_NotificacionData.Fecha_de_Notificacion == null ? string.Empty : Convert.ToDateTime(Solicitud_de_NotificacionData.Fecha_de_Notificacion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Notificacion = Solicitud_de_NotificacionData.Hora_de_Notificacion
                    ,Notificador = Solicitud_de_NotificacionData.Notificador
                    ,NotificadorName = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_NotificacionData.Notificador), "Spartan_User") ??  (string)Solicitud_de_NotificacionData.Notificador_Spartan_User.Name
                    ,Resultado = Solicitud_de_NotificacionData.Resultado
                    ,ResultadoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_NotificacionData.Resultado), "Resultado_de_Notificacion") ??  (string)Solicitud_de_NotificacionData.Resultado_Resultado_de_Notificacion.Descripcion
                    ,Archivo = Solicitud_de_NotificacionData.Archivo
                    ,Incidente_en_la_Recepcion = Solicitud_de_NotificacionData.Incidente_en_la_Recepcion
                    ,Incidente_en_la_RecepcionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_NotificacionData.Incidente_en_la_Recepcion), "Incidente_con_Invitacion") ??  (string)Solicitud_de_NotificacionData.Incidente_en_la_Recepcion_Incidente_con_Invitacion.Descripcion

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IOrigen_de_InvitacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Origen_de_Invitacions_Origen = _IOrigen_de_InvitacionApiConsumer.SelAll(true);
            if (Origen_de_Invitacions_Origen != null && Origen_de_Invitacions_Origen.Resource != null)
                ViewBag.Origen_de_Invitacions_Origen = Origen_de_Invitacions_Origen.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Origen_de_Invitacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_InvitacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Invitacions_Forma_de_Invitacion = _ITipo_de_InvitacionApiConsumer.SelAll(true);
            if (Tipo_de_Invitacions_Forma_de_Invitacion != null && Tipo_de_Invitacions_Forma_de_Invitacion.Resource != null)
                ViewBag.Tipo_de_Invitacions_Forma_de_Invitacion = Tipo_de_Invitacions_Forma_de_Invitacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Invitacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatus_de_NotificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_de_Notificacions_Estatus = _IEstatus_de_NotificacionApiConsumer.SelAll(true);
            if (Estatus_de_Notificacions_Estatus != null && Estatus_de_Notificacions_Estatus.Resource != null)
                ViewBag.Estatus_de_Notificacions_Estatus = Estatus_de_Notificacions_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Notificacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResultado_de_NotificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resultado_de_Notificacions_Resultado = _IResultado_de_NotificacionApiConsumer.SelAll(true);
            if (Resultado_de_Notificacions_Resultado != null && Resultado_de_Notificacions_Resultado.Resource != null)
                ViewBag.Resultado_de_Notificacions_Resultado = Resultado_de_Notificacions_Resultado.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resultado_de_Notificacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IIncidente_con_InvitacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Incidente_con_Invitacions_Incidente_en_la_Recepcion = _IIncidente_con_InvitacionApiConsumer.SelAll(true);
            if (Incidente_con_Invitacions_Incidente_en_la_Recepcion != null && Incidente_con_Invitacions_Incidente_en_la_Recepcion.Resource != null)
                ViewBag.Incidente_con_Invitacions_Incidente_en_la_Recepcion = Incidente_con_Invitacions_Incidente_en_la_Recepcion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Incidente_con_Invitacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddSolicitud_de_Notificacion", varSolicitud_de_Notificacion);
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
        public ActionResult GetOrigen_de_InvitacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IOrigen_de_InvitacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IOrigen_de_InvitacionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Origen_de_Invitacion", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
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
				
                return Json(result.OrderBy(m => m.Folio).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modulo_Atencion_Inicial", "Folio")?? m.Folio,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
		[HttpGet]
        public ActionResult GetSolicitudAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISolicitudApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Numero_de_Folio).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Solicitud", "Numero_de_Folio")?? m.Numero_de_Folio,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
		[HttpGet]
        public ActionResult GetExpediente_InicialAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IExpediente_InicialApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.NIC).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Expediente_Inicial", "NIC")?? m.NIC,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetTipo_de_InvitacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_InvitacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_InvitacionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Invitacion", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetEstatus_de_NotificacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstatus_de_NotificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstatus_de_NotificacionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Notificacion", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetResultado_de_NotificacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IResultado_de_NotificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IResultado_de_NotificacionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resultado_de_Notificacion", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetIncidente_con_InvitacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IIncidente_con_InvitacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IIncidente_con_InvitacionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Incidente_con_Invitacion", "Descripcion")?? m.Descripcion,
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
        public ActionResult ShowAdvanceFilter(Solicitud_de_NotificacionAdvanceSearchModel model, int idFilter = -1)
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

            _IOrigen_de_InvitacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Origen_de_Invitacions_Origen = _IOrigen_de_InvitacionApiConsumer.SelAll(true);
            if (Origen_de_Invitacions_Origen != null && Origen_de_Invitacions_Origen.Resource != null)
                ViewBag.Origen_de_Invitacions_Origen = Origen_de_Invitacions_Origen.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Origen_de_Invitacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_InvitacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Invitacions_Forma_de_Invitacion = _ITipo_de_InvitacionApiConsumer.SelAll(true);
            if (Tipo_de_Invitacions_Forma_de_Invitacion != null && Tipo_de_Invitacions_Forma_de_Invitacion.Resource != null)
                ViewBag.Tipo_de_Invitacions_Forma_de_Invitacion = Tipo_de_Invitacions_Forma_de_Invitacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Invitacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatus_de_NotificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_de_Notificacions_Estatus = _IEstatus_de_NotificacionApiConsumer.SelAll(true);
            if (Estatus_de_Notificacions_Estatus != null && Estatus_de_Notificacions_Estatus.Resource != null)
                ViewBag.Estatus_de_Notificacions_Estatus = Estatus_de_Notificacions_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Notificacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResultado_de_NotificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resultado_de_Notificacions_Resultado = _IResultado_de_NotificacionApiConsumer.SelAll(true);
            if (Resultado_de_Notificacions_Resultado != null && Resultado_de_Notificacions_Resultado.Resource != null)
                ViewBag.Resultado_de_Notificacions_Resultado = Resultado_de_Notificacions_Resultado.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resultado_de_Notificacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IIncidente_con_InvitacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Incidente_con_Invitacions_Incidente_en_la_Recepcion = _IIncidente_con_InvitacionApiConsumer.SelAll(true);
            if (Incidente_con_Invitacions_Incidente_en_la_Recepcion != null && Incidente_con_Invitacions_Incidente_en_la_Recepcion.Resource != null)
                ViewBag.Incidente_con_Invitacions_Incidente_en_la_Recepcion = Incidente_con_Invitacions_Incidente_en_la_Recepcion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Incidente_con_Invitacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IOrigen_de_InvitacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Origen_de_Invitacions_Origen = _IOrigen_de_InvitacionApiConsumer.SelAll(true);
            if (Origen_de_Invitacions_Origen != null && Origen_de_Invitacions_Origen.Resource != null)
                ViewBag.Origen_de_Invitacions_Origen = Origen_de_Invitacions_Origen.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Origen_de_Invitacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_InvitacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Invitacions_Forma_de_Invitacion = _ITipo_de_InvitacionApiConsumer.SelAll(true);
            if (Tipo_de_Invitacions_Forma_de_Invitacion != null && Tipo_de_Invitacions_Forma_de_Invitacion.Resource != null)
                ViewBag.Tipo_de_Invitacions_Forma_de_Invitacion = Tipo_de_Invitacions_Forma_de_Invitacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Invitacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatus_de_NotificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_de_Notificacions_Estatus = _IEstatus_de_NotificacionApiConsumer.SelAll(true);
            if (Estatus_de_Notificacions_Estatus != null && Estatus_de_Notificacions_Estatus.Resource != null)
                ViewBag.Estatus_de_Notificacions_Estatus = Estatus_de_Notificacions_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Notificacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResultado_de_NotificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resultado_de_Notificacions_Resultado = _IResultado_de_NotificacionApiConsumer.SelAll(true);
            if (Resultado_de_Notificacions_Resultado != null && Resultado_de_Notificacions_Resultado.Resource != null)
                ViewBag.Resultado_de_Notificacions_Resultado = Resultado_de_Notificacions_Resultado.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resultado_de_Notificacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IIncidente_con_InvitacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Incidente_con_Invitacions_Incidente_en_la_Recepcion = _IIncidente_con_InvitacionApiConsumer.SelAll(true);
            if (Incidente_con_Invitacions_Incidente_en_la_Recepcion != null && Incidente_con_Invitacions_Incidente_en_la_Recepcion.Resource != null)
                ViewBag.Incidente_con_Invitacions_Incidente_en_la_Recepcion = Incidente_con_Invitacions_Incidente_en_la_Recepcion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Incidente_con_Invitacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Solicitud_de_NotificacionAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Solicitud_de_NotificacionAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Solicitud_de_NotificacionAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Solicitud_de_NotificacionPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _ISolicitud_de_NotificacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Solicitud_de_Notificacions == null)
                result.Solicitud_de_Notificacions = new List<Solicitud_de_Notificacion>();

            return Json(new
            {
                data = result.Solicitud_de_Notificacions.Select(m => new Solicitud_de_NotificacionGridModel
                    {
                    Folio = m.Folio
                        ,Fecha_de_Solicitud = (m.Fecha_de_Solicitud == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Solicitud).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Solicitud = m.Hora_de_Solicitud
                        ,Usuario_que_SolicitaName = CultureHelper.GetTraduction(m.Usuario_que_Solicita_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Solicita_Spartan_User.Name
                        ,OrigenDescripcion = CultureHelper.GetTraduction(m.Origen_Origen_de_Invitacion.Clave.ToString(), "Descripcion") ?? (string)m.Origen_Origen_de_Invitacion.Descripcion
                        ,Expediente_Atencion_TempranaFolio = CultureHelper.GetTraduction(m.Expediente_Atencion_Temprana_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Expediente_Atencion_Temprana_Modulo_Atencion_Inicial.Folio
                        ,Expediente_Mecanismos_AlternosNumero_de_Folio = CultureHelper.GetTraduction(m.Expediente_Mecanismos_Alternos_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Expediente_Mecanismos_Alternos_Solicitud.Numero_de_Folio
                        ,Carpeta_de_InvestigacionNIC = CultureHelper.GetTraduction(m.Carpeta_de_Investigacion_Expediente_Inicial.Clave.ToString(), "Expediente_Inicial") ?? (string)m.Carpeta_de_Investigacion_Expediente_Inicial.NIC
                        ,Forma_de_InvitacionDescripcion = CultureHelper.GetTraduction(m.Forma_de_Invitacion_Tipo_de_Invitacion.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Invitacion_Tipo_de_Invitacion.Descripcion
			,Numero_de_Invitacion = m.Numero_de_Invitacion
                        ,Fecha_de_la_cita = (m.Fecha_de_la_cita == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_la_cita).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_la_Cita = m.Hora_de_la_Cita
			,Lugar_de_la_Cita = m.Lugar_de_la_Cita
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_de_Notificacion.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_de_Notificacion.Descripcion
                        ,Fecha_de_Notificacion = (m.Fecha_de_Notificacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Notificacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Notificacion = m.Hora_de_Notificacion
                        ,NotificadorName = CultureHelper.GetTraduction(m.Notificador_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Notificador_Spartan_User.Name
                        ,ResultadoDescripcion = CultureHelper.GetTraduction(m.Resultado_Resultado_de_Notificacion.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_Resultado_de_Notificacion.Descripcion
			,Archivo = m.Archivo
                        ,Incidente_en_la_RecepcionDescripcion = CultureHelper.GetTraduction(m.Incidente_en_la_Recepcion_Incidente_con_Invitacion.Clave.ToString(), "Descripcion") ?? (string)m.Incidente_en_la_Recepcion_Incidente_con_Invitacion.Descripcion

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetSolicitud_de_NotificacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitud_de_NotificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISolicitud_de_NotificacionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Folio), "Solicitud_de_Notificacion", m.),
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
        /// Get List of Solicitud_de_Notificacion from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Solicitud_de_Notificacion Entity</returns>
        public ActionResult GetSolicitud_de_NotificacionList(UrlParametersModel param)
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
            _ISolicitud_de_NotificacionApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Solicitud_de_NotificacionPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Solicitud_de_NotificacionAdvanceSearchModel))
                {
					var advanceFilter =
                    (Solicitud_de_NotificacionAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Solicitud_de_NotificacionPropertyMapper oSolicitud_de_NotificacionPropertyMapper = new Solicitud_de_NotificacionPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oSolicitud_de_NotificacionPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _ISolicitud_de_NotificacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Solicitud_de_Notificacions == null)
                result.Solicitud_de_Notificacions = new List<Solicitud_de_Notificacion>();

            return Json(new
            {
                aaData = result.Solicitud_de_Notificacions.Select(m => new Solicitud_de_NotificacionGridModel
            {
                    Folio = m.Folio
                        ,Fecha_de_Solicitud = (m.Fecha_de_Solicitud == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Solicitud).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Solicitud = m.Hora_de_Solicitud
                        ,Usuario_que_SolicitaName = CultureHelper.GetTraduction(m.Usuario_que_Solicita_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Solicita_Spartan_User.Name
                        ,OrigenDescripcion = CultureHelper.GetTraduction(m.Origen_Origen_de_Invitacion.Clave.ToString(), "Descripcion") ?? (string)m.Origen_Origen_de_Invitacion.Descripcion
                        ,Expediente_Atencion_TempranaFolio = CultureHelper.GetTraduction(m.Expediente_Atencion_Temprana_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Expediente_Atencion_Temprana_Modulo_Atencion_Inicial.Folio
                        ,Expediente_Mecanismos_AlternosNumero_de_Folio = CultureHelper.GetTraduction(m.Expediente_Mecanismos_Alternos_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Expediente_Mecanismos_Alternos_Solicitud.Numero_de_Folio
                        ,Carpeta_de_InvestigacionNIC = CultureHelper.GetTraduction(m.Carpeta_de_Investigacion_Expediente_Inicial.Clave.ToString(), "Expediente_Inicial") ?? (string)m.Carpeta_de_Investigacion_Expediente_Inicial.NIC
                        ,Forma_de_InvitacionDescripcion = CultureHelper.GetTraduction(m.Forma_de_Invitacion_Tipo_de_Invitacion.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Invitacion_Tipo_de_Invitacion.Descripcion
			,Numero_de_Invitacion = m.Numero_de_Invitacion
                        ,Fecha_de_la_cita = (m.Fecha_de_la_cita == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_la_cita).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_la_Cita = m.Hora_de_la_Cita
			,Lugar_de_la_Cita = m.Lugar_de_la_Cita
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_de_Notificacion.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_de_Notificacion.Descripcion
                        ,Fecha_de_Notificacion = (m.Fecha_de_Notificacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Notificacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Notificacion = m.Hora_de_Notificacion
                        ,NotificadorName = CultureHelper.GetTraduction(m.Notificador_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Notificador_Spartan_User.Name
                        ,ResultadoDescripcion = CultureHelper.GetTraduction(m.Resultado_Resultado_de_Notificacion.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_Resultado_de_Notificacion.Descripcion
			,Archivo = m.Archivo
                        ,Incidente_en_la_RecepcionDescripcion = CultureHelper.GetTraduction(m.Incidente_en_la_Recepcion_Incidente_con_Invitacion.Clave.ToString(), "Descripcion") ?? (string)m.Incidente_en_la_Recepcion_Incidente_con_Invitacion.Descripcion

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetSolicitud_de_Notificacion_Usuario_que_Solicita_Spartan_User(string query, string where)
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
        public JsonResult GetSolicitud_de_Notificacion_Expediente_Atencion_Temprana_Modulo_Atencion_Inicial(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModulo_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Modulo_Atencion_Inicial.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Modulo_Atencion_Inicial.Folio as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IModulo_Atencion_InicialApiConsumer.ListaSelAll(1, 20,elWhere , " Modulo_Atencion_Inicial.Folio ASC ").Resource;
               
                foreach (var item in result.Modulo_Atencion_Inicials)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Modulo_Atencion_Inicial", "Folio");
                    item.Folio =trans ??item.Folio;
                }
                return Json(result.Modulo_Atencion_Inicials.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetSolicitud_de_Notificacion_Expediente_Mecanismos_Alternos_Solicitud(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Solicitud.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Solicitud.Numero_de_Folio as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _ISolicitudApiConsumer.ListaSelAll(1, 20,elWhere , " Solicitud.Numero_de_Folio ASC ").Resource;
               
                foreach (var item in result.Solicituds)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Solicitud", "Numero_de_Folio");
                    item.Numero_de_Folio =trans ??item.Numero_de_Folio;
                }
                return Json(result.Solicituds.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetSolicitud_de_Notificacion_Carpeta_de_Investigacion_Expediente_Inicial(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Expediente_Inicial.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Expediente_Inicial.NIC as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IExpediente_InicialApiConsumer.ListaSelAll(1, 20,elWhere , " Expediente_Inicial.NIC ASC ").Resource;
               
                foreach (var item in result.Expediente_Inicials)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Expediente_Inicial", "NIC");
                    item.NIC =trans ??item.NIC;
                }
                return Json(result.Expediente_Inicials.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
//Grid GetAutoComplete
        [HttpGet]
        public JsonResult GetDetalle_de_Invitado_de_Notificacion_Estado_Estado(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Estado.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Estado.Nombre as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IEstadoApiConsumer.ListaSelAll(1, 20,elWhere , " Estado.Nombre ASC ").Resource;
               
                foreach (var item in result.Estados)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Estado", "Nombre");
                    item.Nombre =trans ??item.Nombre;
                }
                return Json(result.Estados.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetDetalle_de_Invitado_de_Notificacion_Municipio_Municipio(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Municipio.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Municipio.Nombre as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IMunicipioApiConsumer.ListaSelAll(1, 20,elWhere , " Municipio.Nombre ASC ").Resource;
               
                foreach (var item in result.Municipios)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Municipio", "Nombre");
                    item.Nombre =trans ??item.Nombre;
                }
                return Json(result.Municipios.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetDetalle_de_Invitado_de_Notificacion_Poblacion_Colonia(string query, string where)
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
        [HttpGet]
        public JsonResult GetDetalle_de_Invitado_de_Notificacion_Colonia_Colonia(string query, string where)
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

        [HttpGet]
        public JsonResult GetSolicitud_de_Notificacion_Notificador_Spartan_User(string query, string where)
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
        public string GetAdvanceFilter(Solicitud_de_NotificacionAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromFolio) || !string.IsNullOrEmpty(filter.ToFolio))
            {
                if (!string.IsNullOrEmpty(filter.FromFolio))
                    where += " AND Solicitud_de_Notificacion.Folio >= " + filter.FromFolio;
                if (!string.IsNullOrEmpty(filter.ToFolio))
                    where += " AND Solicitud_de_Notificacion.Folio <= " + filter.ToFolio;
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Solicitud) || !string.IsNullOrEmpty(filter.ToFecha_de_Solicitud))
            {
                var Fecha_de_SolicitudFrom = DateTime.ParseExact(filter.FromFecha_de_Solicitud, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_SolicitudTo = DateTime.ParseExact(filter.ToFecha_de_Solicitud, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Solicitud))
                    where += " AND Solicitud_de_Notificacion.Fecha_de_Solicitud >= '" + Fecha_de_SolicitudFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Solicitud))
                    where += " AND Solicitud_de_Notificacion.Fecha_de_Solicitud <= '" + Fecha_de_SolicitudTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Solicitud) || !string.IsNullOrEmpty(filter.ToHora_de_Solicitud))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Solicitud))
                    where += " AND Convert(TIME,Solicitud_de_Notificacion.Hora_de_Solicitud) >='" + filter.FromHora_de_Solicitud + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Solicitud))
                    where += " AND Convert(TIME,Solicitud_de_Notificacion.Hora_de_Solicitud) <='" + filter.ToHora_de_Solicitud + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceUsuario_que_Solicita))
            {
                switch (filter.Usuario_que_SolicitaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_User.Name LIKE '" + filter.AdvanceUsuario_que_Solicita + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceUsuario_que_Solicita + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_User.Name = '" + filter.AdvanceUsuario_que_Solicita + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceUsuario_que_Solicita + "%'";
                        break;
                }
            }
            else if (filter.AdvanceUsuario_que_SolicitaMultiple != null && filter.AdvanceUsuario_que_SolicitaMultiple.Count() > 0)
            {
                var Usuario_que_SolicitaIds = string.Join(",", filter.AdvanceUsuario_que_SolicitaMultiple);

                where += " AND Solicitud_de_Notificacion.Usuario_que_Solicita In (" + Usuario_que_SolicitaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceOrigen))
            {
                switch (filter.OrigenFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Origen_de_Invitacion.Descripcion LIKE '" + filter.AdvanceOrigen + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Origen_de_Invitacion.Descripcion LIKE '%" + filter.AdvanceOrigen + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Origen_de_Invitacion.Descripcion = '" + filter.AdvanceOrigen + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Origen_de_Invitacion.Descripcion LIKE '%" + filter.AdvanceOrigen + "%'";
                        break;
                }
            }
            else if (filter.AdvanceOrigenMultiple != null && filter.AdvanceOrigenMultiple.Count() > 0)
            {
                var OrigenIds = string.Join(",", filter.AdvanceOrigenMultiple);

                where += " AND Solicitud_de_Notificacion.Origen In (" + OrigenIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceExpediente_Atencion_Temprana))
            {
                switch (filter.Expediente_Atencion_TempranaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_Atencion_Inicial.Folio LIKE '" + filter.AdvanceExpediente_Atencion_Temprana + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_Atencion_Inicial.Folio LIKE '%" + filter.AdvanceExpediente_Atencion_Temprana + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_Atencion_Inicial.Folio = '" + filter.AdvanceExpediente_Atencion_Temprana + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_Atencion_Inicial.Folio LIKE '%" + filter.AdvanceExpediente_Atencion_Temprana + "%'";
                        break;
                }
            }
            else if (filter.AdvanceExpediente_Atencion_TempranaMultiple != null && filter.AdvanceExpediente_Atencion_TempranaMultiple.Count() > 0)
            {
                var Expediente_Atencion_TempranaIds = string.Join(",", filter.AdvanceExpediente_Atencion_TempranaMultiple);

                where += " AND Solicitud_de_Notificacion.Expediente_Atencion_Temprana In (" + Expediente_Atencion_TempranaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceExpediente_Mecanismos_Alternos))
            {
                switch (filter.Expediente_Mecanismos_AlternosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud.Numero_de_Folio LIKE '" + filter.AdvanceExpediente_Mecanismos_Alternos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud.Numero_de_Folio LIKE '%" + filter.AdvanceExpediente_Mecanismos_Alternos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud.Numero_de_Folio = '" + filter.AdvanceExpediente_Mecanismos_Alternos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud.Numero_de_Folio LIKE '%" + filter.AdvanceExpediente_Mecanismos_Alternos + "%'";
                        break;
                }
            }
            else if (filter.AdvanceExpediente_Mecanismos_AlternosMultiple != null && filter.AdvanceExpediente_Mecanismos_AlternosMultiple.Count() > 0)
            {
                var Expediente_Mecanismos_AlternosIds = string.Join(",", filter.AdvanceExpediente_Mecanismos_AlternosMultiple);

                where += " AND Solicitud_de_Notificacion.Expediente_Mecanismos_Alternos In (" + Expediente_Mecanismos_AlternosIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceCarpeta_de_Investigacion))
            {
                switch (filter.Carpeta_de_InvestigacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Expediente_Inicial.NIC LIKE '" + filter.AdvanceCarpeta_de_Investigacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Expediente_Inicial.NIC LIKE '%" + filter.AdvanceCarpeta_de_Investigacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Expediente_Inicial.NIC = '" + filter.AdvanceCarpeta_de_Investigacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Expediente_Inicial.NIC LIKE '%" + filter.AdvanceCarpeta_de_Investigacion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceCarpeta_de_InvestigacionMultiple != null && filter.AdvanceCarpeta_de_InvestigacionMultiple.Count() > 0)
            {
                var Carpeta_de_InvestigacionIds = string.Join(",", filter.AdvanceCarpeta_de_InvestigacionMultiple);

                where += " AND Solicitud_de_Notificacion.Carpeta_de_Investigacion In (" + Carpeta_de_InvestigacionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceForma_de_Invitacion))
            {
                switch (filter.Forma_de_InvitacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Invitacion.Descripcion LIKE '" + filter.AdvanceForma_de_Invitacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Invitacion.Descripcion LIKE '%" + filter.AdvanceForma_de_Invitacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Invitacion.Descripcion = '" + filter.AdvanceForma_de_Invitacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Invitacion.Descripcion LIKE '%" + filter.AdvanceForma_de_Invitacion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceForma_de_InvitacionMultiple != null && filter.AdvanceForma_de_InvitacionMultiple.Count() > 0)
            {
                var Forma_de_InvitacionIds = string.Join(",", filter.AdvanceForma_de_InvitacionMultiple);

                where += " AND Solicitud_de_Notificacion.Forma_de_Invitacion In (" + Forma_de_InvitacionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Numero_de_Invitacion))
            {
                switch (filter.Numero_de_InvitacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud_de_Notificacion.Numero_de_Invitacion LIKE '" + filter.Numero_de_Invitacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud_de_Notificacion.Numero_de_Invitacion LIKE '%" + filter.Numero_de_Invitacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud_de_Notificacion.Numero_de_Invitacion = '" + filter.Numero_de_Invitacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud_de_Notificacion.Numero_de_Invitacion LIKE '%" + filter.Numero_de_Invitacion + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_la_cita) || !string.IsNullOrEmpty(filter.ToFecha_de_la_cita))
            {
                var Fecha_de_la_citaFrom = DateTime.ParseExact(filter.FromFecha_de_la_cita, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_la_citaTo = DateTime.ParseExact(filter.ToFecha_de_la_cita, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_la_cita))
                    where += " AND Solicitud_de_Notificacion.Fecha_de_la_cita >= '" + Fecha_de_la_citaFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_la_cita))
                    where += " AND Solicitud_de_Notificacion.Fecha_de_la_cita <= '" + Fecha_de_la_citaTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_la_Cita) || !string.IsNullOrEmpty(filter.ToHora_de_la_Cita))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_la_Cita))
                    where += " AND Convert(TIME,Solicitud_de_Notificacion.Hora_de_la_Cita) >='" + filter.FromHora_de_la_Cita + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_la_Cita))
                    where += " AND Convert(TIME,Solicitud_de_Notificacion.Hora_de_la_Cita) <='" + filter.ToHora_de_la_Cita + "'";
            }

            if (!string.IsNullOrEmpty(filter.Lugar_de_la_Cita))
            {
                switch (filter.Lugar_de_la_CitaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud_de_Notificacion.Lugar_de_la_Cita LIKE '" + filter.Lugar_de_la_Cita + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud_de_Notificacion.Lugar_de_la_Cita LIKE '%" + filter.Lugar_de_la_Cita + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud_de_Notificacion.Lugar_de_la_Cita = '" + filter.Lugar_de_la_Cita + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud_de_Notificacion.Lugar_de_la_Cita LIKE '%" + filter.Lugar_de_la_Cita + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstatus))
            {
                switch (filter.EstatusFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estatus_de_Notificacion.Descripcion LIKE '" + filter.AdvanceEstatus + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estatus_de_Notificacion.Descripcion LIKE '%" + filter.AdvanceEstatus + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estatus_de_Notificacion.Descripcion = '" + filter.AdvanceEstatus + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estatus_de_Notificacion.Descripcion LIKE '%" + filter.AdvanceEstatus + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstatusMultiple != null && filter.AdvanceEstatusMultiple.Count() > 0)
            {
                var EstatusIds = string.Join(",", filter.AdvanceEstatusMultiple);

                where += " AND Solicitud_de_Notificacion.Estatus In (" + EstatusIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Notificacion) || !string.IsNullOrEmpty(filter.ToFecha_de_Notificacion))
            {
                var Fecha_de_NotificacionFrom = DateTime.ParseExact(filter.FromFecha_de_Notificacion, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_NotificacionTo = DateTime.ParseExact(filter.ToFecha_de_Notificacion, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Notificacion))
                    where += " AND Solicitud_de_Notificacion.Fecha_de_Notificacion >= '" + Fecha_de_NotificacionFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Notificacion))
                    where += " AND Solicitud_de_Notificacion.Fecha_de_Notificacion <= '" + Fecha_de_NotificacionTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Notificacion) || !string.IsNullOrEmpty(filter.ToHora_de_Notificacion))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Notificacion))
                    where += " AND Convert(TIME,Solicitud_de_Notificacion.Hora_de_Notificacion) >='" + filter.FromHora_de_Notificacion + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Notificacion))
                    where += " AND Convert(TIME,Solicitud_de_Notificacion.Hora_de_Notificacion) <='" + filter.ToHora_de_Notificacion + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceNotificador))
            {
                switch (filter.NotificadorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_User.Name LIKE '" + filter.AdvanceNotificador + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceNotificador + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_User.Name = '" + filter.AdvanceNotificador + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceNotificador + "%'";
                        break;
                }
            }
            else if (filter.AdvanceNotificadorMultiple != null && filter.AdvanceNotificadorMultiple.Count() > 0)
            {
                var NotificadorIds = string.Join(",", filter.AdvanceNotificadorMultiple);

                where += " AND Solicitud_de_Notificacion.Notificador In (" + NotificadorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceResultado))
            {
                switch (filter.ResultadoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Resultado_de_Notificacion.Descripcion LIKE '" + filter.AdvanceResultado + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Resultado_de_Notificacion.Descripcion LIKE '%" + filter.AdvanceResultado + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Resultado_de_Notificacion.Descripcion = '" + filter.AdvanceResultado + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Resultado_de_Notificacion.Descripcion LIKE '%" + filter.AdvanceResultado + "%'";
                        break;
                }
            }
            else if (filter.AdvanceResultadoMultiple != null && filter.AdvanceResultadoMultiple.Count() > 0)
            {
                var ResultadoIds = string.Join(",", filter.AdvanceResultadoMultiple);

                where += " AND Solicitud_de_Notificacion.Resultado In (" + ResultadoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromArchivo) || !string.IsNullOrEmpty(filter.ToArchivo))
            {
                if (!string.IsNullOrEmpty(filter.FromArchivo))
                    where += " AND Solicitud_de_Notificacion.Archivo >= " + filter.FromArchivo;
                if (!string.IsNullOrEmpty(filter.ToArchivo))
                    where += " AND Solicitud_de_Notificacion.Archivo <= " + filter.ToArchivo;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceIncidente_en_la_Recepcion))
            {
                switch (filter.Incidente_en_la_RecepcionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Incidente_con_Invitacion.Descripcion LIKE '" + filter.AdvanceIncidente_en_la_Recepcion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Incidente_con_Invitacion.Descripcion LIKE '%" + filter.AdvanceIncidente_en_la_Recepcion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Incidente_con_Invitacion.Descripcion = '" + filter.AdvanceIncidente_en_la_Recepcion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Incidente_con_Invitacion.Descripcion LIKE '%" + filter.AdvanceIncidente_en_la_Recepcion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceIncidente_en_la_RecepcionMultiple != null && filter.AdvanceIncidente_en_la_RecepcionMultiple.Count() > 0)
            {
                var Incidente_en_la_RecepcionIds = string.Join(",", filter.AdvanceIncidente_en_la_RecepcionMultiple);

                where += " AND Solicitud_de_Notificacion.Incidente_en_la_Recepcion In (" + Incidente_en_la_RecepcionIds + ")";
            }


            where = new Regex(Regex.Escape("AND ")).Replace(where, "", 1);
            return where;
        }

        [NonAction]
        public Grid_File ConvertSpartane_FileToGridFile(Spartane.Core.Domain.Spartane_File.Spartane_File file)
        {
            return file == null ? new Grid_File { FileId = 0, FileSize = 0, FileName = "" } : new Grid_File { FileId = file.File_Id, FileName = file.Description, FileSize = file.File_Size ?? 0, };
        }

        public ActionResult GetDetalle_de_Invitado_de_Notificacion(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_Invitado_de_NotificacionGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Invitado_de_NotificacionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_Invitado_de_Notificacion.Solicitud_de_Notificacion=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_Invitado_de_Notificacion.Solicitud_de_Notificacion='" + RelationId + "'";
            }
            var result = _IDetalle_de_Invitado_de_NotificacionApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_Invitado_de_Notificacions == null)
                result.Detalle_de_Invitado_de_Notificacions = new List<Detalle_de_Invitado_de_Notificacion>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_Invitado_de_Notificacions.Select(m => new Detalle_de_Invitado_de_NotificacionGridModel
                {
                    Folio = m.Folio

			,Nombre_Completo = m.Nombre_Completo
			,Telefono = m.Telefono
			,Correo_Electronico = m.Correo_Electronico
                        ,Estado = m.Estado
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Nombre") ??(string)m.Estado_Estado.Nombre
                        ,Municipio = m.Municipio
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Nombre") ??(string)m.Municipio_Municipio.Nombre
                        ,Poblacion = m.Poblacion
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Nombre") ??(string)m.Poblacion_Colonia.Nombre
                        ,Colonia = m.Colonia
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Nombre") ??(string)m.Colonia_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
			,Calle = m.Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_Invitado_de_NotificacionGridModel> GetDetalle_de_Invitado_de_NotificacionData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_Invitado_de_NotificacionGridModel> resultData = new List<Detalle_de_Invitado_de_NotificacionGridModel>();
            string where = "Detalle_de_Invitado_de_Notificacion.Solicitud_de_Notificacion=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_Invitado_de_Notificacion.Solicitud_de_Notificacion='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Invitado_de_NotificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_Invitado_de_NotificacionApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_Invitado_de_Notificacions != null)
            {
                resultData = result.Detalle_de_Invitado_de_Notificacions.Select(m => new Detalle_de_Invitado_de_NotificacionGridModel
                    {
                        Folio = m.Folio

			,Nombre_Completo = m.Nombre_Completo
			,Telefono = m.Telefono
			,Correo_Electronico = m.Correo_Electronico
                        ,Estado = m.Estado
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Nombre") ??(string)m.Estado_Estado.Nombre
                        ,Municipio = m.Municipio
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Nombre") ??(string)m.Municipio_Municipio.Nombre
                        ,Poblacion = m.Poblacion
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Nombre") ??(string)m.Poblacion_Colonia.Nombre
                        ,Colonia = m.Colonia
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Nombre") ??(string)m.Colonia_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
			,Calle = m.Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior


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
                _ISolicitud_de_NotificacionApiConsumer.SetAuthHeader(_tokenManager.Token);

                Solicitud_de_Notificacion varSolicitud_de_Notificacion = null;
                if (id.ToString() != "0")
                {
                        string where = "";
                    _IDetalle_de_Invitado_de_NotificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_Invitado_de_Notificacion.Solicitud_de_Notificacion=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_Invitado_de_Notificacion.Solicitud_de_Notificacion='" + id + "'";
                    }
                    var Detalle_de_Invitado_de_NotificacionInfo =
                        _IDetalle_de_Invitado_de_NotificacionApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_Invitado_de_NotificacionInfo.Detalle_de_Invitado_de_Notificacions.Count > 0)
                    {
                        var resultDetalle_de_Invitado_de_Notificacion = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_Invitado_de_NotificacionItem in Detalle_de_Invitado_de_NotificacionInfo.Detalle_de_Invitado_de_Notificacions)
                            resultDetalle_de_Invitado_de_Notificacion = resultDetalle_de_Invitado_de_Notificacion
                                              && _IDetalle_de_Invitado_de_NotificacionApiConsumer.Delete(Detalle_de_Invitado_de_NotificacionItem.Folio, null,null).Resource;

                        if (!resultDetalle_de_Invitado_de_Notificacion)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }

                }
                var result = _ISolicitud_de_NotificacionApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Solicitud_de_NotificacionModel varSolicitud_de_Notificacion)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _ISolicitud_de_NotificacionApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Solicitud_de_NotificacionInfo = new Solicitud_de_Notificacion
                    {
                        Folio = varSolicitud_de_Notificacion.Folio
                        ,Fecha_de_Solicitud = (!String.IsNullOrEmpty(varSolicitud_de_Notificacion.Fecha_de_Solicitud)) ? DateTime.ParseExact(varSolicitud_de_Notificacion.Fecha_de_Solicitud, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Solicitud = varSolicitud_de_Notificacion.Hora_de_Solicitud
                        ,Usuario_que_Solicita = varSolicitud_de_Notificacion.Usuario_que_Solicita
                        ,Origen = varSolicitud_de_Notificacion.Origen
                        ,Expediente_Atencion_Temprana = varSolicitud_de_Notificacion.Expediente_Atencion_Temprana
                        ,Expediente_Mecanismos_Alternos = varSolicitud_de_Notificacion.Expediente_Mecanismos_Alternos
                        ,Carpeta_de_Investigacion = varSolicitud_de_Notificacion.Carpeta_de_Investigacion
                        ,Forma_de_Invitacion = varSolicitud_de_Notificacion.Forma_de_Invitacion
                        ,Numero_de_Invitacion = varSolicitud_de_Notificacion.Numero_de_Invitacion
                        ,Fecha_de_la_cita = (!String.IsNullOrEmpty(varSolicitud_de_Notificacion.Fecha_de_la_cita)) ? DateTime.ParseExact(varSolicitud_de_Notificacion.Fecha_de_la_cita, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_la_Cita = varSolicitud_de_Notificacion.Hora_de_la_Cita
                        ,Lugar_de_la_Cita = varSolicitud_de_Notificacion.Lugar_de_la_Cita
                        ,Estatus = varSolicitud_de_Notificacion.Estatus
                        ,Fecha_de_Notificacion = (!String.IsNullOrEmpty(varSolicitud_de_Notificacion.Fecha_de_Notificacion)) ? DateTime.ParseExact(varSolicitud_de_Notificacion.Fecha_de_Notificacion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Notificacion = varSolicitud_de_Notificacion.Hora_de_Notificacion
                        ,Notificador = varSolicitud_de_Notificacion.Notificador
                        ,Resultado = varSolicitud_de_Notificacion.Resultado
                        ,Archivo = varSolicitud_de_Notificacion.Archivo
                        ,Incidente_en_la_Recepcion = varSolicitud_de_Notificacion.Incidente_en_la_Recepcion

                    };

                    result = !IsNew ?
                        _ISolicitud_de_NotificacionApiConsumer.Update(Solicitud_de_NotificacionInfo, null, null).Resource.ToString() :
                         _ISolicitud_de_NotificacionApiConsumer.Insert(Solicitud_de_NotificacionInfo, null, null).Resource.ToString();
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
        public bool CopyDetalle_de_Invitado_de_Notificacion(int MasterId, int referenceId, List<Detalle_de_Invitado_de_NotificacionGridModelPost> Detalle_de_Invitado_de_NotificacionItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_Invitado_de_NotificacionApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_Invitado_de_NotificacionData = _IDetalle_de_Invitado_de_NotificacionApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_Invitado_de_Notificacion.Solicitud_de_Notificacion=" + referenceId,"").Resource;
                if (Detalle_de_Invitado_de_NotificacionData == null || Detalle_de_Invitado_de_NotificacionData.Detalle_de_Invitado_de_Notificacions.Count == 0)
                    return true;

                var result = true;

                Detalle_de_Invitado_de_NotificacionGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_Invitado_de_Notificacion in Detalle_de_Invitado_de_NotificacionData.Detalle_de_Invitado_de_Notificacions)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_Invitado_de_Notificacion Detalle_de_Invitado_de_Notificacion1 = varDetalle_de_Invitado_de_Notificacion;

                    if (Detalle_de_Invitado_de_NotificacionItems != null && Detalle_de_Invitado_de_NotificacionItems.Any(m => m.Folio == Detalle_de_Invitado_de_Notificacion1.Folio))
                    {
                        modelDataToChange = Detalle_de_Invitado_de_NotificacionItems.FirstOrDefault(m => m.Folio == Detalle_de_Invitado_de_Notificacion1.Folio);
                    }
                    //Chaning Id Value
                    varDetalle_de_Invitado_de_Notificacion.Solicitud_de_Notificacion = MasterId;
                    var insertId = _IDetalle_de_Invitado_de_NotificacionApiConsumer.Insert(varDetalle_de_Invitado_de_Notificacion,null,null).Resource;
                    if (insertId > 0 && modelDataToChange != null)
                        modelDataToChange.Folio = insertId;

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
        public ActionResult PostDetalle_de_Invitado_de_Notificacion(List<Detalle_de_Invitado_de_NotificacionGridModelPost> Detalle_de_Invitado_de_NotificacionItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_Invitado_de_Notificacion(MasterId, referenceId, Detalle_de_Invitado_de_NotificacionItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_Invitado_de_NotificacionItems != null && Detalle_de_Invitado_de_NotificacionItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_Invitado_de_NotificacionApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_Invitado_de_NotificacionItem in Detalle_de_Invitado_de_NotificacionItems)
                    {













                        //Removal Request
                        if (Detalle_de_Invitado_de_NotificacionItem.Removed)
                        {
                            result = result && _IDetalle_de_Invitado_de_NotificacionApiConsumer.Delete(Detalle_de_Invitado_de_NotificacionItem.Folio, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_Invitado_de_NotificacionItem.Folio = 0;

                        var Detalle_de_Invitado_de_NotificacionData = new Detalle_de_Invitado_de_Notificacion
                        {
                            Solicitud_de_Notificacion = MasterId
                            ,Folio = Detalle_de_Invitado_de_NotificacionItem.Folio
                            ,Nombre_Completo = Detalle_de_Invitado_de_NotificacionItem.Nombre_Completo
                            ,Telefono = Detalle_de_Invitado_de_NotificacionItem.Telefono
                            ,Correo_Electronico = Detalle_de_Invitado_de_NotificacionItem.Correo_Electronico
                            ,Estado = (Convert.ToInt32(Detalle_de_Invitado_de_NotificacionItem.Estado) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Invitado_de_NotificacionItem.Estado))
                            ,Municipio = (Convert.ToInt32(Detalle_de_Invitado_de_NotificacionItem.Municipio) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Invitado_de_NotificacionItem.Municipio))
                            ,Poblacion = (Convert.ToInt32(Detalle_de_Invitado_de_NotificacionItem.Poblacion) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Invitado_de_NotificacionItem.Poblacion))
                            ,Colonia = (Convert.ToInt32(Detalle_de_Invitado_de_NotificacionItem.Colonia) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Invitado_de_NotificacionItem.Colonia))
                            ,Codigo_Postal = Detalle_de_Invitado_de_NotificacionItem.Codigo_Postal
                            ,Calle = Detalle_de_Invitado_de_NotificacionItem.Calle
                            ,Numero_Exterior = Detalle_de_Invitado_de_NotificacionItem.Numero_Exterior
                            ,Numero_Interior = Detalle_de_Invitado_de_NotificacionItem.Numero_Interior

                        };

                        var resultId = Detalle_de_Invitado_de_NotificacionItem.Folio > 0
                           ? _IDetalle_de_Invitado_de_NotificacionApiConsumer.Update(Detalle_de_Invitado_de_NotificacionData,null,null).Resource
                           : _IDetalle_de_Invitado_de_NotificacionApiConsumer.Insert(Detalle_de_Invitado_de_NotificacionData,null,null).Resource;

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
        public ActionResult GetDetalle_de_Invitado_de_Notificacion_EstadoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstadoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
                    item.Nombre= CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Estado", "Nombre");
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Invitado_de_Notificacion_MunicipioAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IMunicipioApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
                    item.Nombre= CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Municipio", "Nombre");
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Invitado_de_Notificacion_ColoniaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IColoniaApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
                    item.Nombre= CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Colonia", "Nombre");
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }







        /// <summary>
        /// Write Element Array of Solicitud_de_Notificacion script
        /// </summary>
        /// <param name="oSolicitud_de_NotificacionElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Solicitud_de_NotificacionModuleAttributeList)
        {
            for (int i = 0; i < Solicitud_de_NotificacionModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Solicitud_de_NotificacionModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Solicitud_de_NotificacionModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Solicitud_de_NotificacionModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Solicitud_de_NotificacionModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Solicitud_de_NotificacionModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Solicitud_de_NotificacionModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Solicitud_de_NotificacionModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Solicitud_de_NotificacionModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Solicitud_de_NotificacionModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Solicitud_de_NotificacionModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Solicitud_de_NotificacionModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strSolicitud_de_NotificacionScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Solicitud_de_Notificacion.js")))
            {
                strSolicitud_de_NotificacionScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Solicitud_de_Notificacion element attributes
            string userChangeJson = jsSerialize.Serialize(Solicitud_de_NotificacionModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strSolicitud_de_NotificacionScript.IndexOf("inpuElementArray");
            string splittedString = strSolicitud_de_NotificacionScript.Substring(indexOfArray, strSolicitud_de_NotificacionScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Solicitud_de_NotificacionModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Solicitud_de_NotificacionModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strSolicitud_de_NotificacionScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strSolicitud_de_NotificacionScript.Substring(indexOfArrayHistory, strSolicitud_de_NotificacionScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strSolicitud_de_NotificacionScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strSolicitud_de_NotificacionScript.Substring(endIndexOfMainElement + indexOfArray, strSolicitud_de_NotificacionScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Solicitud_de_NotificacionModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Solicitud_de_NotificacionModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Solicitud_de_Notificacion.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Solicitud_de_Notificacion.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Solicitud_de_Notificacion.js")))
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
        public ActionResult Solicitud_de_NotificacionPropertyBag()
        {
            return PartialView("Solicitud_de_NotificacionPropertyBag", "Solicitud_de_Notificacion");
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
        public ActionResult AddDetalle_de_Invitado_de_Notificacion(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_Invitado_de_Notificacion/AddDetalle_de_Invitado_de_Notificacion");
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
                var whereClauseFormat = "Object = 45356 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _ISolicitud_de_NotificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Solicitud_de_Notificacion.Folio= " + RecordId;
                            var result = _ISolicitud_de_NotificacionApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _ISolicitud_de_NotificacionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Solicitud_de_NotificacionPropertyMapper());
			
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
                    (Solicitud_de_NotificacionAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Solicitud_de_NotificacionPropertyMapper oSolicitud_de_NotificacionPropertyMapper = new Solicitud_de_NotificacionPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oSolicitud_de_NotificacionPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _ISolicitud_de_NotificacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Solicitud_de_Notificacions == null)
                result.Solicitud_de_Notificacions = new List<Solicitud_de_Notificacion>();

            var data = result.Solicitud_de_Notificacions.Select(m => new Solicitud_de_NotificacionGridModel
            {
                Folio = m.Folio
                        ,Fecha_de_Solicitud = (m.Fecha_de_Solicitud == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Solicitud).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Solicitud = m.Hora_de_Solicitud
                        ,Usuario_que_SolicitaName = CultureHelper.GetTraduction(m.Usuario_que_Solicita_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Solicita_Spartan_User.Name
                        ,OrigenDescripcion = CultureHelper.GetTraduction(m.Origen_Origen_de_Invitacion.Clave.ToString(), "Descripcion") ?? (string)m.Origen_Origen_de_Invitacion.Descripcion
                        ,Expediente_Atencion_TempranaFolio = CultureHelper.GetTraduction(m.Expediente_Atencion_Temprana_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Expediente_Atencion_Temprana_Modulo_Atencion_Inicial.Folio
                        ,Expediente_Mecanismos_AlternosNumero_de_Folio = CultureHelper.GetTraduction(m.Expediente_Mecanismos_Alternos_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Expediente_Mecanismos_Alternos_Solicitud.Numero_de_Folio
                        ,Carpeta_de_InvestigacionNIC = CultureHelper.GetTraduction(m.Carpeta_de_Investigacion_Expediente_Inicial.Clave.ToString(), "Expediente_Inicial") ?? (string)m.Carpeta_de_Investigacion_Expediente_Inicial.NIC
                        ,Forma_de_InvitacionDescripcion = CultureHelper.GetTraduction(m.Forma_de_Invitacion_Tipo_de_Invitacion.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Invitacion_Tipo_de_Invitacion.Descripcion
			,Numero_de_Invitacion = m.Numero_de_Invitacion
                        ,Fecha_de_la_cita = (m.Fecha_de_la_cita == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_la_cita).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_la_Cita = m.Hora_de_la_Cita
			,Lugar_de_la_Cita = m.Lugar_de_la_Cita
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_de_Notificacion.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_de_Notificacion.Descripcion
                        ,Fecha_de_Notificacion = (m.Fecha_de_Notificacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Notificacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Notificacion = m.Hora_de_Notificacion
                        ,NotificadorName = CultureHelper.GetTraduction(m.Notificador_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Notificador_Spartan_User.Name
                        ,ResultadoDescripcion = CultureHelper.GetTraduction(m.Resultado_Resultado_de_Notificacion.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_Resultado_de_Notificacion.Descripcion
			,Archivo = m.Archivo
                        ,Incidente_en_la_RecepcionDescripcion = CultureHelper.GetTraduction(m.Incidente_en_la_Recepcion_Incidente_con_Invitacion.Clave.ToString(), "Descripcion") ?? (string)m.Incidente_en_la_Recepcion_Incidente_con_Invitacion.Descripcion

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45356, arrayColumnsVisible), "Solicitud_de_NotificacionList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45356, arrayColumnsVisible), "Solicitud_de_NotificacionList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45356, arrayColumnsVisible), "Solicitud_de_NotificacionList_" + DateTime.Now.ToString());
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

            _ISolicitud_de_NotificacionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Solicitud_de_NotificacionPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Solicitud_de_NotificacionAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Solicitud_de_NotificacionPropertyMapper oSolicitud_de_NotificacionPropertyMapper = new Solicitud_de_NotificacionPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oSolicitud_de_NotificacionPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _ISolicitud_de_NotificacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Solicitud_de_Notificacions == null)
                result.Solicitud_de_Notificacions = new List<Solicitud_de_Notificacion>();

            var data = result.Solicitud_de_Notificacions.Select(m => new Solicitud_de_NotificacionGridModel
            {
                Folio = m.Folio
                        ,Fecha_de_Solicitud = (m.Fecha_de_Solicitud == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Solicitud).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Solicitud = m.Hora_de_Solicitud
                        ,Usuario_que_SolicitaName = CultureHelper.GetTraduction(m.Usuario_que_Solicita_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Solicita_Spartan_User.Name
                        ,OrigenDescripcion = CultureHelper.GetTraduction(m.Origen_Origen_de_Invitacion.Clave.ToString(), "Descripcion") ?? (string)m.Origen_Origen_de_Invitacion.Descripcion
                        ,Expediente_Atencion_TempranaFolio = CultureHelper.GetTraduction(m.Expediente_Atencion_Temprana_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Expediente_Atencion_Temprana_Modulo_Atencion_Inicial.Folio
                        ,Expediente_Mecanismos_AlternosNumero_de_Folio = CultureHelper.GetTraduction(m.Expediente_Mecanismos_Alternos_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Expediente_Mecanismos_Alternos_Solicitud.Numero_de_Folio
                        ,Carpeta_de_InvestigacionNIC = CultureHelper.GetTraduction(m.Carpeta_de_Investigacion_Expediente_Inicial.Clave.ToString(), "Expediente_Inicial") ?? (string)m.Carpeta_de_Investigacion_Expediente_Inicial.NIC
                        ,Forma_de_InvitacionDescripcion = CultureHelper.GetTraduction(m.Forma_de_Invitacion_Tipo_de_Invitacion.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Invitacion_Tipo_de_Invitacion.Descripcion
			,Numero_de_Invitacion = m.Numero_de_Invitacion
                        ,Fecha_de_la_cita = (m.Fecha_de_la_cita == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_la_cita).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_la_Cita = m.Hora_de_la_Cita
			,Lugar_de_la_Cita = m.Lugar_de_la_Cita
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_de_Notificacion.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_de_Notificacion.Descripcion
                        ,Fecha_de_Notificacion = (m.Fecha_de_Notificacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Notificacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Notificacion = m.Hora_de_Notificacion
                        ,NotificadorName = CultureHelper.GetTraduction(m.Notificador_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Notificador_Spartan_User.Name
                        ,ResultadoDescripcion = CultureHelper.GetTraduction(m.Resultado_Resultado_de_Notificacion.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_Resultado_de_Notificacion.Descripcion
			,Archivo = m.Archivo
                        ,Incidente_en_la_RecepcionDescripcion = CultureHelper.GetTraduction(m.Incidente_en_la_Recepcion_Incidente_con_Invitacion.Clave.ToString(), "Descripcion") ?? (string)m.Incidente_en_la_Recepcion_Incidente_con_Invitacion.Descripcion

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
                _ISolicitud_de_NotificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISolicitud_de_NotificacionApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Solicitud_de_Notificacion_Datos_GeneralesModel varSolicitud_de_Notificacion)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitud_de_NotificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Solicitud_de_Notificacion_Datos_GeneralesInfo = new Solicitud_de_Notificacion_Datos_Generales
                {
                    Folio = varSolicitud_de_Notificacion.Folio
                                            ,Fecha_de_Solicitud = (!String.IsNullOrEmpty(varSolicitud_de_Notificacion.Fecha_de_Solicitud)) ? DateTime.ParseExact(varSolicitud_de_Notificacion.Fecha_de_Solicitud, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Solicitud = varSolicitud_de_Notificacion.Hora_de_Solicitud
                        ,Usuario_que_Solicita = varSolicitud_de_Notificacion.Usuario_que_Solicita
                        ,Origen = varSolicitud_de_Notificacion.Origen
                        ,Expediente_Atencion_Temprana = varSolicitud_de_Notificacion.Expediente_Atencion_Temprana
                        ,Expediente_Mecanismos_Alternos = varSolicitud_de_Notificacion.Expediente_Mecanismos_Alternos
                        ,Carpeta_de_Investigacion = varSolicitud_de_Notificacion.Carpeta_de_Investigacion
                        ,Forma_de_Invitacion = varSolicitud_de_Notificacion.Forma_de_Invitacion
                        ,Numero_de_Invitacion = varSolicitud_de_Notificacion.Numero_de_Invitacion
                        ,Fecha_de_la_cita = (!String.IsNullOrEmpty(varSolicitud_de_Notificacion.Fecha_de_la_cita)) ? DateTime.ParseExact(varSolicitud_de_Notificacion.Fecha_de_la_cita, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_la_Cita = varSolicitud_de_Notificacion.Hora_de_la_Cita
                        ,Lugar_de_la_Cita = varSolicitud_de_Notificacion.Lugar_de_la_Cita
                        ,Estatus = varSolicitud_de_Notificacion.Estatus
                    
                };

                result = _ISolicitud_de_NotificacionApiConsumer.Update_Datos_Generales(Solicitud_de_Notificacion_Datos_GeneralesInfo).Resource.ToString();
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
                _ISolicitud_de_NotificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _ISolicitud_de_NotificacionApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_de_Invitado_de_Notificacion;
                var Detalle_de_Invitado_de_NotificacionData = GetDetalle_de_Invitado_de_NotificacionData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Invitado_de_Notificacion);

                var result = new Solicitud_de_Notificacion_Datos_GeneralesModel
                {
                    Folio = m.Folio
                        ,Fecha_de_Solicitud = (m.Fecha_de_Solicitud == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Solicitud).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Solicitud = m.Hora_de_Solicitud
                        ,Usuario_que_Solicita = m.Usuario_que_Solicita
                        ,Usuario_que_SolicitaName = CultureHelper.GetTraduction(m.Usuario_que_Solicita_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Solicita_Spartan_User.Name
                        ,Origen = m.Origen
                        ,OrigenDescripcion = CultureHelper.GetTraduction(m.Origen_Origen_de_Invitacion.Clave.ToString(), "Descripcion") ?? (string)m.Origen_Origen_de_Invitacion.Descripcion
                        ,Expediente_Atencion_Temprana = m.Expediente_Atencion_Temprana
                        ,Expediente_Atencion_TempranaFolio = CultureHelper.GetTraduction(m.Expediente_Atencion_Temprana_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Expediente_Atencion_Temprana_Modulo_Atencion_Inicial.Folio
                        ,Expediente_Mecanismos_Alternos = m.Expediente_Mecanismos_Alternos
                        ,Expediente_Mecanismos_AlternosNumero_de_Folio = CultureHelper.GetTraduction(m.Expediente_Mecanismos_Alternos_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Expediente_Mecanismos_Alternos_Solicitud.Numero_de_Folio
                        ,Carpeta_de_Investigacion = m.Carpeta_de_Investigacion
                        ,Carpeta_de_InvestigacionNIC = CultureHelper.GetTraduction(m.Carpeta_de_Investigacion_Expediente_Inicial.Clave.ToString(), "Expediente_Inicial") ?? (string)m.Carpeta_de_Investigacion_Expediente_Inicial.NIC
                        ,Forma_de_Invitacion = m.Forma_de_Invitacion
                        ,Forma_de_InvitacionDescripcion = CultureHelper.GetTraduction(m.Forma_de_Invitacion_Tipo_de_Invitacion.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Invitacion_Tipo_de_Invitacion.Descripcion
			,Numero_de_Invitacion = m.Numero_de_Invitacion
                        ,Fecha_de_la_cita = (m.Fecha_de_la_cita == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_la_cita).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_la_Cita = m.Hora_de_la_Cita
			,Lugar_de_la_Cita = m.Lugar_de_la_Cita
                        ,Estatus = m.Estatus
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_de_Notificacion.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_de_Notificacion.Descripcion

                    
                };
				var resultData = new
                {
                    data = result
                    ,Invitados = Detalle_de_Invitado_de_NotificacionData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Resultado_de_Notificacion(Solicitud_de_Notificacion_Resultado_de_NotificacionModel varSolicitud_de_Notificacion)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitud_de_NotificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Solicitud_de_Notificacion_Resultado_de_NotificacionInfo = new Solicitud_de_Notificacion_Resultado_de_Notificacion
                {
                    Folio = varSolicitud_de_Notificacion.Folio
                                            ,Fecha_de_Notificacion = (!String.IsNullOrEmpty(varSolicitud_de_Notificacion.Fecha_de_Notificacion)) ? DateTime.ParseExact(varSolicitud_de_Notificacion.Fecha_de_Notificacion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Notificacion = varSolicitud_de_Notificacion.Hora_de_Notificacion
                        ,Notificador = varSolicitud_de_Notificacion.Notificador
                        ,Resultado = varSolicitud_de_Notificacion.Resultado
                        ,Archivo = varSolicitud_de_Notificacion.Archivo
                        ,Incidente_en_la_Recepcion = varSolicitud_de_Notificacion.Incidente_en_la_Recepcion
                    
                };

                result = _ISolicitud_de_NotificacionApiConsumer.Update_Resultado_de_Notificacion(Solicitud_de_Notificacion_Resultado_de_NotificacionInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Resultado_de_Notificacion(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitud_de_NotificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _ISolicitud_de_NotificacionApiConsumer.Get_Resultado_de_Notificacion(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_de_Invitado_de_Notificacion;
                var Detalle_de_Invitado_de_NotificacionData = GetDetalle_de_Invitado_de_NotificacionData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Invitado_de_Notificacion);

                var result = new Solicitud_de_Notificacion_Resultado_de_NotificacionModel
                {
                    Folio = m.Folio
                        ,Fecha_de_Notificacion = (m.Fecha_de_Notificacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Notificacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Notificacion = m.Hora_de_Notificacion
                        ,Notificador = m.Notificador
                        ,NotificadorName = CultureHelper.GetTraduction(m.Notificador_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Notificador_Spartan_User.Name
                        ,Resultado = m.Resultado
                        ,ResultadoDescripcion = CultureHelper.GetTraduction(m.Resultado_Resultado_de_Notificacion.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_Resultado_de_Notificacion.Descripcion
			,Archivo = m.Archivo
                        ,Incidente_en_la_Recepcion = m.Incidente_en_la_Recepcion
                        ,Incidente_en_la_RecepcionDescripcion = CultureHelper.GetTraduction(m.Incidente_en_la_Recepcion_Incidente_con_Invitacion.Clave.ToString(), "Descripcion") ?? (string)m.Incidente_en_la_Recepcion_Incidente_con_Invitacion.Descripcion

                    
                };
				var resultData = new
                {
                    data = result
                    ,Invitados = Detalle_de_Invitado_de_NotificacionData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }


    }
}

