using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Compareciente
{
    /// <summary>
    /// Compareciente table
    /// </summary>
    public class Compareciente: BaseEntity
    {
        public int Clave { get; set; }
        public string Nombre_Completo { get; set; }
        public int? Registro_de_Atencion_Inicial { get; set; }


    }
	
	public class Compareciente_Datos_Generales
    {
                public int Clave { get; set; }
        public string Nombre_Completo { get; set; }
        public int? Registro_de_Atencion_Inicial { get; set; }

		
    }


}

