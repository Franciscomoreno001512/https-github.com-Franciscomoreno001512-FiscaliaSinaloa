using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Delegacion
{
    public class DelegacionPagingModel
    {
        public List<Spartane.Core.Domain.Delegacion.Delegacion> Delegacions { set; get; }
        public int RowCount { set; get; }
    }
}
