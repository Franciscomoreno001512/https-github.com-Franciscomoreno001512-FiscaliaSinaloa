using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Especificacion_DetencionGridModel
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public short? Detenido { get; set; }
        public string DetenidoDescripcion { get; set; }
        
    }
}

