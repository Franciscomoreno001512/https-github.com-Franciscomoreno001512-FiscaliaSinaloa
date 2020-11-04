using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Solicitud_de_NotificacionAdvanceSearchModel
    {
        public Solicitud_de_NotificacionAdvanceSearchModel()
        {

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromFolio { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromFolio", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFolio { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Solicitud { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Solicitud", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Solicitud { set; get; }

        public string ToHora_de_Solicitud { set; get; }
        public string FromHora_de_Solicitud { set; get; }

        public Filters Usuario_que_SolicitaFilter { set; get; }
        public string AdvanceUsuario_que_Solicita { set; get; }
        public int[] AdvanceUsuario_que_SolicitaMultiple { set; get; }

        public Filters OrigenFilter { set; get; }
        public string AdvanceOrigen { set; get; }
        public int[] AdvanceOrigenMultiple { set; get; }

        public Filters Expediente_Atencion_TempranaFilter { set; get; }
        public string AdvanceExpediente_Atencion_Temprana { set; get; }
        public int[] AdvanceExpediente_Atencion_TempranaMultiple { set; get; }

        public Filters Expediente_Mecanismos_AlternosFilter { set; get; }
        public string AdvanceExpediente_Mecanismos_Alternos { set; get; }
        public int[] AdvanceExpediente_Mecanismos_AlternosMultiple { set; get; }

        public Filters Carpeta_de_InvestigacionFilter { set; get; }
        public string AdvanceCarpeta_de_Investigacion { set; get; }
        public int[] AdvanceCarpeta_de_InvestigacionMultiple { set; get; }

        public Filters Forma_de_InvitacionFilter { set; get; }
        public string AdvanceForma_de_Invitacion { set; get; }
        public int[] AdvanceForma_de_InvitacionMultiple { set; get; }

        public Filters Numero_de_InvitacionFilter { set; get; }
        public string Numero_de_Invitacion { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_la_cita { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_la_cita", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_la_cita { set; get; }

        public string ToHora_de_la_Cita { set; get; }
        public string FromHora_de_la_Cita { set; get; }

        public Filters Lugar_de_la_CitaFilter { set; get; }
        public string Lugar_de_la_Cita { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromArchivo { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromArchivo", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToArchivo { set; get; }

        public Filters EstatusFilter { set; get; }
        public string AdvanceEstatus { set; get; }
        public int[] AdvanceEstatusMultiple { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Notificacion { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Notificacion", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Notificacion { set; get; }

        public string ToHora_de_Notificacion { set; get; }
        public string FromHora_de_Notificacion { set; get; }

        public Filters NotificadorFilter { set; get; }
        public string AdvanceNotificador { set; get; }
        public int[] AdvanceNotificadorMultiple { set; get; }

        public Filters ResultadoFilter { set; get; }
        public string AdvanceResultado { set; get; }
        public int[] AdvanceResultadoMultiple { set; get; }

        public Filters Incidente_en_la_RecepcionFilter { set; get; }
        public string AdvanceIncidente_en_la_Recepcion { set; get; }
        public int[] AdvanceIncidente_en_la_RecepcionMultiple { set; get; }


    }
}
