using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Acuerdos_MASC;
using Spartane.Core.Domain.Detalle_de_Solicitud_Requerido;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_Requerido_Acuerdo
{
    /// <summary>
    /// Detalle_Requerido_Acuerdo table
    /// </summary>
    public class Detalle_Requerido_Acuerdo: BaseEntity
    {
        public int Folio { get; set; }
        public int? Acuerdo { get; set; }
        public int? Requerido { get; set; }

        [ForeignKey("Acuerdo")]
        public virtual Spartane.Core.Domain.Acuerdos_MASC.Acuerdos_MASC Acuerdo_Acuerdos_MASC { get; set; }
        [ForeignKey("Requerido")]
        public virtual Spartane.Core.Domain.Detalle_de_Solicitud_Requerido.Detalle_de_Solicitud_Requerido Requerido_Detalle_de_Solicitud_Requerido { get; set; }

    }
	
	public class Detalle_Requerido_Acuerdo_Datos_Generales
    {
                public int Folio { get; set; }
        public int? Acuerdo { get; set; }
        public int? Requerido { get; set; }

		        [ForeignKey("Acuerdo")]
        public virtual Spartane.Core.Domain.Acuerdos_MASC.Acuerdos_MASC Acuerdo_Acuerdos_MASC { get; set; }
        [ForeignKey("Requerido")]
        public virtual Spartane.Core.Domain.Detalle_de_Solicitud_Requerido.Detalle_de_Solicitud_Requerido Requerido_Detalle_de_Solicitud_Requerido { get; set; }

    }


}

