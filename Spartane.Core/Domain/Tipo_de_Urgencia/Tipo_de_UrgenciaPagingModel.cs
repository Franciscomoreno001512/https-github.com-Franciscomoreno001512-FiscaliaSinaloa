using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_de_Urgencia
{
    public class Tipo_de_UrgenciaPagingModel
    {
        public List<Spartane.Core.Domain.Tipo_de_Urgencia.Tipo_de_Urgencia> Tipo_de_Urgencias { set; get; }
        public int RowCount { set; get; }
    }
}
