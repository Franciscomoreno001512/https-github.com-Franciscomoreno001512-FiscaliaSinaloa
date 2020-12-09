using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Tamano_Orejas
{
    /// <summary>
    /// Tamano_Orejas table
    /// </summary>
    public class Tamano_Orejas: BaseEntity
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? LLAVE { get; set; }


    }
	
	public class Tamano_Orejas_Datos_Generales
    {
                public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? LLAVE { get; set; }

		
    }


}

