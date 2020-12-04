using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Medios_Prueba_ImputadoGridModel
    {
        public int Clave { get; set; }
        public string Medio_de_Prueba_Presentado { get; set; }
        public string Fecha_de_Presentacion { get; set; }
        public int? Archivo_Adjunto { get; set; }
        public Grid_File Archivo_AdjuntoFileInfo { set; get; }
        
    }
}

