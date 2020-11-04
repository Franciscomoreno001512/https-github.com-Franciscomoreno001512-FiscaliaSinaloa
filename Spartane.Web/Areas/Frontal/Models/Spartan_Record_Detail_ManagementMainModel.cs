using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Spartan_Record_Detail_ManagementMainModel
    {
        public Spartan_Record_Detail_ManagementModel Spartan_Record_Detail_ManagementInfo { set; get; }
        public Spartan_RDM_Filters_DetailGridModelPost Spartan_RDM_Filters_DetailGridInfo { set; get; }
        public Spartan_RDM_Operations_DetailGridModelPost Spartan_RDM_Operations_DetailGridInfo { set; get; }

    }

    public class Spartan_RDM_Filters_DetailGridModelPost
    {
        public int Filters_Detail_Id { get; set; }
        public int? Field_Name { get; set; }
        public string Field_Label { get; set; }
        public short? Order_Shown { get; set; }
        public string Field_Path { get; set; }
        public string Physical_Field_Name { get; set; }
        public string Logical_Field_Name { get; set; }

        public bool Removed { set; get; }
    }

    public class Spartan_RDM_Operations_DetailGridModelPost
    {
        public int DetailId { get; set; }
        public int? Object_Name { get; set; }
        public string Object_Label { get; set; }
        public short? Order_Shown { get; set; }
        public string Count_Query { get; set; }
        public string Query_Data { get; set; }
        public int? Icono { get; set; }
        public Grid_File IconoInfo { set; get; }

        public bool Removed { set; get; }
    }



}

