using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Solicitud_Datos_de_ApoyoModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Solicitud { get; set; }
        public string SolicitudNumero_de_Folio { get; set; }
        public string Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_registra { get; set; }
        public string Usuario_que_registraName { get; set; }
        public int? Tipo_de_Servicio { get; set; }
        public string Tipo_de_ServicioServicio { get; set; }
        public string Dictamen { get; set; }
        public int? Solicitante { get; set; }
        public string SolicitanteNombre_Completo { get; set; }
        public string Responsable { get; set; }
        public int? Idioma { get; set; }
        public string IdiomaDescripcion { get; set; }
        public int? Lengua_Originaria { get; set; }
        public string Lengua_OriginariaDescripcion { get; set; }
        public int? Diligencia_a_Enviar { get; set; }
        public string Diligencia_a_EnviarDescripcion { get; set; }
        public int? Archivo_Adjunto { get; set; }
        public HttpPostedFileBase Archivo_AdjuntoFile { set; get; }
        public int Archivo_AdjuntoRemoveAttachment { set; get; }

    }
	
	public class Detalle_de_Solicitud_Datos_de_Apoyo_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Solicitud { get; set; }
        public string SolicitudNumero_de_Folio { get; set; }
        public string Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_registra { get; set; }
        public string Usuario_que_registraName { get; set; }
        public int? Tipo_de_Servicio { get; set; }
        public string Tipo_de_ServicioServicio { get; set; }
        public string Dictamen { get; set; }
        public int? Solicitante { get; set; }
        public string SolicitanteNombre_Completo { get; set; }
        public string Responsable { get; set; }
        public int? Idioma { get; set; }
        public string IdiomaDescripcion { get; set; }
        public int? Lengua_Originaria { get; set; }
        public string Lengua_OriginariaDescripcion { get; set; }
        public int? Diligencia_a_Enviar { get; set; }
        public string Diligencia_a_EnviarDescripcion { get; set; }
        public int? Archivo_Adjunto { get; set; }
        public HttpPostedFileBase Archivo_AdjuntoFile { set; get; }
        public int Archivo_AdjuntoRemoveAttachment { set; get; }

    }


}

