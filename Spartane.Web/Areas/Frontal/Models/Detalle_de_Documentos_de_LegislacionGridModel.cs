using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Documentos_de_LegislacionGridModel
    {
        public int Clave { get; set; }
        public string ID_de_Dispositivo { get; set; }
        public int? Estatus { get; set; }
        public string EstatusDescripcion { get; set; }
        
    }
}

