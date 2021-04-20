using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_de_Localizacion
{
    public class Tipo_de_LocalizacionPagingModel
    {
        public List<Spartane.Core.Domain.Tipo_de_Localizacion.Tipo_de_Localizacion> Tipo_de_Localizacions { set; get; }
        public int RowCount { set; get; }
    }
}
