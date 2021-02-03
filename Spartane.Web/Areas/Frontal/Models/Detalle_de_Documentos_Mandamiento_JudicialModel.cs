using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Documentos_Mandamiento_JudicialModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Documentos { get; set; }
        public HttpPostedFileBase DocumentosFile { set; get; }
        public int DocumentosRemoveAttachment { set; get; }

    }
	
	public class Detalle_de_Documentos_Mandamiento_Judicial_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Documentos { get; set; }
        public HttpPostedFileBase DocumentosFile { set; get; }
        public int DocumentosRemoveAttachment { set; get; }

    }


}

