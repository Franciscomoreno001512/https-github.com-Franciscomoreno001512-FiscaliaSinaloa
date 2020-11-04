using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_de_Comparecencia
{
    public class Tipo_de_ComparecenciaPagingModel
    {
        public List<Spartane.Core.Domain.Tipo_de_Comparecencia.Tipo_de_Comparecencia> Tipo_de_Comparecencias { set; get; }
        public int RowCount { set; get; }
    }
}
