using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Solicitud_Requerido;
using Spartane.Core.Domain.Adicciones;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Adicciones_Requerido_MASC
{
    /// <summary>
    /// Adicciones_Requerido_MASC table
    /// </summary>
    public class Adicciones_Requerido_MASC: BaseEntity
    {
        public int Clave { get; set; }
        public int? Requerido { get; set; }
        public int? Descripcion { get; set; }

        [ForeignKey("Requerido")]
        public virtual Spartane.Core.Domain.Detalle_de_Solicitud_Requerido.Detalle_de_Solicitud_Requerido Requerido_Detalle_de_Solicitud_Requerido { get; set; }
        [ForeignKey("Descripcion")]
        public virtual Spartane.Core.Domain.Adicciones.Adicciones Descripcion_Adicciones { get; set; }

    }
	
	public class Adicciones_Requerido_MASC_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Requerido { get; set; }
        public int? Descripcion { get; set; }

		        [ForeignKey("Requerido")]
        public virtual Spartane.Core.Domain.Detalle_de_Solicitud_Requerido.Detalle_de_Solicitud_Requerido Requerido_Detalle_de_Solicitud_Requerido { get; set; }
        [ForeignKey("Descripcion")]
        public virtual Spartane.Core.Domain.Adicciones.Adicciones Descripcion_Adicciones { get; set; }

    }


}

