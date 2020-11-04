using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Modalidad_de_Robo_de_Vehiculo
{
    /// <summary>
    /// Modalidad_de_Robo_de_Vehiculo table
    /// </summary>
    public class Modalidad_de_Robo_de_Vehiculo: BaseEntity
    {
        public short Clave { get; set; }
        public string Descripcion { get; set; }


    }
	
	public class Modalidad_de_Robo_de_Vehiculo_Datos_Generales
    {
                public short Clave { get; set; }
        public string Descripcion { get; set; }

		
    }


}

