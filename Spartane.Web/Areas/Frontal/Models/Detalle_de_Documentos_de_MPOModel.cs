using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Documentos_de_MPOModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha { get; set; }
        public string Documento { get; set; }
        public int? Archivo { get; set; }
        public HttpPostedFileBase ArchivoFile { set; get; }
        public int ArchivoRemoveAttachment { set; get; }

    }
	
	public class Detalle_de_Documentos_de_MPO_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha { get; set; }
        public string Documento { get; set; }
        public int? Archivo { get; set; }
        public HttpPostedFileBase ArchivoFile { set; get; }
        public int ArchivoRemoveAttachment { set; get; }

    }


}

