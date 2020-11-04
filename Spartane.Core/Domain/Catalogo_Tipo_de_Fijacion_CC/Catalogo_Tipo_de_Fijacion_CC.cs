using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Cadena_de_Custodia;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Catalogo_Tipo_de_Fijacion_CC
{
    /// <summary>
    /// Catalogo_Tipo_de_Fijacion_CC table
    /// </summary>
    public class Catalogo_Tipo_de_Fijacion_CC: BaseEntity
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Cadena_y_Custodia { get; set; }

        [ForeignKey("Cadena_y_Custodia")]
        public virtual Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia Cadena_y_Custodia_Cadena_de_Custodia { get; set; }

    }
	
	public class Catalogo_Tipo_de_Fijacion_CC_Datos_Generales
    {
                public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Cadena_y_Custodia { get; set; }

		        [ForeignKey("Cadena_y_Custodia")]
        public virtual Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia Cadena_y_Custodia_Cadena_de_Custodia { get; set; }

    }


}

