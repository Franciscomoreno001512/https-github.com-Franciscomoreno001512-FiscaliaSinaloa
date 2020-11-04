using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class EncuestaModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Numero_de_Preguntas { get; set; }
        public string Numero_de_PreguntasDescripcion { get; set; }
        public string Pregunta_1 { get; set; }
        public string Pregunta_2 { get; set; }
        public string Pregunta_3 { get; set; }
        public string Pregunta_4 { get; set; }
        public string Pregunta_5 { get; set; }
        public string Pregunta_6 { get; set; }
        public string Pregunta_7 { get; set; }
        public string Pregunta_8 { get; set; }
        public string Pregunta_9 { get; set; }
        public string Pregunta_10 { get; set; }

    }
	
	public class Encuesta_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Numero_de_Preguntas { get; set; }
        public string Numero_de_PreguntasDescripcion { get; set; }
        public string Pregunta_1 { get; set; }
        public string Pregunta_2 { get; set; }
        public string Pregunta_3 { get; set; }
        public string Pregunta_4 { get; set; }
        public string Pregunta_5 { get; set; }
        public string Pregunta_6 { get; set; }
        public string Pregunta_7 { get; set; }
        public string Pregunta_8 { get; set; }
        public string Pregunta_9 { get; set; }
        public string Pregunta_10 { get; set; }

    }


}

