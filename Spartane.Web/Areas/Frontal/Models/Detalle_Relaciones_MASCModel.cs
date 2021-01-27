using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Relaciones_MASCModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Requerido { get; set; }
        public string RequeridoNombre_Completo_del_Tutor { get; set; }
        public int? Delito { get; set; }
        public string DelitoDescripcion { get; set; }
        public int? Solicitante { get; set; }
        public string SolicitanteNombre_Completo { get; set; }

    }
	
	public class Detalle_Relaciones_MASC_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Requerido { get; set; }
        public string RequeridoNombre_Completo_del_Tutor { get; set; }
        public int? Delito { get; set; }
        public string DelitoDescripcion { get; set; }
        public int? Solicitante { get; set; }
        public string SolicitanteNombre_Completo { get; set; }

    }


}

