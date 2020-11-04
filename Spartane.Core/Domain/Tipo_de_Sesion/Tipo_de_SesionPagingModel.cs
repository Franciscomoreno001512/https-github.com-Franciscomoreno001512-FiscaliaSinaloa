using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_de_Sesion
{
    public class Tipo_de_SesionPagingModel
    {
        public List<Spartane.Core.Domain.Tipo_de_Sesion.Tipo_de_Sesion> Tipo_de_Sesions { set; get; }
        public int RowCount { set; get; }
    }
}
