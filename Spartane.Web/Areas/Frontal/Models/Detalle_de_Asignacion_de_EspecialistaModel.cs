using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Asignacion_de_EspecialistaModel
    {
        [Required]
        public short Clave { get; set; }
        [Range(0, 9999999999)]
        public int? Nombre_de_Especialista { get; set; }
        [Range(0, 9999999999)]
        public short? Carga_de_trabajo { get; set; }

    }
	
	public class Detalle_de_Asignacion_de_Especialista_Datos_GeneralesModel
    {
        [Required]
        public short Clave { get; set; }
        [Range(0, 9999999999)]
        public int? Nombre_de_Especialista { get; set; }
        [Range(0, 9999999999)]
        public short? Carga_de_trabajo { get; set; }

    }


}

