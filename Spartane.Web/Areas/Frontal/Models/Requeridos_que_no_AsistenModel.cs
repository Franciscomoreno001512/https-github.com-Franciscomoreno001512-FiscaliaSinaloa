using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Requeridos_que_no_AsistenModel
    {
        [Required]
        public int Clave { get; set; }
        public string Requeridos { get; set; }
        public string Solicitud { get; set; }

    }
	
	public class Requeridos_que_no_Asisten_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Requeridos { get; set; }
        public string Solicitud { get; set; }

    }


}

