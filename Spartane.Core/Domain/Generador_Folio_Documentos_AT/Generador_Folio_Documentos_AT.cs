using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Unidad;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Generador_Folio_Documentos_AT
{
    /// <summary>
    /// Generador_Folio_Documentos_AT table
    /// </summary>
    public class Generador_Folio_Documentos_AT: BaseEntity
    {
        public int Folio { get; set; }
        public DateTime? Fecha_Genera { get; set; }
        public short? Anio_Genera { get; set; }
        public int? Municipio { get; set; }
        public int? Unidad { get; set; }
        public int? Consecutivo { get; set; }
        public string Folio_Ultimo_Generado { get; set; }

        [ForeignKey("Municipio")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Municipio { get; set; }
        [ForeignKey("Unidad")]
        public virtual Spartane.Core.Domain.Unidad.Unidad Unidad_Unidad { get; set; }

    }
	
	public class Generador_Folio_Documentos_AT_Datos_Generales
    {
                public int Folio { get; set; }
        public DateTime? Fecha_Genera { get; set; }
        public short? Anio_Genera { get; set; }
        public int? Municipio { get; set; }
        public int? Unidad { get; set; }
        public int? Consecutivo { get; set; }
        public string Folio_Ultimo_Generado { get; set; }

		        [ForeignKey("Municipio")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_Municipio { get; set; }
        [ForeignKey("Unidad")]
        public virtual Spartane.Core.Domain.Unidad.Unidad Unidad_Unidad { get; set; }

    }


}

