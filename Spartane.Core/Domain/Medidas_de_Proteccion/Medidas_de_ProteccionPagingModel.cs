using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Medidas_de_Proteccion
{
    public class Medidas_de_ProteccionPagingModel
    {
        public List<Spartane.Core.Domain.Medidas_de_Proteccion.Medidas_de_Proteccion> Medidas_de_Proteccions { set; get; }
        public int RowCount { set; get; }
    }
}
