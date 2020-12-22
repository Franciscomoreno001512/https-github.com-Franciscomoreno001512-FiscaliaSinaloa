using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class CanalizacionMainModel
    {
        public CanalizacionModel CanalizacionInfo { set; get; }
        public Detalle_Diligencias_CanalizacionGridModelPost Detalle_Diligencias_CanalizacionGridInfo { set; get; } 
    }

    public class Detalle_Diligencias_CanalizacionGridModelPost
    {
        public int Clave { get; set; }
        public string Diligencia { get; set; }
        public int? Ver_Documento { get; set; }
        public Grid_File Ver_DocumentoInfo { set; get; }
        public string Observaciones { get; set; }

        public bool Removed { set; get; }
    }



}

