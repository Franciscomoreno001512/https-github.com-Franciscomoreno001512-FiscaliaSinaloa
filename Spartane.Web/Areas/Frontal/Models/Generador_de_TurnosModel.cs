using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Generador_de_TurnosModel
    {
        [Required]
        public int Folio { get; set; }
        public string Fecha_de_Generador_de_Turno { get; set; }
        public string Numero_de_Turno { get; set; }

    }
	
	public class Generador_de_Turnos_Datos_GeneralesModel
    {
        [Required]
        public int Folio { get; set; }
        public string Fecha_de_Generador_de_Turno { get; set; }
        public string Numero_de_Turno { get; set; }

    }


}

