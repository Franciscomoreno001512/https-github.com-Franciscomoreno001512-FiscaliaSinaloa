using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_telefonoModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Tipo_de_Telefono { get; set; }
        public string Tipo_de_TelefonoDescripcion { get; set; }
        public string Telefono { get; set; }
        [Range(0, 9999999999)]
        public short? Extension { get; set; }

    }
	
	public class Detalle_de_telefono_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Tipo_de_Telefono { get; set; }
        public string Tipo_de_TelefonoDescripcion { get; set; }
        public string Telefono { get; set; }
        [Range(0, 9999999999)]
        public short? Extension { get; set; }

    }


}

