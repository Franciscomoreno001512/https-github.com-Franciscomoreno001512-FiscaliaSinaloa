using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Solicitud;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Spartan_User;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_Solicitud_Historial_de_Asignaciones
{
    /// <summary>
    /// Detalle_Solicitud_Historial_de_Asignaciones table
    /// </summary>
    public class Detalle_Solicitud_Historial_de_Asignaciones: BaseEntity
    {
        public int Folio { get; set; }
        public int? Solicitud { get; set; }
        public DateTime? Fecha_cambio { get; set; }
        public string Hora_cambio { get; set; }
        public int? Usuario { get; set; }
        public int? Facilitador_Asignado { get; set; }
        public string Motivo_cambio { get; set; }

        [ForeignKey("Solicitud")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Solicitud_Solicitud { get; set; }
        [ForeignKey("Usuario")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_Spartan_User { get; set; }
        [ForeignKey("Facilitador_Asignado")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Facilitador_Asignado_Spartan_User { get; set; }

    }
	
	public class Detalle_Solicitud_Historial_de_Asignaciones_Datos_Generales
    {
                public int Folio { get; set; }
        public int? Solicitud { get; set; }
        public DateTime? Fecha_cambio { get; set; }
        public string Hora_cambio { get; set; }
        public int? Usuario { get; set; }
        public int? Facilitador_Asignado { get; set; }
        public string Motivo_cambio { get; set; }

		        [ForeignKey("Solicitud")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Solicitud_Solicitud { get; set; }
        [ForeignKey("Usuario")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_Spartan_User { get; set; }
        [ForeignKey("Facilitador_Asignado")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Facilitador_Asignado_Spartan_User { get; set; }

    }


}

