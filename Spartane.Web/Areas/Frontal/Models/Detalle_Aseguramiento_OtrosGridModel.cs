using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Aseguramiento_OtrosGridModel
    {
        public int Clave { get; set; }
        public string Tipo { get; set; }
        public string Unidad_de_medida { get; set; }
        public decimal? Cantidad { get; set; }
        public string Descripcion { get; set; }
        
    }
}

