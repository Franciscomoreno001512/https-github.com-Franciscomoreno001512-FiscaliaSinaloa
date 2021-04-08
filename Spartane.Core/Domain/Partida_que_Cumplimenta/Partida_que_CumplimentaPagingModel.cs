using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Partida_que_Cumplimenta
{
    public class Partida_que_CumplimentaPagingModel
    {
        public List<Spartane.Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta> Partida_que_Cumplimentas { set; get; }
        public int RowCount { set; get; }
    }
}
