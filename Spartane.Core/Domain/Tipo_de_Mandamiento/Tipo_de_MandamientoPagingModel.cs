using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_de_Mandamiento
{
    public class Tipo_de_MandamientoPagingModel
    {
        public List<Spartane.Core.Domain.Tipo_de_Mandamiento.Tipo_de_Mandamiento> Tipo_de_Mandamientos { set; get; }
        public int RowCount { set; get; }
    }
}
