using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Estatus_Orientador;
using Spartane.Core.Domain.Estatus_Orientador;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Correccion_de_Error_en_Estatus
{
    /// <summary>
    /// Correccion_de_Error_en_Estatus table
    /// </summary>
    public class Correccion_de_Error_en_Estatus: BaseEntity
    {
        public int Clave { get; set; }
        public string NUAT { get; set; }
        public int? Estatus_Actual { get; set; }
        public int? Estatus_a_Cambiar { get; set; }
        public string Motivo { get; set; }

        [ForeignKey("Estatus_Actual")]
        public virtual Spartane.Core.Domain.Estatus_Orientador.Estatus_Orientador Estatus_Actual_Estatus_Orientador { get; set; }
        [ForeignKey("Estatus_a_Cambiar")]
        public virtual Spartane.Core.Domain.Estatus_Orientador.Estatus_Orientador Estatus_a_Cambiar_Estatus_Orientador { get; set; }

    }
	
	public class Correccion_de_Error_en_Estatus_Datos_Generales
    {
                public int Clave { get; set; }
        public string NUAT { get; set; }
        public int? Estatus_Actual { get; set; }
        public int? Estatus_a_Cambiar { get; set; }
        public string Motivo { get; set; }

		        [ForeignKey("Estatus_Actual")]
        public virtual Spartane.Core.Domain.Estatus_Orientador.Estatus_Orientador Estatus_Actual_Estatus_Orientador { get; set; }
        [ForeignKey("Estatus_a_Cambiar")]
        public virtual Spartane.Core.Domain.Estatus_Orientador.Estatus_Orientador Estatus_a_Cambiar_Estatus_Orientador { get; set; }

    }


}

