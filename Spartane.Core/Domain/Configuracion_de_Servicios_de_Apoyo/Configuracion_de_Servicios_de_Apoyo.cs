using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Region;
using Spartane.Core.Domain.Area_de_Servicios_de_Apoyo;
using Spartane.Core.Domain.SubArea_de_Servicios_de_Apoyo;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Configuracion_de_Servicios_de_Apoyo
{
    /// <summary>
    /// Configuracion_de_Servicios_de_Apoyo table
    /// </summary>
    public class Configuracion_de_Servicios_de_Apoyo: BaseEntity
    {
        public int Clave { get; set; }
        public int? Region { get; set; }
        public int? Area { get; set; }
        public int? SubArea { get; set; }
        public bool? Acreditada { get; set; }
        public bool? Centralizada { get; set; }

        [ForeignKey("Region")]
        public virtual Spartane.Core.Domain.Region.Region Region_Region { get; set; }
        [ForeignKey("Area")]
        public virtual Spartane.Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_Apoyo Area_Area_de_Servicios_de_Apoyo { get; set; }
        [ForeignKey("SubArea")]
        public virtual Spartane.Core.Domain.SubArea_de_Servicios_de_Apoyo.SubArea_de_Servicios_de_Apoyo SubArea_SubArea_de_Servicios_de_Apoyo { get; set; }

    }
	
	public class Configuracion_de_Servicios_de_Apoyo_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Region { get; set; }
        public int? Area { get; set; }
        public int? SubArea { get; set; }
        public bool? Acreditada { get; set; }
        public bool? Centralizada { get; set; }

		        [ForeignKey("Region")]
        public virtual Spartane.Core.Domain.Region.Region Region_Region { get; set; }
        [ForeignKey("Area")]
        public virtual Spartane.Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_Apoyo Area_Area_de_Servicios_de_Apoyo { get; set; }
        [ForeignKey("SubArea")]
        public virtual Spartane.Core.Domain.SubArea_de_Servicios_de_Apoyo.SubArea_de_Servicios_de_Apoyo SubArea_SubArea_de_Servicios_de_Apoyo { get; set; }

    }


}

