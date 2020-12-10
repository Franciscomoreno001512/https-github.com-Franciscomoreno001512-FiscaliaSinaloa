using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Modulo_Encuesta;
using Spartane.Core.Domain.Region;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Generador_Folio_Encuesta
{
    /// <summary>
    /// Generador_Folio_Encuesta table
    /// </summary>
    public class Generador_Folio_Encuesta: BaseEntity
    {
        public int Folio { get; set; }
        public DateTime? Fecha_Genera { get; set; }
        public short? Anio_Genera { get; set; }
        public int? Modulo_Encuesta { get; set; }
        public int? Region { get; set; }
        public int? Consecutivo { get; set; }
        public string Folio_Encuesta_Ultimo_Generado { get; set; }

        [ForeignKey("Modulo_Encuesta")]
        public virtual Spartane.Core.Domain.Modulo_Encuesta.Modulo_Encuesta Modulo_Encuesta_Modulo_Encuesta { get; set; }
        [ForeignKey("Region")]
        public virtual Spartane.Core.Domain.Region.Region Region_Region { get; set; }

    }
	
	public class Generador_Folio_Encuesta_Datos_Generales
    {
                public int Folio { get; set; }
        public DateTime? Fecha_Genera { get; set; }
        public short? Anio_Genera { get; set; }
        public int? Modulo_Encuesta { get; set; }
        public int? Region { get; set; }
        public int? Consecutivo { get; set; }
        public string Folio_Encuesta_Ultimo_Generado { get; set; }

		        [ForeignKey("Modulo_Encuesta")]
        public virtual Spartane.Core.Domain.Modulo_Encuesta.Modulo_Encuesta Modulo_Encuesta_Modulo_Encuesta { get; set; }
        [ForeignKey("Region")]
        public virtual Spartane.Core.Domain.Region.Region Region_Region { get; set; }

    }


}

