using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Solicitudes_de_InvitacionesMainModel
    {
        public Detalle_de_Solicitudes_de_InvitacionesModel Detalle_de_Solicitudes_de_InvitacionesInfo { set; get; }
        public Detalle_de_Solicitante_en_InvitacionesGridModelPost Detalle_de_Solicitante_en_InvitacionesGridInfo { set; get; }
        public Detalle_de_Requerido_en_InvitacionesGridModelPost Detalle_de_Requerido_en_InvitacionesGridInfo { set; get; }

    }

    public class Detalle_de_Solicitante_en_InvitacionesGridModelPost
    {
        public int Clave { get; set; }
        public int? Nombre { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_de_Requerido_en_InvitacionesGridModelPost
    {
        public int Clave { get; set; }
        public int? Nombre { get; set; }

        public bool Removed { set; get; }
    }



}

