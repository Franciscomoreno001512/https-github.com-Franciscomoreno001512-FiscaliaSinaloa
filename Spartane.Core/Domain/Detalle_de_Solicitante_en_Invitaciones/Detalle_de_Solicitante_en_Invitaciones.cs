using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Solicitudes_de_Invitaciones;
using Spartane.Core.Domain.Detalle_de_Solicitud_Solicitante;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Solicitante_en_Invitaciones
{
    /// <summary>
    /// Detalle_de_Solicitante_en_Invitaciones table
    /// </summary>
    public class Detalle_de_Solicitante_en_Invitaciones: BaseEntity
    {
        public int Clave { get; set; }
        public int? Solicitud { get; set; }
        public int? Nombre { get; set; }

        [ForeignKey("Solicitud")]
        public virtual Spartane.Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_Invitaciones Solicitud_Detalle_de_Solicitudes_de_Invitaciones { get; set; }
        [ForeignKey("Nombre")]
        public virtual Spartane.Core.Domain.Detalle_de_Solicitud_Solicitante.Detalle_de_Solicitud_Solicitante Nombre_Detalle_de_Solicitud_Solicitante { get; set; }

    }
	
	public class Detalle_de_Solicitante_en_Invitaciones_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Solicitud { get; set; }
        public int? Nombre { get; set; }

		        [ForeignKey("Solicitud")]
        public virtual Spartane.Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_Invitaciones Solicitud_Detalle_de_Solicitudes_de_Invitaciones { get; set; }
        [ForeignKey("Nombre")]
        public virtual Spartane.Core.Domain.Detalle_de_Solicitud_Solicitante.Detalle_de_Solicitud_Solicitante Nombre_Detalle_de_Solicitud_Solicitante { get; set; }

    }


}

