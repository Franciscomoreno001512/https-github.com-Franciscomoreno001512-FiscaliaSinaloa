using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Certifica_Defuncion;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Consecuencia_Defuncion
{
    /// <summary>
    /// Consecuencia_Defuncion table
    /// </summary>
    public class Consecuencia_Defuncion: BaseEntity
    {
        public short Clave { get; set; }
        public string Descripcion { get; set; }
        public short? Tipo_Defuncion { get; set; }

        [ForeignKey("Tipo_Defuncion")]
        public virtual Spartane.Core.Domain.Certifica_Defuncion.Certifica_Defuncion Tipo_Defuncion_Certifica_Defuncion { get; set; }

    }
	
	public class Consecuencia_Defuncion_Datos_Generales
    {
                public short Clave { get; set; }
        public string Descripcion { get; set; }
        public short? Tipo_Defuncion { get; set; }

		        [ForeignKey("Tipo_Defuncion")]
        public virtual Spartane.Core.Domain.Certifica_Defuncion.Certifica_Defuncion Tipo_Defuncion_Certifica_Defuncion { get; set; }

    }


}

