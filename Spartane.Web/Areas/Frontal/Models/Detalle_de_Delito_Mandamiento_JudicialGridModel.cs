using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Delito_Mandamiento_JudicialGridModel
    {
        public int Clave { get; set; }
        public int? Delito { get; set; }
        public string DelitoDescripcion { get; set; }
        public short? Modalidad { get; set; }
        public string ModalidadDescripcion { get; set; }
        
    }
}

