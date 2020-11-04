using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Solicitud_Bitacora_de_CoincidGridModel
    {
        public int Clave { get; set; }
        public string Nombre_Completo { get; set; }
        public string Alias { get; set; }
        public string Numero_de_Expediente { get; set; }
        public string Fuente_de_Origen { get; set; }
        public int? Tipo_de_Acuerdo { get; set; }
        public string Tipo_de_AcuerdoDescripcion { get; set; }
        public bool? Cumplido { get; set; }
        public int? Razon_de_Incumplimiento { get; set; }
        public string Razon_de_IncumplimientoDescripcion { get; set; }
        public string Observaciones { get; set; }
        
    }
}

