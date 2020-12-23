using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Tipo_de_Orden
{
    /// <summary>
    /// Tipo_de_Orden table
    /// </summary>
    public class Tipo_de_Orden: BaseEntity
    {
        public int Clave { get; set; }
        public string Tipo_de_Ordenx { get; set; }


    }
	
	public class Tipo_de_Orden_Datos_Generales
    {
                public int Clave { get; set; }
        public string Tipo_de_Ordenx { get; set; }

		
    }


}

