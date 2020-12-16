using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.SubTipo_de_Medida_de_Proteccion
{
    /// <summary>
    /// SubTipo_de_Medida_de_Proteccion table
    /// </summary>
    public class SubTipo_de_Medida_de_Proteccion: BaseEntity
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }


    }
	
	public class SubTipo_de_Medida_de_Proteccion_Datos_Generales
    {
                public int Clave { get; set; }
        public string Descripcion { get; set; }

		
    }


}

