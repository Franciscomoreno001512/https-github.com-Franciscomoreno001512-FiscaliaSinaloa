using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_RelacionesAdvanceSearchModel
    {
        public Detalle_de_RelacionesAdvanceSearchModel()
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

        public Filters Expediente_MPFilter { set; get; }
        public string AdvanceExpediente_MP { set; get; }
        public int[] AdvanceExpediente_MPMultiple { set; get; }

        public Filters InvolucradoFilter { set; get; }
        public string AdvanceInvolucrado { set; get; }
        public int[] AdvanceInvolucradoMultiple { set; get; }

        public Filters Probable_ResponsableFilter { set; get; }
        public string AdvanceProbable_Responsable { set; get; }
        public int[] AdvanceProbable_ResponsableMultiple { set; get; }

        public Filters DelitoFilter { set; get; }
        public string AdvanceDelito { set; get; }
        public int[] AdvanceDelitoMultiple { set; get; }

        public Filters Es_FamiliarFilter { set; get; }
        public string AdvanceEs_Familiar { set; get; }
        public int[] AdvanceEs_FamiliarMultiple { set; get; }

        public Filters ParentescoFilter { set; get; }
        public string AdvanceParentesco { set; get; }
        public int[] AdvanceParentescoMultiple { set; get; }

        public Filters DescripcionFilter { set; get; }
        public string Descripcion { set; get; }


    }
}
