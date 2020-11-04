using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Cadena_de_Custodia;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Fotos_CC
{
    /// <summary>
    /// Detalle_de_Fotos_CC table
    /// </summary>
    public class Detalle_de_Fotos_CC: BaseEntity
    {
        public int Clave { get; set; }
        public int? Cadena_de_Custodia { get; set; }
        public short? Fotos { get; set; }
        public string Pie_de_Foto { get; set; }

        [ForeignKey("Cadena_de_Custodia")]
        public virtual Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia Cadena_de_Custodia_Cadena_de_Custodia { get; set; }

    }
	
	public class Detalle_de_Fotos_CC_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Cadena_de_Custodia { get; set; }
        public short? Fotos { get; set; }
        public string Pie_de_Foto { get; set; }

		        [ForeignKey("Cadena_de_Custodia")]
        public virtual Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia Cadena_de_Custodia_Cadena_de_Custodia { get; set; }

    }


}

