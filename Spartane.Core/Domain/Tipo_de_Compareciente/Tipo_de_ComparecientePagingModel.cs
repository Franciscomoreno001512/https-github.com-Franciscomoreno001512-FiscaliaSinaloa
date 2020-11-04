using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_de_Compareciente
{
    public class Tipo_de_ComparecientePagingModel
    {
        public List<Spartane.Core.Domain.Tipo_de_Compareciente.Tipo_de_Compareciente> Tipo_de_Comparecientes { set; get; }
        public int RowCount { set; get; }
    }
}
