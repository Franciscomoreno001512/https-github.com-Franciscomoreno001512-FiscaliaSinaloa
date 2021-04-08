using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Personas_a_IncluirGridModel
    {
        public int Folio { get; set; }
        public string Persona { get; set; }
        public bool? Seleccionar { get; set; }
        public int? PersonaId { get; set; }
        
    }
}

