using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Director_de_AgenciaModel
    {
        [Required]
        public int Clave { get; set; }
        [Range(0, 9999999999)]
        public int? Numero_de_Empleado { get; set; }
        public string Nombre_de_Empleado { get; set; }

    }
	
	public class Director_de_Agencia_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        [Range(0, 9999999999)]
        public int? Numero_de_Empleado { get; set; }
        public string Nombre_de_Empleado { get; set; }

    }


}

