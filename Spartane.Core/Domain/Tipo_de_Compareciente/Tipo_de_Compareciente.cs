using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Tipo_de_Compareciente
{
    /// <summary>
    /// Tipo_de_Compareciente table
    /// </summary>
    public class Tipo_de_Compareciente: BaseEntity
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public string TP_DescripcionCorta { get; set; }


    }
	
	public class Tipo_de_Compareciente_Datos_Generales
    {
                public int Clave { get; set; }
        public string Descripcion { get; set; }
        public string TP_DescripcionCorta { get; set; }

		
    }


}

