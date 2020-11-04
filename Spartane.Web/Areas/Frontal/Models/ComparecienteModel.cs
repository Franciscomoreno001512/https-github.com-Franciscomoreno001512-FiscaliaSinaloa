using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class ComparecienteModel
    {
        [Required]
        public int Clave { get; set; }
        public string Nombre_Completo { get; set; }
        [Range(0, 9999999999)]
        public int? Registro_de_Atencion_Inicial { get; set; }

    }
	
	public class Compareciente_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Nombre_Completo { get; set; }
        [Range(0, 9999999999)]
        public int? Registro_de_Atencion_Inicial { get; set; }

    }


}

