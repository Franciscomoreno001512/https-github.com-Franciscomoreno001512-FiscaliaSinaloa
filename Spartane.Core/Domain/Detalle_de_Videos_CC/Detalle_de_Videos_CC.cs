using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Cadena_de_Custodia;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Videos_CC
{
    /// <summary>
    /// Detalle_de_Videos_CC table
    /// </summary>
    public class Detalle_de_Videos_CC: BaseEntity
    {
        public int Clave { get; set; }
        public int? Cadenade_Custodia { get; set; }
        public short? Video { get; set; }
        public string Pie_de_Video { get; set; }

        [ForeignKey("Cadenade_Custodia")]
        public virtual Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia Cadenade_Custodia_Cadena_de_Custodia { get; set; }

    }
	
	public class Detalle_de_Videos_CC_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Cadenade_Custodia { get; set; }
        public short? Video { get; set; }
        public string Pie_de_Video { get; set; }

		        [ForeignKey("Cadenade_Custodia")]
        public virtual Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia Cadenade_Custodia_Cadena_de_Custodia { get; set; }

    }


}

