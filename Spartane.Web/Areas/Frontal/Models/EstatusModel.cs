using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class EstatusModel
    {
        [Required]
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        [Range(0, 9999999999)]
        public int? Tiempo1 { get; set; }
        [Range(0, 9999999999)]
        public int? Tiempo2 { get; set; }
        public int? Vigencia { get; set; }
        public string VigenciaAbreviacion { get; set; }
        public string Observaciones { get; set; }

    }
	
	public class Estatus_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        [Range(0, 9999999999)]
        public int? Tiempo1 { get; set; }
        [Range(0, 9999999999)]
        public int? Tiempo2 { get; set; }
        public int? Vigencia { get; set; }
        public string VigenciaAbreviacion { get; set; }
        public string Observaciones { get; set; }

    }


}

