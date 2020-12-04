using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Resultado_de_Audiencia_Intermedia
{
    /// <summary>
    /// Resultado_de_Audiencia_Intermedia table
    /// </summary>
    public class Resultado_de_Audiencia_Intermedia: BaseEntity
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }


    }
	
	public class Resultado_de_Audiencia_Intermedia_Datos_Generales
    {
                public int Clave { get; set; }
        public string Descripcion { get; set; }

		
    }


}

