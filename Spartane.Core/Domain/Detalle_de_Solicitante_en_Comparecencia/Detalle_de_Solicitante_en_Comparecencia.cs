using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Solicitud;
using Spartane.Core.Domain.Solicitante;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Solicitante_en_Comparecencia
{
    /// <summary>
    /// Detalle_de_Solicitante_en_Comparecencia table
    /// </summary>
    public class Detalle_de_Solicitante_en_Comparecencia: BaseEntity
    {
        public int Clave { get; set; }
        public int? Solicitud { get; set; }
        public int? Nombre { get; set; }

        [ForeignKey("Solicitud")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Solicitud_Solicitud { get; set; }
        [ForeignKey("Nombre")]
        public virtual Spartane.Core.Domain.Solicitante.Solicitante Nombre_Solicitante { get; set; }

    }
	
	public class Detalle_de_Solicitante_en_Comparecencia_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Solicitud { get; set; }
        public int? Nombre { get; set; }

		        [ForeignKey("Solicitud")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Solicitud_Solicitud { get; set; }
        [ForeignKey("Nombre")]
        public virtual Spartane.Core.Domain.Solicitante.Solicitante Nombre_Solicitante { get; set; }

    }


}

