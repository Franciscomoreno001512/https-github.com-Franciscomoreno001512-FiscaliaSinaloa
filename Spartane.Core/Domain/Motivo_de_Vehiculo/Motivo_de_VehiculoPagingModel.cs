using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Motivo_de_Vehiculo
{
    public class Motivo_de_VehiculoPagingModel
    {
        public List<Spartane.Core.Domain.Motivo_de_Vehiculo.Motivo_de_Vehiculo> Motivo_de_Vehiculos { set; get; }
        public int RowCount { set; get; }
    }
}
