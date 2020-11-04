using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Solicitudes_de_ComparecenciaModel
    {
        [Required]
        public int Clave { get; set; }
        [Range(0, 9999999999)]
        public short? Archivo { get; set; }
        public int? Nombre { get; set; }
        public string NombreDescripcion { get; set; }
        public string Fecha_de_la_Comparecencia { get; set; }
        public string Hora_de_la_Comparecencia { get; set; }

    }
	
	public class Detalle_de_Solicitudes_de_Comparecencia_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        [Range(0, 9999999999)]
        public short? Archivo { get; set; }
        public int? Nombre { get; set; }
        public string NombreDescripcion { get; set; }
        public string Fecha_de_la_Comparecencia { get; set; }
        public string Hora_de_la_Comparecencia { get; set; }

    }


}

