using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.expediente_ministerio_publico;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Spartan_User;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Asignacion_de_Agente
{
    /// <summary>
    /// Asignacion_de_Agente table
    /// </summary>
    public class Asignacion_de_Agente: BaseEntity
    {
        public int Clave { get; set; }
        public int? Expediente_MP { get; set; }
        public DateTime? Fecha_de_Asignacion { get; set; }
        public string Hora_de_Asignacion { get; set; }
        public int? Usuario_que_Asigna { get; set; }
        public int? Agente_Asignado { get; set; }
        public string Observaciones { get; set; }

        [ForeignKey("Expediente_MP")]
        public virtual Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico Expediente_MP_expediente_ministerio_publico { get; set; }
        [ForeignKey("Usuario_que_Asigna")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Asigna_Spartan_User { get; set; }
        [ForeignKey("Agente_Asignado")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Agente_Asignado_Spartan_User { get; set; }

    }
	
	public class Asignacion_de_Agente_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Expediente_MP { get; set; }
        public DateTime? Fecha_de_Asignacion { get; set; }
        public string Hora_de_Asignacion { get; set; }
        public int? Usuario_que_Asigna { get; set; }
        public int? Agente_Asignado { get; set; }
        public string Observaciones { get; set; }

		        [ForeignKey("Expediente_MP")]
        public virtual Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico Expediente_MP_expediente_ministerio_publico { get; set; }
        [ForeignKey("Usuario_que_Asigna")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Asigna_Spartan_User { get; set; }
        [ForeignKey("Agente_Asignado")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Agente_Asignado_Spartan_User { get; set; }

    }


}

