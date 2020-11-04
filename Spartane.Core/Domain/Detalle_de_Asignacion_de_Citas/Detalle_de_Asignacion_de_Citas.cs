using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Calendario_de_Citas;
using Spartane.Core.Domain.Usuario;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Asignacion_de_Citas
{
    /// <summary>
    /// Detalle_de_Asignacion_de_Citas table
    /// </summary>
    public class Detalle_de_Asignacion_de_Citas: BaseEntity
    {
        public int Clave { get; set; }
        public int? Calendario_de_Citas { get; set; }
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

        [ForeignKey("Calendario_de_Citas")]
        public virtual Spartane.Core.Domain.Calendario_de_Citas.Calendario_de_Citas Calendario_de_Citas_Calendario_de_Citas { get; set; }
        [ForeignKey("Numero_de_Empleado")]
        public virtual Spartane.Core.Domain.Usuario.Usuario Numero_de_Empleado_Usuario { get; set; }

    }
	
	public class Detalle_de_Asignacion_de_Citas_Datos_Generales
    {
                public int Clave { get; set; }
        public int? Calendario_de_Citas { get; set; }
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

		        [ForeignKey("Calendario_de_Citas")]
        public virtual Spartane.Core.Domain.Calendario_de_Citas.Calendario_de_Citas Calendario_de_Citas_Calendario_de_Citas { get; set; }
        [ForeignKey("Numero_de_Empleado")]
        public virtual Spartane.Core.Domain.Usuario.Usuario Numero_de_Empleado_Usuario { get; set; }

    }


}

