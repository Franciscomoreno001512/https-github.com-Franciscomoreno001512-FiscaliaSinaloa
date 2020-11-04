using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Delito;
using Spartane.Core.Domain.Tipo_de_Lugar_del_Robo;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Circunstancias_del_Delito
{
    /// <summary>
    /// Circunstancias_del_Delito table
    /// </summary>
    public class Circunstancias_del_Delito: BaseEntity
    {
        public int Clave { get; set; }
        public int? Folio_Circunstacias { get; set; }
        public int? Tipo_de_Lugar { get; set; }

        [ForeignKey("Folio_Circunstacias")]
        public virtual Spartane.Core.Domain.Detalle_de_Delito.Detalle_de_Delito Folio_Circunstacias_Detalle_de_Delito { get; set; }
        [ForeignKey("Tipo_de_Lugar")]
        public virtual Spartane.Core.Domain.Tipo_de_Lugar_del_Robo.Tipo_de_Lugar_del_Robo Tipo_de_Lugar_Tipo_de_Lugar_del_Robo { get; set; }

    }
	
	public class Circunstancias_del_Delito_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Folio_Circunstacias { get; set; }
        public int? Tipo_de_Lugar { get; set; }

		        [ForeignKey("Folio_Circunstacias")]
        public virtual Spartane.Core.Domain.Detalle_de_Delito.Detalle_de_Delito Folio_Circunstacias_Detalle_de_Delito { get; set; }
        [ForeignKey("Tipo_de_Lugar")]
        public virtual Spartane.Core.Domain.Tipo_de_Lugar_del_Robo.Tipo_de_Lugar_del_Robo Tipo_de_Lugar_Tipo_de_Lugar_del_Robo { get; set; }

    }


}

