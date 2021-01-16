using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Modulo_Atencion_Inicial;
using Spartane.Core.Domain.Estatus_Servicio_Pericial;
using Spartane.Core.Domain.Detalle_de_Servicio_de_Apoyo;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Solicitud;
using Spartane.Core.Domain.expediente_ministerio_publico;
using Spartane.Core.Domain.Origen_de_Invitacion;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Modulo_Servicio_Pericial
{
    /// <summary>
    /// Modulo_Servicio_Pericial table
    /// </summary>
    public class Modulo_Servicio_Pericial: BaseEntity
    {
        public int Clave { get; set; }
        public int? Modulo_Atencion_Inicial { get; set; }
        public int? Estatus { get; set; }
        public int? Servicio_Pericial { get; set; }
        public int? Usuario_Asignado { get; set; }
        public int? Modulo_Mecanismos_Alternos { get; set; }
        public int? Modulo_Ministerio_Publico { get; set; }
        public int? Origen { get; set; }
        public string Descripcion { get; set; }

        [ForeignKey("Modulo_Atencion_Inicial")]
        public virtual Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial Modulo_Atencion_Inicial_Modulo_Atencion_Inicial { get; set; }
        [ForeignKey("Estatus")]
        public virtual Spartane.Core.Domain.Estatus_Servicio_Pericial.Estatus_Servicio_Pericial Estatus_Estatus_Servicio_Pericial { get; set; }
        [ForeignKey("Servicio_Pericial")]
        public virtual Spartane.Core.Domain.Detalle_de_Servicio_de_Apoyo.Detalle_de_Servicio_de_Apoyo Servicio_Pericial_Detalle_de_Servicio_de_Apoyo { get; set; }
        [ForeignKey("Usuario_Asignado")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_Asignado_Spartan_User { get; set; }
        [ForeignKey("Modulo_Mecanismos_Alternos")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Modulo_Mecanismos_Alternos_Solicitud { get; set; }
        [ForeignKey("Modulo_Ministerio_Publico")]
        public virtual Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico Modulo_Ministerio_Publico_expediente_ministerio_publico { get; set; }
        [ForeignKey("Origen")]
        public virtual Spartane.Core.Domain.Origen_de_Invitacion.Origen_de_Invitacion Origen_Origen_de_Invitacion { get; set; }

    }
	
	public class Modulo_Servicio_Pericial_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Modulo_Atencion_Inicial { get; set; }
        public int? Estatus { get; set; }
        public int? Servicio_Pericial { get; set; }
        public int? Usuario_Asignado { get; set; }
        public int? Modulo_Mecanismos_Alternos { get; set; }
        public int? Modulo_Ministerio_Publico { get; set; }
        public int? Origen { get; set; }
        public string Descripcion { get; set; }

		        [ForeignKey("Modulo_Atencion_Inicial")]
        public virtual Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial Modulo_Atencion_Inicial_Modulo_Atencion_Inicial { get; set; }
        [ForeignKey("Estatus")]
        public virtual Spartane.Core.Domain.Estatus_Servicio_Pericial.Estatus_Servicio_Pericial Estatus_Estatus_Servicio_Pericial { get; set; }
        [ForeignKey("Servicio_Pericial")]
        public virtual Spartane.Core.Domain.Detalle_de_Servicio_de_Apoyo.Detalle_de_Servicio_de_Apoyo Servicio_Pericial_Detalle_de_Servicio_de_Apoyo { get; set; }
        [ForeignKey("Usuario_Asignado")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_Asignado_Spartan_User { get; set; }
        [ForeignKey("Modulo_Mecanismos_Alternos")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Modulo_Mecanismos_Alternos_Solicitud { get; set; }
        [ForeignKey("Modulo_Ministerio_Publico")]
        public virtual Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico Modulo_Ministerio_Publico_expediente_ministerio_publico { get; set; }
        [ForeignKey("Origen")]
        public virtual Spartane.Core.Domain.Origen_de_Invitacion.Origen_de_Invitacion Origen_Origen_de_Invitacion { get; set; }

    }


}

