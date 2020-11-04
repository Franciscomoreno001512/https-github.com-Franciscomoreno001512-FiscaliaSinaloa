using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Vigencia
{
    /// <summary>
    /// Vigencia table
    /// </summary>
    public class Vigencia: BaseEntity
    {
        public int Clave { get; set; }
        public string Abreviacion { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }


    }
	
	public class Vigencia_Datos_Generales
    {
                public int Clave { get; set; }
        public string Abreviacion { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }

		
    }


}

