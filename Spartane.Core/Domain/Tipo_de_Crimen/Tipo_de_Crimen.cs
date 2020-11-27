using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Tipo_de_Crimen
{
    /// <summary>
    /// Tipo_de_Crimen table
    /// </summary>
    public class Tipo_de_Crimen: BaseEntity
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }


    }
	
	public class Tipo_de_Crimen_Datos_Generales
    {
                public int Clave { get; set; }
        public string Descripcion { get; set; }

		
    }


}

