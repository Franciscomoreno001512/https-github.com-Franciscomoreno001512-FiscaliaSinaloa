using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Spartan_Object_ByPassModel
    {
        [Required]
        public int ObjectId { get; set; }
        public string Description { get; set; }

    }
	
	public class Spartan_Object_ByPass_Datos_GeneralesModel
    {
        [Required]
        public int ObjectId { get; set; }
        public string Description { get; set; }

    }


}

