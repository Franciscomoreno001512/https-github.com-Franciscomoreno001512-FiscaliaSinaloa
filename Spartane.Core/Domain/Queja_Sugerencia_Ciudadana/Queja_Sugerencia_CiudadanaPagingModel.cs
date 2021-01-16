using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Queja_Sugerencia_Ciudadana
{
    public class Queja_Sugerencia_CiudadanaPagingModel
    {
        public List<Spartane.Core.Domain.Queja_Sugerencia_Ciudadana.Queja_Sugerencia_Ciudadana> Queja_Sugerencia_Ciudadanas { set; get; }
        public int RowCount { set; get; }
    }
}
