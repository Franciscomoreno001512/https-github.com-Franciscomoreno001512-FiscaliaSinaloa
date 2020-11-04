using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Otras_Identificaciones_Requerido_MASCModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Tipo_de_Identificacion { get; set; }
        public string Tipo_de_IdentificacionNombre { get; set; }
        public string Descripcion { get; set; }

    }
	
	public class Otras_Identificaciones_Requerido_MASC_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Tipo_de_Identificacion { get; set; }
        public string Tipo_de_IdentificacionNombre { get; set; }
        public string Descripcion { get; set; }

    }


}

