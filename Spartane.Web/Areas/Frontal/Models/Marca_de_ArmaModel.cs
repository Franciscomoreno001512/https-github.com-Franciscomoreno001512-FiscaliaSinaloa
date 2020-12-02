using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Marca_de_ArmaModel
    {
        [Required]
        public int Clave { get; set; }
        public string Nombre { get; set; }

    }
	
	public class Marca_de_Arma_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Nombre { get; set; }

    }


}

