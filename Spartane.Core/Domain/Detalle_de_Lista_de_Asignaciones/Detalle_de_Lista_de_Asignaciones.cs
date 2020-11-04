using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Cadena_de_Custodia;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Lista_de_Asignaciones
{
    /// <summary>
    /// Detalle_de_Lista_de_Asignaciones table
    /// </summary>
    public class Detalle_de_Lista_de_Asignaciones: BaseEntity
    {
        public int Clave { get; set; }
        public int? Cadena_de_Custodia { get; set; }
        public int? Numero_de_Asignacion { get; set; }
        public string Nombre { get; set; }
        public bool? Realizado { get; set; }
        public string Especifique { get; set; }

        [ForeignKey("Cadena_de_Custodia")]
        public virtual Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia Cadena_de_Custodia_Cadena_de_Custodia { get; set; }

    }
	
	public class Detalle_de_Lista_de_Asignaciones_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Cadena_de_Custodia { get; set; }
        public int? Numero_de_Asignacion { get; set; }
        public string Nombre { get; set; }
        public bool? Realizado { get; set; }
        public string Especifique { get; set; }

		        [ForeignKey("Cadena_de_Custodia")]
        public virtual Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia Cadena_de_Custodia_Cadena_de_Custodia { get; set; }

    }


}

