using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Mensaje_de_HistorialModel
    {
        [Required]
        public int Clave { get; set; }
        public string Hora { get; set; }
        public string Mensaje { get; set; }

    }
	
	public class Detalle_de_Mensaje_de_Historial_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Hora { get; set; }
        public string Mensaje { get; set; }

    }


}

