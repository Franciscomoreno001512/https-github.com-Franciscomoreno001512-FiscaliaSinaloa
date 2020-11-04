using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class RecepcionistasModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Nombre { get; set; }
        public string NombreName { get; set; }

    }
	
	public class Recepcionistas_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Nombre { get; set; }
        public string NombreName { get; set; }

    }


}

