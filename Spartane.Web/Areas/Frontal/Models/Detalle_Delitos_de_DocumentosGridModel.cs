using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Delitos_de_DocumentosGridModel
    {
        public int Clave { get; set; }
        public int? Delito { get; set; }
        public string DelitoDescripcion_corta { get; set; }
        
    }
}

