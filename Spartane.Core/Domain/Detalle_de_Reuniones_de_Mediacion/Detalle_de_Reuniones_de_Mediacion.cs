using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Solicitud;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Tipo_de_Sesion;
using Spartane.Core.Domain.Cumplimiento;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Reuniones_de_Mediacion
{
    /// <summary>
    /// Detalle_de_Reuniones_de_Mediacion table
    /// </summary>
    public class Detalle_de_Reuniones_de_Mediacion: BaseEntity
    {
        public int Clave { get; set; }
        public int? Numero_de_Expediente { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Lugar { get; set; }
        public DateTime? Fecha { get; set; }
        public string Hora { get; set; }
        public int? Especialista { get; set; }
        public int? Tipo_de_Sesion { get; set; }
        public int? Cumplimiento { get; set; }

        [ForeignKey("Numero_de_Expediente")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Numero_de_Expediente_Solicitud { get; set; }
        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }
        [ForeignKey("Especialista")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Especialista_Spartan_User { get; set; }
        [ForeignKey("Tipo_de_Sesion")]
        public virtual Spartane.Core.Domain.Tipo_de_Sesion.Tipo_de_Sesion Tipo_de_Sesion_Tipo_de_Sesion { get; set; }
        [ForeignKey("Cumplimiento")]
        public virtual Spartane.Core.Domain.Cumplimiento.Cumplimiento Cumplimiento_Cumplimiento { get; set; }

    }
	
	public class Detalle_de_Reuniones_de_Mediacion_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Numero_de_Expediente { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Lugar { get; set; }
        public DateTime? Fecha { get; set; }
        public string Hora { get; set; }
        public int? Especialista { get; set; }
        public int? Tipo_de_Sesion { get; set; }
        public int? Cumplimiento { get; set; }

		        [ForeignKey("Numero_de_Expediente")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Numero_de_Expediente_Solicitud { get; set; }
        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }
        [ForeignKey("Especialista")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Especialista_Spartan_User { get; set; }
        [ForeignKey("Tipo_de_Sesion")]
        public virtual Spartane.Core.Domain.Tipo_de_Sesion.Tipo_de_Sesion Tipo_de_Sesion_Tipo_de_Sesion { get; set; }
        [ForeignKey("Cumplimiento")]
        public virtual Spartane.Core.Domain.Cumplimiento.Cumplimiento Cumplimiento_Cumplimiento { get; set; }

    }


}

