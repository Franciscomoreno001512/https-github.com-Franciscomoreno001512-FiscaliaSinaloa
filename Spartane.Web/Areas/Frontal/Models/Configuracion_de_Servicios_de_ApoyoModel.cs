using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Configuracion_de_Servicios_de_ApoyoModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Region { get; set; }
        public string RegionDescripcion { get; set; }
        public int? Area { get; set; }
        public string AreaDescripcion { get; set; }
        public int? SubArea { get; set; }
        public string SubAreaDescripcion { get; set; }
        public bool Acreditada { get; set; }
        public bool Centralizada { get; set; }

    }
	
	public class Configuracion_de_Servicios_de_Apoyo_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Region { get; set; }
        public string RegionDescripcion { get; set; }
        public int? Area { get; set; }
        public string AreaDescripcion { get; set; }
        public int? SubArea { get; set; }
        public string SubAreaDescripcion { get; set; }
        public bool? Acreditada { get; set; }
        public bool? Centralizada { get; set; }

    }


}

