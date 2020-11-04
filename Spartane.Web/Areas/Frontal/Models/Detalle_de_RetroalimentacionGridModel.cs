using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_RetroalimentacionGridModel
    {
        public int Clave { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public string Retroalimentacion { get; set; }
        
    }
}

