using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Solicitud;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Tipo_de_Invitacion;
using Spartane.Core.Domain.Tipo_de_Funcion;
using Spartane.Core.Domain.Cumplimiento;
using Spartane.Core.Domain.Incidente_con_Invitacion;
using Spartane.Core.Domain.A_Tiempo;
using Spartane.Core.Domain.Spartane_File;

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
        public DateTime? Fecha_de_Recepcion { get; set; }
        public DateTime? Fecha_de_Aceptacion { get; set; }
        public int? Cumplimiento { get; set; }
        public int? Incidente { get; set; }
        public short? A_Tiempo { get; set; }
        public int? Archivo { get; set; }
        public string Archivo_URL { get; set; }

        [ForeignKey("Solicitud")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Solicitud_Solicitud { get; set; }
        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }
        [ForeignKey("Formato_de_Invitacion")]
        public virtual Spartane.Core.Domain.Tipo_de_Invitacion.Tipo_de_Invitacion Formato_de_Invitacion_Tipo_de_Invitacion { get; set; }
        [ForeignKey("Tipo_de_Participacion")]
        public virtual Spartane.Core.Domain.Tipo_de_Funcion.Tipo_de_Funcion Tipo_de_Participacion_Tipo_de_Funcion { get; set; }
        [ForeignKey("Cumplimiento")]
        public virtual Spartane.Core.Domain.Cumplimiento.Cumplimiento Cumplimiento_Cumplimiento { get; set; }
        [ForeignKey("Incidente")]
        public virtual Spartane.Core.Domain.Incidente_con_Invitacion.Incidente_con_Invitacion Incidente_Incidente_con_Invitacion { get; set; }
        [ForeignKey("A_Tiempo")]
        public virtual Spartane.Core.Domain.A_Tiempo.A_Tiempo A_Tiempo_A_Tiempo { get; set; }
        [ForeignKey("Archivo")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Archivo_Spartane_File { get; set; }

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
        public DateTime? Fecha_de_Recepcion { get; set; }
        public DateTime? Fecha_de_Aceptacion { get; set; }
        public int? Cumplimiento { get; set; }
        public int? Incidente { get; set; }
        public short? A_Tiempo { get; set; }
        public int? Archivo { get; set; }
        public string Archivo_URL { get; set; }

		        [ForeignKey("Solicitud")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Solicitud_Solicitud { get; set; }
        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }
        [ForeignKey("Formato_de_Invitacion")]
        public virtual Spartane.Core.Domain.Tipo_de_Invitacion.Tipo_de_Invitacion Formato_de_Invitacion_Tipo_de_Invitacion { get; set; }
        [ForeignKey("Tipo_de_Participacion")]
        public virtual Spartane.Core.Domain.Tipo_de_Funcion.Tipo_de_Funcion Tipo_de_Participacion_Tipo_de_Funcion { get; set; }
        [ForeignKey("Cumplimiento")]
        public virtual Spartane.Core.Domain.Cumplimiento.Cumplimiento Cumplimiento_Cumplimiento { get; set; }
        [ForeignKey("Incidente")]
        public virtual Spartane.Core.Domain.Incidente_con_Invitacion.Incidente_con_Invitacion Incidente_Incidente_con_Invitacion { get; set; }
        [ForeignKey("A_Tiempo")]
        public virtual Spartane.Core.Domain.A_Tiempo.A_Tiempo A_Tiempo_A_Tiempo { get; set; }
        [ForeignKey("Archivo")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Archivo_Spartane_File { get; set; }

    }


}

