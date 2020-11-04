using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Galeria_de_IntervinientesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Nombre { get; set; }
        [Range(0, 9999999999)]
        public short? Archivo { get; set; }

    }
	
	public class Detalle_de_Galeria_de_Intervinientes_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Nombre { get; set; }
        [Range(0, 9999999999)]
        public short? Archivo { get; set; }

    }


}

