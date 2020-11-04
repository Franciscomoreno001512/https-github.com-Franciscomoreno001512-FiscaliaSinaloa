using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Encuesta
{
    public class EncuestaPagingModel
    {
        public List<Spartane.Core.Domain.Encuesta.Encuesta> Encuestas { set; get; }
        public int RowCount { set; get; }
    }
}
