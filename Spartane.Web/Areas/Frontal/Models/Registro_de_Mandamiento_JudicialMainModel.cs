using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Registro_de_Mandamiento_JudicialMainModel
    {
        public Registro_de_Mandamiento_JudicialModel Registro_de_Mandamiento_JudicialInfo { set; get; }
        public Detalle_de_Personas_a_IncluirGridModelPost Detalle_de_Personas_a_IncluirGridInfo { set; get; }

    }

    public class Detalle_de_Personas_a_IncluirGridModelPost
    {
        public int Folio { get; set; }
        public string Persona { get; set; }
        public bool? Seleccionar { get; set; }
        public int? PersonaId { get; set; }

        public bool Removed { set; get; }
    }



}

