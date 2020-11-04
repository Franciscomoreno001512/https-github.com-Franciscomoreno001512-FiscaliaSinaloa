using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_de_Robo
{
    public class Tipo_de_RoboPagingModel
    {
        public List<Spartane.Core.Domain.Tipo_de_Robo.Tipo_de_Robo> Tipo_de_Robos { set; get; }
        public int RowCount { set; get; }
    }
}
