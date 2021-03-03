using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class SubArea_de_Servicios_de_ApoyoModel
    {
        [Required]
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Area { get; set; }
        public string AreaDescripcion { get; set; }

    }
	
	public class SubArea_de_Servicios_de_Apoyo_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Area { get; set; }
        public string AreaDescripcion { get; set; }

    }


}

