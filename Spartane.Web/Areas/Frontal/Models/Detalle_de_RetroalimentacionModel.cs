using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_RetroalimentacionModel
    {
        [Required]
        public int Clave { get; set; }
        [Range(0, 9999999999)]
        public int? Usuario_que_Registra { get; set; }
        public string Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public string Retroalimentacion { get; set; }

    }
	
	public class Detalle_de_Retroalimentacion_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        [Range(0, 9999999999)]
        public int? Usuario_que_Registra { get; set; }
        public string Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public string Retroalimentacion { get; set; }

    }


}

