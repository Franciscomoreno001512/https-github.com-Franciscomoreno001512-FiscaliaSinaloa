using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Violencia_de_Genero
{
    public class Violencia_de_GeneroPagingModel
    {
        public List<Spartane.Core.Domain.Violencia_de_Genero.Violencia_de_Genero> Violencia_de_Generos { set; get; }
        public int RowCount { set; get; }
    }
}
