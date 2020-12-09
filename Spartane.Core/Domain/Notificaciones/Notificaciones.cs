using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Spartan_User;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Notificaciones
{
    /// <summary>
    /// Notificaciones table
    /// </summary>
    public class Notificaciones: BaseEntity
    {
        public int Folio { get; set; }
        public DateTime? Fecha { get; set; }
        public string Hora { get; set; }
        public string Titulo { get; set; }
        public string Notificacion { get; set; }
        public int? Destinatario { get; set; }
        public bool? Enviado { get; set; }

        [ForeignKey("Destinatario")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Destinatario_Spartan_User { get; set; }

    }
	
	public class Notificaciones_Datos_Generales
    {
                public int Folio { get; set; }
        public DateTime? Fecha { get; set; }
        public string Hora { get; set; }
        public string Titulo { get; set; }
        public string Notificacion { get; set; }
        public int? Destinatario { get; set; }
        public bool? Enviado { get; set; }

		        [ForeignKey("Destinatario")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Destinatario_Spartan_User { get; set; }

    }


}

