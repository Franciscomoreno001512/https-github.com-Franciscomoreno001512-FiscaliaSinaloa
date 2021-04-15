using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Area_envia_Cumplimiento
{
    /// <summary>
    /// Area_envia_Cumplimiento table
    /// </summary>
    public class Area_envia_Cumplimiento: BaseEntity
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public bool? Vigente { get; set; }


    }
	
	public class Area_envia_Cumplimiento_Datos_Generales
    {
                public int Clave { get; set; }
        public string Descripcion { get; set; }
        public bool? Vigente { get; set; }

		
    }


}

