using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Reuniones_de_MediacionMainModel
    {
        public Detalle_de_Reuniones_de_MediacionModel Detalle_de_Reuniones_de_MediacionInfo { set; get; }
        public Detalle_de_Solicitante_en_ReunionesGridModelPost Detalle_de_Solicitante_en_ReunionesGridInfo { set; get; }
        public Detalle_de_Requerido_en_ReunionesGridModelPost Detalle_de_Requerido_en_ReunionesGridInfo { set; get; }

    }

    public class Detalle_de_Solicitante_en_ReunionesGridModelPost
    {
        public int Clave { get; set; }
        public int? Nombre { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_de_Requerido_en_ReunionesGridModelPost
    {
        public int Clave { get; set; }
        public int? Nombre { get; set; }
        public bool? Faltante { get; set; }

        public bool Removed { set; get; }
    }



}

