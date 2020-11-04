using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Tipo_de_Expediente
{
    /// <summary>
    /// Tipo_de_Expediente table
    /// </summary>
    public class Tipo_de_Expediente: BaseEntity
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public string Clave_Descripcion { get; set; }


    }
	
	public class Tipo_de_Expediente_Datos_Generales
    {
                public int Clave { get; set; }
        public string Descripcion { get; set; }
        public string Clave_Descripcion { get; set; }

		
    }


}

