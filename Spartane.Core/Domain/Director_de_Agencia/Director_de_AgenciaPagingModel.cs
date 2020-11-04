using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Director_de_Agencia
{
    public class Director_de_AgenciaPagingModel
    {
        public List<Spartane.Core.Domain.Director_de_Agencia.Director_de_Agencia> Director_de_Agencias { set; get; }
        public int RowCount { set; get; }
    }
}
