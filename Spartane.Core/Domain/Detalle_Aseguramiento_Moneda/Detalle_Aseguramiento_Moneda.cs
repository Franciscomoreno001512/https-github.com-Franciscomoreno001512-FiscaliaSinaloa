using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Aseguramientos;
using Spartane.Core.Domain.Tipo_de_Moneda;
using Spartane.Core.Domain.Tipo_de_Dinero;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_Aseguramiento_Moneda
{
    /// <summary>
    /// Detalle_Aseguramiento_Moneda table
    /// </summary>
    public class Detalle_Aseguramiento_Moneda: BaseEntity
    {
        public int Clave { get; set; }
        public int? Aseguramiento { get; set; }
        public short? Tipo { get; set; }
        public decimal? Cantidad { get; set; }
        public string Observaciones { get; set; }
        public short? Descripcion { get; set; }

        [ForeignKey("Aseguramiento")]
        public virtual Spartane.Core.Domain.Aseguramientos.Aseguramientos Aseguramiento_Aseguramientos { get; set; }
        [ForeignKey("Tipo")]
        public virtual Spartane.Core.Domain.Tipo_de_Moneda.Tipo_de_Moneda Tipo_Tipo_de_Moneda { get; set; }
        [ForeignKey("Descripcion")]
        public virtual Spartane.Core.Domain.Tipo_de_Dinero.Tipo_de_Dinero Descripcion_Tipo_de_Dinero { get; set; }

    }
	
	public class Detalle_Aseguramiento_Moneda_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Aseguramiento { get; set; }
        public short? Tipo { get; set; }
        public decimal? Cantidad { get; set; }
        public string Observaciones { get; set; }
        public short? Descripcion { get; set; }

		        [ForeignKey("Aseguramiento")]
        public virtual Spartane.Core.Domain.Aseguramientos.Aseguramientos Aseguramiento_Aseguramientos { get; set; }
        [ForeignKey("Tipo")]
        public virtual Spartane.Core.Domain.Tipo_de_Moneda.Tipo_de_Moneda Tipo_Tipo_de_Moneda { get; set; }
        [ForeignKey("Descripcion")]
        public virtual Spartane.Core.Domain.Tipo_de_Dinero.Tipo_de_Dinero Descripcion_Tipo_de_Dinero { get; set; }

    }


}

