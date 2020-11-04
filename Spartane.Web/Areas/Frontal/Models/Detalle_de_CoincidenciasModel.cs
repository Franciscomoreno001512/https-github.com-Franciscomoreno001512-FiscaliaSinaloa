using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_CoincidenciasModel
    {
        [Required]
        public int Clave { get; set; }

    }
	
	public class Detalle_de_Coincidencias_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }

    }


}

