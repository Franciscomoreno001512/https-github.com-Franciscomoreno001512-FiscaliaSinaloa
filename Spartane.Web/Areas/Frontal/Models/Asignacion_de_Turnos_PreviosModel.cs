using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Asignacion_de_Turnos_PreviosModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha { get; set; }
        [Range(0, 9999999999)]
        public int? Clave_Asignacion_Turno { get; set; }
        public string Numero_Turno { get; set; }

    }
	
	public class Asignacion_de_Turnos_Previos_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha { get; set; }
        [Range(0, 9999999999)]
        public int? Clave_Asignacion_Turno { get; set; }
        public string Numero_Turno { get; set; }

    }


}

