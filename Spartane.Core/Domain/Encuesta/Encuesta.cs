﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Modulo_Encuesta;
using Spartane.Core.Domain.Tipo_Encuesta;
using Spartane.Core.Domain.Catalogo_Numero_de_Preguntas;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Encuesta
{
    /// <summary>
    /// Encuesta table
    /// </summary>
    public class Encuesta: BaseEntity
    {
        public int Clave { get; set; }
        public int? Modulo { get; set; }
        public int? Tipo_Encuesta { get; set; }
        public int? Numero_de_Preguntas { get; set; }
        public string Pregunta_1 { get; set; }
        public string Pregunta_2 { get; set; }
        public string Pregunta_3 { get; set; }
        public string Pregunta_4 { get; set; }
        public string Pregunta_5 { get; set; }

        [ForeignKey("Modulo")]
        public virtual Spartane.Core.Domain.Modulo_Encuesta.Modulo_Encuesta Modulo_Modulo_Encuesta { get; set; }
        [ForeignKey("Tipo_Encuesta")]
        public virtual Spartane.Core.Domain.Tipo_Encuesta.Tipo_Encuesta Tipo_Encuesta_Tipo_Encuesta { get; set; }
        [ForeignKey("Numero_de_Preguntas")]
        public virtual Spartane.Core.Domain.Catalogo_Numero_de_Preguntas.Catalogo_Numero_de_Preguntas Numero_de_Preguntas_Catalogo_Numero_de_Preguntas { get; set; }

    }
	
	public class Encuesta_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Modulo { get; set; }
        public int? Tipo_Encuesta { get; set; }
        public int? Numero_de_Preguntas { get; set; }
        public string Pregunta_1 { get; set; }
        public string Pregunta_2 { get; set; }
        public string Pregunta_3 { get; set; }
        public string Pregunta_4 { get; set; }
        public string Pregunta_5 { get; set; }

		        [ForeignKey("Modulo")]
        public virtual Spartane.Core.Domain.Modulo_Encuesta.Modulo_Encuesta Modulo_Modulo_Encuesta { get; set; }
        [ForeignKey("Tipo_Encuesta")]
        public virtual Spartane.Core.Domain.Tipo_Encuesta.Tipo_Encuesta Tipo_Encuesta_Tipo_Encuesta { get; set; }
        [ForeignKey("Numero_de_Preguntas")]
        public virtual Spartane.Core.Domain.Catalogo_Numero_de_Preguntas.Catalogo_Numero_de_Preguntas Numero_de_Preguntas_Catalogo_Numero_de_Preguntas { get; set; }

    }


}

