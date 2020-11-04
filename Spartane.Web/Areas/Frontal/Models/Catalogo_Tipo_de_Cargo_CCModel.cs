using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Catalogo_Tipo_de_Cargo_CCModel
    {
        [Required]
        public int Clave { get; set; }
        public string Tipo_de_Cargo { get; set; }

    }
	
	public class Catalogo_Tipo_de_Cargo_CC_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Tipo_de_Cargo { get; set; }

    }


}

