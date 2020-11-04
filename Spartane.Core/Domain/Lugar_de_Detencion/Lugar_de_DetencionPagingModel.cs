using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Lugar_de_Detencion
{
    public class Lugar_de_DetencionPagingModel
    {
        public List<Spartane.Core.Domain.Lugar_de_Detencion.Lugar_de_Detencion> Lugar_de_Detencions { set; get; }
        public int RowCount { set; get; }
    }
}
