using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Solicitud_Requerido;
using Spartane.Core.Domain.Tipo_de_Identificacion;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Otras_Identificaciones_Requerido_MASC
{
    /// <summary>
    /// Otras_Identificaciones_Requerido_MASC table
    /// </summary>
    public class Otras_Identificaciones_Requerido_MASC: BaseEntity
    {
        public int Clave { get; set; }
        public int? Requerido { get; set; }
        public int? Tipo_de_Identificacion { get; set; }
        public string Descripcion { get; set; }

        [ForeignKey("Requerido")]
        public virtual Spartane.Core.Domain.Detalle_de_Solicitud_Requerido.Detalle_de_Solicitud_Requerido Requerido_Detalle_de_Solicitud_Requerido { get; set; }
        [ForeignKey("Tipo_de_Identificacion")]
        public virtual Spartane.Core.Domain.Tipo_de_Identificacion.Tipo_de_Identificacion Tipo_de_Identificacion_Tipo_de_Identificacion { get; set; }

    }
	
	public class Otras_Identificaciones_Requerido_MASC_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Requerido { get; set; }
        public int? Tipo_de_Identificacion { get; set; }
        public string Descripcion { get; set; }

		        [ForeignKey("Requerido")]
        public virtual Spartane.Core.Domain.Detalle_de_Solicitud_Requerido.Detalle_de_Solicitud_Requerido Requerido_Detalle_de_Solicitud_Requerido { get; set; }
        [ForeignKey("Tipo_de_Identificacion")]
        public virtual Spartane.Core.Domain.Tipo_de_Identificacion.Tipo_de_Identificacion Tipo_de_Identificacion_Tipo_de_Identificacion { get; set; }

    }


}

