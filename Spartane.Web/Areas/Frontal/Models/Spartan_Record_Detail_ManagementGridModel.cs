using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Spartan_Record_Detail_ManagementGridModel
    {
        public int Process_Id { get; set; }
        public string Register_Date { get; set; }
        public string Register_Hour { get; set; }
        public int? Register_User { get; set; }
        public string Register_UserName { get; set; }
        public string Description { get; set; }
        public int? Object { get; set; }
        public string ObjectDescription { get; set; }
        public string Reference_Label { get; set; }
        public int? Reference_Field { get; set; }
        public string Reference_FieldDescription { get; set; }
        public int? Search_Result { get; set; }
        public string Search_Result_Query { get; set; }
        public int? Image_Field { get; set; }
        public string Image_FieldDescription { get; set; }
        public int? Data_Detail { get; set; }
        public string Query_Data_Detail { get; set; }
        
    }
}

