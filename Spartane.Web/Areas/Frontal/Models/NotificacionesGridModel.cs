using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class NotificacionesGridModel
    {
        public int Folio { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string Titulo { get; set; }
        public string Notificacion { get; set; }
        public int? Destinatario { get; set; }
        public string DestinatarioName { get; set; }
        public bool? Enviado { get; set; }
        
    }
}

