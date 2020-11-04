using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Solicitante
{
    /// <summary>
    /// Solicitante table
    /// </summary>
    public class Solicitante: BaseEntity
    {
        public int Clave { get; set; }
        public string Nombre { get; set; }
        public int? Solicitud { get; set; }


    }
	
	public class Solicitante_Datos_Generales
    {
                public int Clave { get; set; }
        public string Nombre { get; set; }
        public int? Solicitud { get; set; }

		
    }


}

