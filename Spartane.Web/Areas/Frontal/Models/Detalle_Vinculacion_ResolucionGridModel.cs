using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Vinculacion_ResolucionGridModel
    {
        public int Clave { get; set; }
        public bool? Seleccionar { get; set; }
        public string Relacion { get; set; }
        public int? idRelacion { get; set; }
        
    }
}

