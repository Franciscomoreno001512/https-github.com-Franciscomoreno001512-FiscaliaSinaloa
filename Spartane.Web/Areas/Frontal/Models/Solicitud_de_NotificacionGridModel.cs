using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Solicitud_de_NotificacionGridModel
    {
        public int Folio { get; set; }
        public string Fecha_de_Solicitud { get; set; }
        public string Hora_de_Solicitud { get; set; }
        public int? Usuario_que_Solicita { get; set; }
        public string Usuario_que_SolicitaName { get; set; }
        public int? Origen { get; set; }
        public string OrigenDescripcion { get; set; }
        public int? Expediente_Atencion_Temprana { get; set; }
        public string Expediente_Atencion_TempranaFolio { get; set; }
        public int? Expediente_Mecanismos_Alternos { get; set; }
        public string Expediente_Mecanismos_AlternosNumero_de_Folio { get; set; }
        public int? Carpeta_de_Investigacion { get; set; }
        public string Carpeta_de_InvestigacionNIC { get; set; }
        public int? Forma_de_Invitacion { get; set; }
        public string Forma_de_InvitacionDescripcion { get; set; }
        public string Numero_de_Invitacion { get; set; }
        public string Fecha_de_la_cita { get; set; }
        public string Hora_de_la_Cita { get; set; }
        public string Lugar_de_la_Cita { get; set; }
        public int? Archivo { get; set; }
        public int? Estatus { get; set; }
        public string EstatusDescripcion { get; set; }
        public string Fecha_de_Notificacion { get; set; }
        public string Hora_de_Notificacion { get; set; }
        public int? Notificador { get; set; }
        public string NotificadorName { get; set; }
        public int? Resultado { get; set; }
        public string ResultadoDescripcion { get; set; }
        public int? Incidente_en_la_Recepcion { get; set; }
        public string Incidente_en_la_RecepcionDescripcion { get; set; }
        
    }
}

