using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Aseguramiento_Artefactos_y_ExplosivosModel
    {
        [Required]
        public int Clave { get; set; }
        public short? Clasificacion { get; set; }
        public string ClasificacionDescripcion { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Cantidad { get; set; }
        public string Lugar_de_Hallazgo { get; set; }
        public string Observaciones { get; set; }

    }
	
	public class Detalle_Aseguramiento_Artefactos_y_Explosivos_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public short? Clasificacion { get; set; }
        public string ClasificacionDescripcion { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Cantidad { get; set; }
        public string Lugar_de_Hallazgo { get; set; }
        public string Observaciones { get; set; }

    }


}

