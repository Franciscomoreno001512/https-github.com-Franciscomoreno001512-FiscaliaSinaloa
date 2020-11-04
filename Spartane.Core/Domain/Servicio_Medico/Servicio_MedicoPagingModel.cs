using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Servicio_Medico
{
    public class Servicio_MedicoPagingModel
    {
        public List<Spartane.Core.Domain.Servicio_Medico.Servicio_Medico> Servicio_Medicos { set; get; }
        public int RowCount { set; get; }
    }
}
