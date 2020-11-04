using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Solicitud_RequeridoAdvanceSearchModel
    {
        public Detalle_de_Solicitud_RequeridoAdvanceSearchModel()
        {
            A_Quien_Sea_Responsable = RadioOptions.NoApply;
            Inimputable = RadioOptions.NoApply;
            Se_Presenta_con_Detenido = RadioOptions.NoApply;
            Suspension_Condicional = RadioOptions.NoApply;
            Viene_en_Estado_de_Ebriedad = RadioOptions.NoApply;
            Bajo_el_Efecto_de_una_Droga = RadioOptions.NoApply;
            Imagen_Tatuaje = RadioOptions.NoApply;

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

        public RadioOptions A_Quien_Sea_Responsable { set; get; }

        public Filters NombreFilter { set; get; }
        public string Nombre { set; get; }

        public Filters Apellido_PaternoFilter { set; get; }
        public string Apellido_Paterno { set; get; }

        public Filters Apellido_MaternoFilter { set; get; }
        public string Apellido_Materno { set; get; }

        public Filters Nombre_CompletoFilter { set; get; }
        public string Nombre_Completo { set; get; }

        public Filters AliasFilter { set; get; }
        public string Alias { set; get; }

        public Filters ApodoFilter { set; get; }
        public string Apodo { set; get; }

        public Filters CURPFilter { set; get; }
        public string CURP { set; get; }

        public Filters RFCFilter { set; get; }
        public string RFC { set; get; }

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

        public Filters Referencia_de_Domicilio_RequeridoFilter { set; get; }
        public string Referencia_de_Domicilio_Requerido { set; get; }

        public Filters LatitudFilter { set; get; }
        public string Latitud { set; get; }

        public Filters LongitudFilter { set; get; }
        public string Longitud { set; get; }

        public Filters TelefonoFilter { set; get; }
        public string Telefono { set; get; }

        public Filters ExtencionFilter { set; get; }
        public string Extencion { set; get; }

        public Filters CelularFilter { set; get; }
        public string Celular { set; get; }

        public Filters Correo_ElectronicoFilter { set; get; }
        public string Correo_Electronico { set; get; }

        public Filters Pais_de_OrigenFilter { set; get; }
        public string AdvancePais_de_Origen { set; get; }
        public int[] AdvancePais_de_OrigenMultiple { set; get; }

        public Filters Originario_deFilter { set; get; }
        public string Originario_de { set; get; }

        public Filters Estado_de_NacimientoFilter { set; get; }
        public string AdvanceEstado_de_Nacimiento { set; get; }
        public int[] AdvanceEstado_de_NacimientoMultiple { set; get; }

        public Filters Municipio_de_NacimientoFilter { set; get; }
        public string AdvanceMunicipio_de_Nacimiento { set; get; }
        public int[] AdvanceMunicipio_de_NacimientoMultiple { set; get; }

        public RadioOptions Inimputable { set; get; }

        public Filters Tipo_de_InimputabilidadFilter { set; get; }
        public string AdvanceTipo_de_Inimputabilidad { set; get; }
        public int[] AdvanceTipo_de_InimputabilidadMultiple { set; get; }

        public RadioOptions Se_Presenta_con_Detenido { set; get; }

        public Filters Folio_Registro_Nacional_de_DetencionesFilter { set; get; }
        public string Folio_Registro_Nacional_de_Detenciones { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Detencion { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Detencion", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Detencion { set; get; }

        public Filters Municipio_de_DetencionFilter { set; get; }
        public string AdvanceMunicipio_de_Detencion { set; get; }
        public int[] AdvanceMunicipio_de_DetencionMultiple { set; get; }

        public Filters CorporacionFilter { set; get; }
        public string AdvanceCorporacion { set; get; }
        public int[] AdvanceCorporacionMultiple { set; get; }

        public RadioOptions Suspension_Condicional { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Suspension_Condicional { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Suspension_Condicional", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Suspension_Condicional { set; get; }

        public Filters Lugar_donde_se_Encuentra_DetenidoFilter { set; get; }
        public string Lugar_donde_se_Encuentra_Detenido { set; get; }

        public Filters EtniaFilter { set; get; }
        public string AdvanceEtnia { set; get; }
        public int[] AdvanceEtniaMultiple { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromNo__de_Hijos { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromNo__de_Hijos", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToNo__de_Hijos { set; get; }

        public Filters ReligionFilter { set; get; }
        public string AdvanceReligion { set; get; }
        public int[] AdvanceReligionMultiple { set; get; }

        public Filters Servicio_MedicoFilter { set; get; }
        public string AdvanceServicio_Medico { set; get; }
        public int[] AdvanceServicio_MedicoMultiple { set; get; }

        public Filters EspecialidadFilter { set; get; }
        public string AdvanceEspecialidad { set; get; }
        public int[] AdvanceEspecialidadMultiple { set; get; }

        public Filters Estudios_SuperioresFilter { set; get; }
        public string AdvanceEstudios_Superiores { set; get; }
        public int[] AdvanceEstudios_SuperioresMultiple { set; get; }

        public Filters IdiomaFilter { set; get; }
        public string AdvanceIdioma { set; get; }
        public int[] AdvanceIdiomaMultiple { set; get; }

        public Filters Calidad_MigratoriaFilter { set; get; }
        public string AdvanceCalidad_Migratoria { set; get; }
        public int[] AdvanceCalidad_MigratoriaMultiple { set; get; }

        public Filters DialectoFilter { set; get; }
        public string AdvanceDialecto { set; get; }
        public int[] AdvanceDialectoMultiple { set; get; }

        public RadioOptions Viene_en_Estado_de_Ebriedad { set; get; }

        public RadioOptions Bajo_el_Efecto_de_una_Droga { set; get; }

        public Filters Nombre_de_DrogaFilter { set; get; }
        public string Nombre_de_Droga { set; get; }

        public Filters Discapacidad_MentalFilter { set; get; }
        public string AdvanceDiscapacidad_Mental { set; get; }
        public int[] AdvanceDiscapacidad_MentalMultiple { set; get; }

        public Filters Discapacidad_FisicaFilter { set; get; }
        public string AdvanceDiscapacidad_Fisica { set; get; }
        public int[] AdvanceDiscapacidad_FisicaMultiple { set; get; }

        public Filters Discapacidad_SensorialFilter { set; get; }
        public string AdvanceDiscapacidad_Sensorial { set; get; }
        public int[] AdvanceDiscapacidad_SensorialMultiple { set; get; }

        public Filters Discapacidad_PsicosocialFilter { set; get; }
        public string AdvanceDiscapacidad_Psicosocial { set; get; }
        public int[] AdvanceDiscapacidad_PsicosocialMultiple { set; get; }

        public Filters Nombre_de_TutorFilter { set; get; }
        public string Nombre_de_Tutor { set; get; }

        public Filters Apellido_Paterno_TutorFilter { set; get; }
        public string Apellido_Paterno_Tutor { set; get; }

        public Filters Apellido_Materno_TutorFilter { set; get; }
        public string Apellido_Materno_Tutor { set; get; }

        public Filters Nombre_Completo_TutorFilter { set; get; }
        public string Nombre_Completo_Tutor { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Nacimiento_tutor { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Nacimiento_tutor", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Nacimiento_tutor { set; get; }

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

        public Filters Poblacion_tutorFilter { set; get; }
        public string AdvancePoblacion_tutor { set; get; }
        public int[] AdvancePoblacion_tutorMultiple { set; get; }

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

        public Filters ReferenciaFilter { set; get; }
        public string Referencia { set; get; }

        public Filters Latitud_tutorFilter { set; get; }
        public string Latitud_tutor { set; get; }

        public Filters Longitud_tutorFilter { set; get; }
        public string Longitud_tutor { set; get; }

        public Filters Extension_tutorFilter { set; get; }
        public string Extension_tutor { set; get; }

        public Filters Celular_tutorFilter { set; get; }
        public string Celular_tutor { set; get; }

        public Filters Correo_Electronico_tutorFilter { set; get; }
        public string Correo_Electronico_tutor { set; get; }

        public Filters Pais_de_Origen_TutorFilter { set; get; }
        public string AdvancePais_de_Origen_Tutor { set; get; }
        public int[] AdvancePais_de_Origen_TutorMultiple { set; get; }

        public Filters Originario_de_TutorFilter { set; get; }
        public string Originario_de_Tutor { set; get; }

        public Filters CURP_TutorFilter { set; get; }
        public string CURP_Tutor { set; get; }

        public Filters RFC_TutorFilter { set; get; }
        public string RFC_Tutor { set; get; }

        public Filters Padecimiento_de_EnfermedadFilter { set; get; }
        public string Padecimiento_de_Enfermedad { set; get; }

        public Filters CejasFilter { set; get; }
        public string AdvanceCejas { set; get; }
        public int[] AdvanceCejasMultiple { set; get; }

        public Filters Tamano_de_CejasFilter { set; get; }
        public string AdvanceTamano_de_Cejas { set; get; }
        public int[] AdvanceTamano_de_CejasMultiple { set; get; }

        public Filters AnteojosFilter { set; get; }
        public string AdvanceAnteojos { set; get; }
        public int[] AdvanceAnteojosMultiple { set; get; }

        public Filters Forma_de_NarizFilter { set; get; }
        public string AdvanceForma_de_Nariz { set; get; }
        public int[] AdvanceForma_de_NarizMultiple { set; get; }

        public Filters Nariz_baseFilter { set; get; }
        public string AdvanceNariz_base { set; get; }
        public int[] AdvanceNariz_baseMultiple { set; get; }

        public Filters Grosor_de_LabiosFilter { set; get; }
        public string AdvanceGrosor_de_Labios { set; get; }
        public int[] AdvanceGrosor_de_LabiosMultiple { set; get; }

        public Filters Forma_de_MentonFilter { set; get; }
        public string AdvanceForma_de_Menton { set; get; }
        public int[] AdvanceForma_de_MentonMultiple { set; get; }

        public Filters Senas_ParticularesFilter { set; get; }
        public string AdvanceSenas_Particulares { set; get; }
        public int[] AdvanceSenas_ParticularesMultiple { set; get; }

        public RadioOptions Imagen_Tatuaje { set; get; }

        public Filters Otras_Senas_ParticularesFilter { set; get; }
        public string Otras_Senas_Particulares { set; get; }

        public Filters Imputado_RecluidoFilter { set; get; }
        public string Imputado_Recluido { set; get; }


    }
}
