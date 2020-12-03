using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Condiciones_en_Suspension_Condicional
{
    /// <summary>
    /// Condiciones_en_Suspension_Condicional table
    /// </summary>
    public class Condiciones_en_Suspension_Condicional: BaseEntity
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }


    }
	
	public class Condiciones_en_Suspension_Condicional_Datos_Generales
    {
                public int Clave { get; set; }
        public string Descripcion { get; set; }

		
    }


}

