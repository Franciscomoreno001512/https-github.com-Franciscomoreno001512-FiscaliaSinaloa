using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Catalogo_de_Inicio_de_Cadena_de_Custodia
{
    /// <summary>
    /// Catalogo_de_Inicio_de_Cadena_de_Custodia table
    /// </summary>
    public class Catalogo_de_Inicio_de_Cadena_de_Custodia: BaseEntity
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }


    }
	
	public class Catalogo_de_Inicio_de_Cadena_de_Custodia_Datos_Generales
    {
                public int Clave { get; set; }
        public string Descripcion { get; set; }

		
    }


}

