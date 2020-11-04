using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Estatus_de_Documento;
using Spartane.Core.Domain.Estatus_de_Actualizacion_de_Documento;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Carga_de_Documentos_de_Legislacion
{
    /// <summary>
    /// Carga_de_Documentos_de_Legislacion table
    /// </summary>
    public class Carga_de_Documentos_de_Legislacion: BaseEntity
    {
        public int Folio { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public short? Adjuntar_Documento { get; set; }
        public int? Estatus { get; set; }
        public int? Estatus_de_Actualizacion { get; set; }

        [ForeignKey("Estatus")]
        public virtual Spartane.Core.Domain.Estatus_de_Documento.Estatus_de_Documento Estatus_Estatus_de_Documento { get; set; }
        [ForeignKey("Estatus_de_Actualizacion")]
        public virtual Spartane.Core.Domain.Estatus_de_Actualizacion_de_Documento.Estatus_de_Actualizacion_de_Documento Estatus_de_Actualizacion_Estatus_de_Actualizacion_de_Documento { get; set; }

    }
	
	public class Carga_de_Documentos_de_Legislacion_Datos_Generales
    {
                public int Folio { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public short? Adjuntar_Documento { get; set; }
        public int? Estatus { get; set; }
        public int? Estatus_de_Actualizacion { get; set; }

		        [ForeignKey("Estatus")]
        public virtual Spartane.Core.Domain.Estatus_de_Documento.Estatus_de_Documento Estatus_Estatus_de_Documento { get; set; }
        [ForeignKey("Estatus_de_Actualizacion")]
        public virtual Spartane.Core.Domain.Estatus_de_Actualizacion_de_Documento.Estatus_de_Actualizacion_de_Documento Estatus_de_Actualizacion_Estatus_de_Actualizacion_de_Documento { get; set; }

    }


}

