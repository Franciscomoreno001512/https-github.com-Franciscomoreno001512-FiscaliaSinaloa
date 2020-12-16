using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Fase_de_Judicializacion;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Configurador_de_Movimientos
{
    /// <summary>
    /// Configurador_de_Movimientos table
    /// </summary>
    public class Configurador_de_Movimientos: BaseEntity
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Fase { get; set; }
        public bool? Aplica_para_Adolescentes { get; set; }

        [ForeignKey("Fase")]
        public virtual Spartane.Core.Domain.Fase_de_Judicializacion.Fase_de_Judicializacion Fase_Fase_de_Judicializacion { get; set; }

    }
	
	public class Configurador_de_Movimientos_Datos_Generales
    {
                public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Fase { get; set; }
        public bool? Aplica_para_Adolescentes { get; set; }

		        [ForeignKey("Fase")]
        public virtual Spartane.Core.Domain.Fase_de_Judicializacion.Fase_de_Judicializacion Fase_Fase_de_Judicializacion { get; set; }

    }


}

