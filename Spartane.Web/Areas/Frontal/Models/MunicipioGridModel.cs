using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class MunicipioGridModel
    {
        public int Clave { get; set; }
        public string Nombre { get; set; }
        public string Abreviacion { get; set; }
        public int? Estado { get; set; }
        public string EstadoNombre { get; set; }
        public int? Vigencia { get; set; }
        public string VigenciaAbreviacion { get; set; }
        public string Observaciones { get; set; }
        public int? cod_pais { get; set; }
        public string cod_zona { get; set; }
        public string MuniNSJP { get; set; }
        public int? cod_zona_nsjp { get; set; }
        
    }
}

