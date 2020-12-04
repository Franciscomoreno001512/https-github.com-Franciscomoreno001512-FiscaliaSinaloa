using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Plazo_de_Investigacion_Complementaria
{
    /// <summary>
    /// Plazo_de_Investigacion_Complementaria table
    /// </summary>
    public class Plazo_de_Investigacion_Complementaria: BaseEntity
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }


    }
	
	public class Plazo_de_Investigacion_Complementaria_Datos_Generales
    {
                public int Clave { get; set; }
        public string Descripcion { get; set; }

		
    }


}

