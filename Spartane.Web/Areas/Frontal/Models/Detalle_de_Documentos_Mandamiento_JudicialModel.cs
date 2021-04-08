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
        public int? Registro_de_Orden_de_Aprehension { get; set; }
        public string Registro_de_Orden_de_AprehensionNumero_de_Mandamiento { get; set; }
        public int? Documentos { get; set; }
        public HttpPostedFileBase DocumentosFile { set; get; }
        public int DocumentosRemoveAttachment { set; get; }
        public string Descripcion { get; set; }

    }
	
	public class Detalle_de_Documentos_Mandamiento_Judicial_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Registro_de_Orden_de_Aprehension { get; set; }
        public string Registro_de_Orden_de_AprehensionNumero_de_Mandamiento { get; set; }
        public int? Documentos { get; set; }
        public HttpPostedFileBase DocumentosFile { set; get; }
        public int DocumentosRemoveAttachment { set; get; }
        public string Descripcion { get; set; }

    }


}

