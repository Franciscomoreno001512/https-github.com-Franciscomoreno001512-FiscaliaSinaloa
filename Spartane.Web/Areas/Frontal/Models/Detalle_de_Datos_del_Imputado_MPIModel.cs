using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Datos_del_Imputado_MPIModel
    {
        [Required]
        public int Clave { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
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
        public int? Nacionalidad { get; set; }
        public string NacionalidadNacionalidadC { get; set; }
        public short? Escolaridad { get; set; }
        public string EscolaridadDescripcion { get; set; }
        public int? Ocupacion { get; set; }
        public string OcupacionDescripcion { get; set; }
        public int? Estado { get; set; }
        public string EstadoNombre { get; set; }
        public int? Municipio { get; set; }
        public string MunicipioNombre { get; set; }
        [Range(0, 9999999999)]
        public int? Codigo_Postal { get; set; }
        public int? Localidad { get; set; }
        public string LocalidadDescripcion { get; set; }
        public int? Colonia { get; set; }
        public string ColoniaNombre { get; set; }
        public string Calle_del_Imputado { get; set; }
        public string Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public string Telefono { get; set; }
        [Range(0, 9999999999)]
        public short? Extencion { get; set; }
        public string Celular { get; set; }
        public string Correo_Electronico { get; set; }
        public int? Pais { get; set; }
        public string PaisNombre { get; set; }
        public int? Forma_Cara { get; set; }
        public string Forma_CaraDescripcion { get; set; }
        public int? Cejas { get; set; }
        public string CejasDescripcion { get; set; }
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
        public int? Calvicie { get; set; }
        public string CalvicieDescripcion { get; set; }
        public int? Color_Ojos { get; set; }
        public string Color_OjosDescripcion { get; set; }
        public int? Ojos { get; set; }
        public string OjosDescripcion { get; set; }
        public int? Forma_de_Ojos { get; set; }
        public string Forma_de_OjosDescripcion { get; set; }
        public int? Nariz_Base { get; set; }
        public string Nariz_BaseDescripcion { get; set; }
        public int? Labios { get; set; }
        public string LabiosDescripcion { get; set; }
        public int? Boca { get; set; }
        public string BocaDescripcion { get; set; }
        public int? Menton { get; set; }
        public string MentonDescripcion { get; set; }
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
        public int? Situacion_Fisica { get; set; }
        public string Situacion_FisicaDescripcion { get; set; }
        public string Alias_media_diliacion { get; set; }
        public string Fecha_de_Detencion { get; set; }
        public string Hora_de_Detencion { get; set; }
        public string Fecha_de_Puesto_a_Disposicion { get; set; }
        public string Hora_de_Puesto_a_Disposicion { get; set; }
        public int? Con_Detenido { get; set; }
        public string Con_DetenidoDescripcion { get; set; }
        public bool A_Quien_Resulte_Responsable { get; set; }
        public string Tiempo_Restante_para_Vinculacion { get; set; }
        public bool Vincular { get; set; }
        public int? Medidas_Cautelares { get; set; }
        public string Medidas_CautelaresDescripcion { get; set; }
        public string Solicitar_Prorroga { get; set; }
        public string Nuevo_Plazo { get; set; }
        public bool Orden_de_Aprehension { get; set; }
        public int? Medidas_Cautelares_en_Imputado { get; set; }
        public string Medidas_Cautelares_en_ImputadoDescripcion { get; set; }
        public string Titulo_del_Hecho { get; set; }
        public string Narrativa_Breve_de_los_Hechos { get; set; }
        public int? Prioridad_del_Hecho { get; set; }
        public string Prioridad_del_HechoDescripcion { get; set; }
        public string Fecha_del_Hecho { get; set; }
        public string Hora_Aproximada_del_Hecho { get; set; }
        public int? Pais_del_Hecho { get; set; }
        public string Pais_del_HechoNombre { get; set; }
        public int? Estado_del_Hecho { get; set; }
        public string Estado_del_HechoNombre { get; set; }
        public int? Municipio_del_Hecho { get; set; }
        public string Municipio_del_HechoNombre { get; set; }
        public int? Colonia_del_Hecho { get; set; }
        public string Colonia_del_HechoNombre { get; set; }
        [Range(0, 9999999999)]
        public int? Codigo_Postal_del_Hecho { get; set; }
        public string Calle_del_Hecho { get; set; }
        public string Entre_Calle_del_Hecho { get; set; }
        public string Y_Calle_del_Hecho { get; set; }
        public string Numero_Exterior_del_Hecho { get; set; }
        public string Numero_Interior_del_Hecho { get; set; }
        public string Latitud_del_Hecho { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Longitud_del_Hecho { get; set; }
        public int? Tipo_de_Lugar_del_Hecho { get; set; }
        public string Tipo_de_Lugar_del_HechoDescripcion { get; set; }
        public bool Incapaz { get; set; }
        public string Nombre_del_Tutor { get; set; }
        public string Apellido_Paterno_del_Tutor { get; set; }
        public string Apellido_Materno_del_Tutor { get; set; }
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
        public int? Nacionalidad_del_Tutor { get; set; }
        public string Nacionalidad_del_TutorNacionalidadC { get; set; }
        public short? Escolaridad_del_Tutor { get; set; }
        public string Escolaridad_del_TutorDescripcion { get; set; }
        public int? Ocupacion_del_Tutor { get; set; }
        public string Ocupacion_del_TutorDescripcion { get; set; }
        public int? Pais_del_Tutor { get; set; }
        public string Pais_del_TutorNombre { get; set; }
        public int? Estado_del_Tutor { get; set; }
        public string Estado_del_TutorNombre { get; set; }
        public int? Municipio_del_Tutor { get; set; }
        public string Municipio_del_TutorNombre { get; set; }
        public int? Colonia_del_Tutor { get; set; }
        public string Colonia_del_TutorNombre { get; set; }
        [Range(0, 9999999999)]
        public int? Codigo_Postal_del_Tutor { get; set; }
        public string Calle_del_Tutor { get; set; }
        public string Numero_Exterior_del_Tutor { get; set; }
        public string Numero_Interior_del_Tutor { get; set; }
        public string Telefono_del_Tutor { get; set; }
        [Range(0, 9999999999)]
        public short? Extension_del_Tutor { get; set; }
        public string Celular_del_Tutor { get; set; }
        public string Correo_Electronico_del_Tutor { get; set; }
        public bool Proteccion_de_Datos { get; set; }
        public int? Estatus { get; set; }
        public string EstatusDescripcion { get; set; }
        public bool Judicializar { get; set; }

    }
	
	public class Detalle_de_Datos_del_Imputado_MPI_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
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
        public int? Nacionalidad { get; set; }
        public string NacionalidadNacionalidadC { get; set; }
        public short? Escolaridad { get; set; }
        public string EscolaridadDescripcion { get; set; }
        public int? Ocupacion { get; set; }
        public string OcupacionDescripcion { get; set; }
        public int? Estado { get; set; }
        public string EstadoNombre { get; set; }
        public int? Municipio { get; set; }
        public string MunicipioNombre { get; set; }
        [Range(0, 9999999999)]
        public int? Codigo_Postal { get; set; }
        public int? Localidad { get; set; }
        public string LocalidadDescripcion { get; set; }
        public int? Colonia { get; set; }
        public string ColoniaNombre { get; set; }
        public string Calle_del_Imputado { get; set; }
        public string Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public string Telefono { get; set; }
        [Range(0, 9999999999)]
        public short? Extencion { get; set; }
        public string Celular { get; set; }
        public string Correo_Electronico { get; set; }
        public int? Pais { get; set; }
        public string PaisNombre { get; set; }
        public string Alias_media_diliacion { get; set; }
        public int? Con_Detenido { get; set; }
        public string Con_DetenidoDescripcion { get; set; }
        public bool? A_Quien_Resulte_Responsable { get; set; }
        public bool? Orden_de_Aprehension { get; set; }
        public int? Medidas_Cautelares_en_Imputado { get; set; }
        public string Medidas_Cautelares_en_ImputadoDescripcion { get; set; }
        public bool? Incapaz { get; set; }
        public bool? Proteccion_de_Datos { get; set; }
        public int? Estatus { get; set; }
        public string EstatusDescripcion { get; set; }

    }

	public class Detalle_de_Datos_del_Imputado_MPI_Datos_de_Media_FiliacionModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Forma_Cara { get; set; }
        public string Forma_CaraDescripcion { get; set; }
        public int? Cejas { get; set; }
        public string CejasDescripcion { get; set; }
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
        public int? Calvicie { get; set; }
        public string CalvicieDescripcion { get; set; }
        public int? Color_Ojos { get; set; }
        public string Color_OjosDescripcion { get; set; }
        public int? Ojos { get; set; }
        public string OjosDescripcion { get; set; }
        public int? Forma_de_Ojos { get; set; }
        public string Forma_de_OjosDescripcion { get; set; }
        public int? Nariz_Base { get; set; }
        public string Nariz_BaseDescripcion { get; set; }
        public int? Labios { get; set; }
        public string LabiosDescripcion { get; set; }
        public int? Boca { get; set; }
        public string BocaDescripcion { get; set; }
        public int? Menton { get; set; }
        public string MentonDescripcion { get; set; }
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
        public int? Situacion_Fisica { get; set; }
        public string Situacion_FisicaDescripcion { get; set; }

    }

	public class Detalle_de_Datos_del_Imputado_MPI_Control_de_TiemposModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha_de_Detencion { get; set; }
        public string Hora_de_Detencion { get; set; }
        public string Fecha_de_Puesto_a_Disposicion { get; set; }
        public string Hora_de_Puesto_a_Disposicion { get; set; }
        public string Tiempo_Restante_para_Vinculacion { get; set; }
        public bool? Vincular { get; set; }
        public int? Medidas_Cautelares { get; set; }
        public string Medidas_CautelaresDescripcion { get; set; }
        public string Solicitar_Prorroga { get; set; }
        public string Nuevo_Plazo { get; set; }
        public bool? Judicializar { get; set; }

    }

	public class Detalle_de_Datos_del_Imputado_MPI_Datos_de_los_HechosModel
    {
        [Required]
        public int Clave { get; set; }
        public string Titulo_del_Hecho { get; set; }
        public string Narrativa_Breve_de_los_Hechos { get; set; }
        public int? Prioridad_del_Hecho { get; set; }
        public string Prioridad_del_HechoDescripcion { get; set; }
        public string Fecha_del_Hecho { get; set; }
        public string Hora_Aproximada_del_Hecho { get; set; }
        public int? Pais_del_Hecho { get; set; }
        public string Pais_del_HechoNombre { get; set; }
        public int? Estado_del_Hecho { get; set; }
        public string Estado_del_HechoNombre { get; set; }
        public int? Municipio_del_Hecho { get; set; }
        public string Municipio_del_HechoNombre { get; set; }
        public int? Colonia_del_Hecho { get; set; }
        public string Colonia_del_HechoNombre { get; set; }
        [Range(0, 9999999999)]
        public int? Codigo_Postal_del_Hecho { get; set; }
        public string Calle_del_Hecho { get; set; }
        public string Entre_Calle_del_Hecho { get; set; }
        public string Y_Calle_del_Hecho { get; set; }
        public string Numero_Exterior_del_Hecho { get; set; }
        public string Numero_Interior_del_Hecho { get; set; }
        public string Latitud_del_Hecho { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Longitud_del_Hecho { get; set; }
        public int? Tipo_de_Lugar_del_Hecho { get; set; }
        public string Tipo_de_Lugar_del_HechoDescripcion { get; set; }

    }

	public class Detalle_de_Datos_del_Imputado_MPI_Datos_del_AbogadoModel
    {
        [Required]
        public int Clave { get; set; }

    }

	public class Detalle_de_Datos_del_Imputado_MPI_Datos_del_TutorModel
    {
        [Required]
        public int Clave { get; set; }
        public string Nombre_del_Tutor { get; set; }
        public string Apellido_Paterno_del_Tutor { get; set; }
        public string Apellido_Materno_del_Tutor { get; set; }
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
        public int? Nacionalidad_del_Tutor { get; set; }
        public string Nacionalidad_del_TutorNacionalidadC { get; set; }
        public short? Escolaridad_del_Tutor { get; set; }
        public string Escolaridad_del_TutorDescripcion { get; set; }
        public int? Ocupacion_del_Tutor { get; set; }
        public string Ocupacion_del_TutorDescripcion { get; set; }
        public int? Pais_del_Tutor { get; set; }
        public string Pais_del_TutorNombre { get; set; }
        public int? Estado_del_Tutor { get; set; }
        public string Estado_del_TutorNombre { get; set; }
        public int? Municipio_del_Tutor { get; set; }
        public string Municipio_del_TutorNombre { get; set; }
        public int? Colonia_del_Tutor { get; set; }
        public string Colonia_del_TutorNombre { get; set; }
        [Range(0, 9999999999)]
        public int? Codigo_Postal_del_Tutor { get; set; }
        public string Calle_del_Tutor { get; set; }
        public string Numero_Exterior_del_Tutor { get; set; }
        public string Numero_Interior_del_Tutor { get; set; }
        public string Telefono_del_Tutor { get; set; }
        [Range(0, 9999999999)]
        public short? Extension_del_Tutor { get; set; }
        public string Celular_del_Tutor { get; set; }
        public string Correo_Electronico_del_Tutor { get; set; }

    }

	public class Detalle_de_Datos_del_Imputado_MPI_SentenciasModel
    {
        [Required]
        public int Clave { get; set; }

    }


}

