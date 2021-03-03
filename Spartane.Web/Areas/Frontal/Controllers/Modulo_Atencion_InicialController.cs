using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Modulo_Atencion_Inicial;
using Spartane.Core.Domain.Asignacion_de_Turnos;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Unidad;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Region;
using Spartane.Core.Domain.Tipo_de_Denuncia;
using Spartane.Core.Domain.Estatus;
using Spartane.Core.Domain.Delegacion;
using Spartane.Core.Domain.Agencia;
using Spartane.Core.Domain.Jefes_de_Usuarios_del_Sistema;
using Spartane.Core.Domain.Solicitud_de_Denuncia_Ciudadana;
using Spartane.Core.Domain.Genero;
using Spartane.Core.Domain.Tipo_de_Atencion;
using Spartane.Core.Domain.Tipo_de_Identificacion;
using Spartane.Core.Domain.Tipo_de_Urgencia;
using Spartane.Core.Domain.Motivo_Finalizacion_Turno;
using Spartane.Core.Domain.Prioridad_del_Hecho;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Documento_Extraviado;
using Spartane.Core.Domain.Lugar_Tipo;
using Spartane.Core.Domain.Zona;
using Spartane.Core.Domain.Detalle_de_coincidencias_a;






using Spartane.Core.Domain.Detalle_Historico_MPO;







using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Modulo_Atencion_Inicial;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Modulo_Atencion_Inicial;
using Spartane.Web.Areas.WebApiConsumer.Asignacion_de_Turnos;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Unidad;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Region;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Denuncia;
using Spartane.Web.Areas.WebApiConsumer.Estatus;
using Spartane.Web.Areas.WebApiConsumer.Delegacion;
using Spartane.Web.Areas.WebApiConsumer.Agencia;
using Spartane.Web.Areas.WebApiConsumer.Jefes_de_Usuarios_del_Sistema;
using Spartane.Web.Areas.WebApiConsumer.Solicitud_de_Denuncia_Ciudadana;
using Spartane.Web.Areas.WebApiConsumer.Genero;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Atencion;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Identificacion;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Urgencia;
using Spartane.Web.Areas.WebApiConsumer.Motivo_Finalizacion_Turno;
using Spartane.Web.Areas.WebApiConsumer.Prioridad_del_Hecho;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Documento_Extraviado;
using Spartane.Web.Areas.WebApiConsumer.Lugar_Tipo;
using Spartane.Web.Areas.WebApiConsumer.Zona;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_coincidencias_a;


