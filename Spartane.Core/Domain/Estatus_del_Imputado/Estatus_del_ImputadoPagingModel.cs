using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Estatus_del_Imputado
{
    public class Estatus_del_ImputadoPagingModel
    {
        public List<Spartane.Core.Domain.Estatus_del_Imputado.Estatus_del_Imputado> Estatus_del_Imputados { set; get; }
        public int RowCount { set; get; }
    }
}
