using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Descarga_de_ArchivoModel
    {
        [Required]
        public int Clave { get; set; }
        [Range(0, 9999999999)]
        public short? Documento { get; set; }

    }
	
	public class Detalle_de_Descarga_de_Archivo_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        [Range(0, 9999999999)]
        public short? Documento { get; set; }

    }


}

