using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Medidas_de_Proteccion;
using Spartane.Core.Domain.Medida_de_Proteccion;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_Medidas_Proteccion
{
    /// <summary>
    /// Detalle_Medidas_Proteccion table
    /// </summary>
    public class Detalle_Medidas_Proteccion: BaseEntity
    {
        public int Clave { get; set; }
        public int? Medidas_de_Proteccion { get; set; }
        public bool? Seleccionar { get; set; }
        public int? Medida { get; set; }

        [ForeignKey("Medidas_de_Proteccion")]
        public virtual Spartane.Core.Domain.Medidas_de_Proteccion.Medidas_de_Proteccion Medidas_de_Proteccion_Medidas_de_Proteccion { get; set; }
        [ForeignKey("Medida")]
        public virtual Spartane.Core.Domain.Medida_de_Proteccion.Medida_de_Proteccion Medida_Medida_de_Proteccion { get; set; }

    }
	
	public class Detalle_Medidas_Proteccion_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Medidas_de_Proteccion { get; set; }
        public bool? Seleccionar { get; set; }
        public int? Medida { get; set; }

		        [ForeignKey("Medidas_de_Proteccion")]
        public virtual Spartane.Core.Domain.Medidas_de_Proteccion.Medidas_de_Proteccion Medidas_de_Proteccion_Medidas_de_Proteccion { get; set; }
        [ForeignKey("Medida")]
        public virtual Spartane.Core.Domain.Medida_de_Proteccion.Medida_de_Proteccion Medida_Medida_de_Proteccion { get; set; }

    }


}

