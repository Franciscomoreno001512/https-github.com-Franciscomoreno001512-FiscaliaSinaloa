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
            Documento_Extraviado_hechos = RadioOptions.NoApply;
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

        public Filters Solicitud_de_Denuncia_CiudadanaFilter { set; get; }
        public string AdvanceSolicitud_de_Denuncia_Ciudadana { set; get; }
        public int[] AdvanceSolicitud_de_Denuncia_CiudadanaMultiple { set; get; }

        public Filters Motivo_Finalizacion_TurnoFilter { set; get; }
        public string AdvanceMotivo_Finalizacion_Turno { set; get; }
        public int[] AdvanceMotivo_Finalizacion_TurnoMultiple { set; get; }

        public Filters Observaciones_turnoFilter { set; get; }
        public string Observaciones_turno { set; get; }

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

        public Filters Referencia_hechosFilter { set; get; }
        public string Referencia_hechos { set; get; }

        public Filters LatitudFilter { set; get; }
        public string Latitud { set; get; }

        public Filters LongitudFilter { set; get; }
        public string Longitud { set; get; }

        public RadioOptions Documento_Extraviado_hechos { set; get; }

        public Filters Tipo_de_Documento_ExtraviadoFilter { set; get; }
        public string AdvanceTipo_de_Documento_Extraviado { set; get; }
        public int[] AdvanceTipo_de_Documento_ExtraviadoMultiple { set; get; }

        public Filters Tipo_de_Lugar_del_HechoFilter { set; get; }
        public string AdvanceTipo_de_Lugar_del_Hecho { set; get; }
        public int[] AdvanceTipo_de_Lugar_del_HechoMultiple { set; get; }

        public Filters Zona_de_los_HechosFilter { set; get; }
        public string AdvanceZona_de_los_Hechos { set; get; }
        public int[] AdvanceZona_de_los_HechosMultiple { set; get; }

        public Filters TurnoFilter { set; get; }
        public string Turno { set; get; }

        public RadioOptions Cerrar { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Cierre { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Cierre", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Cierre { set; get; }

        public string ToHora_de_Cierre { set; get; }
        public string FromHora_de_Cierre { set; get; }


    }
}
