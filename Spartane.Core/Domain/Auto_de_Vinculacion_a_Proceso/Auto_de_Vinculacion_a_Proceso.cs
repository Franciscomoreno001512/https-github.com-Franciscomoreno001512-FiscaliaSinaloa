using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Auto_de_Vinculacion_a_Proceso
{
    /// <summary>
    /// Auto_de_Vinculacion_a_Proceso table
    /// </summary>
    public class Auto_de_Vinculacion_a_Proceso: BaseEntity
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }


    }
	
	public class Auto_de_Vinculacion_a_Proceso_Datos_Generales
    {
                public int Clave { get; set; }
        public string Descripcion { get; set; }

		
    }


}

