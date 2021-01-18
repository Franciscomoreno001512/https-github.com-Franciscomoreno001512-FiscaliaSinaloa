using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Ambito
{
    /// <summary>
    /// Ambito table
    /// </summary>
    public class Ambito: BaseEntity
    {
        public int Clave { get; set; }
        public string Ambitox { get; set; }


    }
	
	public class Ambito_Datos_Generales
    {
                public int Clave { get; set; }
        public string Ambitox { get; set; }

		
    }


}

