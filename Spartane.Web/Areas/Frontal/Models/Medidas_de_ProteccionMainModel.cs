using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Medidas_de_ProteccionMainModel
    {
        public Medidas_de_ProteccionModel Medidas_de_ProteccionInfo { set; get; }
        public Detalle_Medidas_ProteccionGridModelPost Detalle_Medidas_ProteccionGridInfo { set; get; }

    }

    public class Detalle_Medidas_ProteccionGridModelPost
    {
        public int Clave { get; set; }
        public bool? Seleccionar { get; set; }
        public int? Medida { get; set; }

        public bool Removed { set; get; }
    }



}

