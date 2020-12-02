using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_de_medios_de_transporte
{
    public class Tipo_de_medios_de_transportePagingModel
    {
        public List<Spartane.Core.Domain.Tipo_de_medios_de_transporte.Tipo_de_medios_de_transporte> Tipo_de_medios_de_transportes { set; get; }
        public int RowCount { set; get; }
    }
}
