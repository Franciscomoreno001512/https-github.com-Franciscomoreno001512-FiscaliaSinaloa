using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Probable_Responsable_de_DocumentosAdvanceSearchModel
    {
        public Detalle_Probable_Responsable_de_DocumentosAdvanceSearchModel()
        {

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromClave { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromClave", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToClave { set; get; }

        public Filters IdDocumentosFilter { set; get; }
        public string IdDocumentos { set; get; }

        public Filters Probable_ResponsableFilter { set; get; }
        public string AdvanceProbable_Responsable { set; get; }
        public int[] AdvanceProbable_ResponsableMultiple { set; get; }


    }
}
