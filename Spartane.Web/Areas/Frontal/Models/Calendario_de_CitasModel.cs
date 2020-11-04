using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Calendario_de_CitasModel
    {
        [Required]
        public int Clave { get; set; }
        [Range(0, 9999999999)]
        public short? Pertenece_a { get; set; }

    }
	
	public class Calendario_de_Citas_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        [Range(0, 9999999999)]
        public short? Pertenece_a { get; set; }

    }


}

