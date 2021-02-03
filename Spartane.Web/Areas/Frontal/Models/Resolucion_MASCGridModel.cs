using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Resolucion_MASCGridModel
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public bool? Rechazo { get; set; }
        public bool? Resolucion_para_Solicitud { get; set; }
        public bool? Resolucion_para_Procedimiento { get; set; }
        public string ClaveFiscalia { get; set; }
        
    }
}

