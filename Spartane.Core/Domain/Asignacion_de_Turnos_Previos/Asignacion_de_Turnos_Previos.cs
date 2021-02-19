using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Asignacion_de_Turnos_Previos
{
    /// <summary>
    /// Asignacion_de_Turnos_Previos table
    /// </summary>
    public class Asignacion_de_Turnos_Previos: BaseEntity
    {
        public int Clave { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Clave_Asignacion_Turno { get; set; }
        public string Numero_Turno { get; set; }


    }
	
	public class Asignacion_de_Turnos_Previos_Datos_Generales
    {
                public int Clave { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Clave_Asignacion_Turno { get; set; }
        public string Numero_Turno { get; set; }

		
    }


}

