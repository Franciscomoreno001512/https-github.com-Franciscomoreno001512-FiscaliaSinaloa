using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Asignacion_de_Estatus_de_AgenteModel
    {
        [Required]
        public int Clave { get; set; }
        public int? MP { get; set; }
        public string MPName { get; set; }
        public int? Unidad { get; set; }
        public string UnidadDescripcion { get; set; }
        public int? Estatus { get; set; }
        public string EstatusDescripcion { get; set; }

    }
	
	public class Asignacion_de_Estatus_de_Agente_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? MP { get; set; }
        public string MPName { get; set; }
        public int? Unidad { get; set; }
        public string UnidadDescripcion { get; set; }
        public int? Estatus { get; set; }
        public string EstatusDescripcion { get; set; }

    }


}

