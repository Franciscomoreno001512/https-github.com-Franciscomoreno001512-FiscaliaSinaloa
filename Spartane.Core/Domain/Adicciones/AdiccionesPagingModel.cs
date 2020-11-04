using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Adicciones
{
    public class AdiccionesPagingModel
    {
        public List<Spartane.Core.Domain.Adicciones.Adicciones> Adiccioness { set; get; }
        public int RowCount { set; get; }
    }
}
