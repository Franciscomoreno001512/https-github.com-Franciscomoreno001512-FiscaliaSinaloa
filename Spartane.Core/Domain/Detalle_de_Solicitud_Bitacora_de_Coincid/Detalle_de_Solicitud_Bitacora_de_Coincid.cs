using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Solicitud;
using Spartane.Core.Domain.Tipo_de_Acuerdo;
using Spartane.Core.Domain.Razon_de_Incumplimiento;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Solicitud_Bitacora_de_Coincid
{
    /// <summary>
    /// Detalle_de_Solicitud_Bitacora_de_Coincid table
    /// </summary>
    public class Detalle_de_Solicitud_Bitacora_de_Coincid: BaseEntity
    {
        public int Clave { get; set; }
        public string Nombre_Completo { get; set; }
        public string Alias { get; set; }
        public string Numero_de_Expediente { get; set; }
        public string Fuente_de_Origen { get; set; }
        public int? Solicitud { get; set; }
        public int? Tipo_de_Acuerdo { get; set; }
        public bool? Cumplido { get; set; }
        public int? Razon_de_Incumplimiento { get; set; }
        public string Observaciones { get; set; }

        [ForeignKey("Solicitud")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Solicitud_Solicitud { get; set; }
        [ForeignKey("Tipo_de_Acuerdo")]
        public virtual Spartane.Core.Domain.Tipo_de_Acuerdo.Tipo_de_Acuerdo Tipo_de_Acuerdo_Tipo_de_Acuerdo { get; set; }
        [ForeignKey("Razon_de_Incumplimiento")]
        public virtual Spartane.Core.Domain.Razon_de_Incumplimiento.Razon_de_Incumplimiento Razon_de_Incumplimiento_Razon_de_Incumplimiento { get; set; }

    }
	
	public class Detalle_de_Solicitud_Bitacora_de_Coincid_Datos_Generales
    {
                public int Clave { get; set; }
        public string Nombre_Completo { get; set; }
        public string Alias { get; set; }
        public string Numero_de_Expediente { get; set; }
        public string Fuente_de_Origen { get; set; }
        public int? Solicitud { get; set; }
        public int? Tipo_de_Acuerdo { get; set; }
        public bool? Cumplido { get; set; }
        public int? Razon_de_Incumplimiento { get; set; }
        public string Observaciones { get; set; }

		        [ForeignKey("Solicitud")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Solicitud_Solicitud { get; set; }
        [ForeignKey("Tipo_de_Acuerdo")]
        public virtual Spartane.Core.Domain.Tipo_de_Acuerdo.Tipo_de_Acuerdo Tipo_de_Acuerdo_Tipo_de_Acuerdo { get; set; }
        [ForeignKey("Razon_de_Incumplimiento")]
        public virtual Spartane.Core.Domain.Razon_de_Incumplimiento.Razon_de_Incumplimiento Razon_de_Incumplimiento_Razon_de_Incumplimiento { get; set; }

    }


}

