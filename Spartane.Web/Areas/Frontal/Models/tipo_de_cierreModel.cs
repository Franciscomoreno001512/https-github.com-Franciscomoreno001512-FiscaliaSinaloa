using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class tipo_de_cierreModel
    {
        [Required]
        public int clave { get; set; }
        public string descripcion { get; set; }

    }
	
	public class tipo_de_cierre_Datos_GeneralesModel
    {
        [Required]
        public int clave { get; set; }
        public string descripcion { get; set; }

    }


}

