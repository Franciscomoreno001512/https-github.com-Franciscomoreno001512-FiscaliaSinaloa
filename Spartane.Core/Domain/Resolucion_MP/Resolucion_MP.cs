using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.expediente_ministerio_publico;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Estatus_de_Resolucion;
using Spartane.Core.Domain.Resolucion;
using Spartane.Core.Domain.Juzgado;
using Spartane.Core.Domain.Tipo_de_Judicializacion;
using Spartane.Core.Domain.Ano;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Resolucion;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Resolucion_MP
{
    /// <summary>
    /// Resolucion_MP table
    /// </summary>
    public class Resolucion_MP: BaseEntity
    {
        public int Clave { get; set; }
        public int? Expediente_MP { get; set; }
        public DateTime? Fecha_de_Resolucion { get; set; }
        public int? Persona_que_Resuelve { get; set; }
        public int? Estatus { get; set; }
        public int? Resolucion { get; set; }
        public int? Juzgado { get; set; }
        public int? Tipo { get; set; }
        public int? No__De_Causa_o_Cuadernillo { get; set; }
        public int? Ano_de_Causa_o_Cuadernillo { get; set; }
        public string Observaciones { get; set; }
        public DateTime? Fecha_de_Validacion { get; set; }
        public string Hora_de_Validacion { get; set; }
        public int? Dictaminador { get; set; }
        public int? Resultado_de_Validacion { get; set; }
        public string Observaciones_Dictaminador { get; set; }

        [ForeignKey("Expediente_MP")]
        public virtual Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico Expediente_MP_expediente_ministerio_publico { get; set; }
        [ForeignKey("Persona_que_Resuelve")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Persona_que_Resuelve_Spartan_User { get; set; }
        [ForeignKey("Estatus")]
        public virtual Spartane.Core.Domain.Estatus_de_Resolucion.Estatus_de_Resolucion Estatus_Estatus_de_Resolucion { get; set; }
        [ForeignKey("Resolucion")]
        public virtual Spartane.Core.Domain.Resolucion.Resolucion Resolucion_Resolucion { get; set; }
        [ForeignKey("Juzgado")]
        public virtual Spartane.Core.Domain.Juzgado.Juzgado Juzgado_Juzgado { get; set; }
        [ForeignKey("Tipo")]
        public virtual Spartane.Core.Domain.Tipo_de_Judicializacion.Tipo_de_Judicializacion Tipo_Tipo_de_Judicializacion { get; set; }
        [ForeignKey("Ano_de_Causa_o_Cuadernillo")]
        public virtual Spartane.Core.Domain.Ano.Ano Ano_de_Causa_o_Cuadernillo_Ano { get; set; }
        [ForeignKey("Dictaminador")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Dictaminador_Spartan_User { get; set; }
        [ForeignKey("Resultado_de_Validacion")]
        public virtual Spartane.Core.Domain.Resolucion.Resolucion Resultado_de_Validacion_Resolucion { get; set; }

    }
	
	public class Resolucion_MP_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Expediente_MP { get; set; }
        public DateTime? Fecha_de_Resolucion { get; set; }
        public int? Persona_que_Resuelve { get; set; }
        public int? Estatus { get; set; }
        public int? Resolucion { get; set; }
        public int? Juzgado { get; set; }
        public int? Tipo { get; set; }
        public int? No__De_Causa_o_Cuadernillo { get; set; }
        public int? Ano_de_Causa_o_Cuadernillo { get; set; }
        public string Observaciones { get; set; }

		        [ForeignKey("Expediente_MP")]
        public virtual Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico Expediente_MP_expediente_ministerio_publico { get; set; }
        [ForeignKey("Persona_que_Resuelve")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Persona_que_Resuelve_Spartan_User { get; set; }
        [ForeignKey("Estatus")]
        public virtual Spartane.Core.Domain.Estatus_de_Resolucion.Estatus_de_Resolucion Estatus_Estatus_de_Resolucion { get; set; }
        [ForeignKey("Resolucion")]
        public virtual Spartane.Core.Domain.Resolucion.Resolucion Resolucion_Resolucion { get; set; }
        [ForeignKey("Juzgado")]
        public virtual Spartane.Core.Domain.Juzgado.Juzgado Juzgado_Juzgado { get; set; }
        [ForeignKey("Tipo")]
        public virtual Spartane.Core.Domain.Tipo_de_Judicializacion.Tipo_de_Judicializacion Tipo_Tipo_de_Judicializacion { get; set; }
        [ForeignKey("Ano_de_Causa_o_Cuadernillo")]
        public virtual Spartane.Core.Domain.Ano.Ano Ano_de_Causa_o_Cuadernillo_Ano { get; set; }

    }

	public class Resolucion_MP_Validacion
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

