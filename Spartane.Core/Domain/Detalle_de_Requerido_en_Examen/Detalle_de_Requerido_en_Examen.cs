using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Solicitud;
using Spartane.Core.Domain.Requerido;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Requerido_en_Examen
{
    /// <summary>
    /// Detalle_de_Requerido_en_Examen table
    /// </summary>
    public class Detalle_de_Requerido_en_Examen: BaseEntity
    {
        public int Clave { get; set; }
        public int? Solicitud { get; set; }
        public int? Nombre { get; set; }

        [ForeignKey("Solicitud")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Solicitud_Solicitud { get; set; }
        [ForeignKey("Nombre")]
        public virtual Spartane.Core.Domain.Requerido.Requerido Nombre_Requerido { get; set; }

    }
	
	public class Detalle_de_Requerido_en_Examen_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Solicitud { get; set; }
        public int? Nombre { get; set; }

		        [ForeignKey("Solicitud")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Solicitud_Solicitud { get; set; }
        [ForeignKey("Nombre")]
        public virtual Spartane.Core.Domain.Requerido.Requerido Nombre_Requerido { get; set; }

    }


}

