using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Aseguramientos;
using Spartane.Core.Domain.Tipo_de_Documento;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_Aseguramiento_Documentos
{
    /// <summary>
    /// Detalle_Aseguramiento_Documentos table
    /// </summary>
    public class Detalle_Aseguramiento_Documentos: BaseEntity
    {
        public int Clave { get; set; }
        public int? Aseguramiento { get; set; }
        public int? Tipo { get; set; }
        public decimal? Cantidad { get; set; }
        public string Observaciones { get; set; }
        public string Descipcion_de_Documento { get; set; }

        [ForeignKey("Aseguramiento")]
        public virtual Spartane.Core.Domain.Aseguramientos.Aseguramientos Aseguramiento_Aseguramientos { get; set; }
        [ForeignKey("Tipo")]
        public virtual Spartane.Core.Domain.Tipo_de_Documento.Tipo_de_Documento Tipo_Tipo_de_Documento { get; set; }

    }
	
	public class Detalle_Aseguramiento_Documentos_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Aseguramiento { get; set; }
        public int? Tipo { get; set; }
        public decimal? Cantidad { get; set; }
        public string Observaciones { get; set; }
        public string Descipcion_de_Documento { get; set; }

		        [ForeignKey("Aseguramiento")]
        public virtual Spartane.Core.Domain.Aseguramientos.Aseguramientos Aseguramiento_Aseguramientos { get; set; }
        [ForeignKey("Tipo")]
        public virtual Spartane.Core.Domain.Tipo_de_Documento.Tipo_de_Documento Tipo_Tipo_de_Documento { get; set; }

    }


}

