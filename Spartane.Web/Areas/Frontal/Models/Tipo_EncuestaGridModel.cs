using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Tipo_EncuestaGridModel
    {
        public int Clave { get; set; }
        public int? Modulo_Encuesta { get; set; }
        public string Modulo_EncuestaDescripcion { get; set; }
        public string Descripcion { get; set; }
        public string Abreviacion { get; set; }
        
    }
}

