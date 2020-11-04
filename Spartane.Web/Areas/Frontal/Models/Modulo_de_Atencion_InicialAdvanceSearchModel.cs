using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Modulo_de_Atencion_InicialAdvanceSearchModel
    {
        public Modulo_de_Atencion_InicialAdvanceSearchModel()
        {
            Menor_de_Edad = RadioOptions.NoApply;
            Representante_Legal = RadioOptions.NoApply;
            Atencion_Medica = RadioOptions.NoApply;
            Atencion_Psicologica = RadioOptions.NoApply;
            Requiere_Traductor = RadioOptions.NoApply;

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromFolio { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromFolio", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFolio { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Registro { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Registro", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Registro { set; get; }

        public string ToHora_de_Registro { set; get; }
        public string FromHora_de_Registro { set; get; }

        public Filters NUATFilter { set; get; }
        public string NUAT { set; get; }

        public Filters Usuario_que_RegistraFilter { set; get; }
        public string AdvanceUsuario_que_Registra { set; get; }
        public int[] AdvanceUsuario_que_RegistraMultiple { set; get; }

        public Filters NombreFilter { set; get; }
        public string Nombre { set; get; }

        public Filters Apellido_PaternoFilter { set; get; }
        public string Apellido_Paterno { set; get; }

        public Filters Apellido_MaternoFilter { set; get; }
        public string Apellido_Materno { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Nacimiento { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Nacimiento", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Nacimiento { set; get; }

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

        public Filters Numero_de_IdentificacionFilter { set; get; }
        public string Numero_de_Identificacion { set; get; }

        public Filters NacionalidadFilter { set; get; }
        public string AdvanceNacionalidad { set; get; }
        public int[] AdvanceNacionalidadMultiple { set; get; }

        public Filters EscolaridadFilter { set; get; }
        public string AdvanceEscolaridad { set; get; }
        public int[] AdvanceEscolaridadMultiple { set; get; }

        public Filters OcupacionFilter { set; get; }
        public string AdvanceOcupacion { set; get; }
        public int[] AdvanceOcupacionMultiple { set; get; }

        public Filters CalleFilter { set; get; }
        public string Calle { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromNumero_Exterior { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromNumero_Exterior", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToNumero_Exterior { set; get; }

        public Filters Numero_InteriorFilter { set; get; }
        public string Numero_Interior { set; get; }

        public Filters ColoniaFilter { set; get; }
        public string AdvanceColonia { set; get; }
        public int[] AdvanceColoniaMultiple { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromCodigo_Postal { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromCodigo_Postal", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToCodigo_Postal { set; get; }

        public Filters ZonaFilter { set; get; }
        public string AdvanceZona { set; get; }
        public int[] AdvanceZonaMultiple { set; get; }

        public Filters MunicipioFilter { set; get; }
        public string AdvanceMunicipio { set; get; }
        public int[] AdvanceMunicipioMultiple { set; get; }

        public Filters EstadoFilter { set; get; }
        public string AdvanceEstado { set; get; }
        public int[] AdvanceEstadoMultiple { set; get; }

        public Filters TelefonoFilter { set; get; }
        public string Telefono { set; get; }

        public Filters CelularFilter { set; get; }
        public string Celular { set; get; }

        public Filters Correo_ElectronicoFilter { set; get; }
        public string Correo_Electronico { set; get; }

        public RadioOptions Menor_de_Edad { set; get; }

        public RadioOptions Representante_Legal { set; get; }

        public Filters Nombre_del_TutorFilter { set; get; }
        public string Nombre_del_Tutor { set; get; }

        public Filters Apellido_Paterno_del_TutorFilter { set; get; }
        public string Apellido_Paterno_del_Tutor { set; get; }

        public Filters Apellido_Materno_del_TutorFilter { set; get; }
        public string Apellido_Materno_del_Tutor { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Nacimiento_del_Tutor { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Nacimiento_del_Tutor", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Nacimiento_del_Tutor { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromEdad_del_Tutor { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromEdad_del_Tutor", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToEdad_del_Tutor { set; get; }

        public Filters Sexo_del_TutorFilter { set; get; }
        public string AdvanceSexo_del_Tutor { set; get; }
        public int[] AdvanceSexo_del_TutorMultiple { set; get; }

        public Filters Estado_Civil_del_TutorFilter { set; get; }
        public string AdvanceEstado_Civil_del_Tutor { set; get; }
        public int[] AdvanceEstado_Civil_del_TutorMultiple { set; get; }

        public Filters Tipo_de_Identificacion_del_TutorFilter { set; get; }
        public string AdvanceTipo_de_Identificacion_del_Tutor { set; get; }
        public int[] AdvanceTipo_de_Identificacion_del_TutorMultiple { set; get; }

        public Filters Numero_de_Identificacion_del_TutorFilter { set; get; }
        public string Numero_de_Identificacion_del_Tutor { set; get; }

        public Filters Nacionalidad_del_TutorFilter { set; get; }
        public string AdvanceNacionalidad_del_Tutor { set; get; }
        public int[] AdvanceNacionalidad_del_TutorMultiple { set; get; }

        public Filters Escolaridad_del_TutorFilter { set; get; }
        public string AdvanceEscolaridad_del_Tutor { set; get; }
        public int[] AdvanceEscolaridad_del_TutorMultiple { set; get; }

        public Filters Ocupacion_del_TutorFilter { set; get; }
        public string AdvanceOcupacion_del_Tutor { set; get; }
        public int[] AdvanceOcupacion_del_TutorMultiple { set; get; }

        public Filters Calle_del_TutorFilter { set; get; }
        public string Calle_del_Tutor { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromNumero_Exterior_del_Tutor { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromNumero_Exterior_del_Tutor", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToNumero_Exterior_del_Tutor { set; get; }

        public Filters Numero_Interior_del_TutorFilter { set; get; }
        public string Numero_Interior_del_Tutor { set; get; }

        public Filters Colonia_del_TutorFilter { set; get; }
        public string AdvanceColonia_del_Tutor { set; get; }
        public int[] AdvanceColonia_del_TutorMultiple { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromCodigo_Postal_del_Tutor { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromCodigo_Postal_del_Tutor", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToCodigo_Postal_del_Tutor { set; get; }

        public Filters Localidad_del_TutorFilter { set; get; }
        public string AdvanceLocalidad_del_Tutor { set; get; }
        public int[] AdvanceLocalidad_del_TutorMultiple { set; get; }

        public Filters Municipio_del_TutorFilter { set; get; }
        public string AdvanceMunicipio_del_Tutor { set; get; }
        public int[] AdvanceMunicipio_del_TutorMultiple { set; get; }

        public Filters Estado_del_TutorFilter { set; get; }
        public string AdvanceEstado_del_Tutor { set; get; }
        public int[] AdvanceEstado_del_TutorMultiple { set; get; }

        public Filters Telefono_del_TutorFilter { set; get; }
        public string Telefono_del_Tutor { set; get; }

        public Filters Celular_del_TutorFilter { set; get; }
        public string Celular_del_Tutor { set; get; }

        public Filters Correo_Electronico_del_TutorFilter { set; get; }
        public string Correo_Electronico_del_Tutor { set; get; }

        public Filters Nombre_del_RepresentanteFilter { set; get; }
        public string Nombre_del_Representante { set; get; }

        public Filters Apellido_Paterno_del_RepresentanteFilter { set; get; }
        public string Apellido_Paterno_del_Representante { set; get; }

        public Filters Apellido_Materno_del_RepresentanteFilter { set; get; }
        public string Apellido_Materno_del_Representante { set; get; }

        public Filters Calidad_JuridicaFilter { set; get; }
        public string Calidad_Juridica { set; get; }

        public Filters Calle_del_RepresentanteFilter { set; get; }
        public string Calle_del_Representante { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromNumero_Exterior_del_Representante { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromNumero_Exterior_del_Representante", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToNumero_Exterior_del_Representante { set; get; }

        public Filters Numero_Interior_del_RepresentanteFilter { set; get; }
        public string Numero_Interior_del_Representante { set; get; }

        public Filters Colonia_del_RepresentanteFilter { set; get; }
        public string AdvanceColonia_del_Representante { set; get; }
        public int[] AdvanceColonia_del_RepresentanteMultiple { set; get; }

        public Filters Localidad_del_RepresentanteFilter { set; get; }
        public string AdvanceLocalidad_del_Representante { set; get; }
        public int[] AdvanceLocalidad_del_RepresentanteMultiple { set; get; }

        public Filters Municipio_del_RepresentanteFilter { set; get; }
        public string AdvanceMunicipio_del_Representante { set; get; }
        public int[] AdvanceMunicipio_del_RepresentanteMultiple { set; get; }

        public Filters Estado_del_RepresentanteFilter { set; get; }
        public string AdvanceEstado_del_Representante { set; get; }
        public int[] AdvanceEstado_del_RepresentanteMultiple { set; get; }

        public Filters Telefono_del_RepresentanteFilter { set; get; }
        public string Telefono_del_Representante { set; get; }

        public Filters Celular_del_RepresentanteFilter { set; get; }
        public string Celular_del_Representante { set; get; }

        public Filters Correo_Electronico_del_RepresentanteFilter { set; get; }
        public string Correo_Electronico_del_Representante { set; get; }

        public Filters NarrativaFilter { set; get; }
        public string Narrativa { set; get; }

        public RadioOptions Atencion_Medica { set; get; }

        public RadioOptions Atencion_Psicologica { set; get; }

        public RadioOptions Requiere_Traductor { set; get; }

        public Filters Tipo_de_ComparecienteFilter { set; get; }
        public string AdvanceTipo_de_Compareciente { set; get; }
        public int[] AdvanceTipo_de_ComparecienteMultiple { set; get; }

        public Filters EstatusFilter { set; get; }
        public string AdvanceEstatus { set; get; }
        public int[] AdvanceEstatusMultiple { set; get; }

        public Filters Turno_AsignadoFilter { set; get; }
        public string AdvanceTurno_Asignado { set; get; }
        public int[] AdvanceTurno_AsignadoMultiple { set; get; }

        public Filters UnidadFilter { set; get; }
        public string AdvanceUnidad { set; get; }
        public int[] AdvanceUnidadMultiple { set; get; }

        public Filters Municipio_CasoFilter { set; get; }
        public string AdvanceMunicipio_Caso { set; get; }
        public int[] AdvanceMunicipio_CasoMultiple { set; get; }

        public Filters Tipo_de_DenunciaFilter { set; get; }
        public string AdvanceTipo_de_Denuncia { set; get; }
        public int[] AdvanceTipo_de_DenunciaMultiple { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromNumero_de_Expediente { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromNumero_de_Expediente", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToNumero_de_Expediente { set; get; }

        public Filters PoblacionFilter { set; get; }
        public string AdvancePoblacion { set; get; }
        public int[] AdvancePoblacionMultiple { set; get; }

        public Filters Colonia_Hechos_MPOFilter { set; get; }
        public string AdvanceColonia_Hechos_MPO { set; get; }
        public int[] AdvanceColonia_Hechos_MPOMultiple { set; get; }


    }
}
