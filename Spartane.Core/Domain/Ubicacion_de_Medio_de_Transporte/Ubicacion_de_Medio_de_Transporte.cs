using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Ubicacion_de_Medio_de_Transporte
{
    /// <summary>
    /// Ubicacion_de_Medio_de_Transporte table
    /// </summary>
    public class Ubicacion_de_Medio_de_Transporte: BaseEntity
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }


    }
	
	public class Ubicacion_de_Medio_de_Transporte_Datos_Generales
    {
                public int Clave { get; set; }
        public string Descripcion { get; set; }

		
    }


}

