using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Fase_de_JudicializacionModel
    {
        [Required]
        public int Clave { get; set; }
        public string Descripcion { get; set; }

    }
	
	public class Fase_de_Judicializacion_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Descripcion { get; set; }

    }


}

