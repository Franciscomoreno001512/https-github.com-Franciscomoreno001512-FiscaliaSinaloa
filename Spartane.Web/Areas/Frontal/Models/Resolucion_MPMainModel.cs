using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Resolucion_MPMainModel
    {
        public Resolucion_MPModel Resolucion_MPInfo { set; get; }
        public Detalle_Vinculacion_ResolucionGridModelPost Detalle_Vinculacion_ResolucionGridInfo { set; get; }

    }

    public class Detalle_Vinculacion_ResolucionGridModelPost
    {
        public int Clave { get; set; }
        public bool? Seleccionar { get; set; }
        public string Relacion { get; set; }
        public int? idRelacion { get; set; }

        public bool Removed { set; get; }
    }



}

