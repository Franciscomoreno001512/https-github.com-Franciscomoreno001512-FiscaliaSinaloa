using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Concurso
{
    public class ConcursoPagingModel
    {
        public List<Spartane.Core.Domain.Concurso.Concurso> Concursos { set; get; }
        public int RowCount { set; get; }
    }
}
