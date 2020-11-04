using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Solicitud;
using Spartane.Core.Domain.Nombre_Comparecencia;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Solicitudes_de_Comparecencia
{
    /// <summary>
    /// Detalle_de_Solicitudes_de_Comparecencia table
    /// </summary>
    public class Detalle_de_Solicitudes_de_Comparecencia: BaseEntity
    {
        public int Clave { get; set; }
        public short? Archivo { get; set; }
        public int? Solicitud { get; set; }
        public int? Nombre { get; set; }
        public DateTime? Fecha_de_la_Comparecencia { get; set; }
        public string Hora_de_la_Comparecencia { get; set; }

        [ForeignKey("Solicitud")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Solicitud_Solicitud { get; set; }
        [ForeignKey("Nombre")]
        public virtual Spartane.Core.Domain.Nombre_Comparecencia.Nombre_Comparecencia Nombre_Nombre_Comparecencia { get; set; }

    }
	
	public class Detalle_de_Solicitudes_de_Comparecencia_Datos_Generales
    {
                public int Clave { get; set; }
        public short? Archivo { get; set; }
        public int? Solicitud { get; set; }
        public int? Nombre { get; set; }
        public DateTime? Fecha_de_la_Comparecencia { get; set; }
        public string Hora_de_la_Comparecencia { get; set; }

		        [ForeignKey("Solicitud")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Solicitud_Solicitud { get; set; }
        [ForeignKey("Nombre")]
        public virtual Spartane.Core.Domain.Nombre_Comparecencia.Nombre_Comparecencia Nombre_Nombre_Comparecencia { get; set; }

    }


}

