using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Bitacora_de_CambiosModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha_de_Entrada { get; set; }
        public string Hora_de_Entrada { get; set; }
        public int? Usuario { get; set; }
        public string UsuarioName { get; set; }

    }
	
	public class Detalle_de_Bitacora_de_Cambios_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha_de_Entrada { get; set; }
        public string Hora_de_Entrada { get; set; }
        public int? Usuario { get; set; }
        public string UsuarioName { get; set; }

    }


}

