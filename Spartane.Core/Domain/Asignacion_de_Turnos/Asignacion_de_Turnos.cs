using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Unidad;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Genero;
using Spartane.Core.Domain.Tipo_de_Atencion;
using Spartane.Core.Domain.Tipo_de_Identificacion;
using Spartane.Core.Domain.Tipo_de_Urgencia;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Estatus_de_Turno;
using Spartane.Core.Domain.Modulo;
using Spartane.Core.Domain.Motivo_Finalizacion_Turno;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Asignacion_de_Turnos
{
    /// <summary>
    /// Asignacion_de_Turnos table
    /// </summary>
    public class Asignacion_de_Turnos: BaseEntity
    {
        public int Folio { get; set; }
        public DateTime? Fecha_de_Turno { get; set; }
        public string Hora_de_Turno { get; set; }
        public string Numero_de_Turno { get; set; }
        public int? Unidad_de_Atencion { get; set; }
        public int? Recepcion { get; set; }
        public string Nombres { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Nombre_Completo { get; set; }
        public int? Sexo { get; set; }
        public short? Edad { get; set; }
        public int? Tipo_de_Atencion { get; set; }
        public int? Tipo_de_Identificacion { get; set; }
        public string Otra_Identificacion { get; set; }
        public string Numero_de_Identificacion { get; set; }
        public bool? Urgencia { get; set; }
        public int? Tipo_de_Urgencia { get; set; }
        public int? Orientador { get; set; }
        public int? Estatus_de_Turno { get; set; }
        public int? Modulo { get; set; }
        public int? Motivo_Finalizacion_Turno { get; set; }
        public string Observaciones { get; set; }
        public DateTime? Fecha_de_Asignacion { get; set; }
        public string Hora_de_Asignacion { get; set; }
        public DateTime? Fecha_de_Finalizacion { get; set; }
        public string Hora_de_Finalizacion { get; set; }

        [ForeignKey("Unidad_de_Atencion")]
        public virtual Spartane.Core.Domain.Unidad.Unidad Unidad_de_Atencion_Unidad { get; set; }
        [ForeignKey("Recepcion")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Recepcion_Spartan_User { get; set; }
        [ForeignKey("Sexo")]
        public virtual Spartane.Core.Domain.Genero.Genero Sexo_Genero { get; set; }
        [ForeignKey("Tipo_de_Atencion")]
        public virtual Spartane.Core.Domain.Tipo_de_Atencion.Tipo_de_Atencion Tipo_de_Atencion_Tipo_de_Atencion { get; set; }
        [ForeignKey("Tipo_de_Identificacion")]
        public virtual Spartane.Core.Domain.Tipo_de_Identificacion.Tipo_de_Identificacion Tipo_de_Identificacion_Tipo_de_Identificacion { get; set; }
        [ForeignKey("Tipo_de_Urgencia")]
        public virtual Spartane.Core.Domain.Tipo_de_Urgencia.Tipo_de_Urgencia Tipo_de_Urgencia_Tipo_de_Urgencia { get; set; }
        [ForeignKey("Orientador")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Orientador_Spartan_User { get; set; }
        [ForeignKey("Estatus_de_Turno")]
        public virtual Spartane.Core.Domain.Estatus_de_Turno.Estatus_de_Turno Estatus_de_Turno_Estatus_de_Turno { get; set; }
        [ForeignKey("Modulo")]
        public virtual Spartane.Core.Domain.Modulo.Modulo Modulo_Modulo { get; set; }
        [ForeignKey("Motivo_Finalizacion_Turno")]
        public virtual Spartane.Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_Turno Motivo_Finalizacion_Turno_Motivo_Finalizacion_Turno { get; set; }

    }
	
	public class Asignacion_de_Turnos_Datos_Generales
    {
                public int Folio { get; set; }
        public DateTime? Fecha_de_Turno { get; set; }
        public string Hora_de_Turno { get; set; }
        public string Numero_de_Turno { get; set; }
        public int? Unidad_de_Atencion { get; set; }
        public int? Recepcion { get; set; }
        public string Nombres { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Nombre_Completo { get; set; }
        public int? Sexo { get; set; }
        public short? Edad { get; set; }
        public int? Tipo_de_Atencion { get; set; }
        public int? Tipo_de_Identificacion { get; set; }
        public string Otra_Identificacion { get; set; }
        public string Numero_de_Identificacion { get; set; }
        public bool? Urgencia { get; set; }
        public int? Tipo_de_Urgencia { get; set; }
        public int? Orientador { get; set; }
        public int? Estatus_de_Turno { get; set; }
        public int? Modulo { get; set; }
        public int? Motivo_Finalizacion_Turno { get; set; }
        public string Observaciones { get; set; }
        public DateTime? Fecha_de_Asignacion { get; set; }
        public string Hora_de_Asignacion { get; set; }
        public DateTime? Fecha_de_Finalizacion { get; set; }
        public string Hora_de_Finalizacion { get; set; }

		        [ForeignKey("Unidad_de_Atencion")]
        public virtual Spartane.Core.Domain.Unidad.Unidad Unidad_de_Atencion_Unidad { get; set; }
        [ForeignKey("Recepcion")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Recepcion_Spartan_User { get; set; }
        [ForeignKey("Sexo")]
        public virtual Spartane.Core.Domain.Genero.Genero Sexo_Genero { get; set; }
        [ForeignKey("Tipo_de_Atencion")]
        public virtual Spartane.Core.Domain.Tipo_de_Atencion.Tipo_de_Atencion Tipo_de_Atencion_Tipo_de_Atencion { get; set; }
        [ForeignKey("Tipo_de_Identificacion")]
        public virtual Spartane.Core.Domain.Tipo_de_Identificacion.Tipo_de_Identificacion Tipo_de_Identificacion_Tipo_de_Identificacion { get; set; }
        [ForeignKey("Tipo_de_Urgencia")]
        public virtual Spartane.Core.Domain.Tipo_de_Urgencia.Tipo_de_Urgencia Tipo_de_Urgencia_Tipo_de_Urgencia { get; set; }
        [ForeignKey("Orientador")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Orientador_Spartan_User { get; set; }
        [ForeignKey("Estatus_de_Turno")]
        public virtual Spartane.Core.Domain.Estatus_de_Turno.Estatus_de_Turno Estatus_de_Turno_Estatus_de_Turno { get; set; }
        [ForeignKey("Modulo")]
        public virtual Spartane.Core.Domain.Modulo.Modulo Modulo_Modulo { get; set; }
        [ForeignKey("Motivo_Finalizacion_Turno")]
        public virtual Spartane.Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_Turno Motivo_Finalizacion_Turno_Motivo_Finalizacion_Turno { get; set; }

    }


}

