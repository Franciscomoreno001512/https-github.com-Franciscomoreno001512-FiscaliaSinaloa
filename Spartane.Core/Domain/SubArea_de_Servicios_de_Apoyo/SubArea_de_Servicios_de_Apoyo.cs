using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Area_de_Servicios_de_Apoyo;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.SubArea_de_Servicios_de_Apoyo
{
    /// <summary>
    /// SubArea_de_Servicios_de_Apoyo table
    /// </summary>
    public class SubArea_de_Servicios_de_Apoyo: BaseEntity
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Area { get; set; }

        [ForeignKey("Area")]
        public virtual Spartane.Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_Apoyo Area_Area_de_Servicios_de_Apoyo { get; set; }

    }
	
	public class SubArea_de_Servicios_de_Apoyo_Datos_Generales
    {
                public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Area { get; set; }

		        [ForeignKey("Area")]
        public virtual Spartane.Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_Apoyo Area_Area_de_Servicios_de_Apoyo { get; set; }

    }


}

