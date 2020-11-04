using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Solicitud;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_Historico_JA
{
    /// <summary>
    /// Detalle_Historico_JA table
    /// </summary>
    public class Detalle_Historico_JA: BaseEntity
    {
        public int Clave { get; set; }
        public DateTime? Fecha { get; set; }
        public string Hora { get; set; }
        public int? Usuario { get; set; }
        public string Estatus { get; set; }
        public int? Solicitud { get; set; }

        [ForeignKey("Usuario")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_Spartan_User { get; set; }
        [ForeignKey("Solicitud")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Solicitud_Solicitud { get; set; }

    }
	
	public class Detalle_Historico_JA_Datos_Generales
    {
                public int Clave { get; set; }
        public DateTime? Fecha { get; set; }
        public string Hora { get; set; }
        public int? Usuario { get; set; }
        public string Estatus { get; set; }
        public int? Solicitud { get; set; }

		        [ForeignKey("Usuario")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_Spartan_User { get; set; }
        [ForeignKey("Solicitud")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Solicitud_Solicitud { get; set; }

    }


}

