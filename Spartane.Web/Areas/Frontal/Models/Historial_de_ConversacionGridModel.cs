using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Historial_de_ConversacionGridModel
    {
        public int Folio { get; set; }
        public int? Remitente { get; set; }
        public int? Destinatario { get; set; }
        public string Fecha { get; set; }
        
    }
}

