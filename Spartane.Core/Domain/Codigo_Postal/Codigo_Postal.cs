using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Colonia;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Codigo_Postal
{
    /// <summary>
    /// Codigo_Postal table
    /// </summary>
    public class Codigo_Postal: BaseEntity
    {
        public int Clave { get; set; }
        public int? Codigo_PostalC { get; set; }
        public int? Colonia { get; set; }

        [ForeignKey("Colonia")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_Colonia { get; set; }

    }
	
	public class Codigo_Postal_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Codigo_PostalC { get; set; }
        public int? Colonia { get; set; }

		        [ForeignKey("Colonia")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_Colonia { get; set; }

    }


}

