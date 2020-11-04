using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Especifica_Vehiculo
{
    public class Especifica_VehiculoPagingModel
    {
        public List<Spartane.Core.Domain.Especifica_Vehiculo.Especifica_Vehiculo> Especifica_Vehiculos { set; get; }
        public int RowCount { set; get; }
    }
}
