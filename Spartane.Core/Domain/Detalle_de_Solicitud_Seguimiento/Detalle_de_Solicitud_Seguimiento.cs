using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Solicitud;
using Spartane.Core.Domain.Relaciones_MASC;
using Spartane.Core.Domain.Cumplimiento;
using Spartane.Core.Domain.Forma_de_Cumplimiento;
using Spartane.Core.Domain.A_Tiempo;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Spartane_File;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Solicitud_Seguimiento
{
    /// <summary>
    /// Detalle_de_Solicitud_Seguimiento table
    /// </summary>
    public class Detalle_de_Solicitud_Seguimiento: BaseEntity
    {
        public int Clave { get; set; }
        public int? Solicitud { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public DateTime? Fecha_Requerida { get; set; }
        public int? Relacion { get; set; }
        public int? Cumplimiento { get; set; }
        public DateTime? Fecha_de_Cumplimiento { get; set; }
        public int? Forma_de_Pago { get; set; }
        public decimal? Cantidad_del_Monto { get; set; }
        public string Descripcion_de_Cumplimiento { get; set; }
        public short? Concluir_Acuerdo { get; set; }
        public int? Especialista { get; set; }
        public string Comentarios { get; set; }
        public int? Archivo { get; set; }
        public string Archivo_URL { get; set; }

        [ForeignKey("Solicitud")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Solicitud_Solicitud { get; set; }
        [ForeignKey("Relacion")]
        public virtual Spartane.Core.Domain.Relaciones_MASC.Relaciones_MASC Relacion_Relaciones_MASC { get; set; }
        [ForeignKey("Cumplimiento")]
        public virtual Spartane.Core.Domain.Cumplimiento.Cumplimiento Cumplimiento_Cumplimiento { get; set; }
        [ForeignKey("Forma_de_Pago")]
        public virtual Spartane.Core.Domain.Forma_de_Cumplimiento.Forma_de_Cumplimiento Forma_de_Pago_Forma_de_Cumplimiento { get; set; }
        [ForeignKey("Concluir_Acuerdo")]
        public virtual Spartane.Core.Domain.A_Tiempo.A_Tiempo Concluir_Acuerdo_A_Tiempo { get; set; }
        [ForeignKey("Especialista")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Especialista_Spartan_User { get; set; }
        [ForeignKey("Archivo")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Archivo_Spartane_File { get; set; }

    }
	
	public class Detalle_de_Solicitud_Seguimiento_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Solicitud { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public DateTime? Fecha_Requerida { get; set; }
        public int? Relacion { get; set; }
        public int? Cumplimiento { get; set; }
        public DateTime? Fecha_de_Cumplimiento { get; set; }
        public int? Forma_de_Pago { get; set; }
        public decimal? Cantidad_del_Monto { get; set; }
        public string Descripcion_de_Cumplimiento { get; set; }
        public short? Concluir_Acuerdo { get; set; }
        public int? Especialista { get; set; }
        public string Comentarios { get; set; }
        public int? Archivo { get; set; }
        public string Archivo_URL { get; set; }

		        [ForeignKey("Solicitud")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Solicitud_Solicitud { get; set; }
        [ForeignKey("Relacion")]
        public virtual Spartane.Core.Domain.Relaciones_MASC.Relaciones_MASC Relacion_Relaciones_MASC { get; set; }
        [ForeignKey("Cumplimiento")]
        public virtual Spartane.Core.Domain.Cumplimiento.Cumplimiento Cumplimiento_Cumplimiento { get; set; }
        [ForeignKey("Forma_de_Pago")]
        public virtual Spartane.Core.Domain.Forma_de_Cumplimiento.Forma_de_Cumplimiento Forma_de_Pago_Forma_de_Cumplimiento { get; set; }
        [ForeignKey("Concluir_Acuerdo")]
        public virtual Spartane.Core.Domain.A_Tiempo.A_Tiempo Concluir_Acuerdo_A_Tiempo { get; set; }
        [ForeignKey("Especialista")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Especialista_Spartan_User { get; set; }
        [ForeignKey("Archivo")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Archivo_Spartane_File { get; set; }

    }


}

