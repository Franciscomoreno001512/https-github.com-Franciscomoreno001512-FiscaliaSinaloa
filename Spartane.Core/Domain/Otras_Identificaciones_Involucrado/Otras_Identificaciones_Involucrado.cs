using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Datos_Generales;
using Spartane.Core.Domain.Tipo_de_Identificacion;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Otras_Identificaciones_Involucrado
{
    /// <summary>
    /// Otras_Identificaciones_Involucrado table
    /// </summary>
    public class Otras_Identificaciones_Involucrado: BaseEntity
    {
        public int Clave { get; set; }
        public int? Involucrado { get; set; }
        public int? Tipo_de_identificacion { get; set; }
        public string Descripcion { get; set; }

        [ForeignKey("Involucrado")]
        public virtual Spartane.Core.Domain.Detalle_de_Datos_Generales.Detalle_de_Datos_Generales Involucrado_Detalle_de_Datos_Generales { get; set; }
        [ForeignKey("Tipo_de_identificacion")]
        public virtual Spartane.Core.Domain.Tipo_de_Identificacion.Tipo_de_Identificacion Tipo_de_identificacion_Tipo_de_Identificacion { get; set; }

    }
	
	public class Otras_Identificaciones_Involucrado_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Involucrado { get; set; }
        public int? Tipo_de_identificacion { get; set; }
        public string Descripcion { get; set; }

		        [ForeignKey("Involucrado")]
        public virtual Spartane.Core.Domain.Detalle_de_Datos_Generales.Detalle_de_Datos_Generales Involucrado_Detalle_de_Datos_Generales { get; set; }
        [ForeignKey("Tipo_de_identificacion")]
        public virtual Spartane.Core.Domain.Tipo_de_Identificacion.Tipo_de_Identificacion Tipo_de_identificacion_Tipo_de_Identificacion { get; set; }

    }


}

