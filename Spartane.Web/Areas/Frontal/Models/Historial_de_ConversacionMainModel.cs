using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Historial_de_ConversacionMainModel
    {
        public Historial_de_ConversacionModel Historial_de_ConversacionInfo { set; get; }
        public Detalle_de_Mensaje_de_HistorialGridModelPost Detalle_de_Mensaje_de_HistorialGridInfo { set; get; }

    }

    public class Detalle_de_Mensaje_de_HistorialGridModelPost
    {
        public int Clave { get; set; }
        public string Hora { get; set; }
        public string Mensaje { get; set; }

        public bool Removed { set; get; }
    }



}

