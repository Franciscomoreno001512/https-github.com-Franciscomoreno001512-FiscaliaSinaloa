using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Tipo_EncuestaModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Modulo_Encuesta { get; set; }
        public string Modulo_EncuestaDescripcion { get; set; }
        public string Descripcion { get; set; }
        public string Abreviacion { get; set; }

    }
	
	public class Tipo_Encuesta_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Modulo_Encuesta { get; set; }
        public string Modulo_EncuestaDescripcion { get; set; }
        public string Descripcion { get; set; }
        public string Abreviacion { get; set; }

    }


}

