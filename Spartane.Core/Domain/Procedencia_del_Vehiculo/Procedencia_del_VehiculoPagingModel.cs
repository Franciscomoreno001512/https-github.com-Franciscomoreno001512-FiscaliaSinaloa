using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Procedencia_del_Vehiculo
{
    public class Procedencia_del_VehiculoPagingModel
    {
        public List<Spartane.Core.Domain.Procedencia_del_Vehiculo.Procedencia_del_Vehiculo> Procedencia_del_Vehiculos { set; get; }
        public int RowCount { set; get; }
    }
}
