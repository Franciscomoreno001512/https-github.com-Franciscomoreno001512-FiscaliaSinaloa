using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Unidad;
using Spartane.Core.Domain.Spartan_User;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Modulo
{
    /// <summary>
    /// Modulo table
    /// </summary>
    public class Modulo: BaseEntity
    {
        public int Clave { get; set; }
        public short? Numero_de_Modulo { get; set; }
        public string Descripcion { get; set; }
        public int? Unidad_de_Atencion { get; set; }
        public int? Orientador { get; set; }

        [ForeignKey("Unidad_de_Atencion")]
        public virtual Spartane.Core.Domain.Unidad.Unidad Unidad_de_Atencion_Unidad { get; set; }
        [ForeignKey("Orientador")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Orientador_Spartan_User { get; set; }

    }
	
	public class Modulo_Datos_Generales
    {
                public int Clave { get; set; }
        public short? Numero_de_Modulo { get; set; }
        public string Descripcion { get; set; }
        public int? Unidad_de_Atencion { get; set; }
        public int? Orientador { get; set; }

		        [ForeignKey("Unidad_de_Atencion")]
        public virtual Spartane.Core.Domain.Unidad.Unidad Unidad_de_Atencion_Unidad { get; set; }
        [ForeignKey("Orientador")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Orientador_Spartan_User { get; set; }

    }


}

