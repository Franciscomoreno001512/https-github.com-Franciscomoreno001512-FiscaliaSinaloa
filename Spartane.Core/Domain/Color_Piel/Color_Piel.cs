using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Color_Piel
{
    /// <summary>
    /// Color_Piel table
    /// </summary>
    public class Color_Piel: BaseEntity
    {
        public int Clave { get; set; }
        public string Descrpicion { get; set; }


    }
	
	public class Color_Piel_Datos_Generales
    {
                public int Clave { get; set; }
        public string Descrpicion { get; set; }

		
    }


}

