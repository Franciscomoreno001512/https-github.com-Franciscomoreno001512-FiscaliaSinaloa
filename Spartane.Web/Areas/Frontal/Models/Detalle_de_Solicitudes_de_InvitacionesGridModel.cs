using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Solicitudes_de_InvitacionesGridModel
    {
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
        public Grid_File DocumentoFileInfo { set; get; }
        
    }
}

