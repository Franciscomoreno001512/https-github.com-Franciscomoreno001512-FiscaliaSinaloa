using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Calendario_de_Citas
{
    /// <summary>
    /// Calendario_de_Citas table
    /// </summary>
    public class Calendario_de_Citas: BaseEntity
    {
        public int Clave { get; set; }
        public short? Pertenece_a { get; set; }


    }
	
	public class Calendario_de_Citas_Datos_Generales
    {
                public int Clave { get; set; }
        public short? Pertenece_a { get; set; }

		
    }


}

