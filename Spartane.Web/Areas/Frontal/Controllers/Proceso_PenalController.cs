using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Proceso_Penal;
using Spartane.Core.Domain.expediente_ministerio_publico;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Detalle_de_Imputado;
using Spartane.Core.Domain.A_Tiempo;
using Spartane.Core.Domain.Detalle_Delitos_Proceso_Penal;

using Spartane.Core.Domain.Delito;

using Spartane.Core.Domain.Plazo_Constitucional;
using Spartane.Core.Domain.Vinculacion_a_Proceso;
using Spartane.Core.Domain.Continuacion_de_Proceso;
using Spartane.Core.Domain.Auto_de_Vinculacion_a_Proceso;
using Spartane.Core.Domain.Plazo_de_Investigacion_Complementaria;
using Spartane.Core.Domain.Detalle_Medidas_Cautelares_Proceso_Penal;

using Spartane.Core.Domain.Medidas_Cautelares;

using Spartane.Core.Domain.Detalle_Medios_Prueba_Imputado;





using Spartane.Core.Domain.A_Tiempo;
using Spartane.Core.Domain.Detalle_Medios_Prueba_Victima;





using Spartane.Core.Domain.A_Tiempo;
using Spartane.Core.Domain.Detalle_Medios_Prueba_Admitidos;





using Spartane.Core.Domain.A_Tiempo;
using Spartane.Core.Domain.Resultado_de_Audiencia_Intermedia;
using Spartane.Core.Domain.Tribunal_de_Enjuiciamiento;
using Spartane.Core.Domain.Sentencia;
using Spartane.Core.Domain.Resolucion;
using Spartane.Core.Domain.Detalle_Condiciones_Proceso_Penal;

using Spartane.Core.Domain.Condiciones_en_Suspension_Condicional;

using Spartane.Core.Domain.Sentencia;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Proceso_Penal;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Proceso_Penal;
using Spartane.Web.Areas.WebApiConsumer.expediente_ministerio_publico;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Imputado;
using Spartane.Web.Areas.WebApiConsumer.A_Tiempo;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Delitos_Proceso_Penal;

using Spartane.Web.Areas.WebApiConsumer.Delito;

using Spartane.Web.Areas.WebApiConsumer.Plazo_Constitucional;
using Spartane.Web.Areas.WebApiConsumer.Vinculacion_a_Proceso;
using Spartane.Web.Areas.WebApiConsumer.Continuacion_de_Proceso;
using Spartane.Web.Areas.WebApiConsumer.Auto_de_Vinculacion_a_Proceso;
using Spartane.Web.Areas.WebApiConsumer.Plazo_de_Investigacion_Complementaria;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Medidas_Cautelares_Proceso_Penal;

using Spartane.Web.Areas.WebApiConsumer.Medidas_Cautelares;

using Spartane.Web.Areas.WebApiConsumer.Detalle_Medios_Prueba_Imputado;




using Spartane.Web.Areas.WebApiConsumer.A_Tiempo;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Medios_Prueba_Victima;




using Spartane.Web.Areas.WebApiConsumer.A_Tiempo;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Medios_Prueba_Admitidos;



using Spartane.Web.Areas.WebApiConsumer.A_Tiempo;
using Spartane.Web.Areas.WebApiConsumer.Resultado_de_Audiencia_Intermedia;
using Spartane.Web.Areas.WebApiConsumer.Tribunal_de_Enjuiciamiento;
using Spartane.Web.Areas.WebApiConsumer.Sentencia;
using Spartane.Web.Areas.WebApiConsumer.Resolucion;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Condiciones_Proceso_Penal;

using Spartane.Web.Areas.WebApiConsumer.Condiciones_en_Suspension_Condicional;

