using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Diligencias_CanalizacionGridModel
    {
        public int Clave { get; set; }
        public string Diligencia { get; set; }
        public int? Ver_Documento { get; set; }
        public Grid_File Ver_DocumentoFileInfo { set; get; }
        public string Observaciones { get; set; }
        
    }
}

