using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Descarga_de_Archivo
{
    /// <summary>
    /// Descarga_de_Archivo table
    /// </summary>
    public class Descarga_de_Archivo: BaseEntity
    {
        public int Clave { get; set; }
        public string Nombre { get; set; }


    }
	
	public class Descarga_de_Archivo_Datos_Generales
    {
                public int Clave { get; set; }
        public string Nombre { get; set; }

		
    }


}

