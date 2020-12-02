using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Marca_de_Arma
{
    public class Marca_de_ArmaPagingModel
    {
        public List<Spartane.Core.Domain.Marca_de_Arma.Marca_de_Arma> Marca_de_Armas { set; get; }
        public int RowCount { set; get; }
    }
}
