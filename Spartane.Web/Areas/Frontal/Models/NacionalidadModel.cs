using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class NacionalidadModel
    {
        [Required]
        public int Clave { get; set; }
        public string NacionalidadC { get; set; }
        public string Descripcion_Estadistica { get; set; }

    }
	
	public class Nacionalidad_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string NacionalidadC { get; set; }
        public string Descripcion_Estadistica { get; set; }

    }


}

