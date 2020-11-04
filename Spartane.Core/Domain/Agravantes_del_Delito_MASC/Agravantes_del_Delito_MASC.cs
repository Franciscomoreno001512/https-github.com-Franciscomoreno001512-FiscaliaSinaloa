using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Delito_de_Justicia;
using Spartane.Core.Domain.Agravantes;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Agravantes_del_Delito_MASC
{
    /// <summary>
    /// Agravantes_del_Delito_MASC table
    /// </summary>
    public class Agravantes_del_Delito_MASC: BaseEntity
    {
        public int Clave { get; set; }
        public int? Folio_Agravante { get; set; }
        public int? Agravante { get; set; }

        [ForeignKey("Folio_Agravante")]
        public virtual Spartane.Core.Domain.Detalle_de_Delito_de_Justicia.Detalle_de_Delito_de_Justicia Folio_Agravante_Detalle_de_Delito_de_Justicia { get; set; }
        [ForeignKey("Agravante")]
        public virtual Spartane.Core.Domain.Agravantes.Agravantes Agravante_Agravantes { get; set; }

    }
	
	public class Agravantes_del_Delito_MASC_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Folio_Agravante { get; set; }
        public int? Agravante { get; set; }

		        [ForeignKey("Folio_Agravante")]
        public virtual Spartane.Core.Domain.Detalle_de_Delito_de_Justicia.Detalle_de_Delito_de_Justicia Folio_Agravante_Detalle_de_Delito_de_Justicia { get; set; }
        [ForeignKey("Agravante")]
        public virtual Spartane.Core.Domain.Agravantes.Agravantes Agravante_Agravantes { get; set; }

    }


}

