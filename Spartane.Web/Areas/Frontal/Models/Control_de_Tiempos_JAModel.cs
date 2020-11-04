using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Control_de_Tiempos_JAModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string Numero_de_Expediente { get; set; }
        [Range(0, 9999999999)]
        public int? Estatus { get; set; }
        [Range(0, 9999999999)]
        public int? Estatus_Destino { get; set; }
        public string Tiempo_Transcurrido { get; set; }

    }
	
	public class Control_de_Tiempos_JA_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string Numero_de_Expediente { get; set; }
        [Range(0, 9999999999)]
        public int? Estatus { get; set; }
        [Range(0, 9999999999)]
        public int? Estatus_Destino { get; set; }
        public string Tiempo_Transcurrido { get; set; }

    }


}

