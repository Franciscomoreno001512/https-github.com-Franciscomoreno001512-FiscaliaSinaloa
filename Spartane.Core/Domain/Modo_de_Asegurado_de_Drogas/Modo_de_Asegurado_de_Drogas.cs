using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Modo_de_Asegurado_de_Drogas
{
    /// <summary>
    /// Modo_de_Asegurado_de_Drogas table
    /// </summary>
    public class Modo_de_Asegurado_de_Drogas: BaseEntity
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }


    }
	
	public class Modo_de_Asegurado_de_Drogas_Datos_Generales
    {
                public int Clave { get; set; }
        public string Descripcion { get; set; }

		
    }


}

