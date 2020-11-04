using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Requerido_en_ExamenModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Nombre { get; set; }
        public string NombreNombre { get; set; }

    }
	
	public class Detalle_de_Requerido_en_Examen_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Nombre { get; set; }
        public string NombreNombre { get; set; }

    }


}

