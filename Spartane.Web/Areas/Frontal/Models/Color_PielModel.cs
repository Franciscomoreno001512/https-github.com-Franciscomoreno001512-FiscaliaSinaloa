using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Color_PielModel
    {
        [Required]
        public int Clave { get; set; }
        public string Descrpicion { get; set; }

    }
	
	public class Color_Piel_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Descrpicion { get; set; }

    }


}

