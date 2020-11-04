using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Catalogo_Unidad_PolicialModel
    {
        [Required]
        public int Clave { get; set; }
        public string Unidad_Policial { get; set; }

    }
	
	public class Catalogo_Unidad_Policial_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Unidad_Policial { get; set; }

    }


}

