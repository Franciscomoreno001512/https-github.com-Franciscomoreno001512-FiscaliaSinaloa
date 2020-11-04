using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class ColoniaGridModel
    {
        public int Clave { get; set; }
        public string Nombre { get; set; }
        public int? Municipio { get; set; }
        public string MunicipioNombre { get; set; }
        public int? Codigo_Postal { get; set; }
        public string Zona { get; set; }
        public int? Vigente { get; set; }
        public string VigenteAbreviacion { get; set; }
        public string Observaciones { get; set; }
        
    }
}

