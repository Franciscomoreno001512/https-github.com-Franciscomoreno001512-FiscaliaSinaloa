using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Detalle_de_Huellas_Digitales
{
    public class Detalle_de_Huellas_DigitalesPagingModel
    {
        public List<Spartane.Core.Domain.Detalle_de_Huellas_Digitales.Detalle_de_Huellas_Digitales> Detalle_de_Huellas_Digitaless { set; get; }
        public int RowCount { set; get; }
    }
}
