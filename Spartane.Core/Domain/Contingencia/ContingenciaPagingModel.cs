using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Contingencia
{
    public class ContingenciaPagingModel
    {
        public List<Spartane.Core.Domain.Contingencia.Contingencia> Contingencias { set; get; }
        public int RowCount { set; get; }
    }
}
