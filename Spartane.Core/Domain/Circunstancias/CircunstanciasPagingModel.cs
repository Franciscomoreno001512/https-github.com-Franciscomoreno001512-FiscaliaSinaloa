using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Circunstancias
{
    public class CircunstanciasPagingModel
    {
        public List<Spartane.Core.Domain.Circunstancias.Circunstancias> Circunstanciass { set; get; }
        public int RowCount { set; get; }
    }
}
