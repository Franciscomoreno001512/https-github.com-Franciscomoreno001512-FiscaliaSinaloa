using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Datos_Generales;
using Spartane.Core.Domain.Redes_Sociales;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Datos_Personales_Adicionales_Involucrado
{
    /// <summary>
    /// Datos_Personales_Adicionales_Involucrado table
    /// </summary>
    public class Datos_Personales_Adicionales_Involucrado: BaseEntity
    {
        public int Clave { get; set; }
        public int? Involucrado { get; set; }
        public string Correo_Electronico { get; set; }
        public string Numero_Telefonico { get; set; }
        public int? Redes_Sociales { get; set; }
        public string Observaciones { get; set; }

        [ForeignKey("Involucrado")]
        public virtual Spartane.Core.Domain.Detalle_de_Datos_Generales.Detalle_de_Datos_Generales Involucrado_Detalle_de_Datos_Generales { get; set; }
        [ForeignKey("Redes_Sociales")]
        public virtual Spartane.Core.Domain.Redes_Sociales.Redes_Sociales Redes_Sociales_Redes_Sociales { get; set; }

    }
	
	public class Datos_Personales_Adicionales_Involucrado_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Involucrado { get; set; }
        public string Correo_Electronico { get; set; }
        public string Numero_Telefonico { get; set; }
        public int? Redes_Sociales { get; set; }
        public string Observaciones { get; set; }

		        [ForeignKey("Involucrado")]
        public virtual Spartane.Core.Domain.Detalle_de_Datos_Generales.Detalle_de_Datos_Generales Involucrado_Detalle_de_Datos_Generales { get; set; }
        [ForeignKey("Redes_Sociales")]
        public virtual Spartane.Core.Domain.Redes_Sociales.Redes_Sociales Redes_Sociales_Redes_Sociales { get; set; }

    }


}

