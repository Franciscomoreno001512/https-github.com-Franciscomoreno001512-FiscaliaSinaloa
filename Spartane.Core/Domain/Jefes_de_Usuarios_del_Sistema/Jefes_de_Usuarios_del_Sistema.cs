using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Region;
using Spartane.Core.Domain.Unidad;
using Spartane.Core.Domain.Vigencia;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Jefes_de_Usuarios_del_Sistema
{
    /// <summary>
    /// Jefes_de_Usuarios_del_Sistema table
    /// </summary>
    public class Jefes_de_Usuarios_del_Sistema: BaseEntity
    {
        public int Clave { get; set; }
        public int? Region { get; set; }
        public string Ministerio_Publico_en_Turno { get; set; }
        public int? Unidad { get; set; }
        public int? Vigencia { get; set; }
        public string Observaciones { get; set; }

        [ForeignKey("Region")]
        public virtual Spartane.Core.Domain.Region.Region Region_Region { get; set; }
        [ForeignKey("Unidad")]
        public virtual Spartane.Core.Domain.Unidad.Unidad Unidad_Unidad { get; set; }
        [ForeignKey("Vigencia")]
        public virtual Spartane.Core.Domain.Vigencia.Vigencia Vigencia_Vigencia { get; set; }

    }
	
	public class Jefes_de_Usuarios_del_Sistema_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Region { get; set; }
        public string Ministerio_Publico_en_Turno { get; set; }
        public int? Unidad { get; set; }
        public int? Vigencia { get; set; }
        public string Observaciones { get; set; }

		        [ForeignKey("Region")]
        public virtual Spartane.Core.Domain.Region.Region Region_Region { get; set; }
        [ForeignKey("Unidad")]
        public virtual Spartane.Core.Domain.Unidad.Unidad Unidad_Unidad { get; set; }
        [ForeignKey("Vigencia")]
        public virtual Spartane.Core.Domain.Vigencia.Vigencia Vigencia_Vigencia { get; set; }

    }


}

