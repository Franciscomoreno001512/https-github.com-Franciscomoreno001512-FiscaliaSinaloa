using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Acuerdos_MASC;
using Spartane.Core.Domain.Solicitud;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Tipo_de_Acuerdo;
using Spartane.Core.Domain.Forma_de_Cumplimiento;
using Spartane.Core.Domain.Relaciones_MASC;
using Spartane.Core.Domain.Periodicidad;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.A_Tiempo;
using Spartane.Core.Domain.Razon_de_Incumplimiento;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Resultado_de_Revision;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Acuerdos_MASC;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Acuerdos_MASC;
using Spartane.Web.Areas.WebApiConsumer.Solicitud;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Acuerdo;
using Spartane.Web.Areas.WebApiConsumer.Forma_de_Cumplimiento;
using Spartane.Web.Areas.WebApiConsumer.Relaciones_MASC;
using Spartane.Web.Areas.WebApiConsumer.Periodicidad;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.A_Tiempo;
using Spartane.Web.Areas.WebApiConsumer.Razon_de_Incumplimiento;
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
    public class Acuerdos_MASCController : Controller
    {
        #region "variable declaration"

        private IAcuerdos_MASCService service = null;
        private IAcuerdos_MASCApiConsumer _IAcuerdos_MASCApiConsumer;
        private ISolicitudApiConsumer _ISolicitudApiConsumer;
        private ISpartan_UserApiConsumer _ISpartan_UserApiConsumer;
        private ITipo_de_AcuerdoApiConsumer _ITipo_de_AcuerdoApiConsumer;
        private IForma_de_CumplimientoApiConsumer _IForma_de_CumplimientoApiConsumer;
        private IRelaciones_MASCApiConsumer _IRelaciones_MASCApiConsumer;
        private IPeriodicidadApiConsumer _IPeriodicidadApiConsumer;
        private IA_TiempoApiConsumer _IA_TiempoApiConsumer;
        private IRazon_de_IncumplimientoApiConsumer _IRazon_de_IncumplimientoApiConsumer;
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

        
        public Acuerdos_MASCController(IAcuerdos_MASCService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IAcuerdos_MASCApiConsumer Acuerdos_MASCApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , ISolicitudApiConsumer SolicitudApiConsumer , ISpartan_UserApiConsumer Spartan_UserApiConsumer , ITipo_de_AcuerdoApiConsumer Tipo_de_AcuerdoApiConsumer , IForma_de_CumplimientoApiConsumer Forma_de_CumplimientoApiConsumer , IRelaciones_MASCApiConsumer Relaciones_MASCApiConsumer , IPeriodicidadApiConsumer PeriodicidadApiConsumer , IA_TiempoApiConsumer A_TiempoApiConsumer , IRazon_de_IncumplimientoApiConsumer Razon_de_IncumplimientoApiConsumer , IResultado_de_RevisionApiConsumer Resultado_de_RevisionApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IAcuerdos_MASCApiConsumer = Acuerdos_MASCApiConsumer;
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
            this._ITipo_de_AcuerdoApiConsumer = Tipo_de_AcuerdoApiConsumer;
            this._IForma_de_CumplimientoApiConsumer = Forma_de_CumplimientoApiConsumer;
            this._IRelaciones_MASCApiConsumer = Relaciones_MASCApiConsumer;
            this._IPeriodicidadApiConsumer = PeriodicidadApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._IA_TiempoApiConsumer = A_TiempoApiConsumer;
            this._IRazon_de_IncumplimientoApiConsumer = Razon_de_IncumplimientoApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._IResultado_de_RevisionApiConsumer = Resultado_de_RevisionApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Acuerdos_MASC
        [ObjectAuth(ObjectId = (ModuleObjectId)45378, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45378, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Acuerdos_MASC/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45378, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45378, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varAcuerdos_MASC = new Acuerdos_MASCModel();
			varAcuerdos_MASC.Clave = Id;
			
            ViewBag.ObjectId = "45378";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IAcuerdos_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Acuerdos_MASCsData = _IAcuerdos_MASCApiConsumer.ListaSelAll(0, 1000, "Acuerdos_MASC.Clave=" + Id, "").Resource.Acuerdos_MASCs;
				
				if (Acuerdos_MASCsData != null && Acuerdos_MASCsData.Count > 0)
                {
					var Acuerdos_MASCData = Acuerdos_MASCsData.First();
					varAcuerdos_MASC= new Acuerdos_MASCModel
					{
						Clave  = Acuerdos_MASCData.Clave 
	                    ,Numero_de_Expediente = Acuerdos_MASCData.Numero_de_Expediente
                    ,Numero_de_ExpedienteNumero_de_Folio = CultureHelper.GetTraduction(Convert.ToString(Acuerdos_MASCData.Numero_de_Expediente), "Solicitud") ??  (string)Acuerdos_MASCData.Numero_de_Expediente_Solicitud.Numero_de_Folio
                    ,Fecha_de_Registro = (Acuerdos_MASCData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(Acuerdos_MASCData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Registro = Acuerdos_MASCData.Hora_de_Registro
                    ,Usuario_que_Registra = Acuerdos_MASCData.Usuario_que_Registra
                    ,Usuario_que_RegistraName = CultureHelper.GetTraduction(Convert.ToString(Acuerdos_MASCData.Usuario_que_Registra), "Spartan_User") ??  (string)Acuerdos_MASCData.Usuario_que_Registra_Spartan_User.Name
                    ,Tipo_de_Acuerdo = Acuerdos_MASCData.Tipo_de_Acuerdo
                    ,Tipo_de_AcuerdoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Acuerdos_MASCData.Tipo_de_Acuerdo), "Tipo_de_Acuerdo") ??  (string)Acuerdos_MASCData.Tipo_de_Acuerdo_Tipo_de_Acuerdo.Descripcion
                    ,Forma_de_Cumplimiento = Acuerdos_MASCData.Forma_de_Cumplimiento
                    ,Forma_de_CumplimientoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Acuerdos_MASCData.Forma_de_Cumplimiento), "Forma_de_Cumplimiento") ??  (string)Acuerdos_MASCData.Forma_de_Cumplimiento_Forma_de_Cumplimiento.Descripcion
                    ,Descripcion_del_Cumplimiento = Acuerdos_MASCData.Descripcion_del_Cumplimiento
                    ,Relacion = Acuerdos_MASCData.Relacion
                    ,RelacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Acuerdos_MASCData.Relacion), "Relaciones_MASC") ??  (string)Acuerdos_MASCData.Relacion_Relaciones_MASC.Descripcion
                    ,Lugar_Acordado = Acuerdos_MASCData.Lugar_Acordado
                    ,Domicilio_Acordado = Acuerdos_MASCData.Domicilio_Acordado
                    ,Hora_de_Acuerdo = Acuerdos_MASCData.Hora_de_Acuerdo
                    ,Fecha_de_Inicio_de_Acuerdo = (Acuerdos_MASCData.Fecha_de_Inicio_de_Acuerdo == null ? string.Empty : Convert.ToDateTime(Acuerdos_MASCData.Fecha_de_Inicio_de_Acuerdo).ToString(ConfigurationProperty.DateFormat))
                    ,Monto_Total = Acuerdos_MASCData.Monto_Total
                    ,Parcialidades = Acuerdos_MASCData.Parcialidades
                    ,Periodicidad = Acuerdos_MASCData.Periodicidad
                    ,PeriodicidadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Acuerdos_MASCData.Periodicidad), "Periodicidad") ??  (string)Acuerdos_MASCData.Periodicidad_Periodicidad.Descripcion
                    ,Monto_de_la_Parcialidad = Acuerdos_MASCData.Monto_de_la_Parcialidad
                    ,Personal_de_Seguimiento_Asignado = Acuerdos_MASCData.Personal_de_Seguimiento_Asignado
                    ,Personal_de_Seguimiento_AsignadoName = CultureHelper.GetTraduction(Convert.ToString(Acuerdos_MASCData.Personal_de_Seguimiento_Asignado), "Spartan_User") ??  (string)Acuerdos_MASCData.Personal_de_Seguimiento_Asignado_Spartan_User.Name
                    ,Acuerdo = Acuerdos_MASCData.Acuerdo
                    ,Comentarios = Acuerdos_MASCData.Comentarios
                    ,Acuerdo_Cumplido = Acuerdos_MASCData.Acuerdo_Cumplido
                    ,Acuerdo_CumplidoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Acuerdos_MASCData.Acuerdo_Cumplido), "A_Tiempo") ??  (string)Acuerdos_MASCData.Acuerdo_Cumplido_A_Tiempo.Descripcion
                    ,Fecha_de_Cumplimiento_de_Acuerdo = (Acuerdos_MASCData.Fecha_de_Cumplimiento_de_Acuerdo == null ? string.Empty : Convert.ToDateTime(Acuerdos_MASCData.Fecha_de_Cumplimiento_de_Acuerdo).ToString(ConfigurationProperty.DateFormat))
                    ,Razon_de_Incumplimiento = Acuerdos_MASCData.Razon_de_Incumplimiento
                    ,Razon_de_IncumplimientoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Acuerdos_MASCData.Razon_de_Incumplimiento), "Razon_de_Incumplimiento") ??  (string)Acuerdos_MASCData.Razon_de_Incumplimiento_Razon_de_Incumplimiento.Descripcion
                    ,Fecha_de_Revision = (Acuerdos_MASCData.Fecha_de_Revision == null ? string.Empty : Convert.ToDateTime(Acuerdos_MASCData.Fecha_de_Revision).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Revision = Acuerdos_MASCData.Hora_de_Revision
                    ,Usuario_que_Revisa = Acuerdos_MASCData.Usuario_que_Revisa
                    ,Usuario_que_RevisaName = CultureHelper.GetTraduction(Convert.ToString(Acuerdos_MASCData.Usuario_que_Revisa), "Spartan_User") ??  (string)Acuerdos_MASCData.Usuario_que_Revisa_Spartan_User.Name
                    ,Resultado = Acuerdos_MASCData.Resultado
                    ,ResultadoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Acuerdos_MASCData.Resultado), "Resultado_de_Revision") ??  (string)Acuerdos_MASCData.Resultado_Resultado_de_Revision.Descripcion
                    ,Motivo_de_Rechazo_de_Acuerdo = Acuerdos_MASCData.Motivo_de_Rechazo_de_Acuerdo

					};
				}
				
				                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.AcuerdoSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varAcuerdos_MASC.Acuerdo).Resource;

				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_AcuerdoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Acuerdos_Tipo_de_Acuerdo = _ITipo_de_AcuerdoApiConsumer.SelAll(true);
            if (Tipo_de_Acuerdos_Tipo_de_Acuerdo != null && Tipo_de_Acuerdos_Tipo_de_Acuerdo.Resource != null)
                ViewBag.Tipo_de_Acuerdos_Tipo_de_Acuerdo = Tipo_de_Acuerdos_Tipo_de_Acuerdo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Acuerdo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_de_CumplimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_de_Cumplimientos_Forma_de_Cumplimiento = _IForma_de_CumplimientoApiConsumer.SelAll(true);
            if (Forma_de_Cumplimientos_Forma_de_Cumplimiento != null && Forma_de_Cumplimientos_Forma_de_Cumplimiento.Resource != null)
                ViewBag.Forma_de_Cumplimientos_Forma_de_Cumplimiento = Forma_de_Cumplimientos_Forma_de_Cumplimiento.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_de_Cumplimiento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPeriodicidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Periodicidads_Periodicidad = _IPeriodicidadApiConsumer.SelAll(true);
            if (Periodicidads_Periodicidad != null && Periodicidads_Periodicidad.Resource != null)
                ViewBag.Periodicidads_Periodicidad = Periodicidads_Periodicidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Periodicidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_Acuerdo_Cumplido = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_Acuerdo_Cumplido != null && A_Tiempos_Acuerdo_Cumplido.Resource != null)
                ViewBag.A_Tiempos_Acuerdo_Cumplido = A_Tiempos_Acuerdo_Cumplido.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IRazon_de_IncumplimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Razon_de_Incumplimientos_Razon_de_Incumplimiento = _IRazon_de_IncumplimientoApiConsumer.SelAll(true);
            if (Razon_de_Incumplimientos_Razon_de_Incumplimiento != null && Razon_de_Incumplimientos_Razon_de_Incumplimiento.Resource != null)
                ViewBag.Razon_de_Incumplimientos_Razon_de_Incumplimiento = Razon_de_Incumplimientos_Razon_de_Incumplimiento.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Razon_de_Incumplimiento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResultado_de_RevisionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resultado_de_Revisions_Resultado = _IResultado_de_RevisionApiConsumer.SelAll(true);
            if (Resultado_de_Revisions_Resultado != null && Resultado_de_Revisions_Resultado.Resource != null)
                ViewBag.Resultado_de_Revisions_Resultado = Resultado_de_Revisions_Resultado.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
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

				
            return View(varAcuerdos_MASC);
        }
		
	[HttpGet]
        public ActionResult AddAcuerdos_MASC(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45378);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IAcuerdos_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
			Acuerdos_MASCModel varAcuerdos_MASC= new Acuerdos_MASCModel();


            if (id.ToString() != "0")
            {
                var Acuerdos_MASCsData = _IAcuerdos_MASCApiConsumer.ListaSelAll(0, 1000, "Acuerdos_MASC.Clave=" + id, "").Resource.Acuerdos_MASCs;
				
				if (Acuerdos_MASCsData != null && Acuerdos_MASCsData.Count > 0)
                {
					var Acuerdos_MASCData = Acuerdos_MASCsData.First();
					varAcuerdos_MASC= new Acuerdos_MASCModel
					{
						Clave  = Acuerdos_MASCData.Clave 
	                    ,Numero_de_Expediente = Acuerdos_MASCData.Numero_de_Expediente
                    ,Numero_de_ExpedienteNumero_de_Folio = CultureHelper.GetTraduction(Convert.ToString(Acuerdos_MASCData.Numero_de_Expediente), "Solicitud") ??  (string)Acuerdos_MASCData.Numero_de_Expediente_Solicitud.Numero_de_Folio
                    ,Fecha_de_Registro = (Acuerdos_MASCData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(Acuerdos_MASCData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Registro = Acuerdos_MASCData.Hora_de_Registro
                    ,Usuario_que_Registra = Acuerdos_MASCData.Usuario_que_Registra
                    ,Usuario_que_RegistraName = CultureHelper.GetTraduction(Convert.ToString(Acuerdos_MASCData.Usuario_que_Registra), "Spartan_User") ??  (string)Acuerdos_MASCData.Usuario_que_Registra_Spartan_User.Name
                    ,Tipo_de_Acuerdo = Acuerdos_MASCData.Tipo_de_Acuerdo
                    ,Tipo_de_AcuerdoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Acuerdos_MASCData.Tipo_de_Acuerdo), "Tipo_de_Acuerdo") ??  (string)Acuerdos_MASCData.Tipo_de_Acuerdo_Tipo_de_Acuerdo.Descripcion
                    ,Forma_de_Cumplimiento = Acuerdos_MASCData.Forma_de_Cumplimiento
                    ,Forma_de_CumplimientoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Acuerdos_MASCData.Forma_de_Cumplimiento), "Forma_de_Cumplimiento") ??  (string)Acuerdos_MASCData.Forma_de_Cumplimiento_Forma_de_Cumplimiento.Descripcion
                    ,Descripcion_del_Cumplimiento = Acuerdos_MASCData.Descripcion_del_Cumplimiento
                    ,Relacion = Acuerdos_MASCData.Relacion
                    ,RelacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Acuerdos_MASCData.Relacion), "Relaciones_MASC") ??  (string)Acuerdos_MASCData.Relacion_Relaciones_MASC.Descripcion
                    ,Lugar_Acordado = Acuerdos_MASCData.Lugar_Acordado
                    ,Domicilio_Acordado = Acuerdos_MASCData.Domicilio_Acordado
                    ,Hora_de_Acuerdo = Acuerdos_MASCData.Hora_de_Acuerdo
                    ,Fecha_de_Inicio_de_Acuerdo = (Acuerdos_MASCData.Fecha_de_Inicio_de_Acuerdo == null ? string.Empty : Convert.ToDateTime(Acuerdos_MASCData.Fecha_de_Inicio_de_Acuerdo).ToString(ConfigurationProperty.DateFormat))
                    ,Monto_Total = Acuerdos_MASCData.Monto_Total
                    ,Parcialidades = Acuerdos_MASCData.Parcialidades
                    ,Periodicidad = Acuerdos_MASCData.Periodicidad
                    ,PeriodicidadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Acuerdos_MASCData.Periodicidad), "Periodicidad") ??  (string)Acuerdos_MASCData.Periodicidad_Periodicidad.Descripcion
                    ,Monto_de_la_Parcialidad = Acuerdos_MASCData.Monto_de_la_Parcialidad
                    ,Personal_de_Seguimiento_Asignado = Acuerdos_MASCData.Personal_de_Seguimiento_Asignado
                    ,Personal_de_Seguimiento_AsignadoName = CultureHelper.GetTraduction(Convert.ToString(Acuerdos_MASCData.Personal_de_Seguimiento_Asignado), "Spartan_User") ??  (string)Acuerdos_MASCData.Personal_de_Seguimiento_Asignado_Spartan_User.Name
                    ,Acuerdo = Acuerdos_MASCData.Acuerdo
                    ,Comentarios = Acuerdos_MASCData.Comentarios
                    ,Acuerdo_Cumplido = Acuerdos_MASCData.Acuerdo_Cumplido
                    ,Acuerdo_CumplidoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Acuerdos_MASCData.Acuerdo_Cumplido), "A_Tiempo") ??  (string)Acuerdos_MASCData.Acuerdo_Cumplido_A_Tiempo.Descripcion
                    ,Fecha_de_Cumplimiento_de_Acuerdo = (Acuerdos_MASCData.Fecha_de_Cumplimiento_de_Acuerdo == null ? string.Empty : Convert.ToDateTime(Acuerdos_MASCData.Fecha_de_Cumplimiento_de_Acuerdo).ToString(ConfigurationProperty.DateFormat))
                    ,Razon_de_Incumplimiento = Acuerdos_MASCData.Razon_de_Incumplimiento
                    ,Razon_de_IncumplimientoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Acuerdos_MASCData.Razon_de_Incumplimiento), "Razon_de_Incumplimiento") ??  (string)Acuerdos_MASCData.Razon_de_Incumplimiento_Razon_de_Incumplimiento.Descripcion
                    ,Fecha_de_Revision = (Acuerdos_MASCData.Fecha_de_Revision == null ? string.Empty : Convert.ToDateTime(Acuerdos_MASCData.Fecha_de_Revision).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Revision = Acuerdos_MASCData.Hora_de_Revision
                    ,Usuario_que_Revisa = Acuerdos_MASCData.Usuario_que_Revisa
                    ,Usuario_que_RevisaName = CultureHelper.GetTraduction(Convert.ToString(Acuerdos_MASCData.Usuario_que_Revisa), "Spartan_User") ??  (string)Acuerdos_MASCData.Usuario_que_Revisa_Spartan_User.Name
                    ,Resultado = Acuerdos_MASCData.Resultado
                    ,ResultadoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Acuerdos_MASCData.Resultado), "Resultado_de_Revision") ??  (string)Acuerdos_MASCData.Resultado_Resultado_de_Revision.Descripcion
                    ,Motivo_de_Rechazo_de_Acuerdo = Acuerdos_MASCData.Motivo_de_Rechazo_de_Acuerdo

					};
				}
                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.AcuerdoSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varAcuerdos_MASC.Acuerdo).Resource;

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_AcuerdoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Acuerdos_Tipo_de_Acuerdo = _ITipo_de_AcuerdoApiConsumer.SelAll(true);
            if (Tipo_de_Acuerdos_Tipo_de_Acuerdo != null && Tipo_de_Acuerdos_Tipo_de_Acuerdo.Resource != null)
                ViewBag.Tipo_de_Acuerdos_Tipo_de_Acuerdo = Tipo_de_Acuerdos_Tipo_de_Acuerdo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Acuerdo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_de_CumplimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_de_Cumplimientos_Forma_de_Cumplimiento = _IForma_de_CumplimientoApiConsumer.SelAll(true);
            if (Forma_de_Cumplimientos_Forma_de_Cumplimiento != null && Forma_de_Cumplimientos_Forma_de_Cumplimiento.Resource != null)
                ViewBag.Forma_de_Cumplimientos_Forma_de_Cumplimiento = Forma_de_Cumplimientos_Forma_de_Cumplimiento.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_de_Cumplimiento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPeriodicidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Periodicidads_Periodicidad = _IPeriodicidadApiConsumer.SelAll(true);
            if (Periodicidads_Periodicidad != null && Periodicidads_Periodicidad.Resource != null)
                ViewBag.Periodicidads_Periodicidad = Periodicidads_Periodicidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Periodicidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_Acuerdo_Cumplido = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_Acuerdo_Cumplido != null && A_Tiempos_Acuerdo_Cumplido.Resource != null)
                ViewBag.A_Tiempos_Acuerdo_Cumplido = A_Tiempos_Acuerdo_Cumplido.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IRazon_de_IncumplimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Razon_de_Incumplimientos_Razon_de_Incumplimiento = _IRazon_de_IncumplimientoApiConsumer.SelAll(true);
            if (Razon_de_Incumplimientos_Razon_de_Incumplimiento != null && Razon_de_Incumplimientos_Razon_de_Incumplimiento.Resource != null)
                ViewBag.Razon_de_Incumplimientos_Razon_de_Incumplimiento = Razon_de_Incumplimientos_Razon_de_Incumplimiento.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Razon_de_Incumplimiento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResultado_de_RevisionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resultado_de_Revisions_Resultado = _IResultado_de_RevisionApiConsumer.SelAll(true);
            if (Resultado_de_Revisions_Resultado != null && Resultado_de_Revisions_Resultado.Resource != null)
                ViewBag.Resultado_de_Revisions_Resultado = Resultado_de_Revisions_Resultado.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resultado_de_Revision", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddAcuerdos_MASC", varAcuerdos_MASC);
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
        public ActionResult GetTipo_de_AcuerdoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_AcuerdoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_AcuerdoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Acuerdo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetForma_de_CumplimientoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IForma_de_CumplimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IForma_de_CumplimientoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_de_Cumplimiento", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
		[HttpGet]
        public ActionResult GetRelaciones_MASCAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRelaciones_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IRelaciones_MASCApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Relaciones_MASC", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetPeriodicidadAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IPeriodicidadApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IPeriodicidadApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Periodicidad", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetA_TiempoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IA_TiempoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetRazon_de_IncumplimientoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRazon_de_IncumplimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IRazon_de_IncumplimientoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Razon_de_Incumplimiento", "Descripcion")?? m.Descripcion,
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
        public ActionResult ShowAdvanceFilter(Acuerdos_MASCAdvanceSearchModel model, int idFilter = -1)
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

            _ITipo_de_AcuerdoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Acuerdos_Tipo_de_Acuerdo = _ITipo_de_AcuerdoApiConsumer.SelAll(true);
            if (Tipo_de_Acuerdos_Tipo_de_Acuerdo != null && Tipo_de_Acuerdos_Tipo_de_Acuerdo.Resource != null)
                ViewBag.Tipo_de_Acuerdos_Tipo_de_Acuerdo = Tipo_de_Acuerdos_Tipo_de_Acuerdo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Acuerdo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_de_CumplimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_de_Cumplimientos_Forma_de_Cumplimiento = _IForma_de_CumplimientoApiConsumer.SelAll(true);
            if (Forma_de_Cumplimientos_Forma_de_Cumplimiento != null && Forma_de_Cumplimientos_Forma_de_Cumplimiento.Resource != null)
                ViewBag.Forma_de_Cumplimientos_Forma_de_Cumplimiento = Forma_de_Cumplimientos_Forma_de_Cumplimiento.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_de_Cumplimiento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPeriodicidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Periodicidads_Periodicidad = _IPeriodicidadApiConsumer.SelAll(true);
            if (Periodicidads_Periodicidad != null && Periodicidads_Periodicidad.Resource != null)
                ViewBag.Periodicidads_Periodicidad = Periodicidads_Periodicidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Periodicidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_Acuerdo_Cumplido = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_Acuerdo_Cumplido != null && A_Tiempos_Acuerdo_Cumplido.Resource != null)
                ViewBag.A_Tiempos_Acuerdo_Cumplido = A_Tiempos_Acuerdo_Cumplido.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IRazon_de_IncumplimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Razon_de_Incumplimientos_Razon_de_Incumplimiento = _IRazon_de_IncumplimientoApiConsumer.SelAll(true);
            if (Razon_de_Incumplimientos_Razon_de_Incumplimiento != null && Razon_de_Incumplimientos_Razon_de_Incumplimiento.Resource != null)
                ViewBag.Razon_de_Incumplimientos_Razon_de_Incumplimiento = Razon_de_Incumplimientos_Razon_de_Incumplimiento.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Razon_de_Incumplimiento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResultado_de_RevisionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resultado_de_Revisions_Resultado = _IResultado_de_RevisionApiConsumer.SelAll(true);
            if (Resultado_de_Revisions_Resultado != null && Resultado_de_Revisions_Resultado.Resource != null)
                ViewBag.Resultado_de_Revisions_Resultado = Resultado_de_Revisions_Resultado.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
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

            _ITipo_de_AcuerdoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Acuerdos_Tipo_de_Acuerdo = _ITipo_de_AcuerdoApiConsumer.SelAll(true);
            if (Tipo_de_Acuerdos_Tipo_de_Acuerdo != null && Tipo_de_Acuerdos_Tipo_de_Acuerdo.Resource != null)
                ViewBag.Tipo_de_Acuerdos_Tipo_de_Acuerdo = Tipo_de_Acuerdos_Tipo_de_Acuerdo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Acuerdo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_de_CumplimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_de_Cumplimientos_Forma_de_Cumplimiento = _IForma_de_CumplimientoApiConsumer.SelAll(true);
            if (Forma_de_Cumplimientos_Forma_de_Cumplimiento != null && Forma_de_Cumplimientos_Forma_de_Cumplimiento.Resource != null)
                ViewBag.Forma_de_Cumplimientos_Forma_de_Cumplimiento = Forma_de_Cumplimientos_Forma_de_Cumplimiento.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_de_Cumplimiento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPeriodicidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Periodicidads_Periodicidad = _IPeriodicidadApiConsumer.SelAll(true);
            if (Periodicidads_Periodicidad != null && Periodicidads_Periodicidad.Resource != null)
                ViewBag.Periodicidads_Periodicidad = Periodicidads_Periodicidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Periodicidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_Acuerdo_Cumplido = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_Acuerdo_Cumplido != null && A_Tiempos_Acuerdo_Cumplido.Resource != null)
                ViewBag.A_Tiempos_Acuerdo_Cumplido = A_Tiempos_Acuerdo_Cumplido.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IRazon_de_IncumplimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Razon_de_Incumplimientos_Razon_de_Incumplimiento = _IRazon_de_IncumplimientoApiConsumer.SelAll(true);
            if (Razon_de_Incumplimientos_Razon_de_Incumplimiento != null && Razon_de_Incumplimientos_Razon_de_Incumplimiento.Resource != null)
                ViewBag.Razon_de_Incumplimientos_Razon_de_Incumplimiento = Razon_de_Incumplimientos_Razon_de_Incumplimiento.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Razon_de_Incumplimiento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResultado_de_RevisionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resultado_de_Revisions_Resultado = _IResultado_de_RevisionApiConsumer.SelAll(true);
            if (Resultado_de_Revisions_Resultado != null && Resultado_de_Revisions_Resultado.Resource != null)
                ViewBag.Resultado_de_Revisions_Resultado = Resultado_de_Revisions_Resultado.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resultado_de_Revision", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Acuerdos_MASCAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Acuerdos_MASCAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Acuerdos_MASCAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Acuerdos_MASCPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IAcuerdos_MASCApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Acuerdos_MASCs == null)
                result.Acuerdos_MASCs = new List<Acuerdos_MASC>();

            return Json(new
            {
                data = result.Acuerdos_MASCs.Select(m => new Acuerdos_MASCGridModel
                    {
                    Clave = m.Clave
                        ,Numero_de_ExpedienteNumero_de_Folio = CultureHelper.GetTraduction(m.Numero_de_Expediente_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Numero_de_Expediente_Solicitud.Numero_de_Folio
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,Tipo_de_AcuerdoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Acuerdo_Tipo_de_Acuerdo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Acuerdo_Tipo_de_Acuerdo.Descripcion
                        ,Forma_de_CumplimientoDescripcion = CultureHelper.GetTraduction(m.Forma_de_Cumplimiento_Forma_de_Cumplimiento.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Cumplimiento_Forma_de_Cumplimiento.Descripcion
			,Descripcion_del_Cumplimiento = m.Descripcion_del_Cumplimiento
                        ,RelacionDescripcion = CultureHelper.GetTraduction(m.Relacion_Relaciones_MASC.Clave.ToString(), "Relaciones_MASC") ?? (string)m.Relacion_Relaciones_MASC.Descripcion
			,Lugar_Acordado = m.Lugar_Acordado
			,Domicilio_Acordado = m.Domicilio_Acordado
			,Hora_de_Acuerdo = m.Hora_de_Acuerdo
                        ,Fecha_de_Inicio_de_Acuerdo = (m.Fecha_de_Inicio_de_Acuerdo == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Inicio_de_Acuerdo).ToString(ConfigurationProperty.DateFormat))
			,Monto_Total = m.Monto_Total
			,Parcialidades = m.Parcialidades
                        ,PeriodicidadDescripcion = CultureHelper.GetTraduction(m.Periodicidad_Periodicidad.Clave.ToString(), "Descripcion") ?? (string)m.Periodicidad_Periodicidad.Descripcion
			,Monto_de_la_Parcialidad = m.Monto_de_la_Parcialidad
                        ,Personal_de_Seguimiento_AsignadoName = CultureHelper.GetTraduction(m.Personal_de_Seguimiento_Asignado_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Personal_de_Seguimiento_Asignado_Spartan_User.Name
			,Acuerdo = m.Acuerdo
			,Comentarios = m.Comentarios
                        ,Acuerdo_CumplidoDescripcion = CultureHelper.GetTraduction(m.Acuerdo_Cumplido_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Acuerdo_Cumplido_A_Tiempo.Descripcion
                        ,Fecha_de_Cumplimiento_de_Acuerdo = (m.Fecha_de_Cumplimiento_de_Acuerdo == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Cumplimiento_de_Acuerdo).ToString(ConfigurationProperty.DateFormat))
                        ,Razon_de_IncumplimientoDescripcion = CultureHelper.GetTraduction(m.Razon_de_Incumplimiento_Razon_de_Incumplimiento.Clave.ToString(), "Descripcion") ?? (string)m.Razon_de_Incumplimiento_Razon_de_Incumplimiento.Descripcion
                        ,Fecha_de_Revision = (m.Fecha_de_Revision == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Revision).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Revision = m.Hora_de_Revision
                        ,Usuario_que_RevisaName = CultureHelper.GetTraduction(m.Usuario_que_Revisa_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Revisa_Spartan_User.Name
                        ,ResultadoDescripcion = CultureHelper.GetTraduction(m.Resultado_Resultado_de_Revision.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_Resultado_de_Revision.Descripcion
			,Motivo_de_Rechazo_de_Acuerdo = m.Motivo_de_Rechazo_de_Acuerdo

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetAcuerdos_MASCAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IAcuerdos_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IAcuerdos_MASCApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Acuerdos_MASC", m.),
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
        /// Get List of Acuerdos_MASC from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Acuerdos_MASC Entity</returns>
        public ActionResult GetAcuerdos_MASCList(UrlParametersModel param)
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
            _IAcuerdos_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Acuerdos_MASCPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Acuerdos_MASCAdvanceSearchModel))
                {
					var advanceFilter =
                    (Acuerdos_MASCAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Acuerdos_MASCPropertyMapper oAcuerdos_MASCPropertyMapper = new Acuerdos_MASCPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oAcuerdos_MASCPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IAcuerdos_MASCApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Acuerdos_MASCs == null)
                result.Acuerdos_MASCs = new List<Acuerdos_MASC>();

            return Json(new
            {
                aaData = result.Acuerdos_MASCs.Select(m => new Acuerdos_MASCGridModel
            {
                    Clave = m.Clave
                        ,Numero_de_ExpedienteNumero_de_Folio = CultureHelper.GetTraduction(m.Numero_de_Expediente_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Numero_de_Expediente_Solicitud.Numero_de_Folio
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,Tipo_de_AcuerdoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Acuerdo_Tipo_de_Acuerdo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Acuerdo_Tipo_de_Acuerdo.Descripcion
                        ,Forma_de_CumplimientoDescripcion = CultureHelper.GetTraduction(m.Forma_de_Cumplimiento_Forma_de_Cumplimiento.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Cumplimiento_Forma_de_Cumplimiento.Descripcion
			,Descripcion_del_Cumplimiento = m.Descripcion_del_Cumplimiento
                        ,RelacionDescripcion = CultureHelper.GetTraduction(m.Relacion_Relaciones_MASC.Clave.ToString(), "Relaciones_MASC") ?? (string)m.Relacion_Relaciones_MASC.Descripcion
			,Lugar_Acordado = m.Lugar_Acordado
			,Domicilio_Acordado = m.Domicilio_Acordado
			,Hora_de_Acuerdo = m.Hora_de_Acuerdo
                        ,Fecha_de_Inicio_de_Acuerdo = (m.Fecha_de_Inicio_de_Acuerdo == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Inicio_de_Acuerdo).ToString(ConfigurationProperty.DateFormat))
			,Monto_Total = m.Monto_Total
			,Parcialidades = m.Parcialidades
                        ,PeriodicidadDescripcion = CultureHelper.GetTraduction(m.Periodicidad_Periodicidad.Clave.ToString(), "Descripcion") ?? (string)m.Periodicidad_Periodicidad.Descripcion
			,Monto_de_la_Parcialidad = m.Monto_de_la_Parcialidad
                        ,Personal_de_Seguimiento_AsignadoName = CultureHelper.GetTraduction(m.Personal_de_Seguimiento_Asignado_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Personal_de_Seguimiento_Asignado_Spartan_User.Name
			,Acuerdo = m.Acuerdo
			,Comentarios = m.Comentarios
                        ,Acuerdo_CumplidoDescripcion = CultureHelper.GetTraduction(m.Acuerdo_Cumplido_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Acuerdo_Cumplido_A_Tiempo.Descripcion
                        ,Fecha_de_Cumplimiento_de_Acuerdo = (m.Fecha_de_Cumplimiento_de_Acuerdo == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Cumplimiento_de_Acuerdo).ToString(ConfigurationProperty.DateFormat))
                        ,Razon_de_IncumplimientoDescripcion = CultureHelper.GetTraduction(m.Razon_de_Incumplimiento_Razon_de_Incumplimiento.Clave.ToString(), "Descripcion") ?? (string)m.Razon_de_Incumplimiento_Razon_de_Incumplimiento.Descripcion
                        ,Fecha_de_Revision = (m.Fecha_de_Revision == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Revision).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Revision = m.Hora_de_Revision
                        ,Usuario_que_RevisaName = CultureHelper.GetTraduction(m.Usuario_que_Revisa_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Revisa_Spartan_User.Name
                        ,ResultadoDescripcion = CultureHelper.GetTraduction(m.Resultado_Resultado_de_Revision.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_Resultado_de_Revision.Descripcion
			,Motivo_de_Rechazo_de_Acuerdo = m.Motivo_de_Rechazo_de_Acuerdo

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetAcuerdos_MASC_Numero_de_Expediente_Solicitud(string query, string where)
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
        public JsonResult GetAcuerdos_MASC_Usuario_que_Registra_Spartan_User(string query, string where)
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
        public JsonResult GetAcuerdos_MASC_Relacion_Relaciones_MASC(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRelaciones_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Relaciones_MASC.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Relaciones_MASC.Descripcion as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IRelaciones_MASCApiConsumer.ListaSelAll(1, 20,elWhere , " Relaciones_MASC.Descripcion ASC ").Resource;
               
                foreach (var item in result.Relaciones_MASCs)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Relaciones_MASC", "Descripcion");
                    item.Descripcion =trans ??item.Descripcion;
                }
                return Json(result.Relaciones_MASCs.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetAcuerdos_MASC_Personal_de_Seguimiento_Asignado_Spartan_User(string query, string where)
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
        public JsonResult GetAcuerdos_MASC_Usuario_que_Revisa_Spartan_User(string query, string where)
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
        public string GetAdvanceFilter(Acuerdos_MASCAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Acuerdos_MASC.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Acuerdos_MASC.Clave <= " + filter.ToClave;
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

                where += " AND Acuerdos_MASC.Numero_de_Expediente In (" + Numero_de_ExpedienteIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro) || !string.IsNullOrEmpty(filter.ToFecha_de_Registro))
            {
                var Fecha_de_RegistroFrom = DateTime.ParseExact(filter.FromFecha_de_Registro, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_RegistroTo = DateTime.ParseExact(filter.ToFecha_de_Registro, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro))
                    where += " AND Acuerdos_MASC.Fecha_de_Registro >= '" + Fecha_de_RegistroFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Registro))
                    where += " AND Acuerdos_MASC.Fecha_de_Registro <= '" + Fecha_de_RegistroTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Registro) || !string.IsNullOrEmpty(filter.ToHora_de_Registro))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Registro))
                    where += " AND Convert(TIME,Acuerdos_MASC.Hora_de_Registro) >='" + filter.FromHora_de_Registro + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Registro))
                    where += " AND Convert(TIME,Acuerdos_MASC.Hora_de_Registro) <='" + filter.ToHora_de_Registro + "'";
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

                where += " AND Acuerdos_MASC.Usuario_que_Registra In (" + Usuario_que_RegistraIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Acuerdo))
            {
                switch (filter.Tipo_de_AcuerdoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Acuerdo.Descripcion LIKE '" + filter.AdvanceTipo_de_Acuerdo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Acuerdo.Descripcion LIKE '%" + filter.AdvanceTipo_de_Acuerdo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Acuerdo.Descripcion = '" + filter.AdvanceTipo_de_Acuerdo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Acuerdo.Descripcion LIKE '%" + filter.AdvanceTipo_de_Acuerdo + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_AcuerdoMultiple != null && filter.AdvanceTipo_de_AcuerdoMultiple.Count() > 0)
            {
                var Tipo_de_AcuerdoIds = string.Join(",", filter.AdvanceTipo_de_AcuerdoMultiple);

                where += " AND Acuerdos_MASC.Tipo_de_Acuerdo In (" + Tipo_de_AcuerdoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceForma_de_Cumplimiento))
            {
                switch (filter.Forma_de_CumplimientoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Forma_de_Cumplimiento.Descripcion LIKE '" + filter.AdvanceForma_de_Cumplimiento + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Forma_de_Cumplimiento.Descripcion LIKE '%" + filter.AdvanceForma_de_Cumplimiento + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Forma_de_Cumplimiento.Descripcion = '" + filter.AdvanceForma_de_Cumplimiento + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Forma_de_Cumplimiento.Descripcion LIKE '%" + filter.AdvanceForma_de_Cumplimiento + "%'";
                        break;
                }
            }
            else if (filter.AdvanceForma_de_CumplimientoMultiple != null && filter.AdvanceForma_de_CumplimientoMultiple.Count() > 0)
            {
                var Forma_de_CumplimientoIds = string.Join(",", filter.AdvanceForma_de_CumplimientoMultiple);

                where += " AND Acuerdos_MASC.Forma_de_Cumplimiento In (" + Forma_de_CumplimientoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Descripcion_del_Cumplimiento))
            {
                switch (filter.Descripcion_del_CumplimientoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Acuerdos_MASC.Descripcion_del_Cumplimiento LIKE '" + filter.Descripcion_del_Cumplimiento + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Acuerdos_MASC.Descripcion_del_Cumplimiento LIKE '%" + filter.Descripcion_del_Cumplimiento + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Acuerdos_MASC.Descripcion_del_Cumplimiento = '" + filter.Descripcion_del_Cumplimiento + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Acuerdos_MASC.Descripcion_del_Cumplimiento LIKE '%" + filter.Descripcion_del_Cumplimiento + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceRelacion))
            {
                switch (filter.RelacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Relaciones_MASC.Descripcion LIKE '" + filter.AdvanceRelacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Relaciones_MASC.Descripcion LIKE '%" + filter.AdvanceRelacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Relaciones_MASC.Descripcion = '" + filter.AdvanceRelacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Relaciones_MASC.Descripcion LIKE '%" + filter.AdvanceRelacion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceRelacionMultiple != null && filter.AdvanceRelacionMultiple.Count() > 0)
            {
                var RelacionIds = string.Join(",", filter.AdvanceRelacionMultiple);

                where += " AND Acuerdos_MASC.Relacion In (" + RelacionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Lugar_Acordado))
            {
                switch (filter.Lugar_AcordadoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Acuerdos_MASC.Lugar_Acordado LIKE '" + filter.Lugar_Acordado + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Acuerdos_MASC.Lugar_Acordado LIKE '%" + filter.Lugar_Acordado + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Acuerdos_MASC.Lugar_Acordado = '" + filter.Lugar_Acordado + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Acuerdos_MASC.Lugar_Acordado LIKE '%" + filter.Lugar_Acordado + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Domicilio_Acordado))
            {
                switch (filter.Domicilio_AcordadoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Acuerdos_MASC.Domicilio_Acordado LIKE '" + filter.Domicilio_Acordado + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Acuerdos_MASC.Domicilio_Acordado LIKE '%" + filter.Domicilio_Acordado + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Acuerdos_MASC.Domicilio_Acordado = '" + filter.Domicilio_Acordado + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Acuerdos_MASC.Domicilio_Acordado LIKE '%" + filter.Domicilio_Acordado + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Acuerdo) || !string.IsNullOrEmpty(filter.ToHora_de_Acuerdo))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Acuerdo))
                    where += " AND Convert(TIME,Acuerdos_MASC.Hora_de_Acuerdo) >='" + filter.FromHora_de_Acuerdo + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Acuerdo))
                    where += " AND Convert(TIME,Acuerdos_MASC.Hora_de_Acuerdo) <='" + filter.ToHora_de_Acuerdo + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Inicio_de_Acuerdo) || !string.IsNullOrEmpty(filter.ToFecha_de_Inicio_de_Acuerdo))
            {
                var Fecha_de_Inicio_de_AcuerdoFrom = DateTime.ParseExact(filter.FromFecha_de_Inicio_de_Acuerdo, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_Inicio_de_AcuerdoTo = DateTime.ParseExact(filter.ToFecha_de_Inicio_de_Acuerdo, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Inicio_de_Acuerdo))
                    where += " AND Acuerdos_MASC.Fecha_de_Inicio_de_Acuerdo >= '" + Fecha_de_Inicio_de_AcuerdoFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Inicio_de_Acuerdo))
                    where += " AND Acuerdos_MASC.Fecha_de_Inicio_de_Acuerdo <= '" + Fecha_de_Inicio_de_AcuerdoTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromMonto_Total) || !string.IsNullOrEmpty(filter.ToMonto_Total))
            {
                if (!string.IsNullOrEmpty(filter.FromMonto_Total))
                    where += " AND Acuerdos_MASC.Monto_Total >= " + filter.FromMonto_Total;
                if (!string.IsNullOrEmpty(filter.ToMonto_Total))
                    where += " AND Acuerdos_MASC.Monto_Total <= " + filter.ToMonto_Total;
            }

            if (!string.IsNullOrEmpty(filter.FromParcialidades) || !string.IsNullOrEmpty(filter.ToParcialidades))
            {
                if (!string.IsNullOrEmpty(filter.FromParcialidades))
                    where += " AND Acuerdos_MASC.Parcialidades >= " + filter.FromParcialidades;
                if (!string.IsNullOrEmpty(filter.ToParcialidades))
                    where += " AND Acuerdos_MASC.Parcialidades <= " + filter.ToParcialidades;
            }

            if (!string.IsNullOrEmpty(filter.AdvancePeriodicidad))
            {
                switch (filter.PeriodicidadFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Periodicidad.Descripcion LIKE '" + filter.AdvancePeriodicidad + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Periodicidad.Descripcion LIKE '%" + filter.AdvancePeriodicidad + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Periodicidad.Descripcion = '" + filter.AdvancePeriodicidad + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Periodicidad.Descripcion LIKE '%" + filter.AdvancePeriodicidad + "%'";
                        break;
                }
            }
            else if (filter.AdvancePeriodicidadMultiple != null && filter.AdvancePeriodicidadMultiple.Count() > 0)
            {
                var PeriodicidadIds = string.Join(",", filter.AdvancePeriodicidadMultiple);

                where += " AND Acuerdos_MASC.Periodicidad In (" + PeriodicidadIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromMonto_de_la_Parcialidad) || !string.IsNullOrEmpty(filter.ToMonto_de_la_Parcialidad))
            {
                if (!string.IsNullOrEmpty(filter.FromMonto_de_la_Parcialidad))
                    where += " AND Acuerdos_MASC.Monto_de_la_Parcialidad >= " + filter.FromMonto_de_la_Parcialidad;
                if (!string.IsNullOrEmpty(filter.ToMonto_de_la_Parcialidad))
                    where += " AND Acuerdos_MASC.Monto_de_la_Parcialidad <= " + filter.ToMonto_de_la_Parcialidad;
            }

            if (!string.IsNullOrEmpty(filter.AdvancePersonal_de_Seguimiento_Asignado))
            {
                switch (filter.Personal_de_Seguimiento_AsignadoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_User.Name LIKE '" + filter.AdvancePersonal_de_Seguimiento_Asignado + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvancePersonal_de_Seguimiento_Asignado + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_User.Name = '" + filter.AdvancePersonal_de_Seguimiento_Asignado + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvancePersonal_de_Seguimiento_Asignado + "%'";
                        break;
                }
            }
            else if (filter.AdvancePersonal_de_Seguimiento_AsignadoMultiple != null && filter.AdvancePersonal_de_Seguimiento_AsignadoMultiple.Count() > 0)
            {
                var Personal_de_Seguimiento_AsignadoIds = string.Join(",", filter.AdvancePersonal_de_Seguimiento_AsignadoMultiple);

                where += " AND Acuerdos_MASC.Personal_de_Seguimiento_Asignado In (" + Personal_de_Seguimiento_AsignadoIds + ")";
            }

            if (filter.Acuerdo != RadioOptions.NoApply)
                where += " AND Acuerdos_MASC.Acuerdo " + (filter.Acuerdo == RadioOptions.Yes ? ">" : "==") + " 0";

            if (!string.IsNullOrEmpty(filter.Comentarios))
            {
                switch (filter.ComentariosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Acuerdos_MASC.Comentarios LIKE '" + filter.Comentarios + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Acuerdos_MASC.Comentarios LIKE '%" + filter.Comentarios + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Acuerdos_MASC.Comentarios = '" + filter.Comentarios + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Acuerdos_MASC.Comentarios LIKE '%" + filter.Comentarios + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceAcuerdo_Cumplido))
            {
                switch (filter.Acuerdo_CumplidoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND A_Tiempo.Descripcion LIKE '" + filter.AdvanceAcuerdo_Cumplido + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND A_Tiempo.Descripcion LIKE '%" + filter.AdvanceAcuerdo_Cumplido + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND A_Tiempo.Descripcion = '" + filter.AdvanceAcuerdo_Cumplido + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND A_Tiempo.Descripcion LIKE '%" + filter.AdvanceAcuerdo_Cumplido + "%'";
                        break;
                }
            }
            else if (filter.AdvanceAcuerdo_CumplidoMultiple != null && filter.AdvanceAcuerdo_CumplidoMultiple.Count() > 0)
            {
                var Acuerdo_CumplidoIds = string.Join(",", filter.AdvanceAcuerdo_CumplidoMultiple);

                where += " AND Acuerdos_MASC.Acuerdo_Cumplido In (" + Acuerdo_CumplidoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Cumplimiento_de_Acuerdo) || !string.IsNullOrEmpty(filter.ToFecha_de_Cumplimiento_de_Acuerdo))
            {
                var Fecha_de_Cumplimiento_de_AcuerdoFrom = DateTime.ParseExact(filter.FromFecha_de_Cumplimiento_de_Acuerdo, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_Cumplimiento_de_AcuerdoTo = DateTime.ParseExact(filter.ToFecha_de_Cumplimiento_de_Acuerdo, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Cumplimiento_de_Acuerdo))
                    where += " AND Acuerdos_MASC.Fecha_de_Cumplimiento_de_Acuerdo >= '" + Fecha_de_Cumplimiento_de_AcuerdoFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Cumplimiento_de_Acuerdo))
                    where += " AND Acuerdos_MASC.Fecha_de_Cumplimiento_de_Acuerdo <= '" + Fecha_de_Cumplimiento_de_AcuerdoTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceRazon_de_Incumplimiento))
            {
                switch (filter.Razon_de_IncumplimientoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Razon_de_Incumplimiento.Descripcion LIKE '" + filter.AdvanceRazon_de_Incumplimiento + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Razon_de_Incumplimiento.Descripcion LIKE '%" + filter.AdvanceRazon_de_Incumplimiento + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Razon_de_Incumplimiento.Descripcion = '" + filter.AdvanceRazon_de_Incumplimiento + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Razon_de_Incumplimiento.Descripcion LIKE '%" + filter.AdvanceRazon_de_Incumplimiento + "%'";
                        break;
                }
            }
            else if (filter.AdvanceRazon_de_IncumplimientoMultiple != null && filter.AdvanceRazon_de_IncumplimientoMultiple.Count() > 0)
            {
                var Razon_de_IncumplimientoIds = string.Join(",", filter.AdvanceRazon_de_IncumplimientoMultiple);

                where += " AND Acuerdos_MASC.Razon_de_Incumplimiento In (" + Razon_de_IncumplimientoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Revision) || !string.IsNullOrEmpty(filter.ToFecha_de_Revision))
            {
                var Fecha_de_RevisionFrom = DateTime.ParseExact(filter.FromFecha_de_Revision, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_RevisionTo = DateTime.ParseExact(filter.ToFecha_de_Revision, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Revision))
                    where += " AND Acuerdos_MASC.Fecha_de_Revision >= '" + Fecha_de_RevisionFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Revision))
                    where += " AND Acuerdos_MASC.Fecha_de_Revision <= '" + Fecha_de_RevisionTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Revision) || !string.IsNullOrEmpty(filter.ToHora_de_Revision))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Revision))
                    where += " AND Convert(TIME,Acuerdos_MASC.Hora_de_Revision) >='" + filter.FromHora_de_Revision + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Revision))
                    where += " AND Convert(TIME,Acuerdos_MASC.Hora_de_Revision) <='" + filter.ToHora_de_Revision + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceUsuario_que_Revisa))
            {
                switch (filter.Usuario_que_RevisaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_User.Name LIKE '" + filter.AdvanceUsuario_que_Revisa + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceUsuario_que_Revisa + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_User.Name = '" + filter.AdvanceUsuario_que_Revisa + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceUsuario_que_Revisa + "%'";
                        break;
                }
            }
            else if (filter.AdvanceUsuario_que_RevisaMultiple != null && filter.AdvanceUsuario_que_RevisaMultiple.Count() > 0)
            {
                var Usuario_que_RevisaIds = string.Join(",", filter.AdvanceUsuario_que_RevisaMultiple);

                where += " AND Acuerdos_MASC.Usuario_que_Revisa In (" + Usuario_que_RevisaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceResultado))
            {
                switch (filter.ResultadoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Resultado_de_Revision.Descripcion LIKE '" + filter.AdvanceResultado + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Resultado_de_Revision.Descripcion LIKE '%" + filter.AdvanceResultado + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Resultado_de_Revision.Descripcion = '" + filter.AdvanceResultado + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Resultado_de_Revision.Descripcion LIKE '%" + filter.AdvanceResultado + "%'";
                        break;
                }
            }
            else if (filter.AdvanceResultadoMultiple != null && filter.AdvanceResultadoMultiple.Count() > 0)
            {
                var ResultadoIds = string.Join(",", filter.AdvanceResultadoMultiple);

                where += " AND Acuerdos_MASC.Resultado In (" + ResultadoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Motivo_de_Rechazo_de_Acuerdo))
            {
                switch (filter.Motivo_de_Rechazo_de_AcuerdoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Acuerdos_MASC.Motivo_de_Rechazo_de_Acuerdo LIKE '" + filter.Motivo_de_Rechazo_de_Acuerdo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Acuerdos_MASC.Motivo_de_Rechazo_de_Acuerdo LIKE '%" + filter.Motivo_de_Rechazo_de_Acuerdo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Acuerdos_MASC.Motivo_de_Rechazo_de_Acuerdo = '" + filter.Motivo_de_Rechazo_de_Acuerdo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Acuerdos_MASC.Motivo_de_Rechazo_de_Acuerdo LIKE '%" + filter.Motivo_de_Rechazo_de_Acuerdo + "%'";
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
                _IAcuerdos_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

                Acuerdos_MASC varAcuerdos_MASC = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IAcuerdos_MASCApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Acuerdos_MASCModel varAcuerdos_MASC)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IAcuerdos_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);


                    if (varAcuerdos_MASC.AcuerdoRemoveAttachment != 0 && varAcuerdos_MASC.AcuerdoFile == null)
                    {
                        varAcuerdos_MASC.Acuerdo = 0;
                    }

                    if (varAcuerdos_MASC.AcuerdoFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varAcuerdos_MASC.AcuerdoFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varAcuerdos_MASC.Acuerdo = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varAcuerdos_MASC.AcuerdoFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }

                    
                    var result = "";
                    var Acuerdos_MASCInfo = new Acuerdos_MASC
                    {
                        Clave = varAcuerdos_MASC.Clave
                        ,Numero_de_Expediente = varAcuerdos_MASC.Numero_de_Expediente
                        ,Fecha_de_Registro = (!String.IsNullOrEmpty(varAcuerdos_MASC.Fecha_de_Registro)) ? DateTime.ParseExact(varAcuerdos_MASC.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Registro = varAcuerdos_MASC.Hora_de_Registro
                        ,Usuario_que_Registra = varAcuerdos_MASC.Usuario_que_Registra
                        ,Tipo_de_Acuerdo = varAcuerdos_MASC.Tipo_de_Acuerdo
                        ,Forma_de_Cumplimiento = varAcuerdos_MASC.Forma_de_Cumplimiento
                        ,Descripcion_del_Cumplimiento = varAcuerdos_MASC.Descripcion_del_Cumplimiento
                        ,Relacion = varAcuerdos_MASC.Relacion
                        ,Lugar_Acordado = varAcuerdos_MASC.Lugar_Acordado
                        ,Domicilio_Acordado = varAcuerdos_MASC.Domicilio_Acordado
                        ,Hora_de_Acuerdo = varAcuerdos_MASC.Hora_de_Acuerdo
                        ,Fecha_de_Inicio_de_Acuerdo = (!String.IsNullOrEmpty(varAcuerdos_MASC.Fecha_de_Inicio_de_Acuerdo)) ? DateTime.ParseExact(varAcuerdos_MASC.Fecha_de_Inicio_de_Acuerdo, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Monto_Total = varAcuerdos_MASC.Monto_Total
                        ,Parcialidades = varAcuerdos_MASC.Parcialidades
                        ,Periodicidad = varAcuerdos_MASC.Periodicidad
                        ,Monto_de_la_Parcialidad = varAcuerdos_MASC.Monto_de_la_Parcialidad
                        ,Personal_de_Seguimiento_Asignado = varAcuerdos_MASC.Personal_de_Seguimiento_Asignado
                        ,Acuerdo = (varAcuerdos_MASC.Acuerdo.HasValue && varAcuerdos_MASC.Acuerdo != 0) ? ((int?)Convert.ToInt32(varAcuerdos_MASC.Acuerdo.Value)) : null

                        ,Comentarios = varAcuerdos_MASC.Comentarios
                        ,Acuerdo_Cumplido = varAcuerdos_MASC.Acuerdo_Cumplido
                        ,Fecha_de_Cumplimiento_de_Acuerdo = (!String.IsNullOrEmpty(varAcuerdos_MASC.Fecha_de_Cumplimiento_de_Acuerdo)) ? DateTime.ParseExact(varAcuerdos_MASC.Fecha_de_Cumplimiento_de_Acuerdo, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Razon_de_Incumplimiento = varAcuerdos_MASC.Razon_de_Incumplimiento
                        ,Fecha_de_Revision = (!String.IsNullOrEmpty(varAcuerdos_MASC.Fecha_de_Revision)) ? DateTime.ParseExact(varAcuerdos_MASC.Fecha_de_Revision, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Revision = varAcuerdos_MASC.Hora_de_Revision
                        ,Usuario_que_Revisa = varAcuerdos_MASC.Usuario_que_Revisa
                        ,Resultado = varAcuerdos_MASC.Resultado
                        ,Motivo_de_Rechazo_de_Acuerdo = varAcuerdos_MASC.Motivo_de_Rechazo_de_Acuerdo

                    };

                    result = !IsNew ?
                        _IAcuerdos_MASCApiConsumer.Update(Acuerdos_MASCInfo, null, null).Resource.ToString() :
                         _IAcuerdos_MASCApiConsumer.Insert(Acuerdos_MASCInfo, null, null).Resource.ToString();
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
        /// Write Element Array of Acuerdos_MASC script
        /// </summary>
        /// <param name="oAcuerdos_MASCElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Acuerdos_MASCModuleAttributeList)
        {
            for (int i = 0; i < Acuerdos_MASCModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Acuerdos_MASCModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Acuerdos_MASCModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Acuerdos_MASCModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Acuerdos_MASCModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Acuerdos_MASCModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Acuerdos_MASCModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Acuerdos_MASCModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Acuerdos_MASCModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Acuerdos_MASCModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Acuerdos_MASCModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Acuerdos_MASCModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strAcuerdos_MASCScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Acuerdos_MASC.js")))
            {
                strAcuerdos_MASCScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Acuerdos_MASC element attributes
            string userChangeJson = jsSerialize.Serialize(Acuerdos_MASCModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strAcuerdos_MASCScript.IndexOf("inpuElementArray");
            string splittedString = strAcuerdos_MASCScript.Substring(indexOfArray, strAcuerdos_MASCScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Acuerdos_MASCModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Acuerdos_MASCModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strAcuerdos_MASCScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strAcuerdos_MASCScript.Substring(indexOfArrayHistory, strAcuerdos_MASCScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strAcuerdos_MASCScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strAcuerdos_MASCScript.Substring(endIndexOfMainElement + indexOfArray, strAcuerdos_MASCScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Acuerdos_MASCModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Acuerdos_MASCModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Acuerdos_MASC.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Acuerdos_MASC.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Acuerdos_MASC.js")))
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
        public ActionResult Acuerdos_MASCPropertyBag()
        {
            return PartialView("Acuerdos_MASCPropertyBag", "Acuerdos_MASC");
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
                var whereClauseFormat = "Object = 45378 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IAcuerdos_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Acuerdos_MASC.Clave= " + RecordId;
                            var result = _IAcuerdos_MASCApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IAcuerdos_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Acuerdos_MASCPropertyMapper());
			
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
                    (Acuerdos_MASCAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Acuerdos_MASCPropertyMapper oAcuerdos_MASCPropertyMapper = new Acuerdos_MASCPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oAcuerdos_MASCPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IAcuerdos_MASCApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Acuerdos_MASCs == null)
                result.Acuerdos_MASCs = new List<Acuerdos_MASC>();

            var data = result.Acuerdos_MASCs.Select(m => new Acuerdos_MASCGridModel
            {
                Clave = m.Clave
                        ,Numero_de_ExpedienteNumero_de_Folio = CultureHelper.GetTraduction(m.Numero_de_Expediente_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Numero_de_Expediente_Solicitud.Numero_de_Folio
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,Tipo_de_AcuerdoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Acuerdo_Tipo_de_Acuerdo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Acuerdo_Tipo_de_Acuerdo.Descripcion
                        ,Forma_de_CumplimientoDescripcion = CultureHelper.GetTraduction(m.Forma_de_Cumplimiento_Forma_de_Cumplimiento.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Cumplimiento_Forma_de_Cumplimiento.Descripcion
			,Descripcion_del_Cumplimiento = m.Descripcion_del_Cumplimiento
                        ,RelacionDescripcion = CultureHelper.GetTraduction(m.Relacion_Relaciones_MASC.Clave.ToString(), "Relaciones_MASC") ?? (string)m.Relacion_Relaciones_MASC.Descripcion
			,Lugar_Acordado = m.Lugar_Acordado
			,Domicilio_Acordado = m.Domicilio_Acordado
			,Hora_de_Acuerdo = m.Hora_de_Acuerdo
                        ,Fecha_de_Inicio_de_Acuerdo = (m.Fecha_de_Inicio_de_Acuerdo == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Inicio_de_Acuerdo).ToString(ConfigurationProperty.DateFormat))
			,Monto_Total = m.Monto_Total
			,Parcialidades = m.Parcialidades
                        ,PeriodicidadDescripcion = CultureHelper.GetTraduction(m.Periodicidad_Periodicidad.Clave.ToString(), "Descripcion") ?? (string)m.Periodicidad_Periodicidad.Descripcion
			,Monto_de_la_Parcialidad = m.Monto_de_la_Parcialidad
                        ,Personal_de_Seguimiento_AsignadoName = CultureHelper.GetTraduction(m.Personal_de_Seguimiento_Asignado_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Personal_de_Seguimiento_Asignado_Spartan_User.Name
			,Acuerdo = m.Acuerdo
			,Comentarios = m.Comentarios
                        ,Acuerdo_CumplidoDescripcion = CultureHelper.GetTraduction(m.Acuerdo_Cumplido_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Acuerdo_Cumplido_A_Tiempo.Descripcion
                        ,Fecha_de_Cumplimiento_de_Acuerdo = (m.Fecha_de_Cumplimiento_de_Acuerdo == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Cumplimiento_de_Acuerdo).ToString(ConfigurationProperty.DateFormat))
                        ,Razon_de_IncumplimientoDescripcion = CultureHelper.GetTraduction(m.Razon_de_Incumplimiento_Razon_de_Incumplimiento.Clave.ToString(), "Descripcion") ?? (string)m.Razon_de_Incumplimiento_Razon_de_Incumplimiento.Descripcion
                        ,Fecha_de_Revision = (m.Fecha_de_Revision == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Revision).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Revision = m.Hora_de_Revision
                        ,Usuario_que_RevisaName = CultureHelper.GetTraduction(m.Usuario_que_Revisa_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Revisa_Spartan_User.Name
                        ,ResultadoDescripcion = CultureHelper.GetTraduction(m.Resultado_Resultado_de_Revision.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_Resultado_de_Revision.Descripcion
			,Motivo_de_Rechazo_de_Acuerdo = m.Motivo_de_Rechazo_de_Acuerdo

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45378, arrayColumnsVisible), "Acuerdos_MASCList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45378, arrayColumnsVisible), "Acuerdos_MASCList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45378, arrayColumnsVisible), "Acuerdos_MASCList_" + DateTime.Now.ToString());
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

            _IAcuerdos_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Acuerdos_MASCPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Acuerdos_MASCAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Acuerdos_MASCPropertyMapper oAcuerdos_MASCPropertyMapper = new Acuerdos_MASCPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oAcuerdos_MASCPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IAcuerdos_MASCApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Acuerdos_MASCs == null)
                result.Acuerdos_MASCs = new List<Acuerdos_MASC>();

            var data = result.Acuerdos_MASCs.Select(m => new Acuerdos_MASCGridModel
            {
                Clave = m.Clave
                        ,Numero_de_ExpedienteNumero_de_Folio = CultureHelper.GetTraduction(m.Numero_de_Expediente_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Numero_de_Expediente_Solicitud.Numero_de_Folio
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,Tipo_de_AcuerdoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Acuerdo_Tipo_de_Acuerdo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Acuerdo_Tipo_de_Acuerdo.Descripcion
                        ,Forma_de_CumplimientoDescripcion = CultureHelper.GetTraduction(m.Forma_de_Cumplimiento_Forma_de_Cumplimiento.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Cumplimiento_Forma_de_Cumplimiento.Descripcion
			,Descripcion_del_Cumplimiento = m.Descripcion_del_Cumplimiento
                        ,RelacionDescripcion = CultureHelper.GetTraduction(m.Relacion_Relaciones_MASC.Clave.ToString(), "Relaciones_MASC") ?? (string)m.Relacion_Relaciones_MASC.Descripcion
			,Lugar_Acordado = m.Lugar_Acordado
			,Domicilio_Acordado = m.Domicilio_Acordado
			,Hora_de_Acuerdo = m.Hora_de_Acuerdo
                        ,Fecha_de_Inicio_de_Acuerdo = (m.Fecha_de_Inicio_de_Acuerdo == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Inicio_de_Acuerdo).ToString(ConfigurationProperty.DateFormat))
			,Monto_Total = m.Monto_Total
			,Parcialidades = m.Parcialidades
                        ,PeriodicidadDescripcion = CultureHelper.GetTraduction(m.Periodicidad_Periodicidad.Clave.ToString(), "Descripcion") ?? (string)m.Periodicidad_Periodicidad.Descripcion
			,Monto_de_la_Parcialidad = m.Monto_de_la_Parcialidad
                        ,Personal_de_Seguimiento_AsignadoName = CultureHelper.GetTraduction(m.Personal_de_Seguimiento_Asignado_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Personal_de_Seguimiento_Asignado_Spartan_User.Name
			,Acuerdo = m.Acuerdo
			,Comentarios = m.Comentarios
                        ,Acuerdo_CumplidoDescripcion = CultureHelper.GetTraduction(m.Acuerdo_Cumplido_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Acuerdo_Cumplido_A_Tiempo.Descripcion
                        ,Fecha_de_Cumplimiento_de_Acuerdo = (m.Fecha_de_Cumplimiento_de_Acuerdo == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Cumplimiento_de_Acuerdo).ToString(ConfigurationProperty.DateFormat))
                        ,Razon_de_IncumplimientoDescripcion = CultureHelper.GetTraduction(m.Razon_de_Incumplimiento_Razon_de_Incumplimiento.Clave.ToString(), "Descripcion") ?? (string)m.Razon_de_Incumplimiento_Razon_de_Incumplimiento.Descripcion
                        ,Fecha_de_Revision = (m.Fecha_de_Revision == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Revision).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Revision = m.Hora_de_Revision
                        ,Usuario_que_RevisaName = CultureHelper.GetTraduction(m.Usuario_que_Revisa_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Revisa_Spartan_User.Name
                        ,ResultadoDescripcion = CultureHelper.GetTraduction(m.Resultado_Resultado_de_Revision.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_Resultado_de_Revision.Descripcion
			,Motivo_de_Rechazo_de_Acuerdo = m.Motivo_de_Rechazo_de_Acuerdo

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
                _IAcuerdos_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IAcuerdos_MASCApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Acuerdos_MASC_Datos_GeneralesModel varAcuerdos_MASC)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IAcuerdos_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
				                    if (varAcuerdos_MASC.AcuerdoRemoveAttachment != 0 && varAcuerdos_MASC.AcuerdoFile == null)
                    {
                        varAcuerdos_MASC.Acuerdo = 0;
                    }

                    if (varAcuerdos_MASC.AcuerdoFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varAcuerdos_MASC.AcuerdoFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varAcuerdos_MASC.Acuerdo = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varAcuerdos_MASC.AcuerdoFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }

                var result = "";
                var Acuerdos_MASC_Datos_GeneralesInfo = new Acuerdos_MASC_Datos_Generales
                {
                    Clave = varAcuerdos_MASC.Clave
                                            ,Numero_de_Expediente = varAcuerdos_MASC.Numero_de_Expediente
                        ,Fecha_de_Registro = (!String.IsNullOrEmpty(varAcuerdos_MASC.Fecha_de_Registro)) ? DateTime.ParseExact(varAcuerdos_MASC.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Registro = varAcuerdos_MASC.Hora_de_Registro
                        ,Usuario_que_Registra = varAcuerdos_MASC.Usuario_que_Registra
                        ,Tipo_de_Acuerdo = varAcuerdos_MASC.Tipo_de_Acuerdo
                        ,Forma_de_Cumplimiento = varAcuerdos_MASC.Forma_de_Cumplimiento
                        ,Descripcion_del_Cumplimiento = varAcuerdos_MASC.Descripcion_del_Cumplimiento
                        ,Relacion = varAcuerdos_MASC.Relacion
                        ,Lugar_Acordado = varAcuerdos_MASC.Lugar_Acordado
                        ,Domicilio_Acordado = varAcuerdos_MASC.Domicilio_Acordado
                        ,Hora_de_Acuerdo = varAcuerdos_MASC.Hora_de_Acuerdo
                        ,Fecha_de_Inicio_de_Acuerdo = (!String.IsNullOrEmpty(varAcuerdos_MASC.Fecha_de_Inicio_de_Acuerdo)) ? DateTime.ParseExact(varAcuerdos_MASC.Fecha_de_Inicio_de_Acuerdo, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Monto_Total = varAcuerdos_MASC.Monto_Total
                        ,Parcialidades = varAcuerdos_MASC.Parcialidades
                        ,Periodicidad = varAcuerdos_MASC.Periodicidad
                        ,Monto_de_la_Parcialidad = varAcuerdos_MASC.Monto_de_la_Parcialidad
                        ,Personal_de_Seguimiento_Asignado = varAcuerdos_MASC.Personal_de_Seguimiento_Asignado
                        ,Acuerdo = (varAcuerdos_MASC.Acuerdo.HasValue && varAcuerdos_MASC.Acuerdo != 0) ? ((int?)Convert.ToInt32(varAcuerdos_MASC.Acuerdo.Value)) : null

                        ,Comentarios = varAcuerdos_MASC.Comentarios
                        ,Acuerdo_Cumplido = varAcuerdos_MASC.Acuerdo_Cumplido
                        ,Fecha_de_Cumplimiento_de_Acuerdo = (!String.IsNullOrEmpty(varAcuerdos_MASC.Fecha_de_Cumplimiento_de_Acuerdo)) ? DateTime.ParseExact(varAcuerdos_MASC.Fecha_de_Cumplimiento_de_Acuerdo, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Razon_de_Incumplimiento = varAcuerdos_MASC.Razon_de_Incumplimiento
                    
                };

                result = _IAcuerdos_MASCApiConsumer.Update_Datos_Generales(Acuerdos_MASC_Datos_GeneralesInfo).Resource.ToString();
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
                _IAcuerdos_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IAcuerdos_MASCApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Acuerdos_MASC_Datos_GeneralesModel
                {
                    Clave = m.Clave
                        ,Numero_de_Expediente = m.Numero_de_Expediente
                        ,Numero_de_ExpedienteNumero_de_Folio = CultureHelper.GetTraduction(m.Numero_de_Expediente_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Numero_de_Expediente_Solicitud.Numero_de_Folio
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_Registra = m.Usuario_que_Registra
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,Tipo_de_Acuerdo = m.Tipo_de_Acuerdo
                        ,Tipo_de_AcuerdoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Acuerdo_Tipo_de_Acuerdo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Acuerdo_Tipo_de_Acuerdo.Descripcion
                        ,Forma_de_Cumplimiento = m.Forma_de_Cumplimiento
                        ,Forma_de_CumplimientoDescripcion = CultureHelper.GetTraduction(m.Forma_de_Cumplimiento_Forma_de_Cumplimiento.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Cumplimiento_Forma_de_Cumplimiento.Descripcion
			,Descripcion_del_Cumplimiento = m.Descripcion_del_Cumplimiento
                        ,Relacion = m.Relacion
                        ,RelacionDescripcion = CultureHelper.GetTraduction(m.Relacion_Relaciones_MASC.Clave.ToString(), "Relaciones_MASC") ?? (string)m.Relacion_Relaciones_MASC.Descripcion
			,Lugar_Acordado = m.Lugar_Acordado
			,Domicilio_Acordado = m.Domicilio_Acordado
			,Hora_de_Acuerdo = m.Hora_de_Acuerdo
                        ,Fecha_de_Inicio_de_Acuerdo = (m.Fecha_de_Inicio_de_Acuerdo == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Inicio_de_Acuerdo).ToString(ConfigurationProperty.DateFormat))
			,Monto_Total = m.Monto_Total
			,Parcialidades = m.Parcialidades
                        ,Periodicidad = m.Periodicidad
                        ,PeriodicidadDescripcion = CultureHelper.GetTraduction(m.Periodicidad_Periodicidad.Clave.ToString(), "Descripcion") ?? (string)m.Periodicidad_Periodicidad.Descripcion
			,Monto_de_la_Parcialidad = m.Monto_de_la_Parcialidad
                        ,Personal_de_Seguimiento_Asignado = m.Personal_de_Seguimiento_Asignado
                        ,Personal_de_Seguimiento_AsignadoName = CultureHelper.GetTraduction(m.Personal_de_Seguimiento_Asignado_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Personal_de_Seguimiento_Asignado_Spartan_User.Name
			,Acuerdo = m.Acuerdo
			,Comentarios = m.Comentarios
                        ,Acuerdo_Cumplido = m.Acuerdo_Cumplido
                        ,Acuerdo_CumplidoDescripcion = CultureHelper.GetTraduction(m.Acuerdo_Cumplido_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Acuerdo_Cumplido_A_Tiempo.Descripcion
                        ,Fecha_de_Cumplimiento_de_Acuerdo = (m.Fecha_de_Cumplimiento_de_Acuerdo == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Cumplimiento_de_Acuerdo).ToString(ConfigurationProperty.DateFormat))
                        ,Razon_de_Incumplimiento = m.Razon_de_Incumplimiento
                        ,Razon_de_IncumplimientoDescripcion = CultureHelper.GetTraduction(m.Razon_de_Incumplimiento_Razon_de_Incumplimiento.Clave.ToString(), "Descripcion") ?? (string)m.Razon_de_Incumplimiento_Razon_de_Incumplimiento.Descripcion

                    
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
        public ActionResult Post_Autorizacion(Acuerdos_MASC_AutorizacionModel varAcuerdos_MASC)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IAcuerdos_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Acuerdos_MASC_AutorizacionInfo = new Acuerdos_MASC_Autorizacion
                {
                    Clave = varAcuerdos_MASC.Clave
                                            ,Fecha_de_Revision = (!String.IsNullOrEmpty(varAcuerdos_MASC.Fecha_de_Revision)) ? DateTime.ParseExact(varAcuerdos_MASC.Fecha_de_Revision, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Revision = varAcuerdos_MASC.Hora_de_Revision
                        ,Usuario_que_Revisa = varAcuerdos_MASC.Usuario_que_Revisa
                        ,Resultado = varAcuerdos_MASC.Resultado
                        ,Motivo_de_Rechazo_de_Acuerdo = varAcuerdos_MASC.Motivo_de_Rechazo_de_Acuerdo
                    
                };

                result = _IAcuerdos_MASCApiConsumer.Update_Autorizacion(Acuerdos_MASC_AutorizacionInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Autorizacion(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IAcuerdos_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IAcuerdos_MASCApiConsumer.Get_Autorizacion(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Acuerdos_MASC_AutorizacionModel
                {
                    Clave = m.Clave
                        ,Fecha_de_Revision = (m.Fecha_de_Revision == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Revision).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Revision = m.Hora_de_Revision
                        ,Usuario_que_Revisa = m.Usuario_que_Revisa
                        ,Usuario_que_RevisaName = CultureHelper.GetTraduction(m.Usuario_que_Revisa_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Revisa_Spartan_User.Name
                        ,Resultado = m.Resultado
                        ,ResultadoDescripcion = CultureHelper.GetTraduction(m.Resultado_Resultado_de_Revision.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_Resultado_de_Revision.Descripcion
			,Motivo_de_Rechazo_de_Acuerdo = m.Motivo_de_Rechazo_de_Acuerdo

                    
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

