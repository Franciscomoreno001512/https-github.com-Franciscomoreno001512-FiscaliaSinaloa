using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Documentos_de_LegislacionModel
    {
        [Required]
        public int Clave { get; set; }
        public string ID_de_Dispositivo { get; set; }
        public int? Estatus { get; set; }
        public string EstatusDescripcion { get; set; }

    }
	
	public class Detalle_de_Documentos_de_Legislacion_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string ID_de_Dispositivo { get; set; }
        public int? Estatus { get; set; }
        public string EstatusDescripcion { get; set; }

    }


}

