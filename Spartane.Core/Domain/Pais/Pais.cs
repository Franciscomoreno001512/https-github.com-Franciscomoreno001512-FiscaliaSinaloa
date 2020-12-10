using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Vigencia;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Pais
{
    /// <summary>
    /// Pais table
    /// </summary>
    public class Pais: BaseEntity
    {
        public int Clave { get; set; }
        public string Nombre { get; set; }
        public int? Vigencia { get; set; }
        public string Observaciones { get; set; }
        public string Nacionalidad { get; set; }
        public string Abrevia { get; set; }

        [ForeignKey("Vigencia")]
        public virtual Spartane.Core.Domain.Vigencia.Vigencia Vigencia_Vigencia { get; set; }

    }
	
	public class Pais_Datos_Generales
    {
                public int Clave { get; set; }
        public string Nombre { get; set; }
        public int? Vigencia { get; set; }
        public string Observaciones { get; set; }
        public string Nacionalidad { get; set; }
        public string Abrevia { get; set; }

		        [ForeignKey("Vigencia")]
        public virtual Spartane.Core.Domain.Vigencia.Vigencia Vigencia_Vigencia { get; set; }

    }


}

