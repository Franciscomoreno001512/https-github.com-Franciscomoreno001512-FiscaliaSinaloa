using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.A_Tiempo;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Especificacion_Detencion
{
    /// <summary>
    /// Especificacion_Detencion table
    /// </summary>
    public class Especificacion_Detencion: BaseEntity
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public short? Detenido { get; set; }

        [ForeignKey("Detenido")]
        public virtual Spartane.Core.Domain.A_Tiempo.A_Tiempo Detenido_A_Tiempo { get; set; }

    }
	
	public class Especificacion_Detencion_Datos_Generales
    {
                public int Clave { get; set; }
        public string Descripcion { get; set; }
        public short? Detenido { get; set; }

		        [ForeignKey("Detenido")]
        public virtual Spartane.Core.Domain.A_Tiempo.A_Tiempo Detenido_A_Tiempo { get; set; }

    }


}

