using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Delito_de_JusticiaMainModel
    {
        public Detalle_de_Delito_de_JusticiaModel Detalle_de_Delito_de_JusticiaInfo { set; get; }
        public Agravantes_del_Delito_MASCGridModelPost Agravantes_del_Delito_MASCGridInfo { set; get; }
        public Circunstancias_del_Delito_MASCGridModelPost Circunstancias_del_Delito_MASCGridInfo { set; get; }

    }

    public class Agravantes_del_Delito_MASCGridModelPost
    {
        public int Clave { get; set; }
        public int? Agravante { get; set; }

        public bool Removed { set; get; }
    }

    public class Circunstancias_del_Delito_MASCGridModelPost
    {
        public int Clave { get; set; }
        public int? Tipo_de_Lugar { get; set; }

        public bool Removed { set; get; }
    }



}

