using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Region;
using Spartane.Core.Domain.Vigencia;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Tipo_de_Asignacion_de_MP;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Unidad
{
    /// <summary>
    /// Unidad table
    /// </summary>
    public class Unidad: BaseEntity
    {
        public int Clave { get; set; }
        public int? Clave_Unica_Municipio { get; set; }
        public int? Clave_de_Municipio { get; set; }
        public int? Clave_de_Region { get; set; }
        public string Abreviacion { get; set; }
        public string Descripcion { get; set; }
        public string Descripcion_Corta { get; set; }
        public int? Vigencia { get; set; }
        public string Direccion { get; set; }
        public string Observaciones { get; set; }
        public int? Supervisor { get; set; }
        public int? Consecutivo_CDI { get; set; }
        public int? Tipo_de_Asignacion_de_MP { get; set; }

        [ForeignKey("Clave_de_Municipio")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Clave_de_Municipio_Municipio { get; set; }
        [ForeignKey("Clave_de_Region")]
        public virtual Spartane.Core.Domain.Region.Region Clave_de_Region_Region { get; set; }
        [ForeignKey("Vigencia")]
        public virtual Spartane.Core.Domain.Vigencia.Vigencia Vigencia_Vigencia { get; set; }
        [ForeignKey("Supervisor")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Supervisor_Spartan_User { get; set; }
        [ForeignKey("Tipo_de_Asignacion_de_MP")]
        public virtual Spartane.Core.Domain.Tipo_de_Asignacion_de_MP.Tipo_de_Asignacion_de_MP Tipo_de_Asignacion_de_MP_Tipo_de_Asignacion_de_MP { get; set; }

    }
	
	public class Unidad_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Clave_Unica_Municipio { get; set; }
        public int? Clave_de_Municipio { get; set; }
        public int? Clave_de_Region { get; set; }
        public string Abreviacion { get; set; }
        public string Descripcion { get; set; }
        public string Descripcion_Corta { get; set; }
        public int? Vigencia { get; set; }
        public string Direccion { get; set; }
        public string Observaciones { get; set; }
        public int? Supervisor { get; set; }
        public int? Consecutivo_CDI { get; set; }
        public int? Tipo_de_Asignacion_de_MP { get; set; }

		        [ForeignKey("Clave_de_Municipio")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Clave_de_Municipio_Municipio { get; set; }
        [ForeignKey("Clave_de_Region")]
        public virtual Spartane.Core.Domain.Region.Region Clave_de_Region_Region { get; set; }
        [ForeignKey("Vigencia")]
        public virtual Spartane.Core.Domain.Vigencia.Vigencia Vigencia_Vigencia { get; set; }
        [ForeignKey("Supervisor")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Supervisor_Spartan_User { get; set; }
        [ForeignKey("Tipo_de_Asignacion_de_MP")]
        public virtual Spartane.Core.Domain.Tipo_de_Asignacion_de_MP.Tipo_de_Asignacion_de_MP Tipo_de_Asignacion_de_MP_Tipo_de_Asignacion_de_MP { get; set; }

    }


}

