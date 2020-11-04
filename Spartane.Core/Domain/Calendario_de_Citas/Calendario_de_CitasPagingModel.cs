using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Calendario_de_Citas
{
    public class Calendario_de_CitasPagingModel
    {
        public List<Spartane.Core.Domain.Calendario_de_Citas.Calendario_de_Citas> Calendario_de_Citass { set; get; }
        public int RowCount { set; get; }
    }
}
