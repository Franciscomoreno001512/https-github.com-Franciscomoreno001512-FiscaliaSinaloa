using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class EncuestaGridModel
    {
        public int Clave { get; set; }
        public int? Modulo { get; set; }
        public string ModuloDescripcion { get; set; }
        public int? Numero_de_Preguntas { get; set; }
        public string Numero_de_PreguntasDescripcion { get; set; }
        public string Pregunta_1 { get; set; }
        public string Pregunta_2 { get; set; }
        public string Pregunta_3 { get; set; }
        public string Pregunta_4 { get; set; }
        public string Pregunta_5 { get; set; }
        
    }
}

