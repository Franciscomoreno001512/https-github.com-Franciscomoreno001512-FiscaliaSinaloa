using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Aseguramientos;
using Spartane.Core.Domain.Motivo_de_Registro;
using Spartane.Core.Domain.Tipo_de_Pirateria;
using Spartane.Core.Domain.Unidad_de_Medida_de_pirateria;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_Aseguramiento_Pirateria
{
    /// <summary>
    /// Detalle_Aseguramiento_Pirateria table
    /// </summary>
    public class Detalle_Aseguramiento_Pirateria: BaseEntity
    {
        public int Clave { get; set; }
        public int? Aseguramiento { get; set; }
        public int? Motivo_de_Registro { get; set; }
        public short? Tipo { get; set; }
        public string Descripcion { get; set; }
        public decimal? Cantidad { get; set; }
        public short? Unidad_de_Medicion { get; set; }
        public string Observaciones { get; set; }

        [ForeignKey("Aseguramiento")]
        public virtual Spartane.Core.Domain.Aseguramientos.Aseguramientos Aseguramiento_Aseguramientos { get; set; }
        [ForeignKey("Motivo_de_Registro")]
        public virtual Spartane.Core.Domain.Motivo_de_Registro.Motivo_de_Registro Motivo_de_Registro_Motivo_de_Registro { get; set; }
        [ForeignKey("Tipo")]
        public virtual Spartane.Core.Domain.Tipo_de_Pirateria.Tipo_de_Pirateria Tipo_Tipo_de_Pirateria { get; set; }
        [ForeignKey("Unidad_de_Medicion")]
        public virtual Spartane.Core.Domain.Unidad_de_Medida_de_pirateria.Unidad_de_Medida_de_pirateria Unidad_de_Medicion_Unidad_de_Medida_de_pirateria { get; set; }

    }
	
	public class Detalle_Aseguramiento_Pirateria_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Aseguramiento { get; set; }
        public int? Motivo_de_Registro { get; set; }
        public short? Tipo { get; set; }
        public string Descripcion { get; set; }
        public decimal? Cantidad { get; set; }
        public short? Unidad_de_Medicion { get; set; }
        public string Observaciones { get; set; }

		        [ForeignKey("Aseguramiento")]
        public virtual Spartane.Core.Domain.Aseguramientos.Aseguramientos Aseguramiento_Aseguramientos { get; set; }
        [ForeignKey("Motivo_de_Registro")]
        public virtual Spartane.Core.Domain.Motivo_de_Registro.Motivo_de_Registro Motivo_de_Registro_Motivo_de_Registro { get; set; }
        [ForeignKey("Tipo")]
        public virtual Spartane.Core.Domain.Tipo_de_Pirateria.Tipo_de_Pirateria Tipo_Tipo_de_Pirateria { get; set; }
        [ForeignKey("Unidad_de_Medicion")]
        public virtual Spartane.Core.Domain.Unidad_de_Medida_de_pirateria.Unidad_de_Medida_de_pirateria Unidad_de_Medicion_Unidad_de_Medida_de_pirateria { get; set; }

    }


}

