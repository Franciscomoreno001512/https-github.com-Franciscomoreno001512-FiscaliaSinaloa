using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Proceso_PenalAdvanceSearchModel
    {
        public Proceso_PenalAdvanceSearchModel()
        {

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromFolio { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromFolio", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFolio { set; get; }

        public Filters Expediente_MPFilter { set; get; }
        public string AdvanceExpediente_MP { set; get; }
        public int[] AdvanceExpediente_MPMultiple { set; get; }

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

        public Filters ImputadoFilter { set; get; }
        public string AdvanceImputado { set; get; }
        public int[] AdvanceImputadoMultiple { set; get; }

        public Filters Reclasificacion_JuridicaFilter { set; get; }
        public string AdvanceReclasificacion_Juridica { set; get; }
        public int[] AdvanceReclasificacion_JuridicaMultiple { set; get; }

        public Filters Plazo_ConstitucionalFilter { set; get; }
        public string AdvancePlazo_Constitucional { set; get; }
        public int[] AdvancePlazo_ConstitucionalMultiple { set; get; }

        public Filters VinculacionFilter { set; get; }
        public string AdvanceVinculacion { set; get; }
        public int[] AdvanceVinculacionMultiple { set; get; }

        public Filters Resultado_No_VinculacionFilter { set; get; }
        public string AdvanceResultado_No_Vinculacion { set; get; }
        public int[] AdvanceResultado_No_VinculacionMultiple { set; get; }

        public Filters Resultado_VinculacionFilter { set; get; }
        public string AdvanceResultado_Vinculacion { set; get; }
        public int[] AdvanceResultado_VinculacionMultiple { set; get; }

        public Filters plazo_investigacion_complementariaFilter { set; get; }
        public string Advanceplazo_investigacion_complementaria { set; get; }
        public int[] Advanceplazo_investigacion_complementariaMultiple { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string Fromfecha_investigacion_complementaria { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("Fromfecha_investigacion_complementaria", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string Tofecha_investigacion_complementaria { set; get; }

        public string Tohora_investigacion_complementaria { set; get; }
        public string Fromhora_investigacion_complementaria { set; get; }

        public Filters Nombre_del_Juez_de_ControlFilter { set; get; }
        public string Nombre_del_Juez_de_Control { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Entrega_de_Escrito_de_Acusacion { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Entrega_de_Escrito_de_Acusacion", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Entrega_de_Escrito_de_Acusacion { set; get; }

        public string ToHora_de_Entrega_de_Escrito_de_Acusacion { set; get; }
        public string FromHora_de_Entrega_de_Escrito_de_Acusacion { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Audiencia_Intermedia { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Audiencia_Intermedia", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Audiencia_Intermedia { set; get; }

        public string ToHora_de_Audiencia_Intermedia { set; get; }
        public string FromHora_de_Audiencia_Intermedia { set; get; }

        public Filters Acusador_CoadyudanteFilter { set; get; }
        public string AdvanceAcusador_Coadyudante { set; get; }
        public int[] AdvanceAcusador_CoadyudanteMultiple { set; get; }

        public Filters cumplio_descubrimiento_probatorioFilter { set; get; }
        public string Advancecumplio_descubrimiento_probatorio { set; get; }
        public int[] Advancecumplio_descubrimiento_probatorioMultiple { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha { set; get; }

        public string ToHora { set; get; }
        public string FromHora { set; get; }

        public Filters Acuerdos_ProbatoriosFilter { set; get; }
        public string AdvanceAcuerdos_Probatorios { set; get; }
        public int[] AdvanceAcuerdos_ProbatoriosMultiple { set; get; }

        public Filters acuerdos_probatorios_cuales_fueronFilter { set; get; }
        public string acuerdos_probatorios_cuales_fueron { set; get; }

        public Filters ResultadoFilter { set; get; }
        public string AdvanceResultado { set; get; }
        public int[] AdvanceResultadoMultiple { set; get; }

        public Filters Tribunal_de_EnjuiciamientoFilter { set; get; }
        public string AdvanceTribunal_de_Enjuiciamiento { set; get; }
        public int[] AdvanceTribunal_de_EnjuiciamientoMultiple { set; get; }

        public Filters Nombre_del_JuezFilter { set; get; }
        public string Nombre_del_Juez { set; get; }

        public Filters Juez_ColegiadoFilter { set; get; }
        public string Juez_Colegiado { set; get; }

        public Filters Juez_RelatorFilter { set; get; }
        public string Juez_Relator { set; get; }

        public Filters Juez_VocalFilter { set; get; }
        public string Juez_Vocal { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Audiencia_de_Juicio { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Audiencia_de_Juicio", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Audiencia_de_Juicio { set; get; }

        public string ToHora_de_Audiencia_de_Juicio { set; get; }
        public string FromHora_de_Audiencia_de_Juicio { set; get; }

        public Filters Fallo_del_TribunalFilter { set; get; }
        public string AdvanceFallo_del_Tribunal { set; get; }
        public int[] AdvanceFallo_del_TribunalMultiple { set; get; }

        public Filters pruebas_a_desahogarFilter { set; get; }
        public string pruebas_a_desahogar { set; get; }

        public Filters ResolucionFilter { set; get; }
        public string AdvanceResolucion { set; get; }
        public int[] AdvanceResolucionMultiple { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromPlazo_meses { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromPlazo_meses", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToPlazo_meses { set; get; }

        public Filters Tipo_de_SentenciaFilter { set; get; }
        public string AdvanceTipo_de_Sentencia { set; get; }
        public int[] AdvanceTipo_de_SentenciaMultiple { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string Fromcuantia_de_pena_anios { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("Fromcuantia_de_pena_anios", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string Tocuantia_de_pena_anios { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string Fromcuantia_de_pena_meses { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("Fromcuantia_de_pena_meses", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string Tocuantia_de_pena_meses { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromMonto_de_la_Reparacion_del_Dano { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromMonto_de_la_Reparacion_del_Dano", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToMonto_de_la_Reparacion_del_Dano { set; get; }


    }
}
