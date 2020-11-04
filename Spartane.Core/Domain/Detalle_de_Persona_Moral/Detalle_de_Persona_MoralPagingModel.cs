using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_de_Persona_Moral
{
    public class Detalle_de_Persona_MoralPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_de_Persona_Moral.Detalle_de_Persona_Moral> Detalle_de_Persona_Morals { set; get; }
        public int RowCount { set; get; }
    }
}
