using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Vinculacion_ResolucionModel
    {
        [Required]
        public int Clave { get; set; }
        public bool Seleccionar { get; set; }
        public string Relacion { get; set; }
        [Range(0, 9999999999)]
        public int? idRelacion { get; set; }

    }
	
	public class Detalle_Vinculacion_Resolucion_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public bool? Seleccionar { get; set; }
        public string Relacion { get; set; }
        [Range(0, 9999999999)]
        public int? idRelacion { get; set; }

    }


}

