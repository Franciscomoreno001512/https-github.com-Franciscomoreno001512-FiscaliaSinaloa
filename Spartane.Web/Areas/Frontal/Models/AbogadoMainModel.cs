using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class AbogadoMainModel
    {
        public AbogadoModel AbogadoInfo { set; get; }
        public Detalle_de_AbogadoGridModelPost Detalle_de_AbogadoGridInfo { set; get; }

    }

    public class Detalle_de_AbogadoGridModelPost
    {
        public int Clave { get; set; }
        public string NUC { get; set; }
        public string Nombre_del_Representado { get; set; }
        public string Tipo_de_Representante { get; set; }
        public string Comentarios { get; set; }

        public bool Removed { set; get; }
    }



}

