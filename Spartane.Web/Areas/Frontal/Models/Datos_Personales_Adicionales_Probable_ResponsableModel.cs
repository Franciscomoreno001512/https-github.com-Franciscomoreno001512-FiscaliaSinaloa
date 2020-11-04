using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Datos_Personales_Adicionales_Probable_ResponsableModel
    {
        [Required]
        public int Clave { get; set; }
        public string Correo_Electronico { get; set; }
        public string Numero_Telefonico { get; set; }
        public int? Redes_Sociales { get; set; }
        public string Redes_SocialesDescripcion { get; set; }
        public string Observaciones { get; set; }

    }
	
	public class Datos_Personales_Adicionales_Probable_Responsable_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Correo_Electronico { get; set; }
        public string Numero_Telefonico { get; set; }
        public int? Redes_Sociales { get; set; }
        public string Redes_SocialesDescripcion { get; set; }
        public string Observaciones { get; set; }

    }


}

