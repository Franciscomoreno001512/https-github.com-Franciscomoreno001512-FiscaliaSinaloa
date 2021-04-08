using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Registro_de_Mandamiento_Judicial;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Personas_a_Incluir
{
    /// <summary>
    /// Detalle_de_Personas_a_Incluir table
    /// </summary>
    public class Detalle_de_Personas_a_Incluir: BaseEntity
    {
        public int Folio { get; set; }
        public int? Mandamiento_Judicial { get; set; }
        public string Persona { get; set; }
        public bool? Seleccionar { get; set; }
        public int? PersonaId { get; set; }

        [ForeignKey("Mandamiento_Judicial")]
        public virtual Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial Mandamiento_Judicial_Registro_de_Mandamiento_Judicial { get; set; }

    }
	
	public class Detalle_de_Personas_a_Incluir_Datos_Generales
    {
                public int Folio { get; set; }
        public int? Mandamiento_Judicial { get; set; }
        public string Persona { get; set; }
        public bool? Seleccionar { get; set; }
        public int? PersonaId { get; set; }

		        [ForeignKey("Mandamiento_Judicial")]
        public virtual Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial Mandamiento_Judicial_Registro_de_Mandamiento_Judicial { get; set; }

    }


}

