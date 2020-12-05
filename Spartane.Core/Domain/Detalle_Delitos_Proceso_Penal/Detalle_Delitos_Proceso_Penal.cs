using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Proceso_Penal;
using Spartane.Core.Domain.Delito;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_Delitos_Proceso_Penal
{
    /// <summary>
    /// Detalle_Delitos_Proceso_Penal table
    /// </summary>
    public class Detalle_Delitos_Proceso_Penal: BaseEntity
    {
        public int Clave { get; set; }
        public int? Proceso_Penal { get; set; }
        public int? Delito { get; set; }

        [ForeignKey("Proceso_Penal")]
        public virtual Spartane.Core.Domain.Proceso_Penal.Proceso_Penal Proceso_Penal_Proceso_Penal { get; set; }
        [ForeignKey("Delito")]
        public virtual Spartane.Core.Domain.Delito.Delito Delito_Delito { get; set; }

    }
	
	public class Detalle_Delitos_Proceso_Penal_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Proceso_Penal { get; set; }
        public int? Delito { get; set; }

		        [ForeignKey("Proceso_Penal")]
        public virtual Spartane.Core.Domain.Proceso_Penal.Proceso_Penal Proceso_Penal_Proceso_Penal { get; set; }
        [ForeignKey("Delito")]
        public virtual Spartane.Core.Domain.Delito.Delito Delito_Delito { get; set; }

    }


}

