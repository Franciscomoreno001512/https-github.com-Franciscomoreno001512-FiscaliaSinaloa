using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Institucion_Emisora
{
    /// <summary>
    /// Institucion_Emisora table
    /// </summary>
    public class Institucion_Emisora: BaseEntity
    {
        public int Clave { get; set; }
        public string Nombre { get; set; }


    }
	
	public class Institucion_Emisora_Datos_Generales
    {
                public int Clave { get; set; }
        public string Nombre { get; set; }

		
    }


}

