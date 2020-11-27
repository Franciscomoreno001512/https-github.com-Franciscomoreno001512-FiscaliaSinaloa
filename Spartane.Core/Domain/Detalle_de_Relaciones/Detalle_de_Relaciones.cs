using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Modulo_Atencion_Inicial;
using Spartane.Core.Domain.expediente_ministerio_publico;
using Spartane.Core.Domain.Detalle_de_Datos_Generales;
using Spartane.Core.Domain.Detalle_de_Imputado;
using Spartane.Core.Domain.Delito;
using Spartane.Core.Domain.Binario;
using Spartane.Core.Domain.Parentesco;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Relaciones
{
    /// <summary>
    /// Detalle_de_Relaciones table
    /// </summary>
    public class Detalle_de_Relaciones: BaseEntity
    {
        public int Clave { get; set; }
        public int? Modulo_Atencion_Inicial { get; set; }
        public int? Expediente_MP { get; set; }
        public int? Involucrado { get; set; }
        public int? Probable_Responsable { get; set; }
        public int? Delito { get; set; }
        public int? Es_Familiar { get; set; }
        public int? Parentesco { get; set; }

        [ForeignKey("Modulo_Atencion_Inicial")]
        public virtual Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial Modulo_Atencion_Inicial_Modulo_Atencion_Inicial { get; set; }
        [ForeignKey("Expediente_MP")]
        public virtual Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico Expediente_MP_expediente_ministerio_publico { get; set; }
        [ForeignKey("Involucrado")]
        public virtual Spartane.Core.Domain.Detalle_de_Datos_Generales.Detalle_de_Datos_Generales Involucrado_Detalle_de_Datos_Generales { get; set; }
        [ForeignKey("Probable_Responsable")]
        public virtual Spartane.Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado Probable_Responsable_Detalle_de_Imputado { get; set; }
        [ForeignKey("Delito")]
        public virtual Spartane.Core.Domain.Delito.Delito Delito_Delito { get; set; }
        [ForeignKey("Es_Familiar")]
        public virtual Spartane.Core.Domain.Binario.Binario Es_Familiar_Binario { get; set; }
        [ForeignKey("Parentesco")]
        public virtual Spartane.Core.Domain.Parentesco.Parentesco Parentesco_Parentesco { get; set; }

    }
	
	public class Detalle_de_Relaciones_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Modulo_Atencion_Inicial { get; set; }
        public int? Expediente_MP { get; set; }
        public int? Involucrado { get; set; }
        public int? Probable_Responsable { get; set; }
        public int? Delito { get; set; }
        public int? Es_Familiar { get; set; }
        public int? Parentesco { get; set; }

		        [ForeignKey("Modulo_Atencion_Inicial")]
        public virtual Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial Modulo_Atencion_Inicial_Modulo_Atencion_Inicial { get; set; }
        [ForeignKey("Expediente_MP")]
        public virtual Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico Expediente_MP_expediente_ministerio_publico { get; set; }
        [ForeignKey("Involucrado")]
        public virtual Spartane.Core.Domain.Detalle_de_Datos_Generales.Detalle_de_Datos_Generales Involucrado_Detalle_de_Datos_Generales { get; set; }
        [ForeignKey("Probable_Responsable")]
        public virtual Spartane.Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado Probable_Responsable_Detalle_de_Imputado { get; set; }
        [ForeignKey("Delito")]
        public virtual Spartane.Core.Domain.Delito.Delito Delito_Delito { get; set; }
        [ForeignKey("Es_Familiar")]
        public virtual Spartane.Core.Domain.Binario.Binario Es_Familiar_Binario { get; set; }
        [ForeignKey("Parentesco")]
        public virtual Spartane.Core.Domain.Parentesco.Parentesco Parentesco_Parentesco { get; set; }

    }


}

