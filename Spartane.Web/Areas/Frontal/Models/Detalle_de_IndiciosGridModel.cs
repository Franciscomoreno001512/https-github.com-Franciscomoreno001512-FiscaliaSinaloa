using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_IndiciosGridModel
    {
        public int Clave { get; set; }
        public string Numero_de_Indicio { get; set; }
        public string Nombre_de_Indicio { get; set; }
        public string Descripcion_de_Indicio { get; set; }
        public string Motivo_de_Indicio { get; set; }
        public int? Diligencia { get; set; }
        public string DiligenciaServicio { get; set; }
        public string Ubicacion { get; set; }
        public int? Estatus { get; set; }
        public string EstatusDescripcion { get; set; }
        
    }
}

