using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Origen_de_Invitacion;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Control_de_Citas
{
    /// <summary>
    /// Control_de_Citas table
    /// </summary>
    public class Control_de_Citas: BaseEntity
    {
        public int Folio { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Atiende { get; set; }
        public DateTime? Fecha_de_la_Cita { get; set; }
        public string Hora_de_la_Cita { get; set; }
        public int? Proceso { get; set; }
        public string Numero_de_Expediente { get; set; }
        public string Tipo_de_Cita { get; set; }
        public string Cita { get; set; }
        public bool? Cumplida { get; set; }
        public string Observaciones { get; set; }

        [ForeignKey("Usuario_que_Atiende")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Atiende_Spartan_User { get; set; }
        [ForeignKey("Proceso")]
        public virtual Spartane.Core.Domain.Origen_de_Invitacion.Origen_de_Invitacion Proceso_Origen_de_Invitacion { get; set; }

    }
	
	public class Control_de_Citas_Datos_Generales
    {
                public int Folio { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Atiende { get; set; }
        public DateTime? Fecha_de_la_Cita { get; set; }
        public string Hora_de_la_Cita { get; set; }
        public int? Proceso { get; set; }
        public string Numero_de_Expediente { get; set; }
        public string Tipo_de_Cita { get; set; }
        public string Cita { get; set; }
        public bool? Cumplida { get; set; }
        public string Observaciones { get; set; }

		        [ForeignKey("Usuario_que_Atiende")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Atiende_Spartan_User { get; set; }
        [ForeignKey("Proceso")]
        public virtual Spartane.Core.Domain.Origen_de_Invitacion.Origen_de_Invitacion Proceso_Origen_de_Invitacion { get; set; }

    }


}

