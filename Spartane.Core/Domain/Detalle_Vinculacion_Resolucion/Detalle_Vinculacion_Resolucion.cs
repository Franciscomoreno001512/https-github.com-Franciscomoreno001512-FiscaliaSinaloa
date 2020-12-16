using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Resolucion_MP;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_Vinculacion_Resolucion
{
    /// <summary>
    /// Detalle_Vinculacion_Resolucion table
    /// </summary>
    public class Detalle_Vinculacion_Resolucion: BaseEntity
    {
        public int Clave { get; set; }
        public int? Resolucion { get; set; }
        public bool? Seleccionar { get; set; }
        public string Relacion { get; set; }
        public int? idRelacion { get; set; }

        [ForeignKey("Resolucion")]
        public virtual Spartane.Core.Domain.Resolucion_MP.Resolucion_MP Resolucion_Resolucion_MP { get; set; }

    }
	
	public class Detalle_Vinculacion_Resolucion_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Resolucion { get; set; }
        public bool? Seleccionar { get; set; }
        public string Relacion { get; set; }
        public int? idRelacion { get; set; }

		        [ForeignKey("Resolucion")]
        public virtual Spartane.Core.Domain.Resolucion_MP.Resolucion_MP Resolucion_Resolucion_MP { get; set; }

    }


}

