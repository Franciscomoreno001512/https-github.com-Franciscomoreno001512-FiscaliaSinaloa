using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_de_Audiencia
{
    public class Tipo_de_AudienciaPagingModel
    {
        public List<Spartane.Core.Domain.Tipo_de_Audiencia.Tipo_de_Audiencia> Tipo_de_Audiencias { set; get; }
        public int RowCount { set; get; }
    }
}
