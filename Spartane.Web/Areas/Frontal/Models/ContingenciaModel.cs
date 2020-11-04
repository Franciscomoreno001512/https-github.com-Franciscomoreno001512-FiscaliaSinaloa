using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class ContingenciaModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        [Range(0, 9999999999)]
        public int? Usuario_que_Registra { get; set; }
        [Range(0, 9999999999)]
        public int? Usuario { get; set; }
        public string Numero_de_Expediente { get; set; }
        public string Observaciones { get; set; }

    }
	
	public class Contingencia_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        [Range(0, 9999999999)]
        public int? Usuario_que_Registra { get; set; }
        [Range(0, 9999999999)]
        public int? Usuario { get; set; }
        public string Numero_de_Expediente { get; set; }
        public string Observaciones { get; set; }

    }


}

