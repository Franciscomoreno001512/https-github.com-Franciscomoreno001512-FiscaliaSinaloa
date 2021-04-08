using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Registro_de_Cumplimiento;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Personas_donde_se_ejecuto_mandamiento
{
    /// <summary>
    /// Personas_donde_se_ejecuto_mandamiento table
    /// </summary>
    public class Personas_donde_se_ejecuto_mandamiento: BaseEntity
    {
        public int Folio { get; set; }
        public int? Cumplimiento { get; set; }
        public string Persona { get; set; }
        public bool? Seleccionar { get; set; }
        public int? PersonaId { get; set; }

        [ForeignKey("Cumplimiento")]
        public virtual Spartane.Core.Domain.Registro_de_Cumplimiento.Registro_de_Cumplimiento Cumplimiento_Registro_de_Cumplimiento { get; set; }

    }
	
	public class Personas_donde_se_ejecuto_mandamiento_Datos_Generales
    {
                public int Folio { get; set; }
        public int? Cumplimiento { get; set; }
        public string Persona { get; set; }
        public bool? Seleccionar { get; set; }
        public int? PersonaId { get; set; }

		        [ForeignKey("Cumplimiento")]
        public virtual Spartane.Core.Domain.Registro_de_Cumplimiento.Registro_de_Cumplimiento Cumplimiento_Registro_de_Cumplimiento { get; set; }

    }


}

