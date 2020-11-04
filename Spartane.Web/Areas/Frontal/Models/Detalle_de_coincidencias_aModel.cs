using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_coincidencias_aModel
    {
        [Required]
        public int Clave { get; set; }
        public string Nombre_Completo { get; set; }
        public string Alias { get; set; }
        public string NUAT { get; set; }
        public string Fuente_de_Origen { get; set; }

    }
	
	public class Detalle_de_coincidencias_a_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Nombre_Completo { get; set; }
        public string Alias { get; set; }
        public string NUAT { get; set; }
        public string Fuente_de_Origen { get; set; }

    }


}

