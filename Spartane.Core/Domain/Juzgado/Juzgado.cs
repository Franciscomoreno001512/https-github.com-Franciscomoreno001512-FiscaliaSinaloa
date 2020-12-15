using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Region;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Juzgado
{
    /// <summary>
    /// Juzgado table
    /// </summary>
    public class Juzgado: BaseEntity
    {
        public int Clave { get; set; }
        public string Nombre { get; set; }
        public int? Region { get; set; }

        [ForeignKey("Region")]
        public virtual Spartane.Core.Domain.Region.Region Region_Region { get; set; }

    }
	
	public class Juzgado_Datos_Generales
    {
                public int Clave { get; set; }
        public string Nombre { get; set; }
        public int? Region { get; set; }

		        [ForeignKey("Region")]
        public virtual Spartane.Core.Domain.Region.Region Region_Region { get; set; }

    }


}

