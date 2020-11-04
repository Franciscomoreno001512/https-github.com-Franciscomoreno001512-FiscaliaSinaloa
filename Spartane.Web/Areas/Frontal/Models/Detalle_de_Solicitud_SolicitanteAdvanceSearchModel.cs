using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Solicitud_SolicitanteAdvanceSearchModel
    {
        public Detalle_de_Solicitud_SolicitanteAdvanceSearchModel()
        {
            Incapaz = RadioOptions.NoApply;

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromidRegistroAT { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromidRegistroAT", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToidRegistroAT { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromidRegistroUI { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromidRegistroUI", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToidRegistroUI { set; get; }

        public Filters SolicitudFilter { set; get; }
        public string AdvanceSolicitud { set; get; }
        public int[] AdvanceSolicitudMultiple { set; get; }

        public Filters NombreFilter { set; get; }
        public string Nombre { set; get; }

        public Filters Apellido_PaternoFilter { set; get; }
        public string Apellido_Paterno { set; get; }

        public Filters Apellido_MaternoFilter { set; get; }
        public string Apellido_Materno { set; get; }

        public Filters Nombre_CompletoFilter { set; get; }
        public string Nombre_Completo { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Nacimiento { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Nacimiento", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Nacimiento { set; get; }

        public Filters CURPFilter { set; get; }
        public string CURP { set; get; }

        public Filters RFCFilter { set; get; }
        public string RFC { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromEdad { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromEdad", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToEdad { set; get; }

        public Filters SexoFilter { set; get; }
        public string AdvanceSexo { set; get; }
        public int[] AdvanceSexoMultiple { set; get; }

        public Filters Estado_CivilFilter { set; get; }
        public string AdvanceEstado_Civil { set; get; }
        public int[] AdvanceEstado_CivilMultiple { set; get; }

        public Filters Tipo_de_IdentificacionFilter { set; get; }
        public string AdvanceTipo_de_Identificacion { set; get; }
        public int[] AdvanceTipo_de_IdentificacionMultiple { set; get; }

        public Filters Numero_de_IndentificacionFilter { set; get; }
        public string Numero_de_Indentificacion { set; get; }

        public Filters NacionalidadFilter { set; get; }
        public string AdvanceNacionalidad { set; get; }
        public int[] AdvanceNacionalidadMultiple { set; get; }

        public Filters EscolaridadFilter { set; get; }
        public string AdvanceEscolaridad { set; get; }
        public int[] AdvanceEscolaridadMultiple { set; get; }

        public Filters OcupacionFilter { set; get; }
        public string AdvanceOcupacion { set; get; }
        public int[] AdvanceOcupacionMultiple { set; get; }

        public Filters PaisFilter { set; get; }
        public string AdvancePais { set; get; }
        public int[] AdvancePaisMultiple { set; get; }

        public Filters EstadoFilter { set; get; }
        public string AdvanceEstado { set; get; }
        public int[] AdvanceEstadoMultiple { set; get; }

        public Filters MunicipioFilter { set; get; }
        public string AdvanceMunicipio { set; get; }
        public int[] AdvanceMunicipioMultiple { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromCodigo_Postal { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromCodigo_Postal", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToCodigo_Postal { set; get; }

        public Filters PoblacionFilter { set; get; }
        public string AdvancePoblacion { set; get; }
        public int[] AdvancePoblacionMultiple { set; get; }

        public Filters ColoniaFilter { set; get; }
        public string AdvanceColonia { set; get; }
        public int[] AdvanceColoniaMultiple { set; get; }

        public Filters CalleFilter { set; get; }
        public string Calle { set; get; }

        public Filters Numero_ExteriorFilter { set; get; }
        public string Numero_Exterior { set; get; }

        public Filters Numero_InteriorFilter { set; get; }
        public string Numero_Interior { set; get; }

        public Filters Entre_CalleFilter { set; get; }
        public string Entre_Calle { set; get; }

        public Filters Y_CalleFilter { set; get; }
        public string Y_Calle { set; get; }

        public Filters LongitudFilter { set; get; }
        public string Longitud { set; get; }

        public Filters LatitudFilter { set; get; }
        public string Latitud { set; get; }

        public Filters TelefonoFilter { set; get; }
        public string Telefono { set; get; }

        public Filters CelularFilter { set; get; }
        public string Celular { set; get; }

        public Filters Correo_ElectronicoFilter { set; get; }
        public string Correo_Electronico { set; get; }

        public Filters Pais_de_OrigenFilter { set; get; }
        public string AdvancePais_de_Origen { set; get; }
        public int[] AdvancePais_de_OrigenMultiple { set; get; }

        public Filters Originario_deFilter { set; get; }
        public string Originario_de { set; get; }

        public Filters Tipo_de_ComparecienteFilter { set; get; }
        public string AdvanceTipo_de_Compareciente { set; get; }
        public int[] AdvanceTipo_de_ComparecienteMultiple { set; get; }

        public RadioOptions Incapaz { set; get; }

        public Filters Tipo_de_InimputabilidadFilter { set; get; }
        public string AdvanceTipo_de_Inimputabilidad { set; get; }
        public int[] AdvanceTipo_de_InimputabilidadMultiple { set; get; }

        public Filters Nombre_tutorFilter { set; get; }
        public string Nombre_tutor { set; get; }

        public Filters Apellido_Paterno_tutorFilter { set; get; }
        public string Apellido_Paterno_tutor { set; get; }

        public Filters Apellido_Materno_tutorFilter { set; get; }
        public string Apellido_Materno_tutor { set; get; }

        public Filters Nombre_Completo_tutorFilter { set; get; }
        public string Nombre_Completo_tutor { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Nacimiento_tutor { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Nacimiento_tutor", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Nacimiento_tutor { set; get; }

        public Filters CURP_TutorFilter { set; get; }
        public string CURP_Tutor { set; get; }

        public Filters RFC_TutorFilter { set; get; }
        public string RFC_Tutor { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromEdad_tutor { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromEdad_tutor", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToEdad_tutor { set; get; }

        public Filters Sexo_tutorFilter { set; get; }
        public string AdvanceSexo_tutor { set; get; }
        public int[] AdvanceSexo_tutorMultiple { set; get; }

        public Filters Estado_Civil_tutorFilter { set; get; }
        public string AdvanceEstado_Civil_tutor { set; get; }
        public int[] AdvanceEstado_Civil_tutorMultiple { set; get; }

        public Filters Tipo_de_Identificacion_tutorFilter { set; get; }
        public string AdvanceTipo_de_Identificacion_tutor { set; get; }
        public int[] AdvanceTipo_de_Identificacion_tutorMultiple { set; get; }

        public Filters Numero_de_Identificacion_tutorFilter { set; get; }
        public string Numero_de_Identificacion_tutor { set; get; }

        public Filters Nacionalidad_tutorFilter { set; get; }
        public string AdvanceNacionalidad_tutor { set; get; }
        public int[] AdvanceNacionalidad_tutorMultiple { set; get; }

        public Filters Escolaridad_tutorFilter { set; get; }
        public string AdvanceEscolaridad_tutor { set; get; }
        public int[] AdvanceEscolaridad_tutorMultiple { set; get; }

        public Filters Ocupacion_tutorFilter { set; get; }
        public string AdvanceOcupacion_tutor { set; get; }
        public int[] AdvanceOcupacion_tutorMultiple { set; get; }

        public Filters Pais_tutorFilter { set; get; }
        public string AdvancePais_tutor { set; get; }
        public int[] AdvancePais_tutorMultiple { set; get; }

        public Filters Estado_tutorFilter { set; get; }
        public string AdvanceEstado_tutor { set; get; }
        public int[] AdvanceEstado_tutorMultiple { set; get; }

        public Filters Municipio_tutorFilter { set; get; }
        public string AdvanceMunicipio_tutor { set; get; }
        public int[] AdvanceMunicipio_tutorMultiple { set; get; }

        public Filters Localidad_tutorFilter { set; get; }
        public string AdvanceLocalidad_tutor { set; get; }
        public int[] AdvanceLocalidad_tutorMultiple { set; get; }

        public Filters Colonia_tutorFilter { set; get; }
        public string AdvanceColonia_tutor { set; get; }
        public int[] AdvanceColonia_tutorMultiple { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromCodigo_Postal_tutor { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromCodigo_Postal_tutor", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToCodigo_Postal_tutor { set; get; }

        public Filters Calle_tutorFilter { set; get; }
        public string Calle_tutor { set; get; }

        public Filters Numero_Exterior_tutorFilter { set; get; }
        public string Numero_Exterior_tutor { set; get; }

        public Filters Numero_Interior_tutorFilter { set; get; }
        public string Numero_Interior_tutor { set; get; }

        public Filters Telefono_tutorFilter { set; get; }
        public string Telefono_tutor { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromExtension_tutor { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromExtension_tutor", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToExtension_tutor { set; get; }

        public Filters Celular_tutorFilter { set; get; }
        public string Celular_tutor { set; get; }

        public Filters Correo_Electronico_tutorFilter { set; get; }
        public string Correo_Electronico_tutor { set; get; }

        public Filters Pais_de_Origen_TFilter { set; get; }
        public string AdvancePais_de_Origen_T { set; get; }
        public int[] AdvancePais_de_Origen_TMultiple { set; get; }

        public Filters Originario_de_TFilter { set; get; }
        public string Originario_de_T { set; get; }

        public Filters Titulo_del_HechoFilter { set; get; }
        public string Titulo_del_Hecho { set; get; }

        public Filters Narrativa_Breve_de_los_HechosFilter { set; get; }
        public string Narrativa_Breve_de_los_Hechos { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_del_Hecho { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_del_Hecho", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_del_Hecho { set; get; }

        public string ToHora_Aproximada_del_Hecho { set; get; }
        public string FromHora_Aproximada_del_Hecho { set; get; }

        public Filters Lugar_de_los_HechosFilter { set; get; }
        public string AdvanceLugar_de_los_Hechos { set; get; }
        public int[] AdvanceLugar_de_los_HechosMultiple { set; get; }

        public Filters Pais_HechosFilter { set; get; }
        public string AdvancePais_Hechos { set; get; }
        public int[] AdvancePais_HechosMultiple { set; get; }

        public Filters Estado_HechosFilter { set; get; }
        public string AdvanceEstado_Hechos { set; get; }
        public int[] AdvanceEstado_HechosMultiple { set; get; }

        public Filters Municipio_HechosFilter { set; get; }
        public string AdvanceMunicipio_Hechos { set; get; }
        public int[] AdvanceMunicipio_HechosMultiple { set; get; }

        public Filters Colonia_HechosFilter { set; get; }
        public string AdvanceColonia_Hechos { set; get; }
        public int[] AdvanceColonia_HechosMultiple { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromCodigo_Postal_Hechos { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromCodigo_Postal_Hechos", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToCodigo_Postal_Hechos { set; get; }

        public Filters Calle_HechosFilter { set; get; }
        public string Calle_Hechos { set; get; }

        public Filters Numero_Exterior_HechosFilter { set; get; }
        public string Numero_Exterior_Hechos { set; get; }

        public Filters Numero_Interior_HechosFilter { set; get; }
        public string Numero_Interior_Hechos { set; get; }

        public Filters Entre_Calle_HechosFilter { set; get; }
        public string Entre_Calle_Hechos { set; get; }

        public Filters y_Calle_HechosFilter { set; get; }
        public string y_Calle_Hechos { set; get; }

        public Filters Longitud_HechosFilter { set; get; }
        public string Longitud_Hechos { set; get; }

        public Filters Latitud_HFilter { set; get; }
        public string Latitud_H { set; get; }


    }
}
