using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Datos_Generales;
using Spartane.Core.Domain.Adicciones;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Adicciones_de_Involucrado
{
    /// <summary>
    /// Adicciones_de_Involucrado table
    /// </summary>
    public class Adicciones_de_Involucrado: BaseEntity
    {
        public int Clave { get; set; }
        public int? Folio_Adicciones { get; set; }
        public int? Descripcion { get; set; }

        [ForeignKey("Folio_Adicciones")]
        public virtual Spartane.Core.Domain.Detalle_de_Datos_Generales.Detalle_de_Datos_Generales Folio_Adicciones_Detalle_de_Datos_Generales { get; set; }
        [ForeignKey("Descripcion")]
        public virtual Spartane.Core.Domain.Adicciones.Adicciones Descripcion_Adicciones { get; set; }

    }
	
	public class Adicciones_de_Involucrado_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Folio_Adicciones { get; set; }
        public int? Descripcion { get; set; }

		        [ForeignKey("Folio_Adicciones")]
        public virtual Spartane.Core.Domain.Detalle_de_Datos_Generales.Detalle_de_Datos_Generales Folio_Adicciones_Detalle_de_Datos_Generales { get; set; }
        [ForeignKey("Descripcion")]
        public virtual Spartane.Core.Domain.Adicciones.Adicciones Descripcion_Adicciones { get; set; }

    }


}

