using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Relacion_Unidad_UsuarioGridModel
    {
        public int Clave { get; set; }
        public int? Usuario { get; set; }
        public string UsuarioName { get; set; }
        public int? Unidad { get; set; }
        public string UnidadDescripcion_Corta { get; set; }
        
    }
}

