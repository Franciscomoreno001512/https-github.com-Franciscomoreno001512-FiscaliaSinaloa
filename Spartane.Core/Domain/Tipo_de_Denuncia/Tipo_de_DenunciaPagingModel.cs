using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_de_Denuncia
{
    public class Tipo_de_DenunciaPagingModel
    {
        public List<Spartane.Core.Domain.Tipo_de_Denuncia.Tipo_de_Denuncia> Tipo_de_Denuncias { set; get; }
        public int RowCount { set; get; }
    }
}
