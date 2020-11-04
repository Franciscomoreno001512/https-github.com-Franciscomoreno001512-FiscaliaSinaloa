using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Correccion_de_Error_en_EstatusGridModel
    {
        public int Clave { get; set; }
        public string NUAT { get; set; }
        public int? Estatus_Actual { get; set; }
        public string Estatus_ActualDescripcion { get; set; }
        public int? Estatus_a_Cambiar { get; set; }
        public string Estatus_a_CambiarDescripcion { get; set; }
        public string Motivo { get; set; }
        
    }
}

