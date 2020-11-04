using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Hechos_Audiencia_InicialGridModel
    {
        public int Clave { get; set; }
        public int? Descripcion_del_Hecho { get; set; }
        public string Descripcion_del_HechoDescripcion { get; set; }
        public bool? Si { get; set; }
        public short? Archivo_Adjunto { get; set; }
        
    }
}

