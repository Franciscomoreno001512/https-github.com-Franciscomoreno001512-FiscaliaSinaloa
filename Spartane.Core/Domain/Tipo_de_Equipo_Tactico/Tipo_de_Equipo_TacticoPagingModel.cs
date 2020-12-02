using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_de_Equipo_Tactico
{
    public class Tipo_de_Equipo_TacticoPagingModel
    {
        public List<Spartane.Core.Domain.Tipo_de_Equipo_Tactico.Tipo_de_Equipo_Tactico> Tipo_de_Equipo_Tacticos { set; get; }
        public int RowCount { set; get; }
    }
}
