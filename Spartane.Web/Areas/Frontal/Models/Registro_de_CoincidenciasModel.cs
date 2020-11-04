using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Registro_de_CoincidenciasModel
    {
        [Required]
        public int Clave { get; set; }
        public string NUAT { get; set; }
        [Range(0, 9999999999)]
        public short? Numero_de_Coincidencias { get; set; }

    }
	
	public class Registro_de_Coincidencias_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string NUAT { get; set; }
        [Range(0, 9999999999)]
        public short? Numero_de_Coincidencias { get; set; }

    }


}

