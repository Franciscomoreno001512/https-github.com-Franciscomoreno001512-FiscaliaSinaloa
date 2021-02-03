using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Documentos_Mandamiento_JudicialGridModel
    {
        public int Clave { get; set; }
        public int? Documentos { get; set; }
        public Grid_File DocumentosFileInfo { set; get; }
        
    }
}

