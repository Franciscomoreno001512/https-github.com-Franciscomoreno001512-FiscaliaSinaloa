using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Relaciones_Audiencia_InicialModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Imputado { get; set; }
        public string ImputadoNombre_Completo_del_Tutor { get; set; }
        public int? Delito { get; set; }
        public string DelitoDescripcion { get; set; }

    }
	
	public class Detalle_Relaciones_Audiencia_Inicial_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Imputado { get; set; }
        public string ImputadoNombre_Completo_del_Tutor { get; set; }
        public int? Delito { get; set; }
        public string DelitoDescripcion { get; set; }

    }


}

