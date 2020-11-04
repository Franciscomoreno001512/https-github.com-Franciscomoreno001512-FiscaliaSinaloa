using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Lista_de_AsignacionesModel
    {
        [Required]
        public int Clave { get; set; }
        [Range(0, 9999999999)]
        public int? Numero_de_Asignacion { get; set; }
        public string Nombre { get; set; }
        public bool Realizado { get; set; }
        public string Especifique { get; set; }

    }
	
	public class Detalle_de_Lista_de_Asignaciones_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        [Range(0, 9999999999)]
        public int? Numero_de_Asignacion { get; set; }
        public string Nombre { get; set; }
        public bool? Realizado { get; set; }
        public string Especifique { get; set; }

    }


}

