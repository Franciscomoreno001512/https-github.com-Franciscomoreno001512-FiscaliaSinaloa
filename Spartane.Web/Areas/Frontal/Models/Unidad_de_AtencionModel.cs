using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Unidad_de_AtencionModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Unidad { get; set; }
        public string UnidadDescripcion { get; set; }

    }
	
	public class Unidad_de_Atencion_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Unidad { get; set; }
        public string UnidadDescripcion { get; set; }

    }


}

