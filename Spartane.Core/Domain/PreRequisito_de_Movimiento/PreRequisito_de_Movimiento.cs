using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Configurador_de_Movimientos;
using Spartane.Core.Domain.Configurador_de_Movimientos;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.PreRequisito_de_Movimiento
{
    /// <summary>
    /// PreRequisito_de_Movimiento table
    /// </summary>
    public class PreRequisito_de_Movimiento: BaseEntity
    {
        public int Clave { get; set; }
        public int? Movimiento { get; set; }
        public int? PreRequisito { get; set; }

        [ForeignKey("Movimiento")]
        public virtual Spartane.Core.Domain.Configurador_de_Movimientos.Configurador_de_Movimientos Movimiento_Configurador_de_Movimientos { get; set; }
        [ForeignKey("PreRequisito")]
        public virtual Spartane.Core.Domain.Configurador_de_Movimientos.Configurador_de_Movimientos PreRequisito_Configurador_de_Movimientos { get; set; }

    }
	
	public class PreRequisito_de_Movimiento_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Movimiento { get; set; }
        public int? PreRequisito { get; set; }

		        [ForeignKey("Movimiento")]
        public virtual Spartane.Core.Domain.Configurador_de_Movimientos.Configurador_de_Movimientos Movimiento_Configurador_de_Movimientos { get; set; }
        [ForeignKey("PreRequisito")]
        public virtual Spartane.Core.Domain.Configurador_de_Movimientos.Configurador_de_Movimientos PreRequisito_Configurador_de_Movimientos { get; set; }

    }


}

