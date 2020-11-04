using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Catalogo_Estatus_CC
{
    /// <summary>
    /// Catalogo_Estatus_CC table
    /// </summary>
    public class Catalogo_Estatus_CC: BaseEntity
    {
        public int Clave { get; set; }
        public string Estatus { get; set; }


    }
	
	public class Catalogo_Estatus_CC_Datos_Generales
    {
                public int Clave { get; set; }
        public string Estatus { get; set; }

		
    }


}

