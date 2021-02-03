using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Tipo_de_Denuncia;
using Spartane.Core.Domain.Region;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Generador_de_NUAT
{
    /// <summary>
    /// Generador_de_NUAT table
    /// </summary>
    public class Generador_de_NUAT: BaseEntity
    {
        public int Folio { get; set; }
        public DateTime? Fecha_de_Generador_de_NUAT { get; set; }
        public short? Anio_de_Generador_de_NUAT { get; set; }
        public int? Tipo_de_Denuncia { get; set; }
        public int? Region { get; set; }
        public int? Consecutivo { get; set; }
        public string NUAT_Ultimo_Generado { get; set; }

        [ForeignKey("Tipo_de_Denuncia")]
        public virtual Spartane.Core.Domain.Tipo_de_Denuncia.Tipo_de_Denuncia Tipo_de_Denuncia_Tipo_de_Denuncia { get; set; }
        [ForeignKey("Region")]
        public virtual Spartane.Core.Domain.Region.Region Region_Region { get; set; }

    }
	
	public class Generador_de_NUAT_Datos_Generales
    {
                public int Folio { get; set; }
        public DateTime? Fecha_de_Generador_de_NUAT { get; set; }
        public short? Anio_de_Generador_de_NUAT { get; set; }
        public int? Tipo_de_Denuncia { get; set; }
        public int? Region { get; set; }
        public int? Consecutivo { get; set; }
        public string NUAT_Ultimo_Generado { get; set; }

		        [ForeignKey("Tipo_de_Denuncia")]
        public virtual Spartane.Core.Domain.Tipo_de_Denuncia.Tipo_de_Denuncia Tipo_de_Denuncia_Tipo_de_Denuncia { get; set; }
        [ForeignKey("Region")]
        public virtual Spartane.Core.Domain.Region.Region Region_Region { get; set; }

    }


}

