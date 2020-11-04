using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Registro_de_Intervinientes_CCMainModel
    {
        public Detalle_de_Registro_de_Intervinientes_CCModel Detalle_de_Registro_de_Intervinientes_CCInfo { set; get; }
        public Detalle_de_Galeria_de_IntervinientesGridModelPost Detalle_de_Galeria_de_IntervinientesGridInfo { set; get; }

    }

    public class Detalle_de_Galeria_de_IntervinientesGridModelPost
    {
        public int Clave { get; set; }
        public string Nombre { get; set; }
        public short? Archivo { get; set; }

        public bool Removed { set; get; }
    }



}

