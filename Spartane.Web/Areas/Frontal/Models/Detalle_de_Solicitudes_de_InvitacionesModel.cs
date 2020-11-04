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
        public string Fecha_de_Recepcion { get; set; }
        public string Fecha_de_Aceptacion { get; set; }
        public int? Cumplimiento { get; set; }
        public string CumplimientoDescripcion { get; set; }
        public int? Incidente { get; set; }
        public string IncidenteDescripcion { get; set; }
        public short? A_Tiempo { get; set; }
        public string A_TiempoDescripcion { get; set; }
        public int? Archivo { get; set; }
        public HttpPostedFileBase ArchivoFile { set; get; }
        public int ArchivoRemoveAttachment { set; get; }

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
        public string Fecha_de_Recepcion { get; set; }
        public string Fecha_de_Aceptacion { get; set; }
        public int? Cumplimiento { get; set; }
        public string CumplimientoDescripcion { get; set; }
        public int? Incidente { get; set; }
        public string IncidenteDescripcion { get; set; }
        public short? A_Tiempo { get; set; }
        public string A_TiempoDescripcion { get; set; }
        public int? Archivo { get; set; }
        public HttpPostedFileBase ArchivoFile { set; get; }
        public int ArchivoRemoveAttachment { set; get; }

    }


}

