using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_DesestimacionAdvanceSearchModel
    {
        public Detalle_de_DesestimacionAdvanceSearchModel()
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

        public Filters Nombre_CompletoFilter { set; get; }
        public string AdvanceNombre_Completo { set; get; }
        public int[] AdvanceNombre_CompletoMultiple { set; get; }

        public Filters Causal_de_InterrupcionFilter { set; get; }
        public string AdvanceCausal_de_Interrupcion { set; get; }
        public int[] AdvanceCausal_de_InterrupcionMultiple { set; get; }

        public Filters Causa_de_InterrupcionFilter { set; get; }
        public string AdvanceCausa_de_Interrupcion { set; get; }
        public int[] AdvanceCausa_de_InterrupcionMultiple { set; get; }

        public Filters Datos_InsuficientesFilter { set; get; }
        public string AdvanceDatos_Insuficientes { set; get; }
        public int[] AdvanceDatos_InsuficientesMultiple { set; get; }

        public Filters Actualizacion_de_SobreseimientoFilter { set; get; }
        public string Actualizacion_de_Sobreseimiento { set; get; }


    }
}
