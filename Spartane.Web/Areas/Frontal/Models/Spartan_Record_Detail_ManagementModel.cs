using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Spartan_Record_Detail_ManagementModel
    {
        [Required]
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
        [Range(0, 9999999999)]
        public int? Search_Result { get; set; }
        public string Search_Result_Query { get; set; }
        public int? Image_Field { get; set; }
        public string Image_FieldDescription { get; set; }
        [Range(0, 9999999999)]
        public int? Data_Detail { get; set; }
        public string Query_Data_Detail { get; set; }

    }
	
	public class Spartan_Record_Detail_Management_Datos_GeneralesModel
    {
        [Required]
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

    }

	public class Spartan_Record_Detail_Management_BusquedaModel
    {
        [Required]
        public int Process_Id { get; set; }
        [Range(0, 9999999999)]
        public int? Search_Result { get; set; }
        public string Search_Result_Query { get; set; }

    }

	public class Spartan_Record_Detail_Management_Informacion_GeneralModel
    {
        [Required]
        public int Process_Id { get; set; }
        public int? Image_Field { get; set; }
        public string Image_FieldDescription { get; set; }
        [Range(0, 9999999999)]
        public int? Data_Detail { get; set; }
        public string Query_Data_Detail { get; set; }

    }

	public class Spartan_Record_Detail_Management_OperacionesModel
    {
        [Required]
        public int Process_Id { get; set; }

    }


}

