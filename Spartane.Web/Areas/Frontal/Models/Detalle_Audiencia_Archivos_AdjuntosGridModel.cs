using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Audiencia_Archivos_AdjuntosGridModel
    {
        public int Clave { get; set; }
        public string Nombre_Archivo { get; set; }
        public int? Archivo_Adjunto { get; set; }
        public Grid_File Archivo_AdjuntoFileInfo { set; get; }
        
    }
}

