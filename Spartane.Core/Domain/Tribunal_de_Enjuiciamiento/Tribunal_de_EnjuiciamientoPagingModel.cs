using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tribunal_de_Enjuiciamiento
{
    public class Tribunal_de_EnjuiciamientoPagingModel
    {
        public List<Spartane.Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento> Tribunal_de_Enjuiciamientos { set; get; }
        public int RowCount { set; get; }
    }
}
