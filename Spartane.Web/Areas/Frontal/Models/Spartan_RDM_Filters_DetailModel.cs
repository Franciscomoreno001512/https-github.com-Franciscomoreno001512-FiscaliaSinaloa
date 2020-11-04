using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Spartan_RDM_Filters_DetailModel
    {
        [Required]
        public int Filters_Detail_Id { get; set; }
        public int? Field_Name { get; set; }
        public string Field_NameDescription { get; set; }
        public string Field_Label { get; set; }
        [Range(0, 9999999999)]
        public short? Order_Shown { get; set; }
        public string Field_Path { get; set; }
        public string Physical_Field_Name { get; set; }
        public string Logical_Field_Name { get; set; }

    }
	
	public class Spartan_RDM_Filters_Detail_Datos_GeneralesModel
    {
        [Required]
        public int Filters_Detail_Id { get; set; }
        public int? Field_Name { get; set; }
        public string Field_NameDescription { get; set; }
        public string Field_Label { get; set; }
        [Range(0, 9999999999)]
        public short? Order_Shown { get; set; }
        public string Field_Path { get; set; }
        public string Physical_Field_Name { get; set; }
        public string Logical_Field_Name { get; set; }

    }


}

