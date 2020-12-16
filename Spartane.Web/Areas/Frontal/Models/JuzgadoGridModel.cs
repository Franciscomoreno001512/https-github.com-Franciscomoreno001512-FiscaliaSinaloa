using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class JuzgadoGridModel
    {
        public int Clave { get; set; }
        public string Nombre { get; set; }
        public int? Region { get; set; }
        public string RegionDescripcion { get; set; }
        
    }
}

