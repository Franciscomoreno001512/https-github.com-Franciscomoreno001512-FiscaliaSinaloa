using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Area_de_Servicios_de_Apoyo;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Asignacion_responsable_servicios_apoyo
{
    /// <summary>
    /// Asignacion_responsable_servicios_apoyo table
    /// </summary>
    public class Asignacion_responsable_servicios_apoyo: BaseEntity
    {
        public int Clave { get; set; }
        public int? Usuario { get; set; }
        public int? Area_Asignada { get; set; }

        [ForeignKey("Usuario")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_Spartan_User { get; set; }
        [ForeignKey("Area_Asignada")]
        public virtual Spartane.Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_Apoyo Area_Asignada_Area_de_Servicios_de_Apoyo { get; set; }

    }
	
	public class Asignacion_responsable_servicios_apoyo_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Usuario { get; set; }
        public int? Area_Asignada { get; set; }

		        [ForeignKey("Usuario")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_Spartan_User { get; set; }
        [ForeignKey("Area_Asignada")]
        public virtual Spartane.Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_Apoyo Area_Asignada_Area_de_Servicios_de_Apoyo { get; set; }

    }


}

