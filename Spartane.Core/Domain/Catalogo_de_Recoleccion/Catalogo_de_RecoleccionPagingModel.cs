using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Catalogo_de_Recoleccion
{
    public class Catalogo_de_RecoleccionPagingModel
    {
        public List<Spartane.Core.Domain.Catalogo_de_Recoleccion.Catalogo_de_Recoleccion> Catalogo_de_Recoleccions { set; get; }
        public int RowCount { set; get; }
    }
}
