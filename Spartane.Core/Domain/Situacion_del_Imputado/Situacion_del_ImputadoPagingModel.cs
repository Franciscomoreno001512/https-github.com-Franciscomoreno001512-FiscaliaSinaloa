using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Situacion_del_Imputado
{
    public class Situacion_del_ImputadoPagingModel
    {
        public List<Spartane.Core.Domain.Situacion_del_Imputado.Situacion_del_Imputado> Situacion_del_Imputados { set; get; }
        public int RowCount { set; get; }
    }
}
