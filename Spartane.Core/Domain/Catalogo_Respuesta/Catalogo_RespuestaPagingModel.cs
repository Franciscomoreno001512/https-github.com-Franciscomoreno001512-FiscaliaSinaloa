using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Catalogo_Respuesta
{
    public class Catalogo_RespuestaPagingModel
    {
        public List<Spartane.Core.Domain.Catalogo_Respuesta.Catalogo_Respuesta> Catalogo_Respuestas { set; get; }
        public int RowCount { set; get; }
    }
}
