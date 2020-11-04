using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Catalogo_Tipo_de_Cargo_CC
{
    /// <summary>
    /// Catalogo_Tipo_de_Cargo_CC table
    /// </summary>
    public class Catalogo_Tipo_de_Cargo_CC: BaseEntity
    {
        public int Clave { get; set; }
        public string Tipo_de_Cargo { get; set; }


    }
	
	public class Catalogo_Tipo_de_Cargo_CC_Datos_Generales
    {
                public int Clave { get; set; }
        public string Tipo_de_Cargo { get; set; }

		
    }


}

