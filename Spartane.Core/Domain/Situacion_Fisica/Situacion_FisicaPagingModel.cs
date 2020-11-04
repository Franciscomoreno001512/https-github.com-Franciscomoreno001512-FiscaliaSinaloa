using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Situacion_Fisica
{
    public class Situacion_FisicaPagingModel
    {
        public List<Spartane.Core.Domain.Situacion_Fisica.Situacion_Fisica> Situacion_Fisicas { set; get; }
        public int RowCount { set; get; }
    }
}
