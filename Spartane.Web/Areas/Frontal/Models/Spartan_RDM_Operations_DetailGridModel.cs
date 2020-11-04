using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Spartan_RDM_Operations_DetailGridModel
    {
        public int DetailId { get; set; }
        public int? Object_Name { get; set; }
        public string Object_NameDescription { get; set; }
        public string Object_Label { get; set; }
        public short? Order_Shown { get; set; }
        public string Count_Query { get; set; }
        public string Query_Data { get; set; }
        public int? Icono { get; set; }
        public Grid_File IconoFileInfo { set; get; }
        
    }
}

