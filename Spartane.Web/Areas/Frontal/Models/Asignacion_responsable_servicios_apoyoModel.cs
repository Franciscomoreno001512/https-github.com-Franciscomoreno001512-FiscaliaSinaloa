using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Asignacion_responsable_servicios_apoyoModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Usuario { get; set; }
        public string UsuarioName { get; set; }
        public int? Area_Asignada { get; set; }
        public string Area_AsignadaDescripcion { get; set; }

    }
	
	public class Asignacion_responsable_servicios_apoyo_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Usuario { get; set; }
        public string UsuarioName { get; set; }
        public int? Area_Asignada { get; set; }
        public string Area_AsignadaDescripcion { get; set; }

    }


}

