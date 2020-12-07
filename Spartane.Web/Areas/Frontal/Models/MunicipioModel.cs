using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class MunicipioModel
    {
        [Required]
        public int Clave { get; set; }
        public string Nombre { get; set; }
        public string Abreviacion { get; set; }
        public int? Estado { get; set; }
        public string EstadoNombre { get; set; }
        public int? Vigencia { get; set; }
        public string VigenciaAbreviacion { get; set; }
        public string Observaciones { get; set; }
        [Range(0, 9999999999)]
        public int? cod_pais { get; set; }
        public string cod_zona { get; set; }
        public string MuniNSJP { get; set; }
        [Range(0, 9999999999)]
        public int? cod_zona_nsjp { get; set; }

    }
	
	public class Municipio_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Nombre { get; set; }
        public string Abreviacion { get; set; }
        public int? Estado { get; set; }
        public string EstadoNombre { get; set; }
        public int? Vigencia { get; set; }
        public string VigenciaAbreviacion { get; set; }
        public string Observaciones { get; set; }
        [Range(0, 9999999999)]
        public int? cod_pais { get; set; }
        public string cod_zona { get; set; }
        public string MuniNSJP { get; set; }
        [Range(0, 9999999999)]
        public int? cod_zona_nsjp { get; set; }

    }


}

