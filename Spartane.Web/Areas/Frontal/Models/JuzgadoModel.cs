using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class JuzgadoModel
    {
        [Required]
        public int Clave { get; set; }
        public string Nombre { get; set; }
        public int? Region { get; set; }
        public string RegionDescripcion { get; set; }

    }
	
	public class Juzgado_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Nombre { get; set; }
        public int? Region { get; set; }
        public string RegionDescripcion { get; set; }

    }


}

