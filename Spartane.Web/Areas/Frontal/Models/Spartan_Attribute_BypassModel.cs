using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Spartan_Attribute_BypassModel
    {
        [Required]
        public int AttributeId { get; set; }
        public string Description { get; set; }
        public int? ObjectId { get; set; }
        public string ObjectIdDescription { get; set; }

    }
	
	public class Spartan_Attribute_Bypass_Datos_GeneralesModel
    {
        [Required]
        public int AttributeId { get; set; }
        public string Description { get; set; }
        public int? ObjectId { get; set; }
        public string ObjectIdDescription { get; set; }

    }


}

