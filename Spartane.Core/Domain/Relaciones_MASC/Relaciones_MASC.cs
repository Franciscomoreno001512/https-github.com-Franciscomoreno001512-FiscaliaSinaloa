using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Solicitud;
using Spartane.Core.Domain.Detalle_de_Relaciones;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Resolucion_MASC;
using Spartane.Core.Domain.Tipo_de_Mecanismo_Alterno;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Resultado_de_Revision;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Resolucion_MASC;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Resultado_de_Revision;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Relaciones_MASC
{
    /// <summary>
    /// Relaciones_MASC table
    /// </summary>
    public class Relaciones_MASC: BaseEntity
    {
        public int Clave { get; set; }
        public int? Numero_de_Expediente { get; set; }
        public string Numero_de_Procedimiento { get; set; }
        public int? idRelacionOrigen { get; set; }
        public bool? Requiere_cambiar_la_relacion { get; set; }
        public string Motivo_de_Cambio { get; set; }
        public string Observaciones { get; set; }
        public string Descripcion { get; set; }
        public DateTime? Fecha_de_Resolucion_solicitud { get; set; }
        public string Hora_de_Resolucion_solicitud { get; set; }
        public int? Usuario_que_Resuelve_solicitud { get; set; }
        public int? Resolucion { get; set; }
        public int? Tipo_de_Mecanismo { get; set; }
        public string Observaciones_solicitud { get; set; }
        public DateTime? Fecha_de_Validacion_solicitud { get; set; }
        public string Hora_de_Validacion_solicitud { get; set; }
        public int? Usuario_que_Valida_solicitud { get; set; }
        public short? resultado_solicitud { get; set; }
        public string motivo_rechazo_solicitud { get; set; }
        public DateTime? Fecha_de_Resolucion_proc { get; set; }
        public string hora_resolucion_proc { get; set; }
        public int? usuario_resuelve_proc { get; set; }
        public int? Resolucion_proc { get; set; }
        public string Observaciones_proc { get; set; }
        public DateTime? Fecha_de_Validacion_proc { get; set; }
        public string Hora_de_Validacion_proc { get; set; }
        public int? Usuario_que_Valida_proc { get; set; }
        public short? Resultado_proc { get; set; }
        public string Motivo_de_Rechazo_proc { get; set; }

        [ForeignKey("Numero_de_Expediente")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Numero_de_Expediente_Solicitud { get; set; }
        [ForeignKey("idRelacionOrigen")]
        public virtual Spartane.Core.Domain.Detalle_de_Relaciones.Detalle_de_Relaciones idRelacionOrigen_Detalle_de_Relaciones { get; set; }
        [ForeignKey("Usuario_que_Resuelve_solicitud")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Resuelve_solicitud_Spartan_User { get; set; }
        [ForeignKey("Resolucion")]
        public virtual Spartane.Core.Domain.Resolucion_MASC.Resolucion_MASC Resolucion_Resolucion_MASC { get; set; }
        [ForeignKey("Tipo_de_Mecanismo")]
        public virtual Spartane.Core.Domain.Tipo_de_Mecanismo_Alterno.Tipo_de_Mecanismo_Alterno Tipo_de_Mecanismo_Tipo_de_Mecanismo_Alterno { get; set; }
        [ForeignKey("Usuario_que_Valida_solicitud")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Valida_solicitud_Spartan_User { get; set; }
        [ForeignKey("resultado_solicitud")]
        public virtual Spartane.Core.Domain.Resultado_de_Revision.Resultado_de_Revision resultado_solicitud_Resultado_de_Revision { get; set; }
        [ForeignKey("usuario_resuelve_proc")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User usuario_resuelve_proc_Spartan_User { get; set; }
        [ForeignKey("Resolucion_proc")]
        public virtual Spartane.Core.Domain.Resolucion_MASC.Resolucion_MASC Resolucion_proc_Resolucion_MASC { get; set; }
        [ForeignKey("Usuario_que_Valida_proc")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Valida_proc_Spartan_User { get; set; }
        [ForeignKey("Resultado_proc")]
        public virtual Spartane.Core.Domain.Resultado_de_Revision.Resultado_de_Revision Resultado_proc_Resultado_de_Revision { get; set; }

    }
	
	public class Relaciones_MASC_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Numero_de_Expediente { get; set; }
        public string Numero_de_Procedimiento { get; set; }
        public int? idRelacionOrigen { get; set; }
        public bool? Requiere_cambiar_la_relacion { get; set; }
        public string Motivo_de_Cambio { get; set; }
        public string Observaciones { get; set; }
        public string Descripcion { get; set; }

		        [ForeignKey("Numero_de_Expediente")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Numero_de_Expediente_Solicitud { get; set; }
        [ForeignKey("idRelacionOrigen")]
        public virtual Spartane.Core.Domain.Detalle_de_Relaciones.Detalle_de_Relaciones idRelacionOrigen_Detalle_de_Relaciones { get; set; }

    }

	public class Relaciones_MASC_Resolucion_de_Solicitud
    {
                public int Clave { get; set; }
        public DateTime? Fecha_de_Resolucion_solicitud { get; set; }
        public string Hora_de_Resolucion_solicitud { get; set; }
        public int? Usuario_que_Resuelve_solicitud { get; set; }
        public int? Resolucion { get; set; }
        public int? Tipo_de_Mecanismo { get; set; }
        public string Observaciones_solicitud { get; set; }
        public DateTime? Fecha_de_Validacion_solicitud { get; set; }
        public string Hora_de_Validacion_solicitud { get; set; }
        public int? Usuario_que_Valida_solicitud { get; set; }
        public short? resultado_solicitud { get; set; }
        public string motivo_rechazo_solicitud { get; set; }

		        [ForeignKey("Usuario_que_Resuelve_solicitud")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Resuelve_solicitud_Spartan_User { get; set; }
        [ForeignKey("Resolucion")]
        public virtual Spartane.Core.Domain.Resolucion_MASC.Resolucion_MASC Resolucion_Resolucion_MASC { get; set; }
        [ForeignKey("Tipo_de_Mecanismo")]
        public virtual Spartane.Core.Domain.Tipo_de_Mecanismo_Alterno.Tipo_de_Mecanismo_Alterno Tipo_de_Mecanismo_Tipo_de_Mecanismo_Alterno { get; set; }
        [ForeignKey("Usuario_que_Valida_solicitud")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Valida_solicitud_Spartan_User { get; set; }
        [ForeignKey("resultado_solicitud")]
        public virtual Spartane.Core.Domain.Resultado_de_Revision.Resultado_de_Revision resultado_solicitud_Resultado_de_Revision { get; set; }

    }

	public class Relaciones_MASC_Resolucion_de_Procedimiento
    {
                public int Clave { get; set; }
        public DateTime? Fecha_de_Resolucion_proc { get; set; }
        public string hora_resolucion_proc { get; set; }
        public int? usuario_resuelve_proc { get; set; }
        public int? Resolucion_proc { get; set; }
        public string Observaciones_proc { get; set; }
        public DateTime? Fecha_de_Validacion_proc { get; set; }
        public string Hora_de_Validacion_proc { get; set; }
        public int? Usuario_que_Valida_proc { get; set; }
        public short? Resultado_proc { get; set; }
        public string Motivo_de_Rechazo_proc { get; set; }

		        [ForeignKey("usuario_resuelve_proc")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User usuario_resuelve_proc_Spartan_User { get; set; }
        [ForeignKey("Resolucion_proc")]
        public virtual Spartane.Core.Domain.Resolucion_MASC.Resolucion_MASC Resolucion_proc_Resolucion_MASC { get; set; }
        [ForeignKey("Usuario_que_Valida_proc")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Valida_proc_Spartan_User { get; set; }
        [ForeignKey("Resultado_proc")]
        public virtual Spartane.Core.Domain.Resultado_de_Revision.Resultado_de_Revision Resultado_proc_Resultado_de_Revision { get; set; }

    }


}

