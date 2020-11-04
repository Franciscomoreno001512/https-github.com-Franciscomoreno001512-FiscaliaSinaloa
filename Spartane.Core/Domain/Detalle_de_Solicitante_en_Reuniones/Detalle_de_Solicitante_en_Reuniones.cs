using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Reuniones_de_Mediacion;
using Spartane.Core.Domain.Detalle_de_Solicitud_Solicitante;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Solicitante_en_Reuniones
{
    /// <summary>
    /// Detalle_de_Solicitante_en_Reuniones table
    /// </summary>
    public class Detalle_de_Solicitante_en_Reuniones: BaseEntity
    {
        public int Clave { get; set; }
        public int? Solicitud { get; set; }
        public int? Nombre { get; set; }

        [ForeignKey("Solicitud")]
        public virtual Spartane.Core.Domain.Detalle_de_Reuniones_de_Mediacion.Detalle_de_Reuniones_de_Mediacion Solicitud_Detalle_de_Reuniones_de_Mediacion { get; set; }
        [ForeignKey("Nombre")]
        public virtual Spartane.Core.Domain.Detalle_de_Solicitud_Solicitante.Detalle_de_Solicitud_Solicitante Nombre_Detalle_de_Solicitud_Solicitante { get; set; }

    }
	
	public class Detalle_de_Solicitante_en_Reuniones_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Solicitud { get; set; }
        public int? Nombre { get; set; }

		        [ForeignKey("Solicitud")]
        public virtual Spartane.Core.Domain.Detalle_de_Reuniones_de_Mediacion.Detalle_de_Reuniones_de_Mediacion Solicitud_Detalle_de_Reuniones_de_Mediacion { get; set; }
        [ForeignKey("Nombre")]
        public virtual Spartane.Core.Domain.Detalle_de_Solicitud_Solicitante.Detalle_de_Solicitud_Solicitante Nombre_Detalle_de_Solicitud_Solicitante { get; set; }

    }


}

