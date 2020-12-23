using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Direccion_Exacta
{
    public class Direccion_ExactaPagingModel
    {
        public List<Spartane.Core.Domain.Direccion_Exacta.Direccion_Exacta> Direccion_Exactas { set; get; }
        public int RowCount { set; get; }
    }
}
