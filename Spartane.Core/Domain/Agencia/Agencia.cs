using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Agencia
{
    /// <summary>
    /// Agencia table
    /// </summary>
    public class Agencia: BaseEntity
    {
        public string Clave { get; set; }
        public string Clave_de_Municipio { get; set; }
        public string Descripcion { get; set; }
        public bool? Activa { get; set; }
        public int ClaveID { get; set; }


    }
	
	public class Agencia_Datos_Generales
    {
                public string Clave { get; set; }
        public string Clave_de_Municipio { get; set; }
        public string Descripcion { get; set; }
        public bool? Activa { get; set; }
        public int ClaveID { get; set; }

		
    }


}

