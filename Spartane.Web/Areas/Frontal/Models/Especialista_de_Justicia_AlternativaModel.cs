using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Especialista_de_Justicia_AlternativaModel
    {
        [Required]
        public int Clave { get; set; }
        public string Numero_de_Empleado { get; set; }
        public string Nombre_de_Especialista { get; set; }
        [Range(0, 9999999999)]
        public short? Carga_de_Trabajo { get; set; }

    }
	
	public class Especialista_de_Justicia_Alternativa_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Numero_de_Empleado { get; set; }
        public string Nombre_de_Especialista { get; set; }
        [Range(0, 9999999999)]
        public short? Carga_de_Trabajo { get; set; }

    }


}

