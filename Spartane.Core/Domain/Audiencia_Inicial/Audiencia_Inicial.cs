using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.expediente_ministerio_publico;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Tipo_de_Judicializacion;
using Spartane.Core.Domain.A_Tiempo;
using Spartane.Core.Domain.Especificacion_Detencion;
using Spartane.Core.Domain.Control_de_Detencion;
using Spartane.Core.Domain.Continuacion_de_Proceso;
using Spartane.Core.Domain.Formulacion_de_Imputacion;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Audiencia_Inicial
{
    /// <summary>
    /// Audiencia_Inicial table
    /// </summary>
    public class Audiencia_Inicial: BaseEntity
    {
        public int Clave { get; set; }
        public int? Expediente_MP { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Nombre_del_Juez_de_Control { get; set; }
        public int? Tipo { get; set; }
        public string causa_penal { get; set; }
        public DateTime? Fecha_Audiencia_Inicial { get; set; }
        public string Hora_Audiencia_Inicial { get; set; }
        public string Sala_de_Audiencia { get; set; }
        public short? Con_Detenido { get; set; }
        public int? Especificar_Detencion { get; set; }
        public int? Control_de_Detencion { get; set; }
        public int? Especificar_Control_Detencion { get; set; }
        public int? Formulacion_de_Imputacion { get; set; }

        [ForeignKey("Expediente_MP")]
        public virtual Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico Expediente_MP_expediente_ministerio_publico { get; set; }
        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }
        [ForeignKey("Tipo")]
        public virtual Spartane.Core.Domain.Tipo_de_Judicializacion.Tipo_de_Judicializacion Tipo_Tipo_de_Judicializacion { get; set; }
        [ForeignKey("Con_Detenido")]
        public virtual Spartane.Core.Domain.A_Tiempo.A_Tiempo Con_Detenido_A_Tiempo { get; set; }
        [ForeignKey("Especificar_Detencion")]
        public virtual Spartane.Core.Domain.Especificacion_Detencion.Especificacion_Detencion Especificar_Detencion_Especificacion_Detencion { get; set; }
        [ForeignKey("Control_de_Detencion")]
        public virtual Spartane.Core.Domain.Control_de_Detencion.Control_de_Detencion Control_de_Detencion_Control_de_Detencion { get; set; }
        [ForeignKey("Especificar_Control_Detencion")]
        public virtual Spartane.Core.Domain.Continuacion_de_Proceso.Continuacion_de_Proceso Especificar_Control_Detencion_Continuacion_de_Proceso { get; set; }
        [ForeignKey("Formulacion_de_Imputacion")]
        public virtual Spartane.Core.Domain.Formulacion_de_Imputacion.Formulacion_de_Imputacion Formulacion_de_Imputacion_Formulacion_de_Imputacion { get; set; }

    }
	
	public class Audiencia_Inicial_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Expediente_MP { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Nombre_del_Juez_de_Control { get; set; }
        public int? Tipo { get; set; }
        public string causa_penal { get; set; }
        public DateTime? Fecha_Audiencia_Inicial { get; set; }
        public string Hora_Audiencia_Inicial { get; set; }
        public string Sala_de_Audiencia { get; set; }
        public short? Con_Detenido { get; set; }
        public int? Especificar_Detencion { get; set; }
        public int? Control_de_Detencion { get; set; }
        public int? Especificar_Control_Detencion { get; set; }
        public int? Formulacion_de_Imputacion { get; set; }

		        [ForeignKey("Expediente_MP")]
        public virtual Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico Expediente_MP_expediente_ministerio_publico { get; set; }
        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }
        [ForeignKey("Tipo")]
        public virtual Spartane.Core.Domain.Tipo_de_Judicializacion.Tipo_de_Judicializacion Tipo_Tipo_de_Judicializacion { get; set; }
        [ForeignKey("Con_Detenido")]
        public virtual Spartane.Core.Domain.A_Tiempo.A_Tiempo Con_Detenido_A_Tiempo { get; set; }
        [ForeignKey("Especificar_Detencion")]
        public virtual Spartane.Core.Domain.Especificacion_Detencion.Especificacion_Detencion Especificar_Detencion_Especificacion_Detencion { get; set; }
        [ForeignKey("Control_de_Detencion")]
        public virtual Spartane.Core.Domain.Control_de_Detencion.Control_de_Detencion Control_de_Detencion_Control_de_Detencion { get; set; }
        [ForeignKey("Especificar_Control_Detencion")]
        public virtual Spartane.Core.Domain.Continuacion_de_Proceso.Continuacion_de_Proceso Especificar_Control_Detencion_Continuacion_de_Proceso { get; set; }
        [ForeignKey("Formulacion_de_Imputacion")]
        public virtual Spartane.Core.Domain.Formulacion_de_Imputacion.Formulacion_de_Imputacion Formulacion_de_Imputacion_Formulacion_de_Imputacion { get; set; }

    }


}

