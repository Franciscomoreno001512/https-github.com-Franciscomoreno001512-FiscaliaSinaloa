using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_de_Solicitudes_de_Invitaciones;
using Spartane.Core.Domain.Solicitud;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Tipo_de_Invitacion;
using Spartane.Core.Domain.Tipo_de_Funcion;
using Spartane.Core.Domain.Detalle_de_Solicitante_en_Invitaciones;

using Spartane.Core.Domain.Detalle_de_Solicitud_Solicitante;

using Spartane.Core.Domain.Detalle_de_Requerido_en_Invitaciones;

using Spartane.Core.Domain.Detalle_de_Solicitud_Requerido;

using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Resultado_de_Notificacion;
using Spartane.Core.Domain.Incidente_con_Invitacion;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_de_Solicitudes_de_Invitaciones;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Solicitudes_de_Invitaciones;
using Spartane.Web.Areas.WebApiConsumer.Solicitud;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Invitacion;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Funcion;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Solicitante_en_Invitaciones;

using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Solicitud_Solicitante;

using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Requerido_en_Invitaciones;

using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Solicitud_Requerido;

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
    public class Detalle_de_Solicitudes_de_InvitacionesController : Controller
    {
        #region "variable declaration"

        private IDetalle_de_Solicitudes_de_InvitacionesService service = null;
        private IDetalle_de_Solicitudes_de_InvitacionesApiConsumer _IDetalle_de_Solicitudes_de_InvitacionesApiConsumer;
        private ISolicitudApiConsumer _ISolicitudApiConsumer;
        private ISpartan_UserApiConsumer _ISpartan_UserApiConsumer;
        private ITipo_de_InvitacionApiConsumer _ITipo_de_InvitacionApiConsumer;
        private ITipo_de_FuncionApiConsumer _ITipo_de_FuncionApiConsumer;
        private IDetalle_de_Solicitante_en_InvitacionesApiConsumer _IDetalle_de_Solicitante_en_InvitacionesApiConsumer;

        private IDetalle_de_Solicitud_SolicitanteApiConsumer _IDetalle_de_Solicitud_SolicitanteApiConsumer;

        private IDetalle_de_Requerido_en_InvitacionesApiConsumer _IDetalle_de_Requerido_en_InvitacionesApiConsumer;

        private IDetalle_de_Solicitud_RequeridoApiConsumer _IDetalle_de_Solicitud_RequeridoApiConsumer;

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

        
        public Detalle_de_Solicitudes_de_InvitacionesController(IDetalle_de_Solicitudes_de_InvitacionesService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_de_Solicitudes_de_InvitacionesApiConsumer Detalle_de_Solicitudes_de_InvitacionesApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , ISolicitudApiConsumer SolicitudApiConsumer , ISpartan_UserApiConsumer Spartan_UserApiConsumer , ITipo_de_InvitacionApiConsumer Tipo_de_InvitacionApiConsumer , ITipo_de_FuncionApiConsumer Tipo_de_FuncionApiConsumer , IDetalle_de_Solicitante_en_InvitacionesApiConsumer Detalle_de_Solicitante_en_InvitacionesApiConsumer , IDetalle_de_Solicitud_SolicitanteApiConsumer Detalle_de_Solicitud_SolicitanteApiConsumer  , IDetalle_de_Requerido_en_InvitacionesApiConsumer Detalle_de_Requerido_en_InvitacionesApiConsumer , IDetalle_de_Solicitud_RequeridoApiConsumer Detalle_de_Solicitud_RequeridoApiConsumer  , IResultado_de_NotificacionApiConsumer Resultado_de_NotificacionApiConsumer , IIncidente_con_InvitacionApiConsumer Incidente_con_InvitacionApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_de_Solicitudes_de_InvitacionesApiConsumer = Detalle_de_Solicitudes_de_InvitacionesApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_FormatApiConsumer = Spartan_FormatApiConsumer;
            this._ISpartan_Format_PermissionsApiConsumer = Spartan_Format_PermissionsApiConsumer;
            this._IGeneratePDFApiConsumer = GeneratePDFApiConsumer;
			this._ISpartan_FormatRelatedApiConsumer = Spartan_Format_RelatedApiConsumer;
            this._ISolicitudApiConsumer = SolicitudApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._ITipo_de_InvitacionApiConsumer = Tipo_de_InvitacionApiConsumer;
            this._ITipo_de_FuncionApiConsumer = Tipo_de_FuncionApiConsumer;
            this._IDetalle_de_Solicitante_en_InvitacionesApiConsumer = Detalle_de_Solicitante_en_InvitacionesApiConsumer;

            this._IDetalle_de_Solicitud_SolicitanteApiConsumer = Detalle_de_Solicitud_SolicitanteApiConsumer;

            this._IDetalle_de_Requerido_en_InvitacionesApiConsumer = Detalle_de_Requerido_en_InvitacionesApiConsumer;

            this._IDetalle_de_Solicitud_RequeridoApiConsumer = Detalle_de_Solicitud_RequeridoApiConsumer;

            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._IResultado_de_NotificacionApiConsumer = Resultado_de_NotificacionApiConsumer;
            this._IIncidente_con_InvitacionApiConsumer = Incidente_con_InvitacionApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_de_Solicitudes_de_Invitaciones
        [ObjectAuth(ObjectId = (ModuleObjectId)45033, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45033, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Detalle_de_Solicitudes_de_Invitaciones/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45033, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45033, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varDetalle_de_Solicitudes_de_Invitaciones = new Detalle_de_Solicitudes_de_InvitacionesModel();
			varDetalle_de_Solicitudes_de_Invitaciones.Clave = Id;
			
            ViewBag.ObjectId = "45033";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;

            var permissionDetalle_de_Solicitante_en_Invitaciones = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45099, ModuleId);
            ViewBag.PermissionDetalle_de_Solicitante_en_Invitaciones = permissionDetalle_de_Solicitante_en_Invitaciones;
            var permissionDetalle_de_Requerido_en_Invitaciones = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45098, ModuleId);
            ViewBag.PermissionDetalle_de_Requerido_en_Invitaciones = permissionDetalle_de_Requerido_en_Invitaciones;


            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IDetalle_de_Solicitudes_de_InvitacionesApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_de_Solicitudes_de_InvitacionessData = _IDetalle_de_Solicitudes_de_InvitacionesApiConsumer.ListaSelAll(0, 1000, "Detalle_de_Solicitudes_de_Invitaciones.Clave=" + Id, "").Resource.Detalle_de_Solicitudes_de_Invitacioness;
				
				if (Detalle_de_Solicitudes_de_InvitacionessData != null && Detalle_de_Solicitudes_de_InvitacionessData.Count > 0)
                {
					var Detalle_de_Solicitudes_de_InvitacionesData = Detalle_de_Solicitudes_de_InvitacionessData.First();
					varDetalle_de_Solicitudes_de_Invitaciones= new Detalle_de_Solicitudes_de_InvitacionesModel
					{
						Clave  = Detalle_de_Solicitudes_de_InvitacionesData.Clave 
	                    ,Solicitud = Detalle_de_Solicitudes_de_InvitacionesData.Solicitud
                    ,SolicitudNumero_de_Folio = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitudes_de_InvitacionesData.Solicitud), "Solicitud") ??  (string)Detalle_de_Solicitudes_de_InvitacionesData.Solicitud_Solicitud.Numero_de_Folio
                    ,Fecha_de_Invitacion = (Detalle_de_Solicitudes_de_InvitacionesData.Fecha_de_Invitacion == null ? string.Empty : Convert.ToDateTime(Detalle_de_Solicitudes_de_InvitacionesData.Fecha_de_Invitacion).ToString(ConfigurationProperty.DateFormat))
                    ,Usuario_que_Registra = Detalle_de_Solicitudes_de_InvitacionesData.Usuario_que_Registra
                    ,Usuario_que_RegistraName = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitudes_de_InvitacionesData.Usuario_que_Registra), "Spartan_User") ??  (string)Detalle_de_Solicitudes_de_InvitacionesData.Usuario_que_Registra_Spartan_User.Name
                    ,Numero_de_Invitacion = Detalle_de_Solicitudes_de_InvitacionesData.Numero_de_Invitacion
                    ,Numero_de_Oficio = Detalle_de_Solicitudes_de_InvitacionesData.Numero_de_Oficio
                    ,Formato_de_Invitacion = Detalle_de_Solicitudes_de_InvitacionesData.Formato_de_Invitacion
                    ,Formato_de_InvitacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitudes_de_InvitacionesData.Formato_de_Invitacion), "Tipo_de_Invitacion") ??  (string)Detalle_de_Solicitudes_de_InvitacionesData.Formato_de_Invitacion_Tipo_de_Invitacion.Descripcion
                    ,Tipo_de_Participacion = Detalle_de_Solicitudes_de_InvitacionesData.Tipo_de_Participacion
                    ,Tipo_de_ParticipacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitudes_de_InvitacionesData.Tipo_de_Participacion), "Tipo_de_Funcion") ??  (string)Detalle_de_Solicitudes_de_InvitacionesData.Tipo_de_Participacion_Tipo_de_Funcion.Descripcion
                    ,Fecha_de_la_cita = (Detalle_de_Solicitudes_de_InvitacionesData.Fecha_de_la_cita == null ? string.Empty : Convert.ToDateTime(Detalle_de_Solicitudes_de_InvitacionesData.Fecha_de_la_cita).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_la_Cita = Detalle_de_Solicitudes_de_InvitacionesData.Hora_de_la_Cita
                    ,Domicilio = Detalle_de_Solicitudes_de_InvitacionesData.Domicilio
                    ,Fecha_de_Notificacion = (Detalle_de_Solicitudes_de_InvitacionesData.Fecha_de_Notificacion == null ? string.Empty : Convert.ToDateTime(Detalle_de_Solicitudes_de_InvitacionesData.Fecha_de_Notificacion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Notificacion = Detalle_de_Solicitudes_de_InvitacionesData.Hora_de_Notificacion
                    ,Notificador = Detalle_de_Solicitudes_de_InvitacionesData.Notificador
                    ,NotificadorName = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitudes_de_InvitacionesData.Notificador), "Spartan_User") ??  (string)Detalle_de_Solicitudes_de_InvitacionesData.Notificador_Spartan_User.Name
                    ,Resultado = Detalle_de_Solicitudes_de_InvitacionesData.Resultado
                    ,ResultadoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitudes_de_InvitacionesData.Resultado), "Resultado_de_Notificacion") ??  (string)Detalle_de_Solicitudes_de_InvitacionesData.Resultado_Resultado_de_Notificacion.Descripcion
                    ,Incidente_en_la_Recepcion = Detalle_de_Solicitudes_de_InvitacionesData.Incidente_en_la_Recepcion
                    ,Incidente_en_la_RecepcionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitudes_de_InvitacionesData.Incidente_en_la_Recepcion), "Incidente_con_Invitacion") ??  (string)Detalle_de_Solicitudes_de_InvitacionesData.Incidente_en_la_Recepcion_Incidente_con_Invitacion.Descripcion
                    ,Documento = Detalle_de_Solicitudes_de_InvitacionesData.Documento

					};
				}
				
				                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.DocumentoSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varDetalle_de_Solicitudes_de_Invitaciones.Documento).Resource;

				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_InvitacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Invitacions_Formato_de_Invitacion = _ITipo_de_InvitacionApiConsumer.SelAll(true);
            if (Tipo_de_Invitacions_Formato_de_Invitacion != null && Tipo_de_Invitacions_Formato_de_Invitacion.Resource != null)
                ViewBag.Tipo_de_Invitacions_Formato_de_Invitacion = Tipo_de_Invitacions_Formato_de_Invitacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Invitacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_FuncionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Funcions_Tipo_de_Participacion = _ITipo_de_FuncionApiConsumer.SelAll(true);
            if (Tipo_de_Funcions_Tipo_de_Participacion != null && Tipo_de_Funcions_Tipo_de_Participacion.Resource != null)
                ViewBag.Tipo_de_Funcions_Tipo_de_Participacion = Tipo_de_Funcions_Tipo_de_Participacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Funcion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Notificador = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Notificador != null && Spartan_Users_Notificador.Resource != null)
                ViewBag.Spartan_Users_Notificador = Spartan_Users_Notificador.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
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

				
            return View(varDetalle_de_Solicitudes_de_Invitaciones);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_de_Solicitudes_de_Invitaciones(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45033);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_de_Solicitudes_de_InvitacionesApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_de_Solicitudes_de_InvitacionesModel varDetalle_de_Solicitudes_de_Invitaciones= new Detalle_de_Solicitudes_de_InvitacionesModel();
            var permissionDetalle_de_Solicitante_en_Invitaciones = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45099, ModuleId);
            ViewBag.PermissionDetalle_de_Solicitante_en_Invitaciones = permissionDetalle_de_Solicitante_en_Invitaciones;
            var permissionDetalle_de_Requerido_en_Invitaciones = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45098, ModuleId);
            ViewBag.PermissionDetalle_de_Requerido_en_Invitaciones = permissionDetalle_de_Requerido_en_Invitaciones;


            if (id.ToString() != "0")
            {
                var Detalle_de_Solicitudes_de_InvitacionessData = _IDetalle_de_Solicitudes_de_InvitacionesApiConsumer.ListaSelAll(0, 1000, "Detalle_de_Solicitudes_de_Invitaciones.Clave=" + id, "").Resource.Detalle_de_Solicitudes_de_Invitacioness;
				
				if (Detalle_de_Solicitudes_de_InvitacionessData != null && Detalle_de_Solicitudes_de_InvitacionessData.Count > 0)
                {
					var Detalle_de_Solicitudes_de_InvitacionesData = Detalle_de_Solicitudes_de_InvitacionessData.First();
					varDetalle_de_Solicitudes_de_Invitaciones= new Detalle_de_Solicitudes_de_InvitacionesModel
					{
						Clave  = Detalle_de_Solicitudes_de_InvitacionesData.Clave 
	                    ,Solicitud = Detalle_de_Solicitudes_de_InvitacionesData.Solicitud
                    ,SolicitudNumero_de_Folio = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitudes_de_InvitacionesData.Solicitud), "Solicitud") ??  (string)Detalle_de_Solicitudes_de_InvitacionesData.Solicitud_Solicitud.Numero_de_Folio
                    ,Fecha_de_Invitacion = (Detalle_de_Solicitudes_de_InvitacionesData.Fecha_de_Invitacion == null ? string.Empty : Convert.ToDateTime(Detalle_de_Solicitudes_de_InvitacionesData.Fecha_de_Invitacion).ToString(ConfigurationProperty.DateFormat))
                    ,Usuario_que_Registra = Detalle_de_Solicitudes_de_InvitacionesData.Usuario_que_Registra
                    ,Usuario_que_RegistraName = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitudes_de_InvitacionesData.Usuario_que_Registra), "Spartan_User") ??  (string)Detalle_de_Solicitudes_de_InvitacionesData.Usuario_que_Registra_Spartan_User.Name
                    ,Numero_de_Invitacion = Detalle_de_Solicitudes_de_InvitacionesData.Numero_de_Invitacion
                    ,Numero_de_Oficio = Detalle_de_Solicitudes_de_InvitacionesData.Numero_de_Oficio
                    ,Formato_de_Invitacion = Detalle_de_Solicitudes_de_InvitacionesData.Formato_de_Invitacion
                    ,Formato_de_InvitacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitudes_de_InvitacionesData.Formato_de_Invitacion), "Tipo_de_Invitacion") ??  (string)Detalle_de_Solicitudes_de_InvitacionesData.Formato_de_Invitacion_Tipo_de_Invitacion.Descripcion
                    ,Tipo_de_Participacion = Detalle_de_Solicitudes_de_InvitacionesData.Tipo_de_Participacion
                    ,Tipo_de_ParticipacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitudes_de_InvitacionesData.Tipo_de_Participacion), "Tipo_de_Funcion") ??  (string)Detalle_de_Solicitudes_de_InvitacionesData.Tipo_de_Participacion_Tipo_de_Funcion.Descripcion
                    ,Fecha_de_la_cita = (Detalle_de_Solicitudes_de_InvitacionesData.Fecha_de_la_cita == null ? string.Empty : Convert.ToDateTime(Detalle_de_Solicitudes_de_InvitacionesData.Fecha_de_la_cita).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_la_Cita = Detalle_de_Solicitudes_de_InvitacionesData.Hora_de_la_Cita
                    ,Domicilio = Detalle_de_Solicitudes_de_InvitacionesData.Domicilio
                    ,Fecha_de_Notificacion = (Detalle_de_Solicitudes_de_InvitacionesData.Fecha_de_Notificacion == null ? string.Empty : Convert.ToDateTime(Detalle_de_Solicitudes_de_InvitacionesData.Fecha_de_Notificacion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Notificacion = Detalle_de_Solicitudes_de_InvitacionesData.Hora_de_Notificacion
                    ,Notificador = Detalle_de_Solicitudes_de_InvitacionesData.Notificador
                    ,NotificadorName = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitudes_de_InvitacionesData.Notificador), "Spartan_User") ??  (string)Detalle_de_Solicitudes_de_InvitacionesData.Notificador_Spartan_User.Name
                    ,Resultado = Detalle_de_Solicitudes_de_InvitacionesData.Resultado
                    ,ResultadoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitudes_de_InvitacionesData.Resultado), "Resultado_de_Notificacion") ??  (string)Detalle_de_Solicitudes_de_InvitacionesData.Resultado_Resultado_de_Notificacion.Descripcion
                    ,Incidente_en_la_Recepcion = Detalle_de_Solicitudes_de_InvitacionesData.Incidente_en_la_Recepcion
                    ,Incidente_en_la_RecepcionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitudes_de_InvitacionesData.Incidente_en_la_Recepcion), "Incidente_con_Invitacion") ??  (string)Detalle_de_Solicitudes_de_InvitacionesData.Incidente_en_la_Recepcion_Incidente_con_Invitacion.Descripcion
                    ,Documento = Detalle_de_Solicitudes_de_InvitacionesData.Documento

					};
				}
                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.DocumentoSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varDetalle_de_Solicitudes_de_Invitaciones.Documento).Resource;

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_InvitacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Invitacions_Formato_de_Invitacion = _ITipo_de_InvitacionApiConsumer.SelAll(true);
            if (Tipo_de_Invitacions_Formato_de_Invitacion != null && Tipo_de_Invitacions_Formato_de_Invitacion.Resource != null)
                ViewBag.Tipo_de_Invitacions_Formato_de_Invitacion = Tipo_de_Invitacions_Formato_de_Invitacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Invitacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_FuncionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Funcions_Tipo_de_Participacion = _ITipo_de_FuncionApiConsumer.SelAll(true);
            if (Tipo_de_Funcions_Tipo_de_Participacion != null && Tipo_de_Funcions_Tipo_de_Participacion.Resource != null)
                ViewBag.Tipo_de_Funcions_Tipo_de_Participacion = Tipo_de_Funcions_Tipo_de_Participacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Funcion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Notificador = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Notificador != null && Spartan_Users_Notificador.Resource != null)
                ViewBag.Spartan_Users_Notificador = Spartan_Users_Notificador.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
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


            return PartialView("AddDetalle_de_Solicitudes_de_Invitaciones", varDetalle_de_Solicitudes_de_Invitaciones);
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
        public ActionResult GetTipo_de_FuncionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_FuncionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_FuncionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Funcion", "Descripcion")?? m.Descripcion,
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
        public ActionResult ShowAdvanceFilter(Detalle_de_Solicitudes_de_InvitacionesAdvanceSearchModel model, int idFilter = -1)
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

            _ITipo_de_InvitacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Invitacions_Formato_de_Invitacion = _ITipo_de_InvitacionApiConsumer.SelAll(true);
            if (Tipo_de_Invitacions_Formato_de_Invitacion != null && Tipo_de_Invitacions_Formato_de_Invitacion.Resource != null)
                ViewBag.Tipo_de_Invitacions_Formato_de_Invitacion = Tipo_de_Invitacions_Formato_de_Invitacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Invitacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_FuncionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Funcions_Tipo_de_Participacion = _ITipo_de_FuncionApiConsumer.SelAll(true);
            if (Tipo_de_Funcions_Tipo_de_Participacion != null && Tipo_de_Funcions_Tipo_de_Participacion.Resource != null)
                ViewBag.Tipo_de_Funcions_Tipo_de_Participacion = Tipo_de_Funcions_Tipo_de_Participacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Funcion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Notificador = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Notificador != null && Spartan_Users_Notificador.Resource != null)
                ViewBag.Spartan_Users_Notificador = Spartan_Users_Notificador.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
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

            _ITipo_de_InvitacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Invitacions_Formato_de_Invitacion = _ITipo_de_InvitacionApiConsumer.SelAll(true);
            if (Tipo_de_Invitacions_Formato_de_Invitacion != null && Tipo_de_Invitacions_Formato_de_Invitacion.Resource != null)
                ViewBag.Tipo_de_Invitacions_Formato_de_Invitacion = Tipo_de_Invitacions_Formato_de_Invitacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Invitacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_FuncionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Funcions_Tipo_de_Participacion = _ITipo_de_FuncionApiConsumer.SelAll(true);
            if (Tipo_de_Funcions_Tipo_de_Participacion != null && Tipo_de_Funcions_Tipo_de_Participacion.Resource != null)
                ViewBag.Tipo_de_Funcions_Tipo_de_Participacion = Tipo_de_Funcions_Tipo_de_Participacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Funcion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Notificador = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Notificador != null && Spartan_Users_Notificador.Resource != null)
                ViewBag.Spartan_Users_Notificador = Spartan_Users_Notificador.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
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


            var previousFiltersObj = new Detalle_de_Solicitudes_de_InvitacionesAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Detalle_de_Solicitudes_de_InvitacionesAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Detalle_de_Solicitudes_de_InvitacionesAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_Solicitudes_de_InvitacionesPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_de_Solicitudes_de_InvitacionesApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Solicitudes_de_Invitacioness == null)
                result.Detalle_de_Solicitudes_de_Invitacioness = new List<Detalle_de_Solicitudes_de_Invitaciones>();

            return Json(new
            {
                data = result.Detalle_de_Solicitudes_de_Invitacioness.Select(m => new Detalle_de_Solicitudes_de_InvitacionesGridModel
                    {
                    Clave = m.Clave
                        ,SolicitudNumero_de_Folio = CultureHelper.GetTraduction(m.Solicitud_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Solicitud_Solicitud.Numero_de_Folio
                        ,Fecha_de_Invitacion = (m.Fecha_de_Invitacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Invitacion).ToString(ConfigurationProperty.DateFormat))
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
			,Numero_de_Invitacion = m.Numero_de_Invitacion
			,Numero_de_Oficio = m.Numero_de_Oficio
                        ,Formato_de_InvitacionDescripcion = CultureHelper.GetTraduction(m.Formato_de_Invitacion_Tipo_de_Invitacion.Clave.ToString(), "Descripcion") ?? (string)m.Formato_de_Invitacion_Tipo_de_Invitacion.Descripcion
                        ,Tipo_de_ParticipacionDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Participacion_Tipo_de_Funcion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Participacion_Tipo_de_Funcion.Descripcion
                        ,Fecha_de_la_cita = (m.Fecha_de_la_cita == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_la_cita).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_la_Cita = m.Hora_de_la_Cita
			,Domicilio = m.Domicilio
                        ,Fecha_de_Notificacion = (m.Fecha_de_Notificacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Notificacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Notificacion = m.Hora_de_Notificacion
                        ,NotificadorName = CultureHelper.GetTraduction(m.Notificador_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Notificador_Spartan_User.Name
                        ,ResultadoDescripcion = CultureHelper.GetTraduction(m.Resultado_Resultado_de_Notificacion.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_Resultado_de_Notificacion.Descripcion
                        ,Incidente_en_la_RecepcionDescripcion = CultureHelper.GetTraduction(m.Incidente_en_la_Recepcion_Incidente_con_Invitacion.Clave.ToString(), "Descripcion") ?? (string)m.Incidente_en_la_Recepcion_Incidente_con_Invitacion.Descripcion
			,Documento = m.Documento

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetDetalle_de_Solicitudes_de_InvitacionesAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Solicitudes_de_InvitacionesApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_Solicitudes_de_InvitacionesApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Detalle_de_Solicitudes_de_Invitaciones", m.),
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
        /// Get List of Detalle_de_Solicitudes_de_Invitaciones from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Detalle_de_Solicitudes_de_Invitaciones Entity</returns>
        public ActionResult GetDetalle_de_Solicitudes_de_InvitacionesList(UrlParametersModel param)
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
            _IDetalle_de_Solicitudes_de_InvitacionesApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Detalle_de_Solicitudes_de_InvitacionesPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Detalle_de_Solicitudes_de_InvitacionesAdvanceSearchModel))
                {
					var advanceFilter =
                    (Detalle_de_Solicitudes_de_InvitacionesAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Detalle_de_Solicitudes_de_InvitacionesPropertyMapper oDetalle_de_Solicitudes_de_InvitacionesPropertyMapper = new Detalle_de_Solicitudes_de_InvitacionesPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oDetalle_de_Solicitudes_de_InvitacionesPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IDetalle_de_Solicitudes_de_InvitacionesApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Solicitudes_de_Invitacioness == null)
                result.Detalle_de_Solicitudes_de_Invitacioness = new List<Detalle_de_Solicitudes_de_Invitaciones>();

            return Json(new
            {
                aaData = result.Detalle_de_Solicitudes_de_Invitacioness.Select(m => new Detalle_de_Solicitudes_de_InvitacionesGridModel
            {
                    Clave = m.Clave
                        ,SolicitudNumero_de_Folio = CultureHelper.GetTraduction(m.Solicitud_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Solicitud_Solicitud.Numero_de_Folio
                        ,Fecha_de_Invitacion = (m.Fecha_de_Invitacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Invitacion).ToString(ConfigurationProperty.DateFormat))
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
			,Numero_de_Invitacion = m.Numero_de_Invitacion
			,Numero_de_Oficio = m.Numero_de_Oficio
                        ,Formato_de_InvitacionDescripcion = CultureHelper.GetTraduction(m.Formato_de_Invitacion_Tipo_de_Invitacion.Clave.ToString(), "Descripcion") ?? (string)m.Formato_de_Invitacion_Tipo_de_Invitacion.Descripcion
                        ,Tipo_de_ParticipacionDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Participacion_Tipo_de_Funcion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Participacion_Tipo_de_Funcion.Descripcion
                        ,Fecha_de_la_cita = (m.Fecha_de_la_cita == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_la_cita).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_la_Cita = m.Hora_de_la_Cita
			,Domicilio = m.Domicilio
                        ,Fecha_de_Notificacion = (m.Fecha_de_Notificacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Notificacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Notificacion = m.Hora_de_Notificacion
                        ,NotificadorName = CultureHelper.GetTraduction(m.Notificador_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Notificador_Spartan_User.Name
                        ,ResultadoDescripcion = CultureHelper.GetTraduction(m.Resultado_Resultado_de_Notificacion.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_Resultado_de_Notificacion.Descripcion
                        ,Incidente_en_la_RecepcionDescripcion = CultureHelper.GetTraduction(m.Incidente_en_la_Recepcion_Incidente_con_Invitacion.Clave.ToString(), "Descripcion") ?? (string)m.Incidente_en_la_Recepcion_Incidente_con_Invitacion.Descripcion
			,Documento = m.Documento

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetDetalle_de_Solicitudes_de_Invitaciones_Solicitud_Solicitud(string query, string where)
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
        public JsonResult GetDetalle_de_Solicitudes_de_Invitaciones_Usuario_que_Registra_Spartan_User(string query, string where)
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
//Grid GetAutoComplete
        [HttpGet]
        public JsonResult GetDetalle_de_Solicitante_en_Invitaciones_Nombre_Detalle_de_Solicitud_Solicitante(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Solicitud_SolicitanteApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Detalle_de_Solicitud_Solicitante.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Detalle_de_Solicitud_Solicitante.Nombre_Completo as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IDetalle_de_Solicitud_SolicitanteApiConsumer.ListaSelAll(1, 20,elWhere , " Detalle_de_Solicitud_Solicitante.Nombre_Completo ASC ").Resource;
               
                foreach (var item in result.Detalle_de_Solicitud_Solicitantes)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Detalle_de_Solicitud_Solicitante", "Nombre_Completo");
                    item.Nombre_Completo =trans ??item.Nombre_Completo;
                }
                return Json(result.Detalle_de_Solicitud_Solicitantes.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }

//Grid GetAutoComplete
        [HttpGet]
        public JsonResult GetDetalle_de_Requerido_en_Invitaciones_Nombre_Detalle_de_Solicitud_Requerido(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Solicitud_RequeridoApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Detalle_de_Solicitud_Requerido.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Detalle_de_Solicitud_Requerido.Nombre_Completo as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IDetalle_de_Solicitud_RequeridoApiConsumer.ListaSelAll(1, 20,elWhere , " Detalle_de_Solicitud_Requerido.Nombre_Completo ASC ").Resource;
               
                foreach (var item in result.Detalle_de_Solicitud_Requeridos)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Detalle_de_Solicitud_Requerido", "Nombre_Completo");
                    item.Nombre_Completo =trans ??item.Nombre_Completo;
                }
                return Json(result.Detalle_de_Solicitud_Requeridos.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }






        [NonAction]
        public string GetAdvanceFilter(Detalle_de_Solicitudes_de_InvitacionesAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Detalle_de_Solicitudes_de_Invitaciones.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Detalle_de_Solicitudes_de_Invitaciones.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceSolicitud))
            {
                switch (filter.SolicitudFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud.Numero_de_Folio LIKE '" + filter.AdvanceSolicitud + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud.Numero_de_Folio LIKE '%" + filter.AdvanceSolicitud + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud.Numero_de_Folio = '" + filter.AdvanceSolicitud + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud.Numero_de_Folio LIKE '%" + filter.AdvanceSolicitud + "%'";
                        break;
                }
            }
            else if (filter.AdvanceSolicitudMultiple != null && filter.AdvanceSolicitudMultiple.Count() > 0)
            {
                var SolicitudIds = string.Join(",", filter.AdvanceSolicitudMultiple);

                where += " AND Detalle_de_Solicitudes_de_Invitaciones.Solicitud In (" + SolicitudIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Invitacion) || !string.IsNullOrEmpty(filter.ToFecha_de_Invitacion))
            {
                var Fecha_de_InvitacionFrom = DateTime.ParseExact(filter.FromFecha_de_Invitacion, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_InvitacionTo = DateTime.ParseExact(filter.ToFecha_de_Invitacion, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Invitacion))
                    where += " AND Detalle_de_Solicitudes_de_Invitaciones.Fecha_de_Invitacion >= '" + Fecha_de_InvitacionFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Invitacion))
                    where += " AND Detalle_de_Solicitudes_de_Invitaciones.Fecha_de_Invitacion <= '" + Fecha_de_InvitacionTo.ToString("MM-dd-yyyy") + "'";
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

                where += " AND Detalle_de_Solicitudes_de_Invitaciones.Usuario_que_Registra In (" + Usuario_que_RegistraIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Numero_de_Invitacion))
            {
                switch (filter.Numero_de_InvitacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitudes_de_Invitaciones.Numero_de_Invitacion LIKE '" + filter.Numero_de_Invitacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitudes_de_Invitaciones.Numero_de_Invitacion LIKE '%" + filter.Numero_de_Invitacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitudes_de_Invitaciones.Numero_de_Invitacion = '" + filter.Numero_de_Invitacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitudes_de_Invitaciones.Numero_de_Invitacion LIKE '%" + filter.Numero_de_Invitacion + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_de_Oficio))
            {
                switch (filter.Numero_de_OficioFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitudes_de_Invitaciones.Numero_de_Oficio LIKE '" + filter.Numero_de_Oficio + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitudes_de_Invitaciones.Numero_de_Oficio LIKE '%" + filter.Numero_de_Oficio + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitudes_de_Invitaciones.Numero_de_Oficio = '" + filter.Numero_de_Oficio + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitudes_de_Invitaciones.Numero_de_Oficio LIKE '%" + filter.Numero_de_Oficio + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceFormato_de_Invitacion))
            {
                switch (filter.Formato_de_InvitacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Invitacion.Descripcion LIKE '" + filter.AdvanceFormato_de_Invitacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Invitacion.Descripcion LIKE '%" + filter.AdvanceFormato_de_Invitacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Invitacion.Descripcion = '" + filter.AdvanceFormato_de_Invitacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Invitacion.Descripcion LIKE '%" + filter.AdvanceFormato_de_Invitacion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceFormato_de_InvitacionMultiple != null && filter.AdvanceFormato_de_InvitacionMultiple.Count() > 0)
            {
                var Formato_de_InvitacionIds = string.Join(",", filter.AdvanceFormato_de_InvitacionMultiple);

                where += " AND Detalle_de_Solicitudes_de_Invitaciones.Formato_de_Invitacion In (" + Formato_de_InvitacionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Participacion))
            {
                switch (filter.Tipo_de_ParticipacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Funcion.Descripcion LIKE '" + filter.AdvanceTipo_de_Participacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Funcion.Descripcion LIKE '%" + filter.AdvanceTipo_de_Participacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Funcion.Descripcion = '" + filter.AdvanceTipo_de_Participacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Funcion.Descripcion LIKE '%" + filter.AdvanceTipo_de_Participacion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_ParticipacionMultiple != null && filter.AdvanceTipo_de_ParticipacionMultiple.Count() > 0)
            {
                var Tipo_de_ParticipacionIds = string.Join(",", filter.AdvanceTipo_de_ParticipacionMultiple);

                where += " AND Detalle_de_Solicitudes_de_Invitaciones.Tipo_de_Participacion In (" + Tipo_de_ParticipacionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_la_cita) || !string.IsNullOrEmpty(filter.ToFecha_de_la_cita))
            {
                var Fecha_de_la_citaFrom = DateTime.ParseExact(filter.FromFecha_de_la_cita, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_la_citaTo = DateTime.ParseExact(filter.ToFecha_de_la_cita, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_la_cita))
                    where += " AND Detalle_de_Solicitudes_de_Invitaciones.Fecha_de_la_cita >= '" + Fecha_de_la_citaFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_la_cita))
                    where += " AND Detalle_de_Solicitudes_de_Invitaciones.Fecha_de_la_cita <= '" + Fecha_de_la_citaTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_la_Cita) || !string.IsNullOrEmpty(filter.ToHora_de_la_Cita))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_la_Cita))
                    where += " AND Convert(TIME,Detalle_de_Solicitudes_de_Invitaciones.Hora_de_la_Cita) >='" + filter.FromHora_de_la_Cita + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_la_Cita))
                    where += " AND Convert(TIME,Detalle_de_Solicitudes_de_Invitaciones.Hora_de_la_Cita) <='" + filter.ToHora_de_la_Cita + "'";
            }

            if (!string.IsNullOrEmpty(filter.Domicilio))
            {
                switch (filter.DomicilioFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitudes_de_Invitaciones.Domicilio LIKE '" + filter.Domicilio + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitudes_de_Invitaciones.Domicilio LIKE '%" + filter.Domicilio + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitudes_de_Invitaciones.Domicilio = '" + filter.Domicilio + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitudes_de_Invitaciones.Domicilio LIKE '%" + filter.Domicilio + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Notificacion) || !string.IsNullOrEmpty(filter.ToFecha_de_Notificacion))
            {
                var Fecha_de_NotificacionFrom = DateTime.ParseExact(filter.FromFecha_de_Notificacion, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_NotificacionTo = DateTime.ParseExact(filter.ToFecha_de_Notificacion, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Notificacion))
                    where += " AND Detalle_de_Solicitudes_de_Invitaciones.Fecha_de_Notificacion >= '" + Fecha_de_NotificacionFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Notificacion))
                    where += " AND Detalle_de_Solicitudes_de_Invitaciones.Fecha_de_Notificacion <= '" + Fecha_de_NotificacionTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Notificacion) || !string.IsNullOrEmpty(filter.ToHora_de_Notificacion))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Notificacion))
                    where += " AND Convert(TIME,Detalle_de_Solicitudes_de_Invitaciones.Hora_de_Notificacion) >='" + filter.FromHora_de_Notificacion + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Notificacion))
                    where += " AND Convert(TIME,Detalle_de_Solicitudes_de_Invitaciones.Hora_de_Notificacion) <='" + filter.ToHora_de_Notificacion + "'";
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

                where += " AND Detalle_de_Solicitudes_de_Invitaciones.Notificador In (" + NotificadorIds + ")";
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

                where += " AND Detalle_de_Solicitudes_de_Invitaciones.Resultado In (" + ResultadoIds + ")";
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

                where += " AND Detalle_de_Solicitudes_de_Invitaciones.Incidente_en_la_Recepcion In (" + Incidente_en_la_RecepcionIds + ")";
            }

            if (filter.Documento != RadioOptions.NoApply)
                where += " AND Detalle_de_Solicitudes_de_Invitaciones.Documento " + (filter.Documento == RadioOptions.Yes ? ">" : "==") + " 0";


            where = new Regex(Regex.Escape("AND ")).Replace(where, "", 1);
            return where;
        }

        [NonAction]
        public Grid_File ConvertSpartane_FileToGridFile(Spartane.Core.Domain.Spartane_File.Spartane_File file)
        {
            return file == null ? new Grid_File { FileId = 0, FileSize = 0, FileName = "" } : new Grid_File { FileId = file.File_Id, FileName = file.Description, FileSize = file.File_Size ?? 0, };
        }

        public ActionResult GetDetalle_de_Solicitante_en_Invitaciones(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_Solicitante_en_InvitacionesGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Solicitante_en_InvitacionesApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_Solicitante_en_Invitaciones.Solicitud=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_Solicitante_en_Invitaciones.Solicitud='" + RelationId + "'";
            }
            var result = _IDetalle_de_Solicitante_en_InvitacionesApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_Solicitante_en_Invitacioness == null)
                result.Detalle_de_Solicitante_en_Invitacioness = new List<Detalle_de_Solicitante_en_Invitaciones>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_Solicitante_en_Invitacioness.Select(m => new Detalle_de_Solicitante_en_InvitacionesGridModel
                {
                    Clave = m.Clave

                        ,Nombre = m.Nombre
                        ,NombreNombre_Completo = CultureHelper.GetTraduction(m.Nombre_Detalle_de_Solicitud_Solicitante.Clave.ToString(), "Nombre_Completo") ??(string)m.Nombre_Detalle_de_Solicitud_Solicitante.Nombre_Completo

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_Solicitante_en_InvitacionesGridModel> GetDetalle_de_Solicitante_en_InvitacionesData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_Solicitante_en_InvitacionesGridModel> resultData = new List<Detalle_de_Solicitante_en_InvitacionesGridModel>();
            string where = "Detalle_de_Solicitante_en_Invitaciones.Solicitud=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_Solicitante_en_Invitaciones.Solicitud='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Solicitante_en_InvitacionesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_Solicitante_en_InvitacionesApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_Solicitante_en_Invitacioness != null)
            {
                resultData = result.Detalle_de_Solicitante_en_Invitacioness.Select(m => new Detalle_de_Solicitante_en_InvitacionesGridModel
                    {
                        Clave = m.Clave

                        ,Nombre = m.Nombre
                        ,NombreNombre_Completo = CultureHelper.GetTraduction(m.Nombre_Detalle_de_Solicitud_Solicitante.Clave.ToString(), "Nombre_Completo") ??(string)m.Nombre_Detalle_de_Solicitud_Solicitante.Nombre_Completo


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_de_Requerido_en_Invitaciones(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_Requerido_en_InvitacionesGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Requerido_en_InvitacionesApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_Requerido_en_Invitaciones.Solicitud=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_Requerido_en_Invitaciones.Solicitud='" + RelationId + "'";
            }
            var result = _IDetalle_de_Requerido_en_InvitacionesApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_Requerido_en_Invitacioness == null)
                result.Detalle_de_Requerido_en_Invitacioness = new List<Detalle_de_Requerido_en_Invitaciones>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_Requerido_en_Invitacioness.Select(m => new Detalle_de_Requerido_en_InvitacionesGridModel
                {
                    Clave = m.Clave

                        ,Nombre = m.Nombre
                        ,NombreNombre_Completo = CultureHelper.GetTraduction(m.Nombre_Detalle_de_Solicitud_Requerido.Clave.ToString(), "Nombre_Completo") ??(string)m.Nombre_Detalle_de_Solicitud_Requerido.Nombre_Completo

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_Requerido_en_InvitacionesGridModel> GetDetalle_de_Requerido_en_InvitacionesData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_Requerido_en_InvitacionesGridModel> resultData = new List<Detalle_de_Requerido_en_InvitacionesGridModel>();
            string where = "Detalle_de_Requerido_en_Invitaciones.Solicitud=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_Requerido_en_Invitaciones.Solicitud='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Requerido_en_InvitacionesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_Requerido_en_InvitacionesApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_Requerido_en_Invitacioness != null)
            {
                resultData = result.Detalle_de_Requerido_en_Invitacioness.Select(m => new Detalle_de_Requerido_en_InvitacionesGridModel
                    {
                        Clave = m.Clave

                        ,Nombre = m.Nombre
                        ,NombreNombre_Completo = CultureHelper.GetTraduction(m.Nombre_Detalle_de_Solicitud_Requerido.Clave.ToString(), "Nombre_Completo") ??(string)m.Nombre_Detalle_de_Solicitud_Requerido.Nombre_Completo


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
                _IDetalle_de_Solicitudes_de_InvitacionesApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_de_Solicitudes_de_Invitaciones varDetalle_de_Solicitudes_de_Invitaciones = null;
                if (id.ToString() != "0")
                {
                        string where = "";
                    _IDetalle_de_Solicitante_en_InvitacionesApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_Solicitante_en_Invitaciones.Solicitud=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_Solicitante_en_Invitaciones.Solicitud='" + id + "'";
                    }
                    var Detalle_de_Solicitante_en_InvitacionesInfo =
                        _IDetalle_de_Solicitante_en_InvitacionesApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_Solicitante_en_InvitacionesInfo.Detalle_de_Solicitante_en_Invitacioness.Count > 0)
                    {
                        var resultDetalle_de_Solicitante_en_Invitaciones = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_Solicitante_en_InvitacionesItem in Detalle_de_Solicitante_en_InvitacionesInfo.Detalle_de_Solicitante_en_Invitacioness)
                            resultDetalle_de_Solicitante_en_Invitaciones = resultDetalle_de_Solicitante_en_Invitaciones
                                              && _IDetalle_de_Solicitante_en_InvitacionesApiConsumer.Delete(Detalle_de_Solicitante_en_InvitacionesItem.Clave, null,null).Resource;

                        if (!resultDetalle_de_Solicitante_en_Invitaciones)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_de_Requerido_en_InvitacionesApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_Requerido_en_Invitaciones.Solicitud=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_Requerido_en_Invitaciones.Solicitud='" + id + "'";
                    }
                    var Detalle_de_Requerido_en_InvitacionesInfo =
                        _IDetalle_de_Requerido_en_InvitacionesApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_Requerido_en_InvitacionesInfo.Detalle_de_Requerido_en_Invitacioness.Count > 0)
                    {
                        var resultDetalle_de_Requerido_en_Invitaciones = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_Requerido_en_InvitacionesItem in Detalle_de_Requerido_en_InvitacionesInfo.Detalle_de_Requerido_en_Invitacioness)
                            resultDetalle_de_Requerido_en_Invitaciones = resultDetalle_de_Requerido_en_Invitaciones
                                              && _IDetalle_de_Requerido_en_InvitacionesApiConsumer.Delete(Detalle_de_Requerido_en_InvitacionesItem.Clave, null,null).Resource;

                        if (!resultDetalle_de_Requerido_en_Invitaciones)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }

                }
                var result = _IDetalle_de_Solicitudes_de_InvitacionesApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_de_Solicitudes_de_InvitacionesModel varDetalle_de_Solicitudes_de_Invitaciones)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_de_Solicitudes_de_InvitacionesApiConsumer.SetAuthHeader(_tokenManager.Token);


                    if (varDetalle_de_Solicitudes_de_Invitaciones.DocumentoRemoveAttachment != 0 && varDetalle_de_Solicitudes_de_Invitaciones.DocumentoFile == null)
                    {
                        varDetalle_de_Solicitudes_de_Invitaciones.Documento = 0;
                    }

                    if (varDetalle_de_Solicitudes_de_Invitaciones.DocumentoFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varDetalle_de_Solicitudes_de_Invitaciones.DocumentoFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varDetalle_de_Solicitudes_de_Invitaciones.Documento = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varDetalle_de_Solicitudes_de_Invitaciones.DocumentoFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }

                    
                    var result = "";
                    var Detalle_de_Solicitudes_de_InvitacionesInfo = new Detalle_de_Solicitudes_de_Invitaciones
                    {
                        Clave = varDetalle_de_Solicitudes_de_Invitaciones.Clave
                        ,Solicitud = varDetalle_de_Solicitudes_de_Invitaciones.Solicitud
                        ,Fecha_de_Invitacion = (!String.IsNullOrEmpty(varDetalle_de_Solicitudes_de_Invitaciones.Fecha_de_Invitacion)) ? DateTime.ParseExact(varDetalle_de_Solicitudes_de_Invitaciones.Fecha_de_Invitacion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Usuario_que_Registra = varDetalle_de_Solicitudes_de_Invitaciones.Usuario_que_Registra
                        ,Numero_de_Invitacion = varDetalle_de_Solicitudes_de_Invitaciones.Numero_de_Invitacion
                        ,Numero_de_Oficio = varDetalle_de_Solicitudes_de_Invitaciones.Numero_de_Oficio
                        ,Formato_de_Invitacion = varDetalle_de_Solicitudes_de_Invitaciones.Formato_de_Invitacion
                        ,Tipo_de_Participacion = varDetalle_de_Solicitudes_de_Invitaciones.Tipo_de_Participacion
                        ,Fecha_de_la_cita = (!String.IsNullOrEmpty(varDetalle_de_Solicitudes_de_Invitaciones.Fecha_de_la_cita)) ? DateTime.ParseExact(varDetalle_de_Solicitudes_de_Invitaciones.Fecha_de_la_cita, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_la_Cita = varDetalle_de_Solicitudes_de_Invitaciones.Hora_de_la_Cita
                        ,Domicilio = varDetalle_de_Solicitudes_de_Invitaciones.Domicilio
                        ,Fecha_de_Notificacion = (!String.IsNullOrEmpty(varDetalle_de_Solicitudes_de_Invitaciones.Fecha_de_Notificacion)) ? DateTime.ParseExact(varDetalle_de_Solicitudes_de_Invitaciones.Fecha_de_Notificacion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Notificacion = varDetalle_de_Solicitudes_de_Invitaciones.Hora_de_Notificacion
                        ,Notificador = varDetalle_de_Solicitudes_de_Invitaciones.Notificador
                        ,Resultado = varDetalle_de_Solicitudes_de_Invitaciones.Resultado
                        ,Incidente_en_la_Recepcion = varDetalle_de_Solicitudes_de_Invitaciones.Incidente_en_la_Recepcion
                        ,Documento = (varDetalle_de_Solicitudes_de_Invitaciones.Documento.HasValue && varDetalle_de_Solicitudes_de_Invitaciones.Documento != 0) ? ((int?)Convert.ToInt32(varDetalle_de_Solicitudes_de_Invitaciones.Documento.Value)) : null


                    };

                    result = !IsNew ?
                        _IDetalle_de_Solicitudes_de_InvitacionesApiConsumer.Update(Detalle_de_Solicitudes_de_InvitacionesInfo, null, null).Resource.ToString() :
                         _IDetalle_de_Solicitudes_de_InvitacionesApiConsumer.Insert(Detalle_de_Solicitudes_de_InvitacionesInfo, null, null).Resource.ToString();
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
        public bool CopyDetalle_de_Solicitante_en_Invitaciones(int MasterId, int referenceId, List<Detalle_de_Solicitante_en_InvitacionesGridModelPost> Detalle_de_Solicitante_en_InvitacionesItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_Solicitante_en_InvitacionesApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_Solicitante_en_InvitacionesData = _IDetalle_de_Solicitante_en_InvitacionesApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_Solicitante_en_Invitaciones.Solicitud=" + referenceId,"").Resource;
                if (Detalle_de_Solicitante_en_InvitacionesData == null || Detalle_de_Solicitante_en_InvitacionesData.Detalle_de_Solicitante_en_Invitacioness.Count == 0)
                    return true;

                var result = true;

                Detalle_de_Solicitante_en_InvitacionesGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_Solicitante_en_Invitaciones in Detalle_de_Solicitante_en_InvitacionesData.Detalle_de_Solicitante_en_Invitacioness)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_Solicitante_en_Invitaciones Detalle_de_Solicitante_en_Invitaciones1 = varDetalle_de_Solicitante_en_Invitaciones;

                    if (Detalle_de_Solicitante_en_InvitacionesItems != null && Detalle_de_Solicitante_en_InvitacionesItems.Any(m => m.Clave == Detalle_de_Solicitante_en_Invitaciones1.Clave))
                    {
                        modelDataToChange = Detalle_de_Solicitante_en_InvitacionesItems.FirstOrDefault(m => m.Clave == Detalle_de_Solicitante_en_Invitaciones1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_de_Solicitante_en_Invitaciones.Solicitud = MasterId;
                    var insertId = _IDetalle_de_Solicitante_en_InvitacionesApiConsumer.Insert(varDetalle_de_Solicitante_en_Invitaciones,null,null).Resource;
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
        public ActionResult PostDetalle_de_Solicitante_en_Invitaciones(List<Detalle_de_Solicitante_en_InvitacionesGridModelPost> Detalle_de_Solicitante_en_InvitacionesItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_Solicitante_en_Invitaciones(MasterId, referenceId, Detalle_de_Solicitante_en_InvitacionesItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_Solicitante_en_InvitacionesItems != null && Detalle_de_Solicitante_en_InvitacionesItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_Solicitante_en_InvitacionesApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_Solicitante_en_InvitacionesItem in Detalle_de_Solicitante_en_InvitacionesItems)
                    {



                        //Removal Request
                        if (Detalle_de_Solicitante_en_InvitacionesItem.Removed)
                        {
                            result = result && _IDetalle_de_Solicitante_en_InvitacionesApiConsumer.Delete(Detalle_de_Solicitante_en_InvitacionesItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_Solicitante_en_InvitacionesItem.Clave = 0;

                        var Detalle_de_Solicitante_en_InvitacionesData = new Detalle_de_Solicitante_en_Invitaciones
                        {
                            Solicitud = MasterId
                            ,Clave = Detalle_de_Solicitante_en_InvitacionesItem.Clave
                            ,Nombre = (Convert.ToInt32(Detalle_de_Solicitante_en_InvitacionesItem.Nombre) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Solicitante_en_InvitacionesItem.Nombre))

                        };

                        var resultId = Detalle_de_Solicitante_en_InvitacionesItem.Clave > 0
                           ? _IDetalle_de_Solicitante_en_InvitacionesApiConsumer.Update(Detalle_de_Solicitante_en_InvitacionesData,null,null).Resource
                           : _IDetalle_de_Solicitante_en_InvitacionesApiConsumer.Insert(Detalle_de_Solicitante_en_InvitacionesData,null,null).Resource;

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
        public ActionResult GetDetalle_de_Solicitante_en_Invitaciones_Detalle_de_Solicitud_SolicitanteAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Solicitud_SolicitanteApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_Solicitud_SolicitanteApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
                    item.Nombre_Completo= CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Detalle_de_Solicitud_Solicitante", "Nombre_Completo");
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }

        [NonAction]
        public bool CopyDetalle_de_Requerido_en_Invitaciones(int MasterId, int referenceId, List<Detalle_de_Requerido_en_InvitacionesGridModelPost> Detalle_de_Requerido_en_InvitacionesItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_Requerido_en_InvitacionesApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_Requerido_en_InvitacionesData = _IDetalle_de_Requerido_en_InvitacionesApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_Requerido_en_Invitaciones.Solicitud=" + referenceId,"").Resource;
                if (Detalle_de_Requerido_en_InvitacionesData == null || Detalle_de_Requerido_en_InvitacionesData.Detalle_de_Requerido_en_Invitacioness.Count == 0)
                    return true;

                var result = true;

                Detalle_de_Requerido_en_InvitacionesGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_Requerido_en_Invitaciones in Detalle_de_Requerido_en_InvitacionesData.Detalle_de_Requerido_en_Invitacioness)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_Requerido_en_Invitaciones Detalle_de_Requerido_en_Invitaciones1 = varDetalle_de_Requerido_en_Invitaciones;

                    if (Detalle_de_Requerido_en_InvitacionesItems != null && Detalle_de_Requerido_en_InvitacionesItems.Any(m => m.Clave == Detalle_de_Requerido_en_Invitaciones1.Clave))
                    {
                        modelDataToChange = Detalle_de_Requerido_en_InvitacionesItems.FirstOrDefault(m => m.Clave == Detalle_de_Requerido_en_Invitaciones1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_de_Requerido_en_Invitaciones.Solicitud = MasterId;
                    var insertId = _IDetalle_de_Requerido_en_InvitacionesApiConsumer.Insert(varDetalle_de_Requerido_en_Invitaciones,null,null).Resource;
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
        public ActionResult PostDetalle_de_Requerido_en_Invitaciones(List<Detalle_de_Requerido_en_InvitacionesGridModelPost> Detalle_de_Requerido_en_InvitacionesItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_Requerido_en_Invitaciones(MasterId, referenceId, Detalle_de_Requerido_en_InvitacionesItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_Requerido_en_InvitacionesItems != null && Detalle_de_Requerido_en_InvitacionesItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_Requerido_en_InvitacionesApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_Requerido_en_InvitacionesItem in Detalle_de_Requerido_en_InvitacionesItems)
                    {



                        //Removal Request
                        if (Detalle_de_Requerido_en_InvitacionesItem.Removed)
                        {
                            result = result && _IDetalle_de_Requerido_en_InvitacionesApiConsumer.Delete(Detalle_de_Requerido_en_InvitacionesItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_Requerido_en_InvitacionesItem.Clave = 0;

                        var Detalle_de_Requerido_en_InvitacionesData = new Detalle_de_Requerido_en_Invitaciones
                        {
                            Solicitud = MasterId
                            ,Clave = Detalle_de_Requerido_en_InvitacionesItem.Clave
                            ,Nombre = (Convert.ToInt32(Detalle_de_Requerido_en_InvitacionesItem.Nombre) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Requerido_en_InvitacionesItem.Nombre))

                        };

                        var resultId = Detalle_de_Requerido_en_InvitacionesItem.Clave > 0
                           ? _IDetalle_de_Requerido_en_InvitacionesApiConsumer.Update(Detalle_de_Requerido_en_InvitacionesData,null,null).Resource
                           : _IDetalle_de_Requerido_en_InvitacionesApiConsumer.Insert(Detalle_de_Requerido_en_InvitacionesData,null,null).Resource;

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
        public ActionResult GetDetalle_de_Requerido_en_Invitaciones_Detalle_de_Solicitud_RequeridoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Solicitud_RequeridoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_Solicitud_RequeridoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
                    item.Nombre_Completo= CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Detalle_de_Solicitud_Requerido", "Nombre_Completo");
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }



        /// <summary>
        /// Write Element Array of Detalle_de_Solicitudes_de_Invitaciones script
        /// </summary>
        /// <param name="oDetalle_de_Solicitudes_de_InvitacionesElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Detalle_de_Solicitudes_de_InvitacionesModuleAttributeList)
        {
            for (int i = 0; i < Detalle_de_Solicitudes_de_InvitacionesModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_de_Solicitudes_de_InvitacionesModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_de_Solicitudes_de_InvitacionesModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_de_Solicitudes_de_InvitacionesModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_de_Solicitudes_de_InvitacionesModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_de_Solicitudes_de_InvitacionesModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_de_Solicitudes_de_InvitacionesModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Detalle_de_Solicitudes_de_InvitacionesModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Detalle_de_Solicitudes_de_InvitacionesModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Detalle_de_Solicitudes_de_InvitacionesModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Detalle_de_Solicitudes_de_InvitacionesModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Detalle_de_Solicitudes_de_InvitacionesModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strDetalle_de_Solicitudes_de_InvitacionesScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Solicitudes_de_Invitaciones.js")))
            {
                strDetalle_de_Solicitudes_de_InvitacionesScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_de_Solicitudes_de_Invitaciones element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_de_Solicitudes_de_InvitacionesModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_de_Solicitudes_de_InvitacionesScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_de_Solicitudes_de_InvitacionesScript.Substring(indexOfArray, strDetalle_de_Solicitudes_de_InvitacionesScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_de_Solicitudes_de_InvitacionesModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_de_Solicitudes_de_InvitacionesModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_de_Solicitudes_de_InvitacionesScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strDetalle_de_Solicitudes_de_InvitacionesScript.Substring(indexOfArrayHistory, strDetalle_de_Solicitudes_de_InvitacionesScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strDetalle_de_Solicitudes_de_InvitacionesScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_de_Solicitudes_de_InvitacionesScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_de_Solicitudes_de_InvitacionesScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Detalle_de_Solicitudes_de_InvitacionesModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Detalle_de_Solicitudes_de_InvitacionesModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_de_Solicitudes_de_Invitaciones.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_de_Solicitudes_de_Invitaciones.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Solicitudes_de_Invitaciones.js")))
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
        public ActionResult Detalle_de_Solicitudes_de_InvitacionesPropertyBag()
        {
            return PartialView("Detalle_de_Solicitudes_de_InvitacionesPropertyBag", "Detalle_de_Solicitudes_de_Invitaciones");
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
        public ActionResult AddDetalle_de_Solicitante_en_Invitaciones(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_Solicitante_en_Invitaciones/AddDetalle_de_Solicitante_en_Invitaciones");
        }

        [HttpGet]
        public ActionResult AddDetalle_de_Requerido_en_Invitaciones(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_Requerido_en_Invitaciones/AddDetalle_de_Requerido_en_Invitaciones");
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
                var whereClauseFormat = "Object = 45033 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IDetalle_de_Solicitudes_de_InvitacionesApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Detalle_de_Solicitudes_de_Invitaciones.Clave= " + RecordId;
                            var result = _IDetalle_de_Solicitudes_de_InvitacionesApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IDetalle_de_Solicitudes_de_InvitacionesApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Detalle_de_Solicitudes_de_InvitacionesPropertyMapper());
			
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
                    (Detalle_de_Solicitudes_de_InvitacionesAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Detalle_de_Solicitudes_de_InvitacionesPropertyMapper oDetalle_de_Solicitudes_de_InvitacionesPropertyMapper = new Detalle_de_Solicitudes_de_InvitacionesPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oDetalle_de_Solicitudes_de_InvitacionesPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_Solicitudes_de_InvitacionesApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Solicitudes_de_Invitacioness == null)
                result.Detalle_de_Solicitudes_de_Invitacioness = new List<Detalle_de_Solicitudes_de_Invitaciones>();

            var data = result.Detalle_de_Solicitudes_de_Invitacioness.Select(m => new Detalle_de_Solicitudes_de_InvitacionesGridModel
            {
                Clave = m.Clave
                        ,SolicitudNumero_de_Folio = CultureHelper.GetTraduction(m.Solicitud_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Solicitud_Solicitud.Numero_de_Folio
                        ,Fecha_de_Invitacion = (m.Fecha_de_Invitacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Invitacion).ToString(ConfigurationProperty.DateFormat))
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
			,Numero_de_Invitacion = m.Numero_de_Invitacion
			,Numero_de_Oficio = m.Numero_de_Oficio
                        ,Formato_de_InvitacionDescripcion = CultureHelper.GetTraduction(m.Formato_de_Invitacion_Tipo_de_Invitacion.Clave.ToString(), "Descripcion") ?? (string)m.Formato_de_Invitacion_Tipo_de_Invitacion.Descripcion
                        ,Tipo_de_ParticipacionDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Participacion_Tipo_de_Funcion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Participacion_Tipo_de_Funcion.Descripcion
                        ,Fecha_de_la_cita = (m.Fecha_de_la_cita == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_la_cita).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_la_Cita = m.Hora_de_la_Cita
			,Domicilio = m.Domicilio
                        ,Fecha_de_Notificacion = (m.Fecha_de_Notificacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Notificacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Notificacion = m.Hora_de_Notificacion
                        ,NotificadorName = CultureHelper.GetTraduction(m.Notificador_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Notificador_Spartan_User.Name
                        ,ResultadoDescripcion = CultureHelper.GetTraduction(m.Resultado_Resultado_de_Notificacion.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_Resultado_de_Notificacion.Descripcion
                        ,Incidente_en_la_RecepcionDescripcion = CultureHelper.GetTraduction(m.Incidente_en_la_Recepcion_Incidente_con_Invitacion.Clave.ToString(), "Descripcion") ?? (string)m.Incidente_en_la_Recepcion_Incidente_con_Invitacion.Descripcion
			,Documento = m.Documento

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45033, arrayColumnsVisible), "Detalle_de_Solicitudes_de_InvitacionesList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45033, arrayColumnsVisible), "Detalle_de_Solicitudes_de_InvitacionesList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45033, arrayColumnsVisible), "Detalle_de_Solicitudes_de_InvitacionesList_" + DateTime.Now.ToString());
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

            _IDetalle_de_Solicitudes_de_InvitacionesApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Detalle_de_Solicitudes_de_InvitacionesPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Detalle_de_Solicitudes_de_InvitacionesAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Detalle_de_Solicitudes_de_InvitacionesPropertyMapper oDetalle_de_Solicitudes_de_InvitacionesPropertyMapper = new Detalle_de_Solicitudes_de_InvitacionesPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oDetalle_de_Solicitudes_de_InvitacionesPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_Solicitudes_de_InvitacionesApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Solicitudes_de_Invitacioness == null)
                result.Detalle_de_Solicitudes_de_Invitacioness = new List<Detalle_de_Solicitudes_de_Invitaciones>();

            var data = result.Detalle_de_Solicitudes_de_Invitacioness.Select(m => new Detalle_de_Solicitudes_de_InvitacionesGridModel
            {
                Clave = m.Clave
                        ,SolicitudNumero_de_Folio = CultureHelper.GetTraduction(m.Solicitud_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Solicitud_Solicitud.Numero_de_Folio
                        ,Fecha_de_Invitacion = (m.Fecha_de_Invitacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Invitacion).ToString(ConfigurationProperty.DateFormat))
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
			,Numero_de_Invitacion = m.Numero_de_Invitacion
			,Numero_de_Oficio = m.Numero_de_Oficio
                        ,Formato_de_InvitacionDescripcion = CultureHelper.GetTraduction(m.Formato_de_Invitacion_Tipo_de_Invitacion.Clave.ToString(), "Descripcion") ?? (string)m.Formato_de_Invitacion_Tipo_de_Invitacion.Descripcion
                        ,Tipo_de_ParticipacionDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Participacion_Tipo_de_Funcion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Participacion_Tipo_de_Funcion.Descripcion
                        ,Fecha_de_la_cita = (m.Fecha_de_la_cita == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_la_cita).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_la_Cita = m.Hora_de_la_Cita
			,Domicilio = m.Domicilio
                        ,Fecha_de_Notificacion = (m.Fecha_de_Notificacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Notificacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Notificacion = m.Hora_de_Notificacion
                        ,NotificadorName = CultureHelper.GetTraduction(m.Notificador_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Notificador_Spartan_User.Name
                        ,ResultadoDescripcion = CultureHelper.GetTraduction(m.Resultado_Resultado_de_Notificacion.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_Resultado_de_Notificacion.Descripcion
                        ,Incidente_en_la_RecepcionDescripcion = CultureHelper.GetTraduction(m.Incidente_en_la_Recepcion_Incidente_con_Invitacion.Clave.ToString(), "Descripcion") ?? (string)m.Incidente_en_la_Recepcion_Incidente_con_Invitacion.Descripcion
			,Documento = m.Documento

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
                _IDetalle_de_Solicitudes_de_InvitacionesApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_Solicitudes_de_InvitacionesApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Detalle_de_Solicitudes_de_Invitaciones_Datos_GeneralesModel varDetalle_de_Solicitudes_de_Invitaciones)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Solicitudes_de_InvitacionesApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Detalle_de_Solicitudes_de_Invitaciones_Datos_GeneralesInfo = new Detalle_de_Solicitudes_de_Invitaciones_Datos_Generales
                {
                    Clave = varDetalle_de_Solicitudes_de_Invitaciones.Clave
                                            ,Solicitud = varDetalle_de_Solicitudes_de_Invitaciones.Solicitud
                        ,Fecha_de_Invitacion = (!String.IsNullOrEmpty(varDetalle_de_Solicitudes_de_Invitaciones.Fecha_de_Invitacion)) ? DateTime.ParseExact(varDetalle_de_Solicitudes_de_Invitaciones.Fecha_de_Invitacion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Usuario_que_Registra = varDetalle_de_Solicitudes_de_Invitaciones.Usuario_que_Registra
                        ,Numero_de_Invitacion = varDetalle_de_Solicitudes_de_Invitaciones.Numero_de_Invitacion
                        ,Numero_de_Oficio = varDetalle_de_Solicitudes_de_Invitaciones.Numero_de_Oficio
                        ,Formato_de_Invitacion = varDetalle_de_Solicitudes_de_Invitaciones.Formato_de_Invitacion
                        ,Tipo_de_Participacion = varDetalle_de_Solicitudes_de_Invitaciones.Tipo_de_Participacion
                        ,Fecha_de_la_cita = (!String.IsNullOrEmpty(varDetalle_de_Solicitudes_de_Invitaciones.Fecha_de_la_cita)) ? DateTime.ParseExact(varDetalle_de_Solicitudes_de_Invitaciones.Fecha_de_la_cita, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_la_Cita = varDetalle_de_Solicitudes_de_Invitaciones.Hora_de_la_Cita
                        ,Domicilio = varDetalle_de_Solicitudes_de_Invitaciones.Domicilio
                    
                };

                result = _IDetalle_de_Solicitudes_de_InvitacionesApiConsumer.Update_Datos_Generales(Detalle_de_Solicitudes_de_Invitaciones_Datos_GeneralesInfo).Resource.ToString();
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
                _IDetalle_de_Solicitudes_de_InvitacionesApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IDetalle_de_Solicitudes_de_InvitacionesApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_de_Solicitante_en_Invitaciones;
                var Detalle_de_Solicitante_en_InvitacionesData = GetDetalle_de_Solicitante_en_InvitacionesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Solicitante_en_Invitaciones);
                int RowCount_Detalle_de_Requerido_en_Invitaciones;
                var Detalle_de_Requerido_en_InvitacionesData = GetDetalle_de_Requerido_en_InvitacionesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Requerido_en_Invitaciones);

                var result = new Detalle_de_Solicitudes_de_Invitaciones_Datos_GeneralesModel
                {
                    Clave = m.Clave
                        ,Solicitud = m.Solicitud
                        ,SolicitudNumero_de_Folio = CultureHelper.GetTraduction(m.Solicitud_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Solicitud_Solicitud.Numero_de_Folio
                        ,Fecha_de_Invitacion = (m.Fecha_de_Invitacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Invitacion).ToString(ConfigurationProperty.DateFormat))
                        ,Usuario_que_Registra = m.Usuario_que_Registra
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
			,Numero_de_Invitacion = m.Numero_de_Invitacion
			,Numero_de_Oficio = m.Numero_de_Oficio
                        ,Formato_de_Invitacion = m.Formato_de_Invitacion
                        ,Formato_de_InvitacionDescripcion = CultureHelper.GetTraduction(m.Formato_de_Invitacion_Tipo_de_Invitacion.Clave.ToString(), "Descripcion") ?? (string)m.Formato_de_Invitacion_Tipo_de_Invitacion.Descripcion
                        ,Tipo_de_Participacion = m.Tipo_de_Participacion
                        ,Tipo_de_ParticipacionDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Participacion_Tipo_de_Funcion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Participacion_Tipo_de_Funcion.Descripcion
                        ,Fecha_de_la_cita = (m.Fecha_de_la_cita == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_la_cita).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_la_Cita = m.Hora_de_la_Cita
			,Domicilio = m.Domicilio

                    
                };
				var resultData = new
                {
                    data = result
                    ,nombre_del_interviniente_solicitante = Detalle_de_Solicitante_en_InvitacionesData
                    ,nombre_del_interviniente_requerido = Detalle_de_Requerido_en_InvitacionesData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Resultado_de_Notificacion(Detalle_de_Solicitudes_de_Invitaciones_Resultado_de_NotificacionModel varDetalle_de_Solicitudes_de_Invitaciones)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Solicitudes_de_InvitacionesApiConsumer.SetAuthHeader(_tokenManager.Token);
				                    if (varDetalle_de_Solicitudes_de_Invitaciones.DocumentoRemoveAttachment != 0 && varDetalle_de_Solicitudes_de_Invitaciones.DocumentoFile == null)
                    {
                        varDetalle_de_Solicitudes_de_Invitaciones.Documento = 0;
                    }

                    if (varDetalle_de_Solicitudes_de_Invitaciones.DocumentoFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varDetalle_de_Solicitudes_de_Invitaciones.DocumentoFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varDetalle_de_Solicitudes_de_Invitaciones.Documento = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varDetalle_de_Solicitudes_de_Invitaciones.DocumentoFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }

                var result = "";
                var Detalle_de_Solicitudes_de_Invitaciones_Resultado_de_NotificacionInfo = new Detalle_de_Solicitudes_de_Invitaciones_Resultado_de_Notificacion
                {
                    Clave = varDetalle_de_Solicitudes_de_Invitaciones.Clave
                                            ,Fecha_de_Notificacion = (!String.IsNullOrEmpty(varDetalle_de_Solicitudes_de_Invitaciones.Fecha_de_Notificacion)) ? DateTime.ParseExact(varDetalle_de_Solicitudes_de_Invitaciones.Fecha_de_Notificacion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Notificacion = varDetalle_de_Solicitudes_de_Invitaciones.Hora_de_Notificacion
                        ,Notificador = varDetalle_de_Solicitudes_de_Invitaciones.Notificador
                        ,Resultado = varDetalle_de_Solicitudes_de_Invitaciones.Resultado
                        ,Incidente_en_la_Recepcion = varDetalle_de_Solicitudes_de_Invitaciones.Incidente_en_la_Recepcion
                        ,Documento = (varDetalle_de_Solicitudes_de_Invitaciones.Documento.HasValue && varDetalle_de_Solicitudes_de_Invitaciones.Documento != 0) ? ((int?)Convert.ToInt32(varDetalle_de_Solicitudes_de_Invitaciones.Documento.Value)) : null

                    
                };

                result = _IDetalle_de_Solicitudes_de_InvitacionesApiConsumer.Update_Resultado_de_Notificacion(Detalle_de_Solicitudes_de_Invitaciones_Resultado_de_NotificacionInfo).Resource.ToString();
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
                _IDetalle_de_Solicitudes_de_InvitacionesApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IDetalle_de_Solicitudes_de_InvitacionesApiConsumer.Get_Resultado_de_Notificacion(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_de_Solicitante_en_Invitaciones;
                var Detalle_de_Solicitante_en_InvitacionesData = GetDetalle_de_Solicitante_en_InvitacionesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Solicitante_en_Invitaciones);
                int RowCount_Detalle_de_Requerido_en_Invitaciones;
                var Detalle_de_Requerido_en_InvitacionesData = GetDetalle_de_Requerido_en_InvitacionesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Requerido_en_Invitaciones);

                var result = new Detalle_de_Solicitudes_de_Invitaciones_Resultado_de_NotificacionModel
                {
                    Clave = m.Clave
                        ,Fecha_de_Notificacion = (m.Fecha_de_Notificacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Notificacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Notificacion = m.Hora_de_Notificacion
                        ,Notificador = m.Notificador
                        ,NotificadorName = CultureHelper.GetTraduction(m.Notificador_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Notificador_Spartan_User.Name
                        ,Resultado = m.Resultado
                        ,ResultadoDescripcion = CultureHelper.GetTraduction(m.Resultado_Resultado_de_Notificacion.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_Resultado_de_Notificacion.Descripcion
                        ,Incidente_en_la_Recepcion = m.Incidente_en_la_Recepcion
                        ,Incidente_en_la_RecepcionDescripcion = CultureHelper.GetTraduction(m.Incidente_en_la_Recepcion_Incidente_con_Invitacion.Clave.ToString(), "Descripcion") ?? (string)m.Incidente_en_la_Recepcion_Incidente_con_Invitacion.Descripcion
			,Documento = m.Documento

                    
                };
				var resultData = new
                {
                    data = result
                    ,nombre_del_interviniente_solicitante = Detalle_de_Solicitante_en_InvitacionesData
                    ,nombre_del_interviniente_requerido = Detalle_de_Requerido_en_InvitacionesData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }


    }
}

