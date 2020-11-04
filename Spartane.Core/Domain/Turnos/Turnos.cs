using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Turnos
{
    /// <summary>
    /// Turnos table
    /// </summary>
    public class Turnos: BaseEntity
    {
        public int Clave { get; set; }
        public string Clave_de_Municipio { get; set; }
        public string Descripcion { get; set; }
        public string Clave_de_Agencia { get; set; }
        public string Clave_de_MunicipioAgencia { get; set; }
        public string Depende_de { get; set; }
        public bool? Activo { get; set; }
        public string Prioridad { get; set; }


    }
	
	public class Turnos_Datos_Generales
    {
                public int Clave { get; set; }
        public string Clave_de_Municipio { get; set; }
        public string Descripcion { get; set; }
        public string Clave_de_Agencia { get; set; }
        public string Clave_de_MunicipioAgencia { get; set; }
        public string Depende_de { get; set; }
        public bool? Activo { get; set; }
        public string Prioridad { get; set; }

		
    }


}

