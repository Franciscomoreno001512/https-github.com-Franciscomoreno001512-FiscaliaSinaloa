using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Compania_de_Seguros
{
    public class Compania_de_SegurosPagingModel
    {
        public List<Spartane.Core.Domain.Compania_de_Seguros.Compania_de_Seguros> Compania_de_Seguross { set; get; }
        public int RowCount { set; get; }
    }
}
