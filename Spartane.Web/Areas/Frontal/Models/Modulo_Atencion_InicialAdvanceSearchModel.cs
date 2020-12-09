using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Modulo_Atencion_InicialAdvanceSearchModel
    {
        public Modulo_Atencion_InicialAdvanceSearchModel()
        {
            Urgencia_turno = RadioOptions.NoApply;
            Requiere_Traductor = RadioOptions.NoApply;
            Autoriza_Traductor = RadioOptions.NoApply;
            Finalizar_Servicios_de_Apoyo = RadioOptions.NoApply;
            Enviar_a_MP = RadioOptions.NoApply;
            Correccion_de_Estatus = RadioOptions.NoApply;
            Requiere_Servicios_de_Apoyo = RadioOptions.NoApply;
            Persona_Moral = RadioOptions.NoApply;
            Se_Acepta_Acuerdo = RadioOptions.NoApply;
            Cerrar = RadioOptions.NoApply;

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters FolioFilter { set; get; }
        public string Folio { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Registro { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Registro", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Registro { set; get; }

        public string ToHora_de_Registro { set; get; }
        public string FromHora_de_Registro { set; get; }

        public Filters Turno_AsignadoFilter { set; get; }
        public string AdvanceTurno_Asignado { set; get; }
        public int[] AdvanceTurno_AsignadoMultiple { set; get; }

        public Filters Usuario_que_RegistraFilter { set; get; }
        public string AdvanceUsuario_que_Registra { set; get; }
        public int[] AdvanceUsuario_que_RegistraMultiple { set; get; }

        public Filters UnidadFilter { set; get; }
        public string AdvanceUnidad { set; get; }
        public int[] AdvanceUnidadMultiple { set; get; }

        public Filters MunicipioFilter { set; get; }
        public string AdvanceMunicipio { set; get; }
        public int[] AdvanceMunicipioMultiple { set; get; }

        public Filters RegionFilter { set; get; }
        public string AdvanceRegion { set; get; }
        public int[] AdvanceRegionMultiple { set; get; }

        public Filters Tipo_de_DenunciaFilter { set; get; }
        public string AdvanceTipo_de_Denuncia { set; get; }
        public int[] AdvanceTipo_de_DenunciaMultiple { set; get; }

        public Filters NUATFilter { set; get; }
        public string NUAT { set; get; }

        public Filters CDIFilter { set; get; }
        public string CDI { set; get; }

        public Filters Expedientes_RelacionadosFilter { set; get; }
        public string Expedientes_Relacionados { set; get; }

        public Filters EstatusFilter { set; get; }
        public string AdvanceEstatus { set; get; }
        public int[] AdvanceEstatusMultiple { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromGenerar_Cita { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromGenerar_Cita", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToGenerar_Cita { set; get; }

        public Filters Nombres_del_RemitenteFilter { set; get; }
        public string Nombres_del_Remitente { set; get; }

        public Filters Apellido_Paterno_del_RemitenteFilter { set; get; }
        public string Apellido_Paterno_del_Remitente { set; get; }

        public Filters Apellido_Materno_del_RemitenteFilter { set; get; }
        public string Apellido_Materno_del_Remitente { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_en_que_llega_para_validacion { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_en_que_llega_para_validacion", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_en_que_llega_para_validacion { set; get; }

        public Filters DelegacionFilter { set; get; }
        public string AdvanceDelegacion { set; get; }
        public int[] AdvanceDelegacionMultiple { set; get; }

        public Filters AgenciaFilter { set; get; }
        public string AdvanceAgencia { set; get; }
        public int[] AdvanceAgenciaMultiple { set; get; }

        public Filters Ministerio_Publico_en_TurnoFilter { set; get; }
        public string AdvanceMinisterio_Publico_en_Turno { set; get; }
        public int[] AdvanceMinisterio_Publico_en_TurnoMultiple { set; get; }

        public Filters Nombres_turnoFilter { set; get; }
        public string Nombres_turno { set; get; }

        public Filters Apellido_Paterno_turnoFilter { set; get; }
        public string Apellido_Paterno_turno { set; get; }

        public Filters Apellido_Materno_turnoFilter { set; get; }
        public string Apellido_Materno_turno { set; get; }

        public Filters Sexo_turnoFilter { set; get; }
        public string AdvanceSexo_turno { set; get; }
        public int[] AdvanceSexo_turnoMultiple { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromEdad_turno { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromEdad_turno", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToEdad_turno { set; get; }

        public Filters Tipo_de_Atencion_turnoFilter { set; get; }
        public string AdvanceTipo_de_Atencion_turno { set; get; }
        public int[] AdvanceTipo_de_Atencion_turnoMultiple { set; get; }

        public Filters Tipo_de_Identificacion_turnoFilter { set; get; }
        public string AdvanceTipo_de_Identificacion_turno { set; get; }
        public int[] AdvanceTipo_de_Identificacion_turnoMultiple { set; get; }

        public Filters Numero_de_Identificacion_turnoFilter { set; get; }
        public string Numero_de_Identificacion_turno { set; get; }

        public RadioOptions Urgencia_turno { set; get; }

        public Filters Tipo_de_Urgencia_turnoFilter { set; get; }
        public string AdvanceTipo_de_Urgencia_turno { set; get; }
        public int[] AdvanceTipo_de_Urgencia_turnoMultiple { set; get; }

        public Filters Motivo_Finalizacion_TurnoFilter { set; get; }
        public string AdvanceMotivo_Finalizacion_Turno { set; get; }
        public int[] AdvanceMotivo_Finalizacion_TurnoMultiple { set; get; }

        public Filters Observaciones_turnoFilter { set; get; }
        public string Observaciones_turno { set; get; }

        public RadioOptions Requiere_Traductor { set; get; }

        public Filters Lengua_OriginariaFilter { set; get; }
        public string AdvanceLengua_Originaria { set; get; }
        public int[] AdvanceLengua_OriginariaMultiple { set; get; }

        public Filters IdiomaFilter { set; get; }
        public string AdvanceIdioma { set; get; }
        public int[] AdvanceIdiomaMultiple { set; get; }

        public RadioOptions Autoriza_Traductor { set; get; }

        public RadioOptions Finalizar_Servicios_de_Apoyo { set; get; }

        public Filters Estatus2Filter { set; get; }
        public string AdvanceEstatus2 { set; get; }
        public int[] AdvanceEstatus2Multiple { set; get; }

        public Filters Unidad_canalizaFilter { set; get; }
        public string AdvanceUnidad_canaliza { set; get; }
        public int[] AdvanceUnidad_canalizaMultiple { set; get; }

        public RadioOptions Enviar_a_MP { set; get; }

        public RadioOptions Correccion_de_Estatus { set; get; }

        public RadioOptions Requiere_Servicios_de_Apoyo { set; get; }

        public RadioOptions Persona_Moral { set; get; }

        public Filters Titulo_del_HechoFilter { set; get; }
        public string Titulo_del_Hecho { set; get; }

        public Filters Narrativa_Breve_de_los_HechosFilter { set; get; }
        public string Narrativa_Breve_de_los_Hechos { set; get; }

        public Filters Prioridad_del_HechoFilter { set; get; }
        public string AdvancePrioridad_del_Hecho { set; get; }
        public int[] AdvancePrioridad_del_HechoMultiple { set; get; }

        public Filters OrientadorFilter { set; get; }
        public string AdvanceOrientador { set; get; }
        public int[] AdvanceOrientadorMultiple { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_del_Hecho { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_del_Hecho", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_del_Hecho { set; get; }

        public string ToHora_del_Hecho { set; get; }
        public string FromHora_del_Hecho { set; get; }

        public Filters Pais_de_los_HechosFilter { set; get; }
        public string AdvancePais_de_los_Hechos { set; get; }
        public int[] AdvancePais_de_los_HechosMultiple { set; get; }

        public Filters Estado_de_los_HechosFilter { set; get; }
        public string AdvanceEstado_de_los_Hechos { set; get; }
        public int[] AdvanceEstado_de_los_HechosMultiple { set; get; }

        public Filters Municipio_de_los_HechosFilter { set; get; }
        public string AdvanceMunicipio_de_los_Hechos { set; get; }
        public int[] AdvanceMunicipio_de_los_HechosMultiple { set; get; }

        public Filters PoblacionFilter { set; get; }
        public string AdvancePoblacion { set; get; }
        public int[] AdvancePoblacionMultiple { set; get; }

        public Filters Colonia_de_los_HechosFilter { set; get; }
        public string AdvanceColonia_de_los_Hechos { set; get; }
        public int[] AdvanceColonia_de_los_HechosMultiple { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromCodigo_Postal_de_los_Hechos { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromCodigo_Postal_de_los_Hechos", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToCodigo_Postal_de_los_Hechos { set; get; }

        public Filters Calle_de_los_HechosFilter { set; get; }
        public string Calle_de_los_Hechos { set; get; }

        public Filters Entre_CalleFilter { set; get; }
        public string Entre_Calle { set; get; }

        public Filters Y_CalleFilter { set; get; }
        public string Y_Calle { set; get; }

        public Filters Numero_Exrterior_de_los_HechosFilter { set; get; }
        public string Numero_Exrterior_de_los_Hechos { set; get; }

        public Filters Numero_Interior_de_los_HechosFilter { set; get; }
        public string Numero_Interior_de_los_Hechos { set; get; }

        public Filters LatitudFilter { set; get; }
        public string Latitud { set; get; }

        public Filters LongitudFilter { set; get; }
        public string Longitud { set; get; }

        public Filters Tipo_de_Lugar_del_HechoFilter { set; get; }
        public string AdvanceTipo_de_Lugar_del_Hecho { set; get; }
        public int[] AdvanceTipo_de_Lugar_del_HechoMultiple { set; get; }

        public Filters Zona_de_los_HechosFilter { set; get; }
        public string AdvanceZona_de_los_Hechos { set; get; }
        public int[] AdvanceZona_de_los_HechosMultiple { set; get; }

        public Filters TurnoFilter { set; get; }
        public string Turno { set; get; }

        public Filters Tipo_de_AcuerdoFilter { set; get; }
        public string AdvanceTipo_de_Acuerdo { set; get; }
        public int[] AdvanceTipo_de_AcuerdoMultiple { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Inicio_de_Acuerdo { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Inicio_de_Acuerdo", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Inicio_de_Acuerdo { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Cumplimiento_del_Acuerdo { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Cumplimiento_del_Acuerdo", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Cumplimiento_del_Acuerdo { set; get; }

        public string ToHora_de_Cumplimiento_del_Acuerdo { set; get; }
        public string FromHora_de_Cumplimiento_del_Acuerdo { set; get; }

        public Filters Domicilio_para_el_CumplimientoFilter { set; get; }
        public string Domicilio_para_el_Cumplimiento { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromMonto_de_Reparacion_de_Danos { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromMonto_de_Reparacion_de_Danos", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToMonto_de_Reparacion_de_Danos { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromParcialidades { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromParcialidades", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToParcialidades { set; get; }

        public Filters PeriodicidadFilter { set; get; }
        public string AdvancePeriodicidad { set; get; }
        public int[] AdvancePeriodicidadMultiple { set; get; }

        public RadioOptions Se_Acepta_Acuerdo { set; get; }

        public Filters Motivo_de_Rechazo_de_AcuerdoFilter { set; get; }
        public string Motivo_de_Rechazo_de_Acuerdo { set; get; }

        public RadioOptions Cerrar { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Cierre { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Cierre", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Cierre { set; get; }

        public string ToHora_de_Cierre { set; get; }
        public string FromHora_de_Cierre { set; get; }

        public Filters NUCFilter { set; get; }
        public string NUC { set; get; }

        public Filters Fecha_de_Vencimiento_1Filter { set; get; }
        public string Fecha_de_Vencimiento_1 { set; get; }

        public Filters EspecialistaJAFilter { set; get; }
        public string EspecialistaJA { set; get; }

        public Filters Campo_Oculto1Filter { set; get; }
        public string Campo_Oculto1 { set; get; }

        public Filters JefeMPOFilter { set; get; }
        public string AdvanceJefeMPO { set; get; }
        public int[] AdvanceJefeMPOMultiple { set; get; }

        public Filters Campo_Oculto2Filter { set; get; }
        public string Campo_Oculto2 { set; get; }

        public Filters Campo_Oculto3Filter { set; get; }
        public string Campo_Oculto3 { set; get; }

        public Filters CoordinadorJAFilter { set; get; }
        public string AdvanceCoordinadorJA { set; get; }
        public int[] AdvanceCoordinadorJAMultiple { set; get; }

        public Filters EspJAFilter { set; get; }
        public string AdvanceEspJA { set; get; }
        public int[] AdvanceEspJAMultiple { set; get; }

        public Filters Ano_ActualFilter { set; get; }
        public string Ano_Actual { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromSecuencial { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromSecuencial", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToSecuencial { set; get; }


    }
}
