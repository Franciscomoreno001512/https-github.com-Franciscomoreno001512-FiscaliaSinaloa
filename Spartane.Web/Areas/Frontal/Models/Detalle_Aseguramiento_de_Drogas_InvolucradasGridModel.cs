using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Aseguramiento_de_Drogas_InvolucradasGridModel
    {
        public int Clave { get; set; }
        public short? Tipo { get; set; }
        public string TipoDescripcion { get; set; }
        public short? Unidad_de_Medida { get; set; }
        public string Unidad_de_MedidaDescripcion { get; set; }
        public decimal? Cantidad { get; set; }
        public string Observaciones { get; set; }
        
    }
}

