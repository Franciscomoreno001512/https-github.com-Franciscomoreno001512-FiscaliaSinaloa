using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.expediente_ministerio_publico;
using Spartane.Core.Domain.Modulo_Atencion_Inicial;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Detalle_de_Relaciones;
using Spartane.Core.Domain.Estatus_Orientador;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Unidad;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Canalizacion
{
    /// <summary>
    /// Canalizacion table
    /// </summary>
    public class Canalizacion: BaseEntity
    {
        public int Clave { get; set; }
        public int? Expediente_MP { get; set; }
        public int? Expediente_AT { get; set; }
        public DateTime? Fecha_de_Canalizacion { get; set; }
        public string Hora_de_Canalizacion { get; set; }
        public int? Usuario_que_Canaliza { get; set; }
        public int? Relacion_a_Canalizar { get; set; }
        public int? Canalizar_a { get; set; }
        public int? Municipio { get; set; }
        public int? Unidad { get; set; }
        public DateTime? Fecha_de_Resolucion { get; set; }
        public string Hora_de_Resolucion { get; set; }
        public bool? Hubo_modificacion_en_la_relacion { get; set; }
        public string Nueva_Relacion { get; set; }
        public int? ResolucionId { get; set; }
        public string Resolucion { get; set; }
        public string Detalle_de_la_Resolucion { get; set; }
        public string Observaciones { get; set; }

        [ForeignKey("Expediente_MP")]
        public virtual Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico Expediente_MP_expediente_ministerio_publico { get; set; }
        [ForeignKey("Expediente_AT")]
        public virtual Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial Expediente_AT_Modulo_Atencion_Inicial { get; set; }
        [ForeignKey("Usuario_que_Canaliza")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Canaliza_Spartan_User { get; set; }
        [ForeignKey("Relacion_a_Canalizar")]
        public virtual Spartane.Core.Domain.Detalle_de_Relaciones.Detalle_de_Relaciones Relacion_a_Canalizar_Detalle_de_Relaciones { get; set; }
        [ForeignKey("Canalizar_a")]
        public virtual Spartane.Core.Domain.Estatus_Orientador.Estatus_Orientador Canalizar_a_Estatus_Orientador { get; set; }
        [ForeignKey("Municipio")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Municipio { get; set; }
        [ForeignKey("Unidad")]
        public virtual Spartane.Core.Domain.Unidad.Unidad Unidad_Unidad { get; set; }

    }
	
	public class Canalizacion_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Expediente_MP { get; set; }
        public int? Expediente_AT { get; set; }
        public DateTime? Fecha_de_Canalizacion { get; set; }
        public string Hora_de_Canalizacion { get; set; }
        public int? Usuario_que_Canaliza { get; set; }
        public int? Relacion_a_Canalizar { get; set; }
        public int? Canalizar_a { get; set; }
        public int? Municipio { get; set; }
        public int? Unidad { get; set; }

		        [ForeignKey("Expediente_MP")]
        public virtual Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico Expediente_MP_expediente_ministerio_publico { get; set; }
        [ForeignKey("Expediente_AT")]
        public virtual Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial Expediente_AT_Modulo_Atencion_Inicial { get; set; }
        [ForeignKey("Usuario_que_Canaliza")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Canaliza_Spartan_User { get; set; }
        [ForeignKey("Relacion_a_Canalizar")]
        public virtual Spartane.Core.Domain.Detalle_de_Relaciones.Detalle_de_Relaciones Relacion_a_Canalizar_Detalle_de_Relaciones { get; set; }
        [ForeignKey("Canalizar_a")]
        public virtual Spartane.Core.Domain.Estatus_Orientador.Estatus_Orientador Canalizar_a_Estatus_Orientador { get; set; }
        [ForeignKey("Municipio")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Municipio { get; set; }
        [ForeignKey("Unidad")]
        public virtual Spartane.Core.Domain.Unidad.Unidad Unidad_Unidad { get; set; }

    }

	public class Canalizacion_Resolucion
    {
                public int Clave { get; set; }
        public DateTime? Fecha_de_Resolucion { get; set; }
        public string Hora_de_Resolucion { get; set; }
        public bool? Hubo_modificacion_en_la_relacion { get; set; }
        public string Nueva_Relacion { get; set; }
        public int? ResolucionId { get; set; }
        public string Resolucion { get; set; }
        public string Detalle_de_la_Resolucion { get; set; }
        public string Observaciones { get; set; }

		
    }


}

