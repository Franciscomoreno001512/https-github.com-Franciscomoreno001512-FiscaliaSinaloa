using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_ImputadoAdvanceSearchModel
    {
        public Detalle_de_ImputadoAdvanceSearchModel()
        {
            Persona_Moral = RadioOptions.NoApply;
            Quien_Resulte_Responsable = RadioOptions.NoApply;
            Se_Presenta_con_Detenido = RadioOptions.NoApply;
            Incompleto = RadioOptions.NoApply;
            Viene_en_Estado_de_Ebriedad = RadioOptions.NoApply;
            Bajo_el_Efecto_de_una_Droga = RadioOptions.NoApply;
            Inimputable = RadioOptions.NoApply;
            Gravidez = RadioOptions.NoApply;
            Imagen_Tatuaje = RadioOptions.NoApply;

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public RadioOptions Persona_Moral { set; get; }

        public Filters Modulo_Atencion_InicialFilter { set; get; }
        public string AdvanceModulo_Atencion_Inicial { set; get; }
        public int[] AdvanceModulo_Atencion_InicialMultiple { set; get; }

        public Filters Expediente_MPFilter { set; get; }
        public string AdvanceExpediente_MP { set; get; }
        public int[] AdvanceExpediente_MPMultiple { set; get; }

        public RadioOptions Quien_Resulte_Responsable { set; get; }

        public RadioOptions Se_Presenta_con_Detenido { set; get; }

        public Filters Folio_Registro_Nacional_de_DetencionesFilter { set; get; }
        public string Folio_Registro_Nacional_de_Detenciones { set; get; }

        public Filters NombreFilter { set; get; }
        public string Nombre { set; get; }

        public Filters Apellido_PaternoFilter { set; get; }
        public string Apellido_Paterno { set; get; }

        public Filters Apellido_MaternoFilter { set; get; }
        public string Apellido_Materno { set; get; }

        public Filters Nombre_Completo_DetenidoFilter { set; get; }
        public string Nombre_Completo_Detenido { set; get; }

        public Filters AliasFilter { set; get; }
        public string Alias { set; get; }

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

        public Filters CURPFilter { set; get; }
        public string CURP { set; get; }

        public Filters RFCFilter { set; get; }
        public string RFC { set; get; }

        public Filters Calidad_JuridicaFilter { set; get; }
        public string Calidad_Juridica { set; get; }

        public Filters Razon_SocialFilter { set; get; }
        public string Razon_Social { set; get; }

        public Filters NacionalidadFilter { set; get; }
        public string AdvanceNacionalidad { set; get; }
        public int[] AdvanceNacionalidadMultiple { set; get; }

        public Filters EscolaridadFilter { set; get; }
        public string AdvanceEscolaridad { set; get; }
        public int[] AdvanceEscolaridadMultiple { set; get; }

        public Filters OcupacionFilter { set; get; }
        public string AdvanceOcupacion { set; get; }
        public int[] AdvanceOcupacionMultiple { set; get; }

        public Filters Pais_de_OrigenFilter { set; get; }
        public string AdvancePais_de_Origen { set; get; }
        public int[] AdvancePais_de_OrigenMultiple { set; get; }

        public Filters Originario_deFilter { set; get; }
        public string Originario_de { set; get; }

        public Filters PaisFilter { set; get; }
        public string AdvancePais { set; get; }
        public int[] AdvancePaisMultiple { set; get; }

        public Filters EstadoFilter { set; get; }
        public string AdvanceEstado { set; get; }
        public int[] AdvanceEstadoMultiple { set; get; }

        public Filters MunicipioFilter { set; get; }
        public string AdvanceMunicipio { set; get; }
        public int[] AdvanceMunicipioMultiple { set; get; }

        public Filters PoblacionFilter { set; get; }
        public string AdvancePoblacion { set; get; }
        public int[] AdvancePoblacionMultiple { set; get; }

        public Filters ColoniaFilter { set; get; }
        public string AdvanceColonia { set; get; }
        public int[] AdvanceColoniaMultiple { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromCodigo_Postal { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromCodigo_Postal", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToCodigo_Postal { set; get; }

        public Filters Calle_del_ImputadoFilter { set; get; }
        public string Calle_del_Imputado { set; get; }

        public Filters Numero_ExteriorFilter { set; get; }
        public string Numero_Exterior { set; get; }

        public Filters Numero_InteriorFilter { set; get; }
        public string Numero_Interior { set; get; }

        public Filters Referencia_de_DomicilioFilter { set; get; }
        public string Referencia_de_Domicilio { set; get; }

        public Filters LatitudFilter { set; get; }
        public string Latitud { set; get; }

        public Filters LongitudFilter { set; get; }
        public string Longitud { set; get; }

        public Filters TelefonoFilter { set; get; }
        public string Telefono { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromExtension { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromExtension", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToExtension { set; get; }

        public Filters CelularFilter { set; get; }
        public string Celular { set; get; }

        public Filters Correo_ElectronicoFilter { set; get; }
        public string Correo_Electronico { set; get; }

        public Filters ApodoFilter { set; get; }
        public string Apodo { set; get; }

        public Filters EtniaFilter { set; get; }
        public string AdvanceEtnia { set; get; }
        public int[] AdvanceEtniaMultiple { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromNo_de_Hijos { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromNo_de_Hijos", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToNo_de_Hijos { set; get; }

        public Filters ReligionFilter { set; get; }
        public string AdvanceReligion { set; get; }
        public int[] AdvanceReligionMultiple { set; get; }

        public Filters Servicio_MedicoFilter { set; get; }
        public string AdvanceServicio_Medico { set; get; }
        public int[] AdvanceServicio_MedicoMultiple { set; get; }

        public Filters Escolaridad_DetenidoFilter { set; get; }
        public string AdvanceEscolaridad_Detenido { set; get; }
        public int[] AdvanceEscolaridad_DetenidoMultiple { set; get; }

        public Filters EspecialidadFilter { set; get; }
        public string AdvanceEspecialidad { set; get; }
        public int[] AdvanceEspecialidadMultiple { set; get; }

        public Filters Estudios_SuperioresFilter { set; get; }
        public string AdvanceEstudios_Superiores { set; get; }
        public int[] AdvanceEstudios_SuperioresMultiple { set; get; }

        public RadioOptions Incompleto { set; get; }

        public Filters IdiomaFilter { set; get; }
        public string AdvanceIdioma { set; get; }
        public int[] AdvanceIdiomaMultiple { set; get; }

        public Filters Calidad_MigratoriaFilter { set; get; }
        public string AdvanceCalidad_Migratoria { set; get; }
        public int[] AdvanceCalidad_MigratoriaMultiple { set; get; }

        public Filters Estado_de_NacimientoFilter { set; get; }
        public string AdvanceEstado_de_Nacimiento { set; get; }
        public int[] AdvanceEstado_de_NacimientoMultiple { set; get; }

        public Filters Municipio_de_NacimientoFilter { set; get; }
        public string AdvanceMunicipio_de_Nacimiento { set; get; }
        public int[] AdvanceMunicipio_de_NacimientoMultiple { set; get; }

        public Filters DialectoFilter { set; get; }
        public string AdvanceDialecto { set; get; }
        public int[] AdvanceDialectoMultiple { set; get; }

        public RadioOptions Viene_en_Estado_de_Ebriedad { set; get; }

        public RadioOptions Bajo_el_Efecto_de_una_Droga { set; get; }

        public Filters Nombre_de_DrogaFilter { set; get; }
        public string Nombre_de_Droga { set; get; }

        public RadioOptions Inimputable { set; get; }

        public RadioOptions Gravidez { set; get; }

        public Filters Tipo_de_InimputabilidadFilter { set; get; }
        public string AdvanceTipo_de_Inimputabilidad { set; get; }
        public int[] AdvanceTipo_de_InimputabilidadMultiple { set; get; }

        public Filters EspecifiqueFilter { set; get; }
        public string Especifique { set; get; }

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

        public Filters Nombres2Filter { set; get; }
        public string Nombres2 { set; get; }

        public Filters Apellido_Paterno2Filter { set; get; }
        public string Apellido_Paterno2 { set; get; }

        public Filters Apellido_Materno2Filter { set; get; }
        public string Apellido_Materno2 { set; get; }

        public Filters Nombre_Completo2Filter { set; get; }
        public string Nombre_Completo2 { set; get; }

        public Filters Sexo2Filter { set; get; }
        public string AdvanceSexo2 { set; get; }
        public int[] AdvanceSexo2Multiple { set; get; }

        public Filters Nacionalidad2Filter { set; get; }
        public string AdvanceNacionalidad2 { set; get; }
        public int[] AdvanceNacionalidad2Multiple { set; get; }

        public Filters Escolaridad2Filter { set; get; }
        public string AdvanceEscolaridad2 { set; get; }
        public int[] AdvanceEscolaridad2Multiple { set; get; }

        public Filters ID_Estado_InstitucionFilter { set; get; }
        public string ID_Estado_Institucion { set; get; }

        public Filters PesoFilter { set; get; }
        public string Peso { set; get; }

        public Filters EstaturaFilter { set; get; }
        public string Estatura { set; get; }

        public Filters Padecimiento_de_EnfermedadFilter { set; get; }
        public string Padecimiento_de_Enfermedad { set; get; }

        public Filters Forma_CaraFilter { set; get; }
        public string AdvanceForma_Cara { set; get; }
        public int[] AdvanceForma_CaraMultiple { set; get; }

        public Filters CejasFilter { set; get; }
        public string AdvanceCejas { set; get; }
        public int[] AdvanceCejasMultiple { set; get; }

        public Filters Tamano_de_CejasFilter { set; get; }
        public string AdvanceTamano_de_Cejas { set; get; }
        public int[] AdvanceTamano_de_CejasMultiple { set; get; }

        public Filters Largo_de_CabelloFilter { set; get; }
        public string AdvanceLargo_de_Cabello { set; get; }
        public int[] AdvanceLargo_de_CabelloMultiple { set; get; }

        public Filters Cantidad_CabelloFilter { set; get; }
        public string AdvanceCantidad_Cabello { set; get; }
        public int[] AdvanceCantidad_CabelloMultiple { set; get; }

        public Filters Implantacion_CabelloFilter { set; get; }
        public string AdvanceImplantacion_Cabello { set; get; }
        public int[] AdvanceImplantacion_CabelloMultiple { set; get; }

        public Filters ComplexionFilter { set; get; }
        public string AdvanceComplexion { set; get; }
        public int[] AdvanceComplexionMultiple { set; get; }

        public Filters Color_PielFilter { set; get; }
        public string AdvanceColor_Piel { set; get; }
        public int[] AdvanceColor_PielMultiple { set; get; }

        public Filters FrenteFilter { set; get; }
        public string AdvanceFrente { set; get; }
        public int[] AdvanceFrenteMultiple { set; get; }

        public Filters Forma_CabelloFilter { set; get; }
        public string AdvanceForma_Cabello { set; get; }
        public int[] AdvanceForma_CabelloMultiple { set; get; }

        public Filters Color_CabelloFilter { set; get; }
        public string AdvanceColor_Cabello { set; get; }
        public int[] AdvanceColor_CabelloMultiple { set; get; }

        public Filters CalvicieFilter { set; get; }
        public string AdvanceCalvicie { set; get; }
        public int[] AdvanceCalvicieMultiple { set; get; }

        public Filters Color_OjosFilter { set; get; }
        public string AdvanceColor_Ojos { set; get; }
        public int[] AdvanceColor_OjosMultiple { set; get; }

        public Filters OjosFilter { set; get; }
        public string AdvanceOjos { set; get; }
        public int[] AdvanceOjosMultiple { set; get; }

        public Filters Forma_OjosFilter { set; get; }
        public string AdvanceForma_Ojos { set; get; }
        public int[] AdvanceForma_OjosMultiple { set; get; }

        public Filters AnteojosFilter { set; get; }
        public string AdvanceAnteojos { set; get; }
        public int[] AdvanceAnteojosMultiple { set; get; }

        public Filters Forma_de_NarizFilter { set; get; }
        public string AdvanceForma_de_Nariz { set; get; }
        public int[] AdvanceForma_de_NarizMultiple { set; get; }

        public Filters Nariz_BaseFilter { set; get; }
        public string AdvanceNariz_Base { set; get; }
        public int[] AdvanceNariz_BaseMultiple { set; get; }

        public Filters LabiosFilter { set; get; }
        public string AdvanceLabios { set; get; }
        public int[] AdvanceLabiosMultiple { set; get; }

        public Filters BocaFilter { set; get; }
        public string AdvanceBoca { set; get; }
        public int[] AdvanceBocaMultiple { set; get; }

        public Filters Grosor_de_LabiosFilter { set; get; }
        public string AdvanceGrosor_de_Labios { set; get; }
        public int[] AdvanceGrosor_de_LabiosMultiple { set; get; }

        public Filters MentonFilter { set; get; }
        public string AdvanceMenton { set; get; }
        public int[] AdvanceMentonMultiple { set; get; }

        public Filters Forma_de_MentonFilter { set; get; }
        public string AdvanceForma_de_Menton { set; get; }
        public int[] AdvanceForma_de_MentonMultiple { set; get; }

        public Filters BarbaFilter { set; get; }
        public string AdvanceBarba { set; get; }
        public int[] AdvanceBarbaMultiple { set; get; }

        public Filters Forma_OrejasFilter { set; get; }
        public string AdvanceForma_Orejas { set; get; }
        public int[] AdvanceForma_OrejasMultiple { set; get; }

        public Filters Tamano_OrejasFilter { set; get; }
        public string AdvanceTamano_Orejas { set; get; }
        public int[] AdvanceTamano_OrejasMultiple { set; get; }

        public Filters Tipo_LobuloFilter { set; get; }
        public string AdvanceTipo_Lobulo { set; get; }
        public int[] AdvanceTipo_LobuloMultiple { set; get; }

        public Filters BigoteFilter { set; get; }
        public string AdvanceBigote { set; get; }
        public int[] AdvanceBigoteMultiple { set; get; }

        public Filters Senas_ParticularesFilter { set; get; }
        public string AdvanceSenas_Particulares { set; get; }
        public int[] AdvanceSenas_ParticularesMultiple { set; get; }

        public RadioOptions Imagen_Tatuaje { set; get; }

        public Filters Situacion_FisicaFilter { set; get; }
        public string AdvanceSituacion_Fisica { set; get; }
        public int[] AdvanceSituacion_FisicaMultiple { set; get; }

        public Filters Otras_Senas_ParticularesFilter { set; get; }
        public string Otras_Senas_Particulares { set; get; }

        public Filters Imputado_RecluidoFilter { set; get; }
        public string Imputado_Recluido { set; get; }

        public Filters Narrativa_Breve_de_los_HechosFilter { set; get; }
        public string Narrativa_Breve_de_los_Hechos { set; get; }

        public Filters Prioridad_del_HechoFilter { set; get; }
        public string AdvancePrioridad_del_Hecho { set; get; }
        public int[] AdvancePrioridad_del_HechoMultiple { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_del_Hecho { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_del_Hecho", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_del_Hecho { set; get; }

        public string ToHora_Aproximada_del_Hecho { set; get; }
        public string FromHora_Aproximada_del_Hecho { set; get; }

        public Filters Pais_del_hechoFilter { set; get; }
        public string AdvancePais_del_hecho { set; get; }
        public int[] AdvancePais_del_hechoMultiple { set; get; }

        public Filters Estado_del_HechoFilter { set; get; }
        public string AdvanceEstado_del_Hecho { set; get; }
        public int[] AdvanceEstado_del_HechoMultiple { set; get; }

        public Filters Municipio_del_HechoFilter { set; get; }
        public string AdvanceMunicipio_del_Hecho { set; get; }
        public int[] AdvanceMunicipio_del_HechoMultiple { set; get; }

        public Filters Poblacion_HechosFilter { set; get; }
        public string AdvancePoblacion_Hechos { set; get; }
        public int[] AdvancePoblacion_HechosMultiple { set; get; }

        public Filters Colonia_del_hechoFilter { set; get; }
        public string AdvanceColonia_del_hecho { set; get; }
        public int[] AdvanceColonia_del_hechoMultiple { set; get; }

        public Filters Codigo_Postal_del_hechoFilter { set; get; }
        public string Codigo_Postal_del_hecho { set; get; }

        public Filters Calle_del_hechoFilter { set; get; }
        public string Calle_del_hecho { set; get; }

        public Filters Entre_CalleFilter { set; get; }
        public string Entre_Calle { set; get; }

        public Filters Y_CalleFilter { set; get; }
        public string Y_Calle { set; get; }

        public Filters Numero_Exterior_de_los_HechosFilter { set; get; }
        public string Numero_Exterior_de_los_Hechos { set; get; }

        public Filters Numero_interior_de_los_hechoFilter { set; get; }
        public string Numero_interior_de_los_hecho { set; get; }

        public Filters Latitud_de_los_hechosFilter { set; get; }
        public string Latitud_de_los_hechos { set; get; }

        public Filters Longitud_de_los_HechosFilter { set; get; }
        public string Longitud_de_los_Hechos { set; get; }

        public Filters Tipo_del_lugar_del_heFilter { set; get; }
        public string AdvanceTipo_del_lugar_del_he { set; get; }
        public int[] AdvanceTipo_del_lugar_del_heMultiple { set; get; }

        public Filters Nombre_del_TutorFilter { set; get; }
        public string Nombre_del_Tutor { set; get; }

        public Filters Apellido_Paterno_del_TutorFilter { set; get; }
        public string Apellido_Paterno_del_Tutor { set; get; }

        public Filters Apellido_Materno_del_TutorFilter { set; get; }
        public string Apellido_Materno_del_Tutor { set; get; }

        public Filters Nombre_Completo_del_TutorFilter { set; get; }
        public string Nombre_Completo_del_Tutor { set; get; }

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

        public Filters CURP_TutorFilter { set; get; }
        public string CURP_Tutor { set; get; }

        public Filters RFC_TutorFilter { set; get; }
        public string RFC_Tutor { set; get; }

        public Filters Nacionalidad_del_TutorFilter { set; get; }
        public string AdvanceNacionalidad_del_Tutor { set; get; }
        public int[] AdvanceNacionalidad_del_TutorMultiple { set; get; }

        public Filters Escolaridad_del_TutorFilter { set; get; }
        public string AdvanceEscolaridad_del_Tutor { set; get; }
        public int[] AdvanceEscolaridad_del_TutorMultiple { set; get; }

        public Filters Ocupacion_del_TutorFilter { set; get; }
        public string AdvanceOcupacion_del_Tutor { set; get; }
        public int[] AdvanceOcupacion_del_TutorMultiple { set; get; }

        public Filters Pais_de_Origen_tutorFilter { set; get; }
        public string AdvancePais_de_Origen_tutor { set; get; }
        public int[] AdvancePais_de_Origen_tutorMultiple { set; get; }

        public Filters Originario_de_tutorFilter { set; get; }
        public string Originario_de_tutor { set; get; }

        public Filters Pais_del_TutorFilter { set; get; }
        public string AdvancePais_del_Tutor { set; get; }
        public int[] AdvancePais_del_TutorMultiple { set; get; }

        public Filters Estado_del_TutorFilter { set; get; }
        public string AdvanceEstado_del_Tutor { set; get; }
        public int[] AdvanceEstado_del_TutorMultiple { set; get; }

        public Filters Municipio_del_TutorFilter { set; get; }
        public string AdvanceMunicipio_del_Tutor { set; get; }
        public int[] AdvanceMunicipio_del_TutorMultiple { set; get; }

        public Filters Poblacion_TutorFilter { set; get; }
        public string AdvancePoblacion_Tutor { set; get; }
        public int[] AdvancePoblacion_TutorMultiple { set; get; }

        public Filters Colonia_del_TutorFilter { set; get; }
        public string AdvanceColonia_del_Tutor { set; get; }
        public int[] AdvanceColonia_del_TutorMultiple { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromCodigo_Postal_del_Tutor { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromCodigo_Postal_del_Tutor", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToCodigo_Postal_del_Tutor { set; get; }

        public Filters Calle_del_TutorFilter { set; get; }
        public string Calle_del_Tutor { set; get; }

        public Filters Numero_Exterior_del_TutorFilter { set; get; }
        public string Numero_Exterior_del_Tutor { set; get; }

        public Filters Numero_Interior_del_TutorFilter { set; get; }
        public string Numero_Interior_del_Tutor { set; get; }

        public Filters ReferenciaFilter { set; get; }
        public string Referencia { set; get; }

        public Filters Latitud_TutorFilter { set; get; }
        public string Latitud_Tutor { set; get; }

        public Filters Longitud_TutorFilter { set; get; }
        public string Longitud_Tutor { set; get; }

        public Filters Telefono_del_TutorFilter { set; get; }
        public string Telefono_del_Tutor { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromExtension_del_Tutor { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromExtension_del_Tutor", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToExtension_del_Tutor { set; get; }

        public Filters Celular_del_TutorFilter { set; get; }
        public string Celular_del_Tutor { set; get; }

        public Filters Correo_Electronico_del_TutorFilter { set; get; }
        public string Correo_Electronico_del_Tutor { set; get; }


    }
}
