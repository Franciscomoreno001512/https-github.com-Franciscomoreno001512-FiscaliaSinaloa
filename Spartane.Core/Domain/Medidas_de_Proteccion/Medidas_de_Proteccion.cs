using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Modulo_Atencion_Inicial;
using Spartane.Core.Domain.Solicitud;
using Spartane.Core.Domain.expediente_ministerio_publico;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Tipo_de_Medida_de_Proteccion;
using Spartane.Core.Domain.SubTipo_de_Medida_de_Proteccion;
using Spartane.Core.Domain.Detalle_de_Relaciones;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Medidas_de_Proteccion
{
    /// <summary>
    /// Medidas_de_Proteccion table
    /// </summary>
    public class Medidas_de_Proteccion: BaseEntity
    {
        public int Clave { get; set; }
        public int? Expediente_AT { get; set; }
        public int? Expediente_MASC { get; set; }
        public int? Expediente_MP { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Orden_de_Proteccion { get; set; }
        public int? Tipo_de_Medida { get; set; }
        public int? Sub_Tipo { get; set; }
        public DateTime? Fecha_de_Inicio { get; set; }
        public string Hora_de_Inicio { get; set; }
        public DateTime? Fecha_de_Conclusion { get; set; }
        public string Hora_de_Conclusion { get; set; }
        public short? Duracion_en_Dias { get; set; }
        public int? Aplicar_a { get; set; }

        [ForeignKey("Expediente_AT")]
        public virtual Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial Expediente_AT_Modulo_Atencion_Inicial { get; set; }
        [ForeignKey("Expediente_MASC")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Expediente_MASC_Solicitud { get; set; }
        [ForeignKey("Expediente_MP")]
        public virtual Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico Expediente_MP_expediente_ministerio_publico { get; set; }
        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }
        [ForeignKey("Tipo_de_Medida")]
        public virtual Spartane.Core.Domain.Tipo_de_Medida_de_Proteccion.Tipo_de_Medida_de_Proteccion Tipo_de_Medida_Tipo_de_Medida_de_Proteccion { get; set; }
        [ForeignKey("Sub_Tipo")]
        public virtual Spartane.Core.Domain.SubTipo_de_Medida_de_Proteccion.SubTipo_de_Medida_de_Proteccion Sub_Tipo_SubTipo_de_Medida_de_Proteccion { get; set; }
        [ForeignKey("Aplicar_a")]
        public virtual Spartane.Core.Domain.Detalle_de_Relaciones.Detalle_de_Relaciones Aplicar_a_Detalle_de_Relaciones { get; set; }

    }
	
	public class Medidas_de_Proteccion_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Expediente_AT { get; set; }
        public int? Expediente_MASC { get; set; }
        public int? Expediente_MP { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Orden_de_Proteccion { get; set; }
        public int? Tipo_de_Medida { get; set; }
        public int? Sub_Tipo { get; set; }
        public DateTime? Fecha_de_Inicio { get; set; }
        public string Hora_de_Inicio { get; set; }
        public DateTime? Fecha_de_Conclusion { get; set; }
        public string Hora_de_Conclusion { get; set; }
        public short? Duracion_en_Dias { get; set; }
        public int? Aplicar_a { get; set; }

		        [ForeignKey("Expediente_AT")]
        public virtual Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial Expediente_AT_Modulo_Atencion_Inicial { get; set; }
        [ForeignKey("Expediente_MASC")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Expediente_MASC_Solicitud { get; set; }
        [ForeignKey("Expediente_MP")]
        public virtual Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico Expediente_MP_expediente_ministerio_publico { get; set; }
        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }
        [ForeignKey("Tipo_de_Medida")]
        public virtual Spartane.Core.Domain.Tipo_de_Medida_de_Proteccion.Tipo_de_Medida_de_Proteccion Tipo_de_Medida_Tipo_de_Medida_de_Proteccion { get; set; }
        [ForeignKey("Sub_Tipo")]
        public virtual Spartane.Core.Domain.SubTipo_de_Medida_de_Proteccion.SubTipo_de_Medida_de_Proteccion Sub_Tipo_SubTipo_de_Medida_de_Proteccion { get; set; }
        [ForeignKey("Aplicar_a")]
        public virtual Spartane.Core.Domain.Detalle_de_Relaciones.Detalle_de_Relaciones Aplicar_a_Detalle_de_Relaciones { get; set; }

    }


}

