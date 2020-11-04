using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Audiencia_de_Control_Reiteracion
{
    /// <summary>
    /// Audiencia_de_Control_Reiteracion table
    /// </summary>
    public class Audiencia_de_Control_Reiteracion: BaseEntity
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }


    }
	
	public class Audiencia_de_Control_Reiteracion_Datos_Generales
    {
                public int Clave { get; set; }
        public string Descripcion { get; set; }

		
    }


}

