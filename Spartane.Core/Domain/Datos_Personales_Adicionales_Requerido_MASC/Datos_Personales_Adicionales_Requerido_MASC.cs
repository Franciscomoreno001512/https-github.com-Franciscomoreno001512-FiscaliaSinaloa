using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Solicitud_Requerido;
using Spartane.Core.Domain.Redes_Sociales;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Datos_Personales_Adicionales_Requerido_MASC
{
    /// <summary>
    /// Datos_Personales_Adicionales_Requerido_MASC table
    /// </summary>
    public class Datos_Personales_Adicionales_Requerido_MASC: BaseEntity
    {
        public int Clave { get; set; }
        public int? Requerido { get; set; }
        public string Correo_Electronico { get; set; }
        public string Numero_Telefonico { get; set; }
        public int? Redes_Sociales { get; set; }
        public string Observaciones { get; set; }

        [ForeignKey("Requerido")]
        public virtual Spartane.Core.Domain.Detalle_de_Solicitud_Requerido.Detalle_de_Solicitud_Requerido Requerido_Detalle_de_Solicitud_Requerido { get; set; }
        [ForeignKey("Redes_Sociales")]
        public virtual Spartane.Core.Domain.Redes_Sociales.Redes_Sociales Redes_Sociales_Redes_Sociales { get; set; }

    }
	
	public class Datos_Personales_Adicionales_Requerido_MASC_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Requerido { get; set; }
        public string Correo_Electronico { get; set; }
        public string Numero_Telefonico { get; set; }
        public int? Redes_Sociales { get; set; }
        public string Observaciones { get; set; }

		        [ForeignKey("Requerido")]
        public virtual Spartane.Core.Domain.Detalle_de_Solicitud_Requerido.Detalle_de_Solicitud_Requerido Requerido_Detalle_de_Solicitud_Requerido { get; set; }
        [ForeignKey("Redes_Sociales")]
        public virtual Spartane.Core.Domain.Redes_Sociales.Redes_Sociales Redes_Sociales_Redes_Sociales { get; set; }

    }


}

