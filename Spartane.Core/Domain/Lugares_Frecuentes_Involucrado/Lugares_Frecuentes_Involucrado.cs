using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Datos_Generales;
using Spartane.Core.Domain.Lugares;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Lugares_Frecuentes_Involucrado
{
    /// <summary>
    /// Lugares_Frecuentes_Involucrado table
    /// </summary>
    public class Lugares_Frecuentes_Involucrado: BaseEntity
    {
        public int Clave { get; set; }
        public int? Involucrado { get; set; }
        public int? Tipo_de_Lugar { get; set; }
        public string Descripcion { get; set; }

        [ForeignKey("Involucrado")]
        public virtual Spartane.Core.Domain.Detalle_de_Datos_Generales.Detalle_de_Datos_Generales Involucrado_Detalle_de_Datos_Generales { get; set; }
        [ForeignKey("Tipo_de_Lugar")]
        public virtual Spartane.Core.Domain.Lugares.Lugares Tipo_de_Lugar_Lugares { get; set; }

    }
	
	public class Lugares_Frecuentes_Involucrado_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Involucrado { get; set; }
        public int? Tipo_de_Lugar { get; set; }
        public string Descripcion { get; set; }

		        [ForeignKey("Involucrado")]
        public virtual Spartane.Core.Domain.Detalle_de_Datos_Generales.Detalle_de_Datos_Generales Involucrado_Detalle_de_Datos_Generales { get; set; }
        [ForeignKey("Tipo_de_Lugar")]
        public virtual Spartane.Core.Domain.Lugares.Lugares Tipo_de_Lugar_Lugares { get; set; }

    }


}

