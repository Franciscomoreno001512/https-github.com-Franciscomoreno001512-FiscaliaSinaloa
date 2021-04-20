using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Documentos_MPO;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Indicios_de_Diligencia
{
    /// <summary>
    /// Detalle_de_Indicios_de_Diligencia table
    /// </summary>
    public class Detalle_de_Indicios_de_Diligencia: BaseEntity
    {
        public int Folio { get; set; }
        public int? Diligencia { get; set; }
        public string Indicio { get; set; }
        public bool? Seleccionar { get; set; }
        public int? IndicioId { get; set; }

        [ForeignKey("Diligencia")]
        public virtual Spartane.Core.Domain.Detalle_de_Documentos_MPO.Detalle_de_Documentos_MPO Diligencia_Detalle_de_Documentos_MPO { get; set; }

    }
	
	public class Detalle_de_Indicios_de_Diligencia_Datos_Generales
    {
                public int Folio { get; set; }
        public int? Diligencia { get; set; }
        public string Indicio { get; set; }
        public bool? Seleccionar { get; set; }
        public int? IndicioId { get; set; }

		        [ForeignKey("Diligencia")]
        public virtual Spartane.Core.Domain.Detalle_de_Documentos_MPO.Detalle_de_Documentos_MPO Diligencia_Detalle_de_Documentos_MPO { get; set; }

    }


}

