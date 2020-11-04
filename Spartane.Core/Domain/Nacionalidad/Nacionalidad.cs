using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Nacionalidad
{
    /// <summary>
    /// Nacionalidad table
    /// </summary>
    public class Nacionalidad: BaseEntity
    {
        public int Clave { get; set; }
        public string NacionalidadC { get; set; }
        public string Descripcion_Estadistica { get; set; }


    }
	
	public class Nacionalidad_Datos_Generales
    {
                public int Clave { get; set; }
        public string NacionalidadC { get; set; }
        public string Descripcion_Estadistica { get; set; }

		
    }


}

