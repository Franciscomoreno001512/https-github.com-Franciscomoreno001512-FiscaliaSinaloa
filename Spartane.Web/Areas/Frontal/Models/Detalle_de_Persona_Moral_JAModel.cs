using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Persona_Moral_JAModel
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
        public string Calidad_Juridica { get; set; }
        public string Razon_Social { get; set; }
        public string CURP { get; set; }
        public string RFC { get; set; }
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
        public string Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public string Referencia { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public string Telefono { get; set; }
        [Range(0, 9999999999)]
        public int? Extension { get; set; }
        public string Celular { get; set; }
        public string Correo_Electronico { get; set; }

    }
	
	public class Detalle_de_Persona_Moral_JA_Datos_GeneralesModel
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
        public string Calidad_Juridica { get; set; }
        public string Razon_Social { get; set; }
        public string CURP { get; set; }
        public string RFC { get; set; }
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
        public string Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public string Referencia { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public string Telefono { get; set; }
        [Range(0, 9999999999)]
        public int? Extension { get; set; }
        public string Celular { get; set; }
        public string Correo_Electronico { get; set; }

    }


}

