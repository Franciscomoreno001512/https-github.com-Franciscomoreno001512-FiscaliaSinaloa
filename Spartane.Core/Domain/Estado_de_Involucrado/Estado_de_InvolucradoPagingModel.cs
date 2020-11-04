using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Estado_de_Involucrado
{
    public class Estado_de_InvolucradoPagingModel
    {
        public List<Spartane.Core.Domain.Estado_de_Involucrado.Estado_de_Involucrado> Estado_de_Involucrados { set; get; }
        public int RowCount { set; get; }
    }
}
