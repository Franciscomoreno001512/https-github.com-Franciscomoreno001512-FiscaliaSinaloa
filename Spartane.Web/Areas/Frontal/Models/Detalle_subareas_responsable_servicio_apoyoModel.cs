using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_subareas_responsable_servicio_apoyoModel
    {
        [Required]
        public int Clave { get; set; }
        public int? SubArea_Asignada { get; set; }
        public string SubArea_AsignadaDescripcion { get; set; }

    }
	
	public class Detalle_subareas_responsable_servicio_apoyo_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? SubArea_Asignada { get; set; }
        public string SubArea_AsignadaDescripcion { get; set; }

    }


}

