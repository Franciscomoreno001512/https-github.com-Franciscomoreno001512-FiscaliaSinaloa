using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Bitacora_de_UsuariosModel
    {
        [Required]
        public int Clave { get; set; }
        public string Numero_de_Empleado { get; set; }
        [Range(0, 9999999999)]
        public int? Usuario { get; set; }
        [Range(0, 9999999999)]
        public short? ID_de_Huella { get; set; }
        public string ID_de_Dispositivo { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }

    }
	
	public class Bitacora_de_Usuarios_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Numero_de_Empleado { get; set; }
        [Range(0, 9999999999)]
        public int? Usuario { get; set; }
        [Range(0, 9999999999)]
        public short? ID_de_Huella { get; set; }
        public string ID_de_Dispositivo { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }

    }


}

