using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Area_de_Servicios_de_Apoyo
{
    /// <summary>
    /// Area_de_Servicios_de_Apoyo table
    /// </summary>
    public class Area_de_Servicios_de_Apoyo: BaseEntity
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }


    }
	
	public class Area_de_Servicios_de_Apoyo_Datos_Generales
    {
                public int Clave { get; set; }
        public string Descripcion { get; set; }

		
    }


}

