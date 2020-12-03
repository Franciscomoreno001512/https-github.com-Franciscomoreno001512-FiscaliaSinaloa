using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Tipo_de_Audiencia;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Audiencia
{
    /// <summary>
    /// Audiencia table
    /// </summary>
    public class Audiencia: BaseEntity
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Tipo_de_Audiencia { get; set; }

        [ForeignKey("Tipo_de_Audiencia")]
        public virtual Spartane.Core.Domain.Tipo_de_Audiencia.Tipo_de_Audiencia Tipo_de_Audiencia_Tipo_de_Audiencia { get; set; }

    }
	
	public class Audiencia_Datos_Generales
    {
                public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Tipo_de_Audiencia { get; set; }

		        [ForeignKey("Tipo_de_Audiencia")]
        public virtual Spartane.Core.Domain.Tipo_de_Audiencia.Tipo_de_Audiencia Tipo_de_Audiencia_Tipo_de_Audiencia { get; set; }

    }


}

