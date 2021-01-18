using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_FotosModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Foto_Perfil_Izquierdo { get; set; }
        public HttpPostedFileBase Foto_Perfil_IzquierdoFile { set; get; }
        public int Foto_Perfil_IzquierdoRemoveAttachment { set; get; }
        public int? Foto_Perfil_Derecho { get; set; }
        public HttpPostedFileBase Foto_Perfil_DerechoFile { set; get; }
        public int Foto_Perfil_DerechoRemoveAttachment { set; get; }
        public int? Foto_de_Frente { get; set; }
        public HttpPostedFileBase Foto_de_FrenteFile { set; get; }
        public int Foto_de_FrenteRemoveAttachment { set; get; }

    }
	
	public class Detalle_de_Fotos_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Foto_Perfil_Izquierdo { get; set; }
        public HttpPostedFileBase Foto_Perfil_IzquierdoFile { set; get; }
        public int Foto_Perfil_IzquierdoRemoveAttachment { set; get; }
        public int? Foto_Perfil_Derecho { get; set; }
        public HttpPostedFileBase Foto_Perfil_DerechoFile { set; get; }
        public int Foto_Perfil_DerechoRemoveAttachment { set; get; }
        public int? Foto_de_Frente { get; set; }
        public HttpPostedFileBase Foto_de_FrenteFile { set; get; }
        public int Foto_de_FrenteRemoveAttachment { set; get; }

    }


}

