using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Encuesta1Model
    {
        [Required]
        public int Clave { get; set; }
        public string Folio { get; set; }
        public string Fecha_Enviado { get; set; }
        public string Hora_Enviado { get; set; }
        public string Fecha_Respuesta { get; set; }
        public string Hora_Respuesta { get; set; }
        public string NUAT { get; set; }
        public int? Modulo { get; set; }
        public string ModuloDescripcion { get; set; }
        public int? Numero_de_Preguntas { get; set; }
        public string Numero_de_PreguntasDescripcion { get; set; }
        public string Pregunta1 { get; set; }
        public int? Respuesta_1 { get; set; }
        public string Respuesta_1Descripcion { get; set; }
        public string Pregunta2 { get; set; }
        public int? Respuesta_2 { get; set; }
        public string Respuesta_2Descripcion { get; set; }
        public string Pregunta3 { get; set; }
        public int? Respuesta_3 { get; set; }
        public string Respuesta_3Descripcion { get; set; }
        public string Pregunta4 { get; set; }
        public int? Respuesta_4 { get; set; }
        public string Respuesta_4Descripcion { get; set; }
        public string Pregunta5 { get; set; }
        public int? Respuesta_5 { get; set; }
        public string Respuesta_5Descripcion { get; set; }
        public int? Estatus { get; set; }
        public string EstatusDescripcion { get; set; }

    }
	
	public class Encuesta1_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Folio { get; set; }
        public string Fecha_Enviado { get; set; }
        public string Hora_Enviado { get; set; }
        public string Fecha_Respuesta { get; set; }
        public string Hora_Respuesta { get; set; }
        public string NUAT { get; set; }
        public int? Modulo { get; set; }
        public string ModuloDescripcion { get; set; }
        public int? Numero_de_Preguntas { get; set; }
        public string Numero_de_PreguntasDescripcion { get; set; }
        public string Pregunta1 { get; set; }
        public int? Respuesta_1 { get; set; }
        public string Respuesta_1Descripcion { get; set; }
        public string Pregunta2 { get; set; }
        public int? Respuesta_2 { get; set; }
        public string Respuesta_2Descripcion { get; set; }
        public string Pregunta3 { get; set; }
        public int? Respuesta_3 { get; set; }
        public string Respuesta_3Descripcion { get; set; }
        public string Pregunta4 { get; set; }
        public int? Respuesta_4 { get; set; }
        public string Respuesta_4Descripcion { get; set; }
        public string Pregunta5 { get; set; }
        public int? Respuesta_5 { get; set; }
        public string Respuesta_5Descripcion { get; set; }
        public int? Estatus { get; set; }
        public string EstatusDescripcion { get; set; }

    }


}

