using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Region;
using Spartane.Core.Domain.Distrito_Judicial;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Delegacion
{
    /// <summary>
    /// Delegacion table
    /// </summary>
    public class Delegacion: BaseEntity
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Zona { get; set; }
        public short? Clave_Expediente { get; set; }
        public string Direccion { get; set; }
        public int? Consecutivo_MPO { get; set; }
        public int? Consecutivo_MPI { get; set; }
        public int? Distrito { get; set; }
        public string Abreviacion_Delegacion { get; set; }

        [ForeignKey("Zona")]
        public virtual Spartane.Core.Domain.Region.Region Zona_Region { get; set; }
        [ForeignKey("Distrito")]
        public virtual Spartane.Core.Domain.Distrito_Judicial.Distrito_Judicial Distrito_Distrito_Judicial { get; set; }

    }
	
	public class Delegacion_Datos_Generales
    {
                public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Zona { get; set; }
        public short? Clave_Expediente { get; set; }
        public string Direccion { get; set; }
        public int? Consecutivo_MPO { get; set; }
        public int? Consecutivo_MPI { get; set; }
        public int? Distrito { get; set; }
        public string Abreviacion_Delegacion { get; set; }

		        [ForeignKey("Zona")]
        public virtual Spartane.Core.Domain.Region.Region Zona_Region { get; set; }
        [ForeignKey("Distrito")]
        public virtual Spartane.Core.Domain.Distrito_Judicial.Distrito_Judicial Distrito_Distrito_Judicial { get; set; }

    }


}

