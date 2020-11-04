using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Idioma
{
    public class IdiomaPagingModel
    {
        public List<Spartane.Core.Domain.Idioma.Idioma> Idiomas { set; get; }
        public int RowCount { set; get; }
    }
}
