using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Relacion_Unidad_UsuarioModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Usuario { get; set; }
        public string UsuarioName { get; set; }
        public int? Unidad { get; set; }
        public string UnidadDescripcion_Corta { get; set; }

    }
	
	public class Relacion_Unidad_Usuario_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Usuario { get; set; }
        public string UsuarioName { get; set; }
        public int? Unidad { get; set; }
        public string UnidadDescripcion_Corta { get; set; }

    }


}

