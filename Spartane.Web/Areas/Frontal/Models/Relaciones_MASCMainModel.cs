using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Relaciones_MASCMainModel
    {
        public Relaciones_MASCModel Relaciones_MASCInfo { set; get; }
        public Detalle_Relaciones_MASCGridModelPost Detalle_Relaciones_MASCGridInfo { set; get; }

    }

    public class Detalle_Relaciones_MASCGridModelPost
    {
        public int Clave { get; set; }
        public int? Requerido { get; set; }
        public int? Delito { get; set; }
        public int? Solicitante { get; set; }

        public bool Removed { set; get; }
    }



}

