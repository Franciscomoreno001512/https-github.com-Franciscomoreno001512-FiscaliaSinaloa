using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_de_Crimen
{
    public class Tipo_de_CrimenPagingModel
    {
        public List<Spartane.Core.Domain.Tipo_de_Crimen.Tipo_de_Crimen> Tipo_de_Crimens { set; get; }
        public int RowCount { set; get; }
    }
}
