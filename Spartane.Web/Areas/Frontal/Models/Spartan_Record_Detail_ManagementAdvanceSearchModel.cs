using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Spartan_Record_Detail_ManagementAdvanceSearchModel
    {
        public Spartan_Record_Detail_ManagementAdvanceSearchModel()
        {

        }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromProcess_Id { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromProcess_Id", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToProcess_Id { set; get; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        public string FromRegister_Date { set; get; }
        [DataType(DataType.Date, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "InvalidDate")]
        [IsDateAfter("FromRegister_Date", true, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToRegister_Date { set; get; }

        public string ToRegister_Hour { set; get; }
        public string FromRegister_Hour { set; get; }

        public Filters Register_UserFilter { set; get; }
        public string AdvanceRegister_User { set; get; }
        public int[] AdvanceRegister_UserMultiple { set; get; }

        public Filters DescriptionFilter { set; get; }
        public string Description { set; get; }

        public Filters ObjectFilter { set; get; }
        public string AdvanceObject { set; get; }
        public int[] AdvanceObjectMultiple { set; get; }

        public Filters Reference_LabelFilter { set; get; }
        public string Reference_Label { set; get; }

        public Filters Reference_FieldFilter { set; get; }
        public string AdvanceReference_Field { set; get; }
        public int[] AdvanceReference_FieldMultiple { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromSearch_Result { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromSearch_Result", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToSearch_Result { set; get; }

        public Filters Search_Result_QueryFilter { set; get; }
        public string Search_Result_Query { set; get; }

        public Filters Image_FieldFilter { set; get; }
        public string AdvanceImage_Field { set; get; }
        public int[] AdvanceImage_FieldMultiple { set; get; }

        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        public string FromData_Detail { set; get; }
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanZero")]
        [IsNumberAfterAttribute("FromData_Detail", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "GreaterThanFrom")]
        public string ToData_Detail { set; get; }

        public Filters Query_Data_DetailFilter { set; get; }
        public string Query_Data_Detail { set; get; }


    }
}
