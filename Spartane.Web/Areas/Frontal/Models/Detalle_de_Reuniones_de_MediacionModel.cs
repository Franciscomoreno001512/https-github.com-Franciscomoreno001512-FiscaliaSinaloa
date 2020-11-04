using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Reuniones_de_MediacionModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Numero_de_Expediente { get; set; }
        public string Numero_de_ExpedienteNumero_de_Folio { get; set; }
        public string Lugar { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public int? Especialista { get; set; }
        public string EspecialistaName { get; set; }
        public int? Mecanismo_Alterno { get; set; }
        public string Mecanismo_AlternoDescripcion { get; set; }
        public int? Tipo_de_Sesion { get; set; }
        public string Tipo_de_SesionDescripcion { get; set; }
        public int? Cumplimiento { get; set; }
        public string CumplimientoDescripcion { get; set; }
        public string Fecha_de_Registro { get; set; }
        public int? Archivo_adjunto { get; set; }
        public HttpPostedFileBase Archivo_adjuntoFile { set; get; }
        public int Archivo_adjuntoRemoveAttachment { set; get; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Usuario_que_RegistraName { get; set; }

    }
	
	public class Detalle_de_Reuniones_de_Mediacion_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Numero_de_Expediente { get; set; }
        public string Numero_de_ExpedienteNumero_de_Folio { get; set; }
        public string Lugar { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public int? Especialista { get; set; }
        public string EspecialistaName { get; set; }
        public int? Mecanismo_Alterno { get; set; }
        public string Mecanismo_AlternoDescripcion { get; set; }
        public int? Tipo_de_Sesion { get; set; }
        public string Tipo_de_SesionDescripcion { get; set; }
        public int? Cumplimiento { get; set; }
        public string CumplimientoDescripcion { get; set; }
        public string Fecha_de_Registro { get; set; }
        public int? Archivo_adjunto { get; set; }
        public HttpPostedFileBase Archivo_adjuntoFile { set; get; }
        public int Archivo_adjuntoRemoveAttachment { set; get; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Usuario_que_RegistraName { get; set; }

    }


}

