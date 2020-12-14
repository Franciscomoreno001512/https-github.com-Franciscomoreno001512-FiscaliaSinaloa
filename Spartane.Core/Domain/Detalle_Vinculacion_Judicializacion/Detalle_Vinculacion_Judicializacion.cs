using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Judicializacion;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_Vinculacion_Judicializacion
{
    /// <summary>
    /// Detalle_Vinculacion_Judicializacion table
    /// </summary>
    public class Detalle_Vinculacion_Judicializacion: BaseEntity
    {
        public int Clave { get; set; }
        public int? Judicializacion { get; set; }
        public string Relacion { get; set; }

        [ForeignKey("Judicializacion")]
        public virtual Spartane.Core.Domain.Judicializacion.Judicializacion Judicializacion_Judicializacion { get; set; }

    }
	
	public class Detalle_Vinculacion_Judicializacion_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Judicializacion { get; set; }
        public string Relacion { get; set; }

		        [ForeignKey("Judicializacion")]
        public virtual Spartane.Core.Domain.Judicializacion.Judicializacion Judicializacion_Judicializacion { get; set; }

    }


}

