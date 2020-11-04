using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Tipo_de_Diligencia_MASC;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Dilgencia_MASC
{
    /// <summary>
    /// Dilgencia_MASC table
    /// </summary>
    public class Dilgencia_MASC: BaseEntity
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Tipo_de_Diligencia { get; set; }

        [ForeignKey("Tipo_de_Diligencia")]
        public virtual Spartane.Core.Domain.Tipo_de_Diligencia_MASC.Tipo_de_Diligencia_MASC Tipo_de_Diligencia_Tipo_de_Diligencia_MASC { get; set; }

    }
	
	public class Dilgencia_MASC_Datos_Generales
    {
                public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Tipo_de_Diligencia { get; set; }

		        [ForeignKey("Tipo_de_Diligencia")]
        public virtual Spartane.Core.Domain.Tipo_de_Diligencia_MASC.Tipo_de_Diligencia_MASC Tipo_de_Diligencia_Tipo_de_Diligencia_MASC { get; set; }

    }


}

