using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Documentos_MPO;
using Spartane.Core.Domain.Detalle_de_Imputado;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_Probable_Responsable_de_Documentos
{
    /// <summary>
    /// Detalle_Probable_Responsable_de_Documentos table
    /// </summary>
    public class Detalle_Probable_Responsable_de_Documentos: BaseEntity
    {
        public int Clave { get; set; }
        public int? IdDocumentos { get; set; }
        public int? Probable_Responsable { get; set; }

        [ForeignKey("IdDocumentos")]
        public virtual Spartane.Core.Domain.Detalle_de_Documentos_MPO.Detalle_de_Documentos_MPO IdDocumentos_Detalle_de_Documentos_MPO { get; set; }
        [ForeignKey("Probable_Responsable")]
        public virtual Spartane.Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado Probable_Responsable_Detalle_de_Imputado { get; set; }

    }
	
	public class Detalle_Probable_Responsable_de_Documentos_Datos_Generales
    {
                public int Clave { get; set; }
        public int? IdDocumentos { get; set; }
        public int? Probable_Responsable { get; set; }

		        [ForeignKey("IdDocumentos")]
        public virtual Spartane.Core.Domain.Detalle_de_Documentos_MPO.Detalle_de_Documentos_MPO IdDocumentos_Detalle_de_Documentos_MPO { get; set; }
        [ForeignKey("Probable_Responsable")]
        public virtual Spartane.Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado Probable_Responsable_Detalle_de_Imputado { get; set; }

    }


}

