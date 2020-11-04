using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Requeridos_que_no_Asisten;
using Spartane.Core.Domain.Solicitud;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Requeridos_Faltantes
{
    /// <summary>
    /// Detalle_de_Requeridos_Faltantes table
    /// </summary>
    public class Detalle_de_Requeridos_Faltantes: BaseEntity
    {
        public int Clave { get; set; }
        public int? Requerido { get; set; }
        public int? Solicitud { get; set; }

        [ForeignKey("Requerido")]
        public virtual Spartane.Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten Requerido_Requeridos_que_no_Asisten { get; set; }
        [ForeignKey("Solicitud")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Solicitud_Solicitud { get; set; }

    }
	
	public class Detalle_de_Requeridos_Faltantes_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Requerido { get; set; }
        public int? Solicitud { get; set; }

		        [ForeignKey("Requerido")]
        public virtual Spartane.Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten Requerido_Requeridos_que_no_Asisten { get; set; }
        [ForeignKey("Solicitud")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Solicitud_Solicitud { get; set; }

    }


}

