using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Expediente_InicialAdvanceSearchModel
    {
        public Expediente_InicialAdvanceSearchModel()
        {
            Persona_Moral = RadioOptions.NoApply;
            Requiere_Diligencia = RadioOptions.NoApply;
            Requiere_Traductor = RadioOptions.NoApply;
            Asignar_Agente_del_Ministerio_Publico = RadioOptions.NoApply;
            Solicitar_Diligencias = RadioOptions.NoApply;
            Acepta_Acuerdo = RadioOptions.NoApply;

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

        public string ToHora_de_Registro { set; get; }
        public string FromHora_de_Registro { set; get; }

        public Filters Usuario_que_RegistraFilter { set; get; }
        public string AdvanceUsuario_que_Registra { set; get; }
        public int[] AdvanceUsuario_que_RegistraMultiple { set; get; }

        public Filters DetenidoFilter { set; get; }
        public string AdvanceDetenido { set; get; }
        public int[] AdvanceDetenidoMultiple { set; get; }

        public Filters NUCFilter { set; get; }
        public string NUC { set; get; }

        public Filters NICFilter { set; get; }
        public string NIC { set; get; }

        public string ToHora_del_Detenido { set; get; }
        public string FromHora_del_Detenido { set; get; }

        public string ToHora_Puesto_a_Disposicion { set; get; }
        public string FromHora_Puesto_a_Disposicion { set; get; }

        public Filters Solicitar_Servicos_de_ApoyoFilter { set; get; }
        public string AdvanceSolicitar_Servicos_de_Apoyo { set; get; }
        public int[] AdvanceSolicitar_Servicos_de_ApoyoMultiple { set; get; }

        public Filters Narrativa_Breve_de_los_HechosFilter { set; get; }
        public string Narrativa_Breve_de_los_Hechos { set; get; }

        public Filters Prioridad_del_HechoFilter { set; get; }
        public string AdvancePrioridad_del_Hecho { set; get; }
        public int[] AdvancePrioridad_del_HechoMultiple { set; get; }

        public Filters TurnoFilter { set; get; }
        public string Turno { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_del_Hecho { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_del_Hecho", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_del_Hecho { set; get; }

        public string ToHora_del_Hecho { set; get; }
        public string FromHora_del_Hecho { set; get; }

        public Filters Pais_de_los_Hechos_MPIFilter { set; get; }
        public string AdvancePais_de_los_Hechos_MPI { set; get; }
        public int[] AdvancePais_de_los_Hechos_MPIMultiple { set; get; }

        public Filters Estado_de_los_Hechos_MPIFilter { set; get; }
        public string AdvanceEstado_de_los_Hechos_MPI { set; get; }
        public int[] AdvanceEstado_de_los_Hechos_MPIMultiple { set; get; }

        public Filters Municipio_de_los_Hechos_MPIFilter { set; get; }
        public string AdvanceMunicipio_de_los_Hechos_MPI { set; get; }
        public int[] AdvanceMunicipio_de_los_Hechos_MPIMultiple { set; get; }

        public Filters Colonia_de_los_Hechos_MPIFilter { set; get; }
        public string AdvanceColonia_de_los_Hechos_MPI { set; get; }
        public int[] AdvanceColonia_de_los_Hechos_MPIMultiple { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromCodigo_Postal_de_los_Hechos_MPI { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromCodigo_Postal_de_los_Hechos_MPI", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToCodigo_Postal_de_los_Hechos_MPI { set; get; }

        public Filters Calle_de_los_Hechos_MPIFilter { set; get; }
        public string Calle_de_los_Hechos_MPI { set; get; }

        public Filters Entre_Calle_MPIFilter { set; get; }
        public string Entre_Calle_MPI { set; get; }

        public Filters Y_Calle_MPIFilter { set; get; }
        public string Y_Calle_MPI { set; get; }

        public Filters Numero_Exrterior_de_los_Hechos_MPIFilter { set; get; }
        public string Numero_Exrterior_de_los_Hechos_MPI { set; get; }

        public Filters Numero_Interior_de_los_Hechos_MPIFilter { set; get; }
        public string Numero_Interior_de_los_Hechos_MPI { set; get; }

        public Filters Latitud_MPIFilter { set; get; }
        public string Latitud_MPI { set; get; }

        public Filters Longitud_MPIFilter { set; get; }
        public string Longitud_MPI { set; get; }

        public Filters Tipo_de_Lugar_del_Hecho_MPIFilter { set; get; }
        public string AdvanceTipo_de_Lugar_del_Hecho_MPI { set; get; }
        public int[] AdvanceTipo_de_Lugar_del_Hecho_MPIMultiple { set; get; }

        public RadioOptions Persona_Moral { set; get; }

        public RadioOptions Requiere_Diligencia { set; get; }

        public Filters Numero_de_Expediente_VictimaFilter { set; get; }
        public string Numero_de_Expediente_Victima { set; get; }

        public RadioOptions Requiere_Traductor { set; get; }

        public Filters Lengua_OriginariaFilter { set; get; }
        public string AdvanceLengua_Originaria { set; get; }
        public int[] AdvanceLengua_OriginariaMultiple { set; get; }

        public Filters IdiomaFilter { set; get; }
        public string AdvanceIdioma { set; get; }
        public int[] AdvanceIdiomaMultiple { set; get; }

        public Filters Titulo_del_HechoFilter { set; get; }
        public string Titulo_del_Hecho { set; get; }

        public RadioOptions Asignar_Agente_del_Ministerio_Publico { set; get; }

        public Filters Nombre_de_Agente_del_Ministerio_PublicoFilter { set; get; }
        public string AdvanceNombre_de_Agente_del_Ministerio_Publico { set; get; }
        public int[] AdvanceNombre_de_Agente_del_Ministerio_PublicoMultiple { set; get; }

        public Filters Tipo_de_OficioFilter { set; get; }
        public string AdvanceTipo_de_Oficio { set; get; }
        public int[] AdvanceTipo_de_OficioMultiple { set; get; }

        public Filters DelegacionFilter { set; get; }
        public string AdvanceDelegacion { set; get; }
        public int[] AdvanceDelegacionMultiple { set; get; }

        public Filters AgenciaFilter { set; get; }
        public string AdvanceAgencia { set; get; }
        public int[] AdvanceAgenciaMultiple { set; get; }

        public RadioOptions Solicitar_Diligencias { set; get; }

        public Filters NUC_AudienciasFilter { set; get; }
        public string NUC_Audiencias { set; get; }

        public Filters NIC_AudienciasFilter { set; get; }
        public string NIC_Audiencias { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Registro_Audiencias { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Registro_Audiencias", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Registro_Audiencias { set; get; }

        public string ToHora_de_Registro_Audiencias { set; get; }
        public string FromHora_de_Registro_Audiencias { set; get; }

        public Filters Tipo_de_Oficio_AudienciasFilter { set; get; }
        public string AdvanceTipo_de_Oficio_Audiencias { set; get; }
        public int[] AdvanceTipo_de_Oficio_AudienciasMultiple { set; get; }

        public Filters Delegacion_AudienciasFilter { set; get; }
        public string AdvanceDelegacion_Audiencias { set; get; }
        public int[] AdvanceDelegacion_AudienciasMultiple { set; get; }

        public Filters Domicilio_Delegacion_AFilter { set; get; }
        public string Domicilio_Delegacion_A { set; get; }

        public Filters Numero_de_ExpedienteFilter { set; get; }
        public string Numero_de_Expediente { set; get; }

        public Filters NUATFilter { set; get; }
        public string NUAT { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_RegistroI { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_RegistroI", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_RegistroI { set; get; }

        public string ToHora_de_RegistroI { set; get; }
        public string FromHora_de_RegistroI { set; get; }

        public Filters EstatusFilter { set; get; }
        public string AdvanceEstatus { set; get; }
        public int[] AdvanceEstatusMultiple { set; get; }

        public Filters Canalizar_aFilter { set; get; }
        public string AdvanceCanalizar_a { set; get; }
        public int[] AdvanceCanalizar_aMultiple { set; get; }

        public Filters Delito_PrincipalFilter { set; get; }
        public string AdvanceDelito_Principal { set; get; }
        public int[] AdvanceDelito_PrincipalMultiple { set; get; }

        public Filters Tipo_de_AcuerdoFilter { set; get; }
        public string AdvanceTipo_de_Acuerdo { set; get; }
        public int[] AdvanceTipo_de_AcuerdoMultiple { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Inicio_de_Acuerdo { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Inicio_de_Acuerdo", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Inicio_de_Acuerdo { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Cumplimiento { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Cumplimiento", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Cumplimiento { set; get; }

        public string ToHora_de_Cumplimiento { set; get; }
        public string FromHora_de_Cumplimiento { set; get; }

        public Filters Domicilio_para_el_CumplimientoFilter { set; get; }
        public string Domicilio_para_el_Cumplimiento { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromMonto_de_Reparacion_de_Danos { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromMonto_de_Reparacion_de_Danos", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToMonto_de_Reparacion_de_Danos { set; get; }

        public Filters ParcialidadesFilter { set; get; }
        public string Parcialidades { set; get; }

        public Filters PeriodicidadFilter { set; get; }
        public string AdvancePeriodicidad { set; get; }
        public int[] AdvancePeriodicidadMultiple { set; get; }

        public RadioOptions Acepta_Acuerdo { set; get; }

        public Filters Motivo_de_Rechazo_de_AcuerdoFilter { set; get; }
        public string Motivo_de_Rechazo_de_Acuerdo { set; get; }


    }
}
