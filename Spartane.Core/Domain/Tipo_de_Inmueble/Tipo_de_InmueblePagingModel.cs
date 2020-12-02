using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_de_Inmueble
{
    public class Tipo_de_InmueblePagingModel
    {
        public List<Spartane.Core.Domain.Tipo_de_Inmueble.Tipo_de_Inmueble> Tipo_de_Inmuebles { set; get; }
        public int RowCount { set; get; }
    }
}
