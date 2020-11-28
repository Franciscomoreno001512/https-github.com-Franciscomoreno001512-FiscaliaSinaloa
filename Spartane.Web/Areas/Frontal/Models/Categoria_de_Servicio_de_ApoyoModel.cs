using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Categoria_de_Servicio_de_ApoyoModel
    {
        [Required]
        public short Clave { get; set; }
        public string Descripcion { get; set; }

    }
	
	public class Categoria_de_Servicio_de_Apoyo_Datos_GeneralesModel
    {
        [Required]
        public short Clave { get; set; }
        public string Descripcion { get; set; }

    }


}

