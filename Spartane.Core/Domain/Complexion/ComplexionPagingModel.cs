using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Complexion
{
    public class ComplexionPagingModel
    {
        public List<Spartane.Core.Domain.Complexion.Complexion> Complexions { set; get; }
        public int RowCount { set; get; }
    }
}
