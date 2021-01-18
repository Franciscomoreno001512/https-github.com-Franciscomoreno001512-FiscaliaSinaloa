using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Diligencias_CanalizacionModel
    {
        [Required]
        public int Clave { get; set; }
        public string Diligencia { get; set; }
        public int? Ver_Documento { get; set; }
        public HttpPostedFileBase Ver_DocumentoFile { set; get; }
        public int Ver_DocumentoRemoveAttachment { set; get; }
        public string Observaciones { get; set; }

    }
	
	public class Detalle_Diligencias_Canalizacion_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public string Diligencia { get; set; }
        public int? Ver_Documento { get; set; }
        public HttpPostedFileBase Ver_DocumentoFile { set; get; }
        public int Ver_DocumentoRemoveAttachment { set; get; }
        public string Observaciones { get; set; }

    }


}

