using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Solicitud_Solicitante;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_Documentos_Solicitantes
{
    /// <summary>
    /// Detalle_Documentos_Solicitantes table
    /// </summary>
    public class Detalle_Documentos_Solicitantes: BaseEntity
    {
        public int Clave { get; set; }
        public int? Nombre { get; set; }

        [ForeignKey("Nombre")]
        public virtual Spartane.Core.Domain.Detalle_de_Solicitud_Solicitante.Detalle_de_Solicitud_Solicitante Nombre_Detalle_de_Solicitud_Solicitante { get; set; }

    }
	
	public class Detalle_Documentos_Solicitantes_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Nombre { get; set; }

		        [ForeignKey("Nombre")]
        public virtual Spartane.Core.Domain.Detalle_de_Solicitud_Solicitante.Detalle_de_Solicitud_Solicitante Nombre_Detalle_de_Solicitud_Solicitante { get; set; }

    }


}

