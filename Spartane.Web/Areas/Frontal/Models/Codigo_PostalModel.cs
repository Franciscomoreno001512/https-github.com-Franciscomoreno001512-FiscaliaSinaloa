using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Codigo_PostalModel
    {
        [Required]
        public int Clave { get; set; }
        [Range(0, 9999999999)]
        public int? Codigo_PostalC { get; set; }
        public int? Colonia { get; set; }
        public string ColoniaNombre { get; set; }

    }
	
	public class Codigo_Postal_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        [Range(0, 9999999999)]
        public int? Codigo_PostalC { get; set; }
        public int? Colonia { get; set; }
        public string ColoniaNombre { get; set; }

    }


}

