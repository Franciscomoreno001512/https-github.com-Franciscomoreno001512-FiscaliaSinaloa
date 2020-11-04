using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Distrito_JudicialGridModel
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public short? Codigo { get; set; }
        public int? Municipio { get; set; }
        public string MunicipioNombre { get; set; }
        
    }
}

