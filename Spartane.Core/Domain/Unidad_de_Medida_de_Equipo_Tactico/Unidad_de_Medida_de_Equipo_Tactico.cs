using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Unidad_de_Medida_de_Equipo_Tactico
{
    /// <summary>
    /// Unidad_de_Medida_de_Equipo_Tactico table
    /// </summary>
    public class Unidad_de_Medida_de_Equipo_Tactico: BaseEntity
    {
        public short Clave { get; set; }
        public string Descripcion { get; set; }


    }
	
	public class Unidad_de_Medida_de_Equipo_Tactico_Datos_Generales
    {
                public short Clave { get; set; }
        public string Descripcion { get; set; }

		
    }


}

