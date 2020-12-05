using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Aseguramiento_Armas_InvolucradasGridModel
    {
        public int Clave { get; set; }
        public int? Tipo { get; set; }
        public string TipoNombre { get; set; }
        public string Descripcion_del_Arma { get; set; }
        public int? Marca { get; set; }
        public string MarcaNombre { get; set; }
        public short? Calibre { get; set; }
        public string CalibreDescripcion { get; set; }
        public string Matricula { get; set; }
        public string Serie { get; set; }
        public string Inventario { get; set; }
        public int? Clasificacion { get; set; }
        public string ClasificacionDescripcion { get; set; }
        public int? Cantidad { get; set; }
        public string Lugar_de_Hallazgo { get; set; }
        public string Observaciones { get; set; }
        
    }
}

