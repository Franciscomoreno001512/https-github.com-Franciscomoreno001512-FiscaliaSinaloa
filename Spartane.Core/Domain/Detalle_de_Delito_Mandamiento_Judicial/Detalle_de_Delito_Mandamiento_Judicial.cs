using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Registro_de_Mandamiento_Judicial;
using Spartane.Core.Domain.Delito;
using Spartane.Core.Domain.Modalidad_Delito;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Delito_Mandamiento_Judicial
{
    /// <summary>
    /// Detalle_de_Delito_Mandamiento_Judicial table
    /// </summary>
    public class Detalle_de_Delito_Mandamiento_Judicial: BaseEntity
    {
        public int Clave { get; set; }
        public int? Orden_Aprehension { get; set; }
        public int? Delito { get; set; }
        public short? Modalidad { get; set; }

        [ForeignKey("Orden_Aprehension")]
        public virtual Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial Orden_Aprehension_Registro_de_Mandamiento_Judicial { get; set; }
        [ForeignKey("Delito")]
        public virtual Spartane.Core.Domain.Delito.Delito Delito_Delito { get; set; }
        [ForeignKey("Modalidad")]
        public virtual Spartane.Core.Domain.Modalidad_Delito.Modalidad_Delito Modalidad_Modalidad_Delito { get; set; }

    }
	
	public class Detalle_de_Delito_Mandamiento_Judicial_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Orden_Aprehension { get; set; }
        public int? Delito { get; set; }
        public short? Modalidad { get; set; }

		        [ForeignKey("Orden_Aprehension")]
        public virtual Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial Orden_Aprehension_Registro_de_Mandamiento_Judicial { get; set; }
        [ForeignKey("Delito")]
        public virtual Spartane.Core.Domain.Delito.Delito Delito_Delito { get; set; }
        [ForeignKey("Modalidad")]
        public virtual Spartane.Core.Domain.Modalidad_Delito.Modalidad_Delito Modalidad_Modalidad_Delito { get; set; }

    }


}

