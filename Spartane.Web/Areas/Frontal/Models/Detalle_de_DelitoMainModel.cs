using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_DelitoMainModel
    {
        public Detalle_de_DelitoModel Detalle_de_DelitoInfo { set; get; }
        public Agravantes_del_DelitoGridModelPost Agravantes_del_DelitoGridInfo { set; get; }
        public Circunstancias_del_DelitoGridModelPost Circunstancias_del_DelitoGridInfo { set; get; }

    }

    public class Agravantes_del_DelitoGridModelPost
    {
        public int Clave { get; set; }
        public int? Agravante { get; set; }

        public bool Removed { set; get; }
    }

    public class Circunstancias_del_DelitoGridModelPost
    {
        public int Clave { get; set; }
        public int? Tipo_de_Lugar { get; set; }

        public bool Removed { set; get; }
    }



}

