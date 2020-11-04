using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Circunstancia_Vehiculo
{
    public class Circunstancia_VehiculoPagingModel
    {
        public List<Spartane.Core.Domain.Circunstancia_Vehiculo.Circunstancia_Vehiculo> Circunstancia_Vehiculos { set; get; }
        public int RowCount { set; get; }
    }
}
