using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Bitacora_de_UsuariosGridModel
    {
        public int Clave { get; set; }
        public string Numero_de_Empleado { get; set; }
        public int? Usuario { get; set; }
        public short? ID_de_Huella { get; set; }
        public string ID_de_Dispositivo { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        
    }
}

