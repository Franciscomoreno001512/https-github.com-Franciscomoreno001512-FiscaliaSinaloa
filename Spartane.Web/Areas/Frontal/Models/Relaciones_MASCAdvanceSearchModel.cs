using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Relaciones_MASCAdvanceSearchModel
    {
        public Relaciones_MASCAdvanceSearchModel()
        {
            Requiere_cambiar_la_relacion = RadioOptions.NoApply;

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters EstatusFilter { set; get; }
        public string AdvanceEstatus { set; get; }
        public int[] AdvanceEstatusMultiple { set; get; }

        public Filters Numero_de_ExpedienteFilter { set; get; }
        public string AdvanceNumero_de_Expediente { set; get; }
        public int[] AdvanceNumero_de_ExpedienteMultiple { set; get; }

        public Filters Numero_de_ProcedimientoFilter { set; get; }
        public string Numero_de_Procedimiento { set; get; }

        public Filters idRelacionOrigenFilter { set; get; }
        public string AdvanceidRelacionOrigen { set; get; }
        public int[] AdvanceidRelacionOrigenMultiple { set; get; }

        public RadioOptions Requiere_cambiar_la_relacion { set; get; }

        public Filters Motivo_de_CambioFilter { set; get; }
        public string Motivo_de_Cambio { set; get; }

        public Filters ObservacionesFilter { set; get; }
        public string Observaciones { set; get; }

        public Filters DescripcionFilter { set; get; }
        public string Descripcion { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Resolucion_solicitud { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Resolucion_solicitud", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Resolucion_solicitud { set; get; }

        public string ToHora_de_Resolucion_solicitud { set; get; }
        public string FromHora_de_Resolucion_solicitud { set; get; }

        public Filters Usuario_que_Resuelve_solicitudFilter { set; get; }
        public string AdvanceUsuario_que_Resuelve_solicitud { set; get; }
        public int[] AdvanceUsuario_que_Resuelve_solicitudMultiple { set; get; }

        public Filters ResolucionFilter { set; get; }
        public string AdvanceResolucion { set; get; }
        public int[] AdvanceResolucionMultiple { set; get; }

        public Filters Tipo_de_MecanismoFilter { set; get; }
        public string AdvanceTipo_de_Mecanismo { set; get; }
        public int[] AdvanceTipo_de_MecanismoMultiple { set; get; }

        public Filters Observaciones_solicitudFilter { set; get; }
        public string Observaciones_solicitud { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Validacion_solicitud { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Validacion_solicitud", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Validacion_solicitud { set; get; }

        public string ToHora_de_Validacion_solicitud { set; get; }
        public string FromHora_de_Validacion_solicitud { set; get; }

        public Filters Usuario_que_Valida_solicitudFilter { set; get; }
        public string AdvanceUsuario_que_Valida_solicitud { set; get; }
        public int[] AdvanceUsuario_que_Valida_solicitudMultiple { set; get; }

        public Filters resultado_solicitudFilter { set; get; }
        public string Advanceresultado_solicitud { set; get; }
        public int[] Advanceresultado_solicitudMultiple { set; get; }

        public Filters motivo_rechazo_solicitudFilter { set; get; }
        public string motivo_rechazo_solicitud { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Resolucion_proc { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Resolucion_proc", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Resolucion_proc { set; get; }

        public string Tohora_resolucion_proc { set; get; }
        public string Fromhora_resolucion_proc { set; get; }

        public Filters usuario_resuelve_procFilter { set; get; }
        public string Advanceusuario_resuelve_proc { set; get; }
        public int[] Advanceusuario_resuelve_procMultiple { set; get; }

        public Filters Resolucion_procFilter { set; get; }
        public string AdvanceResolucion_proc { set; get; }
        public int[] AdvanceResolucion_procMultiple { set; get; }

        public Filters Observaciones_procFilter { set; get; }
        public string Observaciones_proc { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Validacion_proc { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Validacion_proc", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Validacion_proc { set; get; }

        public string ToHora_de_Validacion_proc { set; get; }
        public string FromHora_de_Validacion_proc { set; get; }

        public Filters Usuario_que_Valida_procFilter { set; get; }
        public string AdvanceUsuario_que_Valida_proc { set; get; }
        public int[] AdvanceUsuario_que_Valida_procMultiple { set; get; }

        public Filters Resultado_procFilter { set; get; }
        public string AdvanceResultado_proc { set; get; }
        public int[] AdvanceResultado_procMultiple { set; get; }

        public Filters Motivo_de_Rechazo_procFilter { set; get; }
        public string Motivo_de_Rechazo_proc { set; get; }


    }
}
