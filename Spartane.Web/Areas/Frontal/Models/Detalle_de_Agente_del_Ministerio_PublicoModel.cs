using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Agente_del_Ministerio_PublicoModel
    {
        [Required]
        public int Clave { get; set; }
        [Range(0, 9999999999)]
        public int? Agente_del_Ministerio_Publico { get; set; }
        [Range(0, 9999999999)]
        public int? Carga_de_Trabajo { get; set; }
        public string Especialidad { get; set; }

    }
	
	public class Detalle_de_Agente_del_Ministerio_Publico_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        [Range(0, 9999999999)]
        public int? Agente_del_Ministerio_Publico { get; set; }
        [Range(0, 9999999999)]
        public int? Carga_de_Trabajo { get; set; }
        public string Especialidad { get; set; }

    }


}

