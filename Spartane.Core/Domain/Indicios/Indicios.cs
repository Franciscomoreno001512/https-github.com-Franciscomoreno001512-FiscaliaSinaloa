using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Expediente_Inicial;
using Spartane.Core.Domain.Delegacion;
using Spartane.Core.Domain.Agencia;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Indicios
{
    /// <summary>
    /// Indicios table
    /// </summary>
    public class Indicios: BaseEntity
    {
        public int Clave { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public int? NUC { get; set; }
        public string NIC { get; set; }
        public int? Delegacion { get; set; }
        public int? Agencia { get; set; }
        public string Clave_Indicio { get; set; }

        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }
        [ForeignKey("NUC")]
        public virtual Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial NUC_Expediente_Inicial { get; set; }
        [ForeignKey("Delegacion")]
        public virtual Spartane.Core.Domain.Delegacion.Delegacion Delegacion_Delegacion { get; set; }
        [ForeignKey("Agencia")]
        public virtual Spartane.Core.Domain.Agencia.Agencia Agencia_Agencia { get; set; }

    }
	
	public class Indicios_Registro_de_Indicios
    {
                public int Clave { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public int? NUC { get; set; }
        public string NIC { get; set; }
        public int? Delegacion { get; set; }
        public int? Agencia { get; set; }
        public string Clave_Indicio { get; set; }

		        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }
        [ForeignKey("NUC")]
        public virtual Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial NUC_Expediente_Inicial { get; set; }
        [ForeignKey("Delegacion")]
        public virtual Spartane.Core.Domain.Delegacion.Delegacion Delegacion_Delegacion { get; set; }
        [ForeignKey("Agencia")]
        public virtual Spartane.Core.Domain.Agencia.Agencia Agencia_Agencia { get; set; }

    }

	public class Indicios_Datos_Indicios
    {
                public int Clave { get; set; }

		
    }

	public class Indicios_Solicitud_de_Indicios
    {
                public int Clave { get; set; }

		
    }

	public class Indicios_Devolucion_de_Indicios
    {
                public int Clave { get; set; }

		
    }


}

