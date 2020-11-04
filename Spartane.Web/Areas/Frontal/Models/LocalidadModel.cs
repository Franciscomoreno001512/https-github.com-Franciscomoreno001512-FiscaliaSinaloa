using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class LocalidadModel
    {
        [Required]
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }

    }
	
	public class Localidad_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }

    }


}

