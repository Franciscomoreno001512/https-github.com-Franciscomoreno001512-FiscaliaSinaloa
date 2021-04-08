using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Involucrados_PCModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Solicitud { get; set; }
        public string SolicitudFolio { get; set; }
        public bool Desea_indicar_datos_adicionales { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Usuario_que_RegistraName { get; set; }
        public int? Tipo_de_Compareciente { get; set; }
        public string Tipo_de_ComparecienteDescripcion { get; set; }
        public int? Tipo_de_Victima { get; set; }
        public string Tipo_de_VictimaDescripcion { get; set; }
        public string Nombres { get; set; }
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
        public int? Fotografia_de_la_identificacion { get; set; }
        public HttpPostedFileBase Fotografia_de_la_identificacionFile { set; get; }
        public int Fotografia_de_la_identificacionRemoveAttachment { set; get; }
        public string CURP { get; set; }
        public int? Nacionalidad { get; set; }
        public string NacionalidadNacionalidadC { get; set; }
        public string Originario_de { get; set; }
        public bool Existieron_testigos { get; set; }
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
        public string Calle { get; set; }
        public string Entre_Calle { get; set; }
        public string Y_Calle { get; set; }
        public string Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public string Referencia_de_Domicilio { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }

    }
	
	public class Involucrados_PC_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Solicitud { get; set; }
        public string SolicitudFolio { get; set; }
        public bool? Desea_indicar_datos_adicionales { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Usuario_que_RegistraName { get; set; }
        public int? Tipo_de_Compareciente { get; set; }
        public string Tipo_de_ComparecienteDescripcion { get; set; }
        public int? Tipo_de_Victima { get; set; }
        public string Tipo_de_VictimaDescripcion { get; set; }
        public string Nombres { get; set; }
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
        public int? Fotografia_de_la_identificacion { get; set; }
        public HttpPostedFileBase Fotografia_de_la_identificacionFile { set; get; }
        public int Fotografia_de_la_identificacionRemoveAttachment { set; get; }
        public string CURP { get; set; }
        public int? Nacionalidad { get; set; }
        public string NacionalidadNacionalidadC { get; set; }
        public string Originario_de { get; set; }
        public bool? Existieron_testigos { get; set; }

    }

	public class Involucrados_PC_DomicilioModel
    {
        [Required]
        public int Clave { get; set; }
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
        public string Calle { get; set; }
        public string Entre_Calle { get; set; }
        public string Y_Calle { get; set; }
        public string Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public string Referencia_de_Domicilio { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }

    }


}

