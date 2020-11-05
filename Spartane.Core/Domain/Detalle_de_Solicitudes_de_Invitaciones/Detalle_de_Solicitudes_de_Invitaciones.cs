using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Solicitud;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Tipo_de_Invitacion;
using Spartane.Core.Domain.Tipo_de_Funcion;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Resultado_de_Notificacion;
using Spartane.Core.Domain.Incidente_con_Invitacion;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Solicitudes_de_Invitaciones
{
    /// <summary>
    /// Detalle_de_Solicitudes_de_Invitaciones table
    /// </summary>
    public class Detalle_de_Solicitudes_de_Invitaciones: BaseEntity
    {
        public int Clave { get; set; }
        public int? Solicitud { get; set; }
        public DateTime? Fecha_de_Invitacion { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Numero_de_Invitacion { get; set; }
        public string Numero_de_Oficio { get; set; }
        public int? Formato_de_Invitacion { get; set; }
        public int? Tipo_de_Participacion { get; set; }
        public DateTime? Fecha_de_la_cita { get; set; }
        public string Hora_de_la_Cita { get; set; }
        public string Domicilio { get; set; }
        public DateTime? Fecha_de_Notificacion { get; set; }
        public string Hora_de_Notificacion { get; set; }
        public int? Notificador { get; set; }
        public int? Resultado { get; set; }
        public int? Incidente_en_la_Recepcion { get; set; }

        [ForeignKey("Solicitud")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Solicitud_Solicitud { get; set; }
        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }
        [ForeignKey("Formato_de_Invitacion")]
        public virtual Spartane.Core.Domain.Tipo_de_Invitacion.Tipo_de_Invitacion Formato_de_Invitacion_Tipo_de_Invitacion { get; set; }
        [ForeignKey("Tipo_de_Participacion")]
        public virtual Spartane.Core.Domain.Tipo_de_Funcion.Tipo_de_Funcion Tipo_de_Participacion_Tipo_de_Funcion { get; set; }
        [ForeignKey("Notificador")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Notificador_Spartan_User { get; set; }
        [ForeignKey("Resultado")]
        public virtual Spartane.Core.Domain.Resultado_de_Notificacion.Resultado_de_Notificacion Resultado_Resultado_de_Notificacion { get; set; }
        [ForeignKey("Incidente_en_la_Recepcion")]
        public virtual Spartane.Core.Domain.Incidente_con_Invitacion.Incidente_con_Invitacion Incidente_en_la_Recepcion_Incidente_con_Invitacion { get; set; }

    }
	
	public class Detalle_de_Solicitudes_de_Invitaciones_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Solicitud { get; set; }
        public DateTime? Fecha_de_Invitacion { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Numero_de_Invitacion { get; set; }
        public string Numero_de_Oficio { get; set; }
        public int? Formato_de_Invitacion { get; set; }
        public int? Tipo_de_Participacion { get; set; }
        public DateTime? Fecha_de_la_cita { get; set; }
        public string Hora_de_la_Cita { get; set; }
        public string Domicilio { get; set; }

		        [ForeignKey("Solicitud")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Solicitud_Solicitud { get; set; }
        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }
        [ForeignKey("Formato_de_Invitacion")]
        public virtual Spartane.Core.Domain.Tipo_de_Invitacion.Tipo_de_Invitacion Formato_de_Invitacion_Tipo_de_Invitacion { get; set; }
        [ForeignKey("Tipo_de_Participacion")]
        public virtual Spartane.Core.Domain.Tipo_de_Funcion.Tipo_de_Funcion Tipo_de_Participacion_Tipo_de_Funcion { get; set; }

    }

	public class Detalle_de_Solicitudes_de_Invitaciones_Resultado_de_Notificacion
    {
                public int Clave { get; set; }
        public DateTime? Fecha_de_Notificacion { get; set; }
        public string Hora_de_Notificacion { get; set; }
        public int? Notificador { get; set; }
        public int? Resultado { get; set; }
        public int? Incidente_en_la_Recepcion { get; set; }

		        [ForeignKey("Notificador")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Notificador_Spartan_User { get; set; }
        [ForeignKey("Resultado")]
        public virtual Spartane.Core.Domain.Resultado_de_Notificacion.Resultado_de_Notificacion Resultado_Resultado_de_Notificacion { get; set; }
        [ForeignKey("Incidente_en_la_Recepcion")]
        public virtual Spartane.Core.Domain.Incidente_con_Invitacion.Incidente_con_Invitacion Incidente_en_la_Recepcion_Incidente_con_Invitacion { get; set; }

    }


}

