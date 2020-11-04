using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_ReferenciaModel
    {
        [Required]
        public int Clave { get; set; }
        public string Punto_de_Referencia { get; set; }
        public string Descripcion { get; set; }
        public string Distancia { get; set; }

    }
	
	public class Detalle_de_Referencia_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Punto_de_Referencia { get; set; }
        public string Descripcion { get; set; }
        public string Distancia { get; set; }

    }


}

