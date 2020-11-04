using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class CorporacionModel
    {
        [Required]
        public int Clave { get; set; }
        [Range(0, 9999999999)]
        public int? Clave_Municipio { get; set; }
        [Range(0, 9999999999)]
        public int? Clave_Policia { get; set; }
        public string Descripcion { get; set; }
        public int? Vigencia { get; set; }
        public string VigenciaAbreviacion { get; set; }
        public string Uso_Vehiculo { get; set; }
        public string Observaciones { get; set; }

    }
	
	public class Corporacion_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        [Range(0, 9999999999)]
        public int? Clave_Municipio { get; set; }
        [Range(0, 9999999999)]
        public int? Clave_Policia { get; set; }
        public string Descripcion { get; set; }
        public int? Vigencia { get; set; }
        public string VigenciaAbreviacion { get; set; }
        public string Uso_Vehiculo { get; set; }
        public string Observaciones { get; set; }

    }


}

