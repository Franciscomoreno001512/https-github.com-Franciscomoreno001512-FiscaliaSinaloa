using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Acuerdos_MASCAdvanceSearchModel
    {
        public Acuerdos_MASCAdvanceSearchModel()
        {
            Acuerdo = RadioOptions.NoApply;

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters Numero_de_ExpedienteFilter { set; get; }
        public string AdvanceNumero_de_Expediente { set; get; }
        public int[] AdvanceNumero_de_ExpedienteMultiple { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Registro { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Registro", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Registro { set; get; }

        public string ToHora_de_Registro { set; get; }
        public string FromHora_de_Registro { set; get; }

        public Filters Usuario_que_RegistraFilter { set; get; }
        public string AdvanceUsuario_que_Registra { set; get; }
        public int[] AdvanceUsuario_que_RegistraMultiple { set; get; }

        public Filters Tipo_de_AcuerdoFilter { set; get; }
        public string AdvanceTipo_de_Acuerdo { set; get; }
        public int[] AdvanceTipo_de_AcuerdoMultiple { set; get; }

        public Filters Forma_de_CumplimientoFilter { set; get; }
        public string AdvanceForma_de_Cumplimiento { set; get; }
        public int[] AdvanceForma_de_CumplimientoMultiple { set; get; }

        public Filters Descripcion_del_CumplimientoFilter { set; get; }
        public string Descripcion_del_Cumplimiento { set; get; }

        public Filters SolicitanteFilter { set; get; }
        public string AdvanceSolicitante { set; get; }
        public int[] AdvanceSolicitanteMultiple { set; get; }

        public Filters RequeridoFilter { set; get; }
        public string AdvanceRequerido { set; get; }
        public int[] AdvanceRequeridoMultiple { set; get; }

        public Filters Lugar_AcordadoFilter { set; get; }
        public string Lugar_Acordado { set; get; }

        public Filters Domicilio_AcordadoFilter { set; get; }
        public string Domicilio_Acordado { set; get; }

        public string ToHora_de_Acuerdo { set; get; }
        public string FromHora_de_Acuerdo { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Inicio_de_Acuerdo { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Inicio_de_Acuerdo", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Inicio_de_Acuerdo { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromMonto_Total { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromMonto_Total", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToMonto_Total { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromParcialidades { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromParcialidades", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToParcialidades { set; get; }

        public Filters PeriodicidadFilter { set; get; }
        public string AdvancePeriodicidad { set; get; }
        public int[] AdvancePeriodicidadMultiple { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromMonto_de_la_Parcialidad { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromMonto_de_la_Parcialidad", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToMonto_de_la_Parcialidad { set; get; }

        public Filters Personal_de_Seguimiento_AsignadoFilter { set; get; }
        public string AdvancePersonal_de_Seguimiento_Asignado { set; get; }
        public int[] AdvancePersonal_de_Seguimiento_AsignadoMultiple { set; get; }

        public RadioOptions Acuerdo { set; get; }

        public Filters ComentariosFilter { set; get; }
        public string Comentarios { set; get; }

        public Filters Acuerdo_CumplidoFilter { set; get; }
        public string AdvanceAcuerdo_Cumplido { set; get; }
        public int[] AdvanceAcuerdo_CumplidoMultiple { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Cumplimiento_de_Acuerdo { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Cumplimiento_de_Acuerdo", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Cumplimiento_de_Acuerdo { set; get; }

        public Filters Razon_de_IncumplimientoFilter { set; get; }
        public string AdvanceRazon_de_Incumplimiento { set; get; }
        public int[] AdvanceRazon_de_IncumplimientoMultiple { set; get; }

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

        public Filters ResultadoFilter { set; get; }
        public string AdvanceResultado { set; get; }
        public int[] AdvanceResultadoMultiple { set; get; }

        public Filters Motivo_de_Rechazo_de_AcuerdoFilter { set; get; }
        public string Motivo_de_Rechazo_de_Acuerdo { set; get; }


    }
}
