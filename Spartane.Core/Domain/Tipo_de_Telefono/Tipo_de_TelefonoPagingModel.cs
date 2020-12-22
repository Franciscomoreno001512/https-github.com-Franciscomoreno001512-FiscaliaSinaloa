using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_de_Telefono
{
    public class Tipo_de_TelefonoPagingModel
    {
        public List<Spartane.Core.Domain.Tipo_de_Telefono.Tipo_de_Telefono> Tipo_de_Telefonos { set; get; }
        public int RowCount { set; get; }
    }
}
