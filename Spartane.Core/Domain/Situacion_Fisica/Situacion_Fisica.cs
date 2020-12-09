using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Situacion_Fisica
{
    /// <summary>
    /// Situacion_Fisica table
    /// </summary>
    public class Situacion_Fisica: BaseEntity
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Justicia { get; set; }


    }
	
	public class Situacion_Fisica_Datos_Generales
    {
                public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Justicia { get; set; }

		
    }


}

