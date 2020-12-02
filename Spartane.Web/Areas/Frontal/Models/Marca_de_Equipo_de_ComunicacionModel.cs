using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Marca_de_Equipo_de_ComunicacionModel
    {
        [Required]
        public short Clave { get; set; }
        public string Descripcion { get; set; }

    }
	
	public class Marca_de_Equipo_de_Comunicacion_Datos_GeneralesModel
    {
        [Required]
        public short Clave { get; set; }
        public string Descripcion { get; set; }

    }


}

