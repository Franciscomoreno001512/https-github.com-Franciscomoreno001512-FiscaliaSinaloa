using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Categoria_de_Servicio_de_Apoyo
{
    /// <summary>
    /// Categoria_de_Servicio_de_Apoyo table
    /// </summary>
    public class Categoria_de_Servicio_de_Apoyo: BaseEntity
    {
        public short Clave { get; set; }
        public string Descripcion { get; set; }


    }
	
	public class Categoria_de_Servicio_de_Apoyo_Datos_Generales
    {
                public short Clave { get; set; }
        public string Descripcion { get; set; }

		
    }


}

