using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Tipo_de_AtencionGridModel
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Vigente { get; set; }
        public string VigenteAbreviacion { get; set; }
        public string Observaciones { get; set; }
        
    }
}

