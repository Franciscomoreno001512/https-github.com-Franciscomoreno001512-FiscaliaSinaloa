using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Localidad
{
    /// <summary>
    /// Localidad table
    /// </summary>
    public class Localidad: BaseEntity
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }


    }
	
	public class Localidad_Datos_Generales
    {
                public int Clave { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }

		
    }


}

