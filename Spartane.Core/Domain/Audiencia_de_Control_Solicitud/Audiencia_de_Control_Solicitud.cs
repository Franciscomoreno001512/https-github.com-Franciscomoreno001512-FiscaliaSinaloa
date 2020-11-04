using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Audiencia_de_Control_Solicitud
{
    /// <summary>
    /// Audiencia_de_Control_Solicitud table
    /// </summary>
    public class Audiencia_de_Control_Solicitud: BaseEntity
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; } 

    }
	
	public class Audiencia_de_Control_Solicitud_Datos_Generales
    {
                public int Clave { get; set; }
        public string Descripcion { get; set; } 
		
    }


}

