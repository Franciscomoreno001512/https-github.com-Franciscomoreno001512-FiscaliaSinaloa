using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Catalogo_Numero_de_Preguntas;
using Spartane.Core.Domain.Catalogo_Respuesta;
using Spartane.Core.Domain.Catalogo_Respuesta;
using Spartane.Core.Domain.Catalogo_Respuesta;
using Spartane.Core.Domain.Catalogo_Respuesta;
using Spartane.Core.Domain.Catalogo_Respuesta;
using Spartane.Core.Domain.Catalogo_Respuesta;
using Spartane.Core.Domain.Catalogo_Respuesta;
using Spartane.Core.Domain.Catalogo_Respuesta;
using Spartane.Core.Domain.Catalogo_Respuesta;
using Spartane.Core.Domain.Catalogo_Respuesta;

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
        public int? Numero_de_Preguntas { get; set; }
        public string NUAT { get; set; }
        public int? Pregunta1 { get; set; }
        public int? Pregunta2 { get; set; }
        public int? Pregunta3 { get; set; }
        public int? Pregunta4 { get; set; }
        public int? Pregunta5 { get; set; }
        public int? Pregunta6 { get; set; }
        public int? Pregunta7 { get; set; }
        public int? Pregunta8 { get; set; }
        public int? Pregunta9 { get; set; }
        public int? Pregunta10 { get; set; }

        [ForeignKey("Numero_de_Preguntas")]
        public virtual Spartane.Core.Domain.Catalogo_Numero_de_Preguntas.Catalogo_Numero_de_Preguntas Numero_de_Preguntas_Catalogo_Numero_de_Preguntas { get; set; }
        [ForeignKey("Pregunta1")]
        public virtual Spartane.Core.Domain.Catalogo_Respuesta.Catalogo_Respuesta Pregunta1_Catalogo_Respuesta { get; set; }
        [ForeignKey("Pregunta2")]
        public virtual Spartane.Core.Domain.Catalogo_Respuesta.Catalogo_Respuesta Pregunta2_Catalogo_Respuesta { get; set; }
        [ForeignKey("Pregunta3")]
        public virtual Spartane.Core.Domain.Catalogo_Respuesta.Catalogo_Respuesta Pregunta3_Catalogo_Respuesta { get; set; }
        [ForeignKey("Pregunta4")]
        public virtual Spartane.Core.Domain.Catalogo_Respuesta.Catalogo_Respuesta Pregunta4_Catalogo_Respuesta { get; set; }
        [ForeignKey("Pregunta5")]
        public virtual Spartane.Core.Domain.Catalogo_Respuesta.Catalogo_Respuesta Pregunta5_Catalogo_Respuesta { get; set; }
        [ForeignKey("Pregunta6")]
        public virtual Spartane.Core.Domain.Catalogo_Respuesta.Catalogo_Respuesta Pregunta6_Catalogo_Respuesta { get; set; }
        [ForeignKey("Pregunta7")]
        public virtual Spartane.Core.Domain.Catalogo_Respuesta.Catalogo_Respuesta Pregunta7_Catalogo_Respuesta { get; set; }
        [ForeignKey("Pregunta8")]
        public virtual Spartane.Core.Domain.Catalogo_Respuesta.Catalogo_Respuesta Pregunta8_Catalogo_Respuesta { get; set; }
        [ForeignKey("Pregunta9")]
        public virtual Spartane.Core.Domain.Catalogo_Respuesta.Catalogo_Respuesta Pregunta9_Catalogo_Respuesta { get; set; }
        [ForeignKey("Pregunta10")]
        public virtual Spartane.Core.Domain.Catalogo_Respuesta.Catalogo_Respuesta Pregunta10_Catalogo_Respuesta { get; set; }

    }
	
	public class Encuesta1_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Numero_de_Preguntas { get; set; }
        public string NUAT { get; set; }
        public int? Pregunta1 { get; set; }
        public int? Pregunta2 { get; set; }
        public int? Pregunta3 { get; set; }
        public int? Pregunta4 { get; set; }
        public int? Pregunta5 { get; set; }
        public int? Pregunta6 { get; set; }
        public int? Pregunta7 { get; set; }
        public int? Pregunta8 { get; set; }
        public int? Pregunta9 { get; set; }
        public int? Pregunta10 { get; set; }

		        [ForeignKey("Numero_de_Preguntas")]
        public virtual Spartane.Core.Domain.Catalogo_Numero_de_Preguntas.Catalogo_Numero_de_Preguntas Numero_de_Preguntas_Catalogo_Numero_de_Preguntas { get; set; }
        [ForeignKey("Pregunta1")]
        public virtual Spartane.Core.Domain.Catalogo_Respuesta.Catalogo_Respuesta Pregunta1_Catalogo_Respuesta { get; set; }
        [ForeignKey("Pregunta2")]
        public virtual Spartane.Core.Domain.Catalogo_Respuesta.Catalogo_Respuesta Pregunta2_Catalogo_Respuesta { get; set; }
        [ForeignKey("Pregunta3")]
        public virtual Spartane.Core.Domain.Catalogo_Respuesta.Catalogo_Respuesta Pregunta3_Catalogo_Respuesta { get; set; }
        [ForeignKey("Pregunta4")]
        public virtual Spartane.Core.Domain.Catalogo_Respuesta.Catalogo_Respuesta Pregunta4_Catalogo_Respuesta { get; set; }
        [ForeignKey("Pregunta5")]
        public virtual Spartane.Core.Domain.Catalogo_Respuesta.Catalogo_Respuesta Pregunta5_Catalogo_Respuesta { get; set; }
        [ForeignKey("Pregunta6")]
        public virtual Spartane.Core.Domain.Catalogo_Respuesta.Catalogo_Respuesta Pregunta6_Catalogo_Respuesta { get; set; }
        [ForeignKey("Pregunta7")]
        public virtual Spartane.Core.Domain.Catalogo_Respuesta.Catalogo_Respuesta Pregunta7_Catalogo_Respuesta { get; set; }
        [ForeignKey("Pregunta8")]
        public virtual Spartane.Core.Domain.Catalogo_Respuesta.Catalogo_Respuesta Pregunta8_Catalogo_Respuesta { get; set; }
        [ForeignKey("Pregunta9")]
        public virtual Spartane.Core.Domain.Catalogo_Respuesta.Catalogo_Respuesta Pregunta9_Catalogo_Respuesta { get; set; }
        [ForeignKey("Pregunta10")]
        public virtual Spartane.Core.Domain.Catalogo_Respuesta.Catalogo_Respuesta Pregunta10_Catalogo_Respuesta { get; set; }

    }


}

