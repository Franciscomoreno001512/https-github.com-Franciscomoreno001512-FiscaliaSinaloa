using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Aseguramiento_MonedaGridModel
    {
        public int Clave { get; set; }
        public short? Tipo { get; set; }
        public string TipoDescripcion { get; set; }
        public decimal? Cantidad { get; set; }
        public string Observaciones { get; set; }
        public short? Descripcion { get; set; }
        public string DescripcionDescripcion { get; set; }
        
    }
}

