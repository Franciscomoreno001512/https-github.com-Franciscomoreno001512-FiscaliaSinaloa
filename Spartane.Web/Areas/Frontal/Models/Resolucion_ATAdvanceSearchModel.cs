using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Resolucion_ATAdvanceSearchModel
    {
        public Resolucion_ATAdvanceSearchModel()
        {

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters Modulo_Atencion_InicialFilter { set; get; }
        public string AdvanceModulo_Atencion_Inicial { set; get; }
        public int[] AdvanceModulo_Atencion_InicialMultiple { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Resolucion { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Resolucion", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Resolucion { set; get; }

        public Filters Persona_que_ResuelveFilter { set; get; }
        public string AdvancePersona_que_Resuelve { set; get; }
        public int[] AdvancePersona_que_ResuelveMultiple { set; get; }

        public Filters EstatusFilter { set; get; }
        public string AdvanceEstatus { set; get; }
        public int[] AdvanceEstatusMultiple { set; get; }

        public Filters ResolucionFilter { set; get; }
        public string AdvanceResolucion { set; get; }
        public int[] AdvanceResolucionMultiple { set; get; }

        public Filters RelacionFilter { set; get; }
        public string AdvanceRelacion { set; get; }
        public int[] AdvanceRelacionMultiple { set; get; }

        public Filters ObservacionesFilter { set; get; }
        public string Observaciones { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromFecha_de_Validacion { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromFecha_de_Validacion", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToFecha_de_Validacion { set; get; }

        public string ToHora_de_Validacion { set; get; }
        public string FromHora_de_Validacion { set; get; }

        public Filters DictaminadorFilter { set; get; }
        public string AdvanceDictaminador { set; get; }
        public int[] AdvanceDictaminadorMultiple { set; get; }

        public Filters Resultado_de_ValidacionFilter { set; get; }
        public string AdvanceResultado_de_Validacion { set; get; }
        public int[] AdvanceResultado_de_ValidacionMultiple { set; get; }

        public Filters Observaciones_DictaminadorFilter { set; get; }
        public string Observaciones_Dictaminador { set; get; }


    }
}
