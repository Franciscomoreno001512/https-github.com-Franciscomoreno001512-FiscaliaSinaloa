using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Director_de_Agencia
{
    /// <summary>
    /// Director_de_Agencia table
    /// </summary>
    public class Director_de_Agencia: BaseEntity
    {
        public int Clave { get; set; }
        public int? Numero_de_Empleado { get; set; }
        public string Nombre_de_Empleado { get; set; }


    }
	
	public class Director_de_Agencia_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Numero_de_Empleado { get; set; }
        public string Nombre_de_Empleado { get; set; }

		
    }


}

