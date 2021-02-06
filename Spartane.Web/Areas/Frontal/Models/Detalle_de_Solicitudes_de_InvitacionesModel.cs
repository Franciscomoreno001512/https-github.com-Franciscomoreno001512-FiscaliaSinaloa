using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Solicitudes_de_InvitacionesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Solicitud { get; set; }
        public string SolicitudNumero_de_Folio { get; set; }
        public string Fecha_de_Invitacion { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Usuario_que_RegistraName { get; set; }
        public string Numero_de_Invitacion { get; set; }
        public string Numero_de_Oficio { get; set; }
        public int? Formato_de_Invitacion { get; set; }
        public string Formato_de_InvitacionDescripcion { get; set; }
        public int? Tipo_de_Participacion { get; set; }
        public string Tipo_de_ParticipacionDescripcion { get; set; }
        public string Fecha_de_la_cita { get; set; }
        public string Hora_de_la_Cita { get; set; }
        public string Domicilio { get; set; }
        public string Fecha_de_Notificacion { get; set; }
        public string Hora_de_Notificacion { get; set; }
        public int? Notificador { get; set; }
        public string NotificadorName { get; set; }
        public int? Resultado { get; set; }
        public string ResultadoDescripcion { get; set; }
        public int? Incidente_en_la_Recepcion { get; set; }
        public string Incidente_en_la_RecepcionDescripcion { get; set; }
        public int? Documento { get; set; }
        public HttpPostedFileBase DocumentoFile { set; get; }
        public int DocumentoRemoveAttachment { set; get; }

    }
	
	public class Detalle_de_Solicitudes_de_Invitaciones_Datos_GeneralesModel
    {
        [Required]
        public int Clave { get; set; }
        public int? Solicitud { get; set; }
        public string SolicitudNumero_de_Folio { get; set; }
        public string Fecha_de_Invitacion { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Usuario_que_RegistraName { get; set; }
        public string Numero_de_Invitacion { get; set; }
        public string Numero_de_Oficio { get; set; }
        public int? Formato_de_Invitacion { get; set; }
        public string Formato_de_InvitacionDescripcion { get; set; }
        public int? Tipo_de_Participacion { get; set; }
        public string Tipo_de_ParticipacionDescripcion { get; set; }
        public string Fecha_de_la_cita { get; set; }
        public string Hora_de_la_Cita { get; set; }
        public string Domicilio { get; set; }

    }

	public class Detalle_de_Solicitudes_de_Invitaciones_Resultado_de_NotificacionModel
    {
        [Required]
        public int Clave { get; set; }
        public string Fecha_de_Notificacion { get; set; }
        public string Hora_de_Notificacion { get; set; }
        public int? Notificador { get; set; }
        public string NotificadorName { get; set; }
        public int? Resultado { get; set; }
        public string ResultadoDescripcion { get; set; }
        public int? Incidente_en_la_Recepcion { get; set; }
        public string Incidente_en_la_RecepcionDescripcion { get; set; }
        public int? Documento { get; set; }
        public HttpPostedFileBase DocumentoFile { set; get; }
        public int DocumentoRemoveAttachment { set; get; }

    }


}

