using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.tipo_de_cierre
{
    /// <summary>
    /// tipo_de_cierre table
    /// </summary>
    public class tipo_de_cierre: BaseEntity
    {
        public int clave { get; set; }
        public string descripcion { get; set; }


    }
	
	public class tipo_de_cierre_Datos_Generales
    {
                public int clave { get; set; }
        public string descripcion { get; set; }

		
    }


}

