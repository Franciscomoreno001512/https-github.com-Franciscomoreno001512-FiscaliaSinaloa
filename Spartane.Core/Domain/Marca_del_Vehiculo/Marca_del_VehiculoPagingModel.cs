using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Marca_del_Vehiculo
{
    public class Marca_del_VehiculoPagingModel
    {
        public List<Spartane.Core.Domain.Marca_del_Vehiculo.Marca_del_Vehiculo> Marca_del_Vehiculos { set; get; }
        public int RowCount { set; get; }
    }
}
