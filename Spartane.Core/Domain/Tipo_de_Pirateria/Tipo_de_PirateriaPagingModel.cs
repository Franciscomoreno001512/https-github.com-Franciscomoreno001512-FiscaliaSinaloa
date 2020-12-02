using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_de_Pirateria
{
    public class Tipo_de_PirateriaPagingModel
    {
        public List<Spartane.Core.Domain.Tipo_de_Pirateria.Tipo_de_Pirateria> Tipo_de_Piraterias { set; get; }
        public int RowCount { set; get; }
    }
}
