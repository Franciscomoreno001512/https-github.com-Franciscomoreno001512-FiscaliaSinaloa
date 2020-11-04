using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Folio_NUE_CCModel
    {
        [Required]
        public int Clave { get; set; }
        public string Folio { get; set; }

    }
	
	public class Detalle_de_Folio_NUE_CC_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Folio { get; set; }

    }


}

