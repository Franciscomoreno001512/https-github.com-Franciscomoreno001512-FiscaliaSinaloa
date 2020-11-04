using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Control_de_Tiempos_JAGridModel
    {
        public int Clave { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string Numero_de_Expediente { get; set; }
        public int? Estatus { get; set; }
        public int? Estatus_Destino { get; set; }
        public string Tiempo_Transcurrido { get; set; }
        
    }
}

