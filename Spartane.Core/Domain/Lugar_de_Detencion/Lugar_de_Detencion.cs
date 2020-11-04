using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Imputado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Corporacion;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Lugar_de_Detencion
{
    /// <summary>
    /// Lugar_de_Detencion table
    /// </summary>
    public class Lugar_de_Detencion: BaseEntity
    {
        public int Clave { get; set; }
        public int? Probable_Responsable { get; set; }
        public DateTime? Fecha_de_Detencion { get; set; }
        public int? Municipio_de_Detencion { get; set; }
        public int? Corporacion { get; set; }
        public bool? Suspension_Condicional { get; set; }
        public DateTime? Fecha_de_Suspension_Condicional { get; set; }

        [ForeignKey("Probable_Responsable")]
        public virtual Spartane.Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado Probable_Responsable_Detalle_de_Imputado { get; set; }
        [ForeignKey("Municipio_de_Detencion")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_de_Detencion_Municipio { get; set; }
        [ForeignKey("Corporacion")]
        public virtual Spartane.Core.Domain.Corporacion.Corporacion Corporacion_Corporacion { get; set; }

    }
	
	public class Lugar_de_Detencion_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Probable_Responsable { get; set; }
        public DateTime? Fecha_de_Detencion { get; set; }
        public int? Municipio_de_Detencion { get; set; }
        public int? Corporacion { get; set; }
        public bool? Suspension_Condicional { get; set; }
        public DateTime? Fecha_de_Suspension_Condicional { get; set; }

		        [ForeignKey("Probable_Responsable")]
        public virtual Spartane.Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado Probable_Responsable_Detalle_de_Imputado { get; set; }
        [ForeignKey("Municipio_de_Detencion")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_de_Detencion_Municipio { get; set; }
        [ForeignKey("Corporacion")]
        public virtual Spartane.Core.Domain.Corporacion.Corporacion Corporacion_Corporacion { get; set; }

    }


}

