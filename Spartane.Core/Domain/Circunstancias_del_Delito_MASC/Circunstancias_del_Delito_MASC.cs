using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Delito_de_Justicia;
using Spartane.Core.Domain.Circunstancias;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Circunstancias_del_Delito_MASC
{
    /// <summary>
    /// Circunstancias_del_Delito_MASC table
    /// </summary>
    public class Circunstancias_del_Delito_MASC: BaseEntity
    {
        public int Clave { get; set; }
        public int? Folio_Circunstancial { get; set; }
        public int? Tipo_de_Lugar { get; set; }

        [ForeignKey("Folio_Circunstancial")]
        public virtual Spartane.Core.Domain.Detalle_de_Delito_de_Justicia.Detalle_de_Delito_de_Justicia Folio_Circunstancial_Detalle_de_Delito_de_Justicia { get; set; }
        [ForeignKey("Tipo_de_Lugar")]
        public virtual Spartane.Core.Domain.Circunstancias.Circunstancias Tipo_de_Lugar_Circunstancias { get; set; }

    }
	
	public class Circunstancias_del_Delito_MASC_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Folio_Circunstancial { get; set; }
        public int? Tipo_de_Lugar { get; set; }

		        [ForeignKey("Folio_Circunstancial")]
        public virtual Spartane.Core.Domain.Detalle_de_Delito_de_Justicia.Detalle_de_Delito_de_Justicia Folio_Circunstancial_Detalle_de_Delito_de_Justicia { get; set; }
        [ForeignKey("Tipo_de_Lugar")]
        public virtual Spartane.Core.Domain.Circunstancias.Circunstancias Tipo_de_Lugar_Circunstancias { get; set; }

    }


}

