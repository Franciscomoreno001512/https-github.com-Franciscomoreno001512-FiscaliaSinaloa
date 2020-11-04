using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Agravantes_del_DelitoModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Agravante { get; set; }
        public string AgravanteDescripcion { get; set; }

    }
	
	public class Agravantes_del_Delito_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Agravante { get; set; }
        public string AgravanteDescripcion { get; set; }

    }


}

