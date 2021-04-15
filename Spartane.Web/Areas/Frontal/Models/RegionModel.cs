using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class RegionModel
    {
        [Required]
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public string Abreviacion { get; set; }
        public bool recepcion_servicios_apoyo { get; set; }
        public int? Vigencia { get; set; }
        public string VigenciaAbreviacion { get; set; }
        public string Observaciones { get; set; }
        [Range(0, 9999999999)]
        public int? Consecutivo_CDI { get; set; }

    }
	
	public class Region_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public string Abreviacion { get; set; }
        public bool? recepcion_servicios_apoyo { get; set; }
        public int? Vigencia { get; set; }
        public string VigenciaAbreviacion { get; set; }
        public string Observaciones { get; set; }
        [Range(0, 9999999999)]
        public int? Consecutivo_CDI { get; set; }

    }


}

