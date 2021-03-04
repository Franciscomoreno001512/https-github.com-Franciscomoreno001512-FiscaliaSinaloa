using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Solicitud_Disponibles_ConfiguracionModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Documento { get; set; }
        public string DocumentoDescripcion { get; set; }

    }
	
	public class Detalle_Solicitud_Disponibles_Configuracion_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Documento { get; set; }
        public string DocumentoDescripcion { get; set; }

    }


}

