using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class AmbitoModel
    {
        [Required]
        public int Clave { get; set; }
        public string Ambitox { get; set; }

    }
	
	public class Ambito_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Ambitox { get; set; }

    }


}

