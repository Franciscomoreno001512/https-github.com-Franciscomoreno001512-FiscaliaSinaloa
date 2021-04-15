using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Tipo_de_Solicitud;
using Spartane.Core.Domain.Estatus_de_Solicitud;
using Spartane.Core.Domain.PC_CanalizarA;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Tipo_Resolucion_Portal_Ciudadano;
using Spartane.Core.Domain.Region;
using Spartane.Core.Domain.Unidad;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Contestacion_de_Portal_Ciudadano;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Solicitud_de_Denuncia_Ciudadana
{
    /// <summary>
    /// Solicitud_de_Denuncia_Ciudadana table
    /// </summary>
    public class Solicitud_de_Denuncia_Ciudadana: BaseEntity
    {
        public int Clave { get; set; }
        public string Folio { get; set; }
        public string Contrasena { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public int? Tipo_de_Solicitud { get; set; }
        public int? Estatus_de_Solicitud { get; set; }
        public string Motivo { get; set; }
        public int? Canalizar_a { get; set; }
        public DateTime? Fecha_de_Revision { get; set; }
        public string Hora_de_Revision { get; set; }
        public int? Usuario_que_Revisa { get; set; }
        public int? Tipo_de_Resolucion { get; set; }
        public int? Region { get; set; }
        public int? Unidad_canaliza { get; set; }
        public string Contestacion { get; set; }
        public string Observaciones_resolucion { get; set; }
        public DateTime? Fecha_de_Asignacion { get; set; }
        public string Hora_de_Asignacion { get; set; }
        public int? Usuario_que_Asigna { get; set; }
        public int? Responsable_Asignado { get; set; }
        public string Observaciones_responsable { get; set; }
        public DateTime? Fecha_de_Atencion { get; set; }
        public string Hora_de_Atencion { get; set; }
        public int? Usuario_que_Atiende { get; set; }
        public int? Atencion_Realizada { get; set; }
        public string Observaciones_atencion { get; set; }

        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }
        [ForeignKey("Tipo_de_Solicitud")]
        public virtual Spartane.Core.Domain.Tipo_de_Solicitud.Tipo_de_Solicitud Tipo_de_Solicitud_Tipo_de_Solicitud { get; set; }
        [ForeignKey("Estatus_de_Solicitud")]
        public virtual Spartane.Core.Domain.Estatus_de_Solicitud.Estatus_de_Solicitud Estatus_de_Solicitud_Estatus_de_Solicitud { get; set; }
        [ForeignKey("Canalizar_a")]
        public virtual Spartane.Core.Domain.PC_CanalizarA.PC_CanalizarA Canalizar_a_PC_CanalizarA { get; set; }
        [ForeignKey("Usuario_que_Revisa")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Revisa_Spartan_User { get; set; }
        [ForeignKey("Tipo_de_Resolucion")]
        public virtual Spartane.Core.Domain.Tipo_Resolucion_Portal_Ciudadano.Tipo_Resolucion_Portal_Ciudadano Tipo_de_Resolucion_Tipo_Resolucion_Portal_Ciudadano { get; set; }
        [ForeignKey("Region")]
        public virtual Spartane.Core.Domain.Region.Region Region_Region { get; set; }
        [ForeignKey("Unidad_canaliza")]
        public virtual Spartane.Core.Domain.Unidad.Unidad Unidad_canaliza_Unidad { get; set; }
        [ForeignKey("Usuario_que_Asigna")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Asigna_Spartan_User { get; set; }
        [ForeignKey("Responsable_Asignado")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Responsable_Asignado_Spartan_User { get; set; }
        [ForeignKey("Usuario_que_Atiende")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Atiende_Spartan_User { get; set; }
        [ForeignKey("Atencion_Realizada")]
        public virtual Spartane.Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_Ciudadano Atencion_Realizada_Contestacion_de_Portal_Ciudadano { get; set; }

    }
	
	public class Solicitud_de_Denuncia_Ciudadana_Datos_de_la_Solicitud
    {
                public int Clave { get; set; }
        public string Folio { get; set; }
        public string Contrasena { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public int? Tipo_de_Solicitud { get; set; }
        public int? Estatus_de_Solicitud { get; set; }

		        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }
        [ForeignKey("Tipo_de_Solicitud")]
        public virtual Spartane.Core.Domain.Tipo_de_Solicitud.Tipo_de_Solicitud Tipo_de_Solicitud_Tipo_de_Solicitud { get; set; }
        [ForeignKey("Estatus_de_Solicitud")]
        public virtual Spartane.Core.Domain.Estatus_de_Solicitud.Estatus_de_Solicitud Estatus_de_Solicitud_Estatus_de_Solicitud { get; set; }

    }

	public class Solicitud_de_Denuncia_Ciudadana_Resolucion
    {
                public int Clave { get; set; }
        public string Motivo { get; set; }
        public int? Canalizar_a { get; set; }
        public DateTime? Fecha_de_Revision { get; set; }
        public string Hora_de_Revision { get; set; }
        public int? Usuario_que_Revisa { get; set; }
        public int? Tipo_de_Resolucion { get; set; }
        public int? Region { get; set; }
        public int? Unidad_canaliza { get; set; }
        public string Contestacion { get; set; }
        public string Observaciones_resolucion { get; set; }

		        [ForeignKey("Canalizar_a")]
        public virtual Spartane.Core.Domain.PC_CanalizarA.PC_CanalizarA Canalizar_a_PC_CanalizarA { get; set; }
        [ForeignKey("Usuario_que_Revisa")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Revisa_Spartan_User { get; set; }
        [ForeignKey("Tipo_de_Resolucion")]
        public virtual Spartane.Core.Domain.Tipo_Resolucion_Portal_Ciudadano.Tipo_Resolucion_Portal_Ciudadano Tipo_de_Resolucion_Tipo_Resolucion_Portal_Ciudadano { get; set; }
        [ForeignKey("Region")]
        public virtual Spartane.Core.Domain.Region.Region Region_Region { get; set; }
        [ForeignKey("Unidad_canaliza")]
        public virtual Spartane.Core.Domain.Unidad.Unidad Unidad_canaliza_Unidad { get; set; }

    }

	public class Solicitud_de_Denuncia_Ciudadana_Asignar_Responsable_de_Atencion
    {
                public int Clave { get; set; }
        public DateTime? Fecha_de_Asignacion { get; set; }
        public string Hora_de_Asignacion { get; set; }
        public int? Usuario_que_Asigna { get; set; }
        public int? Responsable_Asignado { get; set; }
        public string Observaciones_responsable { get; set; }

		        [ForeignKey("Usuario_que_Asigna")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Asigna_Spartan_User { get; set; }
        [ForeignKey("Responsable_Asignado")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Responsable_Asignado_Spartan_User { get; set; }

    }

	public class Solicitud_de_Denuncia_Ciudadana_Atencion
    {
                public int Clave { get; set; }
        public DateTime? Fecha_de_Atencion { get; set; }
        public string Hora_de_Atencion { get; set; }
        public int? Usuario_que_Atiende { get; set; }
        public int? Atencion_Realizada { get; set; }
        public string Observaciones_atencion { get; set; }

		        [ForeignKey("Usuario_que_Atiende")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Atiende_Spartan_User { get; set; }
        [ForeignKey("Atencion_Realizada")]
        public virtual Spartane.Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_Ciudadano Atencion_Realizada_Contestacion_de_Portal_Ciudadano { get; set; }

    }


}

