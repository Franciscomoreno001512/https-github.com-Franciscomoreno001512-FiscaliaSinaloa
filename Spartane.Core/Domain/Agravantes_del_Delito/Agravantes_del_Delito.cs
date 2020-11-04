using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Delito;
using Spartane.Core.Domain.Agravantes;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Agravantes_del_Delito
{
    /// <summary>
    /// Agravantes_del_Delito table
    /// </summary>
    public class Agravantes_del_Delito: BaseEntity
    {
        public int Clave { get; set; }
        public int? Folio_Agravante { get; set; }
        public int? Agravante { get; set; }

        [ForeignKey("Folio_Agravante")]
        public virtual Spartane.Core.Domain.Detalle_de_Delito.Detalle_de_Delito Folio_Agravante_Detalle_de_Delito { get; set; }
        [ForeignKey("Agravante")]
        public virtual Spartane.Core.Domain.Agravantes.Agravantes Agravante_Agravantes { get; set; }

    }
	
	public class Agravantes_del_Delito_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Folio_Agravante { get; set; }
        public int? Agravante { get; set; }

		        [ForeignKey("Folio_Agravante")]
        public virtual Spartane.Core.Domain.Detalle_de_Delito.Detalle_de_Delito Folio_Agravante_Detalle_de_Delito { get; set; }
        [ForeignKey("Agravante")]
        public virtual Spartane.Core.Domain.Agravantes.Agravantes Agravante_Agravantes { get; set; }

    }


}

