using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Medidas_ProteccionGridModel
    {
        public int Clave { get; set; }
        public bool? Seleccionar { get; set; }
        public int? Medida { get; set; }
        public string MedidaDescripcion { get; set; }
        
    }
}

