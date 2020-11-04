using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Correccion_de_Error_en_EstatusAdvanceSearchModel
    {
        public Correccion_de_Error_en_EstatusAdvanceSearchModel()
        {

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters NUATFilter { set; get; }
        public string NUAT { set; get; }

        public Filters Estatus_ActualFilter { set; get; }
        public string AdvanceEstatus_Actual { set; get; }
        public int[] AdvanceEstatus_ActualMultiple { set; get; }

        public Filters Estatus_a_CambiarFilter { set; get; }
        public string AdvanceEstatus_a_Cambiar { set; get; }
        public int[] AdvanceEstatus_a_CambiarMultiple { set; get; }

        public Filters MotivoFilter { set; get; }
        public string Motivo { set; get; }


    }
}
