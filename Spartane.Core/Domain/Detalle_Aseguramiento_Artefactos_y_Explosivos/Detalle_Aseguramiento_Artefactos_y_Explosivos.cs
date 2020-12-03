using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Aseguramientos;
using Spartane.Core.Domain.Tipo_Clasificacion;
using Spartane.Core.Domain.Tipo_Artefacto;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_Aseguramiento_Artefactos_y_Explosivos
{
    /// <summary>
    /// Detalle_Aseguramiento_Artefactos_y_Explosivos table
    /// </summary>
    public class Detalle_Aseguramiento_Artefactos_y_Explosivos: BaseEntity
    {
        public int Clave { get; set; }
        public int? Aseguramiento { get; set; }
        public int? Clasificacion { get; set; }
        public int? Tipo { get; set; }
        public decimal? Cantidad { get; set; }
        public string Lugar_de_Hallazgo { get; set; }
        public string Observaciones { get; set; }

        [ForeignKey("Aseguramiento")]
        public virtual Spartane.Core.Domain.Aseguramientos.Aseguramientos Aseguramiento_Aseguramientos { get; set; }
        [ForeignKey("Clasificacion")]
        public virtual Spartane.Core.Domain.Tipo_Clasificacion.Tipo_Clasificacion Clasificacion_Tipo_Clasificacion { get; set; }
        [ForeignKey("Tipo")]
        public virtual Spartane.Core.Domain.Tipo_Artefacto.Tipo_Artefacto Tipo_Tipo_Artefacto { get; set; }

    }
	
	public class Detalle_Aseguramiento_Artefactos_y_Explosivos_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Aseguramiento { get; set; }
        public int? Clasificacion { get; set; }
        public int? Tipo { get; set; }
        public decimal? Cantidad { get; set; }
        public string Lugar_de_Hallazgo { get; set; }
        public string Observaciones { get; set; }

		        [ForeignKey("Aseguramiento")]
        public virtual Spartane.Core.Domain.Aseguramientos.Aseguramientos Aseguramiento_Aseguramientos { get; set; }
        [ForeignKey("Clasificacion")]
        public virtual Spartane.Core.Domain.Tipo_Clasificacion.Tipo_Clasificacion Clasificacion_Tipo_Clasificacion { get; set; }
        [ForeignKey("Tipo")]
        public virtual Spartane.Core.Domain.Tipo_Artefacto.Tipo_Artefacto Tipo_Tipo_Artefacto { get; set; }

    }


}

