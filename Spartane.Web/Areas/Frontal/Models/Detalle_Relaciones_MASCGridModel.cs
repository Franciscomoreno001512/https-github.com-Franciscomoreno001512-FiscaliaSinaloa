using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Relaciones_MASCGridModel
    {
        public int Clave { get; set; }
        public int? Requerido { get; set; }
        public string RequeridoNombre_Completo_Detenido { get; set; }
        public int? Delito { get; set; }
        public string DelitoDescripcion { get; set; }
        public int? Solicitante { get; set; }
        public string SolicitanteNombre_Completo { get; set; }
        
    }
}

