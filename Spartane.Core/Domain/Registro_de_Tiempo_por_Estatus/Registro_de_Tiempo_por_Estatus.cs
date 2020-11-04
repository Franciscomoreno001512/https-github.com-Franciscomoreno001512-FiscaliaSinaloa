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

namespace Spartane.Core.Domain.Registro_de_Tiempo_por_Estatus
{
    /// <summary>
    /// Registro_de_Tiempo_por_Estatus table
    /// </summary>
    public class Registro_de_Tiempo_por_Estatus: BaseEntity
    {
        public int Clave { get; set; }
        public DateTime? Fecha { get; set; }
        public string Hora { get; set; }
        public int? NUAT { get; set; }
        public int? Estatus_Interno { get; set; }
        public int? Estatus { get; set; }
        public int? Estatus_Destino { get; set; }
        public string Tiempo_Transcurrido { get; set; }

        [ForeignKey("NUAT")]
        public virtual Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial NUAT_Modulo_Atencion_Inicial { get; set; }
        [ForeignKey("Estatus_Interno")]
        public virtual Spartane.Core.Domain.Estatus.Estatus Estatus_Interno_Estatus { get; set; }
        [ForeignKey("Estatus")]
        public virtual Spartane.Core.Domain.Estatus_Orientador.Estatus_Orientador Estatus_Estatus_Orientador { get; set; }

    }
	
	public class Registro_de_Tiempo_por_Estatus_Datos_Generales
    {
                public int Clave { get; set; }
        public DateTime? Fecha { get; set; }
        public string Hora { get; set; }
        public int? NUAT { get; set; }
        public int? Estatus_Interno { get; set; }
        public int? Estatus { get; set; }
        public int? Estatus_Destino { get; set; }
        public string Tiempo_Transcurrido { get; set; }

		        [ForeignKey("NUAT")]
        public virtual Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial NUAT_Modulo_Atencion_Inicial { get; set; }
        [ForeignKey("Estatus_Interno")]
        public virtual Spartane.Core.Domain.Estatus.Estatus Estatus_Interno_Estatus { get; set; }
        [ForeignKey("Estatus")]
        public virtual Spartane.Core.Domain.Estatus_Orientador.Estatus_Orientador Estatus_Estatus_Orientador { get; set; }

    }


}

