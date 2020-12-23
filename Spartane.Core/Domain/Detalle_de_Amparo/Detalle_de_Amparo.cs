using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Registro_de_Mandamiento_Judicial;
using Spartane.Core.Domain.Tipo_de_Amparo;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Tipo_de_Resolucion;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Amparo
{
    /// <summary>
    /// Detalle_de_Amparo table
    /// </summary>
    public class Detalle_de_Amparo: BaseEntity
    {
        public int Clave { get; set; }
        public int? Orden_de_Aprehension { get; set; }
        public int? Tipo_de_Amparo { get; set; }
        public string Numero_de_Amparo { get; set; }
        public DateTime? Fecha_Amparo { get; set; }
        public int? Entidad_que_Emitio_Amparo { get; set; }
        public int? Resolucion { get; set; }

        [ForeignKey("Orden_de_Aprehension")]
        public virtual Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial Orden_de_Aprehension_Registro_de_Mandamiento_Judicial { get; set; }
        [ForeignKey("Tipo_de_Amparo")]
        public virtual Spartane.Core.Domain.Tipo_de_Amparo.Tipo_de_Amparo Tipo_de_Amparo_Tipo_de_Amparo { get; set; }
        [ForeignKey("Entidad_que_Emitio_Amparo")]
        public virtual Spartane.Core.Domain.Estado.Estado Entidad_que_Emitio_Amparo_Estado { get; set; }
        [ForeignKey("Resolucion")]
        public virtual Spartane.Core.Domain.Tipo_de_Resolucion.Tipo_de_Resolucion Resolucion_Tipo_de_Resolucion { get; set; }

    }
	
	public class Detalle_de_Amparo_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Orden_de_Aprehension { get; set; }
        public int? Tipo_de_Amparo { get; set; }
        public string Numero_de_Amparo { get; set; }
        public DateTime? Fecha_Amparo { get; set; }
        public int? Entidad_que_Emitio_Amparo { get; set; }
        public int? Resolucion { get; set; }

		        [ForeignKey("Orden_de_Aprehension")]
        public virtual Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial Orden_de_Aprehension_Registro_de_Mandamiento_Judicial { get; set; }
        [ForeignKey("Tipo_de_Amparo")]
        public virtual Spartane.Core.Domain.Tipo_de_Amparo.Tipo_de_Amparo Tipo_de_Amparo_Tipo_de_Amparo { get; set; }
        [ForeignKey("Entidad_que_Emitio_Amparo")]
        public virtual Spartane.Core.Domain.Estado.Estado Entidad_que_Emitio_Amparo_Estado { get; set; }
        [ForeignKey("Resolucion")]
        public virtual Spartane.Core.Domain.Tipo_de_Resolucion.Tipo_de_Resolucion Resolucion_Tipo_de_Resolucion { get; set; }

    }


}

