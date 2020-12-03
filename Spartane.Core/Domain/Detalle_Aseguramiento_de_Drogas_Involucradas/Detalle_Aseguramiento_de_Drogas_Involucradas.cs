using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Aseguramientos;
using Spartane.Core.Domain.Tipo_de_Droga;
using Spartane.Core.Domain.Unidad_de_medida_de_tipo_de_droga;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_Aseguramiento_de_Drogas_Involucradas
{
    /// <summary>
    /// Detalle_Aseguramiento_de_Drogas_Involucradas table
    /// </summary>
    public class Detalle_Aseguramiento_de_Drogas_Involucradas: BaseEntity
    {
        public int Clave { get; set; }
        public int? Aseguramiento { get; set; }
        public short? Tipo { get; set; }
        public short? Unidad_de_Medida { get; set; }
        public decimal? Cantidad { get; set; }
        public string Observaciones { get; set; }

        [ForeignKey("Aseguramiento")]
        public virtual Spartane.Core.Domain.Aseguramientos.Aseguramientos Aseguramiento_Aseguramientos { get; set; }
        [ForeignKey("Tipo")]
        public virtual Spartane.Core.Domain.Tipo_de_Droga.Tipo_de_Droga Tipo_Tipo_de_Droga { get; set; }
        [ForeignKey("Unidad_de_Medida")]
        public virtual Spartane.Core.Domain.Unidad_de_medida_de_tipo_de_droga.Unidad_de_medida_de_tipo_de_droga Unidad_de_Medida_Unidad_de_medida_de_tipo_de_droga { get; set; }

    }
	
	public class Detalle_Aseguramiento_de_Drogas_Involucradas_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Aseguramiento { get; set; }
        public short? Tipo { get; set; }
        public short? Unidad_de_Medida { get; set; }
        public decimal? Cantidad { get; set; }
        public string Observaciones { get; set; }

		        [ForeignKey("Aseguramiento")]
        public virtual Spartane.Core.Domain.Aseguramientos.Aseguramientos Aseguramiento_Aseguramientos { get; set; }
        [ForeignKey("Tipo")]
        public virtual Spartane.Core.Domain.Tipo_de_Droga.Tipo_de_Droga Tipo_Tipo_de_Droga { get; set; }
        [ForeignKey("Unidad_de_Medida")]
        public virtual Spartane.Core.Domain.Unidad_de_medida_de_tipo_de_droga.Unidad_de_medida_de_tipo_de_droga Unidad_de_Medida_Unidad_de_medida_de_tipo_de_droga { get; set; }

    }


}

