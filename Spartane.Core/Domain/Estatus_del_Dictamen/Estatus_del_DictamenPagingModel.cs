using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Estatus_del_Dictamen
{
    public class Estatus_del_DictamenPagingModel
    {
        public List<Spartane.Core.Domain.Estatus_del_Dictamen.Estatus_del_Dictamen> Estatus_del_Dictamens { set; get; }
        public int RowCount { set; get; }
    }
}
