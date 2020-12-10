using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Estatus_Encuesta
{
    public class Estatus_EncuestaPagingModel
    {
        public List<Spartane.Core.Domain.Estatus_Encuesta.Estatus_Encuesta> Estatus_Encuestas { set; get; }
        public int RowCount { set; get; }
    }
}
