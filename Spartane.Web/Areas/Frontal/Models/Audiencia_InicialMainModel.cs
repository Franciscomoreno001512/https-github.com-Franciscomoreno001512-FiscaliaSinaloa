using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Audiencia_InicialMainModel
    {
        public Audiencia_InicialModel Audiencia_InicialInfo { set; get; }
        public Detalle_Relaciones_Audiencia_InicialGridModelPost Detalle_Relaciones_Audiencia_InicialGridInfo { set; get; }

    }

    public class Detalle_Relaciones_Audiencia_InicialGridModelPost
    {
        public int Clave { get; set; }
        public int? Imputado { get; set; }
        public int? Delito { get; set; }

        public bool Removed { set; get; }
    }



}

