using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Especifica_VehiculoModel
    {
        public short? Circunstancia_Vehiculo { get; set; }
        public string Circunstancia_VehiculoDescripcion { get; set; }
        [Required]
        public short Clave { get; set; }
        public string Descripcion { get; set; }

    }
	
	public class Especifica_Vehiculo_Datos_GeneralesModel
    {
        public short? Circunstancia_Vehiculo { get; set; }
        public string Circunstancia_VehiculoDescripcion { get; set; }
        [Required]
        public short Clave { get; set; }
        public string Descripcion { get; set; }

    }


}

