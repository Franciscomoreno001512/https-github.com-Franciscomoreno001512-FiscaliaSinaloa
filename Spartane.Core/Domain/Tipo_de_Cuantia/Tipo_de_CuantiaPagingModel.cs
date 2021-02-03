using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_de_Cuantia
{
    public class Tipo_de_CuantiaPagingModel
    {
        public List<Spartane.Core.Domain.Tipo_de_Cuantia.Tipo_de_Cuantia> Tipo_de_Cuantias { set; get; }
        public int RowCount { set; get; }
    }
}
