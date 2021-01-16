using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_de_queja_sugerencia
{
    public class Tipo_de_queja_sugerenciaPagingModel
    {
        public List<Spartane.Core.Domain.Tipo_de_queja_sugerencia.Tipo_de_queja_sugerencia> Tipo_de_queja_sugerencias { set; get; }
        public int RowCount { set; get; }
    }
}
