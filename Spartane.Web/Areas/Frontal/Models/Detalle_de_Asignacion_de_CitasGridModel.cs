using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Asignacion_de_CitasGridModel
    {
        public int Clave { get; set; }
        public int? Numero_de_Empleado { get; set; }
        public string Numero_de_EmpleadoNumero_de_Empleado { get; set; }
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

