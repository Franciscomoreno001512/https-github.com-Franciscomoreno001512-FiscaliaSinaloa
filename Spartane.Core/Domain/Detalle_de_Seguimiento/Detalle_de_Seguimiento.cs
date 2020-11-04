using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Tipo_de_Seguimiento;
using Spartane.Core.Domain.Solicitud;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Seguimiento
{
    /// <summary>
    /// Detalle_de_Seguimiento table
    /// </summary>
    public class Detalle_de_Seguimiento: BaseEntity
    {
        public int Clave { get; set; }
        public string Especialista { get; set; }
        public string Solicitante { get; set; }
        public string Requerido { get; set; }
        public short? Archivo { get; set; }
        public string Observaciones { get; set; }
        public string Cumplimiento { get; set; }
        public int? Tipo_de_Seguimiento { get; set; }
        public decimal? Cantidad_del_Monto { get; set; }
        public DateTime? Fecha_de_Cumplimiento { get; set; }
        public int? Solicitud { get; set; }

        [ForeignKey("Tipo_de_Seguimiento")]
        public virtual Spartane.Core.Domain.Tipo_de_Seguimiento.Tipo_de_Seguimiento Tipo_de_Seguimiento_Tipo_de_Seguimiento { get; set; }
        [ForeignKey("Solicitud")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Solicitud_Solicitud { get; set; }

    }
	
	public class Detalle_de_Seguimiento_Datos_Generales
    {
                public int Clave { get; set; }
        public string Especialista { get; set; }
        public string Solicitante { get; set; }
        public string Requerido { get; set; }
        public short? Archivo { get; set; }
        public string Observaciones { get; set; }
        public string Cumplimiento { get; set; }
        public int? Tipo_de_Seguimiento { get; set; }
        public decimal? Cantidad_del_Monto { get; set; }
        public DateTime? Fecha_de_Cumplimiento { get; set; }
        public int? Solicitud { get; set; }

		        [ForeignKey("Tipo_de_Seguimiento")]
        public virtual Spartane.Core.Domain.Tipo_de_Seguimiento.Tipo_de_Seguimiento Tipo_de_Seguimiento_Tipo_de_Seguimiento { get; set; }
        [ForeignKey("Solicitud")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Solicitud_Solicitud { get; set; }

    }


}

