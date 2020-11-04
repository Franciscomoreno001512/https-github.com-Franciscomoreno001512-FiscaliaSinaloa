using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Lista_de_Documentos_CCModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha { get; set; }
        public string Nombre_del_Archivo { get; set; }
        [Range(0, 9999999999)]
        public short? Archivo { get; set; }

    }
	
	public class Detalle_de_Lista_de_Documentos_CC_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha { get; set; }
        public string Nombre_del_Archivo { get; set; }
        [Range(0, 9999999999)]
        public short? Archivo { get; set; }

    }


}

