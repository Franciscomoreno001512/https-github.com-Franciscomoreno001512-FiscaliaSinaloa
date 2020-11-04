using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Historial_de_Conversacion;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Mensaje_de_Historial
{
    /// <summary>
    /// Detalle_de_Mensaje_de_Historial table
    /// </summary>
    public class Detalle_de_Mensaje_de_Historial: BaseEntity
    {
        public int Clave { get; set; }
        public int? Historial_de_Conversacion { get; set; }
        public string Hora { get; set; }
        public string Mensaje { get; set; }

        [ForeignKey("Historial_de_Conversacion")]
        public virtual Spartane.Core.Domain.Historial_de_Conversacion.Historial_de_Conversacion Historial_de_Conversacion_Historial_de_Conversacion { get; set; }

    }
	
	public class Detalle_de_Mensaje_de_Historial_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Historial_de_Conversacion { get; set; }
        public string Hora { get; set; }
        public string Mensaje { get; set; }

		        [ForeignKey("Historial_de_Conversacion")]
        public virtual Spartane.Core.Domain.Historial_de_Conversacion.Historial_de_Conversacion Historial_de_Conversacion_Historial_de_Conversacion { get; set; }

    }


}

