using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Relaciones_MASC;
using Spartane.Core.Domain.Estatus_Solicitud;
using Spartane.Core.Domain.Solicitud;
using Spartane.Core.Domain.Detalle_Relaciones_MASC;

using Spartane.Core.Domain.Detalle_de_Imputado;
using Spartane.Core.Domain.Delito;
using Spartane.Core.Domain.Detalle_de_Datos_Generales;

using Spartane.Core.Domain.Detalle_de_Relaciones;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Resolucion_MASC;
using Spartane.Core.Domain.Tipo_de_Mecanismo_Alterno;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Resultado_de_Revision;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Resolucion_MASC;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Resultado_de_Revision;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Relaciones_MASC;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Relaciones_MASC;
using Spartane.Web.Areas.WebApiConsumer.Estatus_Solicitud;
using Spartane.Web.Areas.WebApiConsumer.Solicitud;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Relaciones_MASC;

using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Imputado;
using Spartane.Web.Areas.WebApiConsumer.Delito;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Datos_Generales;

using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Relaciones;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Resolucion_MASC;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Mecanismo_Alterno;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Resultado_de_Revision;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Resolucion_MASC;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Resultado_de_Revision;

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
    public class Relaciones_MASCController : Controller
    {
        #region "variable declaration"

        private IRelaciones_MASCService service = null;
        private IRelaciones_MASCApiConsumer _IRelaciones_MASCApiConsumer;
        private IEstatus_SolicitudApiConsumer _IEstatus_SolicitudApiConsumer;
        private ISolicitudApiConsumer _ISolicitudApiConsumer;
        private IDetalle_Relaciones_MASCApiConsumer _IDetalle_Relaciones_MASCApiConsumer;

        private IDetalle_de_ImputadoApiConsumer _IDetalle_de_ImputadoApiConsumer;
        private IDelitoApiConsumer _IDelitoApiConsumer;
        private IDetalle_de_Datos_GeneralesApiConsumer _IDetalle_de_Datos_GeneralesApiConsumer;

        private IDetalle_de_RelacionesApiConsumer _IDetalle_de_RelacionesApiConsumer;
        private ISpartan_UserApiConsumer _ISpartan_UserApiConsumer;
        private IResolucion_MASCApiConsumer _IResolucion_MASCApiConsumer;
        private ITipo_de_Mecanismo_AlternoApiConsumer _ITipo_de_Mecanismo_AlternoApiConsumer;
        private IResultado_de_RevisionApiConsumer _IResultado_de_RevisionApiConsumer;

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

        
        public Relaciones_MASCController(IRelaciones_MASCService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IRelaciones_MASCApiConsumer Relaciones_MASCApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , IEstatus_SolicitudApiConsumer Estatus_SolicitudApiConsumer , ISolicitudApiConsumer SolicitudApiConsumer , IDetalle_Relaciones_MASCApiConsumer Detalle_Relaciones_MASCApiConsumer , IDetalle_de_ImputadoApiConsumer Detalle_de_ImputadoApiConsumer , IDelitoApiConsumer DelitoApiConsumer , IDetalle_de_Datos_GeneralesApiConsumer Detalle_de_Datos_GeneralesApiConsumer  , IDetalle_de_RelacionesApiConsumer Detalle_de_RelacionesApiConsumer , ISpartan_UserApiConsumer Spartan_UserApiConsumer , IResolucion_MASCApiConsumer Resolucion_MASCApiConsumer , ITipo_de_Mecanismo_AlternoApiConsumer Tipo_de_Mecanismo_AlternoApiConsumer , IResultado_de_RevisionApiConsumer Resultado_de_RevisionApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IRelaciones_MASCApiConsumer = Relaciones_MASCApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_FormatApiConsumer = Spartan_FormatApiConsumer;
            this._ISpartan_Format_PermissionsApiConsumer = Spartan_Format_PermissionsApiConsumer;
            this._IGeneratePDFApiConsumer = GeneratePDFApiConsumer;
			this._ISpartan_FormatRelatedApiConsumer = Spartan_Format_RelatedApiConsumer;
            this._IEstatus_SolicitudApiConsumer = Estatus_SolicitudApiConsumer;
            this._ISolicitudApiConsumer = SolicitudApiConsumer;
            this._IDetalle_Relaciones_MASCApiConsumer = Detalle_Relaciones_MASCApiConsumer;

            this._IDetalle_de_ImputadoApiConsumer = Detalle_de_ImputadoApiConsumer;
            this._IDelitoApiConsumer = DelitoApiConsumer;
            this._IDetalle_de_Datos_GeneralesApiConsumer = Detalle_de_Datos_GeneralesApiConsumer;

            this._IDetalle_de_RelacionesApiConsumer = Detalle_de_RelacionesApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._IResolucion_MASCApiConsumer = Resolucion_MASCApiConsumer;
            this._ITipo_de_Mecanismo_AlternoApiConsumer = Tipo_de_Mecanismo_AlternoApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._IResultado_de_RevisionApiConsumer = Resultado_de_RevisionApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._IResolucion_MASCApiConsumer = Resolucion_MASCApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._IResultado_de_RevisionApiConsumer = Resultado_de_RevisionApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Relaciones_MASC
        [ObjectAuth(ObjectId = (ModuleObjectId)45702, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45702, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Relaciones_MASC/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45702, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45702, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varRelaciones_MASC = new Relaciones_MASCModel();
			varRelaciones_MASC.Clave = Id;
			
            ViewBag.ObjectId = "45702";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;

            var permissionDetalle_Relaciones_MASC = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45705, ModuleId);
            ViewBag.PermissionDetalle_Relaciones_MASC = permissionDetalle_Relaciones_MASC;


            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IRelaciones_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Relaciones_MASCsData = _IRelaciones_MASCApiConsumer.ListaSelAll(0, 1000, "Relaciones_MASC.Clave=" + Id, "").Resource.Relaciones_MASCs;
				
				if (Relaciones_MASCsData != null && Relaciones_MASCsData.Count > 0)
                {
					var Relaciones_MASCData = Relaciones_MASCsData.First();
					varRelaciones_MASC= new Relaciones_MASCModel
					{
						Clave  = Relaciones_MASCData.Clave 
	                    ,Estatus = Relaciones_MASCData.Estatus
                    ,EstatusDescripcion = CultureHelper.GetTraduction(Convert.ToString(Relaciones_MASCData.Estatus), "Estatus_Solicitud") ??  (string)Relaciones_MASCData.Estatus_Estatus_Solicitud.Descripcion
                    ,Numero_de_Expediente = Relaciones_MASCData.Numero_de_Expediente
                    ,Numero_de_ExpedienteNumero_de_Expediente = CultureHelper.GetTraduction(Convert.ToString(Relaciones_MASCData.Numero_de_Expediente), "Solicitud") ??  (string)Relaciones_MASCData.Numero_de_Expediente_Solicitud.Numero_de_Expediente
                    ,Numero_de_Procedimiento = Relaciones_MASCData.Numero_de_Procedimiento
                    ,idRelacionOrigen = Relaciones_MASCData.idRelacionOrigen
                    ,idRelacionOrigenDescripcion = CultureHelper.GetTraduction(Convert.ToString(Relaciones_MASCData.idRelacionOrigen), "Detalle_de_Relaciones") ??  (string)Relaciones_MASCData.idRelacionOrigen_Detalle_de_Relaciones.Descripcion
                    ,Requiere_cambiar_la_relacion = Relaciones_MASCData.Requiere_cambiar_la_relacion.GetValueOrDefault()
                    ,Motivo_de_Cambio = Relaciones_MASCData.Motivo_de_Cambio
                    ,Observaciones = Relaciones_MASCData.Observaciones
                    ,Descripcion = Relaciones_MASCData.Descripcion
                    ,Fecha_de_Resolucion_solicitud = (Relaciones_MASCData.Fecha_de_Resolucion_solicitud == null ? string.Empty : Convert.ToDateTime(Relaciones_MASCData.Fecha_de_Resolucion_solicitud).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Resolucion_solicitud = Relaciones_MASCData.Hora_de_Resolucion_solicitud
                    ,Usuario_que_Resuelve_solicitud = Relaciones_MASCData.Usuario_que_Resuelve_solicitud
                    ,Usuario_que_Resuelve_solicitudName = CultureHelper.GetTraduction(Convert.ToString(Relaciones_MASCData.Usuario_que_Resuelve_solicitud), "Spartan_User") ??  (string)Relaciones_MASCData.Usuario_que_Resuelve_solicitud_Spartan_User.Name
                    ,Resolucion = Relaciones_MASCData.Resolucion
                    ,ResolucionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Relaciones_MASCData.Resolucion), "Resolucion_MASC") ??  (string)Relaciones_MASCData.Resolucion_Resolucion_MASC.Descripcion
                    ,Tipo_de_Mecanismo = Relaciones_MASCData.Tipo_de_Mecanismo
                    ,Tipo_de_MecanismoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Relaciones_MASCData.Tipo_de_Mecanismo), "Tipo_de_Mecanismo_Alterno") ??  (string)Relaciones_MASCData.Tipo_de_Mecanismo_Tipo_de_Mecanismo_Alterno.Descripcion
                    ,Observaciones_solicitud = Relaciones_MASCData.Observaciones_solicitud
                    ,Fecha_de_Validacion_solicitud = (Relaciones_MASCData.Fecha_de_Validacion_solicitud == null ? string.Empty : Convert.ToDateTime(Relaciones_MASCData.Fecha_de_Validacion_solicitud).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Validacion_solicitud = Relaciones_MASCData.Hora_de_Validacion_solicitud
                    ,Usuario_que_Valida_solicitud = Relaciones_MASCData.Usuario_que_Valida_solicitud
                    ,Usuario_que_Valida_solicitudName = CultureHelper.GetTraduction(Convert.ToString(Relaciones_MASCData.Usuario_que_Valida_solicitud), "Spartan_User") ??  (string)Relaciones_MASCData.Usuario_que_Valida_solicitud_Spartan_User.Name
                    ,resultado_solicitud = Relaciones_MASCData.resultado_solicitud
                    ,resultado_solicitudDescripcion = CultureHelper.GetTraduction(Convert.ToString(Relaciones_MASCData.resultado_solicitud), "Resultado_de_Revision") ??  (string)Relaciones_MASCData.resultado_solicitud_Resultado_de_Revision.Descripcion
                    ,motivo_rechazo_solicitud = Relaciones_MASCData.motivo_rechazo_solicitud
                    ,Fecha_de_Resolucion_proc = (Relaciones_MASCData.Fecha_de_Resolucion_proc == null ? string.Empty : Convert.ToDateTime(Relaciones_MASCData.Fecha_de_Resolucion_proc).ToString(ConfigurationProperty.DateFormat))
                    ,hora_resolucion_proc = Relaciones_MASCData.hora_resolucion_proc
                    ,usuario_resuelve_proc = Relaciones_MASCData.usuario_resuelve_proc
                    ,usuario_resuelve_procName = CultureHelper.GetTraduction(Convert.ToString(Relaciones_MASCData.usuario_resuelve_proc), "Spartan_User") ??  (string)Relaciones_MASCData.usuario_resuelve_proc_Spartan_User.Name
                    ,Resolucion_proc = Relaciones_MASCData.Resolucion_proc
                    ,Resolucion_procDescripcion = CultureHelper.GetTraduction(Convert.ToString(Relaciones_MASCData.Resolucion_proc), "Resolucion_MASC") ??  (string)Relaciones_MASCData.Resolucion_proc_Resolucion_MASC.Descripcion
                    ,Observaciones_proc = Relaciones_MASCData.Observaciones_proc
                    ,Fecha_de_Validacion_proc = (Relaciones_MASCData.Fecha_de_Validacion_proc == null ? string.Empty : Convert.ToDateTime(Relaciones_MASCData.Fecha_de_Validacion_proc).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Validacion_proc = Relaciones_MASCData.Hora_de_Validacion_proc
                    ,Usuario_que_Valida_proc = Relaciones_MASCData.Usuario_que_Valida_proc
                    ,Usuario_que_Valida_procName = CultureHelper.GetTraduction(Convert.ToString(Relaciones_MASCData.Usuario_que_Valida_proc), "Spartan_User") ??  (string)Relaciones_MASCData.Usuario_que_Valida_proc_Spartan_User.Name
                    ,Resultado_proc = Relaciones_MASCData.Resultado_proc
                    ,Resultado_procDescripcion = CultureHelper.GetTraduction(Convert.ToString(Relaciones_MASCData.Resultado_proc), "Resultado_de_Revision") ??  (string)Relaciones_MASCData.Resultado_proc_Resultado_de_Revision.Descripcion
                    ,Motivo_de_Rechazo_proc = Relaciones_MASCData.Motivo_de_Rechazo_proc

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IEstatus_SolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_Solicituds_Estatus = _IEstatus_SolicitudApiConsumer.SelAll(true);
            if (Estatus_Solicituds_Estatus != null && Estatus_Solicituds_Estatus.Resource != null)
                ViewBag.Estatus_Solicituds_Estatus = Estatus_Solicituds_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_Solicitud", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDetalle_de_RelacionesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Detalle_de_Relacioness_idRelacionOrigen = _IDetalle_de_RelacionesApiConsumer.SelAll(true);
            if (Detalle_de_Relacioness_idRelacionOrigen != null && Detalle_de_Relacioness_idRelacionOrigen.Resource != null)
                ViewBag.Detalle_de_Relacioness_idRelacionOrigen = Detalle_de_Relacioness_idRelacionOrigen.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_Relaciones", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResolucion_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resolucion_MASCs_Resolucion = _IResolucion_MASCApiConsumer.SelAll(true);
            if (Resolucion_MASCs_Resolucion != null && Resolucion_MASCs_Resolucion.Resource != null)
                ViewBag.Resolucion_MASCs_Resolucion = Resolucion_MASCs_Resolucion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resolucion_MASC", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_Mecanismo_AlternoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Mecanismo_Alternos_Tipo_de_Mecanismo = _ITipo_de_Mecanismo_AlternoApiConsumer.SelAll(true);
            if (Tipo_de_Mecanismo_Alternos_Tipo_de_Mecanismo != null && Tipo_de_Mecanismo_Alternos_Tipo_de_Mecanismo.Resource != null)
                ViewBag.Tipo_de_Mecanismo_Alternos_Tipo_de_Mecanismo = Tipo_de_Mecanismo_Alternos_Tipo_de_Mecanismo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Mecanismo_Alterno", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResultado_de_RevisionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resultado_de_Revisions_resultado_solicitud = _IResultado_de_RevisionApiConsumer.SelAll(true);
            if (Resultado_de_Revisions_resultado_solicitud != null && Resultado_de_Revisions_resultado_solicitud.Resource != null)
                ViewBag.Resultado_de_Revisions_resultado_solicitud = Resultado_de_Revisions_resultado_solicitud.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resultado_de_Revision", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResolucion_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resolucion_MASCs_Resolucion_proc = _IResolucion_MASCApiConsumer.SelAll(true);
            if (Resolucion_MASCs_Resolucion_proc != null && Resolucion_MASCs_Resolucion_proc.Resource != null)
                ViewBag.Resolucion_MASCs_Resolucion_proc = Resolucion_MASCs_Resolucion_proc.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resolucion_MASC", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResultado_de_RevisionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resultado_de_Revisions_Resultado_proc = _IResultado_de_RevisionApiConsumer.SelAll(true);
            if (Resultado_de_Revisions_Resultado_proc != null && Resultado_de_Revisions_Resultado_proc.Resource != null)
                ViewBag.Resultado_de_Revisions_Resultado_proc = Resultado_de_Revisions_Resultado_proc.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resultado_de_Revision", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varRelaciones_MASC);
        }
		
	[HttpGet]
        public ActionResult AddRelaciones_MASC(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45702);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IRelaciones_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
			Relaciones_MASCModel varRelaciones_MASC= new Relaciones_MASCModel();
            var permissionDetalle_Relaciones_MASC = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45705, ModuleId);
            ViewBag.PermissionDetalle_Relaciones_MASC = permissionDetalle_Relaciones_MASC;


            if (id.ToString() != "0")
            {
                var Relaciones_MASCsData = _IRelaciones_MASCApiConsumer.ListaSelAll(0, 1000, "Relaciones_MASC.Clave=" + id, "").Resource.Relaciones_MASCs;
				
				if (Relaciones_MASCsData != null && Relaciones_MASCsData.Count > 0)
                {
					var Relaciones_MASCData = Relaciones_MASCsData.First();
					varRelaciones_MASC= new Relaciones_MASCModel
					{
						Clave  = Relaciones_MASCData.Clave 
	                    ,Estatus = Relaciones_MASCData.Estatus
                    ,EstatusDescripcion = CultureHelper.GetTraduction(Convert.ToString(Relaciones_MASCData.Estatus), "Estatus_Solicitud") ??  (string)Relaciones_MASCData.Estatus_Estatus_Solicitud.Descripcion
                    ,Numero_de_Expediente = Relaciones_MASCData.Numero_de_Expediente
                    ,Numero_de_ExpedienteNumero_de_Expediente = CultureHelper.GetTraduction(Convert.ToString(Relaciones_MASCData.Numero_de_Expediente), "Solicitud") ??  (string)Relaciones_MASCData.Numero_de_Expediente_Solicitud.Numero_de_Expediente
                    ,Numero_de_Procedimiento = Relaciones_MASCData.Numero_de_Procedimiento
                    ,idRelacionOrigen = Relaciones_MASCData.idRelacionOrigen
                    ,idRelacionOrigenDescripcion = CultureHelper.GetTraduction(Convert.ToString(Relaciones_MASCData.idRelacionOrigen), "Detalle_de_Relaciones") ??  (string)Relaciones_MASCData.idRelacionOrigen_Detalle_de_Relaciones.Descripcion
                    ,Requiere_cambiar_la_relacion = Relaciones_MASCData.Requiere_cambiar_la_relacion.GetValueOrDefault()
                    ,Motivo_de_Cambio = Relaciones_MASCData.Motivo_de_Cambio
                    ,Observaciones = Relaciones_MASCData.Observaciones
                    ,Descripcion = Relaciones_MASCData.Descripcion
                    ,Fecha_de_Resolucion_solicitud = (Relaciones_MASCData.Fecha_de_Resolucion_solicitud == null ? string.Empty : Convert.ToDateTime(Relaciones_MASCData.Fecha_de_Resolucion_solicitud).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Resolucion_solicitud = Relaciones_MASCData.Hora_de_Resolucion_solicitud
                    ,Usuario_que_Resuelve_solicitud = Relaciones_MASCData.Usuario_que_Resuelve_solicitud
                    ,Usuario_que_Resuelve_solicitudName = CultureHelper.GetTraduction(Convert.ToString(Relaciones_MASCData.Usuario_que_Resuelve_solicitud), "Spartan_User") ??  (string)Relaciones_MASCData.Usuario_que_Resuelve_solicitud_Spartan_User.Name
                    ,Resolucion = Relaciones_MASCData.Resolucion
                    ,ResolucionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Relaciones_MASCData.Resolucion), "Resolucion_MASC") ??  (string)Relaciones_MASCData.Resolucion_Resolucion_MASC.Descripcion
                    ,Tipo_de_Mecanismo = Relaciones_MASCData.Tipo_de_Mecanismo
                    ,Tipo_de_MecanismoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Relaciones_MASCData.Tipo_de_Mecanismo), "Tipo_de_Mecanismo_Alterno") ??  (string)Relaciones_MASCData.Tipo_de_Mecanismo_Tipo_de_Mecanismo_Alterno.Descripcion
                    ,Observaciones_solicitud = Relaciones_MASCData.Observaciones_solicitud
                    ,Fecha_de_Validacion_solicitud = (Relaciones_MASCData.Fecha_de_Validacion_solicitud == null ? string.Empty : Convert.ToDateTime(Relaciones_MASCData.Fecha_de_Validacion_solicitud).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Validacion_solicitud = Relaciones_MASCData.Hora_de_Validacion_solicitud
                    ,Usuario_que_Valida_solicitud = Relaciones_MASCData.Usuario_que_Valida_solicitud
                    ,Usuario_que_Valida_solicitudName = CultureHelper.GetTraduction(Convert.ToString(Relaciones_MASCData.Usuario_que_Valida_solicitud), "Spartan_User") ??  (string)Relaciones_MASCData.Usuario_que_Valida_solicitud_Spartan_User.Name
                    ,resultado_solicitud = Relaciones_MASCData.resultado_solicitud
                    ,resultado_solicitudDescripcion = CultureHelper.GetTraduction(Convert.ToString(Relaciones_MASCData.resultado_solicitud), "Resultado_de_Revision") ??  (string)Relaciones_MASCData.resultado_solicitud_Resultado_de_Revision.Descripcion
                    ,motivo_rechazo_solicitud = Relaciones_MASCData.motivo_rechazo_solicitud
                    ,Fecha_de_Resolucion_proc = (Relaciones_MASCData.Fecha_de_Resolucion_proc == null ? string.Empty : Convert.ToDateTime(Relaciones_MASCData.Fecha_de_Resolucion_proc).ToString(ConfigurationProperty.DateFormat))
                    ,hora_resolucion_proc = Relaciones_MASCData.hora_resolucion_proc
                    ,usuario_resuelve_proc = Relaciones_MASCData.usuario_resuelve_proc
                    ,usuario_resuelve_procName = CultureHelper.GetTraduction(Convert.ToString(Relaciones_MASCData.usuario_resuelve_proc), "Spartan_User") ??  (string)Relaciones_MASCData.usuario_resuelve_proc_Spartan_User.Name
                    ,Resolucion_proc = Relaciones_MASCData.Resolucion_proc
                    ,Resolucion_procDescripcion = CultureHelper.GetTraduction(Convert.ToString(Relaciones_MASCData.Resolucion_proc), "Resolucion_MASC") ??  (string)Relaciones_MASCData.Resolucion_proc_Resolucion_MASC.Descripcion
                    ,Observaciones_proc = Relaciones_MASCData.Observaciones_proc
                    ,Fecha_de_Validacion_proc = (Relaciones_MASCData.Fecha_de_Validacion_proc == null ? string.Empty : Convert.ToDateTime(Relaciones_MASCData.Fecha_de_Validacion_proc).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Validacion_proc = Relaciones_MASCData.Hora_de_Validacion_proc
                    ,Usuario_que_Valida_proc = Relaciones_MASCData.Usuario_que_Valida_proc
                    ,Usuario_que_Valida_procName = CultureHelper.GetTraduction(Convert.ToString(Relaciones_MASCData.Usuario_que_Valida_proc), "Spartan_User") ??  (string)Relaciones_MASCData.Usuario_que_Valida_proc_Spartan_User.Name
                    ,Resultado_proc = Relaciones_MASCData.Resultado_proc
                    ,Resultado_procDescripcion = CultureHelper.GetTraduction(Convert.ToString(Relaciones_MASCData.Resultado_proc), "Resultado_de_Revision") ??  (string)Relaciones_MASCData.Resultado_proc_Resultado_de_Revision.Descripcion
                    ,Motivo_de_Rechazo_proc = Relaciones_MASCData.Motivo_de_Rechazo_proc

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IEstatus_SolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_Solicituds_Estatus = _IEstatus_SolicitudApiConsumer.SelAll(true);
            if (Estatus_Solicituds_Estatus != null && Estatus_Solicituds_Estatus.Resource != null)
                ViewBag.Estatus_Solicituds_Estatus = Estatus_Solicituds_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_Solicitud", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDetalle_de_RelacionesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Detalle_de_Relacioness_idRelacionOrigen = _IDetalle_de_RelacionesApiConsumer.SelAll(true);
            if (Detalle_de_Relacioness_idRelacionOrigen != null && Detalle_de_Relacioness_idRelacionOrigen.Resource != null)
                ViewBag.Detalle_de_Relacioness_idRelacionOrigen = Detalle_de_Relacioness_idRelacionOrigen.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_Relaciones", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResolucion_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resolucion_MASCs_Resolucion = _IResolucion_MASCApiConsumer.SelAll(true);
            if (Resolucion_MASCs_Resolucion != null && Resolucion_MASCs_Resolucion.Resource != null)
                ViewBag.Resolucion_MASCs_Resolucion = Resolucion_MASCs_Resolucion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resolucion_MASC", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_Mecanismo_AlternoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Mecanismo_Alternos_Tipo_de_Mecanismo = _ITipo_de_Mecanismo_AlternoApiConsumer.SelAll(true);
            if (Tipo_de_Mecanismo_Alternos_Tipo_de_Mecanismo != null && Tipo_de_Mecanismo_Alternos_Tipo_de_Mecanismo.Resource != null)
                ViewBag.Tipo_de_Mecanismo_Alternos_Tipo_de_Mecanismo = Tipo_de_Mecanismo_Alternos_Tipo_de_Mecanismo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Mecanismo_Alterno", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResultado_de_RevisionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resultado_de_Revisions_resultado_solicitud = _IResultado_de_RevisionApiConsumer.SelAll(true);
            if (Resultado_de_Revisions_resultado_solicitud != null && Resultado_de_Revisions_resultado_solicitud.Resource != null)
                ViewBag.Resultado_de_Revisions_resultado_solicitud = Resultado_de_Revisions_resultado_solicitud.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resultado_de_Revision", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResolucion_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resolucion_MASCs_Resolucion_proc = _IResolucion_MASCApiConsumer.SelAll(true);
            if (Resolucion_MASCs_Resolucion_proc != null && Resolucion_MASCs_Resolucion_proc.Resource != null)
                ViewBag.Resolucion_MASCs_Resolucion_proc = Resolucion_MASCs_Resolucion_proc.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resolucion_MASC", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResultado_de_RevisionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resultado_de_Revisions_Resultado_proc = _IResultado_de_RevisionApiConsumer.SelAll(true);
            if (Resultado_de_Revisions_Resultado_proc != null && Resultado_de_Revisions_Resultado_proc.Resource != null)
                ViewBag.Resultado_de_Revisions_Resultado_proc = Resultado_de_Revisions_Resultado_proc.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resultado_de_Revision", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddRelaciones_MASC", varRelaciones_MASC);
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
        public ActionResult GetEstatus_SolicitudAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstatus_SolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstatus_SolicitudApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_Solicitud", "Descripcion")?? m.Descripcion,
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
				
                return Json(result.OrderBy(m => m.Numero_de_Expediente).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Solicitud", "Numero_de_Expediente")?? m.Numero_de_Expediente,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_RelacionesAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_RelacionesApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_RelacionesApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_Relaciones", "Descripcion")?? m.Descripcion,
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
        public ActionResult GetResolucion_MASCAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IResolucion_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IResolucion_MASCApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resolucion_MASC", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetTipo_de_Mecanismo_AlternoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_Mecanismo_AlternoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_Mecanismo_AlternoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Mecanismo_Alterno", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetResultado_de_RevisionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IResultado_de_RevisionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IResultado_de_RevisionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resultado_de_Revision", "Descripcion")?? m.Descripcion,
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
        public ActionResult ShowAdvanceFilter(Relaciones_MASCAdvanceSearchModel model, int idFilter = -1)
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

            _IEstatus_SolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_Solicituds_Estatus = _IEstatus_SolicitudApiConsumer.SelAll(true);
            if (Estatus_Solicituds_Estatus != null && Estatus_Solicituds_Estatus.Resource != null)
                ViewBag.Estatus_Solicituds_Estatus = Estatus_Solicituds_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_Solicitud", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDetalle_de_RelacionesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Detalle_de_Relacioness_idRelacionOrigen = _IDetalle_de_RelacionesApiConsumer.SelAll(true);
            if (Detalle_de_Relacioness_idRelacionOrigen != null && Detalle_de_Relacioness_idRelacionOrigen.Resource != null)
                ViewBag.Detalle_de_Relacioness_idRelacionOrigen = Detalle_de_Relacioness_idRelacionOrigen.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_Relaciones", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResolucion_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resolucion_MASCs_Resolucion = _IResolucion_MASCApiConsumer.SelAll(true);
            if (Resolucion_MASCs_Resolucion != null && Resolucion_MASCs_Resolucion.Resource != null)
                ViewBag.Resolucion_MASCs_Resolucion = Resolucion_MASCs_Resolucion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resolucion_MASC", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_Mecanismo_AlternoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Mecanismo_Alternos_Tipo_de_Mecanismo = _ITipo_de_Mecanismo_AlternoApiConsumer.SelAll(true);
            if (Tipo_de_Mecanismo_Alternos_Tipo_de_Mecanismo != null && Tipo_de_Mecanismo_Alternos_Tipo_de_Mecanismo.Resource != null)
                ViewBag.Tipo_de_Mecanismo_Alternos_Tipo_de_Mecanismo = Tipo_de_Mecanismo_Alternos_Tipo_de_Mecanismo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Mecanismo_Alterno", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResultado_de_RevisionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resultado_de_Revisions_resultado_solicitud = _IResultado_de_RevisionApiConsumer.SelAll(true);
            if (Resultado_de_Revisions_resultado_solicitud != null && Resultado_de_Revisions_resultado_solicitud.Resource != null)
                ViewBag.Resultado_de_Revisions_resultado_solicitud = Resultado_de_Revisions_resultado_solicitud.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resultado_de_Revision", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResolucion_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resolucion_MASCs_Resolucion_proc = _IResolucion_MASCApiConsumer.SelAll(true);
            if (Resolucion_MASCs_Resolucion_proc != null && Resolucion_MASCs_Resolucion_proc.Resource != null)
                ViewBag.Resolucion_MASCs_Resolucion_proc = Resolucion_MASCs_Resolucion_proc.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resolucion_MASC", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResultado_de_RevisionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resultado_de_Revisions_Resultado_proc = _IResultado_de_RevisionApiConsumer.SelAll(true);
            if (Resultado_de_Revisions_Resultado_proc != null && Resultado_de_Revisions_Resultado_proc.Resource != null)
                ViewBag.Resultado_de_Revisions_Resultado_proc = Resultado_de_Revisions_Resultado_proc.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resultado_de_Revision", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IEstatus_SolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_Solicituds_Estatus = _IEstatus_SolicitudApiConsumer.SelAll(true);
            if (Estatus_Solicituds_Estatus != null && Estatus_Solicituds_Estatus.Resource != null)
                ViewBag.Estatus_Solicituds_Estatus = Estatus_Solicituds_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_Solicitud", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDetalle_de_RelacionesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Detalle_de_Relacioness_idRelacionOrigen = _IDetalle_de_RelacionesApiConsumer.SelAll(true);
            if (Detalle_de_Relacioness_idRelacionOrigen != null && Detalle_de_Relacioness_idRelacionOrigen.Resource != null)
                ViewBag.Detalle_de_Relacioness_idRelacionOrigen = Detalle_de_Relacioness_idRelacionOrigen.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_Relaciones", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResolucion_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resolucion_MASCs_Resolucion = _IResolucion_MASCApiConsumer.SelAll(true);
            if (Resolucion_MASCs_Resolucion != null && Resolucion_MASCs_Resolucion.Resource != null)
                ViewBag.Resolucion_MASCs_Resolucion = Resolucion_MASCs_Resolucion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resolucion_MASC", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_Mecanismo_AlternoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Mecanismo_Alternos_Tipo_de_Mecanismo = _ITipo_de_Mecanismo_AlternoApiConsumer.SelAll(true);
            if (Tipo_de_Mecanismo_Alternos_Tipo_de_Mecanismo != null && Tipo_de_Mecanismo_Alternos_Tipo_de_Mecanismo.Resource != null)
                ViewBag.Tipo_de_Mecanismo_Alternos_Tipo_de_Mecanismo = Tipo_de_Mecanismo_Alternos_Tipo_de_Mecanismo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Mecanismo_Alterno", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResultado_de_RevisionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resultado_de_Revisions_resultado_solicitud = _IResultado_de_RevisionApiConsumer.SelAll(true);
            if (Resultado_de_Revisions_resultado_solicitud != null && Resultado_de_Revisions_resultado_solicitud.Resource != null)
                ViewBag.Resultado_de_Revisions_resultado_solicitud = Resultado_de_Revisions_resultado_solicitud.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resultado_de_Revision", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResolucion_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resolucion_MASCs_Resolucion_proc = _IResolucion_MASCApiConsumer.SelAll(true);
            if (Resolucion_MASCs_Resolucion_proc != null && Resolucion_MASCs_Resolucion_proc.Resource != null)
                ViewBag.Resolucion_MASCs_Resolucion_proc = Resolucion_MASCs_Resolucion_proc.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resolucion_MASC", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResultado_de_RevisionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resultado_de_Revisions_Resultado_proc = _IResultado_de_RevisionApiConsumer.SelAll(true);
            if (Resultado_de_Revisions_Resultado_proc != null && Resultado_de_Revisions_Resultado_proc.Resource != null)
                ViewBag.Resultado_de_Revisions_Resultado_proc = Resultado_de_Revisions_Resultado_proc.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resultado_de_Revision", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Relaciones_MASCAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Relaciones_MASCAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Relaciones_MASCAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Relaciones_MASCPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IRelaciones_MASCApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Relaciones_MASCs == null)
                result.Relaciones_MASCs = new List<Relaciones_MASC>();

            return Json(new
            {
                data = result.Relaciones_MASCs.Select(m => new Relaciones_MASCGridModel
                    {
                    Clave = m.Clave
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_Solicitud.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_Solicitud.Descripcion
                        ,Numero_de_ExpedienteNumero_de_Expediente = CultureHelper.GetTraduction(m.Numero_de_Expediente_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Numero_de_Expediente_Solicitud.Numero_de_Expediente
			,Numero_de_Procedimiento = m.Numero_de_Procedimiento
                        ,idRelacionOrigenDescripcion = CultureHelper.GetTraduction(m.idRelacionOrigen_Detalle_de_Relaciones.Clave.ToString(), "Descripcion") ?? (string)m.idRelacionOrigen_Detalle_de_Relaciones.Descripcion
			,Requiere_cambiar_la_relacion = m.Requiere_cambiar_la_relacion
			,Motivo_de_Cambio = m.Motivo_de_Cambio
			,Observaciones = m.Observaciones
			,Descripcion = m.Descripcion
                        ,Fecha_de_Resolucion_solicitud = (m.Fecha_de_Resolucion_solicitud == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Resolucion_solicitud).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Resolucion_solicitud = m.Hora_de_Resolucion_solicitud
                        ,Usuario_que_Resuelve_solicitudName = CultureHelper.GetTraduction(m.Usuario_que_Resuelve_solicitud_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Resuelve_solicitud_Spartan_User.Name
                        ,ResolucionDescripcion = CultureHelper.GetTraduction(m.Resolucion_Resolucion_MASC.Clave.ToString(), "Descripcion") ?? (string)m.Resolucion_Resolucion_MASC.Descripcion
                        ,Tipo_de_MecanismoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Mecanismo_Tipo_de_Mecanismo_Alterno.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Mecanismo_Tipo_de_Mecanismo_Alterno.Descripcion
			,Observaciones_solicitud = m.Observaciones_solicitud
                        ,Fecha_de_Validacion_solicitud = (m.Fecha_de_Validacion_solicitud == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Validacion_solicitud).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Validacion_solicitud = m.Hora_de_Validacion_solicitud
                        ,Usuario_que_Valida_solicitudName = CultureHelper.GetTraduction(m.Usuario_que_Valida_solicitud_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Valida_solicitud_Spartan_User.Name
                        ,resultado_solicitudDescripcion = CultureHelper.GetTraduction(m.resultado_solicitud_Resultado_de_Revision.Clave.ToString(), "Descripcion") ?? (string)m.resultado_solicitud_Resultado_de_Revision.Descripcion
			,motivo_rechazo_solicitud = m.motivo_rechazo_solicitud
                        ,Fecha_de_Resolucion_proc = (m.Fecha_de_Resolucion_proc == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Resolucion_proc).ToString(ConfigurationProperty.DateFormat))
			,hora_resolucion_proc = m.hora_resolucion_proc
                        ,usuario_resuelve_procName = CultureHelper.GetTraduction(m.usuario_resuelve_proc_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.usuario_resuelve_proc_Spartan_User.Name
                        ,Resolucion_procDescripcion = CultureHelper.GetTraduction(m.Resolucion_proc_Resolucion_MASC.Clave.ToString(), "Descripcion") ?? (string)m.Resolucion_proc_Resolucion_MASC.Descripcion
			,Observaciones_proc = m.Observaciones_proc
                        ,Fecha_de_Validacion_proc = (m.Fecha_de_Validacion_proc == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Validacion_proc).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Validacion_proc = m.Hora_de_Validacion_proc
                        ,Usuario_que_Valida_procName = CultureHelper.GetTraduction(m.Usuario_que_Valida_proc_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Valida_proc_Spartan_User.Name
                        ,Resultado_procDescripcion = CultureHelper.GetTraduction(m.Resultado_proc_Resultado_de_Revision.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_proc_Resultado_de_Revision.Descripcion
			,Motivo_de_Rechazo_proc = m.Motivo_de_Rechazo_proc

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetRelaciones_MASCAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRelaciones_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IRelaciones_MASCApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Relaciones_MASC", m.),
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
        /// Get List of Relaciones_MASC from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Relaciones_MASC Entity</returns>
        public ActionResult GetRelaciones_MASCList(UrlParametersModel param)
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
            _IRelaciones_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Relaciones_MASCPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Relaciones_MASCAdvanceSearchModel))
                {
					var advanceFilter =
                    (Relaciones_MASCAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Relaciones_MASCPropertyMapper oRelaciones_MASCPropertyMapper = new Relaciones_MASCPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oRelaciones_MASCPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IRelaciones_MASCApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Relaciones_MASCs == null)
                result.Relaciones_MASCs = new List<Relaciones_MASC>();

            return Json(new
            {
                aaData = result.Relaciones_MASCs.Select(m => new Relaciones_MASCGridModel
            {
                    Clave = m.Clave
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_Solicitud.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_Solicitud.Descripcion
                        ,Numero_de_ExpedienteNumero_de_Expediente = CultureHelper.GetTraduction(m.Numero_de_Expediente_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Numero_de_Expediente_Solicitud.Numero_de_Expediente
			,Numero_de_Procedimiento = m.Numero_de_Procedimiento
                        ,idRelacionOrigenDescripcion = CultureHelper.GetTraduction(m.idRelacionOrigen_Detalle_de_Relaciones.Clave.ToString(), "Descripcion") ?? (string)m.idRelacionOrigen_Detalle_de_Relaciones.Descripcion
			,Requiere_cambiar_la_relacion = m.Requiere_cambiar_la_relacion
			,Motivo_de_Cambio = m.Motivo_de_Cambio
			,Observaciones = m.Observaciones
			,Descripcion = m.Descripcion
                        ,Fecha_de_Resolucion_solicitud = (m.Fecha_de_Resolucion_solicitud == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Resolucion_solicitud).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Resolucion_solicitud = m.Hora_de_Resolucion_solicitud
                        ,Usuario_que_Resuelve_solicitudName = CultureHelper.GetTraduction(m.Usuario_que_Resuelve_solicitud_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Resuelve_solicitud_Spartan_User.Name
                        ,ResolucionDescripcion = CultureHelper.GetTraduction(m.Resolucion_Resolucion_MASC.Clave.ToString(), "Descripcion") ?? (string)m.Resolucion_Resolucion_MASC.Descripcion
                        ,Tipo_de_MecanismoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Mecanismo_Tipo_de_Mecanismo_Alterno.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Mecanismo_Tipo_de_Mecanismo_Alterno.Descripcion
			,Observaciones_solicitud = m.Observaciones_solicitud
                        ,Fecha_de_Validacion_solicitud = (m.Fecha_de_Validacion_solicitud == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Validacion_solicitud).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Validacion_solicitud = m.Hora_de_Validacion_solicitud
                        ,Usuario_que_Valida_solicitudName = CultureHelper.GetTraduction(m.Usuario_que_Valida_solicitud_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Valida_solicitud_Spartan_User.Name
                        ,resultado_solicitudDescripcion = CultureHelper.GetTraduction(m.resultado_solicitud_Resultado_de_Revision.Clave.ToString(), "Descripcion") ?? (string)m.resultado_solicitud_Resultado_de_Revision.Descripcion
			,motivo_rechazo_solicitud = m.motivo_rechazo_solicitud
                        ,Fecha_de_Resolucion_proc = (m.Fecha_de_Resolucion_proc == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Resolucion_proc).ToString(ConfigurationProperty.DateFormat))
			,hora_resolucion_proc = m.hora_resolucion_proc
                        ,usuario_resuelve_procName = CultureHelper.GetTraduction(m.usuario_resuelve_proc_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.usuario_resuelve_proc_Spartan_User.Name
                        ,Resolucion_procDescripcion = CultureHelper.GetTraduction(m.Resolucion_proc_Resolucion_MASC.Clave.ToString(), "Descripcion") ?? (string)m.Resolucion_proc_Resolucion_MASC.Descripcion
			,Observaciones_proc = m.Observaciones_proc
                        ,Fecha_de_Validacion_proc = (m.Fecha_de_Validacion_proc == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Validacion_proc).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Validacion_proc = m.Hora_de_Validacion_proc
                        ,Usuario_que_Valida_procName = CultureHelper.GetTraduction(m.Usuario_que_Valida_proc_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Valida_proc_Spartan_User.Name
                        ,Resultado_procDescripcion = CultureHelper.GetTraduction(m.Resultado_proc_Resultado_de_Revision.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_proc_Resultado_de_Revision.Descripcion
			,Motivo_de_Rechazo_proc = m.Motivo_de_Rechazo_proc

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetRelaciones_MASC_Numero_de_Expediente_Solicitud(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Solicitud.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Solicitud.Numero_de_Expediente as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _ISolicitudApiConsumer.ListaSelAll(1, 20,elWhere , " Solicitud.Numero_de_Expediente ASC ").Resource;
               
                foreach (var item in result.Solicituds)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Solicitud", "Numero_de_Expediente");
                    item.Numero_de_Expediente =trans ??item.Numero_de_Expediente;
                }
                return Json(result.Solicituds.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
//Grid GetAutoComplete
        [HttpGet]
        public JsonResult GetDetalle_Relaciones_MASC_Requerido_Detalle_de_Imputado(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_ImputadoApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Detalle_de_Imputado.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Detalle_de_Imputado.Nombre_Completo_Detenido as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IDetalle_de_ImputadoApiConsumer.ListaSelAll(1, 20,elWhere , " Detalle_de_Imputado.Nombre_Completo_Detenido ASC ").Resource;
               
                foreach (var item in result.Detalle_de_Imputados)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Detalle_de_Imputado", "Nombre_Completo_Detenido");
                    item.Nombre_Completo_Detenido =trans ??item.Nombre_Completo_Detenido;
                }
                return Json(result.Detalle_de_Imputados.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetDetalle_Relaciones_MASC_Delito_Delito(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDelitoApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Delito.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Delito.Descripcion as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IDelitoApiConsumer.ListaSelAll(1, 20,elWhere , " Delito.Descripcion ASC ").Resource;
               
                foreach (var item in result.Delitos)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Delito", "Descripcion");
                    item.Descripcion =trans ??item.Descripcion;
                }
                return Json(result.Delitos.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetDetalle_Relaciones_MASC_Solicitante_Detalle_de_Datos_Generales(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Datos_GeneralesApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Detalle_de_Datos_Generales.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Detalle_de_Datos_Generales.Nombre_Completo as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IDetalle_de_Datos_GeneralesApiConsumer.ListaSelAll(1, 20,elWhere , " Detalle_de_Datos_Generales.Nombre_Completo ASC ").Resource;
               
                foreach (var item in result.Detalle_de_Datos_Generaless)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Detalle_de_Datos_Generales", "Nombre_Completo");
                    item.Nombre_Completo =trans ??item.Nombre_Completo;
                }
                return Json(result.Detalle_de_Datos_Generaless.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public JsonResult GetRelaciones_MASC_Usuario_que_Resuelve_solicitud_Spartan_User(string query, string where)
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
        public JsonResult GetRelaciones_MASC_Usuario_que_Valida_solicitud_Spartan_User(string query, string where)
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
        public JsonResult GetRelaciones_MASC_usuario_resuelve_proc_Spartan_User(string query, string where)
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
        public JsonResult GetRelaciones_MASC_Usuario_que_Valida_proc_Spartan_User(string query, string where)
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
        public string GetAdvanceFilter(Relaciones_MASCAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Relaciones_MASC.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Relaciones_MASC.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstatus))
            {
                switch (filter.EstatusFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estatus_Solicitud.Descripcion LIKE '" + filter.AdvanceEstatus + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estatus_Solicitud.Descripcion LIKE '%" + filter.AdvanceEstatus + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estatus_Solicitud.Descripcion = '" + filter.AdvanceEstatus + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estatus_Solicitud.Descripcion LIKE '%" + filter.AdvanceEstatus + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstatusMultiple != null && filter.AdvanceEstatusMultiple.Count() > 0)
            {
                var EstatusIds = string.Join(",", filter.AdvanceEstatusMultiple);

                where += " AND Relaciones_MASC.Estatus In (" + EstatusIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceNumero_de_Expediente))
            {
                switch (filter.Numero_de_ExpedienteFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud.Numero_de_Expediente LIKE '" + filter.AdvanceNumero_de_Expediente + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud.Numero_de_Expediente LIKE '%" + filter.AdvanceNumero_de_Expediente + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud.Numero_de_Expediente = '" + filter.AdvanceNumero_de_Expediente + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud.Numero_de_Expediente LIKE '%" + filter.AdvanceNumero_de_Expediente + "%'";
                        break;
                }
            }
            else if (filter.AdvanceNumero_de_ExpedienteMultiple != null && filter.AdvanceNumero_de_ExpedienteMultiple.Count() > 0)
            {
                var Numero_de_ExpedienteIds = string.Join(",", filter.AdvanceNumero_de_ExpedienteMultiple);

                where += " AND Relaciones_MASC.Numero_de_Expediente In (" + Numero_de_ExpedienteIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Numero_de_Procedimiento))
            {
                switch (filter.Numero_de_ProcedimientoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Relaciones_MASC.Numero_de_Procedimiento LIKE '" + filter.Numero_de_Procedimiento + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Relaciones_MASC.Numero_de_Procedimiento LIKE '%" + filter.Numero_de_Procedimiento + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Relaciones_MASC.Numero_de_Procedimiento = '" + filter.Numero_de_Procedimiento + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Relaciones_MASC.Numero_de_Procedimiento LIKE '%" + filter.Numero_de_Procedimiento + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceidRelacionOrigen))
            {
                switch (filter.idRelacionOrigenFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Relaciones.Descripcion LIKE '" + filter.AdvanceidRelacionOrigen + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Relaciones.Descripcion LIKE '%" + filter.AdvanceidRelacionOrigen + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Relaciones.Descripcion = '" + filter.AdvanceidRelacionOrigen + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Relaciones.Descripcion LIKE '%" + filter.AdvanceidRelacionOrigen + "%'";
                        break;
                }
            }
            else if (filter.AdvanceidRelacionOrigenMultiple != null && filter.AdvanceidRelacionOrigenMultiple.Count() > 0)
            {
                var idRelacionOrigenIds = string.Join(",", filter.AdvanceidRelacionOrigenMultiple);

                where += " AND Relaciones_MASC.idRelacionOrigen In (" + idRelacionOrigenIds + ")";
            }

            if (filter.Requiere_cambiar_la_relacion != RadioOptions.NoApply)
                where += " AND Relaciones_MASC.Requiere_cambiar_la_relacion = " + Convert.ToInt32(filter.Requiere_cambiar_la_relacion);

            if (!string.IsNullOrEmpty(filter.Motivo_de_Cambio))
            {
                switch (filter.Motivo_de_CambioFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Relaciones_MASC.Motivo_de_Cambio LIKE '" + filter.Motivo_de_Cambio + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Relaciones_MASC.Motivo_de_Cambio LIKE '%" + filter.Motivo_de_Cambio + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Relaciones_MASC.Motivo_de_Cambio = '" + filter.Motivo_de_Cambio + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Relaciones_MASC.Motivo_de_Cambio LIKE '%" + filter.Motivo_de_Cambio + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Observaciones))
            {
                switch (filter.ObservacionesFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Relaciones_MASC.Observaciones LIKE '" + filter.Observaciones + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Relaciones_MASC.Observaciones LIKE '%" + filter.Observaciones + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Relaciones_MASC.Observaciones = '" + filter.Observaciones + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Relaciones_MASC.Observaciones LIKE '%" + filter.Observaciones + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Descripcion))
            {
                switch (filter.DescripcionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Relaciones_MASC.Descripcion LIKE '" + filter.Descripcion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Relaciones_MASC.Descripcion LIKE '%" + filter.Descripcion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Relaciones_MASC.Descripcion = '" + filter.Descripcion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Relaciones_MASC.Descripcion LIKE '%" + filter.Descripcion + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Resolucion_solicitud) || !string.IsNullOrEmpty(filter.ToFecha_de_Resolucion_solicitud))
            {
                var Fecha_de_Resolucion_solicitudFrom = DateTime.ParseExact(filter.FromFecha_de_Resolucion_solicitud, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_Resolucion_solicitudTo = DateTime.ParseExact(filter.ToFecha_de_Resolucion_solicitud, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Resolucion_solicitud))
                    where += " AND Relaciones_MASC.Fecha_de_Resolucion_solicitud >= '" + Fecha_de_Resolucion_solicitudFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Resolucion_solicitud))
                    where += " AND Relaciones_MASC.Fecha_de_Resolucion_solicitud <= '" + Fecha_de_Resolucion_solicitudTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Resolucion_solicitud) || !string.IsNullOrEmpty(filter.ToHora_de_Resolucion_solicitud))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Resolucion_solicitud))
                    where += " AND Convert(TIME,Relaciones_MASC.Hora_de_Resolucion_solicitud) >='" + filter.FromHora_de_Resolucion_solicitud + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Resolucion_solicitud))
                    where += " AND Convert(TIME,Relaciones_MASC.Hora_de_Resolucion_solicitud) <='" + filter.ToHora_de_Resolucion_solicitud + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceUsuario_que_Resuelve_solicitud))
            {
                switch (filter.Usuario_que_Resuelve_solicitudFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_User.Name LIKE '" + filter.AdvanceUsuario_que_Resuelve_solicitud + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceUsuario_que_Resuelve_solicitud + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_User.Name = '" + filter.AdvanceUsuario_que_Resuelve_solicitud + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceUsuario_que_Resuelve_solicitud + "%'";
                        break;
                }
            }
            else if (filter.AdvanceUsuario_que_Resuelve_solicitudMultiple != null && filter.AdvanceUsuario_que_Resuelve_solicitudMultiple.Count() > 0)
            {
                var Usuario_que_Resuelve_solicitudIds = string.Join(",", filter.AdvanceUsuario_que_Resuelve_solicitudMultiple);

                where += " AND Relaciones_MASC.Usuario_que_Resuelve_solicitud In (" + Usuario_que_Resuelve_solicitudIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceResolucion))
            {
                switch (filter.ResolucionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Resolucion_MASC.Descripcion LIKE '" + filter.AdvanceResolucion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Resolucion_MASC.Descripcion LIKE '%" + filter.AdvanceResolucion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Resolucion_MASC.Descripcion = '" + filter.AdvanceResolucion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Resolucion_MASC.Descripcion LIKE '%" + filter.AdvanceResolucion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceResolucionMultiple != null && filter.AdvanceResolucionMultiple.Count() > 0)
            {
                var ResolucionIds = string.Join(",", filter.AdvanceResolucionMultiple);

                where += " AND Relaciones_MASC.Resolucion In (" + ResolucionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Mecanismo))
            {
                switch (filter.Tipo_de_MecanismoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Mecanismo_Alterno.Descripcion LIKE '" + filter.AdvanceTipo_de_Mecanismo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Mecanismo_Alterno.Descripcion LIKE '%" + filter.AdvanceTipo_de_Mecanismo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Mecanismo_Alterno.Descripcion = '" + filter.AdvanceTipo_de_Mecanismo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Mecanismo_Alterno.Descripcion LIKE '%" + filter.AdvanceTipo_de_Mecanismo + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_MecanismoMultiple != null && filter.AdvanceTipo_de_MecanismoMultiple.Count() > 0)
            {
                var Tipo_de_MecanismoIds = string.Join(",", filter.AdvanceTipo_de_MecanismoMultiple);

                where += " AND Relaciones_MASC.Tipo_de_Mecanismo In (" + Tipo_de_MecanismoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Observaciones_solicitud))
            {
                switch (filter.Observaciones_solicitudFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Relaciones_MASC.Observaciones_solicitud LIKE '" + filter.Observaciones_solicitud + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Relaciones_MASC.Observaciones_solicitud LIKE '%" + filter.Observaciones_solicitud + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Relaciones_MASC.Observaciones_solicitud = '" + filter.Observaciones_solicitud + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Relaciones_MASC.Observaciones_solicitud LIKE '%" + filter.Observaciones_solicitud + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Validacion_solicitud) || !string.IsNullOrEmpty(filter.ToFecha_de_Validacion_solicitud))
            {
                var Fecha_de_Validacion_solicitudFrom = DateTime.ParseExact(filter.FromFecha_de_Validacion_solicitud, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_Validacion_solicitudTo = DateTime.ParseExact(filter.ToFecha_de_Validacion_solicitud, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Validacion_solicitud))
                    where += " AND Relaciones_MASC.Fecha_de_Validacion_solicitud >= '" + Fecha_de_Validacion_solicitudFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Validacion_solicitud))
                    where += " AND Relaciones_MASC.Fecha_de_Validacion_solicitud <= '" + Fecha_de_Validacion_solicitudTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Validacion_solicitud) || !string.IsNullOrEmpty(filter.ToHora_de_Validacion_solicitud))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Validacion_solicitud))
                    where += " AND Convert(TIME,Relaciones_MASC.Hora_de_Validacion_solicitud) >='" + filter.FromHora_de_Validacion_solicitud + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Validacion_solicitud))
                    where += " AND Convert(TIME,Relaciones_MASC.Hora_de_Validacion_solicitud) <='" + filter.ToHora_de_Validacion_solicitud + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceUsuario_que_Valida_solicitud))
            {
                switch (filter.Usuario_que_Valida_solicitudFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_User.Name LIKE '" + filter.AdvanceUsuario_que_Valida_solicitud + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceUsuario_que_Valida_solicitud + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_User.Name = '" + filter.AdvanceUsuario_que_Valida_solicitud + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceUsuario_que_Valida_solicitud + "%'";
                        break;
                }
            }
            else if (filter.AdvanceUsuario_que_Valida_solicitudMultiple != null && filter.AdvanceUsuario_que_Valida_solicitudMultiple.Count() > 0)
            {
                var Usuario_que_Valida_solicitudIds = string.Join(",", filter.AdvanceUsuario_que_Valida_solicitudMultiple);

                where += " AND Relaciones_MASC.Usuario_que_Valida_solicitud In (" + Usuario_que_Valida_solicitudIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Advanceresultado_solicitud))
            {
                switch (filter.resultado_solicitudFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Resultado_de_Revision.Descripcion LIKE '" + filter.Advanceresultado_solicitud + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Resultado_de_Revision.Descripcion LIKE '%" + filter.Advanceresultado_solicitud + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Resultado_de_Revision.Descripcion = '" + filter.Advanceresultado_solicitud + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Resultado_de_Revision.Descripcion LIKE '%" + filter.Advanceresultado_solicitud + "%'";
                        break;
                }
            }
            else if (filter.Advanceresultado_solicitudMultiple != null && filter.Advanceresultado_solicitudMultiple.Count() > 0)
            {
                var resultado_solicitudIds = string.Join(",", filter.Advanceresultado_solicitudMultiple);

                where += " AND Relaciones_MASC.resultado_solicitud In (" + resultado_solicitudIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.motivo_rechazo_solicitud))
            {
                switch (filter.motivo_rechazo_solicitudFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Relaciones_MASC.motivo_rechazo_solicitud LIKE '" + filter.motivo_rechazo_solicitud + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Relaciones_MASC.motivo_rechazo_solicitud LIKE '%" + filter.motivo_rechazo_solicitud + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Relaciones_MASC.motivo_rechazo_solicitud = '" + filter.motivo_rechazo_solicitud + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Relaciones_MASC.motivo_rechazo_solicitud LIKE '%" + filter.motivo_rechazo_solicitud + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Resolucion_proc) || !string.IsNullOrEmpty(filter.ToFecha_de_Resolucion_proc))
            {
                var Fecha_de_Resolucion_procFrom = DateTime.ParseExact(filter.FromFecha_de_Resolucion_proc, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_Resolucion_procTo = DateTime.ParseExact(filter.ToFecha_de_Resolucion_proc, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Resolucion_proc))
                    where += " AND Relaciones_MASC.Fecha_de_Resolucion_proc >= '" + Fecha_de_Resolucion_procFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Resolucion_proc))
                    where += " AND Relaciones_MASC.Fecha_de_Resolucion_proc <= '" + Fecha_de_Resolucion_procTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.Fromhora_resolucion_proc) || !string.IsNullOrEmpty(filter.Tohora_resolucion_proc))
            {
                if (!string.IsNullOrEmpty(filter.Fromhora_resolucion_proc))
                    where += " AND Convert(TIME,Relaciones_MASC.hora_resolucion_proc) >='" + filter.Fromhora_resolucion_proc + "'";
                if (!string.IsNullOrEmpty(filter.Tohora_resolucion_proc))
                    where += " AND Convert(TIME,Relaciones_MASC.hora_resolucion_proc) <='" + filter.Tohora_resolucion_proc + "'";
            }

            if (!string.IsNullOrEmpty(filter.Advanceusuario_resuelve_proc))
            {
                switch (filter.usuario_resuelve_procFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_User.Name LIKE '" + filter.Advanceusuario_resuelve_proc + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_User.Name LIKE '%" + filter.Advanceusuario_resuelve_proc + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_User.Name = '" + filter.Advanceusuario_resuelve_proc + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_User.Name LIKE '%" + filter.Advanceusuario_resuelve_proc + "%'";
                        break;
                }
            }
            else if (filter.Advanceusuario_resuelve_procMultiple != null && filter.Advanceusuario_resuelve_procMultiple.Count() > 0)
            {
                var usuario_resuelve_procIds = string.Join(",", filter.Advanceusuario_resuelve_procMultiple);

                where += " AND Relaciones_MASC.usuario_resuelve_proc In (" + usuario_resuelve_procIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceResolucion_proc))
            {
                switch (filter.Resolucion_procFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Resolucion_MASC.Descripcion LIKE '" + filter.AdvanceResolucion_proc + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Resolucion_MASC.Descripcion LIKE '%" + filter.AdvanceResolucion_proc + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Resolucion_MASC.Descripcion = '" + filter.AdvanceResolucion_proc + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Resolucion_MASC.Descripcion LIKE '%" + filter.AdvanceResolucion_proc + "%'";
                        break;
                }
            }
            else if (filter.AdvanceResolucion_procMultiple != null && filter.AdvanceResolucion_procMultiple.Count() > 0)
            {
                var Resolucion_procIds = string.Join(",", filter.AdvanceResolucion_procMultiple);

                where += " AND Relaciones_MASC.Resolucion_proc In (" + Resolucion_procIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Observaciones_proc))
            {
                switch (filter.Observaciones_procFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Relaciones_MASC.Observaciones_proc LIKE '" + filter.Observaciones_proc + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Relaciones_MASC.Observaciones_proc LIKE '%" + filter.Observaciones_proc + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Relaciones_MASC.Observaciones_proc = '" + filter.Observaciones_proc + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Relaciones_MASC.Observaciones_proc LIKE '%" + filter.Observaciones_proc + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Validacion_proc) || !string.IsNullOrEmpty(filter.ToFecha_de_Validacion_proc))
            {
                var Fecha_de_Validacion_procFrom = DateTime.ParseExact(filter.FromFecha_de_Validacion_proc, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_Validacion_procTo = DateTime.ParseExact(filter.ToFecha_de_Validacion_proc, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Validacion_proc))
                    where += " AND Relaciones_MASC.Fecha_de_Validacion_proc >= '" + Fecha_de_Validacion_procFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Validacion_proc))
                    where += " AND Relaciones_MASC.Fecha_de_Validacion_proc <= '" + Fecha_de_Validacion_procTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Validacion_proc) || !string.IsNullOrEmpty(filter.ToHora_de_Validacion_proc))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Validacion_proc))
                    where += " AND Convert(TIME,Relaciones_MASC.Hora_de_Validacion_proc) >='" + filter.FromHora_de_Validacion_proc + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Validacion_proc))
                    where += " AND Convert(TIME,Relaciones_MASC.Hora_de_Validacion_proc) <='" + filter.ToHora_de_Validacion_proc + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceUsuario_que_Valida_proc))
            {
                switch (filter.Usuario_que_Valida_procFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_User.Name LIKE '" + filter.AdvanceUsuario_que_Valida_proc + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceUsuario_que_Valida_proc + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_User.Name = '" + filter.AdvanceUsuario_que_Valida_proc + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceUsuario_que_Valida_proc + "%'";
                        break;
                }
            }
            else if (filter.AdvanceUsuario_que_Valida_procMultiple != null && filter.AdvanceUsuario_que_Valida_procMultiple.Count() > 0)
            {
                var Usuario_que_Valida_procIds = string.Join(",", filter.AdvanceUsuario_que_Valida_procMultiple);

                where += " AND Relaciones_MASC.Usuario_que_Valida_proc In (" + Usuario_que_Valida_procIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceResultado_proc))
            {
                switch (filter.Resultado_procFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Resultado_de_Revision.Descripcion LIKE '" + filter.AdvanceResultado_proc + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Resultado_de_Revision.Descripcion LIKE '%" + filter.AdvanceResultado_proc + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Resultado_de_Revision.Descripcion = '" + filter.AdvanceResultado_proc + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Resultado_de_Revision.Descripcion LIKE '%" + filter.AdvanceResultado_proc + "%'";
                        break;
                }
            }
            else if (filter.AdvanceResultado_procMultiple != null && filter.AdvanceResultado_procMultiple.Count() > 0)
            {
                var Resultado_procIds = string.Join(",", filter.AdvanceResultado_procMultiple);

                where += " AND Relaciones_MASC.Resultado_proc In (" + Resultado_procIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Motivo_de_Rechazo_proc))
            {
                switch (filter.Motivo_de_Rechazo_procFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Relaciones_MASC.Motivo_de_Rechazo_proc LIKE '" + filter.Motivo_de_Rechazo_proc + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Relaciones_MASC.Motivo_de_Rechazo_proc LIKE '%" + filter.Motivo_de_Rechazo_proc + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Relaciones_MASC.Motivo_de_Rechazo_proc = '" + filter.Motivo_de_Rechazo_proc + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Relaciones_MASC.Motivo_de_Rechazo_proc LIKE '%" + filter.Motivo_de_Rechazo_proc + "%'";
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

        public ActionResult GetDetalle_Relaciones_MASC(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_Relaciones_MASCGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Relaciones_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_Relaciones_MASC.Relaciones=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_Relaciones_MASC.Relaciones='" + RelationId + "'";
            }
            var result = _IDetalle_Relaciones_MASCApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_Relaciones_MASCs == null)
                result.Detalle_Relaciones_MASCs = new List<Detalle_Relaciones_MASC>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_Relaciones_MASCs.Select(m => new Detalle_Relaciones_MASCGridModel
                {
                    Clave = m.Clave

                        ,Requerido = m.Requerido
                        ,RequeridoNombre_Completo_Detenido = CultureHelper.GetTraduction(m.Requerido_Detalle_de_Imputado.Clave.ToString(), "Nombre_Completo_Detenido") ??(string)m.Requerido_Detalle_de_Imputado.Nombre_Completo_Detenido
                        ,Delito = m.Delito
                        ,DelitoDescripcion = CultureHelper.GetTraduction(m.Delito_Delito.Clave.ToString(), "Descripcion") ??(string)m.Delito_Delito.Descripcion
                        ,Solicitante = m.Solicitante
                        ,SolicitanteNombre_Completo = CultureHelper.GetTraduction(m.Solicitante_Detalle_de_Datos_Generales.Clave.ToString(), "Nombre_Completo") ??(string)m.Solicitante_Detalle_de_Datos_Generales.Nombre_Completo

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_Relaciones_MASCGridModel> GetDetalle_Relaciones_MASCData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_Relaciones_MASCGridModel> resultData = new List<Detalle_Relaciones_MASCGridModel>();
            string where = "Detalle_Relaciones_MASC.Relaciones=" + Id;
            if("int" == "string")
            {
                where = "Detalle_Relaciones_MASC.Relaciones='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Relaciones_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_Relaciones_MASCApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_Relaciones_MASCs != null)
            {
                resultData = result.Detalle_Relaciones_MASCs.Select(m => new Detalle_Relaciones_MASCGridModel
                    {
                        Clave = m.Clave

                        ,Requerido = m.Requerido
                        ,RequeridoNombre_Completo_Detenido = CultureHelper.GetTraduction(m.Requerido_Detalle_de_Imputado.Clave.ToString(), "Nombre_Completo_Detenido") ??(string)m.Requerido_Detalle_de_Imputado.Nombre_Completo_Detenido
                        ,Delito = m.Delito
                        ,DelitoDescripcion = CultureHelper.GetTraduction(m.Delito_Delito.Clave.ToString(), "Descripcion") ??(string)m.Delito_Delito.Descripcion
                        ,Solicitante = m.Solicitante
                        ,SolicitanteNombre_Completo = CultureHelper.GetTraduction(m.Solicitante_Detalle_de_Datos_Generales.Clave.ToString(), "Nombre_Completo") ??(string)m.Solicitante_Detalle_de_Datos_Generales.Nombre_Completo


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
                _IRelaciones_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

                Relaciones_MASC varRelaciones_MASC = null;
                if (id.ToString() != "0")
                {
                        string where = "";
                    _IDetalle_Relaciones_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_Relaciones_MASC.Relaciones=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_Relaciones_MASC.Relaciones='" + id + "'";
                    }
                    var Detalle_Relaciones_MASCInfo =
                        _IDetalle_Relaciones_MASCApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_Relaciones_MASCInfo.Detalle_Relaciones_MASCs.Count > 0)
                    {
                        var resultDetalle_Relaciones_MASC = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_Relaciones_MASCItem in Detalle_Relaciones_MASCInfo.Detalle_Relaciones_MASCs)
                            resultDetalle_Relaciones_MASC = resultDetalle_Relaciones_MASC
                                              && _IDetalle_Relaciones_MASCApiConsumer.Delete(Detalle_Relaciones_MASCItem.Clave, null,null).Resource;

                        if (!resultDetalle_Relaciones_MASC)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }

                }
                var result = _IRelaciones_MASCApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Relaciones_MASCModel varRelaciones_MASC)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IRelaciones_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Relaciones_MASCInfo = new Relaciones_MASC
                    {
                        Clave = varRelaciones_MASC.Clave
                        ,Estatus = varRelaciones_MASC.Estatus
                        ,Numero_de_Expediente = varRelaciones_MASC.Numero_de_Expediente
                        ,Numero_de_Procedimiento = varRelaciones_MASC.Numero_de_Procedimiento
                        ,idRelacionOrigen = varRelaciones_MASC.idRelacionOrigen
                        ,Requiere_cambiar_la_relacion = varRelaciones_MASC.Requiere_cambiar_la_relacion
                        ,Motivo_de_Cambio = varRelaciones_MASC.Motivo_de_Cambio
                        ,Observaciones = varRelaciones_MASC.Observaciones
                        ,Descripcion = varRelaciones_MASC.Descripcion
                        ,Fecha_de_Resolucion_solicitud = (!String.IsNullOrEmpty(varRelaciones_MASC.Fecha_de_Resolucion_solicitud)) ? DateTime.ParseExact(varRelaciones_MASC.Fecha_de_Resolucion_solicitud, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Resolucion_solicitud = varRelaciones_MASC.Hora_de_Resolucion_solicitud
                        ,Usuario_que_Resuelve_solicitud = varRelaciones_MASC.Usuario_que_Resuelve_solicitud
                        ,Resolucion = varRelaciones_MASC.Resolucion
                        ,Tipo_de_Mecanismo = varRelaciones_MASC.Tipo_de_Mecanismo
                        ,Observaciones_solicitud = varRelaciones_MASC.Observaciones_solicitud
                        ,Fecha_de_Validacion_solicitud = (!String.IsNullOrEmpty(varRelaciones_MASC.Fecha_de_Validacion_solicitud)) ? DateTime.ParseExact(varRelaciones_MASC.Fecha_de_Validacion_solicitud, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Validacion_solicitud = varRelaciones_MASC.Hora_de_Validacion_solicitud
                        ,Usuario_que_Valida_solicitud = varRelaciones_MASC.Usuario_que_Valida_solicitud
                        ,resultado_solicitud = varRelaciones_MASC.resultado_solicitud
                        ,motivo_rechazo_solicitud = varRelaciones_MASC.motivo_rechazo_solicitud
                        ,Fecha_de_Resolucion_proc = (!String.IsNullOrEmpty(varRelaciones_MASC.Fecha_de_Resolucion_proc)) ? DateTime.ParseExact(varRelaciones_MASC.Fecha_de_Resolucion_proc, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,hora_resolucion_proc = varRelaciones_MASC.hora_resolucion_proc
                        ,usuario_resuelve_proc = varRelaciones_MASC.usuario_resuelve_proc
                        ,Resolucion_proc = varRelaciones_MASC.Resolucion_proc
                        ,Observaciones_proc = varRelaciones_MASC.Observaciones_proc
                        ,Fecha_de_Validacion_proc = (!String.IsNullOrEmpty(varRelaciones_MASC.Fecha_de_Validacion_proc)) ? DateTime.ParseExact(varRelaciones_MASC.Fecha_de_Validacion_proc, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Validacion_proc = varRelaciones_MASC.Hora_de_Validacion_proc
                        ,Usuario_que_Valida_proc = varRelaciones_MASC.Usuario_que_Valida_proc
                        ,Resultado_proc = varRelaciones_MASC.Resultado_proc
                        ,Motivo_de_Rechazo_proc = varRelaciones_MASC.Motivo_de_Rechazo_proc

                    };

                    result = !IsNew ?
                        _IRelaciones_MASCApiConsumer.Update(Relaciones_MASCInfo, null, null).Resource.ToString() :
                         _IRelaciones_MASCApiConsumer.Insert(Relaciones_MASCInfo, null, null).Resource.ToString();
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
        public bool CopyDetalle_Relaciones_MASC(int MasterId, int referenceId, List<Detalle_Relaciones_MASCGridModelPost> Detalle_Relaciones_MASCItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_Relaciones_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_Relaciones_MASCData = _IDetalle_Relaciones_MASCApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_Relaciones_MASC.Relaciones=" + referenceId,"").Resource;
                if (Detalle_Relaciones_MASCData == null || Detalle_Relaciones_MASCData.Detalle_Relaciones_MASCs.Count == 0)
                    return true;

                var result = true;

                Detalle_Relaciones_MASCGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_Relaciones_MASC in Detalle_Relaciones_MASCData.Detalle_Relaciones_MASCs)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_Relaciones_MASC Detalle_Relaciones_MASC1 = varDetalle_Relaciones_MASC;

                    if (Detalle_Relaciones_MASCItems != null && Detalle_Relaciones_MASCItems.Any(m => m.Clave == Detalle_Relaciones_MASC1.Clave))
                    {
                        modelDataToChange = Detalle_Relaciones_MASCItems.FirstOrDefault(m => m.Clave == Detalle_Relaciones_MASC1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_Relaciones_MASC.Relaciones = MasterId;
                    var insertId = _IDetalle_Relaciones_MASCApiConsumer.Insert(varDetalle_Relaciones_MASC,null,null).Resource;
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
        public ActionResult PostDetalle_Relaciones_MASC(List<Detalle_Relaciones_MASCGridModelPost> Detalle_Relaciones_MASCItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_Relaciones_MASC(MasterId, referenceId, Detalle_Relaciones_MASCItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_Relaciones_MASCItems != null && Detalle_Relaciones_MASCItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_Relaciones_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_Relaciones_MASCItem in Detalle_Relaciones_MASCItems)
                    {





                        //Removal Request
                        if (Detalle_Relaciones_MASCItem.Removed)
                        {
                            result = result && _IDetalle_Relaciones_MASCApiConsumer.Delete(Detalle_Relaciones_MASCItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_Relaciones_MASCItem.Clave = 0;

                        var Detalle_Relaciones_MASCData = new Detalle_Relaciones_MASC
                        {
                            Relaciones = MasterId
                            ,Clave = Detalle_Relaciones_MASCItem.Clave
                            ,Requerido = (Convert.ToInt32(Detalle_Relaciones_MASCItem.Requerido) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_Relaciones_MASCItem.Requerido))
                            ,Delito = (Convert.ToInt32(Detalle_Relaciones_MASCItem.Delito) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_Relaciones_MASCItem.Delito))
                            ,Solicitante = (Convert.ToInt32(Detalle_Relaciones_MASCItem.Solicitante) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_Relaciones_MASCItem.Solicitante))

                        };

                        var resultId = Detalle_Relaciones_MASCItem.Clave > 0
                           ? _IDetalle_Relaciones_MASCApiConsumer.Update(Detalle_Relaciones_MASCData,null,null).Resource
                           : _IDetalle_Relaciones_MASCApiConsumer.Insert(Detalle_Relaciones_MASCData,null,null).Resource;

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
        public ActionResult GetDetalle_Relaciones_MASC_Detalle_de_ImputadoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_ImputadoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_ImputadoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
                    item.Nombre_Completo_Detenido= CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Detalle_de_Imputado", "Nombre_Completo_Detenido");
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_Relaciones_MASC_DelitoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDelitoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
                    item.Descripcion= CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Delito", "Descripcion");
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_Relaciones_MASC_Detalle_de_Datos_GeneralesAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Datos_GeneralesApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_Datos_GeneralesApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
                    item.Nombre_Completo= CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Detalle_de_Datos_Generales", "Nombre_Completo");
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }



        /// <summary>
        /// Write Element Array of Relaciones_MASC script
        /// </summary>
        /// <param name="oRelaciones_MASCElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Relaciones_MASCModuleAttributeList)
        {
            for (int i = 0; i < Relaciones_MASCModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Relaciones_MASCModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Relaciones_MASCModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Relaciones_MASCModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Relaciones_MASCModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Relaciones_MASCModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Relaciones_MASCModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Relaciones_MASCModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Relaciones_MASCModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Relaciones_MASCModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Relaciones_MASCModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Relaciones_MASCModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strRelaciones_MASCScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Relaciones_MASC.js")))
            {
                strRelaciones_MASCScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Relaciones_MASC element attributes
            string userChangeJson = jsSerialize.Serialize(Relaciones_MASCModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strRelaciones_MASCScript.IndexOf("inpuElementArray");
            string splittedString = strRelaciones_MASCScript.Substring(indexOfArray, strRelaciones_MASCScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Relaciones_MASCModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Relaciones_MASCModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strRelaciones_MASCScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strRelaciones_MASCScript.Substring(indexOfArrayHistory, strRelaciones_MASCScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strRelaciones_MASCScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strRelaciones_MASCScript.Substring(endIndexOfMainElement + indexOfArray, strRelaciones_MASCScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Relaciones_MASCModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Relaciones_MASCModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Relaciones_MASC.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Relaciones_MASC.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Relaciones_MASC.js")))
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
        public ActionResult Relaciones_MASCPropertyBag()
        {
            return PartialView("Relaciones_MASCPropertyBag", "Relaciones_MASC");
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
        public ActionResult AddDetalle_Relaciones_MASC(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_Relaciones_MASC/AddDetalle_Relaciones_MASC");
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
                var whereClauseFormat = "Object = 45702 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IRelaciones_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Relaciones_MASC.Clave= " + RecordId;
                            var result = _IRelaciones_MASCApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IRelaciones_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Relaciones_MASCPropertyMapper());
			
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
                    (Relaciones_MASCAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Relaciones_MASCPropertyMapper oRelaciones_MASCPropertyMapper = new Relaciones_MASCPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oRelaciones_MASCPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IRelaciones_MASCApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Relaciones_MASCs == null)
                result.Relaciones_MASCs = new List<Relaciones_MASC>();

            var data = result.Relaciones_MASCs.Select(m => new Relaciones_MASCGridModel
            {
                Clave = m.Clave
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_Solicitud.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_Solicitud.Descripcion
                        ,Numero_de_ExpedienteNumero_de_Expediente = CultureHelper.GetTraduction(m.Numero_de_Expediente_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Numero_de_Expediente_Solicitud.Numero_de_Expediente
			,Numero_de_Procedimiento = m.Numero_de_Procedimiento
                        ,idRelacionOrigenDescripcion = CultureHelper.GetTraduction(m.idRelacionOrigen_Detalle_de_Relaciones.Clave.ToString(), "Descripcion") ?? (string)m.idRelacionOrigen_Detalle_de_Relaciones.Descripcion
			,Requiere_cambiar_la_relacion = m.Requiere_cambiar_la_relacion
			,Motivo_de_Cambio = m.Motivo_de_Cambio
			,Observaciones = m.Observaciones
			,Descripcion = m.Descripcion
                        ,Fecha_de_Resolucion_solicitud = (m.Fecha_de_Resolucion_solicitud == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Resolucion_solicitud).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Resolucion_solicitud = m.Hora_de_Resolucion_solicitud
                        ,Usuario_que_Resuelve_solicitudName = CultureHelper.GetTraduction(m.Usuario_que_Resuelve_solicitud_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Resuelve_solicitud_Spartan_User.Name
                        ,ResolucionDescripcion = CultureHelper.GetTraduction(m.Resolucion_Resolucion_MASC.Clave.ToString(), "Descripcion") ?? (string)m.Resolucion_Resolucion_MASC.Descripcion
                        ,Tipo_de_MecanismoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Mecanismo_Tipo_de_Mecanismo_Alterno.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Mecanismo_Tipo_de_Mecanismo_Alterno.Descripcion
			,Observaciones_solicitud = m.Observaciones_solicitud
                        ,Fecha_de_Validacion_solicitud = (m.Fecha_de_Validacion_solicitud == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Validacion_solicitud).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Validacion_solicitud = m.Hora_de_Validacion_solicitud
                        ,Usuario_que_Valida_solicitudName = CultureHelper.GetTraduction(m.Usuario_que_Valida_solicitud_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Valida_solicitud_Spartan_User.Name
                        ,resultado_solicitudDescripcion = CultureHelper.GetTraduction(m.resultado_solicitud_Resultado_de_Revision.Clave.ToString(), "Descripcion") ?? (string)m.resultado_solicitud_Resultado_de_Revision.Descripcion
			,motivo_rechazo_solicitud = m.motivo_rechazo_solicitud
                        ,Fecha_de_Resolucion_proc = (m.Fecha_de_Resolucion_proc == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Resolucion_proc).ToString(ConfigurationProperty.DateFormat))
			,hora_resolucion_proc = m.hora_resolucion_proc
                        ,usuario_resuelve_procName = CultureHelper.GetTraduction(m.usuario_resuelve_proc_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.usuario_resuelve_proc_Spartan_User.Name
                        ,Resolucion_procDescripcion = CultureHelper.GetTraduction(m.Resolucion_proc_Resolucion_MASC.Clave.ToString(), "Descripcion") ?? (string)m.Resolucion_proc_Resolucion_MASC.Descripcion
			,Observaciones_proc = m.Observaciones_proc
                        ,Fecha_de_Validacion_proc = (m.Fecha_de_Validacion_proc == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Validacion_proc).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Validacion_proc = m.Hora_de_Validacion_proc
                        ,Usuario_que_Valida_procName = CultureHelper.GetTraduction(m.Usuario_que_Valida_proc_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Valida_proc_Spartan_User.Name
                        ,Resultado_procDescripcion = CultureHelper.GetTraduction(m.Resultado_proc_Resultado_de_Revision.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_proc_Resultado_de_Revision.Descripcion
			,Motivo_de_Rechazo_proc = m.Motivo_de_Rechazo_proc

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45702, arrayColumnsVisible), "Relaciones_MASCList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45702, arrayColumnsVisible), "Relaciones_MASCList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45702, arrayColumnsVisible), "Relaciones_MASCList_" + DateTime.Now.ToString());
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

            _IRelaciones_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Relaciones_MASCPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Relaciones_MASCAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Relaciones_MASCPropertyMapper oRelaciones_MASCPropertyMapper = new Relaciones_MASCPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oRelaciones_MASCPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IRelaciones_MASCApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Relaciones_MASCs == null)
                result.Relaciones_MASCs = new List<Relaciones_MASC>();

            var data = result.Relaciones_MASCs.Select(m => new Relaciones_MASCGridModel
            {
                Clave = m.Clave
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_Solicitud.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_Solicitud.Descripcion
                        ,Numero_de_ExpedienteNumero_de_Expediente = CultureHelper.GetTraduction(m.Numero_de_Expediente_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Numero_de_Expediente_Solicitud.Numero_de_Expediente
			,Numero_de_Procedimiento = m.Numero_de_Procedimiento
                        ,idRelacionOrigenDescripcion = CultureHelper.GetTraduction(m.idRelacionOrigen_Detalle_de_Relaciones.Clave.ToString(), "Descripcion") ?? (string)m.idRelacionOrigen_Detalle_de_Relaciones.Descripcion
			,Requiere_cambiar_la_relacion = m.Requiere_cambiar_la_relacion
			,Motivo_de_Cambio = m.Motivo_de_Cambio
			,Observaciones = m.Observaciones
			,Descripcion = m.Descripcion
                        ,Fecha_de_Resolucion_solicitud = (m.Fecha_de_Resolucion_solicitud == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Resolucion_solicitud).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Resolucion_solicitud = m.Hora_de_Resolucion_solicitud
                        ,Usuario_que_Resuelve_solicitudName = CultureHelper.GetTraduction(m.Usuario_que_Resuelve_solicitud_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Resuelve_solicitud_Spartan_User.Name
                        ,ResolucionDescripcion = CultureHelper.GetTraduction(m.Resolucion_Resolucion_MASC.Clave.ToString(), "Descripcion") ?? (string)m.Resolucion_Resolucion_MASC.Descripcion
                        ,Tipo_de_MecanismoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Mecanismo_Tipo_de_Mecanismo_Alterno.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Mecanismo_Tipo_de_Mecanismo_Alterno.Descripcion
			,Observaciones_solicitud = m.Observaciones_solicitud
                        ,Fecha_de_Validacion_solicitud = (m.Fecha_de_Validacion_solicitud == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Validacion_solicitud).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Validacion_solicitud = m.Hora_de_Validacion_solicitud
                        ,Usuario_que_Valida_solicitudName = CultureHelper.GetTraduction(m.Usuario_que_Valida_solicitud_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Valida_solicitud_Spartan_User.Name
                        ,resultado_solicitudDescripcion = CultureHelper.GetTraduction(m.resultado_solicitud_Resultado_de_Revision.Clave.ToString(), "Descripcion") ?? (string)m.resultado_solicitud_Resultado_de_Revision.Descripcion
			,motivo_rechazo_solicitud = m.motivo_rechazo_solicitud
                        ,Fecha_de_Resolucion_proc = (m.Fecha_de_Resolucion_proc == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Resolucion_proc).ToString(ConfigurationProperty.DateFormat))
			,hora_resolucion_proc = m.hora_resolucion_proc
                        ,usuario_resuelve_procName = CultureHelper.GetTraduction(m.usuario_resuelve_proc_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.usuario_resuelve_proc_Spartan_User.Name
                        ,Resolucion_procDescripcion = CultureHelper.GetTraduction(m.Resolucion_proc_Resolucion_MASC.Clave.ToString(), "Descripcion") ?? (string)m.Resolucion_proc_Resolucion_MASC.Descripcion
			,Observaciones_proc = m.Observaciones_proc
                        ,Fecha_de_Validacion_proc = (m.Fecha_de_Validacion_proc == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Validacion_proc).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Validacion_proc = m.Hora_de_Validacion_proc
                        ,Usuario_que_Valida_procName = CultureHelper.GetTraduction(m.Usuario_que_Valida_proc_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Valida_proc_Spartan_User.Name
                        ,Resultado_procDescripcion = CultureHelper.GetTraduction(m.Resultado_proc_Resultado_de_Revision.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_proc_Resultado_de_Revision.Descripcion
			,Motivo_de_Rechazo_proc = m.Motivo_de_Rechazo_proc

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
                _IRelaciones_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IRelaciones_MASCApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Relaciones_MASC_Datos_GeneralesModel varRelaciones_MASC)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRelaciones_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Relaciones_MASC_Datos_GeneralesInfo = new Relaciones_MASC_Datos_Generales
                {
                    Clave = varRelaciones_MASC.Clave
                                            ,Estatus = varRelaciones_MASC.Estatus
                        ,Numero_de_Expediente = varRelaciones_MASC.Numero_de_Expediente
                        ,Numero_de_Procedimiento = varRelaciones_MASC.Numero_de_Procedimiento
                        ,idRelacionOrigen = varRelaciones_MASC.idRelacionOrigen
                        ,Requiere_cambiar_la_relacion = varRelaciones_MASC.Requiere_cambiar_la_relacion
                        ,Motivo_de_Cambio = varRelaciones_MASC.Motivo_de_Cambio
                        ,Observaciones = varRelaciones_MASC.Observaciones
                        ,Descripcion = varRelaciones_MASC.Descripcion
                    
                };

                result = _IRelaciones_MASCApiConsumer.Update_Datos_Generales(Relaciones_MASC_Datos_GeneralesInfo).Resource.ToString();
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
                _IRelaciones_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IRelaciones_MASCApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_Relaciones_MASC;
                var Detalle_Relaciones_MASCData = GetDetalle_Relaciones_MASCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Relaciones_MASC);

                var result = new Relaciones_MASC_Datos_GeneralesModel
                {
                    Clave = m.Clave
                        ,Estatus = m.Estatus
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_Solicitud.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_Solicitud.Descripcion
                        ,Numero_de_Expediente = m.Numero_de_Expediente
                        ,Numero_de_ExpedienteNumero_de_Expediente = CultureHelper.GetTraduction(m.Numero_de_Expediente_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Numero_de_Expediente_Solicitud.Numero_de_Expediente
			,Numero_de_Procedimiento = m.Numero_de_Procedimiento
                        ,idRelacionOrigen = m.idRelacionOrigen
                        ,idRelacionOrigenDescripcion = CultureHelper.GetTraduction(m.idRelacionOrigen_Detalle_de_Relaciones.Clave.ToString(), "Descripcion") ?? (string)m.idRelacionOrigen_Detalle_de_Relaciones.Descripcion
			,Requiere_cambiar_la_relacion = m.Requiere_cambiar_la_relacion
			,Motivo_de_Cambio = m.Motivo_de_Cambio
			,Observaciones = m.Observaciones
			,Descripcion = m.Descripcion

                    
                };
				var resultData = new
                {
                    data = result
                    ,Relacion = Detalle_Relaciones_MASCData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Resolucion_de_Solicitud(Relaciones_MASC_Resolucion_de_SolicitudModel varRelaciones_MASC)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRelaciones_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Relaciones_MASC_Resolucion_de_SolicitudInfo = new Relaciones_MASC_Resolucion_de_Solicitud
                {
                    Clave = varRelaciones_MASC.Clave
                                            ,Fecha_de_Resolucion_solicitud = (!String.IsNullOrEmpty(varRelaciones_MASC.Fecha_de_Resolucion_solicitud)) ? DateTime.ParseExact(varRelaciones_MASC.Fecha_de_Resolucion_solicitud, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Resolucion_solicitud = varRelaciones_MASC.Hora_de_Resolucion_solicitud
                        ,Usuario_que_Resuelve_solicitud = varRelaciones_MASC.Usuario_que_Resuelve_solicitud
                        ,Resolucion = varRelaciones_MASC.Resolucion
                        ,Tipo_de_Mecanismo = varRelaciones_MASC.Tipo_de_Mecanismo
                        ,Observaciones_solicitud = varRelaciones_MASC.Observaciones_solicitud
                        ,Fecha_de_Validacion_solicitud = (!String.IsNullOrEmpty(varRelaciones_MASC.Fecha_de_Validacion_solicitud)) ? DateTime.ParseExact(varRelaciones_MASC.Fecha_de_Validacion_solicitud, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Validacion_solicitud = varRelaciones_MASC.Hora_de_Validacion_solicitud
                        ,Usuario_que_Valida_solicitud = varRelaciones_MASC.Usuario_que_Valida_solicitud
                        ,resultado_solicitud = varRelaciones_MASC.resultado_solicitud
                        ,motivo_rechazo_solicitud = varRelaciones_MASC.motivo_rechazo_solicitud
                    
                };

                result = _IRelaciones_MASCApiConsumer.Update_Resolucion_de_Solicitud(Relaciones_MASC_Resolucion_de_SolicitudInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Resolucion_de_Solicitud(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRelaciones_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IRelaciones_MASCApiConsumer.Get_Resolucion_de_Solicitud(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_Relaciones_MASC;
                var Detalle_Relaciones_MASCData = GetDetalle_Relaciones_MASCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Relaciones_MASC);

                var result = new Relaciones_MASC_Resolucion_de_SolicitudModel
                {
                    Clave = m.Clave
                        ,Fecha_de_Resolucion_solicitud = (m.Fecha_de_Resolucion_solicitud == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Resolucion_solicitud).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Resolucion_solicitud = m.Hora_de_Resolucion_solicitud
                        ,Usuario_que_Resuelve_solicitud = m.Usuario_que_Resuelve_solicitud
                        ,Usuario_que_Resuelve_solicitudName = CultureHelper.GetTraduction(m.Usuario_que_Resuelve_solicitud_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Resuelve_solicitud_Spartan_User.Name
                        ,Resolucion = m.Resolucion
                        ,ResolucionDescripcion = CultureHelper.GetTraduction(m.Resolucion_Resolucion_MASC.Clave.ToString(), "Descripcion") ?? (string)m.Resolucion_Resolucion_MASC.Descripcion
                        ,Tipo_de_Mecanismo = m.Tipo_de_Mecanismo
                        ,Tipo_de_MecanismoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Mecanismo_Tipo_de_Mecanismo_Alterno.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Mecanismo_Tipo_de_Mecanismo_Alterno.Descripcion
			,Observaciones_solicitud = m.Observaciones_solicitud
                        ,Fecha_de_Validacion_solicitud = (m.Fecha_de_Validacion_solicitud == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Validacion_solicitud).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Validacion_solicitud = m.Hora_de_Validacion_solicitud
                        ,Usuario_que_Valida_solicitud = m.Usuario_que_Valida_solicitud
                        ,Usuario_que_Valida_solicitudName = CultureHelper.GetTraduction(m.Usuario_que_Valida_solicitud_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Valida_solicitud_Spartan_User.Name
                        ,resultado_solicitud = m.resultado_solicitud
                        ,resultado_solicitudDescripcion = CultureHelper.GetTraduction(m.resultado_solicitud_Resultado_de_Revision.Clave.ToString(), "Descripcion") ?? (string)m.resultado_solicitud_Resultado_de_Revision.Descripcion
			,motivo_rechazo_solicitud = m.motivo_rechazo_solicitud

                    
                };
				var resultData = new
                {
                    data = result
                    ,Relacion = Detalle_Relaciones_MASCData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Resolucion_de_Procedimiento(Relaciones_MASC_Resolucion_de_ProcedimientoModel varRelaciones_MASC)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRelaciones_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Relaciones_MASC_Resolucion_de_ProcedimientoInfo = new Relaciones_MASC_Resolucion_de_Procedimiento
                {
                    Clave = varRelaciones_MASC.Clave
                                            ,Fecha_de_Resolucion_proc = (!String.IsNullOrEmpty(varRelaciones_MASC.Fecha_de_Resolucion_proc)) ? DateTime.ParseExact(varRelaciones_MASC.Fecha_de_Resolucion_proc, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,hora_resolucion_proc = varRelaciones_MASC.hora_resolucion_proc
                        ,usuario_resuelve_proc = varRelaciones_MASC.usuario_resuelve_proc
                        ,Resolucion_proc = varRelaciones_MASC.Resolucion_proc
                        ,Observaciones_proc = varRelaciones_MASC.Observaciones_proc
                        ,Fecha_de_Validacion_proc = (!String.IsNullOrEmpty(varRelaciones_MASC.Fecha_de_Validacion_proc)) ? DateTime.ParseExact(varRelaciones_MASC.Fecha_de_Validacion_proc, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Validacion_proc = varRelaciones_MASC.Hora_de_Validacion_proc
                        ,Usuario_que_Valida_proc = varRelaciones_MASC.Usuario_que_Valida_proc
                        ,Resultado_proc = varRelaciones_MASC.Resultado_proc
                        ,Motivo_de_Rechazo_proc = varRelaciones_MASC.Motivo_de_Rechazo_proc
                    
                };

                result = _IRelaciones_MASCApiConsumer.Update_Resolucion_de_Procedimiento(Relaciones_MASC_Resolucion_de_ProcedimientoInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Resolucion_de_Procedimiento(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRelaciones_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IRelaciones_MASCApiConsumer.Get_Resolucion_de_Procedimiento(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_Relaciones_MASC;
                var Detalle_Relaciones_MASCData = GetDetalle_Relaciones_MASCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Relaciones_MASC);

                var result = new Relaciones_MASC_Resolucion_de_ProcedimientoModel
                {
                    Clave = m.Clave
                        ,Fecha_de_Resolucion_proc = (m.Fecha_de_Resolucion_proc == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Resolucion_proc).ToString(ConfigurationProperty.DateFormat))
			,hora_resolucion_proc = m.hora_resolucion_proc
                        ,usuario_resuelve_proc = m.usuario_resuelve_proc
                        ,usuario_resuelve_procName = CultureHelper.GetTraduction(m.usuario_resuelve_proc_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.usuario_resuelve_proc_Spartan_User.Name
                        ,Resolucion_proc = m.Resolucion_proc
                        ,Resolucion_procDescripcion = CultureHelper.GetTraduction(m.Resolucion_proc_Resolucion_MASC.Clave.ToString(), "Descripcion") ?? (string)m.Resolucion_proc_Resolucion_MASC.Descripcion
			,Observaciones_proc = m.Observaciones_proc
                        ,Fecha_de_Validacion_proc = (m.Fecha_de_Validacion_proc == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Validacion_proc).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Validacion_proc = m.Hora_de_Validacion_proc
                        ,Usuario_que_Valida_proc = m.Usuario_que_Valida_proc
                        ,Usuario_que_Valida_procName = CultureHelper.GetTraduction(m.Usuario_que_Valida_proc_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Valida_proc_Spartan_User.Name
                        ,Resultado_proc = m.Resultado_proc
                        ,Resultado_procDescripcion = CultureHelper.GetTraduction(m.Resultado_proc_Resultado_de_Revision.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_proc_Resultado_de_Revision.Descripcion
			,Motivo_de_Rechazo_proc = m.Motivo_de_Rechazo_proc

                    
                };
				var resultData = new
                {
                    data = result
                    ,Relacion = Detalle_Relaciones_MASCData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }


    }
}

