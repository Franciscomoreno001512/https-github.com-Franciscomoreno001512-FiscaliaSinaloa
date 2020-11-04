using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Formato_de_Denuncia
{
    public class Formato_de_DenunciaPagingModel
    {
        public List<Spartane.Core.Domain.Formato_de_Denuncia.Formato_de_Denuncia> Formato_de_Denuncias { set; get; }
        public int RowCount { set; get; }
    }
}
