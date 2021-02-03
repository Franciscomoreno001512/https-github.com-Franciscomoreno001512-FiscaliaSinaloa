using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Relaciones_MASC;
using Spartane.Core.Domain.Detalle_de_Imputado;
using Spartane.Core.Domain.Delito;
using Spartane.Core.Domain.Detalle_de_Datos_Generales;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_Relaciones_MASC
{
    /// <summary>
    /// Detalle_Relaciones_MASC table
    /// </summary>
    public class Detalle_Relaciones_MASC: BaseEntity
    {
        public int Clave { get; set; }
        public int? Relaciones { get; set; }
        public int? Requerido { get; set; }
        public int? Delito { get; set; }
        public int? Solicitante { get; set; }

        [ForeignKey("Relaciones")]
        public virtual Spartane.Core.Domain.Relaciones_MASC.Relaciones_MASC Relaciones_Relaciones_MASC { get; set; }
        [ForeignKey("Requerido")]
        public virtual Spartane.Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado Requerido_Detalle_de_Imputado { get; set; }
        [ForeignKey("Delito")]
        public virtual Spartane.Core.Domain.Delito.Delito Delito_Delito { get; set; }
        [ForeignKey("Solicitante")]
        public virtual Spartane.Core.Domain.Detalle_de_Datos_Generales.Detalle_de_Datos_Generales Solicitante_Detalle_de_Datos_Generales { get; set; }

    }
	
	public class Detalle_Relaciones_MASC_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Relaciones { get; set; }
        public int? Requerido { get; set; }
        public int? Delito { get; set; }
        public int? Solicitante { get; set; }

		        [ForeignKey("Relaciones")]
        public virtual Spartane.Core.Domain.Relaciones_MASC.Relaciones_MASC Relaciones_Relaciones_MASC { get; set; }
        [ForeignKey("Requerido")]
        public virtual Spartane.Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado Requerido_Detalle_de_Imputado { get; set; }
        [ForeignKey("Delito")]
        public virtual Spartane.Core.Domain.Delito.Delito Delito_Delito { get; set; }
        [ForeignKey("Solicitante")]
        public virtual Spartane.Core.Domain.Detalle_de_Datos_Generales.Detalle_de_Datos_Generales Solicitante_Detalle_de_Datos_Generales { get; set; }

    }


}

