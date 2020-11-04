using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class CorporacionGridModel
    {
        public int Clave { get; set; }
        public int? Clave_Municipio { get; set; }
        public int? Clave_Policia { get; set; }
        public string Descripcion { get; set; }
        public int? Vigencia { get; set; }
        public string VigenciaAbreviacion { get; set; }
        public string Uso_Vehiculo { get; set; }
        public string Observaciones { get; set; }
        
    }
}

