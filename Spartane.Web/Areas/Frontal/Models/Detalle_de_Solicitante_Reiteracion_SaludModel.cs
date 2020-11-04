using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Solicitante_Reiteracion_SaludModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Descripcion { get; set; }
        public string DescripcionDescripcion { get; set; }
        public bool Si { get; set; }
        [Range(0, 9999999999)]
        public short? Archivo_Adjunto { get; set; }

    }
	
	public class Detalle_de_Solicitante_Reiteracion_Salud_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Descripcion { get; set; }
        public string DescripcionDescripcion { get; set; }
        public bool? Si { get; set; }
        [Range(0, 9999999999)]
        public short? Archivo_Adjunto { get; set; }

    }


}

