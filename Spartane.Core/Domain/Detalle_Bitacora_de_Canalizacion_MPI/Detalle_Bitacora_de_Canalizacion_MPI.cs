using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Expediente_Inicial;
using Spartane.Core.Domain.Estatus_de_Expediente_Inicial;
using Spartane.Core.Domain.Estatus_Orientador;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_Bitacora_de_Canalizacion_MPI
{
    /// <summary>
    /// Detalle_Bitacora_de_Canalizacion_MPI table
    /// </summary>
    public class Detalle_Bitacora_de_Canalizacion_MPI: BaseEntity
    {
        public int Clave { get; set; }
        public int? Expediente_Inicial { get; set; }
        public DateTime? Fecha_de_Cambio_de_Estatus { get; set; }
        public string Hora_de_Cambio_de_Estatus { get; set; }
        public short? Estatus_Interno { get; set; }
        public int? Estatus_de_Canalizacion { get; set; }

        [ForeignKey("Expediente_Inicial")]
        public virtual Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial Expediente_Inicial_Expediente_Inicial { get; set; }
        [ForeignKey("Estatus_Interno")]
        public virtual Spartane.Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_Inicial Estatus_Interno_Estatus_de_Expediente_Inicial { get; set; }
        [ForeignKey("Estatus_de_Canalizacion")]
        public virtual Spartane.Core.Domain.Estatus_Orientador.Estatus_Orientador Estatus_de_Canalizacion_Estatus_Orientador { get; set; }

    }
	
	public class Detalle_Bitacora_de_Canalizacion_MPI_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Expediente_Inicial { get; set; }
        public DateTime? Fecha_de_Cambio_de_Estatus { get; set; }
        public string Hora_de_Cambio_de_Estatus { get; set; }
        public short? Estatus_Interno { get; set; }
        public int? Estatus_de_Canalizacion { get; set; }

		        [ForeignKey("Expediente_Inicial")]
        public virtual Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial Expediente_Inicial_Expediente_Inicial { get; set; }
        [ForeignKey("Estatus_Interno")]
        public virtual Spartane.Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_Inicial Estatus_Interno_Estatus_de_Expediente_Inicial { get; set; }
        [ForeignKey("Estatus_de_Canalizacion")]
        public virtual Spartane.Core.Domain.Estatus_Orientador.Estatus_Orientador Estatus_de_Canalizacion_Estatus_Orientador { get; set; }

    }


}

