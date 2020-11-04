using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Requerido_AcuerdoModel
    {
        [Required]
        public int Folio { get; set; }
        public int? Requerido { get; set; }
        public string RequeridoNombre_Completo { get; set; }

    }
	
	public class Detalle_Requerido_Acuerdo_Datos_GeneralesModel
    {
        [Required]
        public int Folio { get; set; }
        public int? Requerido { get; set; }
        public string RequeridoNombre_Completo { get; set; }

    }


}

