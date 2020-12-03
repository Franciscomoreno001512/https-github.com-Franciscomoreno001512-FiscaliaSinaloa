using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Aseguramiento_OtrosModel
    {
        [Required]
        public int Clave { get; set; }
        public string Tipo { get; set; }
        public string Unidad_de_medida { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Cantidad { get; set; }
        public string Descripcion { get; set; }

    }
	
	public class Detalle_Aseguramiento_Otros_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Tipo { get; set; }
        public string Unidad_de_medida { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Cantidad { get; set; }
        public string Descripcion { get; set; }

    }


}

