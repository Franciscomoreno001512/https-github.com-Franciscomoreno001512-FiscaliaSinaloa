using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Aseguramientos;
using Spartane.Core.Domain.Motivo_de_Registro;
using Spartane.Core.Domain.Clasificacion_de_Artefacto_y_Explosivo;

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
        public int? Motivo_de_Registro { get; set; }
        public short? Clasificacion { get; set; }
        public decimal? Cantidad { get; set; }
        public string Lugar_de_Hallazgo { get; set; }
        public string Observaciones { get; set; }

        [ForeignKey("Aseguramiento")]
        public virtual Spartane.Core.Domain.Aseguramientos.Aseguramientos Aseguramiento_Aseguramientos { get; set; }
        [ForeignKey("Motivo_de_Registro")]
        public virtual Spartane.Core.Domain.Motivo_de_Registro.Motivo_de_Registro Motivo_de_Registro_Motivo_de_Registro { get; set; }
        [ForeignKey("Clasificacion")]
        public virtual Spartane.Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo Clasificacion_Clasificacion_de_Artefacto_y_Explosivo { get; set; }

    }
	
	public class Detalle_Aseguramiento_Artefactos_y_Explosivos_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Aseguramiento { get; set; }
        public int? Motivo_de_Registro { get; set; }
        public short? Clasificacion { get; set; }
        public decimal? Cantidad { get; set; }
        public string Lugar_de_Hallazgo { get; set; }
        public string Observaciones { get; set; }

		        [ForeignKey("Aseguramiento")]
        public virtual Spartane.Core.Domain.Aseguramientos.Aseguramientos Aseguramiento_Aseguramientos { get; set; }
        [ForeignKey("Motivo_de_Registro")]
        public virtual Spartane.Core.Domain.Motivo_de_Registro.Motivo_de_Registro Motivo_de_Registro_Motivo_de_Registro { get; set; }
        [ForeignKey("Clasificacion")]
        public virtual Spartane.Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo Clasificacion_Clasificacion_de_Artefacto_y_Explosivo { get; set; }

    }


}

