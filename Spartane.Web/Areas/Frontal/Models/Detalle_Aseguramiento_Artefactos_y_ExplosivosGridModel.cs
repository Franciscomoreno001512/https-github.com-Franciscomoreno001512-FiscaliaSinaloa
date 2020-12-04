using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Aseguramiento_Artefactos_y_ExplosivosGridModel
    {
        public int Clave { get; set; }
        public short? Clasificacion { get; set; }
        public string ClasificacionDescripcion { get; set; }
        public decimal? Cantidad { get; set; }
        public string Lugar_de_Hallazgo { get; set; }
        public string Observaciones { get; set; }
        
    }
}

