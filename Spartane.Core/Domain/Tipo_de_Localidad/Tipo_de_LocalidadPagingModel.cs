using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_de_Localidad
{
    public class Tipo_de_LocalidadPagingModel
    {
        public List<Spartane.Core.Domain.Tipo_de_Localidad.Tipo_de_Localidad> Tipo_de_Localidads { set; get; }
        public int RowCount { set; get; }
    }
}
