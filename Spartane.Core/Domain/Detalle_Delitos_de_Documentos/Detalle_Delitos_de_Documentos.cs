using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Documentos_MPO;
using Spartane.Core.Domain.Detalle_de_Delito;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_Delitos_de_Documentos
{
    /// <summary>
    /// Detalle_Delitos_de_Documentos table
    /// </summary>
    public class Detalle_Delitos_de_Documentos: BaseEntity
    {
        public int Clave { get; set; }
        public int? IdDocumentos { get; set; }
        public int? Delito { get; set; }

        [ForeignKey("IdDocumentos")]
        public virtual Spartane.Core.Domain.Detalle_de_Documentos_MPO.Detalle_de_Documentos_MPO IdDocumentos_Detalle_de_Documentos_MPO { get; set; }
        [ForeignKey("Delito")]
        public virtual Spartane.Core.Domain.Detalle_de_Delito.Detalle_de_Delito Delito_Detalle_de_Delito { get; set; }

    }
	
	public class Detalle_Delitos_de_Documentos_Datos_Generales
    {
                public int Clave { get; set; }
        public int? IdDocumentos { get; set; }
        public int? Delito { get; set; }

		        [ForeignKey("IdDocumentos")]
        public virtual Spartane.Core.Domain.Detalle_de_Documentos_MPO.Detalle_de_Documentos_MPO IdDocumentos_Detalle_de_Documentos_MPO { get; set; }
        [ForeignKey("Delito")]
        public virtual Spartane.Core.Domain.Detalle_de_Delito.Detalle_de_Delito Delito_Detalle_de_Delito { get; set; }

    }


}

