using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class ErmeOficioGridModel
    {
        public int Clave { get; set; }
        public string Oficio { get; set; }
        public int? Municipio { get; set; }
        public string MunicipioNombre { get; set; }
        public int? Agencia { get; set; }
        public string AgenciaClave { get; set; }
        
    }
}

