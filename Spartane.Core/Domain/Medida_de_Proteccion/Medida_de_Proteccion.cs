using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Tipo_de_Medida_de_Proteccion;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Medida_de_Proteccion
{
    /// <summary>
    /// Medida_de_Proteccion table
    /// </summary>
    public class Medida_de_Proteccion: BaseEntity
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Tipo { get; set; }

        [ForeignKey("Tipo")]
        public virtual Spartane.Core.Domain.Tipo_de_Medida_de_Proteccion.Tipo_de_Medida_de_Proteccion Tipo_Tipo_de_Medida_de_Proteccion { get; set; }

    }
	
	public class Medida_de_Proteccion_Datos_Generales
    {
                public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Tipo { get; set; }

		        [ForeignKey("Tipo")]
        public virtual Spartane.Core.Domain.Tipo_de_Medida_de_Proteccion.Tipo_de_Medida_de_Proteccion Tipo_Tipo_de_Medida_de_Proteccion { get; set; }

    }


}

