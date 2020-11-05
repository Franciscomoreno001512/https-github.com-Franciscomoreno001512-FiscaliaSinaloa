using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Documentos_MPOMainModel
    {
        public Detalle_de_Documentos_MPOModel Detalle_de_Documentos_MPOInfo { set; get; }
        public Detalle_Delitos_de_DocumentosGridModelPost Detalle_Delitos_de_DocumentosGridInfo { set; get; }

    }

    public class Detalle_Delitos_de_DocumentosGridModelPost
    {
        public int Clave { get; set; }
        public int? Delito { get; set; }

        public bool Removed { set; get; }
    }



}

