using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Solicitudes_de_InvitacionesAdvanceSearchModel
    {
        public Detalle_de_Solicitudes_de_InvitacionesAdvanceSearchModel()
        {
            Archivo = RadioOptions.NoApply;

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters SolicitudFilter { set; get; }
        public string AdvanceSolicitud { set; get; }
        public int[] AdvanceSolicitudMultiple { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Invitacion { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Invitacion", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Invitacion { set; get; }

        public Filters Usuario_que_RegistraFilter { set; get; }
        public string AdvanceUsuario_que_Registra { set; get; }
        public int[] AdvanceUsuario_que_RegistraMultiple { set; get; }

        public Filters Numero_de_InvitacionFilter { set; get; }
        public string Numero_de_Invitacion { set; get; }

        public Filters Numero_de_OficioFilter { set; get; }
        public string Numero_de_Oficio { set; get; }

        public Filters Formato_de_InvitacionFilter { set; get; }
        public string AdvanceFormato_de_Invitacion { set; get; }
        public int[] AdvanceFormato_de_InvitacionMultiple { set; get; }

        public Filters Tipo_de_ParticipacionFilter { set; get; }
        public string AdvanceTipo_de_Participacion { set; get; }
        public int[] AdvanceTipo_de_ParticipacionMultiple { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_la_cita { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_la_cita", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_la_cita { set; get; }

        public string ToHora_de_la_Cita { set; get; }
        public string FromHora_de_la_Cita { set; get; }

        public Filters DomicilioFilter { set; get; }
        public string Domicilio { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Recepcion { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Recepcion", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Recepcion { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Aceptacion { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Aceptacion", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Aceptacion { set; get; }

        public Filters CumplimientoFilter { set; get; }
        public string AdvanceCumplimiento { set; get; }
        public int[] AdvanceCumplimientoMultiple { set; get; }

        public Filters IncidenteFilter { set; get; }
        public string AdvanceIncidente { set; get; }
        public int[] AdvanceIncidenteMultiple { set; get; }

        public Filters A_TiempoFilter { set; get; }
        public string AdvanceA_Tiempo { set; get; }
        public int[] AdvanceA_TiempoMultiple { set; get; }

        public RadioOptions Archivo { set; get; }


    }
}
