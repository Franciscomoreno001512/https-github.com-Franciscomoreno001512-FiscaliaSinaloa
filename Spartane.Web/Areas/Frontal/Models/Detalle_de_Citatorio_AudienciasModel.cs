using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Citatorio_AudienciasModel
    {
        [Required]
        public int Clave { get; set; }
        public string Numero_de_audiencia_citatorio { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string Fecha_de_Aceptacion { get; set; }
        public string Hora_de_Aceptacion { get; set; }

    }
	
	public class Detalle_de_Citatorio_Audiencias_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Numero_de_audiencia_citatorio { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string Fecha_de_Aceptacion { get; set; }
        public string Hora_de_Aceptacion { get; set; }

    }


}

