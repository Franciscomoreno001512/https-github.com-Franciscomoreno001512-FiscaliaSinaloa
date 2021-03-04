using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Configuracion_de_Servicios_de_Apoyo;
using Spartane.Core.Domain.Documento;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_Solicitud_Disponibles_Configuracion
{
    /// <summary>
    /// Detalle_Solicitud_Disponibles_Configuracion table
    /// </summary>
    public class Detalle_Solicitud_Disponibles_Configuracion: BaseEntity
    {
        public int Clave { get; set; }
        public int? Configuracion { get; set; }
        public int? Documento { get; set; }

        [ForeignKey("Configuracion")]
        public virtual Spartane.Core.Domain.Configuracion_de_Servicios_de_Apoyo.Configuracion_de_Servicios_de_Apoyo Configuracion_Configuracion_de_Servicios_de_Apoyo { get; set; }
        [ForeignKey("Documento")]
        public virtual Spartane.Core.Domain.Documento.Documento Documento_Documento { get; set; }

    }
	
	public class Detalle_Solicitud_Disponibles_Configuracion_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Configuracion { get; set; }
        public int? Documento { get; set; }

		        [ForeignKey("Configuracion")]
        public virtual Spartane.Core.Domain.Configuracion_de_Servicios_de_Apoyo.Configuracion_de_Servicios_de_Apoyo Configuracion_Configuracion_de_Servicios_de_Apoyo { get; set; }
        [ForeignKey("Documento")]
        public virtual Spartane.Core.Domain.Documento.Documento Documento_Documento { get; set; }

    }


}

