using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Spartan_User;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Bitacora_de_Cambios
{
    /// <summary>
    /// Detalle_de_Bitacora_de_Cambios table
    /// </summary>
    public class Detalle_de_Bitacora_de_Cambios: BaseEntity
    {
        public int Clave { get; set; }
        public DateTime? Fecha_de_Entrada { get; set; }
        public string Hora_de_Entrada { get; set; }
        public int? Usuario { get; set; }

        [ForeignKey("Usuario")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_Spartan_User { get; set; }

    }
	
	public class Detalle_de_Bitacora_de_Cambios_Datos_Generales
    {
                public int Clave { get; set; }
        public DateTime? Fecha_de_Entrada { get; set; }
        public string Hora_de_Entrada { get; set; }
        public int? Usuario { get; set; }

		        [ForeignKey("Usuario")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Usuario_Spartan_User { get; set; }

    }


}

