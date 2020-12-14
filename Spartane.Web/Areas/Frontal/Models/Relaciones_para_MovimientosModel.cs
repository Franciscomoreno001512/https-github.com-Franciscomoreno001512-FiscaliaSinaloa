using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Relaciones_para_MovimientosModel
    {
        [Required]
        public int ObjectId { get; set; }
        public string Descripcion { get; set; }

    }
	
	public class Relaciones_para_Movimientos_Datos_GeneralesModel
    {
        [Required]
        public int ObjectId { get; set; }
        public string Descripcion { get; set; }

    }


}

