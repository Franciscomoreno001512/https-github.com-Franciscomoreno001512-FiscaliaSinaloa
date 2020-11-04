using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_de_Reuniones_de_Mediacion;
using Spartane.Core.Domain.Solicitud;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Tipo_de_Mecanismo_Alterno;
using Spartane.Core.Domain.Tipo_de_Sesion;
using Spartane.Core.Domain.Detalle_de_Solicitante_en_Reuniones;

using Spartane.Core.Domain.Detalle_de_Solicitud_Solicitante;

using Spartane.Core.Domain.Detalle_de_Requerido_en_Reuniones;

using Spartane.Core.Domain.Detalle_de_Solicitud_Requerido;


using Spartane.Core.Domain.Cumplimiento;
using Spartane.Core.Domain.Spartan_User;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_de_Reuniones_de_Mediacion;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Reuniones_de_Mediacion;
using Spartane.Web.Areas.WebApiConsumer.Solicitud;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Mecanismo_Alterno;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Sesion;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Solicitante_en_Reuniones;

using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Solicitud_Solicitante;

using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Requerido_en_Reuniones;

using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Solicitud_Requerido;


using Spartane.Web.Areas.WebApiConsumer.Cumplimiento;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;

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
    public class Detalle_de_Reuniones_de_MediacionController : Controller
    {
        #region "variable declaration"

        private IDetalle_de_Reuniones_de_MediacionService service = null;
        private IDetalle_de_Reuniones_de_MediacionApiConsumer _IDetalle_de_Reuniones_de_MediacionApiConsumer;
        private ISolicitudApiConsumer _ISolicitudApiConsumer;
        private ISpartan_UserApiConsumer _ISpartan_UserApiConsumer;
        private ITipo_de_Mecanismo_AlternoApiConsumer _ITipo_de_Mecanismo_AlternoApiConsumer;
        private ITipo_de_SesionApiConsumer _ITipo_de_SesionApiConsumer;
        private IDetalle_de_Solicitante_en_ReunionesApiConsumer _IDetalle_de_Solicitante_en_ReunionesApiConsumer;

        private IDetalle_de_Solicitud_SolicitanteApiConsumer _IDetalle_de_Solicitud_SolicitanteApiConsumer;

        private IDetalle_de_Requerido_en_ReunionesApiConsumer _IDetalle_de_Requerido_en_ReunionesApiConsumer;

        private IDetalle_de_Solicitud_RequeridoApiConsumer _IDetalle_de_Solicitud_RequeridoApiConsumer;


        private ICumplimientoApiConsumer _ICumplimientoApiConsumer;

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

        
        public Detalle_de_Reuniones_de_MediacionController(IDetalle_de_Reuniones_de_MediacionService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_de_Reuniones_de_MediacionApiConsumer Detalle_de_Reuniones_de_MediacionApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , ISolicitudApiConsumer SolicitudApiConsumer , ISpartan_UserApiConsumer Spartan_UserApiConsumer , ITipo_de_Mecanismo_AlternoApiConsumer Tipo_de_Mecanismo_AlternoApiConsumer , ITipo_de_SesionApiConsumer Tipo_de_SesionApiConsumer , IDetalle_de_Solicitante_en_ReunionesApiConsumer Detalle_de_Solicitante_en_ReunionesApiConsumer , IDetalle_de_Solicitud_SolicitanteApiConsumer Detalle_de_Solicitud_SolicitanteApiConsumer  , IDetalle_de_Requerido_en_ReunionesApiConsumer Detalle_de_Requerido_en_ReunionesApiConsumer , IDetalle_de_Solicitud_RequeridoApiConsumer Detalle_de_Solicitud_RequeridoApiConsumer  , ICumplimientoApiConsumer CumplimientoApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_de_Reuniones_de_MediacionApiConsumer = Detalle_de_Reuniones_de_MediacionApiConsumer;
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
            this._ITipo_de_Mecanismo_AlternoApiConsumer = Tipo_de_Mecanismo_AlternoApiConsumer;
            this._ITipo_de_SesionApiConsumer = Tipo_de_SesionApiConsumer;
            this._IDetalle_de_Solicitante_en_ReunionesApiConsumer = Detalle_de_Solicitante_en_ReunionesApiConsumer;

            this._IDetalle_de_Solicitud_SolicitanteApiConsumer = Detalle_de_Solicitud_SolicitanteApiConsumer;

            this._IDetalle_de_Requerido_en_ReunionesApiConsumer = Detalle_de_Requerido_en_ReunionesApiConsumer;

            this._IDetalle_de_Solicitud_RequeridoApiConsumer = Detalle_de_Solicitud_RequeridoApiConsumer;


            this._ICumplimientoApiConsumer = CumplimientoApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_de_Reuniones_de_Mediacion
        [ObjectAuth(ObjectId = (ModuleObjectId)45074, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45074, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Detalle_de_Reuniones_de_Mediacion/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45074, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45074, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varDetalle_de_Reuniones_de_Mediacion = new Detalle_de_Reuniones_de_MediacionModel();
			varDetalle_de_Reuniones_de_Mediacion.Clave = Id;
			
            ViewBag.ObjectId = "45074";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;

            var permissionDetalle_de_Solicitante_en_Reuniones = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45103, ModuleId);
            ViewBag.PermissionDetalle_de_Solicitante_en_Reuniones = permissionDetalle_de_Solicitante_en_Reuniones;
            var permissionDetalle_de_Requerido_en_Reuniones = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45102, ModuleId);
            ViewBag.PermissionDetalle_de_Requerido_en_Reuniones = permissionDetalle_de_Requerido_en_Reuniones;


            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IDetalle_de_Reuniones_de_MediacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_de_Reuniones_de_MediacionsData = _IDetalle_de_Reuniones_de_MediacionApiConsumer.ListaSelAll(0, 1000, "Detalle_de_Reuniones_de_Mediacion.Clave=" + Id, "").Resource.Detalle_de_Reuniones_de_Mediacions;
				
				if (Detalle_de_Reuniones_de_MediacionsData != null && Detalle_de_Reuniones_de_MediacionsData.Count > 0)
                {
					var Detalle_de_Reuniones_de_MediacionData = Detalle_de_Reuniones_de_MediacionsData.First();
					varDetalle_de_Reuniones_de_Mediacion= new Detalle_de_Reuniones_de_MediacionModel
					{
						Clave  = Detalle_de_Reuniones_de_MediacionData.Clave 
	                    ,Numero_de_Expediente = Detalle_de_Reuniones_de_MediacionData.Numero_de_Expediente
                    ,Numero_de_ExpedienteNumero_de_Folio = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Reuniones_de_MediacionData.Numero_de_Expediente), "Solicitud") ??  (string)Detalle_de_Reuniones_de_MediacionData.Numero_de_Expediente_Solicitud.Numero_de_Folio
                    ,Lugar = Detalle_de_Reuniones_de_MediacionData.Lugar
                    ,Fecha = (Detalle_de_Reuniones_de_MediacionData.Fecha == null ? string.Empty : Convert.ToDateTime(Detalle_de_Reuniones_de_MediacionData.Fecha).ToString(ConfigurationProperty.DateFormat))
                    ,Hora = Detalle_de_Reuniones_de_MediacionData.Hora
                    ,Especialista = Detalle_de_Reuniones_de_MediacionData.Especialista
                    ,EspecialistaName = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Reuniones_de_MediacionData.Especialista), "Spartan_User") ??  (string)Detalle_de_Reuniones_de_MediacionData.Especialista_Spartan_User.Name
                    ,Mecanismo_Alterno = Detalle_de_Reuniones_de_MediacionData.Mecanismo_Alterno
                    ,Mecanismo_AlternoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Reuniones_de_MediacionData.Mecanismo_Alterno), "Tipo_de_Mecanismo_Alterno") ??  (string)Detalle_de_Reuniones_de_MediacionData.Mecanismo_Alterno_Tipo_de_Mecanismo_Alterno.Descripcion
                    ,Tipo_de_Sesion = Detalle_de_Reuniones_de_MediacionData.Tipo_de_Sesion
                    ,Tipo_de_SesionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Reuniones_de_MediacionData.Tipo_de_Sesion), "Tipo_de_Sesion") ??  (string)Detalle_de_Reuniones_de_MediacionData.Tipo_de_Sesion_Tipo_de_Sesion.Descripcion
                    ,Cumplimiento = Detalle_de_Reuniones_de_MediacionData.Cumplimiento
                    ,CumplimientoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Reuniones_de_MediacionData.Cumplimiento), "Cumplimiento") ??  (string)Detalle_de_Reuniones_de_MediacionData.Cumplimiento_Cumplimiento.Descripcion
                    ,Fecha_de_Registro = (Detalle_de_Reuniones_de_MediacionData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(Detalle_de_Reuniones_de_MediacionData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,Archivo_adjunto = Detalle_de_Reuniones_de_MediacionData.Archivo_adjunto
                    ,Hora_de_Registro = Detalle_de_Reuniones_de_MediacionData.Hora_de_Registro
                    ,Usuario_que_Registra = Detalle_de_Reuniones_de_MediacionData.Usuario_que_Registra
                    ,Usuario_que_RegistraName = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Reuniones_de_MediacionData.Usuario_que_Registra), "Spartan_User") ??  (string)Detalle_de_Reuniones_de_MediacionData.Usuario_que_Registra_Spartan_User.Name

					};
				}
				
				                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.Archivo_adjuntoSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varDetalle_de_Reuniones_de_Mediacion.Archivo_adjunto).Resource;

				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_SesionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Sesions_Tipo_de_Sesion = _ITipo_de_SesionApiConsumer.SelAll(true);
            if (Tipo_de_Sesions_Tipo_de_Sesion != null && Tipo_de_Sesions_Tipo_de_Sesion.Resource != null)
                ViewBag.Tipo_de_Sesions_Tipo_de_Sesion = Tipo_de_Sesions_Tipo_de_Sesion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Sesion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICumplimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Cumplimientos_Cumplimiento = _ICumplimientoApiConsumer.SelAll(true);
            if (Cumplimientos_Cumplimiento != null && Cumplimientos_Cumplimiento.Resource != null)
                ViewBag.Cumplimientos_Cumplimiento = Cumplimientos_Cumplimiento.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Cumplimiento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varDetalle_de_Reuniones_de_Mediacion);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_de_Reuniones_de_Mediacion(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45074);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_de_Reuniones_de_MediacionApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_de_Reuniones_de_MediacionModel varDetalle_de_Reuniones_de_Mediacion= new Detalle_de_Reuniones_de_MediacionModel();
            var permissionDetalle_de_Solicitante_en_Reuniones = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45103, ModuleId);
            ViewBag.PermissionDetalle_de_Solicitante_en_Reuniones = permissionDetalle_de_Solicitante_en_Reuniones;
            var permissionDetalle_de_Requerido_en_Reuniones = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45102, ModuleId);
            ViewBag.PermissionDetalle_de_Requerido_en_Reuniones = permissionDetalle_de_Requerido_en_Reuniones;


            if (id.ToString() != "0")
            {
                var Detalle_de_Reuniones_de_MediacionsData = _IDetalle_de_Reuniones_de_MediacionApiConsumer.ListaSelAll(0, 1000, "Detalle_de_Reuniones_de_Mediacion.Clave=" + id, "").Resource.Detalle_de_Reuniones_de_Mediacions;
				
				if (Detalle_de_Reuniones_de_MediacionsData != null && Detalle_de_Reuniones_de_MediacionsData.Count > 0)
                {
					var Detalle_de_Reuniones_de_MediacionData = Detalle_de_Reuniones_de_MediacionsData.First();
					varDetalle_de_Reuniones_de_Mediacion= new Detalle_de_Reuniones_de_MediacionModel
					{
						Clave  = Detalle_de_Reuniones_de_MediacionData.Clave 
	                    ,Numero_de_Expediente = Detalle_de_Reuniones_de_MediacionData.Numero_de_Expediente
                    ,Numero_de_ExpedienteNumero_de_Folio = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Reuniones_de_MediacionData.Numero_de_Expediente), "Solicitud") ??  (string)Detalle_de_Reuniones_de_MediacionData.Numero_de_Expediente_Solicitud.Numero_de_Folio
                    ,Lugar = Detalle_de_Reuniones_de_MediacionData.Lugar
                    ,Fecha = (Detalle_de_Reuniones_de_MediacionData.Fecha == null ? string.Empty : Convert.ToDateTime(Detalle_de_Reuniones_de_MediacionData.Fecha).ToString(ConfigurationProperty.DateFormat))
                    ,Hora = Detalle_de_Reuniones_de_MediacionData.Hora
                    ,Especialista = Detalle_de_Reuniones_de_MediacionData.Especialista
                    ,EspecialistaName = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Reuniones_de_MediacionData.Especialista), "Spartan_User") ??  (string)Detalle_de_Reuniones_de_MediacionData.Especialista_Spartan_User.Name
                    ,Mecanismo_Alterno = Detalle_de_Reuniones_de_MediacionData.Mecanismo_Alterno
                    ,Mecanismo_AlternoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Reuniones_de_MediacionData.Mecanismo_Alterno), "Tipo_de_Mecanismo_Alterno") ??  (string)Detalle_de_Reuniones_de_MediacionData.Mecanismo_Alterno_Tipo_de_Mecanismo_Alterno.Descripcion
                    ,Tipo_de_Sesion = Detalle_de_Reuniones_de_MediacionData.Tipo_de_Sesion
                    ,Tipo_de_SesionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Reuniones_de_MediacionData.Tipo_de_Sesion), "Tipo_de_Sesion") ??  (string)Detalle_de_Reuniones_de_MediacionData.Tipo_de_Sesion_Tipo_de_Sesion.Descripcion
                    ,Cumplimiento = Detalle_de_Reuniones_de_MediacionData.Cumplimiento
                    ,CumplimientoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Reuniones_de_MediacionData.Cumplimiento), "Cumplimiento") ??  (string)Detalle_de_Reuniones_de_MediacionData.Cumplimiento_Cumplimiento.Descripcion
                    ,Fecha_de_Registro = (Detalle_de_Reuniones_de_MediacionData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(Detalle_de_Reuniones_de_MediacionData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,Archivo_adjunto = Detalle_de_Reuniones_de_MediacionData.Archivo_adjunto
                    ,Hora_de_Registro = Detalle_de_Reuniones_de_MediacionData.Hora_de_Registro
                    ,Usuario_que_Registra = Detalle_de_Reuniones_de_MediacionData.Usuario_que_Registra
                    ,Usuario_que_RegistraName = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Reuniones_de_MediacionData.Usuario_que_Registra), "Spartan_User") ??  (string)Detalle_de_Reuniones_de_MediacionData.Usuario_que_Registra_Spartan_User.Name

					};
				}
                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.Archivo_adjuntoSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varDetalle_de_Reuniones_de_Mediacion.Archivo_adjunto).Resource;

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_SesionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Sesions_Tipo_de_Sesion = _ITipo_de_SesionApiConsumer.SelAll(true);
            if (Tipo_de_Sesions_Tipo_de_Sesion != null && Tipo_de_Sesions_Tipo_de_Sesion.Resource != null)
                ViewBag.Tipo_de_Sesions_Tipo_de_Sesion = Tipo_de_Sesions_Tipo_de_Sesion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Sesion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICumplimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Cumplimientos_Cumplimiento = _ICumplimientoApiConsumer.SelAll(true);
            if (Cumplimientos_Cumplimiento != null && Cumplimientos_Cumplimiento.Resource != null)
                ViewBag.Cumplimientos_Cumplimiento = Cumplimientos_Cumplimiento.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Cumplimiento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddDetalle_de_Reuniones_de_Mediacion", varDetalle_de_Reuniones_de_Mediacion);
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
        public ActionResult GetTipo_de_SesionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_SesionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_SesionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Sesion", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetCumplimientoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICumplimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICumplimientoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Cumplimiento", "Descripcion")?? m.Descripcion,
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
        public ActionResult ShowAdvanceFilter(Detalle_de_Reuniones_de_MediacionAdvanceSearchModel model, int idFilter = -1)
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

            _ITipo_de_SesionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Sesions_Tipo_de_Sesion = _ITipo_de_SesionApiConsumer.SelAll(true);
            if (Tipo_de_Sesions_Tipo_de_Sesion != null && Tipo_de_Sesions_Tipo_de_Sesion.Resource != null)
                ViewBag.Tipo_de_Sesions_Tipo_de_Sesion = Tipo_de_Sesions_Tipo_de_Sesion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Sesion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICumplimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Cumplimientos_Cumplimiento = _ICumplimientoApiConsumer.SelAll(true);
            if (Cumplimientos_Cumplimiento != null && Cumplimientos_Cumplimiento.Resource != null)
                ViewBag.Cumplimientos_Cumplimiento = Cumplimientos_Cumplimiento.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Cumplimiento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_SesionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Sesions_Tipo_de_Sesion = _ITipo_de_SesionApiConsumer.SelAll(true);
            if (Tipo_de_Sesions_Tipo_de_Sesion != null && Tipo_de_Sesions_Tipo_de_Sesion.Resource != null)
                ViewBag.Tipo_de_Sesions_Tipo_de_Sesion = Tipo_de_Sesions_Tipo_de_Sesion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Sesion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICumplimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Cumplimientos_Cumplimiento = _ICumplimientoApiConsumer.SelAll(true);
            if (Cumplimientos_Cumplimiento != null && Cumplimientos_Cumplimiento.Resource != null)
                ViewBag.Cumplimientos_Cumplimiento = Cumplimientos_Cumplimiento.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Cumplimiento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Detalle_de_Reuniones_de_MediacionAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Detalle_de_Reuniones_de_MediacionAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Detalle_de_Reuniones_de_MediacionAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_Reuniones_de_MediacionPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_de_Reuniones_de_MediacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Reuniones_de_Mediacions == null)
                result.Detalle_de_Reuniones_de_Mediacions = new List<Detalle_de_Reuniones_de_Mediacion>();

            return Json(new
            {
                data = result.Detalle_de_Reuniones_de_Mediacions.Select(m => new Detalle_de_Reuniones_de_MediacionGridModel
                    {
                    Clave = m.Clave
                        ,Numero_de_ExpedienteNumero_de_Folio = CultureHelper.GetTraduction(m.Numero_de_Expediente_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Numero_de_Expediente_Solicitud.Numero_de_Folio
			,Lugar = m.Lugar
                        ,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora
                        ,EspecialistaName = CultureHelper.GetTraduction(m.Especialista_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Especialista_Spartan_User.Name
                        ,Mecanismo_AlternoDescripcion = CultureHelper.GetTraduction(m.Mecanismo_Alterno_Tipo_de_Mecanismo_Alterno.Clave.ToString(), "Tipo_de_Mecanismo_Alterno") ?? (string)m.Mecanismo_Alterno_Tipo_de_Mecanismo_Alterno.Descripcion
                        ,Tipo_de_SesionDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Sesion_Tipo_de_Sesion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Sesion_Tipo_de_Sesion.Descripcion
                        ,CumplimientoDescripcion = CultureHelper.GetTraduction(m.Cumplimiento_Cumplimiento.Clave.ToString(), "Descripcion") ?? (string)m.Cumplimiento_Cumplimiento.Descripcion
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Archivo_adjunto = m.Archivo_adjunto
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetDetalle_de_Reuniones_de_MediacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Reuniones_de_MediacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_Reuniones_de_MediacionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Detalle_de_Reuniones_de_Mediacion", m.),
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
        /// Get List of Detalle_de_Reuniones_de_Mediacion from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Detalle_de_Reuniones_de_Mediacion Entity</returns>
        public ActionResult GetDetalle_de_Reuniones_de_MediacionList(UrlParametersModel param)
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
            _IDetalle_de_Reuniones_de_MediacionApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Detalle_de_Reuniones_de_MediacionPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Detalle_de_Reuniones_de_MediacionAdvanceSearchModel))
                {
					var advanceFilter =
                    (Detalle_de_Reuniones_de_MediacionAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Detalle_de_Reuniones_de_MediacionPropertyMapper oDetalle_de_Reuniones_de_MediacionPropertyMapper = new Detalle_de_Reuniones_de_MediacionPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oDetalle_de_Reuniones_de_MediacionPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IDetalle_de_Reuniones_de_MediacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Reuniones_de_Mediacions == null)
                result.Detalle_de_Reuniones_de_Mediacions = new List<Detalle_de_Reuniones_de_Mediacion>();

            return Json(new
            {
                aaData = result.Detalle_de_Reuniones_de_Mediacions.Select(m => new Detalle_de_Reuniones_de_MediacionGridModel
            {
                    Clave = m.Clave
                        ,Numero_de_ExpedienteNumero_de_Folio = CultureHelper.GetTraduction(m.Numero_de_Expediente_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Numero_de_Expediente_Solicitud.Numero_de_Folio
			,Lugar = m.Lugar
                        ,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora
                        ,EspecialistaName = CultureHelper.GetTraduction(m.Especialista_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Especialista_Spartan_User.Name
                        ,Mecanismo_AlternoDescripcion = CultureHelper.GetTraduction(m.Mecanismo_Alterno_Tipo_de_Mecanismo_Alterno.Clave.ToString(), "Tipo_de_Mecanismo_Alterno") ?? (string)m.Mecanismo_Alterno_Tipo_de_Mecanismo_Alterno.Descripcion
                        ,Tipo_de_SesionDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Sesion_Tipo_de_Sesion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Sesion_Tipo_de_Sesion.Descripcion
                        ,CumplimientoDescripcion = CultureHelper.GetTraduction(m.Cumplimiento_Cumplimiento.Clave.ToString(), "Descripcion") ?? (string)m.Cumplimiento_Cumplimiento.Descripcion
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Archivo_adjunto = m.Archivo_adjunto
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetDetalle_de_Reuniones_de_Mediacion_Numero_de_Expediente_Solicitud(string query, string where)
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
        public JsonResult GetDetalle_de_Reuniones_de_Mediacion_Especialista_Spartan_User(string query, string where)
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
        public JsonResult GetDetalle_de_Reuniones_de_Mediacion_Mecanismo_Alterno_Tipo_de_Mecanismo_Alterno(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_Mecanismo_AlternoApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Tipo_de_Mecanismo_Alterno.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Tipo_de_Mecanismo_Alterno.Descripcion as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _ITipo_de_Mecanismo_AlternoApiConsumer.ListaSelAll(1, 20,elWhere , " Tipo_de_Mecanismo_Alterno.Descripcion ASC ").Resource;
               
                foreach (var item in result.Tipo_de_Mecanismo_Alternos)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Tipo_de_Mecanismo_Alterno", "Descripcion");
                    item.Descripcion =trans ??item.Descripcion;
                }
                return Json(result.Tipo_de_Mecanismo_Alternos.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
//Grid GetAutoComplete
        [HttpGet]
        public JsonResult GetDetalle_de_Solicitante_en_Reuniones_Nombre_Detalle_de_Solicitud_Solicitante(string query, string where)
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
        public JsonResult GetDetalle_de_Requerido_en_Reuniones_Nombre_Detalle_de_Solicitud_Requerido(string query, string where)
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

        [HttpGet]
        public JsonResult GetDetalle_de_Reuniones_de_Mediacion_Usuario_que_Registra_Spartan_User(string query, string where)
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
        public string GetAdvanceFilter(Detalle_de_Reuniones_de_MediacionAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Detalle_de_Reuniones_de_Mediacion.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Detalle_de_Reuniones_de_Mediacion.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceNumero_de_Expediente))
            {
                switch (filter.Numero_de_ExpedienteFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud.Numero_de_Folio LIKE '" + filter.AdvanceNumero_de_Expediente + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud.Numero_de_Folio LIKE '%" + filter.AdvanceNumero_de_Expediente + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud.Numero_de_Folio = '" + filter.AdvanceNumero_de_Expediente + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud.Numero_de_Folio LIKE '%" + filter.AdvanceNumero_de_Expediente + "%'";
                        break;
                }
            }
            else if (filter.AdvanceNumero_de_ExpedienteMultiple != null && filter.AdvanceNumero_de_ExpedienteMultiple.Count() > 0)
            {
                var Numero_de_ExpedienteIds = string.Join(",", filter.AdvanceNumero_de_ExpedienteMultiple);

                where += " AND Detalle_de_Reuniones_de_Mediacion.Numero_de_Expediente In (" + Numero_de_ExpedienteIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Lugar))
            {
                switch (filter.LugarFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Reuniones_de_Mediacion.Lugar LIKE '" + filter.Lugar + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Reuniones_de_Mediacion.Lugar LIKE '%" + filter.Lugar + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Reuniones_de_Mediacion.Lugar = '" + filter.Lugar + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Reuniones_de_Mediacion.Lugar LIKE '%" + filter.Lugar + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha) || !string.IsNullOrEmpty(filter.ToFecha))
            {
                var FechaFrom = DateTime.ParseExact(filter.FromFecha, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var FechaTo = DateTime.ParseExact(filter.ToFecha, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha))
                    where += " AND Detalle_de_Reuniones_de_Mediacion.Fecha >= '" + FechaFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha))
                    where += " AND Detalle_de_Reuniones_de_Mediacion.Fecha <= '" + FechaTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora) || !string.IsNullOrEmpty(filter.ToHora))
            {
                if (!string.IsNullOrEmpty(filter.FromHora))
                    where += " AND Convert(TIME,Detalle_de_Reuniones_de_Mediacion.Hora) >='" + filter.FromHora + "'";
                if (!string.IsNullOrEmpty(filter.ToHora))
                    where += " AND Convert(TIME,Detalle_de_Reuniones_de_Mediacion.Hora) <='" + filter.ToHora + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEspecialista))
            {
                switch (filter.EspecialistaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_User.Name LIKE '" + filter.AdvanceEspecialista + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceEspecialista + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_User.Name = '" + filter.AdvanceEspecialista + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceEspecialista + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEspecialistaMultiple != null && filter.AdvanceEspecialistaMultiple.Count() > 0)
            {
                var EspecialistaIds = string.Join(",", filter.AdvanceEspecialistaMultiple);

                where += " AND Detalle_de_Reuniones_de_Mediacion.Especialista In (" + EspecialistaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceMecanismo_Alterno))
            {
                switch (filter.Mecanismo_AlternoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Mecanismo_Alterno.Descripcion LIKE '" + filter.AdvanceMecanismo_Alterno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Mecanismo_Alterno.Descripcion LIKE '%" + filter.AdvanceMecanismo_Alterno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Mecanismo_Alterno.Descripcion = '" + filter.AdvanceMecanismo_Alterno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Mecanismo_Alterno.Descripcion LIKE '%" + filter.AdvanceMecanismo_Alterno + "%'";
                        break;
                }
            }
            else if (filter.AdvanceMecanismo_AlternoMultiple != null && filter.AdvanceMecanismo_AlternoMultiple.Count() > 0)
            {
                var Mecanismo_AlternoIds = string.Join(",", filter.AdvanceMecanismo_AlternoMultiple);

                where += " AND Detalle_de_Reuniones_de_Mediacion.Mecanismo_Alterno In (" + Mecanismo_AlternoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Sesion))
            {
                switch (filter.Tipo_de_SesionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Sesion.Descripcion LIKE '" + filter.AdvanceTipo_de_Sesion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Sesion.Descripcion LIKE '%" + filter.AdvanceTipo_de_Sesion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Sesion.Descripcion = '" + filter.AdvanceTipo_de_Sesion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Sesion.Descripcion LIKE '%" + filter.AdvanceTipo_de_Sesion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_SesionMultiple != null && filter.AdvanceTipo_de_SesionMultiple.Count() > 0)
            {
                var Tipo_de_SesionIds = string.Join(",", filter.AdvanceTipo_de_SesionMultiple);

                where += " AND Detalle_de_Reuniones_de_Mediacion.Tipo_de_Sesion In (" + Tipo_de_SesionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceCumplimiento))
            {
                switch (filter.CumplimientoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cumplimiento.Descripcion LIKE '" + filter.AdvanceCumplimiento + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cumplimiento.Descripcion LIKE '%" + filter.AdvanceCumplimiento + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cumplimiento.Descripcion = '" + filter.AdvanceCumplimiento + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cumplimiento.Descripcion LIKE '%" + filter.AdvanceCumplimiento + "%'";
                        break;
                }
            }
            else if (filter.AdvanceCumplimientoMultiple != null && filter.AdvanceCumplimientoMultiple.Count() > 0)
            {
                var CumplimientoIds = string.Join(",", filter.AdvanceCumplimientoMultiple);

                where += " AND Detalle_de_Reuniones_de_Mediacion.Cumplimiento In (" + CumplimientoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro) || !string.IsNullOrEmpty(filter.ToFecha_de_Registro))
            {
                var Fecha_de_RegistroFrom = DateTime.ParseExact(filter.FromFecha_de_Registro, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_RegistroTo = DateTime.ParseExact(filter.ToFecha_de_Registro, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro))
                    where += " AND Detalle_de_Reuniones_de_Mediacion.Fecha_de_Registro >= '" + Fecha_de_RegistroFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Registro))
                    where += " AND Detalle_de_Reuniones_de_Mediacion.Fecha_de_Registro <= '" + Fecha_de_RegistroTo.ToString("MM-dd-yyyy") + "'";
            }

            if (filter.Archivo_adjunto != RadioOptions.NoApply)
                where += " AND Detalle_de_Reuniones_de_Mediacion.Archivo_adjunto " + (filter.Archivo_adjunto == RadioOptions.Yes ? ">" : "==") + " 0";

            if (!string.IsNullOrEmpty(filter.FromHora_de_Registro) || !string.IsNullOrEmpty(filter.ToHora_de_Registro))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Registro))
                    where += " AND Convert(TIME,Detalle_de_Reuniones_de_Mediacion.Hora_de_Registro) >='" + filter.FromHora_de_Registro + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Registro))
                    where += " AND Convert(TIME,Detalle_de_Reuniones_de_Mediacion.Hora_de_Registro) <='" + filter.ToHora_de_Registro + "'";
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

                where += " AND Detalle_de_Reuniones_de_Mediacion.Usuario_que_Registra In (" + Usuario_que_RegistraIds + ")";
            }


            where = new Regex(Regex.Escape("AND ")).Replace(where, "", 1);
            return where;
        }

        [NonAction]
        public Grid_File ConvertSpartane_FileToGridFile(Spartane.Core.Domain.Spartane_File.Spartane_File file)
        {
            return file == null ? new Grid_File { FileId = 0, FileSize = 0, FileName = "" } : new Grid_File { FileId = file.File_Id, FileName = file.Description, FileSize = file.File_Size ?? 0, };
        }

        public ActionResult GetDetalle_de_Solicitante_en_Reuniones(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_Solicitante_en_ReunionesGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Solicitante_en_ReunionesApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_Solicitante_en_Reuniones.Solicitud=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_Solicitante_en_Reuniones.Solicitud='" + RelationId + "'";
            }
            var result = _IDetalle_de_Solicitante_en_ReunionesApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_Solicitante_en_Reunioness == null)
                result.Detalle_de_Solicitante_en_Reunioness = new List<Detalle_de_Solicitante_en_Reuniones>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_Solicitante_en_Reunioness.Select(m => new Detalle_de_Solicitante_en_ReunionesGridModel
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
        public List<Detalle_de_Solicitante_en_ReunionesGridModel> GetDetalle_de_Solicitante_en_ReunionesData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_Solicitante_en_ReunionesGridModel> resultData = new List<Detalle_de_Solicitante_en_ReunionesGridModel>();
            string where = "Detalle_de_Solicitante_en_Reuniones.Solicitud=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_Solicitante_en_Reuniones.Solicitud='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Solicitante_en_ReunionesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_Solicitante_en_ReunionesApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_Solicitante_en_Reunioness != null)
            {
                resultData = result.Detalle_de_Solicitante_en_Reunioness.Select(m => new Detalle_de_Solicitante_en_ReunionesGridModel
                    {
                        Clave = m.Clave

                        ,Nombre = m.Nombre
                        ,NombreNombre_Completo = CultureHelper.GetTraduction(m.Nombre_Detalle_de_Solicitud_Solicitante.Clave.ToString(), "Nombre_Completo") ??(string)m.Nombre_Detalle_de_Solicitud_Solicitante.Nombre_Completo


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_de_Requerido_en_Reuniones(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_Requerido_en_ReunionesGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Requerido_en_ReunionesApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_Requerido_en_Reuniones.Solicitud=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_Requerido_en_Reuniones.Solicitud='" + RelationId + "'";
            }
            var result = _IDetalle_de_Requerido_en_ReunionesApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_Requerido_en_Reunioness == null)
                result.Detalle_de_Requerido_en_Reunioness = new List<Detalle_de_Requerido_en_Reuniones>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_Requerido_en_Reunioness.Select(m => new Detalle_de_Requerido_en_ReunionesGridModel
                {
                    Clave = m.Clave

                        ,Nombre = m.Nombre
                        ,NombreNombre_Completo = CultureHelper.GetTraduction(m.Nombre_Detalle_de_Solicitud_Requerido.Clave.ToString(), "Nombre_Completo") ??(string)m.Nombre_Detalle_de_Solicitud_Requerido.Nombre_Completo
			,Faltante = m.Faltante

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_Requerido_en_ReunionesGridModel> GetDetalle_de_Requerido_en_ReunionesData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_Requerido_en_ReunionesGridModel> resultData = new List<Detalle_de_Requerido_en_ReunionesGridModel>();
            string where = "Detalle_de_Requerido_en_Reuniones.Solicitud=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_Requerido_en_Reuniones.Solicitud='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Requerido_en_ReunionesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_Requerido_en_ReunionesApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_Requerido_en_Reunioness != null)
            {
                resultData = result.Detalle_de_Requerido_en_Reunioness.Select(m => new Detalle_de_Requerido_en_ReunionesGridModel
                    {
                        Clave = m.Clave

                        ,Nombre = m.Nombre
                        ,NombreNombre_Completo = CultureHelper.GetTraduction(m.Nombre_Detalle_de_Solicitud_Requerido.Clave.ToString(), "Nombre_Completo") ??(string)m.Nombre_Detalle_de_Solicitud_Requerido.Nombre_Completo
			,Faltante = m.Faltante


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
                _IDetalle_de_Reuniones_de_MediacionApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_de_Reuniones_de_Mediacion varDetalle_de_Reuniones_de_Mediacion = null;
                if (id.ToString() != "0")
                {
                        string where = "";
                    _IDetalle_de_Solicitante_en_ReunionesApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_Solicitante_en_Reuniones.Solicitud=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_Solicitante_en_Reuniones.Solicitud='" + id + "'";
                    }
                    var Detalle_de_Solicitante_en_ReunionesInfo =
                        _IDetalle_de_Solicitante_en_ReunionesApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_Solicitante_en_ReunionesInfo.Detalle_de_Solicitante_en_Reunioness.Count > 0)
                    {
                        var resultDetalle_de_Solicitante_en_Reuniones = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_Solicitante_en_ReunionesItem in Detalle_de_Solicitante_en_ReunionesInfo.Detalle_de_Solicitante_en_Reunioness)
                            resultDetalle_de_Solicitante_en_Reuniones = resultDetalle_de_Solicitante_en_Reuniones
                                              && _IDetalle_de_Solicitante_en_ReunionesApiConsumer.Delete(Detalle_de_Solicitante_en_ReunionesItem.Clave, null,null).Resource;

                        if (!resultDetalle_de_Solicitante_en_Reuniones)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_de_Requerido_en_ReunionesApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_Requerido_en_Reuniones.Solicitud=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_Requerido_en_Reuniones.Solicitud='" + id + "'";
                    }
                    var Detalle_de_Requerido_en_ReunionesInfo =
                        _IDetalle_de_Requerido_en_ReunionesApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_Requerido_en_ReunionesInfo.Detalle_de_Requerido_en_Reunioness.Count > 0)
                    {
                        var resultDetalle_de_Requerido_en_Reuniones = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_Requerido_en_ReunionesItem in Detalle_de_Requerido_en_ReunionesInfo.Detalle_de_Requerido_en_Reunioness)
                            resultDetalle_de_Requerido_en_Reuniones = resultDetalle_de_Requerido_en_Reuniones
                                              && _IDetalle_de_Requerido_en_ReunionesApiConsumer.Delete(Detalle_de_Requerido_en_ReunionesItem.Clave, null,null).Resource;

                        if (!resultDetalle_de_Requerido_en_Reuniones)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }

                }
                var result = _IDetalle_de_Reuniones_de_MediacionApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_de_Reuniones_de_MediacionModel varDetalle_de_Reuniones_de_Mediacion)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_de_Reuniones_de_MediacionApiConsumer.SetAuthHeader(_tokenManager.Token);


                    if (varDetalle_de_Reuniones_de_Mediacion.Archivo_adjuntoRemoveAttachment != 0 && varDetalle_de_Reuniones_de_Mediacion.Archivo_adjuntoFile == null)
                    {
                        varDetalle_de_Reuniones_de_Mediacion.Archivo_adjunto = 0;
                    }

                    if (varDetalle_de_Reuniones_de_Mediacion.Archivo_adjuntoFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varDetalle_de_Reuniones_de_Mediacion.Archivo_adjuntoFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varDetalle_de_Reuniones_de_Mediacion.Archivo_adjunto = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varDetalle_de_Reuniones_de_Mediacion.Archivo_adjuntoFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }

                    
                    var result = "";
                    var Detalle_de_Reuniones_de_MediacionInfo = new Detalle_de_Reuniones_de_Mediacion
                    {
                        Clave = varDetalle_de_Reuniones_de_Mediacion.Clave
                        ,Numero_de_Expediente = varDetalle_de_Reuniones_de_Mediacion.Numero_de_Expediente
                        ,Lugar = varDetalle_de_Reuniones_de_Mediacion.Lugar
                        ,Fecha = (!String.IsNullOrEmpty(varDetalle_de_Reuniones_de_Mediacion.Fecha)) ? DateTime.ParseExact(varDetalle_de_Reuniones_de_Mediacion.Fecha, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora = varDetalle_de_Reuniones_de_Mediacion.Hora
                        ,Especialista = varDetalle_de_Reuniones_de_Mediacion.Especialista
                        ,Mecanismo_Alterno = varDetalle_de_Reuniones_de_Mediacion.Mecanismo_Alterno
                        ,Tipo_de_Sesion = varDetalle_de_Reuniones_de_Mediacion.Tipo_de_Sesion
                        ,Cumplimiento = varDetalle_de_Reuniones_de_Mediacion.Cumplimiento
                        ,Fecha_de_Registro = (!String.IsNullOrEmpty(varDetalle_de_Reuniones_de_Mediacion.Fecha_de_Registro)) ? DateTime.ParseExact(varDetalle_de_Reuniones_de_Mediacion.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Archivo_adjunto = (varDetalle_de_Reuniones_de_Mediacion.Archivo_adjunto.HasValue && varDetalle_de_Reuniones_de_Mediacion.Archivo_adjunto != 0) ? ((int?)Convert.ToInt32(varDetalle_de_Reuniones_de_Mediacion.Archivo_adjunto.Value)) : null

                        ,Hora_de_Registro = varDetalle_de_Reuniones_de_Mediacion.Hora_de_Registro
                        ,Usuario_que_Registra = varDetalle_de_Reuniones_de_Mediacion.Usuario_que_Registra

                    };

                    result = !IsNew ?
                        _IDetalle_de_Reuniones_de_MediacionApiConsumer.Update(Detalle_de_Reuniones_de_MediacionInfo, null, null).Resource.ToString() :
                         _IDetalle_de_Reuniones_de_MediacionApiConsumer.Insert(Detalle_de_Reuniones_de_MediacionInfo, null, null).Resource.ToString();
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
        public bool CopyDetalle_de_Solicitante_en_Reuniones(int MasterId, int referenceId, List<Detalle_de_Solicitante_en_ReunionesGridModelPost> Detalle_de_Solicitante_en_ReunionesItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_Solicitante_en_ReunionesApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_Solicitante_en_ReunionesData = _IDetalle_de_Solicitante_en_ReunionesApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_Solicitante_en_Reuniones.Solicitud=" + referenceId,"").Resource;
                if (Detalle_de_Solicitante_en_ReunionesData == null || Detalle_de_Solicitante_en_ReunionesData.Detalle_de_Solicitante_en_Reunioness.Count == 0)
                    return true;

                var result = true;

                Detalle_de_Solicitante_en_ReunionesGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_Solicitante_en_Reuniones in Detalle_de_Solicitante_en_ReunionesData.Detalle_de_Solicitante_en_Reunioness)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_Solicitante_en_Reuniones Detalle_de_Solicitante_en_Reuniones1 = varDetalle_de_Solicitante_en_Reuniones;

                    if (Detalle_de_Solicitante_en_ReunionesItems != null && Detalle_de_Solicitante_en_ReunionesItems.Any(m => m.Clave == Detalle_de_Solicitante_en_Reuniones1.Clave))
                    {
                        modelDataToChange = Detalle_de_Solicitante_en_ReunionesItems.FirstOrDefault(m => m.Clave == Detalle_de_Solicitante_en_Reuniones1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_de_Solicitante_en_Reuniones.Solicitud = MasterId;
                    var insertId = _IDetalle_de_Solicitante_en_ReunionesApiConsumer.Insert(varDetalle_de_Solicitante_en_Reuniones,null,null).Resource;
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
        public ActionResult PostDetalle_de_Solicitante_en_Reuniones(List<Detalle_de_Solicitante_en_ReunionesGridModelPost> Detalle_de_Solicitante_en_ReunionesItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_Solicitante_en_Reuniones(MasterId, referenceId, Detalle_de_Solicitante_en_ReunionesItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_Solicitante_en_ReunionesItems != null && Detalle_de_Solicitante_en_ReunionesItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_Solicitante_en_ReunionesApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_Solicitante_en_ReunionesItem in Detalle_de_Solicitante_en_ReunionesItems)
                    {



                        //Removal Request
                        if (Detalle_de_Solicitante_en_ReunionesItem.Removed)
                        {
                            result = result && _IDetalle_de_Solicitante_en_ReunionesApiConsumer.Delete(Detalle_de_Solicitante_en_ReunionesItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_Solicitante_en_ReunionesItem.Clave = 0;

                        var Detalle_de_Solicitante_en_ReunionesData = new Detalle_de_Solicitante_en_Reuniones
                        {
                            Solicitud = MasterId
                            ,Clave = Detalle_de_Solicitante_en_ReunionesItem.Clave
                            ,Nombre = (Convert.ToInt32(Detalle_de_Solicitante_en_ReunionesItem.Nombre) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Solicitante_en_ReunionesItem.Nombre))

                        };

                        var resultId = Detalle_de_Solicitante_en_ReunionesItem.Clave > 0
                           ? _IDetalle_de_Solicitante_en_ReunionesApiConsumer.Update(Detalle_de_Solicitante_en_ReunionesData,null,null).Resource
                           : _IDetalle_de_Solicitante_en_ReunionesApiConsumer.Insert(Detalle_de_Solicitante_en_ReunionesData,null,null).Resource;

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
        public ActionResult GetDetalle_de_Solicitante_en_Reuniones_Detalle_de_Solicitud_SolicitanteAll()
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
        public bool CopyDetalle_de_Requerido_en_Reuniones(int MasterId, int referenceId, List<Detalle_de_Requerido_en_ReunionesGridModelPost> Detalle_de_Requerido_en_ReunionesItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_Requerido_en_ReunionesApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_Requerido_en_ReunionesData = _IDetalle_de_Requerido_en_ReunionesApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_Requerido_en_Reuniones.Solicitud=" + referenceId,"").Resource;
                if (Detalle_de_Requerido_en_ReunionesData == null || Detalle_de_Requerido_en_ReunionesData.Detalle_de_Requerido_en_Reunioness.Count == 0)
                    return true;

                var result = true;

                Detalle_de_Requerido_en_ReunionesGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_Requerido_en_Reuniones in Detalle_de_Requerido_en_ReunionesData.Detalle_de_Requerido_en_Reunioness)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_Requerido_en_Reuniones Detalle_de_Requerido_en_Reuniones1 = varDetalle_de_Requerido_en_Reuniones;

                    if (Detalle_de_Requerido_en_ReunionesItems != null && Detalle_de_Requerido_en_ReunionesItems.Any(m => m.Clave == Detalle_de_Requerido_en_Reuniones1.Clave))
                    {
                        modelDataToChange = Detalle_de_Requerido_en_ReunionesItems.FirstOrDefault(m => m.Clave == Detalle_de_Requerido_en_Reuniones1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_de_Requerido_en_Reuniones.Solicitud = MasterId;
                    var insertId = _IDetalle_de_Requerido_en_ReunionesApiConsumer.Insert(varDetalle_de_Requerido_en_Reuniones,null,null).Resource;
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
        public ActionResult PostDetalle_de_Requerido_en_Reuniones(List<Detalle_de_Requerido_en_ReunionesGridModelPost> Detalle_de_Requerido_en_ReunionesItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_Requerido_en_Reuniones(MasterId, referenceId, Detalle_de_Requerido_en_ReunionesItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_Requerido_en_ReunionesItems != null && Detalle_de_Requerido_en_ReunionesItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_Requerido_en_ReunionesApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_Requerido_en_ReunionesItem in Detalle_de_Requerido_en_ReunionesItems)
                    {




                        //Removal Request
                        if (Detalle_de_Requerido_en_ReunionesItem.Removed)
                        {
                            result = result && _IDetalle_de_Requerido_en_ReunionesApiConsumer.Delete(Detalle_de_Requerido_en_ReunionesItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_Requerido_en_ReunionesItem.Clave = 0;

                        var Detalle_de_Requerido_en_ReunionesData = new Detalle_de_Requerido_en_Reuniones
                        {
                            Solicitud = MasterId
                            ,Clave = Detalle_de_Requerido_en_ReunionesItem.Clave
                            ,Nombre = (Convert.ToInt32(Detalle_de_Requerido_en_ReunionesItem.Nombre) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Requerido_en_ReunionesItem.Nombre))
                            ,Faltante = Detalle_de_Requerido_en_ReunionesItem.Faltante

                        };

                        var resultId = Detalle_de_Requerido_en_ReunionesItem.Clave > 0
                           ? _IDetalle_de_Requerido_en_ReunionesApiConsumer.Update(Detalle_de_Requerido_en_ReunionesData,null,null).Resource
                           : _IDetalle_de_Requerido_en_ReunionesApiConsumer.Insert(Detalle_de_Requerido_en_ReunionesData,null,null).Resource;

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
        public ActionResult GetDetalle_de_Requerido_en_Reuniones_Detalle_de_Solicitud_RequeridoAll()
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
        /// Write Element Array of Detalle_de_Reuniones_de_Mediacion script
        /// </summary>
        /// <param name="oDetalle_de_Reuniones_de_MediacionElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Detalle_de_Reuniones_de_MediacionModuleAttributeList)
        {
            for (int i = 0; i < Detalle_de_Reuniones_de_MediacionModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_de_Reuniones_de_MediacionModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_de_Reuniones_de_MediacionModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_de_Reuniones_de_MediacionModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_de_Reuniones_de_MediacionModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_de_Reuniones_de_MediacionModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_de_Reuniones_de_MediacionModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Detalle_de_Reuniones_de_MediacionModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Detalle_de_Reuniones_de_MediacionModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Detalle_de_Reuniones_de_MediacionModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Detalle_de_Reuniones_de_MediacionModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Detalle_de_Reuniones_de_MediacionModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strDetalle_de_Reuniones_de_MediacionScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Reuniones_de_Mediacion.js")))
            {
                strDetalle_de_Reuniones_de_MediacionScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_de_Reuniones_de_Mediacion element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_de_Reuniones_de_MediacionModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_de_Reuniones_de_MediacionScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_de_Reuniones_de_MediacionScript.Substring(indexOfArray, strDetalle_de_Reuniones_de_MediacionScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_de_Reuniones_de_MediacionModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_de_Reuniones_de_MediacionModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_de_Reuniones_de_MediacionScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strDetalle_de_Reuniones_de_MediacionScript.Substring(indexOfArrayHistory, strDetalle_de_Reuniones_de_MediacionScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strDetalle_de_Reuniones_de_MediacionScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_de_Reuniones_de_MediacionScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_de_Reuniones_de_MediacionScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Detalle_de_Reuniones_de_MediacionModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Detalle_de_Reuniones_de_MediacionModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_de_Reuniones_de_Mediacion.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_de_Reuniones_de_Mediacion.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Reuniones_de_Mediacion.js")))
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
        public ActionResult Detalle_de_Reuniones_de_MediacionPropertyBag()
        {
            return PartialView("Detalle_de_Reuniones_de_MediacionPropertyBag", "Detalle_de_Reuniones_de_Mediacion");
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
        public ActionResult AddDetalle_de_Solicitante_en_Reuniones(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_Solicitante_en_Reuniones/AddDetalle_de_Solicitante_en_Reuniones");
        }

        [HttpGet]
        public ActionResult AddDetalle_de_Requerido_en_Reuniones(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_Requerido_en_Reuniones/AddDetalle_de_Requerido_en_Reuniones");
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
                var whereClauseFormat = "Object = 45074 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IDetalle_de_Reuniones_de_MediacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Detalle_de_Reuniones_de_Mediacion.Clave= " + RecordId;
                            var result = _IDetalle_de_Reuniones_de_MediacionApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IDetalle_de_Reuniones_de_MediacionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Detalle_de_Reuniones_de_MediacionPropertyMapper());
			
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
                    (Detalle_de_Reuniones_de_MediacionAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Detalle_de_Reuniones_de_MediacionPropertyMapper oDetalle_de_Reuniones_de_MediacionPropertyMapper = new Detalle_de_Reuniones_de_MediacionPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oDetalle_de_Reuniones_de_MediacionPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_Reuniones_de_MediacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Reuniones_de_Mediacions == null)
                result.Detalle_de_Reuniones_de_Mediacions = new List<Detalle_de_Reuniones_de_Mediacion>();

            var data = result.Detalle_de_Reuniones_de_Mediacions.Select(m => new Detalle_de_Reuniones_de_MediacionGridModel
            {
                Clave = m.Clave
                        ,Numero_de_ExpedienteNumero_de_Folio = CultureHelper.GetTraduction(m.Numero_de_Expediente_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Numero_de_Expediente_Solicitud.Numero_de_Folio
			,Lugar = m.Lugar
                        ,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora
                        ,EspecialistaName = CultureHelper.GetTraduction(m.Especialista_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Especialista_Spartan_User.Name
                        ,Mecanismo_AlternoDescripcion = CultureHelper.GetTraduction(m.Mecanismo_Alterno_Tipo_de_Mecanismo_Alterno.Clave.ToString(), "Tipo_de_Mecanismo_Alterno") ?? (string)m.Mecanismo_Alterno_Tipo_de_Mecanismo_Alterno.Descripcion
                        ,Tipo_de_SesionDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Sesion_Tipo_de_Sesion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Sesion_Tipo_de_Sesion.Descripcion
                        ,CumplimientoDescripcion = CultureHelper.GetTraduction(m.Cumplimiento_Cumplimiento.Clave.ToString(), "Descripcion") ?? (string)m.Cumplimiento_Cumplimiento.Descripcion
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Archivo_adjunto = m.Archivo_adjunto
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45074, arrayColumnsVisible), "Detalle_de_Reuniones_de_MediacionList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45074, arrayColumnsVisible), "Detalle_de_Reuniones_de_MediacionList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45074, arrayColumnsVisible), "Detalle_de_Reuniones_de_MediacionList_" + DateTime.Now.ToString());
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

            _IDetalle_de_Reuniones_de_MediacionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Detalle_de_Reuniones_de_MediacionPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Detalle_de_Reuniones_de_MediacionAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Detalle_de_Reuniones_de_MediacionPropertyMapper oDetalle_de_Reuniones_de_MediacionPropertyMapper = new Detalle_de_Reuniones_de_MediacionPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oDetalle_de_Reuniones_de_MediacionPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_Reuniones_de_MediacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Reuniones_de_Mediacions == null)
                result.Detalle_de_Reuniones_de_Mediacions = new List<Detalle_de_Reuniones_de_Mediacion>();

            var data = result.Detalle_de_Reuniones_de_Mediacions.Select(m => new Detalle_de_Reuniones_de_MediacionGridModel
            {
                Clave = m.Clave
                        ,Numero_de_ExpedienteNumero_de_Folio = CultureHelper.GetTraduction(m.Numero_de_Expediente_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Numero_de_Expediente_Solicitud.Numero_de_Folio
			,Lugar = m.Lugar
                        ,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora
                        ,EspecialistaName = CultureHelper.GetTraduction(m.Especialista_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Especialista_Spartan_User.Name
                        ,Mecanismo_AlternoDescripcion = CultureHelper.GetTraduction(m.Mecanismo_Alterno_Tipo_de_Mecanismo_Alterno.Clave.ToString(), "Tipo_de_Mecanismo_Alterno") ?? (string)m.Mecanismo_Alterno_Tipo_de_Mecanismo_Alterno.Descripcion
                        ,Tipo_de_SesionDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Sesion_Tipo_de_Sesion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Sesion_Tipo_de_Sesion.Descripcion
                        ,CumplimientoDescripcion = CultureHelper.GetTraduction(m.Cumplimiento_Cumplimiento.Clave.ToString(), "Descripcion") ?? (string)m.Cumplimiento_Cumplimiento.Descripcion
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Archivo_adjunto = m.Archivo_adjunto
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name

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
                _IDetalle_de_Reuniones_de_MediacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_Reuniones_de_MediacionApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Detalle_de_Reuniones_de_Mediacion_Datos_GeneralesModel varDetalle_de_Reuniones_de_Mediacion)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Reuniones_de_MediacionApiConsumer.SetAuthHeader(_tokenManager.Token);
				                    if (varDetalle_de_Reuniones_de_Mediacion.Archivo_adjuntoRemoveAttachment != 0 && varDetalle_de_Reuniones_de_Mediacion.Archivo_adjuntoFile == null)
                    {
                        varDetalle_de_Reuniones_de_Mediacion.Archivo_adjunto = 0;
                    }

                    if (varDetalle_de_Reuniones_de_Mediacion.Archivo_adjuntoFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varDetalle_de_Reuniones_de_Mediacion.Archivo_adjuntoFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varDetalle_de_Reuniones_de_Mediacion.Archivo_adjunto = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varDetalle_de_Reuniones_de_Mediacion.Archivo_adjuntoFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }

                var result = "";
                var Detalle_de_Reuniones_de_Mediacion_Datos_GeneralesInfo = new Detalle_de_Reuniones_de_Mediacion_Datos_Generales
                {
                    Clave = varDetalle_de_Reuniones_de_Mediacion.Clave
                                            ,Numero_de_Expediente = varDetalle_de_Reuniones_de_Mediacion.Numero_de_Expediente
                        ,Lugar = varDetalle_de_Reuniones_de_Mediacion.Lugar
                        ,Fecha = (!String.IsNullOrEmpty(varDetalle_de_Reuniones_de_Mediacion.Fecha)) ? DateTime.ParseExact(varDetalle_de_Reuniones_de_Mediacion.Fecha, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora = varDetalle_de_Reuniones_de_Mediacion.Hora
                        ,Especialista = varDetalle_de_Reuniones_de_Mediacion.Especialista
                        ,Mecanismo_Alterno = varDetalle_de_Reuniones_de_Mediacion.Mecanismo_Alterno
                        ,Tipo_de_Sesion = varDetalle_de_Reuniones_de_Mediacion.Tipo_de_Sesion
                        ,Cumplimiento = varDetalle_de_Reuniones_de_Mediacion.Cumplimiento
                        ,Fecha_de_Registro = (!String.IsNullOrEmpty(varDetalle_de_Reuniones_de_Mediacion.Fecha_de_Registro)) ? DateTime.ParseExact(varDetalle_de_Reuniones_de_Mediacion.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Archivo_adjunto = (varDetalle_de_Reuniones_de_Mediacion.Archivo_adjunto.HasValue && varDetalle_de_Reuniones_de_Mediacion.Archivo_adjunto != 0) ? ((int?)Convert.ToInt32(varDetalle_de_Reuniones_de_Mediacion.Archivo_adjunto.Value)) : null

                        ,Hora_de_Registro = varDetalle_de_Reuniones_de_Mediacion.Hora_de_Registro
                        ,Usuario_que_Registra = varDetalle_de_Reuniones_de_Mediacion.Usuario_que_Registra
                    
                };

                result = _IDetalle_de_Reuniones_de_MediacionApiConsumer.Update_Datos_Generales(Detalle_de_Reuniones_de_Mediacion_Datos_GeneralesInfo).Resource.ToString();
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
                _IDetalle_de_Reuniones_de_MediacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IDetalle_de_Reuniones_de_MediacionApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_de_Solicitante_en_Reuniones;
                var Detalle_de_Solicitante_en_ReunionesData = GetDetalle_de_Solicitante_en_ReunionesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Solicitante_en_Reuniones);
                int RowCount_Detalle_de_Requerido_en_Reuniones;
                var Detalle_de_Requerido_en_ReunionesData = GetDetalle_de_Requerido_en_ReunionesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Requerido_en_Reuniones);

                var result = new Detalle_de_Reuniones_de_Mediacion_Datos_GeneralesModel
                {
                    Clave = m.Clave
                        ,Numero_de_Expediente = m.Numero_de_Expediente
                        ,Numero_de_ExpedienteNumero_de_Folio = CultureHelper.GetTraduction(m.Numero_de_Expediente_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Numero_de_Expediente_Solicitud.Numero_de_Folio
			,Lugar = m.Lugar
                        ,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora
                        ,Especialista = m.Especialista
                        ,EspecialistaName = CultureHelper.GetTraduction(m.Especialista_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Especialista_Spartan_User.Name
                        ,Mecanismo_Alterno = m.Mecanismo_Alterno
                        ,Mecanismo_AlternoDescripcion = CultureHelper.GetTraduction(m.Mecanismo_Alterno_Tipo_de_Mecanismo_Alterno.Clave.ToString(), "Tipo_de_Mecanismo_Alterno") ?? (string)m.Mecanismo_Alterno_Tipo_de_Mecanismo_Alterno.Descripcion
                        ,Tipo_de_Sesion = m.Tipo_de_Sesion
                        ,Tipo_de_SesionDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Sesion_Tipo_de_Sesion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Sesion_Tipo_de_Sesion.Descripcion
                        ,Cumplimiento = m.Cumplimiento
                        ,CumplimientoDescripcion = CultureHelper.GetTraduction(m.Cumplimiento_Cumplimiento.Clave.ToString(), "Descripcion") ?? (string)m.Cumplimiento_Cumplimiento.Descripcion
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Archivo_adjunto = m.Archivo_adjunto
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_Registra = m.Usuario_que_Registra
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name

                    
                };
				var resultData = new
                {
                    data = result
                    ,Solicitanter = Detalle_de_Solicitante_en_ReunionesData
                    ,Requeridor = Detalle_de_Requerido_en_ReunionesData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }


    }
}

