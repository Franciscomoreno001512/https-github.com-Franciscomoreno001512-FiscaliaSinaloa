using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Asignacion_responsable_servicios_apoyo;
using Spartane.Core.Domain.SubArea_de_Servicios_de_Apoyo;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_subareas_responsable_servicio_apoyo
{
    /// <summary>
    /// Detalle_subareas_responsable_servicio_apoyo table
    /// </summary>
    public class Detalle_subareas_responsable_servicio_apoyo: BaseEntity
    {
        public int Clave { get; set; }
        public int? Asignacion { get; set; }
        public int? SubArea_Asignada { get; set; }

        [ForeignKey("Asignacion")]
        public virtual Spartane.Core.Domain.Asignacion_responsable_servicios_apoyo.Asignacion_responsable_servicios_apoyo Asignacion_Asignacion_responsable_servicios_apoyo { get; set; }
        [ForeignKey("SubArea_Asignada")]
        public virtual Spartane.Core.Domain.SubArea_de_Servicios_de_Apoyo.SubArea_de_Servicios_de_Apoyo SubArea_Asignada_SubArea_de_Servicios_de_Apoyo { get; set; }

    }
	
	public class Detalle_subareas_responsable_servicio_apoyo_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Asignacion { get; set; }
        public int? SubArea_Asignada { get; set; }

		        [ForeignKey("Asignacion")]
        public virtual Spartane.Core.Domain.Asignacion_responsable_servicios_apoyo.Asignacion_responsable_servicios_apoyo Asignacion_Asignacion_responsable_servicios_apoyo { get; set; }
        [ForeignKey("SubArea_Asignada")]
        public virtual Spartane.Core.Domain.SubArea_de_Servicios_de_Apoyo.SubArea_de_Servicios_de_Apoyo SubArea_Asignada_SubArea_de_Servicios_de_Apoyo { get; set; }

    }


}

