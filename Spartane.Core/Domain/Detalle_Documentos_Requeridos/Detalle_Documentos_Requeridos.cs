using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_documentos;
using Spartane.Core.Domain.Detalle_de_Solicitud_Requerido;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_Documentos_Requeridos
{
    /// <summary>
    /// Detalle_Documentos_Requeridos table
    /// </summary>
    public class Detalle_Documentos_Requeridos: BaseEntity
    {
        public int Clave { get; set; }
        public int? Solicitud { get; set; }
        public int? Nombre { get; set; }

        [ForeignKey("Solicitud")]
        public virtual Spartane.Core.Domain.Detalle_de_documentos.Detalle_de_documentos Solicitud_Detalle_de_documentos { get; set; }
        [ForeignKey("Nombre")]
        public virtual Spartane.Core.Domain.Detalle_de_Solicitud_Requerido.Detalle_de_Solicitud_Requerido Nombre_Detalle_de_Solicitud_Requerido { get; set; }

    }
	
	public class Detalle_Documentos_Requeridos_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Solicitud { get; set; }
        public int? Nombre { get; set; }

		        [ForeignKey("Solicitud")]
        public virtual Spartane.Core.Domain.Detalle_de_documentos.Detalle_de_documentos Solicitud_Detalle_de_documentos { get; set; }
        [ForeignKey("Nombre")]
        public virtual Spartane.Core.Domain.Detalle_de_Solicitud_Requerido.Detalle_de_Solicitud_Requerido Nombre_Detalle_de_Solicitud_Requerido { get; set; }

    }


}

