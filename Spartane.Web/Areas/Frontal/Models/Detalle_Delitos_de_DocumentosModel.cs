using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Delitos_de_DocumentosModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Delito { get; set; }
        public string DelitoDescripcion_corta { get; set; }

    }
	
	public class Detalle_Delitos_de_Documentos_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Delito { get; set; }
        public string DelitoDescripcion_corta { get; set; }

    }


}

