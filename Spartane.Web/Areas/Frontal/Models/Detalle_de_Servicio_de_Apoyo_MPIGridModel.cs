using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Servicio_de_Apoyo_MPIGridModel
    {
        public int Clave { get; set; }
        public int? Tipo_de_Servicio { get; set; }
        public string Tipo_de_ServicioServicio { get; set; }
        public string Dictamen { get; set; }
        public string Responsable { get; set; }
        public int? Victima { get; set; }
        public string VictimaNombre { get; set; }
        
    }
}

