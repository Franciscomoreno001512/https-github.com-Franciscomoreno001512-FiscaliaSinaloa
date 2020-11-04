using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Requeridos_que_no_Asisten
{
    /// <summary>
    /// Requeridos_que_no_Asisten table
    /// </summary>
    public class Requeridos_que_no_Asisten: BaseEntity
    {
        public int Clave { get; set; }
        public string Requeridos { get; set; }
        public string Solicitud { get; set; }


    }
	
	public class Requeridos_que_no_Asisten_Datos_Generales
    {
                public int Clave { get; set; }
        public string Requeridos { get; set; }
        public string Solicitud { get; set; }

		
    }


}

