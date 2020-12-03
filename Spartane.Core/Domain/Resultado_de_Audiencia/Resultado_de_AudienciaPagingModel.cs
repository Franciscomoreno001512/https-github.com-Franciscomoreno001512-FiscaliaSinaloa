using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Resultado_de_Audiencia
{
    public class Resultado_de_AudienciaPagingModel
    {
        public List<Spartane.Core.Domain.Resultado_de_Audiencia.Resultado_de_Audiencia> Resultado_de_Audiencias { set; get; }
        public int RowCount { set; get; }
    }
}
