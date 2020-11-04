using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Genero
{
    public class GeneroPagingModel
    {
        public List<Spartane.Core.Domain.Genero.Genero> Generos { set; get; }
        public int RowCount { set; get; }
    }
}
