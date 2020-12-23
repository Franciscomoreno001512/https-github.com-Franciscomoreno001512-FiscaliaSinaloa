using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Resolucion_MASCModel
    {
        [Required]
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public bool Rechazo { get; set; }
        public bool Resolucion_para_Solicitud { get; set; }
        public bool Resolucion_para_Procedimiento { get; set; }
        public string ClaveFiscalia { get; set; }

    }
	
	public class Resolucion_MASC_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public bool? Rechazo { get; set; }
        public bool? Resolucion_para_Solicitud { get; set; }
        public bool? Resolucion_para_Procedimiento { get; set; }
        public string ClaveFiscalia { get; set; }

    }


}

