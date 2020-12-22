using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_FotosGridModel
    {
        public int Clave { get; set; }
        public int? Foto_Perfil_Izquierdo { get; set; }
        public Grid_File Foto_Perfil_IzquierdoFileInfo { set; get; }
        public int? Foto_Perfil_Derecho { get; set; }
        public Grid_File Foto_Perfil_DerechoFileInfo { set; get; }
        public int? Foto_de_Frente { get; set; }
        public Grid_File Foto_de_FrenteFileInfo { set; get; }
        
    }
}

