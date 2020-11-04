using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Vigencia;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Corporacion
{
    /// <summary>
    /// Corporacion table
    /// </summary>
    public class Corporacion: BaseEntity
    {
        public int Clave { get; set; }
        public int? Clave_Municipio { get; set; }
        public int? Clave_Policia { get; set; }
        public string Descripcion { get; set; }
        public int? Vigencia { get; set; }
        public string Uso_Vehiculo { get; set; }
        public string Observaciones { get; set; }

        [ForeignKey("Vigencia")]
        public virtual Spartane.Core.Domain.Vigencia.Vigencia Vigencia_Vigencia { get; set; }

    }
	
	public class Corporacion_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Clave_Municipio { get; set; }
        public int? Clave_Policia { get; set; }
        public string Descripcion { get; set; }
        public int? Vigencia { get; set; }
        public string Uso_Vehiculo { get; set; }
        public string Observaciones { get; set; }

		        [ForeignKey("Vigencia")]
        public virtual Spartane.Core.Domain.Vigencia.Vigencia Vigencia_Vigencia { get; set; }

    }


}

