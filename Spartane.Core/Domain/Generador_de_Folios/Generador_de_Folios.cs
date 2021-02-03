using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Tipo_de_Denuncia;
using Spartane.Core.Domain.Region;
using Spartane.Core.Domain.Unidad;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Generador_de_Folios
{
    /// <summary>
    /// Generador_de_Folios table
    /// </summary>
    public class Generador_de_Folios: BaseEntity
    {
        public int Folio { get; set; }
        public DateTime? Fecha_de_Generador_de_Folio { get; set; }
        public short? Anio_de_Generador_de_Folio { get; set; }
        public int? Tipo_de_Denuncia { get; set; }
        public int? Region { get; set; }
        public int? Unidad { get; set; }
        public int? Consecutivo { get; set; }
        public string Folio_Ultimo_Generado { get; set; }

        [ForeignKey("Tipo_de_Denuncia")]
        public virtual Spartane.Core.Domain.Tipo_de_Denuncia.Tipo_de_Denuncia Tipo_de_Denuncia_Tipo_de_Denuncia { get; set; }
        [ForeignKey("Region")]
        public virtual Spartane.Core.Domain.Region.Region Region_Region { get; set; }
        [ForeignKey("Unidad")]
        public virtual Spartane.Core.Domain.Unidad.Unidad Unidad_Unidad { get; set; }

    }
	
	public class Generador_de_Folios_Datos_Generales
    {
                public int Folio { get; set; }
        public DateTime? Fecha_de_Generador_de_Folio { get; set; }
        public short? Anio_de_Generador_de_Folio { get; set; }
        public int? Tipo_de_Denuncia { get; set; }
        public int? Region { get; set; }
        public int? Unidad { get; set; }
        public int? Consecutivo { get; set; }
        public string Folio_Ultimo_Generado { get; set; }

		        [ForeignKey("Tipo_de_Denuncia")]
        public virtual Spartane.Core.Domain.Tipo_de_Denuncia.Tipo_de_Denuncia Tipo_de_Denuncia_Tipo_de_Denuncia { get; set; }
        [ForeignKey("Region")]
        public virtual Spartane.Core.Domain.Region.Region Region_Region { get; set; }
        [ForeignKey("Unidad")]
        public virtual Spartane.Core.Domain.Unidad.Unidad Unidad_Unidad { get; set; }

    }


}

