using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Historico_JAGridModel
    {
        public int Clave { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public int? Usuario { get; set; }
        public string UsuarioName { get; set; }
        public string Estatus { get; set; }
        
    }
}

