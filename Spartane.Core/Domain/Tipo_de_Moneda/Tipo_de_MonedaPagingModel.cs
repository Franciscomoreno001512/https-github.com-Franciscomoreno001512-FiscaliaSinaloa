using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_de_Moneda
{
    public class Tipo_de_MonedaPagingModel
    {
        public List<Spartane.Core.Domain.Tipo_de_Moneda.Tipo_de_Moneda> Tipo_de_Monedas { set; get; }
        public int RowCount { set; get; }
    }
}
