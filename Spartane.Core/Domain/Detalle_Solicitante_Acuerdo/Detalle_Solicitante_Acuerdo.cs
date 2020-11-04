using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Acuerdos_MASC;
using Spartane.Core.Domain.Detalle_de_Solicitud_Solicitante;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_Solicitante_Acuerdo
{
    /// <summary>
    /// Detalle_Solicitante_Acuerdo table
    /// </summary>
    public class Detalle_Solicitante_Acuerdo: BaseEntity
    {
        public int Folio { get; set; }
        public int? Acuerdo { get; set; }
        public int? Solicitante { get; set; }

        [ForeignKey("Acuerdo")]
        public virtual Spartane.Core.Domain.Acuerdos_MASC.Acuerdos_MASC Acuerdo_Acuerdos_MASC { get; set; }
        [ForeignKey("Solicitante")]
        public virtual Spartane.Core.Domain.Detalle_de_Solicitud_Solicitante.Detalle_de_Solicitud_Solicitante Solicitante_Detalle_de_Solicitud_Solicitante { get; set; }

    }
	
	public class Detalle_Solicitante_Acuerdo_Datos_Generales
    {
                public int Folio { get; set; }
        public int? Acuerdo { get; set; }
        public int? Solicitante { get; set; }

		        [ForeignKey("Acuerdo")]
        public virtual Spartane.Core.Domain.Acuerdos_MASC.Acuerdos_MASC Acuerdo_Acuerdos_MASC { get; set; }
        [ForeignKey("Solicitante")]
        public virtual Spartane.Core.Domain.Detalle_de_Solicitud_Solicitante.Detalle_de_Solicitud_Solicitante Solicitante_Detalle_de_Solicitud_Solicitante { get; set; }

    }


}

