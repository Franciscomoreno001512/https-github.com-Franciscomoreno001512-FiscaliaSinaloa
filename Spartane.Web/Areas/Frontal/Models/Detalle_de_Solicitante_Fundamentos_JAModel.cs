using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Solicitante_Fundamentos_JAModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Nombre { get; set; }
        public string NombreDescripcion { get; set; }
        public bool Si { get; set; }
        [Range(0, 9999999999)]
        public short? Archivo_Adjunto { get; set; }

    }
	
	public class Detalle_de_Solicitante_Fundamentos_JA_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Nombre { get; set; }
        public string NombreDescripcion { get; set; }
        public bool? Si { get; set; }
        [Range(0, 9999999999)]
        public short? Archivo_Adjunto { get; set; }

    }


}

