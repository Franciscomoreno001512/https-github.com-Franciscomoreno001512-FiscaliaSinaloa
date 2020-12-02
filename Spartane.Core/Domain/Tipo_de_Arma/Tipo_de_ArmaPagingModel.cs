using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_de_Arma
{
    public class Tipo_de_ArmaPagingModel
    {
        public List<Spartane.Core.Domain.Tipo_de_Arma.Tipo_de_Arma> Tipo_de_Armas { set; get; }
        public int RowCount { set; get; }
    }
}
