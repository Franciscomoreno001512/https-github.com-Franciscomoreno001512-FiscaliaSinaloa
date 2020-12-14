using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Tipo_de_Medida_de_ProteccionModel
    {
        [Required]
        public int Clave { get; set; }
        public string Descripcion { get; set; }

    }
	
	public class Tipo_de_Medida_de_Proteccion_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Descripcion { get; set; }

    }


}

