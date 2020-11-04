using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Oficio_de_Servicio_PericialGridModel
    {
        public int Clave { get; set; }
        public int? Oficio { get; set; }
        public string OficioDescripcion { get; set; }
        public int? Servicio_Pericial { get; set; }
        public string Servicio_PericialServicio { get; set; }
        
    }
}

