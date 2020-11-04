using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Estatus_Detalle_Documentos_Legislacion
{
    /// <summary>
    /// Estatus_Detalle_Documentos_Legislacion table
    /// </summary>
    public class Estatus_Detalle_Documentos_Legislacion: BaseEntity
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }


    }
	
	public class Estatus_Detalle_Documentos_Legislacion_Datos_Generales
    {
                public int Clave { get; set; }
        public string Descripcion { get; set; }

		
    }


}

