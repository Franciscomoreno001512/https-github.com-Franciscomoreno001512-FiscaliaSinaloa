using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Modulo_Atencion_Inicial;
using Spartane.Core.Domain.Estatus;
using Spartane.Core.Domain.Estatus_Orientador;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Canalizar_Estatus
{
    /// <summary>
    /// Detalle_de_Canalizar_Estatus table
    /// </summary>
    public class Detalle_de_Canalizar_Estatus: BaseEntity
    {
        public int Clave { get; set; }
        public int? Modulo_Atencion_Inicial { get; set; }
        public DateTime? Fecha_de_Cambio_de_Estatus { get; set; }
        public string Hora_de_Cambio_de_Estatus { get; set; }
        public int? Estatus_Interno { get; set; }
        public int? Estatus_de_Canalizacion { get; set; }

        [ForeignKey("Modulo_Atencion_Inicial")]
        public virtual Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial Modulo_Atencion_Inicial_Modulo_Atencion_Inicial { get; set; }
        [ForeignKey("Estatus_Interno")]
        public virtual Spartane.Core.Domain.Estatus.Estatus Estatus_Interno_Estatus { get; set; }
        [ForeignKey("Estatus_de_Canalizacion")]
        public virtual Spartane.Core.Domain.Estatus_Orientador.Estatus_Orientador Estatus_de_Canalizacion_Estatus_Orientador { get; set; }

    }
	
	public class Detalle_de_Canalizar_Estatus_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Modulo_Atencion_Inicial { get; set; }
        public DateTime? Fecha_de_Cambio_de_Estatus { get; set; }
        public string Hora_de_Cambio_de_Estatus { get; set; }
        public int? Estatus_Interno { get; set; }
        public int? Estatus_de_Canalizacion { get; set; }

		        [ForeignKey("Modulo_Atencion_Inicial")]
        public virtual Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial Modulo_Atencion_Inicial_Modulo_Atencion_Inicial { get; set; }
        [ForeignKey("Estatus_Interno")]
        public virtual Spartane.Core.Domain.Estatus.Estatus Estatus_Interno_Estatus { get; set; }
        [ForeignKey("Estatus_de_Canalizacion")]
        public virtual Spartane.Core.Domain.Estatus_Orientador.Estatus_Orientador Estatus_de_Canalizacion_Estatus_Orientador { get; set; }

    }


}

