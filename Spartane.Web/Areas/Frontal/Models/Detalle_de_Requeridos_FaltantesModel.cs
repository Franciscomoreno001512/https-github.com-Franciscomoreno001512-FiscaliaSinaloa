using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Requeridos_FaltantesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Requerido { get; set; }
        public string RequeridoRequeridos { get; set; }

    }
	
	public class Detalle_de_Requeridos_Faltantes_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Requerido { get; set; }
        public string RequeridoRequeridos { get; set; }

    }


}

