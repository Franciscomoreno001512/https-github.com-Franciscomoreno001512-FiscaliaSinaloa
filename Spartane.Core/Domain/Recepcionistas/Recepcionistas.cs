using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Spartan_User;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Recepcionistas
{
    /// <summary>
    /// Recepcionistas table
    /// </summary>
    public class Recepcionistas: BaseEntity
    {
        public int Clave { get; set; }
        public int? Nombre { get; set; }

        [ForeignKey("Nombre")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Nombre_Spartan_User { get; set; }

    }
	
	public class Recepcionistas_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Nombre { get; set; }

		        [ForeignKey("Nombre")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Nombre_Spartan_User { get; set; }

    }


}

