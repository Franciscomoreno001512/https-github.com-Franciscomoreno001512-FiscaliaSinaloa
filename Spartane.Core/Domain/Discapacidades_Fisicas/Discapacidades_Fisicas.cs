using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Vigencia;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Discapacidades_Fisicas
{
    /// <summary>
    /// Discapacidades_Fisicas table
    /// </summary>
    public class Discapacidades_Fisicas: BaseEntity
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Vigencia { get; set; }
        public string Observaciones { get; set; }

        [ForeignKey("Vigencia")]
        public virtual Spartane.Core.Domain.Vigencia.Vigencia Vigencia_Vigencia { get; set; }

    }
	
	public class Discapacidades_Fisicas_Datos_Generales
    {
                public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Vigencia { get; set; }
        public string Observaciones { get; set; }

		        [ForeignKey("Vigencia")]
        public virtual Spartane.Core.Domain.Vigencia.Vigencia Vigencia_Vigencia { get; set; }

    }


}

