using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class ResolucionAdvanceSearchModel
    {
        public ResolucionAdvanceSearchModel()
        {
            Generar_Judicializacion = RadioOptions.NoApply;
            Aplica_para_Adolescentes = RadioOptions.NoApply;

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters DescripcionFilter { set; get; }
        public string Descripcion { set; get; }

        public Filters TipoFilter { set; get; }
        public string AdvanceTipo { set; get; }
        public int[] AdvanceTipoMultiple { set; get; }

        public Filters Resolucion_Padre_para_AutorizacionFilter { set; get; }
        public string AdvanceResolucion_Padre_para_Autorizacion { set; get; }
        public int[] AdvanceResolucion_Padre_para_AutorizacionMultiple { set; get; }

        public RadioOptions Generar_Judicializacion { set; get; }

        public Filters ClaveFiscaliaFilter { set; get; }
        public string ClaveFiscalia { set; get; }

        public RadioOptions Aplica_para_Adolescentes { set; get; }


    }
}
