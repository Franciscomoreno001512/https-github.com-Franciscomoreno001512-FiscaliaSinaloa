using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Modulo_Encuesta;
using Spartane.Core.Domain.Catalogo_Numero_de_Preguntas;
using Spartane.Core.Domain.Catalogo_Respuesta;
using Spartane.Core.Domain.Catalogo_Respuesta;
using Spartane.Core.Domain.Catalogo_Respuesta;
using Spartane.Core.Domain.Catalogo_Respuesta;
using Spartane.Core.Domain.Catalogo_Respuesta;
using Spartane.Core.Domain.Estatus_Encuesta;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Encuesta1
{
    /// <summary>
    /// Encuesta1 table
    /// </summary>
    public class Encuesta1: BaseEntity
    {
        public int Clave { get; set; }
        public string Folio { get; set; }
        public DateTime? Fecha_Enviado { get; set; }
        public string Hora_Enviado { get; set; }
        public DateTime? Fecha_Respuesta { get; set; }
        public string Hora_Respuesta { get; set; }
        public string NUAT { get; set; }
        public int? Modulo { get; set; }
        public int? Numero_de_Preguntas { get; set; }
        public string Pregunta1 { get; set; }
        public int? Respuesta_1 { get; set; }
        public string Pregunta2 { get; set; }
        public int? Respuesta_2 { get; set; }
        public string Pregunta3 { get; set; }
        public int? Respuesta_3 { get; set; }
        public string Pregunta4 { get; set; }
        public int? Respuesta_4 { get; set; }
        public string Pregunta5 { get; set; }
        public int? Respuesta_5 { get; set; }
        public int? Estatus { get; set; }

        [ForeignKey("Modulo")]
        public virtual Spartane.Core.Domain.Modulo_Encuesta.Modulo_Encuesta Modulo_Modulo_Encuesta { get; set; }
        [ForeignKey("Numero_de_Preguntas")]
        public virtual Spartane.Core.Domain.Catalogo_Numero_de_Preguntas.Catalogo_Numero_de_Preguntas Numero_de_Preguntas_Catalogo_Numero_de_Preguntas { get; set; }
        [ForeignKey("Respuesta_1")]
        public virtual Spartane.Core.Domain.Catalogo_Respuesta.Catalogo_Respuesta Respuesta_1_Catalogo_Respuesta { get; set; }
        [ForeignKey("Respuesta_2")]
        public virtual Spartane.Core.Domain.Catalogo_Respuesta.Catalogo_Respuesta Respuesta_2_Catalogo_Respuesta { get; set; }
        [ForeignKey("Respuesta_3")]
        public virtual Spartane.Core.Domain.Catalogo_Respuesta.Catalogo_Respuesta Respuesta_3_Catalogo_Respuesta { get; set; }
        [ForeignKey("Respuesta_4")]
        public virtual Spartane.Core.Domain.Catalogo_Respuesta.Catalogo_Respuesta Respuesta_4_Catalogo_Respuesta { get; set; }
        [ForeignKey("Respuesta_5")]
        public virtual Spartane.Core.Domain.Catalogo_Respuesta.Catalogo_Respuesta Respuesta_5_Catalogo_Respuesta { get; set; }
        [ForeignKey("Estatus")]
        public virtual Spartane.Core.Domain.Estatus_Encuesta.Estatus_Encuesta Estatus_Estatus_Encuesta { get; set; }

    }
	
	public class Encuesta1_Datos_Generales
    {
                public int Clave { get; set; }
        public string Folio { get; set; }
        public DateTime? Fecha_Enviado { get; set; }
        public string Hora_Enviado { get; set; }
        public DateTime? Fecha_Respuesta { get; set; }
        public string Hora_Respuesta { get; set; }
        public string NUAT { get; set; }
        public int? Modulo { get; set; }
        public int? Numero_de_Preguntas { get; set; }
        public string Pregunta1 { get; set; }
        public int? Respuesta_1 { get; set; }
        public string Pregunta2 { get; set; }
        public int? Respuesta_2 { get; set; }
        public string Pregunta3 { get; set; }
        public int? Respuesta_3 { get; set; }
        public string Pregunta4 { get; set; }
        public int? Respuesta_4 { get; set; }
        public string Pregunta5 { get; set; }
        public int? Respuesta_5 { get; set; }
        public int? Estatus { get; set; }

		        [ForeignKey("Modulo")]
        public virtual Spartane.Core.Domain.Modulo_Encuesta.Modulo_Encuesta Modulo_Modulo_Encuesta { get; set; }
        [ForeignKey("Numero_de_Preguntas")]
        public virtual Spartane.Core.Domain.Catalogo_Numero_de_Preguntas.Catalogo_Numero_de_Preguntas Numero_de_Preguntas_Catalogo_Numero_de_Preguntas { get; set; }
        [ForeignKey("Respuesta_1")]
        public virtual Spartane.Core.Domain.Catalogo_Respuesta.Catalogo_Respuesta Respuesta_1_Catalogo_Respuesta { get; set; }
        [ForeignKey("Respuesta_2")]
        public virtual Spartane.Core.Domain.Catalogo_Respuesta.Catalogo_Respuesta Respuesta_2_Catalogo_Respuesta { get; set; }
        [ForeignKey("Respuesta_3")]
        public virtual Spartane.Core.Domain.Catalogo_Respuesta.Catalogo_Respuesta Respuesta_3_Catalogo_Respuesta { get; set; }
        [ForeignKey("Respuesta_4")]
        public virtual Spartane.Core.Domain.Catalogo_Respuesta.Catalogo_Respuesta Respuesta_4_Catalogo_Respuesta { get; set; }
        [ForeignKey("Respuesta_5")]
        public virtual Spartane.Core.Domain.Catalogo_Respuesta.Catalogo_Respuesta Respuesta_5_Catalogo_Respuesta { get; set; }
        [ForeignKey("Estatus")]
        public virtual Spartane.Core.Domain.Estatus_Encuesta.Estatus_Encuesta Estatus_Estatus_Encuesta { get; set; }

    }


}

