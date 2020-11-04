using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Servicio_del_Vehiculo
{
    public class Servicio_del_VehiculoPagingModel
    {
        public List<Spartane.Core.Domain.Servicio_del_Vehiculo.Servicio_del_Vehiculo> Servicio_del_Vehiculos { set; get; }
        public int RowCount { set; get; }
    }
}
