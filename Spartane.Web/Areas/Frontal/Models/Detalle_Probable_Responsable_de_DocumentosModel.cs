using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Probable_Responsable_de_DocumentosModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Probable_Responsable { get; set; }
        public string Probable_ResponsableNombre_Completo_del_Tutor { get; set; }

    }
	
	public class Detalle_Probable_Responsable_de_Documentos_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Probable_Responsable { get; set; }
        public string Probable_ResponsableNombre_Completo_del_Tutor { get; set; }

    }


}

