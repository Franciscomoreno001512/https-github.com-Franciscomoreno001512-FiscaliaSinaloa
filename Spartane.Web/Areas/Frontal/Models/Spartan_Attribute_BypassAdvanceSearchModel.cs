using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Spartan_Attribute_BypassAdvanceSearchModel
    {
        public Spartan_Attribute_BypassAdvanceSearchModel()
        {

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromAttributeId { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromAttributeId", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToAttributeId { set; get; }

        public Filters DescriptionFilter { set; get; }
        public string Description { set; get; }

        public Filters ObjectIdFilter { set; get; }
        public string AdvanceObjectId { set; get; }
        public int[] AdvanceObjectIdMultiple { set; get; }


    }
}
