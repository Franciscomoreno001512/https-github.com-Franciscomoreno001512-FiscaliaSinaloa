using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class AudienciaModel
    {
        [Required]
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Tipo_de_Audiencia { get; set; }
        public string Tipo_de_AudienciaDescripcion { get; set; }

    }
	
	public class Audiencia_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Tipo_de_Audiencia { get; set; }
        public string Tipo_de_AudienciaDescripcion { get; set; }

    }


}

