using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class JudicializacionAdvanceSearchModel
    {
        public JudicializacionAdvanceSearchModel()
        {

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters Expediente_MPFilter { set; get; }
        public string AdvanceExpediente_MP { set; get; }
        public int[] AdvanceExpediente_MPMultiple { set; get; }

        public Filters ResolucionFilter { set; get; }
        public string AdvanceResolucion { set; get; }
        public int[] AdvanceResolucionMultiple { set; get; }

        public Filters TipoFilter { set; get; }
        public string AdvanceTipo { set; get; }
        public int[] AdvanceTipoMultiple { set; get; }

        public Filters causa_o_cuadernilloFilter { set; get; }
        public string causa_o_cuadernillo { set; get; }

        public Filters Fase_ActualFilter { set; get; }
        public string AdvanceFase_Actual { set; get; }
        public int[] AdvanceFase_ActualMultiple { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_Actos { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_Actos", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_Actos { set; get; }

        public string ToHora_Actos { set; get; }
        public string FromHora_Actos { set; get; }

        public Filters Observaciones_ActosFilter { set; get; }
        public string Observaciones_Actos { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_Genericos { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_Genericos", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_Genericos { set; get; }

        public string ToHora_Genericos { set; get; }
        public string FromHora_Genericos { set; get; }

        public Filters Observaciones_GenericosFilter { set; get; }
        public string Observaciones_Genericos { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_Fase_Inicial { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_Fase_Inicial", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_Fase_Inicial { set; get; }

        public string ToHora_Fase_Inicial { set; get; }
        public string FromHora_Fase_Inicial { set; get; }

        public Filters Observaciones_Fase_InicialFilter { set; get; }
        public string Observaciones_Fase_Inicial { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_Fase_Intermedia { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_Fase_Intermedia", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_Fase_Intermedia { set; get; }

        public string ToHora_Fase_Intermedia { set; get; }
        public string FromHora_Fase_Intermedia { set; get; }

        public Filters Observaciones_Fase_IntermediaFilter { set; get; }
        public string Observaciones_Fase_Intermedia { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Audiencia_de_Juicio { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Audiencia_de_Juicio", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Audiencia_de_Juicio { set; get; }

        public string ToHora_de_Audiencia_de_Juicio { set; get; }
        public string FromHora_de_Audiencia_de_Juicio { set; get; }

        public Filters Tribunal_de_EnjuiciamientoFilter { set; get; }
        public string AdvanceTribunal_de_Enjuiciamiento { set; get; }
        public int[] AdvanceTribunal_de_EnjuiciamientoMultiple { set; get; }

        public Filters Nombre_del_JuezFilter { set; get; }
        public string Nombre_del_Juez { set; get; }

        public Filters Juez_PresidenteFilter { set; get; }
        public string Juez_Presidente { set; get; }

        public Filters Juez_RelatorFilter { set; get; }
        public string Juez_Relator { set; get; }

        public Filters Juez_VocalFilter { set; get; }
        public string Juez_Vocal { set; get; }

        public Filters medios_desahogoFilter { set; get; }
        public string medios_desahogo { set; get; }

        public Filters Tipo_de_SentenciaFilter { set; get; }
        public string AdvanceTipo_de_Sentencia { set; get; }
        public int[] AdvanceTipo_de_SentenciaMultiple { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromCuantia_de_Pena_Anos { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromCuantia_de_Pena_Anos", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToCuantia_de_Pena_Anos { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromCuantia_de_Pena_Meses { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromCuantia_de_Pena_Meses", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToCuantia_de_Pena_Meses { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromMonto_de_Reparacion_del_Dano { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromMonto_de_Reparacion_del_Dano", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToMonto_de_Reparacion_del_Dano { set; get; }

        public Filters Observaciones_Fase_Juicio_OralFilter { set; get; }
        public string Observaciones_Fase_Juicio_Oral { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_Fase_Salidas_Alternas { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_Fase_Salidas_Alternas", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_Fase_Salidas_Alternas { set; get; }

        public string ToHora_Fase_Salidas_Alternas { set; get; }
        public string FromHora_Fase_Salidas_Alternas { set; get; }

        public Filters Observaciones_Fase_Salidas_AlternasFilter { set; get; }
        public string Observaciones_Fase_Salidas_Alternas { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_Fase_Sobreseimientos { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_Fase_Sobreseimientos", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_Fase_Sobreseimientos { set; get; }

        public string ToHora_Fase_Sobreseimientos { set; get; }
        public string FromHora_Fase_Sobreseimientos { set; get; }

        public Filters Observaciones_Fase_SobreseimientosFilter { set; get; }
        public string Observaciones_Fase_Sobreseimientos { set; get; }

        public Filters ObservacionesFilter { set; get; }
        public string Observaciones { set; get; }


    }
}
