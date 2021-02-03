using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Datos_Adicionales_MovimientoModel
    {
        [Required]
        public int Clave { get; set; }
        public string Dato { get; set; }
        public int? Tipo_de_Dato { get; set; }
        public string Tipo_de_DatoDescripcion { get; set; }
        public string Query_para_llenado { get; set; }
        public bool Obligatorio { get; set; }

    }
	
	public class Detalle_Datos_Adicionales_Movimiento_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Dato { get; set; }
        public int? Tipo_de_Dato { get; set; }
        public string Tipo_de_DatoDescripcion { get; set; }
        public string Query_para_llenado { get; set; }
        public bool? Obligatorio { get; set; }

    }


}

