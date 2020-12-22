using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Institucion_Emisora
{
    public class Institucion_EmisoraPagingModel
    {
        public List<Spartane.Core.Domain.Institucion_Emisora.Institucion_Emisora> Institucion_Emisoras { set; get; }
        public int RowCount { set; get; }
    }
}
