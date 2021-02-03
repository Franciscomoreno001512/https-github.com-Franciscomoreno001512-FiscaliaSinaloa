using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Audiencia_Inicial;
using Spartane.Core.Domain.Detalle_de_Imputado;
using Spartane.Core.Domain.Delito;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_Relaciones_Audiencia_Inicial
{
    /// <summary>
    /// Detalle_Relaciones_Audiencia_Inicial table
    /// </summary>
    public class Detalle_Relaciones_Audiencia_Inicial: BaseEntity
    {
        public int Clave { get; set; }
        public int? Audiencia_Inicial { get; set; }
        public int? Imputado { get; set; }
        public int? Delito { get; set; }

        [ForeignKey("Audiencia_Inicial")]
        public virtual Spartane.Core.Domain.Audiencia_Inicial.Audiencia_Inicial Audiencia_Inicial_Audiencia_Inicial { get; set; }
        [ForeignKey("Imputado")]
        public virtual Spartane.Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado Imputado_Detalle_de_Imputado { get; set; }
        [ForeignKey("Delito")]
        public virtual Spartane.Core.Domain.Delito.Delito Delito_Delito { get; set; }

    }
	
	public class Detalle_Relaciones_Audiencia_Inicial_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Audiencia_Inicial { get; set; }
        public int? Imputado { get; set; }
        public int? Delito { get; set; }

		        [ForeignKey("Audiencia_Inicial")]
        public virtual Spartane.Core.Domain.Audiencia_Inicial.Audiencia_Inicial Audiencia_Inicial_Audiencia_Inicial { get; set; }
        [ForeignKey("Imputado")]
        public virtual Spartane.Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado Imputado_Detalle_de_Imputado { get; set; }
        [ForeignKey("Delito")]
        public virtual Spartane.Core.Domain.Delito.Delito Delito_Delito { get; set; }

    }


}

