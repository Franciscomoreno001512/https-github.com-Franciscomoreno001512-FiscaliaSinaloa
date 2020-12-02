using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_de_Droga
{
    public class Tipo_de_DrogaPagingModel
    {
        public List<Spartane.Core.Domain.Tipo_de_Droga.Tipo_de_Droga> Tipo_de_Drogas { set; get; }
        public int RowCount { set; get; }
    }
}
