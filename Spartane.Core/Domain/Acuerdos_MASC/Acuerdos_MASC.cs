using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Solicitud;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Tipo_de_Acuerdo;
using Spartane.Core.Domain.Detalle_de_Solicitud_Solicitante;
using Spartane.Core.Domain.Detalle_de_Solicitud_Requerido;
using Spartane.Core.Domain.Periodicidad;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Domain.A_Tiempo;
using Spartane.Core.Domain.Razon_de_Incumplimiento;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Resultado_de_Revision;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Acuerdos_MASC
{
    /// <summary>
    /// Acuerdos_MASC table
    /// </summary>
    public class Acuerdos_MASC: BaseEntity
    {
        public int Clave { get; set; }
        public int? Numero_de_Expediente { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public int? Tipo_de_Acuerdo { get; set; }
        public int? Solicitante { get; set; }
        public int? Requerido { get; set; }
        public string Lugar_Acordado { get; set; }
        public string Domicilio_Acordado { get; set; }
        public string Hora_de_Acuerdo { get; set; }
        public DateTime? Fecha_de_Inicio_de_Acuerdo { get; set; }
        public decimal? Monto_Total { get; set; }
        public short? Parcialidades { get; set; }
        public int? Periodicidad { get; set; }
        public decimal? Monto_de_la_Parcialidad { get; set; }
        public int? Personal_de_Seguimiento_Asignado { get; set; }
        public int? Acuerdo { get; set; }
        public string Acuerdo_URL { get; set; }
        public string Comentarios { get; set; }
        public short? Acuerdo_Cumplido { get; set; }
        public DateTime? Fecha_de_Cumplimiento_de_Acuerdo { get; set; }
        public int? Razon_de_Incumplimiento { get; set; }
        public DateTime? Fecha_de_Revision { get; set; }
        public string Hora_de_Revision { get; set; }
        public int? Usuario_que_Revisa { get; set; }
        public short? Resultado { get; set; }
        public string Motivo_de_Rechazo_de_Acuerdo { get; set; }

        [ForeignKey("Numero_de_Expediente")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Numero_de_Expediente_Solicitud { get; set; }
        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }
        [ForeignKey("Tipo_de_Acuerdo")]
        public virtual Spartane.Core.Domain.Tipo_de_Acuerdo.Tipo_de_Acuerdo Tipo_de_Acuerdo_Tipo_de_Acuerdo { get; set; }
        [ForeignKey("Solicitante")]
        public virtual Spartane.Core.Domain.Detalle_de_Solicitud_Solicitante.Detalle_de_Solicitud_Solicitante Solicitante_Detalle_de_Solicitud_Solicitante { get; set; }
        [ForeignKey("Requerido")]
        public virtual Spartane.Core.Domain.Detalle_de_Solicitud_Requerido.Detalle_de_Solicitud_Requerido Requerido_Detalle_de_Solicitud_Requerido { get; set; }
        [ForeignKey("Periodicidad")]
        public virtual Spartane.Core.Domain.Periodicidad.Periodicidad Periodicidad_Periodicidad { get; set; }
        [ForeignKey("Personal_de_Seguimiento_Asignado")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Personal_de_Seguimiento_Asignado_Spartan_User { get; set; }
        [ForeignKey("Acuerdo")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Acuerdo_Spartane_File { get; set; }
        [ForeignKey("Acuerdo_Cumplido")]
        public virtual Spartane.Core.Domain.A_Tiempo.A_Tiempo Acuerdo_Cumplido_A_Tiempo { get; set; }
        [ForeignKey("Razon_de_Incumplimiento")]
        public virtual Spartane.Core.Domain.Razon_de_Incumplimiento.Razon_de_Incumplimiento Razon_de_Incumplimiento_Razon_de_Incumplimiento { get; set; }
        [ForeignKey("Usuario_que_Revisa")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Revisa_Spartan_User { get; set; }
        [ForeignKey("Resultado")]
        public virtual Spartane.Core.Domain.Resultado_de_Revision.Resultado_de_Revision Resultado_Resultado_de_Revision { get; set; }

    }
	
	public class Acuerdos_MASC_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Numero_de_Expediente { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public int? Tipo_de_Acuerdo { get; set; }
        public int? Solicitante { get; set; }
        public int? Requerido { get; set; }
        public string Lugar_Acordado { get; set; }
        public string Domicilio_Acordado { get; set; }
        public string Hora_de_Acuerdo { get; set; }
        public DateTime? Fecha_de_Inicio_de_Acuerdo { get; set; }
        public decimal? Monto_Total { get; set; }
        public short? Parcialidades { get; set; }
        public int? Periodicidad { get; set; }
        public decimal? Monto_de_la_Parcialidad { get; set; }
        public int? Personal_de_Seguimiento_Asignado { get; set; }
        public int? Acuerdo { get; set; }
        public string Acuerdo_URL { get; set; }
        public string Comentarios { get; set; }
        public short? Acuerdo_Cumplido { get; set; }
        public DateTime? Fecha_de_Cumplimiento_de_Acuerdo { get; set; }
        public int? Razon_de_Incumplimiento { get; set; }

		        [ForeignKey("Numero_de_Expediente")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Numero_de_Expediente_Solicitud { get; set; }
        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }
        [ForeignKey("Tipo_de_Acuerdo")]
        public virtual Spartane.Core.Domain.Tipo_de_Acuerdo.Tipo_de_Acuerdo Tipo_de_Acuerdo_Tipo_de_Acuerdo { get; set; }
        [ForeignKey("Solicitante")]
        public virtual Spartane.Core.Domain.Detalle_de_Solicitud_Solicitante.Detalle_de_Solicitud_Solicitante Solicitante_Detalle_de_Solicitud_Solicitante { get; set; }
        [ForeignKey("Requerido")]
        public virtual Spartane.Core.Domain.Detalle_de_Solicitud_Requerido.Detalle_de_Solicitud_Requerido Requerido_Detalle_de_Solicitud_Requerido { get; set; }
        [ForeignKey("Periodicidad")]
        public virtual Spartane.Core.Domain.Periodicidad.Periodicidad Periodicidad_Periodicidad { get; set; }
        [ForeignKey("Personal_de_Seguimiento_Asignado")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Personal_de_Seguimiento_Asignado_Spartan_User { get; set; }
        [ForeignKey("Acuerdo")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Acuerdo_Spartane_File { get; set; }
        [ForeignKey("Acuerdo_Cumplido")]
        public virtual Spartane.Core.Domain.A_Tiempo.A_Tiempo Acuerdo_Cumplido_A_Tiempo { get; set; }
        [ForeignKey("Razon_de_Incumplimiento")]
        public virtual Spartane.Core.Domain.Razon_de_Incumplimiento.Razon_de_Incumplimiento Razon_de_Incumplimiento_Razon_de_Incumplimiento { get; set; }

    }

	public class Acuerdos_MASC_Autorizacion
    {
                public int Clave { get; set; }
        public DateTime? Fecha_de_Revision { get; set; }
        public string Hora_de_Revision { get; set; }
        public int? Usuario_que_Revisa { get; set; }
        public short? Resultado { get; set; }
        public string Motivo_de_Rechazo_de_Acuerdo { get; set; }

		        [ForeignKey("Usuario_que_Revisa")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Revisa_Spartan_User { get; set; }
        [ForeignKey("Resultado")]
        public virtual Spartane.Core.Domain.Resultado_de_Revision.Resultado_de_Revision Resultado_Resultado_de_Revision { get; set; }

    }


}

