using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Carga_de_Documentos_de_Legislacion;
using Spartane.Core.Domain.Estatus_Detalle_Documentos_Legislacion;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Documentos_de_Legislacion
{
    /// <summary>
    /// Detalle_de_Documentos_de_Legislacion table
    /// </summary>
    public class Detalle_de_Documentos_de_Legislacion: BaseEntity
    {
        public int Clave { get; set; }
        public int? Documentos_de_Legislacion { get; set; }
        public string ID_de_Dispositivo { get; set; }
        public int? Estatus { get; set; }

        [ForeignKey("Documentos_de_Legislacion")]
        public virtual Spartane.Core.Domain.Carga_de_Documentos_de_Legislacion.Carga_de_Documentos_de_Legislacion Documentos_de_Legislacion_Carga_de_Documentos_de_Legislacion { get; set; }
        [ForeignKey("Estatus")]
        public virtual Spartane.Core.Domain.Estatus_Detalle_Documentos_Legislacion.Estatus_Detalle_Documentos_Legislacion Estatus_Estatus_Detalle_Documentos_Legislacion { get; set; }

    }
	
	public class Detalle_de_Documentos_de_Legislacion_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Documentos_de_Legislacion { get; set; }
        public string ID_de_Dispositivo { get; set; }
        public int? Estatus { get; set; }

		        [ForeignKey("Documentos_de_Legislacion")]
        public virtual Spartane.Core.Domain.Carga_de_Documentos_de_Legislacion.Carga_de_Documentos_de_Legislacion Documentos_de_Legislacion_Carga_de_Documentos_de_Legislacion { get; set; }
        [ForeignKey("Estatus")]
        public virtual Spartane.Core.Domain.Estatus_Detalle_Documentos_Legislacion.Estatus_Detalle_Documentos_Legislacion Estatus_Estatus_Detalle_Documentos_Legislacion { get; set; }

    }


}

