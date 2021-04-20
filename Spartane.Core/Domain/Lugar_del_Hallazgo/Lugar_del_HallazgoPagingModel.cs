using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Lugar_del_Hallazgo
{
    public class Lugar_del_HallazgoPagingModel
    {
        public List<Spartane.Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo> Lugar_del_Hallazgos { set; get; }
        public int RowCount { set; get; }
    }
}
