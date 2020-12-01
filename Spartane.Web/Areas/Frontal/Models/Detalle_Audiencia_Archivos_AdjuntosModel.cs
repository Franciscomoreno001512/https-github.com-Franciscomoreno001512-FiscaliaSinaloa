using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Audiencia_Archivos_AdjuntosModel
    {
        [Required]
        public int Clave { get; set; }
        public string Nombre_Archivo { get; set; }
        public int? Archivo_Adjunto { get; set; }
        public HttpPostedFileBase Archivo_AdjuntoFile { set; get; }
        public int Archivo_AdjuntoRemoveAttachment { set; get; }

    }
	
	public class Detalle_Audiencia_Archivos_Adjuntos_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Nombre_Archivo { get; set; }
        public int? Archivo_Adjunto { get; set; }
        public HttpPostedFileBase Archivo_AdjuntoFile { set; get; }
        public int Archivo_AdjuntoRemoveAttachment { set; get; }

    }


}

