using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_de_Zona
{
    public class Tipo_de_ZonaPagingModel
    {
        public List<Spartane.Core.Domain.Tipo_de_Zona.Tipo_de_Zona> Tipo_de_Zonas { set; get; }
        public int RowCount { set; get; }
    }
}
