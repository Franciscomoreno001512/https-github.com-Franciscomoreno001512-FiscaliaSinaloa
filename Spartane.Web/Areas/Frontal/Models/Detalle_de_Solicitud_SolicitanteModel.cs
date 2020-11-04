using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Solicitud_SolicitanteModel
    {
        [Required]
        public int Clave { get; set; }
        [Range(0, 9999999999)]
        public int? idRegistroAT { get; set; }
        [Range(0, 9999999999)]
        public int? idRegistroUI { get; set; }
        public int? Solicitud { get; set; }
        public string SolicitudNumero_de_Folio { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Nombre_Completo { get; set; }
        public string Fecha_de_Nacimiento { get; set; }
        public string CURP { get; set; }
        public string RFC { get; set; }
        [Range(0, 9999999999)]
        public short? Edad { get; set; }
        public int? Sexo { get; set; }
        public string SexoDescripcion { get; set; }
        public int? Estado_Civil { get; set; }
        public string Estado_CivilDescripcion { get; set; }
        public int? Tipo_de_Identificacion { get; set; }
        public string Tipo_de_IdentificacionNombre { get; set; }
        public string Numero_de_Indentificacion { get; set; }
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
        [Range(0, 9999999999)]
        public int? Codigo_Postal { get; set; }
        public int? Poblacion { get; set; }
        public string PoblacionNombre { get; set; }
        public int? Colonia { get; set; }
        public string ColoniaNombre { get; set; }
        public string Calle { get; set; }
        public string Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public string Entre_Calle { get; set; }
        public string Y_Calle { get; set; }
        public string Longitud { get; set; }
        public string Latitud { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Correo_Electronico { get; set; }
        public int? Pais_de_Origen { get; set; }
        public string Pais_de_OrigenNombre { get; set; }
        public string Originario_de { get; set; }
        public int? Tipo_de_Compareciente { get; set; }
        public string Tipo_de_ComparecienteDescripcion { get; set; }
        public bool Incapaz { get; set; }
        public int? Tipo_de_Inimputabilidad { get; set; }
        public string Tipo_de_InimputabilidadDescripcion { get; set; }
        public string Nombre_tutor { get; set; }
        public string Apellido_Paterno_tutor { get; set; }
        public string Apellido_Materno_tutor { get; set; }
        public string Nombre_Completo_tutor { get; set; }
        public string Fecha_de_Nacimiento_tutor { get; set; }
        public string CURP_Tutor { get; set; }
        public string RFC_Tutor { get; set; }
        [Range(0, 9999999999)]
        public short? Edad_tutor { get; set; }
        public int? Sexo_tutor { get; set; }
        public string Sexo_tutorDescripcion { get; set; }
        public int? Estado_Civil_tutor { get; set; }
        public string Estado_Civil_tutorDescripcion { get; set; }
        public int? Tipo_de_Identificacion_tutor { get; set; }
        public string Tipo_de_Identificacion_tutorNombre { get; set; }
        public string Numero_de_Identificacion_tutor { get; set; }
        public int? Nacionalidad_tutor { get; set; }
        public string Nacionalidad_tutorNacionalidadC { get; set; }
        public short? Escolaridad_tutor { get; set; }
        public string Escolaridad_tutorDescripcion { get; set; }
        public int? Ocupacion_tutor { get; set; }
        public string Ocupacion_tutorDescripcion { get; set; }
        public int? Pais_tutor { get; set; }
        public string Pais_tutorNombre { get; set; }
        public int? Estado_tutor { get; set; }
        public string Estado_tutorNombre { get; set; }
        public int? Municipio_tutor { get; set; }
        public string Municipio_tutorNombre { get; set; }
        public int? Localidad_tutor { get; set; }
        public string Localidad_tutorDescripcion { get; set; }
        public int? Colonia_tutor { get; set; }
        public string Colonia_tutorNombre { get; set; }
        [Range(0, 9999999999)]
        public int? Codigo_Postal_tutor { get; set; }
        public string Calle_tutor { get; set; }
        public string Numero_Exterior_tutor { get; set; }
        public string Numero_Interior_tutor { get; set; }
        public string Telefono_tutor { get; set; }
        [Range(0, 9999999999)]
        public short? Extension_tutor { get; set; }
        public string Celular_tutor { get; set; }
        public string Correo_Electronico_tutor { get; set; }
        public int? Pais_de_Origen_T { get; set; }
        public string Pais_de_Origen_TNombre { get; set; }
        public string Originario_de_T { get; set; }
        public string Titulo_del_Hecho { get; set; }
        public string Narrativa_Breve_de_los_Hechos { get; set; }
        public string Fecha_del_Hecho { get; set; }
        public string Hora_Aproximada_del_Hecho { get; set; }
        public int? Lugar_de_los_Hechos { get; set; }
        public string Lugar_de_los_HechosDescripcion { get; set; }
        public int? Pais_Hechos { get; set; }
        public string Pais_HechosNombre { get; set; }
        public int? Estado_Hechos { get; set; }
        public string Estado_HechosNombre { get; set; }
        public int? Municipio_Hechos { get; set; }
        public string Municipio_HechosNombre { get; set; }
        public int? Colonia_Hechos { get; set; }
        public string Colonia_HechosNombre { get; set; }
        [Range(0, 9999999999)]
        public int? Codigo_Postal_Hechos { get; set; }
        public string Calle_Hechos { get; set; }
        public string Numero_Exterior_Hechos { get; set; }
        public string Numero_Interior_Hechos { get; set; }
        public string Entre_Calle_Hechos { get; set; }
        public string y_Calle_Hechos { get; set; }
        public string Longitud_Hechos { get; set; }
        public string Latitud_H { get; set; }

    }
	
	public class Detalle_de_Solicitud_Solicitante_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        [Range(0, 9999999999)]
        public int? idRegistroAT { get; set; }
        [Range(0, 9999999999)]
        public int? idRegistroUI { get; set; }
        public int? Solicitud { get; set; }
        public string SolicitudNumero_de_Folio { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Nombre_Completo { get; set; }
        public string Fecha_de_Nacimiento { get; set; }
        public string CURP { get; set; }
        public string RFC { get; set; }
        [Range(0, 9999999999)]
        public short? Edad { get; set; }
        public int? Sexo { get; set; }
        public string SexoDescripcion { get; set; }
        public int? Estado_Civil { get; set; }
        public string Estado_CivilDescripcion { get; set; }
        public int? Tipo_de_Identificacion { get; set; }
        public string Tipo_de_IdentificacionNombre { get; set; }
        public string Numero_de_Indentificacion { get; set; }
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
        [Range(0, 9999999999)]
        public int? Codigo_Postal { get; set; }
        public int? Poblacion { get; set; }
        public string PoblacionNombre { get; set; }
        public int? Colonia { get; set; }
        public string ColoniaNombre { get; set; }
        public string Calle { get; set; }
        public string Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public string Entre_Calle { get; set; }
        public string Y_Calle { get; set; }
        public string Longitud { get; set; }
        public string Latitud { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Correo_Electronico { get; set; }
        public int? Pais_de_Origen { get; set; }
        public string Pais_de_OrigenNombre { get; set; }
        public string Originario_de { get; set; }
        public int? Tipo_de_Compareciente { get; set; }
        public string Tipo_de_ComparecienteDescripcion { get; set; }
        public bool? Incapaz { get; set; }
        public int? Tipo_de_Inimputabilidad { get; set; }
        public string Tipo_de_InimputabilidadDescripcion { get; set; }

    }

	public class Detalle_de_Solicitud_Solicitante_Datos_del_TutorModel
    {
        [Required]
        public int Clave { get; set; }
        public string Nombre_tutor { get; set; }
        public string Apellido_Paterno_tutor { get; set; }
        public string Apellido_Materno_tutor { get; set; }
        public string Nombre_Completo_tutor { get; set; }
        public string Fecha_de_Nacimiento_tutor { get; set; }
        public string CURP_Tutor { get; set; }
        public string RFC_Tutor { get; set; }
        [Range(0, 9999999999)]
        public short? Edad_tutor { get; set; }
        public int? Sexo_tutor { get; set; }
        public string Sexo_tutorDescripcion { get; set; }
        public int? Estado_Civil_tutor { get; set; }
        public string Estado_Civil_tutorDescripcion { get; set; }
        public int? Tipo_de_Identificacion_tutor { get; set; }
        public string Tipo_de_Identificacion_tutorNombre { get; set; }
        public string Numero_de_Identificacion_tutor { get; set; }
        public int? Nacionalidad_tutor { get; set; }
        public string Nacionalidad_tutorNacionalidadC { get; set; }
        public short? Escolaridad_tutor { get; set; }
        public string Escolaridad_tutorDescripcion { get; set; }
        public int? Ocupacion_tutor { get; set; }
        public string Ocupacion_tutorDescripcion { get; set; }
        public int? Pais_tutor { get; set; }
        public string Pais_tutorNombre { get; set; }
        public int? Estado_tutor { get; set; }
        public string Estado_tutorNombre { get; set; }
        public int? Municipio_tutor { get; set; }
        public string Municipio_tutorNombre { get; set; }
        public int? Localidad_tutor { get; set; }
        public string Localidad_tutorDescripcion { get; set; }
        public int? Colonia_tutor { get; set; }
        public string Colonia_tutorNombre { get; set; }
        [Range(0, 9999999999)]
        public int? Codigo_Postal_tutor { get; set; }
        public string Calle_tutor { get; set; }
        public string Numero_Exterior_tutor { get; set; }
        public string Numero_Interior_tutor { get; set; }
        public string Telefono_tutor { get; set; }
        [Range(0, 9999999999)]
        public short? Extension_tutor { get; set; }
        public string Celular_tutor { get; set; }
        public string Correo_Electronico_tutor { get; set; }
        public int? Pais_de_Origen_T { get; set; }
        public string Pais_de_Origen_TNombre { get; set; }
        public string Originario_de_T { get; set; }

    }

	public class Detalle_de_Solicitud_Solicitante_Datos_de_los_HechosModel
    {
        [Required]
        public int Clave { get; set; }
        public string Titulo_del_Hecho { get; set; }
        public string Narrativa_Breve_de_los_Hechos { get; set; }
        public string Fecha_del_Hecho { get; set; }
        public string Hora_Aproximada_del_Hecho { get; set; }
        public int? Lugar_de_los_Hechos { get; set; }
        public string Lugar_de_los_HechosDescripcion { get; set; }
        public int? Pais_Hechos { get; set; }
        public string Pais_HechosNombre { get; set; }
        public int? Estado_Hechos { get; set; }
        public string Estado_HechosNombre { get; set; }
        public int? Municipio_Hechos { get; set; }
        public string Municipio_HechosNombre { get; set; }
        public int? Colonia_Hechos { get; set; }
        public string Colonia_HechosNombre { get; set; }
        [Range(0, 9999999999)]
        public int? Codigo_Postal_Hechos { get; set; }
        public string Calle_Hechos { get; set; }
        public string Numero_Exterior_Hechos { get; set; }
        public string Numero_Interior_Hechos { get; set; }
        public string Entre_Calle_Hechos { get; set; }
        public string y_Calle_Hechos { get; set; }
        public string Longitud_Hechos { get; set; }
        public string Latitud_H { get; set; }

    }


}

