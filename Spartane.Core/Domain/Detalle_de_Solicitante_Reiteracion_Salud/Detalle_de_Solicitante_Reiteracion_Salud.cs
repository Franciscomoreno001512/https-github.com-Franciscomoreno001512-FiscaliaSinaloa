using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Audiencia_de_Control_Reiteracion;
using Spartane.Core.Domain.Solicitud;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Solicitante_Reiteracion_Salud
{
    /// <summary>
    /// Detalle_de_Solicitante_Reiteracion_Salud table
    /// </summary>
    public class Detalle_de_Solicitante_Reiteracion_Salud: BaseEntity
    {
        public int Clave { get; set; }
        public int? Descripcion { get; set; }
        public bool? Si { get; set; }
        public short? Archivo_Adjunto { get; set; }
        public int? Solicitud { get; set; }

        [ForeignKey("Descripcion")]
        public virtual Spartane.Core.Domain.Audiencia_de_Control_Reiteracion.Audiencia_de_Control_Reiteracion Descripcion_Audiencia_de_Control_Reiteracion { get; set; }
        [ForeignKey("Solicitud")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Solicitud_Solicitud { get; set; }

    }
	
	public class Detalle_de_Solicitante_Reiteracion_Salud_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Descripcion { get; set; }
        public bool? Si { get; set; }
        public short? Archivo_Adjunto { get; set; }
        public int? Solicitud { get; set; }

		        [ForeignKey("Descripcion")]
        public virtual Spartane.Core.Domain.Audiencia_de_Control_Reiteracion.Audiencia_de_Control_Reiteracion Descripcion_Audiencia_de_Control_Reiteracion { get; set; }
        [ForeignKey("Solicitud")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Solicitud_Solicitud { get; set; }

    }


}

