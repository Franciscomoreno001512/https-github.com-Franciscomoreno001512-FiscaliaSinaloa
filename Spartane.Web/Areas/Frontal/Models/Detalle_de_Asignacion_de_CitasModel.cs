using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Asignacion_de_CitasModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Numero_de_Empleado { get; set; }
        public string Numero_de_EmpleadoNumero_de_Empleado { get; set; }
        [Range(0, 9999999999)]
        public int? Nombre_de_Empleado { get; set; }
        public bool Lunes { get; set; }
        public bool Martes { get; set; }
        public bool Miercoles { get; set; }
        public bool Jueves { get; set; }
        public bool Viernes { get; set; }
        public bool Sabado { get; set; }
        public bool Domingo { get; set; }
        public string Hora_Inicio { get; set; }
        public string Hora_Fin { get; set; }

    }
	
	public class Detalle_de_Asignacion_de_Citas_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Numero_de_Empleado { get; set; }
        public string Numero_de_EmpleadoNumero_de_Empleado { get; set; }
        [Range(0, 9999999999)]
        public int? Nombre_de_Empleado { get; set; }
        public bool? Lunes { get; set; }
        public bool? Martes { get; set; }
        public bool? Miercoles { get; set; }
        public bool? Jueves { get; set; }
        public bool? Viernes { get; set; }
        public bool? Sabado { get; set; }
        public bool? Domingo { get; set; }
        public string Hora_Inicio { get; set; }
        public string Hora_Fin { get; set; }

    }


}

