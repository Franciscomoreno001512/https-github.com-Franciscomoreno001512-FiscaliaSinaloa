using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Origen_de_Invitacion;
using Spartane.Core.Domain.Modulo_Atencion_Inicial;
using Spartane.Core.Domain.Solicitud;
using Spartane.Core.Domain.Expediente_Inicial;
using Spartane.Core.Domain.Tipo_de_Invitacion;
using Spartane.Core.Domain.Estatus_de_Notificacion;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Resultado_de_Notificacion;
using Spartane.Core.Domain.Incidente_con_Invitacion;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Solicitud_de_Notificacion
{
    /// <summary>
    /// Solicitud_de_Notificacion table
    /// </summary>
    public class Solicitud_de_Notificacion: BaseEntity
    {
        public int Folio { get; set; }
        public DateTime? Fecha_de_Solicitud { get; set; }
        public string Hora_de_Solicitud { get; set; }
        public int? Usuario_que_Solicita { get; set; }
        public int? Origen { get; set; }
        public int? Expediente_Atencion_Temprana { get; set; }
        public int? Expediente_Mecanismos_Alternos { get; set; }
        public int? Carpeta_de_Investigacion { get; set; }
        public int? Forma_de_Invitacion { get; set; }
        public string Numero_de_Invitacion { get; set; }
        public DateTime? Fecha_de_la_cita { get; set; }
        public string Hora_de_la_Cita { get; set; }
        public string Lugar_de_la_Cita { get; set; }
        public int? Estatus { get; set; }
        public DateTime? Fecha_de_Notificacion { get; set; }
        public string Hora_de_Notificacion { get; set; }
        public int? Notificador { get; set; }
        public int? Resultado { get; set; }
        public int? Incidente_en_la_Recepcion { get; set; }

        [ForeignKey("Usuario_que_Solicita")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Solicita_Spartan_User { get; set; }
        [ForeignKey("Origen")]
        public virtual Spartane.Core.Domain.Origen_de_Invitacion.Origen_de_Invitacion Origen_Origen_de_Invitacion { get; set; }
        [ForeignKey("Expediente_Atencion_Temprana")]
        public virtual Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial Expediente_Atencion_Temprana_Modulo_Atencion_Inicial { get; set; }
        [ForeignKey("Expediente_Mecanismos_Alternos")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Expediente_Mecanismos_Alternos_Solicitud { get; set; }
        [ForeignKey("Carpeta_de_Investigacion")]
        public virtual Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial Carpeta_de_Investigacion_Expediente_Inicial { get; set; }
        [ForeignKey("Forma_de_Invitacion")]
        public virtual Spartane.Core.Domain.Tipo_de_Invitacion.Tipo_de_Invitacion Forma_de_Invitacion_Tipo_de_Invitacion { get; set; }
        [ForeignKey("Estatus")]
        public virtual Spartane.Core.Domain.Estatus_de_Notificacion.Estatus_de_Notificacion Estatus_Estatus_de_Notificacion { get; set; }
        [ForeignKey("Notificador")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Notificador_Spartan_User { get; set; }
        [ForeignKey("Resultado")]
        public virtual Spartane.Core.Domain.Resultado_de_Notificacion.Resultado_de_Notificacion Resultado_Resultado_de_Notificacion { get; set; }
        [ForeignKey("Incidente_en_la_Recepcion")]
        public virtual Spartane.Core.Domain.Incidente_con_Invitacion.Incidente_con_Invitacion Incidente_en_la_Recepcion_Incidente_con_Invitacion { get; set; }

    }
	
	public class Solicitud_de_Notificacion_Datos_Generales
    {
                public int Folio { get; set; }
        public DateTime? Fecha_de_Solicitud { get; set; }
        public string Hora_de_Solicitud { get; set; }
        public int? Usuario_que_Solicita { get; set; }
        public int? Origen { get; set; }
        public int? Expediente_Atencion_Temprana { get; set; }
        public int? Expediente_Mecanismos_Alternos { get; set; }
        public int? Carpeta_de_Investigacion { get; set; }
        public int? Forma_de_Invitacion { get; set; }
        public string Numero_de_Invitacion { get; set; }
        public DateTime? Fecha_de_la_cita { get; set; }
        public string Hora_de_la_Cita { get; set; }
        public string Lugar_de_la_Cita { get; set; }
        public int? Estatus { get; set; }

		        [ForeignKey("Usuario_que_Solicita")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Solicita_Spartan_User { get; set; }
        [ForeignKey("Origen")]
        public virtual Spartane.Core.Domain.Origen_de_Invitacion.Origen_de_Invitacion Origen_Origen_de_Invitacion { get; set; }
        [ForeignKey("Expediente_Atencion_Temprana")]
        public virtual Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial Expediente_Atencion_Temprana_Modulo_Atencion_Inicial { get; set; }
        [ForeignKey("Expediente_Mecanismos_Alternos")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Expediente_Mecanismos_Alternos_Solicitud { get; set; }
        [ForeignKey("Carpeta_de_Investigacion")]
        public virtual Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial Carpeta_de_Investigacion_Expediente_Inicial { get; set; }
        [ForeignKey("Forma_de_Invitacion")]
        public virtual Spartane.Core.Domain.Tipo_de_Invitacion.Tipo_de_Invitacion Forma_de_Invitacion_Tipo_de_Invitacion { get; set; }
        [ForeignKey("Estatus")]
        public virtual Spartane.Core.Domain.Estatus_de_Notificacion.Estatus_de_Notificacion Estatus_Estatus_de_Notificacion { get; set; }

    }

	public class Solicitud_de_Notificacion_Resultado_de_Notificacion
    {
                public int Folio { get; set; }
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

