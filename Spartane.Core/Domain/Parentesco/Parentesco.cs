using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Vigencia;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Parentesco
{
    /// <summary>
    /// Parentesco table
    /// </summary>
    public class Parentesco: BaseEntity
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public string Complemento { get; set; }
        public string Tipo_de_Relacion { get; set; }
        public string Relacion_con_Involucrado { get; set; }
        public int? Vigencia { get; set; }
        public string Observaciones { get; set; }

        [ForeignKey("Vigencia")]
        public virtual Spartane.Core.Domain.Vigencia.Vigencia Vigencia_Vigencia { get; set; }

    }
	
	public class Parentesco_Datos_Generales
    {
                public int Clave { get; set; }
        public string Descripcion { get; set; }
        public string Complemento { get; set; }
        public string Tipo_de_Relacion { get; set; }
        public string Relacion_con_Involucrado { get; set; }
        public int? Vigencia { get; set; }
        public string Observaciones { get; set; }

		        [ForeignKey("Vigencia")]
        public virtual Spartane.Core.Domain.Vigencia.Vigencia Vigencia_Vigencia { get; set; }

    }


}

