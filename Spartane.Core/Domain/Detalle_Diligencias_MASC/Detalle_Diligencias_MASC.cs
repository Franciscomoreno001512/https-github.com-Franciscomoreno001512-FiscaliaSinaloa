using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Solicitud;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Tipo_de_Diligencia_MASC;
using Spartane.Core.Domain.Dilgencia_MASC;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_Diligencias_MASC
{
    /// <summary>
    /// Detalle_Diligencias_MASC table
    /// </summary>
    public class Detalle_Diligencias_MASC: BaseEntity
    {
        public int Clave { get; set; }
        public int? Solicitud { get; set; }
        public DateTime? Fecha { get; set; }
        public string Hora { get; set; }
        public int? Facilitador { get; set; }
        public int? Tipo_de_Diligencia { get; set; }
        public int? Diligencia { get; set; }
        public string Observaciones { get; set; }

        [ForeignKey("Solicitud")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Solicitud_Solicitud { get; set; }
        [ForeignKey("Facilitador")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Facilitador_Spartan_User { get; set; }
        [ForeignKey("Tipo_de_Diligencia")]
        public virtual Spartane.Core.Domain.Tipo_de_Diligencia_MASC.Tipo_de_Diligencia_MASC Tipo_de_Diligencia_Tipo_de_Diligencia_MASC { get; set; }
        [ForeignKey("Diligencia")]
        public virtual Spartane.Core.Domain.Dilgencia_MASC.Dilgencia_MASC Diligencia_Dilgencia_MASC { get; set; }

    }
	
	public class Detalle_Diligencias_MASC_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Solicitud { get; set; }
        public DateTime? Fecha { get; set; }
        public string Hora { get; set; }
        public int? Facilitador { get; set; }
        public int? Tipo_de_Diligencia { get; set; }
        public int? Diligencia { get; set; }
        public string Observaciones { get; set; }

		        [ForeignKey("Solicitud")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Solicitud_Solicitud { get; set; }
        [ForeignKey("Facilitador")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Facilitador_Spartan_User { get; set; }
        [ForeignKey("Tipo_de_Diligencia")]
        public virtual Spartane.Core.Domain.Tipo_de_Diligencia_MASC.Tipo_de_Diligencia_MASC Tipo_de_Diligencia_Tipo_de_Diligencia_MASC { get; set; }
        [ForeignKey("Diligencia")]
        public virtual Spartane.Core.Domain.Dilgencia_MASC.Dilgencia_MASC Diligencia_Dilgencia_MASC { get; set; }

    }


}

