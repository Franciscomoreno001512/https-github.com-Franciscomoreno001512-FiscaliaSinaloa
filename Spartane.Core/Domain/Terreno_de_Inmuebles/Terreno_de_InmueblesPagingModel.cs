using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Terreno_de_Inmuebles
{
    public class Terreno_de_InmueblesPagingModel
    {
        public List<Spartane.Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles> Terreno_de_Inmuebless { set; get; }
        public int RowCount { set; get; }
    }
}
