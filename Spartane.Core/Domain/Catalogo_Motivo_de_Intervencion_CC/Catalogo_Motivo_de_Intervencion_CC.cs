using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Catalogo_Motivo_de_Intervencion_CC
{
    /// <summary>
    /// Catalogo_Motivo_de_Intervencion_CC table
    /// </summary>
    public class Catalogo_Motivo_de_Intervencion_CC: BaseEntity
    {
        public int Clave { get; set; }         public string Descripcion { get; set; } 

    }
	
	public class Catalogo_Motivo_de_Intervencion_CC_Datos_Generales
    {
                public int Clave { get; set; }
        public string Descripcion { get; set; }

		
    }


}

