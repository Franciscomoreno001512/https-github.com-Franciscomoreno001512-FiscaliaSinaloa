using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Modulo_Atencion_Inicial;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Estatus_de_Resolucion_de_AT;
using Spartane.Core.Domain.Resolucion;
using Spartane.Core.Domain.Detalle_de_Relaciones;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Resolucion;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Resolucion_AT
{
    /// <summary>
    /// Resolucion_AT table
    /// </summary>
    public class Resolucion_AT: BaseEntity
    {
        public int Clave { get; set; }
        public int? Modulo_Atencion_Inicial { get; set; }
        public DateTime? Fecha_de_Resolucion { get; set; }
        public int? Persona_que_Resuelve { get; set; }
        public int? Estatus { get; set; }
        public int? Resolucion { get; set; }
        public int? Relacion { get; set; }
        public string Observaciones { get; set; }
        public DateTime? Fecha_de_Validacion { get; set; }
        public string Hora_de_Validacion { get; set; }
        public int? Dictaminador { get; set; }
        public int? Resultado_de_Validacion { get; set; }
        public string Observaciones_Dictaminador { get; set; }

        [ForeignKey("Modulo_Atencion_Inicial")]
        public virtual Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial Modulo_Atencion_Inicial_Modulo_Atencion_Inicial { get; set; }
        [ForeignKey("Persona_que_Resuelve")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Persona_que_Resuelve_Spartan_User { get; set; }
        [ForeignKey("Estatus")]
        public virtual Spartane.Core.Domain.Estatus_de_Resolucion_de_AT.Estatus_de_Resolucion_de_AT Estatus_Estatus_de_Resolucion_de_AT { get; set; }
        [ForeignKey("Resolucion")]
        public virtual Spartane.Core.Domain.Resolucion.Resolucion Resolucion_Resolucion { get; set; }
        [ForeignKey("Relacion")]
        public virtual Spartane.Core.Domain.Detalle_de_Relaciones.Detalle_de_Relaciones Relacion_Detalle_de_Relaciones { get; set; }
        [ForeignKey("Dictaminador")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Dictaminador_Spartan_User { get; set; }
        [ForeignKey("Resultado_de_Validacion")]
        public virtual Spartane.Core.Domain.Resolucion.Resolucion Resultado_de_Validacion_Resolucion { get; set; }

    }
	
	public class Resolucion_AT_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Modulo_Atencion_Inicial { get; set; }
        public DateTime? Fecha_de_Resolucion { get; set; }
        public int? Persona_que_Resuelve { get; set; }
        public int? Estatus { get; set; }
        public int? Resolucion { get; set; }
        public int? Relacion { get; set; }
        public string Observaciones { get; set; }

		        [ForeignKey("Modulo_Atencion_Inicial")]
        public virtual Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial Modulo_Atencion_Inicial_Modulo_Atencion_Inicial { get; set; }
        [ForeignKey("Persona_que_Resuelve")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Persona_que_Resuelve_Spartan_User { get; set; }
        [ForeignKey("Estatus")]
        public virtual Spartane.Core.Domain.Estatus_de_Resolucion_de_AT.Estatus_de_Resolucion_de_AT Estatus_Estatus_de_Resolucion_de_AT { get; set; }
        [ForeignKey("Resolucion")]
        public virtual Spartane.Core.Domain.Resolucion.Resolucion Resolucion_Resolucion { get; set; }
        [ForeignKey("Relacion")]
        public virtual Spartane.Core.Domain.Detalle_de_Relaciones.Detalle_de_Relaciones Relacion_Detalle_de_Relaciones { get; set; }

    }

	public class Resolucion_AT_Dictaminacion
    {
                public int Clave { get; set; }
        public DateTime? Fecha_de_Validacion { get; set; }
        public string Hora_de_Validacion { get; set; }
        public int? Dictaminador { get; set; }
        public int? Resultado_de_Validacion { get; set; }
        public string Observaciones_Dictaminador { get; set; }

		        [ForeignKey("Dictaminador")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Dictaminador_Spartan_User { get; set; }
        [ForeignKey("Resultado_de_Validacion")]
        public virtual Spartane.Core.Domain.Resolucion.Resolucion Resultado_de_Validacion_Resolucion { get; set; }

    }


}

