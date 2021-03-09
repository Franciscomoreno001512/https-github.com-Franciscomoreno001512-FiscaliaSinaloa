using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Solicitud_de_Servicios_de_ApoyoAdvanceSearchModel
    {
        public Solicitud_de_Servicios_de_ApoyoAdvanceSearchModel()
        {
            Ver_Documento = RadioOptions.NoApply;
            Enviar_Contestacion = RadioOptions.NoApply;

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

        public Filters RegionFilter { set; get; }
        public string AdvanceRegion { set; get; }
        public int[] AdvanceRegionMultiple { set; get; }

        public Filters OrigenFilter { set; get; }
        public string AdvanceOrigen { set; get; }
        public int[] AdvanceOrigenMultiple { set; get; }

        public Filters Numero_de_Expediente_ATFilter { set; get; }
        public string AdvanceNumero_de_Expediente_AT { set; get; }
        public int[] AdvanceNumero_de_Expediente_ATMultiple { set; get; }

        public Filters Numero_de_Expediente_MPFilter { set; get; }
        public string AdvanceNumero_de_Expediente_MP { set; get; }
        public int[] AdvanceNumero_de_Expediente_MPMultiple { set; get; }

        public Filters NUATFilter { set; get; }
        public string NUAT { set; get; }

        public Filters Numero_de_DenunciaFilter { set; get; }
        public string Numero_de_Denuncia { set; get; }

        public Filters Carpeta_de_InvestigacionFilter { set; get; }
        public string Carpeta_de_Investigacion { set; get; }

        public Filters Numero_de_OficioFilter { set; get; }
        public string Numero_de_Oficio { set; get; }

        public Filters SolicitudFilter { set; get; }
        public string AdvanceSolicitud { set; get; }
        public int[] AdvanceSolicitudMultiple { set; get; }

        public RadioOptions Ver_Documento { set; get; }

        public Filters ObservacionesFilter { set; get; }
        public string Observaciones { set; get; }

        public Filters EstatusFilter { set; get; }
        public string AdvanceEstatus { set; get; }
        public int[] AdvanceEstatusMultiple { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Recepcion { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Recepcion", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Recepcion { set; get; }

        public string ToHora_de_Recepcion { set; get; }
        public string FromHora_de_Recepcion { set; get; }

        public Filters Usuario_que_RecibeFilter { set; get; }
        public string AdvanceUsuario_que_Recibe { set; get; }
        public int[] AdvanceUsuario_que_RecibeMultiple { set; get; }

        public Filters Area_AsignadaFilter { set; get; }
        public string AdvanceArea_Asignada { set; get; }
        public int[] AdvanceArea_AsignadaMultiple { set; get; }

        public Filters SubArea_AsignadaFilter { set; get; }
        public string AdvanceSubArea_Asignada { set; get; }
        public int[] AdvanceSubArea_AsignadaMultiple { set; get; }

        public Filters Observaciones_RecepcionFilter { set; get; }
        public string Observaciones_Recepcion { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Asignacion { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Asignacion", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Asignacion { set; get; }

        public string ToHora_de_Asignacion { set; get; }
        public string FromHora_de_Asignacion { set; get; }

        public Filters Usuario_que_AsignaFilter { set; get; }
        public string AdvanceUsuario_que_Asigna { set; get; }
        public int[] AdvanceUsuario_que_AsignaMultiple { set; get; }

        public Filters Tipo_de_AsignacionFilter { set; get; }
        public string AdvanceTipo_de_Asignacion { set; get; }
        public int[] AdvanceTipo_de_AsignacionMultiple { set; get; }

        public Filters Responsable_AsignadoFilter { set; get; }
        public string AdvanceResponsable_Asignado { set; get; }
        public int[] AdvanceResponsable_AsignadoMultiple { set; get; }

        public Filters Observaciones_AsignacionFilter { set; get; }
        public string Observaciones_Asignacion { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Contestacion { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Contestacion", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Contestacion { set; get; }

        public string ToHora_de_Contestacion { set; get; }
        public string FromHora_de_Contestacion { set; get; }

        public Filters Usuario_que_contestaFilter { set; get; }
        public string AdvanceUsuario_que_contesta { set; get; }
        public int[] AdvanceUsuario_que_contestaMultiple { set; get; }

        public Filters DictamenFilter { set; get; }
        public string AdvanceDictamen { set; get; }
        public int[] AdvanceDictamenMultiple { set; get; }

        public RadioOptions Enviar_Contestacion { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromArchivo { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromArchivo", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToArchivo { set; get; }

        public Filters Observaciones_ContestacionFilter { set; get; }
        public string Observaciones_Contestacion { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Revision { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Revision", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Revision { set; get; }

        public string ToHora_de_Revision { set; get; }
        public string FromHora_de_Revision { set; get; }

        public Filters Usuario_que_RevisaFilter { set; get; }
        public string AdvanceUsuario_que_Revisa { set; get; }
        public int[] AdvanceUsuario_que_RevisaMultiple { set; get; }

        public Filters Resultado_de_AutorizacionFilter { set; get; }
        public string AdvanceResultado_de_Autorizacion { set; get; }
        public int[] AdvanceResultado_de_AutorizacionMultiple { set; get; }

        public Filters Motivo_de_RechazoFilter { set; get; }
        public string Motivo_de_Rechazo { set; get; }

        public Filters Observaciones_AutorizacionFilter { set; get; }
        public string Observaciones_Autorizacion { set; get; }


    }
}
