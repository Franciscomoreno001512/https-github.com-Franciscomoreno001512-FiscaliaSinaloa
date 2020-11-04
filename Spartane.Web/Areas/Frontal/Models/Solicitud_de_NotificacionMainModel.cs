using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Solicitud_de_NotificacionMainModel
    {
        public Solicitud_de_NotificacionModel Solicitud_de_NotificacionInfo { set; get; }
        public Detalle_de_Invitado_de_NotificacionGridModelPost Detalle_de_Invitado_de_NotificacionGridInfo { set; get; }

    }

    public class Detalle_de_Invitado_de_NotificacionGridModelPost
    {
        public int Folio { get; set; }
        public string Nombre_Completo { get; set; }
        public string Telefono { get; set; }
        public string Correo_Electronico { get; set; }
        public int? Estado { get; set; }
        public int? Municipio { get; set; }
        public int? Poblacion { get; set; }
        public int? Colonia { get; set; }
        public int? Codigo_Postal { get; set; }
        public string Calle { get; set; }
        public string Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }

        public bool Removed { set; get; }
    }



}

