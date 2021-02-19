using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Asignacion_de_Turnos_PreviosGridModel
    {
        public int Clave { get; set; }
        public string Fecha { get; set; }
        public int? Clave_Asignacion_Turno { get; set; }
        public string Numero_Turno { get; set; }
        
    }
}

