using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Solicitud;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Unidad;
using Spartane.Core.Domain.Modulo_Atencion_Inicial;
using Spartane.Core.Domain.expediente_ministerio_publico;
using Spartane.Core.Domain.Resolucion_MP;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Region;
using Spartane.Core.Domain.Estatus_Solicitud;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Unidad;
using Spartane.Core.Domain.Lugar_Tipo;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Motivo_de_Rechazo_de_Solicitud;
using Spartane.Core.Domain.A_Tiempo;
using Spartane.Core.Domain.Razon_de_Incumplimiento;
using Spartane.Core.Domain.Tipo_de_Conclusion_Anticipada;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Resultado_de_Revision;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Tipo_de_Mecanismo_Alterno;
using Spartane.Core.Domain.Detalle_Solicitud_Historial_de_Asignaciones;



using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Spartan_User;


using Spartane.Core.Domain.Detalle_de_Solicitud_Bitacora_de_Coincid;





using Spartane.Core.Domain.Tipo_de_Acuerdo;

using Spartane.Core.Domain.Razon_de_Incumplimiento;


using Spartane.Core.Domain.Detalle_Historico_JA;



using Spartane.Core.Domain.Spartan_User;



using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Solicitud;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Solicitud;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Unidad;
using Spartane.Web.Areas.WebApiConsumer.Modulo_Atencion_Inicial;
using Spartane.Web.Areas.WebApiConsumer.expediente_ministerio_publico;
using Spartane.Web.Areas.WebApiConsumer.Resolucion_MP;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Region;
using Spartane.Web.Areas.WebApiConsumer.Estatus_Solicitud;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Unidad;
using Spartane.Web.Areas.WebApiConsumer.Lugar_Tipo;
using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Motivo_de_Rechazo_de_Solicitud;
using Spartane.Web.Areas.WebApiConsumer.A_Tiempo;
using Spartane.Web.Areas.WebApiConsumer.Razon_de_Incumplimiento;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Conclusion_Anticipada;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Resultado_de_Revision;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Mecanismo_Alterno;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Solicitud_Historial_de_Asignaciones;



using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;

using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Solicitud_Bitacora_de_Coincid;

using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Acuerdo;

using Spartane.Web.Areas.WebApiConsumer.Razon_de_Incumplimiento;

