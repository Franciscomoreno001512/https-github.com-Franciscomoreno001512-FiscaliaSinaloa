using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Modulo_Encuesta
{
    /// <summary>
    /// Modulo_Encuesta table
    /// </summary>
    public class Modulo_Encuesta: BaseEntity
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public string Abreviacion { get; set; }


    }
	
	public class Modulo_Encuesta_Datos_Generales
    {
                public int Clave { get; set; }
        public string Descripcion { get; set; }
        public string Abreviacion { get; set; }

		
    }


}

