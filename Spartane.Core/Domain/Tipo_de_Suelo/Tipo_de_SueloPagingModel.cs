using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_de_Suelo
{
    public class Tipo_de_SueloPagingModel
    {
        public List<Spartane.Core.Domain.Tipo_de_Suelo.Tipo_de_Suelo> Tipo_de_Suelos { set; get; }
        public int RowCount { set; get; }
    }
}
