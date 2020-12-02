using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Aparato_Electronicos_y_Multimedia
{
    /// <summary>
    /// Aparato_Electronicos_y_Multimedia table
    /// </summary>
    public class Aparato_Electronicos_y_Multimedia: BaseEntity
    {
        public short Clave { get; set; }
        public string Descripcion { get; set; }


    }
	
	public class Aparato_Electronicos_y_Multimedia_Datos_Generales
    {
                public short Clave { get; set; }
        public string Descripcion { get; set; }

		
    }


}

