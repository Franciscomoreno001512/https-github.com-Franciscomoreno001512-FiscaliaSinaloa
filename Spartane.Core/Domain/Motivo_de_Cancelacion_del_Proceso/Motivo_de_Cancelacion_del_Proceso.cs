using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Motivo_de_Cancelacion_del_Proceso
{
    /// <summary>
    /// Motivo_de_Cancelacion_del_Proceso table
    /// </summary>
    public class Motivo_de_Cancelacion_del_Proceso: BaseEntity
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }


    }
	
	public class Motivo_de_Cancelacion_del_Proceso_Datos_Generales
    {
                public int Clave { get; set; }
        public string Descripcion { get; set; }

		
    }


}

