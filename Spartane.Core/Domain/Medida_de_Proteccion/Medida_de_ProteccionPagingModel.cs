using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Medida_de_Proteccion
{
    public class Medida_de_ProteccionPagingModel
    {
        public List<Spartane.Core.Domain.Medida_de_Proteccion.Medida_de_Proteccion> Medida_de_Proteccions { set; get; }
        public int RowCount { set; get; }
    }
}
