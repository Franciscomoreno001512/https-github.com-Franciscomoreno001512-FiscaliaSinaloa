using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_de_Expediente
{
    public class Tipo_de_ExpedientePagingModel
    {
        public List<Spartane.Core.Domain.Tipo_de_Expediente.Tipo_de_Expediente> Tipo_de_Expedientes { set; get; }
        public int RowCount { set; get; }
    }
}
