using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Otras_Identificaciones_Probable_ResponsableModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Tipo_de_identificacion { get; set; }
        public string Tipo_de_identificacionNombre { get; set; }
        public string Descripcion { get; set; }

    }
	
	public class Otras_Identificaciones_Probable_Responsable_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Tipo_de_identificacion { get; set; }
        public string Tipo_de_identificacionNombre { get; set; }
        public string Descripcion { get; set; }

    }


}

