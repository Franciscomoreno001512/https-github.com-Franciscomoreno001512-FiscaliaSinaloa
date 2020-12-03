using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_Aseguramiento_Moneda
{
    public class Detalle_Aseguramiento_MonedaPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_Aseguramiento_Moneda.Detalle_Aseguramiento_Moneda> Detalle_Aseguramiento_Monedas { set; get; }
        public int RowCount { set; get; }
    }
}
