using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Requerido
{
    /// <summary>
    /// Requerido table
    /// </summary>
    public class Requerido: BaseEntity
    {
        public int Clave { get; set; }
        public string Nombre { get; set; }
        public int? Solicitud { get; set; }


    }
	
	public class Requerido_Datos_Generales
    {
                public int Clave { get; set; }
        public string Nombre { get; set; }
        public int? Solicitud { get; set; }

		
    }


}

