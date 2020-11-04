using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Fotos_CCModel
    {
        [Required]
        public int Clave { get; set; }
        [Range(0, 9999999999)]
        public short? Fotos { get; set; }
        public string Pie_de_Foto { get; set; }

    }
	
	public class Detalle_de_Fotos_CC_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        [Range(0, 9999999999)]
        public short? Fotos { get; set; }
        public string Pie_de_Foto { get; set; }

    }


}

