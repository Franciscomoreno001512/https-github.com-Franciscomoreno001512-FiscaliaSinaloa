using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Medios_Prueba_AdmitidosModel
    {
        [Required]
        public int Clave { get; set; }
        public string Origen { get; set; }
        public string Medio_de_Prueba_Presentado { get; set; }
        public bool Admitido { get; set; }

    }
	
	public class Detalle_Medios_Prueba_Admitidos_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Origen { get; set; }
        public string Medio_de_Prueba_Presentado { get; set; }
        public bool? Admitido { get; set; }

    }


}

