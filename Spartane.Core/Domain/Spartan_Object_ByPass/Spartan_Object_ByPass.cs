using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Spartan_Object_ByPass
{
    /// <summary>
    /// Spartan_Object_ByPass table
    /// </summary>
    public class Spartan_Object_ByPass: BaseEntity
    {
        public int ObjectId { get; set; }
        public string Description { get; set; }


    }
	
	public class Spartan_Object_ByPass_Datos_Generales
    {
                public int ObjectId { get; set; }
        public string Description { get; set; }

		
    }


}

