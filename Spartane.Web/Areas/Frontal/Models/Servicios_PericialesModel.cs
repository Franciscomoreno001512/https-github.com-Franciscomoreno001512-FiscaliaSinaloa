using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Servicios_PericialesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Servicio { get; set; }
        public short? Rol_de_Donde_Proviene { get; set; }
        public string Rol_de_Donde_ProvieneDescripcion { get; set; }

    }
	
	public class Servicios_Periciales_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Servicio { get; set; }
        public short? Rol_de_Donde_Proviene { get; set; }
        public string Rol_de_Donde_ProvieneDescripcion { get; set; }

    }


}

