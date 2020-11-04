using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Solicitud_de_Servicios_de_ApoyoModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Tipo_de_Servicio { get; set; }
        public string Tipo_de_ServicioServicio { get; set; }
        public string Dictamen { get; set; }
        public string Responsable { get; set; }
        [Range(0, 9999999999)]
        public int? Clave_MR { get; set; }
        public int? Compareciente { get; set; }
        public string ComparecienteNombre_Completo { get; set; }

    }
	
	public class Solicitud_de_Servicios_de_Apoyo_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Tipo_de_Servicio { get; set; }
        public string Tipo_de_ServicioServicio { get; set; }
        public string Dictamen { get; set; }
        public string Responsable { get; set; }
        [Range(0, 9999999999)]
        public int? Clave_MR { get; set; }
        public int? Compareciente { get; set; }
        public string ComparecienteNombre_Completo { get; set; }

    }


}

