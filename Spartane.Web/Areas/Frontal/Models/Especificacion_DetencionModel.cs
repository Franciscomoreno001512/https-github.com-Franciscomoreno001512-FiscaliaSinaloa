using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Especificacion_DetencionModel
    {
        [Required]
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public short? Detenido { get; set; }
        public string DetenidoDescripcion { get; set; }

    }
	
	public class Especificacion_Detencion_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public short? Detenido { get; set; }
        public string DetenidoDescripcion { get; set; }

    }


}

