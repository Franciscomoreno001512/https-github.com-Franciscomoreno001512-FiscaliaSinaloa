using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Spartan_Object_ByPass;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Spartan_Attribute_Bypass
{
    /// <summary>
    /// Spartan_Attribute_Bypass table
    /// </summary>
    public class Spartan_Attribute_Bypass: BaseEntity
    {
        public int AttributeId { get; set; }
        public string Description { get; set; }
        public int? ObjectId { get; set; }

        [ForeignKey("ObjectId")]
        public virtual Spartane.Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPass ObjectId_Spartan_Object_ByPass { get; set; }

    }
	
	public class Spartan_Attribute_Bypass_Datos_Generales
    {
                public int AttributeId { get; set; }
        public string Description { get; set; }
        public int? ObjectId { get; set; }

		        [ForeignKey("ObjectId")]
        public virtual Spartane.Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPass ObjectId_Spartan_Object_ByPass { get; set; }

    }


}

