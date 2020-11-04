using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Imputado;
using Spartane.Core.Domain.Adicciones;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Adicciones_Probable_Responsable
{
    /// <summary>
    /// Adicciones_Probable_Responsable table
    /// </summary>
    public class Adicciones_Probable_Responsable: BaseEntity
    {
        public int Clave { get; set; }
        public int? Folio_Adicciones { get; set; }
        public int? Descripcion { get; set; }

        [ForeignKey("Folio_Adicciones")]
        public virtual Spartane.Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado Folio_Adicciones_Detalle_de_Imputado { get; set; }
        [ForeignKey("Descripcion")]
        public virtual Spartane.Core.Domain.Adicciones.Adicciones Descripcion_Adicciones { get; set; }

    }
	
	public class Adicciones_Probable_Responsable_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Folio_Adicciones { get; set; }
        public int? Descripcion { get; set; }

		        [ForeignKey("Folio_Adicciones")]
        public virtual Spartane.Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado Folio_Adicciones_Detalle_de_Imputado { get; set; }
        [ForeignKey("Descripcion")]
        public virtual Spartane.Core.Domain.Adicciones.Adicciones Descripcion_Adicciones { get; set; }

    }


}

