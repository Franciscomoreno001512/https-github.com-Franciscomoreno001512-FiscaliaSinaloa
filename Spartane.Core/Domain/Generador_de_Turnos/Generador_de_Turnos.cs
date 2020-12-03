using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Generador_de_Turnos
{
    /// <summary>
    /// Generador_de_Turnos table
    /// </summary>
    public class Generador_de_Turnos: BaseEntity
    {
        public int Folio { get; set; }
        public DateTime? Fecha_de_Generador_de_Turno { get; set; }
        public string Numero_de_Turno { get; set; }


    }
	
	public class Generador_de_Turnos_Datos_Generales
    {
                public int Folio { get; set; }
        public DateTime? Fecha_de_Generador_de_Turno { get; set; }
        public string Numero_de_Turno { get; set; }

		
    }


}

