using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Datos_del_Testigo_MPIModel
    {
        [Required]
        public int Clave { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Nombre_Completo { get; set; }
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
        public int? Pais { get; set; }
        public string PaisNombre { get; set; }
        public int? Estado { get; set; }
        public string EstadoNombre { get; set; }
        public int? Municipio { get; set; }
        public string MunicipioNombre { get; set; }
        public int? Colonia { get; set; }
        public string ColoniaNombre { get; set; }
        [Range(0, 9999999999)]
        public int? Codigo_Postal { get; set; }
        public string Calle { get; set; }
        public string Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public string Telefono { get; set; }
        [Range(0, 9999999999)]
        public short? Extencion { get; set; }
        public string Celular { get; set; }
        public string Correo_Electronico { get; set; }
        public bool Incapaz { get; set; }
        public string Nombre_del_Tutor { get; set; }
        public string Apellido_Paterno_del_Tutor { get; set; }
        public string Apellido_Materno_del_Tutor { get; set; }
        public string Nombre_Completo_del_Tutor { get; set; }
        public string Fecha_de_Nacimento_del_Tutor { get; set; }
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
        public short? Extencion_del_Tutor { get; set; }
        public string Celular_del_Tutor { get; set; }
        public string Correo_Electronico_del_Tutor { get; set; }
        public int? Tipo_de_Compareciente { get; set; }
        public string Tipo_de_ComparecienteDescripcion { get; set; }
        public string Narrativa_del_Testigo { get; set; }
        public string Titulo_del_Hecho { get; set; }
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
        public string Longitud_del_Hecho { get; set; }
        public int? Tipo_del_Lugar_del_Hecho { get; set; }
        public string Tipo_del_Lugar_del_HechoDescripcion { get; set; }
        public bool Proteccion_de_Datos { get; set; }

    }
	
	public class Detalle_de_Datos_del_Testigo_MPI_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Nombre_Completo { get; set; }
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
        public int? Pais { get; set; }
        public string PaisNombre { get; set; }
        public int? Estado { get; set; }
        public string EstadoNombre { get; set; }
        public int? Municipio { get; set; }
        public string MunicipioNombre { get; set; }
        public int? Colonia { get; set; }
        public string ColoniaNombre { get; set; }
        [Range(0, 9999999999)]
        public int? Codigo_Postal { get; set; }
        public string Calle { get; set; }
        public string Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public string Telefono { get; set; }
        [Range(0, 9999999999)]
        public short? Extencion { get; set; }
        public string Celular { get; set; }
        public string Correo_Electronico { get; set; }
        public bool? Incapaz { get; set; }
        public bool? Proteccion_de_Datos { get; set; }

    }

	public class Detalle_de_Datos_del_Testigo_MPI__Datos_del_TutorModel
    {
        [Required]
        public int Clave { get; set; }
        public string Nombre_del_Tutor { get; set; }
        public string Apellido_Paterno_del_Tutor { get; set; }
        public string Apellido_Materno_del_Tutor { get; set; }
        public string Nombre_Completo_del_Tutor { get; set; }
        public string Fecha_de_Nacimento_del_Tutor { get; set; }
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
        public short? Extencion_del_Tutor { get; set; }
        public string Celular_del_Tutor { get; set; }
        public string Correo_Electronico_del_Tutor { get; set; }
        public int? Tipo_de_Compareciente { get; set; }
        public string Tipo_de_ComparecienteDescripcion { get; set; }

    }

	public class Detalle_de_Datos_del_Testigo_MPI_Datos_de_los_HechosModel
    {
        [Required]
        public int Clave { get; set; }
        public string Narrativa_del_Testigo { get; set; }
        public string Titulo_del_Hecho { get; set; }
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
        public string Longitud_del_Hecho { get; set; }
        public int? Tipo_del_Lugar_del_Hecho { get; set; }
        public string Tipo_del_Lugar_del_HechoDescripcion { get; set; }

    }


}

