using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_del_Certificado_CCModel
    {
        [Required]
        public int Clave { get; set; }
        public string Certificado { get; set; }
        [Range(0, 9999999999)]
        public short? Archivo { get; set; }
        public string Fecha { get; set; }

    }
	
	public class Detalle_del_Certificado_CC_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Certificado { get; set; }
        [Range(0, 9999999999)]
        public short? Archivo { get; set; }
        public string Fecha { get; set; }

    }


}

