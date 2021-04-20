using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Indicios_de_DiligenciaGridModel
    {
        public int Folio { get; set; }
        public string Indicio { get; set; }
        public bool? Seleccionar { get; set; }
        public int? IndicioId { get; set; }
        
    }
}

