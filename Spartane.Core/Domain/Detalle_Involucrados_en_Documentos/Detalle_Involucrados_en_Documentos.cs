using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Documentos_MPO;
using Spartane.Core.Domain.Detalle_de_Datos_Generales;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_Involucrados_en_Documentos
{
    /// <summary>
    /// Detalle_Involucrados_en_Documentos table
    /// </summary>
    public class Detalle_Involucrados_en_Documentos: BaseEntity
    {
        public int Clave { get; set; }
        public int? IdDocumentos { get; set; }
        public int? Involucrado { get; set; }

        [ForeignKey("IdDocumentos")]
        public virtual Spartane.Core.Domain.Detalle_de_Documentos_MPO.Detalle_de_Documentos_MPO IdDocumentos_Detalle_de_Documentos_MPO { get; set; }
        [ForeignKey("Involucrado")]
        public virtual Spartane.Core.Domain.Detalle_de_Datos_Generales.Detalle_de_Datos_Generales Involucrado_Detalle_de_Datos_Generales { get; set; }

    }
	
	public class Detalle_Involucrados_en_Documentos_Datos_Generales
    {
                public int Clave { get; set; }
        public int? IdDocumentos { get; set; }
        public int? Involucrado { get; set; }

		        [ForeignKey("IdDocumentos")]
        public virtual Spartane.Core.Domain.Detalle_de_Documentos_MPO.Detalle_de_Documentos_MPO IdDocumentos_Detalle_de_Documentos_MPO { get; set; }
        [ForeignKey("Involucrado")]
        public virtual Spartane.Core.Domain.Detalle_de_Datos_Generales.Detalle_de_Datos_Generales Involucrado_Detalle_de_Datos_Generales { get; set; }

    }


}

