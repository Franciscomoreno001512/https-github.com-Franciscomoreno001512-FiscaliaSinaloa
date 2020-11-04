using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Solicitante_AcuerdoModel
    {
        [Required]
        public int Folio { get; set; }
        public int? Solicitante { get; set; }
        public string SolicitanteNombre_Completo_tutor { get; set; }

    }
	
	public class Detalle_Solicitante_Acuerdo_Datos_GeneralesModel
    {
        [Required]
        public int Folio { get; set; }
        public int? Solicitante { get; set; }
        public string SolicitanteNombre_Completo_tutor { get; set; }

    }


}

