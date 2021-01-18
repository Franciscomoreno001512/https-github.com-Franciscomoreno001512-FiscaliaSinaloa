using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Tipo_de_queja_sugerencia;
using Spartane.Core.Domain.Estatus_queja_sugerencia;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Queja_Sugerencia_Ciudadana
{
    /// <summary>
    /// Queja_Sugerencia_Ciudadana table
    /// </summary>
    public class Queja_Sugerencia_Ciudadana: BaseEntity
    {
        public int Folio { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public int? Tipo_de_Registro { get; set; }
        public string Queja { get; set; }
        public string Sugerencia { get; set; }
        public int? Estatus { get; set; }
        public string Motivo_de_Eliminacion { get; set; }
        public string Contestacion { get; set; }

        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }
        [ForeignKey("Tipo_de_Registro")]
        public virtual Spartane.Core.Domain.Tipo_de_queja_sugerencia.Tipo_de_queja_sugerencia Tipo_de_Registro_Tipo_de_queja_sugerencia { get; set; }
        [ForeignKey("Estatus")]
        public virtual Spartane.Core.Domain.Estatus_queja_sugerencia.Estatus_queja_sugerencia Estatus_Estatus_queja_sugerencia { get; set; }

    }
	
	public class Queja_Sugerencia_Ciudadana_Datos_Generales
    {
                public int Folio { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public int? Tipo_de_Registro { get; set; }
        public string Queja { get; set; }
        public string Sugerencia { get; set; }
        public int? Estatus { get; set; }
        public string Motivo_de_Eliminacion { get; set; }
        public string Contestacion { get; set; }

		        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }
        [ForeignKey("Tipo_de_Registro")]
        public virtual Spartane.Core.Domain.Tipo_de_queja_sugerencia.Tipo_de_queja_sugerencia Tipo_de_Registro_Tipo_de_queja_sugerencia { get; set; }
        [ForeignKey("Estatus")]
        public virtual Spartane.Core.Domain.Estatus_queja_sugerencia.Estatus_queja_sugerencia Estatus_Estatus_queja_sugerencia { get; set; }

    }


}

