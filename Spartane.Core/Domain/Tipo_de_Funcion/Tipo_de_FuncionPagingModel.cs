using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_de_Funcion
{
    public class Tipo_de_FuncionPagingModel
    {
        public List<Spartane.Core.Domain.Tipo_de_Funcion.Tipo_de_Funcion> Tipo_de_Funcions { set; get; }
        public int RowCount { set; get; }
    }
}
