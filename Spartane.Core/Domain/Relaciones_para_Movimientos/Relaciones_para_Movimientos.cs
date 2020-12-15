using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Relaciones_para_Movimientos
{
    /// <summary>
    /// Relaciones_para_Movimientos table
    /// </summary>
    public class Relaciones_para_Movimientos: BaseEntity
    {
        public int ObjectId { get; set; }
        public string Descripcion { get; set; }


    }
	
	public class Relaciones_para_Movimientos_Datos_Generales
    {
                public int ObjectId { get; set; }
        public string Descripcion { get; set; }

		
    }


}

