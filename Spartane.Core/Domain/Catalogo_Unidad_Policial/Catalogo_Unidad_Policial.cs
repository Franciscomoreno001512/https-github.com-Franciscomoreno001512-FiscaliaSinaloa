using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Catalogo_Unidad_Policial
{
    /// <summary>
    /// Catalogo_Unidad_Policial table
    /// </summary>
    public class Catalogo_Unidad_Policial: BaseEntity
    {
        public int Clave { get; set; }
        public string Unidad_Policial { get; set; }


    }
	
	public class Catalogo_Unidad_Policial_Datos_Generales
    {
                public int Clave { get; set; }
        public string Unidad_Policial { get; set; }

		
    }


}

