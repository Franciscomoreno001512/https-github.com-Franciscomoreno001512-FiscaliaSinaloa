using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Genero
{
    /// <summary>
    /// Genero table
    /// </summary>
    public class Genero: BaseEntity
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public string sexo { get; set; }
        public string Inicial { get; set; }


    }
	
	public class Genero_Datos_Generales
    {
                public int Clave { get; set; }
        public string Descripcion { get; set; }
        public string sexo { get; set; }
        public string Inicial { get; set; }

		
    }


}

