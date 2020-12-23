using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Tipo_de_Solicitud;
using Spartane.Core.Domain.Estatus_de_Solicitud;
using Spartane.Core.Domain.PC_CanalizarA;
using Spartane.Core.Domain.Unidad;

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
        public int? Canalizar_a { get; set; }
        public int? Unidad_canaliza { get; set; }

        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }
        [ForeignKey("Tipo_de_Solicitud")]
        public virtual Spartane.Core.Domain.Tipo_de_Solicitud.Tipo_de_Solicitud Tipo_de_Solicitud_Tipo_de_Solicitud { get; set; }
        [ForeignKey("Estatus_de_Solicitud")]
        public virtual Spartane.Core.Domain.Estatus_de_Solicitud.Estatus_de_Solicitud Estatus_de_Solicitud_Estatus_de_Solicitud { get; set; }
        [ForeignKey("Canalizar_a")]
        public virtual Spartane.Core.Domain.PC_CanalizarA.PC_CanalizarA Canalizar_a_PC_CanalizarA { get; set; }
        [ForeignKey("Unidad_canaliza")]
        public virtual Spartane.Core.Domain.Unidad.Unidad Unidad_canaliza_Unidad { get; set; }

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

		        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }
        [ForeignKey("Tipo_de_Solicitud")]
        public virtual Spartane.Core.Domain.Tipo_de_Solicitud.Tipo_de_Solicitud Tipo_de_Solicitud_Tipo_de_Solicitud { get; set; }

    }

	public class Solicitud_de_Denuncia_Ciudadana_Canalizar
    {
                public int Clave { get; set; }
        public int? Estatus_de_Solicitud { get; set; }
        public int? Canalizar_a { get; set; }
        public int? Unidad_canaliza { get; set; }

		        [ForeignKey("Estatus_de_Solicitud")]
        public virtual Spartane.Core.Domain.Estatus_de_Solicitud.Estatus_de_Solicitud Estatus_de_Solicitud_Estatus_de_Solicitud { get; set; }
        [ForeignKey("Canalizar_a")]
        public virtual Spartane.Core.Domain.PC_CanalizarA.PC_CanalizarA Canalizar_a_PC_CanalizarA { get; set; }
        [ForeignKey("Unidad_canaliza")]
        public virtual Spartane.Core.Domain.Unidad.Unidad Unidad_canaliza_Unidad { get; set; }

    }


}

