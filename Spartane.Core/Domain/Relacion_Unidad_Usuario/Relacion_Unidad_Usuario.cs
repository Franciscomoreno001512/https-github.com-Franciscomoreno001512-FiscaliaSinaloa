using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Unidad;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Relacion_Unidad_Usuario
{
    /// <summary>
    /// Relacion_Unidad_Usuario table
    /// </summary>
    public class Relacion_Unidad_Usuario: BaseEntity
    {
        public int Clave { get; set; }
        public int? Usuario { get; set; }
        public int? Unidad { get; set; }

        [ForeignKey("Usuario")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_Spartan_User { get; set; }
        [ForeignKey("Unidad")]
        public virtual Spartane.Core.Domain.Unidad.Unidad Unidad_Unidad { get; set; }

    }
	
	public class Relacion_Unidad_Usuario_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Usuario { get; set; }
        public int? Unidad { get; set; }

		        [ForeignKey("Usuario")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_Spartan_User { get; set; }
        [ForeignKey("Unidad")]
        public virtual Spartane.Core.Domain.Unidad.Unidad Unidad_Unidad { get; set; }

    }


}

