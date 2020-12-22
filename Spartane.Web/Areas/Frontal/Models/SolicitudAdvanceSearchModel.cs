using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class SolicitudAdvanceSearchModel
    {
        public SolicitudAdvanceSearchModel()
        {
            Asignar_Especialista_Automatico = RadioOptions.NoApply;
            Rechazar = RadioOptions.NoApply;

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Registro { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Registro", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Registro { set; get; }

        public Filters Usuario_que_RegistraFilter { set; get; }
        public string AdvanceUsuario_que_Registra { set; get; }
        public int[] AdvanceUsuario_que_RegistraMultiple { set; get; }

        public Filters Numero_de_FolioFilter { set; get; }
        public string Numero_de_Folio { set; get; }

        public Filters Unidad_MASCFilter { set; get; }
        public string AdvanceUnidad_MASC { set; get; }
        public int[] AdvanceUnidad_MASCMultiple { set; get; }

        public Filters RemitenteFilter { set; get; }
        public string Remitente { set; get; }

        public Filters NUATFilter { set; get; }
        public string AdvanceNUAT { set; get; }
        public int[] AdvanceNUATMultiple { set; get; }

        public Filters NUAT_CodigoFilter { set; get; }
        public string NUAT_Codigo { set; get; }

        public Filters Expediente_MPIFilter { set; get; }
        public string AdvanceExpediente_MPI { set; get; }
        public int[] AdvanceExpediente_MPIMultiple { set; get; }

        public Filters Expediente_CausaPenalFilter { set; get; }
        public string AdvanceExpediente_CausaPenal { set; get; }
        public int[] AdvanceExpediente_CausaPenalMultiple { set; get; }

        public Filters MunicipioFilter { set; get; }
        public string AdvanceMunicipio { set; get; }
        public int[] AdvanceMunicipioMultiple { set; get; }

        public Filters RegionFilter { set; get; }
        public string AdvanceRegion { set; get; }
        public int[] AdvanceRegionMultiple { set; get; }

        public Filters NUCFilter { set; get; }
        public string NUC { set; get; }

        public Filters CDIFilter { set; get; }
        public string CDI { set; get; }

        public Filters Causa_PenalFilter { set; get; }
        public string Causa_Penal { set; get; }

        public Filters Numero_de_ExpedienteFilter { set; get; }
        public string Numero_de_Expediente { set; get; }

        public Filters EstatusFilter { set; get; }
        public string AdvanceEstatus { set; get; }
        public int[] AdvanceEstatusMultiple { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_en_que_llega_a_Coordinador { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_en_que_llega_a_Coordinador", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_en_que_llega_a_Coordinador { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_en_que_llega_a_Especialista { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_en_que_llega_a_Especialista", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_en_que_llega_a_Especialista { set; get; }

        public Filters Agente_del_Ministerio_Publico_OrientadorFilter { set; get; }
        public string AdvanceAgente_del_Ministerio_Publico_Orientador { set; get; }
        public int[] AdvanceAgente_del_Ministerio_Publico_OrientadorMultiple { set; get; }

        public Filters Agente_del_Ministerio_Publico_InvestFilter { set; get; }
        public string AdvanceAgente_del_Ministerio_Publico_Invest { set; get; }
        public int[] AdvanceAgente_del_Ministerio_Publico_InvestMultiple { set; get; }

        public Filters Juez_de_ControlFilter { set; get; }
        public string Juez_de_Control { set; get; }

        public Filters UnidadFilter { set; get; }
        public string AdvanceUnidad { set; get; }
        public int[] AdvanceUnidadMultiple { set; get; }

        public Filters Titulo_del_HechoFilter { set; get; }
        public string Titulo_del_Hecho { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_del_Hecho { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_del_Hecho", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_del_Hecho { set; get; }

        public Filters Narrativa_Breve_de_los_HechosFilter { set; get; }
        public string Narrativa_Breve_de_los_Hechos { set; get; }

        public string ToHora_Aproximada_del_Hecho { set; get; }
        public string FromHora_Aproximada_del_Hecho { set; get; }

        public Filters Tipo_de_Lugar_del_HechoFilter { set; get; }
        public string AdvanceTipo_de_Lugar_del_Hecho { set; get; }
        public int[] AdvanceTipo_de_Lugar_del_HechoMultiple { set; get; }

        public Filters PaisHFilter { set; get; }
        public string AdvancePaisH { set; get; }
        public int[] AdvancePaisHMultiple { set; get; }

        public Filters EstadoHFilter { set; get; }
        public string AdvanceEstadoH { set; get; }
        public int[] AdvanceEstadoHMultiple { set; get; }

        public Filters MunicipioHFilter { set; get; }
        public string AdvanceMunicipioH { set; get; }
        public int[] AdvanceMunicipioHMultiple { set; get; }

        public Filters PoblacionFilter { set; get; }
        public string AdvancePoblacion { set; get; }
        public int[] AdvancePoblacionMultiple { set; get; }

        public Filters ColoniaHFilter { set; get; }
        public string AdvanceColoniaH { set; get; }
        public int[] AdvanceColoniaHMultiple { set; get; }

        public Filters CalleHFilter { set; get; }
        public string CalleH { set; get; }

        public Filters Numero_InteriorHFilter { set; get; }
        public string Numero_InteriorH { set; get; }

        public Filters Numero_ExteriorHFilter { set; get; }
        public string Numero_ExteriorH { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromCodigo_PostalH { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromCodigo_PostalH", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToCodigo_PostalH { set; get; }

        public Filters Entre_CalleFilter { set; get; }
        public string Entre_Calle { set; get; }

        public Filters y_CalleFilter { set; get; }
        public string y_Calle { set; get; }

        public Filters LongitudHFilter { set; get; }
        public string LongitudH { set; get; }

        public Filters LatitudHFilter { set; get; }
        public string LatitudH { set; get; }

        public Filters Especialista_AsignadoAFilter { set; get; }
        public string AdvanceEspecialista_AsignadoA { set; get; }
        public int[] AdvanceEspecialista_AsignadoAMultiple { set; get; }

        public Filters Motivo_cambio_facilitadorFilter { set; get; }
        public string Motivo_cambio_facilitador { set; get; }

        public RadioOptions Asignar_Especialista_Automatico { set; get; }

        public Filters RazoneFilter { set; get; }
        public string Razone { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_AsignacionA { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_AsignacionA", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_AsignacionA { set; get; }

        public string ToHora_de_AsignacionA { set; get; }
        public string FromHora_de_AsignacionA { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Atencion_del_Especialista { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Atencion_del_Especialista", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Atencion_del_Especialista { set; get; }

        public string ToHora_de_Atencion_del_Especialista { set; get; }
        public string FromHora_de_Atencion_del_Especialista { set; get; }

        public RadioOptions Rechazar { set; get; }

        public Filters Motivo_de_RechazoFilter { set; get; }
        public string AdvanceMotivo_de_Rechazo { set; get; }
        public int[] AdvanceMotivo_de_RechazoMultiple { set; get; }

        public Filters Acuerdo_CumplidoFilter { set; get; }
        public string AdvanceAcuerdo_Cumplido { set; get; }
        public int[] AdvanceAcuerdo_CumplidoMultiple { set; get; }

        public Filters Razon_de_IncumplimientoFilter { set; get; }
        public string AdvanceRazon_de_Incumplimiento { set; get; }
        public int[] AdvanceRazon_de_IncumplimientoMultiple { set; get; }

        public Filters Tipo_de_Conclusion_AnticipadaFilter { set; get; }
        public string AdvanceTipo_de_Conclusion_Anticipada { set; get; }
        public int[] AdvanceTipo_de_Conclusion_AnticipadaMultiple { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Cierre { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Cierre", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Cierre { set; get; }

        public string ToHora_de_Cierre { set; get; }
        public string FromHora_de_Cierre { set; get; }

        public Filters Usuario_que_Resuelve_SolicitudFilter { set; get; }
        public string AdvanceUsuario_que_Resuelve_Solicitud { set; get; }
        public int[] AdvanceUsuario_que_Resuelve_SolicitudMultiple { set; get; }

        public Filters Resolucion_SolicitudFilter { set; get; }
        public string AdvanceResolucion_Solicitud { set; get; }
        public int[] AdvanceResolucion_SolicitudMultiple { set; get; }

        public Filters Tipo_de_MecanismoFilter { set; get; }
        public string AdvanceTipo_de_Mecanismo { set; get; }
        public int[] AdvanceTipo_de_MecanismoMultiple { set; get; }

        public Filters Observaciones_SolicitudFilter { set; get; }
        public string Observaciones_Solicitud { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_Validacion { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_Validacion", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_Validacion { set; get; }

        public string ToHora_Validacion { set; get; }
        public string FromHora_Validacion { set; get; }

        public Filters Usuario_que_ValidaFilter { set; get; }
        public string AdvanceUsuario_que_Valida { set; get; }
        public int[] AdvanceUsuario_que_ValidaMultiple { set; get; }

        public Filters Autoriza_Cierre_de_ExpedienteFilter { set; get; }
        public string AdvanceAutoriza_Cierre_de_Expediente { set; get; }
        public int[] AdvanceAutoriza_Cierre_de_ExpedienteMultiple { set; get; }

        public Filters Motivo_de_Rechazo_SolicitudFilter { set; get; }
        public string Motivo_de_Rechazo_Solicitud { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Resolucion_Procedimiento { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Resolucion_Procedimiento", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Resolucion_Procedimiento { set; get; }

        public string ToHora_de_Resolucion_Procedimiento { set; get; }
        public string FromHora_de_Resolucion_Procedimiento { set; get; }

        public Filters Resolucion_de_ProcedimientoFilter { set; get; }
        public string AdvanceResolucion_de_Procedimiento { set; get; }
        public int[] AdvanceResolucion_de_ProcedimientoMultiple { set; get; }

        public Filters Usuario_que_Resuelve_ProcedimientoFilter { set; get; }
        public string AdvanceUsuario_que_Resuelve_Procedimiento { set; get; }
        public int[] AdvanceUsuario_que_Resuelve_ProcedimientoMultiple { set; get; }

        public Filters Observaciones_ProcedimientoFilter { set; get; }
        public string Observaciones_Procedimiento { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Validacion_Procedimiento { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Validacion_Procedimiento", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Validacion_Procedimiento { set; get; }

        public string ToHora_de_Validacion_Procedimiento { set; get; }
        public string FromHora_de_Validacion_Procedimiento { set; get; }

        public Filters Usuario_que_Valida_ProcedimientoFilter { set; get; }
        public string AdvanceUsuario_que_Valida_Procedimiento { set; get; }
        public int[] AdvanceUsuario_que_Valida_ProcedimientoMultiple { set; get; }

        public Filters Resultado_ProcedimientoFilter { set; get; }
        public string AdvanceResultado_Procedimiento { set; get; }
        public int[] AdvanceResultado_ProcedimientoMultiple { set; get; }

        public Filters Motivo_de_Rechazo_ProcedimientoFilter { set; get; }
        public string Motivo_de_Rechazo_Procedimiento { set; get; }


    }
}
