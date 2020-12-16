using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Datos_Adicionales_MovimientoGridModel
    {
        public int Clave { get; set; }
        public string Dato { get; set; }
        public int? Tipo_de_Dato { get; set; }
        public string Tipo_de_DatoDescripcion { get; set; }
        public int? Relacion { get; set; }
        public string RelacionDescripcion { get; set; }
        public bool? Obligatorio { get; set; }
        
    }
}

