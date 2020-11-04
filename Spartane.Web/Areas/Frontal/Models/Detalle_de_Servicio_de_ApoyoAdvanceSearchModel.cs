using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Servicio_de_ApoyoAdvanceSearchModel
    {
        public Detalle_de_Servicio_de_ApoyoAdvanceSearchModel()
        {
            Requiere_Traductor = RadioOptions.NoApply;

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters Modulo_de_Atencion_InicialFilter { set; get; }
        public string AdvanceModulo_de_Atencion_Inicial { set; get; }
        public int[] AdvanceModulo_de_Atencion_InicialMultiple { set; get; }

        public Filters Tipo_de_ServicioFilter { set; get; }
        public string AdvanceTipo_de_Servicio { set; get; }
        public int[] AdvanceTipo_de_ServicioMultiple { set; get; }

        public RadioOptions Requiere_Traductor { set; get; }

        public Filters Lengua_OriginariaFilter { set; get; }
        public string AdvanceLengua_Originaria { set; get; }
        public int[] AdvanceLengua_OriginariaMultiple { set; get; }

        public Filters IdiomaFilter { set; get; }
        public string AdvanceIdioma { set; get; }
        public int[] AdvanceIdiomaMultiple { set; get; }

        public Filters DictamenFilter { set; get; }
        public string Dictamen { set; get; }

        public Filters ResponsableFilter { set; get; }
        public string Responsable { set; get; }

        public Filters ComparecienteFilter { set; get; }
        public string AdvanceCompareciente { set; get; }
        public int[] AdvanceComparecienteMultiple { set; get; }


    }
}
