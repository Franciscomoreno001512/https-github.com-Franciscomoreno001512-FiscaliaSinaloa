using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class PaisModel
    {
        [Required]
        public int Clave { get; set; }
        public string Nombre { get; set; }
        public int? Vigencia { get; set; }
        public string VigenciaAbreviacion { get; set; }
        public string Observaciones { get; set; }
        public string Nacionalidad { get; set; }
        public string Abrevia { get; set; }

    }
	
	public class Pais_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Nombre { get; set; }
        public int? Vigencia { get; set; }
        public string VigenciaAbreviacion { get; set; }
        public string Observaciones { get; set; }
        public string Nacionalidad { get; set; }
        public string Abrevia { get; set; }

    }


}

