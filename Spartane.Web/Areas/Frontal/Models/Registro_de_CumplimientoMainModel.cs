using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Registro_de_CumplimientoMainModel
    {
        public Registro_de_CumplimientoModel Registro_de_CumplimientoInfo { set; get; }
        public Personas_donde_se_ejecuto_mandamientoGridModelPost Personas_donde_se_ejecuto_mandamientoGridInfo { set; get; }

    }

    public class Personas_donde_se_ejecuto_mandamientoGridModelPost
    {
        public int Folio { get; set; }
        public string Persona { get; set; }
        public bool? Seleccionar { get; set; }
        public int? PersonaId { get; set; }

        public bool Removed { set; get; }
    }



}