using Spartane.Web.Areas.WebApiConsumer.Sentencia;

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
    public class Proceso_PenalController : Controller
    {
        #region "variable declaration"

        private IProceso_PenalService service = null;
        private IProceso_PenalApiConsumer _IProceso_PenalApiConsumer;
        private Iexpediente_ministerio_publicoApiConsumer _Iexpediente_ministerio_publicoApiConsumer;
        private ISpartan_UserApiConsumer _ISpartan_UserApiConsumer;
        private IDetalle_de_ImputadoApiConsumer _IDetalle_de_ImputadoApiConsumer;
        private IA_TiempoApiConsumer _IA_TiempoApiConsumer;
        private IDetalle_Delitos_Proceso_PenalApiConsumer _IDetalle_Delitos_Proceso_PenalApiConsumer;

        private IDelitoApiConsumer _IDelitoApiConsumer;

        private IPlazo_ConstitucionalApiConsumer _IPlazo_ConstitucionalApiConsumer;
        private IVinculacion_a_ProcesoApiConsumer _IVinculacion_a_ProcesoApiConsumer;
        private IContinuacion_de_ProcesoApiConsumer _IContinuacion_de_ProcesoApiConsumer;
        private IAuto_de_Vinculacion_a_ProcesoApiConsumer _IAuto_de_Vinculacion_a_ProcesoApiConsumer;
        private IPlazo_de_Investigacion_ComplementariaApiConsumer _IPlazo_de_Investigacion_ComplementariaApiConsumer;
        private IDetalle_Medidas_Cautelares_Proceso_PenalApiConsumer _IDetalle_Medidas_Cautelares_Proceso_PenalApiConsumer;

        private IMedidas_CautelaresApiConsumer _IMedidas_CautelaresApiConsumer;

        private IDetalle_Medios_Prueba_ImputadoApiConsumer _IDetalle_Medios_Prueba_ImputadoApiConsumer;




        private IDetalle_Medios_Prueba_VictimaApiConsumer _IDetalle_Medios_Prueba_VictimaApiConsumer;




        private IDetalle_Medios_Prueba_AdmitidosApiConsumer _IDetalle_Medios_Prueba_AdmitidosApiConsumer;



        private IResultado_de_Audiencia_IntermediaApiConsumer _IResultado_de_Audiencia_IntermediaApiConsumer;
        private ITribunal_de_EnjuiciamientoApiConsumer _ITribunal_de_EnjuiciamientoApiConsumer;
        private ISentenciaApiConsumer _ISentenciaApiConsumer;
        private IResolucionApiConsumer _IResolucionApiConsumer;
        private IDetalle_Condiciones_Proceso_PenalApiConsumer _IDetalle_Condiciones_Proceso_PenalApiConsumer;

        private ICondiciones_en_Suspension_CondicionalApiConsumer _ICondiciones_en_Suspension_CondicionalApiConsumer;


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

        
        public Proceso_PenalController(IProceso_PenalService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IProceso_PenalApiConsumer Proceso_PenalApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , Iexpediente_ministerio_publicoApiConsumer expediente_ministerio_publicoApiConsumer , ISpartan_UserApiConsumer Spartan_UserApiConsumer , IDetalle_de_ImputadoApiConsumer Detalle_de_ImputadoApiConsumer , IA_TiempoApiConsumer A_TiempoApiConsumer , IDetalle_Delitos_Proceso_PenalApiConsumer Detalle_Delitos_Proceso_PenalApiConsumer , IDelitoApiConsumer DelitoApiConsumer  , IPlazo_ConstitucionalApiConsumer Plazo_ConstitucionalApiConsumer , IVinculacion_a_ProcesoApiConsumer Vinculacion_a_ProcesoApiConsumer , IContinuacion_de_ProcesoApiConsumer Continuacion_de_ProcesoApiConsumer , IAuto_de_Vinculacion_a_ProcesoApiConsumer Auto_de_Vinculacion_a_ProcesoApiConsumer , IPlazo_de_Investigacion_ComplementariaApiConsumer Plazo_de_Investigacion_ComplementariaApiConsumer , IDetalle_Medidas_Cautelares_Proceso_PenalApiConsumer Detalle_Medidas_Cautelares_Proceso_PenalApiConsumer , IMedidas_CautelaresApiConsumer Medidas_CautelaresApiConsumer  , IDetalle_Medios_Prueba_ImputadoApiConsumer Detalle_Medios_Prueba_ImputadoApiConsumer  , IDetalle_Medios_Prueba_VictimaApiConsumer Detalle_Medios_Prueba_VictimaApiConsumer  , IDetalle_Medios_Prueba_AdmitidosApiConsumer Detalle_Medios_Prueba_AdmitidosApiConsumer  , IResultado_de_Audiencia_IntermediaApiConsumer Resultado_de_Audiencia_IntermediaApiConsumer , ITribunal_de_EnjuiciamientoApiConsumer Tribunal_de_EnjuiciamientoApiConsumer , ISentenciaApiConsumer SentenciaApiConsumer , IResolucionApiConsumer ResolucionApiConsumer , IDetalle_Condiciones_Proceso_PenalApiConsumer Detalle_Condiciones_Proceso_PenalApiConsumer , ICondiciones_en_Suspension_CondicionalApiConsumer Condiciones_en_Suspension_CondicionalApiConsumer  )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IProceso_PenalApiConsumer = Proceso_PenalApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_FormatApiConsumer = Spartan_FormatApiConsumer;
            this._ISpartan_Format_PermissionsApiConsumer = Spartan_Format_PermissionsApiConsumer;
            this._IGeneratePDFApiConsumer = GeneratePDFApiConsumer;
			this._ISpartan_FormatRelatedApiConsumer = Spartan_Format_RelatedApiConsumer;
            this._Iexpediente_ministerio_publicoApiConsumer = expediente_ministerio_publicoApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._IDetalle_de_ImputadoApiConsumer = Detalle_de_ImputadoApiConsumer;
            this._IA_TiempoApiConsumer = A_TiempoApiConsumer;
            this._IDetalle_Delitos_Proceso_PenalApiConsumer = Detalle_Delitos_Proceso_PenalApiConsumer;

            this._IDelitoApiConsumer = DelitoApiConsumer;

            this._IPlazo_ConstitucionalApiConsumer = Plazo_ConstitucionalApiConsumer;
            this._IVinculacion_a_ProcesoApiConsumer = Vinculacion_a_ProcesoApiConsumer;
            this._IContinuacion_de_ProcesoApiConsumer = Continuacion_de_ProcesoApiConsumer;
            this._IAuto_de_Vinculacion_a_ProcesoApiConsumer = Auto_de_Vinculacion_a_ProcesoApiConsumer;
            this._IPlazo_de_Investigacion_ComplementariaApiConsumer = Plazo_de_Investigacion_ComplementariaApiConsumer;
            this._IDetalle_Medidas_Cautelares_Proceso_PenalApiConsumer = Detalle_Medidas_Cautelares_Proceso_PenalApiConsumer;

            this._IMedidas_CautelaresApiConsumer = Medidas_CautelaresApiConsumer;

            this._IDetalle_Medios_Prueba_ImputadoApiConsumer = Detalle_Medios_Prueba_ImputadoApiConsumer;




            this._IA_TiempoApiConsumer = A_TiempoApiConsumer;
            this._IDetalle_Medios_Prueba_VictimaApiConsumer = Detalle_Medios_Prueba_VictimaApiConsumer;




            this._IA_TiempoApiConsumer = A_TiempoApiConsumer;
            this._IDetalle_Medios_Prueba_AdmitidosApiConsumer = Detalle_Medios_Prueba_AdmitidosApiConsumer;



            this._IA_TiempoApiConsumer = A_TiempoApiConsumer;
            this._IResultado_de_Audiencia_IntermediaApiConsumer = Resultado_de_Audiencia_IntermediaApiConsumer;
            this._ITribunal_de_EnjuiciamientoApiConsumer = Tribunal_de_EnjuiciamientoApiConsumer;
            this._ISentenciaApiConsumer = SentenciaApiConsumer;
            this._IResolucionApiConsumer = ResolucionApiConsumer;
            this._IDetalle_Condiciones_Proceso_PenalApiConsumer = Detalle_Condiciones_Proceso_PenalApiConsumer;

            this._ICondiciones_en_Suspension_CondicionalApiConsumer = Condiciones_en_Suspension_CondicionalApiConsumer;

            this._ISentenciaApiConsumer = SentenciaApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Proceso_Penal
        [ObjectAuth(ObjectId = (ModuleObjectId)45558, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45558, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Proceso_Penal/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45558, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45558, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varProceso_Penal = new Proceso_PenalModel();
			varProceso_Penal.Folio = Id;
			
            ViewBag.ObjectId = "45558";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;

            var permissionDetalle_Delitos_Proceso_Penal = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45559, ModuleId);
            ViewBag.PermissionDetalle_Delitos_Proceso_Penal = permissionDetalle_Delitos_Proceso_Penal;
            var permissionDetalle_Medidas_Cautelares_Proceso_Penal = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45561, ModuleId);
            ViewBag.PermissionDetalle_Medidas_Cautelares_Proceso_Penal = permissionDetalle_Medidas_Cautelares_Proceso_Penal;
            var permissionDetalle_Medios_Prueba_Imputado = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45560, ModuleId);
            ViewBag.PermissionDetalle_Medios_Prueba_Imputado = permissionDetalle_Medios_Prueba_Imputado;
            var permissionDetalle_Medios_Prueba_Victima = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45557, ModuleId);
            ViewBag.PermissionDetalle_Medios_Prueba_Victima = permissionDetalle_Medios_Prueba_Victima;
            var permissionDetalle_Medios_Prueba_Admitidos = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45563, ModuleId);
            ViewBag.PermissionDetalle_Medios_Prueba_Admitidos = permissionDetalle_Medios_Prueba_Admitidos;
            var permissionDetalle_Condiciones_Proceso_Penal = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45564, ModuleId);
            ViewBag.PermissionDetalle_Condiciones_Proceso_Penal = permissionDetalle_Condiciones_Proceso_Penal;


            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IProceso_PenalApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Proceso_PenalsData = _IProceso_PenalApiConsumer.ListaSelAll(0, 1000, "Proceso_Penal.Folio=" + Id, "").Resource.Proceso_Penals;
				
				if (Proceso_PenalsData != null && Proceso_PenalsData.Count > 0)
                {
					var Proceso_PenalData = Proceso_PenalsData.First();
					varProceso_Penal= new Proceso_PenalModel
					{
						Folio  = Proceso_PenalData.Folio 
	                    ,Expediente_MP = Proceso_PenalData.Expediente_MP
                    ,Expediente_MPnic = CultureHelper.GetTraduction(Convert.ToString(Proceso_PenalData.Expediente_MP), "expediente_ministerio_publico") ??  (string)Proceso_PenalData.Expediente_MP_expediente_ministerio_publico.nic
                    ,Fecha_de_Registro = (Proceso_PenalData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(Proceso_PenalData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Registro = Proceso_PenalData.Hora_de_Registro
                    ,Usuario_que_Registra = Proceso_PenalData.Usuario_que_Registra
                    ,Usuario_que_RegistraName = CultureHelper.GetTraduction(Convert.ToString(Proceso_PenalData.Usuario_que_Registra), "Spartan_User") ??  (string)Proceso_PenalData.Usuario_que_Registra_Spartan_User.Name
                    ,Imputado = Proceso_PenalData.Imputado
                    ,ImputadoNombre_Completo_Detenido = CultureHelper.GetTraduction(Convert.ToString(Proceso_PenalData.Imputado), "Detalle_de_Imputado") ??  (string)Proceso_PenalData.Imputado_Detalle_de_Imputado.Nombre_Completo_Detenido
                    ,Reclasificacion_Juridica = Proceso_PenalData.Reclasificacion_Juridica
                    ,Reclasificacion_JuridicaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Proceso_PenalData.Reclasificacion_Juridica), "A_Tiempo") ??  (string)Proceso_PenalData.Reclasificacion_Juridica_A_Tiempo.Descripcion
                    ,Plazo_Constitucional = Proceso_PenalData.Plazo_Constitucional
                    ,Plazo_ConstitucionalDescripcion = CultureHelper.GetTraduction(Convert.ToString(Proceso_PenalData.Plazo_Constitucional), "Plazo_Constitucional") ??  (string)Proceso_PenalData.Plazo_Constitucional_Plazo_Constitucional.Descripcion
                    ,Vinculacion = Proceso_PenalData.Vinculacion
                    ,VinculacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Proceso_PenalData.Vinculacion), "Vinculacion_a_Proceso") ??  (string)Proceso_PenalData.Vinculacion_Vinculacion_a_Proceso.Descripcion
                    ,Resultado_No_Vinculacion = Proceso_PenalData.Resultado_No_Vinculacion
                    ,Resultado_No_VinculacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Proceso_PenalData.Resultado_No_Vinculacion), "Continuacion_de_Proceso") ??  (string)Proceso_PenalData.Resultado_No_Vinculacion_Continuacion_de_Proceso.Descripcion
                    ,Resultado_Vinculacion = Proceso_PenalData.Resultado_Vinculacion
                    ,Resultado_VinculacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Proceso_PenalData.Resultado_Vinculacion), "Auto_de_Vinculacion_a_Proceso") ??  (string)Proceso_PenalData.Resultado_Vinculacion_Auto_de_Vinculacion_a_Proceso.Descripcion
                    ,plazo_investigacion_complementaria = Proceso_PenalData.plazo_investigacion_complementaria
                    ,plazo_investigacion_complementariaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Proceso_PenalData.plazo_investigacion_complementaria), "Plazo_de_Investigacion_Complementaria") ??  (string)Proceso_PenalData.plazo_investigacion_complementaria_Plazo_de_Investigacion_Complementaria.Descripcion
                    ,fecha_investigacion_complementaria = Proceso_PenalData.fecha_investigacion_complementaria
                    ,hora_investigacion_complementaria = Proceso_PenalData.hora_investigacion_complementaria
                    ,Nombre_del_Juez_de_Control = Proceso_PenalData.Nombre_del_Juez_de_Control
                    ,Fecha_de_Entrega_de_Escrito_de_Acusacion = (Proceso_PenalData.Fecha_de_Entrega_de_Escrito_de_Acusacion == null ? string.Empty : Convert.ToDateTime(Proceso_PenalData.Fecha_de_Entrega_de_Escrito_de_Acusacion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Entrega_de_Escrito_de_Acusacion = Proceso_PenalData.Hora_de_Entrega_de_Escrito_de_Acusacion
                    ,Fecha_de_Audiencia_Intermedia = (Proceso_PenalData.Fecha_de_Audiencia_Intermedia == null ? string.Empty : Convert.ToDateTime(Proceso_PenalData.Fecha_de_Audiencia_Intermedia).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Audiencia_Intermedia = Proceso_PenalData.Hora_de_Audiencia_Intermedia
                    ,Acusador_Coadyudante = Proceso_PenalData.Acusador_Coadyudante
                    ,Acusador_CoadyudanteDescripcion = CultureHelper.GetTraduction(Convert.ToString(Proceso_PenalData.Acusador_Coadyudante), "A_Tiempo") ??  (string)Proceso_PenalData.Acusador_Coadyudante_A_Tiempo.Descripcion
                    ,cumplio_descubrimiento_probatorio = Proceso_PenalData.cumplio_descubrimiento_probatorio
                    ,cumplio_descubrimiento_probatorioDescripcion = CultureHelper.GetTraduction(Convert.ToString(Proceso_PenalData.cumplio_descubrimiento_probatorio), "A_Tiempo") ??  (string)Proceso_PenalData.cumplio_descubrimiento_probatorio_A_Tiempo.Descripcion
                    ,Fecha = (Proceso_PenalData.Fecha == null ? string.Empty : Convert.ToDateTime(Proceso_PenalData.Fecha).ToString(ConfigurationProperty.DateFormat))
                    ,Hora = Proceso_PenalData.Hora
                    ,Acuerdos_Probatorios = Proceso_PenalData.Acuerdos_Probatorios
                    ,Acuerdos_ProbatoriosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Proceso_PenalData.Acuerdos_Probatorios), "A_Tiempo") ??  (string)Proceso_PenalData.Acuerdos_Probatorios_A_Tiempo.Descripcion
                    ,acuerdos_probatorios_cuales_fueron = Proceso_PenalData.acuerdos_probatorios_cuales_fueron
                    ,Resultado = Proceso_PenalData.Resultado
                    ,ResultadoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Proceso_PenalData.Resultado), "Resultado_de_Audiencia_Intermedia") ??  (string)Proceso_PenalData.Resultado_Resultado_de_Audiencia_Intermedia.Descripcion
                    ,Tribunal_de_Enjuiciamiento = Proceso_PenalData.Tribunal_de_Enjuiciamiento
                    ,Tribunal_de_EnjuiciamientoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Proceso_PenalData.Tribunal_de_Enjuiciamiento), "Tribunal_de_Enjuiciamiento") ??  (string)Proceso_PenalData.Tribunal_de_Enjuiciamiento_Tribunal_de_Enjuiciamiento.Descripcion
                    ,Nombre_del_Juez = Proceso_PenalData.Nombre_del_Juez
                    ,Juez_Colegiado = Proceso_PenalData.Juez_Colegiado
                    ,Juez_Relator = Proceso_PenalData.Juez_Relator
                    ,Juez_Vocal = Proceso_PenalData.Juez_Vocal
                    ,Fecha_de_Audiencia_de_Juicio = (Proceso_PenalData.Fecha_de_Audiencia_de_Juicio == null ? string.Empty : Convert.ToDateTime(Proceso_PenalData.Fecha_de_Audiencia_de_Juicio).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Audiencia_de_Juicio = Proceso_PenalData.Hora_de_Audiencia_de_Juicio
                    ,Fallo_del_Tribunal = Proceso_PenalData.Fallo_del_Tribunal
                    ,Fallo_del_TribunalDescripcion = CultureHelper.GetTraduction(Convert.ToString(Proceso_PenalData.Fallo_del_Tribunal), "Sentencia") ??  (string)Proceso_PenalData.Fallo_del_Tribunal_Sentencia.Descripcion
                    ,pruebas_a_desahogar = Proceso_PenalData.pruebas_a_desahogar
                    ,Resolucion = Proceso_PenalData.Resolucion
                    ,ResolucionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Proceso_PenalData.Resolucion), "Resolucion") ??  (string)Proceso_PenalData.Resolucion_Resolucion.Descripcion
                    ,Plazo_meses = Proceso_PenalData.Plazo_meses
                    ,Tipo_de_Sentencia = Proceso_PenalData.Tipo_de_Sentencia
                    ,Tipo_de_SentenciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Proceso_PenalData.Tipo_de_Sentencia), "Sentencia") ??  (string)Proceso_PenalData.Tipo_de_Sentencia_Sentencia.Descripcion
                    ,cuantia_de_pena_anios = Proceso_PenalData.cuantia_de_pena_anios
                    ,cuantia_de_pena_meses = Proceso_PenalData.cuantia_de_pena_meses
                    ,Monto_de_la_Reparacion_del_Dano = Proceso_PenalData.Monto_de_la_Reparacion_del_Dano

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Usuario_que_Registra = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Usuario_que_Registra != null && Spartan_Users_Usuario_que_Registra.Resource != null)
                ViewBag.Spartan_Users_Usuario_que_Registra = Spartan_Users_Usuario_que_Registra.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_Reclasificacion_Juridica = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_Reclasificacion_Juridica != null && A_Tiempos_Reclasificacion_Juridica.Resource != null)
                ViewBag.A_Tiempos_Reclasificacion_Juridica = A_Tiempos_Reclasificacion_Juridica.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPlazo_ConstitucionalApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Plazo_Constitucionals_Plazo_Constitucional = _IPlazo_ConstitucionalApiConsumer.SelAll(true);
            if (Plazo_Constitucionals_Plazo_Constitucional != null && Plazo_Constitucionals_Plazo_Constitucional.Resource != null)
                ViewBag.Plazo_Constitucionals_Plazo_Constitucional = Plazo_Constitucionals_Plazo_Constitucional.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Plazo_Constitucional", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IVinculacion_a_ProcesoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Vinculacion_a_Procesos_Vinculacion = _IVinculacion_a_ProcesoApiConsumer.SelAll(true);
            if (Vinculacion_a_Procesos_Vinculacion != null && Vinculacion_a_Procesos_Vinculacion.Resource != null)
                ViewBag.Vinculacion_a_Procesos_Vinculacion = Vinculacion_a_Procesos_Vinculacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Vinculacion_a_Proceso", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IContinuacion_de_ProcesoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Continuacion_de_Procesos_Resultado_No_Vinculacion = _IContinuacion_de_ProcesoApiConsumer.SelAll(true);
            if (Continuacion_de_Procesos_Resultado_No_Vinculacion != null && Continuacion_de_Procesos_Resultado_No_Vinculacion.Resource != null)
                ViewBag.Continuacion_de_Procesos_Resultado_No_Vinculacion = Continuacion_de_Procesos_Resultado_No_Vinculacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Continuacion_de_Proceso", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAuto_de_Vinculacion_a_ProcesoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Auto_de_Vinculacion_a_Procesos_Resultado_Vinculacion = _IAuto_de_Vinculacion_a_ProcesoApiConsumer.SelAll(true);
            if (Auto_de_Vinculacion_a_Procesos_Resultado_Vinculacion != null && Auto_de_Vinculacion_a_Procesos_Resultado_Vinculacion.Resource != null)
                ViewBag.Auto_de_Vinculacion_a_Procesos_Resultado_Vinculacion = Auto_de_Vinculacion_a_Procesos_Resultado_Vinculacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Auto_de_Vinculacion_a_Proceso", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPlazo_de_Investigacion_ComplementariaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Plazo_de_Investigacion_Complementarias_plazo_investigacion_complementaria = _IPlazo_de_Investigacion_ComplementariaApiConsumer.SelAll(true);
            if (Plazo_de_Investigacion_Complementarias_plazo_investigacion_complementaria != null && Plazo_de_Investigacion_Complementarias_plazo_investigacion_complementaria.Resource != null)
                ViewBag.Plazo_de_Investigacion_Complementarias_plazo_investigacion_complementaria = Plazo_de_Investigacion_Complementarias_plazo_investigacion_complementaria.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Plazo_de_Investigacion_Complementaria", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_Acusador_Coadyudante = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_Acusador_Coadyudante != null && A_Tiempos_Acusador_Coadyudante.Resource != null)
                ViewBag.A_Tiempos_Acusador_Coadyudante = A_Tiempos_Acusador_Coadyudante.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_cumplio_descubrimiento_probatorio = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_cumplio_descubrimiento_probatorio != null && A_Tiempos_cumplio_descubrimiento_probatorio.Resource != null)
                ViewBag.A_Tiempos_cumplio_descubrimiento_probatorio = A_Tiempos_cumplio_descubrimiento_probatorio.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_Acuerdos_Probatorios = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_Acuerdos_Probatorios != null && A_Tiempos_Acuerdos_Probatorios.Resource != null)
                ViewBag.A_Tiempos_Acuerdos_Probatorios = A_Tiempos_Acuerdos_Probatorios.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResultado_de_Audiencia_IntermediaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resultado_de_Audiencia_Intermedias_Resultado = _IResultado_de_Audiencia_IntermediaApiConsumer.SelAll(true);
            if (Resultado_de_Audiencia_Intermedias_Resultado != null && Resultado_de_Audiencia_Intermedias_Resultado.Resource != null)
                ViewBag.Resultado_de_Audiencia_Intermedias_Resultado = Resultado_de_Audiencia_Intermedias_Resultado.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resultado_de_Audiencia_Intermedia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITribunal_de_EnjuiciamientoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tribunal_de_Enjuiciamientos_Tribunal_de_Enjuiciamiento = _ITribunal_de_EnjuiciamientoApiConsumer.SelAll(true);
            if (Tribunal_de_Enjuiciamientos_Tribunal_de_Enjuiciamiento != null && Tribunal_de_Enjuiciamientos_Tribunal_de_Enjuiciamiento.Resource != null)
                ViewBag.Tribunal_de_Enjuiciamientos_Tribunal_de_Enjuiciamiento = Tribunal_de_Enjuiciamientos_Tribunal_de_Enjuiciamiento.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tribunal_de_Enjuiciamiento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISentenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Sentencias_Fallo_del_Tribunal = _ISentenciaApiConsumer.SelAll(true);
            if (Sentencias_Fallo_del_Tribunal != null && Sentencias_Fallo_del_Tribunal.Resource != null)
                ViewBag.Sentencias_Fallo_del_Tribunal = Sentencias_Fallo_del_Tribunal.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Sentencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resolucions_Resolucion = _IResolucionApiConsumer.SelAll(true);
            if (Resolucions_Resolucion != null && Resolucions_Resolucion.Resource != null)
                ViewBag.Resolucions_Resolucion = Resolucions_Resolucion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resolucion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISentenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Sentencias_Tipo_de_Sentencia = _ISentenciaApiConsumer.SelAll(true);
            if (Sentencias_Tipo_de_Sentencia != null && Sentencias_Tipo_de_Sentencia.Resource != null)
                ViewBag.Sentencias_Tipo_de_Sentencia = Sentencias_Tipo_de_Sentencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Sentencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varProceso_Penal);
        }
		
	[HttpGet]
        public ActionResult AddProceso_Penal(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45558);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IProceso_PenalApiConsumer.SetAuthHeader(_tokenManager.Token);
			Proceso_PenalModel varProceso_Penal= new Proceso_PenalModel();
            var permissionDetalle_Delitos_Proceso_Penal = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45559, ModuleId);
            ViewBag.PermissionDetalle_Delitos_Proceso_Penal = permissionDetalle_Delitos_Proceso_Penal;
            var permissionDetalle_Medidas_Cautelares_Proceso_Penal = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45561, ModuleId);
            ViewBag.PermissionDetalle_Medidas_Cautelares_Proceso_Penal = permissionDetalle_Medidas_Cautelares_Proceso_Penal;
            var permissionDetalle_Medios_Prueba_Imputado = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45560, ModuleId);
            ViewBag.PermissionDetalle_Medios_Prueba_Imputado = permissionDetalle_Medios_Prueba_Imputado;
            var permissionDetalle_Medios_Prueba_Victima = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45557, ModuleId);
            ViewBag.PermissionDetalle_Medios_Prueba_Victima = permissionDetalle_Medios_Prueba_Victima;
            var permissionDetalle_Medios_Prueba_Admitidos = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45563, ModuleId);
            ViewBag.PermissionDetalle_Medios_Prueba_Admitidos = permissionDetalle_Medios_Prueba_Admitidos;
            var permissionDetalle_Condiciones_Proceso_Penal = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45564, ModuleId);
            ViewBag.PermissionDetalle_Condiciones_Proceso_Penal = permissionDetalle_Condiciones_Proceso_Penal;


            if (id.ToString() != "0")
            {
                var Proceso_PenalsData = _IProceso_PenalApiConsumer.ListaSelAll(0, 1000, "Proceso_Penal.Folio=" + id, "").Resource.Proceso_Penals;
				
				if (Proceso_PenalsData != null && Proceso_PenalsData.Count > 0)
                {
					var Proceso_PenalData = Proceso_PenalsData.First();
					varProceso_Penal= new Proceso_PenalModel
					{
						Folio  = Proceso_PenalData.Folio 
	                    ,Expediente_MP = Proceso_PenalData.Expediente_MP
                    ,Expediente_MPnic = CultureHelper.GetTraduction(Convert.ToString(Proceso_PenalData.Expediente_MP), "expediente_ministerio_publico") ??  (string)Proceso_PenalData.Expediente_MP_expediente_ministerio_publico.nic
                    ,Fecha_de_Registro = (Proceso_PenalData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(Proceso_PenalData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Registro = Proceso_PenalData.Hora_de_Registro
                    ,Usuario_que_Registra = Proceso_PenalData.Usuario_que_Registra
                    ,Usuario_que_RegistraName = CultureHelper.GetTraduction(Convert.ToString(Proceso_PenalData.Usuario_que_Registra), "Spartan_User") ??  (string)Proceso_PenalData.Usuario_que_Registra_Spartan_User.Name
                    ,Imputado = Proceso_PenalData.Imputado
                    ,ImputadoNombre_Completo_Detenido = CultureHelper.GetTraduction(Convert.ToString(Proceso_PenalData.Imputado), "Detalle_de_Imputado") ??  (string)Proceso_PenalData.Imputado_Detalle_de_Imputado.Nombre_Completo_Detenido
                    ,Reclasificacion_Juridica = Proceso_PenalData.Reclasificacion_Juridica
                    ,Reclasificacion_JuridicaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Proceso_PenalData.Reclasificacion_Juridica), "A_Tiempo") ??  (string)Proceso_PenalData.Reclasificacion_Juridica_A_Tiempo.Descripcion
                    ,Plazo_Constitucional = Proceso_PenalData.Plazo_Constitucional
                    ,Plazo_ConstitucionalDescripcion = CultureHelper.GetTraduction(Convert.ToString(Proceso_PenalData.Plazo_Constitucional), "Plazo_Constitucional") ??  (string)Proceso_PenalData.Plazo_Constitucional_Plazo_Constitucional.Descripcion
                    ,Vinculacion = Proceso_PenalData.Vinculacion
                    ,VinculacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Proceso_PenalData.Vinculacion), "Vinculacion_a_Proceso") ??  (string)Proceso_PenalData.Vinculacion_Vinculacion_a_Proceso.Descripcion
                    ,Resultado_No_Vinculacion = Proceso_PenalData.Resultado_No_Vinculacion
                    ,Resultado_No_VinculacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Proceso_PenalData.Resultado_No_Vinculacion), "Continuacion_de_Proceso") ??  (string)Proceso_PenalData.Resultado_No_Vinculacion_Continuacion_de_Proceso.Descripcion
                    ,Resultado_Vinculacion = Proceso_PenalData.Resultado_Vinculacion
                    ,Resultado_VinculacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Proceso_PenalData.Resultado_Vinculacion), "Auto_de_Vinculacion_a_Proceso") ??  (string)Proceso_PenalData.Resultado_Vinculacion_Auto_de_Vinculacion_a_Proceso.Descripcion
                    ,plazo_investigacion_complementaria = Proceso_PenalData.plazo_investigacion_complementaria
                    ,plazo_investigacion_complementariaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Proceso_PenalData.plazo_investigacion_complementaria), "Plazo_de_Investigacion_Complementaria") ??  (string)Proceso_PenalData.plazo_investigacion_complementaria_Plazo_de_Investigacion_Complementaria.Descripcion
                    ,fecha_investigacion_complementaria = Proceso_PenalData.fecha_investigacion_complementaria
                    ,hora_investigacion_complementaria = Proceso_PenalData.hora_investigacion_complementaria
                    ,Nombre_del_Juez_de_Control = Proceso_PenalData.Nombre_del_Juez_de_Control
                    ,Fecha_de_Entrega_de_Escrito_de_Acusacion = (Proceso_PenalData.Fecha_de_Entrega_de_Escrito_de_Acusacion == null ? string.Empty : Convert.ToDateTime(Proceso_PenalData.Fecha_de_Entrega_de_Escrito_de_Acusacion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Entrega_de_Escrito_de_Acusacion = Proceso_PenalData.Hora_de_Entrega_de_Escrito_de_Acusacion
                    ,Fecha_de_Audiencia_Intermedia = (Proceso_PenalData.Fecha_de_Audiencia_Intermedia == null ? string.Empty : Convert.ToDateTime(Proceso_PenalData.Fecha_de_Audiencia_Intermedia).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Audiencia_Intermedia = Proceso_PenalData.Hora_de_Audiencia_Intermedia
                    ,Acusador_Coadyudante = Proceso_PenalData.Acusador_Coadyudante
                    ,Acusador_CoadyudanteDescripcion = CultureHelper.GetTraduction(Convert.ToString(Proceso_PenalData.Acusador_Coadyudante), "A_Tiempo") ??  (string)Proceso_PenalData.Acusador_Coadyudante_A_Tiempo.Descripcion
                    ,cumplio_descubrimiento_probatorio = Proceso_PenalData.cumplio_descubrimiento_probatorio
                    ,cumplio_descubrimiento_probatorioDescripcion = CultureHelper.GetTraduction(Convert.ToString(Proceso_PenalData.cumplio_descubrimiento_probatorio), "A_Tiempo") ??  (string)Proceso_PenalData.cumplio_descubrimiento_probatorio_A_Tiempo.Descripcion
                    ,Fecha = (Proceso_PenalData.Fecha == null ? string.Empty : Convert.ToDateTime(Proceso_PenalData.Fecha).ToString(ConfigurationProperty.DateFormat))
                    ,Hora = Proceso_PenalData.Hora
                    ,Acuerdos_Probatorios = Proceso_PenalData.Acuerdos_Probatorios
                    ,Acuerdos_ProbatoriosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Proceso_PenalData.Acuerdos_Probatorios), "A_Tiempo") ??  (string)Proceso_PenalData.Acuerdos_Probatorios_A_Tiempo.Descripcion
                    ,acuerdos_probatorios_cuales_fueron = Proceso_PenalData.acuerdos_probatorios_cuales_fueron
                    ,Resultado = Proceso_PenalData.Resultado
                    ,ResultadoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Proceso_PenalData.Resultado), "Resultado_de_Audiencia_Intermedia") ??  (string)Proceso_PenalData.Resultado_Resultado_de_Audiencia_Intermedia.Descripcion
                    ,Tribunal_de_Enjuiciamiento = Proceso_PenalData.Tribunal_de_Enjuiciamiento
                    ,Tribunal_de_EnjuiciamientoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Proceso_PenalData.Tribunal_de_Enjuiciamiento), "Tribunal_de_Enjuiciamiento") ??  (string)Proceso_PenalData.Tribunal_de_Enjuiciamiento_Tribunal_de_Enjuiciamiento.Descripcion
                    ,Nombre_del_Juez = Proceso_PenalData.Nombre_del_Juez
                    ,Juez_Colegiado = Proceso_PenalData.Juez_Colegiado
                    ,Juez_Relator = Proceso_PenalData.Juez_Relator
                    ,Juez_Vocal = Proceso_PenalData.Juez_Vocal
                    ,Fecha_de_Audiencia_de_Juicio = (Proceso_PenalData.Fecha_de_Audiencia_de_Juicio == null ? string.Empty : Convert.ToDateTime(Proceso_PenalData.Fecha_de_Audiencia_de_Juicio).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Audiencia_de_Juicio = Proceso_PenalData.Hora_de_Audiencia_de_Juicio
                    ,Fallo_del_Tribunal = Proceso_PenalData.Fallo_del_Tribunal
                    ,Fallo_del_TribunalDescripcion = CultureHelper.GetTraduction(Convert.ToString(Proceso_PenalData.Fallo_del_Tribunal), "Sentencia") ??  (string)Proceso_PenalData.Fallo_del_Tribunal_Sentencia.Descripcion
                    ,pruebas_a_desahogar = Proceso_PenalData.pruebas_a_desahogar
                    ,Resolucion = Proceso_PenalData.Resolucion
                    ,ResolucionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Proceso_PenalData.Resolucion), "Resolucion") ??  (string)Proceso_PenalData.Resolucion_Resolucion.Descripcion
                    ,Plazo_meses = Proceso_PenalData.Plazo_meses
                    ,Tipo_de_Sentencia = Proceso_PenalData.Tipo_de_Sentencia
                    ,Tipo_de_SentenciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Proceso_PenalData.Tipo_de_Sentencia), "Sentencia") ??  (string)Proceso_PenalData.Tipo_de_Sentencia_Sentencia.Descripcion
                    ,cuantia_de_pena_anios = Proceso_PenalData.cuantia_de_pena_anios
                    ,cuantia_de_pena_meses = Proceso_PenalData.cuantia_de_pena_meses
                    ,Monto_de_la_Reparacion_del_Dano = Proceso_PenalData.Monto_de_la_Reparacion_del_Dano

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Usuario_que_Registra = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Usuario_que_Registra != null && Spartan_Users_Usuario_que_Registra.Resource != null)
                ViewBag.Spartan_Users_Usuario_que_Registra = Spartan_Users_Usuario_que_Registra.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_Reclasificacion_Juridica = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_Reclasificacion_Juridica != null && A_Tiempos_Reclasificacion_Juridica.Resource != null)
                ViewBag.A_Tiempos_Reclasificacion_Juridica = A_Tiempos_Reclasificacion_Juridica.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPlazo_ConstitucionalApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Plazo_Constitucionals_Plazo_Constitucional = _IPlazo_ConstitucionalApiConsumer.SelAll(true);
            if (Plazo_Constitucionals_Plazo_Constitucional != null && Plazo_Constitucionals_Plazo_Constitucional.Resource != null)
                ViewBag.Plazo_Constitucionals_Plazo_Constitucional = Plazo_Constitucionals_Plazo_Constitucional.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Plazo_Constitucional", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IVinculacion_a_ProcesoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Vinculacion_a_Procesos_Vinculacion = _IVinculacion_a_ProcesoApiConsumer.SelAll(true);
            if (Vinculacion_a_Procesos_Vinculacion != null && Vinculacion_a_Procesos_Vinculacion.Resource != null)
                ViewBag.Vinculacion_a_Procesos_Vinculacion = Vinculacion_a_Procesos_Vinculacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Vinculacion_a_Proceso", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IContinuacion_de_ProcesoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Continuacion_de_Procesos_Resultado_No_Vinculacion = _IContinuacion_de_ProcesoApiConsumer.SelAll(true);
            if (Continuacion_de_Procesos_Resultado_No_Vinculacion != null && Continuacion_de_Procesos_Resultado_No_Vinculacion.Resource != null)
                ViewBag.Continuacion_de_Procesos_Resultado_No_Vinculacion = Continuacion_de_Procesos_Resultado_No_Vinculacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Continuacion_de_Proceso", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAuto_de_Vinculacion_a_ProcesoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Auto_de_Vinculacion_a_Procesos_Resultado_Vinculacion = _IAuto_de_Vinculacion_a_ProcesoApiConsumer.SelAll(true);
            if (Auto_de_Vinculacion_a_Procesos_Resultado_Vinculacion != null && Auto_de_Vinculacion_a_Procesos_Resultado_Vinculacion.Resource != null)
                ViewBag.Auto_de_Vinculacion_a_Procesos_Resultado_Vinculacion = Auto_de_Vinculacion_a_Procesos_Resultado_Vinculacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Auto_de_Vinculacion_a_Proceso", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPlazo_de_Investigacion_ComplementariaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Plazo_de_Investigacion_Complementarias_plazo_investigacion_complementaria = _IPlazo_de_Investigacion_ComplementariaApiConsumer.SelAll(true);
            if (Plazo_de_Investigacion_Complementarias_plazo_investigacion_complementaria != null && Plazo_de_Investigacion_Complementarias_plazo_investigacion_complementaria.Resource != null)
                ViewBag.Plazo_de_Investigacion_Complementarias_plazo_investigacion_complementaria = Plazo_de_Investigacion_Complementarias_plazo_investigacion_complementaria.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Plazo_de_Investigacion_Complementaria", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_Acusador_Coadyudante = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_Acusador_Coadyudante != null && A_Tiempos_Acusador_Coadyudante.Resource != null)
                ViewBag.A_Tiempos_Acusador_Coadyudante = A_Tiempos_Acusador_Coadyudante.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_cumplio_descubrimiento_probatorio = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_cumplio_descubrimiento_probatorio != null && A_Tiempos_cumplio_descubrimiento_probatorio.Resource != null)
                ViewBag.A_Tiempos_cumplio_descubrimiento_probatorio = A_Tiempos_cumplio_descubrimiento_probatorio.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_Acuerdos_Probatorios = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_Acuerdos_Probatorios != null && A_Tiempos_Acuerdos_Probatorios.Resource != null)
                ViewBag.A_Tiempos_Acuerdos_Probatorios = A_Tiempos_Acuerdos_Probatorios.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResultado_de_Audiencia_IntermediaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resultado_de_Audiencia_Intermedias_Resultado = _IResultado_de_Audiencia_IntermediaApiConsumer.SelAll(true);
            if (Resultado_de_Audiencia_Intermedias_Resultado != null && Resultado_de_Audiencia_Intermedias_Resultado.Resource != null)
                ViewBag.Resultado_de_Audiencia_Intermedias_Resultado = Resultado_de_Audiencia_Intermedias_Resultado.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resultado_de_Audiencia_Intermedia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITribunal_de_EnjuiciamientoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tribunal_de_Enjuiciamientos_Tribunal_de_Enjuiciamiento = _ITribunal_de_EnjuiciamientoApiConsumer.SelAll(true);
            if (Tribunal_de_Enjuiciamientos_Tribunal_de_Enjuiciamiento != null && Tribunal_de_Enjuiciamientos_Tribunal_de_Enjuiciamiento.Resource != null)
                ViewBag.Tribunal_de_Enjuiciamientos_Tribunal_de_Enjuiciamiento = Tribunal_de_Enjuiciamientos_Tribunal_de_Enjuiciamiento.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tribunal_de_Enjuiciamiento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISentenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Sentencias_Fallo_del_Tribunal = _ISentenciaApiConsumer.SelAll(true);
            if (Sentencias_Fallo_del_Tribunal != null && Sentencias_Fallo_del_Tribunal.Resource != null)
                ViewBag.Sentencias_Fallo_del_Tribunal = Sentencias_Fallo_del_Tribunal.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Sentencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resolucions_Resolucion = _IResolucionApiConsumer.SelAll(true);
            if (Resolucions_Resolucion != null && Resolucions_Resolucion.Resource != null)
                ViewBag.Resolucions_Resolucion = Resolucions_Resolucion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resolucion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISentenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Sentencias_Tipo_de_Sentencia = _ISentenciaApiConsumer.SelAll(true);
            if (Sentencias_Tipo_de_Sentencia != null && Sentencias_Tipo_de_Sentencia.Resource != null)
                ViewBag.Sentencias_Tipo_de_Sentencia = Sentencias_Tipo_de_Sentencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Sentencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddProceso_Penal", varProceso_Penal);
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
        public ActionResult GetDetalle_de_ImputadoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_ImputadoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_ImputadoApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Nombre_Completo_Detenido).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_Imputado", "Nombre_Completo_Detenido")?? m.Nombre_Completo_Detenido,
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
        public ActionResult GetPlazo_ConstitucionalAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IPlazo_ConstitucionalApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IPlazo_ConstitucionalApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Plazo_Constitucional", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetVinculacion_a_ProcesoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IVinculacion_a_ProcesoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IVinculacion_a_ProcesoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Vinculacion_a_Proceso", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetContinuacion_de_ProcesoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IContinuacion_de_ProcesoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IContinuacion_de_ProcesoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Continuacion_de_Proceso", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetAuto_de_Vinculacion_a_ProcesoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IAuto_de_Vinculacion_a_ProcesoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IAuto_de_Vinculacion_a_ProcesoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Auto_de_Vinculacion_a_Proceso", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetPlazo_de_Investigacion_ComplementariaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IPlazo_de_Investigacion_ComplementariaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IPlazo_de_Investigacion_ComplementariaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Plazo_de_Investigacion_Complementaria", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetResultado_de_Audiencia_IntermediaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IResultado_de_Audiencia_IntermediaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IResultado_de_Audiencia_IntermediaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resultado_de_Audiencia_Intermedia", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetTribunal_de_EnjuiciamientoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITribunal_de_EnjuiciamientoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITribunal_de_EnjuiciamientoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tribunal_de_Enjuiciamiento", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetSentenciaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISentenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISentenciaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Sentencia", "Descripcion")?? m.Descripcion,
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
        public ActionResult ShowAdvanceFilter(Proceso_PenalAdvanceSearchModel model, int idFilter = -1)
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

            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Usuario_que_Registra = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Usuario_que_Registra != null && Spartan_Users_Usuario_que_Registra.Resource != null)
                ViewBag.Spartan_Users_Usuario_que_Registra = Spartan_Users_Usuario_que_Registra.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_Reclasificacion_Juridica = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_Reclasificacion_Juridica != null && A_Tiempos_Reclasificacion_Juridica.Resource != null)
                ViewBag.A_Tiempos_Reclasificacion_Juridica = A_Tiempos_Reclasificacion_Juridica.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPlazo_ConstitucionalApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Plazo_Constitucionals_Plazo_Constitucional = _IPlazo_ConstitucionalApiConsumer.SelAll(true);
            if (Plazo_Constitucionals_Plazo_Constitucional != null && Plazo_Constitucionals_Plazo_Constitucional.Resource != null)
                ViewBag.Plazo_Constitucionals_Plazo_Constitucional = Plazo_Constitucionals_Plazo_Constitucional.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Plazo_Constitucional", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IVinculacion_a_ProcesoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Vinculacion_a_Procesos_Vinculacion = _IVinculacion_a_ProcesoApiConsumer.SelAll(true);
            if (Vinculacion_a_Procesos_Vinculacion != null && Vinculacion_a_Procesos_Vinculacion.Resource != null)
                ViewBag.Vinculacion_a_Procesos_Vinculacion = Vinculacion_a_Procesos_Vinculacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Vinculacion_a_Proceso", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IContinuacion_de_ProcesoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Continuacion_de_Procesos_Resultado_No_Vinculacion = _IContinuacion_de_ProcesoApiConsumer.SelAll(true);
            if (Continuacion_de_Procesos_Resultado_No_Vinculacion != null && Continuacion_de_Procesos_Resultado_No_Vinculacion.Resource != null)
                ViewBag.Continuacion_de_Procesos_Resultado_No_Vinculacion = Continuacion_de_Procesos_Resultado_No_Vinculacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Continuacion_de_Proceso", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAuto_de_Vinculacion_a_ProcesoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Auto_de_Vinculacion_a_Procesos_Resultado_Vinculacion = _IAuto_de_Vinculacion_a_ProcesoApiConsumer.SelAll(true);
            if (Auto_de_Vinculacion_a_Procesos_Resultado_Vinculacion != null && Auto_de_Vinculacion_a_Procesos_Resultado_Vinculacion.Resource != null)
                ViewBag.Auto_de_Vinculacion_a_Procesos_Resultado_Vinculacion = Auto_de_Vinculacion_a_Procesos_Resultado_Vinculacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Auto_de_Vinculacion_a_Proceso", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPlazo_de_Investigacion_ComplementariaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Plazo_de_Investigacion_Complementarias_plazo_investigacion_complementaria = _IPlazo_de_Investigacion_ComplementariaApiConsumer.SelAll(true);
            if (Plazo_de_Investigacion_Complementarias_plazo_investigacion_complementaria != null && Plazo_de_Investigacion_Complementarias_plazo_investigacion_complementaria.Resource != null)
                ViewBag.Plazo_de_Investigacion_Complementarias_plazo_investigacion_complementaria = Plazo_de_Investigacion_Complementarias_plazo_investigacion_complementaria.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Plazo_de_Investigacion_Complementaria", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_Acusador_Coadyudante = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_Acusador_Coadyudante != null && A_Tiempos_Acusador_Coadyudante.Resource != null)
                ViewBag.A_Tiempos_Acusador_Coadyudante = A_Tiempos_Acusador_Coadyudante.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_cumplio_descubrimiento_probatorio = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_cumplio_descubrimiento_probatorio != null && A_Tiempos_cumplio_descubrimiento_probatorio.Resource != null)
                ViewBag.A_Tiempos_cumplio_descubrimiento_probatorio = A_Tiempos_cumplio_descubrimiento_probatorio.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_Acuerdos_Probatorios = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_Acuerdos_Probatorios != null && A_Tiempos_Acuerdos_Probatorios.Resource != null)
                ViewBag.A_Tiempos_Acuerdos_Probatorios = A_Tiempos_Acuerdos_Probatorios.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResultado_de_Audiencia_IntermediaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resultado_de_Audiencia_Intermedias_Resultado = _IResultado_de_Audiencia_IntermediaApiConsumer.SelAll(true);
            if (Resultado_de_Audiencia_Intermedias_Resultado != null && Resultado_de_Audiencia_Intermedias_Resultado.Resource != null)
                ViewBag.Resultado_de_Audiencia_Intermedias_Resultado = Resultado_de_Audiencia_Intermedias_Resultado.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resultado_de_Audiencia_Intermedia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITribunal_de_EnjuiciamientoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tribunal_de_Enjuiciamientos_Tribunal_de_Enjuiciamiento = _ITribunal_de_EnjuiciamientoApiConsumer.SelAll(true);
            if (Tribunal_de_Enjuiciamientos_Tribunal_de_Enjuiciamiento != null && Tribunal_de_Enjuiciamientos_Tribunal_de_Enjuiciamiento.Resource != null)
                ViewBag.Tribunal_de_Enjuiciamientos_Tribunal_de_Enjuiciamiento = Tribunal_de_Enjuiciamientos_Tribunal_de_Enjuiciamiento.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tribunal_de_Enjuiciamiento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISentenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Sentencias_Fallo_del_Tribunal = _ISentenciaApiConsumer.SelAll(true);
            if (Sentencias_Fallo_del_Tribunal != null && Sentencias_Fallo_del_Tribunal.Resource != null)
                ViewBag.Sentencias_Fallo_del_Tribunal = Sentencias_Fallo_del_Tribunal.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Sentencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resolucions_Resolucion = _IResolucionApiConsumer.SelAll(true);
            if (Resolucions_Resolucion != null && Resolucions_Resolucion.Resource != null)
                ViewBag.Resolucions_Resolucion = Resolucions_Resolucion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resolucion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISentenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Sentencias_Tipo_de_Sentencia = _ISentenciaApiConsumer.SelAll(true);
            if (Sentencias_Tipo_de_Sentencia != null && Sentencias_Tipo_de_Sentencia.Resource != null)
                ViewBag.Sentencias_Tipo_de_Sentencia = Sentencias_Tipo_de_Sentencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Sentencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Usuario_que_Registra = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Usuario_que_Registra != null && Spartan_Users_Usuario_que_Registra.Resource != null)
                ViewBag.Spartan_Users_Usuario_que_Registra = Spartan_Users_Usuario_que_Registra.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_Reclasificacion_Juridica = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_Reclasificacion_Juridica != null && A_Tiempos_Reclasificacion_Juridica.Resource != null)
                ViewBag.A_Tiempos_Reclasificacion_Juridica = A_Tiempos_Reclasificacion_Juridica.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPlazo_ConstitucionalApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Plazo_Constitucionals_Plazo_Constitucional = _IPlazo_ConstitucionalApiConsumer.SelAll(true);
            if (Plazo_Constitucionals_Plazo_Constitucional != null && Plazo_Constitucionals_Plazo_Constitucional.Resource != null)
                ViewBag.Plazo_Constitucionals_Plazo_Constitucional = Plazo_Constitucionals_Plazo_Constitucional.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Plazo_Constitucional", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IVinculacion_a_ProcesoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Vinculacion_a_Procesos_Vinculacion = _IVinculacion_a_ProcesoApiConsumer.SelAll(true);
            if (Vinculacion_a_Procesos_Vinculacion != null && Vinculacion_a_Procesos_Vinculacion.Resource != null)
                ViewBag.Vinculacion_a_Procesos_Vinculacion = Vinculacion_a_Procesos_Vinculacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Vinculacion_a_Proceso", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IContinuacion_de_ProcesoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Continuacion_de_Procesos_Resultado_No_Vinculacion = _IContinuacion_de_ProcesoApiConsumer.SelAll(true);
            if (Continuacion_de_Procesos_Resultado_No_Vinculacion != null && Continuacion_de_Procesos_Resultado_No_Vinculacion.Resource != null)
                ViewBag.Continuacion_de_Procesos_Resultado_No_Vinculacion = Continuacion_de_Procesos_Resultado_No_Vinculacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Continuacion_de_Proceso", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAuto_de_Vinculacion_a_ProcesoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Auto_de_Vinculacion_a_Procesos_Resultado_Vinculacion = _IAuto_de_Vinculacion_a_ProcesoApiConsumer.SelAll(true);
            if (Auto_de_Vinculacion_a_Procesos_Resultado_Vinculacion != null && Auto_de_Vinculacion_a_Procesos_Resultado_Vinculacion.Resource != null)
                ViewBag.Auto_de_Vinculacion_a_Procesos_Resultado_Vinculacion = Auto_de_Vinculacion_a_Procesos_Resultado_Vinculacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Auto_de_Vinculacion_a_Proceso", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPlazo_de_Investigacion_ComplementariaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Plazo_de_Investigacion_Complementarias_plazo_investigacion_complementaria = _IPlazo_de_Investigacion_ComplementariaApiConsumer.SelAll(true);
            if (Plazo_de_Investigacion_Complementarias_plazo_investigacion_complementaria != null && Plazo_de_Investigacion_Complementarias_plazo_investigacion_complementaria.Resource != null)
                ViewBag.Plazo_de_Investigacion_Complementarias_plazo_investigacion_complementaria = Plazo_de_Investigacion_Complementarias_plazo_investigacion_complementaria.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Plazo_de_Investigacion_Complementaria", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_Acusador_Coadyudante = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_Acusador_Coadyudante != null && A_Tiempos_Acusador_Coadyudante.Resource != null)
                ViewBag.A_Tiempos_Acusador_Coadyudante = A_Tiempos_Acusador_Coadyudante.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_cumplio_descubrimiento_probatorio = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_cumplio_descubrimiento_probatorio != null && A_Tiempos_cumplio_descubrimiento_probatorio.Resource != null)
                ViewBag.A_Tiempos_cumplio_descubrimiento_probatorio = A_Tiempos_cumplio_descubrimiento_probatorio.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_Acuerdos_Probatorios = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_Acuerdos_Probatorios != null && A_Tiempos_Acuerdos_Probatorios.Resource != null)
                ViewBag.A_Tiempos_Acuerdos_Probatorios = A_Tiempos_Acuerdos_Probatorios.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResultado_de_Audiencia_IntermediaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resultado_de_Audiencia_Intermedias_Resultado = _IResultado_de_Audiencia_IntermediaApiConsumer.SelAll(true);
            if (Resultado_de_Audiencia_Intermedias_Resultado != null && Resultado_de_Audiencia_Intermedias_Resultado.Resource != null)
                ViewBag.Resultado_de_Audiencia_Intermedias_Resultado = Resultado_de_Audiencia_Intermedias_Resultado.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resultado_de_Audiencia_Intermedia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITribunal_de_EnjuiciamientoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tribunal_de_Enjuiciamientos_Tribunal_de_Enjuiciamiento = _ITribunal_de_EnjuiciamientoApiConsumer.SelAll(true);
            if (Tribunal_de_Enjuiciamientos_Tribunal_de_Enjuiciamiento != null && Tribunal_de_Enjuiciamientos_Tribunal_de_Enjuiciamiento.Resource != null)
                ViewBag.Tribunal_de_Enjuiciamientos_Tribunal_de_Enjuiciamiento = Tribunal_de_Enjuiciamientos_Tribunal_de_Enjuiciamiento.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tribunal_de_Enjuiciamiento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISentenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Sentencias_Fallo_del_Tribunal = _ISentenciaApiConsumer.SelAll(true);
            if (Sentencias_Fallo_del_Tribunal != null && Sentencias_Fallo_del_Tribunal.Resource != null)
                ViewBag.Sentencias_Fallo_del_Tribunal = Sentencias_Fallo_del_Tribunal.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Sentencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resolucions_Resolucion = _IResolucionApiConsumer.SelAll(true);
            if (Resolucions_Resolucion != null && Resolucions_Resolucion.Resource != null)
                ViewBag.Resolucions_Resolucion = Resolucions_Resolucion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resolucion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISentenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Sentencias_Tipo_de_Sentencia = _ISentenciaApiConsumer.SelAll(true);
            if (Sentencias_Tipo_de_Sentencia != null && Sentencias_Tipo_de_Sentencia.Resource != null)
                ViewBag.Sentencias_Tipo_de_Sentencia = Sentencias_Tipo_de_Sentencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Sentencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Proceso_PenalAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Proceso_PenalAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Proceso_PenalAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Proceso_PenalPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IProceso_PenalApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Proceso_Penals == null)
                result.Proceso_Penals = new List<Proceso_Penal>();

            return Json(new
            {
                data = result.Proceso_Penals.Select(m => new Proceso_PenalGridModel
                    {
                    Folio = m.Folio
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,ImputadoNombre_Completo_Detenido = CultureHelper.GetTraduction(m.Imputado_Detalle_de_Imputado.Clave.ToString(), "Detalle_de_Imputado") ?? (string)m.Imputado_Detalle_de_Imputado.Nombre_Completo_Detenido
                        ,Reclasificacion_JuridicaDescripcion = CultureHelper.GetTraduction(m.Reclasificacion_Juridica_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Reclasificacion_Juridica_A_Tiempo.Descripcion
                        ,Plazo_ConstitucionalDescripcion = CultureHelper.GetTraduction(m.Plazo_Constitucional_Plazo_Constitucional.Clave.ToString(), "Descripcion") ?? (string)m.Plazo_Constitucional_Plazo_Constitucional.Descripcion
                        ,VinculacionDescripcion = CultureHelper.GetTraduction(m.Vinculacion_Vinculacion_a_Proceso.Clave.ToString(), "Descripcion") ?? (string)m.Vinculacion_Vinculacion_a_Proceso.Descripcion
                        ,Resultado_No_VinculacionDescripcion = CultureHelper.GetTraduction(m.Resultado_No_Vinculacion_Continuacion_de_Proceso.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_No_Vinculacion_Continuacion_de_Proceso.Descripcion
                        ,Resultado_VinculacionDescripcion = CultureHelper.GetTraduction(m.Resultado_Vinculacion_Auto_de_Vinculacion_a_Proceso.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_Vinculacion_Auto_de_Vinculacion_a_Proceso.Descripcion
                        ,plazo_investigacion_complementariaDescripcion = CultureHelper.GetTraduction(m.plazo_investigacion_complementaria_Plazo_de_Investigacion_Complementaria.Clave.ToString(), "Descripcion") ?? (string)m.plazo_investigacion_complementaria_Plazo_de_Investigacion_Complementaria.Descripcion
			,fecha_investigacion_complementaria = m.fecha_investigacion_complementaria
			,hora_investigacion_complementaria = m.hora_investigacion_complementaria
			,Nombre_del_Juez_de_Control = m.Nombre_del_Juez_de_Control
                        ,Fecha_de_Entrega_de_Escrito_de_Acusacion = (m.Fecha_de_Entrega_de_Escrito_de_Acusacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Entrega_de_Escrito_de_Acusacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Entrega_de_Escrito_de_Acusacion = m.Hora_de_Entrega_de_Escrito_de_Acusacion
                        ,Fecha_de_Audiencia_Intermedia = (m.Fecha_de_Audiencia_Intermedia == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Audiencia_Intermedia).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Audiencia_Intermedia = m.Hora_de_Audiencia_Intermedia
                        ,Acusador_CoadyudanteDescripcion = CultureHelper.GetTraduction(m.Acusador_Coadyudante_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Acusador_Coadyudante_A_Tiempo.Descripcion
                        ,cumplio_descubrimiento_probatorioDescripcion = CultureHelper.GetTraduction(m.cumplio_descubrimiento_probatorio_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.cumplio_descubrimiento_probatorio_A_Tiempo.Descripcion
                        ,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora
                        ,Acuerdos_ProbatoriosDescripcion = CultureHelper.GetTraduction(m.Acuerdos_Probatorios_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Acuerdos_Probatorios_A_Tiempo.Descripcion
			,acuerdos_probatorios_cuales_fueron = m.acuerdos_probatorios_cuales_fueron
                        ,ResultadoDescripcion = CultureHelper.GetTraduction(m.Resultado_Resultado_de_Audiencia_Intermedia.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_Resultado_de_Audiencia_Intermedia.Descripcion
                        ,Tribunal_de_EnjuiciamientoDescripcion = CultureHelper.GetTraduction(m.Tribunal_de_Enjuiciamiento_Tribunal_de_Enjuiciamiento.Clave.ToString(), "Descripcion") ?? (string)m.Tribunal_de_Enjuiciamiento_Tribunal_de_Enjuiciamiento.Descripcion
			,Nombre_del_Juez = m.Nombre_del_Juez
			,Juez_Colegiado = m.Juez_Colegiado
			,Juez_Relator = m.Juez_Relator
			,Juez_Vocal = m.Juez_Vocal
                        ,Fecha_de_Audiencia_de_Juicio = (m.Fecha_de_Audiencia_de_Juicio == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Audiencia_de_Juicio).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Audiencia_de_Juicio = m.Hora_de_Audiencia_de_Juicio
                        ,Fallo_del_TribunalDescripcion = CultureHelper.GetTraduction(m.Fallo_del_Tribunal_Sentencia.Clave.ToString(), "Descripcion") ?? (string)m.Fallo_del_Tribunal_Sentencia.Descripcion
			,pruebas_a_desahogar = m.pruebas_a_desahogar
                        ,ResolucionDescripcion = CultureHelper.GetTraduction(m.Resolucion_Resolucion.Clave.ToString(), "Descripcion") ?? (string)m.Resolucion_Resolucion.Descripcion
			,Plazo_meses = m.Plazo_meses
                        ,Tipo_de_SentenciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Sentencia_Sentencia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Sentencia_Sentencia.Descripcion
			,cuantia_de_pena_anios = m.cuantia_de_pena_anios
			,cuantia_de_pena_meses = m.cuantia_de_pena_meses
			,Monto_de_la_Reparacion_del_Dano = m.Monto_de_la_Reparacion_del_Dano

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetProceso_PenalAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IProceso_PenalApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IProceso_PenalApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Folio), "Proceso_Penal", m.),
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
        /// Get List of Proceso_Penal from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Proceso_Penal Entity</returns>
        public ActionResult GetProceso_PenalList(UrlParametersModel param)
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
            _IProceso_PenalApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Proceso_PenalPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Proceso_PenalAdvanceSearchModel))
                {
					var advanceFilter =
                    (Proceso_PenalAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Proceso_PenalPropertyMapper oProceso_PenalPropertyMapper = new Proceso_PenalPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oProceso_PenalPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IProceso_PenalApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Proceso_Penals == null)
                result.Proceso_Penals = new List<Proceso_Penal>();

            return Json(new
            {
                aaData = result.Proceso_Penals.Select(m => new Proceso_PenalGridModel
            {
                    Folio = m.Folio
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,ImputadoNombre_Completo_Detenido = CultureHelper.GetTraduction(m.Imputado_Detalle_de_Imputado.Clave.ToString(), "Detalle_de_Imputado") ?? (string)m.Imputado_Detalle_de_Imputado.Nombre_Completo_Detenido
                        ,Reclasificacion_JuridicaDescripcion = CultureHelper.GetTraduction(m.Reclasificacion_Juridica_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Reclasificacion_Juridica_A_Tiempo.Descripcion
                        ,Plazo_ConstitucionalDescripcion = CultureHelper.GetTraduction(m.Plazo_Constitucional_Plazo_Constitucional.Clave.ToString(), "Descripcion") ?? (string)m.Plazo_Constitucional_Plazo_Constitucional.Descripcion
                        ,VinculacionDescripcion = CultureHelper.GetTraduction(m.Vinculacion_Vinculacion_a_Proceso.Clave.ToString(), "Descripcion") ?? (string)m.Vinculacion_Vinculacion_a_Proceso.Descripcion
                        ,Resultado_No_VinculacionDescripcion = CultureHelper.GetTraduction(m.Resultado_No_Vinculacion_Continuacion_de_Proceso.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_No_Vinculacion_Continuacion_de_Proceso.Descripcion
                        ,Resultado_VinculacionDescripcion = CultureHelper.GetTraduction(m.Resultado_Vinculacion_Auto_de_Vinculacion_a_Proceso.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_Vinculacion_Auto_de_Vinculacion_a_Proceso.Descripcion
                        ,plazo_investigacion_complementariaDescripcion = CultureHelper.GetTraduction(m.plazo_investigacion_complementaria_Plazo_de_Investigacion_Complementaria.Clave.ToString(), "Descripcion") ?? (string)m.plazo_investigacion_complementaria_Plazo_de_Investigacion_Complementaria.Descripcion
			,fecha_investigacion_complementaria = m.fecha_investigacion_complementaria
			,hora_investigacion_complementaria = m.hora_investigacion_complementaria
			,Nombre_del_Juez_de_Control = m.Nombre_del_Juez_de_Control
                        ,Fecha_de_Entrega_de_Escrito_de_Acusacion = (m.Fecha_de_Entrega_de_Escrito_de_Acusacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Entrega_de_Escrito_de_Acusacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Entrega_de_Escrito_de_Acusacion = m.Hora_de_Entrega_de_Escrito_de_Acusacion
                        ,Fecha_de_Audiencia_Intermedia = (m.Fecha_de_Audiencia_Intermedia == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Audiencia_Intermedia).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Audiencia_Intermedia = m.Hora_de_Audiencia_Intermedia
                        ,Acusador_CoadyudanteDescripcion = CultureHelper.GetTraduction(m.Acusador_Coadyudante_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Acusador_Coadyudante_A_Tiempo.Descripcion
                        ,cumplio_descubrimiento_probatorioDescripcion = CultureHelper.GetTraduction(m.cumplio_descubrimiento_probatorio_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.cumplio_descubrimiento_probatorio_A_Tiempo.Descripcion
                        ,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora
                        ,Acuerdos_ProbatoriosDescripcion = CultureHelper.GetTraduction(m.Acuerdos_Probatorios_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Acuerdos_Probatorios_A_Tiempo.Descripcion
			,acuerdos_probatorios_cuales_fueron = m.acuerdos_probatorios_cuales_fueron
                        ,ResultadoDescripcion = CultureHelper.GetTraduction(m.Resultado_Resultado_de_Audiencia_Intermedia.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_Resultado_de_Audiencia_Intermedia.Descripcion
                        ,Tribunal_de_EnjuiciamientoDescripcion = CultureHelper.GetTraduction(m.Tribunal_de_Enjuiciamiento_Tribunal_de_Enjuiciamiento.Clave.ToString(), "Descripcion") ?? (string)m.Tribunal_de_Enjuiciamiento_Tribunal_de_Enjuiciamiento.Descripcion
			,Nombre_del_Juez = m.Nombre_del_Juez
			,Juez_Colegiado = m.Juez_Colegiado
			,Juez_Relator = m.Juez_Relator
			,Juez_Vocal = m.Juez_Vocal
                        ,Fecha_de_Audiencia_de_Juicio = (m.Fecha_de_Audiencia_de_Juicio == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Audiencia_de_Juicio).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Audiencia_de_Juicio = m.Hora_de_Audiencia_de_Juicio
                        ,Fallo_del_TribunalDescripcion = CultureHelper.GetTraduction(m.Fallo_del_Tribunal_Sentencia.Clave.ToString(), "Descripcion") ?? (string)m.Fallo_del_Tribunal_Sentencia.Descripcion
			,pruebas_a_desahogar = m.pruebas_a_desahogar
                        ,ResolucionDescripcion = CultureHelper.GetTraduction(m.Resolucion_Resolucion.Clave.ToString(), "Descripcion") ?? (string)m.Resolucion_Resolucion.Descripcion
			,Plazo_meses = m.Plazo_meses
                        ,Tipo_de_SentenciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Sentencia_Sentencia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Sentencia_Sentencia.Descripcion
			,cuantia_de_pena_anios = m.cuantia_de_pena_anios
			,cuantia_de_pena_meses = m.cuantia_de_pena_meses
			,Monto_de_la_Reparacion_del_Dano = m.Monto_de_la_Reparacion_del_Dano

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetProceso_Penal_Expediente_MP_expediente_ministerio_publico(string query, string where)
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
        public JsonResult GetProceso_Penal_Imputado_Detalle_de_Imputado(string query, string where)
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
//Grid GetAutoComplete
        [HttpGet]
        public JsonResult GetDetalle_Delitos_Proceso_Penal_Delito_Delito(string query, string where)
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

//Grid GetAutoComplete

//Grid GetAutoComplete

//Grid GetAutoComplete

//Grid GetAutoComplete

//Grid GetAutoComplete






        [NonAction]
        public string GetAdvanceFilter(Proceso_PenalAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromFolio) || !string.IsNullOrEmpty(filter.ToFolio))
            {
                if (!string.IsNullOrEmpty(filter.FromFolio))
                    where += " AND Proceso_Penal.Folio >= " + filter.FromFolio;
                if (!string.IsNullOrEmpty(filter.ToFolio))
                    where += " AND Proceso_Penal.Folio <= " + filter.ToFolio;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceExpediente_MP))
            {
                switch (filter.Expediente_MPFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND expediente_ministerio_publico.nic LIKE '" + filter.AdvanceExpediente_MP + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND expediente_ministerio_publico.nic LIKE '%" + filter.AdvanceExpediente_MP + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND expediente_ministerio_publico.nic = '" + filter.AdvanceExpediente_MP + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND expediente_ministerio_publico.nic LIKE '%" + filter.AdvanceExpediente_MP + "%'";
                        break;
                }
            }
            else if (filter.AdvanceExpediente_MPMultiple != null && filter.AdvanceExpediente_MPMultiple.Count() > 0)
            {
                var Expediente_MPIds = string.Join(",", filter.AdvanceExpediente_MPMultiple);

                where += " AND Proceso_Penal.Expediente_MP In (" + Expediente_MPIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro) || !string.IsNullOrEmpty(filter.ToFecha_de_Registro))
            {
                var Fecha_de_RegistroFrom = DateTime.ParseExact(filter.FromFecha_de_Registro, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_RegistroTo = DateTime.ParseExact(filter.ToFecha_de_Registro, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro))
                    where += " AND Proceso_Penal.Fecha_de_Registro >= '" + Fecha_de_RegistroFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Registro))
                    where += " AND Proceso_Penal.Fecha_de_Registro <= '" + Fecha_de_RegistroTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Registro) || !string.IsNullOrEmpty(filter.ToHora_de_Registro))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Registro))
                    where += " AND Convert(TIME,Proceso_Penal.Hora_de_Registro) >='" + filter.FromHora_de_Registro + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Registro))
                    where += " AND Convert(TIME,Proceso_Penal.Hora_de_Registro) <='" + filter.ToHora_de_Registro + "'";
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

                where += " AND Proceso_Penal.Usuario_que_Registra In (" + Usuario_que_RegistraIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceImputado))
            {
                switch (filter.ImputadoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Imputado.Nombre_Completo_Detenido LIKE '" + filter.AdvanceImputado + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Imputado.Nombre_Completo_Detenido LIKE '%" + filter.AdvanceImputado + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Imputado.Nombre_Completo_Detenido = '" + filter.AdvanceImputado + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Imputado.Nombre_Completo_Detenido LIKE '%" + filter.AdvanceImputado + "%'";
                        break;
                }
            }
            else if (filter.AdvanceImputadoMultiple != null && filter.AdvanceImputadoMultiple.Count() > 0)
            {
                var ImputadoIds = string.Join(",", filter.AdvanceImputadoMultiple);

                where += " AND Proceso_Penal.Imputado In (" + ImputadoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceReclasificacion_Juridica))
            {
                switch (filter.Reclasificacion_JuridicaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND A_Tiempo.Descripcion LIKE '" + filter.AdvanceReclasificacion_Juridica + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND A_Tiempo.Descripcion LIKE '%" + filter.AdvanceReclasificacion_Juridica + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND A_Tiempo.Descripcion = '" + filter.AdvanceReclasificacion_Juridica + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND A_Tiempo.Descripcion LIKE '%" + filter.AdvanceReclasificacion_Juridica + "%'";
                        break;
                }
            }
            else if (filter.AdvanceReclasificacion_JuridicaMultiple != null && filter.AdvanceReclasificacion_JuridicaMultiple.Count() > 0)
            {
                var Reclasificacion_JuridicaIds = string.Join(",", filter.AdvanceReclasificacion_JuridicaMultiple);

                where += " AND Proceso_Penal.Reclasificacion_Juridica In (" + Reclasificacion_JuridicaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvancePlazo_Constitucional))
            {
                switch (filter.Plazo_ConstitucionalFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Plazo_Constitucional.Descripcion LIKE '" + filter.AdvancePlazo_Constitucional + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Plazo_Constitucional.Descripcion LIKE '%" + filter.AdvancePlazo_Constitucional + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Plazo_Constitucional.Descripcion = '" + filter.AdvancePlazo_Constitucional + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Plazo_Constitucional.Descripcion LIKE '%" + filter.AdvancePlazo_Constitucional + "%'";
                        break;
                }
            }
            else if (filter.AdvancePlazo_ConstitucionalMultiple != null && filter.AdvancePlazo_ConstitucionalMultiple.Count() > 0)
            {
                var Plazo_ConstitucionalIds = string.Join(",", filter.AdvancePlazo_ConstitucionalMultiple);

                where += " AND Proceso_Penal.Plazo_Constitucional In (" + Plazo_ConstitucionalIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceVinculacion))
            {
                switch (filter.VinculacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Vinculacion_a_Proceso.Descripcion LIKE '" + filter.AdvanceVinculacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Vinculacion_a_Proceso.Descripcion LIKE '%" + filter.AdvanceVinculacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Vinculacion_a_Proceso.Descripcion = '" + filter.AdvanceVinculacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Vinculacion_a_Proceso.Descripcion LIKE '%" + filter.AdvanceVinculacion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceVinculacionMultiple != null && filter.AdvanceVinculacionMultiple.Count() > 0)
            {
                var VinculacionIds = string.Join(",", filter.AdvanceVinculacionMultiple);

                where += " AND Proceso_Penal.Vinculacion In (" + VinculacionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceResultado_No_Vinculacion))
            {
                switch (filter.Resultado_No_VinculacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Continuacion_de_Proceso.Descripcion LIKE '" + filter.AdvanceResultado_No_Vinculacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Continuacion_de_Proceso.Descripcion LIKE '%" + filter.AdvanceResultado_No_Vinculacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Continuacion_de_Proceso.Descripcion = '" + filter.AdvanceResultado_No_Vinculacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Continuacion_de_Proceso.Descripcion LIKE '%" + filter.AdvanceResultado_No_Vinculacion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceResultado_No_VinculacionMultiple != null && filter.AdvanceResultado_No_VinculacionMultiple.Count() > 0)
            {
                var Resultado_No_VinculacionIds = string.Join(",", filter.AdvanceResultado_No_VinculacionMultiple);

                where += " AND Proceso_Penal.Resultado_No_Vinculacion In (" + Resultado_No_VinculacionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceResultado_Vinculacion))
            {
                switch (filter.Resultado_VinculacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Auto_de_Vinculacion_a_Proceso.Descripcion LIKE '" + filter.AdvanceResultado_Vinculacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Auto_de_Vinculacion_a_Proceso.Descripcion LIKE '%" + filter.AdvanceResultado_Vinculacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Auto_de_Vinculacion_a_Proceso.Descripcion = '" + filter.AdvanceResultado_Vinculacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Auto_de_Vinculacion_a_Proceso.Descripcion LIKE '%" + filter.AdvanceResultado_Vinculacion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceResultado_VinculacionMultiple != null && filter.AdvanceResultado_VinculacionMultiple.Count() > 0)
            {
                var Resultado_VinculacionIds = string.Join(",", filter.AdvanceResultado_VinculacionMultiple);

                where += " AND Proceso_Penal.Resultado_Vinculacion In (" + Resultado_VinculacionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Advanceplazo_investigacion_complementaria))
            {
                switch (filter.plazo_investigacion_complementariaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Plazo_de_Investigacion_Complementaria.Descripcion LIKE '" + filter.Advanceplazo_investigacion_complementaria + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Plazo_de_Investigacion_Complementaria.Descripcion LIKE '%" + filter.Advanceplazo_investigacion_complementaria + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Plazo_de_Investigacion_Complementaria.Descripcion = '" + filter.Advanceplazo_investigacion_complementaria + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Plazo_de_Investigacion_Complementaria.Descripcion LIKE '%" + filter.Advanceplazo_investigacion_complementaria + "%'";
                        break;
                }
            }
            else if (filter.Advanceplazo_investigacion_complementariaMultiple != null && filter.Advanceplazo_investigacion_complementariaMultiple.Count() > 0)
            {
                var plazo_investigacion_complementariaIds = string.Join(",", filter.Advanceplazo_investigacion_complementariaMultiple);

                where += " AND Proceso_Penal.plazo_investigacion_complementaria In (" + plazo_investigacion_complementariaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Fromfecha_investigacion_complementaria) || !string.IsNullOrEmpty(filter.Tofecha_investigacion_complementaria))
            {
                if (!string.IsNullOrEmpty(filter.Fromfecha_investigacion_complementaria))
                    where += " AND Proceso_Penal.fecha_investigacion_complementaria >= " + filter.Fromfecha_investigacion_complementaria;
                if (!string.IsNullOrEmpty(filter.Tofecha_investigacion_complementaria))
                    where += " AND Proceso_Penal.fecha_investigacion_complementaria <= " + filter.Tofecha_investigacion_complementaria;
            }

            if (!string.IsNullOrEmpty(filter.Fromhora_investigacion_complementaria) || !string.IsNullOrEmpty(filter.Tohora_investigacion_complementaria))
            {
                if (!string.IsNullOrEmpty(filter.Fromhora_investigacion_complementaria))
                    where += " AND Convert(TIME,Proceso_Penal.hora_investigacion_complementaria) >='" + filter.Fromhora_investigacion_complementaria + "'";
                if (!string.IsNullOrEmpty(filter.Tohora_investigacion_complementaria))
                    where += " AND Convert(TIME,Proceso_Penal.hora_investigacion_complementaria) <='" + filter.Tohora_investigacion_complementaria + "'";
            }

            if (!string.IsNullOrEmpty(filter.Nombre_del_Juez_de_Control))
            {
                switch (filter.Nombre_del_Juez_de_ControlFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Proceso_Penal.Nombre_del_Juez_de_Control LIKE '" + filter.Nombre_del_Juez_de_Control + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Proceso_Penal.Nombre_del_Juez_de_Control LIKE '%" + filter.Nombre_del_Juez_de_Control + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Proceso_Penal.Nombre_del_Juez_de_Control = '" + filter.Nombre_del_Juez_de_Control + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Proceso_Penal.Nombre_del_Juez_de_Control LIKE '%" + filter.Nombre_del_Juez_de_Control + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Entrega_de_Escrito_de_Acusacion) || !string.IsNullOrEmpty(filter.ToFecha_de_Entrega_de_Escrito_de_Acusacion))
            {
                var Fecha_de_Entrega_de_Escrito_de_AcusacionFrom = DateTime.ParseExact(filter.FromFecha_de_Entrega_de_Escrito_de_Acusacion, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_Entrega_de_Escrito_de_AcusacionTo = DateTime.ParseExact(filter.ToFecha_de_Entrega_de_Escrito_de_Acusacion, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Entrega_de_Escrito_de_Acusacion))
                    where += " AND Proceso_Penal.Fecha_de_Entrega_de_Escrito_de_Acusacion >= '" + Fecha_de_Entrega_de_Escrito_de_AcusacionFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Entrega_de_Escrito_de_Acusacion))
                    where += " AND Proceso_Penal.Fecha_de_Entrega_de_Escrito_de_Acusacion <= '" + Fecha_de_Entrega_de_Escrito_de_AcusacionTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Entrega_de_Escrito_de_Acusacion) || !string.IsNullOrEmpty(filter.ToHora_de_Entrega_de_Escrito_de_Acusacion))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Entrega_de_Escrito_de_Acusacion))
                    where += " AND Convert(TIME,Proceso_Penal.Hora_de_Entrega_de_Escrito_de_Acusacion) >='" + filter.FromHora_de_Entrega_de_Escrito_de_Acusacion + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Entrega_de_Escrito_de_Acusacion))
                    where += " AND Convert(TIME,Proceso_Penal.Hora_de_Entrega_de_Escrito_de_Acusacion) <='" + filter.ToHora_de_Entrega_de_Escrito_de_Acusacion + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Audiencia_Intermedia) || !string.IsNullOrEmpty(filter.ToFecha_de_Audiencia_Intermedia))
            {
                var Fecha_de_Audiencia_IntermediaFrom = DateTime.ParseExact(filter.FromFecha_de_Audiencia_Intermedia, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_Audiencia_IntermediaTo = DateTime.ParseExact(filter.ToFecha_de_Audiencia_Intermedia, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Audiencia_Intermedia))
                    where += " AND Proceso_Penal.Fecha_de_Audiencia_Intermedia >= '" + Fecha_de_Audiencia_IntermediaFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Audiencia_Intermedia))
                    where += " AND Proceso_Penal.Fecha_de_Audiencia_Intermedia <= '" + Fecha_de_Audiencia_IntermediaTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Audiencia_Intermedia) || !string.IsNullOrEmpty(filter.ToHora_de_Audiencia_Intermedia))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Audiencia_Intermedia))
                    where += " AND Convert(TIME,Proceso_Penal.Hora_de_Audiencia_Intermedia) >='" + filter.FromHora_de_Audiencia_Intermedia + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Audiencia_Intermedia))
                    where += " AND Convert(TIME,Proceso_Penal.Hora_de_Audiencia_Intermedia) <='" + filter.ToHora_de_Audiencia_Intermedia + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceAcusador_Coadyudante))
            {
                switch (filter.Acusador_CoadyudanteFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND A_Tiempo.Descripcion LIKE '" + filter.AdvanceAcusador_Coadyudante + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND A_Tiempo.Descripcion LIKE '%" + filter.AdvanceAcusador_Coadyudante + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND A_Tiempo.Descripcion = '" + filter.AdvanceAcusador_Coadyudante + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND A_Tiempo.Descripcion LIKE '%" + filter.AdvanceAcusador_Coadyudante + "%'";
                        break;
                }
            }
            else if (filter.AdvanceAcusador_CoadyudanteMultiple != null && filter.AdvanceAcusador_CoadyudanteMultiple.Count() > 0)
            {
                var Acusador_CoadyudanteIds = string.Join(",", filter.AdvanceAcusador_CoadyudanteMultiple);

                where += " AND Proceso_Penal.Acusador_Coadyudante In (" + Acusador_CoadyudanteIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Advancecumplio_descubrimiento_probatorio))
            {
                switch (filter.cumplio_descubrimiento_probatorioFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND A_Tiempo.Descripcion LIKE '" + filter.Advancecumplio_descubrimiento_probatorio + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND A_Tiempo.Descripcion LIKE '%" + filter.Advancecumplio_descubrimiento_probatorio + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND A_Tiempo.Descripcion = '" + filter.Advancecumplio_descubrimiento_probatorio + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND A_Tiempo.Descripcion LIKE '%" + filter.Advancecumplio_descubrimiento_probatorio + "%'";
                        break;
                }
            }
            else if (filter.Advancecumplio_descubrimiento_probatorioMultiple != null && filter.Advancecumplio_descubrimiento_probatorioMultiple.Count() > 0)
            {
                var cumplio_descubrimiento_probatorioIds = string.Join(",", filter.Advancecumplio_descubrimiento_probatorioMultiple);

                where += " AND Proceso_Penal.cumplio_descubrimiento_probatorio In (" + cumplio_descubrimiento_probatorioIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha) || !string.IsNullOrEmpty(filter.ToFecha))
            {
                var FechaFrom = DateTime.ParseExact(filter.FromFecha, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var FechaTo = DateTime.ParseExact(filter.ToFecha, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha))
                    where += " AND Proceso_Penal.Fecha >= '" + FechaFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha))
                    where += " AND Proceso_Penal.Fecha <= '" + FechaTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora) || !string.IsNullOrEmpty(filter.ToHora))
            {
                if (!string.IsNullOrEmpty(filter.FromHora))
                    where += " AND Convert(TIME,Proceso_Penal.Hora) >='" + filter.FromHora + "'";
                if (!string.IsNullOrEmpty(filter.ToHora))
                    where += " AND Convert(TIME,Proceso_Penal.Hora) <='" + filter.ToHora + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceAcuerdos_Probatorios))
            {
                switch (filter.Acuerdos_ProbatoriosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND A_Tiempo.Descripcion LIKE '" + filter.AdvanceAcuerdos_Probatorios + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND A_Tiempo.Descripcion LIKE '%" + filter.AdvanceAcuerdos_Probatorios + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND A_Tiempo.Descripcion = '" + filter.AdvanceAcuerdos_Probatorios + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND A_Tiempo.Descripcion LIKE '%" + filter.AdvanceAcuerdos_Probatorios + "%'";
                        break;
                }
            }
            else if (filter.AdvanceAcuerdos_ProbatoriosMultiple != null && filter.AdvanceAcuerdos_ProbatoriosMultiple.Count() > 0)
            {
                var Acuerdos_ProbatoriosIds = string.Join(",", filter.AdvanceAcuerdos_ProbatoriosMultiple);

                where += " AND Proceso_Penal.Acuerdos_Probatorios In (" + Acuerdos_ProbatoriosIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.acuerdos_probatorios_cuales_fueron))
            {
                switch (filter.acuerdos_probatorios_cuales_fueronFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Proceso_Penal.acuerdos_probatorios_cuales_fueron LIKE '" + filter.acuerdos_probatorios_cuales_fueron + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Proceso_Penal.acuerdos_probatorios_cuales_fueron LIKE '%" + filter.acuerdos_probatorios_cuales_fueron + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Proceso_Penal.acuerdos_probatorios_cuales_fueron = '" + filter.acuerdos_probatorios_cuales_fueron + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Proceso_Penal.acuerdos_probatorios_cuales_fueron LIKE '%" + filter.acuerdos_probatorios_cuales_fueron + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceResultado))
            {
                switch (filter.ResultadoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Resultado_de_Audiencia_Intermedia.Descripcion LIKE '" + filter.AdvanceResultado + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Resultado_de_Audiencia_Intermedia.Descripcion LIKE '%" + filter.AdvanceResultado + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Resultado_de_Audiencia_Intermedia.Descripcion = '" + filter.AdvanceResultado + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Resultado_de_Audiencia_Intermedia.Descripcion LIKE '%" + filter.AdvanceResultado + "%'";
                        break;
                }
            }
            else if (filter.AdvanceResultadoMultiple != null && filter.AdvanceResultadoMultiple.Count() > 0)
            {
                var ResultadoIds = string.Join(",", filter.AdvanceResultadoMultiple);

                where += " AND Proceso_Penal.Resultado In (" + ResultadoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTribunal_de_Enjuiciamiento))
            {
                switch (filter.Tribunal_de_EnjuiciamientoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tribunal_de_Enjuiciamiento.Descripcion LIKE '" + filter.AdvanceTribunal_de_Enjuiciamiento + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tribunal_de_Enjuiciamiento.Descripcion LIKE '%" + filter.AdvanceTribunal_de_Enjuiciamiento + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tribunal_de_Enjuiciamiento.Descripcion = '" + filter.AdvanceTribunal_de_Enjuiciamiento + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tribunal_de_Enjuiciamiento.Descripcion LIKE '%" + filter.AdvanceTribunal_de_Enjuiciamiento + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTribunal_de_EnjuiciamientoMultiple != null && filter.AdvanceTribunal_de_EnjuiciamientoMultiple.Count() > 0)
            {
                var Tribunal_de_EnjuiciamientoIds = string.Join(",", filter.AdvanceTribunal_de_EnjuiciamientoMultiple);

                where += " AND Proceso_Penal.Tribunal_de_Enjuiciamiento In (" + Tribunal_de_EnjuiciamientoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Nombre_del_Juez))
            {
                switch (filter.Nombre_del_JuezFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Proceso_Penal.Nombre_del_Juez LIKE '" + filter.Nombre_del_Juez + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Proceso_Penal.Nombre_del_Juez LIKE '%" + filter.Nombre_del_Juez + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Proceso_Penal.Nombre_del_Juez = '" + filter.Nombre_del_Juez + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Proceso_Penal.Nombre_del_Juez LIKE '%" + filter.Nombre_del_Juez + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Juez_Colegiado))
            {
                switch (filter.Juez_ColegiadoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Proceso_Penal.Juez_Colegiado LIKE '" + filter.Juez_Colegiado + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Proceso_Penal.Juez_Colegiado LIKE '%" + filter.Juez_Colegiado + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Proceso_Penal.Juez_Colegiado = '" + filter.Juez_Colegiado + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Proceso_Penal.Juez_Colegiado LIKE '%" + filter.Juez_Colegiado + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Juez_Relator))
            {
                switch (filter.Juez_RelatorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Proceso_Penal.Juez_Relator LIKE '" + filter.Juez_Relator + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Proceso_Penal.Juez_Relator LIKE '%" + filter.Juez_Relator + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Proceso_Penal.Juez_Relator = '" + filter.Juez_Relator + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Proceso_Penal.Juez_Relator LIKE '%" + filter.Juez_Relator + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Juez_Vocal))
            {
                switch (filter.Juez_VocalFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Proceso_Penal.Juez_Vocal LIKE '" + filter.Juez_Vocal + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Proceso_Penal.Juez_Vocal LIKE '%" + filter.Juez_Vocal + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Proceso_Penal.Juez_Vocal = '" + filter.Juez_Vocal + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Proceso_Penal.Juez_Vocal LIKE '%" + filter.Juez_Vocal + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Audiencia_de_Juicio) || !string.IsNullOrEmpty(filter.ToFecha_de_Audiencia_de_Juicio))
            {
                var Fecha_de_Audiencia_de_JuicioFrom = DateTime.ParseExact(filter.FromFecha_de_Audiencia_de_Juicio, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_Audiencia_de_JuicioTo = DateTime.ParseExact(filter.ToFecha_de_Audiencia_de_Juicio, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Audiencia_de_Juicio))
                    where += " AND Proceso_Penal.Fecha_de_Audiencia_de_Juicio >= '" + Fecha_de_Audiencia_de_JuicioFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Audiencia_de_Juicio))
                    where += " AND Proceso_Penal.Fecha_de_Audiencia_de_Juicio <= '" + Fecha_de_Audiencia_de_JuicioTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Audiencia_de_Juicio) || !string.IsNullOrEmpty(filter.ToHora_de_Audiencia_de_Juicio))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Audiencia_de_Juicio))
                    where += " AND Convert(TIME,Proceso_Penal.Hora_de_Audiencia_de_Juicio) >='" + filter.FromHora_de_Audiencia_de_Juicio + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Audiencia_de_Juicio))
                    where += " AND Convert(TIME,Proceso_Penal.Hora_de_Audiencia_de_Juicio) <='" + filter.ToHora_de_Audiencia_de_Juicio + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceFallo_del_Tribunal))
            {
                switch (filter.Fallo_del_TribunalFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Sentencia.Descripcion LIKE '" + filter.AdvanceFallo_del_Tribunal + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Sentencia.Descripcion LIKE '%" + filter.AdvanceFallo_del_Tribunal + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Sentencia.Descripcion = '" + filter.AdvanceFallo_del_Tribunal + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Sentencia.Descripcion LIKE '%" + filter.AdvanceFallo_del_Tribunal + "%'";
                        break;
                }
            }
            else if (filter.AdvanceFallo_del_TribunalMultiple != null && filter.AdvanceFallo_del_TribunalMultiple.Count() > 0)
            {
                var Fallo_del_TribunalIds = string.Join(",", filter.AdvanceFallo_del_TribunalMultiple);

                where += " AND Proceso_Penal.Fallo_del_Tribunal In (" + Fallo_del_TribunalIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.pruebas_a_desahogar))
            {
                switch (filter.pruebas_a_desahogarFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Proceso_Penal.pruebas_a_desahogar LIKE '" + filter.pruebas_a_desahogar + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Proceso_Penal.pruebas_a_desahogar LIKE '%" + filter.pruebas_a_desahogar + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Proceso_Penal.pruebas_a_desahogar = '" + filter.pruebas_a_desahogar + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Proceso_Penal.pruebas_a_desahogar LIKE '%" + filter.pruebas_a_desahogar + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceResolucion))
            {
                switch (filter.ResolucionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Resolucion.Descripcion LIKE '" + filter.AdvanceResolucion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Resolucion.Descripcion LIKE '%" + filter.AdvanceResolucion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Resolucion.Descripcion = '" + filter.AdvanceResolucion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Resolucion.Descripcion LIKE '%" + filter.AdvanceResolucion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceResolucionMultiple != null && filter.AdvanceResolucionMultiple.Count() > 0)
            {
                var ResolucionIds = string.Join(",", filter.AdvanceResolucionMultiple);

                where += " AND Proceso_Penal.Resolucion In (" + ResolucionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromPlazo_meses) || !string.IsNullOrEmpty(filter.ToPlazo_meses))
            {
                if (!string.IsNullOrEmpty(filter.FromPlazo_meses))
                    where += " AND Proceso_Penal.Plazo_meses >= " + filter.FromPlazo_meses;
                if (!string.IsNullOrEmpty(filter.ToPlazo_meses))
                    where += " AND Proceso_Penal.Plazo_meses <= " + filter.ToPlazo_meses;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Sentencia))
            {
                switch (filter.Tipo_de_SentenciaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Sentencia.Descripcion LIKE '" + filter.AdvanceTipo_de_Sentencia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Sentencia.Descripcion LIKE '%" + filter.AdvanceTipo_de_Sentencia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Sentencia.Descripcion = '" + filter.AdvanceTipo_de_Sentencia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Sentencia.Descripcion LIKE '%" + filter.AdvanceTipo_de_Sentencia + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_SentenciaMultiple != null && filter.AdvanceTipo_de_SentenciaMultiple.Count() > 0)
            {
                var Tipo_de_SentenciaIds = string.Join(",", filter.AdvanceTipo_de_SentenciaMultiple);

                where += " AND Proceso_Penal.Tipo_de_Sentencia In (" + Tipo_de_SentenciaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Fromcuantia_de_pena_anios) || !string.IsNullOrEmpty(filter.Tocuantia_de_pena_anios))
            {
                if (!string.IsNullOrEmpty(filter.Fromcuantia_de_pena_anios))
                    where += " AND Proceso_Penal.cuantia_de_pena_anios >= " + filter.Fromcuantia_de_pena_anios;
                if (!string.IsNullOrEmpty(filter.Tocuantia_de_pena_anios))
                    where += " AND Proceso_Penal.cuantia_de_pena_anios <= " + filter.Tocuantia_de_pena_anios;
            }

            if (!string.IsNullOrEmpty(filter.Fromcuantia_de_pena_meses) || !string.IsNullOrEmpty(filter.Tocuantia_de_pena_meses))
            {
                if (!string.IsNullOrEmpty(filter.Fromcuantia_de_pena_meses))
                    where += " AND Proceso_Penal.cuantia_de_pena_meses >= " + filter.Fromcuantia_de_pena_meses;
                if (!string.IsNullOrEmpty(filter.Tocuantia_de_pena_meses))
                    where += " AND Proceso_Penal.cuantia_de_pena_meses <= " + filter.Tocuantia_de_pena_meses;
            }

            if (!string.IsNullOrEmpty(filter.FromMonto_de_la_Reparacion_del_Dano) || !string.IsNullOrEmpty(filter.ToMonto_de_la_Reparacion_del_Dano))
            {
                if (!string.IsNullOrEmpty(filter.FromMonto_de_la_Reparacion_del_Dano))
                    where += " AND Proceso_Penal.Monto_de_la_Reparacion_del_Dano >= " + filter.FromMonto_de_la_Reparacion_del_Dano;
                if (!string.IsNullOrEmpty(filter.ToMonto_de_la_Reparacion_del_Dano))
                    where += " AND Proceso_Penal.Monto_de_la_Reparacion_del_Dano <= " + filter.ToMonto_de_la_Reparacion_del_Dano;
            }


            where = new Regex(Regex.Escape("AND ")).Replace(where, "", 1);
            return where;
        }

        [NonAction]
        public Grid_File ConvertSpartane_FileToGridFile(Spartane.Core.Domain.Spartane_File.Spartane_File file)
        {
            return file == null ? new Grid_File { FileId = 0, FileSize = 0, FileName = "" } : new Grid_File { FileId = file.File_Id, FileName = file.Description, FileSize = file.File_Size ?? 0, };
        }

        public ActionResult GetDetalle_Delitos_Proceso_Penal(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_Delitos_Proceso_PenalGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Delitos_Proceso_PenalApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_Delitos_Proceso_Penal.Proceso_Penal=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_Delitos_Proceso_Penal.Proceso_Penal='" + RelationId + "'";
            }
            var result = _IDetalle_Delitos_Proceso_PenalApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_Delitos_Proceso_Penals == null)
                result.Detalle_Delitos_Proceso_Penals = new List<Detalle_Delitos_Proceso_Penal>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_Delitos_Proceso_Penals.Select(m => new Detalle_Delitos_Proceso_PenalGridModel
                {
                    Clave = m.Clave

                        ,Delito = m.Delito
                        ,DelitoDescripcion = CultureHelper.GetTraduction(m.Delito_Delito.Clave.ToString(), "Descripcion") ??(string)m.Delito_Delito.Descripcion

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_Delitos_Proceso_PenalGridModel> GetDetalle_Delitos_Proceso_PenalData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_Delitos_Proceso_PenalGridModel> resultData = new List<Detalle_Delitos_Proceso_PenalGridModel>();
            string where = "Detalle_Delitos_Proceso_Penal.Proceso_Penal=" + Id;
            if("int" == "string")
            {
                where = "Detalle_Delitos_Proceso_Penal.Proceso_Penal='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Delitos_Proceso_PenalApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_Delitos_Proceso_PenalApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_Delitos_Proceso_Penals != null)
            {
                resultData = result.Detalle_Delitos_Proceso_Penals.Select(m => new Detalle_Delitos_Proceso_PenalGridModel
                    {
                        Clave = m.Clave

                        ,Delito = m.Delito
                        ,DelitoDescripcion = CultureHelper.GetTraduction(m.Delito_Delito.Clave.ToString(), "Descripcion") ??(string)m.Delito_Delito.Descripcion


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_Medidas_Cautelares_Proceso_Penal(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_Medidas_Cautelares_Proceso_PenalGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Medidas_Cautelares_Proceso_PenalApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_Medidas_Cautelares_Proceso_Penal.Proceso_Penal=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_Medidas_Cautelares_Proceso_Penal.Proceso_Penal='" + RelationId + "'";
            }
            var result = _IDetalle_Medidas_Cautelares_Proceso_PenalApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_Medidas_Cautelares_Proceso_Penals == null)
                result.Detalle_Medidas_Cautelares_Proceso_Penals = new List<Detalle_Medidas_Cautelares_Proceso_Penal>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_Medidas_Cautelares_Proceso_Penals.Select(m => new Detalle_Medidas_Cautelares_Proceso_PenalGridModel
                {
                    Clave = m.Clave

                        ,Medida_Cautelar = m.Medida_Cautelar
                        ,Medida_CautelarDescripcion = CultureHelper.GetTraduction(m.Medida_Cautelar_Medidas_Cautelares.Clave.ToString(), "Descripcion") ??(string)m.Medida_Cautelar_Medidas_Cautelares.Descripcion

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_Medidas_Cautelares_Proceso_PenalGridModel> GetDetalle_Medidas_Cautelares_Proceso_PenalData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_Medidas_Cautelares_Proceso_PenalGridModel> resultData = new List<Detalle_Medidas_Cautelares_Proceso_PenalGridModel>();
            string where = "Detalle_Medidas_Cautelares_Proceso_Penal.Proceso_Penal=" + Id;
            if("int" == "string")
            {
                where = "Detalle_Medidas_Cautelares_Proceso_Penal.Proceso_Penal='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Medidas_Cautelares_Proceso_PenalApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_Medidas_Cautelares_Proceso_PenalApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_Medidas_Cautelares_Proceso_Penals != null)
            {
                resultData = result.Detalle_Medidas_Cautelares_Proceso_Penals.Select(m => new Detalle_Medidas_Cautelares_Proceso_PenalGridModel
                    {
                        Clave = m.Clave

                        ,Medida_Cautelar = m.Medida_Cautelar
                        ,Medida_CautelarDescripcion = CultureHelper.GetTraduction(m.Medida_Cautelar_Medidas_Cautelares.Clave.ToString(), "Descripcion") ??(string)m.Medida_Cautelar_Medidas_Cautelares.Descripcion


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_Medios_Prueba_Imputado(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_Medios_Prueba_ImputadoGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Medios_Prueba_ImputadoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_Medios_Prueba_Imputado.Proceso_Penal=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_Medios_Prueba_Imputado.Proceso_Penal='" + RelationId + "'";
            }
            var result = _IDetalle_Medios_Prueba_ImputadoApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_Medios_Prueba_Imputados == null)
                result.Detalle_Medios_Prueba_Imputados = new List<Detalle_Medios_Prueba_Imputado>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_Medios_Prueba_Imputados.Select(m => new Detalle_Medios_Prueba_ImputadoGridModel
                {
                    Clave = m.Clave

			,Medio_de_Prueba_Presentado = m.Medio_de_Prueba_Presentado
			,Fecha_de_Presentacion = (m.Fecha_de_Presentacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Presentacion).ToString(ConfigurationProperty.DateFormat))
			,Archivo_AdjuntoFileInfo = m.Archivo_Adjunto > 0 ? (ConvertSpartane_FileToGridFile(_ISpartane_FileApiConsumer.GetByKey(m.Archivo_Adjunto).Resource)) : new Grid_File { FileId = 0, FileSize = 0, FileName = "" }

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_Medios_Prueba_ImputadoGridModel> GetDetalle_Medios_Prueba_ImputadoData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_Medios_Prueba_ImputadoGridModel> resultData = new List<Detalle_Medios_Prueba_ImputadoGridModel>();
            string where = "Detalle_Medios_Prueba_Imputado.Proceso_Penal=" + Id;
            if("int" == "string")
            {
                where = "Detalle_Medios_Prueba_Imputado.Proceso_Penal='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Medios_Prueba_ImputadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_Medios_Prueba_ImputadoApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_Medios_Prueba_Imputados != null)
            {
                resultData = result.Detalle_Medios_Prueba_Imputados.Select(m => new Detalle_Medios_Prueba_ImputadoGridModel
                    {
                        Clave = m.Clave

			,Medio_de_Prueba_Presentado = m.Medio_de_Prueba_Presentado
			,Fecha_de_Presentacion = (m.Fecha_de_Presentacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Presentacion).ToString(ConfigurationProperty.DateFormat))
			,Archivo_AdjuntoFileInfo = m.Archivo_Adjunto > 0 ? (ConvertSpartane_FileToGridFile(_ISpartane_FileApiConsumer.GetByKey(m.Archivo_Adjunto).Resource)) : new Grid_File { FileId = 0, FileSize = 0, FileName = "" }


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_Medios_Prueba_Victima(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_Medios_Prueba_VictimaGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Medios_Prueba_VictimaApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_Medios_Prueba_Victima.Proceso_Penal=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_Medios_Prueba_Victima.Proceso_Penal='" + RelationId + "'";
            }
            var result = _IDetalle_Medios_Prueba_VictimaApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_Medios_Prueba_Victimas == null)
                result.Detalle_Medios_Prueba_Victimas = new List<Detalle_Medios_Prueba_Victima>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_Medios_Prueba_Victimas.Select(m => new Detalle_Medios_Prueba_VictimaGridModel
                {
                    Clave = m.Clave

			,Medio_de_Prueba_Presentado = m.Medio_de_Prueba_Presentado
			,Fecha_de_Presentacion = (m.Fecha_de_Presentacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Presentacion).ToString(ConfigurationProperty.DateFormat))
			,Archivo_AdjuntoFileInfo = m.Archivo_Adjunto > 0 ? (ConvertSpartane_FileToGridFile(_ISpartane_FileApiConsumer.GetByKey(m.Archivo_Adjunto).Resource)) : new Grid_File { FileId = 0, FileSize = 0, FileName = "" }

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_Medios_Prueba_VictimaGridModel> GetDetalle_Medios_Prueba_VictimaData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_Medios_Prueba_VictimaGridModel> resultData = new List<Detalle_Medios_Prueba_VictimaGridModel>();
            string where = "Detalle_Medios_Prueba_Victima.Proceso_Penal=" + Id;
            if("int" == "string")
            {
                where = "Detalle_Medios_Prueba_Victima.Proceso_Penal='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Medios_Prueba_VictimaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_Medios_Prueba_VictimaApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_Medios_Prueba_Victimas != null)
            {
                resultData = result.Detalle_Medios_Prueba_Victimas.Select(m => new Detalle_Medios_Prueba_VictimaGridModel
                    {
                        Clave = m.Clave

			,Medio_de_Prueba_Presentado = m.Medio_de_Prueba_Presentado
			,Fecha_de_Presentacion = (m.Fecha_de_Presentacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Presentacion).ToString(ConfigurationProperty.DateFormat))
			,Archivo_AdjuntoFileInfo = m.Archivo_Adjunto > 0 ? (ConvertSpartane_FileToGridFile(_ISpartane_FileApiConsumer.GetByKey(m.Archivo_Adjunto).Resource)) : new Grid_File { FileId = 0, FileSize = 0, FileName = "" }


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_Medios_Prueba_Admitidos(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_Medios_Prueba_AdmitidosGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Medios_Prueba_AdmitidosApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_Medios_Prueba_Admitidos.Proceso_Penal=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_Medios_Prueba_Admitidos.Proceso_Penal='" + RelationId + "'";
            }
            var result = _IDetalle_Medios_Prueba_AdmitidosApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_Medios_Prueba_Admitidoss == null)
                result.Detalle_Medios_Prueba_Admitidoss = new List<Detalle_Medios_Prueba_Admitidos>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_Medios_Prueba_Admitidoss.Select(m => new Detalle_Medios_Prueba_AdmitidosGridModel
                {
                    Clave = m.Clave

			,Origen = m.Origen
			,Medio_de_Prueba_Presentado = m.Medio_de_Prueba_Presentado
			,Admitido = m.Admitido

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_Medios_Prueba_AdmitidosGridModel> GetDetalle_Medios_Prueba_AdmitidosData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_Medios_Prueba_AdmitidosGridModel> resultData = new List<Detalle_Medios_Prueba_AdmitidosGridModel>();
            string where = "Detalle_Medios_Prueba_Admitidos.Proceso_Penal=" + Id;
            if("int" == "string")
            {
                where = "Detalle_Medios_Prueba_Admitidos.Proceso_Penal='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Medios_Prueba_AdmitidosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_Medios_Prueba_AdmitidosApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_Medios_Prueba_Admitidoss != null)
            {
                resultData = result.Detalle_Medios_Prueba_Admitidoss.Select(m => new Detalle_Medios_Prueba_AdmitidosGridModel
                    {
                        Clave = m.Clave

			,Origen = m.Origen
			,Medio_de_Prueba_Presentado = m.Medio_de_Prueba_Presentado
			,Admitido = m.Admitido


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_Condiciones_Proceso_Penal(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_Condiciones_Proceso_PenalGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Condiciones_Proceso_PenalApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_Condiciones_Proceso_Penal.Proceso_Penal=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_Condiciones_Proceso_Penal.Proceso_Penal='" + RelationId + "'";
            }
            var result = _IDetalle_Condiciones_Proceso_PenalApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_Condiciones_Proceso_Penals == null)
                result.Detalle_Condiciones_Proceso_Penals = new List<Detalle_Condiciones_Proceso_Penal>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_Condiciones_Proceso_Penals.Select(m => new Detalle_Condiciones_Proceso_PenalGridModel
                {
                    Clave = m.Clave

                        ,Medida_Cautelar = m.Medida_Cautelar
                        ,Medida_CautelarDescripcion = CultureHelper.GetTraduction(m.Medida_Cautelar_Condiciones_en_Suspension_Condicional.Clave.ToString(), "Descripcion") ??(string)m.Medida_Cautelar_Condiciones_en_Suspension_Condicional.Descripcion

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_Condiciones_Proceso_PenalGridModel> GetDetalle_Condiciones_Proceso_PenalData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_Condiciones_Proceso_PenalGridModel> resultData = new List<Detalle_Condiciones_Proceso_PenalGridModel>();
            string where = "Detalle_Condiciones_Proceso_Penal.Proceso_Penal=" + Id;
            if("int" == "string")
            {
                where = "Detalle_Condiciones_Proceso_Penal.Proceso_Penal='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Condiciones_Proceso_PenalApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_Condiciones_Proceso_PenalApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_Condiciones_Proceso_Penals != null)
            {
                resultData = result.Detalle_Condiciones_Proceso_Penals.Select(m => new Detalle_Condiciones_Proceso_PenalGridModel
                    {
                        Clave = m.Clave

                        ,Medida_Cautelar = m.Medida_Cautelar
                        ,Medida_CautelarDescripcion = CultureHelper.GetTraduction(m.Medida_Cautelar_Condiciones_en_Suspension_Condicional.Clave.ToString(), "Descripcion") ??(string)m.Medida_Cautelar_Condiciones_en_Suspension_Condicional.Descripcion


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
                _IProceso_PenalApiConsumer.SetAuthHeader(_tokenManager.Token);

                Proceso_Penal varProceso_Penal = null;
                if (id.ToString() != "0")
                {
                        string where = "";
                    _IDetalle_Delitos_Proceso_PenalApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_Delitos_Proceso_Penal.Proceso_Penal=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_Delitos_Proceso_Penal.Proceso_Penal='" + id + "'";
                    }
                    var Detalle_Delitos_Proceso_PenalInfo =
                        _IDetalle_Delitos_Proceso_PenalApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_Delitos_Proceso_PenalInfo.Detalle_Delitos_Proceso_Penals.Count > 0)
                    {
                        var resultDetalle_Delitos_Proceso_Penal = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_Delitos_Proceso_PenalItem in Detalle_Delitos_Proceso_PenalInfo.Detalle_Delitos_Proceso_Penals)
                            resultDetalle_Delitos_Proceso_Penal = resultDetalle_Delitos_Proceso_Penal
                                              && _IDetalle_Delitos_Proceso_PenalApiConsumer.Delete(Detalle_Delitos_Proceso_PenalItem.Clave, null,null).Resource;

                        if (!resultDetalle_Delitos_Proceso_Penal)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_Medidas_Cautelares_Proceso_PenalApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_Medidas_Cautelares_Proceso_Penal.Proceso_Penal=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_Medidas_Cautelares_Proceso_Penal.Proceso_Penal='" + id + "'";
                    }
                    var Detalle_Medidas_Cautelares_Proceso_PenalInfo =
                        _IDetalle_Medidas_Cautelares_Proceso_PenalApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_Medidas_Cautelares_Proceso_PenalInfo.Detalle_Medidas_Cautelares_Proceso_Penals.Count > 0)
                    {
                        var resultDetalle_Medidas_Cautelares_Proceso_Penal = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_Medidas_Cautelares_Proceso_PenalItem in Detalle_Medidas_Cautelares_Proceso_PenalInfo.Detalle_Medidas_Cautelares_Proceso_Penals)
                            resultDetalle_Medidas_Cautelares_Proceso_Penal = resultDetalle_Medidas_Cautelares_Proceso_Penal
                                              && _IDetalle_Medidas_Cautelares_Proceso_PenalApiConsumer.Delete(Detalle_Medidas_Cautelares_Proceso_PenalItem.Clave, null,null).Resource;

                        if (!resultDetalle_Medidas_Cautelares_Proceso_Penal)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_Medios_Prueba_ImputadoApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_Medios_Prueba_Imputado.Proceso_Penal=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_Medios_Prueba_Imputado.Proceso_Penal='" + id + "'";
                    }
                    var Detalle_Medios_Prueba_ImputadoInfo =
                        _IDetalle_Medios_Prueba_ImputadoApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_Medios_Prueba_ImputadoInfo.Detalle_Medios_Prueba_Imputados.Count > 0)
                    {
                        var resultDetalle_Medios_Prueba_Imputado = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_Medios_Prueba_ImputadoItem in Detalle_Medios_Prueba_ImputadoInfo.Detalle_Medios_Prueba_Imputados)
                            resultDetalle_Medios_Prueba_Imputado = resultDetalle_Medios_Prueba_Imputado
                                              && _IDetalle_Medios_Prueba_ImputadoApiConsumer.Delete(Detalle_Medios_Prueba_ImputadoItem.Clave, null,null).Resource;

                        if (!resultDetalle_Medios_Prueba_Imputado)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_Medios_Prueba_VictimaApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_Medios_Prueba_Victima.Proceso_Penal=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_Medios_Prueba_Victima.Proceso_Penal='" + id + "'";
                    }
                    var Detalle_Medios_Prueba_VictimaInfo =
                        _IDetalle_Medios_Prueba_VictimaApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_Medios_Prueba_VictimaInfo.Detalle_Medios_Prueba_Victimas.Count > 0)
                    {
                        var resultDetalle_Medios_Prueba_Victima = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_Medios_Prueba_VictimaItem in Detalle_Medios_Prueba_VictimaInfo.Detalle_Medios_Prueba_Victimas)
                            resultDetalle_Medios_Prueba_Victima = resultDetalle_Medios_Prueba_Victima
                                              && _IDetalle_Medios_Prueba_VictimaApiConsumer.Delete(Detalle_Medios_Prueba_VictimaItem.Clave, null,null).Resource;

                        if (!resultDetalle_Medios_Prueba_Victima)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_Medios_Prueba_AdmitidosApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_Medios_Prueba_Admitidos.Proceso_Penal=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_Medios_Prueba_Admitidos.Proceso_Penal='" + id + "'";
                    }
                    var Detalle_Medios_Prueba_AdmitidosInfo =
                        _IDetalle_Medios_Prueba_AdmitidosApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_Medios_Prueba_AdmitidosInfo.Detalle_Medios_Prueba_Admitidoss.Count > 0)
                    {
                        var resultDetalle_Medios_Prueba_Admitidos = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_Medios_Prueba_AdmitidosItem in Detalle_Medios_Prueba_AdmitidosInfo.Detalle_Medios_Prueba_Admitidoss)
                            resultDetalle_Medios_Prueba_Admitidos = resultDetalle_Medios_Prueba_Admitidos
                                              && _IDetalle_Medios_Prueba_AdmitidosApiConsumer.Delete(Detalle_Medios_Prueba_AdmitidosItem.Clave, null,null).Resource;

                        if (!resultDetalle_Medios_Prueba_Admitidos)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_Condiciones_Proceso_PenalApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_Condiciones_Proceso_Penal.Proceso_Penal=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_Condiciones_Proceso_Penal.Proceso_Penal='" + id + "'";
                    }
                    var Detalle_Condiciones_Proceso_PenalInfo =
                        _IDetalle_Condiciones_Proceso_PenalApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_Condiciones_Proceso_PenalInfo.Detalle_Condiciones_Proceso_Penals.Count > 0)
                    {
                        var resultDetalle_Condiciones_Proceso_Penal = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_Condiciones_Proceso_PenalItem in Detalle_Condiciones_Proceso_PenalInfo.Detalle_Condiciones_Proceso_Penals)
                            resultDetalle_Condiciones_Proceso_Penal = resultDetalle_Condiciones_Proceso_Penal
                                              && _IDetalle_Condiciones_Proceso_PenalApiConsumer.Delete(Detalle_Condiciones_Proceso_PenalItem.Clave, null,null).Resource;

                        if (!resultDetalle_Condiciones_Proceso_Penal)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }

                }
                var result = _IProceso_PenalApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Proceso_PenalModel varProceso_Penal)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IProceso_PenalApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Proceso_PenalInfo = new Proceso_Penal
                    {
                        Folio = varProceso_Penal.Folio
                        ,Expediente_MP = varProceso_Penal.Expediente_MP
                        ,Fecha_de_Registro = (!String.IsNullOrEmpty(varProceso_Penal.Fecha_de_Registro)) ? DateTime.ParseExact(varProceso_Penal.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Registro = varProceso_Penal.Hora_de_Registro
                        ,Usuario_que_Registra = varProceso_Penal.Usuario_que_Registra
                        ,Imputado = varProceso_Penal.Imputado
                        ,Reclasificacion_Juridica = varProceso_Penal.Reclasificacion_Juridica
                        ,Plazo_Constitucional = varProceso_Penal.Plazo_Constitucional
                        ,Vinculacion = varProceso_Penal.Vinculacion
                        ,Resultado_No_Vinculacion = varProceso_Penal.Resultado_No_Vinculacion
                        ,Resultado_Vinculacion = varProceso_Penal.Resultado_Vinculacion
                        ,plazo_investigacion_complementaria = varProceso_Penal.plazo_investigacion_complementaria
                        ,fecha_investigacion_complementaria = varProceso_Penal.fecha_investigacion_complementaria
                        ,hora_investigacion_complementaria = varProceso_Penal.hora_investigacion_complementaria
                        ,Nombre_del_Juez_de_Control = varProceso_Penal.Nombre_del_Juez_de_Control
                        ,Fecha_de_Entrega_de_Escrito_de_Acusacion = (!String.IsNullOrEmpty(varProceso_Penal.Fecha_de_Entrega_de_Escrito_de_Acusacion)) ? DateTime.ParseExact(varProceso_Penal.Fecha_de_Entrega_de_Escrito_de_Acusacion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Entrega_de_Escrito_de_Acusacion = varProceso_Penal.Hora_de_Entrega_de_Escrito_de_Acusacion
                        ,Fecha_de_Audiencia_Intermedia = (!String.IsNullOrEmpty(varProceso_Penal.Fecha_de_Audiencia_Intermedia)) ? DateTime.ParseExact(varProceso_Penal.Fecha_de_Audiencia_Intermedia, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Audiencia_Intermedia = varProceso_Penal.Hora_de_Audiencia_Intermedia
                        ,Acusador_Coadyudante = varProceso_Penal.Acusador_Coadyudante
                        ,cumplio_descubrimiento_probatorio = varProceso_Penal.cumplio_descubrimiento_probatorio
                        ,Fecha = (!String.IsNullOrEmpty(varProceso_Penal.Fecha)) ? DateTime.ParseExact(varProceso_Penal.Fecha, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora = varProceso_Penal.Hora
                        ,Acuerdos_Probatorios = varProceso_Penal.Acuerdos_Probatorios
                        ,acuerdos_probatorios_cuales_fueron = varProceso_Penal.acuerdos_probatorios_cuales_fueron
                        ,Resultado = varProceso_Penal.Resultado
                        ,Tribunal_de_Enjuiciamiento = varProceso_Penal.Tribunal_de_Enjuiciamiento
                        ,Nombre_del_Juez = varProceso_Penal.Nombre_del_Juez
                        ,Juez_Colegiado = varProceso_Penal.Juez_Colegiado
                        ,Juez_Relator = varProceso_Penal.Juez_Relator
                        ,Juez_Vocal = varProceso_Penal.Juez_Vocal
                        ,Fecha_de_Audiencia_de_Juicio = (!String.IsNullOrEmpty(varProceso_Penal.Fecha_de_Audiencia_de_Juicio)) ? DateTime.ParseExact(varProceso_Penal.Fecha_de_Audiencia_de_Juicio, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Audiencia_de_Juicio = varProceso_Penal.Hora_de_Audiencia_de_Juicio
                        ,Fallo_del_Tribunal = varProceso_Penal.Fallo_del_Tribunal
                        ,pruebas_a_desahogar = varProceso_Penal.pruebas_a_desahogar
                        ,Resolucion = varProceso_Penal.Resolucion
                        ,Plazo_meses = varProceso_Penal.Plazo_meses
                        ,Tipo_de_Sentencia = varProceso_Penal.Tipo_de_Sentencia
                        ,cuantia_de_pena_anios = varProceso_Penal.cuantia_de_pena_anios
                        ,cuantia_de_pena_meses = varProceso_Penal.cuantia_de_pena_meses
                        ,Monto_de_la_Reparacion_del_Dano = varProceso_Penal.Monto_de_la_Reparacion_del_Dano

                    };

                    result = !IsNew ?
                        _IProceso_PenalApiConsumer.Update(Proceso_PenalInfo, null, null).Resource.ToString() :
                         _IProceso_PenalApiConsumer.Insert(Proceso_PenalInfo, null, null).Resource.ToString();
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
        public bool CopyDetalle_Delitos_Proceso_Penal(int MasterId, int referenceId, List<Detalle_Delitos_Proceso_PenalGridModelPost> Detalle_Delitos_Proceso_PenalItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_Delitos_Proceso_PenalApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_Delitos_Proceso_PenalData = _IDetalle_Delitos_Proceso_PenalApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_Delitos_Proceso_Penal.Proceso_Penal=" + referenceId,"").Resource;
                if (Detalle_Delitos_Proceso_PenalData == null || Detalle_Delitos_Proceso_PenalData.Detalle_Delitos_Proceso_Penals.Count == 0)
                    return true;

                var result = true;

                Detalle_Delitos_Proceso_PenalGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_Delitos_Proceso_Penal in Detalle_Delitos_Proceso_PenalData.Detalle_Delitos_Proceso_Penals)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_Delitos_Proceso_Penal Detalle_Delitos_Proceso_Penal1 = varDetalle_Delitos_Proceso_Penal;

                    if (Detalle_Delitos_Proceso_PenalItems != null && Detalle_Delitos_Proceso_PenalItems.Any(m => m.Clave == Detalle_Delitos_Proceso_Penal1.Clave))
                    {
                        modelDataToChange = Detalle_Delitos_Proceso_PenalItems.FirstOrDefault(m => m.Clave == Detalle_Delitos_Proceso_Penal1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_Delitos_Proceso_Penal.Proceso_Penal = MasterId;
                    var insertId = _IDetalle_Delitos_Proceso_PenalApiConsumer.Insert(varDetalle_Delitos_Proceso_Penal,null,null).Resource;
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
        public ActionResult PostDetalle_Delitos_Proceso_Penal(List<Detalle_Delitos_Proceso_PenalGridModelPost> Detalle_Delitos_Proceso_PenalItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_Delitos_Proceso_Penal(MasterId, referenceId, Detalle_Delitos_Proceso_PenalItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_Delitos_Proceso_PenalItems != null && Detalle_Delitos_Proceso_PenalItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_Delitos_Proceso_PenalApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_Delitos_Proceso_PenalItem in Detalle_Delitos_Proceso_PenalItems)
                    {



                        //Removal Request
                        if (Detalle_Delitos_Proceso_PenalItem.Removed)
                        {
                            result = result && _IDetalle_Delitos_Proceso_PenalApiConsumer.Delete(Detalle_Delitos_Proceso_PenalItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_Delitos_Proceso_PenalItem.Clave = 0;

                        var Detalle_Delitos_Proceso_PenalData = new Detalle_Delitos_Proceso_Penal
                        {
                            Proceso_Penal = MasterId
                            ,Clave = Detalle_Delitos_Proceso_PenalItem.Clave
                            ,Delito = (Convert.ToInt32(Detalle_Delitos_Proceso_PenalItem.Delito) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_Delitos_Proceso_PenalItem.Delito))

                        };

                        var resultId = Detalle_Delitos_Proceso_PenalItem.Clave > 0
                           ? _IDetalle_Delitos_Proceso_PenalApiConsumer.Update(Detalle_Delitos_Proceso_PenalData,null,null).Resource
                           : _IDetalle_Delitos_Proceso_PenalApiConsumer.Insert(Detalle_Delitos_Proceso_PenalData,null,null).Resource;

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
        public ActionResult GetDetalle_Delitos_Proceso_Penal_DelitoAll()
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

        [NonAction]
        public bool CopyDetalle_Medidas_Cautelares_Proceso_Penal(int MasterId, int referenceId, List<Detalle_Medidas_Cautelares_Proceso_PenalGridModelPost> Detalle_Medidas_Cautelares_Proceso_PenalItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_Medidas_Cautelares_Proceso_PenalApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_Medidas_Cautelares_Proceso_PenalData = _IDetalle_Medidas_Cautelares_Proceso_PenalApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_Medidas_Cautelares_Proceso_Penal.Proceso_Penal=" + referenceId,"").Resource;
                if (Detalle_Medidas_Cautelares_Proceso_PenalData == null || Detalle_Medidas_Cautelares_Proceso_PenalData.Detalle_Medidas_Cautelares_Proceso_Penals.Count == 0)
                    return true;

                var result = true;

                Detalle_Medidas_Cautelares_Proceso_PenalGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_Medidas_Cautelares_Proceso_Penal in Detalle_Medidas_Cautelares_Proceso_PenalData.Detalle_Medidas_Cautelares_Proceso_Penals)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_Medidas_Cautelares_Proceso_Penal Detalle_Medidas_Cautelares_Proceso_Penal1 = varDetalle_Medidas_Cautelares_Proceso_Penal;

                    if (Detalle_Medidas_Cautelares_Proceso_PenalItems != null && Detalle_Medidas_Cautelares_Proceso_PenalItems.Any(m => m.Clave == Detalle_Medidas_Cautelares_Proceso_Penal1.Clave))
                    {
                        modelDataToChange = Detalle_Medidas_Cautelares_Proceso_PenalItems.FirstOrDefault(m => m.Clave == Detalle_Medidas_Cautelares_Proceso_Penal1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_Medidas_Cautelares_Proceso_Penal.Proceso_Penal = MasterId;
                    var insertId = _IDetalle_Medidas_Cautelares_Proceso_PenalApiConsumer.Insert(varDetalle_Medidas_Cautelares_Proceso_Penal,null,null).Resource;
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
        public ActionResult PostDetalle_Medidas_Cautelares_Proceso_Penal(List<Detalle_Medidas_Cautelares_Proceso_PenalGridModelPost> Detalle_Medidas_Cautelares_Proceso_PenalItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_Medidas_Cautelares_Proceso_Penal(MasterId, referenceId, Detalle_Medidas_Cautelares_Proceso_PenalItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_Medidas_Cautelares_Proceso_PenalItems != null && Detalle_Medidas_Cautelares_Proceso_PenalItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_Medidas_Cautelares_Proceso_PenalApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_Medidas_Cautelares_Proceso_PenalItem in Detalle_Medidas_Cautelares_Proceso_PenalItems)
                    {



                        //Removal Request
                        if (Detalle_Medidas_Cautelares_Proceso_PenalItem.Removed)
                        {
                            result = result && _IDetalle_Medidas_Cautelares_Proceso_PenalApiConsumer.Delete(Detalle_Medidas_Cautelares_Proceso_PenalItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_Medidas_Cautelares_Proceso_PenalItem.Clave = 0;

                        var Detalle_Medidas_Cautelares_Proceso_PenalData = new Detalle_Medidas_Cautelares_Proceso_Penal
                        {
                            Proceso_Penal = MasterId
                            ,Clave = Detalle_Medidas_Cautelares_Proceso_PenalItem.Clave
                            ,Medida_Cautelar = (Convert.ToInt32(Detalle_Medidas_Cautelares_Proceso_PenalItem.Medida_Cautelar) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_Medidas_Cautelares_Proceso_PenalItem.Medida_Cautelar))

                        };

                        var resultId = Detalle_Medidas_Cautelares_Proceso_PenalItem.Clave > 0
                           ? _IDetalle_Medidas_Cautelares_Proceso_PenalApiConsumer.Update(Detalle_Medidas_Cautelares_Proceso_PenalData,null,null).Resource
                           : _IDetalle_Medidas_Cautelares_Proceso_PenalApiConsumer.Insert(Detalle_Medidas_Cautelares_Proceso_PenalData,null,null).Resource;

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
        public ActionResult GetDetalle_Medidas_Cautelares_Proceso_Penal_Medidas_CautelaresAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMedidas_CautelaresApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IMedidas_CautelaresApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Medidas_Cautelares", "Descripcion");
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
        public bool CopyDetalle_Medios_Prueba_Imputado(int MasterId, int referenceId, List<Detalle_Medios_Prueba_ImputadoGridModelPost> Detalle_Medios_Prueba_ImputadoItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_Medios_Prueba_ImputadoApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_Medios_Prueba_ImputadoData = _IDetalle_Medios_Prueba_ImputadoApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_Medios_Prueba_Imputado.Proceso_Penal=" + referenceId,"").Resource;
                if (Detalle_Medios_Prueba_ImputadoData == null || Detalle_Medios_Prueba_ImputadoData.Detalle_Medios_Prueba_Imputados.Count == 0)
                    return true;

                var result = true;

                Detalle_Medios_Prueba_ImputadoGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_Medios_Prueba_Imputado in Detalle_Medios_Prueba_ImputadoData.Detalle_Medios_Prueba_Imputados)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_Medios_Prueba_Imputado Detalle_Medios_Prueba_Imputado1 = varDetalle_Medios_Prueba_Imputado;

                    if (Detalle_Medios_Prueba_ImputadoItems != null && Detalle_Medios_Prueba_ImputadoItems.Any(m => m.Clave == Detalle_Medios_Prueba_Imputado1.Clave))
                    {
                        modelDataToChange = Detalle_Medios_Prueba_ImputadoItems.FirstOrDefault(m => m.Clave == Detalle_Medios_Prueba_Imputado1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_Medios_Prueba_Imputado.Proceso_Penal = MasterId;
                    var insertId = _IDetalle_Medios_Prueba_ImputadoApiConsumer.Insert(varDetalle_Medios_Prueba_Imputado,null,null).Resource;
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
        public ActionResult PostDetalle_Medios_Prueba_Imputado(List<Detalle_Medios_Prueba_ImputadoGridModelPost> Detalle_Medios_Prueba_ImputadoItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_Medios_Prueba_Imputado(MasterId, referenceId, Detalle_Medios_Prueba_ImputadoItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_Medios_Prueba_ImputadoItems != null && Detalle_Medios_Prueba_ImputadoItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_Medios_Prueba_ImputadoApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_Medios_Prueba_ImputadoItem in Detalle_Medios_Prueba_ImputadoItems)
                    {



                        #region Archivo_AdjuntoInfo
                        //Checking if file exist if yes edit or add
                        if (Detalle_Medios_Prueba_ImputadoItem.Archivo_AdjuntoInfo.Control != null && !Detalle_Medios_Prueba_ImputadoItem.Removed)
                        {
                            var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(Detalle_Medios_Prueba_ImputadoItem.Archivo_AdjuntoInfo.Control);
                            Detalle_Medios_Prueba_ImputadoItem.Archivo_AdjuntoInfo.FileId = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                            {
                                File = fileAsBytes,
                                Description = Detalle_Medios_Prueba_ImputadoItem.Archivo_AdjuntoInfo.Control.FileName,
                                File_Size = fileAsBytes.Length
                            }).Resource;
                        }
                        else if (!Detalle_Medios_Prueba_ImputadoItem.Removed && Detalle_Medios_Prueba_ImputadoItem.Archivo_AdjuntoInfo.RemoveFile)
                        {
                            Detalle_Medios_Prueba_ImputadoItem.Archivo_AdjuntoInfo.FileId = 0;
                        }
                        #endregion Archivo_AdjuntoInfo

                        //Removal Request
                        if (Detalle_Medios_Prueba_ImputadoItem.Removed)
                        {
                            result = result && _IDetalle_Medios_Prueba_ImputadoApiConsumer.Delete(Detalle_Medios_Prueba_ImputadoItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_Medios_Prueba_ImputadoItem.Clave = 0;

                        var Detalle_Medios_Prueba_ImputadoData = new Detalle_Medios_Prueba_Imputado
                        {
                            Proceso_Penal = MasterId
                            ,Clave = Detalle_Medios_Prueba_ImputadoItem.Clave
                            ,Medio_de_Prueba_Presentado = Detalle_Medios_Prueba_ImputadoItem.Medio_de_Prueba_Presentado
                            ,Fecha_de_Presentacion = (Detalle_Medios_Prueba_ImputadoItem.Fecha_de_Presentacion!= null) ? DateTime.ParseExact(Detalle_Medios_Prueba_ImputadoItem.Fecha_de_Presentacion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                            ,Archivo_Adjunto = Detalle_Medios_Prueba_ImputadoItem.Archivo_AdjuntoInfo.FileId

                        };

                        var resultId = Detalle_Medios_Prueba_ImputadoItem.Clave > 0
                           ? _IDetalle_Medios_Prueba_ImputadoApiConsumer.Update(Detalle_Medios_Prueba_ImputadoData,null,null).Resource
                           : _IDetalle_Medios_Prueba_ImputadoApiConsumer.Insert(Detalle_Medios_Prueba_ImputadoData,null,null).Resource;

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
        public bool CopyDetalle_Medios_Prueba_Victima(int MasterId, int referenceId, List<Detalle_Medios_Prueba_VictimaGridModelPost> Detalle_Medios_Prueba_VictimaItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_Medios_Prueba_VictimaApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_Medios_Prueba_VictimaData = _IDetalle_Medios_Prueba_VictimaApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_Medios_Prueba_Victima.Proceso_Penal=" + referenceId,"").Resource;
                if (Detalle_Medios_Prueba_VictimaData == null || Detalle_Medios_Prueba_VictimaData.Detalle_Medios_Prueba_Victimas.Count == 0)
                    return true;

                var result = true;

                Detalle_Medios_Prueba_VictimaGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_Medios_Prueba_Victima in Detalle_Medios_Prueba_VictimaData.Detalle_Medios_Prueba_Victimas)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_Medios_Prueba_Victima Detalle_Medios_Prueba_Victima1 = varDetalle_Medios_Prueba_Victima;

                    if (Detalle_Medios_Prueba_VictimaItems != null && Detalle_Medios_Prueba_VictimaItems.Any(m => m.Clave == Detalle_Medios_Prueba_Victima1.Clave))
                    {
                        modelDataToChange = Detalle_Medios_Prueba_VictimaItems.FirstOrDefault(m => m.Clave == Detalle_Medios_Prueba_Victima1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_Medios_Prueba_Victima.Proceso_Penal = MasterId;
                    var insertId = _IDetalle_Medios_Prueba_VictimaApiConsumer.Insert(varDetalle_Medios_Prueba_Victima,null,null).Resource;
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
        public ActionResult PostDetalle_Medios_Prueba_Victima(List<Detalle_Medios_Prueba_VictimaGridModelPost> Detalle_Medios_Prueba_VictimaItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_Medios_Prueba_Victima(MasterId, referenceId, Detalle_Medios_Prueba_VictimaItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_Medios_Prueba_VictimaItems != null && Detalle_Medios_Prueba_VictimaItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_Medios_Prueba_VictimaApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_Medios_Prueba_VictimaItem in Detalle_Medios_Prueba_VictimaItems)
                    {



                        #region Archivo_AdjuntoInfo
                        //Checking if file exist if yes edit or add
                        if (Detalle_Medios_Prueba_VictimaItem.Archivo_AdjuntoInfo.Control != null && !Detalle_Medios_Prueba_VictimaItem.Removed)
                        {
                            var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(Detalle_Medios_Prueba_VictimaItem.Archivo_AdjuntoInfo.Control);
                            Detalle_Medios_Prueba_VictimaItem.Archivo_AdjuntoInfo.FileId = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                            {
                                File = fileAsBytes,
                                Description = Detalle_Medios_Prueba_VictimaItem.Archivo_AdjuntoInfo.Control.FileName,
                                File_Size = fileAsBytes.Length
                            }).Resource;
                        }
                        else if (!Detalle_Medios_Prueba_VictimaItem.Removed && Detalle_Medios_Prueba_VictimaItem.Archivo_AdjuntoInfo.RemoveFile)
                        {
                            Detalle_Medios_Prueba_VictimaItem.Archivo_AdjuntoInfo.FileId = 0;
                        }
                        #endregion Archivo_AdjuntoInfo

                        //Removal Request
                        if (Detalle_Medios_Prueba_VictimaItem.Removed)
                        {
                            result = result && _IDetalle_Medios_Prueba_VictimaApiConsumer.Delete(Detalle_Medios_Prueba_VictimaItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_Medios_Prueba_VictimaItem.Clave = 0;

                        var Detalle_Medios_Prueba_VictimaData = new Detalle_Medios_Prueba_Victima
                        {
                            Proceso_Penal = MasterId
                            ,Clave = Detalle_Medios_Prueba_VictimaItem.Clave
                            ,Medio_de_Prueba_Presentado = Detalle_Medios_Prueba_VictimaItem.Medio_de_Prueba_Presentado
                            ,Fecha_de_Presentacion = (Detalle_Medios_Prueba_VictimaItem.Fecha_de_Presentacion!= null) ? DateTime.ParseExact(Detalle_Medios_Prueba_VictimaItem.Fecha_de_Presentacion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                            ,Archivo_Adjunto = Detalle_Medios_Prueba_VictimaItem.Archivo_AdjuntoInfo.FileId

                        };

                        var resultId = Detalle_Medios_Prueba_VictimaItem.Clave > 0
                           ? _IDetalle_Medios_Prueba_VictimaApiConsumer.Update(Detalle_Medios_Prueba_VictimaData,null,null).Resource
                           : _IDetalle_Medios_Prueba_VictimaApiConsumer.Insert(Detalle_Medios_Prueba_VictimaData,null,null).Resource;

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
        public bool CopyDetalle_Medios_Prueba_Admitidos(int MasterId, int referenceId, List<Detalle_Medios_Prueba_AdmitidosGridModelPost> Detalle_Medios_Prueba_AdmitidosItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_Medios_Prueba_AdmitidosApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_Medios_Prueba_AdmitidosData = _IDetalle_Medios_Prueba_AdmitidosApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_Medios_Prueba_Admitidos.Proceso_Penal=" + referenceId,"").Resource;
                if (Detalle_Medios_Prueba_AdmitidosData == null || Detalle_Medios_Prueba_AdmitidosData.Detalle_Medios_Prueba_Admitidoss.Count == 0)
                    return true;

                var result = true;

                Detalle_Medios_Prueba_AdmitidosGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_Medios_Prueba_Admitidos in Detalle_Medios_Prueba_AdmitidosData.Detalle_Medios_Prueba_Admitidoss)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_Medios_Prueba_Admitidos Detalle_Medios_Prueba_Admitidos1 = varDetalle_Medios_Prueba_Admitidos;

                    if (Detalle_Medios_Prueba_AdmitidosItems != null && Detalle_Medios_Prueba_AdmitidosItems.Any(m => m.Clave == Detalle_Medios_Prueba_Admitidos1.Clave))
                    {
                        modelDataToChange = Detalle_Medios_Prueba_AdmitidosItems.FirstOrDefault(m => m.Clave == Detalle_Medios_Prueba_Admitidos1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_Medios_Prueba_Admitidos.Proceso_Penal = MasterId;
                    var insertId = _IDetalle_Medios_Prueba_AdmitidosApiConsumer.Insert(varDetalle_Medios_Prueba_Admitidos,null,null).Resource;
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
        public ActionResult PostDetalle_Medios_Prueba_Admitidos(List<Detalle_Medios_Prueba_AdmitidosGridModelPost> Detalle_Medios_Prueba_AdmitidosItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_Medios_Prueba_Admitidos(MasterId, referenceId, Detalle_Medios_Prueba_AdmitidosItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_Medios_Prueba_AdmitidosItems != null && Detalle_Medios_Prueba_AdmitidosItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_Medios_Prueba_AdmitidosApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_Medios_Prueba_AdmitidosItem in Detalle_Medios_Prueba_AdmitidosItems)
                    {





                        //Removal Request
                        if (Detalle_Medios_Prueba_AdmitidosItem.Removed)
                        {
                            result = result && _IDetalle_Medios_Prueba_AdmitidosApiConsumer.Delete(Detalle_Medios_Prueba_AdmitidosItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_Medios_Prueba_AdmitidosItem.Clave = 0;

                        var Detalle_Medios_Prueba_AdmitidosData = new Detalle_Medios_Prueba_Admitidos
                        {
                            Proceso_Penal = MasterId
                            ,Clave = Detalle_Medios_Prueba_AdmitidosItem.Clave
                            ,Origen = Detalle_Medios_Prueba_AdmitidosItem.Origen
                            ,Medio_de_Prueba_Presentado = Detalle_Medios_Prueba_AdmitidosItem.Medio_de_Prueba_Presentado
                            ,Admitido = Detalle_Medios_Prueba_AdmitidosItem.Admitido

                        };

                        var resultId = Detalle_Medios_Prueba_AdmitidosItem.Clave > 0
                           ? _IDetalle_Medios_Prueba_AdmitidosApiConsumer.Update(Detalle_Medios_Prueba_AdmitidosData,null,null).Resource
                           : _IDetalle_Medios_Prueba_AdmitidosApiConsumer.Insert(Detalle_Medios_Prueba_AdmitidosData,null,null).Resource;

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
        public bool CopyDetalle_Condiciones_Proceso_Penal(int MasterId, int referenceId, List<Detalle_Condiciones_Proceso_PenalGridModelPost> Detalle_Condiciones_Proceso_PenalItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_Condiciones_Proceso_PenalApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_Condiciones_Proceso_PenalData = _IDetalle_Condiciones_Proceso_PenalApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_Condiciones_Proceso_Penal.Proceso_Penal=" + referenceId,"").Resource;
                if (Detalle_Condiciones_Proceso_PenalData == null || Detalle_Condiciones_Proceso_PenalData.Detalle_Condiciones_Proceso_Penals.Count == 0)
                    return true;

                var result = true;

                Detalle_Condiciones_Proceso_PenalGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_Condiciones_Proceso_Penal in Detalle_Condiciones_Proceso_PenalData.Detalle_Condiciones_Proceso_Penals)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_Condiciones_Proceso_Penal Detalle_Condiciones_Proceso_Penal1 = varDetalle_Condiciones_Proceso_Penal;

                    if (Detalle_Condiciones_Proceso_PenalItems != null && Detalle_Condiciones_Proceso_PenalItems.Any(m => m.Clave == Detalle_Condiciones_Proceso_Penal1.Clave))
                    {
                        modelDataToChange = Detalle_Condiciones_Proceso_PenalItems.FirstOrDefault(m => m.Clave == Detalle_Condiciones_Proceso_Penal1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_Condiciones_Proceso_Penal.Proceso_Penal = MasterId;
                    var insertId = _IDetalle_Condiciones_Proceso_PenalApiConsumer.Insert(varDetalle_Condiciones_Proceso_Penal,null,null).Resource;
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
        public ActionResult PostDetalle_Condiciones_Proceso_Penal(List<Detalle_Condiciones_Proceso_PenalGridModelPost> Detalle_Condiciones_Proceso_PenalItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_Condiciones_Proceso_Penal(MasterId, referenceId, Detalle_Condiciones_Proceso_PenalItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_Condiciones_Proceso_PenalItems != null && Detalle_Condiciones_Proceso_PenalItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_Condiciones_Proceso_PenalApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_Condiciones_Proceso_PenalItem in Detalle_Condiciones_Proceso_PenalItems)
                    {



                        //Removal Request
                        if (Detalle_Condiciones_Proceso_PenalItem.Removed)
                        {
                            result = result && _IDetalle_Condiciones_Proceso_PenalApiConsumer.Delete(Detalle_Condiciones_Proceso_PenalItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_Condiciones_Proceso_PenalItem.Clave = 0;

                        var Detalle_Condiciones_Proceso_PenalData = new Detalle_Condiciones_Proceso_Penal
                        {
                            Proceso_Penal = MasterId
                            ,Clave = Detalle_Condiciones_Proceso_PenalItem.Clave
                            ,Medida_Cautelar = (Convert.ToInt32(Detalle_Condiciones_Proceso_PenalItem.Medida_Cautelar) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_Condiciones_Proceso_PenalItem.Medida_Cautelar))

                        };

                        var resultId = Detalle_Condiciones_Proceso_PenalItem.Clave > 0
                           ? _IDetalle_Condiciones_Proceso_PenalApiConsumer.Update(Detalle_Condiciones_Proceso_PenalData,null,null).Resource
                           : _IDetalle_Condiciones_Proceso_PenalApiConsumer.Insert(Detalle_Condiciones_Proceso_PenalData,null,null).Resource;

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
        public ActionResult GetDetalle_Condiciones_Proceso_Penal_Condiciones_en_Suspension_CondicionalAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICondiciones_en_Suspension_CondicionalApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICondiciones_en_Suspension_CondicionalApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Condiciones_en_Suspension_Condicional", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }



        /// <summary>
        /// Write Element Array of Proceso_Penal script
        /// </summary>
        /// <param name="oProceso_PenalElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Proceso_PenalModuleAttributeList)
        {
            for (int i = 0; i < Proceso_PenalModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Proceso_PenalModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Proceso_PenalModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Proceso_PenalModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Proceso_PenalModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Proceso_PenalModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Proceso_PenalModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Proceso_PenalModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Proceso_PenalModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Proceso_PenalModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Proceso_PenalModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Proceso_PenalModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strProceso_PenalScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Proceso_Penal.js")))
            {
                strProceso_PenalScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Proceso_Penal element attributes
            string userChangeJson = jsSerialize.Serialize(Proceso_PenalModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strProceso_PenalScript.IndexOf("inpuElementArray");
            string splittedString = strProceso_PenalScript.Substring(indexOfArray, strProceso_PenalScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Proceso_PenalModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Proceso_PenalModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strProceso_PenalScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strProceso_PenalScript.Substring(indexOfArrayHistory, strProceso_PenalScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strProceso_PenalScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strProceso_PenalScript.Substring(endIndexOfMainElement + indexOfArray, strProceso_PenalScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Proceso_PenalModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Proceso_PenalModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Proceso_Penal.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Proceso_Penal.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Proceso_Penal.js")))
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
        public ActionResult Proceso_PenalPropertyBag()
        {
            return PartialView("Proceso_PenalPropertyBag", "Proceso_Penal");
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
        public ActionResult AddDetalle_Delitos_Proceso_Penal(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_Delitos_Proceso_Penal/AddDetalle_Delitos_Proceso_Penal");
        }

        [HttpGet]
        public ActionResult AddDetalle_Medidas_Cautelares_Proceso_Penal(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_Medidas_Cautelares_Proceso_Penal/AddDetalle_Medidas_Cautelares_Proceso_Penal");
        }

        [HttpGet]
        public ActionResult AddDetalle_Medios_Prueba_Imputado(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_Medios_Prueba_Imputado/AddDetalle_Medios_Prueba_Imputado");
        }

        [HttpGet]
        public ActionResult AddDetalle_Medios_Prueba_Victima(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_Medios_Prueba_Victima/AddDetalle_Medios_Prueba_Victima");
        }

        [HttpGet]
        public ActionResult AddDetalle_Medios_Prueba_Admitidos(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_Medios_Prueba_Admitidos/AddDetalle_Medios_Prueba_Admitidos");
        }

        [HttpGet]
        public ActionResult AddDetalle_Condiciones_Proceso_Penal(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_Condiciones_Proceso_Penal/AddDetalle_Condiciones_Proceso_Penal");
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
                var whereClauseFormat = "Object = 45558 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IProceso_PenalApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Proceso_Penal.Folio= " + RecordId;
                            var result = _IProceso_PenalApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IProceso_PenalApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Proceso_PenalPropertyMapper());
			
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
                    (Proceso_PenalAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Proceso_PenalPropertyMapper oProceso_PenalPropertyMapper = new Proceso_PenalPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oProceso_PenalPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IProceso_PenalApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Proceso_Penals == null)
                result.Proceso_Penals = new List<Proceso_Penal>();

            var data = result.Proceso_Penals.Select(m => new Proceso_PenalGridModel
            {
                Folio = m.Folio
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,ImputadoNombre_Completo_Detenido = CultureHelper.GetTraduction(m.Imputado_Detalle_de_Imputado.Clave.ToString(), "Detalle_de_Imputado") ?? (string)m.Imputado_Detalle_de_Imputado.Nombre_Completo_Detenido
                        ,Reclasificacion_JuridicaDescripcion = CultureHelper.GetTraduction(m.Reclasificacion_Juridica_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Reclasificacion_Juridica_A_Tiempo.Descripcion
                        ,Plazo_ConstitucionalDescripcion = CultureHelper.GetTraduction(m.Plazo_Constitucional_Plazo_Constitucional.Clave.ToString(), "Descripcion") ?? (string)m.Plazo_Constitucional_Plazo_Constitucional.Descripcion
                        ,VinculacionDescripcion = CultureHelper.GetTraduction(m.Vinculacion_Vinculacion_a_Proceso.Clave.ToString(), "Descripcion") ?? (string)m.Vinculacion_Vinculacion_a_Proceso.Descripcion
                        ,Resultado_No_VinculacionDescripcion = CultureHelper.GetTraduction(m.Resultado_No_Vinculacion_Continuacion_de_Proceso.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_No_Vinculacion_Continuacion_de_Proceso.Descripcion
                        ,Resultado_VinculacionDescripcion = CultureHelper.GetTraduction(m.Resultado_Vinculacion_Auto_de_Vinculacion_a_Proceso.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_Vinculacion_Auto_de_Vinculacion_a_Proceso.Descripcion
                        ,plazo_investigacion_complementariaDescripcion = CultureHelper.GetTraduction(m.plazo_investigacion_complementaria_Plazo_de_Investigacion_Complementaria.Clave.ToString(), "Descripcion") ?? (string)m.plazo_investigacion_complementaria_Plazo_de_Investigacion_Complementaria.Descripcion
			,fecha_investigacion_complementaria = m.fecha_investigacion_complementaria
			,hora_investigacion_complementaria = m.hora_investigacion_complementaria
			,Nombre_del_Juez_de_Control = m.Nombre_del_Juez_de_Control
                        ,Fecha_de_Entrega_de_Escrito_de_Acusacion = (m.Fecha_de_Entrega_de_Escrito_de_Acusacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Entrega_de_Escrito_de_Acusacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Entrega_de_Escrito_de_Acusacion = m.Hora_de_Entrega_de_Escrito_de_Acusacion
                        ,Fecha_de_Audiencia_Intermedia = (m.Fecha_de_Audiencia_Intermedia == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Audiencia_Intermedia).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Audiencia_Intermedia = m.Hora_de_Audiencia_Intermedia
                        ,Acusador_CoadyudanteDescripcion = CultureHelper.GetTraduction(m.Acusador_Coadyudante_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Acusador_Coadyudante_A_Tiempo.Descripcion
                        ,cumplio_descubrimiento_probatorioDescripcion = CultureHelper.GetTraduction(m.cumplio_descubrimiento_probatorio_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.cumplio_descubrimiento_probatorio_A_Tiempo.Descripcion
                        ,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora
                        ,Acuerdos_ProbatoriosDescripcion = CultureHelper.GetTraduction(m.Acuerdos_Probatorios_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Acuerdos_Probatorios_A_Tiempo.Descripcion
			,acuerdos_probatorios_cuales_fueron = m.acuerdos_probatorios_cuales_fueron
                        ,ResultadoDescripcion = CultureHelper.GetTraduction(m.Resultado_Resultado_de_Audiencia_Intermedia.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_Resultado_de_Audiencia_Intermedia.Descripcion
                        ,Tribunal_de_EnjuiciamientoDescripcion = CultureHelper.GetTraduction(m.Tribunal_de_Enjuiciamiento_Tribunal_de_Enjuiciamiento.Clave.ToString(), "Descripcion") ?? (string)m.Tribunal_de_Enjuiciamiento_Tribunal_de_Enjuiciamiento.Descripcion
			,Nombre_del_Juez = m.Nombre_del_Juez
			,Juez_Colegiado = m.Juez_Colegiado
			,Juez_Relator = m.Juez_Relator
			,Juez_Vocal = m.Juez_Vocal
                        ,Fecha_de_Audiencia_de_Juicio = (m.Fecha_de_Audiencia_de_Juicio == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Audiencia_de_Juicio).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Audiencia_de_Juicio = m.Hora_de_Audiencia_de_Juicio
                        ,Fallo_del_TribunalDescripcion = CultureHelper.GetTraduction(m.Fallo_del_Tribunal_Sentencia.Clave.ToString(), "Descripcion") ?? (string)m.Fallo_del_Tribunal_Sentencia.Descripcion
			,pruebas_a_desahogar = m.pruebas_a_desahogar
                        ,ResolucionDescripcion = CultureHelper.GetTraduction(m.Resolucion_Resolucion.Clave.ToString(), "Descripcion") ?? (string)m.Resolucion_Resolucion.Descripcion
			,Plazo_meses = m.Plazo_meses
                        ,Tipo_de_SentenciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Sentencia_Sentencia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Sentencia_Sentencia.Descripcion
			,cuantia_de_pena_anios = m.cuantia_de_pena_anios
			,cuantia_de_pena_meses = m.cuantia_de_pena_meses
			,Monto_de_la_Reparacion_del_Dano = m.Monto_de_la_Reparacion_del_Dano

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45558, arrayColumnsVisible), "Proceso_PenalList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45558, arrayColumnsVisible), "Proceso_PenalList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45558, arrayColumnsVisible), "Proceso_PenalList_" + DateTime.Now.ToString());
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

            _IProceso_PenalApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Proceso_PenalPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Proceso_PenalAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Proceso_PenalPropertyMapper oProceso_PenalPropertyMapper = new Proceso_PenalPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oProceso_PenalPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IProceso_PenalApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Proceso_Penals == null)
                result.Proceso_Penals = new List<Proceso_Penal>();

            var data = result.Proceso_Penals.Select(m => new Proceso_PenalGridModel
            {
                Folio = m.Folio
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,ImputadoNombre_Completo_Detenido = CultureHelper.GetTraduction(m.Imputado_Detalle_de_Imputado.Clave.ToString(), "Detalle_de_Imputado") ?? (string)m.Imputado_Detalle_de_Imputado.Nombre_Completo_Detenido
                        ,Reclasificacion_JuridicaDescripcion = CultureHelper.GetTraduction(m.Reclasificacion_Juridica_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Reclasificacion_Juridica_A_Tiempo.Descripcion
                        ,Plazo_ConstitucionalDescripcion = CultureHelper.GetTraduction(m.Plazo_Constitucional_Plazo_Constitucional.Clave.ToString(), "Descripcion") ?? (string)m.Plazo_Constitucional_Plazo_Constitucional.Descripcion
                        ,VinculacionDescripcion = CultureHelper.GetTraduction(m.Vinculacion_Vinculacion_a_Proceso.Clave.ToString(), "Descripcion") ?? (string)m.Vinculacion_Vinculacion_a_Proceso.Descripcion
                        ,Resultado_No_VinculacionDescripcion = CultureHelper.GetTraduction(m.Resultado_No_Vinculacion_Continuacion_de_Proceso.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_No_Vinculacion_Continuacion_de_Proceso.Descripcion
                        ,Resultado_VinculacionDescripcion = CultureHelper.GetTraduction(m.Resultado_Vinculacion_Auto_de_Vinculacion_a_Proceso.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_Vinculacion_Auto_de_Vinculacion_a_Proceso.Descripcion
                        ,plazo_investigacion_complementariaDescripcion = CultureHelper.GetTraduction(m.plazo_investigacion_complementaria_Plazo_de_Investigacion_Complementaria.Clave.ToString(), "Descripcion") ?? (string)m.plazo_investigacion_complementaria_Plazo_de_Investigacion_Complementaria.Descripcion
			,fecha_investigacion_complementaria = m.fecha_investigacion_complementaria
			,hora_investigacion_complementaria = m.hora_investigacion_complementaria
			,Nombre_del_Juez_de_Control = m.Nombre_del_Juez_de_Control
                        ,Fecha_de_Entrega_de_Escrito_de_Acusacion = (m.Fecha_de_Entrega_de_Escrito_de_Acusacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Entrega_de_Escrito_de_Acusacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Entrega_de_Escrito_de_Acusacion = m.Hora_de_Entrega_de_Escrito_de_Acusacion
                        ,Fecha_de_Audiencia_Intermedia = (m.Fecha_de_Audiencia_Intermedia == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Audiencia_Intermedia).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Audiencia_Intermedia = m.Hora_de_Audiencia_Intermedia
                        ,Acusador_CoadyudanteDescripcion = CultureHelper.GetTraduction(m.Acusador_Coadyudante_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Acusador_Coadyudante_A_Tiempo.Descripcion
                        ,cumplio_descubrimiento_probatorioDescripcion = CultureHelper.GetTraduction(m.cumplio_descubrimiento_probatorio_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.cumplio_descubrimiento_probatorio_A_Tiempo.Descripcion
                        ,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora
                        ,Acuerdos_ProbatoriosDescripcion = CultureHelper.GetTraduction(m.Acuerdos_Probatorios_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Acuerdos_Probatorios_A_Tiempo.Descripcion
			,acuerdos_probatorios_cuales_fueron = m.acuerdos_probatorios_cuales_fueron
                        ,ResultadoDescripcion = CultureHelper.GetTraduction(m.Resultado_Resultado_de_Audiencia_Intermedia.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_Resultado_de_Audiencia_Intermedia.Descripcion
                        ,Tribunal_de_EnjuiciamientoDescripcion = CultureHelper.GetTraduction(m.Tribunal_de_Enjuiciamiento_Tribunal_de_Enjuiciamiento.Clave.ToString(), "Descripcion") ?? (string)m.Tribunal_de_Enjuiciamiento_Tribunal_de_Enjuiciamiento.Descripcion
			,Nombre_del_Juez = m.Nombre_del_Juez
			,Juez_Colegiado = m.Juez_Colegiado
			,Juez_Relator = m.Juez_Relator
			,Juez_Vocal = m.Juez_Vocal
                        ,Fecha_de_Audiencia_de_Juicio = (m.Fecha_de_Audiencia_de_Juicio == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Audiencia_de_Juicio).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Audiencia_de_Juicio = m.Hora_de_Audiencia_de_Juicio
                        ,Fallo_del_TribunalDescripcion = CultureHelper.GetTraduction(m.Fallo_del_Tribunal_Sentencia.Clave.ToString(), "Descripcion") ?? (string)m.Fallo_del_Tribunal_Sentencia.Descripcion
			,pruebas_a_desahogar = m.pruebas_a_desahogar
                        ,ResolucionDescripcion = CultureHelper.GetTraduction(m.Resolucion_Resolucion.Clave.ToString(), "Descripcion") ?? (string)m.Resolucion_Resolucion.Descripcion
			,Plazo_meses = m.Plazo_meses
                        ,Tipo_de_SentenciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Sentencia_Sentencia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Sentencia_Sentencia.Descripcion
			,cuantia_de_pena_anios = m.cuantia_de_pena_anios
			,cuantia_de_pena_meses = m.cuantia_de_pena_meses
			,Monto_de_la_Reparacion_del_Dano = m.Monto_de_la_Reparacion_del_Dano

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
                _IProceso_PenalApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IProceso_PenalApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Fase_Complementaria(Proceso_Penal_Fase_ComplementariaModel varProceso_Penal)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IProceso_PenalApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Proceso_Penal_Fase_ComplementariaInfo = new Proceso_Penal_Fase_Complementaria
                {
                    Folio = varProceso_Penal.Folio
                                            ,Expediente_MP = varProceso_Penal.Expediente_MP
                        ,Fecha_de_Registro = (!String.IsNullOrEmpty(varProceso_Penal.Fecha_de_Registro)) ? DateTime.ParseExact(varProceso_Penal.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Registro = varProceso_Penal.Hora_de_Registro
                        ,Usuario_que_Registra = varProceso_Penal.Usuario_que_Registra
                        ,Imputado = varProceso_Penal.Imputado
                        ,Reclasificacion_Juridica = varProceso_Penal.Reclasificacion_Juridica
                        ,Plazo_Constitucional = varProceso_Penal.Plazo_Constitucional
                        ,Vinculacion = varProceso_Penal.Vinculacion
                        ,Resultado_No_Vinculacion = varProceso_Penal.Resultado_No_Vinculacion
                        ,Resultado_Vinculacion = varProceso_Penal.Resultado_Vinculacion
                        ,plazo_investigacion_complementaria = varProceso_Penal.plazo_investigacion_complementaria
                        ,fecha_investigacion_complementaria = varProceso_Penal.fecha_investigacion_complementaria
                        ,hora_investigacion_complementaria = varProceso_Penal.hora_investigacion_complementaria
                    
                };

                result = _IProceso_PenalApiConsumer.Update_Fase_Complementaria(Proceso_Penal_Fase_ComplementariaInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Fase_Complementaria(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IProceso_PenalApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IProceso_PenalApiConsumer.Get_Fase_Complementaria(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_Delitos_Proceso_Penal;
                var Detalle_Delitos_Proceso_PenalData = GetDetalle_Delitos_Proceso_PenalData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Delitos_Proceso_Penal);
                int RowCount_Detalle_Medidas_Cautelares_Proceso_Penal;
                var Detalle_Medidas_Cautelares_Proceso_PenalData = GetDetalle_Medidas_Cautelares_Proceso_PenalData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Medidas_Cautelares_Proceso_Penal);
                int RowCount_Detalle_Medios_Prueba_Imputado;
                var Detalle_Medios_Prueba_ImputadoData = GetDetalle_Medios_Prueba_ImputadoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Medios_Prueba_Imputado);
                int RowCount_Detalle_Medios_Prueba_Victima;
                var Detalle_Medios_Prueba_VictimaData = GetDetalle_Medios_Prueba_VictimaData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Medios_Prueba_Victima);
                int RowCount_Detalle_Medios_Prueba_Admitidos;
                var Detalle_Medios_Prueba_AdmitidosData = GetDetalle_Medios_Prueba_AdmitidosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Medios_Prueba_Admitidos);
                int RowCount_Detalle_Condiciones_Proceso_Penal;
                var Detalle_Condiciones_Proceso_PenalData = GetDetalle_Condiciones_Proceso_PenalData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Condiciones_Proceso_Penal);

                var result = new Proceso_Penal_Fase_ComplementariaModel
                {
                    Folio = m.Folio
                        ,Expediente_MP = m.Expediente_MP
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_Registra = m.Usuario_que_Registra
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,Imputado = m.Imputado
                        ,ImputadoNombre_Completo_Detenido = CultureHelper.GetTraduction(m.Imputado_Detalle_de_Imputado.Clave.ToString(), "Detalle_de_Imputado") ?? (string)m.Imputado_Detalle_de_Imputado.Nombre_Completo_Detenido
                        ,Reclasificacion_Juridica = m.Reclasificacion_Juridica
                        ,Reclasificacion_JuridicaDescripcion = CultureHelper.GetTraduction(m.Reclasificacion_Juridica_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Reclasificacion_Juridica_A_Tiempo.Descripcion
                        ,Plazo_Constitucional = m.Plazo_Constitucional
                        ,Plazo_ConstitucionalDescripcion = CultureHelper.GetTraduction(m.Plazo_Constitucional_Plazo_Constitucional.Clave.ToString(), "Descripcion") ?? (string)m.Plazo_Constitucional_Plazo_Constitucional.Descripcion
                        ,Vinculacion = m.Vinculacion
                        ,VinculacionDescripcion = CultureHelper.GetTraduction(m.Vinculacion_Vinculacion_a_Proceso.Clave.ToString(), "Descripcion") ?? (string)m.Vinculacion_Vinculacion_a_Proceso.Descripcion
                        ,Resultado_No_Vinculacion = m.Resultado_No_Vinculacion
                        ,Resultado_No_VinculacionDescripcion = CultureHelper.GetTraduction(m.Resultado_No_Vinculacion_Continuacion_de_Proceso.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_No_Vinculacion_Continuacion_de_Proceso.Descripcion
                        ,Resultado_Vinculacion = m.Resultado_Vinculacion
                        ,Resultado_VinculacionDescripcion = CultureHelper.GetTraduction(m.Resultado_Vinculacion_Auto_de_Vinculacion_a_Proceso.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_Vinculacion_Auto_de_Vinculacion_a_Proceso.Descripcion
                        ,plazo_investigacion_complementaria = m.plazo_investigacion_complementaria
                        ,plazo_investigacion_complementariaDescripcion = CultureHelper.GetTraduction(m.plazo_investigacion_complementaria_Plazo_de_Investigacion_Complementaria.Clave.ToString(), "Descripcion") ?? (string)m.plazo_investigacion_complementaria_Plazo_de_Investigacion_Complementaria.Descripcion
			,fecha_investigacion_complementaria = m.fecha_investigacion_complementaria
			,hora_investigacion_complementaria = m.hora_investigacion_complementaria

                    
                };
				var resultData = new
                {
                    data = result
                    ,Delitos = Detalle_Delitos_Proceso_PenalData
                    ,Medidas_Cautelares = Detalle_Medidas_Cautelares_Proceso_PenalData
                    ,Medios_de_Prueba_del_Imputado = Detalle_Medios_Prueba_ImputadoData
                    ,Medios_de_Prueba_de_la_Victima = Detalle_Medios_Prueba_VictimaData
                    ,Medios_de_Prueba_Admitidos = Detalle_Medios_Prueba_AdmitidosData
                    ,Condiciones = Detalle_Condiciones_Proceso_PenalData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Fase_Escrita(Proceso_Penal_Fase_EscritaModel varProceso_Penal)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IProceso_PenalApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Proceso_Penal_Fase_EscritaInfo = new Proceso_Penal_Fase_Escrita
                {
                    Folio = varProceso_Penal.Folio
                                            ,Nombre_del_Juez_de_Control = varProceso_Penal.Nombre_del_Juez_de_Control
                        ,Fecha_de_Entrega_de_Escrito_de_Acusacion = (!String.IsNullOrEmpty(varProceso_Penal.Fecha_de_Entrega_de_Escrito_de_Acusacion)) ? DateTime.ParseExact(varProceso_Penal.Fecha_de_Entrega_de_Escrito_de_Acusacion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Entrega_de_Escrito_de_Acusacion = varProceso_Penal.Hora_de_Entrega_de_Escrito_de_Acusacion
                        ,Fecha_de_Audiencia_Intermedia = (!String.IsNullOrEmpty(varProceso_Penal.Fecha_de_Audiencia_Intermedia)) ? DateTime.ParseExact(varProceso_Penal.Fecha_de_Audiencia_Intermedia, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Audiencia_Intermedia = varProceso_Penal.Hora_de_Audiencia_Intermedia
                        ,Acusador_Coadyudante = varProceso_Penal.Acusador_Coadyudante
                        ,cumplio_descubrimiento_probatorio = varProceso_Penal.cumplio_descubrimiento_probatorio
                        ,Fecha = (!String.IsNullOrEmpty(varProceso_Penal.Fecha)) ? DateTime.ParseExact(varProceso_Penal.Fecha, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora = varProceso_Penal.Hora
                    
                };

                result = _IProceso_PenalApiConsumer.Update_Fase_Escrita(Proceso_Penal_Fase_EscritaInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Fase_Escrita(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IProceso_PenalApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IProceso_PenalApiConsumer.Get_Fase_Escrita(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_Delitos_Proceso_Penal;
                var Detalle_Delitos_Proceso_PenalData = GetDetalle_Delitos_Proceso_PenalData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Delitos_Proceso_Penal);
                int RowCount_Detalle_Medidas_Cautelares_Proceso_Penal;
                var Detalle_Medidas_Cautelares_Proceso_PenalData = GetDetalle_Medidas_Cautelares_Proceso_PenalData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Medidas_Cautelares_Proceso_Penal);
                int RowCount_Detalle_Medios_Prueba_Imputado;
                var Detalle_Medios_Prueba_ImputadoData = GetDetalle_Medios_Prueba_ImputadoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Medios_Prueba_Imputado);
                int RowCount_Detalle_Medios_Prueba_Victima;
                var Detalle_Medios_Prueba_VictimaData = GetDetalle_Medios_Prueba_VictimaData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Medios_Prueba_Victima);
                int RowCount_Detalle_Medios_Prueba_Admitidos;
                var Detalle_Medios_Prueba_AdmitidosData = GetDetalle_Medios_Prueba_AdmitidosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Medios_Prueba_Admitidos);
                int RowCount_Detalle_Condiciones_Proceso_Penal;
                var Detalle_Condiciones_Proceso_PenalData = GetDetalle_Condiciones_Proceso_PenalData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Condiciones_Proceso_Penal);

                var result = new Proceso_Penal_Fase_EscritaModel
                {
                    Folio = m.Folio
			,Nombre_del_Juez_de_Control = m.Nombre_del_Juez_de_Control
                        ,Fecha_de_Entrega_de_Escrito_de_Acusacion = (m.Fecha_de_Entrega_de_Escrito_de_Acusacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Entrega_de_Escrito_de_Acusacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Entrega_de_Escrito_de_Acusacion = m.Hora_de_Entrega_de_Escrito_de_Acusacion
                        ,Fecha_de_Audiencia_Intermedia = (m.Fecha_de_Audiencia_Intermedia == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Audiencia_Intermedia).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Audiencia_Intermedia = m.Hora_de_Audiencia_Intermedia
                        ,Acusador_Coadyudante = m.Acusador_Coadyudante
                        ,Acusador_CoadyudanteDescripcion = CultureHelper.GetTraduction(m.Acusador_Coadyudante_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Acusador_Coadyudante_A_Tiempo.Descripcion
                        ,cumplio_descubrimiento_probatorio = m.cumplio_descubrimiento_probatorio
                        ,cumplio_descubrimiento_probatorioDescripcion = CultureHelper.GetTraduction(m.cumplio_descubrimiento_probatorio_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.cumplio_descubrimiento_probatorio_A_Tiempo.Descripcion
                        ,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora

                    
                };
				var resultData = new
                {
                    data = result
                    ,Delitos = Detalle_Delitos_Proceso_PenalData
                    ,Medidas_Cautelares = Detalle_Medidas_Cautelares_Proceso_PenalData
                    ,Medios_de_Prueba_del_Imputado = Detalle_Medios_Prueba_ImputadoData
                    ,Medios_de_Prueba_de_la_Victima = Detalle_Medios_Prueba_VictimaData
                    ,Medios_de_Prueba_Admitidos = Detalle_Medios_Prueba_AdmitidosData
                    ,Condiciones = Detalle_Condiciones_Proceso_PenalData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Audiencia_Intermedia(Proceso_Penal_Audiencia_IntermediaModel varProceso_Penal)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IProceso_PenalApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Proceso_Penal_Audiencia_IntermediaInfo = new Proceso_Penal_Audiencia_Intermedia
                {
                    Folio = varProceso_Penal.Folio
                                            ,Acuerdos_Probatorios = varProceso_Penal.Acuerdos_Probatorios
                        ,acuerdos_probatorios_cuales_fueron = varProceso_Penal.acuerdos_probatorios_cuales_fueron
                        ,Resultado = varProceso_Penal.Resultado
                    
                };

                result = _IProceso_PenalApiConsumer.Update_Audiencia_Intermedia(Proceso_Penal_Audiencia_IntermediaInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Audiencia_Intermedia(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IProceso_PenalApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IProceso_PenalApiConsumer.Get_Audiencia_Intermedia(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_Delitos_Proceso_Penal;
                var Detalle_Delitos_Proceso_PenalData = GetDetalle_Delitos_Proceso_PenalData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Delitos_Proceso_Penal);
                int RowCount_Detalle_Medidas_Cautelares_Proceso_Penal;
                var Detalle_Medidas_Cautelares_Proceso_PenalData = GetDetalle_Medidas_Cautelares_Proceso_PenalData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Medidas_Cautelares_Proceso_Penal);
                int RowCount_Detalle_Medios_Prueba_Imputado;
                var Detalle_Medios_Prueba_ImputadoData = GetDetalle_Medios_Prueba_ImputadoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Medios_Prueba_Imputado);
                int RowCount_Detalle_Medios_Prueba_Victima;
                var Detalle_Medios_Prueba_VictimaData = GetDetalle_Medios_Prueba_VictimaData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Medios_Prueba_Victima);
                int RowCount_Detalle_Medios_Prueba_Admitidos;
                var Detalle_Medios_Prueba_AdmitidosData = GetDetalle_Medios_Prueba_AdmitidosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Medios_Prueba_Admitidos);
                int RowCount_Detalle_Condiciones_Proceso_Penal;
                var Detalle_Condiciones_Proceso_PenalData = GetDetalle_Condiciones_Proceso_PenalData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Condiciones_Proceso_Penal);

                var result = new Proceso_Penal_Audiencia_IntermediaModel
                {
                    Folio = m.Folio
                        ,Acuerdos_Probatorios = m.Acuerdos_Probatorios
                        ,Acuerdos_ProbatoriosDescripcion = CultureHelper.GetTraduction(m.Acuerdos_Probatorios_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Acuerdos_Probatorios_A_Tiempo.Descripcion
			,acuerdos_probatorios_cuales_fueron = m.acuerdos_probatorios_cuales_fueron
                        ,Resultado = m.Resultado
                        ,ResultadoDescripcion = CultureHelper.GetTraduction(m.Resultado_Resultado_de_Audiencia_Intermedia.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_Resultado_de_Audiencia_Intermedia.Descripcion

                    
                };
				var resultData = new
                {
                    data = result
                    ,Delitos = Detalle_Delitos_Proceso_PenalData
                    ,Medidas_Cautelares = Detalle_Medidas_Cautelares_Proceso_PenalData
                    ,Medios_de_Prueba_del_Imputado = Detalle_Medios_Prueba_ImputadoData
                    ,Medios_de_Prueba_de_la_Victima = Detalle_Medios_Prueba_VictimaData
                    ,Medios_de_Prueba_Admitidos = Detalle_Medios_Prueba_AdmitidosData
                    ,Condiciones = Detalle_Condiciones_Proceso_PenalData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Juicio_Oral(Proceso_Penal_Juicio_OralModel varProceso_Penal)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IProceso_PenalApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Proceso_Penal_Juicio_OralInfo = new Proceso_Penal_Juicio_Oral
                {
                    Folio = varProceso_Penal.Folio
                                            ,Tribunal_de_Enjuiciamiento = varProceso_Penal.Tribunal_de_Enjuiciamiento
                        ,Nombre_del_Juez = varProceso_Penal.Nombre_del_Juez
                        ,Juez_Colegiado = varProceso_Penal.Juez_Colegiado
                        ,Juez_Relator = varProceso_Penal.Juez_Relator
                        ,Juez_Vocal = varProceso_Penal.Juez_Vocal
                        ,Fecha_de_Audiencia_de_Juicio = (!String.IsNullOrEmpty(varProceso_Penal.Fecha_de_Audiencia_de_Juicio)) ? DateTime.ParseExact(varProceso_Penal.Fecha_de_Audiencia_de_Juicio, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Audiencia_de_Juicio = varProceso_Penal.Hora_de_Audiencia_de_Juicio
                        ,Fallo_del_Tribunal = varProceso_Penal.Fallo_del_Tribunal
                        ,pruebas_a_desahogar = varProceso_Penal.pruebas_a_desahogar
                    
                };

                result = _IProceso_PenalApiConsumer.Update_Juicio_Oral(Proceso_Penal_Juicio_OralInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Juicio_Oral(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IProceso_PenalApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IProceso_PenalApiConsumer.Get_Juicio_Oral(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_Delitos_Proceso_Penal;
                var Detalle_Delitos_Proceso_PenalData = GetDetalle_Delitos_Proceso_PenalData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Delitos_Proceso_Penal);
                int RowCount_Detalle_Medidas_Cautelares_Proceso_Penal;
                var Detalle_Medidas_Cautelares_Proceso_PenalData = GetDetalle_Medidas_Cautelares_Proceso_PenalData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Medidas_Cautelares_Proceso_Penal);
                int RowCount_Detalle_Medios_Prueba_Imputado;
                var Detalle_Medios_Prueba_ImputadoData = GetDetalle_Medios_Prueba_ImputadoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Medios_Prueba_Imputado);
                int RowCount_Detalle_Medios_Prueba_Victima;
                var Detalle_Medios_Prueba_VictimaData = GetDetalle_Medios_Prueba_VictimaData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Medios_Prueba_Victima);
                int RowCount_Detalle_Medios_Prueba_Admitidos;
                var Detalle_Medios_Prueba_AdmitidosData = GetDetalle_Medios_Prueba_AdmitidosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Medios_Prueba_Admitidos);
                int RowCount_Detalle_Condiciones_Proceso_Penal;
                var Detalle_Condiciones_Proceso_PenalData = GetDetalle_Condiciones_Proceso_PenalData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Condiciones_Proceso_Penal);

                var result = new Proceso_Penal_Juicio_OralModel
                {
                    Folio = m.Folio
                        ,Tribunal_de_Enjuiciamiento = m.Tribunal_de_Enjuiciamiento
                        ,Tribunal_de_EnjuiciamientoDescripcion = CultureHelper.GetTraduction(m.Tribunal_de_Enjuiciamiento_Tribunal_de_Enjuiciamiento.Clave.ToString(), "Descripcion") ?? (string)m.Tribunal_de_Enjuiciamiento_Tribunal_de_Enjuiciamiento.Descripcion
			,Nombre_del_Juez = m.Nombre_del_Juez
			,Juez_Colegiado = m.Juez_Colegiado
			,Juez_Relator = m.Juez_Relator
			,Juez_Vocal = m.Juez_Vocal
                        ,Fecha_de_Audiencia_de_Juicio = (m.Fecha_de_Audiencia_de_Juicio == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Audiencia_de_Juicio).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Audiencia_de_Juicio = m.Hora_de_Audiencia_de_Juicio
                        ,Fallo_del_Tribunal = m.Fallo_del_Tribunal
                        ,Fallo_del_TribunalDescripcion = CultureHelper.GetTraduction(m.Fallo_del_Tribunal_Sentencia.Clave.ToString(), "Descripcion") ?? (string)m.Fallo_del_Tribunal_Sentencia.Descripcion
			,pruebas_a_desahogar = m.pruebas_a_desahogar

                    
                };
				var resultData = new
                {
                    data = result
                    ,Delitos = Detalle_Delitos_Proceso_PenalData
                    ,Medidas_Cautelares = Detalle_Medidas_Cautelares_Proceso_PenalData
                    ,Medios_de_Prueba_del_Imputado = Detalle_Medios_Prueba_ImputadoData
                    ,Medios_de_Prueba_de_la_Victima = Detalle_Medios_Prueba_VictimaData
                    ,Medios_de_Prueba_Admitidos = Detalle_Medios_Prueba_AdmitidosData
                    ,Condiciones = Detalle_Condiciones_Proceso_PenalData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Resolucion(Proceso_Penal_ResolucionModel varProceso_Penal)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IProceso_PenalApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Proceso_Penal_ResolucionInfo = new Proceso_Penal_Resolucion
                {
                    Folio = varProceso_Penal.Folio
                                            ,Resolucion = varProceso_Penal.Resolucion
                        ,Plazo_meses = varProceso_Penal.Plazo_meses
                        ,Tipo_de_Sentencia = varProceso_Penal.Tipo_de_Sentencia
                        ,cuantia_de_pena_anios = varProceso_Penal.cuantia_de_pena_anios
                        ,cuantia_de_pena_meses = varProceso_Penal.cuantia_de_pena_meses
                        ,Monto_de_la_Reparacion_del_Dano = varProceso_Penal.Monto_de_la_Reparacion_del_Dano
                    
                };

                result = _IProceso_PenalApiConsumer.Update_Resolucion(Proceso_Penal_ResolucionInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Resolucion(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IProceso_PenalApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IProceso_PenalApiConsumer.Get_Resolucion(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_Delitos_Proceso_Penal;
                var Detalle_Delitos_Proceso_PenalData = GetDetalle_Delitos_Proceso_PenalData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Delitos_Proceso_Penal);
                int RowCount_Detalle_Medidas_Cautelares_Proceso_Penal;
                var Detalle_Medidas_Cautelares_Proceso_PenalData = GetDetalle_Medidas_Cautelares_Proceso_PenalData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Medidas_Cautelares_Proceso_Penal);
                int RowCount_Detalle_Medios_Prueba_Imputado;
                var Detalle_Medios_Prueba_ImputadoData = GetDetalle_Medios_Prueba_ImputadoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Medios_Prueba_Imputado);
                int RowCount_Detalle_Medios_Prueba_Victima;
                var Detalle_Medios_Prueba_VictimaData = GetDetalle_Medios_Prueba_VictimaData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Medios_Prueba_Victima);
                int RowCount_Detalle_Medios_Prueba_Admitidos;
                var Detalle_Medios_Prueba_AdmitidosData = GetDetalle_Medios_Prueba_AdmitidosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Medios_Prueba_Admitidos);
                int RowCount_Detalle_Condiciones_Proceso_Penal;
                var Detalle_Condiciones_Proceso_PenalData = GetDetalle_Condiciones_Proceso_PenalData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Condiciones_Proceso_Penal);

                var result = new Proceso_Penal_ResolucionModel
                {
                    Folio = m.Folio
                        ,Resolucion = m.Resolucion
                        ,ResolucionDescripcion = CultureHelper.GetTraduction(m.Resolucion_Resolucion.Clave.ToString(), "Descripcion") ?? (string)m.Resolucion_Resolucion.Descripcion
			,Plazo_meses = m.Plazo_meses
                        ,Tipo_de_Sentencia = m.Tipo_de_Sentencia
                        ,Tipo_de_SentenciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Sentencia_Sentencia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Sentencia_Sentencia.Descripcion
			,cuantia_de_pena_anios = m.cuantia_de_pena_anios
			,cuantia_de_pena_meses = m.cuantia_de_pena_meses
			,Monto_de_la_Reparacion_del_Dano = m.Monto_de_la_Reparacion_del_Dano

                    
                };
				var resultData = new
                {
                    data = result
                    ,Delitos = Detalle_Delitos_Proceso_PenalData
                    ,Medidas_Cautelares = Detalle_Medidas_Cautelares_Proceso_PenalData
                    ,Medios_de_Prueba_del_Imputado = Detalle_Medios_Prueba_ImputadoData
                    ,Medios_de_Prueba_de_la_Victima = Detalle_Medios_Prueba_VictimaData
                    ,Medios_de_Prueba_Admitidos = Detalle_Medios_Prueba_AdmitidosData
                    ,Condiciones = Detalle_Condiciones_Proceso_PenalData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }


    }
}

