using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class PreRequisito_de_MovimientoModel
    {
        [Required]
        public int Clave { get; set; }
        public int? PreRequisito { get; set; }
        public string PreRequisitoDescripcion { get; set; }

    }
	
	public class PreRequisito_de_Movimiento_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? PreRequisito { get; set; }
        public string PreRequisitoDescripcion { get; set; }

    }


}

