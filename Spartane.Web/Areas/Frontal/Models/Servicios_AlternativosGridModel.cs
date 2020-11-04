using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Servicios_AlternativosGridModel
    {
        public int Clave { get; set; }
        public bool? CJusticia_Alternativa { get; set; }
        public int? Medios_Alternativos { get; set; }
        public string Medios_AlternativosDescripcion { get; set; }
        public string Motivo { get; set; }
        public bool? Derechos { get; set; }
        public bool? Procedimiento { get; set; }
        public bool? Solicita_Medios_Alternativos { get; set; }
        public int? Se_Canaliza { get; set; }
        public string Se_CanalizaDescripcion { get; set; }
        public bool? Investigacion_con_Detenido { get; set; }
        public bool? Investigacion_sin_Detenido { get; set; }
        public bool? Turnar_a_Justicia_Alternativa { get; set; }
        public bool? Instancia_Externa { get; set; }
        
    }
}

