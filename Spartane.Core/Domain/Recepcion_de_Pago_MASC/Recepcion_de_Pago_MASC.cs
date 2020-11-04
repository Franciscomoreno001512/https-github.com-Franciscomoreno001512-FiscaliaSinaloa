using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Solicitud;
using Spartane.Core.Domain.Detalle_de_Solicitud_Requerido;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Recepcion_de_Pago_MASC
{
    /// <summary>
    /// Recepcion_de_Pago_MASC table
    /// </summary>
    public class Recepcion_de_Pago_MASC: BaseEntity
    {
        public int Clave { get; set; }
        public DateTime? Fecha_de_Recepcion { get; set; }
        public string Hora_de_Recepcion { get; set; }
        public int? Usuario_que_Recibe { get; set; }
        public int? Numero_de_Expediente { get; set; }
        public int? Requerido { get; set; }
        public string Nombre_de_la_Persona_que_entrega { get; set; }
        public int? Numero_de_Pago { get; set; }
        public decimal? Monto_del_Pago { get; set; }
        public bool? Pago_Completo { get; set; }
        public string Motivo_para_no_entregar_pago_completo { get; set; }

        [ForeignKey("Usuario_que_Recibe")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Recibe_Spartan_User { get; set; }
        [ForeignKey("Numero_de_Expediente")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Numero_de_Expediente_Solicitud { get; set; }
        [ForeignKey("Requerido")]
        public virtual Spartane.Core.Domain.Detalle_de_Solicitud_Requerido.Detalle_de_Solicitud_Requerido Requerido_Detalle_de_Solicitud_Requerido { get; set; }

    }
	
	public class Recepcion_de_Pago_MASC_Datos_Generales
    {
                public int Clave { get; set; }
        public DateTime? Fecha_de_Recepcion { get; set; }
        public string Hora_de_Recepcion { get; set; }
        public int? Usuario_que_Recibe { get; set; }
        public int? Numero_de_Expediente { get; set; }
        public int? Requerido { get; set; }
        public string Nombre_de_la_Persona_que_entrega { get; set; }
        public int? Numero_de_Pago { get; set; }
        public decimal? Monto_del_Pago { get; set; }
        public bool? Pago_Completo { get; set; }
        public string Motivo_para_no_entregar_pago_completo { get; set; }

		        [ForeignKey("Usuario_que_Recibe")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Recibe_Spartan_User { get; set; }
        [ForeignKey("Numero_de_Expediente")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Numero_de_Expediente_Solicitud { get; set; }
        [ForeignKey("Requerido")]
        public virtual Spartane.Core.Domain.Detalle_de_Solicitud_Requerido.Detalle_de_Solicitud_Requerido Requerido_Detalle_de_Solicitud_Requerido { get; set; }

    }


}

