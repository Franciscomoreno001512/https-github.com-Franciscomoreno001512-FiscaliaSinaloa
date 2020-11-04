using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_de_Carretera
{
    public class Tipo_de_CarreteraPagingModel
    {
        public List<Spartane.Core.Domain.Tipo_de_Carretera.Tipo_de_Carretera> Tipo_de_Carreteras { set; get; }
        public int RowCount { set; get; }
    }
}
