using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Especialista_de_Justicia_Alternativa
{
    /// <summary>
    /// Especialista_de_Justicia_Alternativa table
    /// </summary>
    public class Especialista_de_Justicia_Alternativa: BaseEntity
    {
        public int Clave { get; set; }
        public string Numero_de_Empleado { get; set; }
        public string Nombre_de_Especialista { get; set; }
        public short? Carga_de_Trabajo { get; set; }


    }
	
	public class Especialista_de_Justicia_Alternativa_Datos_Generales
    {
                public int Clave { get; set; }
        public string Numero_de_Empleado { get; set; }
        public string Nombre_de_Especialista { get; set; }
        public short? Carga_de_Trabajo { get; set; }

		
    }


}

