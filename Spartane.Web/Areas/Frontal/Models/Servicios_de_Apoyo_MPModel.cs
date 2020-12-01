using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Servicios_de_Apoyo_MPModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Expediente_MP { get; set; }
        public string Expediente_MPnic { get; set; }
        public string Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Usuario_que_RegistraName { get; set; }
        public short? Categoria { get; set; }
        public string CategoriaDescripcion { get; set; }
        public int? Tipo_de_Servicio { get; set; }
        public string Tipo_de_ServicioServicio { get; set; }
        public string Solicitud { get; set; }
        public string Fecha_de_Termino_para_Entrega { get; set; }
        public string Hora_de_Termino_para_Entrega { get; set; }
        public int? Diligencia_a_Enviar { get; set; }
        public string Diligencia_a_EnviarDescripcion { get; set; }
        public int? Archivo { get; set; }
        public HttpPostedFileBase ArchivoFile { set; get; }
        public int ArchivoRemoveAttachment { set; get; }
        public string Fecha_de_Atencion { get; set; }
        public string Hora_de_Atencion { get; set; }
        public int? Usuario_que_Atiende { get; set; }
        public string Usuario_que_AtiendeName { get; set; }
        public int? Archivo_Adjunto { get; set; }
        public HttpPostedFileBase Archivo_AdjuntoFile { set; get; }
        public int Archivo_AdjuntoRemoveAttachment { set; get; }

    }
	
	public class Servicios_de_Apoyo_MP_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Expediente_MP { get; set; }
        public string Expediente_MPnic { get; set; }
        public string Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Usuario_que_RegistraName { get; set; }
        public short? Categoria { get; set; }
        public string CategoriaDescripcion { get; set; }
        public int? Tipo_de_Servicio { get; set; }
        public string Tipo_de_ServicioServicio { get; set; }
        public string Solicitud { get; set; }
        public string Fecha_de_Termino_para_Entrega { get; set; }
        public string Hora_de_Termino_para_Entrega { get; set; }
        public int? Diligencia_a_Enviar { get; set; }
        public string Diligencia_a_EnviarDescripcion { get; set; }
        public int? Archivo { get; set; }
        public HttpPostedFileBase ArchivoFile { set; get; }
        public int ArchivoRemoveAttachment { set; get; }

    }

	public class Servicios_de_Apoyo_MP_ContestacionModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha_de_Atencion { get; set; }
        public string Hora_de_Atencion { get; set; }
        public int? Usuario_que_Atiende { get; set; }
        public string Usuario_que_AtiendeName { get; set; }
        public int? Archivo_Adjunto { get; set; }
        public HttpPostedFileBase Archivo_AdjuntoFile { set; get; }
        public int Archivo_AdjuntoRemoveAttachment { set; get; }

    }


}

