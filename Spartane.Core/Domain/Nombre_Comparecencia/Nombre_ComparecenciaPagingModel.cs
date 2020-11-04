using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Nombre_Comparecencia
{
    public class Nombre_ComparecenciaPagingModel
    {
        public List<Spartane.Core.Domain.Nombre_Comparecencia.Nombre_Comparecencia> Nombre_Comparecencias { set; get; }
        public int RowCount { set; get; }
    }
}
