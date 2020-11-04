using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Modulo_Atencion_Inicial;
using Spartane.Core.Domain.Tipo_de_Servicio_de_Apoyo;
using Spartane.Core.Domain.Dialecto;
using Spartane.Core.Domain.Idioma;
using Spartane.Core.Domain.Compareciente;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Servicio_de_Apoyo
{
    /// <summary>
    /// Detalle_de_Servicio_de_Apoyo table
    /// </summary>
    public class Detalle_de_Servicio_de_Apoyo: BaseEntity
    {
        public int Clave { get; set; }
        public int? Modulo_de_Atencion_Inicial { get; set; }
        public int? Tipo_de_Servicio { get; set; }
        public bool? Requiere_Traductor { get; set; }
        public int? Lengua_Originaria { get; set; }
        public int? Idioma { get; set; }
        public string Dictamen { get; set; }
        public string Responsable { get; set; }
        public int? Compareciente { get; set; }

        [ForeignKey("Modulo_de_Atencion_Inicial")]
        public virtual Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial Modulo_de_Atencion_Inicial_Modulo_Atencion_Inicial { get; set; }
        [ForeignKey("Tipo_de_Servicio")]
        public virtual Spartane.Core.Domain.Tipo_de_Servicio_de_Apoyo.Tipo_de_Servicio_de_Apoyo Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo { get; set; }
        [ForeignKey("Lengua_Originaria")]
        public virtual Spartane.Core.Domain.Dialecto.Dialecto Lengua_Originaria_Dialecto { get; set; }
        [ForeignKey("Idioma")]
        public virtual Spartane.Core.Domain.Idioma.Idioma Idioma_Idioma { get; set; }
        [ForeignKey("Compareciente")]
        public virtual Spartane.Core.Domain.Compareciente.Compareciente Compareciente_Compareciente { get; set; }

    }
	
	public class Detalle_de_Servicio_de_Apoyo_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Modulo_de_Atencion_Inicial { get; set; }
        public int? Tipo_de_Servicio { get; set; }
        public bool? Requiere_Traductor { get; set; }
        public int? Lengua_Originaria { get; set; }
        public int? Idioma { get; set; }
        public string Dictamen { get; set; }
        public string Responsable { get; set; }
        public int? Compareciente { get; set; }

		        [ForeignKey("Modulo_de_Atencion_Inicial")]
        public virtual Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial Modulo_de_Atencion_Inicial_Modulo_Atencion_Inicial { get; set; }
        [ForeignKey("Tipo_de_Servicio")]
        public virtual Spartane.Core.Domain.Tipo_de_Servicio_de_Apoyo.Tipo_de_Servicio_de_Apoyo Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo { get; set; }
        [ForeignKey("Lengua_Originaria")]
        public virtual Spartane.Core.Domain.Dialecto.Dialecto Lengua_Originaria_Dialecto { get; set; }
        [ForeignKey("Idioma")]
        public virtual Spartane.Core.Domain.Idioma.Idioma Idioma_Idioma { get; set; }
        [ForeignKey("Compareciente")]
        public virtual Spartane.Core.Domain.Compareciente.Compareciente Compareciente_Compareciente { get; set; }

    }


}

