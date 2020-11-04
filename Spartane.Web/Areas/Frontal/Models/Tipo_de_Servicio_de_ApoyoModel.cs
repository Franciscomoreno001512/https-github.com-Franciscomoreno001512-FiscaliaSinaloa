using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Tipo_de_Servicio_de_ApoyoModel
    {
        [Required]
        public int Clave { get; set; }
        public string Servicio { get; set; }

    }
	
	public class Tipo_de_Servicio_de_Apoyo_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Servicio { get; set; }

    }


}

