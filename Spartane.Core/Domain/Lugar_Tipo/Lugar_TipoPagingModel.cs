using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Lugar_Tipo
{
    public class Lugar_TipoPagingModel
    {
        public List<Spartane.Core.Domain.Lugar_Tipo.Lugar_Tipo> Lugar_Tipos { set; get; }
        public int RowCount { set; get; }
    }
}
