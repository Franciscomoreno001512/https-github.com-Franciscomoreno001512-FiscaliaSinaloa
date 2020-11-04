using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Solicitante_en_InvitacionesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Nombre { get; set; }
        public string NombreNombre_Completo { get; set; }

    }
	
	public class Detalle_de_Solicitante_en_Invitaciones_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Nombre { get; set; }
        public string NombreNombre_Completo { get; set; }

    }


}

