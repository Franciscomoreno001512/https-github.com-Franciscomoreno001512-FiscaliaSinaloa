using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Lugar_del_Robo
{
    public class Lugar_del_RoboPagingModel
    {
        public List<Spartane.Core.Domain.Lugar_del_Robo.Lugar_del_Robo> Lugar_del_Robos { set; get; }
        public int RowCount { set; get; }
    }
}
