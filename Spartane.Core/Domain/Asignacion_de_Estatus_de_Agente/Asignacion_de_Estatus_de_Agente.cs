using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Unidad;
using Spartane.Core.Domain.Estatus_de_Agente_MP;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Asignacion_de_Estatus_de_Agente
{
    /// <summary>
    /// Asignacion_de_Estatus_de_Agente table
    /// </summary>
    public class Asignacion_de_Estatus_de_Agente: BaseEntity
    {
        public int Clave { get; set; }
        public int? MP { get; set; }
        public int? Unidad { get; set; }
        public int? Estatus { get; set; }

        [ForeignKey("MP")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User MP_Spartan_User { get; set; }
        [ForeignKey("Unidad")]
        public virtual Spartane.Core.Domain.Unidad.Unidad Unidad_Unidad { get; set; }
        [ForeignKey("Estatus")]
        public virtual Spartane.Core.Domain.Estatus_de_Agente_MP.Estatus_de_Agente_MP Estatus_Estatus_de_Agente_MP { get; set; }

    }
	
	public class Asignacion_de_Estatus_de_Agente_Datos_Generales
    {
                public int Clave { get; set; }
        public int? MP { get; set; }
        public int? Unidad { get; set; }
        public int? Estatus { get; set; }

		        [ForeignKey("MP")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User MP_Spartan_User { get; set; }
        [ForeignKey("Unidad")]
        public virtual Spartane.Core.Domain.Unidad.Unidad Unidad_Unidad { get; set; }
        [ForeignKey("Estatus")]
        public virtual Spartane.Core.Domain.Estatus_de_Agente_MP.Estatus_de_Agente_MP Estatus_Estatus_de_Agente_MP { get; set; }

    }


}

