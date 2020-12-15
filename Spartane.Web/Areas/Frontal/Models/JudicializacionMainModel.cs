using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class JudicializacionMainModel
    {
        public JudicializacionModel JudicializacionInfo { set; get; }
        public Detalle_Vinculacion_JudicializacionGridModelPost Detalle_Vinculacion_JudicializacionGridInfo { set; get; }

    }

    public class Detalle_Vinculacion_JudicializacionGridModelPost
    {
        public int Clave { get; set; }
        public string Relacion { get; set; }

        public bool Removed { set; get; }
    }



}

