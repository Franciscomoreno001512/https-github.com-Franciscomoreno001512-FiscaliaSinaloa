using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Catalogo_Unidad_Policial
{
    public class Catalogo_Unidad_PolicialPagingModel
    {
        public List<Spartane.Core.Domain.Catalogo_Unidad_Policial.Catalogo_Unidad_Policial> Catalogo_Unidad_Policials { set; get; }
        public int RowCount { set; get; }
    }
}
