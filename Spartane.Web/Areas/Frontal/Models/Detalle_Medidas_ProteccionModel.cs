using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Medidas_ProteccionModel
    {
        [Required]
        public int Clave { get; set; }
        public bool Seleccionar { get; set; }
        public int? Medida { get; set; }
        public string MedidaDescripcion { get; set; }

    }
	
	public class Detalle_Medidas_Proteccion_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public bool? Seleccionar { get; set; }
        public int? Medida { get; set; }
        public string MedidaDescripcion { get; set; }

    }


}

