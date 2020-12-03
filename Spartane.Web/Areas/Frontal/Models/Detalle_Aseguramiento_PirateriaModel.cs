using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Aseguramiento_PirateriaModel
    {
        [Required]
        public int Clave { get; set; }
        public short? Tipo { get; set; }
        public string TipoDescripcion { get; set; }
        public string Descripcion { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Cantidad { get; set; }
        public short? Unidad_de_Medicion { get; set; }
        public string Unidad_de_MedicionDescripcion { get; set; }
        public string Observaciones { get; set; }

    }
	
	public class Detalle_Aseguramiento_Pirateria_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public short? Tipo { get; set; }
        public string TipoDescripcion { get; set; }
        public string Descripcion { get; set; }
        [Range(0.00, 999999.99)]
        public decimal? Cantidad { get; set; }
        public short? Unidad_de_Medicion { get; set; }
        public string Unidad_de_MedicionDescripcion { get; set; }
        public string Observaciones { get; set; }

    }


}

