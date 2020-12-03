using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_Aseguramiento_Medios_de_Transporte
{
    public class Detalle_Aseguramiento_Medios_de_TransportePagingModel
    {
        public List<Spartane.Core.Domain.Detalle_Aseguramiento_Medios_de_Transporte.Detalle_Aseguramiento_Medios_de_Transporte> Detalle_Aseguramiento_Medios_de_Transportes { set; get; }
        public int RowCount { set; get; }
    }
}
