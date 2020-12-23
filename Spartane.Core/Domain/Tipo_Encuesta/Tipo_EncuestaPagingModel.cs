using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_Encuesta
{
    public class Tipo_EncuestaPagingModel
    {
        public List<Spartane.Core.Domain.Tipo_Encuesta.Tipo_Encuesta> Tipo_Encuestas { set; get; }
        public int RowCount { set; get; }
    }
}
