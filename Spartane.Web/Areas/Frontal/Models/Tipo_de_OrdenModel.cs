using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Tipo_de_OrdenModel
    {
        [Required]
        public int Clave { get; set; }
        public string Tipo_de_Ordenx { get; set; }

    }
	
	public class Tipo_de_Orden_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Tipo_de_Ordenx { get; set; }

    }


}

