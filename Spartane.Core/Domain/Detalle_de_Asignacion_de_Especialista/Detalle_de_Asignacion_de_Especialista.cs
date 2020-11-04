using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Solicitud;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Asignacion_de_Especialista
{
    /// <summary>
    /// Detalle_de_Asignacion_de_Especialista table
    /// </summary>
    public class Detalle_de_Asignacion_de_Especialista: BaseEntity
    {
        public short Clave { get; set; }
        public int? Nombre_de_Especialista { get; set; }
        public short? Carga_de_trabajo { get; set; }
        public int? Solicitud { get; set; }

        [ForeignKey("Solicitud")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Solicitud_Solicitud { get; set; }

    }
	
	public class Detalle_de_Asignacion_de_Especialista_Datos_Generales
    {
                public short Clave { get; set; }
        public int? Nombre_de_Especialista { get; set; }
        public short? Carga_de_trabajo { get; set; }
        public int? Solicitud { get; set; }

		        [ForeignKey("Solicitud")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Solicitud_Solicitud { get; set; }

    }


}

