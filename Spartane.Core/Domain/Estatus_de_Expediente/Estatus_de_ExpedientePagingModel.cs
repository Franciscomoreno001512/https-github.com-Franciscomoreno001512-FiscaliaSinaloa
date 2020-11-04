using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Estatus_de_Expediente
{
    public class Estatus_de_ExpedientePagingModel
    {
        public List<Spartane.Core.Domain.Estatus_de_Expediente.Estatus_de_Expediente> Estatus_de_Expedientes { set; get; }
        public int RowCount { set; get; }
    }
}
