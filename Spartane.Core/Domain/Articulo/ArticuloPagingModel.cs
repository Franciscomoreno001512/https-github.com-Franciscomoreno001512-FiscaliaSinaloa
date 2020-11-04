using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Articulo
{
    public class ArticuloPagingModel
    {
        public List<Spartane.Core.Domain.Articulo.Articulo> Articulos { set; get; }
        public int RowCount { set; get; }
    }
}
