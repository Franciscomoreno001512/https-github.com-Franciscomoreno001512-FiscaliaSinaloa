using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Historial_de_ConversacionModel
    {
        [Required]
        public int Folio { get; set; }
        [Range(0, 9999999999)]
        public int? Remitente { get; set; }
        [Range(0, 9999999999)]
        public int? Destinatario { get; set; }
        public string Fecha { get; set; }

    }
	
	public class Historial_de_Conversacion_Datos_GeneralesModel
    {
        [Required]
        public int Folio { get; set; }
        [Range(0, 9999999999)]
        public int? Remitente { get; set; }
        [Range(0, 9999999999)]
        public int? Destinatario { get; set; }
        public string Fecha { get; set; }

    }


}

