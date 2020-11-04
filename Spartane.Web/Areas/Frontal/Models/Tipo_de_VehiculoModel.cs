using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Tipo_de_VehiculoModel
    {
        [Required]
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        [Range(0, 9999999999)]
        public int? Clase_de_Vehiculo { get; set; }
        [Range(0, 9999999999)]
        public int? SNSP { get; set; }

    }
	
	public class Tipo_de_Vehiculo_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        [Range(0, 9999999999)]
        public int? Clase_de_Vehiculo { get; set; }
        [Range(0, 9999999999)]
        public int? SNSP { get; set; }

    }


}

