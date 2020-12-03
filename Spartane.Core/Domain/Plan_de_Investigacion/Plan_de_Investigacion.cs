using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.expediente_ministerio_publico;
using Spartane.Core.Domain.Spartan_User;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Plan_de_Investigacion
{
    /// <summary>
    /// Plan_de_Investigacion table
    /// </summary>
    public class Plan_de_Investigacion: BaseEntity
    {
        public int Clave { get; set; }
        public int? Expediente_MP { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public DateTime? Fecha_Reunion_Mando_Ministerial { get; set; }
        public string Hora_Reunion_Mando_Ministerial { get; set; }
        public string Asistentes { get; set; }
        public string Acuerdos { get; set; }

        [ForeignKey("Expediente_MP")]
        public virtual Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico Expediente_MP_expediente_ministerio_publico { get; set; }
        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }

    }
	
	public class Plan_de_Investigacion_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Expediente_MP { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public DateTime? Fecha_Reunion_Mando_Ministerial { get; set; }
        public string Hora_Reunion_Mando_Ministerial { get; set; }
        public string Asistentes { get; set; }
        public string Acuerdos { get; set; }

		        [ForeignKey("Expediente_MP")]
        public virtual Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico Expediente_MP_expediente_ministerio_publico { get; set; }
        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }

    }

	public class Plan_de_Investigacion_Actos_de_Investigacion
    {
                public int Clave { get; set; }

		
    }


}

