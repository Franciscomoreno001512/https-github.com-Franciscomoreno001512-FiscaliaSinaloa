using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Estatus_Servicio_Pericial;
using Spartane.Core.Domain.Modulo_Servicio_Pericial;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Historial_Estatus_Modulo_Servicio_Pericial
{
    /// <summary>
    /// Historial_Estatus_Modulo_Servicio_Pericial table
    /// </summary>
    public class Historial_Estatus_Modulo_Servicio_Pericial: BaseEntity
    {
        public int Clave { get; set; }
        public int? Estatus_Servicio_Pericial { get; set; }
        public DateTime? Fecha_Registro { get; set; }
        public bool? Activo { get; set; }
        public DateTime? Fecha_Cierre { get; set; }
        public int? Modulo_Servicio_Pericial { get; set; }

        [ForeignKey("Estatus_Servicio_Pericial")]
        public virtual Spartane.Core.Domain.Estatus_Servicio_Pericial.Estatus_Servicio_Pericial Estatus_Servicio_Pericial_Estatus_Servicio_Pericial { get; set; }
        [ForeignKey("Modulo_Servicio_Pericial")]
        public virtual Spartane.Core.Domain.Modulo_Servicio_Pericial.Modulo_Servicio_Pericial Modulo_Servicio_Pericial_Modulo_Servicio_Pericial { get; set; }

    }
	
	public class Historial_Estatus_Modulo_Servicio_Pericial_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Estatus_Servicio_Pericial { get; set; }
        public DateTime? Fecha_Registro { get; set; }
        public bool? Activo { get; set; }
        public DateTime? Fecha_Cierre { get; set; }
        public int? Modulo_Servicio_Pericial { get; set; }

		        [ForeignKey("Estatus_Servicio_Pericial")]
        public virtual Spartane.Core.Domain.Estatus_Servicio_Pericial.Estatus_Servicio_Pericial Estatus_Servicio_Pericial_Estatus_Servicio_Pericial { get; set; }
        [ForeignKey("Modulo_Servicio_Pericial")]
        public virtual Spartane.Core.Domain.Modulo_Servicio_Pericial.Modulo_Servicio_Pericial Modulo_Servicio_Pericial_Modulo_Servicio_Pericial { get; set; }

    }


}

