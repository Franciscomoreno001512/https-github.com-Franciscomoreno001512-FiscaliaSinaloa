using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_ImputadoModel
    {
        [Required]
        public int Clave { get; set; }
        public bool Persona_Moral { get; set; }
        public int? Modulo_Atencion_Inicial { get; set; }
        public string Modulo_Atencion_InicialNUAT { get; set; }
        public int? Expediente_MP { get; set; }
        public string Expediente_MPnic { get; set; }
        public int? Expediente_MASC { get; set; }
        public string Expediente_MASCNumero_de_Folio { get; set; }
        public bool Quien_Resulte_Responsable { get; set; }
        public bool Se_Presenta_con_Detenido { get; set; }
        public string Folio_Registro_Nacional_de_Detenciones { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Nombre_Completo_Detenido { get; set; }
        public string Alias { get; set; }
        public string Fecha_de_Nacimiento { get; set; }
        [Range(0, 9999999999)]
        public short? Edad { get; set; }
        public int? Sexo { get; set; }
        public string SexoDescripcion { get; set; }
        public int? Estado_Civil { get; set; }
        public string Estado_CivilDescripcion { get; set; }
        public int? Tipo_de_Identificacion { get; set; }
        public string Tipo_de_IdentificacionNombre { get; set; }
        public string Numero_de_Identificacion { get; set; }
        public string CURP { get; set; }
        public string RFC { get; set; }
        public string Calidad_Juridica { get; set; }
        public string Razon_Social { get; set; }
        public int? Nacionalidad { get; set; }
        public string NacionalidadNacionalidadC { get; set; }
        public short? Escolaridad { get; set; }
        public string EscolaridadDescripcion { get; set; }
        public int? Ocupacion { get; set; }
        public string OcupacionDescripcion { get; set; }
        public int? Pais_de_Origen { get; set; }
        public string Pais_de_OrigenNombre { get; set; }
        public string Originario_de { get; set; }
        public int? Pais { get; set; }
        public string PaisNombre { get; set; }
        public int? Estado { get; set; }
        public string EstadoNombre { get; set; }
        public int? Municipio { get; set; }
        public string MunicipioNombre { get; set; }
        public int? Poblacion { get; set; }
        public string PoblacionNombre { get; set; }
        public int? Colonia { get; set; }
        public string ColoniaNombre { get; set; }
        [Range(0, 9999999999)]
        public int? Codigo_Postal { get; set; }
        public string Calle_del_Imputado { get; set; }
        public string Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public string Referencia_de_Domicilio { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public string Telefono { get; set; }
        [Range(0, 9999999999)]
        public short? Extension { get; set; }
        public string Celular { get; set; }
        public string Correo_Electronico { get; set; }
        public string Apodo { get; set; }
        public int? Etnia { get; set; }
        public string EtniaDescripcion { get; set; }
        [Range(0, 9999999999)]
        public short? No_de_Hijos { get; set; }
        public short? Religion { get; set; }
        public string ReligionDescripcion { get; set; }
        public int? Servicio_Medico { get; set; }
        public string Servicio_MedicoDescripcion { get; set; }
        public short? Escolaridad_Detenido { get; set; }
        public string Escolaridad_DetenidoDescripcion { get; set; }
        public int? Especialidad { get; set; }
        public string EspecialidadDescripcion { get; set; }
        public int? Estudios_Superiores { get; set; }
        public string Estudios_SuperioresDescripcion { get; set; }
        public bool Incompleto { get; set; }
        public int? Idioma { get; set; }
        public string IdiomaDescripcion { get; set; }
        public int? Calidad_Migratoria { get; set; }
        public string Calidad_MigratoriaDescripcion { get; set; }
        public int? Estado_de_Nacimiento { get; set; }
        public string Estado_de_NacimientoNombre { get; set; }
        public int? Municipio_de_Nacimiento { get; set; }
        public string Municipio_de_NacimientoNombre { get; set; }
        public int? Dialecto { get; set; }
        public string DialectoDescripcion { get; set; }
        public bool Viene_en_Estado_de_Ebriedad { get; set; }
        public bool Bajo_el_Efecto_de_una_Droga { get; set; }
        public string Nombre_de_Droga { get; set; }
        public bool Inimputable { get; set; }
        public bool Gravidez { get; set; }
        public int? Tipo_de_Inimputabilidad { get; set; }
        public string Tipo_de_InimputabilidadDescripcion { get; set; }
        public string Especifique { get; set; }
        public int? Discapacidad_Mental { get; set; }
        public string Discapacidad_MentalDescripcion { get; set; }
        public int? Discapacidad_Fisica { get; set; }
        public string Discapacidad_FisicaDescripcion { get; set; }
        public int? Discapacidad_Sensorial { get; set; }
        public string Discapacidad_SensorialDescripcion { get; set; }
        public int? Discapacidad_Psicosocial { get; set; }
        public string Discapacidad_PsicosocialDescripcion { get; set; }
        public string Nombres2 { get; set; }
        public string Apellido_Paterno2 { get; set; }
        public string Apellido_Materno2 { get; set; }
        public string Nombre_Completo2 { get; set; }
        public int? Sexo2 { get; set; }
        public string Sexo2Descripcion { get; set; }
        public int? Nacionalidad2 { get; set; }
        public string Nacionalidad2NacionalidadC { get; set; }
        public short? Escolaridad2 { get; set; }
        public string Escolaridad2Descripcion { get; set; }
        public string ID_Estado_Institucion { get; set; }
        public string Peso { get; set; }
        public string Estatura { get; set; }
        public string Padecimiento_de_Enfermedad { get; set; }
        public int? Forma_Cara { get; set; }
        public string Forma_CaraDescripcion { get; set; }
        public int? Cejas { get; set; }
        public string CejasDescripcion { get; set; }
        public int? Tamano_de_Cejas { get; set; }
        public string Tamano_de_CejasDescripcion { get; set; }
        public int? Largo_de_Cabello { get; set; }
        public string Largo_de_CabelloDescripcion { get; set; }
        public int? Cantidad_Cabello { get; set; }
        public string Cantidad_CabelloDescripcion { get; set; }
        public int? Implantacion_Cabello { get; set; }
        public string Implantacion_CabelloDescripcion { get; set; }
        public int? Complexion { get; set; }
        public string ComplexionDescripcion { get; set; }
        public int? Color_Piel { get; set; }
        public string Color_PielDescrpicion { get; set; }
        public int? Frente { get; set; }
        public string FrenteDescripcion { get; set; }
        public int? Forma_Cabello { get; set; }
        public string Forma_CabelloDescripcion { get; set; }
        public int? Color_Cabello { get; set; }
        public string Color_CabelloDescripcion { get; set; }
        public int? Calvicie { get; set; }
        public string CalvicieDescripcion { get; set; }
        public int? Color_Ojos { get; set; }
        public string Color_OjosDescripcion { get; set; }
        public int? Ojos { get; set; }
        public string OjosDescripcion { get; set; }
        public int? Forma_Ojos { get; set; }
        public string Forma_OjosDescripcion { get; set; }
        public int? Anteojos { get; set; }
        public string AnteojosDescripcion { get; set; }
        public int? Forma_de_Nariz { get; set; }
        public string Forma_de_NarizDescripcion { get; set; }
        public int? Nariz_Base { get; set; }
        public string Nariz_BaseDescripcion { get; set; }
        public int? Labios { get; set; }
        public string LabiosDescripcion { get; set; }
        public int? Boca { get; set; }
        public string BocaDescripcion { get; set; }
        public int? Grosor_de_Labios { get; set; }
        public string Grosor_de_LabiosDescripcion { get; set; }
        public int? Menton { get; set; }
        public string MentonDescripcion { get; set; }
        public int? Forma_de_Menton { get; set; }
        public string Forma_de_MentonDescripcion { get; set; }
        public int? Barba { get; set; }
        public string BarbaDescripcion { get; set; }
        public int? Forma_Orejas { get; set; }
        public string Forma_OrejasDescripcion { get; set; }
        public int? Tamano_Orejas { get; set; }
        public string Tamano_OrejasDescripcion { get; set; }
        public int? Tipo_Lobulo { get; set; }
        public string Tipo_LobuloDescripcion { get; set; }
        public int? Bigote { get; set; }
        public string BigoteDescripcion { get; set; }
        public int? Senas_Particulares { get; set; }
        public string Senas_ParticularesDescripcion { get; set; }
        public int? Imagen_Tatuaje { get; set; }
        public HttpPostedFileBase Imagen_TatuajeFile { set; get; }
        public int Imagen_TatuajeRemoveAttachment { set; get; }
        public int? Situacion_Fisica { get; set; }
        public string Situacion_FisicaDescripcion { get; set; }
        public string Otras_Senas_Particulares { get; set; }
        public string Imputado_Recluido { get; set; }
        public string Narrativa_Breve_de_los_Hechos { get; set; }
        public int? Prioridad_del_Hecho { get; set; }
        public string Prioridad_del_HechoDescripcion { get; set; }
        public string Fecha_del_Hecho { get; set; }
        public string Hora_Aproximada_del_Hecho { get; set; }
        public int? Pais_del_hecho { get; set; }
        public string Pais_del_hechoNombre { get; set; }
        public int? Estado_del_Hecho { get; set; }
        public string Estado_del_HechoNombre { get; set; }
        public int? Municipio_del_Hecho { get; set; }
        public string Municipio_del_HechoNombre { get; set; }
        public int? Poblacion_Hechos { get; set; }
        public string Poblacion_HechosNombre { get; set; }
        public int? Colonia_del_hecho { get; set; }
        public string Colonia_del_hechoNombre { get; set; }
        public string Codigo_Postal_del_hecho { get; set; }
        public string Calle_del_hecho { get; set; }
        public string Entre_Calle { get; set; }
        public string Y_Calle { get; set; }
        public string Numero_Exterior_de_los_Hechos { get; set; }
        public string Numero_interior_de_los_hecho { get; set; }
        public string Latitud_de_los_hechos { get; set; }
        public string Longitud_de_los_Hechos { get; set; }
        public int? Tipo_del_lugar_del_he { get; set; }
        public string Tipo_del_lugar_del_heDescripcion { get; set; }
        public string Nombre_del_Tutor { get; set; }
        public string Apellido_Paterno_del_Tutor { get; set; }
        public string Apellido_Materno_del_Tutor { get; set; }
        public string Nombre_Completo_del_Tutor { get; set; }
        public string Fecha_de_Nacimiento_del_Tutor { get; set; }
        [Range(0, 9999999999)]
        public short? Edad_del_Tutor { get; set; }
        public int? Sexo_del_Tutor { get; set; }
        public string Sexo_del_TutorDescripcion { get; set; }
        public int? Estado_Civil_del_Tutor { get; set; }
        public string Estado_Civil_del_TutorDescripcion { get; set; }
        public int? Tipo_de_Identificacion_del_Tutor { get; set; }
        public string Tipo_de_Identificacion_del_TutorNombre { get; set; }
        public string Numero_de_Identificacion_del_Tutor { get; set; }
        public string CURP_Tutor { get; set; }
        public string RFC_Tutor { get; set; }
        public int? Nacionalidad_del_Tutor { get; set; }
        public string Nacionalidad_del_TutorNacionalidadC { get; set; }
        public short? Escolaridad_del_Tutor { get; set; }
        public string Escolaridad_del_TutorDescripcion { get; set; }
        public int? Ocupacion_del_Tutor { get; set; }
        public string Ocupacion_del_TutorDescripcion { get; set; }
        public int? Pais_de_Origen_tutor { get; set; }
        public string Pais_de_Origen_tutorNombre { get; set; }
        public string Originario_de_tutor { get; set; }
        public int? Pais_del_Tutor { get; set; }
        public string Pais_del_TutorNombre { get; set; }
        public int? Estado_del_Tutor { get; set; }
        public string Estado_del_TutorNombre { get; set; }
        public int? Municipio_del_Tutor { get; set; }
        public string Municipio_del_TutorNombre { get; set; }
        public int? Poblacion_Tutor { get; set; }
        public string Poblacion_TutorNombre { get; set; }
        public int? Colonia_del_Tutor { get; set; }
        public string Colonia_del_TutorNombre { get; set; }
        [Range(0, 9999999999)]
        public int? Codigo_Postal_del_Tutor { get; set; }
        public string Calle_del_Tutor { get; set; }
        public string Numero_Exterior_del_Tutor { get; set; }
        public string Numero_Interior_del_Tutor { get; set; }
        public string Referencia { get; set; }
        public string Latitud_Tutor { get; set; }
        public string Longitud_Tutor { get; set; }
        public string Telefono_del_Tutor { get; set; }
        [Range(0, 9999999999)]
        public int? Extension_del_Tutor { get; set; }
        public string Celular_del_Tutor { get; set; }
        public string Correo_Electronico_del_Tutor { get; set; }

    }
	
	public class Detalle_de_Imputado_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public bool? Persona_Moral { get; set; }
        public int? Modulo_Atencion_Inicial { get; set; }
        public string Modulo_Atencion_InicialNUAT { get; set; }
        public int? Expediente_MP { get; set; }
        public string Expediente_MPnic { get; set; }
        public int? Expediente_MASC { get; set; }
        public string Expediente_MASCNumero_de_Folio { get; set; }
        public bool? Quien_Resulte_Responsable { get; set; }
        public bool? Se_Presenta_con_Detenido { get; set; }
        public string Folio_Registro_Nacional_de_Detenciones { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Nombre_Completo_Detenido { get; set; }
        public string Alias { get; set; }
        public string Fecha_de_Nacimiento { get; set; }
        [Range(0, 9999999999)]
        public short? Edad { get; set; }
        public int? Sexo { get; set; }
        public string SexoDescripcion { get; set; }
        public int? Estado_Civil { get; set; }
        public string Estado_CivilDescripcion { get; set; }
        public int? Tipo_de_Identificacion { get; set; }
        public string Tipo_de_IdentificacionNombre { get; set; }
        public string Numero_de_Identificacion { get; set; }
        public string CURP { get; set; }
        public string RFC { get; set; }
        public string Calidad_Juridica { get; set; }
        public string Razon_Social { get; set; }
        public int? Nacionalidad { get; set; }
        public string NacionalidadNacionalidadC { get; set; }
        public short? Escolaridad { get; set; }
        public string EscolaridadDescripcion { get; set; }
        public int? Ocupacion { get; set; }
        public string OcupacionDescripcion { get; set; }
        public int? Pais_de_Origen { get; set; }
        public string Pais_de_OrigenNombre { get; set; }
        public string Originario_de { get; set; }
        public int? Pais { get; set; }
        public string PaisNombre { get; set; }
        public int? Estado { get; set; }
        public string EstadoNombre { get; set; }
        public int? Municipio { get; set; }
        public string MunicipioNombre { get; set; }
        public int? Poblacion { get; set; }
        public string PoblacionNombre { get; set; }
        public int? Colonia { get; set; }
        public string ColoniaNombre { get; set; }
        [Range(0, 9999999999)]
        public int? Codigo_Postal { get; set; }
        public string Calle_del_Imputado { get; set; }
        public string Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public string Referencia_de_Domicilio { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public string Telefono { get; set; }
        [Range(0, 9999999999)]
        public short? Extension { get; set; }
        public string Celular { get; set; }
        public string Correo_Electronico { get; set; }
        public string Apodo { get; set; }
        public int? Etnia { get; set; }
        public string EtniaDescripcion { get; set; }
        [Range(0, 9999999999)]
        public short? No_de_Hijos { get; set; }
        public short? Religion { get; set; }
        public string ReligionDescripcion { get; set; }
        public int? Servicio_Medico { get; set; }
        public string Servicio_MedicoDescripcion { get; set; }
        public short? Escolaridad_Detenido { get; set; }
        public string Escolaridad_DetenidoDescripcion { get; set; }
        public int? Especialidad { get; set; }
        public string EspecialidadDescripcion { get; set; }
        public int? Estudios_Superiores { get; set; }
        public string Estudios_SuperioresDescripcion { get; set; }
        public bool? Incompleto { get; set; }
        public int? Idioma { get; set; }
        public string IdiomaDescripcion { get; set; }
        public int? Calidad_Migratoria { get; set; }
        public string Calidad_MigratoriaDescripcion { get; set; }
        public int? Estado_de_Nacimiento { get; set; }
        public string Estado_de_NacimientoNombre { get; set; }
        public int? Municipio_de_Nacimiento { get; set; }
        public string Municipio_de_NacimientoNombre { get; set; }
        public int? Dialecto { get; set; }
        public string DialectoDescripcion { get; set; }
        public bool? Viene_en_Estado_de_Ebriedad { get; set; }
        public bool? Bajo_el_Efecto_de_una_Droga { get; set; }
        public string Nombre_de_Droga { get; set; }
        public bool? Inimputable { get; set; }
        public bool? Gravidez { get; set; }
        public int? Tipo_de_Inimputabilidad { get; set; }
        public string Tipo_de_InimputabilidadDescripcion { get; set; }
        public string Especifique { get; set; }
        public int? Discapacidad_Mental { get; set; }
        public string Discapacidad_MentalDescripcion { get; set; }
        public int? Discapacidad_Fisica { get; set; }
        public string Discapacidad_FisicaDescripcion { get; set; }
        public int? Discapacidad_Sensorial { get; set; }
        public string Discapacidad_SensorialDescripcion { get; set; }
        public int? Discapacidad_Psicosocial { get; set; }
        public string Discapacidad_PsicosocialDescripcion { get; set; }

    }

	public class Detalle_de_Imputado_Representante_LegalModel
    {
        [Required]
        public int Clave { get; set; }
        public string Nombres2 { get; set; }
        public string Apellido_Paterno2 { get; set; }
        public string Apellido_Materno2 { get; set; }
        public string Nombre_Completo2 { get; set; }
        public int? Sexo2 { get; set; }
        public string Sexo2Descripcion { get; set; }
        public int? Nacionalidad2 { get; set; }
        public string Nacionalidad2NacionalidadC { get; set; }
        public short? Escolaridad2 { get; set; }
        public string Escolaridad2Descripcion { get; set; }
        public string ID_Estado_Institucion { get; set; }

    }

	public class Detalle_de_Imputado_Datos_de_Media_FiliacionModel
    {
        [Required]
        public int Clave { get; set; }
        public string Peso { get; set; }
        public string Estatura { get; set; }
        public string Padecimiento_de_Enfermedad { get; set; }
        public int? Forma_Cara { get; set; }
        public string Forma_CaraDescripcion { get; set; }
        public int? Cejas { get; set; }
        public string CejasDescripcion { get; set; }
        public int? Tamano_de_Cejas { get; set; }
        public string Tamano_de_CejasDescripcion { get; set; }
        public int? Largo_de_Cabello { get; set; }
        public string Largo_de_CabelloDescripcion { get; set; }
        public int? Cantidad_Cabello { get; set; }
        public string Cantidad_CabelloDescripcion { get; set; }
        public int? Implantacion_Cabello { get; set; }
        public string Implantacion_CabelloDescripcion { get; set; }
        public int? Complexion { get; set; }
        public string ComplexionDescripcion { get; set; }
        public int? Color_Piel { get; set; }
        public string Color_PielDescrpicion { get; set; }
        public int? Frente { get; set; }
        public string FrenteDescripcion { get; set; }
        public int? Forma_Cabello { get; set; }
        public string Forma_CabelloDescripcion { get; set; }
        public int? Color_Cabello { get; set; }
        public string Color_CabelloDescripcion { get; set; }
        public int? Calvicie { get; set; }
        public string CalvicieDescripcion { get; set; }
        public int? Color_Ojos { get; set; }
        public string Color_OjosDescripcion { get; set; }
        public int? Ojos { get; set; }
        public string OjosDescripcion { get; set; }
        public int? Forma_Ojos { get; set; }
        public string Forma_OjosDescripcion { get; set; }
        public int? Anteojos { get; set; }
        public string AnteojosDescripcion { get; set; }
        public int? Forma_de_Nariz { get; set; }
        public string Forma_de_NarizDescripcion { get; set; }
        public int? Nariz_Base { get; set; }
        public string Nariz_BaseDescripcion { get; set; }
        public int? Labios { get; set; }
        public string LabiosDescripcion { get; set; }
        public int? Boca { get; set; }
        public string BocaDescripcion { get; set; }
        public int? Grosor_de_Labios { get; set; }
        public string Grosor_de_LabiosDescripcion { get; set; }
        public int? Menton { get; set; }
        public string MentonDescripcion { get; set; }
        public int? Forma_de_Menton { get; set; }
        public string Forma_de_MentonDescripcion { get; set; }
        public int? Barba { get; set; }
        public string BarbaDescripcion { get; set; }
        public int? Forma_Orejas { get; set; }
        public string Forma_OrejasDescripcion { get; set; }
        public int? Tamano_Orejas { get; set; }
        public string Tamano_OrejasDescripcion { get; set; }
        public int? Tipo_Lobulo { get; set; }
        public string Tipo_LobuloDescripcion { get; set; }
        public int? Bigote { get; set; }
        public string BigoteDescripcion { get; set; }
        public int? Senas_Particulares { get; set; }
        public string Senas_ParticularesDescripcion { get; set; }
        public int? Imagen_Tatuaje { get; set; }
        public HttpPostedFileBase Imagen_TatuajeFile { set; get; }
        public int Imagen_TatuajeRemoveAttachment { set; get; }
        public int? Situacion_Fisica { get; set; }
        public string Situacion_FisicaDescripcion { get; set; }
        public string Otras_Senas_Particulares { get; set; }
        public string Imputado_Recluido { get; set; }

    }

	public class Detalle_de_Imputado_Datos_de_los_HechosModel
    {
        [Required]
        public int Clave { get; set; }
        public string Narrativa_Breve_de_los_Hechos { get; set; }
        public int? Prioridad_del_Hecho { get; set; }
        public string Prioridad_del_HechoDescripcion { get; set; }
        public string Fecha_del_Hecho { get; set; }
        public string Hora_Aproximada_del_Hecho { get; set; }
        public int? Pais_del_hecho { get; set; }
        public string Pais_del_hechoNombre { get; set; }
        public int? Estado_del_Hecho { get; set; }
        public string Estado_del_HechoNombre { get; set; }
        public int? Municipio_del_Hecho { get; set; }
        public string Municipio_del_HechoNombre { get; set; }
        public int? Poblacion_Hechos { get; set; }
        public string Poblacion_HechosNombre { get; set; }
        public int? Colonia_del_hecho { get; set; }
        public string Colonia_del_hechoNombre { get; set; }
        public string Codigo_Postal_del_hecho { get; set; }
        public string Calle_del_hecho { get; set; }
        public string Entre_Calle { get; set; }
        public string Y_Calle { get; set; }
        public string Numero_Exterior_de_los_Hechos { get; set; }
        public string Numero_interior_de_los_hecho { get; set; }
        public string Latitud_de_los_hechos { get; set; }
        public string Longitud_de_los_Hechos { get; set; }
        public int? Tipo_del_lugar_del_he { get; set; }
        public string Tipo_del_lugar_del_heDescripcion { get; set; }

    }

	public class Detalle_de_Imputado_Datos_del_TutorModel
    {
        [Required]
        public int Clave { get; set; }
        public string Nombre_del_Tutor { get; set; }
        public string Apellido_Paterno_del_Tutor { get; set; }
        public string Apellido_Materno_del_Tutor { get; set; }
        public string Nombre_Completo_del_Tutor { get; set; }
        public string Fecha_de_Nacimiento_del_Tutor { get; set; }
        [Range(0, 9999999999)]
        public short? Edad_del_Tutor { get; set; }
        public int? Sexo_del_Tutor { get; set; }
        public string Sexo_del_TutorDescripcion { get; set; }
        public int? Estado_Civil_del_Tutor { get; set; }
        public string Estado_Civil_del_TutorDescripcion { get; set; }
        public int? Tipo_de_Identificacion_del_Tutor { get; set; }
        public string Tipo_de_Identificacion_del_TutorNombre { get; set; }
        public string Numero_de_Identificacion_del_Tutor { get; set; }
        public string CURP_Tutor { get; set; }
        public string RFC_Tutor { get; set; }
        public int? Nacionalidad_del_Tutor { get; set; }
        public string Nacionalidad_del_TutorNacionalidadC { get; set; }
        public short? Escolaridad_del_Tutor { get; set; }
        public string Escolaridad_del_TutorDescripcion { get; set; }
        public int? Ocupacion_del_Tutor { get; set; }
        public string Ocupacion_del_TutorDescripcion { get; set; }
        public int? Pais_de_Origen_tutor { get; set; }
        public string Pais_de_Origen_tutorNombre { get; set; }
        public string Originario_de_tutor { get; set; }
        public int? Pais_del_Tutor { get; set; }
        public string Pais_del_TutorNombre { get; set; }
        public int? Estado_del_Tutor { get; set; }
        public string Estado_del_TutorNombre { get; set; }
        public int? Municipio_del_Tutor { get; set; }
        public string Municipio_del_TutorNombre { get; set; }
        public int? Poblacion_Tutor { get; set; }
        public string Poblacion_TutorNombre { get; set; }
        public int? Colonia_del_Tutor { get; set; }
        public string Colonia_del_TutorNombre { get; set; }
        [Range(0, 9999999999)]
        public int? Codigo_Postal_del_Tutor { get; set; }
        public string Calle_del_Tutor { get; set; }
        public string Numero_Exterior_del_Tutor { get; set; }
        public string Numero_Interior_del_Tutor { get; set; }
        public string Referencia { get; set; }
        public string Latitud_Tutor { get; set; }
        public string Longitud_Tutor { get; set; }
        public string Telefono_del_Tutor { get; set; }
        [Range(0, 9999999999)]
        public int? Extension_del_Tutor { get; set; }
        public string Celular_del_Tutor { get; set; }
        public string Correo_Electronico_del_Tutor { get; set; }

    }


}

