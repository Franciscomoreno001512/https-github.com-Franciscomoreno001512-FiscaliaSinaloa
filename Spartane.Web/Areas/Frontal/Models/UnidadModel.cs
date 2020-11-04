using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class UnidadModel
    {
        [Required]
        public int Clave { get; set; }
        [Range(0, 9999999999)]
        public int? Clave_Unica_Municipio { get; set; }
        public int? Clave_de_Municipio { get; set; }
        public string Clave_de_MunicipioNombre { get; set; }
        public int? Clave_de_Region { get; set; }
        public string Clave_de_RegionDescripcion { get; set; }
        public string Abreviacion { get; set; }
        public string Descripcion { get; set; }
        public string Descripcion_Corta { get; set; }
        public int? Vigencia { get; set; }
        public string VigenciaAbreviacion { get; set; }
        public string Direccion { get; set; }
        public string Observaciones { get; set; }
        public int? Supervisor { get; set; }
        public string SupervisorName { get; set; }

    }
	
	public class Unidad_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        [Range(0, 9999999999)]
        public int? Clave_Unica_Municipio { get; set; }
        public int? Clave_de_Municipio { get; set; }
        public string Clave_de_MunicipioNombre { get; set; }
        public int? Clave_de_Region { get; set; }
        public string Clave_de_RegionDescripcion { get; set; }
        public string Abreviacion { get; set; }
        public string Descripcion { get; set; }
        public string Descripcion_Corta { get; set; }
        public int? Vigencia { get; set; }
        public string VigenciaAbreviacion { get; set; }
        public string Direccion { get; set; }
        public string Observaciones { get; set; }
        public int? Supervisor { get; set; }
        public string SupervisorName { get; set; }

    }


}

