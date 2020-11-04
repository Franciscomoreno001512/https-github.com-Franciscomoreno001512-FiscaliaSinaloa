using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Audiencia_de_Control_Hechos;
using Spartane.Core.Domain.Solicitud;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Hechos_Audiencia_Inicial
{
    /// <summary>
    /// Detalle_de_Hechos_Audiencia_Inicial table
    /// </summary>
    public class Detalle_de_Hechos_Audiencia_Inicial: BaseEntity
    {
        public int Clave { get; set; }
        public int? Descripcion_del_Hecho { get; set; }
        public bool? Si { get; set; }
        public short? Archivo_Adjunto { get; set; }
        public int? Solicitud { get; set; }

        [ForeignKey("Descripcion_del_Hecho")]
        public virtual Spartane.Core.Domain.Audiencia_de_Control_Hechos.Audiencia_de_Control_Hechos Descripcion_del_Hecho_Audiencia_de_Control_Hechos { get; set; }
        [ForeignKey("Solicitud")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Solicitud_Solicitud { get; set; }

    }
	
	public class Detalle_de_Hechos_Audiencia_Inicial_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Descripcion_del_Hecho { get; set; }
        public bool? Si { get; set; }
        public short? Archivo_Adjunto { get; set; }
        public int? Solicitud { get; set; }

		        [ForeignKey("Descripcion_del_Hecho")]
        public virtual Spartane.Core.Domain.Audiencia_de_Control_Hechos.Audiencia_de_Control_Hechos Descripcion_del_Hecho_Audiencia_de_Control_Hechos { get; set; }
        [ForeignKey("Solicitud")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Solicitud_Solicitud { get; set; }

    }


}

