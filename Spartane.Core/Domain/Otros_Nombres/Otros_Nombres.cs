using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Imputado;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Otros_Nombres
{
    /// <summary>
    /// Otros_Nombres table
    /// </summary>
    public class Otros_Nombres: BaseEntity
    {
        public int Clave { get; set; }
        public int? Folio_otros_Nombres { get; set; }
        public string Nombres { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }

        [ForeignKey("Folio_otros_Nombres")]
        public virtual Spartane.Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado Folio_otros_Nombres_Detalle_de_Imputado { get; set; }

    }
	
	public class Otros_Nombres_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Folio_otros_Nombres { get; set; }
        public string Nombres { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }

		        [ForeignKey("Folio_otros_Nombres")]
        public virtual Spartane.Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado Folio_otros_Nombres_Detalle_de_Imputado { get; set; }

    }


}

