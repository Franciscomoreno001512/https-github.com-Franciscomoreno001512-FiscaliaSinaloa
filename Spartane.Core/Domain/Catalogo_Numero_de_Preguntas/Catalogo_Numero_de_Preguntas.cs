using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Catalogo_Numero_de_Preguntas
{
    /// <summary>
    /// Catalogo_Numero_de_Preguntas table
    /// </summary>
    public class Catalogo_Numero_de_Preguntas: BaseEntity
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }


    }
	
	public class Catalogo_Numero_de_Preguntas_Datos_Generales
    {
                public int Clave { get; set; }
        public string Descripcion { get; set; }

		
    }


}