using Spartane.Web.Areas.WebApiConsumer.Detalle_Historico_JA;



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
    public class SolicitudController : Controller
    {
        #region "variable declaration"

        private ISolicitudService service = null;
        private ISolicitudApiConsumer _ISolicitudApiConsumer;
        private ISpartan_UserApiConsumer _ISpartan_UserApiConsumer;
        private IUnidadApiConsumer _IUnidadApiConsumer;
        private IModulo_Atencion_InicialApiConsumer _IModulo_Atencion_InicialApiConsumer;
        private Iexpediente_ministerio_publicoApiConsumer _Iexpediente_ministerio_publicoApiConsumer;
        private IResolucion_MPApiConsumer _IResolucion_MPApiConsumer;
        private IMunicipioApiConsumer _IMunicipioApiConsumer;
        private IRegionApiConsumer _IRegionApiConsumer;
        private IEstatus_SolicitudApiConsumer _IEstatus_SolicitudApiConsumer;
        private ILugar_TipoApiConsumer _ILugar_TipoApiConsumer;
        private IPaisApiConsumer _IPaisApiConsumer;
        private IEstadoApiConsumer _IEstadoApiConsumer;
        private IColoniaApiConsumer _IColoniaApiConsumer;
        private IMotivo_de_Rechazo_de_SolicitudApiConsumer _IMotivo_de_Rechazo_de_SolicitudApiConsumer;
        private IA_TiempoApiConsumer _IA_TiempoApiConsumer;
        private IRazon_de_IncumplimientoApiConsumer _IRazon_de_IncumplimientoApiConsumer;
        private ITipo_de_Conclusion_AnticipadaApiConsumer _ITipo_de_Conclusion_AnticipadaApiConsumer;
        private IResultado_de_RevisionApiConsumer _IResultado_de_RevisionApiConsumer;
        private ITipo_de_Mecanismo_AlternoApiConsumer _ITipo_de_Mecanismo_AlternoApiConsumer;
        private IDetalle_Solicitud_Historial_de_AsignacionesApiConsumer _IDetalle_Solicitud_Historial_de_AsignacionesApiConsumer;




        private IDetalle_de_Solicitud_Bitacora_de_CoincidApiConsumer _IDetalle_de_Solicitud_Bitacora_de_CoincidApiConsumer;

        private ITipo_de_AcuerdoApiConsumer _ITipo_de_AcuerdoApiConsumer;


        private IDetalle_Historico_JAApiConsumer _IDetalle_Historico_JAApiConsumer;





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

        
        public SolicitudController(ISolicitudService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, ISolicitudApiConsumer SolicitudApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , ISpartan_UserApiConsumer Spartan_UserApiConsumer , IUnidadApiConsumer UnidadApiConsumer , IModulo_Atencion_InicialApiConsumer Modulo_Atencion_InicialApiConsumer , Iexpediente_ministerio_publicoApiConsumer expediente_ministerio_publicoApiConsumer , IResolucion_MPApiConsumer Resolucion_MPApiConsumer , IMunicipioApiConsumer MunicipioApiConsumer , IRegionApiConsumer RegionApiConsumer , IEstatus_SolicitudApiConsumer Estatus_SolicitudApiConsumer , ILugar_TipoApiConsumer Lugar_TipoApiConsumer , IPaisApiConsumer PaisApiConsumer , IEstadoApiConsumer EstadoApiConsumer , IColoniaApiConsumer ColoniaApiConsumer , IMotivo_de_Rechazo_de_SolicitudApiConsumer Motivo_de_Rechazo_de_SolicitudApiConsumer , IA_TiempoApiConsumer A_TiempoApiConsumer , IRazon_de_IncumplimientoApiConsumer Razon_de_IncumplimientoApiConsumer , ITipo_de_Conclusion_AnticipadaApiConsumer Tipo_de_Conclusion_AnticipadaApiConsumer , IResultado_de_RevisionApiConsumer Resultado_de_RevisionApiConsumer , ITipo_de_Mecanismo_AlternoApiConsumer Tipo_de_Mecanismo_AlternoApiConsumer , IDetalle_Solicitud_Historial_de_AsignacionesApiConsumer Detalle_Solicitud_Historial_de_AsignacionesApiConsumer  , IDetalle_de_Solicitud_Bitacora_de_CoincidApiConsumer Detalle_de_Solicitud_Bitacora_de_CoincidApiConsumer , ITipo_de_AcuerdoApiConsumer Tipo_de_AcuerdoApiConsumer  , IDetalle_Historico_JAApiConsumer Detalle_Historico_JAApiConsumer  )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._ISolicitudApiConsumer = SolicitudApiConsumer;
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
            this._IUnidadApiConsumer = UnidadApiConsumer;
            this._IModulo_Atencion_InicialApiConsumer = Modulo_Atencion_InicialApiConsumer;
            this._Iexpediente_ministerio_publicoApiConsumer = expediente_ministerio_publicoApiConsumer;
            this._IResolucion_MPApiConsumer = Resolucion_MPApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IRegionApiConsumer = RegionApiConsumer;
            this._IEstatus_SolicitudApiConsumer = Estatus_SolicitudApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._IUnidadApiConsumer = UnidadApiConsumer;
            this._ILugar_TipoApiConsumer = Lugar_TipoApiConsumer;
            this._IPaisApiConsumer = PaisApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._IMotivo_de_Rechazo_de_SolicitudApiConsumer = Motivo_de_Rechazo_de_SolicitudApiConsumer;
            this._IA_TiempoApiConsumer = A_TiempoApiConsumer;
            this._IRazon_de_IncumplimientoApiConsumer = Razon_de_IncumplimientoApiConsumer;
            this._ITipo_de_Conclusion_AnticipadaApiConsumer = Tipo_de_Conclusion_AnticipadaApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._IResultado_de_RevisionApiConsumer = Resultado_de_RevisionApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._ITipo_de_Mecanismo_AlternoApiConsumer = Tipo_de_Mecanismo_AlternoApiConsumer;
            this._IDetalle_Solicitud_Historial_de_AsignacionesApiConsumer = Detalle_Solicitud_Historial_de_AsignacionesApiConsumer;



            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;

            this._IDetalle_de_Solicitud_Bitacora_de_CoincidApiConsumer = Detalle_de_Solicitud_Bitacora_de_CoincidApiConsumer;

            this._ITipo_de_AcuerdoApiConsumer = Tipo_de_AcuerdoApiConsumer;

            this._IRazon_de_IncumplimientoApiConsumer = Razon_de_IncumplimientoApiConsumer;

            this._IDetalle_Historico_JAApiConsumer = Detalle_Historico_JAApiConsumer;



            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;


        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Solicitud
        [ObjectAuth(ObjectId = (ModuleObjectId)45010, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45010, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Solicitud/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45010, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45010, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varSolicitud = new SolicitudModel();
			varSolicitud.Clave = Id;
			
            ViewBag.ObjectId = "45010";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;

            var permissionDetalle_Solicitud_Historial_de_Asignaciones = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45392, ModuleId);
            ViewBag.PermissionDetalle_Solicitud_Historial_de_Asignaciones = permissionDetalle_Solicitud_Historial_de_Asignaciones;
            var permissionDetalle_de_Solicitud_Bitacora_de_Coincid = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45126, ModuleId);
            ViewBag.PermissionDetalle_de_Solicitud_Bitacora_de_Coincid = permissionDetalle_de_Solicitud_Bitacora_de_Coincid;
            var permissionDetalle_Historico_JA = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45190, ModuleId);
            ViewBag.PermissionDetalle_Historico_JA = permissionDetalle_Historico_JA;


            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _ISolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
                var SolicitudsData = _ISolicitudApiConsumer.ListaSelAll(0, 1000, "Solicitud.Clave=" + Id, "").Resource.Solicituds;
				
				if (SolicitudsData != null && SolicitudsData.Count > 0)
                {
					var SolicitudData = SolicitudsData.First();
					varSolicitud= new SolicitudModel
					{
						Clave  = SolicitudData.Clave 
	                    ,Fecha_de_Registro = (SolicitudData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(SolicitudData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,Usuario_que_Registra = SolicitudData.Usuario_que_Registra
                    ,Usuario_que_RegistraName = CultureHelper.GetTraduction(Convert.ToString(SolicitudData.Usuario_que_Registra), "Spartan_User") ??  (string)SolicitudData.Usuario_que_Registra_Spartan_User.Name
                    ,Numero_de_Folio = SolicitudData.Numero_de_Folio
                    ,Unidad_MASC = SolicitudData.Unidad_MASC
                    ,Unidad_MASCDescripcion = CultureHelper.GetTraduction(Convert.ToString(SolicitudData.Unidad_MASC), "Unidad") ??  (string)SolicitudData.Unidad_MASC_Unidad.Descripcion
                    ,Remitente = SolicitudData.Remitente
                    ,NUAT = SolicitudData.NUAT
                    ,NUATNUAT = CultureHelper.GetTraduction(Convert.ToString(SolicitudData.NUAT), "Modulo_Atencion_Inicial") ??  (string)SolicitudData.NUAT_Modulo_Atencion_Inicial.NUAT
                    ,NUAT_Codigo = SolicitudData.NUAT_Codigo
                    ,Expediente_MPI = SolicitudData.Expediente_MPI
                    ,Expediente_MPInic = CultureHelper.GetTraduction(Convert.ToString(SolicitudData.Expediente_MPI), "expediente_ministerio_publico") ??  (string)SolicitudData.Expediente_MPI_expediente_ministerio_publico.nic
                    ,Expediente_CausaPenal = SolicitudData.Expediente_CausaPenal
                    ,Expediente_CausaPenalObservaciones = CultureHelper.GetTraduction(Convert.ToString(SolicitudData.Expediente_CausaPenal), "Resolucion_MP") ??  (string)SolicitudData.Expediente_CausaPenal_Resolucion_MP.Observaciones
                    ,Municipio = SolicitudData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(SolicitudData.Municipio), "Municipio") ??  (string)SolicitudData.Municipio_Municipio.Nombre
                    ,Region = SolicitudData.Region
                    ,RegionDescripcion = CultureHelper.GetTraduction(Convert.ToString(SolicitudData.Region), "Region") ??  (string)SolicitudData.Region_Region.Descripcion
                    ,NUC = SolicitudData.NUC
                    ,CDI = SolicitudData.CDI
                    ,Causa_Penal = SolicitudData.Causa_Penal
                    ,Numero_de_Expediente = SolicitudData.Numero_de_Expediente
                    ,Estatus = SolicitudData.Estatus
                    ,EstatusDescripcion = CultureHelper.GetTraduction(Convert.ToString(SolicitudData.Estatus), "Estatus_Solicitud") ??  (string)SolicitudData.Estatus_Estatus_Solicitud.Descripcion
                    ,Fecha_en_que_llega_a_Coordinador = (SolicitudData.Fecha_en_que_llega_a_Coordinador == null ? string.Empty : Convert.ToDateTime(SolicitudData.Fecha_en_que_llega_a_Coordinador).ToString(ConfigurationProperty.DateFormat))
                    ,Fecha_en_que_llega_a_Especialista = (SolicitudData.Fecha_en_que_llega_a_Especialista == null ? string.Empty : Convert.ToDateTime(SolicitudData.Fecha_en_que_llega_a_Especialista).ToString(ConfigurationProperty.DateFormat))
                    ,Agente_del_Ministerio_Publico_Orientador = SolicitudData.Agente_del_Ministerio_Publico_Orientador
                    ,Agente_del_Ministerio_Publico_OrientadorName = CultureHelper.GetTraduction(Convert.ToString(SolicitudData.Agente_del_Ministerio_Publico_Orientador), "Spartan_User") ??  (string)SolicitudData.Agente_del_Ministerio_Publico_Orientador_Spartan_User.Name
                    ,Agente_del_Ministerio_Publico_Invest = SolicitudData.Agente_del_Ministerio_Publico_Invest
                    ,Agente_del_Ministerio_Publico_InvestName = CultureHelper.GetTraduction(Convert.ToString(SolicitudData.Agente_del_Ministerio_Publico_Invest), "Spartan_User") ??  (string)SolicitudData.Agente_del_Ministerio_Publico_Invest_Spartan_User.Name
                    ,Juez_de_Control = SolicitudData.Juez_de_Control
                    ,Unidad = SolicitudData.Unidad
                    ,UnidadDescripcion = CultureHelper.GetTraduction(Convert.ToString(SolicitudData.Unidad), "Unidad") ??  (string)SolicitudData.Unidad_Unidad.Descripcion
                    ,Titulo_del_Hecho = SolicitudData.Titulo_del_Hecho
                    ,Fecha_del_Hecho = (SolicitudData.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(SolicitudData.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
                    ,Narrativa_Breve_de_los_Hechos = SolicitudData.Narrativa_Breve_de_los_Hechos
                    ,Hora_Aproximada_del_Hecho = SolicitudData.Hora_Aproximada_del_Hecho
                    ,Tipo_de_Lugar_del_Hecho = SolicitudData.Tipo_de_Lugar_del_Hecho
                    ,Tipo_de_Lugar_del_HechoDescripcion = CultureHelper.GetTraduction(Convert.ToString(SolicitudData.Tipo_de_Lugar_del_Hecho), "Lugar_Tipo") ??  (string)SolicitudData.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Descripcion
                    ,PaisH = SolicitudData.PaisH
                    ,PaisHNombre = CultureHelper.GetTraduction(Convert.ToString(SolicitudData.PaisH), "Pais") ??  (string)SolicitudData.PaisH_Pais.Nombre
                    ,EstadoH = SolicitudData.EstadoH
                    ,EstadoHNombre = CultureHelper.GetTraduction(Convert.ToString(SolicitudData.EstadoH), "Estado") ??  (string)SolicitudData.EstadoH_Estado.Nombre
                    ,MunicipioH = SolicitudData.MunicipioH
                    ,MunicipioHNombre = CultureHelper.GetTraduction(Convert.ToString(SolicitudData.MunicipioH), "Municipio") ??  (string)SolicitudData.MunicipioH_Municipio.Nombre
                    ,Poblacion = SolicitudData.Poblacion
                    ,PoblacionNombre = CultureHelper.GetTraduction(Convert.ToString(SolicitudData.Poblacion), "Colonia") ??  (string)SolicitudData.Poblacion_Colonia.Nombre
                    ,ColoniaH = SolicitudData.ColoniaH
                    ,ColoniaHNombre = CultureHelper.GetTraduction(Convert.ToString(SolicitudData.ColoniaH), "Colonia") ??  (string)SolicitudData.ColoniaH_Colonia.Nombre
                    ,CalleH = SolicitudData.CalleH
                    ,Numero_InteriorH = SolicitudData.Numero_InteriorH
                    ,Numero_ExteriorH = SolicitudData.Numero_ExteriorH
                    ,Codigo_PostalH = SolicitudData.Codigo_PostalH
                    ,Entre_Calle = SolicitudData.Entre_Calle
                    ,y_Calle = SolicitudData.y_Calle
                    ,LongitudH = SolicitudData.LongitudH
                    ,LatitudH = SolicitudData.LatitudH
                    ,Rechazar = SolicitudData.Rechazar.GetValueOrDefault()
                    ,Motivo_de_Rechazo = SolicitudData.Motivo_de_Rechazo
                    ,Motivo_de_RechazoDescripcion = CultureHelper.GetTraduction(Convert.ToString(SolicitudData.Motivo_de_Rechazo), "Motivo_de_Rechazo_de_Solicitud") ??  (string)SolicitudData.Motivo_de_Rechazo_Motivo_de_Rechazo_de_Solicitud.Descripcion
                    ,Acuerdo_Cumplido = SolicitudData.Acuerdo_Cumplido
                    ,Acuerdo_CumplidoDescripcion = CultureHelper.GetTraduction(Convert.ToString(SolicitudData.Acuerdo_Cumplido), "A_Tiempo") ??  (string)SolicitudData.Acuerdo_Cumplido_A_Tiempo.Descripcion
                    ,Razon_de_Incumplimiento = SolicitudData.Razon_de_Incumplimiento
                    ,Razon_de_IncumplimientoDescripcion = CultureHelper.GetTraduction(Convert.ToString(SolicitudData.Razon_de_Incumplimiento), "Razon_de_Incumplimiento") ??  (string)SolicitudData.Razon_de_Incumplimiento_Razon_de_Incumplimiento.Descripcion
                    ,Tipo_de_Conclusion_Anticipada = SolicitudData.Tipo_de_Conclusion_Anticipada
                    ,Tipo_de_Conclusion_AnticipadaDescripcion = CultureHelper.GetTraduction(Convert.ToString(SolicitudData.Tipo_de_Conclusion_Anticipada), "Tipo_de_Conclusion_Anticipada") ??  (string)SolicitudData.Tipo_de_Conclusion_Anticipada_Tipo_de_Conclusion_Anticipada.Descripcion
                    ,Fecha_de_Cierre = (SolicitudData.Fecha_de_Cierre == null ? string.Empty : Convert.ToDateTime(SolicitudData.Fecha_de_Cierre).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Cierre = SolicitudData.Hora_de_Cierre
                    ,Fecha_Validacion = (SolicitudData.Fecha_Validacion == null ? string.Empty : Convert.ToDateTime(SolicitudData.Fecha_Validacion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_Validacion = SolicitudData.Hora_Validacion
                    ,Usuario_que_Valida = SolicitudData.Usuario_que_Valida
                    ,Usuario_que_ValidaName = CultureHelper.GetTraduction(Convert.ToString(SolicitudData.Usuario_que_Valida), "Spartan_User") ??  (string)SolicitudData.Usuario_que_Valida_Spartan_User.Name
                    ,Resultado = SolicitudData.Resultado
                    ,ResultadoDescripcion = CultureHelper.GetTraduction(Convert.ToString(SolicitudData.Resultado), "Resultado_de_Revision") ??  (string)SolicitudData.Resultado_Resultado_de_Revision.Descripcion
                    ,Motivo_de_Rechazo_Solicitud = SolicitudData.Motivo_de_Rechazo_Solicitud
                    ,Especialista_AsignadoA = SolicitudData.Especialista_AsignadoA
                    ,Especialista_AsignadoAName = CultureHelper.GetTraduction(Convert.ToString(SolicitudData.Especialista_AsignadoA), "Spartan_User") ??  (string)SolicitudData.Especialista_AsignadoA_Spartan_User.Name
                    ,Motivo_cambio_facilitador = SolicitudData.Motivo_cambio_facilitador
                    ,Asignar_Especialista_Automatico = SolicitudData.Asignar_Especialista_Automatico.GetValueOrDefault()
                    ,Razone = SolicitudData.Razone
                    ,Tipo_de_Mecanismo = SolicitudData.Tipo_de_Mecanismo
                    ,Tipo_de_MecanismoDescripcion = CultureHelper.GetTraduction(Convert.ToString(SolicitudData.Tipo_de_Mecanismo), "Tipo_de_Mecanismo_Alterno") ??  (string)SolicitudData.Tipo_de_Mecanismo_Tipo_de_Mecanismo_Alterno.Descripcion
                    ,Fecha_de_AsignacionA = (SolicitudData.Fecha_de_AsignacionA == null ? string.Empty : Convert.ToDateTime(SolicitudData.Fecha_de_AsignacionA).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_AsignacionA = SolicitudData.Hora_de_AsignacionA
                    ,Fecha_de_Atencion_del_Especialista = (SolicitudData.Fecha_de_Atencion_del_Especialista == null ? string.Empty : Convert.ToDateTime(SolicitudData.Fecha_de_Atencion_del_Especialista).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Atencion_del_Especialista = SolicitudData.Hora_de_Atencion_del_Especialista

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IUnidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Unidads_Unidad_MASC = _IUnidadApiConsumer.SelAll(true);
            if (Unidads_Unidad_MASC != null && Unidads_Unidad_MASC.Resource != null)
                ViewBag.Unidads_Unidad_MASC = Unidads_Unidad_MASC.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Unidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IRegionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Regions_Region = _IRegionApiConsumer.SelAll(true);
            if (Regions_Region != null && Regions_Region.Resource != null)
                ViewBag.Regions_Region = Regions_Region.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Region", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatus_SolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_Solicituds_Estatus = _IEstatus_SolicitudApiConsumer.SelAll(true);
            if (Estatus_Solicituds_Estatus != null && Estatus_Solicituds_Estatus.Resource != null)
                ViewBag.Estatus_Solicituds_Estatus = Estatus_Solicituds_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_Solicitud", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IUnidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Unidads_Unidad = _IUnidadApiConsumer.SelAll(true);
            if (Unidads_Unidad != null && Unidads_Unidad.Resource != null)
                ViewBag.Unidads_Unidad = Unidads_Unidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Unidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILugar_TipoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Lugar_Tipos_Tipo_de_Lugar_del_Hecho = _ILugar_TipoApiConsumer.SelAll(true);
            if (Lugar_Tipos_Tipo_de_Lugar_del_Hecho != null && Lugar_Tipos_Tipo_de_Lugar_del_Hecho.Resource != null)
                ViewBag.Lugar_Tipos_Tipo_de_Lugar_del_Hecho = Lugar_Tipos_Tipo_de_Lugar_del_Hecho.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_Tipo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMotivo_de_Rechazo_de_SolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Motivo_de_Rechazo_de_Solicituds_Motivo_de_Rechazo = _IMotivo_de_Rechazo_de_SolicitudApiConsumer.SelAll(true);
            if (Motivo_de_Rechazo_de_Solicituds_Motivo_de_Rechazo != null && Motivo_de_Rechazo_de_Solicituds_Motivo_de_Rechazo.Resource != null)
                ViewBag.Motivo_de_Rechazo_de_Solicituds_Motivo_de_Rechazo = Motivo_de_Rechazo_de_Solicituds_Motivo_de_Rechazo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Motivo_de_Rechazo_de_Solicitud", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _ITipo_de_Conclusion_AnticipadaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Conclusion_Anticipadas_Tipo_de_Conclusion_Anticipada = _ITipo_de_Conclusion_AnticipadaApiConsumer.SelAll(true);
            if (Tipo_de_Conclusion_Anticipadas_Tipo_de_Conclusion_Anticipada != null && Tipo_de_Conclusion_Anticipadas_Tipo_de_Conclusion_Anticipada.Resource != null)
                ViewBag.Tipo_de_Conclusion_Anticipadas_Tipo_de_Conclusion_Anticipada = Tipo_de_Conclusion_Anticipadas_Tipo_de_Conclusion_Anticipada.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Conclusion_Anticipada", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResultado_de_RevisionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resultado_de_Revisions_Resultado = _IResultado_de_RevisionApiConsumer.SelAll(true);
            if (Resultado_de_Revisions_Resultado != null && Resultado_de_Revisions_Resultado.Resource != null)
                ViewBag.Resultado_de_Revisions_Resultado = Resultado_de_Revisions_Resultado.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resultado_de_Revision", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_Mecanismo_AlternoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Mecanismo_Alternos_Tipo_de_Mecanismo = _ITipo_de_Mecanismo_AlternoApiConsumer.SelAll(true);
            if (Tipo_de_Mecanismo_Alternos_Tipo_de_Mecanismo != null && Tipo_de_Mecanismo_Alternos_Tipo_de_Mecanismo.Resource != null)
                ViewBag.Tipo_de_Mecanismo_Alternos_Tipo_de_Mecanismo = Tipo_de_Mecanismo_Alternos_Tipo_de_Mecanismo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Mecanismo_Alterno", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varSolicitud);
        }
		
	[HttpGet]
        public ActionResult AddSolicitud(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45010);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _ISolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
			SolicitudModel varSolicitud= new SolicitudModel();
            var permissionDetalle_Solicitud_Historial_de_Asignaciones = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45392, ModuleId);
            ViewBag.PermissionDetalle_Solicitud_Historial_de_Asignaciones = permissionDetalle_Solicitud_Historial_de_Asignaciones;
            var permissionDetalle_de_Solicitud_Bitacora_de_Coincid = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45126, ModuleId);
            ViewBag.PermissionDetalle_de_Solicitud_Bitacora_de_Coincid = permissionDetalle_de_Solicitud_Bitacora_de_Coincid;
            var permissionDetalle_Historico_JA = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45190, ModuleId);
            ViewBag.PermissionDetalle_Historico_JA = permissionDetalle_Historico_JA;


            if (id.ToString() != "0")
            {
                var SolicitudsData = _ISolicitudApiConsumer.ListaSelAll(0, 1000, "Solicitud.Clave=" + id, "").Resource.Solicituds;
				
				if (SolicitudsData != null && SolicitudsData.Count > 0)
                {
					var SolicitudData = SolicitudsData.First();
					varSolicitud= new SolicitudModel
					{
						Clave  = SolicitudData.Clave 
	                    ,Fecha_de_Registro = (SolicitudData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(SolicitudData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,Usuario_que_Registra = SolicitudData.Usuario_que_Registra
                    ,Usuario_que_RegistraName = CultureHelper.GetTraduction(Convert.ToString(SolicitudData.Usuario_que_Registra), "Spartan_User") ??  (string)SolicitudData.Usuario_que_Registra_Spartan_User.Name
                    ,Numero_de_Folio = SolicitudData.Numero_de_Folio
                    ,Unidad_MASC = SolicitudData.Unidad_MASC
                    ,Unidad_MASCDescripcion = CultureHelper.GetTraduction(Convert.ToString(SolicitudData.Unidad_MASC), "Unidad") ??  (string)SolicitudData.Unidad_MASC_Unidad.Descripcion
                    ,Remitente = SolicitudData.Remitente
                    ,NUAT = SolicitudData.NUAT
                    ,NUATNUAT = CultureHelper.GetTraduction(Convert.ToString(SolicitudData.NUAT), "Modulo_Atencion_Inicial") ??  (string)SolicitudData.NUAT_Modulo_Atencion_Inicial.NUAT
                    ,NUAT_Codigo = SolicitudData.NUAT_Codigo
                    ,Expediente_MPI = SolicitudData.Expediente_MPI
                    ,Expediente_MPInic = CultureHelper.GetTraduction(Convert.ToString(SolicitudData.Expediente_MPI), "expediente_ministerio_publico") ??  (string)SolicitudData.Expediente_MPI_expediente_ministerio_publico.nic
                    ,Expediente_CausaPenal = SolicitudData.Expediente_CausaPenal
                    ,Expediente_CausaPenalObservaciones = CultureHelper.GetTraduction(Convert.ToString(SolicitudData.Expediente_CausaPenal), "Resolucion_MP") ??  (string)SolicitudData.Expediente_CausaPenal_Resolucion_MP.Observaciones
                    ,Municipio = SolicitudData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(SolicitudData.Municipio), "Municipio") ??  (string)SolicitudData.Municipio_Municipio.Nombre
                    ,Region = SolicitudData.Region
                    ,RegionDescripcion = CultureHelper.GetTraduction(Convert.ToString(SolicitudData.Region), "Region") ??  (string)SolicitudData.Region_Region.Descripcion
                    ,NUC = SolicitudData.NUC
                    ,CDI = SolicitudData.CDI
                    ,Causa_Penal = SolicitudData.Causa_Penal
                    ,Numero_de_Expediente = SolicitudData.Numero_de_Expediente
                    ,Estatus = SolicitudData.Estatus
                    ,EstatusDescripcion = CultureHelper.GetTraduction(Convert.ToString(SolicitudData.Estatus), "Estatus_Solicitud") ??  (string)SolicitudData.Estatus_Estatus_Solicitud.Descripcion
                    ,Fecha_en_que_llega_a_Coordinador = (SolicitudData.Fecha_en_que_llega_a_Coordinador == null ? string.Empty : Convert.ToDateTime(SolicitudData.Fecha_en_que_llega_a_Coordinador).ToString(ConfigurationProperty.DateFormat))
                    ,Fecha_en_que_llega_a_Especialista = (SolicitudData.Fecha_en_que_llega_a_Especialista == null ? string.Empty : Convert.ToDateTime(SolicitudData.Fecha_en_que_llega_a_Especialista).ToString(ConfigurationProperty.DateFormat))
                    ,Agente_del_Ministerio_Publico_Orientador = SolicitudData.Agente_del_Ministerio_Publico_Orientador
                    ,Agente_del_Ministerio_Publico_OrientadorName = CultureHelper.GetTraduction(Convert.ToString(SolicitudData.Agente_del_Ministerio_Publico_Orientador), "Spartan_User") ??  (string)SolicitudData.Agente_del_Ministerio_Publico_Orientador_Spartan_User.Name
                    ,Agente_del_Ministerio_Publico_Invest = SolicitudData.Agente_del_Ministerio_Publico_Invest
                    ,Agente_del_Ministerio_Publico_InvestName = CultureHelper.GetTraduction(Convert.ToString(SolicitudData.Agente_del_Ministerio_Publico_Invest), "Spartan_User") ??  (string)SolicitudData.Agente_del_Ministerio_Publico_Invest_Spartan_User.Name
                    ,Juez_de_Control = SolicitudData.Juez_de_Control
                    ,Unidad = SolicitudData.Unidad
                    ,UnidadDescripcion = CultureHelper.GetTraduction(Convert.ToString(SolicitudData.Unidad), "Unidad") ??  (string)SolicitudData.Unidad_Unidad.Descripcion
                    ,Titulo_del_Hecho = SolicitudData.Titulo_del_Hecho
                    ,Fecha_del_Hecho = (SolicitudData.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(SolicitudData.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
                    ,Narrativa_Breve_de_los_Hechos = SolicitudData.Narrativa_Breve_de_los_Hechos
                    ,Hora_Aproximada_del_Hecho = SolicitudData.Hora_Aproximada_del_Hecho
                    ,Tipo_de_Lugar_del_Hecho = SolicitudData.Tipo_de_Lugar_del_Hecho
                    ,Tipo_de_Lugar_del_HechoDescripcion = CultureHelper.GetTraduction(Convert.ToString(SolicitudData.Tipo_de_Lugar_del_Hecho), "Lugar_Tipo") ??  (string)SolicitudData.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Descripcion
                    ,PaisH = SolicitudData.PaisH
                    ,PaisHNombre = CultureHelper.GetTraduction(Convert.ToString(SolicitudData.PaisH), "Pais") ??  (string)SolicitudData.PaisH_Pais.Nombre
                    ,EstadoH = SolicitudData.EstadoH
                    ,EstadoHNombre = CultureHelper.GetTraduction(Convert.ToString(SolicitudData.EstadoH), "Estado") ??  (string)SolicitudData.EstadoH_Estado.Nombre
                    ,MunicipioH = SolicitudData.MunicipioH
                    ,MunicipioHNombre = CultureHelper.GetTraduction(Convert.ToString(SolicitudData.MunicipioH), "Municipio") ??  (string)SolicitudData.MunicipioH_Municipio.Nombre
                    ,Poblacion = SolicitudData.Poblacion
                    ,PoblacionNombre = CultureHelper.GetTraduction(Convert.ToString(SolicitudData.Poblacion), "Colonia") ??  (string)SolicitudData.Poblacion_Colonia.Nombre
                    ,ColoniaH = SolicitudData.ColoniaH
                    ,ColoniaHNombre = CultureHelper.GetTraduction(Convert.ToString(SolicitudData.ColoniaH), "Colonia") ??  (string)SolicitudData.ColoniaH_Colonia.Nombre
                    ,CalleH = SolicitudData.CalleH
                    ,Numero_InteriorH = SolicitudData.Numero_InteriorH
                    ,Numero_ExteriorH = SolicitudData.Numero_ExteriorH
                    ,Codigo_PostalH = SolicitudData.Codigo_PostalH
                    ,Entre_Calle = SolicitudData.Entre_Calle
                    ,y_Calle = SolicitudData.y_Calle
                    ,LongitudH = SolicitudData.LongitudH
                    ,LatitudH = SolicitudData.LatitudH
                    ,Rechazar = SolicitudData.Rechazar.GetValueOrDefault()
                    ,Motivo_de_Rechazo = SolicitudData.Motivo_de_Rechazo
                    ,Motivo_de_RechazoDescripcion = CultureHelper.GetTraduction(Convert.ToString(SolicitudData.Motivo_de_Rechazo), "Motivo_de_Rechazo_de_Solicitud") ??  (string)SolicitudData.Motivo_de_Rechazo_Motivo_de_Rechazo_de_Solicitud.Descripcion
                    ,Acuerdo_Cumplido = SolicitudData.Acuerdo_Cumplido
                    ,Acuerdo_CumplidoDescripcion = CultureHelper.GetTraduction(Convert.ToString(SolicitudData.Acuerdo_Cumplido), "A_Tiempo") ??  (string)SolicitudData.Acuerdo_Cumplido_A_Tiempo.Descripcion
                    ,Razon_de_Incumplimiento = SolicitudData.Razon_de_Incumplimiento
                    ,Razon_de_IncumplimientoDescripcion = CultureHelper.GetTraduction(Convert.ToString(SolicitudData.Razon_de_Incumplimiento), "Razon_de_Incumplimiento") ??  (string)SolicitudData.Razon_de_Incumplimiento_Razon_de_Incumplimiento.Descripcion
                    ,Tipo_de_Conclusion_Anticipada = SolicitudData.Tipo_de_Conclusion_Anticipada
                    ,Tipo_de_Conclusion_AnticipadaDescripcion = CultureHelper.GetTraduction(Convert.ToString(SolicitudData.Tipo_de_Conclusion_Anticipada), "Tipo_de_Conclusion_Anticipada") ??  (string)SolicitudData.Tipo_de_Conclusion_Anticipada_Tipo_de_Conclusion_Anticipada.Descripcion
                    ,Fecha_de_Cierre = (SolicitudData.Fecha_de_Cierre == null ? string.Empty : Convert.ToDateTime(SolicitudData.Fecha_de_Cierre).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Cierre = SolicitudData.Hora_de_Cierre
                    ,Fecha_Validacion = (SolicitudData.Fecha_Validacion == null ? string.Empty : Convert.ToDateTime(SolicitudData.Fecha_Validacion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_Validacion = SolicitudData.Hora_Validacion
                    ,Usuario_que_Valida = SolicitudData.Usuario_que_Valida
                    ,Usuario_que_ValidaName = CultureHelper.GetTraduction(Convert.ToString(SolicitudData.Usuario_que_Valida), "Spartan_User") ??  (string)SolicitudData.Usuario_que_Valida_Spartan_User.Name
                    ,Resultado = SolicitudData.Resultado
                    ,ResultadoDescripcion = CultureHelper.GetTraduction(Convert.ToString(SolicitudData.Resultado), "Resultado_de_Revision") ??  (string)SolicitudData.Resultado_Resultado_de_Revision.Descripcion
                    ,Motivo_de_Rechazo_Solicitud = SolicitudData.Motivo_de_Rechazo_Solicitud
                    ,Especialista_AsignadoA = SolicitudData.Especialista_AsignadoA
                    ,Especialista_AsignadoAName = CultureHelper.GetTraduction(Convert.ToString(SolicitudData.Especialista_AsignadoA), "Spartan_User") ??  (string)SolicitudData.Especialista_AsignadoA_Spartan_User.Name
                    ,Motivo_cambio_facilitador = SolicitudData.Motivo_cambio_facilitador
                    ,Asignar_Especialista_Automatico = SolicitudData.Asignar_Especialista_Automatico.GetValueOrDefault()
                    ,Razone = SolicitudData.Razone
                    ,Tipo_de_Mecanismo = SolicitudData.Tipo_de_Mecanismo
                    ,Tipo_de_MecanismoDescripcion = CultureHelper.GetTraduction(Convert.ToString(SolicitudData.Tipo_de_Mecanismo), "Tipo_de_Mecanismo_Alterno") ??  (string)SolicitudData.Tipo_de_Mecanismo_Tipo_de_Mecanismo_Alterno.Descripcion
                    ,Fecha_de_AsignacionA = (SolicitudData.Fecha_de_AsignacionA == null ? string.Empty : Convert.ToDateTime(SolicitudData.Fecha_de_AsignacionA).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_AsignacionA = SolicitudData.Hora_de_AsignacionA
                    ,Fecha_de_Atencion_del_Especialista = (SolicitudData.Fecha_de_Atencion_del_Especialista == null ? string.Empty : Convert.ToDateTime(SolicitudData.Fecha_de_Atencion_del_Especialista).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Atencion_del_Especialista = SolicitudData.Hora_de_Atencion_del_Especialista

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IUnidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Unidads_Unidad_MASC = _IUnidadApiConsumer.SelAll(true);
            if (Unidads_Unidad_MASC != null && Unidads_Unidad_MASC.Resource != null)
                ViewBag.Unidads_Unidad_MASC = Unidads_Unidad_MASC.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Unidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IRegionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Regions_Region = _IRegionApiConsumer.SelAll(true);
            if (Regions_Region != null && Regions_Region.Resource != null)
                ViewBag.Regions_Region = Regions_Region.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Region", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatus_SolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_Solicituds_Estatus = _IEstatus_SolicitudApiConsumer.SelAll(true);
            if (Estatus_Solicituds_Estatus != null && Estatus_Solicituds_Estatus.Resource != null)
                ViewBag.Estatus_Solicituds_Estatus = Estatus_Solicituds_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_Solicitud", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IUnidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Unidads_Unidad = _IUnidadApiConsumer.SelAll(true);
            if (Unidads_Unidad != null && Unidads_Unidad.Resource != null)
                ViewBag.Unidads_Unidad = Unidads_Unidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Unidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILugar_TipoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Lugar_Tipos_Tipo_de_Lugar_del_Hecho = _ILugar_TipoApiConsumer.SelAll(true);
            if (Lugar_Tipos_Tipo_de_Lugar_del_Hecho != null && Lugar_Tipos_Tipo_de_Lugar_del_Hecho.Resource != null)
                ViewBag.Lugar_Tipos_Tipo_de_Lugar_del_Hecho = Lugar_Tipos_Tipo_de_Lugar_del_Hecho.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_Tipo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMotivo_de_Rechazo_de_SolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Motivo_de_Rechazo_de_Solicituds_Motivo_de_Rechazo = _IMotivo_de_Rechazo_de_SolicitudApiConsumer.SelAll(true);
            if (Motivo_de_Rechazo_de_Solicituds_Motivo_de_Rechazo != null && Motivo_de_Rechazo_de_Solicituds_Motivo_de_Rechazo.Resource != null)
                ViewBag.Motivo_de_Rechazo_de_Solicituds_Motivo_de_Rechazo = Motivo_de_Rechazo_de_Solicituds_Motivo_de_Rechazo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Motivo_de_Rechazo_de_Solicitud", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _ITipo_de_Conclusion_AnticipadaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Conclusion_Anticipadas_Tipo_de_Conclusion_Anticipada = _ITipo_de_Conclusion_AnticipadaApiConsumer.SelAll(true);
            if (Tipo_de_Conclusion_Anticipadas_Tipo_de_Conclusion_Anticipada != null && Tipo_de_Conclusion_Anticipadas_Tipo_de_Conclusion_Anticipada.Resource != null)
                ViewBag.Tipo_de_Conclusion_Anticipadas_Tipo_de_Conclusion_Anticipada = Tipo_de_Conclusion_Anticipadas_Tipo_de_Conclusion_Anticipada.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Conclusion_Anticipada", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResultado_de_RevisionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resultado_de_Revisions_Resultado = _IResultado_de_RevisionApiConsumer.SelAll(true);
            if (Resultado_de_Revisions_Resultado != null && Resultado_de_Revisions_Resultado.Resource != null)
                ViewBag.Resultado_de_Revisions_Resultado = Resultado_de_Revisions_Resultado.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resultado_de_Revision", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_Mecanismo_AlternoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Mecanismo_Alternos_Tipo_de_Mecanismo = _ITipo_de_Mecanismo_AlternoApiConsumer.SelAll(true);
            if (Tipo_de_Mecanismo_Alternos_Tipo_de_Mecanismo != null && Tipo_de_Mecanismo_Alternos_Tipo_de_Mecanismo.Resource != null)
                ViewBag.Tipo_de_Mecanismo_Alternos_Tipo_de_Mecanismo = Tipo_de_Mecanismo_Alternos_Tipo_de_Mecanismo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Mecanismo_Alterno", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddSolicitud", varSolicitud);
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
        public ActionResult GetModulo_Atencion_InicialAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModulo_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IModulo_Atencion_InicialApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.NUAT).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modulo_Atencion_Inicial", "NUAT")?? m.NUAT,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
		[HttpGet]
        public ActionResult Getexpediente_ministerio_publicoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _Iexpediente_ministerio_publicoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _Iexpediente_ministerio_publicoApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.nic).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.clave), "expediente_ministerio_publico", "nic")?? m.nic,
                    Value = Convert.ToString(m.clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
		[HttpGet]
        public ActionResult GetResolucion_MPAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IResolucion_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IResolucion_MPApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Observaciones).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resolucion_MP", "Observaciones")?? m.Observaciones,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
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
        public ActionResult GetLugar_TipoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ILugar_TipoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ILugar_TipoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_Tipo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
		[HttpGet]
        public ActionResult GetPaisAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IPaisApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IPaisApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Pais", "Nombre")?? m.Nombre,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
		[HttpGet]
        public ActionResult GetEstadoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstadoApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre")?? m.Nombre,
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
        [HttpGet]
        public ActionResult GetMotivo_de_Rechazo_de_SolicitudAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMotivo_de_Rechazo_de_SolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IMotivo_de_Rechazo_de_SolicitudApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Motivo_de_Rechazo_de_Solicitud", "Descripcion")?? m.Descripcion,
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
        public ActionResult GetTipo_de_Conclusion_AnticipadaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_Conclusion_AnticipadaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_Conclusion_AnticipadaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Conclusion_Anticipada", "Descripcion")?? m.Descripcion,
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



        [HttpPost]
        public JsonResult ClearAdvanceFilter()
        {
            Session["AdvanceSearch"] = null;
            return Json(new { result = Session["AdvanceSearch"] == null }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult ShowAdvanceFilter(SolicitudAdvanceSearchModel model, int idFilter = -1)
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

            _IUnidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Unidads_Unidad_MASC = _IUnidadApiConsumer.SelAll(true);
            if (Unidads_Unidad_MASC != null && Unidads_Unidad_MASC.Resource != null)
                ViewBag.Unidads_Unidad_MASC = Unidads_Unidad_MASC.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Unidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IRegionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Regions_Region = _IRegionApiConsumer.SelAll(true);
            if (Regions_Region != null && Regions_Region.Resource != null)
                ViewBag.Regions_Region = Regions_Region.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Region", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatus_SolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_Solicituds_Estatus = _IEstatus_SolicitudApiConsumer.SelAll(true);
            if (Estatus_Solicituds_Estatus != null && Estatus_Solicituds_Estatus.Resource != null)
                ViewBag.Estatus_Solicituds_Estatus = Estatus_Solicituds_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_Solicitud", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IUnidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Unidads_Unidad = _IUnidadApiConsumer.SelAll(true);
            if (Unidads_Unidad != null && Unidads_Unidad.Resource != null)
                ViewBag.Unidads_Unidad = Unidads_Unidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Unidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILugar_TipoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Lugar_Tipos_Tipo_de_Lugar_del_Hecho = _ILugar_TipoApiConsumer.SelAll(true);
            if (Lugar_Tipos_Tipo_de_Lugar_del_Hecho != null && Lugar_Tipos_Tipo_de_Lugar_del_Hecho.Resource != null)
                ViewBag.Lugar_Tipos_Tipo_de_Lugar_del_Hecho = Lugar_Tipos_Tipo_de_Lugar_del_Hecho.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_Tipo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMotivo_de_Rechazo_de_SolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Motivo_de_Rechazo_de_Solicituds_Motivo_de_Rechazo = _IMotivo_de_Rechazo_de_SolicitudApiConsumer.SelAll(true);
            if (Motivo_de_Rechazo_de_Solicituds_Motivo_de_Rechazo != null && Motivo_de_Rechazo_de_Solicituds_Motivo_de_Rechazo.Resource != null)
                ViewBag.Motivo_de_Rechazo_de_Solicituds_Motivo_de_Rechazo = Motivo_de_Rechazo_de_Solicituds_Motivo_de_Rechazo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Motivo_de_Rechazo_de_Solicitud", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _ITipo_de_Conclusion_AnticipadaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Conclusion_Anticipadas_Tipo_de_Conclusion_Anticipada = _ITipo_de_Conclusion_AnticipadaApiConsumer.SelAll(true);
            if (Tipo_de_Conclusion_Anticipadas_Tipo_de_Conclusion_Anticipada != null && Tipo_de_Conclusion_Anticipadas_Tipo_de_Conclusion_Anticipada.Resource != null)
                ViewBag.Tipo_de_Conclusion_Anticipadas_Tipo_de_Conclusion_Anticipada = Tipo_de_Conclusion_Anticipadas_Tipo_de_Conclusion_Anticipada.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Conclusion_Anticipada", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResultado_de_RevisionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resultado_de_Revisions_Resultado = _IResultado_de_RevisionApiConsumer.SelAll(true);
            if (Resultado_de_Revisions_Resultado != null && Resultado_de_Revisions_Resultado.Resource != null)
                ViewBag.Resultado_de_Revisions_Resultado = Resultado_de_Revisions_Resultado.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resultado_de_Revision", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_Mecanismo_AlternoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Mecanismo_Alternos_Tipo_de_Mecanismo = _ITipo_de_Mecanismo_AlternoApiConsumer.SelAll(true);
            if (Tipo_de_Mecanismo_Alternos_Tipo_de_Mecanismo != null && Tipo_de_Mecanismo_Alternos_Tipo_de_Mecanismo.Resource != null)
                ViewBag.Tipo_de_Mecanismo_Alternos_Tipo_de_Mecanismo = Tipo_de_Mecanismo_Alternos_Tipo_de_Mecanismo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Mecanismo_Alterno", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IUnidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Unidads_Unidad_MASC = _IUnidadApiConsumer.SelAll(true);
            if (Unidads_Unidad_MASC != null && Unidads_Unidad_MASC.Resource != null)
                ViewBag.Unidads_Unidad_MASC = Unidads_Unidad_MASC.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Unidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IRegionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Regions_Region = _IRegionApiConsumer.SelAll(true);
            if (Regions_Region != null && Regions_Region.Resource != null)
                ViewBag.Regions_Region = Regions_Region.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Region", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatus_SolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_Solicituds_Estatus = _IEstatus_SolicitudApiConsumer.SelAll(true);
            if (Estatus_Solicituds_Estatus != null && Estatus_Solicituds_Estatus.Resource != null)
                ViewBag.Estatus_Solicituds_Estatus = Estatus_Solicituds_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_Solicitud", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IUnidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Unidads_Unidad = _IUnidadApiConsumer.SelAll(true);
            if (Unidads_Unidad != null && Unidads_Unidad.Resource != null)
                ViewBag.Unidads_Unidad = Unidads_Unidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Unidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILugar_TipoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Lugar_Tipos_Tipo_de_Lugar_del_Hecho = _ILugar_TipoApiConsumer.SelAll(true);
            if (Lugar_Tipos_Tipo_de_Lugar_del_Hecho != null && Lugar_Tipos_Tipo_de_Lugar_del_Hecho.Resource != null)
                ViewBag.Lugar_Tipos_Tipo_de_Lugar_del_Hecho = Lugar_Tipos_Tipo_de_Lugar_del_Hecho.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_Tipo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMotivo_de_Rechazo_de_SolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Motivo_de_Rechazo_de_Solicituds_Motivo_de_Rechazo = _IMotivo_de_Rechazo_de_SolicitudApiConsumer.SelAll(true);
            if (Motivo_de_Rechazo_de_Solicituds_Motivo_de_Rechazo != null && Motivo_de_Rechazo_de_Solicituds_Motivo_de_Rechazo.Resource != null)
                ViewBag.Motivo_de_Rechazo_de_Solicituds_Motivo_de_Rechazo = Motivo_de_Rechazo_de_Solicituds_Motivo_de_Rechazo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Motivo_de_Rechazo_de_Solicitud", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _ITipo_de_Conclusion_AnticipadaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Conclusion_Anticipadas_Tipo_de_Conclusion_Anticipada = _ITipo_de_Conclusion_AnticipadaApiConsumer.SelAll(true);
            if (Tipo_de_Conclusion_Anticipadas_Tipo_de_Conclusion_Anticipada != null && Tipo_de_Conclusion_Anticipadas_Tipo_de_Conclusion_Anticipada.Resource != null)
                ViewBag.Tipo_de_Conclusion_Anticipadas_Tipo_de_Conclusion_Anticipada = Tipo_de_Conclusion_Anticipadas_Tipo_de_Conclusion_Anticipada.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Conclusion_Anticipada", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResultado_de_RevisionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resultado_de_Revisions_Resultado = _IResultado_de_RevisionApiConsumer.SelAll(true);
            if (Resultado_de_Revisions_Resultado != null && Resultado_de_Revisions_Resultado.Resource != null)
                ViewBag.Resultado_de_Revisions_Resultado = Resultado_de_Revisions_Resultado.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resultado_de_Revision", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_Mecanismo_AlternoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Mecanismo_Alternos_Tipo_de_Mecanismo = _ITipo_de_Mecanismo_AlternoApiConsumer.SelAll(true);
            if (Tipo_de_Mecanismo_Alternos_Tipo_de_Mecanismo != null && Tipo_de_Mecanismo_Alternos_Tipo_de_Mecanismo.Resource != null)
                ViewBag.Tipo_de_Mecanismo_Alternos_Tipo_de_Mecanismo = Tipo_de_Mecanismo_Alternos_Tipo_de_Mecanismo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Mecanismo_Alterno", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new SolicitudAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (SolicitudAdvanceSearchModel)(Session["AdvanceSearch"] ?? new SolicitudAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new SolicitudPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _ISolicitudApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Solicituds == null)
                result.Solicituds = new List<Solicitud>();

            return Json(new
            {
                data = result.Solicituds.Select(m => new SolicitudGridModel
                    {
                    Clave = m.Clave
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
			,Numero_de_Folio = m.Numero_de_Folio
                        ,Unidad_MASCDescripcion = CultureHelper.GetTraduction(m.Unidad_MASC_Unidad.Clave.ToString(), "Descripcion") ?? (string)m.Unidad_MASC_Unidad.Descripcion
			,Remitente = m.Remitente
                        ,NUATNUAT = CultureHelper.GetTraduction(m.NUAT_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.NUAT_Modulo_Atencion_Inicial.NUAT
			,NUAT_Codigo = m.NUAT_Codigo
                        ,Expediente_MPInic = CultureHelper.GetTraduction(m.Expediente_MPI_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MPI_expediente_ministerio_publico.nic
                        ,Expediente_CausaPenalObservaciones = CultureHelper.GetTraduction(m.Expediente_CausaPenal_Resolucion_MP.Clave.ToString(), "Resolucion_MP") ?? (string)m.Expediente_CausaPenal_Resolucion_MP.Observaciones
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,RegionDescripcion = CultureHelper.GetTraduction(m.Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Region_Region.Descripcion
			,NUC = m.NUC
			,CDI = m.CDI
			,Causa_Penal = m.Causa_Penal
			,Numero_de_Expediente = m.Numero_de_Expediente
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_Solicitud.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_Solicitud.Descripcion
                        ,Fecha_en_que_llega_a_Coordinador = (m.Fecha_en_que_llega_a_Coordinador == null ? string.Empty : Convert.ToDateTime(m.Fecha_en_que_llega_a_Coordinador).ToString(ConfigurationProperty.DateFormat))
                        ,Fecha_en_que_llega_a_Especialista = (m.Fecha_en_que_llega_a_Especialista == null ? string.Empty : Convert.ToDateTime(m.Fecha_en_que_llega_a_Especialista).ToString(ConfigurationProperty.DateFormat))
                        ,Agente_del_Ministerio_Publico_OrientadorName = CultureHelper.GetTraduction(m.Agente_del_Ministerio_Publico_Orientador_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Agente_del_Ministerio_Publico_Orientador_Spartan_User.Name
                        ,Agente_del_Ministerio_Publico_InvestName = CultureHelper.GetTraduction(m.Agente_del_Ministerio_Publico_Invest_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Agente_del_Ministerio_Publico_Invest_Spartan_User.Name
			,Juez_de_Control = m.Juez_de_Control
                        ,UnidadDescripcion = CultureHelper.GetTraduction(m.Unidad_Unidad.Clave.ToString(), "Descripcion") ?? (string)m.Unidad_Unidad.Descripcion
			,Titulo_del_Hecho = m.Titulo_del_Hecho
                        ,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
			,Narrativa_Breve_de_los_Hechos = m.Narrativa_Breve_de_los_Hechos
			,Hora_Aproximada_del_Hecho = m.Hora_Aproximada_del_Hecho
                        ,Tipo_de_Lugar_del_HechoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Descripcion
                        ,PaisHNombre = CultureHelper.GetTraduction(m.PaisH_Pais.Clave.ToString(), "Pais") ?? (string)m.PaisH_Pais.Nombre
                        ,EstadoHNombre = CultureHelper.GetTraduction(m.EstadoH_Estado.Clave.ToString(), "Estado") ?? (string)m.EstadoH_Estado.Nombre
                        ,MunicipioHNombre = CultureHelper.GetTraduction(m.MunicipioH_Municipio.Clave.ToString(), "Municipio") ?? (string)m.MunicipioH_Municipio.Nombre
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,ColoniaHNombre = CultureHelper.GetTraduction(m.ColoniaH_Colonia.Clave.ToString(), "Colonia") ?? (string)m.ColoniaH_Colonia.Nombre
			,CalleH = m.CalleH
			,Numero_InteriorH = m.Numero_InteriorH
			,Numero_ExteriorH = m.Numero_ExteriorH
			,Codigo_PostalH = m.Codigo_PostalH
			,Entre_Calle = m.Entre_Calle
			,y_Calle = m.y_Calle
			,LongitudH = m.LongitudH
			,LatitudH = m.LatitudH
			,Rechazar = m.Rechazar
                        ,Motivo_de_RechazoDescripcion = CultureHelper.GetTraduction(m.Motivo_de_Rechazo_Motivo_de_Rechazo_de_Solicitud.Clave.ToString(), "Descripcion") ?? (string)m.Motivo_de_Rechazo_Motivo_de_Rechazo_de_Solicitud.Descripcion
                        ,Acuerdo_CumplidoDescripcion = CultureHelper.GetTraduction(m.Acuerdo_Cumplido_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Acuerdo_Cumplido_A_Tiempo.Descripcion
                        ,Razon_de_IncumplimientoDescripcion = CultureHelper.GetTraduction(m.Razon_de_Incumplimiento_Razon_de_Incumplimiento.Clave.ToString(), "Descripcion") ?? (string)m.Razon_de_Incumplimiento_Razon_de_Incumplimiento.Descripcion
                        ,Tipo_de_Conclusion_AnticipadaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Conclusion_Anticipada_Tipo_de_Conclusion_Anticipada.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Conclusion_Anticipada_Tipo_de_Conclusion_Anticipada.Descripcion
                        ,Fecha_de_Cierre = (m.Fecha_de_Cierre == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Cierre).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Cierre = m.Hora_de_Cierre
                        ,Fecha_Validacion = (m.Fecha_Validacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_Validacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_Validacion = m.Hora_Validacion
                        ,Usuario_que_ValidaName = CultureHelper.GetTraduction(m.Usuario_que_Valida_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Valida_Spartan_User.Name
                        ,ResultadoDescripcion = CultureHelper.GetTraduction(m.Resultado_Resultado_de_Revision.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_Resultado_de_Revision.Descripcion
			,Motivo_de_Rechazo_Solicitud = m.Motivo_de_Rechazo_Solicitud
                        ,Especialista_AsignadoAName = CultureHelper.GetTraduction(m.Especialista_AsignadoA_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Especialista_AsignadoA_Spartan_User.Name
			,Motivo_cambio_facilitador = m.Motivo_cambio_facilitador
			,Asignar_Especialista_Automatico = m.Asignar_Especialista_Automatico
			,Razone = m.Razone
                        ,Tipo_de_MecanismoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Mecanismo_Tipo_de_Mecanismo_Alterno.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Mecanismo_Tipo_de_Mecanismo_Alterno.Descripcion
                        ,Fecha_de_AsignacionA = (m.Fecha_de_AsignacionA == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_AsignacionA).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_AsignacionA = m.Hora_de_AsignacionA
                        ,Fecha_de_Atencion_del_Especialista = (m.Fecha_de_Atencion_del_Especialista == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Atencion_del_Especialista).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Atencion_del_Especialista = m.Hora_de_Atencion_del_Especialista

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetSolicitudAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISolicitudApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Solicitud", m.),
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
        /// Get List of Solicitud from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Solicitud Entity</returns>
        public ActionResult GetSolicitudList(UrlParametersModel param)
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
            _ISolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new SolicitudPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(SolicitudAdvanceSearchModel))
                {
					var advanceFilter =
                    (SolicitudAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            SolicitudPropertyMapper oSolicitudPropertyMapper = new SolicitudPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oSolicitudPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _ISolicitudApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Solicituds == null)
                result.Solicituds = new List<Solicitud>();

            return Json(new
            {
                aaData = result.Solicituds.Select(m => new SolicitudGridModel
            {
                    Clave = m.Clave
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
			,Numero_de_Folio = m.Numero_de_Folio
                        ,Unidad_MASCDescripcion = CultureHelper.GetTraduction(m.Unidad_MASC_Unidad.Clave.ToString(), "Descripcion") ?? (string)m.Unidad_MASC_Unidad.Descripcion
			,Remitente = m.Remitente
                        ,NUATNUAT = CultureHelper.GetTraduction(m.NUAT_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.NUAT_Modulo_Atencion_Inicial.NUAT
			,NUAT_Codigo = m.NUAT_Codigo
                        ,Expediente_MPInic = CultureHelper.GetTraduction(m.Expediente_MPI_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MPI_expediente_ministerio_publico.nic
                        ,Expediente_CausaPenalObservaciones = CultureHelper.GetTraduction(m.Expediente_CausaPenal_Resolucion_MP.Clave.ToString(), "Resolucion_MP") ?? (string)m.Expediente_CausaPenal_Resolucion_MP.Observaciones
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,RegionDescripcion = CultureHelper.GetTraduction(m.Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Region_Region.Descripcion
			,NUC = m.NUC
			,CDI = m.CDI
			,Causa_Penal = m.Causa_Penal
			,Numero_de_Expediente = m.Numero_de_Expediente
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_Solicitud.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_Solicitud.Descripcion
                        ,Fecha_en_que_llega_a_Coordinador = (m.Fecha_en_que_llega_a_Coordinador == null ? string.Empty : Convert.ToDateTime(m.Fecha_en_que_llega_a_Coordinador).ToString(ConfigurationProperty.DateFormat))
                        ,Fecha_en_que_llega_a_Especialista = (m.Fecha_en_que_llega_a_Especialista == null ? string.Empty : Convert.ToDateTime(m.Fecha_en_que_llega_a_Especialista).ToString(ConfigurationProperty.DateFormat))
                        ,Agente_del_Ministerio_Publico_OrientadorName = CultureHelper.GetTraduction(m.Agente_del_Ministerio_Publico_Orientador_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Agente_del_Ministerio_Publico_Orientador_Spartan_User.Name
                        ,Agente_del_Ministerio_Publico_InvestName = CultureHelper.GetTraduction(m.Agente_del_Ministerio_Publico_Invest_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Agente_del_Ministerio_Publico_Invest_Spartan_User.Name
			,Juez_de_Control = m.Juez_de_Control
                        ,UnidadDescripcion = CultureHelper.GetTraduction(m.Unidad_Unidad.Clave.ToString(), "Descripcion") ?? (string)m.Unidad_Unidad.Descripcion
			,Titulo_del_Hecho = m.Titulo_del_Hecho
                        ,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
			,Narrativa_Breve_de_los_Hechos = m.Narrativa_Breve_de_los_Hechos
			,Hora_Aproximada_del_Hecho = m.Hora_Aproximada_del_Hecho
                        ,Tipo_de_Lugar_del_HechoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Descripcion
                        ,PaisHNombre = CultureHelper.GetTraduction(m.PaisH_Pais.Clave.ToString(), "Pais") ?? (string)m.PaisH_Pais.Nombre
                        ,EstadoHNombre = CultureHelper.GetTraduction(m.EstadoH_Estado.Clave.ToString(), "Estado") ?? (string)m.EstadoH_Estado.Nombre
                        ,MunicipioHNombre = CultureHelper.GetTraduction(m.MunicipioH_Municipio.Clave.ToString(), "Municipio") ?? (string)m.MunicipioH_Municipio.Nombre
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,ColoniaHNombre = CultureHelper.GetTraduction(m.ColoniaH_Colonia.Clave.ToString(), "Colonia") ?? (string)m.ColoniaH_Colonia.Nombre
			,CalleH = m.CalleH
			,Numero_InteriorH = m.Numero_InteriorH
			,Numero_ExteriorH = m.Numero_ExteriorH
			,Codigo_PostalH = m.Codigo_PostalH
			,Entre_Calle = m.Entre_Calle
			,y_Calle = m.y_Calle
			,LongitudH = m.LongitudH
			,LatitudH = m.LatitudH
			,Rechazar = m.Rechazar
                        ,Motivo_de_RechazoDescripcion = CultureHelper.GetTraduction(m.Motivo_de_Rechazo_Motivo_de_Rechazo_de_Solicitud.Clave.ToString(), "Descripcion") ?? (string)m.Motivo_de_Rechazo_Motivo_de_Rechazo_de_Solicitud.Descripcion
                        ,Acuerdo_CumplidoDescripcion = CultureHelper.GetTraduction(m.Acuerdo_Cumplido_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Acuerdo_Cumplido_A_Tiempo.Descripcion
                        ,Razon_de_IncumplimientoDescripcion = CultureHelper.GetTraduction(m.Razon_de_Incumplimiento_Razon_de_Incumplimiento.Clave.ToString(), "Descripcion") ?? (string)m.Razon_de_Incumplimiento_Razon_de_Incumplimiento.Descripcion
                        ,Tipo_de_Conclusion_AnticipadaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Conclusion_Anticipada_Tipo_de_Conclusion_Anticipada.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Conclusion_Anticipada_Tipo_de_Conclusion_Anticipada.Descripcion
                        ,Fecha_de_Cierre = (m.Fecha_de_Cierre == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Cierre).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Cierre = m.Hora_de_Cierre
                        ,Fecha_Validacion = (m.Fecha_Validacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_Validacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_Validacion = m.Hora_Validacion
                        ,Usuario_que_ValidaName = CultureHelper.GetTraduction(m.Usuario_que_Valida_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Valida_Spartan_User.Name
                        ,ResultadoDescripcion = CultureHelper.GetTraduction(m.Resultado_Resultado_de_Revision.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_Resultado_de_Revision.Descripcion
			,Motivo_de_Rechazo_Solicitud = m.Motivo_de_Rechazo_Solicitud
                        ,Especialista_AsignadoAName = CultureHelper.GetTraduction(m.Especialista_AsignadoA_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Especialista_AsignadoA_Spartan_User.Name
			,Motivo_cambio_facilitador = m.Motivo_cambio_facilitador
			,Asignar_Especialista_Automatico = m.Asignar_Especialista_Automatico
			,Razone = m.Razone
                        ,Tipo_de_MecanismoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Mecanismo_Tipo_de_Mecanismo_Alterno.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Mecanismo_Tipo_de_Mecanismo_Alterno.Descripcion
                        ,Fecha_de_AsignacionA = (m.Fecha_de_AsignacionA == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_AsignacionA).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_AsignacionA = m.Hora_de_AsignacionA
                        ,Fecha_de_Atencion_del_Especialista = (m.Fecha_de_Atencion_del_Especialista == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Atencion_del_Especialista).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Atencion_del_Especialista = m.Hora_de_Atencion_del_Especialista

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetSolicitud_Usuario_que_Registra_Spartan_User(string query, string where)
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
        public JsonResult GetSolicitud_NUAT_Modulo_Atencion_Inicial(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModulo_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Modulo_Atencion_Inicial.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Modulo_Atencion_Inicial.NUAT as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IModulo_Atencion_InicialApiConsumer.ListaSelAll(1, 20,elWhere , " Modulo_Atencion_Inicial.NUAT ASC ").Resource;
               
                foreach (var item in result.Modulo_Atencion_Inicials)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Modulo_Atencion_Inicial", "NUAT");
                    item.NUAT =trans ??item.NUAT;
                }
                return Json(result.Modulo_Atencion_Inicials.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetSolicitud_Expediente_MPI_expediente_ministerio_publico(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _Iexpediente_ministerio_publicoApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(expediente_ministerio_publico.clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(expediente_ministerio_publico.nic as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _Iexpediente_ministerio_publicoApiConsumer.ListaSelAll(1, 20,elWhere , " expediente_ministerio_publico.nic ASC ").Resource;
               
                foreach (var item in result.expediente_ministerio_publicos)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.clave), "expediente_ministerio_publico", "nic");
                    item.nic =trans ??item.nic;
                }
                return Json(result.expediente_ministerio_publicos.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetSolicitud_Expediente_CausaPenal_Resolucion_MP(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IResolucion_MPApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Resolucion_MP.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Resolucion_MP.Observaciones as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IResolucion_MPApiConsumer.ListaSelAll(1, 20,elWhere , " Resolucion_MP.Observaciones ASC ").Resource;
               
                foreach (var item in result.Resolucion_MPs)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Resolucion_MP", "Observaciones");
                    item.Observaciones =trans ??item.Observaciones;
                }
                return Json(result.Resolucion_MPs.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetSolicitud_Municipio_Municipio(string query, string where)
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
        public JsonResult GetSolicitud_Agente_del_Ministerio_Publico_Orientador_Spartan_User(string query, string where)
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
        public JsonResult GetSolicitud_Agente_del_Ministerio_Publico_Invest_Spartan_User(string query, string where)
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
        public JsonResult GetSolicitud_PaisH_Pais(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IPaisApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Pais.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Pais.Nombre as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IPaisApiConsumer.ListaSelAll(1, 20,elWhere , " Pais.Nombre ASC ").Resource;
               
                foreach (var item in result.Paiss)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Pais", "Nombre");
                    item.Nombre =trans ??item.Nombre;
                }
                return Json(result.Paiss.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetSolicitud_EstadoH_Estado(string query, string where)
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
        public JsonResult GetSolicitud_MunicipioH_Municipio(string query, string where)
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
        public JsonResult GetSolicitud_Poblacion_Colonia(string query, string where)
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
        public JsonResult GetSolicitud_ColoniaH_Colonia(string query, string where)
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
        public JsonResult GetSolicitud_Usuario_que_Valida_Spartan_User(string query, string where)
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
        public JsonResult GetSolicitud_Especialista_AsignadoA_Spartan_User(string query, string where)
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
        public JsonResult GetDetalle_Solicitud_Historial_de_Asignaciones_Usuario_Spartan_User(string query, string where)
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
        public JsonResult GetDetalle_Solicitud_Historial_de_Asignaciones_Facilitador_Asignado_Spartan_User(string query, string where)
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

//Grid GetAutoComplete
        [HttpGet]
        public JsonResult GetDetalle_Historico_JA_Usuario_Spartan_User(string query, string where)
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
        public string GetAdvanceFilter(SolicitudAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Solicitud.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Solicitud.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro) || !string.IsNullOrEmpty(filter.ToFecha_de_Registro))
            {
                var Fecha_de_RegistroFrom = DateTime.ParseExact(filter.FromFecha_de_Registro, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_RegistroTo = DateTime.ParseExact(filter.ToFecha_de_Registro, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro))
                    where += " AND Solicitud.Fecha_de_Registro >= '" + Fecha_de_RegistroFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Registro))
                    where += " AND Solicitud.Fecha_de_Registro <= '" + Fecha_de_RegistroTo.ToString("MM-dd-yyyy") + "'";
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

                where += " AND Solicitud.Usuario_que_Registra In (" + Usuario_que_RegistraIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Numero_de_Folio))
            {
                switch (filter.Numero_de_FolioFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud.Numero_de_Folio LIKE '" + filter.Numero_de_Folio + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud.Numero_de_Folio LIKE '%" + filter.Numero_de_Folio + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud.Numero_de_Folio = '" + filter.Numero_de_Folio + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud.Numero_de_Folio LIKE '%" + filter.Numero_de_Folio + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceUnidad_MASC))
            {
                switch (filter.Unidad_MASCFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Unidad.Descripcion LIKE '" + filter.AdvanceUnidad_MASC + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Unidad.Descripcion LIKE '%" + filter.AdvanceUnidad_MASC + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Unidad.Descripcion = '" + filter.AdvanceUnidad_MASC + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Unidad.Descripcion LIKE '%" + filter.AdvanceUnidad_MASC + "%'";
                        break;
                }
            }
            else if (filter.AdvanceUnidad_MASCMultiple != null && filter.AdvanceUnidad_MASCMultiple.Count() > 0)
            {
                var Unidad_MASCIds = string.Join(",", filter.AdvanceUnidad_MASCMultiple);

                where += " AND Solicitud.Unidad_MASC In (" + Unidad_MASCIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Remitente))
            {
                switch (filter.RemitenteFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud.Remitente LIKE '" + filter.Remitente + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud.Remitente LIKE '%" + filter.Remitente + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud.Remitente = '" + filter.Remitente + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud.Remitente LIKE '%" + filter.Remitente + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceNUAT))
            {
                switch (filter.NUATFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_Atencion_Inicial.NUAT LIKE '" + filter.AdvanceNUAT + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_Atencion_Inicial.NUAT LIKE '%" + filter.AdvanceNUAT + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_Atencion_Inicial.NUAT = '" + filter.AdvanceNUAT + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_Atencion_Inicial.NUAT LIKE '%" + filter.AdvanceNUAT + "%'";
                        break;
                }
            }
            else if (filter.AdvanceNUATMultiple != null && filter.AdvanceNUATMultiple.Count() > 0)
            {
                var NUATIds = string.Join(",", filter.AdvanceNUATMultiple);

                where += " AND Solicitud.NUAT In (" + NUATIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.NUAT_Codigo))
            {
                switch (filter.NUAT_CodigoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud.NUAT_Codigo LIKE '" + filter.NUAT_Codigo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud.NUAT_Codigo LIKE '%" + filter.NUAT_Codigo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud.NUAT_Codigo = '" + filter.NUAT_Codigo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud.NUAT_Codigo LIKE '%" + filter.NUAT_Codigo + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceExpediente_MPI))
            {
                switch (filter.Expediente_MPIFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND expediente_ministerio_publico.nic LIKE '" + filter.AdvanceExpediente_MPI + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND expediente_ministerio_publico.nic LIKE '%" + filter.AdvanceExpediente_MPI + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND expediente_ministerio_publico.nic = '" + filter.AdvanceExpediente_MPI + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND expediente_ministerio_publico.nic LIKE '%" + filter.AdvanceExpediente_MPI + "%'";
                        break;
                }
            }
            else if (filter.AdvanceExpediente_MPIMultiple != null && filter.AdvanceExpediente_MPIMultiple.Count() > 0)
            {
                var Expediente_MPIIds = string.Join(",", filter.AdvanceExpediente_MPIMultiple);

                where += " AND Solicitud.Expediente_MPI In (" + Expediente_MPIIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceExpediente_CausaPenal))
            {
                switch (filter.Expediente_CausaPenalFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Resolucion_MP.Observaciones LIKE '" + filter.AdvanceExpediente_CausaPenal + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Resolucion_MP.Observaciones LIKE '%" + filter.AdvanceExpediente_CausaPenal + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Resolucion_MP.Observaciones = '" + filter.AdvanceExpediente_CausaPenal + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Resolucion_MP.Observaciones LIKE '%" + filter.AdvanceExpediente_CausaPenal + "%'";
                        break;
                }
            }
            else if (filter.AdvanceExpediente_CausaPenalMultiple != null && filter.AdvanceExpediente_CausaPenalMultiple.Count() > 0)
            {
                var Expediente_CausaPenalIds = string.Join(",", filter.AdvanceExpediente_CausaPenalMultiple);

                where += " AND Solicitud.Expediente_CausaPenal In (" + Expediente_CausaPenalIds + ")";
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

                where += " AND Solicitud.Municipio In (" + MunicipioIds + ")";
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

                where += " AND Solicitud.Region In (" + RegionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.NUC))
            {
                switch (filter.NUCFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud.NUC LIKE '" + filter.NUC + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud.NUC LIKE '%" + filter.NUC + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud.NUC = '" + filter.NUC + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud.NUC LIKE '%" + filter.NUC + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.CDI))
            {
                switch (filter.CDIFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud.CDI LIKE '" + filter.CDI + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud.CDI LIKE '%" + filter.CDI + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud.CDI = '" + filter.CDI + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud.CDI LIKE '%" + filter.CDI + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Causa_Penal))
            {
                switch (filter.Causa_PenalFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud.Causa_Penal LIKE '" + filter.Causa_Penal + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud.Causa_Penal LIKE '%" + filter.Causa_Penal + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud.Causa_Penal = '" + filter.Causa_Penal + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud.Causa_Penal LIKE '%" + filter.Causa_Penal + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_de_Expediente))
            {
                switch (filter.Numero_de_ExpedienteFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud.Numero_de_Expediente LIKE '" + filter.Numero_de_Expediente + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud.Numero_de_Expediente LIKE '%" + filter.Numero_de_Expediente + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud.Numero_de_Expediente = '" + filter.Numero_de_Expediente + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud.Numero_de_Expediente LIKE '%" + filter.Numero_de_Expediente + "%'";
                        break;
                }
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

                where += " AND Solicitud.Estatus In (" + EstatusIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_en_que_llega_a_Coordinador) || !string.IsNullOrEmpty(filter.ToFecha_en_que_llega_a_Coordinador))
            {
                var Fecha_en_que_llega_a_CoordinadorFrom = DateTime.ParseExact(filter.FromFecha_en_que_llega_a_Coordinador, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_en_que_llega_a_CoordinadorTo = DateTime.ParseExact(filter.ToFecha_en_que_llega_a_Coordinador, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_en_que_llega_a_Coordinador))
                    where += " AND Solicitud.Fecha_en_que_llega_a_Coordinador >= '" + Fecha_en_que_llega_a_CoordinadorFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_en_que_llega_a_Coordinador))
                    where += " AND Solicitud.Fecha_en_que_llega_a_Coordinador <= '" + Fecha_en_que_llega_a_CoordinadorTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_en_que_llega_a_Especialista) || !string.IsNullOrEmpty(filter.ToFecha_en_que_llega_a_Especialista))
            {
                var Fecha_en_que_llega_a_EspecialistaFrom = DateTime.ParseExact(filter.FromFecha_en_que_llega_a_Especialista, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_en_que_llega_a_EspecialistaTo = DateTime.ParseExact(filter.ToFecha_en_que_llega_a_Especialista, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_en_que_llega_a_Especialista))
                    where += " AND Solicitud.Fecha_en_que_llega_a_Especialista >= '" + Fecha_en_que_llega_a_EspecialistaFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_en_que_llega_a_Especialista))
                    where += " AND Solicitud.Fecha_en_que_llega_a_Especialista <= '" + Fecha_en_que_llega_a_EspecialistaTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceAgente_del_Ministerio_Publico_Orientador))
            {
                switch (filter.Agente_del_Ministerio_Publico_OrientadorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_User.Name LIKE '" + filter.AdvanceAgente_del_Ministerio_Publico_Orientador + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceAgente_del_Ministerio_Publico_Orientador + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_User.Name = '" + filter.AdvanceAgente_del_Ministerio_Publico_Orientador + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceAgente_del_Ministerio_Publico_Orientador + "%'";
                        break;
                }
            }
            else if (filter.AdvanceAgente_del_Ministerio_Publico_OrientadorMultiple != null && filter.AdvanceAgente_del_Ministerio_Publico_OrientadorMultiple.Count() > 0)
            {
                var Agente_del_Ministerio_Publico_OrientadorIds = string.Join(",", filter.AdvanceAgente_del_Ministerio_Publico_OrientadorMultiple);

                where += " AND Solicitud.Agente_del_Ministerio_Publico_Orientador In (" + Agente_del_Ministerio_Publico_OrientadorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceAgente_del_Ministerio_Publico_Invest))
            {
                switch (filter.Agente_del_Ministerio_Publico_InvestFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_User.Name LIKE '" + filter.AdvanceAgente_del_Ministerio_Publico_Invest + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceAgente_del_Ministerio_Publico_Invest + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_User.Name = '" + filter.AdvanceAgente_del_Ministerio_Publico_Invest + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceAgente_del_Ministerio_Publico_Invest + "%'";
                        break;
                }
            }
            else if (filter.AdvanceAgente_del_Ministerio_Publico_InvestMultiple != null && filter.AdvanceAgente_del_Ministerio_Publico_InvestMultiple.Count() > 0)
            {
                var Agente_del_Ministerio_Publico_InvestIds = string.Join(",", filter.AdvanceAgente_del_Ministerio_Publico_InvestMultiple);

                where += " AND Solicitud.Agente_del_Ministerio_Publico_Invest In (" + Agente_del_Ministerio_Publico_InvestIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Juez_de_Control))
            {
                switch (filter.Juez_de_ControlFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud.Juez_de_Control LIKE '" + filter.Juez_de_Control + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud.Juez_de_Control LIKE '%" + filter.Juez_de_Control + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud.Juez_de_Control = '" + filter.Juez_de_Control + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud.Juez_de_Control LIKE '%" + filter.Juez_de_Control + "%'";
                        break;
                }
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

                where += " AND Solicitud.Unidad In (" + UnidadIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Titulo_del_Hecho))
            {
                switch (filter.Titulo_del_HechoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud.Titulo_del_Hecho LIKE '" + filter.Titulo_del_Hecho + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud.Titulo_del_Hecho LIKE '%" + filter.Titulo_del_Hecho + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud.Titulo_del_Hecho = '" + filter.Titulo_del_Hecho + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud.Titulo_del_Hecho LIKE '%" + filter.Titulo_del_Hecho + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_del_Hecho) || !string.IsNullOrEmpty(filter.ToFecha_del_Hecho))
            {
                var Fecha_del_HechoFrom = DateTime.ParseExact(filter.FromFecha_del_Hecho, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_del_HechoTo = DateTime.ParseExact(filter.ToFecha_del_Hecho, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_del_Hecho))
                    where += " AND Solicitud.Fecha_del_Hecho >= '" + Fecha_del_HechoFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_del_Hecho))
                    where += " AND Solicitud.Fecha_del_Hecho <= '" + Fecha_del_HechoTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.Narrativa_Breve_de_los_Hechos))
            {
                switch (filter.Narrativa_Breve_de_los_HechosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud.Narrativa_Breve_de_los_Hechos LIKE '" + filter.Narrativa_Breve_de_los_Hechos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud.Narrativa_Breve_de_los_Hechos LIKE '%" + filter.Narrativa_Breve_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud.Narrativa_Breve_de_los_Hechos = '" + filter.Narrativa_Breve_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud.Narrativa_Breve_de_los_Hechos LIKE '%" + filter.Narrativa_Breve_de_los_Hechos + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromHora_Aproximada_del_Hecho) || !string.IsNullOrEmpty(filter.ToHora_Aproximada_del_Hecho))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_Aproximada_del_Hecho))
                    where += " AND Convert(TIME,Solicitud.Hora_Aproximada_del_Hecho) >='" + filter.FromHora_Aproximada_del_Hecho + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_Aproximada_del_Hecho))
                    where += " AND Convert(TIME,Solicitud.Hora_Aproximada_del_Hecho) <='" + filter.ToHora_Aproximada_del_Hecho + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Lugar_del_Hecho))
            {
                switch (filter.Tipo_de_Lugar_del_HechoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Lugar_Tipo.Descripcion LIKE '" + filter.AdvanceTipo_de_Lugar_del_Hecho + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Lugar_Tipo.Descripcion LIKE '%" + filter.AdvanceTipo_de_Lugar_del_Hecho + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Lugar_Tipo.Descripcion = '" + filter.AdvanceTipo_de_Lugar_del_Hecho + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Lugar_Tipo.Descripcion LIKE '%" + filter.AdvanceTipo_de_Lugar_del_Hecho + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_Lugar_del_HechoMultiple != null && filter.AdvanceTipo_de_Lugar_del_HechoMultiple.Count() > 0)
            {
                var Tipo_de_Lugar_del_HechoIds = string.Join(",", filter.AdvanceTipo_de_Lugar_del_HechoMultiple);

                where += " AND Solicitud.Tipo_de_Lugar_del_Hecho In (" + Tipo_de_Lugar_del_HechoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvancePaisH))
            {
                switch (filter.PaisHFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Pais.Nombre LIKE '" + filter.AdvancePaisH + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Pais.Nombre LIKE '%" + filter.AdvancePaisH + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Pais.Nombre = '" + filter.AdvancePaisH + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Pais.Nombre LIKE '%" + filter.AdvancePaisH + "%'";
                        break;
                }
            }
            else if (filter.AdvancePaisHMultiple != null && filter.AdvancePaisHMultiple.Count() > 0)
            {
                var PaisHIds = string.Join(",", filter.AdvancePaisHMultiple);

                where += " AND Solicitud.PaisH In (" + PaisHIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstadoH))
            {
                switch (filter.EstadoHFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estado.Nombre LIKE '" + filter.AdvanceEstadoH + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEstadoH + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estado.Nombre = '" + filter.AdvanceEstadoH + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEstadoH + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstadoHMultiple != null && filter.AdvanceEstadoHMultiple.Count() > 0)
            {
                var EstadoHIds = string.Join(",", filter.AdvanceEstadoHMultiple);

                where += " AND Solicitud.EstadoH In (" + EstadoHIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceMunicipioH))
            {
                switch (filter.MunicipioHFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Municipio.Nombre LIKE '" + filter.AdvanceMunicipioH + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipioH + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Municipio.Nombre = '" + filter.AdvanceMunicipioH + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipioH + "%'";
                        break;
                }
            }
            else if (filter.AdvanceMunicipioHMultiple != null && filter.AdvanceMunicipioHMultiple.Count() > 0)
            {
                var MunicipioHIds = string.Join(",", filter.AdvanceMunicipioHMultiple);

                where += " AND Solicitud.MunicipioH In (" + MunicipioHIds + ")";
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

                where += " AND Solicitud.Poblacion In (" + PoblacionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceColoniaH))
            {
                switch (filter.ColoniaHFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Colonia.Nombre LIKE '" + filter.AdvanceColoniaH + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvanceColoniaH + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Colonia.Nombre = '" + filter.AdvanceColoniaH + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvanceColoniaH + "%'";
                        break;
                }
            }
            else if (filter.AdvanceColoniaHMultiple != null && filter.AdvanceColoniaHMultiple.Count() > 0)
            {
                var ColoniaHIds = string.Join(",", filter.AdvanceColoniaHMultiple);

                where += " AND Solicitud.ColoniaH In (" + ColoniaHIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.CalleH))
            {
                switch (filter.CalleHFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud.CalleH LIKE '" + filter.CalleH + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud.CalleH LIKE '%" + filter.CalleH + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud.CalleH = '" + filter.CalleH + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud.CalleH LIKE '%" + filter.CalleH + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_InteriorH))
            {
                switch (filter.Numero_InteriorHFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud.Numero_InteriorH LIKE '" + filter.Numero_InteriorH + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud.Numero_InteriorH LIKE '%" + filter.Numero_InteriorH + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud.Numero_InteriorH = '" + filter.Numero_InteriorH + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud.Numero_InteriorH LIKE '%" + filter.Numero_InteriorH + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_ExteriorH))
            {
                switch (filter.Numero_ExteriorHFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud.Numero_ExteriorH LIKE '" + filter.Numero_ExteriorH + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud.Numero_ExteriorH LIKE '%" + filter.Numero_ExteriorH + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud.Numero_ExteriorH = '" + filter.Numero_ExteriorH + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud.Numero_ExteriorH LIKE '%" + filter.Numero_ExteriorH + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromCodigo_PostalH) || !string.IsNullOrEmpty(filter.ToCodigo_PostalH))
            {
                if (!string.IsNullOrEmpty(filter.FromCodigo_PostalH))
                    where += " AND Solicitud.Codigo_PostalH >= " + filter.FromCodigo_PostalH;
                if (!string.IsNullOrEmpty(filter.ToCodigo_PostalH))
                    where += " AND Solicitud.Codigo_PostalH <= " + filter.ToCodigo_PostalH;
            }

            if (!string.IsNullOrEmpty(filter.Entre_Calle))
            {
                switch (filter.Entre_CalleFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud.Entre_Calle LIKE '" + filter.Entre_Calle + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud.Entre_Calle LIKE '%" + filter.Entre_Calle + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud.Entre_Calle = '" + filter.Entre_Calle + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud.Entre_Calle LIKE '%" + filter.Entre_Calle + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.y_Calle))
            {
                switch (filter.y_CalleFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud.y_Calle LIKE '" + filter.y_Calle + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud.y_Calle LIKE '%" + filter.y_Calle + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud.y_Calle = '" + filter.y_Calle + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud.y_Calle LIKE '%" + filter.y_Calle + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.LongitudH))
            {
                switch (filter.LongitudHFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud.LongitudH LIKE '" + filter.LongitudH + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud.LongitudH LIKE '%" + filter.LongitudH + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud.LongitudH = '" + filter.LongitudH + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud.LongitudH LIKE '%" + filter.LongitudH + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.LatitudH))
            {
                switch (filter.LatitudHFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud.LatitudH LIKE '" + filter.LatitudH + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud.LatitudH LIKE '%" + filter.LatitudH + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud.LatitudH = '" + filter.LatitudH + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud.LatitudH LIKE '%" + filter.LatitudH + "%'";
                        break;
                }
            }

            if (filter.Rechazar != RadioOptions.NoApply)
                where += " AND Solicitud.Rechazar = " + Convert.ToInt32(filter.Rechazar);

            if (!string.IsNullOrEmpty(filter.AdvanceMotivo_de_Rechazo))
            {
                switch (filter.Motivo_de_RechazoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Motivo_de_Rechazo_de_Solicitud.Descripcion LIKE '" + filter.AdvanceMotivo_de_Rechazo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Motivo_de_Rechazo_de_Solicitud.Descripcion LIKE '%" + filter.AdvanceMotivo_de_Rechazo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Motivo_de_Rechazo_de_Solicitud.Descripcion = '" + filter.AdvanceMotivo_de_Rechazo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Motivo_de_Rechazo_de_Solicitud.Descripcion LIKE '%" + filter.AdvanceMotivo_de_Rechazo + "%'";
                        break;
                }
            }
            else if (filter.AdvanceMotivo_de_RechazoMultiple != null && filter.AdvanceMotivo_de_RechazoMultiple.Count() > 0)
            {
                var Motivo_de_RechazoIds = string.Join(",", filter.AdvanceMotivo_de_RechazoMultiple);

                where += " AND Solicitud.Motivo_de_Rechazo In (" + Motivo_de_RechazoIds + ")";
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

                where += " AND Solicitud.Acuerdo_Cumplido In (" + Acuerdo_CumplidoIds + ")";
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

                where += " AND Solicitud.Razon_de_Incumplimiento In (" + Razon_de_IncumplimientoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Conclusion_Anticipada))
            {
                switch (filter.Tipo_de_Conclusion_AnticipadaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Conclusion_Anticipada.Descripcion LIKE '" + filter.AdvanceTipo_de_Conclusion_Anticipada + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Conclusion_Anticipada.Descripcion LIKE '%" + filter.AdvanceTipo_de_Conclusion_Anticipada + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Conclusion_Anticipada.Descripcion = '" + filter.AdvanceTipo_de_Conclusion_Anticipada + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Conclusion_Anticipada.Descripcion LIKE '%" + filter.AdvanceTipo_de_Conclusion_Anticipada + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_Conclusion_AnticipadaMultiple != null && filter.AdvanceTipo_de_Conclusion_AnticipadaMultiple.Count() > 0)
            {
                var Tipo_de_Conclusion_AnticipadaIds = string.Join(",", filter.AdvanceTipo_de_Conclusion_AnticipadaMultiple);

                where += " AND Solicitud.Tipo_de_Conclusion_Anticipada In (" + Tipo_de_Conclusion_AnticipadaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Cierre) || !string.IsNullOrEmpty(filter.ToFecha_de_Cierre))
            {
                var Fecha_de_CierreFrom = DateTime.ParseExact(filter.FromFecha_de_Cierre, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_CierreTo = DateTime.ParseExact(filter.ToFecha_de_Cierre, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Cierre))
                    where += " AND Solicitud.Fecha_de_Cierre >= '" + Fecha_de_CierreFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Cierre))
                    where += " AND Solicitud.Fecha_de_Cierre <= '" + Fecha_de_CierreTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Cierre) || !string.IsNullOrEmpty(filter.ToHora_de_Cierre))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Cierre))
                    where += " AND Convert(TIME,Solicitud.Hora_de_Cierre) >='" + filter.FromHora_de_Cierre + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Cierre))
                    where += " AND Convert(TIME,Solicitud.Hora_de_Cierre) <='" + filter.ToHora_de_Cierre + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_Validacion) || !string.IsNullOrEmpty(filter.ToFecha_Validacion))
            {
                var Fecha_ValidacionFrom = DateTime.ParseExact(filter.FromFecha_Validacion, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_ValidacionTo = DateTime.ParseExact(filter.ToFecha_Validacion, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_Validacion))
                    where += " AND Solicitud.Fecha_Validacion >= '" + Fecha_ValidacionFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_Validacion))
                    where += " AND Solicitud.Fecha_Validacion <= '" + Fecha_ValidacionTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_Validacion) || !string.IsNullOrEmpty(filter.ToHora_Validacion))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_Validacion))
                    where += " AND Convert(TIME,Solicitud.Hora_Validacion) >='" + filter.FromHora_Validacion + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_Validacion))
                    where += " AND Convert(TIME,Solicitud.Hora_Validacion) <='" + filter.ToHora_Validacion + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceUsuario_que_Valida))
            {
                switch (filter.Usuario_que_ValidaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_User.Name LIKE '" + filter.AdvanceUsuario_que_Valida + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceUsuario_que_Valida + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_User.Name = '" + filter.AdvanceUsuario_que_Valida + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceUsuario_que_Valida + "%'";
                        break;
                }
            }
            else if (filter.AdvanceUsuario_que_ValidaMultiple != null && filter.AdvanceUsuario_que_ValidaMultiple.Count() > 0)
            {
                var Usuario_que_ValidaIds = string.Join(",", filter.AdvanceUsuario_que_ValidaMultiple);

                where += " AND Solicitud.Usuario_que_Valida In (" + Usuario_que_ValidaIds + ")";
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

                where += " AND Solicitud.Resultado In (" + ResultadoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Motivo_de_Rechazo_Solicitud))
            {
                switch (filter.Motivo_de_Rechazo_SolicitudFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud.Motivo_de_Rechazo_Solicitud LIKE '" + filter.Motivo_de_Rechazo_Solicitud + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud.Motivo_de_Rechazo_Solicitud LIKE '%" + filter.Motivo_de_Rechazo_Solicitud + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud.Motivo_de_Rechazo_Solicitud = '" + filter.Motivo_de_Rechazo_Solicitud + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud.Motivo_de_Rechazo_Solicitud LIKE '%" + filter.Motivo_de_Rechazo_Solicitud + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEspecialista_AsignadoA))
            {
                switch (filter.Especialista_AsignadoAFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_User.Name LIKE '" + filter.AdvanceEspecialista_AsignadoA + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceEspecialista_AsignadoA + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_User.Name = '" + filter.AdvanceEspecialista_AsignadoA + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceEspecialista_AsignadoA + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEspecialista_AsignadoAMultiple != null && filter.AdvanceEspecialista_AsignadoAMultiple.Count() > 0)
            {
                var Especialista_AsignadoAIds = string.Join(",", filter.AdvanceEspecialista_AsignadoAMultiple);

                where += " AND Solicitud.Especialista_AsignadoA In (" + Especialista_AsignadoAIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Motivo_cambio_facilitador))
            {
                switch (filter.Motivo_cambio_facilitadorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud.Motivo_cambio_facilitador LIKE '" + filter.Motivo_cambio_facilitador + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud.Motivo_cambio_facilitador LIKE '%" + filter.Motivo_cambio_facilitador + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud.Motivo_cambio_facilitador = '" + filter.Motivo_cambio_facilitador + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud.Motivo_cambio_facilitador LIKE '%" + filter.Motivo_cambio_facilitador + "%'";
                        break;
                }
            }

            if (filter.Asignar_Especialista_Automatico != RadioOptions.NoApply)
                where += " AND Solicitud.Asignar_Especialista_Automatico = " + Convert.ToInt32(filter.Asignar_Especialista_Automatico);

            if (!string.IsNullOrEmpty(filter.Razone))
            {
                switch (filter.RazoneFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud.Razone LIKE '" + filter.Razone + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud.Razone LIKE '%" + filter.Razone + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud.Razone = '" + filter.Razone + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud.Razone LIKE '%" + filter.Razone + "%'";
                        break;
                }
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

                where += " AND Solicitud.Tipo_de_Mecanismo In (" + Tipo_de_MecanismoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_AsignacionA) || !string.IsNullOrEmpty(filter.ToFecha_de_AsignacionA))
            {
                var Fecha_de_AsignacionAFrom = DateTime.ParseExact(filter.FromFecha_de_AsignacionA, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_AsignacionATo = DateTime.ParseExact(filter.ToFecha_de_AsignacionA, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_AsignacionA))
                    where += " AND Solicitud.Fecha_de_AsignacionA >= '" + Fecha_de_AsignacionAFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_AsignacionA))
                    where += " AND Solicitud.Fecha_de_AsignacionA <= '" + Fecha_de_AsignacionATo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_AsignacionA) || !string.IsNullOrEmpty(filter.ToHora_de_AsignacionA))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_AsignacionA))
                    where += " AND Convert(TIME,Solicitud.Hora_de_AsignacionA) >='" + filter.FromHora_de_AsignacionA + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_AsignacionA))
                    where += " AND Convert(TIME,Solicitud.Hora_de_AsignacionA) <='" + filter.ToHora_de_AsignacionA + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Atencion_del_Especialista) || !string.IsNullOrEmpty(filter.ToFecha_de_Atencion_del_Especialista))
            {
                var Fecha_de_Atencion_del_EspecialistaFrom = DateTime.ParseExact(filter.FromFecha_de_Atencion_del_Especialista, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_Atencion_del_EspecialistaTo = DateTime.ParseExact(filter.ToFecha_de_Atencion_del_Especialista, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Atencion_del_Especialista))
                    where += " AND Solicitud.Fecha_de_Atencion_del_Especialista >= '" + Fecha_de_Atencion_del_EspecialistaFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Atencion_del_Especialista))
                    where += " AND Solicitud.Fecha_de_Atencion_del_Especialista <= '" + Fecha_de_Atencion_del_EspecialistaTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Atencion_del_Especialista) || !string.IsNullOrEmpty(filter.ToHora_de_Atencion_del_Especialista))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Atencion_del_Especialista))
                    where += " AND Convert(TIME,Solicitud.Hora_de_Atencion_del_Especialista) >='" + filter.FromHora_de_Atencion_del_Especialista + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Atencion_del_Especialista))
                    where += " AND Convert(TIME,Solicitud.Hora_de_Atencion_del_Especialista) <='" + filter.ToHora_de_Atencion_del_Especialista + "'";
            }


            where = new Regex(Regex.Escape("AND ")).Replace(where, "", 1);
            return where;
        }

        [NonAction]
        public Grid_File ConvertSpartane_FileToGridFile(Spartane.Core.Domain.Spartane_File.Spartane_File file)
        {
            return file == null ? new Grid_File { FileId = 0, FileSize = 0, FileName = "" } : new Grid_File { FileId = file.File_Id, FileName = file.Description, FileSize = file.File_Size ?? 0, };
        }

        public ActionResult GetDetalle_Solicitud_Historial_de_Asignaciones(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_Solicitud_Historial_de_AsignacionesGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Solicitud_Historial_de_AsignacionesApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_Solicitud_Historial_de_Asignaciones.Solicitud=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_Solicitud_Historial_de_Asignaciones.Solicitud='" + RelationId + "'";
            }
            var result = _IDetalle_Solicitud_Historial_de_AsignacionesApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_Solicitud_Historial_de_Asignacioness == null)
                result.Detalle_Solicitud_Historial_de_Asignacioness = new List<Detalle_Solicitud_Historial_de_Asignaciones>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_Solicitud_Historial_de_Asignacioness.Select(m => new Detalle_Solicitud_Historial_de_AsignacionesGridModel
                {
                    Folio = m.Folio

			,Fecha_cambio = (m.Fecha_cambio == null ? string.Empty : Convert.ToDateTime(m.Fecha_cambio).ToString(ConfigurationProperty.DateFormat))
			,Hora_cambio = m.Hora_cambio
                        ,Usuario = m.Usuario
                        ,UsuarioName = CultureHelper.GetTraduction(m.Usuario_Spartan_User.Id_User.ToString(), "Name") ??(string)m.Usuario_Spartan_User.Name
                        ,Facilitador_Asignado = m.Facilitador_Asignado
                        ,Facilitador_AsignadoName = CultureHelper.GetTraduction(m.Facilitador_Asignado_Spartan_User.Id_User.ToString(), "Name") ??(string)m.Facilitador_Asignado_Spartan_User.Name
			,Motivo_de_cambio = m.Motivo_de_cambio

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_Solicitud_Historial_de_AsignacionesGridModel> GetDetalle_Solicitud_Historial_de_AsignacionesData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_Solicitud_Historial_de_AsignacionesGridModel> resultData = new List<Detalle_Solicitud_Historial_de_AsignacionesGridModel>();
            string where = "Detalle_Solicitud_Historial_de_Asignaciones.Solicitud=" + Id;
            if("int" == "string")
            {
                where = "Detalle_Solicitud_Historial_de_Asignaciones.Solicitud='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Solicitud_Historial_de_AsignacionesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_Solicitud_Historial_de_AsignacionesApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_Solicitud_Historial_de_Asignacioness != null)
            {
                resultData = result.Detalle_Solicitud_Historial_de_Asignacioness.Select(m => new Detalle_Solicitud_Historial_de_AsignacionesGridModel
                    {
                        Folio = m.Folio

			,Fecha_cambio = (m.Fecha_cambio == null ? string.Empty : Convert.ToDateTime(m.Fecha_cambio).ToString(ConfigurationProperty.DateFormat))
			,Hora_cambio = m.Hora_cambio
                        ,Usuario = m.Usuario
                        ,UsuarioName = CultureHelper.GetTraduction(m.Usuario_Spartan_User.Id_User.ToString(), "Name") ??(string)m.Usuario_Spartan_User.Name
                        ,Facilitador_Asignado = m.Facilitador_Asignado
                        ,Facilitador_AsignadoName = CultureHelper.GetTraduction(m.Facilitador_Asignado_Spartan_User.Id_User.ToString(), "Name") ??(string)m.Facilitador_Asignado_Spartan_User.Name
			,Motivo_de_cambio = m.Motivo_de_cambio


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_de_Solicitud_Bitacora_de_Coincid(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_Solicitud_Bitacora_de_CoincidGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Solicitud_Bitacora_de_CoincidApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_Solicitud_Bitacora_de_Coincid.Solicitud=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_Solicitud_Bitacora_de_Coincid.Solicitud='" + RelationId + "'";
            }
            var result = _IDetalle_de_Solicitud_Bitacora_de_CoincidApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_Solicitud_Bitacora_de_Coincids == null)
                result.Detalle_de_Solicitud_Bitacora_de_Coincids = new List<Detalle_de_Solicitud_Bitacora_de_Coincid>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_Solicitud_Bitacora_de_Coincids.Select(m => new Detalle_de_Solicitud_Bitacora_de_CoincidGridModel
                {
                    Clave = m.Clave

			,Nombre_Completo = m.Nombre_Completo
			,Alias = m.Alias
			,Numero_de_Expediente = m.Numero_de_Expediente
			,Fuente_de_Origen = m.Fuente_de_Origen
                        ,Tipo_de_Acuerdo = m.Tipo_de_Acuerdo
                        ,Tipo_de_AcuerdoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Acuerdo_Tipo_de_Acuerdo.Clave.ToString(), "Descripcion") ??(string)m.Tipo_de_Acuerdo_Tipo_de_Acuerdo.Descripcion
			,Cumplido = m.Cumplido
                        ,Razon_de_Incumplimiento = m.Razon_de_Incumplimiento
                        ,Razon_de_IncumplimientoDescripcion = CultureHelper.GetTraduction(m.Razon_de_Incumplimiento_Razon_de_Incumplimiento.Clave.ToString(), "Descripcion") ??(string)m.Razon_de_Incumplimiento_Razon_de_Incumplimiento.Descripcion
			,Observaciones = m.Observaciones

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_Solicitud_Bitacora_de_CoincidGridModel> GetDetalle_de_Solicitud_Bitacora_de_CoincidData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_Solicitud_Bitacora_de_CoincidGridModel> resultData = new List<Detalle_de_Solicitud_Bitacora_de_CoincidGridModel>();
            string where = "Detalle_de_Solicitud_Bitacora_de_Coincid.Solicitud=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_Solicitud_Bitacora_de_Coincid.Solicitud='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Solicitud_Bitacora_de_CoincidApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_Solicitud_Bitacora_de_CoincidApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_Solicitud_Bitacora_de_Coincids != null)
            {
                resultData = result.Detalle_de_Solicitud_Bitacora_de_Coincids.Select(m => new Detalle_de_Solicitud_Bitacora_de_CoincidGridModel
                    {
                        Clave = m.Clave

			,Nombre_Completo = m.Nombre_Completo
			,Alias = m.Alias
			,Numero_de_Expediente = m.Numero_de_Expediente
			,Fuente_de_Origen = m.Fuente_de_Origen
                        ,Tipo_de_Acuerdo = m.Tipo_de_Acuerdo
                        ,Tipo_de_AcuerdoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Acuerdo_Tipo_de_Acuerdo.Clave.ToString(), "Descripcion") ??(string)m.Tipo_de_Acuerdo_Tipo_de_Acuerdo.Descripcion
			,Cumplido = m.Cumplido
                        ,Razon_de_Incumplimiento = m.Razon_de_Incumplimiento
                        ,Razon_de_IncumplimientoDescripcion = CultureHelper.GetTraduction(m.Razon_de_Incumplimiento_Razon_de_Incumplimiento.Clave.ToString(), "Descripcion") ??(string)m.Razon_de_Incumplimiento_Razon_de_Incumplimiento.Descripcion
			,Observaciones = m.Observaciones


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_Historico_JA(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_Historico_JAGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Historico_JAApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_Historico_JA.Solicitud=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_Historico_JA.Solicitud='" + RelationId + "'";
            }
            var result = _IDetalle_Historico_JAApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_Historico_JAs == null)
                result.Detalle_Historico_JAs = new List<Detalle_Historico_JA>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_Historico_JAs.Select(m => new Detalle_Historico_JAGridModel
                {
                    Clave = m.Clave

			,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora
                        ,Usuario = m.Usuario
                        ,UsuarioName = CultureHelper.GetTraduction(m.Usuario_Spartan_User.Id_User.ToString(), "Name") ??(string)m.Usuario_Spartan_User.Name
			,Estatus = m.Estatus

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_Historico_JAGridModel> GetDetalle_Historico_JAData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_Historico_JAGridModel> resultData = new List<Detalle_Historico_JAGridModel>();
            string where = "Detalle_Historico_JA.Solicitud=" + Id;
            if("int" == "string")
            {
                where = "Detalle_Historico_JA.Solicitud='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Historico_JAApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_Historico_JAApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_Historico_JAs != null)
            {
                resultData = result.Detalle_Historico_JAs.Select(m => new Detalle_Historico_JAGridModel
                    {
                        Clave = m.Clave

			,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora
                        ,Usuario = m.Usuario
                        ,UsuarioName = CultureHelper.GetTraduction(m.Usuario_Spartan_User.Id_User.ToString(), "Name") ??(string)m.Usuario_Spartan_User.Name
			,Estatus = m.Estatus


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
                _ISolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);

                Solicitud varSolicitud = null;
                if (id.ToString() != "0")
                {
                        string where = "";
                    _IDetalle_Solicitud_Historial_de_AsignacionesApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_Solicitud_Historial_de_Asignaciones.Solicitud=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_Solicitud_Historial_de_Asignaciones.Solicitud='" + id + "'";
                    }
                    var Detalle_Solicitud_Historial_de_AsignacionesInfo =
                        _IDetalle_Solicitud_Historial_de_AsignacionesApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_Solicitud_Historial_de_AsignacionesInfo.Detalle_Solicitud_Historial_de_Asignacioness.Count > 0)
                    {
                        var resultDetalle_Solicitud_Historial_de_Asignaciones = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_Solicitud_Historial_de_AsignacionesItem in Detalle_Solicitud_Historial_de_AsignacionesInfo.Detalle_Solicitud_Historial_de_Asignacioness)
                            resultDetalle_Solicitud_Historial_de_Asignaciones = resultDetalle_Solicitud_Historial_de_Asignaciones
                                              && _IDetalle_Solicitud_Historial_de_AsignacionesApiConsumer.Delete(Detalle_Solicitud_Historial_de_AsignacionesItem.Folio, null,null).Resource;

                        if (!resultDetalle_Solicitud_Historial_de_Asignaciones)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_de_Solicitud_Bitacora_de_CoincidApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_Solicitud_Bitacora_de_Coincid.Solicitud=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_Solicitud_Bitacora_de_Coincid.Solicitud='" + id + "'";
                    }
                    var Detalle_de_Solicitud_Bitacora_de_CoincidInfo =
                        _IDetalle_de_Solicitud_Bitacora_de_CoincidApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_Solicitud_Bitacora_de_CoincidInfo.Detalle_de_Solicitud_Bitacora_de_Coincids.Count > 0)
                    {
                        var resultDetalle_de_Solicitud_Bitacora_de_Coincid = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_Solicitud_Bitacora_de_CoincidItem in Detalle_de_Solicitud_Bitacora_de_CoincidInfo.Detalle_de_Solicitud_Bitacora_de_Coincids)
                            resultDetalle_de_Solicitud_Bitacora_de_Coincid = resultDetalle_de_Solicitud_Bitacora_de_Coincid
                                              && _IDetalle_de_Solicitud_Bitacora_de_CoincidApiConsumer.Delete(Detalle_de_Solicitud_Bitacora_de_CoincidItem.Clave, null,null).Resource;

                        if (!resultDetalle_de_Solicitud_Bitacora_de_Coincid)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_Historico_JAApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_Historico_JA.Solicitud=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_Historico_JA.Solicitud='" + id + "'";
                    }
                    var Detalle_Historico_JAInfo =
                        _IDetalle_Historico_JAApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_Historico_JAInfo.Detalle_Historico_JAs.Count > 0)
                    {
                        var resultDetalle_Historico_JA = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_Historico_JAItem in Detalle_Historico_JAInfo.Detalle_Historico_JAs)
                            resultDetalle_Historico_JA = resultDetalle_Historico_JA
                                              && _IDetalle_Historico_JAApiConsumer.Delete(Detalle_Historico_JAItem.Clave, null,null).Resource;

                        if (!resultDetalle_Historico_JA)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }

                }
                var result = _ISolicitudApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, SolicitudModel varSolicitud)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _ISolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var SolicitudInfo = new Solicitud
                    {
                        Clave = varSolicitud.Clave
                        ,Fecha_de_Registro = (!String.IsNullOrEmpty(varSolicitud.Fecha_de_Registro)) ? DateTime.ParseExact(varSolicitud.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Usuario_que_Registra = varSolicitud.Usuario_que_Registra
                        ,Numero_de_Folio = varSolicitud.Numero_de_Folio
                        ,Unidad_MASC = varSolicitud.Unidad_MASC
                        ,Remitente = varSolicitud.Remitente
                        ,NUAT = varSolicitud.NUAT
                        ,NUAT_Codigo = varSolicitud.NUAT_Codigo
                        ,Expediente_MPI = varSolicitud.Expediente_MPI
                        ,Expediente_CausaPenal = varSolicitud.Expediente_CausaPenal
                        ,Municipio = varSolicitud.Municipio
                        ,Region = varSolicitud.Region
                        ,NUC = varSolicitud.NUC
                        ,CDI = varSolicitud.CDI
                        ,Causa_Penal = varSolicitud.Causa_Penal
                        ,Numero_de_Expediente = varSolicitud.Numero_de_Expediente
                        ,Estatus = varSolicitud.Estatus
                        ,Fecha_en_que_llega_a_Coordinador = (!String.IsNullOrEmpty(varSolicitud.Fecha_en_que_llega_a_Coordinador)) ? DateTime.ParseExact(varSolicitud.Fecha_en_que_llega_a_Coordinador, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Fecha_en_que_llega_a_Especialista = (!String.IsNullOrEmpty(varSolicitud.Fecha_en_que_llega_a_Especialista)) ? DateTime.ParseExact(varSolicitud.Fecha_en_que_llega_a_Especialista, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Agente_del_Ministerio_Publico_Orientador = varSolicitud.Agente_del_Ministerio_Publico_Orientador
                        ,Agente_del_Ministerio_Publico_Invest = varSolicitud.Agente_del_Ministerio_Publico_Invest
                        ,Juez_de_Control = varSolicitud.Juez_de_Control
                        ,Unidad = varSolicitud.Unidad
                        ,Titulo_del_Hecho = varSolicitud.Titulo_del_Hecho
                        ,Fecha_del_Hecho = (!String.IsNullOrEmpty(varSolicitud.Fecha_del_Hecho)) ? DateTime.ParseExact(varSolicitud.Fecha_del_Hecho, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Narrativa_Breve_de_los_Hechos = varSolicitud.Narrativa_Breve_de_los_Hechos
                        ,Hora_Aproximada_del_Hecho = varSolicitud.Hora_Aproximada_del_Hecho
                        ,Tipo_de_Lugar_del_Hecho = varSolicitud.Tipo_de_Lugar_del_Hecho
                        ,PaisH = varSolicitud.PaisH
                        ,EstadoH = varSolicitud.EstadoH
                        ,MunicipioH = varSolicitud.MunicipioH
                        ,Poblacion = varSolicitud.Poblacion
                        ,ColoniaH = varSolicitud.ColoniaH
                        ,CalleH = varSolicitud.CalleH
                        ,Numero_InteriorH = varSolicitud.Numero_InteriorH
                        ,Numero_ExteriorH = varSolicitud.Numero_ExteriorH
                        ,Codigo_PostalH = varSolicitud.Codigo_PostalH
                        ,Entre_Calle = varSolicitud.Entre_Calle
                        ,y_Calle = varSolicitud.y_Calle
                        ,LongitudH = varSolicitud.LongitudH
                        ,LatitudH = varSolicitud.LatitudH
                        ,Rechazar = varSolicitud.Rechazar
                        ,Motivo_de_Rechazo = varSolicitud.Motivo_de_Rechazo
                        ,Acuerdo_Cumplido = varSolicitud.Acuerdo_Cumplido
                        ,Razon_de_Incumplimiento = varSolicitud.Razon_de_Incumplimiento
                        ,Tipo_de_Conclusion_Anticipada = varSolicitud.Tipo_de_Conclusion_Anticipada
                        ,Fecha_de_Cierre = (!String.IsNullOrEmpty(varSolicitud.Fecha_de_Cierre)) ? DateTime.ParseExact(varSolicitud.Fecha_de_Cierre, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Cierre = varSolicitud.Hora_de_Cierre
                        ,Fecha_Validacion = (!String.IsNullOrEmpty(varSolicitud.Fecha_Validacion)) ? DateTime.ParseExact(varSolicitud.Fecha_Validacion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_Validacion = varSolicitud.Hora_Validacion
                        ,Usuario_que_Valida = varSolicitud.Usuario_que_Valida
                        ,Resultado = varSolicitud.Resultado
                        ,Motivo_de_Rechazo_Solicitud = varSolicitud.Motivo_de_Rechazo_Solicitud
                        ,Especialista_AsignadoA = varSolicitud.Especialista_AsignadoA
                        ,Motivo_cambio_facilitador = varSolicitud.Motivo_cambio_facilitador
                        ,Asignar_Especialista_Automatico = varSolicitud.Asignar_Especialista_Automatico
                        ,Razone = varSolicitud.Razone
                        ,Tipo_de_Mecanismo = varSolicitud.Tipo_de_Mecanismo
                        ,Fecha_de_AsignacionA = (!String.IsNullOrEmpty(varSolicitud.Fecha_de_AsignacionA)) ? DateTime.ParseExact(varSolicitud.Fecha_de_AsignacionA, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_AsignacionA = varSolicitud.Hora_de_AsignacionA
                        ,Fecha_de_Atencion_del_Especialista = (!String.IsNullOrEmpty(varSolicitud.Fecha_de_Atencion_del_Especialista)) ? DateTime.ParseExact(varSolicitud.Fecha_de_Atencion_del_Especialista, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Atencion_del_Especialista = varSolicitud.Hora_de_Atencion_del_Especialista

                    };

                    result = !IsNew ?
                        _ISolicitudApiConsumer.Update(SolicitudInfo, null, null).Resource.ToString() :
                         _ISolicitudApiConsumer.Insert(SolicitudInfo, null, null).Resource.ToString();
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
        public bool CopyDetalle_Solicitud_Historial_de_Asignaciones(int MasterId, int referenceId, List<Detalle_Solicitud_Historial_de_AsignacionesGridModelPost> Detalle_Solicitud_Historial_de_AsignacionesItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_Solicitud_Historial_de_AsignacionesApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_Solicitud_Historial_de_AsignacionesData = _IDetalle_Solicitud_Historial_de_AsignacionesApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_Solicitud_Historial_de_Asignaciones.Solicitud=" + referenceId,"").Resource;
                if (Detalle_Solicitud_Historial_de_AsignacionesData == null || Detalle_Solicitud_Historial_de_AsignacionesData.Detalle_Solicitud_Historial_de_Asignacioness.Count == 0)
                    return true;

                var result = true;

                Detalle_Solicitud_Historial_de_AsignacionesGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_Solicitud_Historial_de_Asignaciones in Detalle_Solicitud_Historial_de_AsignacionesData.Detalle_Solicitud_Historial_de_Asignacioness)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_Solicitud_Historial_de_Asignaciones Detalle_Solicitud_Historial_de_Asignaciones1 = varDetalle_Solicitud_Historial_de_Asignaciones;

                    if (Detalle_Solicitud_Historial_de_AsignacionesItems != null && Detalle_Solicitud_Historial_de_AsignacionesItems.Any(m => m.Folio == Detalle_Solicitud_Historial_de_Asignaciones1.Folio))
                    {
                        modelDataToChange = Detalle_Solicitud_Historial_de_AsignacionesItems.FirstOrDefault(m => m.Folio == Detalle_Solicitud_Historial_de_Asignaciones1.Folio);
                    }
                    //Chaning Id Value
                    varDetalle_Solicitud_Historial_de_Asignaciones.Solicitud = MasterId;
                    var insertId = _IDetalle_Solicitud_Historial_de_AsignacionesApiConsumer.Insert(varDetalle_Solicitud_Historial_de_Asignaciones,null,null).Resource;
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
        public ActionResult PostDetalle_Solicitud_Historial_de_Asignaciones(List<Detalle_Solicitud_Historial_de_AsignacionesGridModelPost> Detalle_Solicitud_Historial_de_AsignacionesItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_Solicitud_Historial_de_Asignaciones(MasterId, referenceId, Detalle_Solicitud_Historial_de_AsignacionesItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_Solicitud_Historial_de_AsignacionesItems != null && Detalle_Solicitud_Historial_de_AsignacionesItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_Solicitud_Historial_de_AsignacionesApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_Solicitud_Historial_de_AsignacionesItem in Detalle_Solicitud_Historial_de_AsignacionesItems)
                    {







                        //Removal Request
                        if (Detalle_Solicitud_Historial_de_AsignacionesItem.Removed)
                        {
                            result = result && _IDetalle_Solicitud_Historial_de_AsignacionesApiConsumer.Delete(Detalle_Solicitud_Historial_de_AsignacionesItem.Folio, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_Solicitud_Historial_de_AsignacionesItem.Folio = 0;

                        var Detalle_Solicitud_Historial_de_AsignacionesData = new Detalle_Solicitud_Historial_de_Asignaciones
                        {
                            Solicitud = MasterId
                            ,Folio = Detalle_Solicitud_Historial_de_AsignacionesItem.Folio
                            ,Fecha_cambio = (Detalle_Solicitud_Historial_de_AsignacionesItem.Fecha_cambio!= null) ? DateTime.ParseExact(Detalle_Solicitud_Historial_de_AsignacionesItem.Fecha_cambio, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                            ,Hora_cambio = Detalle_Solicitud_Historial_de_AsignacionesItem.Hora_cambio
                            ,Usuario = (Convert.ToInt32(Detalle_Solicitud_Historial_de_AsignacionesItem.Usuario) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_Solicitud_Historial_de_AsignacionesItem.Usuario))
                            ,Facilitador_Asignado = (Convert.ToInt32(Detalle_Solicitud_Historial_de_AsignacionesItem.Facilitador_Asignado) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_Solicitud_Historial_de_AsignacionesItem.Facilitador_Asignado))
                            ,Motivo_de_cambio = Detalle_Solicitud_Historial_de_AsignacionesItem.Motivo_de_cambio

                        };

                        var resultId = Detalle_Solicitud_Historial_de_AsignacionesItem.Folio > 0
                           ? _IDetalle_Solicitud_Historial_de_AsignacionesApiConsumer.Update(Detalle_Solicitud_Historial_de_AsignacionesData,null,null).Resource
                           : _IDetalle_Solicitud_Historial_de_AsignacionesApiConsumer.Insert(Detalle_Solicitud_Historial_de_AsignacionesData,null,null).Resource;

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
        public ActionResult GetDetalle_Solicitud_Historial_de_Asignaciones_Spartan_UserAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISpartan_UserApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
                    item.Name= CultureHelper.GetTraduction(Convert.ToString(item.Id_User), "Spartan_User", "Name");
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }


        [NonAction]
        public bool CopyDetalle_de_Solicitud_Bitacora_de_Coincid(int MasterId, int referenceId, List<Detalle_de_Solicitud_Bitacora_de_CoincidGridModelPost> Detalle_de_Solicitud_Bitacora_de_CoincidItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_Solicitud_Bitacora_de_CoincidApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_Solicitud_Bitacora_de_CoincidData = _IDetalle_de_Solicitud_Bitacora_de_CoincidApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_Solicitud_Bitacora_de_Coincid.Solicitud=" + referenceId,"").Resource;
                if (Detalle_de_Solicitud_Bitacora_de_CoincidData == null || Detalle_de_Solicitud_Bitacora_de_CoincidData.Detalle_de_Solicitud_Bitacora_de_Coincids.Count == 0)
                    return true;

                var result = true;

                Detalle_de_Solicitud_Bitacora_de_CoincidGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_Solicitud_Bitacora_de_Coincid in Detalle_de_Solicitud_Bitacora_de_CoincidData.Detalle_de_Solicitud_Bitacora_de_Coincids)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_Solicitud_Bitacora_de_Coincid Detalle_de_Solicitud_Bitacora_de_Coincid1 = varDetalle_de_Solicitud_Bitacora_de_Coincid;

                    if (Detalle_de_Solicitud_Bitacora_de_CoincidItems != null && Detalle_de_Solicitud_Bitacora_de_CoincidItems.Any(m => m.Clave == Detalle_de_Solicitud_Bitacora_de_Coincid1.Clave))
                    {
                        modelDataToChange = Detalle_de_Solicitud_Bitacora_de_CoincidItems.FirstOrDefault(m => m.Clave == Detalle_de_Solicitud_Bitacora_de_Coincid1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_de_Solicitud_Bitacora_de_Coincid.Solicitud = MasterId;
                    var insertId = _IDetalle_de_Solicitud_Bitacora_de_CoincidApiConsumer.Insert(varDetalle_de_Solicitud_Bitacora_de_Coincid,null,null).Resource;
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
        public ActionResult PostDetalle_de_Solicitud_Bitacora_de_Coincid(List<Detalle_de_Solicitud_Bitacora_de_CoincidGridModelPost> Detalle_de_Solicitud_Bitacora_de_CoincidItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_Solicitud_Bitacora_de_Coincid(MasterId, referenceId, Detalle_de_Solicitud_Bitacora_de_CoincidItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_Solicitud_Bitacora_de_CoincidItems != null && Detalle_de_Solicitud_Bitacora_de_CoincidItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_Solicitud_Bitacora_de_CoincidApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_Solicitud_Bitacora_de_CoincidItem in Detalle_de_Solicitud_Bitacora_de_CoincidItems)
                    {










                        //Removal Request
                        if (Detalle_de_Solicitud_Bitacora_de_CoincidItem.Removed)
                        {
                            result = result && _IDetalle_de_Solicitud_Bitacora_de_CoincidApiConsumer.Delete(Detalle_de_Solicitud_Bitacora_de_CoincidItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_Solicitud_Bitacora_de_CoincidItem.Clave = 0;

                        var Detalle_de_Solicitud_Bitacora_de_CoincidData = new Detalle_de_Solicitud_Bitacora_de_Coincid
                        {
                            Solicitud = MasterId
                            ,Clave = Detalle_de_Solicitud_Bitacora_de_CoincidItem.Clave
                            ,Nombre_Completo = Detalle_de_Solicitud_Bitacora_de_CoincidItem.Nombre_Completo
                            ,Alias = Detalle_de_Solicitud_Bitacora_de_CoincidItem.Alias
                            ,Numero_de_Expediente = Detalle_de_Solicitud_Bitacora_de_CoincidItem.Numero_de_Expediente
                            ,Fuente_de_Origen = Detalle_de_Solicitud_Bitacora_de_CoincidItem.Fuente_de_Origen
                            ,Tipo_de_Acuerdo = (Convert.ToInt32(Detalle_de_Solicitud_Bitacora_de_CoincidItem.Tipo_de_Acuerdo) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Solicitud_Bitacora_de_CoincidItem.Tipo_de_Acuerdo))
                            ,Cumplido = Detalle_de_Solicitud_Bitacora_de_CoincidItem.Cumplido
                            ,Razon_de_Incumplimiento = (Convert.ToInt32(Detalle_de_Solicitud_Bitacora_de_CoincidItem.Razon_de_Incumplimiento) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Solicitud_Bitacora_de_CoincidItem.Razon_de_Incumplimiento))
                            ,Observaciones = Detalle_de_Solicitud_Bitacora_de_CoincidItem.Observaciones

                        };

                        var resultId = Detalle_de_Solicitud_Bitacora_de_CoincidItem.Clave > 0
                           ? _IDetalle_de_Solicitud_Bitacora_de_CoincidApiConsumer.Update(Detalle_de_Solicitud_Bitacora_de_CoincidData,null,null).Resource
                           : _IDetalle_de_Solicitud_Bitacora_de_CoincidApiConsumer.Insert(Detalle_de_Solicitud_Bitacora_de_CoincidData,null,null).Resource;

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
        public ActionResult GetDetalle_de_Solicitud_Bitacora_de_Coincid_Tipo_de_AcuerdoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_AcuerdoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_AcuerdoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Tipo_de_Acuerdo", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public ActionResult GetDetalle_de_Solicitud_Bitacora_de_Coincid_Razon_de_IncumplimientoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRazon_de_IncumplimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IRazon_de_IncumplimientoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Razon_de_Incumplimiento", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }


        [NonAction]
        public bool CopyDetalle_Historico_JA(int MasterId, int referenceId, List<Detalle_Historico_JAGridModelPost> Detalle_Historico_JAItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_Historico_JAApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_Historico_JAData = _IDetalle_Historico_JAApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_Historico_JA.Solicitud=" + referenceId,"").Resource;
                if (Detalle_Historico_JAData == null || Detalle_Historico_JAData.Detalle_Historico_JAs.Count == 0)
                    return true;

                var result = true;

                Detalle_Historico_JAGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_Historico_JA in Detalle_Historico_JAData.Detalle_Historico_JAs)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_Historico_JA Detalle_Historico_JA1 = varDetalle_Historico_JA;

                    if (Detalle_Historico_JAItems != null && Detalle_Historico_JAItems.Any(m => m.Clave == Detalle_Historico_JA1.Clave))
                    {
                        modelDataToChange = Detalle_Historico_JAItems.FirstOrDefault(m => m.Clave == Detalle_Historico_JA1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_Historico_JA.Solicitud = MasterId;
                    var insertId = _IDetalle_Historico_JAApiConsumer.Insert(varDetalle_Historico_JA,null,null).Resource;
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
        public ActionResult PostDetalle_Historico_JA(List<Detalle_Historico_JAGridModelPost> Detalle_Historico_JAItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_Historico_JA(MasterId, referenceId, Detalle_Historico_JAItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_Historico_JAItems != null && Detalle_Historico_JAItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_Historico_JAApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_Historico_JAItem in Detalle_Historico_JAItems)
                    {






                        //Removal Request
                        if (Detalle_Historico_JAItem.Removed)
                        {
                            result = result && _IDetalle_Historico_JAApiConsumer.Delete(Detalle_Historico_JAItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_Historico_JAItem.Clave = 0;

                        var Detalle_Historico_JAData = new Detalle_Historico_JA
                        {
                            Solicitud = MasterId
                            ,Clave = Detalle_Historico_JAItem.Clave
                            ,Fecha = (Detalle_Historico_JAItem.Fecha!= null) ? DateTime.ParseExact(Detalle_Historico_JAItem.Fecha, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                            ,Hora = Detalle_Historico_JAItem.Hora
                            ,Usuario = (Convert.ToInt32(Detalle_Historico_JAItem.Usuario) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_Historico_JAItem.Usuario))
                            ,Estatus = Detalle_Historico_JAItem.Estatus

                        };

                        var resultId = Detalle_Historico_JAItem.Clave > 0
                           ? _IDetalle_Historico_JAApiConsumer.Update(Detalle_Historico_JAData,null,null).Resource
                           : _IDetalle_Historico_JAApiConsumer.Insert(Detalle_Historico_JAData,null,null).Resource;

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
        public ActionResult GetDetalle_Historico_JA_Spartan_UserAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISpartan_UserApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
                    item.Name= CultureHelper.GetTraduction(Convert.ToString(item.Id_User), "Spartan_User", "Name");
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }




        /// <summary>
        /// Write Element Array of Solicitud script
        /// </summary>
        /// <param name="oSolicitudElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew SolicitudModuleAttributeList)
        {
            for (int i = 0; i < SolicitudModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(SolicitudModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    SolicitudModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(SolicitudModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    SolicitudModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (SolicitudModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < SolicitudModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < SolicitudModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(SolicitudModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							SolicitudModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(SolicitudModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							SolicitudModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strSolicitudScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Solicitud.js")))
            {
                strSolicitudScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Solicitud element attributes
            string userChangeJson = jsSerialize.Serialize(SolicitudModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strSolicitudScript.IndexOf("inpuElementArray");
            string splittedString = strSolicitudScript.Substring(indexOfArray, strSolicitudScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(SolicitudModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (SolicitudModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strSolicitudScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strSolicitudScript.Substring(indexOfArrayHistory, strSolicitudScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strSolicitudScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strSolicitudScript.Substring(endIndexOfMainElement + indexOfArray, strSolicitudScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (SolicitudModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in SolicitudModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Solicitud.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Solicitud.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Solicitud.js")))
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
        public ActionResult SolicitudPropertyBag()
        {
            return PartialView("SolicitudPropertyBag", "Solicitud");
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
        public ActionResult AddDetalle_Solicitud_Historial_de_Asignaciones(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_Solicitud_Historial_de_Asignaciones/AddDetalle_Solicitud_Historial_de_Asignaciones");
        }

        [HttpGet]
        public ActionResult AddDetalle_de_Solicitud_Bitacora_de_Coincid(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_Solicitud_Bitacora_de_Coincid/AddDetalle_de_Solicitud_Bitacora_de_Coincid");
        }

        [HttpGet]
        public ActionResult AddDetalle_Historico_JA(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_Historico_JA/AddDetalle_Historico_JA");
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
                var whereClauseFormat = "Object = 45010 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _ISolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Solicitud.Clave= " + RecordId;
                            var result = _ISolicitudApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _ISolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new SolicitudPropertyMapper());
			
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
                    (SolicitudAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            SolicitudPropertyMapper oSolicitudPropertyMapper = new SolicitudPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oSolicitudPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _ISolicitudApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Solicituds == null)
                result.Solicituds = new List<Solicitud>();

            var data = result.Solicituds.Select(m => new SolicitudGridModel
            {
                Clave = m.Clave
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
			,Numero_de_Folio = m.Numero_de_Folio
                        ,Unidad_MASCDescripcion = CultureHelper.GetTraduction(m.Unidad_MASC_Unidad.Clave.ToString(), "Descripcion") ?? (string)m.Unidad_MASC_Unidad.Descripcion
			,Remitente = m.Remitente
                        ,NUATNUAT = CultureHelper.GetTraduction(m.NUAT_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.NUAT_Modulo_Atencion_Inicial.NUAT
			,NUAT_Codigo = m.NUAT_Codigo
                        ,Expediente_MPInic = CultureHelper.GetTraduction(m.Expediente_MPI_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MPI_expediente_ministerio_publico.nic
                        ,Expediente_CausaPenalObservaciones = CultureHelper.GetTraduction(m.Expediente_CausaPenal_Resolucion_MP.Clave.ToString(), "Resolucion_MP") ?? (string)m.Expediente_CausaPenal_Resolucion_MP.Observaciones
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,RegionDescripcion = CultureHelper.GetTraduction(m.Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Region_Region.Descripcion
			,NUC = m.NUC
			,CDI = m.CDI
			,Causa_Penal = m.Causa_Penal
			,Numero_de_Expediente = m.Numero_de_Expediente
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_Solicitud.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_Solicitud.Descripcion
                        ,Fecha_en_que_llega_a_Coordinador = (m.Fecha_en_que_llega_a_Coordinador == null ? string.Empty : Convert.ToDateTime(m.Fecha_en_que_llega_a_Coordinador).ToString(ConfigurationProperty.DateFormat))
                        ,Fecha_en_que_llega_a_Especialista = (m.Fecha_en_que_llega_a_Especialista == null ? string.Empty : Convert.ToDateTime(m.Fecha_en_que_llega_a_Especialista).ToString(ConfigurationProperty.DateFormat))
                        ,Agente_del_Ministerio_Publico_OrientadorName = CultureHelper.GetTraduction(m.Agente_del_Ministerio_Publico_Orientador_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Agente_del_Ministerio_Publico_Orientador_Spartan_User.Name
                        ,Agente_del_Ministerio_Publico_InvestName = CultureHelper.GetTraduction(m.Agente_del_Ministerio_Publico_Invest_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Agente_del_Ministerio_Publico_Invest_Spartan_User.Name
			,Juez_de_Control = m.Juez_de_Control
                        ,UnidadDescripcion = CultureHelper.GetTraduction(m.Unidad_Unidad.Clave.ToString(), "Descripcion") ?? (string)m.Unidad_Unidad.Descripcion
			,Titulo_del_Hecho = m.Titulo_del_Hecho
                        ,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
			,Narrativa_Breve_de_los_Hechos = m.Narrativa_Breve_de_los_Hechos
			,Hora_Aproximada_del_Hecho = m.Hora_Aproximada_del_Hecho
                        ,Tipo_de_Lugar_del_HechoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Descripcion
                        ,PaisHNombre = CultureHelper.GetTraduction(m.PaisH_Pais.Clave.ToString(), "Pais") ?? (string)m.PaisH_Pais.Nombre
                        ,EstadoHNombre = CultureHelper.GetTraduction(m.EstadoH_Estado.Clave.ToString(), "Estado") ?? (string)m.EstadoH_Estado.Nombre
                        ,MunicipioHNombre = CultureHelper.GetTraduction(m.MunicipioH_Municipio.Clave.ToString(), "Municipio") ?? (string)m.MunicipioH_Municipio.Nombre
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,ColoniaHNombre = CultureHelper.GetTraduction(m.ColoniaH_Colonia.Clave.ToString(), "Colonia") ?? (string)m.ColoniaH_Colonia.Nombre
			,CalleH = m.CalleH
			,Numero_InteriorH = m.Numero_InteriorH
			,Numero_ExteriorH = m.Numero_ExteriorH
			,Codigo_PostalH = m.Codigo_PostalH
			,Entre_Calle = m.Entre_Calle
			,y_Calle = m.y_Calle
			,LongitudH = m.LongitudH
			,LatitudH = m.LatitudH
			,Rechazar = m.Rechazar
                        ,Motivo_de_RechazoDescripcion = CultureHelper.GetTraduction(m.Motivo_de_Rechazo_Motivo_de_Rechazo_de_Solicitud.Clave.ToString(), "Descripcion") ?? (string)m.Motivo_de_Rechazo_Motivo_de_Rechazo_de_Solicitud.Descripcion
                        ,Acuerdo_CumplidoDescripcion = CultureHelper.GetTraduction(m.Acuerdo_Cumplido_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Acuerdo_Cumplido_A_Tiempo.Descripcion
                        ,Razon_de_IncumplimientoDescripcion = CultureHelper.GetTraduction(m.Razon_de_Incumplimiento_Razon_de_Incumplimiento.Clave.ToString(), "Descripcion") ?? (string)m.Razon_de_Incumplimiento_Razon_de_Incumplimiento.Descripcion
                        ,Tipo_de_Conclusion_AnticipadaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Conclusion_Anticipada_Tipo_de_Conclusion_Anticipada.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Conclusion_Anticipada_Tipo_de_Conclusion_Anticipada.Descripcion
                        ,Fecha_de_Cierre = (m.Fecha_de_Cierre == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Cierre).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Cierre = m.Hora_de_Cierre
                        ,Fecha_Validacion = (m.Fecha_Validacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_Validacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_Validacion = m.Hora_Validacion
                        ,Usuario_que_ValidaName = CultureHelper.GetTraduction(m.Usuario_que_Valida_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Valida_Spartan_User.Name
                        ,ResultadoDescripcion = CultureHelper.GetTraduction(m.Resultado_Resultado_de_Revision.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_Resultado_de_Revision.Descripcion
			,Motivo_de_Rechazo_Solicitud = m.Motivo_de_Rechazo_Solicitud
                        ,Especialista_AsignadoAName = CultureHelper.GetTraduction(m.Especialista_AsignadoA_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Especialista_AsignadoA_Spartan_User.Name
			,Motivo_cambio_facilitador = m.Motivo_cambio_facilitador
			,Asignar_Especialista_Automatico = m.Asignar_Especialista_Automatico
			,Razone = m.Razone
                        ,Tipo_de_MecanismoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Mecanismo_Tipo_de_Mecanismo_Alterno.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Mecanismo_Tipo_de_Mecanismo_Alterno.Descripcion
                        ,Fecha_de_AsignacionA = (m.Fecha_de_AsignacionA == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_AsignacionA).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_AsignacionA = m.Hora_de_AsignacionA
                        ,Fecha_de_Atencion_del_Especialista = (m.Fecha_de_Atencion_del_Especialista == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Atencion_del_Especialista).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Atencion_del_Especialista = m.Hora_de_Atencion_del_Especialista

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45010, arrayColumnsVisible), "SolicitudList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45010, arrayColumnsVisible), "SolicitudList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45010, arrayColumnsVisible), "SolicitudList_" + DateTime.Now.ToString());
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

            _ISolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new SolicitudPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (SolicitudAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            SolicitudPropertyMapper oSolicitudPropertyMapper = new SolicitudPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oSolicitudPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _ISolicitudApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Solicituds == null)
                result.Solicituds = new List<Solicitud>();

            var data = result.Solicituds.Select(m => new SolicitudGridModel
            {
                Clave = m.Clave
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
			,Numero_de_Folio = m.Numero_de_Folio
                        ,Unidad_MASCDescripcion = CultureHelper.GetTraduction(m.Unidad_MASC_Unidad.Clave.ToString(), "Descripcion") ?? (string)m.Unidad_MASC_Unidad.Descripcion
			,Remitente = m.Remitente
                        ,NUATNUAT = CultureHelper.GetTraduction(m.NUAT_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.NUAT_Modulo_Atencion_Inicial.NUAT
			,NUAT_Codigo = m.NUAT_Codigo
                        ,Expediente_MPInic = CultureHelper.GetTraduction(m.Expediente_MPI_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MPI_expediente_ministerio_publico.nic
                        ,Expediente_CausaPenalObservaciones = CultureHelper.GetTraduction(m.Expediente_CausaPenal_Resolucion_MP.Clave.ToString(), "Resolucion_MP") ?? (string)m.Expediente_CausaPenal_Resolucion_MP.Observaciones
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,RegionDescripcion = CultureHelper.GetTraduction(m.Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Region_Region.Descripcion
			,NUC = m.NUC
			,CDI = m.CDI
			,Causa_Penal = m.Causa_Penal
			,Numero_de_Expediente = m.Numero_de_Expediente
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_Solicitud.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_Solicitud.Descripcion
                        ,Fecha_en_que_llega_a_Coordinador = (m.Fecha_en_que_llega_a_Coordinador == null ? string.Empty : Convert.ToDateTime(m.Fecha_en_que_llega_a_Coordinador).ToString(ConfigurationProperty.DateFormat))
                        ,Fecha_en_que_llega_a_Especialista = (m.Fecha_en_que_llega_a_Especialista == null ? string.Empty : Convert.ToDateTime(m.Fecha_en_que_llega_a_Especialista).ToString(ConfigurationProperty.DateFormat))
                        ,Agente_del_Ministerio_Publico_OrientadorName = CultureHelper.GetTraduction(m.Agente_del_Ministerio_Publico_Orientador_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Agente_del_Ministerio_Publico_Orientador_Spartan_User.Name
                        ,Agente_del_Ministerio_Publico_InvestName = CultureHelper.GetTraduction(m.Agente_del_Ministerio_Publico_Invest_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Agente_del_Ministerio_Publico_Invest_Spartan_User.Name
			,Juez_de_Control = m.Juez_de_Control
                        ,UnidadDescripcion = CultureHelper.GetTraduction(m.Unidad_Unidad.Clave.ToString(), "Descripcion") ?? (string)m.Unidad_Unidad.Descripcion
			,Titulo_del_Hecho = m.Titulo_del_Hecho
                        ,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
			,Narrativa_Breve_de_los_Hechos = m.Narrativa_Breve_de_los_Hechos
			,Hora_Aproximada_del_Hecho = m.Hora_Aproximada_del_Hecho
                        ,Tipo_de_Lugar_del_HechoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Descripcion
                        ,PaisHNombre = CultureHelper.GetTraduction(m.PaisH_Pais.Clave.ToString(), "Pais") ?? (string)m.PaisH_Pais.Nombre
                        ,EstadoHNombre = CultureHelper.GetTraduction(m.EstadoH_Estado.Clave.ToString(), "Estado") ?? (string)m.EstadoH_Estado.Nombre
                        ,MunicipioHNombre = CultureHelper.GetTraduction(m.MunicipioH_Municipio.Clave.ToString(), "Municipio") ?? (string)m.MunicipioH_Municipio.Nombre
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,ColoniaHNombre = CultureHelper.GetTraduction(m.ColoniaH_Colonia.Clave.ToString(), "Colonia") ?? (string)m.ColoniaH_Colonia.Nombre
			,CalleH = m.CalleH
			,Numero_InteriorH = m.Numero_InteriorH
			,Numero_ExteriorH = m.Numero_ExteriorH
			,Codigo_PostalH = m.Codigo_PostalH
			,Entre_Calle = m.Entre_Calle
			,y_Calle = m.y_Calle
			,LongitudH = m.LongitudH
			,LatitudH = m.LatitudH
			,Rechazar = m.Rechazar
                        ,Motivo_de_RechazoDescripcion = CultureHelper.GetTraduction(m.Motivo_de_Rechazo_Motivo_de_Rechazo_de_Solicitud.Clave.ToString(), "Descripcion") ?? (string)m.Motivo_de_Rechazo_Motivo_de_Rechazo_de_Solicitud.Descripcion
                        ,Acuerdo_CumplidoDescripcion = CultureHelper.GetTraduction(m.Acuerdo_Cumplido_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Acuerdo_Cumplido_A_Tiempo.Descripcion
                        ,Razon_de_IncumplimientoDescripcion = CultureHelper.GetTraduction(m.Razon_de_Incumplimiento_Razon_de_Incumplimiento.Clave.ToString(), "Descripcion") ?? (string)m.Razon_de_Incumplimiento_Razon_de_Incumplimiento.Descripcion
                        ,Tipo_de_Conclusion_AnticipadaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Conclusion_Anticipada_Tipo_de_Conclusion_Anticipada.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Conclusion_Anticipada_Tipo_de_Conclusion_Anticipada.Descripcion
                        ,Fecha_de_Cierre = (m.Fecha_de_Cierre == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Cierre).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Cierre = m.Hora_de_Cierre
                        ,Fecha_Validacion = (m.Fecha_Validacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_Validacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_Validacion = m.Hora_Validacion
                        ,Usuario_que_ValidaName = CultureHelper.GetTraduction(m.Usuario_que_Valida_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Valida_Spartan_User.Name
                        ,ResultadoDescripcion = CultureHelper.GetTraduction(m.Resultado_Resultado_de_Revision.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_Resultado_de_Revision.Descripcion
			,Motivo_de_Rechazo_Solicitud = m.Motivo_de_Rechazo_Solicitud
                        ,Especialista_AsignadoAName = CultureHelper.GetTraduction(m.Especialista_AsignadoA_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Especialista_AsignadoA_Spartan_User.Name
			,Motivo_cambio_facilitador = m.Motivo_cambio_facilitador
			,Asignar_Especialista_Automatico = m.Asignar_Especialista_Automatico
			,Razone = m.Razone
                        ,Tipo_de_MecanismoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Mecanismo_Tipo_de_Mecanismo_Alterno.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Mecanismo_Tipo_de_Mecanismo_Alterno.Descripcion
                        ,Fecha_de_AsignacionA = (m.Fecha_de_AsignacionA == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_AsignacionA).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_AsignacionA = m.Hora_de_AsignacionA
                        ,Fecha_de_Atencion_del_Especialista = (m.Fecha_de_Atencion_del_Especialista == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Atencion_del_Especialista).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Atencion_del_Especialista = m.Hora_de_Atencion_del_Especialista

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
                _ISolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISolicitudApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Solicitud(Solicitud_SolicitudModel varSolicitud)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Solicitud_SolicitudInfo = new Solicitud_Solicitud
                {
                    Clave = varSolicitud.Clave
                                            ,Fecha_de_Registro = (!String.IsNullOrEmpty(varSolicitud.Fecha_de_Registro)) ? DateTime.ParseExact(varSolicitud.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Usuario_que_Registra = varSolicitud.Usuario_que_Registra
                        ,Numero_de_Folio = varSolicitud.Numero_de_Folio
                        ,Unidad_MASC = varSolicitud.Unidad_MASC
                        ,Remitente = varSolicitud.Remitente
                        ,NUAT = varSolicitud.NUAT
                        ,NUAT_Codigo = varSolicitud.NUAT_Codigo
                        ,Expediente_MPI = varSolicitud.Expediente_MPI
                        ,Expediente_CausaPenal = varSolicitud.Expediente_CausaPenal
                        ,Municipio = varSolicitud.Municipio
                        ,Region = varSolicitud.Region
                        ,NUC = varSolicitud.NUC
                        ,CDI = varSolicitud.CDI
                        ,Causa_Penal = varSolicitud.Causa_Penal
                        ,Numero_de_Expediente = varSolicitud.Numero_de_Expediente
                        ,Estatus = varSolicitud.Estatus
                        ,Fecha_en_que_llega_a_Coordinador = (!String.IsNullOrEmpty(varSolicitud.Fecha_en_que_llega_a_Coordinador)) ? DateTime.ParseExact(varSolicitud.Fecha_en_que_llega_a_Coordinador, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Fecha_en_que_llega_a_Especialista = (!String.IsNullOrEmpty(varSolicitud.Fecha_en_que_llega_a_Especialista)) ? DateTime.ParseExact(varSolicitud.Fecha_en_que_llega_a_Especialista, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                    
                };

                result = _ISolicitudApiConsumer.Update_Solicitud(Solicitud_SolicitudInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Solicitud(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _ISolicitudApiConsumer.Get_Solicitud(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_Solicitud_Historial_de_Asignaciones;
                var Detalle_Solicitud_Historial_de_AsignacionesData = GetDetalle_Solicitud_Historial_de_AsignacionesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Solicitud_Historial_de_Asignaciones);
                int RowCount_Detalle_de_Solicitud_Bitacora_de_Coincid;
                var Detalle_de_Solicitud_Bitacora_de_CoincidData = GetDetalle_de_Solicitud_Bitacora_de_CoincidData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Solicitud_Bitacora_de_Coincid);
                int RowCount_Detalle_Historico_JA;
                var Detalle_Historico_JAData = GetDetalle_Historico_JAData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Historico_JA);

                var result = new Solicitud_SolicitudModel
                {
                    Clave = m.Clave
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                        ,Usuario_que_Registra = m.Usuario_que_Registra
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
			,Numero_de_Folio = m.Numero_de_Folio
                        ,Unidad_MASC = m.Unidad_MASC
                        ,Unidad_MASCDescripcion = CultureHelper.GetTraduction(m.Unidad_MASC_Unidad.Clave.ToString(), "Descripcion") ?? (string)m.Unidad_MASC_Unidad.Descripcion
			,Remitente = m.Remitente
                        ,NUAT = m.NUAT
                        ,NUATNUAT = CultureHelper.GetTraduction(m.NUAT_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.NUAT_Modulo_Atencion_Inicial.NUAT
			,NUAT_Codigo = m.NUAT_Codigo
                        ,Expediente_MPI = m.Expediente_MPI
                        ,Expediente_MPInic = CultureHelper.GetTraduction(m.Expediente_MPI_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MPI_expediente_ministerio_publico.nic
                        ,Expediente_CausaPenal = m.Expediente_CausaPenal
                        ,Expediente_CausaPenalObservaciones = CultureHelper.GetTraduction(m.Expediente_CausaPenal_Resolucion_MP.Clave.ToString(), "Resolucion_MP") ?? (string)m.Expediente_CausaPenal_Resolucion_MP.Observaciones
                        ,Municipio = m.Municipio
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,Region = m.Region
                        ,RegionDescripcion = CultureHelper.GetTraduction(m.Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Region_Region.Descripcion
			,NUC = m.NUC
			,CDI = m.CDI
			,Causa_Penal = m.Causa_Penal
			,Numero_de_Expediente = m.Numero_de_Expediente
                        ,Estatus = m.Estatus
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_Solicitud.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_Solicitud.Descripcion
                        ,Fecha_en_que_llega_a_Coordinador = (m.Fecha_en_que_llega_a_Coordinador == null ? string.Empty : Convert.ToDateTime(m.Fecha_en_que_llega_a_Coordinador).ToString(ConfigurationProperty.DateFormat))
                        ,Fecha_en_que_llega_a_Especialista = (m.Fecha_en_que_llega_a_Especialista == null ? string.Empty : Convert.ToDateTime(m.Fecha_en_que_llega_a_Especialista).ToString(ConfigurationProperty.DateFormat))

                    
                };
				var resultData = new
                {
                    data = result
                    ,Historial_de_Asignaciones = Detalle_Solicitud_Historial_de_AsignacionesData
                    ,Coincidencias = Detalle_de_Solicitud_Bitacora_de_CoincidData
                    ,Historial = Detalle_Historico_JAData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Control(Solicitud_ControlModel varSolicitud)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Solicitud_ControlInfo = new Solicitud_Control
                {
                    Clave = varSolicitud.Clave
                                            ,Agente_del_Ministerio_Publico_Orientador = varSolicitud.Agente_del_Ministerio_Publico_Orientador
                        ,Agente_del_Ministerio_Publico_Invest = varSolicitud.Agente_del_Ministerio_Publico_Invest
                        ,Juez_de_Control = varSolicitud.Juez_de_Control
                        ,Unidad = varSolicitud.Unidad
                    
                };

                result = _ISolicitudApiConsumer.Update_Control(Solicitud_ControlInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Control(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _ISolicitudApiConsumer.Get_Control(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_Solicitud_Historial_de_Asignaciones;
                var Detalle_Solicitud_Historial_de_AsignacionesData = GetDetalle_Solicitud_Historial_de_AsignacionesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Solicitud_Historial_de_Asignaciones);
                int RowCount_Detalle_de_Solicitud_Bitacora_de_Coincid;
                var Detalle_de_Solicitud_Bitacora_de_CoincidData = GetDetalle_de_Solicitud_Bitacora_de_CoincidData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Solicitud_Bitacora_de_Coincid);
                int RowCount_Detalle_Historico_JA;
                var Detalle_Historico_JAData = GetDetalle_Historico_JAData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Historico_JA);

                var result = new Solicitud_ControlModel
                {
                    Clave = m.Clave
                        ,Agente_del_Ministerio_Publico_Orientador = m.Agente_del_Ministerio_Publico_Orientador
                        ,Agente_del_Ministerio_Publico_OrientadorName = CultureHelper.GetTraduction(m.Agente_del_Ministerio_Publico_Orientador_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Agente_del_Ministerio_Publico_Orientador_Spartan_User.Name
                        ,Agente_del_Ministerio_Publico_Invest = m.Agente_del_Ministerio_Publico_Invest
                        ,Agente_del_Ministerio_Publico_InvestName = CultureHelper.GetTraduction(m.Agente_del_Ministerio_Publico_Invest_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Agente_del_Ministerio_Publico_Invest_Spartan_User.Name
			,Juez_de_Control = m.Juez_de_Control
                        ,Unidad = m.Unidad
                        ,UnidadDescripcion = CultureHelper.GetTraduction(m.Unidad_Unidad.Clave.ToString(), "Descripcion") ?? (string)m.Unidad_Unidad.Descripcion

                    
                };
				var resultData = new
                {
                    data = result
                    ,Historial_de_Asignaciones = Detalle_Solicitud_Historial_de_AsignacionesData
                    ,Coincidencias = Detalle_de_Solicitud_Bitacora_de_CoincidData
                    ,Historial = Detalle_Historico_JAData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Hechos(Solicitud_HechosModel varSolicitud)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Solicitud_HechosInfo = new Solicitud_Hechos
                {
                    Clave = varSolicitud.Clave
                                            ,Titulo_del_Hecho = varSolicitud.Titulo_del_Hecho
                        ,Fecha_del_Hecho = (!String.IsNullOrEmpty(varSolicitud.Fecha_del_Hecho)) ? DateTime.ParseExact(varSolicitud.Fecha_del_Hecho, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Narrativa_Breve_de_los_Hechos = varSolicitud.Narrativa_Breve_de_los_Hechos
                        ,Hora_Aproximada_del_Hecho = varSolicitud.Hora_Aproximada_del_Hecho
                        ,Tipo_de_Lugar_del_Hecho = varSolicitud.Tipo_de_Lugar_del_Hecho
                        ,PaisH = varSolicitud.PaisH
                        ,EstadoH = varSolicitud.EstadoH
                        ,MunicipioH = varSolicitud.MunicipioH
                        ,Poblacion = varSolicitud.Poblacion
                        ,ColoniaH = varSolicitud.ColoniaH
                        ,CalleH = varSolicitud.CalleH
                        ,Numero_InteriorH = varSolicitud.Numero_InteriorH
                        ,Numero_ExteriorH = varSolicitud.Numero_ExteriorH
                        ,Codigo_PostalH = varSolicitud.Codigo_PostalH
                        ,Entre_Calle = varSolicitud.Entre_Calle
                        ,y_Calle = varSolicitud.y_Calle
                        ,LongitudH = varSolicitud.LongitudH
                        ,LatitudH = varSolicitud.LatitudH
                    
                };

                result = _ISolicitudApiConsumer.Update_Hechos(Solicitud_HechosInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Hechos(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _ISolicitudApiConsumer.Get_Hechos(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_Solicitud_Historial_de_Asignaciones;
                var Detalle_Solicitud_Historial_de_AsignacionesData = GetDetalle_Solicitud_Historial_de_AsignacionesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Solicitud_Historial_de_Asignaciones);
                int RowCount_Detalle_de_Solicitud_Bitacora_de_Coincid;
                var Detalle_de_Solicitud_Bitacora_de_CoincidData = GetDetalle_de_Solicitud_Bitacora_de_CoincidData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Solicitud_Bitacora_de_Coincid);
                int RowCount_Detalle_Historico_JA;
                var Detalle_Historico_JAData = GetDetalle_Historico_JAData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Historico_JA);

                var result = new Solicitud_HechosModel
                {
                    Clave = m.Clave
			,Titulo_del_Hecho = m.Titulo_del_Hecho
                        ,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
			,Narrativa_Breve_de_los_Hechos = m.Narrativa_Breve_de_los_Hechos
			,Hora_Aproximada_del_Hecho = m.Hora_Aproximada_del_Hecho
                        ,Tipo_de_Lugar_del_Hecho = m.Tipo_de_Lugar_del_Hecho
                        ,Tipo_de_Lugar_del_HechoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Descripcion
                        ,PaisH = m.PaisH
                        ,PaisHNombre = CultureHelper.GetTraduction(m.PaisH_Pais.Clave.ToString(), "Pais") ?? (string)m.PaisH_Pais.Nombre
                        ,EstadoH = m.EstadoH
                        ,EstadoHNombre = CultureHelper.GetTraduction(m.EstadoH_Estado.Clave.ToString(), "Estado") ?? (string)m.EstadoH_Estado.Nombre
                        ,MunicipioH = m.MunicipioH
                        ,MunicipioHNombre = CultureHelper.GetTraduction(m.MunicipioH_Municipio.Clave.ToString(), "Municipio") ?? (string)m.MunicipioH_Municipio.Nombre
                        ,Poblacion = m.Poblacion
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,ColoniaH = m.ColoniaH
                        ,ColoniaHNombre = CultureHelper.GetTraduction(m.ColoniaH_Colonia.Clave.ToString(), "Colonia") ?? (string)m.ColoniaH_Colonia.Nombre
			,CalleH = m.CalleH
			,Numero_InteriorH = m.Numero_InteriorH
			,Numero_ExteriorH = m.Numero_ExteriorH
			,Codigo_PostalH = m.Codigo_PostalH
			,Entre_Calle = m.Entre_Calle
			,y_Calle = m.y_Calle
			,LongitudH = m.LongitudH
			,LatitudH = m.LatitudH

                    
                };
				var resultData = new
                {
                    data = result
                    ,Historial_de_Asignaciones = Detalle_Solicitud_Historial_de_AsignacionesData
                    ,Coincidencias = Detalle_de_Solicitud_Bitacora_de_CoincidData
                    ,Historial = Detalle_Historico_JAData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Cierre(Solicitud_CierreModel varSolicitud)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Solicitud_CierreInfo = new Solicitud_Cierre
                {
                    Clave = varSolicitud.Clave
                                            ,Rechazar = varSolicitud.Rechazar
                        ,Motivo_de_Rechazo = varSolicitud.Motivo_de_Rechazo
                        ,Acuerdo_Cumplido = varSolicitud.Acuerdo_Cumplido
                        ,Razon_de_Incumplimiento = varSolicitud.Razon_de_Incumplimiento
                        ,Tipo_de_Conclusion_Anticipada = varSolicitud.Tipo_de_Conclusion_Anticipada
                        ,Fecha_de_Cierre = (!String.IsNullOrEmpty(varSolicitud.Fecha_de_Cierre)) ? DateTime.ParseExact(varSolicitud.Fecha_de_Cierre, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Cierre = varSolicitud.Hora_de_Cierre
                        ,Fecha_Validacion = (!String.IsNullOrEmpty(varSolicitud.Fecha_Validacion)) ? DateTime.ParseExact(varSolicitud.Fecha_Validacion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_Validacion = varSolicitud.Hora_Validacion
                        ,Usuario_que_Valida = varSolicitud.Usuario_que_Valida
                        ,Resultado = varSolicitud.Resultado
                        ,Motivo_de_Rechazo_Solicitud = varSolicitud.Motivo_de_Rechazo_Solicitud
                    
                };

                result = _ISolicitudApiConsumer.Update_Cierre(Solicitud_CierreInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Cierre(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _ISolicitudApiConsumer.Get_Cierre(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_Solicitud_Historial_de_Asignaciones;
                var Detalle_Solicitud_Historial_de_AsignacionesData = GetDetalle_Solicitud_Historial_de_AsignacionesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Solicitud_Historial_de_Asignaciones);
                int RowCount_Detalle_de_Solicitud_Bitacora_de_Coincid;
                var Detalle_de_Solicitud_Bitacora_de_CoincidData = GetDetalle_de_Solicitud_Bitacora_de_CoincidData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Solicitud_Bitacora_de_Coincid);
                int RowCount_Detalle_Historico_JA;
                var Detalle_Historico_JAData = GetDetalle_Historico_JAData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Historico_JA);

                var result = new Solicitud_CierreModel
                {
                    Clave = m.Clave
			,Rechazar = m.Rechazar
                        ,Motivo_de_Rechazo = m.Motivo_de_Rechazo
                        ,Motivo_de_RechazoDescripcion = CultureHelper.GetTraduction(m.Motivo_de_Rechazo_Motivo_de_Rechazo_de_Solicitud.Clave.ToString(), "Descripcion") ?? (string)m.Motivo_de_Rechazo_Motivo_de_Rechazo_de_Solicitud.Descripcion
                        ,Acuerdo_Cumplido = m.Acuerdo_Cumplido
                        ,Acuerdo_CumplidoDescripcion = CultureHelper.GetTraduction(m.Acuerdo_Cumplido_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Acuerdo_Cumplido_A_Tiempo.Descripcion
                        ,Razon_de_Incumplimiento = m.Razon_de_Incumplimiento
                        ,Razon_de_IncumplimientoDescripcion = CultureHelper.GetTraduction(m.Razon_de_Incumplimiento_Razon_de_Incumplimiento.Clave.ToString(), "Descripcion") ?? (string)m.Razon_de_Incumplimiento_Razon_de_Incumplimiento.Descripcion
                        ,Tipo_de_Conclusion_Anticipada = m.Tipo_de_Conclusion_Anticipada
                        ,Tipo_de_Conclusion_AnticipadaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Conclusion_Anticipada_Tipo_de_Conclusion_Anticipada.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Conclusion_Anticipada_Tipo_de_Conclusion_Anticipada.Descripcion
                        ,Fecha_de_Cierre = (m.Fecha_de_Cierre == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Cierre).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Cierre = m.Hora_de_Cierre
                        ,Fecha_Validacion = (m.Fecha_Validacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_Validacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_Validacion = m.Hora_Validacion
                        ,Usuario_que_Valida = m.Usuario_que_Valida
                        ,Usuario_que_ValidaName = CultureHelper.GetTraduction(m.Usuario_que_Valida_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Valida_Spartan_User.Name
                        ,Resultado = m.Resultado
                        ,ResultadoDescripcion = CultureHelper.GetTraduction(m.Resultado_Resultado_de_Revision.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_Resultado_de_Revision.Descripcion
			,Motivo_de_Rechazo_Solicitud = m.Motivo_de_Rechazo_Solicitud

                    
                };
				var resultData = new
                {
                    data = result
                    ,Historial_de_Asignaciones = Detalle_Solicitud_Historial_de_AsignacionesData
                    ,Coincidencias = Detalle_de_Solicitud_Bitacora_de_CoincidData
                    ,Historial = Detalle_Historico_JAData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Asignacion(Solicitud_AsignacionModel varSolicitud)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Solicitud_AsignacionInfo = new Solicitud_Asignacion
                {
                    Clave = varSolicitud.Clave
                                            ,Especialista_AsignadoA = varSolicitud.Especialista_AsignadoA
                        ,Motivo_cambio_facilitador = varSolicitud.Motivo_cambio_facilitador
                        ,Asignar_Especialista_Automatico = varSolicitud.Asignar_Especialista_Automatico
                        ,Razone = varSolicitud.Razone
                        ,Tipo_de_Mecanismo = varSolicitud.Tipo_de_Mecanismo
                        ,Fecha_de_AsignacionA = (!String.IsNullOrEmpty(varSolicitud.Fecha_de_AsignacionA)) ? DateTime.ParseExact(varSolicitud.Fecha_de_AsignacionA, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_AsignacionA = varSolicitud.Hora_de_AsignacionA
                        ,Fecha_de_Atencion_del_Especialista = (!String.IsNullOrEmpty(varSolicitud.Fecha_de_Atencion_del_Especialista)) ? DateTime.ParseExact(varSolicitud.Fecha_de_Atencion_del_Especialista, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Atencion_del_Especialista = varSolicitud.Hora_de_Atencion_del_Especialista
                    
                };

                result = _ISolicitudApiConsumer.Update_Asignacion(Solicitud_AsignacionInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Asignacion(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _ISolicitudApiConsumer.Get_Asignacion(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_Solicitud_Historial_de_Asignaciones;
                var Detalle_Solicitud_Historial_de_AsignacionesData = GetDetalle_Solicitud_Historial_de_AsignacionesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Solicitud_Historial_de_Asignaciones);
                int RowCount_Detalle_de_Solicitud_Bitacora_de_Coincid;
                var Detalle_de_Solicitud_Bitacora_de_CoincidData = GetDetalle_de_Solicitud_Bitacora_de_CoincidData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Solicitud_Bitacora_de_Coincid);
                int RowCount_Detalle_Historico_JA;
                var Detalle_Historico_JAData = GetDetalle_Historico_JAData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Historico_JA);

                var result = new Solicitud_AsignacionModel
                {
                    Clave = m.Clave
                        ,Especialista_AsignadoA = m.Especialista_AsignadoA
                        ,Especialista_AsignadoAName = CultureHelper.GetTraduction(m.Especialista_AsignadoA_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Especialista_AsignadoA_Spartan_User.Name
			,Motivo_cambio_facilitador = m.Motivo_cambio_facilitador
			,Asignar_Especialista_Automatico = m.Asignar_Especialista_Automatico
			,Razone = m.Razone
                        ,Tipo_de_Mecanismo = m.Tipo_de_Mecanismo
                        ,Tipo_de_MecanismoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Mecanismo_Tipo_de_Mecanismo_Alterno.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Mecanismo_Tipo_de_Mecanismo_Alterno.Descripcion
                        ,Fecha_de_AsignacionA = (m.Fecha_de_AsignacionA == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_AsignacionA).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_AsignacionA = m.Hora_de_AsignacionA
                        ,Fecha_de_Atencion_del_Especialista = (m.Fecha_de_Atencion_del_Especialista == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Atencion_del_Especialista).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Atencion_del_Especialista = m.Hora_de_Atencion_del_Especialista

                    
                };
				var resultData = new
                {
                    data = result
                    ,Historial_de_Asignaciones = Detalle_Solicitud_Historial_de_AsignacionesData
                    ,Coincidencias = Detalle_de_Solicitud_Bitacora_de_CoincidData
                    ,Historial = Detalle_Historico_JAData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Bitacora_de_Coincidencias(Solicitud_Bitacora_de_CoincidenciasModel varSolicitud)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Solicitud_Bitacora_de_CoincidenciasInfo = new Solicitud_Bitacora_de_Coincidencias
                {
                    Clave = varSolicitud.Clave
                                        
                };

                result = _ISolicitudApiConsumer.Update_Bitacora_de_Coincidencias(Solicitud_Bitacora_de_CoincidenciasInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Bitacora_de_Coincidencias(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _ISolicitudApiConsumer.Get_Bitacora_de_Coincidencias(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_Solicitud_Historial_de_Asignaciones;
                var Detalle_Solicitud_Historial_de_AsignacionesData = GetDetalle_Solicitud_Historial_de_AsignacionesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Solicitud_Historial_de_Asignaciones);
                int RowCount_Detalle_de_Solicitud_Bitacora_de_Coincid;
                var Detalle_de_Solicitud_Bitacora_de_CoincidData = GetDetalle_de_Solicitud_Bitacora_de_CoincidData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Solicitud_Bitacora_de_Coincid);
                int RowCount_Detalle_Historico_JA;
                var Detalle_Historico_JAData = GetDetalle_Historico_JAData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Historico_JA);

                var result = new Solicitud_Bitacora_de_CoincidenciasModel
                {
                    Clave = m.Clave

                    
                };
				var resultData = new
                {
                    data = result
                    ,Historial_de_Asignaciones = Detalle_Solicitud_Historial_de_AsignacionesData
                    ,Coincidencias = Detalle_de_Solicitud_Bitacora_de_CoincidData
                    ,Historial = Detalle_Historico_JAData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Historial_de_Movimientos(Solicitud_Historial_de_MovimientosModel varSolicitud)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Solicitud_Historial_de_MovimientosInfo = new Solicitud_Historial_de_Movimientos
                {
                    Clave = varSolicitud.Clave
                                        
                };

                result = _ISolicitudApiConsumer.Update_Historial_de_Movimientos(Solicitud_Historial_de_MovimientosInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Historial_de_Movimientos(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _ISolicitudApiConsumer.Get_Historial_de_Movimientos(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_Solicitud_Historial_de_Asignaciones;
                var Detalle_Solicitud_Historial_de_AsignacionesData = GetDetalle_Solicitud_Historial_de_AsignacionesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Solicitud_Historial_de_Asignaciones);
                int RowCount_Detalle_de_Solicitud_Bitacora_de_Coincid;
                var Detalle_de_Solicitud_Bitacora_de_CoincidData = GetDetalle_de_Solicitud_Bitacora_de_CoincidData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Solicitud_Bitacora_de_Coincid);
                int RowCount_Detalle_Historico_JA;
                var Detalle_Historico_JAData = GetDetalle_Historico_JAData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Historico_JA);

                var result = new Solicitud_Historial_de_MovimientosModel
                {
                    Clave = m.Clave

                    
                };
				var resultData = new
                {
                    data = result
                    ,Historial_de_Asignaciones = Detalle_Solicitud_Historial_de_AsignacionesData
                    ,Coincidencias = Detalle_de_Solicitud_Bitacora_de_CoincidData
                    ,Historial = Detalle_Historico_JAData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }


    }
}

