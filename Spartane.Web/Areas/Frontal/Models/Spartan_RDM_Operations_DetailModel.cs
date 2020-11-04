using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Spartan_RDM_Operations_DetailModel
    {
        [Required]
        public int DetailId { get; set; }
        public int? Object_Name { get; set; }
        public string Object_NameDescription { get; set; }
        public string Object_Label { get; set; }
        [Range(0, 9999999999)]
        public short? Order_Shown { get; set; }
        public string Count_Query { get; set; }
        public string Query_Data { get; set; }
        public int? Icono { get; set; }
        public HttpPostedFileBase IconoFile { set; get; }
        public int IconoRemoveAttachment { set; get; }

    }
	
	public class Spartan_RDM_Operations_Detail_Datos_GeneralesModel
    {
        [Required]
        public int DetailId { get; set; }
        public int? Object_Name { get; set; }
        public string Object_NameDescription { get; set; }
        public string Object_Label { get; set; }
        [Range(0, 9999999999)]
        public short? Order_Shown { get; set; }
        public string Count_Query { get; set; }
        public string Query_Data { get; set; }
        public int? Icono { get; set; }
        public HttpPostedFileBase IconoFile { set; get; }
        public int IconoRemoveAttachment { set; get; }

    }


}