using Spartane.Web.Areas.WebApiConsumer.Detalle_Historico_MPO;





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
    public class Modulo_Atencion_InicialController : Controller
    {
        #region "variable declaration"

        private IModulo_Atencion_InicialService service = null;
        private IModulo_Atencion_InicialApiConsumer _IModulo_Atencion_InicialApiConsumer;
        private IAsignacion_de_TurnosApiConsumer _IAsignacion_de_TurnosApiConsumer;
        private ISpartan_UserApiConsumer _ISpartan_UserApiConsumer;
        private IUnidadApiConsumer _IUnidadApiConsumer;
        private IMunicipioApiConsumer _IMunicipioApiConsumer;
        private IRegionApiConsumer _IRegionApiConsumer;
        private ITipo_de_DenunciaApiConsumer _ITipo_de_DenunciaApiConsumer;
        private IEstatusApiConsumer _IEstatusApiConsumer;
        private IDelegacionApiConsumer _IDelegacionApiConsumer;
        private IAgenciaApiConsumer _IAgenciaApiConsumer;
        private IJefes_de_Usuarios_del_SistemaApiConsumer _IJefes_de_Usuarios_del_SistemaApiConsumer;
        private ISolicitud_de_Denuncia_CiudadanaApiConsumer _ISolicitud_de_Denuncia_CiudadanaApiConsumer;
        private IGeneroApiConsumer _IGeneroApiConsumer;
        private ITipo_de_AtencionApiConsumer _ITipo_de_AtencionApiConsumer;
        private ITipo_de_IdentificacionApiConsumer _ITipo_de_IdentificacionApiConsumer;
        private ITipo_de_UrgenciaApiConsumer _ITipo_de_UrgenciaApiConsumer;
        private IMotivo_Finalizacion_TurnoApiConsumer _IMotivo_Finalizacion_TurnoApiConsumer;
        private IPrioridad_del_HechoApiConsumer _IPrioridad_del_HechoApiConsumer;
        private IPaisApiConsumer _IPaisApiConsumer;
        private IEstadoApiConsumer _IEstadoApiConsumer;
        private IColoniaApiConsumer _IColoniaApiConsumer;
        private IDocumento_ExtraviadoApiConsumer _IDocumento_ExtraviadoApiConsumer;
        private ILugar_TipoApiConsumer _ILugar_TipoApiConsumer;
        private IZonaApiConsumer _IZonaApiConsumer;
        private IDetalle_de_coincidencias_aApiConsumer _IDetalle_de_coincidencias_aApiConsumer;


        private IDetalle_Historico_MPOApiConsumer _IDetalle_Historico_MPOApiConsumer;





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

        
        public Modulo_Atencion_InicialController(IModulo_Atencion_InicialService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IModulo_Atencion_InicialApiConsumer Modulo_Atencion_InicialApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , IAsignacion_de_TurnosApiConsumer Asignacion_de_TurnosApiConsumer , ISpartan_UserApiConsumer Spartan_UserApiConsumer , IUnidadApiConsumer UnidadApiConsumer , IMunicipioApiConsumer MunicipioApiConsumer , IRegionApiConsumer RegionApiConsumer , ITipo_de_DenunciaApiConsumer Tipo_de_DenunciaApiConsumer , IEstatusApiConsumer EstatusApiConsumer , IDelegacionApiConsumer DelegacionApiConsumer , IAgenciaApiConsumer AgenciaApiConsumer , IJefes_de_Usuarios_del_SistemaApiConsumer Jefes_de_Usuarios_del_SistemaApiConsumer , ISolicitud_de_Denuncia_CiudadanaApiConsumer Solicitud_de_Denuncia_CiudadanaApiConsumer , IGeneroApiConsumer GeneroApiConsumer , ITipo_de_AtencionApiConsumer Tipo_de_AtencionApiConsumer , ITipo_de_IdentificacionApiConsumer Tipo_de_IdentificacionApiConsumer , ITipo_de_UrgenciaApiConsumer Tipo_de_UrgenciaApiConsumer , IMotivo_Finalizacion_TurnoApiConsumer Motivo_Finalizacion_TurnoApiConsumer , IPrioridad_del_HechoApiConsumer Prioridad_del_HechoApiConsumer , IPaisApiConsumer PaisApiConsumer , IEstadoApiConsumer EstadoApiConsumer , IColoniaApiConsumer ColoniaApiConsumer , IDocumento_ExtraviadoApiConsumer Documento_ExtraviadoApiConsumer , ILugar_TipoApiConsumer Lugar_TipoApiConsumer , IZonaApiConsumer ZonaApiConsumer , IDetalle_de_coincidencias_aApiConsumer Detalle_de_coincidencias_aApiConsumer  , IDetalle_Historico_MPOApiConsumer Detalle_Historico_MPOApiConsumer  )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IModulo_Atencion_InicialApiConsumer = Modulo_Atencion_InicialApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_FormatApiConsumer = Spartan_FormatApiConsumer;
            this._ISpartan_Format_PermissionsApiConsumer = Spartan_Format_PermissionsApiConsumer;
            this._IGeneratePDFApiConsumer = GeneratePDFApiConsumer;
			this._ISpartan_FormatRelatedApiConsumer = Spartan_Format_RelatedApiConsumer;
            this._IAsignacion_de_TurnosApiConsumer = Asignacion_de_TurnosApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._IUnidadApiConsumer = UnidadApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IRegionApiConsumer = RegionApiConsumer;
            this._ITipo_de_DenunciaApiConsumer = Tipo_de_DenunciaApiConsumer;
            this._IEstatusApiConsumer = EstatusApiConsumer;
            this._IDelegacionApiConsumer = DelegacionApiConsumer;
            this._IAgenciaApiConsumer = AgenciaApiConsumer;
            this._IJefes_de_Usuarios_del_SistemaApiConsumer = Jefes_de_Usuarios_del_SistemaApiConsumer;
            this._ISolicitud_de_Denuncia_CiudadanaApiConsumer = Solicitud_de_Denuncia_CiudadanaApiConsumer;
            this._IGeneroApiConsumer = GeneroApiConsumer;
            this._ITipo_de_AtencionApiConsumer = Tipo_de_AtencionApiConsumer;
            this._ITipo_de_IdentificacionApiConsumer = Tipo_de_IdentificacionApiConsumer;
            this._ITipo_de_UrgenciaApiConsumer = Tipo_de_UrgenciaApiConsumer;
            this._IMotivo_Finalizacion_TurnoApiConsumer = Motivo_Finalizacion_TurnoApiConsumer;
            this._IPrioridad_del_HechoApiConsumer = Prioridad_del_HechoApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._IPaisApiConsumer = PaisApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._IDocumento_ExtraviadoApiConsumer = Documento_ExtraviadoApiConsumer;
            this._ILugar_TipoApiConsumer = Lugar_TipoApiConsumer;
            this._IZonaApiConsumer = ZonaApiConsumer;
            this._IDetalle_de_coincidencias_aApiConsumer = Detalle_de_coincidencias_aApiConsumer;


            this._IDetalle_Historico_MPOApiConsumer = Detalle_Historico_MPOApiConsumer;





        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Modulo_Atencion_Inicial
        [ObjectAuth(ObjectId = (ModuleObjectId)45004, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45004, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Modulo_Atencion_Inicial/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45004, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45004, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varModulo_Atencion_Inicial = new Modulo_Atencion_InicialModel();
			varModulo_Atencion_Inicial.Clave = Id;
			
            ViewBag.ObjectId = "45004";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;

            var permissionDetalle_de_coincidencias_a = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45117, ModuleId);
            ViewBag.PermissionDetalle_de_coincidencias_a = permissionDetalle_de_coincidencias_a;
            var permissionDetalle_Historico_MPO = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45191, ModuleId);
            ViewBag.PermissionDetalle_Historico_MPO = permissionDetalle_Historico_MPO;


            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IModulo_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Modulo_Atencion_InicialsData = _IModulo_Atencion_InicialApiConsumer.ListaSelAll(0, 1000, "Modulo_Atencion_Inicial.Clave=" + Id, "").Resource.Modulo_Atencion_Inicials;
				
				if (Modulo_Atencion_InicialsData != null && Modulo_Atencion_InicialsData.Count > 0)
                {
					var Modulo_Atencion_InicialData = Modulo_Atencion_InicialsData.First();
					varModulo_Atencion_Inicial= new Modulo_Atencion_InicialModel
					{
						Clave  = Modulo_Atencion_InicialData.Clave 
	                    ,Folio = Modulo_Atencion_InicialData.Folio
                    ,Fecha_de_Registro = (Modulo_Atencion_InicialData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(Modulo_Atencion_InicialData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Registro = Modulo_Atencion_InicialData.Hora_de_Registro
                    ,Turno_Asignado = Modulo_Atencion_InicialData.Turno_Asignado
                    ,Turno_AsignadoNumero_de_Turno = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Turno_Asignado), "Asignacion_de_Turnos") ??  (string)Modulo_Atencion_InicialData.Turno_Asignado_Asignacion_de_Turnos.Numero_de_Turno
                    ,Usuario_que_Registra = Modulo_Atencion_InicialData.Usuario_que_Registra
                    ,Usuario_que_RegistraName = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Usuario_que_Registra), "Spartan_User") ??  (string)Modulo_Atencion_InicialData.Usuario_que_Registra_Spartan_User.Name
                    ,Unidad = Modulo_Atencion_InicialData.Unidad
                    ,UnidadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Unidad), "Unidad") ??  (string)Modulo_Atencion_InicialData.Unidad_Unidad.Descripcion
                    ,Municipio = Modulo_Atencion_InicialData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Municipio), "Municipio") ??  (string)Modulo_Atencion_InicialData.Municipio_Municipio.Nombre
                    ,Region = Modulo_Atencion_InicialData.Region
                    ,RegionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Region), "Region") ??  (string)Modulo_Atencion_InicialData.Region_Region.Descripcion
                    ,Tipo_de_Denuncia = Modulo_Atencion_InicialData.Tipo_de_Denuncia
                    ,Tipo_de_DenunciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Tipo_de_Denuncia), "Tipo_de_Denuncia") ??  (string)Modulo_Atencion_InicialData.Tipo_de_Denuncia_Tipo_de_Denuncia.Descripcion
                    ,NUAT = Modulo_Atencion_InicialData.NUAT
                    ,CDI = Modulo_Atencion_InicialData.CDI
                    ,Expedientes_Relacionados = Modulo_Atencion_InicialData.Expedientes_Relacionados
                    ,Estatus = Modulo_Atencion_InicialData.Estatus
                    ,EstatusDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Estatus), "Estatus") ??  (string)Modulo_Atencion_InicialData.Estatus_Estatus.Descripcion
                    ,Generar_Cita = (Modulo_Atencion_InicialData.Generar_Cita == null ? string.Empty : Convert.ToDateTime(Modulo_Atencion_InicialData.Generar_Cita).ToString(ConfigurationProperty.DateFormat))
                    ,Nombres_del_Remitente = Modulo_Atencion_InicialData.Nombres_del_Remitente
                    ,Apellido_Paterno_del_Remitente = Modulo_Atencion_InicialData.Apellido_Paterno_del_Remitente
                    ,Apellido_Materno_del_Remitente = Modulo_Atencion_InicialData.Apellido_Materno_del_Remitente
                    ,Fecha_en_que_llega_para_validacion = (Modulo_Atencion_InicialData.Fecha_en_que_llega_para_validacion == null ? string.Empty : Convert.ToDateTime(Modulo_Atencion_InicialData.Fecha_en_que_llega_para_validacion).ToString(ConfigurationProperty.DateFormat))
                    ,Delegacion = Modulo_Atencion_InicialData.Delegacion
                    ,DelegacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Delegacion), "Delegacion") ??  (string)Modulo_Atencion_InicialData.Delegacion_Delegacion.Descripcion
                    ,Agencia = Modulo_Atencion_InicialData.Agencia
                    ,AgenciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Agencia), "Agencia") ??  (string)Modulo_Atencion_InicialData.Agencia_Agencia.Descripcion
                    ,Ministerio_Publico_en_Turno = Modulo_Atencion_InicialData.Ministerio_Publico_en_Turno
                    ,Ministerio_Publico_en_TurnoMinisterio_Publico_en_Turno = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Ministerio_Publico_en_Turno), "Jefes_de_Usuarios_del_Sistema") ??  (string)Modulo_Atencion_InicialData.Ministerio_Publico_en_Turno_Jefes_de_Usuarios_del_Sistema.Ministerio_Publico_en_Turno
                    ,Solicitud_de_Denuncia_Ciudadana = Modulo_Atencion_InicialData.Solicitud_de_Denuncia_Ciudadana
                    ,Solicitud_de_Denuncia_CiudadanaFolio = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Solicitud_de_Denuncia_Ciudadana), "Solicitud_de_Denuncia_Ciudadana") ??  (string)Modulo_Atencion_InicialData.Solicitud_de_Denuncia_Ciudadana_Solicitud_de_Denuncia_Ciudadana.Folio
                    ,Nombres_turno = Modulo_Atencion_InicialData.Nombres_turno
                    ,Apellido_Paterno_turno = Modulo_Atencion_InicialData.Apellido_Paterno_turno
                    ,Apellido_Materno_turno = Modulo_Atencion_InicialData.Apellido_Materno_turno
                    ,Sexo_turno = Modulo_Atencion_InicialData.Sexo_turno
                    ,Sexo_turnoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Sexo_turno), "Genero") ??  (string)Modulo_Atencion_InicialData.Sexo_turno_Genero.Descripcion
                    ,Edad_turno = Modulo_Atencion_InicialData.Edad_turno
                    ,Tipo_de_Atencion_turno = Modulo_Atencion_InicialData.Tipo_de_Atencion_turno
                    ,Tipo_de_Atencion_turnoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Tipo_de_Atencion_turno), "Tipo_de_Atencion") ??  (string)Modulo_Atencion_InicialData.Tipo_de_Atencion_turno_Tipo_de_Atencion.Descripcion
                    ,Tipo_de_Identificacion_turno = Modulo_Atencion_InicialData.Tipo_de_Identificacion_turno
                    ,Tipo_de_Identificacion_turnoNombre = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Tipo_de_Identificacion_turno), "Tipo_de_Identificacion") ??  (string)Modulo_Atencion_InicialData.Tipo_de_Identificacion_turno_Tipo_de_Identificacion.Nombre
                    ,Numero_de_Identificacion_turno = Modulo_Atencion_InicialData.Numero_de_Identificacion_turno
                    ,Urgencia_turno = Modulo_Atencion_InicialData.Urgencia_turno.GetValueOrDefault()
                    ,Tipo_de_Urgencia_turno = Modulo_Atencion_InicialData.Tipo_de_Urgencia_turno
                    ,Tipo_de_Urgencia_turnoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Tipo_de_Urgencia_turno), "Tipo_de_Urgencia") ??  (string)Modulo_Atencion_InicialData.Tipo_de_Urgencia_turno_Tipo_de_Urgencia.Descripcion
                    ,Motivo_Finalizacion_Turno = Modulo_Atencion_InicialData.Motivo_Finalizacion_Turno
                    ,Motivo_Finalizacion_TurnoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Motivo_Finalizacion_Turno), "Motivo_Finalizacion_Turno") ??  (string)Modulo_Atencion_InicialData.Motivo_Finalizacion_Turno_Motivo_Finalizacion_Turno.Descripcion
                    ,Observaciones_turno = Modulo_Atencion_InicialData.Observaciones_turno
                    ,Titulo_del_Hecho = Modulo_Atencion_InicialData.Titulo_del_Hecho
                    ,Narrativa_Breve_de_los_Hechos = Modulo_Atencion_InicialData.Narrativa_Breve_de_los_Hechos
                    ,Prioridad_del_Hecho = Modulo_Atencion_InicialData.Prioridad_del_Hecho
                    ,Prioridad_del_HechoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Prioridad_del_Hecho), "Prioridad_del_Hecho") ??  (string)Modulo_Atencion_InicialData.Prioridad_del_Hecho_Prioridad_del_Hecho.Descripcion
                    ,Orientador = Modulo_Atencion_InicialData.Orientador
                    ,OrientadorName = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Orientador), "Spartan_User") ??  (string)Modulo_Atencion_InicialData.Orientador_Spartan_User.Name
                    ,Fecha_del_Hecho = (Modulo_Atencion_InicialData.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(Modulo_Atencion_InicialData.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_del_Hecho = Modulo_Atencion_InicialData.Hora_del_Hecho
                    ,Pais_de_los_Hechos = Modulo_Atencion_InicialData.Pais_de_los_Hechos
                    ,Pais_de_los_HechosNombre = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Pais_de_los_Hechos), "Pais") ??  (string)Modulo_Atencion_InicialData.Pais_de_los_Hechos_Pais.Nombre
                    ,Estado_de_los_Hechos = Modulo_Atencion_InicialData.Estado_de_los_Hechos
                    ,Estado_de_los_HechosNombre = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Estado_de_los_Hechos), "Estado") ??  (string)Modulo_Atencion_InicialData.Estado_de_los_Hechos_Estado.Nombre
                    ,Municipio_de_los_Hechos = Modulo_Atencion_InicialData.Municipio_de_los_Hechos
                    ,Municipio_de_los_HechosNombre = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Municipio_de_los_Hechos), "Municipio") ??  (string)Modulo_Atencion_InicialData.Municipio_de_los_Hechos_Municipio.Nombre
                    ,Poblacion = Modulo_Atencion_InicialData.Poblacion
                    ,PoblacionNombre = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Poblacion), "Colonia") ??  (string)Modulo_Atencion_InicialData.Poblacion_Colonia.Nombre
                    ,Colonia_de_los_Hechos = Modulo_Atencion_InicialData.Colonia_de_los_Hechos
                    ,Colonia_de_los_HechosNombre = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Colonia_de_los_Hechos), "Colonia") ??  (string)Modulo_Atencion_InicialData.Colonia_de_los_Hechos_Colonia.Nombre
                    ,Codigo_Postal_de_los_Hechos = Modulo_Atencion_InicialData.Codigo_Postal_de_los_Hechos
                    ,Calle_de_los_Hechos = Modulo_Atencion_InicialData.Calle_de_los_Hechos
                    ,Entre_Calle = Modulo_Atencion_InicialData.Entre_Calle
                    ,Y_Calle = Modulo_Atencion_InicialData.Y_Calle
                    ,Numero_Exrterior_de_los_Hechos = Modulo_Atencion_InicialData.Numero_Exrterior_de_los_Hechos
                    ,Numero_Interior_de_los_Hechos = Modulo_Atencion_InicialData.Numero_Interior_de_los_Hechos
                    ,Referencia_hechos = Modulo_Atencion_InicialData.Referencia_hechos
                    ,Latitud = Modulo_Atencion_InicialData.Latitud
                    ,Longitud = Modulo_Atencion_InicialData.Longitud
                    ,Documento_Extraviado_hechos = Modulo_Atencion_InicialData.Documento_Extraviado_hechos.GetValueOrDefault()
                    ,Tipo_de_Documento_Extraviado = Modulo_Atencion_InicialData.Tipo_de_Documento_Extraviado
                    ,Tipo_de_Documento_ExtraviadoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Tipo_de_Documento_Extraviado), "Documento_Extraviado") ??  (string)Modulo_Atencion_InicialData.Tipo_de_Documento_Extraviado_Documento_Extraviado.Descripcion
                    ,Tipo_de_Lugar_del_Hecho = Modulo_Atencion_InicialData.Tipo_de_Lugar_del_Hecho
                    ,Tipo_de_Lugar_del_HechoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Tipo_de_Lugar_del_Hecho), "Lugar_Tipo") ??  (string)Modulo_Atencion_InicialData.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Descripcion
                    ,Zona_de_los_Hechos = Modulo_Atencion_InicialData.Zona_de_los_Hechos
                    ,Zona_de_los_HechosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Zona_de_los_Hechos), "Zona") ??  (string)Modulo_Atencion_InicialData.Zona_de_los_Hechos_Zona.Descripcion
                    ,Turno = Modulo_Atencion_InicialData.Turno
                    ,Cerrar = Modulo_Atencion_InicialData.Cerrar.GetValueOrDefault()
                    ,Fecha_de_Cierre = (Modulo_Atencion_InicialData.Fecha_de_Cierre == null ? string.Empty : Convert.ToDateTime(Modulo_Atencion_InicialData.Fecha_de_Cierre).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Cierre = Modulo_Atencion_InicialData.Hora_de_Cierre

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IUnidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Unidads_Unidad = _IUnidadApiConsumer.SelAll(true);
            if (Unidads_Unidad != null && Unidads_Unidad.Resource != null)
                ViewBag.Unidads_Unidad = Unidads_Unidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
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
            _ITipo_de_DenunciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Denuncias_Tipo_de_Denuncia = _ITipo_de_DenunciaApiConsumer.SelAll(true);
            if (Tipo_de_Denuncias_Tipo_de_Denuncia != null && Tipo_de_Denuncias_Tipo_de_Denuncia.Resource != null)
                ViewBag.Tipo_de_Denuncias_Tipo_de_Denuncia = Tipo_de_Denuncias_Tipo_de_Denuncia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Denuncia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatusApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatuss_Estatus = _IEstatusApiConsumer.SelAll(true);
            if (Estatuss_Estatus != null && Estatuss_Estatus.Resource != null)
                ViewBag.Estatuss_Estatus = Estatuss_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDelegacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Delegacions_Delegacion = _IDelegacionApiConsumer.SelAll(true);
            if (Delegacions_Delegacion != null && Delegacions_Delegacion.Resource != null)
                ViewBag.Delegacions_Delegacion = Delegacions_Delegacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delegacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAgenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Agencias_Agencia = _IAgenciaApiConsumer.SelAll(true);
            if (Agencias_Agencia != null && Agencias_Agencia.Resource != null)
                ViewBag.Agencias_Agencia = Agencias_Agencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.ClaveID), "Agencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.ClaveID)
                }).ToList();
            _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Generos_Sexo_turno = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Sexo_turno != null && Generos_Sexo_turno.Resource != null)
                ViewBag.Generos_Sexo_turno = Generos_Sexo_turno.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_AtencionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Atencions_Tipo_de_Atencion_turno = _ITipo_de_AtencionApiConsumer.SelAll(true);
            if (Tipo_de_Atencions_Tipo_de_Atencion_turno != null && Tipo_de_Atencions_Tipo_de_Atencion_turno.Resource != null)
                ViewBag.Tipo_de_Atencions_Tipo_de_Atencion_turno = Tipo_de_Atencions_Tipo_de_Atencion_turno.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Atencion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Identificacions_Tipo_de_Identificacion_turno = _ITipo_de_IdentificacionApiConsumer.SelAll(true);
            if (Tipo_de_Identificacions_Tipo_de_Identificacion_turno != null && Tipo_de_Identificacions_Tipo_de_Identificacion_turno.Resource != null)
                ViewBag.Tipo_de_Identificacions_Tipo_de_Identificacion_turno = Tipo_de_Identificacions_Tipo_de_Identificacion_turno.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Identificacion", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_UrgenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Urgencias_Tipo_de_Urgencia_turno = _ITipo_de_UrgenciaApiConsumer.SelAll(true);
            if (Tipo_de_Urgencias_Tipo_de_Urgencia_turno != null && Tipo_de_Urgencias_Tipo_de_Urgencia_turno.Resource != null)
                ViewBag.Tipo_de_Urgencias_Tipo_de_Urgencia_turno = Tipo_de_Urgencias_Tipo_de_Urgencia_turno.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Urgencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMotivo_Finalizacion_TurnoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Motivo_Finalizacion_Turnos_Motivo_Finalizacion_Turno = _IMotivo_Finalizacion_TurnoApiConsumer.SelAll(true);
            if (Motivo_Finalizacion_Turnos_Motivo_Finalizacion_Turno != null && Motivo_Finalizacion_Turnos_Motivo_Finalizacion_Turno.Resource != null)
                ViewBag.Motivo_Finalizacion_Turnos_Motivo_Finalizacion_Turno = Motivo_Finalizacion_Turnos_Motivo_Finalizacion_Turno.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Motivo_Finalizacion_Turno", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPrioridad_del_HechoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Prioridad_del_Hechos_Prioridad_del_Hecho = _IPrioridad_del_HechoApiConsumer.SelAll(true);
            if (Prioridad_del_Hechos_Prioridad_del_Hecho != null && Prioridad_del_Hechos_Prioridad_del_Hecho.Resource != null)
                ViewBag.Prioridad_del_Hechos_Prioridad_del_Hecho = Prioridad_del_Hechos_Prioridad_del_Hecho.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Prioridad_del_Hecho", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDocumento_ExtraviadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Documento_Extraviados_Tipo_de_Documento_Extraviado = _IDocumento_ExtraviadoApiConsumer.SelAll(true);
            if (Documento_Extraviados_Tipo_de_Documento_Extraviado != null && Documento_Extraviados_Tipo_de_Documento_Extraviado.Resource != null)
                ViewBag.Documento_Extraviados_Tipo_de_Documento_Extraviado = Documento_Extraviados_Tipo_de_Documento_Extraviado.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Documento_Extraviado", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILugar_TipoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Lugar_Tipos_Tipo_de_Lugar_del_Hecho = _ILugar_TipoApiConsumer.SelAll(true);
            if (Lugar_Tipos_Tipo_de_Lugar_del_Hecho != null && Lugar_Tipos_Tipo_de_Lugar_del_Hecho.Resource != null)
                ViewBag.Lugar_Tipos_Tipo_de_Lugar_del_Hecho = Lugar_Tipos_Tipo_de_Lugar_del_Hecho.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_Tipo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IZonaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Zonas_Zona_de_los_Hechos = _IZonaApiConsumer.SelAll(true);
            if (Zonas_Zona_de_los_Hechos != null && Zonas_Zona_de_los_Hechos.Resource != null)
                ViewBag.Zonas_Zona_de_los_Hechos = Zonas_Zona_de_los_Hechos.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Zona", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varModulo_Atencion_Inicial);
        }
		
	[HttpGet]
        public ActionResult AddModulo_Atencion_Inicial(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45004);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IModulo_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
			Modulo_Atencion_InicialModel varModulo_Atencion_Inicial= new Modulo_Atencion_InicialModel();
            var permissionDetalle_de_coincidencias_a = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45117, ModuleId);
            ViewBag.PermissionDetalle_de_coincidencias_a = permissionDetalle_de_coincidencias_a;
            var permissionDetalle_Historico_MPO = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45191, ModuleId);
            ViewBag.PermissionDetalle_Historico_MPO = permissionDetalle_Historico_MPO;


            if (id.ToString() != "0")
            {
                var Modulo_Atencion_InicialsData = _IModulo_Atencion_InicialApiConsumer.ListaSelAll(0, 1000, "Modulo_Atencion_Inicial.Clave=" + id, "").Resource.Modulo_Atencion_Inicials;
				
				if (Modulo_Atencion_InicialsData != null && Modulo_Atencion_InicialsData.Count > 0)
                {
					var Modulo_Atencion_InicialData = Modulo_Atencion_InicialsData.First();
					varModulo_Atencion_Inicial= new Modulo_Atencion_InicialModel
					{
						Clave  = Modulo_Atencion_InicialData.Clave 
	                    ,Folio = Modulo_Atencion_InicialData.Folio
                    ,Fecha_de_Registro = (Modulo_Atencion_InicialData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(Modulo_Atencion_InicialData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Registro = Modulo_Atencion_InicialData.Hora_de_Registro
                    ,Turno_Asignado = Modulo_Atencion_InicialData.Turno_Asignado
                    ,Turno_AsignadoNumero_de_Turno = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Turno_Asignado), "Asignacion_de_Turnos") ??  (string)Modulo_Atencion_InicialData.Turno_Asignado_Asignacion_de_Turnos.Numero_de_Turno
                    ,Usuario_que_Registra = Modulo_Atencion_InicialData.Usuario_que_Registra
                    ,Usuario_que_RegistraName = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Usuario_que_Registra), "Spartan_User") ??  (string)Modulo_Atencion_InicialData.Usuario_que_Registra_Spartan_User.Name
                    ,Unidad = Modulo_Atencion_InicialData.Unidad
                    ,UnidadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Unidad), "Unidad") ??  (string)Modulo_Atencion_InicialData.Unidad_Unidad.Descripcion
                    ,Municipio = Modulo_Atencion_InicialData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Municipio), "Municipio") ??  (string)Modulo_Atencion_InicialData.Municipio_Municipio.Nombre
                    ,Region = Modulo_Atencion_InicialData.Region
                    ,RegionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Region), "Region") ??  (string)Modulo_Atencion_InicialData.Region_Region.Descripcion
                    ,Tipo_de_Denuncia = Modulo_Atencion_InicialData.Tipo_de_Denuncia
                    ,Tipo_de_DenunciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Tipo_de_Denuncia), "Tipo_de_Denuncia") ??  (string)Modulo_Atencion_InicialData.Tipo_de_Denuncia_Tipo_de_Denuncia.Descripcion
                    ,NUAT = Modulo_Atencion_InicialData.NUAT
                    ,CDI = Modulo_Atencion_InicialData.CDI
                    ,Expedientes_Relacionados = Modulo_Atencion_InicialData.Expedientes_Relacionados
                    ,Estatus = Modulo_Atencion_InicialData.Estatus
                    ,EstatusDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Estatus), "Estatus") ??  (string)Modulo_Atencion_InicialData.Estatus_Estatus.Descripcion
                    ,Generar_Cita = (Modulo_Atencion_InicialData.Generar_Cita == null ? string.Empty : Convert.ToDateTime(Modulo_Atencion_InicialData.Generar_Cita).ToString(ConfigurationProperty.DateFormat))
                    ,Nombres_del_Remitente = Modulo_Atencion_InicialData.Nombres_del_Remitente
                    ,Apellido_Paterno_del_Remitente = Modulo_Atencion_InicialData.Apellido_Paterno_del_Remitente
                    ,Apellido_Materno_del_Remitente = Modulo_Atencion_InicialData.Apellido_Materno_del_Remitente
                    ,Fecha_en_que_llega_para_validacion = (Modulo_Atencion_InicialData.Fecha_en_que_llega_para_validacion == null ? string.Empty : Convert.ToDateTime(Modulo_Atencion_InicialData.Fecha_en_que_llega_para_validacion).ToString(ConfigurationProperty.DateFormat))
                    ,Delegacion = Modulo_Atencion_InicialData.Delegacion
                    ,DelegacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Delegacion), "Delegacion") ??  (string)Modulo_Atencion_InicialData.Delegacion_Delegacion.Descripcion
                    ,Agencia = Modulo_Atencion_InicialData.Agencia
                    ,AgenciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Agencia), "Agencia") ??  (string)Modulo_Atencion_InicialData.Agencia_Agencia.Descripcion
                    ,Ministerio_Publico_en_Turno = Modulo_Atencion_InicialData.Ministerio_Publico_en_Turno
                    ,Ministerio_Publico_en_TurnoMinisterio_Publico_en_Turno = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Ministerio_Publico_en_Turno), "Jefes_de_Usuarios_del_Sistema") ??  (string)Modulo_Atencion_InicialData.Ministerio_Publico_en_Turno_Jefes_de_Usuarios_del_Sistema.Ministerio_Publico_en_Turno
                    ,Solicitud_de_Denuncia_Ciudadana = Modulo_Atencion_InicialData.Solicitud_de_Denuncia_Ciudadana
                    ,Solicitud_de_Denuncia_CiudadanaFolio = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Solicitud_de_Denuncia_Ciudadana), "Solicitud_de_Denuncia_Ciudadana") ??  (string)Modulo_Atencion_InicialData.Solicitud_de_Denuncia_Ciudadana_Solicitud_de_Denuncia_Ciudadana.Folio
                    ,Nombres_turno = Modulo_Atencion_InicialData.Nombres_turno
                    ,Apellido_Paterno_turno = Modulo_Atencion_InicialData.Apellido_Paterno_turno
                    ,Apellido_Materno_turno = Modulo_Atencion_InicialData.Apellido_Materno_turno
                    ,Sexo_turno = Modulo_Atencion_InicialData.Sexo_turno
                    ,Sexo_turnoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Sexo_turno), "Genero") ??  (string)Modulo_Atencion_InicialData.Sexo_turno_Genero.Descripcion
                    ,Edad_turno = Modulo_Atencion_InicialData.Edad_turno
                    ,Tipo_de_Atencion_turno = Modulo_Atencion_InicialData.Tipo_de_Atencion_turno
                    ,Tipo_de_Atencion_turnoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Tipo_de_Atencion_turno), "Tipo_de_Atencion") ??  (string)Modulo_Atencion_InicialData.Tipo_de_Atencion_turno_Tipo_de_Atencion.Descripcion
                    ,Tipo_de_Identificacion_turno = Modulo_Atencion_InicialData.Tipo_de_Identificacion_turno
                    ,Tipo_de_Identificacion_turnoNombre = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Tipo_de_Identificacion_turno), "Tipo_de_Identificacion") ??  (string)Modulo_Atencion_InicialData.Tipo_de_Identificacion_turno_Tipo_de_Identificacion.Nombre
                    ,Numero_de_Identificacion_turno = Modulo_Atencion_InicialData.Numero_de_Identificacion_turno
                    ,Urgencia_turno = Modulo_Atencion_InicialData.Urgencia_turno.GetValueOrDefault()
                    ,Tipo_de_Urgencia_turno = Modulo_Atencion_InicialData.Tipo_de_Urgencia_turno
                    ,Tipo_de_Urgencia_turnoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Tipo_de_Urgencia_turno), "Tipo_de_Urgencia") ??  (string)Modulo_Atencion_InicialData.Tipo_de_Urgencia_turno_Tipo_de_Urgencia.Descripcion
                    ,Motivo_Finalizacion_Turno = Modulo_Atencion_InicialData.Motivo_Finalizacion_Turno
                    ,Motivo_Finalizacion_TurnoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Motivo_Finalizacion_Turno), "Motivo_Finalizacion_Turno") ??  (string)Modulo_Atencion_InicialData.Motivo_Finalizacion_Turno_Motivo_Finalizacion_Turno.Descripcion
                    ,Observaciones_turno = Modulo_Atencion_InicialData.Observaciones_turno
                    ,Titulo_del_Hecho = Modulo_Atencion_InicialData.Titulo_del_Hecho
                    ,Narrativa_Breve_de_los_Hechos = Modulo_Atencion_InicialData.Narrativa_Breve_de_los_Hechos
                    ,Prioridad_del_Hecho = Modulo_Atencion_InicialData.Prioridad_del_Hecho
                    ,Prioridad_del_HechoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Prioridad_del_Hecho), "Prioridad_del_Hecho") ??  (string)Modulo_Atencion_InicialData.Prioridad_del_Hecho_Prioridad_del_Hecho.Descripcion
                    ,Orientador = Modulo_Atencion_InicialData.Orientador
                    ,OrientadorName = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Orientador), "Spartan_User") ??  (string)Modulo_Atencion_InicialData.Orientador_Spartan_User.Name
                    ,Fecha_del_Hecho = (Modulo_Atencion_InicialData.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(Modulo_Atencion_InicialData.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_del_Hecho = Modulo_Atencion_InicialData.Hora_del_Hecho
                    ,Pais_de_los_Hechos = Modulo_Atencion_InicialData.Pais_de_los_Hechos
                    ,Pais_de_los_HechosNombre = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Pais_de_los_Hechos), "Pais") ??  (string)Modulo_Atencion_InicialData.Pais_de_los_Hechos_Pais.Nombre
                    ,Estado_de_los_Hechos = Modulo_Atencion_InicialData.Estado_de_los_Hechos
                    ,Estado_de_los_HechosNombre = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Estado_de_los_Hechos), "Estado") ??  (string)Modulo_Atencion_InicialData.Estado_de_los_Hechos_Estado.Nombre
                    ,Municipio_de_los_Hechos = Modulo_Atencion_InicialData.Municipio_de_los_Hechos
                    ,Municipio_de_los_HechosNombre = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Municipio_de_los_Hechos), "Municipio") ??  (string)Modulo_Atencion_InicialData.Municipio_de_los_Hechos_Municipio.Nombre
                    ,Poblacion = Modulo_Atencion_InicialData.Poblacion
                    ,PoblacionNombre = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Poblacion), "Colonia") ??  (string)Modulo_Atencion_InicialData.Poblacion_Colonia.Nombre
                    ,Colonia_de_los_Hechos = Modulo_Atencion_InicialData.Colonia_de_los_Hechos
                    ,Colonia_de_los_HechosNombre = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Colonia_de_los_Hechos), "Colonia") ??  (string)Modulo_Atencion_InicialData.Colonia_de_los_Hechos_Colonia.Nombre
                    ,Codigo_Postal_de_los_Hechos = Modulo_Atencion_InicialData.Codigo_Postal_de_los_Hechos
                    ,Calle_de_los_Hechos = Modulo_Atencion_InicialData.Calle_de_los_Hechos
                    ,Entre_Calle = Modulo_Atencion_InicialData.Entre_Calle
                    ,Y_Calle = Modulo_Atencion_InicialData.Y_Calle
                    ,Numero_Exrterior_de_los_Hechos = Modulo_Atencion_InicialData.Numero_Exrterior_de_los_Hechos
                    ,Numero_Interior_de_los_Hechos = Modulo_Atencion_InicialData.Numero_Interior_de_los_Hechos
                    ,Referencia_hechos = Modulo_Atencion_InicialData.Referencia_hechos
                    ,Latitud = Modulo_Atencion_InicialData.Latitud
                    ,Longitud = Modulo_Atencion_InicialData.Longitud
                    ,Documento_Extraviado_hechos = Modulo_Atencion_InicialData.Documento_Extraviado_hechos.GetValueOrDefault()
                    ,Tipo_de_Documento_Extraviado = Modulo_Atencion_InicialData.Tipo_de_Documento_Extraviado
                    ,Tipo_de_Documento_ExtraviadoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Tipo_de_Documento_Extraviado), "Documento_Extraviado") ??  (string)Modulo_Atencion_InicialData.Tipo_de_Documento_Extraviado_Documento_Extraviado.Descripcion
                    ,Tipo_de_Lugar_del_Hecho = Modulo_Atencion_InicialData.Tipo_de_Lugar_del_Hecho
                    ,Tipo_de_Lugar_del_HechoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Tipo_de_Lugar_del_Hecho), "Lugar_Tipo") ??  (string)Modulo_Atencion_InicialData.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Descripcion
                    ,Zona_de_los_Hechos = Modulo_Atencion_InicialData.Zona_de_los_Hechos
                    ,Zona_de_los_HechosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_Atencion_InicialData.Zona_de_los_Hechos), "Zona") ??  (string)Modulo_Atencion_InicialData.Zona_de_los_Hechos_Zona.Descripcion
                    ,Turno = Modulo_Atencion_InicialData.Turno
                    ,Cerrar = Modulo_Atencion_InicialData.Cerrar.GetValueOrDefault()
                    ,Fecha_de_Cierre = (Modulo_Atencion_InicialData.Fecha_de_Cierre == null ? string.Empty : Convert.ToDateTime(Modulo_Atencion_InicialData.Fecha_de_Cierre).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Cierre = Modulo_Atencion_InicialData.Hora_de_Cierre

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IUnidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Unidads_Unidad = _IUnidadApiConsumer.SelAll(true);
            if (Unidads_Unidad != null && Unidads_Unidad.Resource != null)
                ViewBag.Unidads_Unidad = Unidads_Unidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
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
            _ITipo_de_DenunciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Denuncias_Tipo_de_Denuncia = _ITipo_de_DenunciaApiConsumer.SelAll(true);
            if (Tipo_de_Denuncias_Tipo_de_Denuncia != null && Tipo_de_Denuncias_Tipo_de_Denuncia.Resource != null)
                ViewBag.Tipo_de_Denuncias_Tipo_de_Denuncia = Tipo_de_Denuncias_Tipo_de_Denuncia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Denuncia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatusApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatuss_Estatus = _IEstatusApiConsumer.SelAll(true);
            if (Estatuss_Estatus != null && Estatuss_Estatus.Resource != null)
                ViewBag.Estatuss_Estatus = Estatuss_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDelegacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Delegacions_Delegacion = _IDelegacionApiConsumer.SelAll(true);
            if (Delegacions_Delegacion != null && Delegacions_Delegacion.Resource != null)
                ViewBag.Delegacions_Delegacion = Delegacions_Delegacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delegacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAgenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Agencias_Agencia = _IAgenciaApiConsumer.SelAll(true);
            if (Agencias_Agencia != null && Agencias_Agencia.Resource != null)
                ViewBag.Agencias_Agencia = Agencias_Agencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.ClaveID), "Agencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.ClaveID)
                }).ToList();
            _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Generos_Sexo_turno = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Sexo_turno != null && Generos_Sexo_turno.Resource != null)
                ViewBag.Generos_Sexo_turno = Generos_Sexo_turno.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_AtencionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Atencions_Tipo_de_Atencion_turno = _ITipo_de_AtencionApiConsumer.SelAll(true);
            if (Tipo_de_Atencions_Tipo_de_Atencion_turno != null && Tipo_de_Atencions_Tipo_de_Atencion_turno.Resource != null)
                ViewBag.Tipo_de_Atencions_Tipo_de_Atencion_turno = Tipo_de_Atencions_Tipo_de_Atencion_turno.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Atencion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Identificacions_Tipo_de_Identificacion_turno = _ITipo_de_IdentificacionApiConsumer.SelAll(true);
            if (Tipo_de_Identificacions_Tipo_de_Identificacion_turno != null && Tipo_de_Identificacions_Tipo_de_Identificacion_turno.Resource != null)
                ViewBag.Tipo_de_Identificacions_Tipo_de_Identificacion_turno = Tipo_de_Identificacions_Tipo_de_Identificacion_turno.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Identificacion", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_UrgenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Urgencias_Tipo_de_Urgencia_turno = _ITipo_de_UrgenciaApiConsumer.SelAll(true);
            if (Tipo_de_Urgencias_Tipo_de_Urgencia_turno != null && Tipo_de_Urgencias_Tipo_de_Urgencia_turno.Resource != null)
                ViewBag.Tipo_de_Urgencias_Tipo_de_Urgencia_turno = Tipo_de_Urgencias_Tipo_de_Urgencia_turno.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Urgencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMotivo_Finalizacion_TurnoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Motivo_Finalizacion_Turnos_Motivo_Finalizacion_Turno = _IMotivo_Finalizacion_TurnoApiConsumer.SelAll(true);
            if (Motivo_Finalizacion_Turnos_Motivo_Finalizacion_Turno != null && Motivo_Finalizacion_Turnos_Motivo_Finalizacion_Turno.Resource != null)
                ViewBag.Motivo_Finalizacion_Turnos_Motivo_Finalizacion_Turno = Motivo_Finalizacion_Turnos_Motivo_Finalizacion_Turno.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Motivo_Finalizacion_Turno", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPrioridad_del_HechoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Prioridad_del_Hechos_Prioridad_del_Hecho = _IPrioridad_del_HechoApiConsumer.SelAll(true);
            if (Prioridad_del_Hechos_Prioridad_del_Hecho != null && Prioridad_del_Hechos_Prioridad_del_Hecho.Resource != null)
                ViewBag.Prioridad_del_Hechos_Prioridad_del_Hecho = Prioridad_del_Hechos_Prioridad_del_Hecho.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Prioridad_del_Hecho", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDocumento_ExtraviadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Documento_Extraviados_Tipo_de_Documento_Extraviado = _IDocumento_ExtraviadoApiConsumer.SelAll(true);
            if (Documento_Extraviados_Tipo_de_Documento_Extraviado != null && Documento_Extraviados_Tipo_de_Documento_Extraviado.Resource != null)
                ViewBag.Documento_Extraviados_Tipo_de_Documento_Extraviado = Documento_Extraviados_Tipo_de_Documento_Extraviado.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Documento_Extraviado", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILugar_TipoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Lugar_Tipos_Tipo_de_Lugar_del_Hecho = _ILugar_TipoApiConsumer.SelAll(true);
            if (Lugar_Tipos_Tipo_de_Lugar_del_Hecho != null && Lugar_Tipos_Tipo_de_Lugar_del_Hecho.Resource != null)
                ViewBag.Lugar_Tipos_Tipo_de_Lugar_del_Hecho = Lugar_Tipos_Tipo_de_Lugar_del_Hecho.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_Tipo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IZonaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Zonas_Zona_de_los_Hechos = _IZonaApiConsumer.SelAll(true);
            if (Zonas_Zona_de_los_Hechos != null && Zonas_Zona_de_los_Hechos.Resource != null)
                ViewBag.Zonas_Zona_de_los_Hechos = Zonas_Zona_de_los_Hechos.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Zona", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddModulo_Atencion_Inicial", varModulo_Atencion_Inicial);
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
        public ActionResult GetAsignacion_de_TurnosAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IAsignacion_de_TurnosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IAsignacion_de_TurnosApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Numero_de_Turno).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Folio), "Asignacion_de_Turnos", "Numero_de_Turno")?? m.Numero_de_Turno,
                    Value = Convert.ToString(m.Folio)
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
        public ActionResult GetTipo_de_DenunciaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_DenunciaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_DenunciaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Denuncia", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetEstatusAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstatusApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstatusApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDelegacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDelegacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDelegacionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delegacion", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetAgenciaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IAgenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IAgenciaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.ClaveID), "Agencia", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.ClaveID)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
		[HttpGet]
        public ActionResult GetJefes_de_Usuarios_del_SistemaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IJefes_de_Usuarios_del_SistemaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IJefes_de_Usuarios_del_SistemaApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Ministerio_Publico_en_Turno).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Jefes_de_Usuarios_del_Sistema", "Ministerio_Publico_en_Turno")?? m.Ministerio_Publico_en_Turno,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
		[HttpGet]
        public ActionResult GetSolicitud_de_Denuncia_CiudadanaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitud_de_Denuncia_CiudadanaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISolicitud_de_Denuncia_CiudadanaApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Folio).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Solicitud_de_Denuncia_Ciudadana", "Folio")?? m.Folio,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetGeneroAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IGeneroApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetTipo_de_AtencionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_AtencionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_AtencionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Atencion", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetTipo_de_IdentificacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_IdentificacionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Identificacion", "Nombre")?? m.Nombre,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetTipo_de_UrgenciaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_UrgenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_UrgenciaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Urgencia", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetMotivo_Finalizacion_TurnoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMotivo_Finalizacion_TurnoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IMotivo_Finalizacion_TurnoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Motivo_Finalizacion_Turno", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetPrioridad_del_HechoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IPrioridad_del_HechoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IPrioridad_del_HechoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Prioridad_del_Hecho", "Descripcion")?? m.Descripcion,
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
        public ActionResult GetDocumento_ExtraviadoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDocumento_ExtraviadoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDocumento_ExtraviadoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Documento_Extraviado", "Descripcion")?? m.Descripcion,
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
        public ActionResult GetZonaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IZonaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IZonaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Zona", "Descripcion")?? m.Descripcion,
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
        public ActionResult ShowAdvanceFilter(Modulo_Atencion_InicialAdvanceSearchModel model, int idFilter = -1)
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
            var Unidads_Unidad = _IUnidadApiConsumer.SelAll(true);
            if (Unidads_Unidad != null && Unidads_Unidad.Resource != null)
                ViewBag.Unidads_Unidad = Unidads_Unidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
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
            _ITipo_de_DenunciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Denuncias_Tipo_de_Denuncia = _ITipo_de_DenunciaApiConsumer.SelAll(true);
            if (Tipo_de_Denuncias_Tipo_de_Denuncia != null && Tipo_de_Denuncias_Tipo_de_Denuncia.Resource != null)
                ViewBag.Tipo_de_Denuncias_Tipo_de_Denuncia = Tipo_de_Denuncias_Tipo_de_Denuncia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Denuncia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatusApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatuss_Estatus = _IEstatusApiConsumer.SelAll(true);
            if (Estatuss_Estatus != null && Estatuss_Estatus.Resource != null)
                ViewBag.Estatuss_Estatus = Estatuss_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDelegacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Delegacions_Delegacion = _IDelegacionApiConsumer.SelAll(true);
            if (Delegacions_Delegacion != null && Delegacions_Delegacion.Resource != null)
                ViewBag.Delegacions_Delegacion = Delegacions_Delegacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delegacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAgenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Agencias_Agencia = _IAgenciaApiConsumer.SelAll(true);
            if (Agencias_Agencia != null && Agencias_Agencia.Resource != null)
                ViewBag.Agencias_Agencia = Agencias_Agencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.ClaveID), "Agencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.ClaveID)
                }).ToList();
            _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Generos_Sexo_turno = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Sexo_turno != null && Generos_Sexo_turno.Resource != null)
                ViewBag.Generos_Sexo_turno = Generos_Sexo_turno.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_AtencionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Atencions_Tipo_de_Atencion_turno = _ITipo_de_AtencionApiConsumer.SelAll(true);
            if (Tipo_de_Atencions_Tipo_de_Atencion_turno != null && Tipo_de_Atencions_Tipo_de_Atencion_turno.Resource != null)
                ViewBag.Tipo_de_Atencions_Tipo_de_Atencion_turno = Tipo_de_Atencions_Tipo_de_Atencion_turno.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Atencion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Identificacions_Tipo_de_Identificacion_turno = _ITipo_de_IdentificacionApiConsumer.SelAll(true);
            if (Tipo_de_Identificacions_Tipo_de_Identificacion_turno != null && Tipo_de_Identificacions_Tipo_de_Identificacion_turno.Resource != null)
                ViewBag.Tipo_de_Identificacions_Tipo_de_Identificacion_turno = Tipo_de_Identificacions_Tipo_de_Identificacion_turno.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Identificacion", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_UrgenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Urgencias_Tipo_de_Urgencia_turno = _ITipo_de_UrgenciaApiConsumer.SelAll(true);
            if (Tipo_de_Urgencias_Tipo_de_Urgencia_turno != null && Tipo_de_Urgencias_Tipo_de_Urgencia_turno.Resource != null)
                ViewBag.Tipo_de_Urgencias_Tipo_de_Urgencia_turno = Tipo_de_Urgencias_Tipo_de_Urgencia_turno.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Urgencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMotivo_Finalizacion_TurnoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Motivo_Finalizacion_Turnos_Motivo_Finalizacion_Turno = _IMotivo_Finalizacion_TurnoApiConsumer.SelAll(true);
            if (Motivo_Finalizacion_Turnos_Motivo_Finalizacion_Turno != null && Motivo_Finalizacion_Turnos_Motivo_Finalizacion_Turno.Resource != null)
                ViewBag.Motivo_Finalizacion_Turnos_Motivo_Finalizacion_Turno = Motivo_Finalizacion_Turnos_Motivo_Finalizacion_Turno.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Motivo_Finalizacion_Turno", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPrioridad_del_HechoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Prioridad_del_Hechos_Prioridad_del_Hecho = _IPrioridad_del_HechoApiConsumer.SelAll(true);
            if (Prioridad_del_Hechos_Prioridad_del_Hecho != null && Prioridad_del_Hechos_Prioridad_del_Hecho.Resource != null)
                ViewBag.Prioridad_del_Hechos_Prioridad_del_Hecho = Prioridad_del_Hechos_Prioridad_del_Hecho.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Prioridad_del_Hecho", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDocumento_ExtraviadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Documento_Extraviados_Tipo_de_Documento_Extraviado = _IDocumento_ExtraviadoApiConsumer.SelAll(true);
            if (Documento_Extraviados_Tipo_de_Documento_Extraviado != null && Documento_Extraviados_Tipo_de_Documento_Extraviado.Resource != null)
                ViewBag.Documento_Extraviados_Tipo_de_Documento_Extraviado = Documento_Extraviados_Tipo_de_Documento_Extraviado.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Documento_Extraviado", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILugar_TipoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Lugar_Tipos_Tipo_de_Lugar_del_Hecho = _ILugar_TipoApiConsumer.SelAll(true);
            if (Lugar_Tipos_Tipo_de_Lugar_del_Hecho != null && Lugar_Tipos_Tipo_de_Lugar_del_Hecho.Resource != null)
                ViewBag.Lugar_Tipos_Tipo_de_Lugar_del_Hecho = Lugar_Tipos_Tipo_de_Lugar_del_Hecho.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_Tipo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IZonaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Zonas_Zona_de_los_Hechos = _IZonaApiConsumer.SelAll(true);
            if (Zonas_Zona_de_los_Hechos != null && Zonas_Zona_de_los_Hechos.Resource != null)
                ViewBag.Zonas_Zona_de_los_Hechos = Zonas_Zona_de_los_Hechos.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Zona", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IUnidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Unidads_Unidad = _IUnidadApiConsumer.SelAll(true);
            if (Unidads_Unidad != null && Unidads_Unidad.Resource != null)
                ViewBag.Unidads_Unidad = Unidads_Unidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
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
            _ITipo_de_DenunciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Denuncias_Tipo_de_Denuncia = _ITipo_de_DenunciaApiConsumer.SelAll(true);
            if (Tipo_de_Denuncias_Tipo_de_Denuncia != null && Tipo_de_Denuncias_Tipo_de_Denuncia.Resource != null)
                ViewBag.Tipo_de_Denuncias_Tipo_de_Denuncia = Tipo_de_Denuncias_Tipo_de_Denuncia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Denuncia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatusApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatuss_Estatus = _IEstatusApiConsumer.SelAll(true);
            if (Estatuss_Estatus != null && Estatuss_Estatus.Resource != null)
                ViewBag.Estatuss_Estatus = Estatuss_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDelegacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Delegacions_Delegacion = _IDelegacionApiConsumer.SelAll(true);
            if (Delegacions_Delegacion != null && Delegacions_Delegacion.Resource != null)
                ViewBag.Delegacions_Delegacion = Delegacions_Delegacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delegacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAgenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Agencias_Agencia = _IAgenciaApiConsumer.SelAll(true);
            if (Agencias_Agencia != null && Agencias_Agencia.Resource != null)
                ViewBag.Agencias_Agencia = Agencias_Agencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.ClaveID), "Agencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.ClaveID)
                }).ToList();
            _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Generos_Sexo_turno = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Sexo_turno != null && Generos_Sexo_turno.Resource != null)
                ViewBag.Generos_Sexo_turno = Generos_Sexo_turno.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_AtencionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Atencions_Tipo_de_Atencion_turno = _ITipo_de_AtencionApiConsumer.SelAll(true);
            if (Tipo_de_Atencions_Tipo_de_Atencion_turno != null && Tipo_de_Atencions_Tipo_de_Atencion_turno.Resource != null)
                ViewBag.Tipo_de_Atencions_Tipo_de_Atencion_turno = Tipo_de_Atencions_Tipo_de_Atencion_turno.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Atencion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Identificacions_Tipo_de_Identificacion_turno = _ITipo_de_IdentificacionApiConsumer.SelAll(true);
            if (Tipo_de_Identificacions_Tipo_de_Identificacion_turno != null && Tipo_de_Identificacions_Tipo_de_Identificacion_turno.Resource != null)
                ViewBag.Tipo_de_Identificacions_Tipo_de_Identificacion_turno = Tipo_de_Identificacions_Tipo_de_Identificacion_turno.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Identificacion", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_UrgenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Urgencias_Tipo_de_Urgencia_turno = _ITipo_de_UrgenciaApiConsumer.SelAll(true);
            if (Tipo_de_Urgencias_Tipo_de_Urgencia_turno != null && Tipo_de_Urgencias_Tipo_de_Urgencia_turno.Resource != null)
                ViewBag.Tipo_de_Urgencias_Tipo_de_Urgencia_turno = Tipo_de_Urgencias_Tipo_de_Urgencia_turno.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Urgencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMotivo_Finalizacion_TurnoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Motivo_Finalizacion_Turnos_Motivo_Finalizacion_Turno = _IMotivo_Finalizacion_TurnoApiConsumer.SelAll(true);
            if (Motivo_Finalizacion_Turnos_Motivo_Finalizacion_Turno != null && Motivo_Finalizacion_Turnos_Motivo_Finalizacion_Turno.Resource != null)
                ViewBag.Motivo_Finalizacion_Turnos_Motivo_Finalizacion_Turno = Motivo_Finalizacion_Turnos_Motivo_Finalizacion_Turno.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Motivo_Finalizacion_Turno", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPrioridad_del_HechoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Prioridad_del_Hechos_Prioridad_del_Hecho = _IPrioridad_del_HechoApiConsumer.SelAll(true);
            if (Prioridad_del_Hechos_Prioridad_del_Hecho != null && Prioridad_del_Hechos_Prioridad_del_Hecho.Resource != null)
                ViewBag.Prioridad_del_Hechos_Prioridad_del_Hecho = Prioridad_del_Hechos_Prioridad_del_Hecho.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Prioridad_del_Hecho", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDocumento_ExtraviadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Documento_Extraviados_Tipo_de_Documento_Extraviado = _IDocumento_ExtraviadoApiConsumer.SelAll(true);
            if (Documento_Extraviados_Tipo_de_Documento_Extraviado != null && Documento_Extraviados_Tipo_de_Documento_Extraviado.Resource != null)
                ViewBag.Documento_Extraviados_Tipo_de_Documento_Extraviado = Documento_Extraviados_Tipo_de_Documento_Extraviado.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Documento_Extraviado", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILugar_TipoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Lugar_Tipos_Tipo_de_Lugar_del_Hecho = _ILugar_TipoApiConsumer.SelAll(true);
            if (Lugar_Tipos_Tipo_de_Lugar_del_Hecho != null && Lugar_Tipos_Tipo_de_Lugar_del_Hecho.Resource != null)
                ViewBag.Lugar_Tipos_Tipo_de_Lugar_del_Hecho = Lugar_Tipos_Tipo_de_Lugar_del_Hecho.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_Tipo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IZonaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Zonas_Zona_de_los_Hechos = _IZonaApiConsumer.SelAll(true);
            if (Zonas_Zona_de_los_Hechos != null && Zonas_Zona_de_los_Hechos.Resource != null)
                ViewBag.Zonas_Zona_de_los_Hechos = Zonas_Zona_de_los_Hechos.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Zona", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Modulo_Atencion_InicialAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Modulo_Atencion_InicialAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Modulo_Atencion_InicialAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Modulo_Atencion_InicialPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IModulo_Atencion_InicialApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Modulo_Atencion_Inicials == null)
                result.Modulo_Atencion_Inicials = new List<Modulo_Atencion_Inicial>();

            return Json(new
            {
                data = result.Modulo_Atencion_Inicials.Select(m => new Modulo_Atencion_InicialGridModel
                    {
                    Clave = m.Clave
			,Folio = m.Folio
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Turno_AsignadoNumero_de_Turno = CultureHelper.GetTraduction(m.Turno_Asignado_Asignacion_de_Turnos.Folio.ToString(), "Asignacion_de_Turnos") ?? (string)m.Turno_Asignado_Asignacion_de_Turnos.Numero_de_Turno
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,UnidadDescripcion = CultureHelper.GetTraduction(m.Unidad_Unidad.Clave.ToString(), "Descripcion") ?? (string)m.Unidad_Unidad.Descripcion
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,RegionDescripcion = CultureHelper.GetTraduction(m.Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Region_Region.Descripcion
                        ,Tipo_de_DenunciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Denuncia_Tipo_de_Denuncia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Denuncia_Tipo_de_Denuncia.Descripcion
			,NUAT = m.NUAT
			,CDI = m.CDI
			,Expedientes_Relacionados = m.Expedientes_Relacionados
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus.Descripcion
                        ,Generar_Cita = (m.Generar_Cita == null ? string.Empty : Convert.ToDateTime(m.Generar_Cita).ToString(ConfigurationProperty.DateFormat))
			,Nombres_del_Remitente = m.Nombres_del_Remitente
			,Apellido_Paterno_del_Remitente = m.Apellido_Paterno_del_Remitente
			,Apellido_Materno_del_Remitente = m.Apellido_Materno_del_Remitente
                        ,Fecha_en_que_llega_para_validacion = (m.Fecha_en_que_llega_para_validacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_en_que_llega_para_validacion).ToString(ConfigurationProperty.DateFormat))
                        ,DelegacionDescripcion = CultureHelper.GetTraduction(m.Delegacion_Delegacion.Clave.ToString(), "Descripcion") ?? (string)m.Delegacion_Delegacion.Descripcion
                        ,AgenciaDescripcion = CultureHelper.GetTraduction(m.Agencia_Agencia.ClaveID.ToString(), "Descripcion") ?? (string)m.Agencia_Agencia.Descripcion
                        ,Ministerio_Publico_en_TurnoMinisterio_Publico_en_Turno = CultureHelper.GetTraduction(m.Ministerio_Publico_en_Turno_Jefes_de_Usuarios_del_Sistema.Clave.ToString(), "Jefes_de_Usuarios_del_Sistema") ?? (string)m.Ministerio_Publico_en_Turno_Jefes_de_Usuarios_del_Sistema.Ministerio_Publico_en_Turno
                        ,Solicitud_de_Denuncia_CiudadanaFolio = CultureHelper.GetTraduction(m.Solicitud_de_Denuncia_Ciudadana_Solicitud_de_Denuncia_Ciudadana.Clave.ToString(), "Solicitud_de_Denuncia_Ciudadana") ?? (string)m.Solicitud_de_Denuncia_Ciudadana_Solicitud_de_Denuncia_Ciudadana.Folio
			,Nombres_turno = m.Nombres_turno
			,Apellido_Paterno_turno = m.Apellido_Paterno_turno
			,Apellido_Materno_turno = m.Apellido_Materno_turno
                        ,Sexo_turnoDescripcion = CultureHelper.GetTraduction(m.Sexo_turno_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_turno_Genero.Descripcion
			,Edad_turno = m.Edad_turno
                        ,Tipo_de_Atencion_turnoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Atencion_turno_Tipo_de_Atencion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Atencion_turno_Tipo_de_Atencion.Descripcion
                        ,Tipo_de_Identificacion_turnoNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_turno_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_turno_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion_turno = m.Numero_de_Identificacion_turno
			,Urgencia_turno = m.Urgencia_turno
                        ,Tipo_de_Urgencia_turnoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Urgencia_turno_Tipo_de_Urgencia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Urgencia_turno_Tipo_de_Urgencia.Descripcion
                        ,Motivo_Finalizacion_TurnoDescripcion = CultureHelper.GetTraduction(m.Motivo_Finalizacion_Turno_Motivo_Finalizacion_Turno.Clave.ToString(), "Descripcion") ?? (string)m.Motivo_Finalizacion_Turno_Motivo_Finalizacion_Turno.Descripcion
			,Observaciones_turno = m.Observaciones_turno
			,Titulo_del_Hecho = m.Titulo_del_Hecho
			,Narrativa_Breve_de_los_Hechos = m.Narrativa_Breve_de_los_Hechos
                        ,Prioridad_del_HechoDescripcion = CultureHelper.GetTraduction(m.Prioridad_del_Hecho_Prioridad_del_Hecho.Clave.ToString(), "Descripcion") ?? (string)m.Prioridad_del_Hecho_Prioridad_del_Hecho.Descripcion
                        ,OrientadorName = CultureHelper.GetTraduction(m.Orientador_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Orientador_Spartan_User.Name
                        ,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
			,Hora_del_Hecho = m.Hora_del_Hecho
                        ,Pais_de_los_HechosNombre = CultureHelper.GetTraduction(m.Pais_de_los_Hechos_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_de_los_Hechos_Pais.Nombre
                        ,Estado_de_los_HechosNombre = CultureHelper.GetTraduction(m.Estado_de_los_Hechos_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_de_los_Hechos_Estado.Nombre
                        ,Municipio_de_los_HechosNombre = CultureHelper.GetTraduction(m.Municipio_de_los_Hechos_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_de_los_Hechos_Municipio.Nombre
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,Colonia_de_los_HechosNombre = CultureHelper.GetTraduction(m.Colonia_de_los_Hechos_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_de_los_Hechos_Colonia.Nombre
			,Codigo_Postal_de_los_Hechos = m.Codigo_Postal_de_los_Hechos
			,Calle_de_los_Hechos = m.Calle_de_los_Hechos
			,Entre_Calle = m.Entre_Calle
			,Y_Calle = m.Y_Calle
			,Numero_Exrterior_de_los_Hechos = m.Numero_Exrterior_de_los_Hechos
			,Numero_Interior_de_los_Hechos = m.Numero_Interior_de_los_Hechos
			,Referencia_hechos = m.Referencia_hechos
			,Latitud = m.Latitud
			,Longitud = m.Longitud
			,Documento_Extraviado_hechos = m.Documento_Extraviado_hechos
                        ,Tipo_de_Documento_ExtraviadoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Documento_Extraviado_Documento_Extraviado.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Documento_Extraviado_Documento_Extraviado.Descripcion
                        ,Tipo_de_Lugar_del_HechoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Descripcion
                        ,Zona_de_los_HechosDescripcion = CultureHelper.GetTraduction(m.Zona_de_los_Hechos_Zona.Clave.ToString(), "Descripcion") ?? (string)m.Zona_de_los_Hechos_Zona.Descripcion
			,Turno = m.Turno
			,Cerrar = m.Cerrar
                        ,Fecha_de_Cierre = (m.Fecha_de_Cierre == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Cierre).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Cierre = m.Hora_de_Cierre

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetModulo_Atencion_InicialAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModulo_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IModulo_Atencion_InicialApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Modulo_Atencion_Inicial", m.),
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
        /// Get List of Modulo_Atencion_Inicial from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Modulo_Atencion_Inicial Entity</returns>
        public ActionResult GetModulo_Atencion_InicialList(UrlParametersModel param)
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
            _IModulo_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Modulo_Atencion_InicialPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Modulo_Atencion_InicialAdvanceSearchModel))
                {
					var advanceFilter =
                    (Modulo_Atencion_InicialAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Modulo_Atencion_InicialPropertyMapper oModulo_Atencion_InicialPropertyMapper = new Modulo_Atencion_InicialPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oModulo_Atencion_InicialPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IModulo_Atencion_InicialApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Modulo_Atencion_Inicials == null)
                result.Modulo_Atencion_Inicials = new List<Modulo_Atencion_Inicial>();

            return Json(new
            {
                aaData = result.Modulo_Atencion_Inicials.Select(m => new Modulo_Atencion_InicialGridModel
            {
                    Clave = m.Clave
			,Folio = m.Folio
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Turno_AsignadoNumero_de_Turno = CultureHelper.GetTraduction(m.Turno_Asignado_Asignacion_de_Turnos.Folio.ToString(), "Asignacion_de_Turnos") ?? (string)m.Turno_Asignado_Asignacion_de_Turnos.Numero_de_Turno
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,UnidadDescripcion = CultureHelper.GetTraduction(m.Unidad_Unidad.Clave.ToString(), "Descripcion") ?? (string)m.Unidad_Unidad.Descripcion
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,RegionDescripcion = CultureHelper.GetTraduction(m.Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Region_Region.Descripcion
                        ,Tipo_de_DenunciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Denuncia_Tipo_de_Denuncia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Denuncia_Tipo_de_Denuncia.Descripcion
			,NUAT = m.NUAT
			,CDI = m.CDI
			,Expedientes_Relacionados = m.Expedientes_Relacionados
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus.Descripcion
                        ,Generar_Cita = (m.Generar_Cita == null ? string.Empty : Convert.ToDateTime(m.Generar_Cita).ToString(ConfigurationProperty.DateFormat))
			,Nombres_del_Remitente = m.Nombres_del_Remitente
			,Apellido_Paterno_del_Remitente = m.Apellido_Paterno_del_Remitente
			,Apellido_Materno_del_Remitente = m.Apellido_Materno_del_Remitente
                        ,Fecha_en_que_llega_para_validacion = (m.Fecha_en_que_llega_para_validacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_en_que_llega_para_validacion).ToString(ConfigurationProperty.DateFormat))
                        ,DelegacionDescripcion = CultureHelper.GetTraduction(m.Delegacion_Delegacion.Clave.ToString(), "Descripcion") ?? (string)m.Delegacion_Delegacion.Descripcion
                        ,AgenciaDescripcion = CultureHelper.GetTraduction(m.Agencia_Agencia.ClaveID.ToString(), "Descripcion") ?? (string)m.Agencia_Agencia.Descripcion
                        ,Ministerio_Publico_en_TurnoMinisterio_Publico_en_Turno = CultureHelper.GetTraduction(m.Ministerio_Publico_en_Turno_Jefes_de_Usuarios_del_Sistema.Clave.ToString(), "Jefes_de_Usuarios_del_Sistema") ?? (string)m.Ministerio_Publico_en_Turno_Jefes_de_Usuarios_del_Sistema.Ministerio_Publico_en_Turno
                        ,Solicitud_de_Denuncia_CiudadanaFolio = CultureHelper.GetTraduction(m.Solicitud_de_Denuncia_Ciudadana_Solicitud_de_Denuncia_Ciudadana.Clave.ToString(), "Solicitud_de_Denuncia_Ciudadana") ?? (string)m.Solicitud_de_Denuncia_Ciudadana_Solicitud_de_Denuncia_Ciudadana.Folio
			,Nombres_turno = m.Nombres_turno
			,Apellido_Paterno_turno = m.Apellido_Paterno_turno
			,Apellido_Materno_turno = m.Apellido_Materno_turno
                        ,Sexo_turnoDescripcion = CultureHelper.GetTraduction(m.Sexo_turno_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_turno_Genero.Descripcion
			,Edad_turno = m.Edad_turno
                        ,Tipo_de_Atencion_turnoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Atencion_turno_Tipo_de_Atencion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Atencion_turno_Tipo_de_Atencion.Descripcion
                        ,Tipo_de_Identificacion_turnoNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_turno_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_turno_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion_turno = m.Numero_de_Identificacion_turno
			,Urgencia_turno = m.Urgencia_turno
                        ,Tipo_de_Urgencia_turnoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Urgencia_turno_Tipo_de_Urgencia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Urgencia_turno_Tipo_de_Urgencia.Descripcion
                        ,Motivo_Finalizacion_TurnoDescripcion = CultureHelper.GetTraduction(m.Motivo_Finalizacion_Turno_Motivo_Finalizacion_Turno.Clave.ToString(), "Descripcion") ?? (string)m.Motivo_Finalizacion_Turno_Motivo_Finalizacion_Turno.Descripcion
			,Observaciones_turno = m.Observaciones_turno
			,Titulo_del_Hecho = m.Titulo_del_Hecho
			,Narrativa_Breve_de_los_Hechos = m.Narrativa_Breve_de_los_Hechos
                        ,Prioridad_del_HechoDescripcion = CultureHelper.GetTraduction(m.Prioridad_del_Hecho_Prioridad_del_Hecho.Clave.ToString(), "Descripcion") ?? (string)m.Prioridad_del_Hecho_Prioridad_del_Hecho.Descripcion
                        ,OrientadorName = CultureHelper.GetTraduction(m.Orientador_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Orientador_Spartan_User.Name
                        ,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
			,Hora_del_Hecho = m.Hora_del_Hecho
                        ,Pais_de_los_HechosNombre = CultureHelper.GetTraduction(m.Pais_de_los_Hechos_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_de_los_Hechos_Pais.Nombre
                        ,Estado_de_los_HechosNombre = CultureHelper.GetTraduction(m.Estado_de_los_Hechos_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_de_los_Hechos_Estado.Nombre
                        ,Municipio_de_los_HechosNombre = CultureHelper.GetTraduction(m.Municipio_de_los_Hechos_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_de_los_Hechos_Municipio.Nombre
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,Colonia_de_los_HechosNombre = CultureHelper.GetTraduction(m.Colonia_de_los_Hechos_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_de_los_Hechos_Colonia.Nombre
			,Codigo_Postal_de_los_Hechos = m.Codigo_Postal_de_los_Hechos
			,Calle_de_los_Hechos = m.Calle_de_los_Hechos
			,Entre_Calle = m.Entre_Calle
			,Y_Calle = m.Y_Calle
			,Numero_Exrterior_de_los_Hechos = m.Numero_Exrterior_de_los_Hechos
			,Numero_Interior_de_los_Hechos = m.Numero_Interior_de_los_Hechos
			,Referencia_hechos = m.Referencia_hechos
			,Latitud = m.Latitud
			,Longitud = m.Longitud
			,Documento_Extraviado_hechos = m.Documento_Extraviado_hechos
                        ,Tipo_de_Documento_ExtraviadoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Documento_Extraviado_Documento_Extraviado.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Documento_Extraviado_Documento_Extraviado.Descripcion
                        ,Tipo_de_Lugar_del_HechoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Descripcion
                        ,Zona_de_los_HechosDescripcion = CultureHelper.GetTraduction(m.Zona_de_los_Hechos_Zona.Clave.ToString(), "Descripcion") ?? (string)m.Zona_de_los_Hechos_Zona.Descripcion
			,Turno = m.Turno
			,Cerrar = m.Cerrar
                        ,Fecha_de_Cierre = (m.Fecha_de_Cierre == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Cierre).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Cierre = m.Hora_de_Cierre

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetModulo_Atencion_Inicial_Turno_Asignado_Asignacion_de_Turnos(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IAsignacion_de_TurnosApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Asignacion_de_Turnos.Folio as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Asignacion_de_Turnos.Numero_de_Turno as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IAsignacion_de_TurnosApiConsumer.ListaSelAll(1, 20,elWhere , " Asignacion_de_Turnos.Numero_de_Turno ASC ").Resource;
               
                foreach (var item in result.Asignacion_de_Turnoss)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Folio), "Asignacion_de_Turnos", "Numero_de_Turno");
                    item.Numero_de_Turno =trans ??item.Numero_de_Turno;
                }
                return Json(result.Asignacion_de_Turnoss.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetModulo_Atencion_Inicial_Usuario_que_Registra_Spartan_User(string query, string where)
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
        public JsonResult GetModulo_Atencion_Inicial_Municipio_Municipio(string query, string where)
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
        public JsonResult GetModulo_Atencion_Inicial_Ministerio_Publico_en_Turno_Jefes_de_Usuarios_del_Sistema(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IJefes_de_Usuarios_del_SistemaApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Jefes_de_Usuarios_del_Sistema.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Jefes_de_Usuarios_del_Sistema.Ministerio_Publico_en_Turno as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IJefes_de_Usuarios_del_SistemaApiConsumer.ListaSelAll(1, 20,elWhere , " Jefes_de_Usuarios_del_Sistema.Ministerio_Publico_en_Turno ASC ").Resource;
               
                foreach (var item in result.Jefes_de_Usuarios_del_Sistemas)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Jefes_de_Usuarios_del_Sistema", "Ministerio_Publico_en_Turno");
                    item.Ministerio_Publico_en_Turno =trans ??item.Ministerio_Publico_en_Turno;
                }
                return Json(result.Jefes_de_Usuarios_del_Sistemas.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetModulo_Atencion_Inicial_Solicitud_de_Denuncia_Ciudadana_Solicitud_de_Denuncia_Ciudadana(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitud_de_Denuncia_CiudadanaApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Solicitud_de_Denuncia_Ciudadana.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Solicitud_de_Denuncia_Ciudadana.Folio as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _ISolicitud_de_Denuncia_CiudadanaApiConsumer.ListaSelAll(1, 20,elWhere , " Solicitud_de_Denuncia_Ciudadana.Folio ASC ").Resource;
               
                foreach (var item in result.Solicitud_de_Denuncia_Ciudadanas)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Solicitud_de_Denuncia_Ciudadana", "Folio");
                    item.Folio =trans ??item.Folio;
                }
                return Json(result.Solicitud_de_Denuncia_Ciudadanas.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetModulo_Atencion_Inicial_Orientador_Spartan_User(string query, string where)
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
        public JsonResult GetModulo_Atencion_Inicial_Pais_de_los_Hechos_Pais(string query, string where)
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
        public JsonResult GetModulo_Atencion_Inicial_Estado_de_los_Hechos_Estado(string query, string where)
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
        public JsonResult GetModulo_Atencion_Inicial_Municipio_de_los_Hechos_Municipio(string query, string where)
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
        public JsonResult GetModulo_Atencion_Inicial_Poblacion_Colonia(string query, string where)
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
        public JsonResult GetModulo_Atencion_Inicial_Colonia_de_los_Hechos_Colonia(string query, string where)
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
//Grid GetAutoComplete

//Grid GetAutoComplete






        [NonAction]
        public string GetAdvanceFilter(Modulo_Atencion_InicialAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Modulo_Atencion_Inicial.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Modulo_Atencion_Inicial.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.Folio))
            {
                switch (filter.FolioFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_Atencion_Inicial.Folio LIKE '" + filter.Folio + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_Atencion_Inicial.Folio LIKE '%" + filter.Folio + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_Atencion_Inicial.Folio = '" + filter.Folio + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_Atencion_Inicial.Folio LIKE '%" + filter.Folio + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro) || !string.IsNullOrEmpty(filter.ToFecha_de_Registro))
            {
                var Fecha_de_RegistroFrom = DateTime.ParseExact(filter.FromFecha_de_Registro, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_RegistroTo = DateTime.ParseExact(filter.ToFecha_de_Registro, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro))
                    where += " AND Modulo_Atencion_Inicial.Fecha_de_Registro >= '" + Fecha_de_RegistroFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Registro))
                    where += " AND Modulo_Atencion_Inicial.Fecha_de_Registro <= '" + Fecha_de_RegistroTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Registro) || !string.IsNullOrEmpty(filter.ToHora_de_Registro))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Registro))
                    where += " AND Convert(TIME,Modulo_Atencion_Inicial.Hora_de_Registro) >='" + filter.FromHora_de_Registro + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Registro))
                    where += " AND Convert(TIME,Modulo_Atencion_Inicial.Hora_de_Registro) <='" + filter.ToHora_de_Registro + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTurno_Asignado))
            {
                switch (filter.Turno_AsignadoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Asignacion_de_Turnos.Numero_de_Turno LIKE '" + filter.AdvanceTurno_Asignado + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Asignacion_de_Turnos.Numero_de_Turno LIKE '%" + filter.AdvanceTurno_Asignado + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Asignacion_de_Turnos.Numero_de_Turno = '" + filter.AdvanceTurno_Asignado + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Asignacion_de_Turnos.Numero_de_Turno LIKE '%" + filter.AdvanceTurno_Asignado + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTurno_AsignadoMultiple != null && filter.AdvanceTurno_AsignadoMultiple.Count() > 0)
            {
                var Turno_AsignadoIds = string.Join(",", filter.AdvanceTurno_AsignadoMultiple);

                where += " AND Modulo_Atencion_Inicial.Turno_Asignado In (" + Turno_AsignadoIds + ")";
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

                where += " AND Modulo_Atencion_Inicial.Usuario_que_Registra In (" + Usuario_que_RegistraIds + ")";
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

                where += " AND Modulo_Atencion_Inicial.Unidad In (" + UnidadIds + ")";
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

                where += " AND Modulo_Atencion_Inicial.Municipio In (" + MunicipioIds + ")";
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

                where += " AND Modulo_Atencion_Inicial.Region In (" + RegionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Denuncia))
            {
                switch (filter.Tipo_de_DenunciaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Denuncia.Descripcion LIKE '" + filter.AdvanceTipo_de_Denuncia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Denuncia.Descripcion LIKE '%" + filter.AdvanceTipo_de_Denuncia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Denuncia.Descripcion = '" + filter.AdvanceTipo_de_Denuncia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Denuncia.Descripcion LIKE '%" + filter.AdvanceTipo_de_Denuncia + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_DenunciaMultiple != null && filter.AdvanceTipo_de_DenunciaMultiple.Count() > 0)
            {
                var Tipo_de_DenunciaIds = string.Join(",", filter.AdvanceTipo_de_DenunciaMultiple);

                where += " AND Modulo_Atencion_Inicial.Tipo_de_Denuncia In (" + Tipo_de_DenunciaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.NUAT))
            {
                switch (filter.NUATFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_Atencion_Inicial.NUAT LIKE '" + filter.NUAT + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_Atencion_Inicial.NUAT LIKE '%" + filter.NUAT + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_Atencion_Inicial.NUAT = '" + filter.NUAT + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_Atencion_Inicial.NUAT LIKE '%" + filter.NUAT + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.CDI))
            {
                switch (filter.CDIFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_Atencion_Inicial.CDI LIKE '" + filter.CDI + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_Atencion_Inicial.CDI LIKE '%" + filter.CDI + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_Atencion_Inicial.CDI = '" + filter.CDI + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_Atencion_Inicial.CDI LIKE '%" + filter.CDI + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Expedientes_Relacionados))
            {
                switch (filter.Expedientes_RelacionadosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_Atencion_Inicial.Expedientes_Relacionados LIKE '" + filter.Expedientes_Relacionados + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_Atencion_Inicial.Expedientes_Relacionados LIKE '%" + filter.Expedientes_Relacionados + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_Atencion_Inicial.Expedientes_Relacionados = '" + filter.Expedientes_Relacionados + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_Atencion_Inicial.Expedientes_Relacionados LIKE '%" + filter.Expedientes_Relacionados + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstatus))
            {
                switch (filter.EstatusFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estatus.Descripcion LIKE '" + filter.AdvanceEstatus + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estatus.Descripcion LIKE '%" + filter.AdvanceEstatus + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estatus.Descripcion = '" + filter.AdvanceEstatus + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estatus.Descripcion LIKE '%" + filter.AdvanceEstatus + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstatusMultiple != null && filter.AdvanceEstatusMultiple.Count() > 0)
            {
                var EstatusIds = string.Join(",", filter.AdvanceEstatusMultiple);

                where += " AND Modulo_Atencion_Inicial.Estatus In (" + EstatusIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromGenerar_Cita) || !string.IsNullOrEmpty(filter.ToGenerar_Cita))
            {
                var Generar_CitaFrom = DateTime.ParseExact(filter.FromGenerar_Cita, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Generar_CitaTo = DateTime.ParseExact(filter.ToGenerar_Cita, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromGenerar_Cita))
                    where += " AND Modulo_Atencion_Inicial.Generar_Cita >= '" + Generar_CitaFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToGenerar_Cita))
                    where += " AND Modulo_Atencion_Inicial.Generar_Cita <= '" + Generar_CitaTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.Nombres_del_Remitente))
            {
                switch (filter.Nombres_del_RemitenteFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_Atencion_Inicial.Nombres_del_Remitente LIKE '" + filter.Nombres_del_Remitente + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_Atencion_Inicial.Nombres_del_Remitente LIKE '%" + filter.Nombres_del_Remitente + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_Atencion_Inicial.Nombres_del_Remitente = '" + filter.Nombres_del_Remitente + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_Atencion_Inicial.Nombres_del_Remitente LIKE '%" + filter.Nombres_del_Remitente + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_Paterno_del_Remitente))
            {
                switch (filter.Apellido_Paterno_del_RemitenteFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_Atencion_Inicial.Apellido_Paterno_del_Remitente LIKE '" + filter.Apellido_Paterno_del_Remitente + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_Atencion_Inicial.Apellido_Paterno_del_Remitente LIKE '%" + filter.Apellido_Paterno_del_Remitente + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_Atencion_Inicial.Apellido_Paterno_del_Remitente = '" + filter.Apellido_Paterno_del_Remitente + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_Atencion_Inicial.Apellido_Paterno_del_Remitente LIKE '%" + filter.Apellido_Paterno_del_Remitente + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_Materno_del_Remitente))
            {
                switch (filter.Apellido_Materno_del_RemitenteFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_Atencion_Inicial.Apellido_Materno_del_Remitente LIKE '" + filter.Apellido_Materno_del_Remitente + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_Atencion_Inicial.Apellido_Materno_del_Remitente LIKE '%" + filter.Apellido_Materno_del_Remitente + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_Atencion_Inicial.Apellido_Materno_del_Remitente = '" + filter.Apellido_Materno_del_Remitente + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_Atencion_Inicial.Apellido_Materno_del_Remitente LIKE '%" + filter.Apellido_Materno_del_Remitente + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_en_que_llega_para_validacion) || !string.IsNullOrEmpty(filter.ToFecha_en_que_llega_para_validacion))
            {
                var Fecha_en_que_llega_para_validacionFrom = DateTime.ParseExact(filter.FromFecha_en_que_llega_para_validacion, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_en_que_llega_para_validacionTo = DateTime.ParseExact(filter.ToFecha_en_que_llega_para_validacion, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_en_que_llega_para_validacion))
                    where += " AND Modulo_Atencion_Inicial.Fecha_en_que_llega_para_validacion >= '" + Fecha_en_que_llega_para_validacionFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_en_que_llega_para_validacion))
                    where += " AND Modulo_Atencion_Inicial.Fecha_en_que_llega_para_validacion <= '" + Fecha_en_que_llega_para_validacionTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceDelegacion))
            {
                switch (filter.DelegacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Delegacion.Descripcion LIKE '" + filter.AdvanceDelegacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Delegacion.Descripcion LIKE '%" + filter.AdvanceDelegacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Delegacion.Descripcion = '" + filter.AdvanceDelegacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Delegacion.Descripcion LIKE '%" + filter.AdvanceDelegacion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceDelegacionMultiple != null && filter.AdvanceDelegacionMultiple.Count() > 0)
            {
                var DelegacionIds = string.Join(",", filter.AdvanceDelegacionMultiple);

                where += " AND Modulo_Atencion_Inicial.Delegacion In (" + DelegacionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceAgencia))
            {
                switch (filter.AgenciaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Agencia.Descripcion LIKE '" + filter.AdvanceAgencia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Agencia.Descripcion LIKE '%" + filter.AdvanceAgencia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Agencia.Descripcion = '" + filter.AdvanceAgencia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Agencia.Descripcion LIKE '%" + filter.AdvanceAgencia + "%'";
                        break;
                }
            }
            else if (filter.AdvanceAgenciaMultiple != null && filter.AdvanceAgenciaMultiple.Count() > 0)
            {
                var AgenciaIds = string.Join(",", filter.AdvanceAgenciaMultiple);

                where += " AND Modulo_Atencion_Inicial.Agencia In (" + AgenciaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceMinisterio_Publico_en_Turno))
            {
                switch (filter.Ministerio_Publico_en_TurnoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Jefes_de_Usuarios_del_Sistema.Ministerio_Publico_en_Turno LIKE '" + filter.AdvanceMinisterio_Publico_en_Turno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Jefes_de_Usuarios_del_Sistema.Ministerio_Publico_en_Turno LIKE '%" + filter.AdvanceMinisterio_Publico_en_Turno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Jefes_de_Usuarios_del_Sistema.Ministerio_Publico_en_Turno = '" + filter.AdvanceMinisterio_Publico_en_Turno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Jefes_de_Usuarios_del_Sistema.Ministerio_Publico_en_Turno LIKE '%" + filter.AdvanceMinisterio_Publico_en_Turno + "%'";
                        break;
                }
            }
            else if (filter.AdvanceMinisterio_Publico_en_TurnoMultiple != null && filter.AdvanceMinisterio_Publico_en_TurnoMultiple.Count() > 0)
            {
                var Ministerio_Publico_en_TurnoIds = string.Join(",", filter.AdvanceMinisterio_Publico_en_TurnoMultiple);

                where += " AND Modulo_Atencion_Inicial.Ministerio_Publico_en_Turno In (" + Ministerio_Publico_en_TurnoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceSolicitud_de_Denuncia_Ciudadana))
            {
                switch (filter.Solicitud_de_Denuncia_CiudadanaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud_de_Denuncia_Ciudadana.Folio LIKE '" + filter.AdvanceSolicitud_de_Denuncia_Ciudadana + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud_de_Denuncia_Ciudadana.Folio LIKE '%" + filter.AdvanceSolicitud_de_Denuncia_Ciudadana + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud_de_Denuncia_Ciudadana.Folio = '" + filter.AdvanceSolicitud_de_Denuncia_Ciudadana + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud_de_Denuncia_Ciudadana.Folio LIKE '%" + filter.AdvanceSolicitud_de_Denuncia_Ciudadana + "%'";
                        break;
                }
            }
            else if (filter.AdvanceSolicitud_de_Denuncia_CiudadanaMultiple != null && filter.AdvanceSolicitud_de_Denuncia_CiudadanaMultiple.Count() > 0)
            {
                var Solicitud_de_Denuncia_CiudadanaIds = string.Join(",", filter.AdvanceSolicitud_de_Denuncia_CiudadanaMultiple);

                where += " AND Modulo_Atencion_Inicial.Solicitud_de_Denuncia_Ciudadana In (" + Solicitud_de_Denuncia_CiudadanaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Nombres_turno))
            {
                switch (filter.Nombres_turnoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_Atencion_Inicial.Nombres_turno LIKE '" + filter.Nombres_turno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_Atencion_Inicial.Nombres_turno LIKE '%" + filter.Nombres_turno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_Atencion_Inicial.Nombres_turno = '" + filter.Nombres_turno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_Atencion_Inicial.Nombres_turno LIKE '%" + filter.Nombres_turno + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_Paterno_turno))
            {
                switch (filter.Apellido_Paterno_turnoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_Atencion_Inicial.Apellido_Paterno_turno LIKE '" + filter.Apellido_Paterno_turno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_Atencion_Inicial.Apellido_Paterno_turno LIKE '%" + filter.Apellido_Paterno_turno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_Atencion_Inicial.Apellido_Paterno_turno = '" + filter.Apellido_Paterno_turno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_Atencion_Inicial.Apellido_Paterno_turno LIKE '%" + filter.Apellido_Paterno_turno + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_Materno_turno))
            {
                switch (filter.Apellido_Materno_turnoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_Atencion_Inicial.Apellido_Materno_turno LIKE '" + filter.Apellido_Materno_turno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_Atencion_Inicial.Apellido_Materno_turno LIKE '%" + filter.Apellido_Materno_turno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_Atencion_Inicial.Apellido_Materno_turno = '" + filter.Apellido_Materno_turno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_Atencion_Inicial.Apellido_Materno_turno LIKE '%" + filter.Apellido_Materno_turno + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceSexo_turno))
            {
                switch (filter.Sexo_turnoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Genero.Descripcion LIKE '" + filter.AdvanceSexo_turno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Genero.Descripcion LIKE '%" + filter.AdvanceSexo_turno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Genero.Descripcion = '" + filter.AdvanceSexo_turno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Genero.Descripcion LIKE '%" + filter.AdvanceSexo_turno + "%'";
                        break;
                }
            }
            else if (filter.AdvanceSexo_turnoMultiple != null && filter.AdvanceSexo_turnoMultiple.Count() > 0)
            {
                var Sexo_turnoIds = string.Join(",", filter.AdvanceSexo_turnoMultiple);

                where += " AND Modulo_Atencion_Inicial.Sexo_turno In (" + Sexo_turnoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromEdad_turno) || !string.IsNullOrEmpty(filter.ToEdad_turno))
            {
                if (!string.IsNullOrEmpty(filter.FromEdad_turno))
                    where += " AND Modulo_Atencion_Inicial.Edad_turno >= " + filter.FromEdad_turno;
                if (!string.IsNullOrEmpty(filter.ToEdad_turno))
                    where += " AND Modulo_Atencion_Inicial.Edad_turno <= " + filter.ToEdad_turno;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Atencion_turno))
            {
                switch (filter.Tipo_de_Atencion_turnoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Atencion.Descripcion LIKE '" + filter.AdvanceTipo_de_Atencion_turno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Atencion.Descripcion LIKE '%" + filter.AdvanceTipo_de_Atencion_turno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Atencion.Descripcion = '" + filter.AdvanceTipo_de_Atencion_turno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Atencion.Descripcion LIKE '%" + filter.AdvanceTipo_de_Atencion_turno + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_Atencion_turnoMultiple != null && filter.AdvanceTipo_de_Atencion_turnoMultiple.Count() > 0)
            {
                var Tipo_de_Atencion_turnoIds = string.Join(",", filter.AdvanceTipo_de_Atencion_turnoMultiple);

                where += " AND Modulo_Atencion_Inicial.Tipo_de_Atencion_turno In (" + Tipo_de_Atencion_turnoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Identificacion_turno))
            {
                switch (filter.Tipo_de_Identificacion_turnoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Identificacion.Nombre LIKE '" + filter.AdvanceTipo_de_Identificacion_turno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Identificacion.Nombre LIKE '%" + filter.AdvanceTipo_de_Identificacion_turno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Identificacion.Nombre = '" + filter.AdvanceTipo_de_Identificacion_turno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Identificacion.Nombre LIKE '%" + filter.AdvanceTipo_de_Identificacion_turno + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_Identificacion_turnoMultiple != null && filter.AdvanceTipo_de_Identificacion_turnoMultiple.Count() > 0)
            {
                var Tipo_de_Identificacion_turnoIds = string.Join(",", filter.AdvanceTipo_de_Identificacion_turnoMultiple);

                where += " AND Modulo_Atencion_Inicial.Tipo_de_Identificacion_turno In (" + Tipo_de_Identificacion_turnoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Numero_de_Identificacion_turno))
            {
                switch (filter.Numero_de_Identificacion_turnoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_Atencion_Inicial.Numero_de_Identificacion_turno LIKE '" + filter.Numero_de_Identificacion_turno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_Atencion_Inicial.Numero_de_Identificacion_turno LIKE '%" + filter.Numero_de_Identificacion_turno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_Atencion_Inicial.Numero_de_Identificacion_turno = '" + filter.Numero_de_Identificacion_turno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_Atencion_Inicial.Numero_de_Identificacion_turno LIKE '%" + filter.Numero_de_Identificacion_turno + "%'";
                        break;
                }
            }

            if (filter.Urgencia_turno != RadioOptions.NoApply)
                where += " AND Modulo_Atencion_Inicial.Urgencia_turno = " + Convert.ToInt32(filter.Urgencia_turno);

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Urgencia_turno))
            {
                switch (filter.Tipo_de_Urgencia_turnoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Urgencia.Descripcion LIKE '" + filter.AdvanceTipo_de_Urgencia_turno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Urgencia.Descripcion LIKE '%" + filter.AdvanceTipo_de_Urgencia_turno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Urgencia.Descripcion = '" + filter.AdvanceTipo_de_Urgencia_turno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Urgencia.Descripcion LIKE '%" + filter.AdvanceTipo_de_Urgencia_turno + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_Urgencia_turnoMultiple != null && filter.AdvanceTipo_de_Urgencia_turnoMultiple.Count() > 0)
            {
                var Tipo_de_Urgencia_turnoIds = string.Join(",", filter.AdvanceTipo_de_Urgencia_turnoMultiple);

                where += " AND Modulo_Atencion_Inicial.Tipo_de_Urgencia_turno In (" + Tipo_de_Urgencia_turnoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceMotivo_Finalizacion_Turno))
            {
                switch (filter.Motivo_Finalizacion_TurnoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Motivo_Finalizacion_Turno.Descripcion LIKE '" + filter.AdvanceMotivo_Finalizacion_Turno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Motivo_Finalizacion_Turno.Descripcion LIKE '%" + filter.AdvanceMotivo_Finalizacion_Turno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Motivo_Finalizacion_Turno.Descripcion = '" + filter.AdvanceMotivo_Finalizacion_Turno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Motivo_Finalizacion_Turno.Descripcion LIKE '%" + filter.AdvanceMotivo_Finalizacion_Turno + "%'";
                        break;
                }
            }
            else if (filter.AdvanceMotivo_Finalizacion_TurnoMultiple != null && filter.AdvanceMotivo_Finalizacion_TurnoMultiple.Count() > 0)
            {
                var Motivo_Finalizacion_TurnoIds = string.Join(",", filter.AdvanceMotivo_Finalizacion_TurnoMultiple);

                where += " AND Modulo_Atencion_Inicial.Motivo_Finalizacion_Turno In (" + Motivo_Finalizacion_TurnoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Observaciones_turno))
            {
                switch (filter.Observaciones_turnoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_Atencion_Inicial.Observaciones_turno LIKE '" + filter.Observaciones_turno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_Atencion_Inicial.Observaciones_turno LIKE '%" + filter.Observaciones_turno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_Atencion_Inicial.Observaciones_turno = '" + filter.Observaciones_turno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_Atencion_Inicial.Observaciones_turno LIKE '%" + filter.Observaciones_turno + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Titulo_del_Hecho))
            {
                switch (filter.Titulo_del_HechoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_Atencion_Inicial.Titulo_del_Hecho LIKE '" + filter.Titulo_del_Hecho + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_Atencion_Inicial.Titulo_del_Hecho LIKE '%" + filter.Titulo_del_Hecho + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_Atencion_Inicial.Titulo_del_Hecho = '" + filter.Titulo_del_Hecho + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_Atencion_Inicial.Titulo_del_Hecho LIKE '%" + filter.Titulo_del_Hecho + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Narrativa_Breve_de_los_Hechos))
            {
                switch (filter.Narrativa_Breve_de_los_HechosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_Atencion_Inicial.Narrativa_Breve_de_los_Hechos LIKE '" + filter.Narrativa_Breve_de_los_Hechos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_Atencion_Inicial.Narrativa_Breve_de_los_Hechos LIKE '%" + filter.Narrativa_Breve_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_Atencion_Inicial.Narrativa_Breve_de_los_Hechos = '" + filter.Narrativa_Breve_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_Atencion_Inicial.Narrativa_Breve_de_los_Hechos LIKE '%" + filter.Narrativa_Breve_de_los_Hechos + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvancePrioridad_del_Hecho))
            {
                switch (filter.Prioridad_del_HechoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Prioridad_del_Hecho.Descripcion LIKE '" + filter.AdvancePrioridad_del_Hecho + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Prioridad_del_Hecho.Descripcion LIKE '%" + filter.AdvancePrioridad_del_Hecho + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Prioridad_del_Hecho.Descripcion = '" + filter.AdvancePrioridad_del_Hecho + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Prioridad_del_Hecho.Descripcion LIKE '%" + filter.AdvancePrioridad_del_Hecho + "%'";
                        break;
                }
            }
            else if (filter.AdvancePrioridad_del_HechoMultiple != null && filter.AdvancePrioridad_del_HechoMultiple.Count() > 0)
            {
                var Prioridad_del_HechoIds = string.Join(",", filter.AdvancePrioridad_del_HechoMultiple);

                where += " AND Modulo_Atencion_Inicial.Prioridad_del_Hecho In (" + Prioridad_del_HechoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceOrientador))
            {
                switch (filter.OrientadorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_User.Name LIKE '" + filter.AdvanceOrientador + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceOrientador + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_User.Name = '" + filter.AdvanceOrientador + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceOrientador + "%'";
                        break;
                }
            }
            else if (filter.AdvanceOrientadorMultiple != null && filter.AdvanceOrientadorMultiple.Count() > 0)
            {
                var OrientadorIds = string.Join(",", filter.AdvanceOrientadorMultiple);

                where += " AND Modulo_Atencion_Inicial.Orientador In (" + OrientadorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_del_Hecho) || !string.IsNullOrEmpty(filter.ToFecha_del_Hecho))
            {
                var Fecha_del_HechoFrom = DateTime.ParseExact(filter.FromFecha_del_Hecho, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_del_HechoTo = DateTime.ParseExact(filter.ToFecha_del_Hecho, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_del_Hecho))
                    where += " AND Modulo_Atencion_Inicial.Fecha_del_Hecho >= '" + Fecha_del_HechoFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_del_Hecho))
                    where += " AND Modulo_Atencion_Inicial.Fecha_del_Hecho <= '" + Fecha_del_HechoTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_del_Hecho) || !string.IsNullOrEmpty(filter.ToHora_del_Hecho))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_del_Hecho))
                    where += " AND Convert(TIME,Modulo_Atencion_Inicial.Hora_del_Hecho) >='" + filter.FromHora_del_Hecho + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_del_Hecho))
                    where += " AND Convert(TIME,Modulo_Atencion_Inicial.Hora_del_Hecho) <='" + filter.ToHora_del_Hecho + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvancePais_de_los_Hechos))
            {
                switch (filter.Pais_de_los_HechosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Pais.Nombre LIKE '" + filter.AdvancePais_de_los_Hechos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Pais.Nombre LIKE '%" + filter.AdvancePais_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Pais.Nombre = '" + filter.AdvancePais_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Pais.Nombre LIKE '%" + filter.AdvancePais_de_los_Hechos + "%'";
                        break;
                }
            }
            else if (filter.AdvancePais_de_los_HechosMultiple != null && filter.AdvancePais_de_los_HechosMultiple.Count() > 0)
            {
                var Pais_de_los_HechosIds = string.Join(",", filter.AdvancePais_de_los_HechosMultiple);

                where += " AND Modulo_Atencion_Inicial.Pais_de_los_Hechos In (" + Pais_de_los_HechosIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstado_de_los_Hechos))
            {
                switch (filter.Estado_de_los_HechosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estado.Nombre LIKE '" + filter.AdvanceEstado_de_los_Hechos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEstado_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estado.Nombre = '" + filter.AdvanceEstado_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEstado_de_los_Hechos + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstado_de_los_HechosMultiple != null && filter.AdvanceEstado_de_los_HechosMultiple.Count() > 0)
            {
                var Estado_de_los_HechosIds = string.Join(",", filter.AdvanceEstado_de_los_HechosMultiple);

                where += " AND Modulo_Atencion_Inicial.Estado_de_los_Hechos In (" + Estado_de_los_HechosIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceMunicipio_de_los_Hechos))
            {
                switch (filter.Municipio_de_los_HechosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Municipio.Nombre LIKE '" + filter.AdvanceMunicipio_de_los_Hechos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Municipio.Nombre = '" + filter.AdvanceMunicipio_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio_de_los_Hechos + "%'";
                        break;
                }
            }
            else if (filter.AdvanceMunicipio_de_los_HechosMultiple != null && filter.AdvanceMunicipio_de_los_HechosMultiple.Count() > 0)
            {
                var Municipio_de_los_HechosIds = string.Join(",", filter.AdvanceMunicipio_de_los_HechosMultiple);

                where += " AND Modulo_Atencion_Inicial.Municipio_de_los_Hechos In (" + Municipio_de_los_HechosIds + ")";
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

                where += " AND Modulo_Atencion_Inicial.Poblacion In (" + PoblacionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceColonia_de_los_Hechos))
            {
                switch (filter.Colonia_de_los_HechosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Colonia.Nombre LIKE '" + filter.AdvanceColonia_de_los_Hechos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvanceColonia_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Colonia.Nombre = '" + filter.AdvanceColonia_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvanceColonia_de_los_Hechos + "%'";
                        break;
                }
            }
            else if (filter.AdvanceColonia_de_los_HechosMultiple != null && filter.AdvanceColonia_de_los_HechosMultiple.Count() > 0)
            {
                var Colonia_de_los_HechosIds = string.Join(",", filter.AdvanceColonia_de_los_HechosMultiple);

                where += " AND Modulo_Atencion_Inicial.Colonia_de_los_Hechos In (" + Colonia_de_los_HechosIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromCodigo_Postal_de_los_Hechos) || !string.IsNullOrEmpty(filter.ToCodigo_Postal_de_los_Hechos))
            {
                if (!string.IsNullOrEmpty(filter.FromCodigo_Postal_de_los_Hechos))
                    where += " AND Modulo_Atencion_Inicial.Codigo_Postal_de_los_Hechos >= " + filter.FromCodigo_Postal_de_los_Hechos;
                if (!string.IsNullOrEmpty(filter.ToCodigo_Postal_de_los_Hechos))
                    where += " AND Modulo_Atencion_Inicial.Codigo_Postal_de_los_Hechos <= " + filter.ToCodigo_Postal_de_los_Hechos;
            }

            if (!string.IsNullOrEmpty(filter.Calle_de_los_Hechos))
            {
                switch (filter.Calle_de_los_HechosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_Atencion_Inicial.Calle_de_los_Hechos LIKE '" + filter.Calle_de_los_Hechos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_Atencion_Inicial.Calle_de_los_Hechos LIKE '%" + filter.Calle_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_Atencion_Inicial.Calle_de_los_Hechos = '" + filter.Calle_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_Atencion_Inicial.Calle_de_los_Hechos LIKE '%" + filter.Calle_de_los_Hechos + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Entre_Calle))
            {
                switch (filter.Entre_CalleFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_Atencion_Inicial.Entre_Calle LIKE '" + filter.Entre_Calle + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_Atencion_Inicial.Entre_Calle LIKE '%" + filter.Entre_Calle + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_Atencion_Inicial.Entre_Calle = '" + filter.Entre_Calle + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_Atencion_Inicial.Entre_Calle LIKE '%" + filter.Entre_Calle + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Y_Calle))
            {
                switch (filter.Y_CalleFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_Atencion_Inicial.Y_Calle LIKE '" + filter.Y_Calle + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_Atencion_Inicial.Y_Calle LIKE '%" + filter.Y_Calle + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_Atencion_Inicial.Y_Calle = '" + filter.Y_Calle + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_Atencion_Inicial.Y_Calle LIKE '%" + filter.Y_Calle + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_Exrterior_de_los_Hechos))
            {
                switch (filter.Numero_Exrterior_de_los_HechosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_Atencion_Inicial.Numero_Exrterior_de_los_Hechos LIKE '" + filter.Numero_Exrterior_de_los_Hechos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_Atencion_Inicial.Numero_Exrterior_de_los_Hechos LIKE '%" + filter.Numero_Exrterior_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_Atencion_Inicial.Numero_Exrterior_de_los_Hechos = '" + filter.Numero_Exrterior_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_Atencion_Inicial.Numero_Exrterior_de_los_Hechos LIKE '%" + filter.Numero_Exrterior_de_los_Hechos + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_Interior_de_los_Hechos))
            {
                switch (filter.Numero_Interior_de_los_HechosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_Atencion_Inicial.Numero_Interior_de_los_Hechos LIKE '" + filter.Numero_Interior_de_los_Hechos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_Atencion_Inicial.Numero_Interior_de_los_Hechos LIKE '%" + filter.Numero_Interior_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_Atencion_Inicial.Numero_Interior_de_los_Hechos = '" + filter.Numero_Interior_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_Atencion_Inicial.Numero_Interior_de_los_Hechos LIKE '%" + filter.Numero_Interior_de_los_Hechos + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Referencia_hechos))
            {
                switch (filter.Referencia_hechosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_Atencion_Inicial.Referencia_hechos LIKE '" + filter.Referencia_hechos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_Atencion_Inicial.Referencia_hechos LIKE '%" + filter.Referencia_hechos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_Atencion_Inicial.Referencia_hechos = '" + filter.Referencia_hechos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_Atencion_Inicial.Referencia_hechos LIKE '%" + filter.Referencia_hechos + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Latitud))
            {
                switch (filter.LatitudFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_Atencion_Inicial.Latitud LIKE '" + filter.Latitud + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_Atencion_Inicial.Latitud LIKE '%" + filter.Latitud + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_Atencion_Inicial.Latitud = '" + filter.Latitud + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_Atencion_Inicial.Latitud LIKE '%" + filter.Latitud + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Longitud))
            {
                switch (filter.LongitudFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_Atencion_Inicial.Longitud LIKE '" + filter.Longitud + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_Atencion_Inicial.Longitud LIKE '%" + filter.Longitud + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_Atencion_Inicial.Longitud = '" + filter.Longitud + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_Atencion_Inicial.Longitud LIKE '%" + filter.Longitud + "%'";
                        break;
                }
            }

            if (filter.Documento_Extraviado_hechos != RadioOptions.NoApply)
                where += " AND Modulo_Atencion_Inicial.Documento_Extraviado_hechos = " + Convert.ToInt32(filter.Documento_Extraviado_hechos);

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Documento_Extraviado))
            {
                switch (filter.Tipo_de_Documento_ExtraviadoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Documento_Extraviado.Descripcion LIKE '" + filter.AdvanceTipo_de_Documento_Extraviado + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Documento_Extraviado.Descripcion LIKE '%" + filter.AdvanceTipo_de_Documento_Extraviado + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Documento_Extraviado.Descripcion = '" + filter.AdvanceTipo_de_Documento_Extraviado + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Documento_Extraviado.Descripcion LIKE '%" + filter.AdvanceTipo_de_Documento_Extraviado + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_Documento_ExtraviadoMultiple != null && filter.AdvanceTipo_de_Documento_ExtraviadoMultiple.Count() > 0)
            {
                var Tipo_de_Documento_ExtraviadoIds = string.Join(",", filter.AdvanceTipo_de_Documento_ExtraviadoMultiple);

                where += " AND Modulo_Atencion_Inicial.Tipo_de_Documento_Extraviado In (" + Tipo_de_Documento_ExtraviadoIds + ")";
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

                where += " AND Modulo_Atencion_Inicial.Tipo_de_Lugar_del_Hecho In (" + Tipo_de_Lugar_del_HechoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceZona_de_los_Hechos))
            {
                switch (filter.Zona_de_los_HechosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Zona.Descripcion LIKE '" + filter.AdvanceZona_de_los_Hechos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Zona.Descripcion LIKE '%" + filter.AdvanceZona_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Zona.Descripcion = '" + filter.AdvanceZona_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Zona.Descripcion LIKE '%" + filter.AdvanceZona_de_los_Hechos + "%'";
                        break;
                }
            }
            else if (filter.AdvanceZona_de_los_HechosMultiple != null && filter.AdvanceZona_de_los_HechosMultiple.Count() > 0)
            {
                var Zona_de_los_HechosIds = string.Join(",", filter.AdvanceZona_de_los_HechosMultiple);

                where += " AND Modulo_Atencion_Inicial.Zona_de_los_Hechos In (" + Zona_de_los_HechosIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Turno))
            {
                switch (filter.TurnoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_Atencion_Inicial.Turno LIKE '" + filter.Turno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_Atencion_Inicial.Turno LIKE '%" + filter.Turno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_Atencion_Inicial.Turno = '" + filter.Turno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_Atencion_Inicial.Turno LIKE '%" + filter.Turno + "%'";
                        break;
                }
            }

            if (filter.Cerrar != RadioOptions.NoApply)
                where += " AND Modulo_Atencion_Inicial.Cerrar = " + Convert.ToInt32(filter.Cerrar);

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Cierre) || !string.IsNullOrEmpty(filter.ToFecha_de_Cierre))
            {
                var Fecha_de_CierreFrom = DateTime.ParseExact(filter.FromFecha_de_Cierre, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_CierreTo = DateTime.ParseExact(filter.ToFecha_de_Cierre, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Cierre))
                    where += " AND Modulo_Atencion_Inicial.Fecha_de_Cierre >= '" + Fecha_de_CierreFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Cierre))
                    where += " AND Modulo_Atencion_Inicial.Fecha_de_Cierre <= '" + Fecha_de_CierreTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Cierre) || !string.IsNullOrEmpty(filter.ToHora_de_Cierre))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Cierre))
                    where += " AND Convert(TIME,Modulo_Atencion_Inicial.Hora_de_Cierre) >='" + filter.FromHora_de_Cierre + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Cierre))
                    where += " AND Convert(TIME,Modulo_Atencion_Inicial.Hora_de_Cierre) <='" + filter.ToHora_de_Cierre + "'";
            }


            where = new Regex(Regex.Escape("AND ")).Replace(where, "", 1);
            return where;
        }

        [NonAction]
        public Grid_File ConvertSpartane_FileToGridFile(Spartane.Core.Domain.Spartane_File.Spartane_File file)
        {
            return file == null ? new Grid_File { FileId = 0, FileSize = 0, FileName = "" } : new Grid_File { FileId = file.File_Id, FileName = file.Description, FileSize = file.File_Size ?? 0, };
        }

        public ActionResult GetDetalle_de_coincidencias_a(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_coincidencias_aGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_coincidencias_aApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_coincidencias_a.Modulo_Atencion_Inicial=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_coincidencias_a.Modulo_Atencion_Inicial='" + RelationId + "'";
            }
            var result = _IDetalle_de_coincidencias_aApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_coincidencias_as == null)
                result.Detalle_de_coincidencias_as = new List<Detalle_de_coincidencias_a>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_coincidencias_as.Select(m => new Detalle_de_coincidencias_aGridModel
                {
                    Clave = m.Clave

			,Nombre_Completo = m.Nombre_Completo
			,Alias = m.Alias
			,NUAT = m.NUAT
			,Fuente_de_Origen = m.Fuente_de_Origen

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_coincidencias_aGridModel> GetDetalle_de_coincidencias_aData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_coincidencias_aGridModel> resultData = new List<Detalle_de_coincidencias_aGridModel>();
            string where = "Detalle_de_coincidencias_a.Modulo_Atencion_Inicial=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_coincidencias_a.Modulo_Atencion_Inicial='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_coincidencias_aApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_coincidencias_aApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_coincidencias_as != null)
            {
                resultData = result.Detalle_de_coincidencias_as.Select(m => new Detalle_de_coincidencias_aGridModel
                    {
                        Clave = m.Clave

			,Nombre_Completo = m.Nombre_Completo
			,Alias = m.Alias
			,NUAT = m.NUAT
			,Fuente_de_Origen = m.Fuente_de_Origen


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_Historico_MPO(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_Historico_MPOGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Historico_MPOApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_Historico_MPO.Modulo_Atencion_Inicial=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_Historico_MPO.Modulo_Atencion_Inicial='" + RelationId + "'";
            }
            var result = _IDetalle_Historico_MPOApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_Historico_MPOs == null)
                result.Detalle_Historico_MPOs = new List<Detalle_Historico_MPO>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_Historico_MPOs.Select(m => new Detalle_Historico_MPOGridModel
                {
                    Clave = m.Clave

			,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora
			,Usuario = m.Usuario
			,Estatus = m.Estatus

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_Historico_MPOGridModel> GetDetalle_Historico_MPOData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_Historico_MPOGridModel> resultData = new List<Detalle_Historico_MPOGridModel>();
            string where = "Detalle_Historico_MPO.Modulo_Atencion_Inicial=" + Id;
            if("int" == "string")
            {
                where = "Detalle_Historico_MPO.Modulo_Atencion_Inicial='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Historico_MPOApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_Historico_MPOApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_Historico_MPOs != null)
            {
                resultData = result.Detalle_Historico_MPOs.Select(m => new Detalle_Historico_MPOGridModel
                    {
                        Clave = m.Clave

			,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora
			,Usuario = m.Usuario
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
                _IModulo_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);

                Modulo_Atencion_Inicial varModulo_Atencion_Inicial = null;
                if (id.ToString() != "0")
                {
                        string where = "";
                    _IDetalle_de_coincidencias_aApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_coincidencias_a.Modulo_Atencion_Inicial=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_coincidencias_a.Modulo_Atencion_Inicial='" + id + "'";
                    }
                    var Detalle_de_coincidencias_aInfo =
                        _IDetalle_de_coincidencias_aApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_coincidencias_aInfo.Detalle_de_coincidencias_as.Count > 0)
                    {
                        var resultDetalle_de_coincidencias_a = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_coincidencias_aItem in Detalle_de_coincidencias_aInfo.Detalle_de_coincidencias_as)
                            resultDetalle_de_coincidencias_a = resultDetalle_de_coincidencias_a
                                              && _IDetalle_de_coincidencias_aApiConsumer.Delete(Detalle_de_coincidencias_aItem.Clave, null,null).Resource;

                        if (!resultDetalle_de_coincidencias_a)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_Historico_MPOApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_Historico_MPO.Modulo_Atencion_Inicial=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_Historico_MPO.Modulo_Atencion_Inicial='" + id + "'";
                    }
                    var Detalle_Historico_MPOInfo =
                        _IDetalle_Historico_MPOApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_Historico_MPOInfo.Detalle_Historico_MPOs.Count > 0)
                    {
                        var resultDetalle_Historico_MPO = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_Historico_MPOItem in Detalle_Historico_MPOInfo.Detalle_Historico_MPOs)
                            resultDetalle_Historico_MPO = resultDetalle_Historico_MPO
                                              && _IDetalle_Historico_MPOApiConsumer.Delete(Detalle_Historico_MPOItem.Clave, null,null).Resource;

                        if (!resultDetalle_Historico_MPO)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }

                }
                var result = _IModulo_Atencion_InicialApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Modulo_Atencion_InicialModel varModulo_Atencion_Inicial)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IModulo_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Modulo_Atencion_InicialInfo = new Modulo_Atencion_Inicial
                    {
                        Clave = varModulo_Atencion_Inicial.Clave
                        ,Folio = varModulo_Atencion_Inicial.Folio
                        ,Fecha_de_Registro = (!String.IsNullOrEmpty(varModulo_Atencion_Inicial.Fecha_de_Registro)) ? DateTime.ParseExact(varModulo_Atencion_Inicial.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Registro = varModulo_Atencion_Inicial.Hora_de_Registro
                        ,Turno_Asignado = varModulo_Atencion_Inicial.Turno_Asignado
                        ,Usuario_que_Registra = varModulo_Atencion_Inicial.Usuario_que_Registra
                        ,Unidad = varModulo_Atencion_Inicial.Unidad
                        ,Municipio = varModulo_Atencion_Inicial.Municipio
                        ,Region = varModulo_Atencion_Inicial.Region
                        ,Tipo_de_Denuncia = varModulo_Atencion_Inicial.Tipo_de_Denuncia
                        ,NUAT = varModulo_Atencion_Inicial.NUAT
                        ,CDI = varModulo_Atencion_Inicial.CDI
                        ,Expedientes_Relacionados = varModulo_Atencion_Inicial.Expedientes_Relacionados
                        ,Estatus = varModulo_Atencion_Inicial.Estatus
                        ,Generar_Cita = (!String.IsNullOrEmpty(varModulo_Atencion_Inicial.Generar_Cita)) ? DateTime.ParseExact(varModulo_Atencion_Inicial.Generar_Cita, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Nombres_del_Remitente = varModulo_Atencion_Inicial.Nombres_del_Remitente
                        ,Apellido_Paterno_del_Remitente = varModulo_Atencion_Inicial.Apellido_Paterno_del_Remitente
                        ,Apellido_Materno_del_Remitente = varModulo_Atencion_Inicial.Apellido_Materno_del_Remitente
                        ,Fecha_en_que_llega_para_validacion = (!String.IsNullOrEmpty(varModulo_Atencion_Inicial.Fecha_en_que_llega_para_validacion)) ? DateTime.ParseExact(varModulo_Atencion_Inicial.Fecha_en_que_llega_para_validacion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Delegacion = varModulo_Atencion_Inicial.Delegacion
                        ,Agencia = varModulo_Atencion_Inicial.Agencia
                        ,Ministerio_Publico_en_Turno = varModulo_Atencion_Inicial.Ministerio_Publico_en_Turno
                        ,Solicitud_de_Denuncia_Ciudadana = varModulo_Atencion_Inicial.Solicitud_de_Denuncia_Ciudadana
                        ,Nombres_turno = varModulo_Atencion_Inicial.Nombres_turno
                        ,Apellido_Paterno_turno = varModulo_Atencion_Inicial.Apellido_Paterno_turno
                        ,Apellido_Materno_turno = varModulo_Atencion_Inicial.Apellido_Materno_turno
                        ,Sexo_turno = varModulo_Atencion_Inicial.Sexo_turno
                        ,Edad_turno = varModulo_Atencion_Inicial.Edad_turno
                        ,Tipo_de_Atencion_turno = varModulo_Atencion_Inicial.Tipo_de_Atencion_turno
                        ,Tipo_de_Identificacion_turno = varModulo_Atencion_Inicial.Tipo_de_Identificacion_turno
                        ,Numero_de_Identificacion_turno = varModulo_Atencion_Inicial.Numero_de_Identificacion_turno
                        ,Urgencia_turno = varModulo_Atencion_Inicial.Urgencia_turno
                        ,Tipo_de_Urgencia_turno = varModulo_Atencion_Inicial.Tipo_de_Urgencia_turno
                        ,Motivo_Finalizacion_Turno = varModulo_Atencion_Inicial.Motivo_Finalizacion_Turno
                        ,Observaciones_turno = varModulo_Atencion_Inicial.Observaciones_turno
                        ,Titulo_del_Hecho = varModulo_Atencion_Inicial.Titulo_del_Hecho
                        ,Narrativa_Breve_de_los_Hechos = varModulo_Atencion_Inicial.Narrativa_Breve_de_los_Hechos
                        ,Prioridad_del_Hecho = varModulo_Atencion_Inicial.Prioridad_del_Hecho
                        ,Orientador = varModulo_Atencion_Inicial.Orientador
                        ,Fecha_del_Hecho = (!String.IsNullOrEmpty(varModulo_Atencion_Inicial.Fecha_del_Hecho)) ? DateTime.ParseExact(varModulo_Atencion_Inicial.Fecha_del_Hecho, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_del_Hecho = varModulo_Atencion_Inicial.Hora_del_Hecho
                        ,Pais_de_los_Hechos = varModulo_Atencion_Inicial.Pais_de_los_Hechos
                        ,Estado_de_los_Hechos = varModulo_Atencion_Inicial.Estado_de_los_Hechos
                        ,Municipio_de_los_Hechos = varModulo_Atencion_Inicial.Municipio_de_los_Hechos
                        ,Poblacion = varModulo_Atencion_Inicial.Poblacion
                        ,Colonia_de_los_Hechos = varModulo_Atencion_Inicial.Colonia_de_los_Hechos
                        ,Codigo_Postal_de_los_Hechos = varModulo_Atencion_Inicial.Codigo_Postal_de_los_Hechos
                        ,Calle_de_los_Hechos = varModulo_Atencion_Inicial.Calle_de_los_Hechos
                        ,Entre_Calle = varModulo_Atencion_Inicial.Entre_Calle
                        ,Y_Calle = varModulo_Atencion_Inicial.Y_Calle
                        ,Numero_Exrterior_de_los_Hechos = varModulo_Atencion_Inicial.Numero_Exrterior_de_los_Hechos
                        ,Numero_Interior_de_los_Hechos = varModulo_Atencion_Inicial.Numero_Interior_de_los_Hechos
                        ,Referencia_hechos = varModulo_Atencion_Inicial.Referencia_hechos
                        ,Latitud = varModulo_Atencion_Inicial.Latitud
                        ,Longitud = varModulo_Atencion_Inicial.Longitud
                        ,Documento_Extraviado_hechos = varModulo_Atencion_Inicial.Documento_Extraviado_hechos
                        ,Tipo_de_Documento_Extraviado = varModulo_Atencion_Inicial.Tipo_de_Documento_Extraviado
                        ,Tipo_de_Lugar_del_Hecho = varModulo_Atencion_Inicial.Tipo_de_Lugar_del_Hecho
                        ,Zona_de_los_Hechos = varModulo_Atencion_Inicial.Zona_de_los_Hechos
                        ,Turno = varModulo_Atencion_Inicial.Turno
                        ,Cerrar = varModulo_Atencion_Inicial.Cerrar
                        ,Fecha_de_Cierre = (!String.IsNullOrEmpty(varModulo_Atencion_Inicial.Fecha_de_Cierre)) ? DateTime.ParseExact(varModulo_Atencion_Inicial.Fecha_de_Cierre, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Cierre = varModulo_Atencion_Inicial.Hora_de_Cierre

                    };

                    result = !IsNew ?
                        _IModulo_Atencion_InicialApiConsumer.Update(Modulo_Atencion_InicialInfo, null, null).Resource.ToString() :
                         _IModulo_Atencion_InicialApiConsumer.Insert(Modulo_Atencion_InicialInfo, null, null).Resource.ToString();
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
        public bool CopyDetalle_de_coincidencias_a(int MasterId, int referenceId, List<Detalle_de_coincidencias_aGridModelPost> Detalle_de_coincidencias_aItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_coincidencias_aApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_coincidencias_aData = _IDetalle_de_coincidencias_aApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_coincidencias_a.Modulo_Atencion_Inicial=" + referenceId,"").Resource;
                if (Detalle_de_coincidencias_aData == null || Detalle_de_coincidencias_aData.Detalle_de_coincidencias_as.Count == 0)
                    return true;

                var result = true;

                Detalle_de_coincidencias_aGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_coincidencias_a in Detalle_de_coincidencias_aData.Detalle_de_coincidencias_as)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_coincidencias_a Detalle_de_coincidencias_a1 = varDetalle_de_coincidencias_a;

                    if (Detalle_de_coincidencias_aItems != null && Detalle_de_coincidencias_aItems.Any(m => m.Clave == Detalle_de_coincidencias_a1.Clave))
                    {
                        modelDataToChange = Detalle_de_coincidencias_aItems.FirstOrDefault(m => m.Clave == Detalle_de_coincidencias_a1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_de_coincidencias_a.Modulo_Atencion_Inicial = MasterId;
                    var insertId = _IDetalle_de_coincidencias_aApiConsumer.Insert(varDetalle_de_coincidencias_a,null,null).Resource;
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
        public ActionResult PostDetalle_de_coincidencias_a(List<Detalle_de_coincidencias_aGridModelPost> Detalle_de_coincidencias_aItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_coincidencias_a(MasterId, referenceId, Detalle_de_coincidencias_aItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_coincidencias_aItems != null && Detalle_de_coincidencias_aItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_coincidencias_aApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_coincidencias_aItem in Detalle_de_coincidencias_aItems)
                    {






                        //Removal Request
                        if (Detalle_de_coincidencias_aItem.Removed)
                        {
                            result = result && _IDetalle_de_coincidencias_aApiConsumer.Delete(Detalle_de_coincidencias_aItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_coincidencias_aItem.Clave = 0;

                        var Detalle_de_coincidencias_aData = new Detalle_de_coincidencias_a
                        {
                            Modulo_Atencion_Inicial = MasterId
                            ,Clave = Detalle_de_coincidencias_aItem.Clave
                            ,Nombre_Completo = Detalle_de_coincidencias_aItem.Nombre_Completo
                            ,Alias = Detalle_de_coincidencias_aItem.Alias
                            ,NUAT = Detalle_de_coincidencias_aItem.NUAT
                            ,Fuente_de_Origen = Detalle_de_coincidencias_aItem.Fuente_de_Origen

                        };

                        var resultId = Detalle_de_coincidencias_aItem.Clave > 0
                           ? _IDetalle_de_coincidencias_aApiConsumer.Update(Detalle_de_coincidencias_aData,null,null).Resource
                           : _IDetalle_de_coincidencias_aApiConsumer.Insert(Detalle_de_coincidencias_aData,null,null).Resource;

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







        [NonAction]
        public bool CopyDetalle_Historico_MPO(int MasterId, int referenceId, List<Detalle_Historico_MPOGridModelPost> Detalle_Historico_MPOItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_Historico_MPOApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_Historico_MPOData = _IDetalle_Historico_MPOApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_Historico_MPO.Modulo_Atencion_Inicial=" + referenceId,"").Resource;
                if (Detalle_Historico_MPOData == null || Detalle_Historico_MPOData.Detalle_Historico_MPOs.Count == 0)
                    return true;

                var result = true;

                Detalle_Historico_MPOGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_Historico_MPO in Detalle_Historico_MPOData.Detalle_Historico_MPOs)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_Historico_MPO Detalle_Historico_MPO1 = varDetalle_Historico_MPO;

                    if (Detalle_Historico_MPOItems != null && Detalle_Historico_MPOItems.Any(m => m.Clave == Detalle_Historico_MPO1.Clave))
                    {
                        modelDataToChange = Detalle_Historico_MPOItems.FirstOrDefault(m => m.Clave == Detalle_Historico_MPO1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_Historico_MPO.Modulo_Atencion_Inicial = MasterId;
                    var insertId = _IDetalle_Historico_MPOApiConsumer.Insert(varDetalle_Historico_MPO,null,null).Resource;
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
        public ActionResult PostDetalle_Historico_MPO(List<Detalle_Historico_MPOGridModelPost> Detalle_Historico_MPOItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_Historico_MPO(MasterId, referenceId, Detalle_Historico_MPOItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_Historico_MPOItems != null && Detalle_Historico_MPOItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_Historico_MPOApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_Historico_MPOItem in Detalle_Historico_MPOItems)
                    {






                        //Removal Request
                        if (Detalle_Historico_MPOItem.Removed)
                        {
                            result = result && _IDetalle_Historico_MPOApiConsumer.Delete(Detalle_Historico_MPOItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_Historico_MPOItem.Clave = 0;

                        var Detalle_Historico_MPOData = new Detalle_Historico_MPO
                        {
                            Modulo_Atencion_Inicial = MasterId
                            ,Clave = Detalle_Historico_MPOItem.Clave
                            ,Fecha = (Detalle_Historico_MPOItem.Fecha!= null) ? DateTime.ParseExact(Detalle_Historico_MPOItem.Fecha, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                            ,Hora = Detalle_Historico_MPOItem.Hora
                            ,Usuario = Detalle_Historico_MPOItem.Usuario
                            ,Estatus = Detalle_Historico_MPOItem.Estatus

                        };

                        var resultId = Detalle_Historico_MPOItem.Clave > 0
                           ? _IDetalle_Historico_MPOApiConsumer.Update(Detalle_Historico_MPOData,null,null).Resource
                           : _IDetalle_Historico_MPOApiConsumer.Insert(Detalle_Historico_MPOData,null,null).Resource;

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









        /// <summary>
        /// Write Element Array of Modulo_Atencion_Inicial script
        /// </summary>
        /// <param name="oModulo_Atencion_InicialElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Modulo_Atencion_InicialModuleAttributeList)
        {
            for (int i = 0; i < Modulo_Atencion_InicialModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Modulo_Atencion_InicialModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Modulo_Atencion_InicialModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Modulo_Atencion_InicialModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Modulo_Atencion_InicialModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Modulo_Atencion_InicialModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Modulo_Atencion_InicialModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Modulo_Atencion_InicialModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Modulo_Atencion_InicialModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Modulo_Atencion_InicialModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Modulo_Atencion_InicialModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Modulo_Atencion_InicialModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strModulo_Atencion_InicialScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Modulo_Atencion_Inicial.js")))
            {
                strModulo_Atencion_InicialScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Modulo_Atencion_Inicial element attributes
            string userChangeJson = jsSerialize.Serialize(Modulo_Atencion_InicialModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strModulo_Atencion_InicialScript.IndexOf("inpuElementArray");
            string splittedString = strModulo_Atencion_InicialScript.Substring(indexOfArray, strModulo_Atencion_InicialScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Modulo_Atencion_InicialModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Modulo_Atencion_InicialModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strModulo_Atencion_InicialScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strModulo_Atencion_InicialScript.Substring(indexOfArrayHistory, strModulo_Atencion_InicialScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strModulo_Atencion_InicialScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strModulo_Atencion_InicialScript.Substring(endIndexOfMainElement + indexOfArray, strModulo_Atencion_InicialScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Modulo_Atencion_InicialModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Modulo_Atencion_InicialModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Modulo_Atencion_Inicial.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Modulo_Atencion_Inicial.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Modulo_Atencion_Inicial.js")))
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
        public ActionResult Modulo_Atencion_InicialPropertyBag()
        {
            return PartialView("Modulo_Atencion_InicialPropertyBag", "Modulo_Atencion_Inicial");
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
        public ActionResult AddDetalle_de_coincidencias_a(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_coincidencias_a/AddDetalle_de_coincidencias_a");
        }

        [HttpGet]
        public ActionResult AddDetalle_Historico_MPO(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_Historico_MPO/AddDetalle_Historico_MPO");
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
                var whereClauseFormat = "Object = 45004 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IModulo_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Modulo_Atencion_Inicial.Clave= " + RecordId;
                            var result = _IModulo_Atencion_InicialApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IModulo_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Modulo_Atencion_InicialPropertyMapper());
			
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
                    (Modulo_Atencion_InicialAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Modulo_Atencion_InicialPropertyMapper oModulo_Atencion_InicialPropertyMapper = new Modulo_Atencion_InicialPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oModulo_Atencion_InicialPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IModulo_Atencion_InicialApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Modulo_Atencion_Inicials == null)
                result.Modulo_Atencion_Inicials = new List<Modulo_Atencion_Inicial>();

            var data = result.Modulo_Atencion_Inicials.Select(m => new Modulo_Atencion_InicialGridModel
            {
                Clave = m.Clave
			,Folio = m.Folio
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Turno_AsignadoNumero_de_Turno = CultureHelper.GetTraduction(m.Turno_Asignado_Asignacion_de_Turnos.Folio.ToString(), "Asignacion_de_Turnos") ?? (string)m.Turno_Asignado_Asignacion_de_Turnos.Numero_de_Turno
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,UnidadDescripcion = CultureHelper.GetTraduction(m.Unidad_Unidad.Clave.ToString(), "Descripcion") ?? (string)m.Unidad_Unidad.Descripcion
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,RegionDescripcion = CultureHelper.GetTraduction(m.Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Region_Region.Descripcion
                        ,Tipo_de_DenunciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Denuncia_Tipo_de_Denuncia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Denuncia_Tipo_de_Denuncia.Descripcion
			,NUAT = m.NUAT
			,CDI = m.CDI
			,Expedientes_Relacionados = m.Expedientes_Relacionados
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus.Descripcion
                        ,Generar_Cita = (m.Generar_Cita == null ? string.Empty : Convert.ToDateTime(m.Generar_Cita).ToString(ConfigurationProperty.DateFormat))
			,Nombres_del_Remitente = m.Nombres_del_Remitente
			,Apellido_Paterno_del_Remitente = m.Apellido_Paterno_del_Remitente
			,Apellido_Materno_del_Remitente = m.Apellido_Materno_del_Remitente
                        ,Fecha_en_que_llega_para_validacion = (m.Fecha_en_que_llega_para_validacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_en_que_llega_para_validacion).ToString(ConfigurationProperty.DateFormat))
                        ,DelegacionDescripcion = CultureHelper.GetTraduction(m.Delegacion_Delegacion.Clave.ToString(), "Descripcion") ?? (string)m.Delegacion_Delegacion.Descripcion
                        ,AgenciaDescripcion = CultureHelper.GetTraduction(m.Agencia_Agencia.ClaveID.ToString(), "Descripcion") ?? (string)m.Agencia_Agencia.Descripcion
                        ,Ministerio_Publico_en_TurnoMinisterio_Publico_en_Turno = CultureHelper.GetTraduction(m.Ministerio_Publico_en_Turno_Jefes_de_Usuarios_del_Sistema.Clave.ToString(), "Jefes_de_Usuarios_del_Sistema") ?? (string)m.Ministerio_Publico_en_Turno_Jefes_de_Usuarios_del_Sistema.Ministerio_Publico_en_Turno
                        ,Solicitud_de_Denuncia_CiudadanaFolio = CultureHelper.GetTraduction(m.Solicitud_de_Denuncia_Ciudadana_Solicitud_de_Denuncia_Ciudadana.Clave.ToString(), "Solicitud_de_Denuncia_Ciudadana") ?? (string)m.Solicitud_de_Denuncia_Ciudadana_Solicitud_de_Denuncia_Ciudadana.Folio
			,Nombres_turno = m.Nombres_turno
			,Apellido_Paterno_turno = m.Apellido_Paterno_turno
			,Apellido_Materno_turno = m.Apellido_Materno_turno
                        ,Sexo_turnoDescripcion = CultureHelper.GetTraduction(m.Sexo_turno_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_turno_Genero.Descripcion
			,Edad_turno = m.Edad_turno
                        ,Tipo_de_Atencion_turnoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Atencion_turno_Tipo_de_Atencion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Atencion_turno_Tipo_de_Atencion.Descripcion
                        ,Tipo_de_Identificacion_turnoNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_turno_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_turno_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion_turno = m.Numero_de_Identificacion_turno
			,Urgencia_turno = m.Urgencia_turno
                        ,Tipo_de_Urgencia_turnoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Urgencia_turno_Tipo_de_Urgencia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Urgencia_turno_Tipo_de_Urgencia.Descripcion
                        ,Motivo_Finalizacion_TurnoDescripcion = CultureHelper.GetTraduction(m.Motivo_Finalizacion_Turno_Motivo_Finalizacion_Turno.Clave.ToString(), "Descripcion") ?? (string)m.Motivo_Finalizacion_Turno_Motivo_Finalizacion_Turno.Descripcion
			,Observaciones_turno = m.Observaciones_turno
			,Titulo_del_Hecho = m.Titulo_del_Hecho
			,Narrativa_Breve_de_los_Hechos = m.Narrativa_Breve_de_los_Hechos
                        ,Prioridad_del_HechoDescripcion = CultureHelper.GetTraduction(m.Prioridad_del_Hecho_Prioridad_del_Hecho.Clave.ToString(), "Descripcion") ?? (string)m.Prioridad_del_Hecho_Prioridad_del_Hecho.Descripcion
                        ,OrientadorName = CultureHelper.GetTraduction(m.Orientador_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Orientador_Spartan_User.Name
                        ,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
			,Hora_del_Hecho = m.Hora_del_Hecho
                        ,Pais_de_los_HechosNombre = CultureHelper.GetTraduction(m.Pais_de_los_Hechos_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_de_los_Hechos_Pais.Nombre
                        ,Estado_de_los_HechosNombre = CultureHelper.GetTraduction(m.Estado_de_los_Hechos_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_de_los_Hechos_Estado.Nombre
                        ,Municipio_de_los_HechosNombre = CultureHelper.GetTraduction(m.Municipio_de_los_Hechos_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_de_los_Hechos_Municipio.Nombre
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,Colonia_de_los_HechosNombre = CultureHelper.GetTraduction(m.Colonia_de_los_Hechos_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_de_los_Hechos_Colonia.Nombre
			,Codigo_Postal_de_los_Hechos = m.Codigo_Postal_de_los_Hechos
			,Calle_de_los_Hechos = m.Calle_de_los_Hechos
			,Entre_Calle = m.Entre_Calle
			,Y_Calle = m.Y_Calle
			,Numero_Exrterior_de_los_Hechos = m.Numero_Exrterior_de_los_Hechos
			,Numero_Interior_de_los_Hechos = m.Numero_Interior_de_los_Hechos
			,Referencia_hechos = m.Referencia_hechos
			,Latitud = m.Latitud
			,Longitud = m.Longitud
			,Documento_Extraviado_hechos = m.Documento_Extraviado_hechos
                        ,Tipo_de_Documento_ExtraviadoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Documento_Extraviado_Documento_Extraviado.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Documento_Extraviado_Documento_Extraviado.Descripcion
                        ,Tipo_de_Lugar_del_HechoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Descripcion
                        ,Zona_de_los_HechosDescripcion = CultureHelper.GetTraduction(m.Zona_de_los_Hechos_Zona.Clave.ToString(), "Descripcion") ?? (string)m.Zona_de_los_Hechos_Zona.Descripcion
			,Turno = m.Turno
			,Cerrar = m.Cerrar
                        ,Fecha_de_Cierre = (m.Fecha_de_Cierre == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Cierre).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Cierre = m.Hora_de_Cierre

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45004, arrayColumnsVisible), "Modulo_Atencion_InicialList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45004, arrayColumnsVisible), "Modulo_Atencion_InicialList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45004, arrayColumnsVisible), "Modulo_Atencion_InicialList_" + DateTime.Now.ToString());
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

            _IModulo_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Modulo_Atencion_InicialPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Modulo_Atencion_InicialAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Modulo_Atencion_InicialPropertyMapper oModulo_Atencion_InicialPropertyMapper = new Modulo_Atencion_InicialPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oModulo_Atencion_InicialPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IModulo_Atencion_InicialApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Modulo_Atencion_Inicials == null)
                result.Modulo_Atencion_Inicials = new List<Modulo_Atencion_Inicial>();

            var data = result.Modulo_Atencion_Inicials.Select(m => new Modulo_Atencion_InicialGridModel
            {
                Clave = m.Clave
			,Folio = m.Folio
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Turno_AsignadoNumero_de_Turno = CultureHelper.GetTraduction(m.Turno_Asignado_Asignacion_de_Turnos.Folio.ToString(), "Asignacion_de_Turnos") ?? (string)m.Turno_Asignado_Asignacion_de_Turnos.Numero_de_Turno
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,UnidadDescripcion = CultureHelper.GetTraduction(m.Unidad_Unidad.Clave.ToString(), "Descripcion") ?? (string)m.Unidad_Unidad.Descripcion
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,RegionDescripcion = CultureHelper.GetTraduction(m.Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Region_Region.Descripcion
                        ,Tipo_de_DenunciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Denuncia_Tipo_de_Denuncia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Denuncia_Tipo_de_Denuncia.Descripcion
			,NUAT = m.NUAT
			,CDI = m.CDI
			,Expedientes_Relacionados = m.Expedientes_Relacionados
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus.Descripcion
                        ,Generar_Cita = (m.Generar_Cita == null ? string.Empty : Convert.ToDateTime(m.Generar_Cita).ToString(ConfigurationProperty.DateFormat))
			,Nombres_del_Remitente = m.Nombres_del_Remitente
			,Apellido_Paterno_del_Remitente = m.Apellido_Paterno_del_Remitente
			,Apellido_Materno_del_Remitente = m.Apellido_Materno_del_Remitente
                        ,Fecha_en_que_llega_para_validacion = (m.Fecha_en_que_llega_para_validacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_en_que_llega_para_validacion).ToString(ConfigurationProperty.DateFormat))
                        ,DelegacionDescripcion = CultureHelper.GetTraduction(m.Delegacion_Delegacion.Clave.ToString(), "Descripcion") ?? (string)m.Delegacion_Delegacion.Descripcion
                        ,AgenciaDescripcion = CultureHelper.GetTraduction(m.Agencia_Agencia.ClaveID.ToString(), "Descripcion") ?? (string)m.Agencia_Agencia.Descripcion
                        ,Ministerio_Publico_en_TurnoMinisterio_Publico_en_Turno = CultureHelper.GetTraduction(m.Ministerio_Publico_en_Turno_Jefes_de_Usuarios_del_Sistema.Clave.ToString(), "Jefes_de_Usuarios_del_Sistema") ?? (string)m.Ministerio_Publico_en_Turno_Jefes_de_Usuarios_del_Sistema.Ministerio_Publico_en_Turno
                        ,Solicitud_de_Denuncia_CiudadanaFolio = CultureHelper.GetTraduction(m.Solicitud_de_Denuncia_Ciudadana_Solicitud_de_Denuncia_Ciudadana.Clave.ToString(), "Solicitud_de_Denuncia_Ciudadana") ?? (string)m.Solicitud_de_Denuncia_Ciudadana_Solicitud_de_Denuncia_Ciudadana.Folio
			,Nombres_turno = m.Nombres_turno
			,Apellido_Paterno_turno = m.Apellido_Paterno_turno
			,Apellido_Materno_turno = m.Apellido_Materno_turno
                        ,Sexo_turnoDescripcion = CultureHelper.GetTraduction(m.Sexo_turno_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_turno_Genero.Descripcion
			,Edad_turno = m.Edad_turno
                        ,Tipo_de_Atencion_turnoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Atencion_turno_Tipo_de_Atencion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Atencion_turno_Tipo_de_Atencion.Descripcion
                        ,Tipo_de_Identificacion_turnoNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_turno_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_turno_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion_turno = m.Numero_de_Identificacion_turno
			,Urgencia_turno = m.Urgencia_turno
                        ,Tipo_de_Urgencia_turnoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Urgencia_turno_Tipo_de_Urgencia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Urgencia_turno_Tipo_de_Urgencia.Descripcion
                        ,Motivo_Finalizacion_TurnoDescripcion = CultureHelper.GetTraduction(m.Motivo_Finalizacion_Turno_Motivo_Finalizacion_Turno.Clave.ToString(), "Descripcion") ?? (string)m.Motivo_Finalizacion_Turno_Motivo_Finalizacion_Turno.Descripcion
			,Observaciones_turno = m.Observaciones_turno
			,Titulo_del_Hecho = m.Titulo_del_Hecho
			,Narrativa_Breve_de_los_Hechos = m.Narrativa_Breve_de_los_Hechos
                        ,Prioridad_del_HechoDescripcion = CultureHelper.GetTraduction(m.Prioridad_del_Hecho_Prioridad_del_Hecho.Clave.ToString(), "Descripcion") ?? (string)m.Prioridad_del_Hecho_Prioridad_del_Hecho.Descripcion
                        ,OrientadorName = CultureHelper.GetTraduction(m.Orientador_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Orientador_Spartan_User.Name
                        ,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
			,Hora_del_Hecho = m.Hora_del_Hecho
                        ,Pais_de_los_HechosNombre = CultureHelper.GetTraduction(m.Pais_de_los_Hechos_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_de_los_Hechos_Pais.Nombre
                        ,Estado_de_los_HechosNombre = CultureHelper.GetTraduction(m.Estado_de_los_Hechos_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_de_los_Hechos_Estado.Nombre
                        ,Municipio_de_los_HechosNombre = CultureHelper.GetTraduction(m.Municipio_de_los_Hechos_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_de_los_Hechos_Municipio.Nombre
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,Colonia_de_los_HechosNombre = CultureHelper.GetTraduction(m.Colonia_de_los_Hechos_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_de_los_Hechos_Colonia.Nombre
			,Codigo_Postal_de_los_Hechos = m.Codigo_Postal_de_los_Hechos
			,Calle_de_los_Hechos = m.Calle_de_los_Hechos
			,Entre_Calle = m.Entre_Calle
			,Y_Calle = m.Y_Calle
			,Numero_Exrterior_de_los_Hechos = m.Numero_Exrterior_de_los_Hechos
			,Numero_Interior_de_los_Hechos = m.Numero_Interior_de_los_Hechos
			,Referencia_hechos = m.Referencia_hechos
			,Latitud = m.Latitud
			,Longitud = m.Longitud
			,Documento_Extraviado_hechos = m.Documento_Extraviado_hechos
                        ,Tipo_de_Documento_ExtraviadoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Documento_Extraviado_Documento_Extraviado.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Documento_Extraviado_Documento_Extraviado.Descripcion
                        ,Tipo_de_Lugar_del_HechoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Descripcion
                        ,Zona_de_los_HechosDescripcion = CultureHelper.GetTraduction(m.Zona_de_los_Hechos_Zona.Clave.ToString(), "Descripcion") ?? (string)m.Zona_de_los_Hechos_Zona.Descripcion
			,Turno = m.Turno
			,Cerrar = m.Cerrar
                        ,Fecha_de_Cierre = (m.Fecha_de_Cierre == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Cierre).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Cierre = m.Hora_de_Cierre

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
                _IModulo_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IModulo_Atencion_InicialApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_del_Caso(Modulo_Atencion_Inicial_Datos_del_CasoModel varModulo_Atencion_Inicial)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModulo_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Modulo_Atencion_Inicial_Datos_del_CasoInfo = new Modulo_Atencion_Inicial_Datos_del_Caso
                {
                    Clave = varModulo_Atencion_Inicial.Clave
                                            ,Folio = varModulo_Atencion_Inicial.Folio
                        ,Fecha_de_Registro = (!String.IsNullOrEmpty(varModulo_Atencion_Inicial.Fecha_de_Registro)) ? DateTime.ParseExact(varModulo_Atencion_Inicial.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Registro = varModulo_Atencion_Inicial.Hora_de_Registro
                        ,Turno_Asignado = varModulo_Atencion_Inicial.Turno_Asignado
                        ,Usuario_que_Registra = varModulo_Atencion_Inicial.Usuario_que_Registra
                        ,Unidad = varModulo_Atencion_Inicial.Unidad
                        ,Municipio = varModulo_Atencion_Inicial.Municipio
                        ,Region = varModulo_Atencion_Inicial.Region
                        ,Tipo_de_Denuncia = varModulo_Atencion_Inicial.Tipo_de_Denuncia
                        ,NUAT = varModulo_Atencion_Inicial.NUAT
                        ,CDI = varModulo_Atencion_Inicial.CDI
                        ,Expedientes_Relacionados = varModulo_Atencion_Inicial.Expedientes_Relacionados
                        ,Estatus = varModulo_Atencion_Inicial.Estatus
                        ,Generar_Cita = (!String.IsNullOrEmpty(varModulo_Atencion_Inicial.Generar_Cita)) ? DateTime.ParseExact(varModulo_Atencion_Inicial.Generar_Cita, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Nombres_del_Remitente = varModulo_Atencion_Inicial.Nombres_del_Remitente
                        ,Apellido_Paterno_del_Remitente = varModulo_Atencion_Inicial.Apellido_Paterno_del_Remitente
                        ,Apellido_Materno_del_Remitente = varModulo_Atencion_Inicial.Apellido_Materno_del_Remitente
                        ,Fecha_en_que_llega_para_validacion = (!String.IsNullOrEmpty(varModulo_Atencion_Inicial.Fecha_en_que_llega_para_validacion)) ? DateTime.ParseExact(varModulo_Atencion_Inicial.Fecha_en_que_llega_para_validacion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Delegacion = varModulo_Atencion_Inicial.Delegacion
                        ,Agencia = varModulo_Atencion_Inicial.Agencia
                        ,Ministerio_Publico_en_Turno = varModulo_Atencion_Inicial.Ministerio_Publico_en_Turno
                        ,Solicitud_de_Denuncia_Ciudadana = varModulo_Atencion_Inicial.Solicitud_de_Denuncia_Ciudadana
                    
                };

                result = _IModulo_Atencion_InicialApiConsumer.Update_Datos_del_Caso(Modulo_Atencion_Inicial_Datos_del_CasoInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Datos_del_Caso(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModulo_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IModulo_Atencion_InicialApiConsumer.Get_Datos_del_Caso(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_de_coincidencias_a;
                var Detalle_de_coincidencias_aData = GetDetalle_de_coincidencias_aData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_coincidencias_a);
                int RowCount_Detalle_Historico_MPO;
                var Detalle_Historico_MPOData = GetDetalle_Historico_MPOData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Historico_MPO);

                var result = new Modulo_Atencion_Inicial_Datos_del_CasoModel
                {
                    Clave = m.Clave
			,Folio = m.Folio
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Turno_Asignado = m.Turno_Asignado
                        ,Turno_AsignadoNumero_de_Turno = CultureHelper.GetTraduction(m.Turno_Asignado_Asignacion_de_Turnos.Folio.ToString(), "Asignacion_de_Turnos") ?? (string)m.Turno_Asignado_Asignacion_de_Turnos.Numero_de_Turno
                        ,Usuario_que_Registra = m.Usuario_que_Registra
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,Unidad = m.Unidad
                        ,UnidadDescripcion = CultureHelper.GetTraduction(m.Unidad_Unidad.Clave.ToString(), "Descripcion") ?? (string)m.Unidad_Unidad.Descripcion
                        ,Municipio = m.Municipio
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,Region = m.Region
                        ,RegionDescripcion = CultureHelper.GetTraduction(m.Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Region_Region.Descripcion
                        ,Tipo_de_Denuncia = m.Tipo_de_Denuncia
                        ,Tipo_de_DenunciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Denuncia_Tipo_de_Denuncia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Denuncia_Tipo_de_Denuncia.Descripcion
			,NUAT = m.NUAT
			,CDI = m.CDI
			,Expedientes_Relacionados = m.Expedientes_Relacionados
                        ,Estatus = m.Estatus
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus.Descripcion
                        ,Generar_Cita = (m.Generar_Cita == null ? string.Empty : Convert.ToDateTime(m.Generar_Cita).ToString(ConfigurationProperty.DateFormat))
			,Nombres_del_Remitente = m.Nombres_del_Remitente
			,Apellido_Paterno_del_Remitente = m.Apellido_Paterno_del_Remitente
			,Apellido_Materno_del_Remitente = m.Apellido_Materno_del_Remitente
                        ,Fecha_en_que_llega_para_validacion = (m.Fecha_en_que_llega_para_validacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_en_que_llega_para_validacion).ToString(ConfigurationProperty.DateFormat))
                        ,Delegacion = m.Delegacion
                        ,DelegacionDescripcion = CultureHelper.GetTraduction(m.Delegacion_Delegacion.Clave.ToString(), "Descripcion") ?? (string)m.Delegacion_Delegacion.Descripcion
                        ,Agencia = m.Agencia
                        ,AgenciaDescripcion = CultureHelper.GetTraduction(m.Agencia_Agencia.ClaveID.ToString(), "Descripcion") ?? (string)m.Agencia_Agencia.Descripcion
                        ,Ministerio_Publico_en_Turno = m.Ministerio_Publico_en_Turno
                        ,Ministerio_Publico_en_TurnoMinisterio_Publico_en_Turno = CultureHelper.GetTraduction(m.Ministerio_Publico_en_Turno_Jefes_de_Usuarios_del_Sistema.Clave.ToString(), "Jefes_de_Usuarios_del_Sistema") ?? (string)m.Ministerio_Publico_en_Turno_Jefes_de_Usuarios_del_Sistema.Ministerio_Publico_en_Turno
                        ,Solicitud_de_Denuncia_Ciudadana = m.Solicitud_de_Denuncia_Ciudadana
                        ,Solicitud_de_Denuncia_CiudadanaFolio = CultureHelper.GetTraduction(m.Solicitud_de_Denuncia_Ciudadana_Solicitud_de_Denuncia_Ciudadana.Clave.ToString(), "Solicitud_de_Denuncia_Ciudadana") ?? (string)m.Solicitud_de_Denuncia_Ciudadana_Solicitud_de_Denuncia_Ciudadana.Folio

                    
                };
				var resultData = new
                {
                    data = result
                    ,Coincidencias = Detalle_de_coincidencias_aData
                    ,Historial = Detalle_Historico_MPOData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Informacion_de_Turno(Modulo_Atencion_Inicial_Informacion_de_TurnoModel varModulo_Atencion_Inicial)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModulo_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Modulo_Atencion_Inicial_Informacion_de_TurnoInfo = new Modulo_Atencion_Inicial_Informacion_de_Turno
                {
                    Clave = varModulo_Atencion_Inicial.Clave
                                            ,Nombres_turno = varModulo_Atencion_Inicial.Nombres_turno
                        ,Apellido_Paterno_turno = varModulo_Atencion_Inicial.Apellido_Paterno_turno
                        ,Apellido_Materno_turno = varModulo_Atencion_Inicial.Apellido_Materno_turno
                        ,Sexo_turno = varModulo_Atencion_Inicial.Sexo_turno
                        ,Edad_turno = varModulo_Atencion_Inicial.Edad_turno
                        ,Tipo_de_Atencion_turno = varModulo_Atencion_Inicial.Tipo_de_Atencion_turno
                        ,Tipo_de_Identificacion_turno = varModulo_Atencion_Inicial.Tipo_de_Identificacion_turno
                        ,Numero_de_Identificacion_turno = varModulo_Atencion_Inicial.Numero_de_Identificacion_turno
                        ,Urgencia_turno = varModulo_Atencion_Inicial.Urgencia_turno
                        ,Tipo_de_Urgencia_turno = varModulo_Atencion_Inicial.Tipo_de_Urgencia_turno
                        ,Motivo_Finalizacion_Turno = varModulo_Atencion_Inicial.Motivo_Finalizacion_Turno
                        ,Observaciones_turno = varModulo_Atencion_Inicial.Observaciones_turno
                    
                };

                result = _IModulo_Atencion_InicialApiConsumer.Update_Informacion_de_Turno(Modulo_Atencion_Inicial_Informacion_de_TurnoInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Informacion_de_Turno(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModulo_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IModulo_Atencion_InicialApiConsumer.Get_Informacion_de_Turno(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_de_coincidencias_a;
                var Detalle_de_coincidencias_aData = GetDetalle_de_coincidencias_aData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_coincidencias_a);
                int RowCount_Detalle_Historico_MPO;
                var Detalle_Historico_MPOData = GetDetalle_Historico_MPOData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Historico_MPO);

                var result = new Modulo_Atencion_Inicial_Informacion_de_TurnoModel
                {
                    Clave = m.Clave
			,Nombres_turno = m.Nombres_turno
			,Apellido_Paterno_turno = m.Apellido_Paterno_turno
			,Apellido_Materno_turno = m.Apellido_Materno_turno
                        ,Sexo_turno = m.Sexo_turno
                        ,Sexo_turnoDescripcion = CultureHelper.GetTraduction(m.Sexo_turno_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_turno_Genero.Descripcion
			,Edad_turno = m.Edad_turno
                        ,Tipo_de_Atencion_turno = m.Tipo_de_Atencion_turno
                        ,Tipo_de_Atencion_turnoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Atencion_turno_Tipo_de_Atencion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Atencion_turno_Tipo_de_Atencion.Descripcion
                        ,Tipo_de_Identificacion_turno = m.Tipo_de_Identificacion_turno
                        ,Tipo_de_Identificacion_turnoNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_turno_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_turno_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion_turno = m.Numero_de_Identificacion_turno
			,Urgencia_turno = m.Urgencia_turno
                        ,Tipo_de_Urgencia_turno = m.Tipo_de_Urgencia_turno
                        ,Tipo_de_Urgencia_turnoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Urgencia_turno_Tipo_de_Urgencia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Urgencia_turno_Tipo_de_Urgencia.Descripcion
                        ,Motivo_Finalizacion_Turno = m.Motivo_Finalizacion_Turno
                        ,Motivo_Finalizacion_TurnoDescripcion = CultureHelper.GetTraduction(m.Motivo_Finalizacion_Turno_Motivo_Finalizacion_Turno.Clave.ToString(), "Descripcion") ?? (string)m.Motivo_Finalizacion_Turno_Motivo_Finalizacion_Turno.Descripcion
			,Observaciones_turno = m.Observaciones_turno

                    
                };
				var resultData = new
                {
                    data = result
                    ,Coincidencias = Detalle_de_coincidencias_aData
                    ,Historial = Detalle_Historico_MPOData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Datos_de_los_Hechos_en_MPO(Modulo_Atencion_Inicial_Datos_de_los_Hechos_en_MPOModel varModulo_Atencion_Inicial)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModulo_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Modulo_Atencion_Inicial_Datos_de_los_Hechos_en_MPOInfo = new Modulo_Atencion_Inicial_Datos_de_los_Hechos_en_MPO
                {
                    Clave = varModulo_Atencion_Inicial.Clave
                                            ,Titulo_del_Hecho = varModulo_Atencion_Inicial.Titulo_del_Hecho
                        ,Narrativa_Breve_de_los_Hechos = varModulo_Atencion_Inicial.Narrativa_Breve_de_los_Hechos
                        ,Prioridad_del_Hecho = varModulo_Atencion_Inicial.Prioridad_del_Hecho
                        ,Orientador = varModulo_Atencion_Inicial.Orientador
                        ,Fecha_del_Hecho = (!String.IsNullOrEmpty(varModulo_Atencion_Inicial.Fecha_del_Hecho)) ? DateTime.ParseExact(varModulo_Atencion_Inicial.Fecha_del_Hecho, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_del_Hecho = varModulo_Atencion_Inicial.Hora_del_Hecho
                        ,Pais_de_los_Hechos = varModulo_Atencion_Inicial.Pais_de_los_Hechos
                        ,Estado_de_los_Hechos = varModulo_Atencion_Inicial.Estado_de_los_Hechos
                        ,Municipio_de_los_Hechos = varModulo_Atencion_Inicial.Municipio_de_los_Hechos
                        ,Poblacion = varModulo_Atencion_Inicial.Poblacion
                        ,Colonia_de_los_Hechos = varModulo_Atencion_Inicial.Colonia_de_los_Hechos
                        ,Codigo_Postal_de_los_Hechos = varModulo_Atencion_Inicial.Codigo_Postal_de_los_Hechos
                        ,Calle_de_los_Hechos = varModulo_Atencion_Inicial.Calle_de_los_Hechos
                        ,Entre_Calle = varModulo_Atencion_Inicial.Entre_Calle
                        ,Y_Calle = varModulo_Atencion_Inicial.Y_Calle
                        ,Numero_Exrterior_de_los_Hechos = varModulo_Atencion_Inicial.Numero_Exrterior_de_los_Hechos
                        ,Numero_Interior_de_los_Hechos = varModulo_Atencion_Inicial.Numero_Interior_de_los_Hechos
                        ,Referencia_hechos = varModulo_Atencion_Inicial.Referencia_hechos
                        ,Latitud = varModulo_Atencion_Inicial.Latitud
                        ,Longitud = varModulo_Atencion_Inicial.Longitud
                        ,Documento_Extraviado_hechos = varModulo_Atencion_Inicial.Documento_Extraviado_hechos
                        ,Tipo_de_Documento_Extraviado = varModulo_Atencion_Inicial.Tipo_de_Documento_Extraviado
                        ,Tipo_de_Lugar_del_Hecho = varModulo_Atencion_Inicial.Tipo_de_Lugar_del_Hecho
                        ,Zona_de_los_Hechos = varModulo_Atencion_Inicial.Zona_de_los_Hechos
                        ,Turno = varModulo_Atencion_Inicial.Turno
                    
                };

                result = _IModulo_Atencion_InicialApiConsumer.Update_Datos_de_los_Hechos_en_MPO(Modulo_Atencion_Inicial_Datos_de_los_Hechos_en_MPOInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Datos_de_los_Hechos_en_MPO(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModulo_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IModulo_Atencion_InicialApiConsumer.Get_Datos_de_los_Hechos_en_MPO(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_de_coincidencias_a;
                var Detalle_de_coincidencias_aData = GetDetalle_de_coincidencias_aData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_coincidencias_a);
                int RowCount_Detalle_Historico_MPO;
                var Detalle_Historico_MPOData = GetDetalle_Historico_MPOData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Historico_MPO);

                var result = new Modulo_Atencion_Inicial_Datos_de_los_Hechos_en_MPOModel
                {
                    Clave = m.Clave
			,Titulo_del_Hecho = m.Titulo_del_Hecho
			,Narrativa_Breve_de_los_Hechos = m.Narrativa_Breve_de_los_Hechos
                        ,Prioridad_del_Hecho = m.Prioridad_del_Hecho
                        ,Prioridad_del_HechoDescripcion = CultureHelper.GetTraduction(m.Prioridad_del_Hecho_Prioridad_del_Hecho.Clave.ToString(), "Descripcion") ?? (string)m.Prioridad_del_Hecho_Prioridad_del_Hecho.Descripcion
                        ,Orientador = m.Orientador
                        ,OrientadorName = CultureHelper.GetTraduction(m.Orientador_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Orientador_Spartan_User.Name
                        ,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
			,Hora_del_Hecho = m.Hora_del_Hecho
                        ,Pais_de_los_Hechos = m.Pais_de_los_Hechos
                        ,Pais_de_los_HechosNombre = CultureHelper.GetTraduction(m.Pais_de_los_Hechos_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_de_los_Hechos_Pais.Nombre
                        ,Estado_de_los_Hechos = m.Estado_de_los_Hechos
                        ,Estado_de_los_HechosNombre = CultureHelper.GetTraduction(m.Estado_de_los_Hechos_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_de_los_Hechos_Estado.Nombre
                        ,Municipio_de_los_Hechos = m.Municipio_de_los_Hechos
                        ,Municipio_de_los_HechosNombre = CultureHelper.GetTraduction(m.Municipio_de_los_Hechos_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_de_los_Hechos_Municipio.Nombre
                        ,Poblacion = m.Poblacion
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,Colonia_de_los_Hechos = m.Colonia_de_los_Hechos
                        ,Colonia_de_los_HechosNombre = CultureHelper.GetTraduction(m.Colonia_de_los_Hechos_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_de_los_Hechos_Colonia.Nombre
			,Codigo_Postal_de_los_Hechos = m.Codigo_Postal_de_los_Hechos
			,Calle_de_los_Hechos = m.Calle_de_los_Hechos
			,Entre_Calle = m.Entre_Calle
			,Y_Calle = m.Y_Calle
			,Numero_Exrterior_de_los_Hechos = m.Numero_Exrterior_de_los_Hechos
			,Numero_Interior_de_los_Hechos = m.Numero_Interior_de_los_Hechos
			,Referencia_hechos = m.Referencia_hechos
			,Latitud = m.Latitud
			,Longitud = m.Longitud
			,Documento_Extraviado_hechos = m.Documento_Extraviado_hechos
                        ,Tipo_de_Documento_Extraviado = m.Tipo_de_Documento_Extraviado
                        ,Tipo_de_Documento_ExtraviadoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Documento_Extraviado_Documento_Extraviado.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Documento_Extraviado_Documento_Extraviado.Descripcion
                        ,Tipo_de_Lugar_del_Hecho = m.Tipo_de_Lugar_del_Hecho
                        ,Tipo_de_Lugar_del_HechoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Descripcion
                        ,Zona_de_los_Hechos = m.Zona_de_los_Hechos
                        ,Zona_de_los_HechosDescripcion = CultureHelper.GetTraduction(m.Zona_de_los_Hechos_Zona.Clave.ToString(), "Descripcion") ?? (string)m.Zona_de_los_Hechos_Zona.Descripcion
			,Turno = m.Turno

                    
                };
				var resultData = new
                {
                    data = result
                    ,Coincidencias = Detalle_de_coincidencias_aData
                    ,Historial = Detalle_Historico_MPOData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Bitacora_de_Coincidencias(Modulo_Atencion_Inicial_Bitacora_de_CoincidenciasModel varModulo_Atencion_Inicial)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModulo_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Modulo_Atencion_Inicial_Bitacora_de_CoincidenciasInfo = new Modulo_Atencion_Inicial_Bitacora_de_Coincidencias
                {
                    Clave = varModulo_Atencion_Inicial.Clave
                                        
                };

                result = _IModulo_Atencion_InicialApiConsumer.Update_Bitacora_de_Coincidencias(Modulo_Atencion_Inicial_Bitacora_de_CoincidenciasInfo).Resource.ToString();
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
                _IModulo_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IModulo_Atencion_InicialApiConsumer.Get_Bitacora_de_Coincidencias(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_de_coincidencias_a;
                var Detalle_de_coincidencias_aData = GetDetalle_de_coincidencias_aData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_coincidencias_a);
                int RowCount_Detalle_Historico_MPO;
                var Detalle_Historico_MPOData = GetDetalle_Historico_MPOData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Historico_MPO);

                var result = new Modulo_Atencion_Inicial_Bitacora_de_CoincidenciasModel
                {
                    Clave = m.Clave

                    
                };
				var resultData = new
                {
                    data = result
                    ,Coincidencias = Detalle_de_coincidencias_aData
                    ,Historial = Detalle_Historico_MPOData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Cierre(Modulo_Atencion_Inicial_CierreModel varModulo_Atencion_Inicial)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModulo_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Modulo_Atencion_Inicial_CierreInfo = new Modulo_Atencion_Inicial_Cierre
                {
                    Clave = varModulo_Atencion_Inicial.Clave
                                            ,Cerrar = varModulo_Atencion_Inicial.Cerrar
                        ,Fecha_de_Cierre = (!String.IsNullOrEmpty(varModulo_Atencion_Inicial.Fecha_de_Cierre)) ? DateTime.ParseExact(varModulo_Atencion_Inicial.Fecha_de_Cierre, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Cierre = varModulo_Atencion_Inicial.Hora_de_Cierre
                    
                };

                result = _IModulo_Atencion_InicialApiConsumer.Update_Cierre(Modulo_Atencion_Inicial_CierreInfo).Resource.ToString();
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
                _IModulo_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IModulo_Atencion_InicialApiConsumer.Get_Cierre(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_de_coincidencias_a;
                var Detalle_de_coincidencias_aData = GetDetalle_de_coincidencias_aData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_coincidencias_a);
                int RowCount_Detalle_Historico_MPO;
                var Detalle_Historico_MPOData = GetDetalle_Historico_MPOData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Historico_MPO);

                var result = new Modulo_Atencion_Inicial_CierreModel
                {
                    Clave = m.Clave
			,Cerrar = m.Cerrar
                        ,Fecha_de_Cierre = (m.Fecha_de_Cierre == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Cierre).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Cierre = m.Hora_de_Cierre

                    
                };
				var resultData = new
                {
                    data = result
                    ,Coincidencias = Detalle_de_coincidencias_aData
                    ,Historial = Detalle_Historico_MPOData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Historial_de_movimientos(Modulo_Atencion_Inicial_Historial_de_movimientosModel varModulo_Atencion_Inicial)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModulo_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Modulo_Atencion_Inicial_Historial_de_movimientosInfo = new Modulo_Atencion_Inicial_Historial_de_movimientos
                {
                    Clave = varModulo_Atencion_Inicial.Clave
                                        
                };

                result = _IModulo_Atencion_InicialApiConsumer.Update_Historial_de_movimientos(Modulo_Atencion_Inicial_Historial_de_movimientosInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Historial_de_movimientos(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModulo_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IModulo_Atencion_InicialApiConsumer.Get_Historial_de_movimientos(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_de_coincidencias_a;
                var Detalle_de_coincidencias_aData = GetDetalle_de_coincidencias_aData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_coincidencias_a);
                int RowCount_Detalle_Historico_MPO;
                var Detalle_Historico_MPOData = GetDetalle_Historico_MPOData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Historico_MPO);

                var result = new Modulo_Atencion_Inicial_Historial_de_movimientosModel
                {
                    Clave = m.Clave

                    
                };
				var resultData = new
                {
                    data = result
                    ,Coincidencias = Detalle_de_coincidencias_aData
                    ,Historial = Detalle_Historico_MPOData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }


    }
}

