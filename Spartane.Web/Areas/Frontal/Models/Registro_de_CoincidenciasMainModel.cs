using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Registro_de_CoincidenciasMainModel
    {
        public Registro_de_CoincidenciasModel Registro_de_CoincidenciasInfo { set; get; }
        public Detalle_de_CoincidenciasGridModelPost Detalle_de_CoincidenciasGridInfo { set; get; }

    }

    public class Detalle_de_CoincidenciasGridModelPost
    {
        public int Clave { get; set; }

        public bool Removed { set; get; }
    }



}

