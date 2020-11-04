using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Tipo_de_UrgenciaModel
    {
        [Required]
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        [Range(0, 9999999999)]
        public short? Orden { get; set; }
        public int? Vigente { get; set; }
        public string VigenteAbreviacion { get; set; }
        public string Observaciones { get; set; }

    }
	
	public class Tipo_de_Urgencia_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        [Range(0, 9999999999)]
        public short? Orden { get; set; }
        public int? Vigente { get; set; }
        public string VigenteAbreviacion { get; set; }
        public string Observaciones { get; set; }

    }


}

