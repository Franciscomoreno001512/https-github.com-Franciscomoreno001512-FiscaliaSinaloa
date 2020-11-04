using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Compareciente
{
    public class ComparecientePagingModel
    {
        public List<Spartane.Core.Domain.Compareciente.Compareciente> Comparecientes { set; get; }
        public int RowCount { set; get; }
    }
}
