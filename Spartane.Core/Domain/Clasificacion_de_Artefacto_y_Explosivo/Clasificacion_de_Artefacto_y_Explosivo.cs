using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Clasificacion_de_Artefacto_y_Explosivo
{
    /// <summary>
    /// Clasificacion_de_Artefacto_y_Explosivo table
    /// </summary>
    public class Clasificacion_de_Artefacto_y_Explosivo: BaseEntity
    {
        public short Clave { get; set; }
        public string Descripcion { get; set; }


    }
	
	public class Clasificacion_de_Artefacto_y_Explosivo_Datos_Generales
    {
                public short Clave { get; set; }
        public string Descripcion { get; set; }

		
    }


}

