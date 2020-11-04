using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Traslado_de_CCGridModel
    {
        public int Clave { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string Temperatura { get; set; }
        public string Humedad { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public int? Estatus { get; set; }
        public string EstatusDescripcion { get; set; }
        
    }
}

