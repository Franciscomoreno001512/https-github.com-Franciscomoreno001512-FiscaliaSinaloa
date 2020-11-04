using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Lista_de_AsignacionesGridModel
    {
        public int Clave { get; set; }
        public int? Numero_de_Asignacion { get; set; }
        public string Nombre { get; set; }
        public bool? Realizado { get; set; }
        public string Especifique { get; set; }
        
    }
}

