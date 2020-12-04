using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Delitos_Proceso_PenalModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Delito { get; set; }
        public string DelitoDescripcion { get; set; }

    }
	
	public class Detalle_Delitos_Proceso_Penal_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Delito { get; set; }
        public string DelitoDescripcion { get; set; }

    }


}

