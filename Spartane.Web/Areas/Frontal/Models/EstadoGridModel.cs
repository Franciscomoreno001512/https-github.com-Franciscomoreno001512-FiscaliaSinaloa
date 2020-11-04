using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class EstadoGridModel
    {
        public int Clave { get; set; }
        public string Nombre { get; set; }
        public int? Pais { get; set; }
        public string PaisNombre { get; set; }
        public string Siglas { get; set; }
        public int? Vigencia { get; set; }
        public string VigenciaAbreviacion { get; set; }
        public string Observaciones { get; set; }
        
    }
}

