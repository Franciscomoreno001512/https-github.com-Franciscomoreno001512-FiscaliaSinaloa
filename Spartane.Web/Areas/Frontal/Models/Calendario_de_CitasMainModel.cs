using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Calendario_de_CitasMainModel
    {
        public Calendario_de_CitasModel Calendario_de_CitasInfo { set; get; }
        public Detalle_de_Asignacion_de_CitasGridModelPost Detalle_de_Asignacion_de_CitasGridInfo { set; get; }

    }

    public class Detalle_de_Asignacion_de_CitasGridModelPost
    {
        public int Clave { get; set; }
        public int? Numero_de_Empleado { get; set; }
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

        public bool Removed { set; get; }
    }



}

