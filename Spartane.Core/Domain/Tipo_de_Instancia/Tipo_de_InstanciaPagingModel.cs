using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_de_Instancia
{
    public class Tipo_de_InstanciaPagingModel
    {
        public List<Spartane.Core.Domain.Tipo_de_Instancia.Tipo_de_Instancia> Tipo_de_Instancias { set; get; }
        public int RowCount { set; get; }
    }
}
