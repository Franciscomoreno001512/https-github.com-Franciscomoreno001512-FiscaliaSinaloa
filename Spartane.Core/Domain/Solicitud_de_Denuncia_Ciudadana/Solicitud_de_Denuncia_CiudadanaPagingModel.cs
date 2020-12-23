using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Solicitud_de_Denuncia_Ciudadana
{
    public class Solicitud_de_Denuncia_CiudadanaPagingModel
    {
        public List<Spartane.Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_Ciudadana> Solicitud_de_Denuncia_Ciudadanas { set; get; }
        public int RowCount { set; get; }
    }
}
